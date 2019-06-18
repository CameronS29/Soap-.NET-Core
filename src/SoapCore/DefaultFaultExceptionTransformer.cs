using System;
using System.ServiceModel.Channels;

namespace SoapCore
{
	public class DefaultFaultExceptionTransformer : IFaultExceptionTransformer
	{
		private readonly ExceptionTransformer _exceptionTransformer;

		public DefaultFaultExceptionTransformer()
		{
			_exceptionTransformer = null;
		}

		public DefaultFaultExceptionTransformer(ExceptionTransformer exceptionTransformer)
		{
			_exceptionTransformer = exceptionTransformer;
		}

		public Message ProvideFault(Exception exception, MessageVersion messageVersion)
		{
			var bodyWriter = _exceptionTransformer == null ?
				new FaultBodyWriter(exception, messageVersion) :
				new FaultBodyWriter(exception, messageVersion, faultStringOverride: _exceptionTransformer.Transform(exception));

			var soapCoreFaultMessage = Message.CreateMessage(messageVersion, null, bodyWriter);

			return new CustomMessage(soapCoreFaultMessage);
		}
	}
}
