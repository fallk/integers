using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A114541
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,4L,6L,8L,9L,9L,10L,11L,11L,13L,14L,14L,16L,17L,18L,20L,21L,22L,23L,24L,24L,25L,26L,28L,30L,31L,33L,35L,35L,37L,39L,40L,43L,46L,46L,47L,48L,48L,49L,49L,50L,51L,52L,53L,54L,55L,55L,56L,56L,57L,58L,58L,59L,59L,60L,61L,61L,62L,63L,64L,64L,66L,67L,67L,68L,69L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114541Inst : IEnumerable<long>
{
public static readonly long[] Value=A114541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114541.Bytes);
public long this[int i]=>Value[i];

public static A114541Inst Instance=new A114541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114542
{
public static readonly BigInteger[] Value={ 0L,1L,1L,4691L,14080L,22014870L,110093079L,103403952290L,723144248019L,486101604111121L,4363129375507939L,2287092226229919002L,BigInteger.Parse("25031447861507056918"),BigInteger.Parse("10769715054951194077653"),BigInteger.Parse("138896030830402313512116") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114542Inst Instance=new A114542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114543
{
public static readonly BigInteger[] Value={ 0L,1L,1L,772L,2308L,597520L,2967568L,464830528L,3208753216L,363407352064L,3191137173760L,285479120733184L,3021751590913024L,225291467904913408L,2771288157631025152L,BigInteger.Parse("178566423666235555840"),BigInteger.Parse("2485482152393098412032") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114543Inst Instance=new A114543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114544
{
public static readonly long[] Value={ 2L,3L,3L,4L,5L,3L,4L,5L,4L,5L,6L,7L,5L,6L,7L,8L,9L,3L,4L,5L,4L,5L,6L,7L,5L,6L,7L,8L,9L,4L,5L,6L,7L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L,15L,16L,17L,3L,4L,5L,4L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114544Inst : IEnumerable<long>
{
public static readonly long[] Value=A114544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114544.Bytes);
public long this[int i]=>Value[i];

public static A114544Inst Instance=new A114544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114545
{
public static readonly long[] Value={ 3L,4L,5L,4L,5L,6L,7L,5L,6L,7L,8L,9L,4L,5L,6L,7L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L,15L,16L,17L,4L,5L,6L,7L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114545Inst : IEnumerable<long>
{
public static readonly long[] Value=A114545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114545.Bytes);
public long this[int i]=>Value[i];

public static A114545Inst Instance=new A114545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114546
{
public static readonly long[] Value={ 4L,5L,6L,7L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L,15L,16L,17L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114546Inst : IEnumerable<long>
{
public static readonly long[] Value=A114546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114546.Bytes);
public long this[int i]=>Value[i];

public static A114546Inst Instance=new A114546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114547
{
public static readonly long[] Value={ 5L,6L,7L,8L,9L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L,15L,16L,17L,6L,7L,8L,9L,10L,11L,7L,8L,9L,10L,11L,12L,13L,8L,9L,10L,11L,12L,13L,14L,15L,9L,10L,11L,12L,13L,14L,15L,16L,17L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114547Inst : IEnumerable<long>
{
public static readonly long[] Value=A114547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114547.Bytes);
public long this[int i]=>Value[i];

public static A114547Inst Instance=new A114547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114548
{
public static readonly long[] Value={ 3L,8L,11L,19L,20L,25L,28L,37L,38L,43L,52L,58L,59L,67L,68L,70L,77L,82L,83L,85L,86L,89L,92L,98L,106L,110L,116L,124L,130L,131L,133L,134L,137L,139L,142L,149L,157L,161L,169L,172L,179L,181L,182L,185L,188L,190L,193L,202L,206L,209L,211L,214L,217L,227L,233L,238L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114548Inst : IEnumerable<long>
{
public static readonly long[] Value=A114548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114548.Bytes);
public long this[int i]=>Value[i];

public static A114548Inst Instance=new A114548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114549
{
public static readonly long[] Value={ 2L,23L,29L,41L,47L,83L,89L,101L,103L,107L,109L,127L,149L,163L,167L,181L,211L,233L,239L,251L,257L,271L,277L,293L,307L,347L,349L,367L,383L,389L,419L,431L,433L,439L,457L,479L,491L,503L,509L,521L,523L,541L,547L,563L,569L,587L,613L,617L,619L,631L,653L,659L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114549Inst : IEnumerable<long>
{
public static readonly long[] Value=A114549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114549.Bytes);
public long this[int i]=>Value[i];

public static A114549Inst Instance=new A114549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114550
{
public static readonly long[] Value={ 2L,5L,8L,4L,4L,0L,1L,7L,2L,4L,0L,1L,9L,7L,7L,6L,7L,2L,4L,8L,1L,2L,0L,7L,6L,1L,4L,7L,1L,5L,3L,3L,3L,1L,3L,4L,2L,1L,1L,2L,3L,8L,2L,0L,9L,0L,4L,6L,7L,9L,6L,9L,0L,0L,0L,3L,1L,3L,4L,3L,8L,5L,8L,3L,9L,6L,7L,5L,4L,4L,8L,2L,9L,8L,9L,1L,8L,6L,7L,9L,6L,3L,6L,1L,4L,0L,8L,8L,7L,4L,6L,9L,7L,7L,8L,0L,1L,8L,6L,9L,6L,4L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114550Inst : IEnumerable<long>
{
public static readonly long[] Value=A114550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114550.Bytes);
public long this[int i]=>Value[i];

public static A114550Inst Instance=new A114550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114551
{
public static readonly BigInteger[] Value={ 2L,1L,1L,2L,2L,6L,12L,78L,936L,73086L,68408496L,4999703411742L,BigInteger.Parse("342022190843338960032"),BigInteger.Parse("1710009514450915230711940280907486"),BigInteger.Parse("584861200495456320274313200204390612579749188443599552") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114551Inst Instance=new A114551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114552
{
public static readonly BigInteger[] Value={ 1L,2L,6L,78L,73086L,4999703411742L,BigInteger.Parse("1710009514450915230711940280907486"),BigInteger.Parse("1000118217480414644596377710149364954622541926875237885435586055466747491") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114552Inst Instance=new A114552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114553
{
public static readonly long[] Value={ 0L,1L,1L,25L,73L,673L,3025L,20329L,107929L,653425L,3674017L,21516217L,123214825L,714258241L,4113149041L,23770767625L,137113121593L,791700344593L,4568824885825L,26373938451289L,152222238686089L,878652055801825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114553Inst : IEnumerable<long>
{
public static readonly long[] Value=A114553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114553.Bytes);
public long this[int i]=>Value[i];

public static A114553Inst Instance=new A114553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114554
{
public static readonly long[] Value={ 6L,9L,12L,18L,21L,31L,35L,40L,44L,47L,49L,50L,56L,57L,65L,66L,76L,91L,107L,121L,125L,127L,129L,136L,138L,145L,148L,152L,154L,155L,163L,164L,187L,196L,201L,205L,212L,220L,221L,223L,226L,230L,235L,236L,237L,239L,242L,246L,248L,260L,268L,284L,289L,292L,299L,309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114554Inst : IEnumerable<long>
{
public static readonly long[] Value=A114554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114554.Bytes);
public long this[int i]=>Value[i];

public static A114554Inst Instance=new A114554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114555
{
public static readonly long[] Value={ 4L,4L,4L,4L,8L,9L,16L,24L,36L,56L,90L,147L,234L,378L,612L,988L,1600L,2588L,4184L,6768L,10948L,17712L,28660L,46372L,75028L,121396L,196420L,317812L,514232L,832041L,1346272L,2178312L,3524580L,5702888L,9227466L,14930356L,24157818L,39088170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114555Inst : IEnumerable<long>
{
public static readonly long[] Value=A114555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114555.Bytes);
public long this[int i]=>Value[i];

public static A114555Inst Instance=new A114555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114556
{
public static readonly long[] Value={ 7L,16L,23L,30L,32L,36L,42L,45L,54L,69L,78L,79L,80L,84L,88L,90L,93L,95L,100L,102L,104L,112L,115L,117L,140L,143L,151L,153L,165L,170L,174L,176L,184L,186L,191L,200L,203L,210L,213L,228L,232L,234L,245L,250L,259L,271L,273L,282L,287L,296L,306L,308L,310L,311L,318L,319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114556Inst : IEnumerable<long>
{
public static readonly long[] Value=A114556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114556.Bytes);
public long this[int i]=>Value[i];

public static A114556Inst Instance=new A114556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114557
{
public static readonly long[] Value={ 2L,5L,4L,6L,8L,8L,12L,10L,20L,14L,24L,16L,32L,20L,36L,22L,44L,26L,56L,32L,60L,34L,72L,40L,80L,44L,84L,46L,92L,50L,104L,56L,116L,62L,120L,64L,132L,70L,140L,74L,144L,76L,156L,82L,164L,86L,176L,92L,192L,100L,200L,104L,204L,106L,212L,110L,216L,112L,224L,116L,252L,130L,260L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114557Inst : IEnumerable<long>
{
public static readonly long[] Value=A114557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114557.Bytes);
public long this[int i]=>Value[i];

public static A114557Inst Instance=new A114557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114558
{
public static readonly long[] Value={ 15L,24L,27L,33L,48L,51L,55L,64L,71L,75L,81L,99L,105L,108L,111L,119L,120L,123L,126L,132L,141L,147L,150L,156L,160L,162L,171L,175L,177L,189L,198L,199L,204L,208L,215L,219L,222L,224L,249L,252L,258L,261L,263L,264L,267L,270L,272L,280L,285L,291L,294L,300L,304L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114558Inst : IEnumerable<long>
{
public static readonly long[] Value=A114558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114558.Bytes);
public long this[int i]=>Value[i];

public static A114558Inst Instance=new A114558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114559
{
public static readonly long[] Value={ 60L,63L,72L,114L,144L,159L,167L,180L,183L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114559Inst : IEnumerable<long>
{
public static readonly long[] Value=A114559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114559.Bytes);
public long this[int i]=>Value[i];

public static A114559Inst Instance=new A114559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114560
{
public static readonly BigInteger[] Value={ 1L,2L,16L,BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639936") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114560Inst Instance=new A114560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114561
{
public static readonly BigInteger[] Value={ 0L,1L,4L,256L,BigInteger.Parse("13407807929942597099574024998205846127479365820592393377723561443721764030073546976801874298166903427690031858186486050853753882811946569946433649006084096") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114561Inst Instance=new A114561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114562
{
public static readonly long[] Value={ 1L,4L,3L,8L,5L,36L,7L,16L,9L,20L,11L,72L,13L,28L,15L,32L,17L,108L,19L,40L,21L,44L,23L,144L,25L,52L,27L,56L,29L,900L,31L,64L,33L,68L,35L,216L,37L,76L,39L,80L,41L,252L,43L,88L,45L,92L,47L,288L,49L,100L,51L,104L,53L,324L,55L,112L,57L,116L,59L,1800L,61L,124L,63L,128L,65L,396L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114562Inst : IEnumerable<long>
{
public static readonly long[] Value=A114562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114562.Bytes);
public long this[int i]=>Value[i];

public static A114562Inst Instance=new A114562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114563
{
public static readonly long[] Value={ 1L,1L,2L,9L,207L,1632L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114563Inst : IEnumerable<long>
{
public static readonly long[] Value=A114563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114563.Bytes);
public long this[int i]=>Value[i];

public static A114563Inst Instance=new A114563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114564
{
public static readonly long[] Value={ 7L,19L,31L,55L,67L,139L,175L,199L,211L,235L,247L,307L,319L,391L,415L,487L,499L,535L,571L,595L,631L,679L,715L,787L,811L,931L,1039L,1075L,1099L,1135L,1147L,1255L,1327L,1387L,1399L,1435L,1459L,1471L,1507L,1567L,1639L,1687L,1759L,1795L,1819L,1855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114564Inst : IEnumerable<long>
{
public static readonly long[] Value=A114564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114564.Bytes);
public long this[int i]=>Value[i];

public static A114564Inst Instance=new A114564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114565
{
public static readonly long[] Value={ 128L,150L,175L,250L,378L,432L,450L,672L,750L,875L,1024L,1197L,1537L,1593L,1675L,2112L,2176L,2596L,3179L,3192L,3478L,3792L,3977L,4050L,4199L,4232L,4895L,5412L,5612L,6171L,6794L,7738L,8294L,8533L,9072L,9196L,9796L,10614L,10731L,11371L,11398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114565Inst : IEnumerable<long>
{
public static readonly long[] Value=A114565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114565.Bytes);
public long this[int i]=>Value[i];

public static A114565Inst Instance=new A114565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114566
{
public static readonly long[] Value={ 4L,2L,4L,6L,3L,5L,4L,5L,2L,10L,5L,3L,3L,3L,4L,10L,5L,7L,2L,4L,5L,10L,4L,4L,2L,4L,5L,7L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114566Inst : IEnumerable<long>
{
public static readonly long[] Value=A114566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114566.Bytes);
public long this[int i]=>Value[i];

public static A114566Inst Instance=new A114566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114567
{
public static readonly long[] Value={ 1L,3L,1L,5L,1L,5L,1L,7L,1L,3L,1L,7L,1L,7L,1L,9L,1L,3L,1L,7L,1L,7L,1L,9L,1L,3L,1L,9L,1L,9L,1L,11L,1L,3L,1L,5L,1L,5L,1L,9L,1L,3L,1L,9L,1L,9L,1L,11L,1L,3L,1L,9L,1L,9L,1L,11L,1L,3L,1L,11L,1L,11L,1L,13L,1L,3L,1L,5L,1L,5L,1L,9L,1L,3L,1L,9L,1L,9L,1L,11L,1L,3L,1L,9L,1L,9L,1L,11L,1L,3L,1L,11L,1L,11L,1L,13L,1L,3L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114567Inst : IEnumerable<long>
{
public static readonly long[] Value=A114567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114567.Bytes);
public long this[int i]=>Value[i];

public static A114567Inst Instance=new A114567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114568
{
public static readonly BigInteger[] Value={ 0L,1L,1L,4694L,14074L,22043016L,110093076L,103601931224L,723540388824L,487340138218336L,4368084700020976L,2294361417644038304L,BigInteger.Parse("25075040078386453024"),BigInteger.Parse("10810705128907312553856"),BigInteger.Parse("139223348225447089786176"),BigInteger.Parse("50980653751026190057165184"),BigInteger.Parse("754918810679399231211479424") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114568Inst Instance=new A114568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114569
{
public static readonly long[] Value={ 8L,35L,143L,575L,2303L,9215L,36863L,147455L,589823L,2359295L,9437183L,37748735L,150994943L,603979775L,2415919103L,9663676415L,38654705663L,154618822655L,618475290623L,2473901162495L,9895604649983L,39582418599935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114569Inst : IEnumerable<long>
{
public static readonly long[] Value=A114569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114569.Bytes);
public long this[int i]=>Value[i];

public static A114569Inst Instance=new A114569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114570
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,49L,50L,51L,52L,53L,54L,55L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114570Inst : IEnumerable<long>
{
public static readonly long[] Value=A114570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114570.Bytes);
public long this[int i]=>Value[i];

public static A114570Inst Instance=new A114570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114571
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,9L,11L,12L,14L,16L,18L,19L,21L,23L,24L,26L,28L,30L,31L,33L,35L,36L,38L,40L,42L,43L,45L,47L,48L,50L,52L,54L,55L,57L,59L,61L,62L,64L,66L,68L,69L,71L,73L,75L,76L,78L,80L,82L,84L,85L,87L,89L,91L,92L,94L,96L,98L,99L,101L,103L,105L,106L,108L,110L,112L,114L,115L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114571Inst : IEnumerable<long>
{
public static readonly long[] Value=A114571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114571.Bytes);
public long this[int i]=>Value[i];

public static A114571Inst Instance=new A114571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114572
{
public static readonly long[] Value={ 2L,1L,2L,6L,27L,185L,2135L,55129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114572Inst : IEnumerable<long>
{
public static readonly long[] Value=A114572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114572.Bytes);
public long this[int i]=>Value[i];

public static A114572Inst Instance=new A114572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114573
{
public static readonly long[] Value={ 1L,2L,3855L,4096L,4112L,4352L,5120L,5140L,5440L,6144L,6168L,6528L,7680L,7710L,8160L,5570645L,8388608L,8388736L,8421376L,8912896L,8913032L,8947712L,10485760L,10485920L,10526720L,11141120L,11141290L,11184640L,12582912L,12583104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114573Inst : IEnumerable<long>
{
public static readonly long[] Value=A114573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114573.Bytes);
public long this[int i]=>Value[i];

public static A114573Inst Instance=new A114573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114574
{
public static readonly BigInteger[] Value={ 4L,18L,600L,35280L,439084800L,80951270400L,6046686277632000L,2311256907767808000L,BigInteger.Parse("594596384994354462720000"),BigInteger.Parse("256411097818451356681764864000000"),BigInteger.Parse("254907998279515607349492449280000000"),BigInteger.Parse("509258864375374766713691244518493388800000000"),BigInteger.Parse("1371553591139716091434972544191070818271232000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114574Inst Instance=new A114574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114575
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,4L,3L,2L,4L,2L,4L,4L,1L,5L,2L,3L,2L,4L,2L,3L,3L,3L,4L,3L,3L,2L,5L,5L,3L,7L,4L,3L,3L,4L,5L,2L,5L,4L,3L,6L,5L,3L,4L,4L,1L,4L,5L,5L,6L,4L,5L,6L,3L,4L,2L,4L,5L,7L,9L,3L,6L,7L,8L,5L,3L,5L,7L,5L,5L,7L,3L,5L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114575Inst : IEnumerable<long>
{
public static readonly long[] Value=A114575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114575.Bytes);
public long this[int i]=>Value[i];

public static A114575Inst Instance=new A114575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114576
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,6L,3L,11L,10L,23L,26L,2L,47L,70L,10L,102L,176L,45L,221L,449L,160L,5L,493L,1121L,539L,35L,1105L,2817L,1680L,196L,2516L,7031L,5082L,868L,14L,5763L,17604L,14856L,3486L,126L,13328L,43996L,42660L,12810L,840L,30995L,110147L,120338L,44640L,4410L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114576Inst : IEnumerable<long>
{
public static readonly long[] Value=A114576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114576.Bytes);
public long this[int i]=>Value[i];

public static A114576Inst Instance=new A114576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114577
{
public static readonly long[] Value={ 1L,4L,2L,9L,6L,3L,16L,12L,8L,5L,26L,21L,15L,10L,7L,39L,33L,25L,18L,14L,11L,56L,49L,38L,28L,24L,20L,13L,78L,69L,55L,42L,36L,32L,22L,17L,106L,94L,77L,60L,52L,48L,34L,27L,19L,141L,125L,105L,84L,74L,68L,50L,40L,30L,23L,184L,164L,140L,115L,100L,93L,70L,57L,45L,35L,29L,236L,212L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114577Inst : IEnumerable<long>
{
public static readonly long[] Value=A114577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114577.Bytes);
public long this[int i]=>Value[i];

public static A114577Inst Instance=new A114577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114578
{
public static readonly long[] Value={ 1L,4L,9L,2L,16L,6L,26L,12L,3L,21L,39L,8L,56L,33L,15L,5L,78L,25L,106L,49L,10L,69L,141L,38L,18L,7L,94L,28L,184L,125L,236L,55L,14L,77L,164L,42L,296L,24L,11L,105L,356L,36L,416L,212L,140L,270L,476L,60L,20L,84L,183L,52L,536L,330L,32L,13L,115L,390L,596L,48L,656L,450L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114578Inst : IEnumerable<long>
{
public static readonly long[] Value=A114578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114578.Bytes);
public long this[int i]=>Value[i];

public static A114578Inst Instance=new A114578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114579
{
public static readonly long[] Value={ 1L,4L,6L,2L,9L,3L,7L,12L,5L,11L,10L,8L,14L,13L,18L,16L,21L,15L,34L,29L,17L,55L,47L,26L,89L,24L,144L,76L,20L,233L,123L,42L,377L,19L,610L,199L,68L,987L,39L,1597L,322L,32L,2584L,521L,110L,4181L,23L,6765L,843L,178L,10946L,63L,17711L,1364L,22L,28657L,2207L,288L,46368L,102L,75025L,3571L,52L,121393L,5778L,466L,196418L,37L,317811L,9349L,754L,514229L,165L,832040L,15127L,28L,1346269L,24476L,1220L,2178309L,267L,3524578L,39603L,84L,5702887L,64079L,1974L,9227465L,25L,14930352L,103682L,3194L,24157817L,432L,39088169L,167761L,136L,63245986L,271443L,5168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114579Inst : IEnumerable<long>
{
public static readonly long[] Value=A114579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114579.Bytes);
public long this[int i]=>Value[i];

public static A114579Inst Instance=new A114579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114580
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,7L,1L,1L,14L,6L,1L,26L,23L,1L,1L,46L,70L,10L,1L,79L,186L,56L,1L,1L,133L,451L,235L,15L,1L,221L,1025L,825L,115L,1L,1L,364L,2220L,2562L,630L,21L,1L,596L,4634L,7274L,2794L,211L,1L,1L,972L,9396L,19286L,10696L,1456L,28L,1L,1581L,18612L,48450L,36715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114580Inst : IEnumerable<long>
{
public static readonly long[] Value=A114580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114580.Bytes);
public long this[int i]=>Value[i];

public static A114580Inst Instance=new A114580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114581
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,7L,2L,16L,5L,40L,10L,1L,100L,24L,3L,256L,58L,9L,663L,149L,22L,1L,1741L,386L,57L,4L,4620L,1017L,147L,14L,12376L,2702L,392L,40L,1L,33416L,7248L,1053L,113L,5L,90853L,19590L,2859L,312L,20L,248515L,53318L,7803L,870L,65L,1L,683429L,145984L,21420L,2428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114581Inst : IEnumerable<long>
{
public static readonly long[] Value=A114581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114581.Bytes);
public long this[int i]=>Value[i];

public static A114581Inst Instance=new A114581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114582
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,16L,40L,100L,256L,663L,1741L,4620L,12376L,33416L,90853L,248515L,683429L,1888449L,5240509L,14598709L,40810390L,114447429L,321885675L,907723460L,2566079622L,7270598910L,20643413513L,58727234739L,167373377361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114582Inst : IEnumerable<long>
{
public static readonly long[] Value=A114582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114582.Bytes);
public long this[int i]=>Value[i];

public static A114582Inst Instance=new A114582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114583
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,7L,2L,15L,6L,36L,14L,1L,85L,39L,3L,209L,102L,12L,517L,280L,37L,1L,1303L,758L,123L,4L,3312L,2085L,381L,20L,8510L,5730L,1194L,76L,1L,22029L,15849L,3657L,295L,5L,57447L,43914L,11187L,1056L,30L,150709L,122090L,33903L,3734L,135L,1L,397569L,340104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114583Inst : IEnumerable<long>
{
public static readonly long[] Value=A114583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114583.Bytes);
public long this[int i]=>Value[i];

public static A114583Inst Instance=new A114583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114584
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,15L,36L,85L,209L,517L,1303L,3312L,8510L,22029L,57447L,150709L,397569L,1053822L,2805518L,7498035L,20110254L,54110386L,146021880L,395114304L,1071772322L,2913900196L,7939004648L,21672609566L,59272260791L,162380575451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114584Inst : IEnumerable<long>
{
public static readonly long[] Value=A114584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114584.Bytes);
public long this[int i]=>Value[i];

public static A114584Inst Instance=new A114584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114585
{
public static readonly long[] Value={ 1L,2L,3L,8L,9L,10L,6L,128L,21L,12L,18L,136L,24L,250L,54L,36L,45L,230L,70L,30L,200L,72L,135L,32896L,384L,441L,144L,324L,105L,60L,490L,150L,90L,972L,1215L,3087L,576L,408L,168L,120L,3645L,1152L,3430L,750L,270L,378L,735L,300L,180L,35937L,9261L,1728L,882L,450L,8990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114585Inst : IEnumerable<long>
{
public static readonly long[] Value=A114585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114585.Bytes);
public long this[int i]=>Value[i];

public static A114585Inst Instance=new A114585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114586
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,6L,8L,3L,1L,15L,22L,15L,4L,1L,36L,68L,52L,24L,5L,1L,91L,198L,191L,100L,35L,6L,1L,232L,586L,651L,425L,170L,48L,7L,1L,603L,1718L,2203L,1656L,820L,266L,63L,8L,1L,1585L,5047L,7285L,6299L,3591L,1435L,392L,80L,9L,1L,4213L,14808L,23832L,23164L,15155L,6972L,2338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114586Inst : IEnumerable<long>
{
public static readonly long[] Value=A114586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114586.Bytes);
public long this[int i]=>Value[i];

public static A114586Inst Instance=new A114586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114587
{
public static readonly long[] Value={ 1L,4L,17L,68L,269L,1056L,4132L,16144L,63046L,246228L,962019L,3760700L,14710589L,57581696L,225546488L,884059808L,3467476430L,13608852968L,53443415522L,210000136136L,825630208466L,3247733377664L,12781815016232L,50328168273408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114587Inst : IEnumerable<long>
{
public static readonly long[] Value=A114587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114587.Bytes);
public long this[int i]=>Value[i];

public static A114587Inst Instance=new A114587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114588
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,3L,1L,1L,3L,6L,6L,2L,1L,7L,17L,18L,11L,3L,1L,17L,48L,58L,40L,18L,4L,1L,43L,134L,186L,150L,76L,27L,5L,1L,110L,380L,590L,540L,325L,130L,38L,6L,1L,286L,1083L,1860L,1915L,1305L,624L,206L,51L,7L,1L,753L,3100L,5844L,6660L,5115L,2772L,1097L,308L,66L,8L,1L,2003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114588Inst : IEnumerable<long>
{
public static readonly long[] Value=A114588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114588.Bytes);
public long this[int i]=>Value[i];

public static A114588Inst Instance=new A114588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114589
{
public static readonly long[] Value={ 1L,1L,3L,7L,17L,43L,110L,286L,753L,2003L,5376L,14540L,39589L,108427L,298512L,825664L,2293271L,6393539L,17885835L,50191175L,141247519L,398537101L,1127203038L,3195229662L,9076078057L,25830193513L,73643406563L,210312889095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114589Inst : IEnumerable<long>
{
public static readonly long[] Value=A114589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114589.Bytes);
public long this[int i]=>Value[i];

public static A114589Inst Instance=new A114589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114590
{
public static readonly long[] Value={ 1L,2L,8L,28L,103L,382L,1432L,5408L,20546L,78436L,300636L,1156188L,4459267L,17241526L,66807856L,259361920L,1008598126L,3928120924L,15319329472L,59817190552L,233826979750L,914962032172L,3583556424208L,14047386554368L,55108441878868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114590Inst : IEnumerable<long>
{
public static readonly long[] Value=A114590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114590.Bytes);
public long this[int i]=>Value[i];

public static A114590Inst Instance=new A114590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114591
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,0L,-1L,-1L,-1L,-1L,0L,-1L,0L,0L,-1L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,0L,-1L,-1L,-1L,0L,1L,-1L,-1L,-1L,-1L,0L,0L,-1L,0L,-1L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,-1L,0L,-1L,-1L,-1L,0L,2L,0L,-1L,-1L,-1L,-1L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114591Inst : IEnumerable<long>
{
public static readonly long[] Value=A114591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114591.Bytes);
public long this[int i]=>Value[i];

public static A114591Inst Instance=new A114591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114592
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-1L,0L,-1L,0L,-1L,0L,-1L,1L,-1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,1L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,1L,-1L,1L,1L,0L,-1L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,0L,0L,-1L,1L,-1L,0L,1L,0L,0L,1L,-1L,1L,0L,1L,-1L,1L,-1L,0L,1L,1L,0L,1L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,1L,-1L,1L,0L,1L,0L,0L,0L,0L,-1L,1L,1L,1L,-1L,1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114592Inst : IEnumerable<long>
{
public static readonly long[] Value=A114592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114592.Bytes);
public long this[int i]=>Value[i];

public static A114592Inst Instance=new A114592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114593
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,10L,16L,36L,5L,32L,112L,42L,64L,320L,224L,14L,128L,864L,960L,168L,256L,2240L,3600L,1200L,42L,512L,5632L,12320L,6600L,660L,1024L,13824L,39424L,30800L,5940L,132L,2048L,33280L,119808L,128128L,40040L,2574L,4096L,78848L,349440L,489216L,224224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114593Inst : IEnumerable<long>
{
public static readonly long[] Value=A114593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114593.Bytes);
public long this[int i]=>Value[i];

public static A114593Inst Instance=new A114593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114594
{
public static readonly long[] Value={ 5L,1L,9L,7L,2L,0L,4L,6L,5L,5L,5L,1L,7L,0L,5L,1L,0L,1L,6L,0L,7L,4L,5L,2L,6L,0L,0L,6L,7L,3L,3L,2L,8L,5L,3L,5L,9L,6L,8L,3L,9L,2L,2L,0L,1L,4L,0L,7L,3L,8L,2L,1L,4L,7L,7L,4L,0L,3L,2L,0L,3L,8L,9L,2L,4L,6L,9L,7L,9L,1L,6L,4L,4L,5L,3L,4L,5L,4L,9L,9L,5L,0L,4L,3L,1L,2L,9L,2L,2L,0L,8L,3L,9L,1L,3L,0L,3L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114594Inst : IEnumerable<long>
{
public static readonly long[] Value=A114594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114594.Bytes);
public long this[int i]=>Value[i];

public static A114594Inst Instance=new A114594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114595
{
public static readonly long[] Value={ 1L,4L,6L,4L,9L,24L,48L,60L,30L,16L,60L,192L,480L,840L,840L,336L,25L,120L,520L,1920L,5700L,12600L,18480L,15120L,5040L,36L,210L,1140L,5520L,22920L,78120L,206640L,393120L,483840L,332640L,95040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114595Inst : IEnumerable<long>
{
public static readonly long[] Value=A114595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114595.Bytes);
public long this[int i]=>Value[i];

public static A114595Inst Instance=new A114595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114596
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,5L,2L,2L,0L,14L,6L,4L,5L,0L,42L,18L,12L,10L,14L,0L,132L,57L,36L,30L,28L,42L,0L,429L,186L,114L,90L,84L,84L,132L,0L,1430L,622L,372L,285L,252L,252L,264L,429L,0L,4862L,2120L,1244L,930L,798L,756L,792L,858L,1430L,0L,16796L,7338L,4240L,3110L,2604L,2394L,2376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114596Inst : IEnumerable<long>
{
public static readonly long[] Value=A114596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114596.Bytes);
public long this[int i]=>Value[i];

public static A114596Inst Instance=new A114596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114597
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,5L,9L,3L,1L,7L,21L,23L,5L,1L,9L,38L,74L,56L,8L,1L,11L,60L,170L,237L,130L,13L,1L,13L,87L,325L,674L,706L,293L,21L,1L,15L,119L,553L,1535L,2442L,1994L,645L,34L,1L,17L,156L,868L,3030L,6542L,8259L,5401L,1395L,55L,1L,19L,198L,1284L,5411L,14840L,25738L,26441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114597Inst : IEnumerable<long>
{
public static readonly long[] Value=A114597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114597.Bytes);
public long this[int i]=>Value[i];

public static A114597Inst Instance=new A114597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114598
{
public static readonly long[] Value={ 5L,6L,3L,3L,5L,3L,3L,9L,3L,9L,0L,6L,0L,5L,5L,1L,4L,6L,8L,9L,0L,3L,6L,6L,6L,5L,3L,3L,6L,7L,4L,5L,4L,6L,4L,6L,5L,7L,9L,8L,9L,4L,4L,8L,7L,5L,7L,0L,1L,7L,6L,3L,2L,2L,0L,6L,5L,8L,9L,1L,9L,6L,7L,5L,6L,8L,3L,1L,5L,2L,6L,3L,6L,3L,1L,3L,6L,4L,7L,7L,7L,5L,7L,8L,1L,5L,7L,7L,1L,1L,2L,5L,8L,2L,8L,9L,0L,8L,6L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114598Inst : IEnumerable<long>
{
public static readonly long[] Value=A114598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114598.Bytes);
public long this[int i]=>Value[i];

public static A114598Inst Instance=new A114598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114599
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,7L,22L,78L,144L,40L,16L,11L,23L,254L,2922L,61850L,602420L,409448L,42038L,2669414L,38065410L,255320214L,315752716934L,22408767609924L,BigInteger.Parse("18684193273697426172"),BigInteger.Parse("85136306795697966858"),BigInteger.Parse("4400725717987783759574480") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114599Inst Instance=new A114599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114600
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,7L,11L,13L,3L,5L,2L,11L,23L,127L,487L,1237L,331L,127L,21019L,1811L,140983L,2239651L,10005473L,1867397300827L,45590891L,96526424938433069L,6424815538907849L,BigInteger.Parse("3320782322201303130883"),BigInteger.Parse("167483630406434494769") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114600Inst Instance=new A114600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114601
{
public static readonly long[] Value={ 1L,3L,23L,393L,13089L,737595L,58969079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114601Inst : IEnumerable<long>
{
public static readonly long[] Value=A114601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114601.Bytes);
public long this[int i]=>Value[i];

public static A114601Inst Instance=new A114601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114602
{
public static readonly long[] Value={ 4L,6L,5L,8L,2L,1L,1L,5L,9L,0L,1L,0L,5L,8L,1L,4L,3L,9L,6L,5L,7L,6L,1L,4L,0L,2L,2L,4L,9L,0L,9L,8L,0L,5L,9L,8L,7L,6L,1L,3L,9L,6L,7L,8L,1L,3L,8L,7L,5L,7L,8L,6L,0L,4L,9L,6L,8L,1L,6L,3L,3L,2L,5L,0L,4L,8L,7L,5L,3L,4L,8L,3L,4L,0L,2L,6L,9L,6L,7L,6L,9L,5L,2L,0L,4L,6L,0L,2L,7L,3L,8L,1L,5L,7L,4L,3L,1L,6L,5L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114602Inst : IEnumerable<long>
{
public static readonly long[] Value=A114602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114602.Bytes);
public long this[int i]=>Value[i];

public static A114602Inst Instance=new A114602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114603
{
public static readonly long[] Value={ 0L,1L,5L,7L,6L,5L,8L,6L,3L,7L,3L,0L,3L,0L,4L,4L,2L,1L,6L,6L,7L,5L,6L,4L,9L,9L,4L,6L,5L,1L,1L,1L,7L,1L,8L,5L,3L,4L,3L,9L,7L,4L,1L,3L,8L,3L,7L,7L,2L,2L,4L,6L,0L,9L,4L,3L,3L,6L,0L,3L,6L,0L,0L,6L,9L,6L,8L,8L,4L,9L,8L,3L,5L,1L,0L,6L,2L,8L,6L,2L,2L,5L,8L,2L,0L,9L,9L,6L,5L,1L,0L,9L,5L,4L,4L,0L,0L,8L,8L,7L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114603Inst : IEnumerable<long>
{
public static readonly long[] Value=A114603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114603.Bytes);
public long this[int i]=>Value[i];

public static A114603Inst Instance=new A114603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114604
{
public static readonly BigInteger[] Value={ 1L,5L,43L,709L,23003L,1481957L,190305691L,48796386661L,25003673060507L,25613941912987493L,BigInteger.Parse("52467767892904362139"),BigInteger.Parse("214929296497738201165669"),BigInteger.Parse("1760788099067877263041671323"),BigInteger.Parse("28849467307107603960961499533157") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114604Inst Instance=new A114604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114605
{
public static readonly long[] Value={ 8L,15L,16L,24L,56L,134217784L,134217785L,134479929L,134479961L,134480473L,134481497L,134872122L,522292611L,522292611L,522554755L,522554880L,522554884L,522554911L,522945536L,522945617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114605Inst : IEnumerable<long>
{
public static readonly long[] Value=A114605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114605.Bytes);
public long this[int i]=>Value[i];

public static A114605Inst Instance=new A114605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114606
{
public static readonly long[] Value={ 2L,15L,17L,19L,21L,25L,29L,31L,33L,35L,41L,51L,55L,65L,73L,77L,79L,83L,89L,91L,93L,95L,97L,101L,107L,111L,123L,131L,133L,139L,141L,145L,149L,151L,155L,157L,173L,179L,183L,197L,201L,203L,205L,215L,221L,223L,227L,229L,233L,237L,241L,247L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114606Inst : IEnumerable<long>
{
public static readonly long[] Value=A114606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114606.Bytes);
public long this[int i]=>Value[i];

public static A114606Inst Instance=new A114606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114607
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114607Inst : IEnumerable<long>
{
public static readonly long[] Value=A114607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114607.Bytes);
public long this[int i]=>Value[i];

public static A114607Inst Instance=new A114607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114608
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,11L,19L,9L,1L,45L,96L,66L,16L,1L,197L,501L,450L,170L,25L,1L,903L,2668L,2955L,1520L,365L,36L,1L,4279L,14407L,18963L,12355L,4165L,693L,49L,1L,20793L,78592L,119812L,94528L,41230L,9856L,1204L,64L,1L,103049L,432073L,748548L,693588L,372078L,117054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114608Inst : IEnumerable<long>
{
public static readonly long[] Value=A114608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114608.Bytes);
public long this[int i]=>Value[i];

public static A114608Inst Instance=new A114608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114609
{
public static readonly long[] Value={ 3L,1L,4L,1L,5L,9L,2L,6L,5L,3L,5L,9L,5L,1L,8L,2L,3L,8L,3L,2L,8L,8L,4L,2L,3L,9L,5L,1L,3L,3L,7L,1L,9L,5L,7L,4L,6L,4L,7L,4L,3L,0L,2L,5L,6L,3L,7L,8L,1L,8L,2L,2L,2L,9L,2L,9L,0L,4L,4L,4L,3L,1L,7L,2L,5L,0L,9L,1L,3L,0L,3L,0L,4L,8L,2L,7L,0L,4L,2L,4L,1L,7L,6L,1L,0L,1L,2L,3L,7L,5L,1L,5L,3L,5L,6L,7L,5L,8L,5L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114609Inst : IEnumerable<long>
{
public static readonly long[] Value=A114609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114609.Bytes);
public long this[int i]=>Value[i];

public static A114609Inst Instance=new A114609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114610
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,8L,8L,5L,1L,0L,9L,0L,4L,1L,3L,8L,2L,5L,1L,5L,6L,2L,4L,3L,0L,7L,8L,8L,6L,9L,9L,9L,1L,1L,6L,7L,9L,6L,0L,8L,2L,6L,3L,8L,2L,8L,0L,4L,0L,1L,4L,7L,1L,1L,1L,6L,2L,8L,2L,6L,6L,2L,6L,0L,6L,3L,0L,5L,1L,1L,9L,7L,2L,0L,8L,1L,6L,6L,8L,5L,5L,1L,0L,0L,7L,2L,6L,9L,1L,3L,8L,0L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114610Inst : IEnumerable<long>
{
public static readonly long[] Value=A114610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114610.Bytes);
public long this[int i]=>Value[i];

public static A114610Inst Instance=new A114610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114611
{
public static readonly long[] Value={ 0L,0L,8L,0L,0L,8L,0L,0L,2L,0L,0L,8L,0L,0L,8L,0L,0L,2L,0L,0L,8L,0L,0L,8L,0L,0L,2L,0L,18L,8L,0L,0L,8L,0L,0L,2L,0L,18L,8L,0L,0L,8L,0L,0L,2L,0L,18L,8L,18L,0L,8L,0L,0L,2L,0L,18L,8L,18L,0L,8L,0L,0L,2L,0L,18L,8L,18L,0L,2L,0L,0L,2L,0L,18L,8L,18L,0L,2L,0L,0L,2L,0L,18L,8L,18L,0L,2L,0L,0L,2L,0L,18L,8L,18L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114611Inst : IEnumerable<long>
{
public static readonly long[] Value=A114611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114611.Bytes);
public long this[int i]=>Value[i];

public static A114611Inst Instance=new A114611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114612
{
public static readonly long[] Value={ 9L,18L,27L,36L,45L,54L,63L,69L,72L,78L,81L,87L,90L,96L,99L,108L,114L,117L,120L,126L,135L,144L,153L,156L,162L,171L,180L,189L,198L,207L,213L,216L,225L,234L,243L,252L,255L,261L,270L,279L,288L,297L,306L,312L,315L,324L,333L,342L,351L,354L,360L,369L,378L,387L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114612Inst : IEnumerable<long>
{
public static readonly long[] Value=A114612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114612.Bytes);
public long this[int i]=>Value[i];

public static A114612Inst Instance=new A114612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114613
{
public static readonly long[] Value={ 20169L,20709L,21159L,22149L,23139L,24129L,25119L,26109L,27099L,28089L,29079L,30159L,30168L,30708L,30789L,31149L,31158L,31779L,32139L,32148L,32769L,33129L,33138L,33759L,34119L,34128L,34749L,35109L,35118L,35739L,36108L,36729L,37098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114613Inst : IEnumerable<long>
{
public static readonly long[] Value=A114613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114613.Bytes);
public long this[int i]=>Value[i];

public static A114613Inst Instance=new A114613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114614
{
public static readonly long[] Value={ 3L,6L,12L,15L,21L,24L,30L,33L,39L,42L,48L,51L,57L,60L,66L,75L,84L,93L,102L,105L,111L,123L,129L,132L,138L,141L,147L,150L,159L,165L,168L,174L,177L,183L,186L,192L,195L,201L,204L,210L,219L,222L,228L,231L,237L,240L,246L,249L,258L,264L,267L,273L,276L,282L,285L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114614Inst : IEnumerable<long>
{
public static readonly long[] Value=A114614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114614.Bytes);
public long this[int i]=>Value[i];

public static A114614Inst Instance=new A114614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114615
{
public static readonly long[] Value={ 6999L,7089L,7179L,7269L,7359L,7449L,7539L,7629L,7719L,7809L,7998L,8088L,8178L,8268L,8358L,8448L,8538L,8628L,8718L,8808L,8997L,9087L,9177L,9267L,9357L,9447L,9537L,9627L,9699L,9717L,9789L,9807L,9879L,9969L,9996L,10128L,10167L,10185L,10191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114615Inst : IEnumerable<long>
{
public static readonly long[] Value=A114615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114615.Bytes);
public long this[int i]=>Value[i];

public static A114615Inst Instance=new A114615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114616
{
public static readonly long[] Value={ 29L,38L,47L,49L,56L,58L,65L,67L,74L,76L,83L,85L,92L,94L,110L,112L,118L,134L,137L,140L,142L,154L,155L,181L,187L,196L,209L,211L,217L,229L,233L,236L,239L,241L,253L,254L,259L,280L,286L,295L,299L,308L,310L,316L,319L,328L,329L,332L,335L,338L,340L,352L,353L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114616Inst : IEnumerable<long>
{
public static readonly long[] Value=A114616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114616.Bytes);
public long this[int i]=>Value[i];

public static A114616Inst Instance=new A114616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114617
{
public static readonly long[] Value={ 1L,8L,1520L,50624L,62000L,103040L,199808L,221840L,269360L,463760L,690560L,848240L,986048L,1252160L,1418480L,2169728L,2692880L,2792240L,3448448L,3721040L,3932288L,5574320L,5716880L,6066368L,6890624L,6922160L,8485568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114617Inst : IEnumerable<long>
{
public static readonly long[] Value=A114617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114617.Bytes);
public long this[int i]=>Value[i];

public static A114617Inst Instance=new A114617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114618
{
public static readonly long[] Value={ 4L,9L,27L,39L,49L,57L,59L,69L,75L,85L,87L,105L,109L,117L,119L,121L,125L,143L,147L,153L,161L,169L,175L,177L,185L,187L,199L,207L,217L,219L,231L,235L,239L,245L,249L,265L,267L,269L,275L,283L,285L,289L,291L,299L,301L,305L,311L,319L,321L,327L,329L,333L,335L,345L,349L,357L,359L,361L,363L,371L,381L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114618Inst : IEnumerable<long>
{
public static readonly long[] Value=A114618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114618.Bytes);
public long this[int i]=>Value[i];

public static A114618Inst Instance=new A114618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114619
{
public static readonly long[] Value={ 0L,2L,8L,50L,288L,1682L,9800L,57122L,332928L,1940450L,11309768L,65918162L,384199200L,2239277042L,13051463048L,76069501250L,443365544448L,2584123765442L,15061377048200L,87784138523762L,511643454094368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114619Inst : IEnumerable<long>
{
public static readonly long[] Value=A114619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114619.Bytes);
public long this[int i]=>Value[i];

public static A114619Inst Instance=new A114619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114620
{
public static readonly long[] Value={ 0L,2L,10L,60L,348L,2030L,11830L,68952L,401880L,2342330L,13652098L,79570260L,463769460L,2703046502L,15754509550L,91824010800L,535189555248L,3119313320690L,18180690368890L,105964828892652L,617608282987020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114620Inst : IEnumerable<long>
{
public static readonly long[] Value=A114620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114620.Bytes);
public long this[int i]=>Value[i];

public static A114620Inst Instance=new A114620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114621
{
public static readonly long[] Value={ 8L,10L,12L,20L,26L,28L,45L,58L,63L,68L,76L,81L,82L,92L,99L,106L,115L,116L,129L,146L,159L,165L,171L,172L,188L,195L,202L,212L,213L,218L,225L,236L,255L,259L,261L,268L,273L,279L,298L,309L,325L,339L,343L,351L,362L,375L,387L,395L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114621Inst : IEnumerable<long>
{
public static readonly long[] Value=A114621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114621.Bytes);
public long this[int i]=>Value[i];

public static A114621Inst Instance=new A114621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114622
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,7L,10L,9L,12L,16L,14L,11L,13L,15L,20L,18L,24L,17L,32L,19L,21L,28L,22L,23L,26L,25L,30L,40L,27L,36L,48L,33L,34L,64L,38L,35L,42L,29L,31L,56L,44L,46L,39L,52L,50L,45L,60L,41L,43L,80L,54L,37L,72L,49L,51L,96L,66L,68L,65L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114622Inst : IEnumerable<long>
{
public static readonly long[] Value=A114622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114622.Bytes);
public long this[int i]=>Value[i];

public static A114622Inst Instance=new A114622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114623
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,15L,26L,43L,78L,134L,238L,415L,731L,1299L,2299L,4126L,7374L,13257L,23847L,42864L,77366L,140071L,254241L,461967L,839829L,1528072L,2782636L,5076421L,9274937L,16973162L,31101087L,57016626L,104600473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114623Inst : IEnumerable<long>
{
public static readonly long[] Value=A114623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114623.Bytes);
public long this[int i]=>Value[i];

public static A114623Inst Instance=new A114623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114624
{
public static readonly long[] Value={ 1L,2L,7L,19L,54L,164L,476L,1417L,4087L,12589L,37818L,116828L,358277L,1106870L,3460676L,10813998L,34339769L,109194390L,350181146L,1126919513L,3634208553L,11774823887L,38335906599L,125461951555L,411934520324L,1356668825821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114624Inst : IEnumerable<long>
{
public static readonly long[] Value=A114624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114624.Bytes);
public long this[int i]=>Value[i];

public static A114624Inst Instance=new A114624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114625
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,14L,19L,38L,57L,71L,142L,284L,568L,571L,1142L,2284L,4568L,9136L,18272L,36544L,36545L,73089L,146178L,292356L,292361L,584722L,1169444L,2338888L,4677776L,9355552L,18711104L,37422208L,37422779L,74845558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114625Inst : IEnumerable<long>
{
public static readonly long[] Value=A114625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114625.Bytes);
public long this[int i]=>Value[i];

public static A114625Inst Instance=new A114625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114626
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,2L,2L,1L,1L,6L,6L,3L,2L,1L,19L,17L,12L,5L,3L,1L,61L,56L,36L,20L,8L,4L,1L,202L,185L,120L,66L,31L,12L,5L,1L,683L,624L,409L,224L,110L,46L,17L,6L,1L,2348L,2144L,1408L,784L,385L,172L,66L,23L,7L,1L,8184L,7468L,4920L,2760L,1380L,624L,257L,92L,30L,8L,1L,28855L,26317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114626Inst : IEnumerable<long>
{
public static readonly long[] Value=A114626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114626.Bytes);
public long this[int i]=>Value[i];

public static A114626Inst Instance=new A114626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114627
{
public static readonly long[] Value={ 1L,2L,6L,19L,61L,202L,683L,2348L,8184L,28855L,102731L,368813L,1333684L,4853436L,17761181L,65320691L,241300829L,894958140L,3331323651L,12441078958L,46601721324L,175040968111L,659136721385L,2487852579751L,9410480922018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114627Inst : IEnumerable<long>
{
public static readonly long[] Value=A114627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114627.Bytes);
public long this[int i]=>Value[i];

public static A114627Inst Instance=new A114627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114628
{
public static readonly BigInteger[] Value={ 1L,2L,6L,576L,80640L,505958400L,30739709952000L,BigInteger.Parse("55019078005712486400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114628Inst Instance=new A114628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114629
{
public static readonly BigInteger[] Value={ 0L,0L,6L,0L,80640L,306892800L,30739709952000L,BigInteger.Parse("53756954453370470400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114629Inst Instance=new A114629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114630
{
public static readonly long[] Value={ 1L,2L,0L,576L,0L,199065600L,0L,1262123552342016000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114630Inst : IEnumerable<long>
{
public static readonly long[] Value=A114630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114630.Bytes);
public long this[int i]=>Value[i];

public static A114630Inst Instance=new A114630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114631
{
public static readonly long[] Value={ 1L,1L,0L,24L,384L,702720L,6231859200L,1364560466411520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114631Inst : IEnumerable<long>
{
public static readonly long[] Value=A114631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114631.Bytes);
public long this[int i]=>Value[i];

public static A114631Inst Instance=new A114631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114632
{
public static readonly long[] Value={ 0L,0L,2L,0L,960L,426240L,5966438400L,1333257798942720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114632Inst : IEnumerable<long>
{
public static readonly long[] Value=A114632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114632.Bytes);
public long this[int i]=>Value[i];

public static A114632Inst Instance=new A114632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114633
{
public static readonly BigInteger[] Value={ 1L,3L,18L,70L,555L,2961L,31108L,213228L,2799765L,23455135L,369569046L,3659001138L,67261566463L,768390239085L,16142775951240L,209002145031256L,4939689441079593L,71478733600689723L,1877081987610245530L,BigInteger.Parse("30021068112289683870"),BigInteger.Parse("867211878275933435091"),BigInteger.Parse("15190660464818580038473") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114633Inst Instance=new A114633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114634
{
public static readonly long[] Value={ 6L,14L,16L,18L,34L,36L,40L,42L,44L,46L,50L,52L,56L,60L,62L,74L,88L,98L,100L,122L,124L,130L,132L,135L,138L,142L,148L,152L,156L,158L,170L,178L,186L,189L,194L,196L,209L,226L,232L,242L,243L,244L,258L,260L,266L,274L,282L,292L,296L,297L,302L,308L,314L,315L,316L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114634Inst : IEnumerable<long>
{
public static readonly long[] Value=A114634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114634.Bytes);
public long this[int i]=>Value[i];

public static A114634Inst Instance=new A114634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114635
{
public static readonly long[] Value={ 24L,30L,32L,38L,48L,66L,72L,78L,90L,94L,104L,110L,112L,114L,120L,136L,140L,154L,164L,166L,168L,176L,180L,190L,204L,206L,208L,210L,220L,222L,228L,238L,248L,254L,276L,280L,284L,286L,290L,300L,306L,312L,326L,338L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114635Inst : IEnumerable<long>
{
public static readonly long[] Value=A114635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114635.Bytes);
public long this[int i]=>Value[i];

public static A114635Inst Instance=new A114635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114636
{
public static readonly long[] Value={ 22L,70L,80L,84L,102L,108L,118L,126L,134L,160L,174L,184L,200L,230L,240L,250L,252L,262L,264L,272L,318L,330L,334L,336L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114636Inst : IEnumerable<long>
{
public static readonly long[] Value=A114636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114636.Bytes);
public long this[int i]=>Value[i];

public static A114636Inst Instance=new A114636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114637
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114637Inst : IEnumerable<long>
{
public static readonly long[] Value=A114637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114637.Bytes);
public long this[int i]=>Value[i];

public static A114637Inst Instance=new A114637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114638
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,1L,1L,0L,2L,2L,3L,5L,5L,6L,9L,7L,8L,14L,12L,16L,21L,28L,32L,43L,47L,61L,68L,84L,89L,109L,126L,140L,170L,198L,227L,261L,323L,362L,427L,501L,581L,658L,794L,880L,1036L,1175L,1355L,1526L,1776L,1985L,2281L,2588L,2943L,3312L,3799L,4271L,4852L,5497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114638Inst : IEnumerable<long>
{
public static readonly long[] Value=A114638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114638.Bytes);
public long this[int i]=>Value[i];

public static A114638Inst Instance=new A114638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114639
{
public static readonly long[] Value={ 1L,0L,2L,2L,2L,3L,5L,4L,7L,7L,13L,16L,19L,23L,33L,34L,44L,58L,63L,80L,101L,112L,139L,171L,196L,234L,288L,328L,394L,478L,545L,658L,777L,881L,1050L,1236L,1414L,1666L,1936L,2216L,2592L,3018L,3428L,3992L,4604L,5243L,6069L,6986L,7951L,9139L,10447L,11892L,13625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114639Inst : IEnumerable<long>
{
public static readonly long[] Value=A114639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114639.Bytes);
public long this[int i]=>Value[i];

public static A114639Inst Instance=new A114639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114640
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,1L,1L,0L,1L,1L,3L,2L,3L,3L,5L,0L,4L,5L,2L,3L,8L,6L,5L,10L,9L,9L,16L,14L,12L,16L,17L,10L,17L,15L,16L,19L,35L,17L,34L,37L,40L,31L,54L,36L,60L,61L,58L,63L,88L,58L,88L,87L,91L,84L,115L,93L,116L,108L,115L,130L,190L,143L,165L,214L,219L,200L,255L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114640Inst : IEnumerable<long>
{
public static readonly long[] Value=A114640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114640.Bytes);
public long this[int i]=>Value[i];

public static A114640Inst Instance=new A114640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}