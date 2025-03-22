using System.Linq;
using NBitcoin.Secp256k1;
using Unchain.Crypto;
using Unchain.Crypto.Randomness;
using Unchain.Crypto.ZeroKnowledge;
using Unchain.Crypto.ZeroKnowledge.LinearRelation;

namespace Unchain.Tests.Crypto;

internal class ProofSystemHelpers
{
	public static bool Verify(Statement statement, Proof proof)
	{
		return ProofSystem.Verify(new Transcript(Array.Empty<byte>()), new[] { statement }, new[] { proof });
	}

	public static Proof Prove(Knowledge knowledge, UnchainexRandom random)
	{
		return ProofSystem.Prove(new Transcript(Array.Empty<byte>()), new[] { knowledge }, random).First();
	}

	public static Proof Prove(Statement statement, Scalar witness, UnchainexRandom random)
	{
		return Prove(statement, new ScalarVector(witness), random);
	}

	public static Proof Prove(Statement statement, ScalarVector witness, UnchainexRandom random)
	{
		return Prove(new Knowledge(statement, witness), random);
	}
}
