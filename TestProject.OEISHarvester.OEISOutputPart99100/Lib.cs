using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A118741
{
public static readonly long[] Value={ 67L,83L,167L,193L,251L,277L,433L,487L,503L,587L,601L,613L,727L,823L,907L,1063L,1217L,1231L,1553L,1663L,1777L,1861L,1873L,1973L,1987L,2083L,2281L,2293L,2351L,2377L,2393L,2797L,2897L,3217L,3343L,3541L,3847L,4073L,4283L,4451L,4507L,4591L,4813L,4871L,5081L };
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
public class A118741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118741Inst : IEnumerable<long>
{
public static readonly long[] Value=A118741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118741.Bytes);
public long this[int i]=>Value[i];

public static A118741Inst Instance=new A118741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118742
{
public static readonly long[] Value={ 0L,5L,7L,8L,9L,11L,13L,14L,15L,17L,19L,20L,21L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,37L,38L,39L,41L,43L,44L,45L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,59L,61L,62L,63L,64L,65L,67L,68L,69L,71L,73L,74L,75L,76L,77L,79L,80L,81L,83L,84L,85L,86L,87L,89L,90L,91L,92L,93L,94L,95L,97L };
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
public class A118742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118742Inst : IEnumerable<long>
{
public static readonly long[] Value=A118742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118742.Bytes);
public long this[int i]=>Value[i];

public static A118742Inst Instance=new A118742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118743
{
public static readonly BigInteger[] Value={ 3L,5L,7L,13L,113L,3851L,46093L,10321937L,185794579L,BigInteger.Parse("216862434431944426122117120047"),BigInteger.Parse("1874480713189654839282450157086195210900931486780353469173376681742503659434414632312033372643386765197475111737132341321962070865661132800000000000000000173") };
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
public class A118743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118743Inst Instance=new A118743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118744
{
public static readonly BigInteger[] Value={ 3L,5L,11L,19L,53L,953L,46091L,34459441L,3715891219L,6332659870762850657L,BigInteger.Parse("107145471557284795514880041") };
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
public class A118744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118744Inst Instance=new A118744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118745
{
public static readonly long[] Value={ -1L,2L,-1L,4L,-1L,-1L,6L,0L,-1L,-1L,8L,1L,0L,-1L,-1L,10L,2L,1L,0L,-1L,-1L,12L,3L,2L,1L,0L,-1L,-1L,14L,4L,3L,2L,1L,0L,-1L,-1L,16L,5L,4L,3L,2L,1L,0L,-1L,-1L,18L,6L,5L,4L,3L,2L,1L,0L,-1L,-1L,20L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-1L,22L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-1L,24L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,-1L,-1L,26L,10L,9L,8L,7L,6L,5L,4L };
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
public class A118745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118745Inst : IEnumerable<long>
{
public static readonly long[] Value=A118745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118745.Bytes);
public long this[int i]=>Value[i];

public static A118745Inst Instance=new A118745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118746
{
public static readonly long[] Value={ 3L,7L,0L,1L,6L,4L,0L,7L,6L,4L,1L,6L,0L,3L,4L,9L,5L,8L,1L,8L,2L,4L,6L,4L,3L,7L,8L,9L,8L,4L,0L,8L,8L,9L,2L,2L,0L,1L,4L,4L,2L,9L,1L,5L,8L,9L,5L,1L,5L,2L,0L,6L,4L,4L,3L,1L,2L,3L,4L,5L,6L,2L,5L,7L,3L,0L,7L,9L,1L,9L,3L,7L,3L,5L,5L,2L,9L,5L,9L,7L,7L,8L,2L,4L,0L,5L,1L,6L,2L,8L,0L,2L,4L,2L,0L,0L,8L,7L,0L,1L,8L,1L,3L,6L,9L };
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
public class A118746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118746Inst : IEnumerable<long>
{
public static readonly long[] Value=A118746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118746.Bytes);
public long this[int i]=>Value[i];

public static A118746Inst Instance=new A118746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118747
{
public static readonly BigInteger[] Value={ 2L,6L,30L,210L,1470L,16170L,210210L,2732730L,46456410L,882671790L,16770764010L,385727572230L,8871734161290L,204049885709670L,5917446685580430L,183440847252993330L,5686666264842793230L,BigInteger.Parse("176286654210126590130") };
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
public class A118747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118747Inst Instance=new A118747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118748
{
public static readonly BigInteger[] Value={ 2L,10L,70L,770L,8470L,110110L,1871870L,31821790L,604614010L,13906122230L,319840811290L,9275383527410L,268986122294890L,7800597546551810L,241818523943106110L,8947285385894926070L,BigInteger.Parse("331049559278112264590") };
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
public class A118748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118748Inst Instance=new A118748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118749
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,23L,29L,31L,31L,37L,41L,43L,47L,47L,53L,53L,59L,61L,61L,67L,71L,73L,73L,79L,83L,83L,89L,89L,89L,97L,101L,103L,107L,109L,113L,113L,113L,113L,113L,127L,131L,131L,137L,139L,139L,139L,149L,151L,151L,157L,157L,163L,167L,167L,173L,173L,179L,181L };
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
public class A118749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118749Inst : IEnumerable<long>
{
public static readonly long[] Value=A118749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118749.Bytes);
public long this[int i]=>Value[i];

public static A118749Inst Instance=new A118749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118750
{
public static readonly BigInteger[] Value={ 3L,15L,105L,1155L,15015L,255255L,4849845L,111546435L,2565568005L,74401472145L,2306445636495L,71499814731345L,2645493145059765L,108465218947450365L,4664004414740365695L,BigInteger.Parse("219208207492797187665"),BigInteger.Parse("10302785752161467820255") };
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
public class A118750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118750Inst Instance=new A118750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118751
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,17L,19L,23L,29L,29L,31L,37L,37L,41L,43L,47L,53L,53L,59L,59L,61L,67L,67L,71L,73L,79L,79L,83L,89L,89L,97L,97L,97L,101L,103L,107L,109L,113L,127L,127L,127L,127L,127L,131L,137L,137L,139L,149L,149L,149L,151L,157L,157L,163L,163L,167L,173L,173L,179L,179L,181L };
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
public class A118751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118751Inst : IEnumerable<long>
{
public static readonly long[] Value=A118751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118751.Bytes);
public long this[int i]=>Value[i];

public static A118751Inst Instance=new A118751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118752
{
public static readonly BigInteger[] Value={ 2L,10L,70L,770L,10010L,170170L,3233230L,74364290L,2156564410L,62540367890L,1938751404590L,71733801969830L,2654150672883710L,108820177588232110L,4679267636293980730L,BigInteger.Parse("219925578905817094310"),BigInteger.Parse("11656055682008305998430") };
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
public class A118752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118752Inst Instance=new A118752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118753
{
public static readonly long[] Value={ 2L,5L,11L,13L,17L,23L,29L,29L,37L,37L,41L,47L,53L,53L,59L,61L,67L,71L,73L,79L,83L,89L,89L,97L,97L,101L,107L,109L,113L,127L,127L,127L,131L,137L,137L,149L,149L,149L,157L,157L,163L,167L,173L,173L,179L,181L,191L,191L,193L,197L,211L,211L,211L,223L,223L,223L,227L,229L,233L };
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
public class A118753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118753Inst : IEnumerable<long>
{
public static readonly long[] Value=A118753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118753.Bytes);
public long this[int i]=>Value[i];

public static A118753Inst Instance=new A118753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118754
{
public static readonly long[] Value={ 2L,5L,11L,17L,23L,29L,31L,37L,41L,47L,53L,59L,61L,67L,71L,79L,83L,89L,97L,97L,101L,107L,113L,127L,127L,127L,131L,137L,149L,149L,151L,157L,163L,167L,173L,179L,181L,191L,191L,197L,211L,211L,211L,223L,223L,227L,233L,239L,241L,251L,251L,257L,263L,269L,271L,277L,281L };
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
public class A118754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118754Inst : IEnumerable<long>
{
public static readonly long[] Value=A118754.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118754.Bytes);
public long this[int i]=>Value[i];

public static A118754Inst Instance=new A118754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118755
{
public static readonly long[] Value={ 2L,7L,13L,19L,29L,31L,37L,43L,53L,59L,61L,67L,73L,79L,89L,97L,97L,103L,109L,127L,127L,127L,137L,139L,149L,151L,157L,163L,173L,179L,181L,191L,193L,199L,211L,211L,223L,223L,229L,239L,241L,251L,257L,263L,269L,271L,277L,283L,293L,307L,307L };
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
public class A118755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118755Inst : IEnumerable<long>
{
public static readonly long[] Value=A118755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118755.Bytes);
public long this[int i]=>Value[i];

public static A118755Inst Instance=new A118755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118756
{
public static readonly long[] Value={ 2L,23L,211L,379L,773L,3389L,23251L,3761L,178069L,77773L,379811L,378997L,747521L,2337691L,3789293L,3574657L };
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
public class A118756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118756Inst : IEnumerable<long>
{
public static readonly long[] Value=A118756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118756.Bytes);
public long this[int i]=>Value[i];

public static A118756Inst Instance=new A118756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118757
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,79L,78L,77L };
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
public class A118757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118757Inst : IEnumerable<long>
{
public static readonly long[] Value=A118757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118757.Bytes);
public long this[int i]=>Value[i];

public static A118757Inst Instance=new A118757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118758
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,79L,78L,77L };
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
public class A118758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118758Inst : IEnumerable<long>
{
public static readonly long[] Value=A118758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118758.Bytes);
public long this[int i]=>Value[i];

public static A118758Inst Instance=new A118758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118759
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,189L };
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
public class A118759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118759Inst : IEnumerable<long>
{
public static readonly long[] Value=A118759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118759.Bytes);
public long this[int i]=>Value[i];

public static A118759Inst Instance=new A118759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118760
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
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
public class A118760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118760Inst : IEnumerable<long>
{
public static readonly long[] Value=A118760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118760.Bytes);
public long this[int i]=>Value[i];

public static A118760Inst Instance=new A118760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118761
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,119L,138L,157L,176L,195L,310L,339L,358L,377L,396L,559L,578L,597L,779L,798L,999L,3130L };
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
public class A118761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118761Inst : IEnumerable<long>
{
public static readonly long[] Value=A118761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118761.Bytes);
public long this[int i]=>Value[i];

public static A118761Inst Instance=new A118761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118762
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L };
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
public class A118762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118762Inst : IEnumerable<long>
{
public static readonly long[] Value=A118762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118762.Bytes);
public long this[int i]=>Value[i];

public static A118762Inst Instance=new A118762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118763
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,10L,11L,12L,13L,14L,15L,16L,17L,18L,28L,20L,21L,22L,23L,24L,25L,26L,27L,29L,39L,30L,31L,32L,33L,34L,35L,36L,37L,38L,48L,40L,41L,42L,43L,44L,45L,46L,47L,49L,59L,50L,51L,52L,53L,54L,55L,56L,57L,58L,68L,60L,61L,62L,63L,64L,65L,66L,67L,69L,79L,70L,71L };
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
public class A118763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118763Inst : IEnumerable<long>
{
public static readonly long[] Value=A118763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118763.Bytes);
public long this[int i]=>Value[i];

public static A118763Inst Instance=new A118763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118764
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,10L,21L,22L,23L,24L,25L,26L,27L,28L,20L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,30L,41L,42L,43L,44L,45L,46L,47L,48L,40L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,50L,61L,62L,63L,64L,65L,66L,67L,68L,60L,69L,71L,72L,73L };
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
public class A118764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118764Inst : IEnumerable<long>
{
public static readonly long[] Value=A118764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118764.Bytes);
public long this[int i]=>Value[i];

public static A118764Inst Instance=new A118764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118765
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,18L,19L,10L,11L,12L,13L,14L,15L,16L,17L,27L,28L,20L,21L,22L,23L,24L,25L,26L,29L,38L,39L,30L,31L,32L,33L,34L,35L,36L,37L,47L,48L,40L,41L,42L,43L,44L,45L,46L,49L,58L,59L,50L,51L,52L,53L,54L,55L,56L,57L,67L,68L,60L,61L,62L,63L,64L,65L,66L,69L,78L,79L,70L };
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
public class A118765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118765Inst : IEnumerable<long>
{
public static readonly long[] Value=A118765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118765.Bytes);
public long this[int i]=>Value[i];

public static A118765Inst Instance=new A118765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118766
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,14L,15L,16L,17L,18L,19L,10L,11L,22L,23L,24L,25L,26L,27L,28L,20L,21L,29L,32L,33L,34L,35L,36L,37L,38L,39L,30L,31L,42L,43L,44L,45L,46L,47L,48L,40L,41L,49L,52L,53L,54L,55L,56L,57L,58L,59L,50L,51L,62L,63L,64L,65L,66L,67L,68L,60L,61L,69L,72L,73L,74L };
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
public class A118766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118766Inst : IEnumerable<long>
{
public static readonly long[] Value=A118766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118766.Bytes);
public long this[int i]=>Value[i];

public static A118766Inst Instance=new A118766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118767
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,29L,49L,69L,89L };
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
public class A118767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118767Inst : IEnumerable<long>
{
public static readonly long[] Value=A118767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118767.Bytes);
public long this[int i]=>Value[i];

public static A118767Inst Instance=new A118767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118768
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-9L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-8L,1L,1L,1L,1L,1L,1L,1L,2L,10L,-9L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-8L,1L,1L,1L,1L,1L,1L,1L,2L,10L,-9L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-8L,1L,1L,1L,1L,1L,1L,1L,2L,10L,-9L,1L,1L,1L,1L,1L,1L,1L,1L,10L,-8L,1L,1L,1L,1L,1L,1L,1L,2L,10L,-9L,1L,1L,1L,1L,1L,1L,1L,1L,100L,-90L,-8L,1L,1L,1L,1L,1L,1L,1L,2L,10L,-9L,1L,1L,1L };
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
public class A118768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118768Inst : IEnumerable<long>
{
public static readonly long[] Value=A118768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118768.Bytes);
public long this[int i]=>Value[i];

public static A118768Inst Instance=new A118768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118769
{
public static readonly BigInteger[] Value={ 17L,673L,39937L,87177646081L,6402373519933441L,BigInteger.Parse("304888344611712432172380979201"),BigInteger.Parse("126886932185884164103433389335161480802865515044406852999479261820223930701069680640000001") };
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
public class A118769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118769Inst Instance=new A118769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118770
{
public static readonly BigInteger[] Value={ 4L,-14L,-196L,480L,696L,-57901L,-525364L,-409579L,18528507L,-237549252L,-2119519900L,6713972874L,18262155072L,-19072020914992L,162234208372185L,1471912942112734L,6828673030820538L,-35126752028893500L,729026655790306778L,BigInteger.Parse("-15365360727898374618") };
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
public class A118770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118770Inst Instance=new A118770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118771
{
public static readonly long[] Value={ 3L,9L,24L,67L };
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
public class A118771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118771Inst : IEnumerable<long>
{
public static readonly long[] Value=A118771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118771.Bytes);
public long this[int i]=>Value[i];

public static A118771Inst Instance=new A118771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118772
{
public static readonly BigInteger[] Value={ 8L,-56L,156L,13328L,-920L,-83678L,1261988L,54252742L,214409844L,-3528354250L,247094703588L,-509185323508L,15154985424718L,884710401396570L,49777180907707320L,-172913218088289027L,844641410704177098L,3066058962037715903L,BigInteger.Parse("-33948947842497666568") };
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
public class A118772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118772Inst Instance=new A118772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118773
{
public static readonly long[] Value={ 101L,107L,167L,179L,197L,251L,293L,401L,443L,491L,503L,509L,521L,563L,577L,587L,617L,631L,653L,809L,1009L,1019L,1031L,1039L,1049L,1061L,1091L,1097L,1283L,1327L,1381L,1409L,1427L,1439L,1451L,1471L,1511L,1559L,1567L,1583L,1601L,1607L,1621L,1787L,1871L };
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
public class A118773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118773Inst : IEnumerable<long>
{
public static readonly long[] Value=A118773.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118773.Bytes);
public long this[int i]=>Value[i];

public static A118773Inst Instance=new A118773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118774
{
public static readonly long[] Value={ 107L,109L,179L,181L,199L,257L,307L,409L,449L,499L,509L,521L,541L,569L,587L,599L,631L,641L,659L,811L,1019L,1031L,1039L,1049L,1061L,1091L,1097L,1109L,1289L,1361L,1399L,1427L,1439L,1451L,1459L,1487L,1553L,1567L,1583L,1601L,1607L,1619L,1637L,1801L,1877L };
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
public class A118774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118774Inst : IEnumerable<long>
{
public static readonly long[] Value=A118774.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118774.Bytes);
public long this[int i]=>Value[i];

public static A118774Inst Instance=new A118774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118775
{
public static readonly long[] Value={ 5L,8L,12L,18L,24L,30L,36L,42L,52L,60L,68L,78L,88L,100L,112L,126L,138L,154L,172L,190L,208L,216L,222L,240L,258L,268L,276L,288L,306L,324L,346L,360L,372L,388L,396L,410L,438L,460L,472L,490L,508L,520L,532L,550L,574L,600L,618L,628L,654L,684L,700L,712L,738L,768L,790L };
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
public class A118775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118775Inst : IEnumerable<long>
{
public static readonly long[] Value=A118775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118775.Bytes);
public long this[int i]=>Value[i];

public static A118775Inst Instance=new A118775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118776
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,2L,4L,6L,2L,6L,4L,6L,6L,6L,8L,4L,12L,6L,12L,6L,2L,4L,14L,4L,6L,2L,10L,8L,10L,12L,2L,10L,6L,2L,12L,16L,6L,6L,12L,6L,6L,6L,12L,12L,14L,4L,6L,20L,10L,6L,6L,20L,10L,12L,8L,10L,12L,12L,6L,12L,6L,12L,8L,4L,8L,4L,6L,12L,20L,16L,6L,6L,2L,6L,10L,12L,18L,14L,10L,6L,6L,6L,18L,6L,18L,18L,24L };
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
public class A118776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118776Inst : IEnumerable<long>
{
public static readonly long[] Value=A118776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118776.Bytes);
public long this[int i]=>Value[i];

public static A118776Inst Instance=new A118776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118777
{
public static readonly long[] Value={ 1L,2L,1L,0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,8L,9L,10L,11L,10L,11L,10L,11L,12L,13L,14L,15L,14L,15L,16L,17L,16L,17L,16L,17L,18L,19L,18L,19L,20L,21L,22L,23L,22L,23L,24L,25L,26L,27L,26L,27L,26L,27L,28L,29L,30L,31L,30L,31L,32L,33L,32L,33L,32L,33L,34L,35L,36L };
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
public class A118777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118777Inst : IEnumerable<long>
{
public static readonly long[] Value=A118777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118777.Bytes);
public long this[int i]=>Value[i];

public static A118777Inst Instance=new A118777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118778
{
public static readonly long[] Value={ 1L,4L,6L,9L,10L,18L,14L,20L,20L,30L,22L,38L,26L,42L,40L,42L,34L,62L,38L,60L,56L,66L,46L,82L,54L,78L,66L,84L,58L,122L,62L,88L,88L,102L,84L,126L,74L,114L,104L,126L,82L,168L,86L,132L,128L,138L,94L,172L,104L,166L,136L,156L,106L,198L,132L,170L,152L,174L,118L,254L,122L,186L,172L };
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
public class A118778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118778Inst : IEnumerable<long>
{
public static readonly long[] Value=A118778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118778.Bytes);
public long this[int i]=>Value[i];

public static A118778Inst Instance=new A118778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118779
{
public static readonly BigInteger[] Value={ 16L,-224L,0L,182016L,12734992L,-80430368L,-125120640L,1334967760L,1060202222660L,-2759409121760L,54820105989504L,-14148083510835712L,49989643415528010L,299304923505836144L,1713123391839442498L,BigInteger.Parse("93227182153040103540"),BigInteger.Parse("-86403659709730762670") };
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
public class A118779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118779Inst Instance=new A118779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118780
{
public static readonly long[] Value={ -14L,-6L,-5L,0L,-7L,-87L,-4L,76L,-8L,-212L,64L,-4L,128L,68L,-265L,31L,-12L,-177L,104L,109L,-28L,103L,-101L,-40L,-24L,-348L,-176L,253L,81L,-285L,-97L,928L,364L,-841L,-257L,-361L,-127L,-3L,-125L,603L,359L,-675L,367L,-8L,-860L,139L,-3L,995L,280L,-1276L,-167L,629L,145L,443L,-365L,-579L,171L,-569L };
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
public class A118780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118780Inst : IEnumerable<long>
{
public static readonly long[] Value=A118780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118780.Bytes);
public long this[int i]=>Value[i];

public static A118780Inst Instance=new A118780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118781
{
public static readonly long[] Value={ -196L,272L,-251L,149L,-423L,909L,-408L,-452L,958L,-123L,-112L,-460L,84L,-271L,-187L,-162L,63L,7L,101L,-483L,-133L,205L,-860L,-46L,339L,1178L,848L,366L,1084L,719L,-384L,334L,-2736L,-984L,-1912L,214L,34L,40L,-1735L,-60L,64L,-2263L,-3468L,5795L,69L,132L,3007L,256L,2130L,3428L };
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
public class A118781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118781Inst : IEnumerable<long>
{
public static readonly long[] Value=A118781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118781.Bytes);
public long this[int i]=>Value[i];

public static A118781Inst Instance=new A118781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118782
{
public static readonly long[] Value={ 6L,9L,12L,19L,20L,23L,28L,31L,32L,33L,39L,59L,62L,66L,67L,75L,79L,80L,83L,84L,85L,91L,98L,99L,107L,108L,109L,117L,121L,144L,147L,149L,150L,153L,155L,156L,159L,160L,167L,169L,178L,179L,184L,186L,187L,191L,195L,208L,210L,212L,220L,222L,226L,227L,229L,231L,242L,246L };
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
public class A118782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118782Inst : IEnumerable<long>
{
public static readonly long[] Value=A118782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118782.Bytes);
public long this[int i]=>Value[i];

public static A118782Inst Instance=new A118782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118783
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,5L,12L,9L,13L,11L,19L,15L,23L,21L,20L,25L,32L,18L,35L,24L,30L,29L,43L,28L,41L,37L,44L,38L,55L,27L,60L,47L,49L,51L,56L,42L,71L,54L,61L,50L,79L,46L,83L,63L,65L,68L,91L,59L,87L,67L,81L,75L,104L,66L,93L,77L,88L,85L,115L,57L,119L,96L,90L,99L,109L,73L,131L,102L,105L,80L };
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
public class A118783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118783Inst : IEnumerable<long>
{
public static readonly long[] Value=A118783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118783.Bytes);
public long this[int i]=>Value[i];

public static A118783Inst Instance=new A118783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118784
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,8L,13L,14L,16L,12L,22L,11L,25L,19L,24L,23L,34L,21L,37L,28L,32L,30L,45L,27L,46L,36L,43L,38L,58L,26L,62L,42L,52L,44L,60L,33L,73L,49L,61L,50L,82L,39L,85L,56L,70L,59L,94L,51L,89L,64L,83L,68L,106L,55L,96L,71L,95L,78L,117L,53L,121L,86L,100L,87L,111L,66L,134L,90L,112L };
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
public class A118784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118784Inst : IEnumerable<long>
{
public static readonly long[] Value=A118784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118784.Bytes);
public long this[int i]=>Value[i];

public static A118784Inst Instance=new A118784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118785
{
public static readonly long[] Value={ 1L,12L,32L,42L,32L,1L };
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
public class A118785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118785Inst : IEnumerable<long>
{
public static readonly long[] Value=A118785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118785.Bytes);
public long this[int i]=>Value[i];

public static A118785Inst Instance=new A118785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118786
{
public static readonly long[] Value={ 2L,5L,7L,31L,71L,83L,89L,101L,103L,109L,139L,223L,241L,293L,349L,433L,491L,509L,521L,541L,599L,617L,641L,719L,751L,787L,827L,883L,947L,997L,1213L,1291L,1303L,1321L,1367L,1381L,1423L,1531L,1571L,1597L,1747L,1787L,2017L,2027L,2029L,2111L,2129L,2207L,2237L,2341L };
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
public class A118786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118786Inst : IEnumerable<long>
{
public static readonly long[] Value=A118786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118786.Bytes);
public long this[int i]=>Value[i];

public static A118786Inst Instance=new A118786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118787
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,6L,12L,23L,41L,24L,60L,130L,255L,469L,120L,360L,870L,1860L,3679L,6889L,720L,2520L,6720L,15540L,32858L,65247L,123605L,5040L,20160L,58800L,146160L,328734L,689388L,1371887L,2620169L,40320L,181440L,574560L,1527120L,3638376L,8029980L };
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
public class A118787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118787Inst : IEnumerable<long>
{
public static readonly long[] Value=A118787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118787.Bytes);
public long this[int i]=>Value[i];

public static A118787Inst Instance=new A118787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118788
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,5L,1L,6L,23L,41L,1L,10L,65L,255L,469L,1L,15L,145L,930L,3679L,6889L,1L,21L,280L,2590L,16429L,65247L,123605L,1L,28L,490L,6090L,54789L,344694L,1371887L,2620169L,1L,36L,798L,12726L,151599L,1338330L,8367785L,33347535L,64074901L,1L,45L,1230L,24360L };
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
public class A118788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118788Inst : IEnumerable<long>
{
public static readonly long[] Value=A118788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118788.Bytes);
public long this[int i]=>Value[i];

public static A118788Inst Instance=new A118788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118789
{
public static readonly BigInteger[] Value={ 1L,2L,9L,71L,800L,11659L,208173L,4398148L,107293711L,2967800711L,91777098006L,3137581240925L,117499040544197L,4783424590188490L,210333509575901445L,9934472399437068811UL,BigInteger.Parse("501615620424564184408"),BigInteger.Parse("26963169913347131361647") };
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
public class A118789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118789Inst Instance=new A118789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118790
{
public static readonly BigInteger[] Value={ 1L,3L,23L,255L,3679L,65247L,1371887L,33347535L,919848991L,28382683263L,968565339983L,36217270235055L,1472548026160639L,64679673007670367L,3052084360057720367L,BigInteger.Parse("153980839859926277775"),BigInteger.Parse("8270901171633696369631") };
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
public class A118790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118790Inst Instance=new A118790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118791
{
public static readonly long[] Value={ 1L,-1L,3L,2L,-9L,19L,-6L,36L,-103L,207L,24L,-180L,650L,-1605L,3211L,-120L,1080L,-4710L,13860L,-32191L,64383L,720L,-7560L,38640L,-132300L,351722L,-790629L,1581259L,-5040L,60480L,-354480L,1386000L,-4163166L,10433556L,-22974463L,45948927L,40320L,-544320L,3598560L,-15830640L,53117064L };
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
public class A118791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118791Inst : IEnumerable<long>
{
public static readonly long[] Value=A118791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118791.Bytes);
public long this[int i]=>Value[i];

public static A118791Inst Instance=new A118791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118792
{
public static readonly BigInteger[] Value={ 0L,1L,4L,30L,352L,5670L,116344L,2902830L,85326112L,2887962870L,110620824904L,4730842053630L,223445584599472L,11552029520192070L,648869447924011864L,BigInteger.Parse("39347855472366932430"),BigInteger.Parse("2562065820090343738432"),BigInteger.Parse("178286102174571726213270") };
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
public class A118792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118792Inst Instance=new A118792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118793
{
public static readonly long[] Value={ 1L,-1L,3L,1L,-9L,19L,-1L,18L,-103L,207L,1L,-30L,325L,-1605L,3211L,-1L,45L,-785L,6930L,-32191L,64383L,1L,-63L,1610L,-22050L,175861L,-790629L,1581259L,-1L,84L,-2954L,57750L,-693861L,5216778L,-22974463L,45948927L,1L,-108L,4998L,-131922L,2213211L,-24542910L,177555925L,-770820885L,1541641771L };
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
public class A118793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118793Inst : IEnumerable<long>
{
public static readonly long[] Value=A118793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118793.Bytes);
public long this[int i]=>Value[i];

public static A118793Inst Instance=new A118793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118794
{
public static readonly BigInteger[] Value={ 0L,1L,2L,11L,121L,1902L,38381L,945989L,27552260L,925920081L,35265751869L,1501219998148L,70632987480771L,3639861179067661L,203881981765871618L,12333901891547136559UL,BigInteger.Parse("801418950244634922973"),BigInteger.Parse("55665376886060309513990") };
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
public class A118794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118794Inst Instance=new A118794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118795
{
public static readonly BigInteger[] Value={ 0L,1L,4L,29L,329L,5172L,104335L,2571473L,74894818L,2516911731L,95862252417L,4080739041238L,192000366357981L,9894168501171229L,554208686184384028L,BigInteger.Parse("33527021385789228265"),BigInteger.Parse("2178482569432714859789"),BigInteger.Parse("151314182463701892157460"),BigInteger.Parse("11188187745418763137485747") };
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
public class A118795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118795Inst Instance=new A118795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118796
{
public static readonly long[] Value={ 2L,13L,23L,29L,37L,41L,79L,107L,127L,149L,211L,239L,263L,313L,383L,389L,397L,439L,467L,509L,547L,631L,673L,743L,757L,773L,787L,827L,829L,907L,997L,1019L,1061L,1091L,1231L,1297L,1367L,1451L,1459L,1487L,1543L,1559L,1601L,1609L,1613L,1627L,1637L,1699L,1721L };
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
public class A118796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118796Inst : IEnumerable<long>
{
public static readonly long[] Value=A118796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118796.Bytes);
public long this[int i]=>Value[i];

public static A118796Inst Instance=new A118796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118797
{
public static readonly long[] Value={ 7L,11L,14L,17L,19L,23L,25L,28L };
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
public class A118797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118797Inst : IEnumerable<long>
{
public static readonly long[] Value=A118797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118797.Bytes);
public long this[int i]=>Value[i];

public static A118797Inst Instance=new A118797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118798
{
public static readonly long[] Value={ 79L,178L,179L,186L,210L,284L,300L,349L,391L,456L,594L,595L,599L,624L,645L,654L,659L,704L,712L,713L,860L,871L,892L,904L,924L,990L,1015L,1089L,1097L,1110L,1118L,1151L,1165L,1374L,1396L,1459L,1709L,1721L,1826L,1831L,1911L,1943L,1956L,2005L,2061L,2082L,2089L };
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
public class A118798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118798Inst : IEnumerable<long>
{
public static readonly long[] Value=A118798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118798.Bytes);
public long this[int i]=>Value[i];

public static A118798Inst Instance=new A118798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118799
{
public static readonly long[] Value={ 880L,-448L,-1472L,-240L,2480L,-1352L,-4128L,-96L,2736L,-2520L,120L,1080L,4288L,4880L,4600L,13368L,7056L,14560L,2960L,13320L,0L,24864L,-11096L,-24264L,0L,-9168L,-2128L,-15792L,0L,18120L,-5248L,6384L,-21840L,-38776L,-20480L,20176L,-72896L,-69200L,40080L,-37632L };
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
public class A118799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118799Inst : IEnumerable<long>
{
public static readonly long[] Value=A118799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118799.Bytes);
public long this[int i]=>Value[i];

public static A118799Inst Instance=new A118799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118800
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-3L,1L,4L,-8L,5L,-1L,8L,-20L,18L,-7L,1L,16L,-48L,56L,-32L,9L,-1L,32L,-112L,160L,-120L,50L,-11L,1L,64L,-256L,432L,-400L,220L,-72L,13L,-1L,128L,-576L,1120L,-1232L,840L,-364L,98L,-15L,1L,256L,-1280L,2816L,-3584L,2912L,-1568L,560L,-128L,17L,-1L,512L,-2816L,6912L,-9984L,9408L,-6048L,2688L,-816L,162L,-19L,1L };
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
public class A118800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118800Inst : IEnumerable<long>
{
public static readonly long[] Value=A118800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118800.Bytes);
public long this[int i]=>Value[i];

public static A118800Inst Instance=new A118800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118801
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-3L,1L,1L,-7L,5L,-1L,1L,-15L,17L,-7L,1L,1L,-31L,49L,-31L,9L,-1L,1L,-63L,129L,-111L,49L,-11L,1L,1L,-127L,321L,-351L,209L,-71L,13L,-1L,1L,-255L,769L,-1023L,769L,-351L,97L,-15L,1L,1L,-511L,1793L,-2815L,2561L,-1471L,545L,-127L,17L,-1L,1L,-1023L,4097L,-7423L,7937L,-5503L,2561L,-799L,161L,-19L,1L };
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
public class A118801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118801Inst : IEnumerable<long>
{
public static readonly long[] Value=A118801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118801.Bytes);
public long this[int i]=>Value[i];

public static A118801Inst Instance=new A118801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118802
{
public static readonly long[] Value={ 1L,2L,11L,76L,565L,4406L,35455L,291264L,2427113L,20436202L,173435251L,1481052596L,12711044125L,109543953182L,947334302951L,8216780507176L,71450654876625L,622692860482514L,5437356743763163L,47561030194674972L,416661242790844421L };
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
public class A118802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118802Inst : IEnumerable<long>
{
public static readonly long[] Value=A118802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118802.Bytes);
public long this[int i]=>Value[i];

public static A118802Inst Instance=new A118802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118803
{
public static readonly long[] Value={ 1L,1L,5L,33L,237L,1801L,14197L,114609L,940445L,7809273L,65437541L,552276577L,4688278093L,39991233641L,342517093333L,2943809545105L,25377201555325L,219341012215385L,1900216743054021L,16496109719061825L,143469924189693229L };
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
public class A118803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118803Inst : IEnumerable<long>
{
public static readonly long[] Value=A118803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118803.Bytes);
public long this[int i]=>Value[i];

public static A118803Inst Instance=new A118803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118804
{
public static readonly BigInteger[] Value={ 1L,2L,9L,66L,685L,9294L,156697L,3169910L,74998081L,2035262154L,62391632417L,2134187066010L,80641239109677L,3337651407273846L,150239268816661137L,7310140430519234862L,BigInteger.Parse("382439924662714479457"),BigInteger.Parse("21413128578896024921298"),BigInteger.Parse("1277905479699750127195097") };
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
public class A118804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118804Inst Instance=new A118804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118805
{
public static readonly BigInteger[] Value={ 1L,2L,11L,106L,1506L,28736L,694719L,20452602L,712529978L,28746803264L,1320665162746L,68164569542628L,3909330000805268L,246855506805662816L,17030177827550184395UL,BigInteger.Parse("1275139722566251183642"),BigInteger.Parse("103032621304705343054010") };
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
public class A118805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118805Inst Instance=new A118805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118806
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,5L,6L,1L,9L,2L,12L,3L,19L,3L,24L,5L,1L,34L,8L,43L,13L,62L,13L,2L,77L,23L,1L,105L,28L,2L,132L,40L,4L,177L,49L,5L,220L,71L,6L,287L,89L,8L,1L,356L,123L,11L,462L,147L,18L,570L,198L,23L,1L,723L,249L,29L,1L,888L,329L,37L,1L,1121L,400L,50L,4L,1370L,518L,69L,1L,1705L,642L,85L };
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
public class A118806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118806Inst : IEnumerable<long>
{
public static readonly long[] Value=A118806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118806.Bytes);
public long this[int i]=>Value[i];

public static A118806Inst Instance=new A118806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118807
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,6L,9L,12L,19L,24L,34L,43L,62L,77L,105L,132L,177L,220L,287L,356L,462L,570L,723L,888L,1121L,1370L,1705L,2074L,2570L,3111L,3816L,4601L,5617L,6743L,8170L,9777L,11794L,14058L,16858L,20029L,23932L,28334L,33692L,39772L,47133L,55468L,65471L,76840L };
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
public class A118807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118807Inst : IEnumerable<long>
{
public static readonly long[] Value=A118807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118807.Bytes);
public long this[int i]=>Value[i];

public static A118807Inst Instance=new A118807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118808
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,3L,3L,5L,8L,13L,13L,23L,28L,40L,49L,71L,89L,123L,147L,198L,249L,329L,400L,518L,642L,825L,996L,1265L,1545L,1941L,2340L,2920L,3533L,4357L,5233L,6417L,7717L,9399L,11211L,13591L,16215L,19540L,23189L,27826L,32990L,39392L,46504L,55313L,65200L };
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
public class A118808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118808Inst : IEnumerable<long>
{
public static readonly long[] Value=A118808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118808.Bytes);
public long this[int i]=>Value[i];

public static A118808Inst Instance=new A118808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118809
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,4L,10L,11L,13L,8L,16L,12L,14L,17L,20L,15L,22L,7L,25L,21L,24L,18L,31L,26L,28L,27L,33L,19L,36L,29L,35L,34L,37L,38L,44L,30L,40L,39L,47L,23L,48L,32L,49L,46L,45L,42L,57L,50L,54L,51L,55L,41L,61L,56L,63L,58L,59L,52L,70L,53L,62L,67L,68L,64L,72L,60L,73L,66L,77L,43L,83L };
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
public class A118809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118809Inst : IEnumerable<long>
{
public static readonly long[] Value=A118809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118809.Bytes);
public long this[int i]=>Value[i];

public static A118809Inst Instance=new A118809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118810
{
public static readonly long[] Value={ 1L,2L,3L,7L,4L,5L,19L,11L,6L,8L,9L,13L,10L,14L,17L,12L,15L,23L,29L,16L,21L,18L,41L,22L,20L,25L,27L,26L,31L,37L,24L,43L,28L,33L,32L,30L,34L,35L,39L,38L,53L,47L,71L,36L,46L,45L,40L,42L,44L,49L,51L,59L,61L,50L,52L,55L,48L,57L,58L,67L,54L,62L,56L,65L };
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
public class A118810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118810Inst : IEnumerable<long>
{
public static readonly long[] Value=A118810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118810.Bytes);
public long this[int i]=>Value[i];

public static A118810Inst Instance=new A118810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118811
{
public static readonly long[] Value={ 9L,0L,1L,7L,3L,5L,6L,9L,8L,5L,6L,5L,4L,6L,9L,7L,6L,9L,1L,8L,6L,0L,9L,6L,3L,4L,0L,2L,9L,7L,0L,0L,7L,7L,0L,0L,3L,9L,3L,0L,5L,9L,7L,1L,8L,6L,1L,3L,0L,9L,8L,0L,1L,9L,8L,9L,3L,4L,3L,3L,8L,3L,3L,7L,6L,1L,7L,1L,5L,4L,4L,6L,8L,0L,2L,0L,3L,4L,6L,9L,4L,5L,5L,7L,2L,9L,6L,9L,7L,0L,5L,9L,3L,1L,0L,3L,5L,8L,6L };
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
public class A118811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118811Inst : IEnumerable<long>
{
public static readonly long[] Value=A118811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118811.Bytes);
public long this[int i]=>Value[i];

public static A118811Inst Instance=new A118811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118812
{
public static readonly BigInteger[] Value={ 2L,23L,87178286161L,BigInteger.Parse("403291461126605629356979201"),BigInteger.Parse("5502622159812088949850305428800254867109635014075023360001") };
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
public class A118812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118812Inst Instance=new A118812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118813
{
public static readonly BigInteger[] Value={ 3628679L,87178286159L,20922789847679L,BigInteger.Parse("265252859812191058635000805631999") };
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
public class A118813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118813Inst Instance=new A118813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118814
{
public static readonly long[] Value={ 1L,2L,5L,18L,70L };
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
public class A118814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118814Inst : IEnumerable<long>
{
public static readonly long[] Value=A118814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118814.Bytes);
public long this[int i]=>Value[i];

public static A118814Inst Instance=new A118814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118815
{
public static readonly long[] Value={ -4656L,1440L,2912L,2832L,-10464L,-768L,-17376L,20384L,-72976L,-18944L,12672L,41184L,-199776L,28944L,-21104L,3552L,25488L,338448L,-60192L,39952L,-21792L,-161904L,499488L,-83424L,-7440L,7440L,-54288L,-75456L,1641792L,42288L };
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
public class A118815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118815Inst : IEnumerable<long>
{
public static readonly long[] Value=A118815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118815.Bytes);
public long this[int i]=>Value[i];

public static A118815Inst Instance=new A118815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118816
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,2L,2L,1L,3L,3L,1L,4L,4L,1L,5L,5L,0L,6L,6L,2L,7L,7L,2L,8L,8L,1L,9L,9L,3L,10L,10L,3L,11L,11L,1L,12L,12L,4L,13L,13L,4L,14L,14L,1L,15L,15L,5L,16L,16L,5L,17L,17L,0L,18L,18L,6L,19L,19L,6L,20L,20L,2L,21L,21L,7L,22L,22L,7L,23L,23L,2L,24L,24L,8L,25L,25L,8L,26L,26L,1L,27L,27L,9L,28L,28L };
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
public class A118816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118816Inst : IEnumerable<long>
{
public static readonly long[] Value=A118816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118816.Bytes);
public long this[int i]=>Value[i];

public static A118816Inst Instance=new A118816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118817
{
public static readonly long[] Value={ 3L,8L,8L,5L,3L,6L,1L,5L,3L,3L,3L,5L,1L,7L,5L,8L,5L,9L,1L,8L,4L,3L,2L,9L,5L,7L,5L,6L,8L,7L,0L,3L,5L,9L,0L,5L,0L,1L,3L,9L,0L,0L,5L,2L,8L,5L,9L,7L,5L,1L,7L,9L,2L,1L,9L,1L,3L,1L,8L,4L,6L,1L,1L,9L,9L,8L,7L,9L,8L,7L,4L,9L,4L,3L,4L,6L,3L,3L,9L,3L,2L,7L,6L,8L,3L,8L,8L,4L,3L,1L,9L,7L,8L,1L,3L,8L,3L,4L,0L,8L,2L,2L,4L,1L,3L };
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
public class A118817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118817Inst : IEnumerable<long>
{
public static readonly long[] Value=A118817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118817.Bytes);
public long this[int i]=>Value[i];

public static A118817Inst Instance=new A118817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118818
{
public static readonly long[] Value={ 223L,379L,463L,631L,691L,883L,907L,1051L,1423L,1447L,1543L,1723L,1747L,1783L,1987L,2143L,2179L,2347L,2467L,2591L,2767L,3259L,3307L,3511L,3631L,3691L,3739L,3823L,3907L,4219L,4447L,4507L,4519L,4639L,4987L,5023L,5107L,5119L,5347L,5683L,5923L };
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
public class A118818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118818Inst : IEnumerable<long>
{
public static readonly long[] Value=A118818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118818.Bytes);
public long this[int i]=>Value[i];

public static A118818Inst Instance=new A118818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118819
{
public static readonly long[] Value={ 1L,7L,13L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L,79L,103L,37L };
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
public class A118819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118819Inst : IEnumerable<long>
{
public static readonly long[] Value=A118819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118819.Bytes);
public long this[int i]=>Value[i];

public static A118819Inst Instance=new A118819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118820
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L,13L,33L,35L,55L,57L,77L,79L,99L,101L };
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
public class A118820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118820Inst : IEnumerable<long>
{
public static readonly long[] Value=A118820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118820.Bytes);
public long this[int i]=>Value[i];

public static A118820Inst Instance=new A118820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118821
{
public static readonly long[] Value={ 2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-8L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-16L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-8L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-32L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-8L,2L,-1L,2L,-2L,2L,-1L,2L,-4L,2L,-1L,2L,-2L,2L,-1L,2L,-16L };
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
public class A118821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118821Inst : IEnumerable<long>
{
public static readonly long[] Value=A118821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118821.Bytes);
public long this[int i]=>Value[i];

public static A118821Inst Instance=new A118821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118822
{
public static readonly long[] Value={ 2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L,-2L,1L,0L,1L,2L,-1L,0L,-1L };
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
public class A118822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118822Inst : IEnumerable<long>
{
public static readonly long[] Value=A118822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118822.Bytes);
public long this[int i]=>Value[i];

public static A118822Inst Instance=new A118822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118823
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,0L,1L,-4L,-7L,3L,-1L,5L,9L,-4L,1L,-12L,-23L,11L,-1L,13L,25L,-12L,1L,-16L,-31L,15L,-1L,17L,33L,-16L,1L,-32L,-63L,31L,-1L,33L,65L,-32L,1L,-36L,-71L,35L,-1L,37L,73L,-36L,1L,-44L,-87L,43L,-1L,45L,89L,-44L,1L,-48L,-95L,47L,-1L,49L,97L,-48L,1L,-80L,-159L,79L,-1L,81L,161L,-80L,1L,-84L,-167L,83L,-1L,85L,169L,-84L,1L,-92L };
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
public class A118823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118823Inst : IEnumerable<long>
{
public static readonly long[] Value=A118823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118823.Bytes);
public long this[int i]=>Value[i];

public static A118823Inst Instance=new A118823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118824
{
public static readonly long[] Value={ -2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,8L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,16L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,8L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,32L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,8L,-2L,1L,-2L,2L,-2L,1L,-2L,4L,-2L,1L,-2L,2L,-2L,1L,-2L,16L,-2L,1L,-2L,2L,-2L,1L };
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
public class A118824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118824Inst : IEnumerable<long>
{
public static readonly long[] Value=A118824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118824.Bytes);
public long this[int i]=>Value[i];

public static A118824Inst Instance=new A118824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118825
{
public static readonly long[] Value={ -2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L,0L,1L,-2L,-1L,0L,-1L,2L,1L };
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
public class A118825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118825Inst : IEnumerable<long>
{
public static readonly long[] Value=A118825.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118825.Bytes);
public long this[int i]=>Value[i];

public static A118825Inst Instance=new A118825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118826
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,1L,0L,1L,4L,-7L,-3L,-1L,-5L,9L,4L,1L,12L,-23L,-11L,-1L,-13L,25L,12L,1L,16L,-31L,-15L,-1L,-17L,33L,16L,1L,32L,-63L,-31L,-1L,-33L,65L,32L,1L,36L,-71L,-35L,-1L,-37L,73L,36L,1L,44L,-87L,-43L,-1L,-45L,89L,44L,1L,48L,-95L,-47L,-1L,-49L,97L,48L,1L,80L,-159L,-79L,-1L,-81L,161L,80L,1L,84L,-167L,-83L,-1L,-85L,169L,84L,1L,92L };
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
public class A118826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118826Inst : IEnumerable<long>
{
public static readonly long[] Value=A118826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118826.Bytes);
public long this[int i]=>Value[i];

public static A118826Inst Instance=new A118826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118827
{
public static readonly long[] Value={ 1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-16L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-32L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-16L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-64L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-16L,1L,-2L,1L,-4L,1L,-2L,1L,-8L,1L,-2L,1L,-4L,1L,-2L,1L,-32L,1L,-2L,1L };
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
public class A118827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118827Inst : IEnumerable<long>
{
public static readonly long[] Value=A118827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118827.Bytes);
public long this[int i]=>Value[i];

public static A118827Inst Instance=new A118827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118828
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,-1L };
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
public class A118828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118828Inst : IEnumerable<long>
{
public static readonly long[] Value=A118828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118828.Bytes);
public long this[int i]=>Value[i];

public static A118828Inst Instance=new A118828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118829
{
public static readonly long[] Value={ 1L,-2L,-1L,2L,1L,0L,1L,-8L,-7L,6L,-1L,10L,9L,-8L,1L,-24L,-23L,22L,-1L,26L,25L,-24L,1L,-32L,-31L,30L,-1L,34L,33L,-32L,1L,-64L,-63L,62L,-1L,66L,65L,-64L,1L,-72L,-71L,70L,-1L,74L,73L,-72L,1L,-88L,-87L,86L,-1L,90L,89L,-88L,1L,-96L,-95L,94L,-1L,98L,97L,-96L,1L,-160L,-159L,158L,-1L,162L,161L,-160L,1L,-168L,-167L,166L,-1L,170L,169L };
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
public class A118829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118829Inst : IEnumerable<long>
{
public static readonly long[] Value=A118829.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118829.Bytes);
public long this[int i]=>Value[i];

public static A118829Inst Instance=new A118829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118830
{
public static readonly long[] Value={ -1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,16L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,32L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,16L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,64L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,16L,-1L,2L,-1L,4L,-1L,2L,-1L,8L,-1L,2L,-1L,4L,-1L,2L,-1L,32L,-1L,2L,-1L };
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
public class A118830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118830Inst : IEnumerable<long>
{
public static readonly long[] Value=A118830.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118830.Bytes);
public long this[int i]=>Value[i];

public static A118830Inst Instance=new A118830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118831
{
public static readonly long[] Value={ -1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,0L };
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
public class A118831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118831Inst : IEnumerable<long>
{
public static readonly long[] Value=A118831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118831.Bytes);
public long this[int i]=>Value[i];

public static A118831Inst Instance=new A118831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118832
{
public static readonly long[] Value={ 1L,2L,-1L,-2L,1L,0L,1L,8L,-7L,-6L,-1L,-10L,9L,8L,1L,24L,-23L,-22L,-1L,-26L,25L,24L,1L,32L,-31L,-30L,-1L,-34L,33L,32L,1L,64L,-63L,-62L,-1L,-66L,65L,64L,1L,72L,-71L,-70L,-1L,-74L,73L,72L,1L,88L,-87L,-86L,-1L,-90L,89L,88L,1L,96L,-95L,-94L,-1L,-98L,97L,96L,1L,160L,-159L,-158L,-1L,-162L,161L,160L,1L,168L,-167L,-166L,-1L,-170L,169L,168L };
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
public class A118832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118832Inst : IEnumerable<long>
{
public static readonly long[] Value=A118832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118832.Bytes);
public long this[int i]=>Value[i];

public static A118832Inst Instance=new A118832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118833
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,7L,4L,12L,11L,9L,13L,10L,16L,15L,8L,24L,23L,21L,18L,19L,20L,22L,17L,31L,30L,28L,25L,29L,14L,46L,45L,43L,40L,36L,27L,42L,37L,32L,44L,38L,35L,49L,48L,41L,47L,33L,61L,60L,58L,55L,51L,34L,72L,71L,69L,66L,62L,53L,57L,52L,67L,59L,56L,70L,64L,50L,84L,83L,81L,78L,74L,54L };
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
public class A118833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118833Inst : IEnumerable<long>
{
public static readonly long[] Value=A118833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118833.Bytes);
public long this[int i]=>Value[i];

public static A118833Inst Instance=new A118833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118834
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,6L,15L,10L,12L,9L,8L,11L,29L,14L,13L,23L,19L,20L,21L,18L,22L,17L,16L,27L,141L,35L,26L,28L,25L,24L,38L,46L,52L,41L,34L,37L,40L,78L,33L,44L,36L,32L,39L,31L,30L,45L,43L,42L,66L,51L,60L,58L,72L,50L,63L,59L,49L,62L,48L,47L,57L,87L,65L,91L,56L,61L,106L,55L,64L,54L,53L };
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
public class A118834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118834Inst : IEnumerable<long>
{
public static readonly long[] Value=A118834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118834.Bytes);
public long this[int i]=>Value[i];

public static A118834Inst Instance=new A118834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118835
{
public static readonly BigInteger[] Value={ 4L,25L,229L,2315L,32639L,491900L,10362539L,228467758L,5722056489L,149001936472L,4922785960065L,167523724578682L,5868253146213935L,223161143280708212L,8709152841093834203L,BigInteger.Parse("400844191833597081550"),BigInteger.Parse("19650074552687350830153"),BigInteger.Parse("1002554646378888489419353") };
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
public class A118835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118835Inst Instance=new A118835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118836
{
public static readonly BigInteger[] Value={ 1L,6L,55L,556L,7839L,118141L,2488800L,54871741L,1374282325L,35786212191L,1182319284628L,40234641889543L,1409394785418633L,53597236487797597L,2091701617809524916L,BigInteger.Parse("96271871655725943733"),BigInteger.Parse("4719413412748380767833"),BigInteger.Parse("240786355921823145103216") };
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
public class A118836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118836Inst Instance=new A118836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118837
{
public static readonly long[] Value={ 1L,5L,9L,13L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L,35L,57L,79L,101L,15L,55L,59L,99L,103L };
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
public class A118837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118837Inst : IEnumerable<long>
{
public static readonly long[] Value=A118837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118837.Bytes);
public long this[int i]=>Value[i];

public static A118837Inst Instance=new A118837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118838
{
public static readonly long[] Value={ 1L,8L,45L,58L,92L,36L,70L,14L,48L,91L,26L,69L,103L,38L,90L,16L,68L,93L,46L,71L,24L,49L,104L,48L,91L,26L,69L,103L,38L,90L,16L,68L,93L,46L,71L,24L,49L,104L,48L,91L,26L,69L,103L,38L,90L,16L,68L,93L,46L,71L,24L,49L,104L,48L,91L,26L,69L,103L,38L,90L,16L,68L,93L,46L,71L,24L,49L };
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
public class A118838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118838Inst : IEnumerable<long>
{
public static readonly long[] Value=A118838.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118838.Bytes);
public long this[int i]=>Value[i];

public static A118838Inst Instance=new A118838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118839
{
public static readonly BigInteger[] Value={ 2L,11L,17L,29L,199L,521L,3571L,9349L,103681L,3010349L,54018521L,370248451L,6643838879L,10749957121L,119218851371L,5600748293801L,688846502588399L,32361122672259149L,BigInteger.Parse("115561578124838522881"),BigInteger.Parse("412670427844921037470771") };
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
public class A118839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118839Inst Instance=new A118839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A118840
{
public static readonly BigInteger[] Value={ 3L,149L,1097L,22027L,BigInteger.Parse("3989519570547215850763757278730095398677254309") };
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
public class A118840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A118840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A118840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A118840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A118840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A118840Inst Instance=new A118840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}