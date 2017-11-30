using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A157405
{
public static readonly long[] Value={ 1L,1L,5L,1L,15L,55L,1L,105L,220L,935L,1L,425L,3300L,4675L,21505L,1L,3075L,47850L,84150L,129030L,623645L,1L,15855L,415800L,2323475L,2709630L,4365515L,415800L,2323475L,2709630L,4365515L,21827575L,1L,123515L,6394080L,51934575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157405Inst : IEnumerable<long>
{
public static readonly long[] Value=A157405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157405.Bytes);
public long this[int i]=>Value[i];

public static A157405Inst Instance=new A157405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157406
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,9L,21L,4L,16L,12L,56L,156L,5L,25L,20L,115L,85L,475L,1555L,6L,36L,30L,204L,24L,162L,1086L,114L,792L,5202L,19608L,7L,49L,42L,329L,35L,273L,2121L,217L,210L,1673L,12873L,1169L,9289L,70217L,299593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157406Inst : IEnumerable<long>
{
public static readonly long[] Value=A157406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157406.Bytes);
public long this[int i]=>Value[i];

public static A157406Inst Instance=new A157406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157407
{
public static readonly long[] Value={ 0L,1L,4L,2L,21L,6L,3L,156L,32L,12L,8L,4L,1555L,260L,50L,45L,15L,10L,5L,19608L,2802L,408L,114L,402L,66L,24L,60L,18L,12L,6L,299593L,37450L,4690L,658L,4683L,595L,147L,91L,588L,84L,28L,77L,21L,14L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157407Inst : IEnumerable<long>
{
public static readonly long[] Value=A157407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157407.Bytes);
public long this[int i]=>Value[i];

public static A157407Inst Instance=new A157407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157408
{
public static readonly BigInteger[] Value={ 1L,-1L,-210L,1261L,220710L,-1104601L,-566112330L,15866612597L,2702443637670L,-24345797298511L,-20725956928531050L,456417479335499911L,BigInteger.Parse("233123963658306714630"),BigInteger.Parse("-3033578821577283836221"),BigInteger.Parse("-3615387031692966692668170"),BigInteger.Parse("434271227929374530797241269"),BigInteger.Parse("73937083339409224087812031590") };
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
public class A157408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157408Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157408.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157408Inst Instance=new A157408Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157409
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,1L,0L,3L,0L,0L,3L,1L,3L,0L,0L,2L,0L,1L,5L,4L,12L,7L,2L,1L,11L,0L,15L,10L,4L,1L,4L,10L,3L,2L,9L,1L,4L,11L,15L,10L,2L,1L,7L,4L,7L,3L,7L,1L,21L,12L,4L,2L,4L,1L,6L,5L,8L,7L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157409Inst : IEnumerable<long>
{
public static readonly long[] Value=A157409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157409.Bytes);
public long this[int i]=>Value[i];

public static A157409Inst Instance=new A157409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157410
{
public static readonly long[] Value={ 97L,199L,293L,397L,499L,599L,691L,797L,887L,997L,1097L,1193L,1297L,1399L,1499L,1597L,1699L,1789L,1889L,1999L,2099L,2179L,2297L,2399L,2477L,2593L,2699L,2797L,2897L,2999L,3089L,3191L,3299L,3391L,3499L,3593L,3697L,3797L,3889L,3989L,4099L,4177L,4297L,4397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157410Inst : IEnumerable<long>
{
public static readonly long[] Value=A157410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157410.Bytes);
public long this[int i]=>Value[i];

public static A157410Inst Instance=new A157410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157411
{
public static readonly long[] Value={ -19L,11L,-19L,251L,1901L,6731L,17261L,36731L,69101L,119051L,191981L,294011L,431981L,613451L,846701L,1140731L,1505261L,1950731L,2488301L,3129851L,3887981L,4776011L,5807981L,6998651L,8363501L,9918731L,11681261L,13668731L,15899501L,18392651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157411Inst : IEnumerable<long>
{
public static readonly long[] Value=A157411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157411.Bytes);
public long this[int i]=>Value[i];

public static A157411Inst Instance=new A157411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157412
{
public static readonly long[] Value={ 0L,-1L,0L,1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,-1L,1L,0L,1L,1L,-1L,-1L,-1L,1L,0L,-1L,-1L,1L,1L,1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157412Inst : IEnumerable<long>
{
public static readonly long[] Value=A157412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157412.Bytes);
public long this[int i]=>Value[i];

public static A157412Inst Instance=new A157412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157413
{
public static readonly long[] Value={ 1L,7L,4L,0L,8L,7L,0L,7L,1L,7L,6L,0L,9L,7L,9L,3L,6L,2L,4L,7L,1L,9L,9L,3L,3L,1L,6L,6L,2L,1L,5L,5L,4L,4L,4L,2L,6L,5L,8L,7L,4L,9L,5L,0L,0L,0L,8L,1L,0L,3L,3L,0L,6L,8L,4L,0L,1L,6L,1L,4L,8L,1L,1L,9L,9L,4L,9L,8L,8L,3L,2L,9L,0L,2L,0L,7L,2L,4L,5L,5L,3L,9L,2L,4L,2L,1L,5L,0L,7L,9L,1L,8L,6L,9L,8L,2L,0L,7L,3L,0L,8L,2L,3L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157413Inst : IEnumerable<long>
{
public static readonly long[] Value=A157413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157413.Bytes);
public long this[int i]=>Value[i];

public static A157413Inst Instance=new A157413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157414
{
public static readonly long[] Value={ 0L,1L,8L,5L,5L,0L,2L,6L,6L,2L,7L,9L,9L,4L,9L,7L,0L,6L,5L,8L,9L,2L,6L,5L,4L,8L,5L,2L,8L,8L,2L,0L,4L,7L,7L,7L,4L,3L,0L,1L,6L,8L,9L,3L,1L,8L,6L,9L,2L,7L,5L,1L,2L,7L,0L,3L,2L,8L,2L,8L,9L,3L,0L,0L,3L,5L,0L,1L,5L,8L,8L,4L,7L,7L,6L,3L,7L,1L,6L,5L,7L,3L,8L,8L,0L,1L,5L,8L,5L,4L,6L,3L,6L,6L,7L,7L,0L,3L,8L,1L,7L,4L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157414Inst : IEnumerable<long>
{
public static readonly long[] Value=A157414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157414.Bytes);
public long this[int i]=>Value[i];

public static A157414Inst Instance=new A157414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157415
{
public static readonly long[] Value={ 0L,-1L,-1L,1L,-2L,1L,-1L,2L,2L,-1L,1L,-2L,-2L,-2L,1L,-1L,0L,-2L,-2L,0L,-1L,1L,2L,-2L,-2L,-2L,2L,1L,-1L,0L,0L,2L,2L,0L,0L,-1L,-1L,2L,0L,-2L,2L,-2L,0L,2L,-1L,1L,0L,0L,0L,-2L,-2L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157415Inst : IEnumerable<long>
{
public static readonly long[] Value=A157415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157415.Bytes);
public long this[int i]=>Value[i];

public static A157415Inst Instance=new A157415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157416
{
public static readonly long[] Value={ 0L,0L,0L,4L,8L,12L,24L,32L,42L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157416Inst : IEnumerable<long>
{
public static readonly long[] Value=A157416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157416.Bytes);
public long this[int i]=>Value[i];

public static A157416Inst Instance=new A157416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157417
{
public static readonly long[] Value={ 7L,17L,29L,43L,61L,103L,157L,257L,337L,641L,701L,829L,967L,1117L,1277L,1361L,1447L,1723L,2129L,2237L,2347L,3067L,3329L,3463L,4177L,4327L,4481L,4637L,4957L,5981L,6343L,6529L,6907L,7297L,7901L,8317L,9181L,9403L,9629L,9857L,10321L,11527L,11777L,12541L,13063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157417Inst : IEnumerable<long>
{
public static readonly long[] Value=A157417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157417.Bytes);
public long this[int i]=>Value[i];

public static A157417Inst Instance=new A157417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157418
{
public static readonly long[] Value={ 1L,2L,5L,16L,55L,202L,773L,3052L,12339L,50830L,212593L,900368L,3853551L,16641554L,72423661L,317312532L,1398490091L,6195882006L,27578607593L,123270393880L,553075982311L,2489989595162L,11245131702245L,50929608736796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157418Inst : IEnumerable<long>
{
public static readonly long[] Value=A157418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157418.Bytes);
public long this[int i]=>Value[i];

public static A157418Inst Instance=new A157418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157419
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,13L,14L,19L,20L,27L,31L,32L,39L,43L,44L,49L,54L,61L,62L,69L,73L,74L,81L,85L,91L,99L,103L,104L,109L,110L,117L,128L,133L,138L,143L,150L,157L,158L,165L,169L,174L,181L,182L,193L,194L,199L,200L,213L,224L,229L,230L,237L,241L,242L,255L,259L,264L,271L,272L,279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157419Inst : IEnumerable<long>
{
public static readonly long[] Value=A157419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157419.Bytes);
public long this[int i]=>Value[i];

public static A157419Inst Instance=new A157419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157420
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,11L,14L,23L,35L,57L,91L,145L,234L,379L,611L,989L,1598L,2587L,4182L,6767L,10947L,17713L,28658L,46371L,75026L,121395L,196421L,317812L,514233L,832042L,1346271L,2178310L,3524579L,5702889L,9227467L,14930353L,24157818L,39088171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157420Inst : IEnumerable<long>
{
public static readonly long[] Value=A157420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157420.Bytes);
public long this[int i]=>Value[i];

public static A157420Inst Instance=new A157420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157421
{
public static readonly long[] Value={ 1L,2L,5L,11L,17L,26L,37L,50L,67L,82L,101L,122L,145L,171L,197L,226L,257L,290L,327L,362L,401L,442L,485L,531L,577L,626L,677L,730L,787L,842L,901L,962L,1025L,1091L,1157L,1226L,1297L,1370L,1447L,1522L,1601L,1682L,1765L,1851L,1937L,2026L,2117L,2210L,2307L,2402L,2501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157421Inst : IEnumerable<long>
{
public static readonly long[] Value=A157421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157421.Bytes);
public long this[int i]=>Value[i];

public static A157421Inst Instance=new A157421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157422
{
public static readonly BigInteger[] Value={ 1L,-7L,-29L,3353L,26941L,-6041287L,-72765089L,23109418073L,371109977881L,-151707487666567L,-3045291210990149L,1521724999112656793L,BigInteger.Parse("36655490867588684821"),BigInteger.Parse("-21647255423482090059847"),BigInteger.Parse("-608348545782999411843209"),BigInteger.Parse("414538453729821857298935513"),BigInteger.Parse("13313934020481550446632579761") };
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
public class A157422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157422Inst Instance=new A157422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157423
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157423Inst : IEnumerable<long>
{
public static readonly long[] Value=A157423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157423.Bytes);
public long this[int i]=>Value[i];

public static A157423Inst Instance=new A157423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157424
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,2L,1L,0L,1L,0L,0L,3L,0L,1L,0L,1L,0L,0L,5L,1L,0L,1L,0L,1L,0L,0L,7L,1L,1L,0L,1L,0L,3L,0L,0L,11L,1L,1L,1L,0L,2L,0L,5L,0L,0L,0L,17L,0L,1L,1L,1L,0L,3L,0L,7L,0L,0L,27L,1L,0L,1L,1L,2L,0L,5L,0L,11L,0L,0L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157424Inst : IEnumerable<long>
{
public static readonly long[] Value=A157424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157424.Bytes);
public long this[int i]=>Value[i];

public static A157424Inst Instance=new A157424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157425
{
public static readonly long[] Value={ 120L,125L,128L,216L,243L,256L,343L,512L,625L,720L,729L,1000L,1024L,1089L,1156L,1225L,1296L,1331L,1369L,1444L,1521L,1600L,1681L,1728L,1764L,1849L,1936L,2025L,2048L,2116L,2187L,2197L,2209L,2304L,2401L,2500L,2601L,2704L,2744L,2809L,2916L,3025L,3125L,3136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157425Inst : IEnumerable<long>
{
public static readonly long[] Value=A157425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157425.Bytes);
public long this[int i]=>Value[i];

public static A157425Inst Instance=new A157425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157426
{
public static readonly long[] Value={ 20L,35L,35L,54L,65L,69L,77L,84L,84L,95L,98L,98L,99L,99L,104L,104L,104L,110L,114L,114L,119L,119L,132L,132L,135L,135L,147L,153L,153L,159L,161L,170L,170L,170L,174L,174L,175L,185L,185L,186L,186L,188L,189L,189L,189L,189L,189L,195L,195L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157426Inst : IEnumerable<long>
{
public static readonly long[] Value=A157426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157426.Bytes);
public long this[int i]=>Value[i];

public static A157426Inst Instance=new A157426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157427
{
public static readonly long[] Value={ 14L,14L,20L,44L,39L,45L,21L,34L,50L,75L,21L,77L,44L,54L,39L,65L,90L,74L,45L,69L,34L,84L,56L,76L,50L,84L,111L,33L,119L,105L,69L,75L,95L,152L,14L,20L,55L,74L,110L,33L,153L,140L,14L,35L,56L,132L,174L,20L,35L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157427Inst : IEnumerable<long>
{
public static readonly long[] Value=A157427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157427.Bytes);
public long this[int i]=>Value[i];

public static A157427Inst Instance=new A157427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157428
{
public static readonly long[] Value={ 54L,174L,550L,574L,588L,608L,678L,740L,740L,790L,798L,804L,874L,944L,986L,986L,994L,1034L,1064L,1104L,1104L,1158L,1208L,1274L,1308L,1308L,1308L,1308L,1406L,1420L,1462L,1462L,1462L,1494L,1494L,1550L,1580L,1580L,1610L,1624L,1638L,1650L,1664L,1664L,1664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157428Inst : IEnumerable<long>
{
public static readonly long[] Value=A157428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157428.Bytes);
public long this[int i]=>Value[i];

public static A157428Inst Instance=new A157428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157429
{
public static readonly long[] Value={ 20L,98L,114L,368L,494L,474L,194L,258L,264L,224L,374L,740L,740L,648L,322L,376L,398L,1000L,1000L,440L,986L,608L,754L,1000L,544L,644L,1034L,1274L,406L,1274L,152L,644L,1274L,50L,1220L,484L,34L,804L,714L,440L,594L,1014L,220L,1000L,1182L,370L,390L,574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157429Inst : IEnumerable<long>
{
public static readonly long[] Value=A157429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157429.Bytes);
public long this[int i]=>Value[i];

public static A157429Inst Instance=new A157429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157430
{
public static readonly long[] Value={ 727L,5623L,21611L,131771L,751691L,8311687L,16867447L,25431851L,71014331L,109056251L,350550731L,3170478247L,4435959611L,4678970407L,6353205851L,9659548091L,11977770247L,26525659687L,29365277771L,39262233611L,52986054967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157430Inst : IEnumerable<long>
{
public static readonly long[] Value=A157430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157430.Bytes);
public long this[int i]=>Value[i];

public static A157430Inst Instance=new A157430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157431
{
public static readonly long[] Value={ 410L,495L,588L,689L,798L,915L,1040L,1173L,1314L,1463L,1620L,1785L,1958L,2139L,2328L,2525L,2730L,2943L,3164L,3393L,3630L,3875L,4128L,4389L,4658L,4935L,5220L,5513L,5814L,6123L,6440L,6765L,7098L,7439L,7788L,8145L,8510L,8883L,9264L,9653L,10050L,10455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157431Inst : IEnumerable<long>
{
public static readonly long[] Value=A157431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157431.Bytes);
public long this[int i]=>Value[i];

public static A157431Inst Instance=new A157431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157432
{
public static readonly long[] Value={ 648L,712L,776L,840L,904L,968L,1032L,1096L,1160L,1224L,1288L,1352L,1416L,1480L,1544L,1608L,1672L,1736L,1800L,1864L,1928L,1992L,2056L,2120L,2184L,2248L,2312L,2376L,2440L,2504L,2568L,2632L,2696L,2760L,2824L,2888L,2952L,3016L,3080L,3144L,3208L,3272L,3336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157432Inst : IEnumerable<long>
{
public static readonly long[] Value=A157432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157432.Bytes);
public long this[int i]=>Value[i];

public static A157432Inst Instance=new A157432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157433
{
public static readonly long[] Value={ 13121L,15841L,18817L,22049L,25537L,29281L,33281L,37537L,42049L,46817L,51841L,57121L,62657L,68449L,74497L,80801L,87361L,94177L,101249L,108577L,116161L,124001L,132097L,140449L,149057L,157921L,167041L,176417L,186049L,195937L,206081L,216481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157433Inst : IEnumerable<long>
{
public static readonly long[] Value=A157433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157433.Bytes);
public long this[int i]=>Value[i];

public static A157433Inst Instance=new A157433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157434
{
public static readonly long[] Value={ 473L,564L,663L,770L,885L,1008L,1139L,1278L,1425L,1580L,1743L,1914L,2093L,2280L,2475L,2678L,2889L,3108L,3335L,3570L,3813L,4064L,4323L,4590L,4865L,5148L,5439L,5738L,6045L,6360L,6683L,7014L,7353L,7700L,8055L,8418L,8789L,9168L,9555L,9950L,10353L,10764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157434Inst : IEnumerable<long>
{
public static readonly long[] Value=A157434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157434.Bytes);
public long this[int i]=>Value[i];

public static A157434Inst Instance=new A157434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157435
{
public static readonly long[] Value={ 696L,760L,824L,888L,952L,1016L,1080L,1144L,1208L,1272L,1336L,1400L,1464L,1528L,1592L,1656L,1720L,1784L,1848L,1912L,1976L,2040L,2104L,2168L,2232L,2296L,2360L,2424L,2488L,2552L,2616L,2680L,2744L,2808L,2872L,2936L,3000L,3064L,3128L,3192L,3256L,3320L,3384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157435Inst : IEnumerable<long>
{
public static readonly long[] Value=A157435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157435.Bytes);
public long this[int i]=>Value[i];

public static A157435Inst Instance=new A157435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157436
{
public static readonly long[] Value={ 15137L,18049L,21217L,24641L,28321L,32257L,36449L,40897L,45601L,50561L,55777L,61249L,66977L,72961L,79201L,85697L,92449L,99457L,106721L,114241L,122017L,130049L,138337L,146881L,155681L,164737L,174049L,183617L,193441L,203521L,213857L,224449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157436Inst : IEnumerable<long>
{
public static readonly long[] Value=A157436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157436.Bytes);
public long this[int i]=>Value[i];

public static A157436Inst Instance=new A157436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157437
{
public static readonly long[] Value={ 5L,7L,11L,29L,31L,53L,59L,73L,79L,83L,97L,101L,103L,107L,127L,131L,149L,151L,173L,179L,193L,197L,199L,223L,227L,241L,251L,269L,271L,293L,313L,317L,337L,347L,367L,389L,409L,419L,433L,439L,443L,457L,461L,463L,467L,487L,491L,509L,557L,563L,577L,587L,601L,607L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157437Inst : IEnumerable<long>
{
public static readonly long[] Value=A157437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157437.Bytes);
public long this[int i]=>Value[i];

public static A157437Inst Instance=new A157437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157438
{
public static readonly long[] Value={ 5L,127L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157438Inst : IEnumerable<long>
{
public static readonly long[] Value=A157438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157438.Bytes);
public long this[int i]=>Value[i];

public static A157438Inst Instance=new A157438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157439
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157439Inst : IEnumerable<long>
{
public static readonly long[] Value=A157439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157439.Bytes);
public long this[int i]=>Value[i];

public static A157439Inst Instance=new A157439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157440
{
public static readonly long[] Value={ 3L,162L,563L,1206L,2091L,3218L,4587L,6198L,8051L,10146L,12483L,15062L,17883L,20946L,24251L,27798L,31587L,35618L,39891L,44406L,49163L,54162L,59403L,64886L,70611L,76578L,82787L,89238L,95931L,102866L,110043L,117462L,125123L,133026L,141171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157440Inst : IEnumerable<long>
{
public static readonly long[] Value=A157440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157440.Bytes);
public long this[int i]=>Value[i];

public static A157440Inst Instance=new A157440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157441
{
public static readonly long[] Value={ 209L,1540L,2871L,4202L,5533L,6864L,8195L,9526L,10857L,12188L,13519L,14850L,16181L,17512L,18843L,20174L,21505L,22836L,24167L,25498L,26829L,28160L,29491L,30822L,32153L,33484L,34815L,36146L,37477L,38808L,40139L,41470L,42801L,44132L,45463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157441Inst : IEnumerable<long>
{
public static readonly long[] Value=A157441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157441.Bytes);
public long this[int i]=>Value[i];

public static A157441Inst Instance=new A157441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157442
{
public static readonly long[] Value={ 362L,19601L,68122L,145925L,253010L,389377L,555026L,749957L,974170L,1227665L,1510442L,1822501L,2163842L,2534465L,2934370L,3363557L,3822026L,4309777L,4826810L,5373125L,5948722L,6553601L,7187762L,7851205L,8543930L,9265937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157442Inst : IEnumerable<long>
{
public static readonly long[] Value=A157442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157442.Bytes);
public long this[int i]=>Value[i];

public static A157442Inst Instance=new A157442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157443
{
public static readonly long[] Value={ 86L,411L,978L,1787L,2838L,4131L,5666L,7443L,9462L,11723L,14226L,16971L,19958L,23187L,26658L,30371L,34326L,38523L,42962L,47643L,52566L,57731L,63138L,68787L,74678L,80811L,87186L,93803L,100662L,107763L,115106L,122691L,130518L,138587L,146898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157443Inst : IEnumerable<long>
{
public static readonly long[] Value=A157443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157443.Bytes);
public long this[int i]=>Value[i];

public static A157443Inst Instance=new A157443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157444
{
public static readonly long[] Value={ 1122L,2453L,3784L,5115L,6446L,7777L,9108L,10439L,11770L,13101L,14432L,15763L,17094L,18425L,19756L,21087L,22418L,23749L,25080L,26411L,27742L,29073L,30404L,31735L,33066L,34397L,35728L,37059L,38390L,39721L,41052L,42383L,43714L,45045L,46376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157444Inst : IEnumerable<long>
{
public static readonly long[] Value=A157444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157444.Bytes);
public long this[int i]=>Value[i];

public static A157444Inst Instance=new A157444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157445
{
public static readonly long[] Value={ 10405L,49730L,118337L,216226L,343397L,499850L,685585L,900602L,1144901L,1418482L,1721345L,2053490L,2414917L,2805626L,3225617L,3674890L,4153445L,4661282L,5198401L,5764802L,6360485L,6985450L,7639697L,8323226L,9036037L,9778130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157445Inst : IEnumerable<long>
{
public static readonly long[] Value=A157445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157445.Bytes);
public long this[int i]=>Value[i];

public static A157445Inst Instance=new A157445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157446
{
public static readonly long[] Value={ 15L,62L,141L,252L,395L,570L,777L,1016L,1287L,1590L,1925L,2292L,2691L,3122L,3585L,4080L,4607L,5166L,5757L,6380L,7035L,7722L,8441L,9192L,9975L,10790L,11637L,12516L,13427L,14370L,15345L,16352L,17391L,18462L,19565L,20700L,21867L,23066L,24297L,25560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157446Inst : IEnumerable<long>
{
public static readonly long[] Value=A157446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157446.Bytes);
public long this[int i]=>Value[i];

public static A157446Inst Instance=new A157446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157447
{
public static readonly long[] Value={ 496L,1008L,1520L,2032L,2544L,3056L,3568L,4080L,4592L,5104L,5616L,6128L,6640L,7152L,7664L,8176L,8688L,9200L,9712L,10224L,10736L,11248L,11760L,12272L,12784L,13296L,13808L,14320L,14832L,15344L,15856L,16368L,16880L,17392L,17904L,18416L,18928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157447Inst : IEnumerable<long>
{
public static readonly long[] Value=A157447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157447.Bytes);
public long this[int i]=>Value[i];

public static A157447Inst Instance=new A157447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157448
{
public static readonly long[] Value={ 1921L,7937L,18049L,32257L,50561L,72961L,99457L,130049L,164737L,203521L,246401L,293377L,344449L,399617L,458881L,522241L,589697L,661249L,736897L,816641L,900481L,988417L,1080449L,1176577L,1276801L,1381121L,1489537L,1602049L,1718657L,1839361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157448Inst : IEnumerable<long>
{
public static readonly long[] Value=A157448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157448.Bytes);
public long this[int i]=>Value[i];

public static A157448Inst Instance=new A157448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157449
{
public static readonly long[] Value={ 2L,3L,2L,5L,1L,7L,2L,6L,3L,11L,-3L,13L,5L,7L,2L,17L,-2L,19L,-1L,11L,9L,23L,-11L,20L,11L,15L,1L,29L,-11L,31L,2L,19L,15L,23L,-18L,37L,17L,23L,-9L,41L,-11L,43L,5L,13L,21L,47L,-27L,42L,8L,31L,7L,53L,-11L,39L,-7L,35L,27L,59L,-47L,61L,29L,23L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157449Inst : IEnumerable<long>
{
public static readonly long[] Value=A157449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157449.Bytes);
public long this[int i]=>Value[i];

public static A157449Inst Instance=new A157449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157450
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,6L,9L,8L,10L,10L,24L,12L,32L,16L,18L,18L,64L,21L,81L,22L,28L,32L,144L,27L,40L,42L,36L,35L,288L,39L,384L,39L,56L,70L,63L,45L,729L,84L,75L,52L,1024L,56L,1296L,66L,66L,128L,1944L,60L,112L,78L,126L,88L,3072L,78L,140L,78L,150L,224L,5184L,81L,6144L,256L,104L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157450Inst : IEnumerable<long>
{
public static readonly long[] Value=A157450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157450.Bytes);
public long this[int i]=>Value[i];

public static A157450Inst Instance=new A157450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157451
{
public static readonly BigInteger[] Value={ 1L,3L,13L,85L,806L,9583L,140050L,2434185L,49031983L,1122332211L,28768909071L,816222524845L,25389827448220L,859153189293015L,31417769545499716L,1234605616147931665L,BigInteger.Parse("51882038993710230701"),BigInteger.Parse("2321660210597147557819") };
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
public class A157451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157451Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157451.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157451.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157451Inst Instance=new A157451Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157452
{
public static readonly BigInteger[] Value={ 1L,3L,16L,105L,961L,11137L,160000L,2738385L,54479161L,1234554321L,31384248336L,884241045961L,27342890695849L,920521266133785L,33512287502995456L,1311768467139281697L,BigInteger.Parse("54933923639963082961"),BigInteger.Parse("2450641333396432006369") };
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
public class A157452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157452Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157452.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157452.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157452Inst Instance=new A157452Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157453
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,19L,19L,1L,1L,188L,630L,188L,1L,1L,1717L,15258L,15258L,1717L,1L,1L,15494L,316047L,762900L,316047L,15494L,1L,1L,139495L,6008053L,29502051L,29502051L,6008053L,139495L,1L,1L,1255520L,109096108L,986409824L,1953238566L,986409824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157453Inst : IEnumerable<long>
{
public static readonly long[] Value=A157453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157453.Bytes);
public long this[int i]=>Value[i];

public static A157453Inst Instance=new A157453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157454
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,3L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,7L,5L,3L,1L,1L,3L,5L,7L,7L,5L,3L,1L,1L,3L,5L,7L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,9L,7L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157454Inst : IEnumerable<long>
{
public static readonly long[] Value=A157454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157454.Bytes);
public long this[int i]=>Value[i];

public static A157454Inst Instance=new A157454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157455
{
public static readonly BigInteger[] Value={ 1L,3L,19L,125L,1141L,12943L,182743L,3080025L,60530761L,1357997531L,34237329611L,957927505717L,29446189175677L,986272776455415L,35746439978786671L,1393753996031259953L,BigInteger.Parse("58165330912030118161"),BigInteger.Parse("2586788074128361802419") };
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
public class A157455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157455Inst Instance=new A157455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157456
{
public static readonly BigInteger[] Value={ 1L,15L,239L,3809L,60705L,967471L,15418831L,245733825L,3916322369L,62415424079L,994730462895L,15853271982241L,252657621252961L,4026668668065135L,64174041067789199L,1022757988416562049L,16299953773597203585UL,BigInteger.Parse("259776502389138695311"),BigInteger.Parse("4140124084452621921391") };
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
public class A157456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157456Inst Instance=new A157456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157457
{
public static readonly BigInteger[] Value={ 0L,3L,16L,125L,1116L,12943L,182400L,3080025L,60524200L,1357997531L,34237168560L,957927505717L,29446184348868L,986272776455415L,35746439807927296L,1393753996031259953L,BigInteger.Parse("58165330905054360720"),BigInteger.Parse("2586788074128361802419") };
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
public class A157457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157457Inst Instance=new A157457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157458
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,3L,4L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,6L,5L,3L,1L,1L,3L,5L,7L,7L,5L,3L,1L,1L,3L,5L,7L,8L,7L,5L,3L,1L,1L,3L,5L,7L,9L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,10L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157458Inst : IEnumerable<long>
{
public static readonly long[] Value=A157458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157458.Bytes);
public long this[int i]=>Value[i];

public static A157458Inst Instance=new A157458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157459
{
public static readonly BigInteger[] Value={ 0L,72L,23256L,7488432L,2411251920L,776415629880L,250003421569512L,80500325329753056L,BigInteger.Parse("25920854752758914592"),BigInteger.Parse("8346434730063040745640"),BigInteger.Parse("2687526062225546361181560"),BigInteger.Parse("865375045601895865259716752"),BigInteger.Parse("278648077157748243067267612656"),BigInteger.Parse("89723815469749332371794911558552") };
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
public class A157459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157459Inst Instance=new A157459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157460
{
public static readonly BigInteger[] Value={ 0L,88L,42504L,20486928L,9874656880L,4759564129320L,2294100035675448L,1105751457631436704L,BigInteger.Parse("532969908478316815968"),BigInteger.Parse("256890390135091073859960"),BigInteger.Parse("123820635075205419283684840"),BigInteger.Parse("59681289215858877003662233008"),BigInteger.Parse("28766257581408903510345912625104") };
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
public class A157460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157460Inst Instance=new A157460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157461
{
public static readonly BigInteger[] Value={ 1L,27L,701L,18199L,472473L,12266099L,318446101L,8267332527L,214632199601L,5572169857099L,144661784084973L,3755634216352199L,97501827841072201L,2531291889651525027L,BigInteger.Parse("65716087303098578501"),BigInteger.Parse("1706086977990911515999"),BigInteger.Parse("44292545340460600837473") };
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
public class A157461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157461Inst Instance=new A157461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157462
{
public static readonly BigInteger[] Value={ 1L,15L,900L,13500L,810000L,12150000L,729000000L,10935000000L,656100000000L,9841500000000L,590490000000000L,8857350000000000L,531441000000000000L,7971615000000000000L,BigInteger.Parse("478296900000000000000"),BigInteger.Parse("7174453500000000000000") };
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
public class A157462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157462Inst Instance=new A157462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157463
{
public static readonly BigInteger[] Value={ 1L,-4L,-161L,611L,170821L,-1125721L,-465389981L,4315888331L,2375412785641L,-28339565851441L,-19493993823335801L,284271853827728051L,BigInteger.Parse("234646937981918468461"),BigInteger.Parse("-4043912971306984481161"),BigInteger.Parse("-3894294137215835281661621"),BigInteger.Parse("77439746620281666611423771"),BigInteger.Parse("85228083768308990492305043281") };
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
public class A157463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157463Inst Instance=new A157463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157464
{
public static readonly long[] Value={ 4L,3L,1L,1L,3L,1L,3L,0L,1L,2L,1L,1L,1L,0L,1L,0L,3L,0L,0L,2L,0L,1L,1L,0L,1L,4L,1L,0L,1L,3L,0L,1L,1L,0L,1L,0L,2L,0L,0L,0L,1L,2L,0L,0L,3L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,2L,1L,0L,1L,0L,2L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,1L,0L,2L,0L,0L,3L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,2L,0L,0L,0L,3L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157464Inst : IEnumerable<long>
{
public static readonly long[] Value=A157464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157464.Bytes);
public long this[int i]=>Value[i];

public static A157464Inst Instance=new A157464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157465
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,16L,19L,21L,22L,24L,25L,26L,28L,29L,31L,32L,34L,36L,40L,41L,44L,48L,49L,52L,56L,57L,59L,61L,62L,64L,65L,66L,67L,69L,72L,74L,76L,78L,79L,81L,84L,89L,90L,91L,96L,100L,102L,104L,108L,109L,115L,116L,121L,122L,124L,125L,126L,129L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157465Inst : IEnumerable<long>
{
public static readonly long[] Value=A157465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157465.Bytes);
public long this[int i]=>Value[i];

public static A157465Inst Instance=new A157465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157466
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,12L,13L,13L,14L,14L,14L,15L,15L,16L,17L,17L,18L,19L,20L,20L,21L,22L,22L,23L,24L,24L,25L,25L,26L,26L,26L,26L,27L,28L,28L,28L,29L,29L,29L,29L,30L,31L,31L,31L,32L,32L,32L,32L,33L,34L,34L,35L,35L,36L,37L,37L,38L,39L,40L,41L,41L,42L,42L,42L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157466Inst : IEnumerable<long>
{
public static readonly long[] Value=A157466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157466.Bytes);
public long this[int i]=>Value[i];

public static A157466Inst Instance=new A157466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157467
{
public static readonly long[] Value={ 17L,37L,197L,401L,577L,2917L,5477L,7057L,8101L,12101L,22501L,32401L,50177L,52901L,57601L,69697L,72901L,80657L,98597L,122501L,147457L,176401L,193601L,197137L,215297L,324901L,352837L,414737L,427717L,454277L,547601L,739601L,746497L,846401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157467Inst : IEnumerable<long>
{
public static readonly long[] Value=A157467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157467.Bytes);
public long this[int i]=>Value[i];

public static A157467Inst Instance=new A157467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157468
{
public static readonly long[] Value={ 3L,5L,13L,19L,23L,53L,73L,83L,89L,109L,149L,179L,223L,229L,239L,263L,269L,283L,313L,349L,383L,419L,439L,443L,463L,569L,593L,643L,653L,673L,739L,859L,863L,919L,929L,1009L,1069L,1093L,1123L,1289L,1319L,1373L,1409L,1429L,1433L,1439L,1459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157468Inst : IEnumerable<long>
{
public static readonly long[] Value=A157468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157468.Bytes);
public long this[int i]=>Value[i];

public static A157468Inst Instance=new A157468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157469
{
public static readonly long[] Value={ 85L,97L,113L,397L,485L,593L,2297L,2813L,3445L,13385L,16393L,20077L,78013L,95545L,117017L,454693L,556877L,682025L,2650145L,3245717L,3975133L,15446177L,18917425L,23168773L,90026917L,110258833L,135037505L,524715325L,642635573L,787056257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157469Inst : IEnumerable<long>
{
public static readonly long[] Value=A157469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157469.Bytes);
public long this[int i]=>Value[i];

public static A157469Inst Instance=new A157469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157470
{
public static readonly long[] Value={ 1L,2L,2L,4L,7L,3L,1L,8L,5L,4L,3L,6L,3L,1L,2L,7L,1L,2L,0L,4L,4L,5L,6L,0L,4L,5L,5L,8L,1L,3L,3L,3L,5L,8L,4L,8L,5L,5L,6L,6L,7L,5L,6L,7L,6L,5L,5L,1L,8L,3L,2L,2L,4L,0L,2L,3L,1L,4L,1L,5L,9L,9L,6L,2L,1L,8L,4L,2L,2L,9L,4L,2L,9L,8L,8L,1L,1L,2L,8L,8L,5L,0L,9L,6L,8L,0L,9L,7L,1L,6L,9L,9L,0L,2L,9L,5L,8L,5L,7L,7L,5L,0L,8L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157470Inst : IEnumerable<long>
{
public static readonly long[] Value=A157470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157470.Bytes);
public long this[int i]=>Value[i];

public static A157470Inst Instance=new A157470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157471
{
public static readonly long[] Value={ 3L,8L,8L,5L,7L,0L,0L,6L,7L,9L,9L,7L,0L,5L,8L,7L,4L,4L,1L,7L,0L,8L,6L,1L,7L,5L,8L,9L,6L,7L,0L,6L,4L,0L,4L,3L,0L,2L,6L,2L,0L,8L,3L,0L,6L,2L,5L,7L,8L,3L,5L,7L,2L,3L,7L,0L,3L,2L,8L,9L,6L,6L,3L,4L,8L,7L,5L,9L,8L,4L,8L,0L,3L,3L,8L,3L,7L,4L,2L,3L,6L,9L,9L,5L,6L,8L,6L,8L,6L,9L,3L,7L,3L,3L,0L,8L,8L,9L,3L,4L,3L,0L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157471Inst : IEnumerable<long>
{
public static readonly long[] Value=A157471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157471.Bytes);
public long this[int i]=>Value[i];

public static A157471Inst Instance=new A157471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157472
{
public static readonly long[] Value={ 1L,8L,2L,1L,5L,1L,7L,6L,3L,2L,9L,7L,6L,9L,3L,1L,2L,3L,1L,7L,8L,6L,0L,1L,4L,9L,6L,4L,7L,6L,7L,3L,1L,2L,1L,7L,9L,0L,1L,6L,2L,2L,2L,8L,8L,5L,3L,3L,0L,2L,7L,1L,5L,3L,3L,8L,6L,7L,7L,6L,8L,9L,5L,5L,8L,4L,4L,6L,0L,1L,7L,5L,7L,7L,9L,5L,8L,0L,6L,1L,9L,1L,3L,9L,2L,0L,4L,5L,8L,0L,9L,3L,9L,5L,0L,4L,4L,7L,9L,0L,7L,5L,7L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157472Inst : IEnumerable<long>
{
public static readonly long[] Value=A157472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157472.Bytes);
public long this[int i]=>Value[i];

public static A157472Inst Instance=new A157472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157473
{
public static readonly long[] Value={ 2L,127L,91127L,328511L,1157627L,2146691L,12326393L,125751503L,693154127L,751089431L,1033364333L,2102071043L,2222447627L,2893640627L,3314613773L,3951805943L,6591796877L,9063964127L,13464285941L,16406426423L,19880486831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157473Inst : IEnumerable<long>
{
public static readonly long[] Value=A157473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157473.Bytes);
public long this[int i]=>Value[i];

public static A157473Inst Instance=new A157473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157474
{
public static readonly long[] Value={ 17L,66L,147L,260L,405L,582L,791L,1032L,1305L,1610L,1947L,2316L,2717L,3150L,3615L,4112L,4641L,5202L,5795L,6420L,7077L,7766L,8487L,9240L,10025L,10842L,11691L,12572L,13485L,14430L,15407L,16416L,17457L,18530L,19635L,20772L,21941L,23142L,24375L,25640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157474Inst : IEnumerable<long>
{
public static readonly long[] Value=A157474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157474.Bytes);
public long this[int i]=>Value[i];

public static A157474Inst Instance=new A157474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157475
{
public static readonly long[] Value={ 528L,1040L,1552L,2064L,2576L,3088L,3600L,4112L,4624L,5136L,5648L,6160L,6672L,7184L,7696L,8208L,8720L,9232L,9744L,10256L,10768L,11280L,11792L,12304L,12816L,13328L,13840L,14352L,14864L,15376L,15888L,16400L,16912L,17424L,17936L,18448L,18960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157475Inst : IEnumerable<long>
{
public static readonly long[] Value=A157475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157475.Bytes);
public long this[int i]=>Value[i];

public static A157475Inst Instance=new A157475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157476
{
public static readonly long[] Value={ 2177L,8449L,18817L,33281L,51841L,74497L,101249L,132097L,167041L,206081L,249217L,296449L,347777L,403201L,462721L,526337L,594049L,665857L,741761L,821761L,905857L,994049L,1086337L,1182721L,1283201L,1387777L,1496449L,1609217L,1726081L,1847041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157476Inst : IEnumerable<long>
{
public static readonly long[] Value=A157476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157476.Bytes);
public long this[int i]=>Value[i];

public static A157476Inst Instance=new A157476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157477
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,4L,4L,4L,4L,5L,6L,6L,6L,7L,8L,8L,9L,10L,10L,10L,11L,12L,12L,12L,12L,13L,14L,14L,14L,15L,16L,16L,16L,16L,17L,18L,19L,20L,20L,20L,21L,22L,22L,22L,22L,23L,24L,24L,24L,25L,26L,26L,26L,27L,28L,28L,28L,28L,29L,30L,30L,30L,31L,32L,33L,34L,34L,34L,35L,36L,36L,36L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157477Inst : IEnumerable<long>
{
public static readonly long[] Value=A157477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157477.Bytes);
public long this[int i]=>Value[i];

public static A157477Inst Instance=new A157477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157478
{
public static readonly long[] Value={ 5L,11L,17L,37L,53L,89L,107L,127L,179L,197L,223L,233L,257L,263L,401L,409L,421L,449L,457L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157478Inst : IEnumerable<long>
{
public static readonly long[] Value=A157478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157478.Bytes);
public long this[int i]=>Value[i];

public static A157478Inst Instance=new A157478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157479
{
public static readonly BigInteger[] Value={ 1L,-2L,-209L,659L,231781L,-1229881L,-634938029L,4723252379L,3242830776361L,-31020714328561L,-26614376748019049L,311173382329131299L,BigInteger.Parse("320356645333260001741"),BigInteger.Parse("-4426612415860378784041"),BigInteger.Parse("-5316771198863075606715269"),BigInteger.Parse("84768353003697761135589419"),BigInteger.Parse("116359537461502435135459795921") };
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
public class A157479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157479Inst Instance=new A157479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157480
{
public static readonly long[] Value={ 2L,13L,11L,2L,5L,3L,19L,17L,2L,7L,5L,107L,23L,101L,2L,11L,5L,3L,257L,29L,71L,2L,17L,11L,3L,43L,41L,37L,467L,31L,17L,13L,7L,5L,47L,173L,167L,1601L,2L,23L,17L,719L,5L,3L,59L,701L,113L,2L,29L,347L,23L,17L,83L,5L,67L,61L,131L,53L,47L,43L,41L,31L,17L,13L,11L,7L,569L,239L,53L,227L,47L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157480Inst : IEnumerable<long>
{
public static readonly long[] Value=A157480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157480.Bytes);
public long this[int i]=>Value[i];

public static A157480Inst Instance=new A157480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157481
{
public static readonly long[] Value={ 0L,2L,5L,8L,10L,16L,21L,24L,32L,36L,43L,53L,57L,65L,74L,86L,92L,104L,114L,123L,133L,150L,151L,175L,180L,194L,207L,224L,238L,251L,271L,275L,306L,305L,332L,349L,359L,383L,408L,410L,434L,458L,473L,497L,502L,549L,553L,570L,590L,630L,641L,668L,685L,718L,726L,748L,780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157481Inst : IEnumerable<long>
{
public static readonly long[] Value=A157481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157481.Bytes);
public long this[int i]=>Value[i];

public static A157481Inst Instance=new A157481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157482
{
public static readonly long[] Value={ 0L,1L,5L,8L,10L,16L,21L,24L,30L,39L,42L,52L,57L,65L,75L,86L,92L,102L,115L,122L,133L,150L,151L,176L,181L,192L,209L,221L,239L,252L,270L,273L,307L,308L,328L,350L,359L,383L,407L,414L,430L,460L,472L,494L,504L,548L,554L,571L,590L,629L,642L,669L,681L,722L,724L,749L,776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157482Inst : IEnumerable<long>
{
public static readonly long[] Value=A157482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157482.Bytes);
public long this[int i]=>Value[i];

public static A157482Inst Instance=new A157482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157483
{
public static readonly long[] Value={ 19L,29L,43L,51L,67L,69L,77L,115L,171L,173L,187L,189L,237L,243L,245L,267L,274L,283L,285L,291L,317L,344L,355L,386L,403L,405L,411L,424L,427L,429L,435L,437L,476L,507L,597L,603L,604L,605L,638L,653L,664L,669L,723L,763L,776L,787L,789L,846L,891L,893L,907L,926L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157483Inst : IEnumerable<long>
{
public static readonly long[] Value=A157483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157483.Bytes);
public long this[int i]=>Value[i];

public static A157483Inst Instance=new A157483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157484
{
public static readonly long[] Value={ 55L,89L,151L,197L,233L,249L,295L,307L,329L,341L,343L,349L,461L,489L,491L,569L,571L,665L,713L,739L,775L,851L,857L,859L,869L,871L,949L,1013L,1015L,1061L,1097L,1111L,1149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157484Inst : IEnumerable<long>
{
public static readonly long[] Value=A157484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157484.Bytes);
public long this[int i]=>Value[i];

public static A157484Inst Instance=new A157484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157485
{
public static readonly long[] Value={ 271L,593L,701L,751L,919L,1169L,1241L,1639L,1649L,1673L,1711L,1751L,2071L,2311L,2393L,2549L,2551L,2609L,2729L,2861L,2863L,2897L,2899L,3185L,3331L,3569L,3631L,3823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157485Inst : IEnumerable<long>
{
public static readonly long[] Value=A157485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157485.Bytes);
public long this[int i]=>Value[i];

public static A157485Inst Instance=new A157485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157486
{
public static readonly long[] Value={ 1889L,3079L,4591L,5023L,6175L,6641L,7649L,9881L,10961L,11501L,11935L,12689L,13751L,14417L,15499L,15713L,16687L,18017L,18089L,18271L,19169L,19249L,19889L,19951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157486Inst : IEnumerable<long>
{
public static readonly long[] Value=A157486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157486.Bytes);
public long this[int i]=>Value[i];

public static A157486Inst Instance=new A157486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157487
{
public static readonly long[] Value={ 10529L,15391L,17983L,18751L,22049L,23489L,24751L,26081L,29249L,32561L,35153L,43471L,49951L,52975L,58049L,58481L,67229L,67231L,70687L,71873L,72415L,76049L,77921L,79001L,79649L,82783L,83249L,85751L,88289L,93799L,95551L,97471L,102545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157487Inst : IEnumerable<long>
{
public static readonly long[] Value=A157487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157487.Bytes);
public long this[int i]=>Value[i];

public static A157487Inst Instance=new A157487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157488
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,6L,7L,16L,27L,10L,11L,72L,13L,14L,15L,128L,17L,108L,19L,200L,21L,22L,23L,144L,125L,26L,81L,392L,29L,30L,31L,64L,33L,34L,35L,46656L,37L,38L,39L,400L,41L,42L,43L,968L,675L,46L,47L,3456L,343L,500L,51L,1352L,53L,324L,55L,784L,57L,58L,59L,1800L,61L,62L,1323L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157488Inst : IEnumerable<long>
{
public static readonly long[] Value=A157488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157488.Bytes);
public long this[int i]=>Value[i];

public static A157488Inst Instance=new A157488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157489
{
public static readonly long[] Value={ 275L,373L,445L,755L,985L,1165L,1245L,1475L,1535L,1643L,1645L,1705L,1715L,1745L,2219L,2305L,2317L,2389L,2445L,2455L,2543L,2579L,2845L,2855L,2893L,3229L,3299L,3325L,3371L,3565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157489Inst : IEnumerable<long>
{
public static readonly long[] Value=A157489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157489.Bytes);
public long this[int i]=>Value[i];

public static A157489Inst Instance=new A157489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157490
{
public static readonly BigInteger[] Value={ 1L,-1L,-221L,671L,247741L,-1256641L,-679694561L,4828434911L,3472065862681L,-31713479172481L,-28496356975044101L,318124890738776351L,BigInteger.Parse("343010832773925500821"),BigInteger.Parse("-4525505109433347923521"),BigInteger.Parse("-5692750997030096043664841"),BigInteger.Parse("86662127452557373393360991"),BigInteger.Parse("124588000528729279236183338161") };
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
public class A157490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157490Inst Instance=new A157490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157491
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,2L,0L,2L,-6L,5L,0L,-5L,20L,-28L,14L,0L,14L,-70L,135L,-120L,42L,0L,-42L,252L,-616L,770L,-495L,132L,0L,132L,-924L,2730L,-4368L,4004L,-2002L,429L,0L,-429L,3432L,-11880L,23100L,-27300L,19656L,-8008L,1430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157491Inst : IEnumerable<long>
{
public static readonly long[] Value=A157491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157491.Bytes);
public long this[int i]=>Value[i];

public static A157491Inst Instance=new A157491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157492
{
public static readonly long[] Value={ 4L,17L,55L,142L,350L,727L,1393L,2420L,3976L,6373L,9731L,14458L,20866L,29123L,39589L,52864L,69620L,90097L,115063L,145070L,180406L,221983L,270449L,326836L,392632L,468629L,555235L,653290L,763226L,885931L,1024765L,1180760L,1355524L,1549609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157492Inst : IEnumerable<long>
{
public static readonly long[] Value=A157492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157492.Bytes);
public long this[int i]=>Value[i];

public static A157492Inst Instance=new A157492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157493
{
public static readonly long[] Value={ 4L,21L,76L,218L,568L,1295L,2688L,5108L,9084L,15457L,25188L,39646L,60512L,89635L,129224L,182088L,251708L,341805L,456868L,601938L,782344L,1004327L,1274776L,1601612L,1994244L,2462873L,3018108L,3671398L,4434624L,5320555L,6345320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157493Inst : IEnumerable<long>
{
public static readonly long[] Value=A157493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157493.Bytes);
public long this[int i]=>Value[i];

public static A157493Inst Instance=new A157493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157494
{
public static readonly long[] Value={ 2L,1429L,32869L,3189059L,5157791L,62701339L,139181423L,296686879L,522304883L,5070516751L,6276844867L,7098350179L,8983996079L,9331926623L,21211375343L,31177858939L,34861039007L,38865340309L,39918757589L,62858815181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157494Inst : IEnumerable<long>
{
public static readonly long[] Value=A157494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157494.Bytes);
public long this[int i]=>Value[i];

public static A157494Inst Instance=new A157494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157495
{
public static readonly long[] Value={ 2L,2L,5L,3L,2L,13L,13L,3L,7L,13L,31L,37L,5L,7L,11L,17L,23L,61L,3L,7L,37L,43L,2L,53L,61L,37L,3L,7L,73L,13L,127L,31L,37L,103L,5L,7L,13L,19L,23L,29L,79L,37L,47L,157L,53L,3L,67L,79L,2L,193L,37L,43L,97L,107L,61L,7L,13L,127L,241L,137L,139L,37L,163L,167L,277L,61L,7L,13L,23L,313L,29L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157495Inst : IEnumerable<long>
{
public static readonly long[] Value=A157495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157495.Bytes);
public long this[int i]=>Value[i];

public static A157495Inst Instance=new A157495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157496
{
public static readonly long[] Value={ 22L,33L,44L,55L,66L,77L,88L,99L,110L,112L,121L,123L,132L,134L,143L,145L,154L,156L,165L,176L,178L,187L,189L,198L,202L,213L,220L,224L,231L,235L,242L,246L,253L,264L,268L,275L,279L,286L,297L,303L,312L,314L,321L,325L,330L,336L,341L,352L,358L,363L,369L,374L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157496Inst : IEnumerable<long>
{
public static readonly long[] Value=A157496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157496.Bytes);
public long this[int i]=>Value[i];

public static A157496Inst Instance=new A157496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157497
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,3L,1L,4L,0L,4L,1L,0L,0L,0L,5L,1L,6L,9L,0L,0L,6L,1L,0L,0L,0L,0L,0L,7L,1L,8L,0L,16L,0L,0L,0L,8L,1L,0L,18L,0L,0L,0L,0L,0L,9L,1L,10L,0L,0L,25L,0L,0L,0L,0L,10L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,1L,12L,30L,40L,0L,36L,0L,0L,0L,0L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157497Inst : IEnumerable<long>
{
public static readonly long[] Value=A157497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157497.Bytes);
public long this[int i]=>Value[i];

public static A157497Inst Instance=new A157497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157498
{
public static readonly BigInteger[] Value={ 1L,-29L,-30L,29609L,29730L,-28480349L,-85738590L,465311675713L,466913240610L,-815422463043899L,-4091129324685150L,17467175570282010779UL,BigInteger.Parse("52581659787073369890"),BigInteger.Parse("-132660073120078701817649"),BigInteger.Parse("-931812652124003239087710"),BigInteger.Parse("21700666809233826614371734881"),BigInteger.Parse("21775262910642199231076673570") };
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
public class A157498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157498Inst Instance=new A157498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157499
{
public static readonly BigInteger[] Value={ 1L,62L,961L,119164L,923521L,57258302L,887503681L,220100912888L,852891037441L,52879244321342L,819628286980801L,101633907585619324L,787662783788549761L,BigInteger.Parse("48835092594890085182"),BigInteger.Parse("756943935220796320321"),BigInteger.Parse("375444191869514974879216") };
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
public class A157499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157499Inst Instance=new A157499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157500
{
public static readonly BigInteger[] Value={ 1L,-27L,-58L,29079L,59102L,-28035747L,-170586178L,458128356543L,929029280702L,-802848203505477L,-8140272455439298L,17197854163509695589UL,BigInteger.Parse("104623752588981018302"),BigInteger.Parse("-130614651870286064169807"),BigInteger.Parse("-1854063629803901107879618"),BigInteger.Parse("21366075247399020547690286751") };
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
public class A157500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157500Inst Instance=new A157500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157501
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,6L,6L,4L,4L,5L,5L,5L,5L,5L,16L,16L,12L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,24L,24L,20L,20L,8L,8L,8L,8L,24L,24L,24L,9L,9L,9L,9L,9L,9L,38L,38L,30L,30L,30L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157501Inst : IEnumerable<long>
{
public static readonly long[] Value=A157501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157501.Bytes);
public long this[int i]=>Value[i];

public static A157501Inst Instance=new A157501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157502
{
public static readonly long[] Value={ 2L,6L,8L,10L,12L,14L,18L,20L,22L,24L,26L,28L,30L,32L,34L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157502Inst : IEnumerable<long>
{
public static readonly long[] Value=A157502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157502.Bytes);
public long this[int i]=>Value[i];

public static A157502Inst Instance=new A157502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157503
{
public static readonly BigInteger[] Value={ 1L,-1L,-4L,-21L,-160L,-1505L,-17136L,-226093L,-3334528L,-53031105L,-864640000L,-12957006821L,-107329453056L,4548002439071L,409321789829120L,23780752998703875L,1257249577352658944L,BigInteger.Parse("65336038911885770623") };
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
public class A157503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157503Inst Instance=new A157503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157504
{
public static readonly BigInteger[] Value={ -1L,-2L,-7L,-40L,-301L,-2856L,-32299L,-416816L,-5892345L,-86464000L,-1177909711L,-8944121088L,349846341467L,29237270702080L,1585383533246925L,78578098584541184L,3843296406581515919L,BigInteger.Parse("190784066705549623296") };
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
public class A157504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157504Inst Instance=new A157504Inst();

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