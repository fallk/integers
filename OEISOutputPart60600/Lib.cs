using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A073102
{
public static readonly long[] Value={ 211L,421L,631L,1051L,1471L,2311L,2521L,2731L,3361L,3571L,4201L,4621L,4831L,5881L,6091L,6301L,7351L,7561L,8191L,8821L,9241L,9661L,9871L,10501L,10711L,11131L,11551L,11971L,12391L,12601L,13441L,14071L,14281L,15121L,15331L,15541L,16381L,17011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073102Inst : IEnumerable<long>
{
public static readonly long[] Value=A073102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073102.Bytes);
public long this[int i]=>Value[i];

public static A073102Inst Instance=new A073102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073103
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,2L,4L,2L,4L,2L,4L,4L,2L,8L,8L,4L,2L,2L,8L,4L,2L,2L,8L,4L,4L,2L,4L,4L,8L,2L,8L,4L,4L,8L,4L,4L,2L,8L,16L,4L,4L,2L,4L,8L,2L,2L,16L,2L,4L,8L,8L,4L,2L,8L,8L,4L,4L,2L,16L,4L,2L,4L,8L,16L,4L,2L,8L,4L,8L,2L,8L,4L,4L,8L,4L,4L,8L,2L,32L,2L,4L,2L,8L,16L,2L,8L,8L,4L,8L,8L,4L,4L,2L,8L,16L,4L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073103Inst : IEnumerable<long>
{
public static readonly long[] Value=A073103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073103.Bytes);
public long this[int i]=>Value[i];

public static A073103Inst Instance=new A073103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073104
{
public static readonly long[] Value={ 1523L,1447L,1373L,1301L,1231L,1163L,1097L,1033L,971L,911L,853L,797L,743L,691L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073104Inst : IEnumerable<long>
{
public static readonly long[] Value=A073104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073104.Bytes);
public long this[int i]=>Value[i];

public static A073104Inst Instance=new A073104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073105
{
public static readonly long[] Value={ 1L,3L,9L,12L,14L,12L,26L,46L,38L,49L,59L,46L,90L,73L,141L,117L,114L,127L,179L,151L,131L,238L,305L,250L,245L,258L,290L,468L,384L,345L,497L,403L,495L,502L,564L,543L,576L,624L,575L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073105Inst : IEnumerable<long>
{
public static readonly long[] Value=A073105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073105.Bytes);
public long this[int i]=>Value[i];

public static A073105Inst Instance=new A073105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073106
{
public static readonly long[] Value={ 1L,3L,3L,11L,7L,9L,15L,22L,15L,26L,30L,28L,36L,39L,23L,53L,45L,45L,62L,61L,41L,77L,72L,66L,74L,94L,59L,93L,120L,71L,116L,124L,75L,122L,100L,104L,144L,192L,101L,155L,166L,109L,176L,189L,101L,198L,192L,140L,186L,174L,129L,242L,250L,162L,180L,231L,159L,228L,276L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073106Inst : IEnumerable<long>
{
public static readonly long[] Value=A073106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073106.Bytes);
public long this[int i]=>Value[i];

public static A073106Inst Instance=new A073106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073107
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,16L,15L,6L,1L,65L,64L,30L,8L,1L,326L,325L,160L,50L,10L,1L,1957L,1956L,975L,320L,75L,12L,1L,13700L,13699L,6846L,2275L,560L,105L,14L,1L,109601L,109600L,54796L,18256L,4550L,896L,140L,16L,1L,986410L,986409L,493200L,164388L,41076L,8190L,1344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073107Inst : IEnumerable<long>
{
public static readonly long[] Value=A073107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073107.Bytes);
public long this[int i]=>Value[i];

public static A073107Inst Instance=new A073107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073108
{
public static readonly long[] Value={ 1L,3L,10L,11L,16L,29L,38L,35L,64L,29L,54L,107L,58L,69L,92L,85L,82L,163L,124L,81L,190L,155L,142L,241L,116L,139L,338L,213L,176L,221L,214L,223L,520L,211L,184L,361L,278L,267L,400L,179L,294L,607L,288L,335L,362L,379L,342L,587L,394L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073108Inst : IEnumerable<long>
{
public static readonly long[] Value=A073108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073108.Bytes);
public long this[int i]=>Value[i];

public static A073108Inst Instance=new A073108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073109
{
public static readonly BigInteger[] Value={ 0L,0L,-7L,-35L,295L,2065L,-42980L,-42980L,1426670L,15693370L,-774856236L,-10073131068L,692669409432L,692669409432L,-63315621131763L,-1076365559239971L,126262920264259779L,2398995485020935801L,BigInteger.Parse("-351338708777824396629"),BigInteger.Parse("-351338708777824396629") };
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
public class A073109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073109Inst Instance=new A073109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073110
{
public static readonly long[] Value={ 0L,1L,0L,2L,10L,37L,121L,725L,5160L,31794L,279136L,2137531L,21305316L,213311303L,2457648287L,30357607661L,387013387043L,5245097770693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073110Inst : IEnumerable<long>
{
public static readonly long[] Value=A073110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073110.Bytes);
public long this[int i]=>Value[i];

public static A073110Inst Instance=new A073110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073111
{
public static readonly long[] Value={ 0L,2L,0L,0L,35L,211L,0L,0L,56204L,337661L,0L,0L,454113487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073111Inst : IEnumerable<long>
{
public static readonly long[] Value=A073111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073111.Bytes);
public long this[int i]=>Value[i];

public static A073111Inst Instance=new A073111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073112
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,7L,6L,30L,110L,278L,1332L,3312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073112Inst : IEnumerable<long>
{
public static readonly long[] Value=A073112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073112.Bytes);
public long this[int i]=>Value[i];

public static A073112Inst Instance=new A073112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073113
{
public static readonly BigInteger[] Value={ 2L,8L,64L,2048L,1048576L,137438953472L,BigInteger.Parse("1180591620717411303424"),BigInteger.Parse("43556142965880123323311949751266331066368") };
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
public class A073113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073113Inst Instance=new A073113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073114
{
public static readonly long[] Value={ 0L,1L,4L,7L,22L,160L,938L,7261L,67492L,572848L,6774544L,71929775L,985400749L,12521202682L,188765264950L,2889019817104L,47703971114988L,877662524710517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073114Inst : IEnumerable<long>
{
public static readonly long[] Value=A073114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073114.Bytes);
public long this[int i]=>Value[i];

public static A073114Inst Instance=new A073114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073115
{
public static readonly long[] Value={ 1L,7L,0L,9L,8L,0L,3L,4L,4L,2L,8L,6L,1L,2L,9L,1L,3L,1L,4L,6L,4L,1L,7L,8L,7L,3L,9L,9L,4L,4L,4L,5L,7L,5L,5L,9L,7L,0L,1L,2L,5L,0L,2L,2L,0L,5L,7L,6L,7L,8L,6L,0L,5L,1L,6L,9L,5L,7L,0L,0L,2L,6L,4L,4L,6L,5L,1L,2L,8L,7L,1L,2L,8L,1L,4L,8L,4L,6L,5L,9L,6L,2L,4L,7L,8L,3L,1L,6L,1L,3L,2L,4L,5L,9L,9L,9L,3L,8L,8L,3L,9L,2L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073115Inst : IEnumerable<long>
{
public static readonly long[] Value=A073115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073115.Bytes);
public long this[int i]=>Value[i];

public static A073115Inst Instance=new A073115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073116
{
public static readonly BigInteger[] Value={ 0L,1L,5L,1L,8L,4L,64L,128L,16384L,1048576L,34359738368L,18014398509481984L,BigInteger.Parse("1237940039285380274899124224") };
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
public class A073116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073116Inst Instance=new A073116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073117
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,8L,10L,13L,18L,18L,26L,30L,36L,46L,50L,55L,62L,73L,74L,91L,102L,120L,130L,145L,146L,167L,178L,194L,220L,237L,264L,280L,304L,311L,316L,317L,346L,359L,376L,401L,402L,435L,450L,470L,500L,505L,550L,583L,590L,592L,634L,656L,688L,740L,778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073117Inst : IEnumerable<long>
{
public static readonly long[] Value=A073117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073117.Bytes);
public long this[int i]=>Value[i];

public static A073117Inst Instance=new A073117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073118
{
public static readonly long[] Value={ 0L,2L,5L,9L,19L,33L,57L,87L,136L,206L,311L,446L,650L,914L,1284L,1762L,2432L,3276L,4433L,5888L,7824L,10272L,13479L,17471L,22642L,29087L,37283L,47453L,60306L,76112L,95931L,120201L,150338L,187141L,232507L,287591L,355143L,436849L,536347L,656282L,801647L,976095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073118Inst : IEnumerable<long>
{
public static readonly long[] Value=A073118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073118.Bytes);
public long this[int i]=>Value[i];

public static A073118Inst Instance=new A073118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073119
{
public static readonly long[] Value={ 0L,1L,1L,4L,5L,10L,14L,26L,35L,56L,77L,116L,157L,226L,302L,424L,560L,762L,998L,1334L,1727L,2270L,2914L,3779L,4809L,6163L,7781L,9875L,12378L,15565L,19383L,24191L,29934L,37093L,45643L,56201L,68789L,84212L,102564L,124903L,151424L,183499L,221508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073119Inst : IEnumerable<long>
{
public static readonly long[] Value=A073119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073119.Bytes);
public long this[int i]=>Value[i];

public static A073119Inst Instance=new A073119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073120
{
public static readonly long[] Value={ 6L,24L,30L,60L,84L,96L,120L,180L,210L,240L,330L,336L,384L,480L,486L,504L,546L,630L,720L,840L,924L,960L,990L,1224L,1320L,1344L,1386L,1536L,1560L,1710L,1716L,1920L,1944L,2016L,2184L,2310L,2340L,2430L,2520L,2574L,2730L,2880L,3036L,3360L,3570L,3696L,3750L,3840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073120Inst : IEnumerable<long>
{
public static readonly long[] Value=A073120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073120.Bytes);
public long this[int i]=>Value[i];

public static A073120Inst Instance=new A073120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073121
{
public static readonly long[] Value={ 1L,4L,10L,16L,28L,40L,52L,64L,88L,112L,136L,160L,184L,208L,232L,256L,304L,352L,400L,448L,496L,544L,592L,640L,688L,736L,784L,832L,880L,928L,976L,1024L,1120L,1216L,1312L,1408L,1504L,1600L,1696L,1792L,1888L,1984L,2080L,2176L,2272L,2368L,2464L,2560L,2656L,2752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073121Inst : IEnumerable<long>
{
public static readonly long[] Value=A073121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073121.Bytes);
public long this[int i]=>Value[i];

public static A073121Inst Instance=new A073121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073122
{
public static readonly long[] Value={ 1L,2L,5L,4L,13L,10L,9L,8L,25L,26L,29L,20L,21L,18L,17L,16L,49L,50L,53L,52L,61L,58L,57L,40L,41L,42L,45L,36L,37L,34L,33L,32L,97L,98L,101L,100L,109L,106L,105L,104L,121L,122L,125L,116L,117L,114L,113L,80L,81L,82L,85L,84L,93L,90L,89L,72L,73L,74L,77L,68L,69L,66L,65L,64L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073122Inst : IEnumerable<long>
{
public static readonly long[] Value=A073122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073122.Bytes);
public long this[int i]=>Value[i];

public static A073122Inst Instance=new A073122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073123
{
public static readonly long[] Value={ 4L,6L,12L,18L,36L,42L,60L,70L,88L,112L,130L,162L,180L,192L,222L,250L,280L,292L,336L,358L,372L,408L,432L,462L,520L,556L,568L,592L,600L,618L,718L,742L,786L,808L,862L,880L,928L,970L,996L,1032L,1068L,1090L,1162L,1180L,1212L,1222L,1300L,1422L,1438L,1450L,1480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073123Inst : IEnumerable<long>
{
public static readonly long[] Value=A073123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073123.Bytes);
public long this[int i]=>Value[i];

public static A073123Inst Instance=new A073123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073124
{
public static readonly long[] Value={ 2L,2L,2L,2L,6L,2L,2L,4L,6L,4L,4L,6L,2L,2L,12L,10L,4L,10L,6L,6L,6L,8L,2L,2L,12L,10L,6L,6L,2L,2L,10L,4L,14L,12L,4L,4L,10L,4L,6L,2L,6L,4L,10L,10L,12L,6L,4L,14L,6L,4L,10L,12L,8L,4L,6L,24L,10L,6L,2L,8L,14L,18L,2L,6L,2L,12L,16L,4L,6L,6L,2L,6L,26L,2L,8L,10L,4L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073124Inst : IEnumerable<long>
{
public static readonly long[] Value=A073124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073124.Bytes);
public long this[int i]=>Value[i];

public static A073124Inst Instance=new A073124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073125
{
public static readonly long[] Value={ 2L,3L,17L,5L,17L,5L,13L,29L,2L,13L,17L,11L,7L,11L,7L,7L,11L,7L,7L,67L,5L,47L,193L,43L,3L,3L,5L,53L,173L,41L,181L,31L,181L,41L,211L,31L,211L,181L,113L,29L,173L,13L,173L,19L,229L,181L,197L,17L,193L,13L,113L,17L,113L,619L,191L,13L,179L,173L,167L,743L,1499L,7L,1627L,733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073125Inst : IEnumerable<long>
{
public static readonly long[] Value=A073125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073125.Bytes);
public long this[int i]=>Value[i];

public static A073125Inst Instance=new A073125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073126
{
public static readonly long[] Value={ 3L,7L,29L,17L,37L,23L,41L,61L,29L,53L,61L,59L,59L,67L,67L,71L,79L,79L,83L,167L,89L,157L,331L,163L,103L,107L,113L,193L,347L,191L,367L,191L,379L,211L,421L,211L,433L,409L,347L,229L,419L,223L,431L,239L,499L,457L,479L,257L,487L,263L,419L,277L,431L,997L,521L,293L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073126Inst : IEnumerable<long>
{
public static readonly long[] Value=A073126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073126.Bytes);
public long this[int i]=>Value[i];

public static A073126Inst Instance=new A073126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073127
{
public static readonly long[] Value={ 1L,2L,4L,3L,4L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,4L,5L,6L,5L,4L,4L,4L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,6L,6L,5L,6L,5L,6L,5L,6L,6L,6L,5L,6L,5L,6L,5L,6L,7L,6L,5L,6L,6L,6L,7L,8L,5L,8L,7L,8L,6L,5L,6L,6L,6L,8L,7L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,8L,6L,8L,6L,8L,6L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073127Inst : IEnumerable<long>
{
public static readonly long[] Value=A073127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073127.Bytes);
public long this[int i]=>Value[i];

public static A073127Inst Instance=new A073127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073128
{
public static readonly long[] Value={ 0L,1L,1L,5L,5L,49L,118L,121L,2406L,2698L,4182L,4946L,153627L,3087192L,8203485L,38394376L,487844934L,2822741576L,4140154385L,4397137572L,8583966231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073128Inst : IEnumerable<long>
{
public static readonly long[] Value=A073128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073128.Bytes);
public long this[int i]=>Value[i];

public static A073128Inst Instance=new A073128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073129
{
public static readonly BigInteger[] Value={ 0L,4L,5L,120L,125L,12201L,70800L,74657L,29526432L,37132574L,89210424L,124777688L,120392102955L,48617257062792L,343289046464505L,7519663359716376L,1214022599940709056L,BigInteger.Parse("40644839476190305216"),BigInteger.Parse("87437200646372849005"),BigInteger.Parse("98628693371623948080"),BigInteger.Parse("375871306587181970568") };
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
public class A073129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073129Inst Instance=new A073129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073130
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,4L,2L,2L,6L,2L,2L,4L,6L,6L,2L,6L,2L,2L,2L,2L,6L,8L,2L,2L,4L,2L,2L,2L,2L,2L,2L,2L,2L,6L,6L,4L,2L,2L,2L,2L,2L,2L,2L,4L,4L,4L,2L,4L,2L,2L,2L,6L,6L,6L,2L,2L,4L,2L,2L,2L,4L,2L,2L,2L,6L,2L,2L,2L,6L,4L,6L,6L,2L,6L,4L,2L,2L,2L,2L,2L,2L,6L,2L,6L,4L,2L,2L,4L,4L,2L,4L,2L,2L,2L,12L,2L,6L,2L,2L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073130Inst : IEnumerable<long>
{
public static readonly long[] Value=A073130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073130.Bytes);
public long this[int i]=>Value[i];

public static A073130Inst Instance=new A073130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073131
{
public static readonly long[] Value={ 2L,6L,6L,14L,10L,18L,8L,16L,26L,18L,30L,22L,12L,20L,30L,36L,6L,48L,22L,14L,34L,30L,30L,48L,38L,16L,24L,12L,18L,92L,30L,34L,24L,62L,18L,42L,48L,24L,40L,32L,24L,66L,18L,30L,16L,80L,112L,24L,14L,24L,28L,24L,74L,24L,48L,54L,18L,46L,36L,24L,66L,114L,36L,18L,18L,122L,48L,72L,10L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073131Inst : IEnumerable<long>
{
public static readonly long[] Value=A073131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073131.Bytes);
public long this[int i]=>Value[i];

public static A073131Inst Instance=new A073131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073132
{
public static readonly long[] Value={ 1L,0L,2L,7L,5L,13L,4L,8L,6L,14L,12L,27L,9L,51L,11L,40L,21L,16L,25L,39L,36L,96L,58L,18L,132L,134L,56L,106L,108L,72L,34L,102L,42L,158L,202L,68L,53L,118L,121L,46L,124L,101L,383L,91L,157L,30L,80L,97L,204L,126L,258L,139L,381L,145L,222L,47L,62L,240L,242L,363L,66L,177L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073132Inst : IEnumerable<long>
{
public static readonly long[] Value=A073132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073132.Bytes);
public long this[int i]=>Value[i];

public static A073132Inst Instance=new A073132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073133
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,4L,10L,12L,5L,1L,5L,17L,33L,29L,8L,1L,6L,26L,72L,109L,70L,13L,1L,7L,37L,135L,305L,360L,169L,21L,1L,8L,50L,228L,701L,1292L,1189L,408L,34L,1L,9L,65L,357L,1405L,3640L,5473L,3927L,985L,55L,1L,10L,82L,528L,2549L,8658L,18901L,23184L,12970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073133Inst : IEnumerable<long>
{
public static readonly long[] Value=A073133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073133.Bytes);
public long this[int i]=>Value[i];

public static A073133Inst Instance=new A073133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073134
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,-1L,3L,3L,1L,-1L,4L,8L,4L,1L,0L,5L,21L,15L,5L,1L,1L,6L,55L,56L,24L,6L,1L,1L,7L,144L,209L,115L,35L,7L,1L,0L,8L,377L,780L,551L,204L,48L,8L,1L,-1L,9L,987L,2911L,2640L,1189L,329L,63L,9L,1L,-1L,10L,2584L,10864L,12649L,6930L,2255L,496L,80L,10L,1L,0L,11L,6765L,40545L,60605L,40391L,15456L,3905L,711L,99L,11L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073134Inst : IEnumerable<long>
{
public static readonly long[] Value=A073134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073134.Bytes);
public long this[int i]=>Value[i];

public static A073134Inst Instance=new A073134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073135
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,12L,6L,1L,6L,32L,27L,8L,1L,10L,81L,108L,48L,10L,1L,17L,200L,406L,256L,75L,12L,1L,28L,488L,1470L,1281L,500L,108L,14L,1L,45L,1184L,5193L,6160L,3126L,864L,147L,16L,1L,72L,2865L,18036L,28832L,18770L,6481L,1372L,192L,18L,1L,116L,6924L,61885L,132352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073135Inst : IEnumerable<long>
{
public static readonly long[] Value=A073135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073135.Bytes);
public long this[int i]=>Value[i];

public static A073135Inst Instance=new A073135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073136
{
public static readonly long[] Value={ 5L,8L,16L,24L,42L,54L,76L,86L,106L,138L,158L,194L,220L,234L,258L,294L,336L,344L,398L,424L,440L,480L,514L,550L,606L,648L,666L,694L,708L,730L,836L,870L,910L,936L,1008L,1028L,1076L,1130L,1158L,1204L,1242L,1268L,1344L,1364L,1398L,1416L,1508L,1632L,1660L,1676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073136Inst : IEnumerable<long>
{
public static readonly long[] Value=A073136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073136.Bytes);
public long this[int i]=>Value[i];

public static A073136Inst Instance=new A073136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073137
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,7L,8L,9L,9L,11L,9L,11L,11L,15L,16L,17L,17L,19L,17L,19L,19L,23L,17L,19L,19L,23L,19L,23L,23L,31L,32L,33L,33L,35L,33L,35L,35L,39L,33L,35L,35L,39L,35L,39L,39L,47L,33L,35L,35L,39L,35L,39L,39L,47L,35L,39L,39L,47L,39L,47L,47L,63L,64L,65L,65L,67L,65L,67L,67L,71L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073137Inst : IEnumerable<long>
{
public static readonly long[] Value=A073137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073137.Bytes);
public long this[int i]=>Value[i];

public static A073137Inst Instance=new A073137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073138
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,6L,7L,8L,12L,12L,14L,12L,14L,14L,15L,16L,24L,24L,28L,24L,28L,28L,30L,24L,28L,28L,30L,28L,30L,30L,31L,32L,48L,48L,56L,48L,56L,56L,60L,48L,56L,56L,60L,56L,60L,60L,62L,48L,56L,56L,60L,56L,60L,60L,62L,56L,60L,60L,62L,60L,62L,62L,63L,64L,96L,96L,112L,96L,112L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073138Inst : IEnumerable<long>
{
public static readonly long[] Value=A073138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073138.Bytes);
public long this[int i]=>Value[i];

public static A073138Inst Instance=new A073138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073139
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,0L,3L,3L,3L,3L,3L,3L,0L,0L,7L,7L,9L,7L,9L,9L,7L,7L,9L,9L,7L,9L,7L,7L,0L,0L,15L,15L,21L,15L,21L,21L,21L,15L,21L,21L,21L,21L,21L,21L,15L,15L,21L,21L,21L,21L,21L,21L,15L,21L,21L,21L,15L,21L,15L,15L,0L,0L,31L,31L,45L,31L,45L,45L,49L,31L,45L,45L,49L,45L,49L,49L,45L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073139Inst : IEnumerable<long>
{
public static readonly long[] Value=A073139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073139.Bytes);
public long this[int i]=>Value[i];

public static A073139Inst Instance=new A073139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073188
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,4L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073188Inst : IEnumerable<long>
{
public static readonly long[] Value=A073188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073188.Bytes);
public long this[int i]=>Value[i];

public static A073188Inst Instance=new A073188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073189
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073189Inst : IEnumerable<long>
{
public static readonly long[] Value=A073189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073189.Bytes);
public long this[int i]=>Value[i];

public static A073189Inst Instance=new A073189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073190
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,20L,60L,181L,584L,1916L,6476L,22210L,77416L,272840L,971640L,3488925L,12621168L,45946156L,168206604L,618853270L,2286974856L,8485246456L,31596023208L,118037654258L,442287721872L,1661790513944L,6259494791096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073190Inst : IEnumerable<long>
{
public static readonly long[] Value=A073190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073190.Bytes);
public long this[int i]=>Value[i];

public static A073190Inst Instance=new A073190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073191
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,31L,96L,305L,1007L,3389L,11636L,40498L,142714L,507870L,1823040L,6591885L,23989419L,87795473L,322922652L,1193058230L,4425547638L,16475756738L,61539293424L,230548633954L,866095934598L,3261868457698L,12313423931624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073191Inst : IEnumerable<long>
{
public static readonly long[] Value=A073191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073191.Bytes);
public long this[int i]=>Value[i];

public static A073191Inst Instance=new A073191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073192
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,18L,54L,155L,500L,1614L,5456L,18630L,64960L,228740L,814914L,2926323L,10589916L,38561814L,141219432L,519711666L,1921142832L,7129756188L,26555149404L,99228108222L,371886574632L,1397548389644L,5265131346368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073192Inst : IEnumerable<long>
{
public static readonly long[] Value=A073192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073192.Bytes);
public long this[int i]=>Value[i];

public static A073192Inst Instance=new A073192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073193
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,30L,93L,292L,965L,3238L,11126L,38708L,136486L,485820L,1744677L,6310584L,22973793L,84103302L,309429066L,1143487428L,4242631626L,15798011604L,59018856522L,221143860936L,830895360978L,3129747395548L,11816242209260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073193Inst : IEnumerable<long>
{
public static readonly long[] Value=A073193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073193.Bytes);
public long this[int i]=>Value[i];

public static A073193Inst Instance=new A073193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073194
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,11L,14L,16L,19L,17L,20L,10L,12L,15L,21L,13L,18L,22L,23L,25L,28L,30L,33L,37L,39L,42L,44L,47L,51L,53L,56L,60L,45L,48L,54L,57L,61L,26L,27L,24L,31L,34L,38L,40L,43L,52L,58L,62L,32L,35L,41L,46L,29L,49L,55L,63L,36L,50L,59L,64L,65L,67L,70L,72L,75L,79L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073194Inst : IEnumerable<long>
{
public static readonly long[] Value=A073194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073194.Bytes);
public long this[int i]=>Value[i];

public static A073194Inst Instance=new A073194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073195
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,16L,10L,17L,20L,11L,18L,12L,14L,21L,13L,15L,19L,22L,23L,44L,24L,42L,43L,25L,57L,26L,45L,53L,27L,46L,54L,61L,28L,47L,29L,48L,55L,30L,49L,31L,37L,56L,32L,38L,58L,62L,33L,50L,34L,39L,59L,35L,40L,51L,63L,36L,41L,52L,60L,64L,65L,126L,66L,128L,131L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073195Inst : IEnumerable<long>
{
public static readonly long[] Value=A073195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073195.Bytes);
public long this[int i]=>Value[i];

public static A073195Inst Instance=new A073195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073196
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,10L,14L,16L,19L,17L,21L,12L,11L,15L,18L,13L,20L,22L,23L,24L,25L,26L,27L,37L,38L,42L,44L,53L,51L,56L,47L,60L,45L,46L,58L,49L,59L,31L,34L,30L,28L,29L,40L,39L,43L,52L,48L,62L,35L,33L,41L,57L,32L,54L,63L,55L,36L,61L,50L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073196Inst : IEnumerable<long>
{
public static readonly long[] Value=A073196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073196.Bytes);
public long this[int i]=>Value[i];

public static A073196Inst Instance=new A073196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073197
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,10L,17L,16L,20L,11L,18L,12L,14L,19L,13L,21L,15L,22L,23L,24L,25L,26L,27L,45L,46L,44L,42L,57L,54L,43L,53L,61L,28L,29L,48L,47L,55L,30L,49L,31L,37L,38L,35L,51L,40L,63L,33L,50L,32L,58L,60L,34L,56L,39L,41L,36L,62L,52L,59L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073197Inst : IEnumerable<long>
{
public static readonly long[] Value=A073197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073197.Bytes);
public long this[int i]=>Value[i];

public static A073197Inst Instance=new A073197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073198
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,14L,16L,11L,19L,17L,18L,10L,12L,15L,20L,13L,21L,22L,23L,37L,42L,30L,51L,44L,47L,28L,25L,39L,53L,33L,56L,60L,45L,46L,48L,49L,50L,26L,29L,24L,31L,40L,38L,43L,32L,52L,54L,55L,27L,34L,41L,57L,35L,58L,59L,61L,36L,62L,63L,64L,65L,107L,121L,70L,149L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073198Inst : IEnumerable<long>
{
public static readonly long[] Value=A073198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073198.Bytes);
public long this[int i]=>Value[i];

public static A073198Inst Instance=new A073198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073199
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,16L,12L,17L,20L,10L,18L,11L,14L,15L,13L,19L,21L,22L,23L,44L,31L,42L,53L,30L,43L,26L,45L,49L,34L,54L,57L,61L,24L,47L,32L,46L,55L,25L,48L,28L,37L,38L,29L,39L,40L,41L,27L,50L,33L,51L,52L,35L,56L,58L,59L,36L,60L,62L,63L,64L,65L,126L,87L,128L,156L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073199Inst : IEnumerable<long>
{
public static readonly long[] Value=A073199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073199.Bytes);
public long this[int i]=>Value[i];

public static A073199Inst Instance=new A073199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073200
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,0L,2L,2L,1L,0L,7L,3L,3L,1L,0L,8L,4L,2L,3L,1L,0L,6L,6L,8L,2L,3L,1L,0L,4L,5L,7L,7L,2L,3L,1L,0L,5L,7L,6L,6L,8L,2L,3L,1L,0L,17L,8L,5L,8L,7L,7L,2L,2L,1L,0L,18L,9L,4L,4L,6L,8L,7L,3L,3L,1L,0L,20L,10L,22L,5L,5L,5L,8L,4L,2L,2L,1L,0L,21L,14L,21L,17L,4L,4L,6L,5L,8L,3L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073200Inst : IEnumerable<long>
{
public static readonly long[] Value=A073200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073200.Bytes);
public long this[int i]=>Value[i];

public static A073200Inst Instance=new A073200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073201
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,7L,4L,1L,1L,1L,22L,11L,3L,1L,1L,1L,66L,31L,7L,2L,1L,1L,1L,217L,96L,22L,4L,3L,1L,1L,1L,715L,305L,66L,11L,7L,2L,1L,1L,1L,2438L,1007L,217L,30L,22L,4L,2L,2L,1L,1L,8398L,3389L,715L,93L,66L,11L,3L,5L,1L,1L,1L,29414L,11636L,2438L,292L,217L,30L,6L,14L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073201Inst : IEnumerable<long>
{
public static readonly long[] Value=A073201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073201.Bytes);
public long this[int i]=>Value[i];

public static A073201Inst Instance=new A073201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073202
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,0L,3L,0L,1L,1L,2L,8L,1L,0L,1L,1L,0L,20L,0L,0L,0L,1L,1L,5L,60L,2L,0L,1L,0L,1L,1L,0L,181L,0L,0L,0L,0L,0L,1L,1L,14L,584L,5L,0L,2L,0L,1L,2L,1L,1L,0L,1916L,0L,0L,0L,0L,0L,5L,0L,1L,1L,42L,6476L,14L,0L,5L,0L,0L,14L,1L,2L,1L,1L,0L,22210L,0L,0L,0L,0L,0L,42L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073202Inst : IEnumerable<long>
{
public static readonly long[] Value=A073202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073202.Bytes);
public long this[int i]=>Value[i];

public static A073202Inst Instance=new A073202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073203
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,3L,2L,1L,1L,2L,2L,2L,6L,2L,2L,1L,1L,2L,2L,2L,8L,2L,3L,2L,1L,1L,2L,2L,2L,10L,2L,6L,4L,1L,1L,1L,2L,2L,2L,12L,2L,8L,8L,1L,2L,1L,1L,2L,2L,2L,14L,2L,10L,16L,1L,4L,1L,1L,1L,2L,2L,2L,16L,2L,12L,32L,1L,8L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073203Inst : IEnumerable<long>
{
public static readonly long[] Value=A073203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073203.Bytes);
public long this[int i]=>Value[i];

public static A073203Inst Instance=new A073203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073220
{
public static readonly long[] Value={ 1L,7L,13L,85L,91L,169L,1099L,1105L,1183L,2197L,14281L,14287L,14365L,15379L,28561L,185647L,185653L,185731L,186745L,199927L,371293L,2413405L,2413411L,2413489L,2414503L,2427685L,2599051L,4826809L,31374259L,31374265L,31374343L,31375357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073220Inst : IEnumerable<long>
{
public static readonly long[] Value=A073220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073220.Bytes);
public long this[int i]=>Value[i];

public static A073220Inst Instance=new A073220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073221
{
public static readonly long[] Value={ 1L,9L,17L,145L,153L,289L,2457L,2465L,2601L,4913L,41761L,41769L,41905L,44217L,83521L,709929L,709937L,710073L,712385L,751689L,1419857L,12068785L,12068793L,12068929L,12071241L,12110545L,12778713L,24137569L,205169337L,205169345L,205169481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073221Inst : IEnumerable<long>
{
public static readonly long[] Value=A073221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073221.Bytes);
public long this[int i]=>Value[i];

public static A073221Inst Instance=new A073221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073222
{
public static readonly long[] Value={ 1L,10L,19L,181L,190L,361L,3430L,3439L,3610L,6859L,65161L,65170L,65341L,68590L,130321L,1238050L,1238059L,1238230L,1241479L,1303210L,2476099L,23522941L,23522950L,23523121L,23526370L,23588101L,24760990L,47045881L,446935870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073222Inst : IEnumerable<long>
{
public static readonly long[] Value=A073222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073222.Bytes);
public long this[int i]=>Value[i];

public static A073222Inst Instance=new A073222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073223
{
public static readonly long[] Value={ 1L,6L,3L,7L,3L,1L,1L,2L,3L,5L,1L,3L,0L,7L,5L,2L,0L,0L,3L,1L,0L,2L,4L,4L,4L,1L,1L,2L,1L,2L,7L,1L,6L,0L,4L,1L,3L,6L,4L,0L,1L,2L,2L,3L,0L,6L,3L,2L,4L,8L,5L,4L,3L,5L,4L,0L,1L,2L,0L,2L,3L,1L,7L,5L,4L,2L,3L,8L,6L,0L,2L,3L,6L,1L,3L,3L,3L,4L,1L,4L,0L,4L,1L,5L,7L,3L,5L,2L,7L,5L,3L,2L,2L,3L,0L,5L,1L,4L,4L,0L,5L,6L,5L,3L,2L,2L,3L,1L,5L,4L,2L,1L,2L,8L,1L,3L,5L,3L,3L,2L,6L,8L,8L,4L,4L,3L,1L,1L,9L,3L,1L,3L,9L,5L,4L,1L,3L,4L,1L,2L,2L,5L,0L,2L,5L,2L,9L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073223Inst : IEnumerable<long>
{
public static readonly long[] Value=A073223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073223.Bytes);
public long this[int i]=>Value[i];

public static A073223Inst Instance=new A073223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073224
{
public static readonly BigInteger[] Value={ 27L,1465L,92041L,6554833L,504813055L,40947676475L,3442465670223L,296935715374179L,26108021958592999L,2329702677873323273L,BigInteger.Parse("210338403560373373799"),BigInteger.Parse("19172323465486902000641"),BigInteger.Parse("1761408925012566646647345"),BigInteger.Parse("162904914369466264400189781") };
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
public class A073224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073224Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073224.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073224Inst Instance=new A073224Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073225
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,27L,65L,164L,417L,1068L,2756L,7148L,18614L,48639L,127464L,334865L,881658L,2325751L,6145597L,16263867L,43099805L,114356612L,303761261L,807692035L,2149632062L,5726042116L,15264691108L,40722913455L,108713644517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073225Inst : IEnumerable<long>
{
public static readonly long[] Value=A073225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073225.Bytes);
public long this[int i]=>Value[i];

public static A073225Inst Instance=new A073225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073226
{
public static readonly long[] Value={ 1L,5L,1L,5L,4L,2L,6L,2L,2L,4L,1L,4L,7L,9L,2L,6L,4L,1L,8L,9L,7L,6L,0L,4L,3L,0L,2L,7L,2L,6L,2L,9L,9L,1L,1L,9L,0L,5L,5L,2L,8L,5L,4L,8L,5L,3L,6L,8L,5L,6L,1L,3L,9L,7L,6L,9L,1L,4L,0L,7L,4L,6L,4L,0L,5L,9L,1L,4L,8L,3L,0L,9L,7L,3L,7L,3L,0L,9L,3L,4L,4L,3L,2L,6L,0L,8L,4L,5L,6L,9L,6L,8L,3L,5L,7L,8L,7L,3L,4L,6L,0L,5L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073226Inst : IEnumerable<long>
{
public static readonly long[] Value=A073226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073226.Bytes);
public long this[int i]=>Value[i];

public static A073226Inst Instance=new A073226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073227
{
public static readonly long[] Value={ 3L,8L,1L,4L,2L,7L,9L,1L,0L,4L,7L,6L,0L,2L,2L,0L,5L,9L,2L,2L,0L,9L,2L,1L,9L,5L,9L,4L,0L,9L,8L,2L,0L,3L,5L,7L,1L,0L,2L,3L,9L,4L,0L,5L,3L,6L,2L,2L,6L,6L,6L,6L,0L,7L,5L,5L,2L,6L,7L,0L,4L,1L,2L,5L,8L,0L,4L,7L,6L,8L,8L,9L,6L,7L,1L,2L,5L,9L,9L,6L,6L,1L,0L,0L,1L,0L,7L,8L,4L,9L,1L,0L,9L,2L,0L,6L,5L,7L,8L,9L,6L,0L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073227Inst : IEnumerable<long>
{
public static readonly long[] Value=A073227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073227.Bytes);
public long this[int i]=>Value[i];

public static A073227Inst Instance=new A073227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073228
{
public static readonly long[] Value={ 1L,6L,1L,8L,1L,7L,7L,9L,9L,1L,9L,1L,2L,6L,5L,3L,5L,0L,1L,6L,6L,8L,6L,9L,1L,2L,2L,5L,4L,8L,3L,6L,1L,0L,1L,9L,5L,6L,9L,2L,2L,8L,8L,1L,0L,3L,4L,7L,3L,3L,5L,3L,3L,6L,0L,5L,3L,0L,0L,1L,6L,9L,9L,4L,5L,6L,1L,5L,6L,0L,7L,5L,4L,1L,6L,5L,8L,8L,1L,7L,8L,3L,0L,0L,0L,5L,3L,7L,3L,7L,7L,3L,4L,8L,4L,2L,3L,1L,7L,8L,0L,0L,9L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073228Inst : IEnumerable<long>
{
public static readonly long[] Value=A073228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073228.Bytes);
public long this[int i]=>Value[i];

public static A073228Inst Instance=new A073228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073229
{
public static readonly long[] Value={ 1L,4L,4L,4L,6L,6L,7L,8L,6L,1L,0L,0L,9L,7L,6L,6L,1L,3L,3L,6L,5L,8L,3L,3L,9L,1L,0L,8L,5L,9L,6L,4L,3L,0L,2L,2L,3L,0L,5L,8L,5L,9L,5L,4L,5L,3L,2L,4L,2L,2L,5L,3L,1L,6L,5L,8L,2L,0L,5L,2L,2L,6L,6L,4L,3L,0L,3L,8L,5L,4L,9L,3L,7L,7L,1L,8L,6L,1L,4L,5L,0L,5L,5L,7L,3L,5L,8L,2L,9L,2L,3L,0L,4L,7L,0L,9L,8L,8L,5L,1L,1L,4L,2L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073229Inst : IEnumerable<long>
{
public static readonly long[] Value=A073229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073229.Bytes);
public long this[int i]=>Value[i];

public static A073229Inst Instance=new A073229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073230
{
public static readonly long[] Value={ 0L,6L,5L,9L,8L,8L,0L,3L,5L,8L,4L,5L,3L,1L,2L,5L,3L,7L,0L,7L,6L,7L,9L,0L,1L,8L,7L,5L,9L,6L,8L,4L,6L,4L,2L,4L,9L,3L,8L,5L,7L,7L,0L,4L,8L,2L,5L,2L,7L,9L,6L,4L,3L,6L,4L,0L,2L,4L,7L,3L,5L,4L,1L,5L,6L,6L,7L,3L,6L,3L,3L,0L,0L,3L,0L,7L,5L,6L,3L,0L,8L,1L,0L,4L,0L,8L,8L,2L,4L,2L,4L,5L,3L,3L,7L,1L,4L,6L,7L,7L,4L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073230Inst : IEnumerable<long>
{
public static readonly long[] Value=A073230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073230.Bytes);
public long this[int i]=>Value[i];

public static A073230Inst Instance=new A073230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073231
{
public static readonly long[] Value={ 5L,0L,0L,4L,7L,3L,5L,0L,0L,5L,6L,3L,6L,3L,6L,8L,4L,0L,5L,4L,5L,1L,3L,4L,9L,0L,1L,3L,3L,7L,9L,0L,4L,5L,7L,2L,8L,0L,3L,4L,5L,3L,2L,1L,5L,3L,4L,2L,2L,8L,3L,0L,0L,6L,4L,9L,7L,9L,0L,9L,3L,5L,2L,7L,8L,3L,7L,5L,7L,3L,2L,1L,1L,6L,2L,6L,1L,4L,3L,3L,4L,4L,3L,5L,1L,0L,6L,5L,0L,8L,2L,6L,5L,0L,9L,6L,5L,7L,5L,8L,9L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073231Inst : IEnumerable<long>
{
public static readonly long[] Value=A073231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073231.Bytes);
public long this[int i]=>Value[i];

public static A073231Inst Instance=new A073231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073232
{
public static readonly long[] Value={ 8L,7L,3L,4L,2L,3L,0L,1L,8L,4L,9L,3L,1L,1L,6L,6L,4L,2L,9L,8L,9L,0L,3L,2L,3L,4L,8L,6L,6L,2L,5L,3L,8L,2L,0L,5L,2L,6L,2L,5L,4L,0L,9L,7L,8L,5L,8L,3L,3L,5L,9L,6L,7L,5L,0L,5L,6L,2L,1L,9L,4L,2L,1L,4L,8L,0L,1L,4L,3L,1L,6L,3L,8L,3L,1L,5L,1L,5L,0L,1L,8L,7L,4L,5L,1L,1L,7L,0L,9L,6L,3L,2L,5L,5L,2L,4L,6L,7L,1L,3L,2L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073232Inst : IEnumerable<long>
{
public static readonly long[] Value=A073232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073232.Bytes);
public long this[int i]=>Value[i];

public static A073232Inst Instance=new A073232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073233
{
public static readonly long[] Value={ 3L,6L,4L,6L,2L,1L,5L,9L,6L,0L,7L,2L,0L,7L,9L,1L,1L,7L,7L,0L,9L,9L,0L,8L,2L,6L,0L,2L,2L,6L,9L,2L,1L,2L,3L,6L,6L,6L,3L,6L,5L,5L,0L,8L,4L,0L,2L,2L,2L,8L,8L,1L,8L,7L,3L,8L,7L,0L,9L,3L,3L,5L,9L,2L,2L,9L,3L,4L,0L,7L,4L,3L,6L,8L,8L,8L,1L,6L,9L,9L,9L,0L,4L,6L,2L,0L,0L,7L,9L,8L,7L,5L,7L,0L,6L,7L,7L,4L,8L,5L,4L,3L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073233Inst : IEnumerable<long>
{
public static readonly long[] Value=A073233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073233.Bytes);
public long this[int i]=>Value[i];

public static A073233Inst Instance=new A073233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073234
{
public static readonly long[] Value={ 1L,3L,4L,0L,1L,6L,4L,1L,8L,3L,0L,0L,6L,3L,5L,7L,4L,3L,5L,2L,9L,7L,4L,4L,9L,1L,2L,9L,6L,4L,0L,1L,3L,1L,4L,1L,5L,0L,9L,9L,3L,7L,4L,9L,7L,4L,5L,7L,3L,4L,9L,9L,2L,3L,7L,7L,8L,7L,9L,2L,7L,5L,1L,6L,5L,8L,6L,0L,3L,4L,0L,9L,2L,6L,1L,9L,0L,9L,4L,0L,6L,8L,1L,4L,8L,2L,6L,9L,4L,7L,2L,6L,1L,1L,3L,0L,1L,1L,4L,2L,2L,7L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073234Inst : IEnumerable<long>
{
public static readonly long[] Value=A073234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073234.Bytes);
public long this[int i]=>Value[i];

public static A073234Inst Instance=new A073234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073235
{
public static readonly long[] Value={ 8L,0L,6L,6L,2L,6L,6L,5L,9L,3L,8L,5L,5L,4L,5L,9L,6L,7L,3L,8L,4L,9L,8L,3L,6L,0L,1L,8L,9L,7L,7L,4L,6L,6L,8L,0L,7L,1L,9L,3L,6L,0L,0L,6L,8L,0L,5L,2L,5L,1L,4L,9L,6L,0L,5L,9L,9L,5L,0L,4L,7L,7L,0L,8L,9L,3L,0L,1L,4L,5L,9L,0L,1L,3L,1L,1L,5L,4L,9L,8L,4L,4L,3L,6L,1L,6L,3L,0L,1L,5L,8L,4L,0L,3L,9L,0L,0L,8L,2L,6L,1L,3L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073235Inst : IEnumerable<long>
{
public static readonly long[] Value=A073235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073235.Bytes);
public long this[int i]=>Value[i];

public static A073235Inst Instance=new A073235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073332
{
public static readonly long[] Value={ 18L,36L,48L,50L,72L,98L,100L,144L,196L,200L,242L,338L,375L,392L,400L,484L,578L,676L,722L,784L,800L,968L,1029L,1058L,1125L,1156L,1280L,1352L,1444L,1568L,1600L,1682L,1922L,1936L,2116L,2312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073332Inst : IEnumerable<long>
{
public static readonly long[] Value=A073332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073332.Bytes);
public long this[int i]=>Value[i];

public static A073332Inst Instance=new A073332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073333
{
public static readonly long[] Value={ 5L,8L,1L,9L,7L,6L,7L,0L,6L,8L,6L,9L,3L,2L,6L,4L,2L,4L,3L,8L,5L,0L,0L,2L,0L,0L,5L,1L,0L,9L,0L,1L,1L,5L,5L,8L,5L,4L,6L,8L,6L,9L,3L,0L,1L,0L,7L,5L,3L,9L,6L,1L,3L,6L,2L,6L,6L,7L,8L,7L,0L,5L,9L,6L,4L,8L,0L,4L,3L,8L,1L,7L,3L,9L,1L,6L,6L,9L,7L,4L,3L,2L,8L,7L,2L,0L,4L,7L,0L,9L,4L,0L,4L,8L,7L,5L,0L,5L,7L,6L,5L,4L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073333Inst : IEnumerable<long>
{
public static readonly long[] Value=A073333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073333.Bytes);
public long this[int i]=>Value[i];

public static A073333Inst Instance=new A073333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073334
{
public static readonly long[] Value={ 3L,5L,8L,5L,8L,13L,8L,5L,8L,13L,21L,13L,8L,13L,8L,5L,8L,13L,21L,13L,21L,34L,21L,13L,8L,13L,21L,13L,8L,13L,8L,5L,8L,13L,21L,13L,21L,34L,21L,13L,21L,34L,55L,34L,21L,34L,21L,13L,8L,13L,21L,13L,21L,34L,21L,13L,8L,13L,21L,13L,8L,13L,8L,5L,8L,13L,21L,13L,21L,34L,21L,13L,21L,34L,55L,34L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073334Inst : IEnumerable<long>
{
public static readonly long[] Value=A073334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073334.Bytes);
public long this[int i]=>Value[i];

public static A073334Inst Instance=new A073334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073335
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,15L,23L,39L,58L,89L,128L,189L,264L,375L,515L,713L,960L,1301L,1726L,2298L,3011L,3948L,5113L,6625L,8492L,10880L,13825L,17545L,22108L,27823L,34800L,43465L,54003L,66983L,82709L,101960L,125180L,153432L,187397L,228490L,277707L,336972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073335Inst : IEnumerable<long>
{
public static readonly long[] Value=A073335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073335.Bytes);
public long this[int i]=>Value[i];

public static A073335Inst Instance=new A073335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073336
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,13L,21L,33L,51L,76L,111L,159L,226L,315L,435L,593L,805L,1077L,1435L,1893L,2486L,3237L,4198L,5405L,6935L,8843L,11235L,14201L,17893L,22437L,28052L,34929L,43371L,53653L,66201L,81410L,99876L,122155L,149063L,181399L,220280L,266811L,322524L,388960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073336Inst : IEnumerable<long>
{
public static readonly long[] Value=A073336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073336.Bytes);
public long this[int i]=>Value[i];

public static A073336Inst Instance=new A073336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073337
{
public static readonly long[] Value={ 7L,3L,13L,31L,241L,307L,463L,757L,1123L,1723L,3307L,3541L,4831L,5113L,5701L,6007L,8011L,9901L,10303L,11131L,12433L,13807L,14281L,17293L,20023L,20593L,21757L,23563L,24181L,26083L,28057L,30103L,35911L,41413L,43891L,46441L,53593L,60271L,78121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073337Inst : IEnumerable<long>
{
public static readonly long[] Value=A073337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073337.Bytes);
public long this[int i]=>Value[i];

public static A073337Inst Instance=new A073337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073338
{
public static readonly long[] Value={ 2L,3L,4L,9L,10L,12L,15L,18L,22L,30L,31L,36L,37L,39L,40L,46L,51L,52L,54L,57L,60L,61L,67L,72L,73L,75L,78L,79L,82L,85L,88L,96L,103L,106L,109L,117L,124L,141L,145L,148L,156L,166L,177L,180L,186L,192L,193L,199L,204L,219L,225L,228L,229L,246L,249L,264L,267L,268L,270L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073338Inst : IEnumerable<long>
{
public static readonly long[] Value=A073338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073338.Bytes);
public long this[int i]=>Value[i];

public static A073338Inst Instance=new A073338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073339
{
public static readonly long[] Value={ 2L,5L,5L,69L,69L,12L,69L,69L,69L,29L,69L,19L,69L,69L,29L,29L,631L,28L,30L,631L,69L,69L,69L,631L,72L,42L,1167L,631L,72L,631L,631L,1167L,51L,631L,1167L,631L,631L,1167L,102L,103L,69L,1167L,1167L,69L,72L,631L,631L,631L,631L,1167L,631L,130L,631L,83L,631L,1167L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073339Inst : IEnumerable<long>
{
public static readonly long[] Value=A073339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073339.Bytes);
public long this[int i]=>Value[i];

public static A073339Inst Instance=new A073339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073340
{
public static readonly long[] Value={ 3L,5L,5L,7L,11L,13L,431L,433L,569L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073340Inst : IEnumerable<long>
{
public static readonly long[] Value=A073340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073340.Bytes);
public long this[int i]=>Value[i];

public static A073340Inst Instance=new A073340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073341
{
public static readonly long[] Value={ 3L,2L,3L,8L,1L,1L,3L,2L,2L,3L,2L,2L,1L,1L,7L,4L,4L,2L,4L,3L,1L,1L,2L,4L,2L,8L,4L,3L,1L,1L,6L,4L,3L,2L,5L,4L,1L,1L,5L,2L,2L,3L,2L,2L,1L,1L,4L,5L,6L,2L,3L,5L,1L,1L,2L,3L,2L,4L,3L,6L,1L,1L,7L,8L,3L,2L,4L,5L,1L,1L,3L,2L,2L,3L,2L,2L,1L,1L,7L,3L,4L,2L,7L,6L,1L,1L,2L,5L,2L,5L,5L,3L,1L,1L,3L,3L,3L,2L,10L,3L,1L,1L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073341Inst : IEnumerable<long>
{
public static readonly long[] Value=A073341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073341.Bytes);
public long this[int i]=>Value[i];

public static A073341Inst Instance=new A073341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073342
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,2L,4L,5L,3L,6L,2L,5L,3L,4L,6L,4L,7L,4L,7L,4L,5L,8L,6L,9L,8L,1L,1L,3L,3L,2L,3L,2L,4L,4L,5L,2L,4L,3L,5L,4L,6L,3L,4L,4L,6L,6L,1L,2L,4L,4L,3L,5L,2L,3L,5L,4L,6L,3L,5L,4L,4L,5L,3L,2L,2L,4L,2L,4L,5L,5L,4L,6L,5L,4L,6L,5L,7L,6L,2L,4L,5L,2L,3L,3L,5L,4L,6L,5L,4L,4L,6L,7L,6L,5L,7L,3L,5L,3L,3L,3L,5L,6L,5L,7L,4L,6L,7L,6L,8L,2L,4L,3L,5L,5L,3L,4L,4L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073342Inst : IEnumerable<long>
{
public static readonly long[] Value=A073342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073342.Bytes);
public long this[int i]=>Value[i];

public static A073342Inst Instance=new A073342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073343
{
public static readonly long[] Value={ 1L,1L,1L,6L,33L,75L,877L,2075L,38692L,239794L,1250340L,18495201L,43023264L,4554211553L,70490483945L,911526001064L,182477118528L,219638126087356L,13070186026272L,79249480638985626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073343Inst : IEnumerable<long>
{
public static readonly long[] Value=A073343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073343.Bytes);
public long this[int i]=>Value[i];

public static A073343Inst Instance=new A073343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073344
{
public static readonly long[] Value={ 0L,0L,2L,7L,23L,105L,386L,1674L,6121L,25072L,89070L,391317L,1432287L,5414201L,20125565L,80661495L,273257927L,1073041080L,3588277692L,13732078994L,49417761548L,176544997915L,551992576980L,2143844160219L,7367037483012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073344Inst : IEnumerable<long>
{
public static readonly long[] Value=A073344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073344.Bytes);
public long this[int i]=>Value[i];

public static A073344Inst Instance=new A073344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073345
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,6L,8L,0L,0L,0L,0L,0L,0L,0L,4L,20L,0L,0L,0L,0L,0L,0L,0L,0L,1L,40L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,68L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,94L,152L,32L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,114L,376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073345Inst : IEnumerable<long>
{
public static readonly long[] Value=A073345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073345.Bytes);
public long this[int i]=>Value[i];

public static A073345Inst Instance=new A073345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073346
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,0L,0L,0L,0L,2L,4L,0L,0L,0L,0L,1L,0L,8L,8L,0L,0L,0L,0L,0L,0L,12L,16L,0L,0L,0L,0L,0L,0L,2L,12L,40L,16L,0L,0L,0L,0L,0L,0L,2L,12L,80L,48L,0L,0L,0L,0L,0L,0L,0L,0L,12L,136L,144L,32L,0L,0L,0L,0L,0L,0L,0L,2L,20L,224L,384L,128L,0L,0L,0L,0L,0L,0L,0L,0L,0L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073346Inst : IEnumerable<long>
{
public static readonly long[] Value=A073346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073346.Bytes);
public long this[int i]=>Value[i];

public static A073346Inst Instance=new A073346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073347
{
public static readonly long[] Value={ 5L,14L,28L,46L,69L,97L,130L,168L,211L,259L,311L,368L,430L,497L,569L,646L,728L,815L,907L,1004L,1105L,1211L,1322L,1438L,1559L,1685L,1816L,1952L,2093L,2239L,2390L,2546L,2706L,2871L,3041L,3216L,3396L,3581L,3771L,3966L,4166L,4371L,4581L,4796L,5016L,5240L,5469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073347Inst : IEnumerable<long>
{
public static readonly long[] Value=A073347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073347.Bytes);
public long this[int i]=>Value[i];

public static A073347Inst Instance=new A073347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073508
{
public static readonly long[] Value={ 0L,5L,38L,303L,2390L,19593L,166032L,1440186L,12711333L,113761326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073508Inst : IEnumerable<long>
{
public static readonly long[] Value=A073508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073508.Bytes);
public long this[int i]=>Value[i];

public static A073508Inst Instance=new A073508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073509
{
public static readonly BigInteger[] Value={ 0L,1L,15L,127L,1006L,8230L,70320L,614821L,5453140L,48982456L,444608278L,4070532710L,37535715441L,348245215460L,3247889171908L,30429496751905L,286235215995588L,2702000272361599L,25586688305447928L,242978340446949438L,2313264023790027111L,BigInteger.Parse("22074118786158858975") };
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
public class A073509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073509Inst Instance=new A073509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073510
{
public static readonly BigInteger[] Value={ 0L,2L,17L,127L,1003L,8326L,71038L,618610L,5481646L,49221187L,446590932L,4087194991L,37677478288L,349465615584L,3258501713644L,30522628848972L,287059041039078L,2709339704446862L,25652489700275636L,243571629996128384L,2318640708958531064L,BigInteger.Parse("22123070798400775157") };
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
public class A073510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073510Inst Instance=new A073510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073511
{
public static readonly BigInteger[] Value={ 1L,4L,18L,125L,1027L,8435L,71564L,622882L,5516130L,49495432L,448855139L,4106164356L,37838546363L,350849788546L,3270531245684L,30628143485953L,287992070079777L,2717649138419586L,25726964404879666L,244242934202964444L,2324722877951987037L,BigInteger.Parse("22178433287546997612") };
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
public class A073511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073511Inst Instance=new A073511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073512
{
public static readonly BigInteger[] Value={ 0L,2L,18L,135L,1013L,8458L,72257L,628206L,5556434L,49815418L,451476802L,4128049326L,38024311091L,352446754137L,3284400373590L,30749731897370L,289066731934716L,2727216210298152L,25812680778645432L,245015325044029789L,2331718909954888809L,BigInteger.Parse("22242097596092999144") };
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
public class A073512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073512Inst Instance=new A073512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073513
{
public static readonly BigInteger[] Value={ 1L,3L,17L,131L,1055L,8615L,72951L,633932L,5602768L,50193913L,454577490L,4153943134L,38243708524L,354330372215L,3300752009165L,30892997367352L,290332329192655L,2738477783884855L,25913537508233527L,245923809778144431L,2339944887042508496L,BigInteger.Parse("22316931815316988517") };
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
public class A073513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073513Inst Instance=new A073513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073514
{
public static readonly BigInteger[] Value={ 0L,3L,20L,139L,1069L,8747L,74114L,641594L,5661135L,50653546L,458352691L,4185483176L,38510936699L,356622729564L,3320632228693L,31067060521057L,291869049531878L,2752144407792176L,26035873192178041L,247025281876786013L,2349914303292170310L,BigInteger.Parse("22407593754131275705") };
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
public class A073514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073514Inst Instance=new A073514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073515
{
public static readonly BigInteger[] Value={ 1L,3L,19L,139L,1097L,8960L,75290L,651085L,5735086L,51247361L,463196868L,4225763390L,38851672813L,359541975662L,3345924530873L,31288310624754L,293820812588401L,2769490109678920L,26191046215879444L,248421640738371325L,2362546444095790527L,BigInteger.Parse("22522418647770393663") };
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
public class A073515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073515Inst Instance=new A073515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073516
{
public static readonly BigInteger[] Value={ 1L,3L,19L,146L,1129L,9142L,77025L,664277L,5837665L,52064915L,469864125L,4281198201L,39319600765L,363545360347L,3380562309312L,31590949437540L,296487794277035L,2793170342851930L,26402713858800478L,250324979315879678L,2379753569255122805L,BigInteger.Parse("22678735843184786383") };
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
public class A073516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073516Inst Instance=new A073516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073517
{
public static readonly BigInteger[] Value={ 0L,4L,25L,160L,1193L,9585L,80020L,686048L,6003530L,53378283L,480532488L,4369582734L,40063566855L,369893939287L,3435376839800L,32069022099022L,300694113015105L,2830466318006780L,26735673312004455L,253315661161665338L,2406763761677705769L,BigInteger.Parse("22923886160712831134") };
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
public class A073517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073517.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073517Inst Instance=new A073517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073518
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,14L,15L,17L,19L,19L,21L,23L,23L,25L,26L,28L,31L,32L,33L,34L,35L,36L,40L,42L,44L,44L,47L,48L,50L,52L,53L,55L,57L,58L,61L,61L,63L,63L,67L,71L,72L,73L,74L,76L,77L,80L,82L,84L,86L,86L,88L,89L,90L,93L,98L,99L,100L,101L,105L,107L,110L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073518Inst : IEnumerable<long>
{
public static readonly long[] Value=A073518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073518.Bytes);
public long this[int i]=>Value[i];

public static A073518Inst Instance=new A073518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073519
{
public static readonly long[] Value={ 1480028129L,1480028141L,1480028153L,1480028159L,1480028171L,1480028183L,1480028189L,1480028201L,1480028213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073519Inst : IEnumerable<long>
{
public static readonly long[] Value=A073519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073519.Bytes);
public long this[int i]=>Value[i];

public static A073519Inst Instance=new A073519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073520
{
public static readonly long[] Value={ 2L,0L,4440084513L,258L,313L,484L,797L,2016L,2211L,2862L,4507L,6188L,6325L,9660L,12669L,13016L,16857L,19530L,23069L,28184L,38761L,46302L,42515L,49846L,59087L,70260L,73385L,78960L,97267L,98316L,111023L,124454L,134641L,152952L,163043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073520Inst : IEnumerable<long>
{
public static readonly long[] Value=A073520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073520.Bytes);
public long this[int i]=>Value[i];

public static A073520Inst Instance=new A073520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073521
{
public static readonly long[] Value={ 31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073521Inst : IEnumerable<long>
{
public static readonly long[] Value=A073521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073521.Bytes);
public long this[int i]=>Value[i];

public static A073521Inst Instance=new A073521Inst();

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