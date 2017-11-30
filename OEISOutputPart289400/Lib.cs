using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A239263
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,6L,8L,14L,19L,24L,30L,49L,61L,75L,93L,144L,177L,217L,260L,385L,461L,556L,663L,956L,1137L,1353L,1603L,2222L,2625L,3093L,3622L,4956L,5796L,6790L,7907L,10578L,12299L,14283L,16558L,21830L,25269L,29175L,33607L,43656L,50227L,57723L,66199L,85183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239263Inst : IEnumerable<long>
{
public static readonly long[] Value=A239263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239263.Bytes);
public long this[int i]=>Value[i];

public static A239263Inst Instance=new A239263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239328
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,2L,4L,3L,4L,4L,5L,5L,3L,4L,1L,2L,2L,5L,2L,2L,2L,5L,3L,3L,5L,8L,4L,7L,5L,5L,6L,5L,4L,4L,4L,6L,7L,5L,4L,6L,5L,8L,7L,4L,1L,2L,3L,8L,5L,3L,8L,5L,7L,6L,6L,4L,6L,9L,3L,6L,7L,8L,6L,3L,4L,4L,5L,6L,7L,6L,11L,10L,4L,6L,6L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239328Inst : IEnumerable<long>
{
public static readonly long[] Value=A239328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239328.Bytes);
public long this[int i]=>Value[i];

public static A239328Inst Instance=new A239328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239329
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,9L,14L,19L,27L,36L,51L,67L,90L,117L,157L,204L,266L,337L,436L,554L,708L,890L,1123L,1401L,1750L,2172L,2701L,3329L,4106L,5026L,6161L,7507L,9147L,11095L,13455L,16245L,19597L,23555L,28288L,33867L,40514L,48328L,57590L,68456L,81286L,96286L,113947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239329Inst : IEnumerable<long>
{
public static readonly long[] Value=A239329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239329.Bytes);
public long this[int i]=>Value[i];

public static A239329Inst Instance=new A239329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239330
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,3L,3L,2L,4L,2L,5L,3L,3L,4L,1L,3L,4L,4L,5L,4L,4L,4L,4L,3L,3L,5L,5L,5L,3L,6L,8L,5L,5L,3L,5L,6L,4L,4L,7L,6L,4L,4L,3L,5L,3L,4L,3L,5L,4L,4L,3L,3L,4L,2L,4L,2L,4L,4L,3L,4L,9L,3L,7L,4L,6L,4L,5L,5L,7L,4L,9L,9L,7L,7L,11L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239330Inst : IEnumerable<long>
{
public static readonly long[] Value=A239330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239330.Bytes);
public long this[int i]=>Value[i];

public static A239330Inst Instance=new A239330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239331
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,6L,1L,1L,7L,13L,10L,1L,1L,9L,22L,25L,15L,1L,1L,11L,33L,46L,41L,21L,1L,1L,13L,46L,73L,79L,61L,28L,1L,1L,15L,61L,106L,129L,121L,85L,36L,1L,1L,17L,78L,145L,191L,201L,172L,113L,45L,1L,1L,19L,97L,190L,265L,301L,289L,232L,145L,55L,1L,1L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239331Inst : IEnumerable<long>
{
public static readonly long[] Value=A239331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239331.Bytes);
public long this[int i]=>Value[i];

public static A239331Inst Instance=new A239331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239332
{
public static readonly BigInteger[] Value={ 2L,31L,2187L,790681L,1527488498L,15397080750829L,808844678734652790L,BigInteger.Parse("222534953338562308679099"),BigInteger.Parse("320707048341323698139814420023") };
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
public class A239332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239332.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239332Inst Instance=new A239332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239333
{
public static readonly long[] Value={ 2L,5L,12L,28L,66L,156L,368L,868L,2048L,4832L,11400L,26896L,63456L,149712L,353216L,833344L,1966112L,4638656L,10944000L,25820224L,60917760L,143723520L,339087488L,800010496L,1887468032L,4453111040L,10506243072L,24787422208L,58481066496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239333Inst : IEnumerable<long>
{
public static readonly long[] Value=A239333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239333.Bytes);
public long this[int i]=>Value[i];

public static A239333Inst Instance=new A239333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239334
{
public static readonly long[] Value={ 5L,31L,172L,926L,5078L,27861L,152260L,832207L,4550810L,24881731L,136029644L,743697760L,4065948624L,22229220072L,121530709245L,664428372582L,3632538661095L,19859679158791L,108576093277449L,593603153333233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239334Inst : IEnumerable<long>
{
public static readonly long[] Value=A239334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239334.Bytes);
public long this[int i]=>Value[i];

public static A239334Inst Instance=new A239334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239335
{
public static readonly long[] Value={ 12L,172L,2187L,27341L,346028L,4360887L,54774178L,688266175L,8649330696L,108663198449L,1365050486095L,17148274201252L,215420739233431L,2706135761424448L,33994663679676011L,427043158643798758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239335Inst : IEnumerable<long>
{
public static readonly long[] Value=A239335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239335.Bytes);
public long this[int i]=>Value[i];

public static A239335Inst Instance=new A239335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239336
{
public static readonly BigInteger[] Value={ 28L,926L,27341L,790681L,22952323L,663249556L,19117551262L,550960518608L,15873533676775L,457181997376959L,13166310184133045L,379162593435951456L,10918763117793096685UL,BigInteger.Parse("314422821700641922733"),BigInteger.Parse("9054241291311457562833") };
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
public class A239336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239336.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239336Inst Instance=new A239336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239337
{
public static readonly BigInteger[] Value={ 66L,5078L,346028L,22952323L,1527488498L,101276030555L,6693244281896L,442014330398515L,29178369838713161L,1925440562309496640L,BigInteger.Parse("127035121924736497404"),BigInteger.Parse("8380770923086769177166"),BigInteger.Parse("552870412078787577689020") };
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
public class A239337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239337Inst Instance=new A239337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239338
{
public static readonly BigInteger[] Value={ 156L,27861L,4360887L,663249556L,101276030555L,15397080750829L,2331550702010844L,352742924096563362L,BigInteger.Parse("53342694175522093768"),BigInteger.Parse("8062792674253914737279"),BigInteger.Parse("1218391421349788433734529") };
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
public class A239338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239338Inst Instance=new A239338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239339
{
public static readonly BigInteger[] Value={ 368L,152260L,54774178L,19117551262L,6693244281896L,2331550702010844L,808844678734652790L,BigInteger.Parse("280328352590045292898"),BigInteger.Parse("97098324777969236740601"),BigInteger.Parse("33612953785570810824523855"),BigInteger.Parse("11632488891977131786485508436") };
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
public class A239339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239339Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239339.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239339.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239339Inst Instance=new A239339Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239340
{
public static readonly long[] Value={ 2L,5L,5L,12L,31L,12L,28L,172L,172L,28L,66L,926L,2187L,926L,66L,156L,5078L,27341L,27341L,5078L,156L,368L,27861L,346028L,790681L,346028L,27861L,368L,868L,152260L,4360887L,22952323L,22952323L,4360887L,152260L,868L,2048L,832207L,54774178L,663249556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239340Inst : IEnumerable<long>
{
public static readonly long[] Value=A239340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239340.Bytes);
public long this[int i]=>Value[i];

public static A239340Inst Instance=new A239340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239341
{
public static readonly long[] Value={ 7L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L,2L,9L,9L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239341Inst : IEnumerable<long>
{
public static readonly long[] Value=A239341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239341.Bytes);
public long this[int i]=>Value[i];

public static A239341Inst Instance=new A239341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239342
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,11L,20L,36L,64L,113L,198L,345L,598L,1032L,1774L,3039L,5190L,8839L,15016L,25452L,43052L,72685L,122502L,206133L,346346L,581136L,973850L,1630011L,2725254L,4551683L,7594748L,12660660L,21087448L,35094377L,58360134L,96979089L,161042110L,267248664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239342Inst : IEnumerable<long>
{
public static readonly long[] Value=A239342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239342.Bytes);
public long this[int i]=>Value[i];

public static A239342Inst Instance=new A239342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239343
{
public static readonly long[] Value={ 0L,2L,36L,42L,56L,72L,98L,122L,134L,156L,162L,182L,212L,302L,338L,386L,486L,492L,576L,642L,666L,672L,698L,708L,722L,734L,782L,828L,846L,878L,882L,888L,896L,938L,962L,974L,986L,992L,1052L,1062L,1104L,1106L,1148L,1182L,1224L,1244L,1266L,1284L,1304L,1338L,1394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239343Inst : IEnumerable<long>
{
public static readonly long[] Value=A239343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239343.Bytes);
public long this[int i]=>Value[i];

public static A239343Inst Instance=new A239343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239408
{
public static readonly BigInteger[] Value={ 28L,698L,16449L,394509L,9340070L,222457036L,5277728354L,125489197292L,2979675864286L,70809806218933L,1681881988746468L,39960823740980549L,949269180927265463L,BigInteger.Parse("22552572727646416085"),BigInteger.Parse("535760871479260663596") };
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
public class A239408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239408Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239408.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239408Inst Instance=new A239408Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239409
{
public static readonly BigInteger[] Value={ 66L,3805L,205969L,11334364L,614216271L,33522573911L,1820591502437L,99155297311831L,5390539057008613L,293381673332485198L,15956203146991156417UL,BigInteger.Parse("868193383242995642964"),BigInteger.Parse("47226335011968154541246"),BigInteger.Parse("2569370658950018916786902") };
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
public class A239409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239409Inst Instance=new A239409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239410
{
public static readonly BigInteger[] Value={ 156L,20818L,2590704L,326882784L,40566958960L,5072216819342L,630657074443394L,78666433617260802L,9791612259389470778UL,BigInteger.Parse("1220385596630190836830"),BigInteger.Parse("151973853622892194440357"),BigInteger.Parse("18935435888110044394225594") };
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
public class A239410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239410Inst Instance=new A239410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239411
{
public static readonly BigInteger[] Value={ 368L,113774L,32507376L,9402398952L,2671846338458L,765206237815409L,217822754771248124L,BigInteger.Parse("62224253930396430225"),BigInteger.Parse("17732860047914475927901"),BigInteger.Parse("5061141668045083629968143"),BigInteger.Parse("1443095146623473513048203207") };
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
public class A239411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239411Inst Instance=new A239411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239412
{
public static readonly long[] Value={ 4L,6L,8L,16L,18L,92L,254L,258L,660L,1850L,2496L,2774L,2832L,7430L,28540L,32124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239412Inst : IEnumerable<long>
{
public static readonly long[] Value=A239412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239412.Bytes);
public long this[int i]=>Value[i];

public static A239412Inst Instance=new A239412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239413
{
public static readonly long[] Value={ 4L,12L,16L,42L,102L,124L,132L,144L,184L,232L,274L,288L,306L,316L,336L,352L,406L,438L,478L,582L,606L,622L,706L,742L,754L,762L,814L,832L,916L,922L,964L,984L,996L,1026L,1044L,1072L,1086L,1096L,1156L,1174L,1204L,1258L,1272L,1366L,1408L,1416L,1428L,1432L,1456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239413Inst : IEnumerable<long>
{
public static readonly long[] Value=A239413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239413.Bytes);
public long this[int i]=>Value[i];

public static A239413Inst Instance=new A239413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239414
{
public static readonly long[] Value={ 5L,7L,17L,37L,113L,137L,157L,173L,175L,203L,223L,227L,295L,337L,395L,407L,475L,487L,503L,535L,605L,617L,707L,743L,797L,833L,857L,863L,865L,877L,905L,943L,947L,965L,973L,995L,1037L,1043L,1057L,1103L,1217L,1243L,1247L,1277L,1295L,1337L,1357L,1363L,1375L,1403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239414Inst : IEnumerable<long>
{
public static readonly long[] Value=A239414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239414.Bytes);
public long this[int i]=>Value[i];

public static A239414Inst Instance=new A239414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239415
{
public static readonly long[] Value={ 60L,66L,132L,212L,242L,246L,290L,296L,312L,326L,380L,384L,446L,516L,524L,554L,654L,704L,740L,782L,834L,1026L,1086L,1142L,1154L,1172L,1182L,1214L,1424L,1430L,1464L,1482L,1494L,1500L,1524L,1604L,1682L,1686L,1752L,1794L,1796L,1844L,1854L,1940L,1952L,1980L,2000L,2010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239415Inst : IEnumerable<long>
{
public static readonly long[] Value=A239415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239415.Bytes);
public long this[int i]=>Value[i];

public static A239415Inst Instance=new A239415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239416
{
public static readonly long[] Value={ 3L,7L,19L,39L,73L,75L,101L,107L,145L,147L,171L,213L,235L,247L,263L,285L,319L,353L,359L,369L,399L,443L,445L,521L,523L,557L,613L,675L,693L,707L,733L,781L,791L,805L,815L,829L,837L,879L,927L,943L,961L,999L,1033L,1097L,1103L,1109L,1129L,1137L,1141L,1155L,1157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239416Inst : IEnumerable<long>
{
public static readonly long[] Value=A239416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239416.Bytes);
public long this[int i]=>Value[i];

public static A239416Inst Instance=new A239416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239417
{
public static readonly long[] Value={ 2L,62L,86L,88L,116L,152L,266L,292L,310L,326L,338L,356L,406L,436L,466L,470L,518L,550L,568L,616L,626L,650L,688L,700L,722L,812L,850L,926L,956L,992L,1058L,1076L,1126L,1186L,1252L,1430L,1550L,1570L,1642L,1672L,1682L,1766L,1808L,1852L,1868L,1888L,2138L,2210L,2306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239417Inst : IEnumerable<long>
{
public static readonly long[] Value=A239417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239417.Bytes);
public long this[int i]=>Value[i];

public static A239417Inst Instance=new A239417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239418
{
public static readonly long[] Value={ 21L,201L,267L,321L,369L,459L,537L,651L,669L,699L,723L,753L,1071L,1113L,1197L,1203L,1209L,1323L,1401L,1503L,1587L,1647L,1773L,1791L,1797L,1917L,1941L,2007L,2139L,2223L,2427L,2493L,2613L,2733L,2769L,2787L,2847L,3147L,3249L,3267L,3297L,3399L,3423L,3441L,3771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239418Inst : IEnumerable<long>
{
public static readonly long[] Value=A239418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239418.Bytes);
public long this[int i]=>Value[i];

public static A239418Inst Instance=new A239418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239419
{
public static readonly long[] Value={ 0L,3L,5L,7L,8L,10L,15L,16L,17L,20L,25L,30L,33L,35L,36L,40L,41L,45L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,63L,65L,67L,70L,74L,75L,76L,77L,78L,79L,80L,84L,85L,88L,89L,90L,95L,97L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,115L,116L,117L,120L,123L,125L,130L,132L,135L,136L,140L,145L,150L,151L,152L,153L,154L,155L,156L,157L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239419Inst : IEnumerable<long>
{
public static readonly long[] Value=A239419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239419.Bytes);
public long this[int i]=>Value[i];

public static A239419Inst Instance=new A239419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239420
{
public static readonly long[] Value={ 6L,18L,80L,320L,1244L,4990L,19560L,77220L,304224L,1197958L,4717332L,18575316L,73129198L,287925250L,1133540066L,4462693994L,17569294396L,69168560346L,272309851366L,1072054712756L,4220563726184L,16615895170312L,65414941885872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239420Inst : IEnumerable<long>
{
public static readonly long[] Value=A239420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239420.Bytes);
public long this[int i]=>Value[i];

public static A239420Inst Instance=new A239420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239421
{
public static readonly long[] Value={ 14L,80L,684L,4740L,34728L,247942L,1823840L,13104784L,96061078L,695765782L,5083225762L,36951321980L,269612837546L,1962752200756L,14312766262898L,104262967785574L,760091929311648L,5538575467521760L,40371718771292856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239421Inst : IEnumerable<long>
{
public static readonly long[] Value=A239421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239421.Bytes);
public long this[int i]=>Value[i];

public static A239421Inst Instance=new A239421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239422
{
public static readonly long[] Value={ 32L,320L,4740L,60626L,811554L,10575232L,145743440L,1928821306L,26684346362L,358305166764L,4952187852212L,67021312062216L,924914248249990L,12574330546236484L,173247780273551176L,2361918979366991628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239422Inst : IEnumerable<long>
{
public static readonly long[] Value=A239422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239422.Bytes);
public long this[int i]=>Value[i];

public static A239422Inst Instance=new A239422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239423
{
public static readonly BigInteger[] Value={ 72L,1244L,34728L,811554L,21127494L,503941286L,13584156020L,331591613568L,9007534804802L,224281794567484L,6091680378840082L,153616126594282898L,4160724940725286438L,BigInteger.Parse("105844296459902589106"),BigInteger.Parse("2855882931255045316668") };
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
public class A239423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239423Inst Instance=new A239423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239472
{
public static readonly long[] Value={ 2L,3L,3L,7L,3L,0L,0L,0L,0L,7L,7L,0L,4L,0L,8L,11L,3L,16L,15L,0L,4L,7L,0L,23L,0L,19L,12L,11L,3L,0L,3L,7L,12L,0L,12L,0L,0L,0L,0L,0L,16L,0L,0L,0L,59L,11L,44L,32L,16L,0L,0L,0L,3L,0L,23L,0L,20L,75L,3L,0L,28L,0L,0L,0L,36L,0L,60L,0L,0L,0L,36L,0L,0L,0L,0L,19L,0L,0L,0L,0L,0L,91L,75L,0L,0L,0L,32L,108L,7L,0L,60L,0L,40L,39L,0L,0L,0L,0L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239472Inst : IEnumerable<long>
{
public static readonly long[] Value=A239472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239472.Bytes);
public long this[int i]=>Value[i];

public static A239472Inst Instance=new A239472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239473
{
public static readonly long[] Value={ 1L,0L,1L,1L,-1L,1L,0L,2L,-2L,1L,1L,-2L,4L,-3L,1L,0L,3L,-6L,7L,-4L,1L,1L,-3L,9L,-13L,11L,-5L,1L,0L,4L,-12L,22L,-24L,16L,-6L,1L,1L,-4L,16L,-34L,46L,-40L,22L,-7L,1L,0L,5L,-20L,50L,-80L,86L,-62L,29L,-8L,1L,1L,-5L,25L,-70L,130L,-166L,148L,-91L,37L,-9L,1L,0L,6L,-30L,95L,-200L,296L,-314L,239L,-128L,46L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239473Inst : IEnumerable<long>
{
public static readonly long[] Value=A239473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239473.Bytes);
public long this[int i]=>Value[i];

public static A239473Inst Instance=new A239473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239474
{
public static readonly long[] Value={ 3L,2L,2L,0L,4L,5L,60L,3L,2L,21L,28L,5L,2L,199L,28L,0L,234L,11L,2L,3L,2L,159L,10L,31L,68L,145L,0L,69L,186L,163L,32L,253L,26L,261L,4L,0L,8L,11L,62L,3L,22L,43L,6L,7L,8L,945L,76L,7L,116L,129L,382L,93L,330L,361L,2L,555L,224L,1359L,78L,29L,62L,39L,110L,0L,1032L,37L,462L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239474Inst : IEnumerable<long>
{
public static readonly long[] Value=A239474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239474.Bytes);
public long this[int i]=>Value[i];

public static A239474Inst Instance=new A239474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239475
{
public static readonly long[] Value={ 4L,3L,2L,0L,42L,175L,66L,3L,2L,4983L,1770L,55055L,28686L,18765L,8456L,0L,594L,128345L,136080L,81L,92L,1163409L,18810L,10415L,11754L,3855L,0L,86043L,38880L,17639L,26088L,37293L,5540L,612015L,6876L,0L,44220L,130425L,110L,9292527L,1004850L,1812149L,442404L,1007445L,570658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239475Inst : IEnumerable<long>
{
public static readonly long[] Value=A239475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239475.Bytes);
public long this[int i]=>Value[i];

public static A239475Inst Instance=new A239475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239476
{
public static readonly long[] Value={ 2L,3L,5L,3L,7L,3L,1L,6L,2L,6L,6L,5L,4L,3L,2L,4L,5L,4L,1L,3L,2L,3L,3L,1L,7L,2L,2L,10L,1L,4L,1L,2L,4L,0L,3L,5L,1L,3L,4L,3L,5L,1L,5L,4L,6L,4L,2L,1L,2L,4L,4L,1L,5L,1L,4L,3L,2L,4L,3L,5L,6L,2L,6L,3L,2L,2L,2L,1L,4L,2L,1L,2L,3L,3L,4L,4L,4L,2L,3L,4L,7L,5L,2L,1L,4L,2L,1L,6L,2L,3L,2L,3L,5L,0L,5L,0L,0L,2L,2L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239476Inst : IEnumerable<long>
{
public static readonly long[] Value=A239476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239476.Bytes);
public long this[int i]=>Value[i];

public static A239476Inst Instance=new A239476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239477
{
public static readonly BigInteger[] Value={ 0L,10L,28L,289L,BigInteger.Parse("2488888888888888999999999") };
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
public class A239477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239477Inst Instance=new A239477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239478
{
public static readonly long[] Value={ 225L,184041L,741321L,1095543801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239478Inst : IEnumerable<long>
{
public static readonly long[] Value=A239478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239478.Bytes);
public long this[int i]=>Value[i];

public static A239478Inst Instance=new A239478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239479
{
public static readonly long[] Value={ 1L,9L,441L,815409L,553613841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239479Inst : IEnumerable<long>
{
public static readonly long[] Value=A239479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239479.Bytes);
public long this[int i]=>Value[i];

public static A239479Inst Instance=new A239479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239480
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,99L,101L,111L,121L,131L,141L,151L,161L,171L,202L,212L,222L,262L,282L,303L,313L,393L,404L,424L,454L,474L,525L,545L,565L,585L,595L,636L,656L,676L,757L,838L,858L,959L,1001L,1111L,1221L,1331L,1441L,1991L,2002L,2112L,2552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239480Inst : IEnumerable<long>
{
public static readonly long[] Value=A239480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239480.Bytes);
public long this[int i]=>Value[i];

public static A239480Inst Instance=new A239480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239481
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,0L,2L,2L,1L,2L,3L,4L,5L,7L,6L,9L,13L,13L,17L,22L,25L,32L,39L,43L,55L,67L,78L,93L,113L,132L,158L,191L,217L,260L,308L,357L,424L,498L,576L,676L,792L,916L,1069L,1244L,1436L,1666L,1934L,2225L,2573L,2971L,3410L,3932L,4524L,5183L,5951L,6826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239481Inst : IEnumerable<long>
{
public static readonly long[] Value=A239481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239481.Bytes);
public long this[int i]=>Value[i];

public static A239481Inst Instance=new A239481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239482
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,2L,3L,5L,5L,7L,10L,11L,14L,19L,21L,27L,34L,39L,48L,60L,69L,84L,102L,119L,142L,172L,199L,237L,282L,328L,387L,458L,530L,623L,730L,847L,987L,1153L,1331L,1547L,1796L,2071L,2394L,2771L,3183L,3671L,4227L,4849L,5568L,6395L,7313L,8377L,9584L,10940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239482Inst : IEnumerable<long>
{
public static readonly long[] Value=A239482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239482.Bytes);
public long this[int i]=>Value[i];

public static A239482Inst Instance=new A239482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239483
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,3L,4L,5L,7L,8L,10L,12L,16L,18L,22L,26L,33L,38L,45L,53L,65L,75L,89L,103L,124L,143L,168L,195L,230L,265L,309L,357L,418L,479L,556L,639L,742L,850L,979L,1122L,1294L,1478L,1696L,1935L,2220L,2528L,2889L,3287L,3752L,4261L,4850L,5502L,6257L,7084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239483Inst : IEnumerable<long>
{
public static readonly long[] Value=A239483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239483.Bytes);
public long this[int i]=>Value[i];

public static A239483Inst Instance=new A239483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239484
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,3L,4L,5L,6L,7L,9L,11L,13L,15L,19L,22L,26L,31L,36L,42L,51L,58L,68L,79L,92L,107L,125L,143L,165L,191L,221L,253L,293L,333L,383L,440L,503L,574L,657L,747L,853L,971L,1105L,1253L,1427L,1616L,1833L,2076L,2349L,2655L,3006L,3389L,3826L,4313L,4861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239484Inst : IEnumerable<long>
{
public static readonly long[] Value=A239484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239484.Bytes);
public long this[int i]=>Value[i];

public static A239484Inst Instance=new A239484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239485
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,4L,4L,6L,7L,8L,9L,12L,13L,16L,19L,22L,25L,31L,34L,41L,47L,54L,62L,74L,82L,96L,110L,126L,143L,167L,187L,216L,245L,279L,316L,364L,408L,466L,527L,597L,673L,767L,860L,976L,1098L,1238L,1391L,1574L,1761L,1986L,2228L,2502L,2801L,3150L,3518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239485Inst : IEnumerable<long>
{
public static readonly long[] Value=A239485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239485.Bytes);
public long this[int i]=>Value[i];

public static A239485Inst Instance=new A239485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239486
{
public static readonly BigInteger[] Value={ 0L,11L,99L,595L,BigInteger.Parse("467778888888979888888877764") };
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
public class A239486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239486Inst Instance=new A239486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239487
{
public static readonly long[] Value={ 3L,6L,5L,12L,7L,18L,9L,12L,11L,30L,13L,16L,15L,18L,17L,20L,19L,30L,21L,24L,23L,30L,25L,28L,27L,30L,29L,32L,31L,34L,33L,36L,35L,38L,37L,40L,39L,42L,41L,44L,43L,46L,45L,48L,47L,50L,49L,52L,51L,54L,53L,56L,55L,58L,57L,60L,59L,62L,61L,64L,63L,66L,65L,68L,67L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239487Inst : IEnumerable<long>
{
public static readonly long[] Value=A239487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239487.Bytes);
public long this[int i]=>Value[i];

public static A239487Inst Instance=new A239487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239568
{
public static readonly long[] Value={ 0L,6L,27L,75L,165L,315L,546L,882L,1350L,1980L,2805L,3861L,5187L,6825L,8820L,11220L,14076L,17442L,21375L,25935L,31185L,37191L,44022L,51750L,60450L,70200L,81081L,93177L,106575L,121365L,137640L,155496L,175032L,196350L,219555L,244755L,272061L,301587L,333450L,367770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239568Inst : IEnumerable<long>
{
public static readonly long[] Value=A239568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239568.Bytes);
public long this[int i]=>Value[i];

public static A239568Inst Instance=new A239568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239569
{
public static readonly long[] Value={ 0L,1L,21L,151L,615L,1845L,4571L,9926L,19566L,35805L,61765L,101541L,160381L,244881L,363195L,525260L,743036L,1030761L,1405221L,1886035L,2495955L,3261181L,4211691L,5381586L,6809450L,8538725L,10618101L,13101921L,16050601L,19531065L,23617195L,28390296L,33939576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239569Inst : IEnumerable<long>
{
public static readonly long[] Value=A239569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239569.Bytes);
public long this[int i]=>Value[i];

public static A239569Inst Instance=new A239569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239570
{
public static readonly long[] Value={ 0L,1L,114L,1137L,6100L,23265L,71211L,186739L,436437L,932850L,1856305L,3483546L,6224439L,10668112L,17640000L,28271370L,44083006L,67084839L,99893412L,145869175L,209275710L,295463091L,411077689L,564300837L,765118875L,1025627200L,1360371051L,1786725864L,2325320137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239570Inst : IEnumerable<long>
{
public static readonly long[] Value=A239570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239570.Bytes);
public long this[int i]=>Value[i];

public static A239570Inst Instance=new A239570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239571
{
public static readonly long[] Value={ 0L,0L,27L,999L,11565L,74811L,342042L,1239525L,3799488L,10259640L,25076952L,56552364L,119324403L,238062357L,452774595L,826245798L,1454229216L,2479147536L,4108199481L,6636929805L,10479498849L,16207085223L,24596072424L,36687908235L,53862785520L,77929575480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239571Inst : IEnumerable<long>
{
public static readonly long[] Value=A239571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239571.Bytes);
public long this[int i]=>Value[i];

public static A239571Inst Instance=new A239571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239572
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,6L,6L,1L,4L,16L,32L,24L,7L,1L,5L,32L,113L,200L,176L,66L,6L,7L,60L,329L,1053L,1976L,2096L,1162L,302L,34L,2L,8L,100L,790L,3932L,12565L,25676L,32963L,25638L,11294L,2493L,222L,7L,10L,160L,1702L,11988L,57275L,187984L,425329L,658608L,684671L,462519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239572Inst : IEnumerable<long>
{
public static readonly long[] Value=A239572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239572.Bytes);
public long this[int i]=>Value[i];

public static A239572Inst Instance=new A239572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239573
{
public static readonly long[] Value={ 0L,1L,6L,32L,113L,329L,790L,1702L,3320L,6057L,10400L,17074L,26903L,41047L,60796L,87886L,124220L,172275L,234732L,314992L,416703L,544391L,702878L,898040L,1136098L,1424521L,1771178L,2185392L,2676947L,3257305L,3938450L,4734286L,5659306L,6730177L,7964228L,9381234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239573Inst : IEnumerable<long>
{
public static readonly long[] Value=A239573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239573.Bytes);
public long this[int i]=>Value[i];

public static A239573Inst Instance=new A239573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239574
{
public static readonly long[] Value={ 0L,1L,24L,200L,1053L,3932L,11988L,31298L,73046L,155880L,310046L,581414L,1038634L,1779531L,2942114L,4714412L,7350595L,11184786L,16654116L,24317554L,34886940L,49252544L,68523846L,94062350L,127534794L,170954603L,226748678L,297809946L,387580007L,500113190L,640178710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239574Inst : IEnumerable<long>
{
public static readonly long[] Value=A239574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239574.Bytes);
public long this[int i]=>Value[i];

public static A239574Inst Instance=new A239574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239575
{
public static readonly long[] Value={ 0L,0L,7L,176L,1976L,12565L,57275L,207018L,634166L,1711262L,4181915L,9428657L,19892816L,39684027L,75473209L,137721045L,242391212L,413215132L,684733527L,1106194950L,1746637600L,2701244609L,4099429895L,6114748948L,8977257362L,12988406970L,18539308619L,26132434991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239575Inst : IEnumerable<long>
{
public static readonly long[] Value=A239575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239575.Bytes);
public long this[int i]=>Value[i];

public static A239575Inst Instance=new A239575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239576
{
public static readonly long[] Value={ 0L,3L,62L,683L,4015L,16989L,56196L,158271L,391917L,882683L,1836106L,3587103L,6638267L,11747613L,19985680L,32879339L,52490521L,81638211L,124000342L,184440963L,269135111L,386033453L,545007772L,758491143L,1041639045L,1413189339L,1895630946L,2516334551L,3307717267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239576Inst : IEnumerable<long>
{
public static readonly long[] Value=A239576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239576.Bytes);
public long this[int i]=>Value[i];

public static A239576Inst Instance=new A239576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239577
{
public static readonly long[] Value={ 1L,4L,10L,28L,91L,280L,820L,2440L,7381L,22204L,66430L,199108L,597871L,1794160L,5380840L,16140880L,48427561L,145287604L,435848050L,1307529388L,3922632451L,11767941640L,35303692060L,105910943320L,317733228541L,953200084204L,2859599056870L,8578795974868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239577Inst : IEnumerable<long>
{
public static readonly long[] Value=A239577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239577.Bytes);
public long this[int i]=>Value[i];

public static A239577Inst Instance=new A239577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239578
{
public static readonly long[] Value={ 1L,6L,2L,3L,24L,5L,4L,7L,10L,1080L,35640L,11L,9L,13L,8L,33L,297600L,17L,588L,19L,20L,1782L,1907020800L,23L,216L,45L,34L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239578Inst : IEnumerable<long>
{
public static readonly long[] Value=A239578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239578.Bytes);
public long this[int i]=>Value[i];

public static A239578Inst Instance=new A239578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239579
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,3L,2L,0L,3L,1L,2L,2L,3L,2L,2L,1L,3L,3L,1L,1L,1L,8L,4L,3L,1L,2L,4L,2L,2L,4L,5L,3L,4L,5L,3L,6L,4L,6L,3L,5L,5L,6L,3L,3L,10L,5L,10L,4L,3L,6L,4L,4L,7L,6L,5L,3L,3L,6L,5L,6L,3L,5L,9L,3L,6L,5L,8L,4L,9L,9L,10L,7L,12L,4L,9L,7L,7L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239579Inst : IEnumerable<long>
{
public static readonly long[] Value=A239579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239579.Bytes);
public long this[int i]=>Value[i];

public static A239579Inst Instance=new A239579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239580
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,10L,13L,14L,15L,18L,30L,32L,54L,58L,59L,81L,85L,128L,140L,203L,204L,206L,209L,223L,286L,305L,343L,350L,367L,397L,399L,451L,453L,506L,534L,656L,676L,698L,730L,756L,845L,849L,878L,944L,1020L,1040L,1091L,1248L,1256L,1300L,1310L,1326L,1364L,1406L,1535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239580Inst : IEnumerable<long>
{
public static readonly long[] Value=A239580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239580.Bytes);
public long this[int i]=>Value[i];

public static A239580Inst Instance=new A239580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239581
{
public static readonly long[] Value={ 1L,18L,179L,1788L,17861L,178600L,1786011L,17860355L,178603639L,1786036410L,17860362941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239581Inst : IEnumerable<long>
{
public static readonly long[] Value=A239581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239581.Bytes);
public long this[int i]=>Value[i];

public static A239581Inst Instance=new A239581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239582
{
public static readonly long[] Value={ 1L,8L,25L,32L,125L,169L,625L,1681L,3721L,12769L,32761L,97969L,177241L,375769L,579121L,707281L,1026169L,1442401L,1692601L,3031081L,3463321L,4464769L,5669161L,6355441L,7189057L,9740641L,13053769L,20367169L,26020201L,53597041L,73633561L,93334921L,98823481L,110523169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239582Inst : IEnumerable<long>
{
public static readonly long[] Value=A239582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239582.Bytes);
public long this[int i]=>Value[i];

public static A239582Inst Instance=new A239582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239583
{
public static readonly long[] Value={ 1L,8L,25L,32L,125L,169L,625L,1681L,3721L,32761L,97969L,177241L,707281L,1442401L,3031081L,3463321L,6355441L,9740641L,26020201L,53597041L,73633561L,86938307L,93334921L,203946961L,268337161L,392079601L,815730721L,1348431841L,1743981121L,3708931801L,5158256041L,6995816881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239583Inst : IEnumerable<long>
{
public static readonly long[] Value=A239583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239583.Bytes);
public long this[int i]=>Value[i];

public static A239583Inst Instance=new A239583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239648
{
public static readonly BigInteger[] Value={ 128L,38888L,13703468L,4304123072L,1393740949524L,449878848794094L,144633234041629586L,BigInteger.Parse("46605631116410605602"),BigInteger.Parse("15009686604114403319918"),BigInteger.Parse("4833298966552939324386658"),BigInteger.Parse("1556693436923279970529451138") };
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
public class A239648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239648Inst Instance=new A239648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239649
{
public static readonly long[] Value={ 2L,4L,4L,8L,20L,10L,16L,92L,112L,22L,32L,418L,1182L,560L,50L,64L,1898L,12246L,13476L,2874L,114L,128L,8588L,127454L,320314L,158728L,14788L,258L,256L,38888L,1320102L,7629186L,8634040L,1864886L,75540L,586L,512L,175974L,13703468L,181039448L,471203608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239649Inst : IEnumerable<long>
{
public static readonly long[] Value=A239649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239649.Bytes);
public long this[int i]=>Value[i];

public static A239649Inst Instance=new A239649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239650
{
public static readonly long[] Value={ 4L,20L,92L,418L,1898L,8588L,38888L,175974L,796550L,3604984L,16316908L,73849786L,334252546L,1512838756L,6847231728L,30990953678L,140267248638L,634858320528L,2873411390324L,13005245181090L,58862597882746L,266415951317884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239650Inst : IEnumerable<long>
{
public static readonly long[] Value=A239650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239650.Bytes);
public long this[int i]=>Value[i];

public static A239650Inst Instance=new A239650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239651
{
public static readonly long[] Value={ 10L,112L,1182L,12246L,127454L,1320102L,13703468L,142051652L,1473731150L,15282171258L,158517866826L,1643986061990L,17051506678146L,176848369394606L,1834236131924494L,19023918997995414L,197310588661661646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239651Inst : IEnumerable<long>
{
public static readonly long[] Value=A239651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239651.Bytes);
public long this[int i]=>Value[i];

public static A239651Inst Instance=new A239651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239652
{
public static readonly BigInteger[] Value={ 22L,560L,13476L,320314L,7629186L,181039448L,4304123072L,102200616210L,2428626527384L,57685354968172L,1370565397733518L,32557886444429002L,773502177670875660L,18375412388378425556UL,BigInteger.Parse("436547133372227822360") };
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
public class A239652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239652Inst Instance=new A239652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239653
{
public static readonly BigInteger[] Value={ 50L,2874L,158728L,8634040L,471203608L,25594620082L,1393740949524L,75771817108924L,4123656581299810L,224277326338407636L,12202934653709078564UL,BigInteger.Parse("663797011286508892758"),BigInteger.Parse("36113966969053403996390"),BigInteger.Parse("1964591618175666103412114") };
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
public class A239653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239653Inst Instance=new A239653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239654
{
public static readonly BigInteger[] Value={ 114L,14788L,1864886L,232304146L,29007348454L,3608789598890L,449878848794094L,56010829047415956L,6979353579795499648L,BigInteger.Parse("869236650992435705746"),BigInteger.Parse("108294631279262866626560"),BigInteger.Parse("13489190878676390250925510") };
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
public class A239654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239654Inst Instance=new A239654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239655
{
public static readonly BigInteger[] Value={ 258L,75540L,21813374L,6219477628L,1778793691226L,506611939408296L,144633234041629586L,BigInteger.Parse("41228312635698988592"),BigInteger.Parse("11764207025789049116296"),BigInteger.Parse("3354764803854586870996290"),BigInteger.Parse("957059647333850993834828574") };
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
public class A239655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239655Inst Instance=new A239655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239656
{
public static readonly long[] Value={ 12L,24L,4L,8L,24L,3L,5L,4L,16L,8L,16L,11L,5L,4L,8L,4L,4L,5L,27L,8L,1L,7L,8L,9L,3L,8L,7L,9L,3L,1L,4L,20L,8L,4L,23L,9L,3L,9L,4L,4L,11L,14L,3L,4L,4L,8L,8L,3L,1L,4L,1L,3L,4L,13L,10L,5L,4L,9L,11L,4L,8L,12L,12L,4L,21L,6L,13L,8L,8L,5L,3L,4L,4L,3L,1L,5L,3L,9L,11L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239656Inst : IEnumerable<long>
{
public static readonly long[] Value=A239656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239656.Bytes);
public long this[int i]=>Value[i];

public static A239656Inst Instance=new A239656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239657
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,3L,0L,0L,0L,0L,1L,2L,0L,0L,0L,1L,0L,3L,0L,0L,3L,0L,0L,1L,0L,0L,0L,0L,0L,3L,0L,1L,0L,0L,0L,3L,0L,0L,1L,0L,0L,3L,0L,0L,0L,1L,0L,2L,0L,0L,2L,0L,1L,2L,0L,1L,0L,0L,0L,3L,0L,0L,0L,1L,0L,5L,1L,0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,2L,0L,1L,4L,0L,0L,3L,0L,1L,0L,1L,0L,2L,0L,0L,1L,0L,0L,3L,0L,0L,0L,0L,0L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239657Inst : IEnumerable<long>
{
public static readonly long[] Value=A239657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239657.Bytes);
public long this[int i]=>Value[i];

public static A239657Inst Instance=new A239657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239658
{
public static readonly long[] Value={ 6L,12L,15L,18L,20L,24L,28L,30L,35L,36L,40L,42L,45L,48L,54L,56L,60L,63L,66L,70L,72L,75L,77L,78L,80L,84L,88L,90L,91L,96L,99L,100L,102L,104L,105L,108L,110L,112L,114L,117L,120L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239658Inst : IEnumerable<long>
{
public static readonly long[] Value=A239658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239658.Bytes);
public long this[int i]=>Value[i];

public static A239658Inst Instance=new A239658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239659
{
public static readonly long[] Value={ 1L,4L,6L,8L,15L,18L,21L,33L,37L,41L,56L,61L,64L,69L,78L,87L,93L,99L,127L,134L,141L,153L,165L,173L,181L,189L,220L,229L,238L,277L,287L,297L,339L,350L,355L,360L,371L,389L,407L,419L,431L,491L,504L,509L,522L,543L,564L,578L,584L,590L,604L,660L,675L,690L,762L,778L,794L,857L,874L,881L,888L,905L,932L,959L,977L,989L,1007L,1098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239659Inst : IEnumerable<long>
{
public static readonly long[] Value=A239659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239659.Bytes);
public long this[int i]=>Value[i];

public static A239659Inst Instance=new A239659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239660
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,2L,3L,1L,1L,3L,3L,1L,1L,3L,3L,2L,2L,3L,3L,2L,2L,3L,4L,1L,1L,1L,1L,4L,4L,1L,1L,1L,1L,4L,4L,2L,1L,1L,2L,4L,4L,2L,1L,1L,2L,4L,5L,2L,1L,1L,2L,5L,5L,2L,1L,1L,2L,5L,5L,2L,2L,2L,2L,5L,5L,2L,2L,2L,2L,5L,6L,2L,1L,1L,1L,1L,2L,6L,6L,2L,1L,1L,1L,1L,2L,6L,6L,3L,1L,1L,1L,1L,3L,6L,6L,3L,1L,1L,1L,1L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239660Inst : IEnumerable<long>
{
public static readonly long[] Value=A239660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239660.Bytes);
public long this[int i]=>Value[i];

public static A239660Inst Instance=new A239660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239661
{
public static readonly long[] Value={ 1L,3L,9L,11L,33L,99L,121L,363L,1089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239661Inst : IEnumerable<long>
{
public static readonly long[] Value=A239661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239661.Bytes);
public long this[int i]=>Value[i];

public static A239661Inst Instance=new A239661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239662
{
public static readonly long[] Value={ 4L,12L,20L,4L,28L,0L,36L,12L,44L,0L,4L,52L,20L,0L,60L,0L,0L,68L,28L,12L,76L,0L,0L,4L,84L,36L,0L,0L,92L,0L,20L,0L,100L,44L,0L,0L,108L,0L,0L,12L,116L,52L,28L,0L,4L,124L,0L,0L,0L,0L,132L,60L,0L,0L,0L,140L,0L,36L,20L,0L,148L,68L,0L,0L,0L,156L,0L,0L,0L,12L,164L,76L,44L,0L,0L,4L,172L,0L,0L,28L,0L,0L,180L,84L,0L,0L,0L,0L,188L,0L,52L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239662Inst : IEnumerable<long>
{
public static readonly long[] Value=A239662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239662.Bytes);
public long this[int i]=>Value[i];

public static A239662Inst Instance=new A239662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239663
{
public static readonly long[] Value={ 1L,3L,9L,21L,63L,147L,357L,903L,2499L,6069L,13915L,29095L,59455L,142945L,320045L,643885L,1367465L,3287735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239663Inst : IEnumerable<long>
{
public static readonly long[] Value=A239663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239663.Bytes);
public long this[int i]=>Value[i];

public static A239663Inst Instance=new A239663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239728
{
public static readonly long[] Value={ 32L,128L,243L,2048L,2187L,3125L,7776L,8192L,16807L,78125L,100000L,131072L,161051L,177147L,248832L,279936L,371293L,524288L,537824L,759375L,823543L,1419857L,1594323L,1889568L,2476099L,3200000L,4084101L,5153632L,6436343L,7962624L,8388608L,10000000L,11881376L,17210368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239728Inst : IEnumerable<long>
{
public static readonly long[] Value=A239728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239728.Bytes);
public long this[int i]=>Value[i];

public static A239728Inst Instance=new A239728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239729
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,4L,4L,5L,7L,8L,10L,14L,16L,19L,25L,31L,36L,47L,55L,67L,83L,99L,119L,146L,173L,208L,250L,298L,352L,424L,500L,593L,703L,829L,974L,1154L,1350L,1585L,1859L,2175L,2537L,2968L,3452L,4019L,4672L,5425L,6283L,7290L,8421L,9735L,11240L,12962L,14921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239729Inst : IEnumerable<long>
{
public static readonly long[] Value=A239729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239729.Bytes);
public long this[int i]=>Value[i];

public static A239729Inst Instance=new A239729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239730
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,3L,1L,3L,1L,5L,2L,1L,3L,2L,1L,1L,2L,5L,0L,3L,0L,1L,3L,2L,3L,2L,1L,5L,1L,1L,0L,0L,4L,1L,2L,2L,2L,2L,4L,1L,3L,1L,1L,3L,1L,4L,0L,1L,0L,2L,1L,0L,3L,0L,1L,2L,1L,3L,1L,3L,1L,1L,4L,2L,1L,1L,1L,4L,2L,2L,4L,3L,1L,1L,3L,4L,6L,4L,1L,1L,1L,1L,1L,1L,0L,5L,0L,2L,2L,2L,1L,1L,2L,1L,1L,0L,1L,1L,0L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239730Inst : IEnumerable<long>
{
public static readonly long[] Value=A239730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239730.Bytes);
public long this[int i]=>Value[i];

public static A239730Inst Instance=new A239730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239731
{
public static readonly long[] Value={ -1L,0L,-1L,0L,-3L,0L,-1L,10L,17L,20L,33L,40L,59L,90L,117L,140L,163L,218L,237L,286L,345L,390L,443L,502L,551L,614L,701L,784L,881L,976L,1011L,1112L,1215L,1330L,1417L,1550L,1665L,1780L,1923L,2056L,2203L,2360L,2485L,2660L,2827L,3010L,3141L,3252L,3455L,3670L,3879L,4090L,4307L,4484L,4717L,4932L,5147L,5400L,5631L,5876L,6135L,6362L,6555L,6830L,7125L,7424L,7633L,7922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239731Inst : IEnumerable<long>
{
public static readonly long[] Value=A239731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239731.Bytes);
public long this[int i]=>Value[i];

public static A239731Inst Instance=new A239731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239732
{
public static readonly long[] Value={ 5L,11L,19L,29L,31L,71L,101L,109L,131L,151L,179L,211L,229L,239L,269L,281L,311L,491L,521L,541L,719L,739L,751L,809L,919L,929L,971L,1051L,1061L,1129L,1181L,1291L,1361L,1439L,1481L,1621L,1741L,1811L,1831L,2111L,2131L,2221L,2371L,2389L,2411L,2521L,2539L,2549L,2689L,2791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239732Inst : IEnumerable<long>
{
public static readonly long[] Value=A239732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239732.Bytes);
public long this[int i]=>Value[i];

public static A239732Inst Instance=new A239732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239733
{
public static readonly long[] Value={ 7L,11L,23L,37L,41L,67L,71L,97L,113L,137L,163L,191L,197L,263L,307L,317L,401L,421L,491L,617L,653L,683L,727L,823L,881L,883L,907L,947L,953L,967L,1031L,1087L,1103L,1217L,1231L,1297L,1451L,1493L,1523L,1567L,1693L,1747L,1933L,1973L,2053L,2141L,2207L,2221L,2281L,2293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239733Inst : IEnumerable<long>
{
public static readonly long[] Value=A239733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239733.Bytes);
public long this[int i]=>Value[i];

public static A239733Inst Instance=new A239733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239734
{
public static readonly long[] Value={ 11L,29L,71L,79L,151L,211L,251L,401L,419L,461L,541L,599L,601L,659L,881L,1129L,1231L,1381L,1831L,1901L,2309L,2521L,2741L,2851L,2879L,2969L,3011L,3121L,3301L,3319L,3511L,3581L,3719L,3761L,3779L,3851L,4099L,4241L,4561L,4649L,4691L,4969L,5021L,5209L,5531L,5641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239734Inst : IEnumerable<long>
{
public static readonly long[] Value=A239734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239734.Bytes);
public long this[int i]=>Value[i];

public static A239734Inst Instance=new A239734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239735
{
public static readonly long[] Value={ 4L,3L,4L,1L,570L,1L,1464L,54L,60L,14025L,1932L,1L,7194L,15L,3612L,0L,4746L,1L,540L,150L,7060L,138L,80094L,6160L,33480L,93135L,0L,366618L,26058L,1L,90510L,16836L,9824L,418875L,57246L,0L,182394L,64077L,14178L,943410L,36078L,1L,314520L,15870L,194942L,15044700L,241944L,3871L,308730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239735Inst : IEnumerable<long>
{
public static readonly long[] Value=A239735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239735.Bytes);
public long this[int i]=>Value[i];

public static A239735Inst Instance=new A239735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239736
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,2L,2L,2L,10L,3L,1L,3L,8L,3L,6L,4L,2L,4L,9L,9L,4L,4L,8L,2L,2L,2L,3L,11L,8L,4L,13L,19L,4L,1L,6L,3L,4L,2L,4L,26L,12L,5L,11L,11L,9L,6L,5L,25L,4L,24L,6L,4L,2L,5L,9L,9L,2L,7L,4L,28L,13L,8L,27L,9L,23L,3L,7L,2L,24L,36L,38L,9L,26L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239736Inst : IEnumerable<long>
{
public static readonly long[] Value=A239736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239736.Bytes);
public long this[int i]=>Value[i];

public static A239736Inst Instance=new A239736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239737
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,5L,7L,10L,13L,21L,28L,38L,54L,77L,99L,137L,180L,236L,306L,398L,504L,644L,807L,1018L,1278L,1599L,1972L,2458L,3039L,3743L,4592L,5659L,6884L,8436L,10235L,12445L,15021L,18204L,21842L,26334L,31501L,37746L,44956L,53707L,63657L,75738L,89536L,106057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239737Inst : IEnumerable<long>
{
public static readonly long[] Value=A239737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239737.Bytes);
public long this[int i]=>Value[i];

public static A239737Inst Instance=new A239737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239738
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,6L,1L,4L,9L,15L,21L,26L,29L,1L,5L,14L,29L,50L,76L,105L,134L,160L,181L,196L,204L,1L,6L,20L,49L,99L,175L,280L,414L,574L,755L,951L,1155L,1359L,1554L,1730L,1876L,1981L,2036L,1L,7L,27L,76L,175L,350L,630L,1044L,1618L,2373L,3324L,4479L,5838L,7392L,9122L,10998L,12979L,15014L,17044L,19005L,20832L,22463L,23842L,24921L,25662L,26039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239738Inst : IEnumerable<long>
{
public static readonly long[] Value=A239738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239738.Bytes);
public long this[int i]=>Value[i];

public static A239738Inst Instance=new A239738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239739
{
public static readonly BigInteger[] Value={ 0L,64L,2048L,49152L,1048576L,20971520L,402653184L,7516192768L,137438953472L,2473901162496L,43980465111040L,774056185954304L,13510798882111488L,234187180623265792L,4035225266123964416L,BigInteger.Parse("69175290276410818560"),BigInteger.Parse("1180591620717411303424"),BigInteger.Parse("20070057552195992158208") };
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
public class A239739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239739Inst Instance=new A239739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239740
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,20L,3L,18L,8L,143L,8L,8L,21L,986L,84L,63L,220L,6764L,55L,770L,144L,46367L,144L,432L,377L,317810L,16588L,377L,43428L,2178308L,987L,53298L,2584L,14930351L,2584L,18088L,6765L,102334154L,784740L,20295L,2054476L,701408732L,17711L,1664834L,46368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239740Inst : IEnumerable<long>
{
public static readonly long[] Value=A239740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239740.Bytes);
public long this[int i]=>Value[i];

public static A239740Inst Instance=new A239740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239741
{
public static readonly long[] Value={ 1L,2L,11L,24L,28L,92L,166L,191L,220L,587L,677L,964L,988L,1840L,2664L,3604L,6079L,6640L,8817L,33647L,34308L,39882L,44055L,47050L,64100L,103313L,223439L,225921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239741Inst : IEnumerable<long>
{
public static readonly long[] Value=A239741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239741.Bytes);
public long this[int i]=>Value[i];

public static A239741Inst Instance=new A239741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239742
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,12L,35L,78L,122L,276L,495L,715L,849L,927L,1128L,1263L,1418L,23201L,30316L,34894L,51844L,200821L,235383L,265970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239742Inst : IEnumerable<long>
{
public static readonly long[] Value=A239742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239742.Bytes);
public long this[int i]=>Value[i];

public static A239742Inst Instance=new A239742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239743
{
public static readonly long[] Value={ 29L,347L,2203L,704993L,2248123L,2685653L,3442987L,81182821L,86938393L,95444081L,230346509L,1064332433L,1298596753L,1829276767L,2202074113L,3449796071L,4306879141L,6740558659L,8205739219L,9649993009L,11650768499L,14225261327L,15124198183L,19968681493L,21415471837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239743Inst : IEnumerable<long>
{
public static readonly long[] Value=A239743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239743.Bytes);
public long this[int i]=>Value[i];

public static A239743Inst Instance=new A239743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239808
{
public static readonly long[] Value={ 0L,6L,9L,6L,4L,1L,2L,5L,2L,6L,2L,7L,3L,0L,0L,3L,5L,4L,4L,1L,5L,1L,8L,4L,9L,6L,2L,0L,5L,8L,5L,8L,3L,4L,6L,9L,7L,3L,2L,7L,2L,7L,3L,1L,4L,5L,4L,4L,8L,0L,4L,1L,3L,8L,0L,4L,0L,5L,5L,1L,9L,6L,1L,2L,3L,6L,3L,8L,3L,4L,1L,5L,3L,1L,3L,4L,8L,5L,7L,8L,2L,4L,1L,3L,1L,4L,9L,2L,6L,9L,2L,5L,3L,1L,7L,0L,3L,2L,1L,1L,9L,4L,9L,9L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239808Inst : IEnumerable<long>
{
public static readonly long[] Value=A239808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239808.Bytes);
public long this[int i]=>Value[i];

public static A239808Inst Instance=new A239808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239809
{
public static readonly long[] Value={ 1L,4L,6L,1L,7L,7L,9L,5L,8L,0L,2L,5L,4L,9L,4L,2L,7L,2L,9L,5L,4L,6L,5L,4L,9L,3L,3L,0L,5L,1L,7L,2L,6L,5L,6L,8L,1L,4L,0L,4L,4L,9L,0L,2L,8L,5L,9L,5L,4L,3L,8L,0L,6L,4L,5L,2L,5L,5L,4L,1L,1L,9L,4L,7L,5L,9L,8L,9L,5L,4L,1L,5L,5L,4L,8L,3L,9L,6L,5L,9L,7L,8L,2L,0L,5L,2L,4L,2L,7L,9L,5L,6L,5L,5L,7L,3L,6L,6L,4L,2L,8L,7L,6L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239809Inst : IEnumerable<long>
{
public static readonly long[] Value=A239809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239809.Bytes);
public long this[int i]=>Value[i];

public static A239809Inst Instance=new A239809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239810
{
public static readonly long[] Value={ 3L,4L,6L,3L,0L,4L,2L,6L,7L,3L,9L,4L,1L,8L,3L,6L,2L,2L,4L,3L,5L,9L,2L,4L,3L,9L,4L,5L,8L,6L,7L,1L,7L,8L,4L,3L,9L,7L,7L,5L,4L,3L,5L,5L,3L,3L,0L,0L,2L,8L,4L,1L,4L,6L,6L,3L,6L,4L,2L,0L,0L,0L,8L,9L,3L,7L,1L,9L,3L,0L,1L,9L,9L,9L,0L,4L,7L,5L,1L,6L,5L,9L,0L,8L,3L,0L,4L,2L,0L,6L,0L,8L,6L,6L,1L,1L,6L,7L,3L,5L,8L,2L,7L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239810Inst : IEnumerable<long>
{
public static readonly long[] Value=A239810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239810.Bytes);
public long this[int i]=>Value[i];

public static A239810Inst Instance=new A239810Inst();

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