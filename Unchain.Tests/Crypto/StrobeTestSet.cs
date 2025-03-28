using Newtonsoft.Json;
using System.Collections.Generic;

namespace Unchain.Tests.Crypto;

public class StrobeTestSet
{
	[JsonConstructor]
	public StrobeTestSet(List<StrobeTestVector> testVectors)
	{
		TestVectors = testVectors;
	}

	[JsonProperty(PropertyName = "test_vectors")]
	public List<StrobeTestVector> TestVectors { get; }
}
