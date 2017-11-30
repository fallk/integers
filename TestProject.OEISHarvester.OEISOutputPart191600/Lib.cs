using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A222057
{
public static readonly long[] Value={ 1L,1L,3L,1L,9L,11L,1L,21L,66L,50L,1L,45L,275L,500L,274L,1L,93L,990L,3250L,4110L,1764L,1L,189L,3311L,17500L,38360L,37044L,13068L,1L,381L,10626L,85050L,287700L,469224L,365904L,109584L,1L,765L,33275L,388500L,1904574L,4667544L,6037416L,3945024L,1026576L,1L,1533L,102630L,1705250L,11651850L,40266828L,76839840L,82188000L,46195920L,10628640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222057Inst : IEnumerable<long>
{
public static readonly long[] Value=A222057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222057.Bytes);
public long this[int i]=>Value[i];

public static A222057Inst Instance=new A222057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222058
{
public static readonly BigInteger[] Value={ 0L,1L,4L,21L,138L,1095L,10208L,109473L,1328470L,18003675L,269580492L,4420677525L,78801184322L,1517300654415L,31386251780536L,694190761402377L,16348768018619694L,408472183061464515L,10791720442056792740UL,BigInteger.Parse("300605598797790229629"),BigInteger.Parse("8805117712245004098586"),BigInteger.Parse("270562051319419652165175"),BigInteger.Parse("8702576800277309526639504"),BigInteger.Parse("292425620801795849417200881") };
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
public class A222058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222058.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222058Inst Instance=new A222058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222059
{
public static readonly BigInteger[] Value={ 0L,1L,5L,44L,590L,11094L,276924L,8821056L,347992560L,16608856176L,941180477760L,62356907861280L,4768658639919360L,416372600735314560L,BigInteger.Parse("41123273761815517440"),BigInteger.Parse("4557176483095745510400"),BigInteger.Parse("562635159090115071744000"),BigInteger.Parse("76906191809174747446425600"),BigInteger.Parse("11573912988161070649533849600") };
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
public class A222059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222059.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222059Inst Instance=new A222059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222060
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,0L,1L,9L,11L,0L,1L,21L,66L,50L,0L,1L,45L,275L,500L,274L,0L,1L,93L,990L,3250L,4110L,1764L,0L,1L,189L,3311L,17500L,38360L,37044L,13068L,0L,1L,381L,10626L,85050L,287700L,469224L,365904L,109584L,0L,1L,765L,33275L,388500L,1904574L,4667544L,6037416L,3945024L,1026576L,0L,1L,1533L,102630L,1705250L,11651850L,40266828L,76839840L,82188000L,46195920L,10628640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222060Inst : IEnumerable<long>
{
public static readonly long[] Value=A222060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222060.Bytes);
public long this[int i]=>Value[i];

public static A222060Inst Instance=new A222060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222061
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,5L,0L,1L,15L,26L,0L,1L,35L,156L,154L,0L,1L,75L,650L,1540L,1044L,0L,1L,155L,2340L,10010L,15660L,8028L,0L,1L,315L,7826L,53900L,146160L,168588L,69264L,0L,1L,635L,25116L,261954L,1096200L,2135448L,1939392L,663696L,0L,1L,1275L,78650L,1196580L,7256844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222061Inst : IEnumerable<long>
{
public static readonly long[] Value=A222061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222061.Bytes);
public long this[int i]=>Value[i];

public static A222061Inst Instance=new A222061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222062
{
public static readonly BigInteger[] Value={ 0L,1L,6L,42L,346L,3310L,36194L,446054L,6122442L,92668302L,1533812722L,27565147126L,534621745178L,11131104732254L,247646911102530L,5863652049020358L,147225092025474154L,3907328980930705966L,BigInteger.Parse("109297865960259305618"),BigInteger.Parse("3214017757399205062550"),BigInteger.Parse("99121172016580291190970") };
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
public class A222062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222062.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222062Inst Instance=new A222062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222063
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,7L,0L,1L,21L,47L,0L,1L,49L,282L,342L,0L,1L,105L,1175L,3420L,2754L,0L,1L,217L,4230L,22230L,41310L,24552L,0L,1L,441L,14147L,119700L,385560L,515592L,241128L,0L,1L,889L,45402L,581742L,2891700L,6530832L,6751584L,2592720L,0L,1L,1785L,142175L,2657340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222063Inst : IEnumerable<long>
{
public static readonly long[] Value=A222063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222063.Bytes);
public long this[int i]=>Value[i];

public static A222063Inst Instance=new A222063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222064
{
public static readonly BigInteger[] Value={ 0L,1L,8L,69L,674L,7455L,92540L,1276569L,19394870L,321982323L,5801055632L,112753640109L,2352074473226L,52419496769991L,1243115350746404L,31257697673933889L,830700701852539742L,BigInteger.Parse("23266435856618600859"),BigInteger.Parse("684997785857198880056"),BigInteger.Parse("21149644833172896698709") };
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
public class A222064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222064.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222064Inst Instance=new A222064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222065
{
public static readonly BigInteger[] Value={ 2L,12L,2144L,9277152L,934520913216L,2152453777211211412L,BigInteger.Parse("112252999240982874562527216"),BigInteger.Parse("131765033045251672652319572331061144"),BigInteger.Parse("3467852755777932367855581588111341658695967892") };
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
public class A222065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222065Inst Instance=new A222065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222066
{
public static readonly long[] Value={ 8L,8L,3L,8L,8L,3L,4L,7L,6L,4L,8L,3L,1L,8L,4L,4L,0L,5L,5L,0L,1L,0L,5L,5L,4L,5L,2L,6L,3L,1L,0L,6L,1L,2L,9L,9L,1L,0L,6L,0L,4L,4L,9L,2L,2L,1L,1L,0L,5L,9L,2L,5L,4L,5L,7L,3L,5L,4L,2L,4L,8L,3L,6L,2L,4L,4L,2L,0L,7L,7L,9L,9L,0L,3L,8L,8L,1L,6L,8L,9L,9L,2L,8L,1L,4L,9L,2L,2L,0L,8L,9L,5L,4L,7L,7L,5L,9L,8L,2L,9L,5L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222066Inst : IEnumerable<long>
{
public static readonly long[] Value=A222066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222066.Bytes);
public long this[int i]=>Value[i];

public static A222066Inst Instance=new A222066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222067
{
public static readonly long[] Value={ 7L,2L,1L,6L,8L,7L,8L,3L,6L,4L,8L,7L,0L,3L,2L,2L,0L,5L,6L,3L,6L,4L,3L,5L,9L,7L,5L,6L,2L,7L,4L,4L,6L,8L,1L,9L,5L,5L,9L,5L,0L,2L,1L,8L,9L,0L,8L,7L,6L,5L,8L,5L,9L,5L,0L,2L,3L,2L,5L,2L,9L,0L,8L,1L,0L,4L,9L,7L,2L,0L,9L,0L,3L,7L,8L,6L,6L,6L,6L,8L,2L,1L,1L,7L,1L,4L,4L,2L,4L,4L,4L,8L,2L,1L,8L,6L,9L,0L,6L,5L,3L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222067Inst : IEnumerable<long>
{
public static readonly long[] Value=A222067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222067.Bytes);
public long this[int i]=>Value[i];

public static A222067Inst Instance=new A222067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222068
{
public static readonly long[] Value={ 6L,1L,6L,8L,5L,0L,2L,7L,5L,0L,6L,8L,0L,8L,4L,9L,1L,3L,6L,7L,7L,1L,5L,5L,6L,8L,7L,4L,9L,2L,2L,5L,9L,4L,4L,5L,9L,5L,7L,1L,0L,6L,2L,1L,2L,9L,5L,2L,5L,4L,9L,4L,1L,4L,1L,5L,0L,8L,3L,4L,3L,3L,6L,0L,1L,3L,7L,5L,2L,8L,0L,1L,4L,0L,1L,2L,0L,0L,3L,2L,7L,6L,8L,7L,6L,1L,0L,8L,3L,7L,7L,3L,2L,4L,0L,9L,5L,1L,4L,4L,8L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222068Inst : IEnumerable<long>
{
public static readonly long[] Value=A222068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222068.Bytes);
public long this[int i]=>Value[i];

public static A222068Inst Instance=new A222068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222069
{
public static readonly long[] Value={ 4L,6L,5L,2L,5L,7L,6L,1L,3L,3L,0L,9L,2L,5L,8L,6L,3L,5L,6L,1L,0L,5L,0L,4L,0L,6L,2L,4L,1L,1L,2L,9L,3L,6L,8L,5L,9L,9L,4L,6L,5L,7L,7L,5L,1L,3L,9L,6L,5L,3L,6L,1L,5L,7L,7L,4L,3L,5L,6L,6L,4L,4L,4L,5L,0L,1L,3L,2L,7L,1L,8L,4L,1L,8L,8L,8L,7L,1L,8L,1L,4L,3L,1L,1L,1L,6L,0L,0L,8L,9L,1L,5L,4L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222069Inst : IEnumerable<long>
{
public static readonly long[] Value=A222069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222069.Bytes);
public long this[int i]=>Value[i];

public static A222069Inst Instance=new A222069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222070
{
public static readonly long[] Value={ 3L,7L,2L,9L,4L,7L,5L,4L,5L,5L,8L,2L,0L,6L,4L,9L,3L,9L,5L,6L,3L,4L,7L,7L,5L,5L,8L,6L,7L,9L,9L,5L,8L,1L,0L,6L,3L,9L,3L,6L,6L,4L,7L,9L,7L,2L,6L,8L,3L,8L,7L,3L,6L,3L,1L,1L,1L,4L,0L,4L,0L,6L,5L,5L,9L,7L,2L,8L,3L,1L,7L,2L,0L,2L,9L,6L,8L,3L,2L,1L,9L,5L,2L,2L,5L,2L,6L,7L,2L,1L,6L,3L,5L,3L,4L,0L,5L,4L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222070Inst : IEnumerable<long>
{
public static readonly long[] Value=A222070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222070.Bytes);
public long this[int i]=>Value[i];

public static A222070Inst Instance=new A222070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222071
{
public static readonly long[] Value={ 2L,9L,5L,2L,9L,7L,8L,7L,3L,1L,4L,5L,7L,1L,2L,5L,7L,3L,0L,9L,9L,7L,7L,4L,4L,2L,9L,2L,1L,0L,4L,8L,9L,4L,7L,8L,1L,1L,6L,4L,3L,1L,3L,1L,9L,6L,7L,5L,0L,9L,6L,2L,6L,3L,7L,5L,3L,7L,5L,7L,5L,0L,5L,7L,5L,0L,5L,3L,7L,0L,9L,4L,4L,5L,2L,0L,5L,4L,3L,4L,3L,2L,1L,4L,9L,2L,0L,9L,6L,2L,2L,1L,5L,2L,6L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222071Inst : IEnumerable<long>
{
public static readonly long[] Value=A222071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222071.Bytes);
public long this[int i]=>Value[i];

public static A222071Inst Instance=new A222071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222072
{
public static readonly long[] Value={ 2L,5L,3L,6L,6L,9L,5L,0L,7L,9L,0L,1L,0L,4L,8L,0L,1L,3L,6L,3L,6L,5L,6L,3L,3L,6L,6L,3L,7L,6L,8L,3L,6L,2L,2L,7L,2L,1L,2L,8L,3L,2L,2L,5L,4L,3L,5L,5L,9L,5L,1L,6L,1L,8L,9L,8L,8L,1L,9L,7L,5L,5L,0L,4L,9L,4L,7L,1L,5L,7L,6L,9L,4L,1L,8L,8L,2L,0L,8L,2L,3L,4L,1L,1L,7L,7L,5L,6L,9L,5L,9L,2L,3L,8L,3L,5L,9L,1L,8L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222072Inst : IEnumerable<long>
{
public static readonly long[] Value=A222072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222072.Bytes);
public long this[int i]=>Value[i];

public static A222072Inst Instance=new A222072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222073
{
public static readonly long[] Value={ 1L,2L,2L,1L,6L,6L,9L,9L,6L,3L,9L,7L,7L,2L,9L,8L,8L,4L,0L,5L,1L,1L,8L,9L,1L,2L,9L,7L,6L,8L,3L,1L,5L,2L,4L,8L,2L,8L,4L,9L,8L,0L,7L,0L,7L,0L,9L,4L,8L,8L,2L,7L,5L,5L,0L,1L,1L,8L,3L,5L,0L,5L,7L,8L,2L,7L,9L,0L,7L,7L,9L,4L,4L,1L,9L,6L,9L,3L,1L,3L,2L,5L,9L,1L,9L,6L,1L,5L,8L,1L,4L,8L,1L,9L,5L,5L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222073Inst : IEnumerable<long>
{
public static readonly long[] Value=A222073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222073.Bytes);
public long this[int i]=>Value[i];

public static A222073Inst Instance=new A222073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222074
{
public static readonly long[] Value={ 1L,5L,9L,3L,8L,5L,2L,5L,2L,4L,9L,2L,3L,3L,4L,0L,9L,0L,2L,4L,1L,0L,1L,1L,0L,9L,8L,9L,8L,0L,9L,5L,6L,0L,4L,5L,0L,4L,1L,8L,2L,3L,2L,8L,4L,7L,0L,2L,1L,2L,2L,3L,9L,0L,9L,1L,3L,2L,7L,7L,3L,1L,4L,4L,1L,9L,9L,1L,4L,0L,5L,8L,4L,0L,2L,9L,2L,3L,9L,7L,1L,0L,8L,6L,3L,4L,5L,5L,7L,3L,1L,6L,3L,2L,8L,3L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222074Inst : IEnumerable<long>
{
public static readonly long[] Value=A222074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222074.Bytes);
public long this[int i]=>Value[i];

public static A222074Inst Instance=new A222074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222075
{
public static readonly long[] Value={ 1L,8L,8L,4L,1L,0L,3L,8L,7L,9L,3L,8L,9L,9L,0L,0L,2L,4L,1L,3L,4L,8L,2L,8L,7L,0L,4L,5L,9L,6L,2L,4L,7L,0L,3L,0L,4L,4L,4L,8L,2L,1L,9L,8L,3L,8L,7L,8L,7L,5L,7L,0L,8L,8L,9L,4L,1L,0L,6L,3L,1L,6L,8L,7L,9L,1L,9L,0L,9L,9L,5L,1L,8L,6L,6L,7L,7L,5L,3L,4L,9L,3L,7L,0L,7L,5L,6L,5L,5L,6L,3L,2L,8L,0L,8L,3L,9L,5L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222075Inst : IEnumerable<long>
{
public static readonly long[] Value=A222075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222075.Bytes);
public long this[int i]=>Value[i];

public static A222075Inst Instance=new A222075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222076
{
public static readonly BigInteger[] Value={ 1L,3L,23L,320L,6397L,166467L,5338412L,203578776L,9001795829L,452924585465L,25555585227999L,1598279794889076L,109748572718377660L,8209004345714098500L,BigInteger.Parse("664396187060996529528"),BigInteger.Parse("57853075421585981420208"),BigInteger.Parse("5393119810256349152565573"),BigInteger.Parse("535908449308064099732283429"),BigInteger.Parse("56548822143306498413322880709") };
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
public class A222076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222076Inst Instance=new A222076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222077
{
public static readonly BigInteger[] Value={ 1L,4L,34L,504L,10572L,285408L,9419440L,367571200L,16562241744L,846509123520L,48401180913824L,3061687935718272L,212316590908782336L,16018267935253721088UL,BigInteger.Parse("1306322033185206970368"),BigInteger.Parse("114519518777575592865792"),BigInteger.Parse("10740222055670467832259840"),BigInteger.Parse("1073051903942317493993088000") };
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
public class A222077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222077Inst Instance=new A222077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222078
{
public static readonly BigInteger[] Value={ 1L,5L,47L,742L,16357L,459369L,15651260L,626935936L,28872594389L,1503262704775L,87328047029511L,5600639046765690L,393092088068927860L,BigInteger.Parse("29974039720132943036"),BigInteger.Parse("2467669218502361588472"),BigInteger.Parse("218168186315818183909344"),BigInteger.Parse("20617367868151866462395205"),BigInteger.Parse("2074120178028300166990286691") };
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
public class A222078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222078Inst Instance=new A222078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222079
{
public static readonly BigInteger[] Value={ 1L,6L,62L,1040L,24076L,703800L,24786512L,1020779520L,48130232528L,2557117300640L,151180506557280L,9846055638729216L,700523098562671360L,BigInteger.Parse("54066239308284456960"),BigInteger.Parse("4499576117943522662400"),BigInteger.Parse("401709919258066014720000"),BigInteger.Parse("38299206898825369235170560"),BigInteger.Parse("3883999501445283274005895680") };
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
public class A222079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222079Inst Instance=new A222079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222080
{
public static readonly BigInteger[] Value={ 1L,2L,11L,92L,1013L,13726L,219919L,4057048L,84545129L,1961698586L,50111003987L,1396488977908L,42139540225501L,1368234341961718L,47547441824994647L,1760308790559597104L,BigInteger.Parse("69151746439874522321"),BigInteger.Parse("2872358517303945656242"),BigInteger.Parse("125758844338252841129371"),BigInteger.Parse("5787515297333376814677004") };
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
public class A222080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222080.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222080Inst Instance=new A222080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222081
{
public static readonly BigInteger[] Value={ 1L,1L,5L,41L,453L,6205L,100649L,1878277L,39534033L,924986401L,23790991061L,666732284009L,20211529694661L,658743175016461L,22964324182662569L,852450674859207605L,BigInteger.Parse("33563386167190876321"),BigInteger.Parse("1396839898167086931137"),BigInteger.Parse("61260669590285253202981"),BigInteger.Parse("2823455397312949805962921") };
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
public class A222081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222081Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222081.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222081.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222081Inst Instance=new A222081Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222082
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,40L,67L,126L,203L,354L,571L,908L,1486L,2250L,3586L,5322L,8186L,12234L,17976L,26970L,38435L,57024L,80805L,116376L,165914L,232352L,332196L,456154L,645469L,885826L,1225998L,1692686L,2290512L,3168986L,4242896L,5805526L,7782803L,10459912L,14110205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222082Inst : IEnumerable<long>
{
public static readonly long[] Value=A222082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222082.Bytes);
public long this[int i]=>Value[i];

public static A222082Inst Instance=new A222082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222083
{
public static readonly long[] Value={ 1L,3L,9L,22L,51L,114L,230L,468L,885L,1674L,3045L,5418L,9560L,16341L,27912L,46383L,76794L,125205L,201580L,322980L,508710L,800495L,1241190L,1916682L,2935492L,4456617L,6747393L,10101532L,15105042L,22378362L,33035166L,48520809L,70776711L,103072393L,148899756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222083Inst : IEnumerable<long>
{
public static readonly long[] Value=A222083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222083.Bytes);
public long this[int i]=>Value[i];

public static A222083Inst Instance=new A222083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222084
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,2L,4L,3L,3L,2L,4L,2L,3L,3L,5L,2L,5L,2L,4L,3L,3L,2L,6L,3L,3L,4L,4L,2L,4L,2L,6L,3L,3L,3L,6L,2L,3L,3L,5L,2L,5L,2L,4L,4L,3L,2L,8L,3L,5L,3L,4L,2L,7L,3L,5L,3L,3L,2L,5L,2L,3L,4L,7L,3L,5L,2L,4L,3L,4L,2L,7L,2L,3L,5L,4L,3L,5L,2L,7L,5L,3L,2L,6L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222084Inst : IEnumerable<long>
{
public static readonly long[] Value=A222084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222084.Bytes);
public long this[int i]=>Value[i];

public static A222084Inst Instance=new A222084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222085
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,6L,8L,15L,13L,8L,12L,10L,14L,10L,9L,31L,18L,21L,20L,12L,11L,14L,24L,24L,31L,16L,40L,14L,30L,11L,32L,63L,15L,20L,13L,25L,38L,22L,17L,20L,42L,19L,44L,18L,18L,26L,48L,52L,57L,43L,21L,20L,54L,66L,17L,22L,23L,32L,60L,15L,62L,34L,20L,127L,19L,23L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222085Inst : IEnumerable<long>
{
public static readonly long[] Value=A222085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222085.Bytes);
public long this[int i]=>Value[i];

public static A222085Inst Instance=new A222085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222086
{
public static readonly long[] Value={ 1L,30L,360L,840L,11088L,18018L,1713600L,32760L,327600L,350064L,39437798400L,180180L,8532905472000L,47361600L,720720L,1750320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222086Inst : IEnumerable<long>
{
public static readonly long[] Value=A222086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222086.Bytes);
public long this[int i]=>Value[i];

public static A222086Inst Instance=new A222086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222087
{
public static readonly long[] Value={ 1L,2L,6L,14L,15L,20L,22L,24L,33L,38L,46L,49L,51L,52L,62L,63L,86L,87L,91L,92L,93L,95L,118L,119L,121L,141L,142L,143L,145L,147L,148L,153L,158L,159L,165L,166L,169L,183L,198L,206L,210L,215L,217L,219L,244L,247L,249L,253L,262L,267L,270L,278L,279L,286L,287L,295L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222087Inst : IEnumerable<long>
{
public static readonly long[] Value=A222087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222087.Bytes);
public long this[int i]=>Value[i];

public static A222087Inst Instance=new A222087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222088
{
public static readonly long[] Value={ 5L,23L,44L,84L,132L,185L,335L,368L,1342L,2226L,3354L,4726L,7359L,7598L,8436L,10234L,12123L,18078L,18744L,19848L,20492L,20922L,21823L,21902L,23218L,24069L,24221L,31678L,36510L,36849L,40235L,45046L,46916L,49356L,49769L,50560L,51780L,52716L,53079L,59942L,60150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222088Inst : IEnumerable<long>
{
public static readonly long[] Value=A222088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222088.Bytes);
public long this[int i]=>Value[i];

public static A222088Inst Instance=new A222088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222089
{
public static readonly long[] Value={ 1L,4L,8L,16L,24L,48L,96L,192L,384L,480L,768L,960L,1920L,3840L,5760L,7680L,11520L,19440L,23040L,26880L,46080L,53760L,80640L,107520L,161280L,215040L,322560L,612360L,645120L,967680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222089Inst : IEnumerable<long>
{
public static readonly long[] Value=A222089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222089.Bytes);
public long this[int i]=>Value[i];

public static A222089Inst Instance=new A222089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222090
{
public static readonly long[] Value={ 3L,31L,308L,3034L,29860L,293848L,2891636L,28455036L,280009384L,2755404412L,27114269752L,266815111088L,2625565876172L,25836603103756L,254242357913972L,2501845009992824L,24619140986161492L,242262050800828048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222090Inst : IEnumerable<long>
{
public static readonly long[] Value=A222090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222090.Bytes);
public long this[int i]=>Value[i];

public static A222090Inst Instance=new A222090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222091
{
public static readonly BigInteger[] Value={ 8L,306L,11698L,439979L,16518325L,620167586L,23285438194L,874320487561L,32829136547878L,1232675333611674L,46284755942965861L,1737909791864677612L,BigInteger.Parse("65255401994426759727"),BigInteger.Parse("2450223514629565888639"),BigInteger.Parse("92001505833953763778608") };
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
public class A222091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222091.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222091Inst Instance=new A222091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222092
{
public static readonly BigInteger[] Value={ 21L,3014L,439644L,62776264L,8936245171L,1271770432077L,181000238870646L,25760940724765249L,3666476510299319316L,BigInteger.Parse("521840279989725924865"),BigInteger.Parse("74272277349160073400124"),BigInteger.Parse("10570998423180909949529557") };
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
public class A222092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222092Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222092.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222092.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222092Inst Instance=new A222092Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222093
{
public static readonly long[] Value={ 1L,3L,3L,8L,31L,8L,21L,306L,308L,21L,55L,3014L,11698L,3034L,55L,144L,29671L,439644L,439979L,29860L,144L,377L,292017L,16509768L,62776264L,16518325L,293848L,377L,987L,2873693L,619931605L,8938090933L,8936245171L,620167586L,2891636L,987L,2584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222093Inst : IEnumerable<long>
{
public static readonly long[] Value=A222093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222093.Bytes);
public long this[int i]=>Value[i];

public static A222093Inst Instance=new A222093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222094
{
public static readonly long[] Value={ 3L,31L,306L,3014L,29671L,292017L,2873693L,28278630L,278273755L,2738325414L,26946205188L,265161285275L,2609291560659L,25676457366269L,252666460567318L,2486337558528381L,24466541550530492L,240760412205806134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222094Inst : IEnumerable<long>
{
public static readonly long[] Value=A222094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222094.Bytes);
public long this[int i]=>Value[i];

public static A222094Inst Instance=new A222094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222095
{
public static readonly BigInteger[] Value={ 8L,308L,11698L,439644L,16509768L,619931605L,23277561783L,874033601365L,32818427706942L,1232273510253579L,46269666765829350L,1737343162836648930L,BigInteger.Parse("65234125114783960319"),BigInteger.Parse("2449424592893411034116"),BigInteger.Parse("91971507601402242033646") };
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
public class A222095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222095.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222095Inst Instance=new A222095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222096
{
public static readonly BigInteger[] Value={ 21L,3034L,439979L,62776264L,8938090933L,1272224461900L,181075284907525L,25772100415484857L,3668085288770478139L,BigInteger.Parse("522070083851345084353"),BigInteger.Parse("74305016748179915810183"),BigInteger.Parse("10575659301127035698958882") };
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
public class A222096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222096Inst Instance=new A222096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222097
{
public static readonly BigInteger[] Value={ 1L,46L,17694L,57455502L,1579646506770L,368159933254055152L,BigInteger.Parse("727800879295716577956574") };
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
public class A222097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222097Inst Instance=new A222097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222098
{
public static readonly long[] Value={ 4L,46L,530L,6108L,70394L,811286L,9350020L,107758398L,1241908834L,14312922076L,164955536810L,1901102303238L,21910085816324L,252512376457166L,2910189435065650L,33539752256081628L,386543558932945114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222098Inst : IEnumerable<long>
{
public static readonly long[] Value=A222098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222098.Bytes);
public long this[int i]=>Value[i];

public static A222098Inst Instance=new A222098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222099
{
public static readonly BigInteger[] Value={ 16L,530L,17694L,591476L,19776286L,661254950L,22110369320L,739304841874L,24720154977078L,826568484486164L,27637992729347366L,924132309919617038L,BigInteger.Parse("30900237030548459544"),BigInteger.Parse("1033212061004215656522"),BigInteger.Parse("34547539617728922860542") };
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
public class A222099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222099Inst Instance=new A222099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222100
{
public static readonly BigInteger[] Value={ 64L,6108L,591476L,57455502L,5585183876L,543019517890L,52797111762730L,5133443560512386L,499123853931892192L,BigInteger.Parse("48529752000392073542"),BigInteger.Parse("4718542457622698098922"),BigInteger.Parse("458783377102773490580554") };
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
public class A222100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222100Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222100.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222100.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222100Inst Instance=new A222100Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222101
{
public static readonly BigInteger[] Value={ 256L,70394L,19776286L,5585183876L,1579646506770L,446953377273926L,126478496485182708L,BigInteger.Parse("35792034236612394178"),BigInteger.Parse("10128858887832420661250"),BigInteger.Parse("2866394503623906825124412"),BigInteger.Parse("811169823087180821333896378") };
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
public class A222101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222101.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222101Inst Instance=new A222101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222102
{
public static readonly BigInteger[] Value={ 1024L,811286L,661254950L,543019517890L,446953377273926L,368159933254055152L,BigInteger.Parse("303334194244175791146"),BigInteger.Parse("249944768409450118648354"),BigInteger.Parse("205958518729604434520433962"),BigInteger.Parse("169714897772459528956828618538") };
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
public class A222102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222102Inst Instance=new A222102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222103
{
public static readonly BigInteger[] Value={ 4096L,9350020L,22110369320L,52797111762730L,126478496485182708L,BigInteger.Parse("303334194244175791146"),BigInteger.Parse("727800879295716577956574"),BigInteger.Parse("1746526809024942183917202210"),BigInteger.Parse("4191462990610923771050017388728") };
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
public class A222103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222103.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222103Inst Instance=new A222103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222104
{
public static readonly long[] Value={ 1L,4L,4L,16L,46L,16L,64L,530L,530L,64L,256L,6108L,17694L,6108L,256L,1024L,70394L,591476L,591476L,70394L,1024L,4096L,811286L,19776286L,57455502L,19776286L,811286L,4096L,16384L,9350020L,661254950L,5585183876L,5585183876L,661254950L,9350020L,16384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222104Inst : IEnumerable<long>
{
public static readonly long[] Value=A222104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222104.Bytes);
public long this[int i]=>Value[i];

public static A222104Inst Instance=new A222104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222105
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,12L,17L,24L,36L,53L,76L,109L,161L,236L,342L,498L,729L,1064L,1545L,2256L,3296L,4807L,7004L,10220L,14915L,21744L,31715L,46271L,67503L,98445L,143596L,209477L,305548L,445679L,650102L,948313L,1383244L,2017670L,2943130L,4293056L,6262110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222105Inst : IEnumerable<long>
{
public static readonly long[] Value=A222105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222105.Bytes);
public long this[int i]=>Value[i];

public static A222105Inst Instance=new A222105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222106
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,13L,19L,30L,48L,75L,116L,186L,297L,464L,735L,1168L,1842L,2902L,4588L,7246L,11419L,18031L,28487L,44950L,70964L,112070L,176962L,279381L,441153L,696646L,1099932L,1736800L,2742479L,4330306L,6837427L,10796190L,17047093L,26916822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222106Inst : IEnumerable<long>
{
public static readonly long[] Value=A222106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222106.Bytes);
public long this[int i]=>Value[i];

public static A222106Inst Instance=new A222106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222107
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,13L,19L,31L,50L,80L,129L,205L,331L,525L,841L,1348L,2151L,3450L,5513L,8830L,14121L,22592L,36153L,57815L,92523L,148013L,236841L,378930L,606302L,970131L,1552146L,2483557L,3973631L,6357945L,10172798L,16276672L,26043161L,41669289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222107Inst : IEnumerable<long>
{
public static readonly long[] Value=A222107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222107.Bytes);
public long this[int i]=>Value[i];

public static A222107Inst Instance=new A222107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222108
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,13L,19L,31L,50L,80L,130L,208L,336L,536L,859L,1376L,2198L,3526L,5647L,9052L,14510L,23263L,37289L,59769L,95809L,153549L,246114L,394458L,632240L,1013351L,1624223L,2603395L,4172799L,6688379L,10720405L,17183121L,27541756L,44144986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222108Inst : IEnumerable<long>
{
public static readonly long[] Value=A222108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222108.Bytes);
public long this[int i]=>Value[i];

public static A222108Inst Instance=new A222108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222109
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,13L,19L,31L,50L,80L,130L,210L,340L,548L,886L,1431L,2307L,3726L,6022L,9716L,15700L,25367L,40977L,66215L,106981L,172863L,279285L,451233L,728991L,1177720L,1902670L,3073828L,4965893L,8022658L,12961162L,20939487L,33829184L,54653423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222109Inst : IEnumerable<long>
{
public static readonly long[] Value=A222109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222109.Bytes);
public long this[int i]=>Value[i];

public static A222109Inst Instance=new A222109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222110
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,13L,19L,31L,50L,80L,130L,210L,340L,550L,890L,1440L,2328L,3760L,6082L,9819L,15868L,25643L,41428L,66967L,108221L,174929L,282739L,456996L,738664L,1193914L,1929726L,3119003L,5041195L,8147983L,13169366L,21285314L,34403008L,55604705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222110Inst : IEnumerable<long>
{
public static readonly long[] Value=A222110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222110.Bytes);
public long this[int i]=>Value[i];

public static A222110Inst Instance=new A222110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222111
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,4L,2L,3L,4L,5L,2L,3L,4L,5L,7L,2L,3L,4L,5L,8L,10L,2L,3L,4L,5L,8L,12L,14L,2L,3L,4L,5L,8L,13L,17L,19L,2L,3L,4L,5L,8L,13L,19L,24L,26L,2L,3L,4L,5L,8L,13L,19L,30L,36L,36L,2L,3L,4L,5L,8L,13L,19L,31L,48L,53L,50L,2L,3L,4L,5L,8L,13L,19L,31L,50L,75L,76L,69L,2L,3L,4L,5L,8L,13L,19L,31L,50L,80L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222111Inst : IEnumerable<long>
{
public static readonly long[] Value=A222111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222111.Bytes);
public long this[int i]=>Value[i];

public static A222111Inst Instance=new A222111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222112
{
public static readonly long[] Value={ 0L,1L,3L,4L,27L,28L,30L,31L,81L,82L,84L,85L,108L,109L,111L,112L,7625597484987L,7625597484988L,7625597484990L,7625597484991L,7625597485014L,7625597485015L,7625597485017L,7625597485018L,7625597485068L,7625597485069L,7625597485071L,7625597485072L,7625597485095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222112Inst : IEnumerable<long>
{
public static readonly long[] Value=A222112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222112.Bytes);
public long this[int i]=>Value[i];

public static A222112Inst Instance=new A222112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222113
{
public static readonly BigInteger[] Value={ 16L,112L,1284L,18753L,326594L,6588345L,150994944L,3524450281L,100077777776L,3138578427935L,106993479003784L,3937376861542205L,155568096352467864L,6568408356994335931L,BigInteger.Parse("295147905181357143920"),BigInteger.Parse("14063084452070776884880"),BigInteger.Parse("708235345355342213988446") };
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
public class A222113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222113Inst Instance=new A222113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222114
{
public static readonly long[] Value={ 2L,5L,5L,13L,19L,29L,31L,37L,37L,37L,61L,61L,61L,89L,97L,97L,97L,109L,131L,139L,149L,157L,157L,157L,173L,181L,193L,193L,193L,193L,241L,241L,241L,271L,271L,271L,271L,317L,331L,331L,331L,349L,349L,367L,367L,367L,397L,397L,397L,397L,397L,397L,457L,457L,457L,457L,457L,457L,523L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222114Inst : IEnumerable<long>
{
public static readonly long[] Value=A222114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222114.Bytes);
public long this[int i]=>Value[i];

public static A222114Inst Instance=new A222114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222115
{
public static readonly long[] Value={ 2L,6L,17L,46L,117L,285L,674L,1558L,3536L,7911L,17503L,38377L,83501L,180480L,387882L,829606L,1766999L,3749766L,7931115L,16724871L,35173778L,73794661L,154485528L,322771345L,673155142L,1401536935L,2913490376L,6047714600L,12536770559L,25956242580L,53678385267L,110889844998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222115Inst : IEnumerable<long>
{
public static readonly long[] Value=A222115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222115.Bytes);
public long this[int i]=>Value[i];

public static A222115Inst Instance=new A222115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222116
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,101L,131L,151L,191L,313L,353L,10301L,10501L,11311L,13331L,30103L,1003001L,1123211L,1201021L,1221221L,1303031L,1311131L,3001003L,3103013L,100030001L,100050001L,100111001L,100131001L,101030101L,110111011L,110232011L,111010111L,111050111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222116Inst : IEnumerable<long>
{
public static readonly long[] Value=A222116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222116.Bytes);
public long this[int i]=>Value[i];

public static A222116Inst Instance=new A222116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222117
{
public static readonly BigInteger[] Value={ 15L,111L,1283L,18752L,326593L,6588344L,150994943L,3524450280L,100077777775L,3138578427934L,106993479003783L,3937376861542204L,155568096352467863L,6568408356994335930L,BigInteger.Parse("295147905181357143919"),BigInteger.Parse("14063084452070776884879"),BigInteger.Parse("708235345355342213988445") };
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
public class A222117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222117Inst Instance=new A222117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222118
{
public static readonly long[] Value={ 1L,1L,6L,0L,0L,1L,10L,0L,3L,0L,0L,1L,0L,0L,9L,0L,0L,1L,5L,0L,3L,0L,0L,1L,3L,0L,95L,0L,0L,1L,0L,0L,3L,0L,0L,1L,3L,0L,12L,0L,0L,1L,8L,0L,3L,0L,0L,1L,0L,0L,5L,0L,0L,1L,7L,0L,3L,0L,0L,1L,0L,0L,13L,0L,0L,1L,0L,0L,3L,0L,0L,1L,3L,0L,8L,0L,0L,1L,9L,0L,1L,0L,0L,1L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222118Inst : IEnumerable<long>
{
public static readonly long[] Value=A222118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222118.Bytes);
public long this[int i]=>Value[i];

public static A222118Inst Instance=new A222118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222119
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,1L,5L,2L,1L,39L,6L,4L,12L,2L,2L,1L,6L,17L,46L,7L,5L,1L,25L,2L,41L,1L,12L,7L,1L,7L,327L,7L,8L,44L,26L,12L,75L,14L,51L,110L,4L,14L,49L,286L,15L,4L,39L,22L,109L,367L,22L,67L,27L,95L,80L,149L,2L,142L,3L,11L,402L,3L,44L,10L,82L,20L,95L,4L,108L,349L,127L,303L,37L,3L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222119Inst : IEnumerable<long>
{
public static readonly long[] Value=A222119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222119.Bytes);
public long this[int i]=>Value[i];

public static A222119Inst Instance=new A222119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222120
{
public static readonly long[] Value={ 1L,1L,2L,3L,9L,4L,6L,6L,18L,14L,10L,60L,35L,31L,53L,26L,29L,19L,57L,90L,122L,72L,65L,27L,138L,49L,168L,33L,122L,103L,39L,119L,345L,126L,143L,250L,225L,182L,315L,204L,308L,371L,134L,227L,335L,489L,255L,156L,364L,312L,476L,613L,329L,460L,372L,522L,514L,590L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222120Inst : IEnumerable<long>
{
public static readonly long[] Value=A222120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222120.Bytes);
public long this[int i]=>Value[i];

public static A222120Inst Instance=new A222120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222121
{
public static readonly long[] Value={ 2L,3L,4L,6L,10L,15L,24L,38L,59L,92L,144L,224L,350L,547L,854L,1334L,2084L,3254L,5082L,7937L,12395L,19358L,30233L,47216L,73740L,115164L,179857L,280892L,438684L,685115L,1069980L,1671044L,2609756L,4075792L,6365377L,9941140L,15525596L,24247132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222121Inst : IEnumerable<long>
{
public static readonly long[] Value=A222121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222121.Bytes);
public long this[int i]=>Value[i];

public static A222121Inst Instance=new A222121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222122
{
public static readonly long[] Value={ 2L,3L,4L,7L,11L,17L,27L,42L,66L,104L,163L,256L,402L,631L,991L,1556L,2443L,3836L,6023L,9457L,14849L,23315L,36608L,57480L,90252L,141709L,222504L,349364L,548553L,861309L,1352382L,2123439L,3334112L,5235047L,8219795L,12906289L,20264775L,31818682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222122Inst : IEnumerable<long>
{
public static readonly long[] Value=A222122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222122.Bytes);
public long this[int i]=>Value[i];

public static A222122Inst Instance=new A222122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222123
{
public static readonly long[] Value={ 2L,3L,4L,8L,12L,19L,31L,48L,79L,126L,200L,322L,513L,823L,1318L,2105L,3372L,5394L,8632L,13817L,22103L,35374L,56607L,90580L,144956L,231952L,371177L,593973L,950478L,1520987L,2433908L,3894788L,6232544L,9973435L,15959719L,25539092L,40868195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222123Inst : IEnumerable<long>
{
public static readonly long[] Value=A222123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222123.Bytes);
public long this[int i]=>Value[i];

public static A222123Inst Instance=new A222123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222124
{
public static readonly long[] Value={ 2L,3L,4L,8L,12L,19L,31L,48L,79L,126L,201L,323L,516L,827L,1324L,2120L,3396L,5436L,8706L,13940L,22323L,35748L,57240L,91661L,146778L,235035L,376367L,602677L,965074L,1545383L,2474634L,3962658L,6345442L,10161019L,16270937L,26054807L,41721820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222124Inst : IEnumerable<long>
{
public static readonly long[] Value=A222124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222124.Bytes);
public long this[int i]=>Value[i];

public static A222124Inst Instance=new A222124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222125
{
public static readonly long[] Value={ 2L,3L,4L,8L,12L,19L,31L,49L,80L,128L,207L,334L,536L,866L,1394L,2247L,3622L,5834L,9404L,15151L,24416L,39346L,63400L,102169L,164633L,265296L,427507L,688891L,1110104L,1788845L,2882595L,4645091L,7485216L,12061886L,19436832L,31321030L,50471539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222125Inst : IEnumerable<long>
{
public static readonly long[] Value=A222125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222125.Bytes);
public long this[int i]=>Value[i];

public static A222125Inst Instance=new A222125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222126
{
public static readonly long[] Value={ 2L,3L,4L,8L,12L,19L,31L,49L,80L,128L,207L,334L,536L,866L,1394L,2248L,3624L,5839L,9414L,15169L,24452L,39411L,63521L,102387L,165020L,265982L,428703L,690979L,1113717L,1795071L,2893285L,4663357L,7516351L,12114776L,19526459L,31472549L,50727107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222126Inst : IEnumerable<long>
{
public static readonly long[] Value=A222126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222126.Bytes);
public long this[int i]=>Value[i];

public static A222126Inst Instance=new A222126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222127
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,4L,2L,3L,4L,6L,2L,3L,4L,6L,9L,2L,3L,4L,7L,10L,13L,2L,3L,4L,8L,11L,15L,19L,2L,3L,4L,8L,12L,17L,24L,28L,2L,3L,4L,8L,12L,19L,27L,38L,41L,2L,3L,4L,8L,12L,19L,31L,42L,59L,60L,2L,3L,4L,8L,12L,19L,31L,48L,66L,92L,88L,2L,3L,4L,8L,12L,19L,31L,48L,79L,104L,144L,129L,2L,3L,4L,8L,12L,20L,31L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222127Inst : IEnumerable<long>
{
public static readonly long[] Value=A222127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222127.Bytes);
public long this[int i]=>Value[i];

public static A222127Inst Instance=new A222127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222128
{
public static readonly long[] Value={ 2L,2L,0L,5L,8L,4L,0L,4L,0L,7L,4L,9L,6L,9L,8L,0L,8L,8L,6L,6L,8L,9L,4L,5L,9L,1L,3L,2L,5L,5L,7L,8L,7L,5L,1L,0L,4L,5L,8L,8L,4L,8L,0L,3L,8L,1L,5L,9L,4L,1L,0L,6L,7L,2L,3L,7L,0L,0L,4L,8L,8L,7L,3L,2L,2L,4L,8L,3L,3L,5L,5L,1L,2L,5L,0L,5L,9L,5L,6L,3L,9L,7L,2L,7L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222128Inst : IEnumerable<long>
{
public static readonly long[] Value=A222128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222128.Bytes);
public long this[int i]=>Value[i];

public static A222128Inst Instance=new A222128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222129
{
public static readonly long[] Value={ 9L,7L,5L,3L,6L,7L,9L,7L,2L,0L,8L,3L,6L,3L,1L,3L,8L,5L,1L,5L,7L,4L,8L,2L,8L,7L,4L,1L,0L,8L,4L,9L,4L,7L,8L,8L,4L,7L,4L,0L,9L,6L,5L,1L,2L,3L,6L,3L,7L,7L,4L,9L,7L,2L,9L,8L,7L,0L,8L,8L,9L,9L,1L,1L,6L,1L,9L,2L,6L,0L,4L,5L,6L,8L,3L,3L,7L,4L,3L,2L,2L,1L,8L,0L,1L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222129Inst : IEnumerable<long>
{
public static readonly long[] Value=A222129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222129.Bytes);
public long this[int i]=>Value[i];

public static A222129Inst Instance=new A222129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222130
{
public static readonly long[] Value={ 4L,1L,3L,2L,9L,2L,1L,1L,6L,1L,0L,1L,5L,9L,4L,3L,3L,6L,6L,2L,6L,6L,2L,8L,3L,9L,4L,2L,7L,6L,6L,9L,7L,5L,6L,4L,9L,8L,5L,5L,9L,0L,6L,8L,7L,0L,8L,3L,5L,4L,5L,0L,8L,2L,8L,7L,1L,9L,7L,6L,6L,4L,2L,4L,7L,7L,2L,3L,8L,9L,0L,6L,3L,0L,3L,4L,8L,5L,5L,4L,3L,3L,5L,6L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222130Inst : IEnumerable<long>
{
public static readonly long[] Value=A222130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222130.Bytes);
public long this[int i]=>Value[i];

public static A222130Inst Instance=new A222130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222131
{
public static readonly long[] Value={ 9L,1L,0L,5L,9L,8L,4L,9L,9L,2L,1L,2L,6L,1L,4L,7L,0L,7L,0L,6L,0L,0L,4L,4L,5L,1L,4L,2L,3L,6L,8L,7L,7L,4L,7L,4L,5L,1L,4L,9L,2L,9L,0L,5L,3L,3L,7L,7L,5L,2L,0L,2L,0L,7L,1L,9L,6L,1L,6L,4L,2L,7L,9L,5L,5L,9L,3L,4L,5L,6L,9L,3L,5L,7L,5L,9L,3L,1L,7L,9L,8L,1L,5L,9L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222131Inst : IEnumerable<long>
{
public static readonly long[] Value=A222131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222131.Bytes);
public long this[int i]=>Value[i];

public static A222131Inst Instance=new A222131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222132
{
public static readonly long[] Value={ 2L,5L,6L,1L,5L,5L,2L,8L,1L,2L,8L,0L,8L,8L,3L,0L,2L,7L,4L,9L,1L,0L,7L,0L,4L,9L,2L,7L,9L,8L,7L,0L,3L,8L,5L,1L,2L,5L,7L,3L,5L,9L,9L,6L,1L,2L,6L,8L,6L,8L,1L,0L,2L,1L,7L,1L,9L,9L,3L,1L,6L,7L,8L,6L,5L,4L,7L,4L,7L,7L,1L,7L,3L,1L,6L,8L,8L,1L,0L,7L,9L,6L,7L,9L,3L,9L,3L,1L,8L,2L,5L,4L,0L,5L,3L,4L,2L,1L,4L,8L,3L,4L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222132Inst : IEnumerable<long>
{
public static readonly long[] Value=A222132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222132.Bytes);
public long this[int i]=>Value[i];

public static A222132Inst Instance=new A222132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222133
{
public static readonly long[] Value={ 1L,5L,6L,1L,5L,5L,2L,8L,1L,2L,8L,0L,8L,8L,3L,0L,2L,7L,4L,9L,1L,0L,7L,0L,4L,9L,2L,7L,9L,8L,7L,0L,3L,8L,5L,1L,2L,5L,7L,3L,5L,9L,9L,6L,1L,2L,6L,8L,6L,8L,1L,0L,2L,1L,7L,1L,9L,9L,3L,1L,6L,7L,8L,6L,5L,4L,7L,4L,7L,7L,1L,7L,3L,1L,6L,8L,8L,1L,0L,7L,9L,6L,7L,9L,3L,9L,3L,1L,8L,2L,5L,4L,0L,5L,3L,4L,2L,1L,4L,8L,3L,4L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222133Inst : IEnumerable<long>
{
public static readonly long[] Value=A222133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222133.Bytes);
public long this[int i]=>Value[i];

public static A222133Inst Instance=new A222133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222134
{
public static readonly long[] Value={ 2L,7L,9L,1L,2L,8L,7L,8L,4L,7L,4L,7L,7L,9L,2L,0L,0L,0L,3L,2L,9L,4L,0L,2L,3L,5L,9L,6L,8L,6L,4L,0L,0L,4L,2L,4L,4L,4L,9L,2L,2L,2L,8L,2L,8L,8L,3L,8L,3L,9L,8L,5L,9L,5L,1L,3L,0L,3L,6L,2L,1L,0L,6L,1L,9L,5L,3L,4L,3L,4L,2L,1L,2L,7L,7L,3L,8L,8L,5L,4L,4L,3L,3L,0L,2L,1L,8L,0L,7L,7L,9L,7L,4L,6L,7L,2L,2L,5L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222134Inst : IEnumerable<long>
{
public static readonly long[] Value=A222134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222134.Bytes);
public long this[int i]=>Value[i];

public static A222134Inst Instance=new A222134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222135
{
public static readonly long[] Value={ 1L,7L,9L,1L,2L,8L,7L,8L,4L,7L,4L,7L,7L,9L,2L,0L,0L,0L,3L,2L,9L,4L,0L,2L,3L,5L,9L,6L,8L,6L,4L,0L,0L,4L,2L,4L,4L,4L,9L,2L,2L,2L,8L,2L,8L,8L,3L,8L,3L,9L,8L,5L,9L,5L,1L,3L,0L,3L,6L,2L,1L,0L,6L,1L,9L,5L,3L,4L,3L,4L,2L,1L,2L,7L,7L,3L,8L,8L,5L,4L,4L,3L,3L,0L,2L,1L,8L,0L,7L,7L,9L,7L,4L,6L,7L,2L,2L,5L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222135Inst : IEnumerable<long>
{
public static readonly long[] Value=A222135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222135.Bytes);
public long this[int i]=>Value[i];

public static A222135Inst Instance=new A222135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222136
{
public static readonly long[] Value={ 1L,3L,4L,10L,8L,16L,19L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222136Inst : IEnumerable<long>
{
public static readonly long[] Value=A222136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222136.Bytes);
public long this[int i]=>Value[i];

public static A222136Inst Instance=new A222136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222137
{
public static readonly BigInteger[] Value={ 7L,79L,130783L,523927L,9007199254738183L,BigInteger.Parse("9671406556917033397642519"),BigInteger.Parse("215679573337205118357336120696157045389097155380324579848828881942199") };
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
public class A222137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222137Inst Instance=new A222137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222138
{
public static readonly long[] Value={ 4L,52L,676L,8788L,114244L,1485172L,19307236L,250994068L,3262922884L,42417997492L,551433967396L,7168641576148L,93192340489924L,1211500426369012L,15749505542797156L,204743572056363028L,2661666436732719364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222138Inst : IEnumerable<long>
{
public static readonly long[] Value=A222138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222138.Bytes);
public long this[int i]=>Value[i];

public static A222138Inst Instance=new A222138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222139
{
public static readonly BigInteger[] Value={ 16L,676L,28564L,1206964L,50999956L,2154990196L,91058563924L,3847656513844L,162581749707796L,6869850581244916L,290283793189916884L,12265868026121849524UL,BigInteger.Parse("518291141165452870036"),BigInteger.Parse("21900260661415244606836") };
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
public class A222139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222139Inst Instance=new A222139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222140
{
public static readonly BigInteger[] Value={ 64L,8788L,1206964L,165770032L,22767656980L,3127020364012L,429480137694664L,58986884432558548L,8101544704688334244L,BigInteger.Parse("1112705429924911477552"),BigInteger.Parse("152824358676750267429220"),BigInteger.Parse("20989638386627725143014812") };
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
public class A222140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222140Inst Instance=new A222140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222141
{
public static readonly BigInteger[] Value={ 256L,114244L,50999956L,22767656980L,10164078082036L,4537511642094436L,2025664524518719732L,BigInteger.Parse("904309916809657591444"),BigInteger.Parse("403707729455406641892052"),BigInteger.Parse("180225747607432250658675940"),BigInteger.Parse("80457513519867024627155058004") };
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
public class A222141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222141Inst Instance=new A222141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222142
{
public static readonly BigInteger[] Value={ 1024L,1485172L,2154990196L,3127020364012L,4537511642094436L,6584229526795818280L,BigInteger.Parse("9554152945600145235628"),BigInteger.Parse("13863708507689968892320744"),BigInteger.Parse("20117158974980617877295384292"),BigInteger.Parse("29191329651902717463310508940292") };
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
public class A222142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222142Inst Instance=new A222142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222143
{
public static readonly BigInteger[] Value={ 4096L,19307236L,91058563924L,429480137694664L,2025664524518719732L,BigInteger.Parse("9554152945600145235628"),BigInteger.Parse("45062665956031451017237456"),BigInteger.Parse("212540440581498107104494924076"),BigInteger.Parse("1002458198124109454670263957843332") };
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
public class A222143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222143Inst Instance=new A222143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222144
{
public static readonly long[] Value={ 1L,4L,4L,16L,52L,16L,64L,676L,676L,64L,256L,8788L,28564L,8788L,256L,1024L,114244L,1206964L,1206964L,114244L,1024L,4096L,1485172L,50999956L,165770032L,50999956L,1485172L,4096L,16384L,19307236L,2154990196L,22767656980L,22767656980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222144Inst : IEnumerable<long>
{
public static readonly long[] Value=A222144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222144.Bytes);
public long this[int i]=>Value[i];

public static A222144Inst Instance=new A222144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222145
{
public static readonly BigInteger[] Value={ 0L,1L,7L,77L,1222L,26364L,739608L,26079780L,1125791280L,58257484128L,3552890064480L,251777905728480L,20488109614761600L,1895120214639868800L,BigInteger.Parse("197527783071095930880"),BigInteger.Parse("23023412842885582176000"),BigInteger.Parse("2980946191374310495795200"),BigInteger.Parse("426192103002275699198054400") };
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
public class A222145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222145Inst Instance=new A222145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222146
{
public static readonly BigInteger[] Value={ 0L,1L,9L,116L,2082L,49774L,1525752L,58180632L,2694333744L,148623965136L,9611353576800L,719080605842400L,61545135592056960L,5968396255982428800L,BigInteger.Parse("650359540100397012480"),BigInteger.Parse("79053322881277342886400"),BigInteger.Parse("10650510963204404347238400"),BigInteger.Parse("1581353364394671905218406400") };
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
public class A222146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222146Inst Instance=new A222146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222147
{
public static readonly long[] Value={ 2L,4L,8L,15L,26L,44L,74L,124L,207L,343L,564L,924L,1510L,2463L,4010L,6517L,10576L,17148L,27789L,45016L,72900L,118024L,191038L,309180L,500343L,809659L,1310147L,2119943L,3430192L,5550177L,8980326L,14530332L,23510266L,38039809L,61548610L,99585874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222147Inst : IEnumerable<long>
{
public static readonly long[] Value=A222147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222147.Bytes);
public long this[int i]=>Value[i];

public static A222147Inst Instance=new A222147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222148
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,79L,131L,216L,355L,582L,952L,1554L,2531L,4114L,6679L,10835L,17568L,28474L,46136L,74732L,121021L,195940L,317190L,513415L,830965L,1344839L,2176388L,3521960L,5699251L,9222308L,14922891L,24146832L,39071752L,63221132L,102296095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222148Inst : IEnumerable<long>
{
public static readonly long[] Value=A222148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222148.Bytes);
public long this[int i]=>Value[i];

public static A222148Inst Instance=new A222148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222149
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,80L,134L,221L,362L,591L,963L,1567L,2547L,4136L,6711L,10882L,17635L,28565L,46255L,74885L,121219L,196202L,317544L,513901L,831639L,1345780L,2177711L,3523841L,5701972L,9226323L,14928923L,24156029L,39085936L,63243204L,102330696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222149Inst : IEnumerable<long>
{
public static readonly long[] Value=A222149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222149.Bytes);
public long this[int i]=>Value[i];

public static A222149Inst Instance=new A222149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222150
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,80L,134L,222L,365L,596L,970L,1576L,2558L,4149L,6726L,10899L,17655L,28591L,46291L,74936L,121290L,196297L,317667L,514056L,831831L,1346016L,2178003L,3524209L,5702444L,9226936L,14929723L,24157071L,39087283L,63244928L,102332884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222150Inst : IEnumerable<long>
{
public static readonly long[] Value=A222150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222150.Bytes);
public long this[int i]=>Value[i];

public static A222150Inst Instance=new A222150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222151
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,80L,134L,222L,365L,597L,973L,1581L,2565L,4158L,6737L,10912L,17670L,28608L,46310L,74957L,121314L,196327L,317707L,514111L,831906L,1346115L,2178130L,3524368L,5702639L,9227171L,14930003L,24157403L,39087679L,63245408L,102333476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222151Inst : IEnumerable<long>
{
public static readonly long[] Value=A222151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222151.Bytes);
public long this[int i]=>Value[i];

public static A222151Inst Instance=new A222151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222152
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,80L,134L,222L,365L,597L,973L,1582L,2568L,4163L,6744L,10921L,17681L,28621L,46325L,74974L,121333L,196348L,317730L,514136L,831934L,1346149L,2178174L,3524427L,5702718L,9227274L,14930134L,24157566L,39087878L,63245647L,102333759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222152Inst : IEnumerable<long>
{
public static readonly long[] Value=A222152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222152.Bytes);
public long this[int i]=>Value[i];

public static A222152Inst Instance=new A222152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222153
{
public static readonly long[] Value={ 2L,2L,4L,2L,4L,7L,2L,4L,8L,12L,2L,4L,8L,15L,20L,2L,4L,8L,15L,26L,33L,2L,4L,8L,15L,27L,44L,53L,2L,4L,8L,15L,27L,47L,74L,85L,2L,4L,8L,15L,27L,47L,79L,124L,137L,2L,4L,8L,15L,27L,47L,80L,131L,207L,221L,2L,4L,8L,15L,27L,47L,80L,134L,216L,343L,355L,2L,4L,8L,15L,27L,47L,80L,134L,221L,355L,564L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222153Inst : IEnumerable<long>
{
public static readonly long[] Value=A222153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222153.Bytes);
public long this[int i]=>Value[i];

public static A222153Inst Instance=new A222153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222154
{
public static readonly long[] Value={ 3360L,13440L,30240L,43680L,53760L,84000L,120960L,127680L,164640L,174720L,215040L,272160L,336000L,393120L,406560L,483840L,510720L,567840L,658560L,665280L,698880L,756000L,860160L,971040L,1088640L,1092000L,1145760L,1149120L,1212960L,1344000L,1367520L,1481760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222154Inst : IEnumerable<long>
{
public static readonly long[] Value=A222154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222154.Bytes);
public long this[int i]=>Value[i];

public static A222154Inst Instance=new A222154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222155
{
public static readonly long[] Value={ 1367520L,5470080L,12307680L,21880320L,32672640L,34188000L,49230720L,58544640L,67008480L,71831760L,73513440L,87521280L,110769120L,130690560L,136752000L,165469920L,196922880L,209969760L,221205600L,231110880L,234178560L,268033920L,287327040L,294053760L,307692000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222155Inst : IEnumerable<long>
{
public static readonly long[] Value=A222155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222155.Bytes);
public long this[int i]=>Value[i];

public static A222155Inst Instance=new A222155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222156
{
public static readonly long[] Value={ 24L,277L,2132L,12521L,60344L,249641L,913748L,3023603L,9190984L,25981835L,68967340L,173242095L,414433320L,949144335L,2090284620L,4443280530L,9145850640L,18279915390L,35563612920L,67490348310L,125168633040L,227242504470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222156Inst : IEnumerable<long>
{
public static readonly long[] Value=A222156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222156.Bytes);
public long this[int i]=>Value[i];

public static A222156Inst Instance=new A222156Inst();

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