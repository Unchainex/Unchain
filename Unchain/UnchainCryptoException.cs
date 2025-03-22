using System.Runtime.Serialization;

namespace Unchain.Crypto;

[Serializable]
public class UnchainCryptoException : Exception
{
	public UnchainCryptoException(UnchainCryptoErrorCode errorCode, string? message = null, Exception? innerException = null)
		: base(message, innerException)
	{
		ErrorCode = errorCode;
	}

	protected UnchainCryptoException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public UnchainCryptoErrorCode ErrorCode { get; }
}
