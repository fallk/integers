using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A175005
{
public static readonly long[] Value={ 0L,1L,4L,13L,42L,137L,448L,1465L,4790L,15661L,51204L,167413L,547362L,1789617L,5851208L,19130705L,62548430L,204504021L,668632204L,2186113613L,7147565882L,23369187097L,76406277968L,249812682345L,816770269670L,2670455587581L };
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
public class A175005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175005Inst : IEnumerable<long>
{
public static readonly long[] Value=A175005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175005.Bytes);
public long this[int i]=>Value[i];

public static A175005Inst Instance=new A175005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175006
{
public static readonly long[] Value={ 1L,3L,9L,21L,44L,81L,139L,222L,339L,495L,701L,1294L,963L,1294L,1701L };
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
public class A175006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175006Inst : IEnumerable<long>
{
public static readonly long[] Value=A175006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175006.Bytes);
public long this[int i]=>Value[i];

public static A175006Inst Instance=new A175006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175007
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,11L,12L,14L,17L,18L,20L,22L,25L,26L,29L,30L,33L,34L,36L,38L,40L,42L,45L,47L,48L,50L,52L,54L,57L,58L,60L,62L,64L,66L,69L,70L,73L,74L,76L,78L,80L,82L,84L,86L,89L,91L,93L,95L,96L,98L,100L,102L,104L,106L,109L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L };
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
public class A175007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175007Inst : IEnumerable<long>
{
public static readonly long[] Value=A175007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175007.Bytes);
public long this[int i]=>Value[i];

public static A175007Inst Instance=new A175007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175008
{
public static readonly long[] Value={ 4L,7L,8L,10L,13L,15L,16L,19L,21L,23L,24L,27L,28L,31L,32L,35L,37L,39L,41L,43L,44L,46L,49L,51L,53L,55L,56L,59L,61L,63L,65L,67L,68L,71L,72L,75L,77L,79L,81L,83L,85L,87L,88L,90L,92L,94L,97L,99L,101L,103L,105L,107L,108L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,132L,133L };
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
public class A175008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175008Inst : IEnumerable<long>
{
public static readonly long[] Value=A175008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175008.Bytes);
public long this[int i]=>Value[i];

public static A175008Inst Instance=new A175008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175009
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,1L,4L,9L,7L,1L,5L,13L,13L,12L,1L,6L,17L,19L,23L,15L,12L,7L,21L,25L,34L,29L,22L,1L,8L,25L,31L,45L,43L,43L,26L,1L,9L,29L,37L,56L,57L,64L,51L,35L,1L,10L,33L,43L,67L,71L,85L,76L,69L,40L,1L,11L,37L,49L,78L,85L,106L,101L,103L,79L,51L };
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
public class A175009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175009Inst : IEnumerable<long>
{
public static readonly long[] Value=A175009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175009.Bytes);
public long this[int i]=>Value[i];

public static A175009Inst Instance=new A175009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175010
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,5L,1L,1L,1L,1L,1L,4L,6L,1L,1L,1L,1L,1L,2L,6L,9L,1L,1L,1L,1L,1L,1L,4L,8L,12L,1L,1L,1L,1L,1L,1L,2L,6L,12L,16L,1L,1L,1L,1L,1L,1L,1L,4L,8L,19L,18L,1L,1L,1L,1L,1L,1L,1L,2L,6L,11L,28L,23L };
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
public class A175010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175010Inst : IEnumerable<long>
{
public static readonly long[] Value=A175010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175010.Bytes);
public long this[int i]=>Value[i];

public static A175010Inst Instance=new A175010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175011
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,5L,1L,2L,2L,16L,1L,2L,2L,5L,45L,1L,2L,2L,2L,12L,125L,1L,2L,2L,2L,5L,24L,341L,1L,2L,2L,2L,2L,12L,48L,918L,1L,2L,2L,2L,2L,7L,18L,97L,2453L,1L,2L,2L,2L,2L,2L,16L,28L,195L,6515L };
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
public class A175011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175011Inst : IEnumerable<long>
{
public static readonly long[] Value=A175011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175011.Bytes);
public long this[int i]=>Value[i];

public static A175011Inst Instance=new A175011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175012
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,4L,2L,4L,9L,5L,2L,4L,10L,14L,6L,2L,4L,10L,19L,23L,7L,2L,4L,10L,20L,34L,32L,8L,2L,4L,10L,20L,39L,55L,46L,9L,2L,4L,10L,20L,40L,66L,88L,60L,10L };
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
public class A175012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175012Inst : IEnumerable<long>
{
public static readonly long[] Value=A175012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175012.Bytes);
public long this[int i]=>Value[i];

public static A175012Inst Instance=new A175012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175013
{
public static readonly long[] Value={ 4L,6L,9L,1L,5L,6L,3L,4L,7L,8L,6L,7L,8L,11L,12L,10L,13L,6L,10L,12L,13L,8L,11L,15L,11L,14L,10L,13L,14L,15L,10L,12L,13L,14L,7L,3L,7L,10L,11L,4L,5L,6L,12L,7L,8L,6L,7L,8L,10L,11L,11L,14L,15L,8L,13L,16L,15L,16L,12L,14L,16L,14L,3L,4L,5L,7L,8L,11L,6L,7L,8L,10L,11L,12L,5L,10L,10L,12L,13L,15L,10L };
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
public class A175013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175013Inst : IEnumerable<long>
{
public static readonly long[] Value=A175013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175013.Bytes);
public long this[int i]=>Value[i];

public static A175013Inst Instance=new A175013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175014
{
public static readonly BigInteger[] Value={ 0L,12L,2136L,380196L,67672752L,12045369660L,2144008126728L,381621401187924L,67926465403323744L,12090529220390438508UL,BigInteger.Parse("2152046274764094730680"),BigInteger.Parse("383052146378788471622532"),BigInteger.Parse("68181130009149583854080016") };
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
public class A175014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175014.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175014Inst Instance=new A175014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175015
{
public static readonly BigInteger[] Value={ 0L,20L,6040L,1824060L,550860080L,166357920100L,50239541010120L,15172175027136140L,4581946618654104160L,BigInteger.Parse("1383732706658512320180"),BigInteger.Parse("417882695464252066590200"),BigInteger.Parse("126199190297497465597920220") };
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
public class A175015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175015Inst Instance=new A175015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175016
{
public static readonly BigInteger[] Value={ 0L,2574L,100916244L,3956522259690L,155119411612489896L,BigInteger.Parse("6081611647722756602886"),BigInteger.Parse("238435666105498983760258620"),BigInteger.Parse("9348108719250581509581942852834"),BigInteger.Parse("366501950208502632559170667727951184") };
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
public class A175016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175016.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175016Inst Instance=new A175016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175017
{
public static readonly long[] Value={ 139L,1327L,1381L,2137L,2713L,3613L,4513L,5413L,6133L,7213L,9013L,11317L,11353L,12613L,13009L,13063L,13171L,13441L,13513L,13711L,15313L,18013L,21613L,24133L,26113L,31333L,31513L,32413L,34213L,36013L,41341L,41413L,44131L,45013L,51133L,53113L,54013L };
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
public class A175017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175017Inst : IEnumerable<long>
{
public static readonly long[] Value=A175017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175017.Bytes);
public long this[int i]=>Value[i];

public static A175017Inst Instance=new A175017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175018
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,6L,6L,6L,8L,7L,7L,8L,8L,8L,8L,10L,9L,9L,10L,11L,10L,10L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,16L,12L,13L,15L,14L,13L,15L,15L,14L,16L,15L,16L,16L,16L,16L,20L,17L,16L,19L,18L,17L,20L,20L,19L,19L,20L,20L,20L,20L,21L,20L,21L,22L,22L,22L,22L,23L,22L,23L,24L,24L,23L,24L,24L,24L,24L,24L,24L,32L,21L,26L,27L,28L };
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
public class A175018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175018Inst : IEnumerable<long>
{
public static readonly long[] Value=A175018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175018.Bytes);
public long this[int i]=>Value[i];

public static A175018Inst Instance=new A175018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175019
{
public static readonly long[] Value={ 1L,1L,3L,5L,3L,3L,7L,5L,3L,5L,7L,9L,5L,5L,7L,9L,7L,5L,11L,9L,7L,7L,11L,9L,7L,9L,11L,13L,7L,9L,11L,13L,9L,9L,11L,13L,11L,9L,15L,13L,11L,9L,15L,13L,11L,11L,15L,13L,11L,13L,15L,17L,11L,13L,15L,17L,11L,13L,15L,17L,13L,13L,15L,17L,15L,13L,19L,17L,15L,13L,19L,17L,15L,13L,19L,17L,15L,15L,19L,17L };
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
public class A175019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175019Inst : IEnumerable<long>
{
public static readonly long[] Value=A175019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175019.Bytes);
public long this[int i]=>Value[i];

public static A175019Inst Instance=new A175019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175020
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,12L,15L,16L,17L,18L,19L,21L,24L,31L,32L,33L,34L,35L,36L,37L,42L,48L,51L,56L,63L,64L,65L,66L,67L,68L,69L,71L,73L,74L,76L,85L,96L,99L,112L,127L,128L,129L,130L,131L,132L,133L,135L,136L,137L,138L,140L,146L,147L,149L,170L,192L,195L,199L,204L,224L };
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
public class A175020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175020Inst : IEnumerable<long>
{
public static readonly long[] Value=A175020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175020.Bytes);
public long this[int i]=>Value[i];

public static A175020Inst Instance=new A175020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175021
{
public static readonly long[] Value={ 6L,11L,13L,14L,20L,22L,23L,25L,26L,27L,28L,29L,30L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,70L,72L,75L,77L,78L,79L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,97L,98L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L };
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
public class A175021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175021Inst : IEnumerable<long>
{
public static readonly long[] Value=A175021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175021.Bytes);
public long this[int i]=>Value[i];

public static A175021Inst Instance=new A175021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175022
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,3L,4L,2L,1L,2L,3L,4L,3L,5L,2L,1L,2L,3L,4L,3L,4L,5L,6L,2L,3L,2L,1L,2L,3L,4L,3L,4L,5L,3L,5L,6L,4L,7L,2L,3L,2L,1L,2L,3L,4L,3L,4L,5L,3L,4L,5L,6L,4L,6L,5L,7L,8L,2L,3L,3L,4L,2L,2L,1L,2L,3L,4L,3L,4L,5L,3L,4L,5L,6L,4L,3L,5L,6L,5L,7L,4L,6L,7L,8L,5L,9L,2L,3L,3L,4L,2L,3L,2L,1L,2L,3L,4L,3L,4L,5L,3L,4L,5L };
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
public class A175022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175022Inst : IEnumerable<long>
{
public static readonly long[] Value=A175022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175022.Bytes);
public long this[int i]=>Value[i];

public static A175022Inst Instance=new A175022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175023
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,3L,1L,2L,1L,1L,1L,1L,1L,2L,2L,4L,1L,4L,1L,3L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,3L,5L,1L,5L,1L,4L,1L,1L,3L,1L,1L,1L,3L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,4L,2L,2L,2L,3L,3L,6L,1L,6L,1L,5L,1L,1L,4L,1L,1L,1L,4L,2L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,3L,3L,1L,2L,1L,2L };
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
public class A175023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175023Inst : IEnumerable<long>
{
public static readonly long[] Value=A175023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175023.Bytes);
public long this[int i]=>Value[i];

public static A175023Inst Instance=new A175023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175024
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,2L,4L,1L,4L,1L,1L,3L,1L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,3L,5L,1L,5L,1L,1L,4L,1L,1L,1L,3L,1L,2L,3L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,4L,2L,2L,2L,3L,3L,6L,1L,6L,1L,1L,5L,1L,1L,1L,4L,1L,2L,4L,1L,1L,2L,3L,1L,1L,1L,1L,3L,1L,3L,3L,1L,1L,1L,2L };
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
public class A175024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175024Inst : IEnumerable<long>
{
public static readonly long[] Value=A175024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175024.Bytes);
public long this[int i]=>Value[i];

public static A175024Inst Instance=new A175024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175025
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,4L,4L,1L,3L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,3L,2L,5L,5L,1L,4L,1L,1L,3L,1L,1L,1L,3L,2L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,2L,2L,2L,2L,3L,3L,6L,6L,1L,5L,1L,1L,4L,1L,1L,1L,4L,2L,1L,3L,2L,1L,1L,3L,1L,1L,1L,1L,3L,3L,1L,2L,2L,1L,1L };
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
public class A175025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175025Inst : IEnumerable<long>
{
public static readonly long[] Value=A175025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175025.Bytes);
public long this[int i]=>Value[i];

public static A175025Inst Instance=new A175025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175026
{
public static readonly long[] Value={ 432L,127L,1426L,10488L,63221L,1328L,11136L,1291186L };
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
public class A175026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175026Inst : IEnumerable<long>
{
public static readonly long[] Value=A175026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175026.Bytes);
public long this[int i]=>Value[i];

public static A175026Inst Instance=new A175026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175027
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,3L,6L,4L,8L,9L,10L,5L,12L,6L,14L,15L,16L,7L,18L,8L,20L,21L,22L,9L,24L,25L,26L,27L,28L,10L,30L,11L,32L,33L,34L,35L,36L,12L,38L,39L,40L,13L,42L,14L,44L,45L,46L,15L,48L,49L,50L,51L,52L,16L,54L,55L,56L,57L,58L,17L,60L,18L,62L,63L,64L,65L,66L,19L,68L,69L,70L,20L,72L,21L };
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
public class A175027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175027Inst : IEnumerable<long>
{
public static readonly long[] Value=A175027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175027.Bytes);
public long this[int i]=>Value[i];

public static A175027Inst Instance=new A175027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175028
{
public static readonly long[] Value={ 0L,3L,4L,3L,6L,5L,8L,7L,8L,9L,12L,11L,14L,13L,14L,15L,18L,17L,20L,19L,20L,21L,24L,23L,24L,25L,26L,27L,30L,29L,32L,31L,32L,33L,34L,35L,38L,37L,38L,39L,42L,41L,44L,43L,44L,45L,48L,47L,48L,49L,50L,51L,54L,53L,54L,55L,56L,57L,60L,59L,62L,61L,62L,63L,64L,65L,68L,67L,68L,69L,72L,71L,74L };
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
public class A175028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175028Inst : IEnumerable<long>
{
public static readonly long[] Value=A175028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175028.Bytes);
public long this[int i]=>Value[i];

public static A175028Inst Instance=new A175028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175029
{
public static readonly long[] Value={ 3L,4L,6L,12L,10L,18L,14L,24L,27L,30L,22L,36L,26L,42L,45L,48L,34L,54L,38L,60L,63L,66L,46L,72L,75L,78L,81L,84L,58L,90L,62L,96L,99L,102L,105L,108L,74L,114L,117L,120L,82L,126L,86L,132L,135L,138L,94L,144L,147L,150L,153L,156L,106L,162L,165L,168L,171L,174L,118L,180L,122L,186L };
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
public class A175029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175029Inst : IEnumerable<long>
{
public static readonly long[] Value=A175029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175029.Bytes);
public long this[int i]=>Value[i];

public static A175029Inst Instance=new A175029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175030
{
public static readonly long[] Value={ 2L,6L,9L,8L,15L,12L,21L,16L,18L,20L,33L,24L,39L,28L,30L,32L,51L,36L,57L,40L,42L,44L,69L,48L,50L,52L,54L,56L,87L,60L,93L,64L,66L,68L,70L,72L,111L,76L,78L,80L,123L,84L,129L,88L,90L,92L,141L,96L,98L,100L,102L,104L,159L,108L,110L,112L,114L,116L,177L,120L,183L,124L,126L,128L,130L };
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
public class A175030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175030Inst : IEnumerable<long>
{
public static readonly long[] Value=A175030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175030.Bytes);
public long this[int i]=>Value[i];

public static A175030Inst Instance=new A175030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175031
{
public static readonly long[] Value={ 1L,4L,8L,9L,16L,25L,27L,32L,36L,49L,64L,81L,216L,243L,256L,289L,324L,343L,484L,512L,529L,576L,729L,784L,841L,961L,2025L,2048L,2187L,2197L,2304L,2401L,2601L,2704L,2809L,2916L,3025L,3125L,3136L,3249L,3481L,3721L,3969L,4096L,4356L,4624L,5041L,5184L,5329L,5476L };
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
public class A175031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175031Inst : IEnumerable<long>
{
public static readonly long[] Value=A175031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175031.Bytes);
public long this[int i]=>Value[i];

public static A175031Inst Instance=new A175031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175032
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,1L,4L,8L,0L,4L,9L,15L,3L,9L,16L,1L,8L,16L,25L,6L,15L,25L,3L,13L,24L,36L,10L,22L,35L,6L,19L,33L,1L,15L,30L,46L,10L,26L,43L,4L,21L,39L,58L,15L,34L,54L,8L,28L,49L,0L,21L,43L,66L,13L,36L,60L,4L,28L,53L,79L,19L,45L,72L,9L,36L,64L,93L,26L,55L,85L,15L,45L,76L,3L,34L,66L,99L,22L };
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
public class A175032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175032Inst : IEnumerable<long>
{
public static readonly long[] Value=A175032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175032.Bytes);
public long this[int i]=>Value[i];

public static A175032Inst Instance=new A175032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175033
{
public static readonly long[] Value={ 9L,15L,55L,89L,321L,519L,1871L,3025L,10905L,17631L,63559L,102761L,370449L,598935L,2159135L,3490849L,12584361L,20346159L,73347031L,118586105L,427497825L,691170471L };
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
public class A175033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175033Inst : IEnumerable<long>
{
public static readonly long[] Value=A175033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175033.Bytes);
public long this[int i]=>Value[i];

public static A175033Inst Instance=new A175033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175034
{
public static readonly long[] Value={ 2L,5L,7L,11L,12L,14L,17L,18L,20L,23L,27L,29L,31L,32L,37L,38L,40L,41L,42L,44L,47L,50L,51L,52L,56L,57L,59L,62L,65L,67L,68L,69L,70L,73L,74L,77L,82L,83L,84L,86L,87L,88L,92L,95L,96L,98L,101L,102L,104L,107L,109L,110L,112L,113L,117L,119L,122L,125L,126L,127L,128L,131L,132L,135L,137L,139L };
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
public class A175034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175034Inst : IEnumerable<long>
{
public static readonly long[] Value=A175034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175034.Bytes);
public long this[int i]=>Value[i];

public static A175034Inst Instance=new A175034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175035
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,10L,13L,15L,16L,19L,21L,22L,24L,25L,26L,28L,30L,33L,34L,35L,36L,39L,43L,45L,46L,48L,49L,53L,54L,55L,58L,60L,61L,63L,64L,66L,71L,72L,75L,76L,78L,79L,80L,81L,85L,89L,90L,91L,93L,94L,97L,99L,100L,103L,105L,106L,108L,111L,114L,115L,116L,118L,120L };
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
public class A175035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175035Inst : IEnumerable<long>
{
public static readonly long[] Value=A175035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175035.Bytes);
public long this[int i]=>Value[i];

public static A175035Inst Instance=new A175035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175036
{
public static readonly long[] Value={ 1L,2L,4L,1L,5L,6L,13L,14L,3L,19L,1L,13L,37L,22L,28L,14L,46L,44L,40L,24L,4L,18L,65L,2L,96L,10L,38L,31L,66L,2L,4L,124L,34L,82L,69L,32L,75L,103L,114L,5L,36L,78L,20L,6L,135L,125L,24L,132L,12L,13L,152L,24L,16L,8L,64L,218L,37L,55L,59L,170L,15L,270L,101L,104L,142L,185L,64L,16L,243L,28L,319L,12L,63L,308L,156L,252L,193L,334L,18L,159L,375L,298L,27L,316L,292L,65L,410L,220L,236L,173L,329L,46L,76L,150L,447L,46L,320L,118L,25L,17L,206L,399L,336L,457L,150L,3L,49L,116L,392L,512L,81L,77L,113L,75L,188L,50L,131L,116L,647L,63L,68L };
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
public class A175036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175036Inst : IEnumerable<long>
{
public static readonly long[] Value=A175036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175036.Bytes);
public long this[int i]=>Value[i];

public static A175036Inst Instance=new A175036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175037
{
public static readonly long[] Value={ 12L,83L,228L,1265L,1321L,5068L,3617L,11993L,32245L,14404L,65873L,67182L,35224L,93088L,201244L,245920L,115246L,369144L,315080L,155560L,612264L,492069L,844778L,1414099L,871855L,436812L,959459L,490218L,1232476L,5122720L,1649231L,2961709L };
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
public class A175037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175037Inst : IEnumerable<long>
{
public static readonly long[] Value=A175037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175037.Bytes);
public long this[int i]=>Value[i];

public static A175037Inst Instance=new A175037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175038
{
public static readonly long[] Value={ 0L,1L,1L,4L,2L,6L,2L,6L,10L,2L,10L,6L,2L,6L,10L,10L,2L,10L,6L,2L,10L,6L,10L,14L,7L,3L,9L,3L,9L,39L,9L,15L,3L,27L,3L,15L,15L,9L,15L,15L,3L,27L,3L,9L,3L,33L,33L,9L,3L,9L,15L,3L,27L,15L,15L,15L,3L,15L,9L,3L,27L,39L,9L,3L,9L,39L,15L,27L,3L,9L,15L,21L,15L,15L,9L,15L,21L,9L,21L,27L,3L,27L,3L,15L,9L,15L };
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
public class A175038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175038Inst : IEnumerable<long>
{
public static readonly long[] Value=A175038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175038.Bytes);
public long this[int i]=>Value[i];

public static A175038Inst Instance=new A175038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175039
{
public static readonly long[] Value={ 1L,3L,3L,7L,6L,7L,7L,11L,12L,13L,12L,15L,14L,15L,15L,20L,20L,23L,22L,23L,24L,25L,24L,29L,28L,29L,28L };
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
public class A175039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175039Inst : IEnumerable<long>
{
public static readonly long[] Value=A175039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175039.Bytes);
public long this[int i]=>Value[i];

public static A175039Inst Instance=new A175039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175040
{
public static readonly long[] Value={ 0L,1L,8L,3L,256L,5L,46656L,7L,512L,9L,10000000L,11L,12L,2197L,14L,170859375L,4096L,289L,104976L,361L,20L,194481L,10648L,279841L,7962624L,15625L,11881376L,19683L,28L,29L,810000L,961L,32L,33L,70188843638032384L,52521875L,1679616L,50653L,38L,1521L };
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
public class A175040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175040Inst : IEnumerable<long>
{
public static readonly long[] Value=A175040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175040.Bytes);
public long this[int i]=>Value[i];

public static A175040Inst Instance=new A175040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175041
{
public static readonly long[] Value={ 2L,4L,9L,12L,15L,19L,24L,28L,33L,41L,45L,49L,54L,61L };
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
public class A175041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175041Inst : IEnumerable<long>
{
public static readonly long[] Value=A175041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175041.Bytes);
public long this[int i]=>Value[i];

public static A175041Inst Instance=new A175041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175042
{
public static readonly long[] Value={ 12L,11L,7L,12L,29L,17L,19L,20L,4L,17L,7L,20L,27L,29L,25L,24L,12L,5L,21L,29L,17L,17L,32L,28L,27L,10L,5L,17L,6L,30L,29L,6L,5L,18L,21L,10L,9L,6L,9L,26L,5L,9L,9L,16L,2L,9L,16L,9L,12L,25L,6L,21L,18L,15L,6L,6L,21L,21L,3L,17L,19L,8L,8L,13L,11L,17L,27L,8L,27L,28L,28L,26L,16L,23L,17L,5L,5L,17L,18L };
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
public class A175042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175042Inst : IEnumerable<long>
{
public static readonly long[] Value=A175042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175042.Bytes);
public long this[int i]=>Value[i];

public static A175042Inst Instance=new A175042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175043
{
public static readonly long[] Value={ 247L,293L,177L,247L,293L,178L,178L,177L,177L,293L,286L,177L,246L,293L,236L,293L,247L,177L,246L,293L,178L,178L,246L,293L,293L,293L,177L,178L,177L,246L,293L,286L,232L,230L,236L,293L,293L,286L,177L,293L,177L,293L,293L,178L,232L,177L,293L,293L,247L,293L,177L };
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
public class A175043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175043Inst : IEnumerable<long>
{
public static readonly long[] Value=A175043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175043.Bytes);
public long this[int i]=>Value[i];

public static A175043Inst Instance=new A175043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175044
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L };
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
public class A175044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175044Inst : IEnumerable<long>
{
public static readonly long[] Value=A175044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175044.Bytes);
public long this[int i]=>Value[i];

public static A175044Inst Instance=new A175044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175045
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,2L,0L,0L,1L,3L,1L,3L,2L,2L,0L,1L,0L,1L,1L,1L,3L,5L,1L,1L,3L,4L,2L,5L,2L,3L,0L,0L,1L,2L,0L,2L,1L,2L,1L,2L,1L,4L,3L,4L,5L,6L,1L,2L,1L,1L,3L,4L,4L,6L,2L,2L,5L,6L,2L,6L,3L,3L,0L,0L,0L,2L,1L,2L,2L,4L,0L,1L,2L,4L,1L,3L,2L,2L,1L,2L,2L,4L,1L,1L,4L,6L,3L,3L,4L,4L,5L,7L,6L,7L,1L,2L,2L,2L,1L,4L,1L,2L,3L };
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
public class A175045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175045Inst : IEnumerable<long>
{
public static readonly long[] Value=A175045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175045.Bytes);
public long this[int i]=>Value[i];

public static A175045Inst Instance=new A175045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175046
{
public static readonly long[] Value={ 3L,12L,7L,24L,51L,28L,15L,48L,99L,204L,103L,56L,115L,60L,31L,96L,195L,396L,199L,408L,819L,412L,207L,112L,227L,460L,231L,120L,243L,124L,63L,192L,387L,780L,391L,792L,1587L,796L,399L,816L,1635L,3276L,1639L,824L,1651L,828L,415L,224L,451L,908L,455L,920L,1843L,924L };
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
public class A175046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175046Inst : IEnumerable<long>
{
public static readonly long[] Value=A175046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175046.Bytes);
public long this[int i]=>Value[i];

public static A175046Inst Instance=new A175046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175047
{
public static readonly long[] Value={ 1L,4L,3L,8L,9L,12L,7L,16L,17L,36L,19L,24L,25L,28L,15L,32L,33L,68L,35L,72L,73L,76L,39L,48L,49L,100L,51L,56L,57L,60L,31L,64L,65L,132L,67L,136L,137L,140L,71L,144L,145L,292L,147L,152L,153L,156L,79L,96L,97L,196L,99L,200L,201L,204L,103L,112L,113L,228L,115L,120L,121L,124L,63L,128L };
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
public class A175047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175047Inst : IEnumerable<long>
{
public static readonly long[] Value=A175047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175047.Bytes);
public long this[int i]=>Value[i];

public static A175047Inst Instance=new A175047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175048
{
public static readonly long[] Value={ 3L,6L,7L,12L,27L,14L,15L,24L,51L,54L,55L,28L,59L,30L,31L,48L,99L,102L,103L,108L,219L,110L,111L,56L,115L,118L,119L,60L,123L,62L,63L,96L,195L,198L,199L,204L,411L,206L,207L,216L,435L,438L,439L,220L,443L,222L,223L,112L,227L,230L,231L,236L,475L,238L,239L,120L,243L,246L };
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
public class A175048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175048Inst : IEnumerable<long>
{
public static readonly long[] Value=A175048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175048.Bytes);
public long this[int i]=>Value[i];

public static A175048Inst Instance=new A175048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175049
{
public static readonly BigInteger[] Value={ 0L,69L,73140L,77528331L,82179957720L,87110677654869L,92337236134203420L,BigInteger.Parse("97877383191577970331"),BigInteger.Parse("103749933845836514347440"),BigInteger.Parse("109974831999203513630316069"),BigInteger.Parse("116573218169221878611620685700") };
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
public class A175049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175049Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175049.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175049.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175049Inst Instance=new A175049Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175050
{
public static readonly long[] Value={ 1L,8L,27L,36L,100L,125L,128L,196L,216L,225L,256L,343L,441L,484L,676L,900L,1000L,1089L,1156L,1225L,1296L,1331L,1444L,1521L,1764L,2116L,2187L,2197L,2304L,2601L,2744L,3025L,3249L,3364L,3375L,3844L,4225L,4356L,4761L,4900L,4913L,5476L,5929L,6084L,6400L,6561L };
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
public class A175050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175050Inst : IEnumerable<long>
{
public static readonly long[] Value=A175050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175050.Bytes);
public long this[int i]=>Value[i];

public static A175050Inst Instance=new A175050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175051
{
public static readonly long[] Value={ 1L,4L,4L,9L,9L,4L,8L,9L,16L,9L,9L,4L,9L,9L,9L,27L,16L,9L,9L,9L,25L,4L,9L,9L,27L,9L,8L,4L,27L,9L,16L,9L,9L,9L,16L,9L,9L,27L,9L,27L,4L,9L,9L,27L,27L,9L,9L,4L,9L,9L,9L,36L,9L,9L,9L,9L,16L,25L,27L,16L,27L,9L,27L,4L,9L,27L,27L,9L,9L,9L,9L,9L,9L,27L,16L,9L,9L,27L,9L,9L,9L,9L,9L,27L,9L,4L,9L,9L,9L,27L,64L,27L };
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
public class A175051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175051Inst : IEnumerable<long>
{
public static readonly long[] Value=A175051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175051.Bytes);
public long this[int i]=>Value[i];

public static A175051Inst Instance=new A175051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175052
{
public static readonly long[] Value={ 4L,25L,32L,121L,128L,196L,225L,343L,484L,1000L,1331L,1728L,2048L,2187L,2197L,2704L,3025L,3375L,4913L,5776L,6859L,7744L,8000L,8100L,9261L,10648L,12167L,13824L,16641L,17424L,19683L,21904L,24389L,26896L,29791L,32768L,35721L,39204L,42849L,50625L };
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
public class A175052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175052Inst : IEnumerable<long>
{
public static readonly long[] Value=A175052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175052.Bytes);
public long this[int i]=>Value[i];

public static A175052Inst Instance=new A175052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175053
{
public static readonly long[] Value={ 1L,8L,9L,16L,27L,36L,49L,64L,81L,100L,125L,144L,169L,216L,243L,256L,289L,324L,361L,400L,441L,512L,529L,576L,625L,676L,729L,784L,841L,900L,961L,1024L,1089L,1156L,1225L,1296L,1369L,1444L,1521L,1600L,1681L,1764L,1849L,1936L,2025L,2116L,2209L,2304L,2401L,2500L };
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
public class A175053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175053Inst : IEnumerable<long>
{
public static readonly long[] Value=A175053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175053.Bytes);
public long this[int i]=>Value[i];

public static A175053Inst Instance=new A175053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175054
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,9L,12L,15L,16L,17L,19L,24L,25L,28L,31L,32L,33L,35L,36L,39L,48L,49L,51L,56L,57L,60L,63L,64L,65L,67L,68L,71L,72L,73L,76L,79L,96L,97L,99L,100L,103L,112L,113L,115L,120L,121L,124L,127L,128L,129L,131L,132L,135L,136L,137L,140L,143L,144L,145L,147L,152L,153L,156L };
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
public class A175054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175054Inst : IEnumerable<long>
{
public static readonly long[] Value=A175054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175054.Bytes);
public long this[int i]=>Value[i];

public static A175054Inst Instance=new A175054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175055
{
public static readonly long[] Value={ 1L,3L,2L,7L,4L,6L,15L,8L,5L,12L,14L,31L,16L,9L,11L,24L,13L,28L,30L,63L,32L,17L,19L,10L,23L,48L,25L,27L,56L,29L,60L,62L,127L,64L,33L,35L,18L,39L,20L,22L,47L,96L,49L,51L,26L,55L,112L,57L,59L,120L,61L,124L,126L,255L,128L,65L,67L,34L,71L,36L,38L,79L,40L,21L,44L,46L,95L,192L,97L,99L };
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
public class A175055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175055Inst : IEnumerable<long>
{
public static readonly long[] Value=A175055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175055.Bytes);
public long this[int i]=>Value[i];

public static A175055Inst Instance=new A175055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175056
{
public static readonly long[] Value={ 1L,3L,2L,5L,9L,6L,4L,8L,14L,24L,15L,10L,17L,11L,7L,13L,22L,37L,23L,39L,64L,40L,25L,16L,27L,45L,28L,18L,30L,19L,12L,21L,35L,58L,36L,60L,98L,61L,38L,63L,103L,168L,104L,65L,106L,66L,41L,26L,43L,71L,44L,73L,119L,74L,46L,29L,48L,79L,49L,31L,51L,32L,20L,34L,56L,92L,57L,94L,153L,95L,59L };
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
public class A175056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175056Inst : IEnumerable<long>
{
public static readonly long[] Value=A175056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175056.Bytes);
public long this[int i]=>Value[i];

public static A175056Inst Instance=new A175056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175057
{
public static readonly long[] Value={ 1L,3L,2L,7L,4L,5L,6L,15L,8L,9L,11L,12L,13L,14L,31L,16L,17L,19L,10L,23L,24L,25L,27L,28L,29L,30L,63L,32L,33L,35L,18L,39L,20L,21L,22L,47L,48L,49L,51L,26L,55L,56L,57L,59L,60L,61L,62L,127L,64L,65L,67L,34L,71L,36L,37L,38L,79L,40L,41L,43L,44L,45L,46L,95L,96L,97L,99L,50L,103L,52L,53L,54L };
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
public class A175057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175057Inst : IEnumerable<long>
{
public static readonly long[] Value=A175057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175057.Bytes);
public long this[int i]=>Value[i];

public static A175057Inst Instance=new A175057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175058
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,7L,4L,9L,10L,19L,11L,12L,13L,14L,8L,16L,17L,31L,18L,33L,34L,35L,20L,21L,22L,40L,23L,24L,25L,26L,15L,28L,29L,52L,30L,54L,55L,56L,32L,58L,59L,105L,60L,61L,62L,63L,36L,37L,38L,68L,39L,70L,71L,72L,41L,42L,43L,77L,44L,45L,46L,47L,27L,49L,50L,89L,51L,91L,92L,93L,53L,95L };
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
public class A175058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175058Inst : IEnumerable<long>
{
public static readonly long[] Value=A175058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175058.Bytes);
public long this[int i]=>Value[i];

public static A175058Inst Instance=new A175058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175059
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,5L,12L,14L,15L,16L,9L,10L,11L,24L,13L,28L,30L,31L,32L,17L,18L,19L,20L,22L,23L,48L,25L,26L,27L,56L,29L,60L,62L,63L,64L,33L,34L,35L,36L,38L,39L,40L,21L,44L,46L,47L,96L,49L,50L,51L,52L,54L,55L,112L,57L,58L,59L,120L,61L,124L,126L,127L,128L,65L,66L,67L,68L,70L };
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
public class A175059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175059Inst : IEnumerable<long>
{
public static readonly long[] Value=A175059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175059.Bytes);
public long this[int i]=>Value[i];

public static A175059Inst Instance=new A175059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175060
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,5L,6L,7L,13L,14L,15L,9L,17L,10L,11L,12L,22L,23L,24L,25L,45L,26L,27L,16L,29L,30L,31L,18L,33L,19L,20L,21L,38L,39L,40L,41L,73L,42L,43L,44L,78L,79L,80L,46L,82L,47L,48L,28L,50L,51L,52L,53L,94L,54L,55L,32L,57L,58L,59L,34L,61L,35L,36L,37L,66L,67L,68L,69L,122L,70L,71L,72L };
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
public class A175060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175060Inst : IEnumerable<long>
{
public static readonly long[] Value=A175060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175060.Bytes);
public long this[int i]=>Value[i];

public static A175060Inst Instance=new A175060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175061
{
public static readonly long[] Value={ 1L,4L,6L,35L,39L,49L,55L,57L,59L,536L,540L,560L,572L,624L,632L,776L,782L,784L,798L,880L,888L,900L,902L,912L,926L,944L,956L,964L,966L,968L,974L,984L,988L,16775L,16783L,16835L,16847L,16867L,16871L,17159L,17183L,17283L,17311L,17379L,17383L,17935L,17951L };
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
public class A175061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175061Inst : IEnumerable<long>
{
public static readonly long[] Value=A175061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175061.Bytes);
public long this[int i]=>Value[i];

public static A175061Inst Instance=new A175061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175062
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,3L,2L,1L,2L,3L,2L,3L,1L,2L,1L,3L,3L,2L,1L,3L,1L,2L,1L,4L,2L,3L,1L,4L,3L,2L,1L,3L,2L,4L,1L,3L,4L,2L,1L,2L,3L,4L,1L,2L,4L,3L,2L,4L,1L,3L,2L,4L,3L,1L,2L,3L,1L,4L,2L,3L,4L,1L,2L,1L,3L,4L,2L,1L,4L,3L,3L,4L,1L,2L,3L,4L,2L,1L,3L,2L,1L,4L,3L,2L,4L,1L,3L,1L,2L,4L,3L,1L,4L,2L,4L,3L,1L,2L,4L,3L,2L,1L,4L,2L };
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
public class A175062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175062Inst : IEnumerable<long>
{
public static readonly long[] Value=A175062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175062.Bytes);
public long this[int i]=>Value[i];

public static A175062Inst Instance=new A175062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175063
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,43L,61L,71L,73L,79L,101L,107L,109L,127L,131L,137L,139L,149L,151L,167L,191L,193L,239L,263L,269L,283L,311L,347L,373L,379L,389L,401L,433L,439L,443L,461L,479L,499L,541L,587L,641L,643L,659L,701L,719L,733L,773L,797L,821L,883L,887L,907L,919L };
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
public class A175063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175063Inst : IEnumerable<long>
{
public static readonly long[] Value=A175063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175063.Bytes);
public long this[int i]=>Value[i];

public static A175063Inst Instance=new A175063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175064
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,2L,2L,2L,2L,4L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,4L,2L,2L,2L,2L,2L,4L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L };
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
public class A175064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175064Inst : IEnumerable<long>
{
public static readonly long[] Value=A175064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175064.Bytes);
public long this[int i]=>Value[i];

public static A175064Inst Instance=new A175064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175065
{
public static readonly BigInteger[] Value={ 4L,16L,64L,65536L,4096L,BigInteger.Parse("18446744073709551616"),16777216L,68719476736L,281474976710656L };
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
public class A175065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175065Inst Instance=new A175065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175066
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,2L,2L,3L,3L,2L,2L,5L,3L,2L,2L,3L,3L,2L,2L,2L,3L,2L,3L,2L,3L,4L,2L,2L,3L,2L,2L,2L,2L,5L,2L,2L,3L,2L,5L,2L,2L,2L,2L,3L,5L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,3L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,7L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L };
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
public class A175066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175066Inst : IEnumerable<long>
{
public static readonly long[] Value=A175066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175066.Bytes);
public long this[int i]=>Value[i];

public static A175066Inst Instance=new A175066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175067
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,6L,7L,10L,12L,10L,11L,12L,13L,14L,15L,22L,17L,18L,19L,20L,21L,22L,23L,24L,30L,26L,30L,28L,29L,30L,31L,34L,33L,34L,35L,42L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,56L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,78L,65L,66L,67L,68L,69L,70L,71L,72L };
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
public class A175067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175067Inst : IEnumerable<long>
{
public static readonly long[] Value=A175067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175067.Bytes);
public long this[int i]=>Value[i];

public static A175067Inst Instance=new A175067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175068
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,6L,7L,16L,27L,10L,11L,12L,13L,14L,15L,128L,17L,18L,19L,20L,21L,22L,23L,24L,125L,26L,81L,28L,29L,30L,31L,64L,33L,34L,35L,216L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,343L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,4096L,65L,66L,67L,68L,69L,70L };
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
public class A175068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175068Inst : IEnumerable<long>
{
public static readonly long[] Value=A175068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175068.Bytes);
public long this[int i]=>Value[i];

public static A175068Inst Instance=new A175068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175069
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,64L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,27L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L };
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
public class A175069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175069Inst : IEnumerable<long>
{
public static readonly long[] Value=A175069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175069.Bytes);
public long this[int i]=>Value[i];

public static A175069Inst Instance=new A175069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175070
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,2L,3L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,3L,0L,0L,0L,0L,2L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,14L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L };
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
public class A175070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175070Inst : IEnumerable<long>
{
public static readonly long[] Value=A175070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175070.Bytes);
public long this[int i]=>Value[i];

public static A175070Inst Instance=new A175070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175071
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,11L,12L,14L,16L,17L,18L,20L,22L,23L,24L,26L,27L,29L,30L,32L,34L,35L,37L,38L,40L,41L,42L,44L,46L,47L,48L,50L,51L,53L,54L,56L,57L,59L,60L,62L,64L,65L,67L,68L,70L,71L,72L,74L,76L,77L,79L,80L,82L,83L,84L,86L,87L,89L,90L,92L,93L,95L,97L,98L,100L,101L,102L };
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
public class A175071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175071Inst : IEnumerable<long>
{
public static readonly long[] Value=A175071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175071.Bytes);
public long this[int i]=>Value[i];

public static A175071Inst Instance=new A175071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175072
{
public static readonly long[] Value={ 2L,5L,7L,9L,13L,15L,19L,21L,25L,28L,31L,33L,36L,39L,43L,45L,49L,52L,55L,58L,61L,63L,66L,69L,73L,75L,78L,81L,85L,88L,91L,94L,96L,99L,103L,105L,109L,111L,115L,118L,120L,122L,126L,129L,133L,136L,139L,141L,144L,146L,148L,151L };
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
public class A175072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175072Inst : IEnumerable<long>
{
public static readonly long[] Value=A175072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175072.Bytes);
public long this[int i]=>Value[i];

public static A175072Inst Instance=new A175072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175073
{
public static readonly long[] Value={ 3L,11L,17L,23L,29L,37L,41L,47L,53L,59L,67L,71L,79L,83L,89L,97L,101L,107L,113L,127L,131L,137L,149L,157L,163L,167L,173L,179L,191L,197L,211L,223L,227L,233L,239L,251L,257L,263L,269L,277L,281L,293L,307L };
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
public class A175073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175073Inst : IEnumerable<long>
{
public static readonly long[] Value=A175073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175073.Bytes);
public long this[int i]=>Value[i];

public static A175073Inst Instance=new A175073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175074
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,27L,30L,32L,34L,35L,38L,40L,42L,44L,46L,48L,50L,51L,54L,56L,57L,60L,62L,64L,65L,68L,70L,72L,74L,76L,77L,80L,82L,84L,86L,87L,90L,92L,93L,95L,98L,100L,102L };
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
public class A175074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175074Inst : IEnumerable<long>
{
public static readonly long[] Value=A175074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175074.Bytes);
public long this[int i]=>Value[i];

public static A175074Inst Instance=new A175074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175075
{
public static readonly long[] Value={ 2L,5L,7L,13L,19L,31L,43L,61L,73L,103L,109L,139L,151L,181L,193L,199L,229L,241L,271L,283L,313L,349L,421L,433L,463L,523L,571L,601L,619L,643L,661L,811L,823L,829L,859L,883L,1021L,1033L,1051L,1063L,1093L,1153L,1231L,1279L,1291L,1303L,1321L,1429L,1453L,1483L,1489L };
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
public class A175075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175075Inst : IEnumerable<long>
{
public static readonly long[] Value=A175075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175075.Bytes);
public long this[int i]=>Value[i];

public static A175075Inst Instance=new A175075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175076
{
public static readonly long[] Value={ 9L,15L,21L,25L,28L,33L,36L,39L,45L,49L,52L,55L,58L,63L,66L,69L,75L,78L,81L,85L,88L,91L,94L,96L,99L,105L,111L,115L,118L,120L,122L,126L,129L,133L,136L,141L,144L,146L,148L,153L,156L,159L,162L,165L,169L,172L,175L,178L,183L,186L,188L,190L,195L,201L,204L,206L,208L,213L,216L };
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
public class A175076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175076Inst : IEnumerable<long>
{
public static readonly long[] Value=A175076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175076.Bytes);
public long this[int i]=>Value[i];

public static A175076Inst Instance=new A175076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175077
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L };
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
public class A175077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175077Inst : IEnumerable<long>
{
public static readonly long[] Value=A175077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175077.Bytes);
public long this[int i]=>Value[i];

public static A175077Inst Instance=new A175077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175078
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L };
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
public class A175078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175078Inst : IEnumerable<long>
{
public static readonly long[] Value=A175078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175078.Bytes);
public long this[int i]=>Value[i];

public static A175078Inst Instance=new A175078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175079
{
public static readonly long[] Value={ 1L,3L,10L,123L,1357324L };
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
public class A175079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175079Inst : IEnumerable<long>
{
public static readonly long[] Value=A175079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175079.Bytes);
public long this[int i]=>Value[i];

public static A175079Inst Instance=new A175079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175080
{
public static readonly long[] Value={ 2L,2999L,3299L,5147L,5981L,8999L,9587L,10037L,10427L,10559L,10937L,11579L,12889L,13367L,14143L,14591L,14621L,15859L,16301L,16871L,18041L,18839L,18947L,19661L,21059L,21557L,22229L,22343L,22853L,23399L,23957L,24317L,24659L,25523L,27179L };
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
public class A175080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175080Inst : IEnumerable<long>
{
public static readonly long[] Value=A175080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175080.Bytes);
public long this[int i]=>Value[i];

public static A175080Inst Instance=new A175080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175081
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,6L,7L,10L,10L,11L,12L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,22L,23L,24L,26L,28L,29L,30L,30L,30L,31L,33L,34L,34L,35L,37L,38L,39L,40L,41L,42L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L };
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
public class A175081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175081Inst : IEnumerable<long>
{
public static readonly long[] Value=A175081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175081.Bytes);
public long this[int i]=>Value[i];

public static A175081Inst Instance=new A175081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175082
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
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
public class A175082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175082Inst : IEnumerable<long>
{
public static readonly long[] Value=A175082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175082.Bytes);
public long this[int i]=>Value[i];

public static A175082Inst Instance=new A175082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175083
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,0L,0L,2L,1L,2L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,0L,1L,0L,1L,1L,3L,1L,0L,1L,2L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,0L,1L };
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
public class A175083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175083Inst : IEnumerable<long>
{
public static readonly long[] Value=A175083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175083.Bytes);
public long this[int i]=>Value[i];

public static A175083Inst Instance=new A175083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175084
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L };
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
public class A175084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175084Inst : IEnumerable<long>
{
public static readonly long[] Value=A175084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175084.Bytes);
public long this[int i]=>Value[i];

public static A175084Inst Instance=new A175084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175085
{
public static readonly long[] Value={ 4L,9L,25L,32L,36L,49L,100L,121L,144L,169L,196L,225L,243L,289L,324L,361L,400L,441L,484L,512L,529L,576L,676L,784L,841L,900L,961L };
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
public class A175085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175085Inst : IEnumerable<long>
{
public static readonly long[] Value=A175085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175085.Bytes);
public long this[int i]=>Value[i];

public static A175085Inst Instance=new A175085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175086
{
public static readonly long[] Value={ 1L,8L,16L,27L,64L,81L,125L,128L,216L,256L,343L,625L,729L };
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
public class A175086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175086Inst : IEnumerable<long>
{
public static readonly long[] Value=A175086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175086.Bytes);
public long this[int i]=>Value[i];

public static A175086Inst Instance=new A175086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175087
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L };
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
public class A175087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175087Inst : IEnumerable<long>
{
public static readonly long[] Value=A175087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175087.Bytes);
public long this[int i]=>Value[i];

public static A175087Inst Instance=new A175087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175088
{
public static readonly long[] Value={ 1L,4L,6L,8L,12L,14L,18L,20L,24L,27L,30L,32L,35L,38L,42L,44L,48L,51L,54L,57L,60L,62L,65L,68L,72L,74L,77L,80L,84L,87L,90L,93L,95L,98L,102L,104L,108L,110L,114L,117L,119L,121L,125L,128L,132L,135L,138L,140L,143L,145L,147L,150L,152L,155L,158L,161L,164L,168L,171L };
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
public class A175088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175088Inst : IEnumerable<long>
{
public static readonly long[] Value=A175088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175088.Bytes);
public long this[int i]=>Value[i];

public static A175088Inst Instance=new A175088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175089
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,10L,11L,13L,15L,16L,17L,19L,21L,22L,23L,25L,26L,28L,29L,31L,33L,34L,36L,37L,39L,40L,41L,43L,45L,46L,47L,49L,50L,52L,53L,55L,56L,58L,59L,61L,63L,64L,66L,67L,69L,70L,71L,73L,75L,76L,78L,79L,81L,82L,83L,85L,86L,88L,89L,91L,92L,94L,96L,97L,99L,100L };
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
public class A175089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175089Inst : IEnumerable<long>
{
public static readonly long[] Value=A175089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175089.Bytes);
public long this[int i]=>Value[i];

public static A175089Inst Instance=new A175089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175090
{
public static readonly long[] Value={ 9L,10L,15L,16L,21L,22L,25L,26L,28L,33L,34L,36L,39L,40L,45L,46L,49L,50L,52L,55L,56L,58L,63L,64L,66L,69L,70L,75L,76L,78L,81L,82L,85L,86L,88L,91L,92L,94L,96L,99L,100L,105L,106L,111L,112L,115L,116L,118L,120L,122L,123L,124L,126L,129L,130L,133L,134L,136L,141L,142L };
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
public class A175090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175090Inst : IEnumerable<long>
{
public static readonly long[] Value=A175090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175090.Bytes);
public long this[int i]=>Value[i];

public static A175090Inst Instance=new A175090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175091
{
public static readonly long[] Value={ 4L,7L,13L,15L,21L,22L,23L,24L,40L,49L,50L,51L,52L,53L,54L,57L,64L,65L,66L,67L,68L,73L,74L,79L,80L,94L,95L,96L,99L,100L,101L,102L,111L,112L,122L,123L,124L,127L,134L,135L,136L,137L,138L,145L,146L,147L,148L,149L,150L,159L,160L,172L,173L,174L,177L,178L,179L,180L,181L,182L };
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
public class A175091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175091Inst : IEnumerable<long>
{
public static readonly long[] Value=A175091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175091.Bytes);
public long this[int i]=>Value[i];

public static A175091Inst Instance=new A175091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175092
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,13L,17L,20L,26L,28L,33L,35L,41L,43L,45L,52L,57L,60L,69L,83L,89L,98L,104L,109L,113L,116L,120L,140L,142L };
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
public class A175092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175092Inst : IEnumerable<long>
{
public static readonly long[] Value=A175092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175092.Bytes);
public long this[int i]=>Value[i];

public static A175092Inst Instance=new A175092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175093
{
public static readonly long[] Value={ 1L,2L,3L,5L,13L,31L,137L,853L,6961L,28697L,179143L,6836131L,68540453L,966402473L,15530980021L };
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
public class A175093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175093Inst : IEnumerable<long>
{
public static readonly long[] Value=A175093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175093.Bytes);
public long this[int i]=>Value[i];

public static A175093Inst Instance=new A175093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175094
{
public static readonly long[] Value={ 1L,3L,7L,17L,41L,181L,1489L,18049L,218077L,1326511L,69196649L,3045979067L,67080736123L };
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
public class A175094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175094Inst : IEnumerable<long>
{
public static readonly long[] Value=A175094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175094.Bytes);
public long this[int i]=>Value[i];

public static A175094Inst Instance=new A175094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175095
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,9L,14L,15L,17L,21L,27L,30L,33L,35L,45L,51L,62L,63L,65L,75L,93L,99L,119L,126L,129L,135L,155L,189L,195L,231L,254L,255L,257L,279L,315L,381L,387L,455L,495L,510L,513L,527L,567L,635L,765L,771L,903L,975L,1022L,1023L,1025L,1071L,1143L,1275L,1533L,1539L };
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
public class A175095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175095Inst : IEnumerable<long>
{
public static readonly long[] Value=A175095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175095.Bytes);
public long this[int i]=>Value[i];

public static A175095Inst Instance=new A175095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175096
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,4L,2L,4L,1L,4L,2L,2L,2L,4L,1L,2L,2L,2L,1L,2L,1L,4L,2L,2L,2L,8L,2L,4L,2L,2L,3L,8L,3L,4L,2L,2L,2L,8L,1L,8L,3L,2L,2L,2L,2L,4L,2L,2L,2L,2L,1L,2L,1L,4L,2L,4L,2L,8L,2L,4L,1L,6L,6L,4L,6L,8L,2L,4L,2L,6L,6L,6L,1L,6L,3L,8L,6L,6L,3L,8L,3L,4L,2L,2L,2L,8L,1L,4L,6L,4L,2L,8L,6L };
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
public class A175096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175096Inst : IEnumerable<long>
{
public static readonly long[] Value=A175096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175096.Bytes);
public long this[int i]=>Value[i];

public static A175096Inst Instance=new A175096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175097
{
public static readonly long[] Value={ 3L,5L,31L,61L,163L,193L,227L,383L,401L,521L,631L,653L,883L,1019L,1151L,1229L,1433L,1601L,1669L,1801L,1873L,2437L,2729L,3191L,3671L,4013L,4049L,4127L,4447L,5507L,5651L,5701L,5813L,6079L,6199L,6353L,6569L,6823L,6857L,7507L,7529L,7873L,7907L,8291L,8419L,8461L };
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
public class A175097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175097Inst : IEnumerable<long>
{
public static readonly long[] Value=A175097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175097.Bytes);
public long this[int i]=>Value[i];

public static A175097Inst Instance=new A175097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175098
{
public static readonly long[] Value={ 0L,3L,5L,9L,12L,16L,20L,26L,31L,35L,39L,45L,51L,59L,67L,79L,88L,92L,96L,102L,108L,116L,124L,136L,146L,154L,162L,174L,186L,202L,218L,242L,259L,263L,267L,273L,279L,287L,295L,307L,317L,325L,333L,345L,357L,373L,389L,413L,431L,439L,447L,459L,471L,487L,503L,527L,547L };
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
public class A175098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175098Inst : IEnumerable<long>
{
public static readonly long[] Value=A175098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175098.Bytes);
public long this[int i]=>Value[i];

public static A175098Inst Instance=new A175098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175099
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,2L,3L,0L,0L,2L,2L,0L,0L,4L,7L,0L,0L,2L,2L,0L,0L,4L,6L,0L,0L,4L,4L,0L,0L,8L,15L,0L,0L,2L,2L,0L,0L,4L,6L,0L,0L,4L,4L,0L,0L,8L,14L,0L,0L,4L,4L,0L,0L,8L,12L,0L,0L,8L,8L,0L,0L,16L,31L,0L,0L,2L,2L,0L,0L,4L,6L,0L,0L,4L,4L,0L,0L,8L,14L,0L,0L,4L,4L,0L,0L,8L,12L,0L,0L,8L,8L,0L,0L,16L,30L,0L,0L,4L,4L,0L };
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
public class A175099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175099Inst : IEnumerable<long>
{
public static readonly long[] Value=A175099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175099.Bytes);
public long this[int i]=>Value[i];

public static A175099Inst Instance=new A175099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175100
{
public static readonly long[] Value={ 5L,7L,11L,13L,16L,22L,23L,35L,35L,35L,36L,43L,43L };
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
public class A175100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175100Inst : IEnumerable<long>
{
public static readonly long[] Value=A175100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175100.Bytes);
public long this[int i]=>Value[i];

public static A175100Inst Instance=new A175100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175101
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,2L,2L,14L,2L,2L,14L,2L,34L,2L,2L,2L,2L,2L,2L,2L,34L,2L,2L,14L,2L,2L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,34L,2L,14L,2L,2L,34L,2L,2L,34L,14L,2L,2L,2L,2L,2L,34L,2L,14L,2L,2L,2L,2L,2L,2L,2L,2L,98L,2L,14L,2L,14L,2L,2L,2L,2L,34L,2L,2L,2L,2L,2L,34L,2L,14L,2L,98L,2L,34L,2L,2L,142L,14L,2L,14L,2L };
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
public class A175101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175101Inst : IEnumerable<long>
{
public static readonly long[] Value=A175101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175101.Bytes);
public long this[int i]=>Value[i];

public static A175101Inst Instance=new A175101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175102
{
public static readonly long[] Value={ 1L,60L,64L,41192L,41194L,41247L,41250L,41252L,41257L,41259L,41261L,41263L,41265L,41267L,41273L,41275L,41277L,41279L,41287L,41317L,41319L,41321L,41323L,41325L,41327L,41328L,41329L,41335L,41336L,41338L,41339L,41341L,41389L,41393L,41397L,41399L,41401L,41404L,41406L,41408L,41412L,41444L,41448L,42112L };
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
public class A175102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175102Inst : IEnumerable<long>
{
public static readonly long[] Value=A175102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175102.Bytes);
public long this[int i]=>Value[i];

public static A175102Inst Instance=new A175102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175103
{
public static readonly long[] Value={ 0L,42L,53L,117L,154L,2377L,3245L,3771L,6381L,9688L,10406L,13879L,13944L,14056L,15026L,18884L,26521L,29565L,30735L,36362L,39310L,43337L,48808L,54415L,58308L,62228L,63378L,69111L,77403L,81750L,86021L,93545L,94388L,103961L,119754L,152555L,162698L };
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
public class A175103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175103Inst : IEnumerable<long>
{
public static readonly long[] Value=A175103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175103.Bytes);
public long this[int i]=>Value[i];

public static A175103Inst Instance=new A175103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175104
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,43L,89L,181L,365L,734L,1473L,2952L,5911L,11830L,23669L,47347L,94704L,189419L,378850L,757713L,1515440L,3030895L,6061806L,12123629L,24247276L,48494571L,96989162L,193978345L,387956712L,775913447L,1551826917L,3103653858L };
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
public class A175104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175104Inst : IEnumerable<long>
{
public static readonly long[] Value=A175104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175104.Bytes);
public long this[int i]=>Value[i];

public static A175104Inst Instance=new A175104Inst();

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