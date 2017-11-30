using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A160105
{
public static readonly long[] Value={ 0L,1L,8L,2L,3L,5L,15L,6L,7L,13L,20L,12L,4L,9L,27L,22L,14L,29L,36L,16L,10L,19L,43L,34L,21L,41L,48L,26L,11L,23L,55L,50L,28L,57L,64L,30L,17L,33L,71L,62L,35L,69L,76L,40L,18L,37L,83L,78L,42L,85L,92L,44L,24L,47L,99L,90L,49L,97L,104L,54L,25L,51L,111L,106L,56L,113L,120L,58L,31L,61L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160105Inst : IEnumerable<long>
{
public static readonly long[] Value=A160105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160105.Bytes);
public long this[int i]=>Value[i];

public static A160105Inst Instance=new A160105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160106
{
public static readonly long[] Value={ 3L,2L,5L,9L,1L,5L,3L,8L,4L,7L,9L,8L,6L,1L,8L,9L,9L,1L,6L,2L,5L,7L,1L,7L,8L,0L,6L,8L,8L,5L,0L,1L,5L,8L,8L,1L,1L,2L,0L,8L,6L,2L,1L,1L,5L,0L,5L,8L,7L,7L,8L,0L,7L,7L,6L,4L,5L,0L,7L,2L,8L,7L,0L,2L,5L,0L,4L,8L,0L,9L,7L,0L,2L,1L,2L,5L,0L,1L,7L,4L,1L,3L,3L,1L,7L,5L,6L,1L,7L,3L,6L,5L,3L,6L,4L,5L,8L,7L,4L,3L,2L,3L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160106Inst : IEnumerable<long>
{
public static readonly long[] Value=A160106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160106.Bytes);
public long this[int i]=>Value[i];

public static A160106Inst Instance=new A160106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160107
{
public static readonly BigInteger[] Value={ 1L,14L,-1262L,-58492L,4701100L,406940744L,-28573848584L,-3959951508688L,236185377526672L,49495469682710240L,-2406287948347046624L,BigInteger.Parse("-755331979250773951936"),BigInteger.Parse("28017398406079098428608"),BigInteger.Parse("13607531886656648441072768"),BigInteger.Parse("-340536322975630153440817280") };
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
public class A160107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160107Inst Instance=new A160107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160108
{
public static readonly long[] Value={ 0L,1L,9L,2L,3L,5L,8L,13L,21L,10L,7L,17L,16L,25L,33L,18L,11L,29L,24L,37L,45L,26L,15L,41L,32L,49L,57L,34L,19L,53L,40L,61L,69L,42L,23L,65L,48L,73L,81L,50L,27L,77L,56L,85L,93L,58L,31L,89L,64L,97L,105L,66L,35L,101L,72L,109L,117L,74L,39L,113L,80L,121L,129L,82L,43L,125L,88L,133L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160108Inst : IEnumerable<long>
{
public static readonly long[] Value=A160108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160108.Bytes);
public long this[int i]=>Value[i];

public static A160108Inst Instance=new A160108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160109
{
public static readonly long[] Value={ 5L,6L,15L,16L,24L,25L,26L,75L,76L,85L,94L,165L,166L,184L,194L,235L,256L,275L,475L,476L,485L,515L,516L,525L,526L,535L,594L,606L,615L,725L,734L,744L,765L,766L,816L,826L,856L,874L,875L,876L,885L,915L,924L,925L,934L,1524L,1525L,1526L,1535L,1624L,1635L,1665L,1666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160109Inst : IEnumerable<long>
{
public static readonly long[] Value=A160109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160109.Bytes);
public long this[int i]=>Value[i];

public static A160109Inst Instance=new A160109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160110
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,1L,10L,1382L,28L,3617L,87734L,349222L,3418052L,472728182L,34212412L,94997844116L,68926730208040L,7709321041217L,5155375716734L,BigInteger.Parse("52630543106106954746"),11719975655366236L,BigInteger.Parse("522165436992898244102") };
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
public class A160110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160110Inst Instance=new A160110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160111
{
public static readonly long[] Value={ 24L,874L,1524L,4874L,5124L,48874L,93474L,271524L,506524L,1500874L,1528474L,2373474L,2501524L,2506524L,2526524L,2555124L,7521524L,7531524L,18805124L,24951124L,25005124L,47778474L,153794874L,194506524L,250271524L,515126524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160111Inst : IEnumerable<long>
{
public static readonly long[] Value=A160111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160111.Bytes);
public long this[int i]=>Value[i];

public static A160111Inst Instance=new A160111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160112
{
public static readonly long[] Value={ 1L,9L,85L,833L,8319L,83190L,831910L,8319081L,83190727L,831907372L,8319073719L,83190737244L,831907372522L,8319073725828L,83190737258105L,831907372580692L,8319073725807178L,83190737258070643L,831907372580707771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160112Inst : IEnumerable<long>
{
public static readonly long[] Value=A160112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160112.Bytes);
public long this[int i]=>Value[i];

public static A160112Inst Instance=new A160112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160113
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,27L,54L,107L,214L,427L,854L,1706L,3410L,6815L,13629L,27259L,54521L,109042L,218080L,436158L,872318L,1744638L,3489278L,6978546L,13957092L,27914186L,55828364L,111656716L,223313428L,446626866L,893253744L,1786507472L,3573014938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160113Inst : IEnumerable<long>
{
public static readonly long[] Value=A160113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160113.Bytes);
public long this[int i]=>Value[i];

public static A160113Inst Instance=new A160113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160114
{
public static readonly long[] Value={ 0L,1L,2L,1L,0L,-1L,3L,7L,-10L,-1L,-7L,-14L,-59L,21L,34L,-15L,103L,-104L,302L,-38L,-514L,-290L,1130L,504L,2466L,6813L,-1854L,1590L,-4879L,3963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160114Inst : IEnumerable<long>
{
public static readonly long[] Value=A160114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160114.Bytes);
public long this[int i]=>Value[i];

public static A160114Inst Instance=new A160114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160115
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,2L,3L,0L,-1L,-1L,1L,2L,0L,-1L,0L,2L,6L,1L,2L,7L,5L,-1L,-7L,-4L,4L,-7L,-21L,-7L,-2L,30L,2L,14L,-8L,7L,-1L,-7L,-12L,-1L,21L,28L,7L,-29L,-33L,-76L,-88L,15L,47L,58L,-51L,-112L,293L,122L,316L,-96L,-42L,-259L,140L,-111L,6L,-790L,-342L,146L,395L,1087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160115Inst : IEnumerable<long>
{
public static readonly long[] Value=A160115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160115.Bytes);
public long this[int i]=>Value[i];

public static A160115Inst Instance=new A160115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160116
{
public static readonly BigInteger[] Value={ 279L,3348L,497842924845L,360L,1120426251L,84L,BigInteger.Parse("1034482758620689655172413793"),2745L,764237181279L,8878058443575583668L,107984565L,103551L,BigInteger.Parse("316069797264352410612542355"),25056L,BigInteger.Parse("10641813669975233258166411970121148474098929093423000284337408425") };
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
public class A160116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160116Inst Instance=new A160116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160117
{
public static readonly long[] Value={ 0L,1L,9L,13L,41L,49L,101L,113L,189L,205L,305L,325L,449L,473L,621L,649L,821L,853L,1049L,1085L,1305L,1345L,1589L,1633L,1901L,1949L,2241L,2293L,2609L,2665L,3005L,3065L,3429L,3493L,3881L,3949L,4361L,4433L,4869L,4945L,5405L,5485L,5969L,6053L,6561L,6649L,7181L,7273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160117Inst : IEnumerable<long>
{
public static readonly long[] Value=A160117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160117.Bytes);
public long this[int i]=>Value[i];

public static A160117Inst Instance=new A160117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160118
{
public static readonly long[] Value={ 0L,1L,9L,13L,41L,45L,73L,85L,169L,173L,201L,213L,297L,309L,393L,429L,681L,685L,713L,725L,809L,821L,905L,941L,1193L,1205L,1289L,1325L,1577L,1613L,1865L,1973L,2729L,2733L,2761L,2773L,2857L,2869L,2953L,2989L,3241L,3253L,3337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160118Inst : IEnumerable<long>
{
public static readonly long[] Value=A160118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160118.Bytes);
public long this[int i]=>Value[i];

public static A160118Inst Instance=new A160118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160119
{
public static readonly long[] Value={ 0L,1L,27L,35L,235L,243L,443L,499L,1899L,1907L,2107L,2163L,3563L,3619L,5019L,5411L,15211L,15219L,15419L,15475L,16875L,16931L,18331L,18723L,28523L,28579L,29979L,30371L,40171L,40563L,50363L,53107L,121707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160119Inst : IEnumerable<long>
{
public static readonly long[] Value=A160119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160119.Bytes);
public long this[int i]=>Value[i];

public static A160119Inst Instance=new A160119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160120
{
public static readonly long[] Value={ 0L,1L,4L,7L,16L,19L,28L,37L,58L,67L,76L,85L,106L,121L,142L,169L,220L,247L,256L,265L,286L,301L,322L,349L,400L,433L,454L,481L,532L,583L,640L,709L,826L,907L,928L,937L,958L,973L,994L,1021L,1072L,1105L,1126L,1153L,1204L,1255L,1312L,1381L,1498L,1585L,1618L,1645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160120Inst : IEnumerable<long>
{
public static readonly long[] Value=A160120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160120.Bytes);
public long this[int i]=>Value[i];

public static A160120Inst Instance=new A160120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160121
{
public static readonly long[] Value={ 1L,3L,3L,9L,3L,9L,9L,21L,9L,9L,9L,21L,15L,21L,27L,51L,27L,9L,9L,21L,15L,21L,27L,51L,33L,21L,27L,51L,51L,57L,69L,117L,81L,21L,9L,21L,15L,21L,27L,51L,33L,21L,27L,51L,51L,57L,69L,117L,87L,33L,27L,51L,51L,57L,75L,129L,117L,75L,69L,117L,135L,141L,171L,279L,231L,69L,9L,21L,15L,21L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160121Inst : IEnumerable<long>
{
public static readonly long[] Value=A160121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160121.Bytes);
public long this[int i]=>Value[i];

public static A160121Inst Instance=new A160121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160122
{
public static readonly long[] Value={ 2L,2L,6L,2L,6L,6L,14L,6L,6L,6L,14L,10L,14L,18L,34L,18L,6L,6L,14L,10L,14L,18L,34L,22L,14L,18L,34L,34L,38L,46L,78L,54L,14L,6L,14L,10L,14L,18L,34L,22L,14L,18L,34L,34L,38L,46L,78L,58L,22L,18L,34L,34L,38L,50L,86L,78L,50L,46L,78L,90L,94L,114L,186L,154L,46L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160122Inst : IEnumerable<long>
{
public static readonly long[] Value=A160122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160122.Bytes);
public long this[int i]=>Value[i];

public static A160122Inst Instance=new A160122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160123
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,3L,7L,3L,3L,3L,7L,5L,7L,9L,17L,9L,3L,3L,7L,5L,7L,9L,17L,11L,7L,9L,17L,17L,19L,23L,39L,27L,7L,3L,7L,5L,7L,9L,17L,11L,7L,9L,17L,17L,19L,23L,39L,29L,11L,9L,17L,17L,19L,25L,43L,39L,25L,23L,39L,45L,47L,57L,93L,77L,23L,3L,7L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160123Inst : IEnumerable<long>
{
public static readonly long[] Value=A160123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160123.Bytes);
public long this[int i]=>Value[i];

public static A160123Inst Instance=new A160123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160124
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,4L,8L,18L,24L,24L,28L,36L,40L,44L,64L,94L,108L,108L,112L,120L,124L,128L,148L,176L,188L,192L,208L,228L,240L,268L,340L,418L,448L,448L,452L,460L,464L,468L,488L,516L,528L,532L,548L,568L,580L,608L,680L,756L,784L,788L,804L,824L,836L,864L,932L,1000L,1028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160124Inst : IEnumerable<long>
{
public static readonly long[] Value=A160124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160124.Bytes);
public long this[int i]=>Value[i];

public static A160124Inst Instance=new A160124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160125
{
public static readonly long[] Value={ 0L,0L,2L,2L,0L,4L,10L,6L,0L,4L,8L,4L,4L,20L,30L,14L,0L,4L,8L,4L,4L,20L,28L,12L,4L,16L,20L,12L,28L,72L,78L,30L,0L,4L,8L,4L,4L,20L,28L,12L,4L,16L,20L,12L,28L,72L,76L,28L,4L,16L,20L,12L,28L,68L,68L,28L,24L,52L,52L,52L,128L,224L,190L,62L,0L,4L,8L,4L,4L,20L,28L,12L,4L,16L,20L,12L,28L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160125Inst : IEnumerable<long>
{
public static readonly long[] Value=A160125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160125.Bytes);
public long this[int i]=>Value[i];

public static A160125Inst Instance=new A160125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160126
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,4L,9L,12L,12L,14L,18L,20L,22L,32L,47L,54L,54L,56L,60L,62L,64L,74L,88L,94L,96L,104L,114L,120L,134L,170L,209L,224L,224L,226L,230L,232L,234L,244L,258L,264L,266L,274L,284L,290L,304L,340L,378L,392L,394L,402L,412L,418L,432L,466L,500L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160126Inst : IEnumerable<long>
{
public static readonly long[] Value=A160126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160126.Bytes);
public long this[int i]=>Value[i];

public static A160126Inst Instance=new A160126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160127
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,5L,3L,0L,2L,4L,2L,2L,10L,15L,7L,0L,2L,4L,2L,2L,10L,14L,6L,2L,8L,10L,6L,14L,36L,39L,15L,0L,2L,4L,2L,2L,10L,14L,6L,2L,8L,10L,6L,14L,36L,38L,14L,2L,8L,10L,6L,14L,34L,34L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160127Inst : IEnumerable<long>
{
public static readonly long[] Value=A160127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160127.Bytes);
public long this[int i]=>Value[i];

public static A160127Inst Instance=new A160127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160128
{
public static readonly long[] Value={ 3L,7L,19L,63L,235L,919L,3651L,14575L,58267L,233031L,932083L,3728287L,14913099L,59652343L,238609315L,954437199L,3817748731L,15270994855L,61083979347L,244335917311L,977343669163L,3909374676567L,15637498706179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160128Inst : IEnumerable<long>
{
public static readonly long[] Value=A160128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160128.Bytes);
public long this[int i]=>Value[i];

public static A160128Inst Instance=new A160128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160129
{
public static readonly long[] Value={ 11L,17L,23L,29L,37L,43L,47L,53L,59L,67L,71L,79L,89L,89L,101L,101L,109L,131L,127L,131L,131L,137L,179L,149L,157L,193L,191L,179L,179L,193L,193L,197L,211L,227L,223L,223L,227L,233L,257L,251L,257L,257L,263L,277L,277L,281L,311L,311L,307L,307L,311L,331L,359L,337L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160129Inst : IEnumerable<long>
{
public static readonly long[] Value=A160129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160129.Bytes);
public long this[int i]=>Value[i];

public static A160129Inst Instance=new A160129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160130
{
public static readonly long[] Value={ 13L,11L,12L,18L,82L,74L,50L,58L,34L,44L,60L,121L,81L,36L,51L,19L,13L,49L,52L,48L,36L,12L,44L,53L,33L,68L,59L,9L,41L,53L,48L,30L,4L,36L,104L,100L,35L,52L,94L,51L,26L,87L,63L,81L,108L,45L,81L,108L,54L,9L,45L,85L,54L,14L,81L,123L,66L,105L,105L,52L,58L,48L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160130Inst : IEnumerable<long>
{
public static readonly long[] Value=A160130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160130.Bytes);
public long this[int i]=>Value[i];

public static A160130Inst Instance=new A160130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160131
{
public static readonly BigInteger[] Value={ 1L,16L,-1202L,-65888L,4203340L,451512256L,-23418152504L,-4324519655552L,169813349966992L,53158210861830400L,-1377759404477582624L,BigInteger.Parse("-797090864837128553984"),BigInteger.Parse("9343051491617413259968"),BigInteger.Parse("14095390595056279792663552"),BigInteger.Parse("48438051548784025753183360"),BigInteger.Parse("-286940104001508238715797489664") };
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
public class A160131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160131Inst Instance=new A160131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160132
{
public static readonly BigInteger[] Value={ 1L,20L,-1058L,-79480L,3038092L,524289200L,-11661906680L,-4819720055200L,22627018472080L,56669755093294400L,836483365475254240L,BigInteger.Parse("-809515361950727267200"),BigInteger.Parse("-29605827454506672845120"),BigInteger.Parse("13571164223599790810028800"),BigInteger.Parse("832572138044715293306980480") };
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
public class A160132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160132Inst Instance=new A160132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160133
{
public static readonly long[] Value={ 1L,6L,8L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,27L,29L,31L,32L,33L,35L,37L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,59L,61L,62L,63L,64L,65L,67L,69L,71L,73L,74L,75L,76L,77L,79L,81L,83L,85L,87L,89L,90L,91L,92L,93L,95L,97L,99L,100L,101L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160133Inst : IEnumerable<long>
{
public static readonly long[] Value=A160133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160133.Bytes);
public long this[int i]=>Value[i];

public static A160133Inst Instance=new A160133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160134
{
public static readonly long[] Value={ 180L,252L,396L,468L,612L,684L,828L,1044L,1116L,1260L,1332L,1476L,1548L,1692L,1908L,1980L,2124L,2196L,2340L,2412L,2556L,2628L,2772L,2844L,2988L,3060L,3204L,3276L,3420L,3492L,3636L,3708L,3852L,3924L,4068L,4140L,4284L,4572L,4716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160134Inst : IEnumerable<long>
{
public static readonly long[] Value=A160134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160134.Bytes);
public long this[int i]=>Value[i];

public static A160134Inst Instance=new A160134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160135
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,1L,5L,1L,8L,1L,10L,1L,10L,9L,9L,1L,15L,1L,12L,11L,14L,1L,30L,1L,16L,10L,14L,1L,42L,1L,29L,15L,20L,13L,19L,1L,22L,17L,40L,1L,54L,1L,18L,18L,26L,1L,58L,1L,33L,21L,20L,1L,60L,17L,50L,23L,32L,1L,78L,1L,34L,20L,49L,19L,78L,1L,24L,27L,74L,1L,75L,1L,40L,34L,26L,19L,90L,1L,76L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160135Inst : IEnumerable<long>
{
public static readonly long[] Value=A160135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160135.Bytes);
public long this[int i]=>Value[i];

public static A160135Inst Instance=new A160135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160136
{
public static readonly long[] Value={ 0L,1L,10L,2L,3L,5L,8L,4L,12L,7L,19L,17L,9L,26L,35L,16L,6L,13L,28L,14L,15L,11L,44L,37L,18L,46L,55L,20L,21L,23L,53L,22L,30L,25L,64L,62L,27L,71L,80L,34L,24L,31L,73L,32L,33L,29L,89L,82L,36L,91L,100L,38L,39L,41L,98L,40L,48L,43L,109L,107L,45L,116L,125L,52L,42L,49L,118L,50L,51L,47L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160136Inst : IEnumerable<long>
{
public static readonly long[] Value=A160136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160136.Bytes);
public long this[int i]=>Value[i];

public static A160136Inst Instance=new A160136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160137
{
public static readonly long[] Value={ 0L,1L,11L,2L,3L,5L,8L,13L,21L,4L,15L,9L,14L,23L,7L,10L,17L,27L,24L,31L,25L,6L,41L,37L,18L,35L,33L,28L,51L,19L,20L,29L,39L,38L,47L,45L,12L,57L,49L,16L,55L,61L,26L,67L,43L,30L,53L,63L,36L,59L,65L,34L,69L,73L,22L,75L,77L,32L,79L,71L,40L,81L,91L,42L,83L,85L,48L,93L,101L,44L,95L,89L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160137Inst : IEnumerable<long>
{
public static readonly long[] Value=A160137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160137.Bytes);
public long this[int i]=>Value[i];

public static A160137Inst Instance=new A160137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160138
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,6L,7L,9L,11L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160138Inst : IEnumerable<long>
{
public static readonly long[] Value=A160138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160138.Bytes);
public long this[int i]=>Value[i];

public static A160138Inst Instance=new A160138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160139
{
public static readonly BigInteger[] Value={ 1L,22L,-974L,-85580L,2377516L,551407912L,-5201117576L,-4938141000848L,-55556496038000L,56376233721055072L,1969289482873847584L,BigInteger.Parse("-778641119029758302912"),BigInteger.Parse("-48713569344985450216256"),BigInteger.Parse("12551406492954971362990720"),BigInteger.Parse("1199447936209863593384712064") };
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
public class A160139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160139Inst Instance=new A160139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160140
{
public static readonly BigInteger[] Value={ 1L,26L,-782L,-96148L,920620L,584671256L,8490132856L,-4893960693232L,-213893273952368L,51521932403096480L,4146277783283481376L,BigInteger.Parse("-643386552071776162624"),BigInteger.Parse("-83226053442166654536512"),BigInteger.Parse("9092813725551462723320192"),BigInteger.Parse("1813879773807164800891373440") };
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
public class A160140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160140Inst Instance=new A160140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160141
{
public static readonly BigInteger[] Value={ 1L,28L,-674L,-100520L,133516L,589971088L,15545858824L,-4725783030752L,-290982960018800L,46974010390164928L,5133550692291311584L,BigInteger.Parse("-541141652104447925888"),BigInteger.Parse("-97483852261892597109056"),BigInteger.Parse("6738266481886428192282880"),BigInteger.Parse("2036380397264732274988968064"),BigInteger.Parse("-80522844304853268561187040768") };
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
public class A160141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160141Inst Instance=new A160141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160142
{
public static readonly BigInteger[] Value={ 1L,32L,-434L,-107200L,-1532084L,576163712L,29606131144L,-4092883955968L,-433132461046640L,33879159708918272L,6767697264539394784L,BigInteger.Parse("-277391836090767772672"),BigInteger.Parse("-117416867483587382271296"),BigInteger.Parse("1095907804769276717987840"),BigInteger.Parse("2260588356036532098545755264") };
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
public class A160142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160142Inst Instance=new A160142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160143
{
public static readonly BigInteger[] Value={ 1L,3L,25L,427L,12465L,555731L,35135945L,2990414715L,329655706465L,45692713833379L,1111113564712575L,1595024111042171723L,BigInteger.Parse("387863354088927172625"),BigInteger.Parse("110350957750914345093747") };
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
public class A160143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160143Inst Instance=new A160143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160144
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,3L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,9L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,15L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160144Inst : IEnumerable<long>
{
public static readonly long[] Value=A160144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160144.Bytes);
public long this[int i]=>Value[i];

public static A160144Inst Instance=new A160144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160145
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,18L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,54L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,90L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,144L,0L,0L,0L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160145Inst : IEnumerable<long>
{
public static readonly long[] Value=A160145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160145.Bytes);
public long this[int i]=>Value[i];

public static A160145Inst Instance=new A160145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160146
{
public static readonly BigInteger[] Value={ 1L,34L,-302L,-109412L,-2399060L,556522744L,36410920696L,-3630489660848L,-495046505092208L,25514450230996000L,7363491547673817376L,BigInteger.Parse("-121641971747011889216"),BigInteger.Parse("-122231504480991087309632"),BigInteger.Parse("-2027623214667976954804352"),BigInteger.Parse("2247836746633993852403416960") };
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
public class A160146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160146Inst Instance=new A160146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160147
{
public static readonly BigInteger[] Value={ 1L,38L,-14L,-111340L,-4169684L,490886888L,49050698104L,-2430351968272L,-592964799643760L,5814962971461728L,8001852693840964384L,BigInteger.Parse("219288242242044652352"),BigInteger.Parse("-120000760298623690001216"),BigInteger.Parse("-8396695977614513457596800"),BigInteger.Parse("1955419963550761908894369664") };
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
public class A160147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160147Inst Instance=new A160147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160148
{
public static readonly BigInteger[] Value={ 1L,40L,142L,-110960L,-5059508L,444738400L,54673349320L,-1703637550400L,-626141705175920L,-5174439819171200L,8009253862551574240L,BigInteger.Parse("395813487065579065600"),BigInteger.Parse("-112619873964978985037120"),BigInteger.Parse("-11429947728298530733222400"),BigInteger.Parse("1677399182000270453064676480") };
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
public class A160148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160148Inst Instance=new A160148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160149
{
public static readonly BigInteger[] Value={ 1L,596L,175294L,49483138L,13916993782L,3913787773536L,1100831164969864L,309656520296472068L,BigInteger.Parse("87106950271042689032"),BigInteger.Parse("24503579727182933530758"),BigInteger.Parse("6892987382635818948665404"),BigInteger.Parse("1939035566761570513740174424") };
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
public class A160149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160149.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160149Inst Instance=new A160149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160150
{
public static readonly BigInteger[] Value={ 1L,44L,478L,-107272L,-6810740L,325937744L,63991555336L,-35674949728L,-654667511547248L,-28389257894451520L,7341419739167121376L,BigInteger.Parse("736937848624456502144"),BigInteger.Parse("-85316424437286206533952"),BigInteger.Parse("-16647387274774084049005312"),BigInteger.Parse("884602468694263060488292480") };
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
public class A160150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160150Inst Instance=new A160150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160151
{
public static readonly BigInteger[] Value={ 1L,46L,658L,-103868L,-7656020L,253581256L,67477123576L,885618857008L,-647933055794288L,-40134778914678560L,6655977728057433376L,BigInteger.Parse("891340052066655340096"),BigInteger.Parse("-65746928407518970839872"),BigInteger.Parse("-18619244257704074488953728"),BigInteger.Parse("389682045181727146807062400") };
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
public class A160151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160151Inst Instance=new A160151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160152
{
public static readonly BigInteger[] Value={ 1L,50L,1042L,-93700L,-9242708L,84323000L,71595491320L,2842116962000L,-588597736311920L,-62580339060364000L,4594562542866814240L,BigInteger.Parse("1142149470643447832000"),BigInteger.Parse("-16580120530325575181120"),BigInteger.Parse("-20812053164894042027728000"),BigInteger.Parse("-726343053712911149403451520") };
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
public class A160152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160152Inst Instance=new A160152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160153
{
public static readonly BigInteger[] Value={ 1L,52L,1246L,-86840L,-9965684L,-11764688L,72038072584L,3848897264992L,-535077911012720L,-72717589071528128L,3239977716589449184L,BigInteger.Parse("1228701289925531463808"),BigInteger.Parse("11929704457466050105024"),BigInteger.Parse("-20877013136748863885323520"),BigInteger.Parse("-1311720301397752435727447936") };
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
public class A160153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160153Inst Instance=new A160153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160154
{
public static readonly long[] Value={ 0L,1L,82L,973L,9964L,99955L,999946L,9999937L,99999928L,999999919L,9999999910L,99999999901L,999999999892L,9999999999883L,99999999999874L,999999999999865L,9999999999999856L,99999999999999847L,999999999999999838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160154Inst : IEnumerable<long>
{
public static readonly long[] Value=A160154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160154.Bytes);
public long this[int i]=>Value[i];

public static A160154Inst Instance=new A160154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160155
{
public static readonly long[] Value={ 1L,1L,6L,7L,3L,0L,3L,9L,7L,8L,2L,6L,1L,4L,1L,8L,6L,8L,4L,2L,5L,6L,0L,4L,5L,8L,9L,9L,8L,5L,4L,8L,4L,2L,1L,8L,0L,7L,2L,0L,5L,6L,0L,3L,7L,1L,5L,2L,5L,4L,8L,9L,0L,3L,9L,1L,4L,0L,0L,8L,2L,4L,4L,9L,2L,7L,5L,6L,5L,1L,9L,0L,3L,4L,2L,9L,5L,2L,7L,0L,5L,3L,1L,8L,0L,6L,8L,5L,2L,0L,5L,0L,4L,9L,7L,2L,8L,6L,7L,2L,8L,9L,5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160155Inst : IEnumerable<long>
{
public static readonly long[] Value=A160155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160155.Bytes);
public long this[int i]=>Value[i];

public static A160155Inst Instance=new A160155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160156
{
public static readonly long[] Value={ 1L,4L,15L,58L,229L,912L,3643L,14566L,58257L,233020L,932071L,3728274L,14913085L,59652328L,238609299L,954437182L,3817748713L,15270994836L,61083979327L,244335917290L,977343669141L,3909374676544L,15637498706155L,62549994824598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160156Inst : IEnumerable<long>
{
public static readonly long[] Value=A160156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160156.Bytes);
public long this[int i]=>Value[i];

public static A160156Inst Instance=new A160156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160157
{
public static readonly long[] Value={ 0L,2L,8L,14L,32L,38L,56L,74L,116L,134L,152L,170L,212L,242L,284L,338L,440L,494L,512L,530L,572L,602L,644L,698L,800L,866L,908L,962L,1064L,1166L,1280L,1418L,1652L,1814L,1856L,1874L,1916L,1946L,1988L,2042L,2144L,2210L,2252L,2306L,2408L,2510L,2624L,2762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160157Inst : IEnumerable<long>
{
public static readonly long[] Value=A160157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160157.Bytes);
public long this[int i]=>Value[i];

public static A160157Inst Instance=new A160157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160158
{
public static readonly long[] Value={ 0L,2L,4L,8L,16L,24L,28L,36L,48L,56L,64L,80L,104L,124L,136L,156L,176L,184L,192L,208L,232L,252L,268L,296L,328L,352L,384L,440L,508L,560L,600L,652L,688L,696L,704L,720L,744L,764L,780L,808L,840L,864L,896L,952L,1020L,1072L,1116L,1176L,1224L,1248L,1280L,1336L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160158Inst : IEnumerable<long>
{
public static readonly long[] Value=A160158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160158.Bytes);
public long this[int i]=>Value[i];

public static A160158Inst Instance=new A160158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160159
{
public static readonly long[] Value={ 2L,2L,4L,8L,8L,4L,8L,12L,8L,8L,16L,24L,20L,12L,20L,20L,8L,8L,16L,24L,20L,16L,28L,32L,24L,32L,56L,68L,52L,40L,52L,36L,8L,8L,16L,24L,20L,16L,28L,32L,24L,32L,56L,68L,52L,44L,60L,48L,24L,32L,56L,68L,56L,60L,88L,88L,80L,120L,180L,188L,144L,128L,132L,68L,8L,8L,16L,24L,20L,16L,28L,32L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160159Inst : IEnumerable<long>
{
public static readonly long[] Value=A160159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160159.Bytes);
public long this[int i]=>Value[i];

public static A160159Inst Instance=new A160159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160160
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,23L,31L,39L,55L,87L,143L,175L,191L,199L,215L,247L,303L,359L,423L,503L,655L,887L,1239L,1383L,1431L,1463L,1487L,1527L,1583L,1639L,1703L,1783L,1935L,2167L,2519L,2735L,2903L,3079L,3351L,3711L,4207L,4655L,5191L,5855L,7023L,8511L,10511L,11279L,11583L,11919L,12183L,12375L,12487L,12607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160160Inst : IEnumerable<long>
{
public static readonly long[] Value=A160160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160160.Bytes);
public long this[int i]=>Value[i];

public static A160160Inst Instance=new A160160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160161
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,8L,8L,8L,16L,32L,56L,32L,16L,8L,16L,32L,56L,56L,64L,80L,152L,232L,352L,144L,48L,32L,24L,40L,56L,56L,64L,80L,152L,232L,352L,216L,168L,176L,272L,360L,496L,448L,536L,664L,1168L,1488L,2000L,768L,304L,336L,264L,192L,112L,120L,128L,112L,168L,240L,352L,216L,168L,176L,272L,360L,496L,448L,536L,664L,1168L,1488L,2000L,984L,656L,736L,928L,928L,928L,808L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160161Inst : IEnumerable<long>
{
public static readonly long[] Value=A160161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160161.Bytes);
public long this[int i]=>Value[i];

public static A160161Inst Instance=new A160161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160162
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,12L,14L,18L,24L,28L,32L,40L,52L,62L,68L,78L,88L,92L,96L,104L,116L,126L,134L,148L,164L,176L,192L,220L,254L,280L,300L,326L,344L,348L,352L,360L,372L,382L,390L,404L,420L,432L,448L,476L,510L,536L,558L,588L,612L,624L,640L,668L,702L,730L,760L,804L,848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160162Inst : IEnumerable<long>
{
public static readonly long[] Value=A160162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160162.Bytes);
public long this[int i]=>Value[i];

public static A160162Inst Instance=new A160162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160163
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,2L,4L,6L,4L,4L,8L,12L,10L,6L,10L,10L,4L,4L,8L,12L,10L,8L,14L,16L,12L,16L,28L,34L,26L,20L,26L,18L,4L,4L,8L,12L,10L,8L,14L,16L,12L,16L,28L,34L,26L,22L,30L,24L,12L,16L,28L,34L,28L,30L,44L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160163Inst : IEnumerable<long>
{
public static readonly long[] Value=A160163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160163.Bytes);
public long this[int i]=>Value[i];

public static A160163Inst Instance=new A160163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160164
{
public static readonly long[] Value={ 0L,2L,6L,14L,22L,30L,46L,70L,86L,94L,110L,134L,158L,190L,246L,310L,342L,350L,366L,390L,414L,446L,502L,566L,606L,638L,694L,766L,846L,966L,1142L,1302L,1366L,1374L,1390L,1414L,1438L,1470L,1526L,1590L,1630L,1662L,1718L,1790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160164Inst : IEnumerable<long>
{
public static readonly long[] Value=A160164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160164.Bytes);
public long this[int i]=>Value[i];

public static A160164Inst Instance=new A160164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160165
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,3L,0L,2L,10L,15L,17L,21L,22L,12L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160165Inst : IEnumerable<long>
{
public static readonly long[] Value=A160165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160165.Bytes);
public long this[int i]=>Value[i];

public static A160165Inst Instance=new A160165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160166
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,5L,6L,7L,2L,4L,2L,6L,8L,23L,28L,29L,16L,14L,4L,4L,-2L,9L,7L,9L,-1L,9L,10L,31L,54L,103L,120L,121L,92L,82L,56L,48L,26L,29L,11L,5L,-21L,-19L,-34L,-21L,-14L,27L,29L,27L,-7L,-9L,-32L,-23L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160166Inst : IEnumerable<long>
{
public static readonly long[] Value=A160166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160166.Bytes);
public long this[int i]=>Value[i];

public static A160166Inst Instance=new A160166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160167
{
public static readonly long[] Value={ 0L,3L,12L,21L,48L,57L,84L,111L,174L,201L,228L,255L,318L,363L,426L,507L,660L,741L,768L,795L,858L,903L,966L,1047L,1200L,1299L,1362L,1443L,1596L,1749L,1920L,2127L,2478L,2721L,2784L,2811L,2874L,2919L,2982L,3063L,3216L,3315L,3378L,3459L,3612L,3765L,3936L,4143L,4494L,4755L,4854L,4935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160167Inst : IEnumerable<long>
{
public static readonly long[] Value=A160167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160167.Bytes);
public long this[int i]=>Value[i];

public static A160167Inst Instance=new A160167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160168
{
public static readonly long[] Value={ 2L,1L,0L,4L,7L,5L,3L,8L,11L,10L,6L,13L,16L,14L,9L,17L,20L,19L,12L,22L,25L,23L,15L,26L,29L,28L,18L,31L,34L,32L,21L,35L,38L,37L,24L,40L,43L,41L,27L,44L,47L,46L,30L,49L,52L,50L,33L,53L,56L,55L,36L,58L,61L,59L,39L,62L,65L,64L,42L,67L,70L,68L,45L,71L,74L,73L,48L,76L,79L,77L,51L,80L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160168Inst : IEnumerable<long>
{
public static readonly long[] Value=A160168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160168.Bytes);
public long this[int i]=>Value[i];

public static A160168Inst Instance=new A160168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160169
{
public static readonly long[] Value={ 2L,1L,3L,0L,7L,11L,6L,5L,15L,4L,19L,23L,10L,9L,27L,8L,31L,35L,14L,13L,39L,12L,43L,47L,18L,17L,51L,16L,55L,59L,22L,21L,63L,20L,67L,71L,26L,25L,75L,24L,79L,83L,30L,29L,87L,28L,91L,95L,34L,33L,99L,32L,103L,107L,38L,37L,111L,36L,115L,119L,42L,41L,123L,40L,127L,131L,46L,45L,135L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160169Inst : IEnumerable<long>
{
public static readonly long[] Value=A160169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160169.Bytes);
public long this[int i]=>Value[i];

public static A160169Inst Instance=new A160169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160170
{
public static readonly long[] Value={ 0L,1L,5L,13L,21L,45L,77L,109L,165L,245L,325L,413L,525L,685L,853L,1093L,1317L,1661L,1981L,2301L,2645L,3093L,3621L,4157L,4861L,5565L,6437L,7173L,8053L,8893L,9917L,11005L,12261L,13589L,14981L,16397L,17837L,19341L,20997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160170Inst : IEnumerable<long>
{
public static readonly long[] Value=A160170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160170.Bytes);
public long this[int i]=>Value[i];

public static A160170Inst Instance=new A160170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160171
{
public static readonly long[] Value={ 0L,1L,4L,8L,8L,24L,32L,32L,56L,80L,80L,88L,112L,160L,168L,240L,224L,344L,320L,320L,344L,448L,528L,536L,704L,704L,872L,736L,880L,840L,1024L,1088L,1256L,1328L,1392L,1416L,1440L,1504L,1656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160171Inst : IEnumerable<long>
{
public static readonly long[] Value=A160171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160171.Bytes);
public long this[int i]=>Value[i];

public static A160171Inst Instance=new A160171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160172
{
public static readonly long[] Value={ 0L,1L,4L,9L,18L,27L,36L,49L,74L,95L,104L,117L,142L,167L,192L,229L,302L,359L,368L,381L,406L,431L,456L,493L,566L,627L,652L,689L,762L,835L,908L,1017L,1234L,1399L,1408L,1421L,1446L,1471L,1496L,1533L,1606L,1667L,1692L,1729L,1802L,1875L,1948L,2057L,2274L,2443L,2468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160172Inst : IEnumerable<long>
{
public static readonly long[] Value=A160172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160172.Bytes);
public long this[int i]=>Value[i];

public static A160172Inst Instance=new A160172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160173
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,9L,9L,13L,25L,21L,9L,13L,25L,25L,25L,37L,73L,57L,9L,13L,25L,25L,25L,37L,73L,61L,25L,37L,73L,73L,73L,109L,217L,165L,9L,13L,25L,25L,25L,37L,73L,61L,25L,37L,73L,73L,73L,109L,217L,169L,25L,37L,73L,73L,73L,109L,217L,181L,73L,109L,217L,217L,217L,325L,649L,489L,9L,13L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160173Inst : IEnumerable<long>
{
public static readonly long[] Value=A160173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160173.Bytes);
public long this[int i]=>Value[i];

public static A160173Inst Instance=new A160173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160174
{
public static readonly long[] Value={ 1L,93L,545L,1645L,3681L,6941L,11713L,18285L,26945L,37981L,51681L,68333L,88225L,111645L,138881L,170221L,205953L,246365L,291745L,342381L,398561L,460573L,528705L,603245L,684481L,772701L,868193L,971245L,1082145L,1201181L,1328641L,1464813L,1609985L,1764445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160174Inst : IEnumerable<long>
{
public static readonly long[] Value=A160174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160174.Bytes);
public long this[int i]=>Value[i];

public static A160174Inst Instance=new A160174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160175
{
public static readonly long[] Value={ 1L,2L,6L,18L,54L,160L,476L,1416L,4212L,12528L,37264L,110840L,329688L,980640L,2916864L,8676064L,25806512L,76760160L,228319200L,679123872L,2020019488L,6008445440L,17871816000L,53158809600L,158118181056L,470314504192L,1398926621696L,4161036233088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160175Inst : IEnumerable<long>
{
public static readonly long[] Value=A160175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160175.Bytes);
public long this[int i]=>Value[i];

public static A160175Inst Instance=new A160175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160176
{
public static readonly long[] Value={ 533L,617L,733L,2465L,3085L,3865L,14257L,17893L,22457L,83077L,104273L,130877L,484205L,607745L,762805L,2822153L,3542197L,4445953L,16448713L,20645437L,25912913L,95870125L,120330425L,151031525L,558772037L,701337113L,880276237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160176Inst : IEnumerable<long>
{
public static readonly long[] Value=A160176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160176.Bytes);
public long this[int i]=>Value[i];

public static A160176Inst Instance=new A160176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160177
{
public static readonly long[] Value={ 1L,2L,5L,5L,1L,3L,9L,9L,6L,1L,4L,8L,6L,7L,2L,5L,2L,9L,1L,5L,3L,9L,9L,8L,1L,9L,6L,5L,0L,2L,5L,8L,8L,2L,9L,9L,4L,9L,0L,5L,9L,4L,3L,5L,7L,7L,8L,5L,6L,8L,7L,9L,7L,5L,2L,5L,4L,0L,7L,9L,0L,8L,8L,1L,3L,5L,9L,9L,2L,4L,2L,2L,6L,6L,5L,5L,1L,2L,2L,6L,9L,6L,7L,3L,4L,2L,6L,0L,5L,4L,0L,4L,0L,9L,6L,6L,6L,3L,8L,1L,3L,1L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160177Inst : IEnumerable<long>
{
public static readonly long[] Value=A160177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160177.Bytes);
public long this[int i]=>Value[i];

public static A160177Inst Instance=new A160177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160178
{
public static readonly long[] Value={ 3L,6L,9L,9L,7L,0L,4L,6L,6L,1L,0L,0L,4L,2L,5L,4L,0L,4L,0L,5L,3L,1L,2L,1L,0L,1L,9L,5L,0L,4L,9L,6L,7L,0L,5L,1L,7L,6L,9L,3L,0L,0L,4L,0L,1L,3L,4L,9L,3L,2L,7L,3L,8L,7L,3L,7L,4L,1L,4L,1L,4L,8L,5L,5L,9L,6L,4L,5L,4L,4L,0L,6L,6L,0L,0L,5L,5L,3L,8L,4L,9L,1L,4L,6L,8L,0L,5L,9L,6L,9L,5L,2L,3L,6L,4L,9L,0L,0L,0L,0L,6L,5L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160178Inst : IEnumerable<long>
{
public static readonly long[] Value=A160178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160178.Bytes);
public long this[int i]=>Value[i];

public static A160178Inst Instance=new A160178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160179
{
public static readonly long[] Value={ 2L,2L,2L,4L,8L,128L,8192L,134217728L,9007199254740992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160179Inst : IEnumerable<long>
{
public static readonly long[] Value=A160179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160179.Bytes);
public long this[int i]=>Value[i];

public static A160179Inst Instance=new A160179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160180
{
public static readonly long[] Value={ 2L,3L,4L,3L,5L,6L,7L,5L,8L,9L,10L,7L,11L,12L,5L,13L,9L,14L,15L,16L,11L,17L,7L,18L,19L,13L,20L,21L,22L,15L,23L,24L,7L,25L,17L,26L,27L,11L,28L,19L,29L,30L,31L,21L,32L,13L,33L,34L,23L,35L,36L,37L,25L,38L,11L,39L,40L,27L,41L,42L,17L,43L,29L,44L,45L,13L,46L,31L,47L,19L,48L,49L,33L,50L,51L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160180Inst : IEnumerable<long>
{
public static readonly long[] Value=A160180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160180.Bytes);
public long this[int i]=>Value[i];

public static A160180Inst Instance=new A160180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160181
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,18L,59L,221L,936L,4361L,22083L,120336L,700653L,4333933L,28345090L,195233255L,1411303635L,10675375402L,84276173439L,692752181561L,5917018378496L,52416910416933L,480786834535250L,4559132648864259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160181Inst : IEnumerable<long>
{
public static readonly long[] Value=A160181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160181.Bytes);
public long this[int i]=>Value[i];

public static A160181Inst Instance=new A160181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160182
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,5L,2L,1L,1L,1L,6L,2L,1L,1L,1L,1L,10L,4L,2L,1L,1L,1L,1L,11L,4L,2L,1L,1L,1L,1L,1L,16L,6L,3L,2L,1L,1L,1L,1L,1L,19L,7L,4L,2L,1L,1L,1L,1L,1L,1L,26L,10L,5L,3L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160182Inst : IEnumerable<long>
{
public static readonly long[] Value=A160182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160182.Bytes);
public long this[int i]=>Value[i];

public static A160182Inst Instance=new A160182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160183
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,5L,2L,1L,1L,6L,2L,1L,1L,1L,10L,4L,2L,1L,1L,1L,11L,4L,2L,1L,1L,1L,1L,16L,6L,3L,2L,1L,1L,1L,1L,19L,7L,4L,2L,1L,1L,1L,1L,1L,26L,10L,5L,3L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160183Inst : IEnumerable<long>
{
public static readonly long[] Value=A160183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160183.Bytes);
public long this[int i]=>Value[i];

public static A160183Inst Instance=new A160183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160184
{
public static readonly BigInteger[] Value={ 1L,1L,-391L,-1175L,458641L,2301041L,-896635319L,-6308683751L,2454058631585L,22238090874721L,-8635680761357159L,-95808996990263479L,BigInteger.Parse("37141246445981806129"),BigInteger.Parse("487826768288181211345"),BigInteger.Parse("-188783965120435102822039"),BigInteger.Parse("-2865977269485973590683399"),BigInteger.Parse("1107183737638672431002905921") };
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
public class A160184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160184Inst Instance=new A160184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160185
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,15L,9L,4L,1L,52L,31L,14L,5L,1L,203L,121L,54L,20L,6L,1L,877L,523L,233L,85L,27L,7L,1L,4140L,2469L,1101L,400L,125L,35L,8L,1L,21147L,12611L,5625L,2046L,635L,175L,44L,9L,1L,115975L,69161L,30846L,11226L,3488L,952L,236L,54L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160185Inst : IEnumerable<long>
{
public static readonly long[] Value=A160185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160185.Bytes);
public long this[int i]=>Value[i];

public static A160185Inst Instance=new A160185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160186
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,6L,8L,9L,12L,11L,13L,14L,17L,16L,18L,19L,22L,21L,23L,24L,27L,26L,28L,29L,32L,31L,33L,34L,37L,36L,38L,39L,42L,41L,43L,44L,47L,46L,48L,49L,52L,51L,53L,54L,57L,56L,58L,59L,62L,61L,63L,64L,67L,66L,68L,69L,72L,71L,73L,74L,77L,76L,78L,79L,82L,81L,83L,84L,87L,86L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160186Inst : IEnumerable<long>
{
public static readonly long[] Value=A160186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160186.Bytes);
public long this[int i]=>Value[i];

public static A160186Inst Instance=new A160186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160187
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,5L,0L,11L,17L,10L,9L,13L,16L,23L,15L,8L,29L,19L,6L,25L,31L,14L,21L,35L,20L,37L,27L,22L,43L,41L,12L,47L,53L,28L,33L,49L,34L,59L,39L,26L,65L,55L,18L,61L,67L,32L,45L,71L,38L,73L,51L,40L,79L,77L,24L,83L,89L,46L,57L,85L,52L,95L,63L,44L,101L,91L,30L,97L,103L,50L,69L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160187Inst : IEnumerable<long>
{
public static readonly long[] Value=A160187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160187.Bytes);
public long this[int i]=>Value[i];

public static A160187Inst Instance=new A160187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160188
{
public static readonly long[] Value={ 2L,1L,3L,4L,0L,11L,18L,8L,5L,6L,25L,10L,7L,17L,24L,13L,9L,15L,31L,32L,14L,39L,46L,22L,12L,20L,53L,38L,21L,45L,52L,27L,16L,29L,59L,60L,28L,67L,74L,36L,19L,34L,81L,66L,35L,73L,80L,41L,23L,43L,87L,88L,42L,95L,102L,50L,26L,48L,109L,94L,49L,101L,108L,55L,30L,57L,115L,116L,56L,123L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160188Inst : IEnumerable<long>
{
public static readonly long[] Value=A160188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160188.Bytes);
public long this[int i]=>Value[i];

public static A160188Inst Instance=new A160188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160189
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,8L,17L,36L,66L,115L,202L,340L,569L,944L,1550L,2531L,4122L,6704L,10879L,17640L,28584L,46289L,74942L,121304L,196321L,317710L,514126L,831933L,1346160L,2178196L,3524451L,5702756L,9227328L,14930213L,24157668L,39088018L,63245829L,102333992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160189Inst : IEnumerable<long>
{
public static readonly long[] Value=A160189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160189.Bytes);
public long this[int i]=>Value[i];

public static A160189Inst Instance=new A160189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160190
{
public static readonly long[] Value={ 4L,9L,25L,56L,143L,273L,578L,1045L,2047L,4176L,7223L,13949L,25010L,42441L,75059L,136952L,246679L,412665L,733382L,1257481L,2091961L,3663072L,6227075L,10803977L,19052546L,32098911L,52965587L,89028280L,146743321L,246148917L,447621406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160190Inst : IEnumerable<long>
{
public static readonly long[] Value=A160190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160190.Bytes);
public long this[int i]=>Value[i];

public static A160190Inst Instance=new A160190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160191
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,11L,10L,5L,15L,12L,19L,23L,18L,9L,27L,20L,31L,35L,26L,13L,39L,28L,43L,47L,34L,17L,51L,36L,55L,59L,42L,21L,63L,44L,67L,71L,50L,25L,75L,52L,79L,83L,58L,29L,87L,60L,91L,95L,66L,33L,99L,68L,103L,107L,74L,37L,111L,76L,115L,119L,82L,41L,123L,84L,127L,131L,90L,45L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160191Inst : IEnumerable<long>
{
public static readonly long[] Value=A160191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160191.Bytes);
public long this[int i]=>Value[i];

public static A160191Inst Instance=new A160191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160192
{
public static readonly BigInteger[] Value={ 1L,3L,-383L,-3501L,439905L,6809283L,-841785951L,-18540791469L,2254238275137L,64906636872195L,-7758232724066751L,-277708714711204653L,BigInteger.Parse("32620373362042216353"),BigInteger.Parse("1404202914087633336771"),BigInteger.Parse("-162020813910704234524575"),BigInteger.Parse("-8192328034245044455772973"),BigInteger.Parse("928105401692205765637182081") };
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
public class A160192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160192Inst Instance=new A160192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160193
{
public static readonly BigInteger[] Value={ 1L,5L,-367L,-5755L,402817L,11037925L,-734331695L,-29632858075L,1866841880705L,102262852326725L,-6074903893493615L,-431244900588230075L,BigInteger.Parse("24038761085803317505"),BigInteger.Parse("2148769817796050860325"),BigInteger.Parse("-111757677404273451703855"),BigInteger.Parse("-12351237147086094379982875"),BigInteger.Parse("595378957401697424118753025") };
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
public class A160193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160193Inst Instance=new A160193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160194
{
public static readonly BigInteger[] Value={ 1L,9L,-311L,-9855L,277041L,17946009L,-381486279L,-45642389679L,636016842465L,148858685615529L,-904139249676759L,-591663300859964511L,-1426321263133495791L,BigInteger.Parse("2770347275877071597625"),BigInteger.Parse("32201658639821938929561"),BigInteger.Parse("-14913850922254971477399951"),BigInteger.Parse("-323570411102447744202418239") };
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
public class A160194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160194Inst Instance=new A160194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160195
{
public static readonly BigInteger[] Value={ 1L,11L,-271L,-11605L,191041L,20298091L,-151161359L,-49403884981L,-128655965695L,153515367677771L,2142567291427441L,-578212001091160469L,BigInteger.Parse("-15599082172637890751"),BigInteger.Parse("2548319349233802047915"),BigInteger.Parse("107524435593334513794161"),BigInteger.Parse("-12802407797068425987221749") };
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
public class A160195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160195Inst Instance=new A160195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160196
{
public static readonly BigInteger[] Value={ 1L,13L,-223L,-13091L,92065L,21723533L,101958529L,-49768288739L,-926761957183L,144025448042125L,5141947009489249L,-497734445201769763L,BigInteger.Parse("-28642623292540648607"),BigInteger.Parse("1968988727426096533261"),BigInteger.Parse("171559661755326400233665"),BigInteger.Parse("-8575534533295174571498723"),BigInteger.Parse("-1120252760054156502803433599") };
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
public class A160196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160196Inst Instance=new A160196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160197
{
public static readonly BigInteger[] Value={ 1L,15L,-167L,-14265L,-17583L,22103775L,366019305L,-46497789225L,-1701823811295L,120289709840175L,7808380053851385L,-354409961765715225L,BigInteger.Parse("-38985884218692900495"),BigInteger.Parse("1082356196865530910975"),BigInteger.Parse("214907408931441984587145"),BigInteger.Parse("-2716359674426403870623625") };
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
public class A160197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160197Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160197.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160197Inst Instance=new A160197Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160198
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,3L,1L,2L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,13L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160198Inst : IEnumerable<long>
{
public static readonly long[] Value=A160198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160198.Bytes);
public long this[int i]=>Value[i];

public static A160198Inst Instance=new A160198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160199
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,1L,4L,1L,10L,1L,24L,1L,14L,15L,8L,1L,54L,1L,40L,21L,22L,1L,2304L,1L,26L,9L,56L,1L,27000L,1L,512L,33L,34L,35L,216L,1L,38L,39L,6400L,1L,74088L,1L,88L,135L,46L,1L,73728L,1L,250L,51L,104L,1L,26244L,55L,12544L,57L,58L,1L,25920000L,1L,62L,189L,512L,65L,287496L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160199Inst : IEnumerable<long>
{
public static readonly long[] Value=A160199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160199.Bytes);
public long this[int i]=>Value[i];

public static A160199Inst Instance=new A160199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160200
{
public static readonly long[] Value={ 541L,761L,1465L,1781L,3805L,8249L,10145L,22069L,48029L,59089L,128609L,279925L,344389L,749585L,1631521L,2007245L,4368901L,9509201L,11699081L,25463821L,55423685L,68187241L,148414025L,323032909L,397424365L,865020329L,1882773769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160200Inst : IEnumerable<long>
{
public static readonly long[] Value=A160200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160200.Bytes);
public long this[int i]=>Value[i];

public static A160200Inst Instance=new A160200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160201
{
public static readonly long[] Value={ 2L,1L,7L,6L,5L,6L,5L,9L,2L,0L,9L,1L,5L,0L,7L,2L,1L,5L,8L,4L,0L,5L,2L,3L,0L,2L,1L,1L,0L,1L,8L,2L,3L,9L,8L,3L,2L,1L,9L,3L,4L,1L,4L,4L,6L,3L,1L,0L,6L,6L,3L,6L,0L,1L,8L,1L,4L,4L,0L,5L,5L,2L,4L,1L,7L,2L,3L,6L,7L,7L,2L,7L,3L,3L,8L,9L,6L,1L,0L,3L,1L,7L,9L,3L,5L,4L,5L,2L,0L,9L,0L,4L,8L,5L,3L,7L,5L,0L,4L,1L,5L,2L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160201Inst : IEnumerable<long>
{
public static readonly long[] Value=A160201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160201.Bytes);
public long this[int i]=>Value[i];

public static A160201Inst Instance=new A160201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160202
{
public static readonly long[] Value={ 1L,2L,3L,0L,2L,9L,0L,6L,4L,1L,9L,9L,8L,0L,0L,6L,3L,2L,0L,9L,2L,6L,8L,3L,6L,9L,6L,2L,8L,5L,9L,2L,2L,3L,8L,4L,5L,0L,3L,4L,0L,7L,4L,7L,6L,6L,0L,0L,4L,8L,0L,8L,6L,1L,0L,6L,3L,4L,0L,4L,0L,6L,0L,7L,4L,7L,9L,2L,1L,7L,3L,4L,9L,7L,3L,1L,7L,2L,0L,9L,7L,9L,6L,6L,8L,9L,3L,5L,2L,0L,6L,3L,8L,9L,0L,9L,3L,3L,7L,8L,3L,3L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160202Inst : IEnumerable<long>
{
public static readonly long[] Value=A160202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160202.Bytes);
public long this[int i]=>Value[i];

public static A160202Inst Instance=new A160202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160203
{
public static readonly long[] Value={ 641L,809L,1105L,2741L,4045L,5989L,15805L,23461L,34829L,92089L,136721L,202985L,536729L,796865L,1183081L,3128285L,4644469L,6895501L,18232981L,27069949L,40189925L,106269601L,157775225L,234244049L,619384625L,919581401L,1365274369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160203Inst : IEnumerable<long>
{
public static readonly long[] Value=A160203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160203.Bytes);
public long this[int i]=>Value[i];

public static A160203Inst Instance=new A160203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160204
{
public static readonly long[] Value={ 1L,4L,8L,4L,6L,6L,9L,4L,0L,2L,3L,1L,2L,1L,8L,5L,4L,7L,7L,5L,3L,0L,2L,7L,4L,1L,4L,5L,8L,7L,9L,6L,6L,6L,1L,9L,8L,0L,5L,7L,0L,6L,2L,8L,8L,6L,3L,8L,7L,4L,5L,6L,0L,6L,0L,5L,4L,0L,1L,6L,0L,3L,2L,0L,4L,1L,2L,6L,6L,9L,8L,8L,2L,5L,7L,5L,0L,4L,1L,8L,2L,0L,7L,8L,2L,8L,0L,5L,8L,1L,9L,4L,8L,5L,8L,0L,0L,7L,9L,7L,1L,2L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160204Inst : IEnumerable<long>
{
public static readonly long[] Value=A160204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160204.Bytes);
public long this[int i]=>Value[i];

public static A160204Inst Instance=new A160204Inst();

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