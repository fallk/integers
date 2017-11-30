using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A196957
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,9L,9L,4L,6L,20L,26L,20L,6L,9L,41L,87L,87L,41L,9L,13L,85L,282L,492L,282L,85L,13L,19L,178L,919L,2687L,2687L,919L,178L,19L,28L,369L,2987L,14509L,23956L,14509L,2987L,369L,28L,41L,769L,9722L,78717L,214124L,214124L,78717L,9722L,769L,41L,60L,1600L,31643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196957Inst : IEnumerable<long>
{
public static readonly long[] Value=A196957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196957.Bytes);
public long this[int i]=>Value[i];

public static A196957Inst Instance=new A196957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196958
{
public static readonly BigInteger[] Value={ 1L,1L,-3L,22L,-227L,2571L,-19157L,-550675L,47287609L,-2474401796L,113036728791L,-4672627704315L,162246902824213L,-2986895872839215L,-218043087879704765L,BigInteger.Parse("36487218926663045686"),BigInteger.Parse("-3474880515053581779215"),BigInteger.Parse("262843589524537015935667"),BigInteger.Parse("-15730145172651453469201745"),BigInteger.Parse("541394288749029235105442821") };
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
public class A196958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196958Inst Instance=new A196958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196959
{
public static readonly BigInteger[] Value={ 1L,1L,9L,193L,6721L,326001L,20316937L,1548374129L,139576777921L,14530808439073L,1715928199384521L,226652340142349793L,BigInteger.Parse("33113449456084235905"),BigInteger.Parse("5302086923264289694225"),BigInteger.Parse("923349950199153833740105"),BigInteger.Parse("173761214485224395469845521"),BigInteger.Parse("35139709415689684107278235265") };
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
public class A196959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196959Inst Instance=new A196959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196960
{
public static readonly long[] Value={ 1L,6L,101L,5465L,1210968L,906566345L,2383058555507L,22106903739199918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196960Inst : IEnumerable<long>
{
public static readonly long[] Value=A196960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196960.Bytes);
public long this[int i]=>Value[i];

public static A196960Inst Instance=new A196960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196961
{
public static readonly long[] Value={ 2L,6L,15L,48L,145L,449L,1397L,4342L,13500L,41981L,130562L,406025L,1262695L,3926857L,12212128L,37978464L,118109177L,367307576L,1142289291L,3552403843L,11047615721L,34356964532L,106846675430L,332282325069L,1033364333556L,3213658281627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196961Inst : IEnumerable<long>
{
public static readonly long[] Value=A196961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196961.Bytes);
public long this[int i]=>Value[i];

public static A196961Inst Instance=new A196961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196962
{
public static readonly long[] Value={ 3L,15L,101L,562L,3145L,17966L,102080L,579654L,3294963L,18723516L,106389322L,604557068L,3435367971L,19521219395L,110928045006L,630341323663L,3581872680156L,20353754514623L,115658863251081L,657223831674612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196962Inst : IEnumerable<long>
{
public static readonly long[] Value=A196962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196962.Bytes);
public long this[int i]=>Value[i];

public static A196962Inst Instance=new A196962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196963
{
public static readonly long[] Value={ 4L,48L,562L,5465L,58639L,634241L,6764386L,72281541L,773637307L,8274218119L,88495136248L,946584068019L,10124647473535L,108293363518701L,1158313188626715L,12389366140294426L,132517210297246830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196963Inst : IEnumerable<long>
{
public static readonly long[] Value=A196963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196963.Bytes);
public long this[int i]=>Value[i];

public static A196963Inst Instance=new A196963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196964
{
public static readonly BigInteger[] Value={ 6L,145L,3145L,58639L,1210968L,24281566L,482839574L,9688062164L,194158517334L,3887864391419L,77882274874621L,1560086250583302L,31249383701318779L,625956152664072444L,12538492197520048383UL,BigInteger.Parse("251157344451183972038") };
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
public class A196964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196964Inst Instance=new A196964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196965
{
public static readonly BigInteger[] Value={ 9L,449L,17966L,634241L,24281566L,906566345L,33928210026L,1276381991598L,47878302949552L,1796412252140585L,67423941362664276L,2530227381866900256L,BigInteger.Parse("94953390054212557512"),BigInteger.Parse("3563426148443173137440"),BigInteger.Parse("133727820453911745380230") };
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
public class A196965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196965Inst Instance=new A196965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196966
{
public static readonly BigInteger[] Value={ 13L,1397L,102080L,6764386L,482839574L,33928210026L,2383058555507L,167702841476961L,11786999591610885L,828960396306273892L,BigInteger.Parse("58296402348891537824"),BigInteger.Parse("4099251286067107216498"),BigInteger.Parse("288261650035459614362322") };
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
public class A196966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196966Inst Instance=new A196966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196967
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,3L,4L,15L,15L,4L,6L,48L,101L,48L,6L,9L,145L,562L,562L,145L,9L,13L,449L,3145L,5465L,3145L,449L,13L,19L,1397L,17966L,58639L,58639L,17966L,1397L,19L,28L,4342L,102080L,634241L,1210968L,634241L,102080L,4342L,28L,41L,13500L,579654L,6764386L,24281566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196967Inst : IEnumerable<long>
{
public static readonly long[] Value=A196967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196967.Bytes);
public long this[int i]=>Value[i];

public static A196967Inst Instance=new A196967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196968
{
public static readonly long[] Value={ 1L,7L,34L,815L,31899L,3602632L,986337603L,654433849619L,1060308532244235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196968Inst : IEnumerable<long>
{
public static readonly long[] Value=A196968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196968.Bytes);
public long this[int i]=>Value[i];

public static A196968Inst Instance=new A196968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196969
{
public static readonly long[] Value={ 2L,10L,34L,104L,386L,1380L,4800L,16794L,58875L,206084L,721260L,2525126L,8840855L,30952194L,108366098L,379400544L,1328316102L,4650549495L,16281977271L,57004611828L,199578061611L,698740003512L,2446349057586L,8564879222176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196969Inst : IEnumerable<long>
{
public static readonly long[] Value=A196969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196969.Bytes);
public long this[int i]=>Value[i];

public static A196969Inst Instance=new A196969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196970
{
public static readonly long[] Value={ 3L,23L,104L,815L,3675L,20500L,115563L,638791L,3550336L,19599537L,108573593L,601527392L,3331391577L,18450904073L,102183492764L,565933465777L,3134368803899L,17359289108840L,96142199882539L,532471005541643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196970Inst : IEnumerable<long>
{
public static readonly long[] Value=A196970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196970.Bytes);
public long this[int i]=>Value[i];

public static A196970Inst Instance=new A196970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196971
{
public static readonly long[] Value={ 5L,57L,386L,3675L,31899L,260394L,2246059L,19246379L,164006734L,1400773245L,11965906663L,102191052974L,872793094884L,7454220149765L,63663510400324L,543728417138307L,4643793942698920L,39660975017361508L,338730301259452052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196971Inst : IEnumerable<long>
{
public static readonly long[] Value=A196971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196971.Bytes);
public long this[int i]=>Value[i];

public static A196971Inst Instance=new A196971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196972
{
public static readonly long[] Value={ 8L,122L,1380L,20500L,260394L,3602632L,47228658L,627332704L,8353150047L,111159106170L,1478940309946L,19675820763094L,261790325506593L,3482887310542208L,46337842544897348L,616501427043267034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196972Inst : IEnumerable<long>
{
public static readonly long[] Value=A196972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196972.Bytes);
public long this[int i]=>Value[i];

public static A196972Inst Instance=new A196972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196973
{
public static readonly BigInteger[] Value={ 13L,275L,4800L,115563L,2246059L,47228658L,986337603L,20278906437L,420951074243L,8734501701701L,181050206799010L,3753750765133292L,77826189975568359L,1613547115315836603L,BigInteger.Parse("33453410187089875487"),BigInteger.Parse("693584699456224460683") };
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
public class A196973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196973Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196973.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196973Inst Instance=new A196973Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196974
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,10L,10L,3L,5L,23L,34L,23L,5L,8L,57L,104L,104L,57L,8L,13L,122L,386L,815L,386L,122L,13L,21L,275L,1380L,3675L,3675L,1380L,275L,21L,34L,623L,4800L,20500L,31899L,20500L,4800L,623L,34L,55L,1394L,16794L,115563L,260394L,260394L,115563L,16794L,1394L,55L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196974Inst : IEnumerable<long>
{
public static readonly long[] Value=A196974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196974.Bytes);
public long this[int i]=>Value[i];

public static A196974Inst Instance=new A196974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196975
{
public static readonly long[] Value={ 1L,5L,65L,2425L,272332L,91153533L,90401915964L,266535433627635L,2320436756494474533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196975Inst : IEnumerable<long>
{
public static readonly long[] Value=A196975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196975.Bytes);
public long this[int i]=>Value[i];

public static A196975Inst Instance=new A196975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196976
{
public static readonly long[] Value={ 1L,5L,14L,37L,104L,290L,803L,2233L,6207L,17242L,47913L,133140L,369944L,1027963L,2856397L,7937011L,22054470L,61282473L,170284722L,473167812L,1314784901L,3653374545L,10151581325L,28208058702L,78381342385L,217797151870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196976Inst : IEnumerable<long>
{
public static readonly long[] Value=A196976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196976.Bytes);
public long this[int i]=>Value[i];

public static A196976Inst Instance=new A196976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196977
{
public static readonly long[] Value={ 2L,14L,65L,298L,1422L,6679L,31386L,147574L,693908L,3264528L,15355363L,72218049L,339655885L,1597498534L,7513580345L,35338859818L,166209560097L,781734366252L,3676738971843L,17292851654928L,81333680575181L,382537629290829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196977Inst : IEnumerable<long>
{
public static readonly long[] Value=A196977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196977.Bytes);
public long this[int i]=>Value[i];

public static A196977Inst Instance=new A196977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196978
{
public static readonly long[] Value={ 3L,37L,298L,2425L,19580L,156862L,1272373L,10339597L,83584679L,675742932L,5470806427L,44295902902L,358490386914L,2901075834539L,23480627788151L,190053072058627L,1538212852796494L,12449506279663245L,100761743839068352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196978Inst : IEnumerable<long>
{
public static readonly long[] Value=A196978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196978.Bytes);
public long this[int i]=>Value[i];

public static A196978Inst Instance=new A196978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196979
{
public static readonly long[] Value={ 4L,104L,1422L,19580L,272332L,3795662L,53216978L,741538796L,10335576740L,144324460038L,2014312044979L,28101431225812L,392129201954237L,5472231735063254L,76359651510217964L,1065515249428296294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196979Inst : IEnumerable<long>
{
public static readonly long[] Value=A196979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196979.Bytes);
public long this[int i]=>Value[i];

public static A196979Inst Instance=new A196979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196980
{
public static readonly BigInteger[] Value={ 6L,290L,6679L,156862L,3795662L,91153533L,2188092870L,52468355814L,1259904818890L,30260896396958L,726311424309641L,17435505488540779L,418593341337186977L,10049005361904800920UL,BigInteger.Parse("241243533429917304743"),BigInteger.Parse("5791533057112464884540") };
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
public class A196980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196980Inst Instance=new A196980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196981
{
public static readonly BigInteger[] Value={ 9L,803L,31386L,1272373L,53216978L,2188092870L,90401915964L,3740738215983L,154705956361411L,6393070820268590L,264219149718966451L,10923404535101323602UL,BigInteger.Parse("451574917966470461834"),BigInteger.Parse("18666476210321258568728") };
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
public class A196981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196981Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196981.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196981Inst Instance=new A196981Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196982
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,3L,14L,14L,3L,4L,37L,65L,37L,4L,6L,104L,298L,298L,104L,6L,9L,290L,1422L,2425L,1422L,290L,9L,13L,803L,6679L,19580L,19580L,6679L,803L,13L,19L,2233L,31386L,156862L,272332L,156862L,31386L,2233L,19L,28L,6207L,147574L,1272373L,3795662L,3795662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196982Inst : IEnumerable<long>
{
public static readonly long[] Value=A196982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196982.Bytes);
public long this[int i]=>Value[i];

public static A196982Inst Instance=new A196982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196983
{
public static readonly BigInteger[] Value={ 1L,1L,10L,113L,4244L,389518L,93411402L,60168452277L,101406070116889L,451089091560500274L,BigInteger.Parse("5277294850017253970644") };
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
public class A196983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196983Inst Instance=new A196983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196984
{
public static readonly long[] Value={ 1L,3L,10L,25L,81L,242L,707L,2095L,6224L,18499L,54863L,162682L,482707L,1432377L,4249808L,12608401L,37408069L,110988820L,329298679L,977007545L,2898720410L,8600339717L,25516721819L,75706627806L,224617138645L,666426019913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196984Inst : IEnumerable<long>
{
public static readonly long[] Value=A196984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196984.Bytes);
public long this[int i]=>Value[i];

public static A196984Inst Instance=new A196984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196985
{
public static readonly long[] Value={ 1L,5L,25L,113L,547L,2499L,11647L,54845L,256395L,1198317L,5607683L,26243839L,122783657L,574447047L,2687794239L,12575875245L,58839924859L,275301009225L,1288087194957L,6026735743519L,28198022800317L,131933577537561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196985Inst : IEnumerable<long>
{
public static readonly long[] Value=A196985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196985.Bytes);
public long this[int i]=>Value[i];

public static A196985Inst Instance=new A196985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196986
{
public static readonly long[] Value={ 1L,9L,81L,547L,4244L,31791L,242602L,1838579L,13941719L,105949190L,804555155L,6108373537L,46382778115L,352202493024L,2674392958960L,20307546721207L,154201699487668L,1170902185284561L,8891038271677518L,67512544345698850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196986Inst : IEnumerable<long>
{
public static readonly long[] Value=A196986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196986.Bytes);
public long this[int i]=>Value[i];

public static A196986Inst Instance=new A196986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196987
{
public static readonly long[] Value={ 1L,17L,242L,2499L,31791L,389518L,4743311L,58038517L,713190410L,8761030047L,107458130741L,1318534640744L,16183672145693L,198628472994711L,2437691980502762L,29916664089221985L,367160436509970605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196987Inst : IEnumerable<long>
{
public static readonly long[] Value=A196987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196987.Bytes);
public long this[int i]=>Value[i];

public static A196987Inst Instance=new A196987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196988
{
public static readonly BigInteger[] Value={ 1L,31L,707L,11647L,242602L,4743311L,93411402L,1863379223L,37097158961L,737372275936L,14668565862312L,291924510277289L,5808427537351763L,115562866241227272L,2299357190745139049L,BigInteger.Parse("45750931870365018621") };
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
public class A196988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196988Inst Instance=new A196988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196989
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,5L,10L,5L,1L,1L,9L,25L,25L,9L,1L,1L,17L,81L,113L,81L,17L,1L,1L,31L,242L,547L,547L,242L,31L,1L,1L,57L,707L,2499L,4244L,2499L,707L,57L,1L,1L,105L,2095L,11647L,31791L,31791L,11647L,2095L,105L,1L,1L,193L,6224L,54845L,242602L,389518L,242602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196989Inst : IEnumerable<long>
{
public static readonly long[] Value=A196989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196989.Bytes);
public long this[int i]=>Value[i];

public static A196989Inst Instance=new A196989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196990
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,9L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196990Inst : IEnumerable<long>
{
public static readonly long[] Value=A196990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196990.Bytes);
public long this[int i]=>Value[i];

public static A196990Inst Instance=new A196990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196991
{
public static readonly long[] Value={ 4L,10L,32L,112L,412L,1572L,6148L,24494L,98992L,404650L,1669496L,6941226L,29047568L,122235518L,516860460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196991Inst : IEnumerable<long>
{
public static readonly long[] Value=A196991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196991.Bytes);
public long this[int i]=>Value[i];

public static A196991Inst Instance=new A196991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196992
{
public static readonly long[] Value={ 6L,12L,32L,93L,288L,926L,3048L,10209L,34694L,119271L,413844L,1446881L,5090694L,18007935L,64000106L,228389088L,817976316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196992Inst : IEnumerable<long>
{
public static readonly long[] Value=A196992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196992.Bytes);
public long this[int i]=>Value[i];

public static A196992Inst Instance=new A196992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196993
{
public static readonly long[] Value={ 6L,9L,14L,24L,42L,77L,144L,276L,538L,1065L,2136L,4321L,8790L,17967L,36890L,76050L,157380L,326824L,680880L,1422570L,2979572L,6254175L,13153242L,27712901L,58487796L,123632910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196993Inst : IEnumerable<long>
{
public static readonly long[] Value=A196993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196993.Bytes);
public long this[int i]=>Value[i];

public static A196993Inst Instance=new A196993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196994
{
public static readonly long[] Value={ 9024L,12499L,18024L,24744L,31303L,51358L,74004L,88928L,119664L,127040L,144156L,147014L,161162L,161703L,221075L,224433L,256920L,376704L,475259L,509937L,519960L,520404L,521873L,579501L,606360L,662304L,693252L,809184L,813247L,817453L,1110110L,1545335L,1681760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196994Inst : IEnumerable<long>
{
public static readonly long[] Value=A196994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196994.Bytes);
public long this[int i]=>Value[i];

public static A196994Inst Instance=new A196994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196995
{
public static readonly BigInteger[] Value={ 0L,-128L,-5038848L,140737488355328L,BigInteger.Parse("5000000000000000000000000"),BigInteger.Parse("-354400937492545922690672153504784580608"),BigInteger.Parse("-72317557999158469111384459491956546088110808312359944192"),BigInteger.Parse("57896044618658097711785492504343953926634992332820282019728792003956564819968") };
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
public class A196995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196995Inst Instance=new A196995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196996
{
public static readonly long[] Value={ 9L,3L,5L,0L,2L,7L,2L,8L,8L,4L,7L,4L,9L,6L,7L,8L,3L,6L,1L,4L,5L,1L,9L,4L,4L,2L,7L,5L,3L,2L,3L,9L,7L,7L,6L,3L,1L,7L,5L,1L,8L,3L,5L,1L,0L,0L,5L,2L,6L,8L,3L,9L,0L,8L,9L,5L,3L,4L,7L,2L,9L,7L,9L,7L,0L,1L,2L,8L,5L,7L,1L,3L,0L,3L,2L,2L,9L,6L,3L,6L,0L,2L,7L,4L,7L,3L,1L,0L,4L,9L,2L,9L,1L,6L,2L,8L,9L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196996Inst : IEnumerable<long>
{
public static readonly long[] Value=A196996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196996.Bytes);
public long this[int i]=>Value[i];

public static A196996Inst Instance=new A196996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196997
{
public static readonly long[] Value={ 3L,5L,3L,1L,4L,0L,0L,6L,5L,6L,5L,9L,1L,2L,0L,9L,6L,7L,5L,5L,6L,6L,6L,1L,1L,1L,4L,1L,2L,7L,8L,5L,0L,3L,1L,9L,5L,4L,3L,7L,5L,6L,8L,5L,5L,0L,1L,6L,0L,6L,6L,8L,4L,3L,1L,8L,7L,7L,3L,8L,6L,5L,9L,0L,5L,2L,8L,4L,7L,1L,6L,5L,0L,1L,6L,9L,6L,6L,2L,4L,3L,6L,0L,2L,0L,2L,7L,0L,6L,6L,2L,2L,6L,8L,7L,7L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196997Inst : IEnumerable<long>
{
public static readonly long[] Value=A196997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196997.Bytes);
public long this[int i]=>Value[i];

public static A196997Inst Instance=new A196997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196998
{
public static readonly long[] Value={ 1L,0L,5L,5L,5L,3L,7L,1L,3L,5L,0L,7L,5L,4L,7L,5L,2L,4L,9L,8L,5L,4L,1L,4L,8L,4L,1L,7L,8L,9L,2L,2L,9L,0L,3L,5L,4L,1L,2L,2L,2L,7L,9L,8L,0L,6L,9L,6L,2L,7L,3L,2L,9L,7L,3L,0L,4L,0L,0L,8L,2L,4L,1L,7L,5L,4L,1L,5L,4L,5L,5L,4L,2L,8L,0L,0L,9L,4L,4L,9L,3L,6L,6L,6L,9L,4L,4L,5L,9L,1L,5L,5L,0L,4L,5L,7L,4L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196998Inst : IEnumerable<long>
{
public static readonly long[] Value=A196998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196998.Bytes);
public long this[int i]=>Value[i];

public static A196998Inst Instance=new A196998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196999
{
public static readonly long[] Value={ 4L,5L,6L,4L,8L,5L,0L,4L,2L,0L,2L,3L,4L,5L,0L,1L,2L,8L,1L,3L,9L,7L,6L,0L,6L,4L,7L,4L,3L,5L,4L,1L,3L,7L,1L,7L,0L,6L,4L,3L,0L,5L,0L,9L,2L,7L,8L,2L,9L,2L,8L,5L,3L,8L,2L,3L,5L,8L,0L,0L,3L,1L,8L,0L,1L,9L,6L,2L,6L,6L,6L,0L,4L,8L,0L,0L,6L,8L,5L,3L,6L,2L,8L,1L,6L,8L,7L,0L,7L,7L,1L,2L,8L,6L,7L,3L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196999Inst : IEnumerable<long>
{
public static readonly long[] Value=A196999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196999.Bytes);
public long this[int i]=>Value[i];

public static A196999Inst Instance=new A196999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197000
{
public static readonly long[] Value={ 1L,2L,4L,8L,8L,0L,1L,4L,3L,6L,7L,2L,1L,5L,5L,0L,8L,5L,6L,0L,4L,7L,5L,1L,2L,5L,0L,2L,0L,1L,2L,8L,3L,8L,1L,5L,3L,5L,5L,8L,7L,6L,1L,4L,3L,0L,3L,6L,0L,8L,2L,1L,6L,3L,4L,1L,4L,6L,0L,2L,5L,0L,2L,0L,4L,4L,2L,0L,8L,5L,0L,0L,0L,1L,4L,5L,2L,7L,2L,5L,5L,3L,7L,0L,6L,7L,4L,7L,9L,9L,7L,6L,6L,0L,1L,4L,2L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197000Inst : IEnumerable<long>
{
public static readonly long[] Value=A197000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197000.Bytes);
public long this[int i]=>Value[i];

public static A197000Inst Instance=new A197000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197001
{
public static readonly long[] Value={ 1L,0L,5L,4L,1L,7L,8L,4L,4L,2L,6L,5L,6L,8L,4L,2L,1L,7L,5L,1L,5L,7L,4L,7L,7L,3L,4L,3L,0L,5L,6L,7L,3L,4L,8L,3L,7L,4L,6L,1L,4L,2L,1L,0L,4L,5L,8L,9L,1L,6L,0L,6L,6L,4L,5L,3L,6L,7L,7L,2L,1L,8L,5L,0L,7L,8L,2L,3L,8L,0L,7L,2L,5L,6L,7L,6L,3L,2L,7L,7L,7L,9L,0L,9L,4L,3L,3L,8L,4L,5L,0L,3L,2L,0L,5L,7L,5L,4L,6L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197001Inst : IEnumerable<long>
{
public static readonly long[] Value=A197001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197001.Bytes);
public long this[int i]=>Value[i];

public static A197001Inst Instance=new A197001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197002
{
public static readonly long[] Value={ 3L,6L,9L,5L,4L,2L,5L,6L,6L,6L,0L,7L,5L,8L,0L,3L,2L,0L,8L,2L,7L,6L,5L,6L,0L,4L,3L,8L,3L,6L,9L,3L,6L,7L,0L,2L,0L,0L,6L,7L,0L,5L,8L,7L,9L,4L,5L,0L,3L,7L,8L,7L,3L,2L,4L,8L,2L,8L,4L,0L,3L,1L,7L,8L,8L,6L,6L,4L,2L,3L,2L,7L,4L,4L,1L,7L,7L,3L,7L,9L,7L,2L,9L,9L,6L,8L,8L,0L,5L,3L,4L,6L,5L,8L,8L,3L,2L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197002Inst : IEnumerable<long>
{
public static readonly long[] Value=A197002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197002.Bytes);
public long this[int i]=>Value[i];

public static A197002Inst Instance=new A197002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197003
{
public static readonly long[] Value={ 1L,0L,9L,3L,1L,6L,9L,7L,4L,4L,9L,8L,5L,0L,1L,6L,9L,2L,2L,0L,8L,8L,1L,5L,3L,2L,1L,4L,1L,6L,0L,5L,7L,9L,7L,1L,4L,4L,0L,4L,8L,9L,0L,6L,5L,9L,2L,9L,4L,8L,9L,8L,8L,8L,3L,5L,6L,3L,5L,1L,7L,5L,1L,3L,3L,2L,4L,9L,6L,0L,5L,3L,7L,6L,7L,0L,9L,4L,4L,7L,3L,6L,8L,3L,7L,6L,7L,0L,6L,7L,9L,9L,3L,4L,8L,1L,7L,9L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197003Inst : IEnumerable<long>
{
public static readonly long[] Value=A197003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197003.Bytes);
public long this[int i]=>Value[i];

public static A197003Inst Instance=new A197003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197004
{
public static readonly long[] Value={ 2L,5L,5L,4L,6L,5L,2L,8L,6L,1L,0L,3L,8L,5L,3L,5L,9L,6L,6L,9L,5L,8L,8L,2L,6L,9L,6L,6L,1L,3L,3L,2L,0L,2L,7L,2L,6L,5L,4L,7L,8L,8L,3L,5L,5L,9L,5L,3L,7L,0L,8L,5L,2L,8L,9L,3L,0L,2L,5L,2L,6L,7L,6L,7L,2L,9L,7L,6L,4L,8L,2L,2L,6L,7L,0L,9L,3L,0L,6L,6L,8L,2L,5L,0L,6L,4L,1L,1L,1L,8L,3L,6L,7L,2L,5L,8L,9L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197004Inst : IEnumerable<long>
{
public static readonly long[] Value=A197004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197004.Bytes);
public long this[int i]=>Value[i];

public static A197004Inst Instance=new A197004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197005
{
public static readonly long[] Value={ 1L,0L,3L,7L,0L,5L,7L,0L,8L,3L,7L,3L,6L,5L,1L,5L,0L,0L,4L,6L,6L,1L,4L,7L,9L,5L,8L,3L,7L,5L,8L,4L,2L,7L,7L,6L,0L,5L,2L,2L,2L,3L,4L,3L,4L,3L,1L,3L,9L,2L,5L,1L,5L,3L,1L,6L,5L,5L,2L,9L,5L,2L,4L,2L,0L,6L,8L,4L,8L,7L,9L,8L,7L,2L,3L,9L,7L,5L,1L,8L,7L,8L,7L,4L,8L,1L,7L,2L,3L,2L,2L,4L,5L,5L,9L,3L,3L,2L,8L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197005Inst : IEnumerable<long>
{
public static readonly long[] Value=A197005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197005.Bytes);
public long this[int i]=>Value[i];

public static A197005Inst Instance=new A197005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197006
{
public static readonly long[] Value={ 4L,6L,0L,8L,8L,5L,5L,8L,0L,8L,6L,0L,9L,6L,5L,9L,7L,6L,9L,8L,7L,9L,8L,1L,2L,8L,2L,5L,1L,3L,6L,9L,8L,2L,7L,7L,2L,4L,3L,7L,4L,9L,9L,9L,8L,7L,4L,3L,9L,3L,4L,3L,5L,6L,9L,3L,2L,5L,7L,8L,4L,3L,3L,9L,2L,4L,8L,3L,4L,7L,5L,2L,2L,8L,8L,0L,3L,8L,7L,9L,7L,1L,3L,0L,5L,0L,5L,9L,7L,4L,8L,0L,7L,6L,7L,9L,4L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197006Inst : IEnumerable<long>
{
public static readonly long[] Value=A197006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197006.Bytes);
public long this[int i]=>Value[i];

public static A197006Inst Instance=new A197006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197007
{
public static readonly long[] Value={ 1L,2L,0L,0L,4L,9L,9L,0L,7L,2L,3L,8L,7L,9L,9L,7L,9L,0L,6L,1L,2L,5L,0L,4L,6L,5L,1L,2L,4L,4L,2L,7L,1L,1L,3L,4L,2L,4L,3L,7L,6L,8L,0L,1L,7L,5L,1L,3L,2L,9L,9L,4L,0L,6L,8L,6L,6L,0L,5L,0L,4L,2L,1L,9L,0L,9L,4L,4L,4L,7L,6L,1L,0L,3L,8L,1L,3L,6L,2L,4L,2L,6L,8L,5L,5L,6L,4L,8L,5L,6L,0L,5L,1L,1L,4L,3L,3L,6L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197007Inst : IEnumerable<long>
{
public static readonly long[] Value=A197007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197007.Bytes);
public long this[int i]=>Value[i];

public static A197007Inst Instance=new A197007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197008
{
public static readonly long[] Value={ 4L,1L,6L,1L,9L,3L,8L,1L,8L,4L,9L,4L,1L,4L,6L,2L,7L,5L,2L,3L,9L,0L,0L,8L,0L,7L,2L,2L,9L,4L,6L,6L,9L,9L,6L,3L,7L,7L,8L,9L,3L,2L,5L,5L,8L,7L,5L,5L,0L,9L,3L,0L,3L,0L,2L,4L,2L,9L,6L,2L,3L,8L,5L,2L,7L,0L,6L,8L,8L,5L,0L,3L,6L,5L,0L,2L,9L,1L,5L,9L,3L,8L,2L,4L,6L,1L,3L,8L,8L,2L,2L,0L,6L,7L,8L,3L,6L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197008Inst : IEnumerable<long>
{
public static readonly long[] Value=A197008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197008.Bytes);
public long this[int i]=>Value[i];

public static A197008Inst Instance=new A197008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197009
{
public static readonly long[] Value={ 1L,0L,4L,4L,7L,3L,5L,8L,2L,5L,1L,0L,2L,5L,9L,1L,9L,6L,4L,4L,6L,7L,0L,4L,6L,7L,1L,2L,5L,0L,4L,4L,0L,4L,1L,1L,3L,0L,4L,8L,6L,5L,8L,9L,3L,2L,8L,0L,5L,0L,5L,9L,5L,7L,8L,8L,7L,4L,2L,8L,3L,1L,8L,2L,0L,8L,4L,6L,5L,0L,8L,0L,5L,9L,3L,0L,7L,3L,2L,6L,8L,9L,7L,2L,4L,3L,1L,3L,3L,0L,3L,9L,5L,6L,6L,9L,3L,8L,4L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197009Inst : IEnumerable<long>
{
public static readonly long[] Value=A197009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197009.Bytes);
public long this[int i]=>Value[i];

public static A197009Inst Instance=new A197009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197010
{
public static readonly long[] Value={ 4L,6L,7L,2L,8L,1L,6L,0L,5L,3L,7L,6L,0L,1L,2L,1L,3L,3L,7L,8L,1L,6L,3L,0L,7L,2L,6L,8L,8L,4L,4L,2L,5L,0L,1L,3L,8L,1L,1L,6L,5L,1L,4L,2L,4L,6L,7L,6L,6L,7L,0L,6L,4L,5L,1L,6L,4L,1L,1L,5L,8L,9L,7L,7L,7L,0L,6L,7L,5L,6L,3L,4L,7L,2L,2L,9L,6L,3L,6L,4L,1L,5L,5L,0L,3L,8L,9L,3L,6L,1L,1L,6L,6L,2L,0L,5L,3L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197010Inst : IEnumerable<long>
{
public static readonly long[] Value=A197010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197010.Bytes);
public long this[int i]=>Value[i];

public static A197010Inst Instance=new A197010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197011
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,5L,6L,2L,7L,2L,0L,0L,1L,0L,5L,6L,9L,8L,0L,2L,9L,9L,8L,8L,0L,1L,6L,7L,5L,4L,7L,7L,7L,7L,6L,2L,0L,4L,2L,9L,7L,3L,0L,6L,2L,9L,3L,4L,2L,3L,0L,1L,1L,0L,7L,5L,5L,0L,6L,1L,4L,8L,2L,3L,4L,8L,8L,0L,8L,3L,4L,2L,2L,5L,6L,0L,8L,4L,2L,7L,4L,5L,6L,0L,0L,6L,6L,7L,4L,8L,5L,3L,8L,8L,8L,6L,5L,7L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197011Inst : IEnumerable<long>
{
public static readonly long[] Value=A197011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197011.Bytes);
public long this[int i]=>Value[i];

public static A197011Inst Instance=new A197011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197012
{
public static readonly long[] Value={ 5L,4L,0L,5L,5L,9L,8L,7L,2L,7L,4L,2L,3L,4L,8L,3L,8L,2L,5L,4L,3L,0L,6L,0L,8L,6L,5L,2L,6L,9L,5L,6L,2L,3L,9L,8L,1L,9L,6L,0L,3L,9L,2L,4L,4L,0L,4L,9L,8L,0L,1L,3L,0L,3L,6L,6L,3L,9L,7L,6L,0L,3L,2L,3L,3L,9L,8L,6L,0L,8L,6L,0L,8L,5L,3L,4L,6L,6L,5L,1L,6L,3L,4L,7L,5L,3L,1L,7L,7L,1L,9L,2L,6L,1L,2L,9L,3L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197012Inst : IEnumerable<long>
{
public static readonly long[] Value=A197012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197012.Bytes);
public long this[int i]=>Value[i];

public static A197012Inst Instance=new A197012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197013
{
public static readonly long[] Value={ 6L,6L,0L,3L,6L,6L,1L,0L,2L,4L,2L,3L,4L,0L,2L,9L,5L,8L,5L,8L,8L,6L,9L,4L,5L,2L,3L,7L,2L,9L,2L,8L,6L,5L,4L,8L,4L,8L,1L,7L,6L,2L,3L,2L,7L,9L,8L,7L,9L,1L,0L,6L,8L,1L,2L,6L,8L,1L,1L,8L,6L,7L,3L,9L,8L,5L,2L,0L,9L,7L,6L,3L,9L,1L,0L,5L,6L,7L,4L,1L,1L,1L,6L,6L,7L,8L,7L,8L,2L,1L,3L,3L,0L,7L,3L,1L,5L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197013Inst : IEnumerable<long>
{
public static readonly long[] Value=A197013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197013.Bytes);
public long this[int i]=>Value[i];

public static A197013Inst Instance=new A197013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197014
{
public static readonly long[] Value={ 7L,0L,2L,3L,4L,8L,2L,3L,7L,9L,2L,1L,9L,9L,6L,5L,9L,2L,6L,8L,4L,4L,5L,6L,0L,1L,4L,4L,1L,2L,9L,1L,5L,0L,4L,8L,0L,2L,7L,3L,2L,7L,6L,1L,6L,6L,0L,3L,5L,3L,4L,0L,6L,2L,6L,7L,2L,3L,9L,5L,1L,5L,6L,7L,6L,5L,5L,5L,8L,5L,2L,9L,4L,8L,0L,5L,6L,7L,0L,4L,3L,8L,9L,6L,9L,7L,6L,1L,5L,3L,8L,3L,8L,3L,1L,5L,9L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197014Inst : IEnumerable<long>
{
public static readonly long[] Value=A197014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197014.Bytes);
public long this[int i]=>Value[i];

public static A197014Inst Instance=new A197014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197015
{
public static readonly long[] Value={ 9L,8L,6L,5L,6L,6L,2L,5L,5L,5L,4L,3L,5L,0L,9L,0L,1L,9L,2L,5L,4L,8L,5L,4L,4L,3L,2L,6L,6L,8L,9L,0L,5L,4L,2L,4L,3L,0L,8L,4L,7L,5L,1L,4L,6L,9L,0L,9L,0L,6L,0L,3L,2L,0L,5L,0L,7L,0L,2L,4L,9L,6L,6L,4L,5L,1L,4L,4L,2L,2L,1L,3L,9L,2L,4L,8L,3L,8L,3L,7L,8L,0L,7L,6L,5L,6L,3L,0L,4L,2L,1L,8L,6L,6L,5L,0L,3L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197015Inst : IEnumerable<long>
{
public static readonly long[] Value=A197015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197015.Bytes);
public long this[int i]=>Value[i];

public static A197015Inst Instance=new A197015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197016
{
public static readonly long[] Value={ 4L,2L,8L,7L,7L,8L,5L,3L,6L,0L,3L,0L,6L,1L,2L,8L,6L,3L,6L,1L,3L,6L,9L,1L,7L,4L,1L,0L,4L,8L,9L,9L,9L,7L,0L,4L,9L,0L,6L,0L,5L,8L,9L,3L,6L,1L,5L,2L,0L,2L,6L,8L,5L,1L,9L,9L,3L,7L,8L,8L,2L,4L,6L,9L,8L,4L,7L,1L,3L,9L,3L,2L,2L,8L,8L,8L,9L,7L,9L,4L,8L,6L,0L,3L,5L,1L,0L,1L,5L,5L,4L,3L,3L,2L,3L,1L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197016Inst : IEnumerable<long>
{
public static readonly long[] Value=A197016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197016.Bytes);
public long this[int i]=>Value[i];

public static A197016Inst Instance=new A197016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197017
{
public static readonly long[] Value={ 2L,9L,7L,1L,0L,5L,6L,3L,5L,2L,7L,4L,8L,2L,2L,7L,1L,6L,7L,1L,2L,2L,1L,4L,4L,3L,6L,5L,2L,6L,3L,1L,6L,1L,9L,9L,4L,0L,7L,2L,9L,6L,0L,7L,1L,0L,8L,5L,6L,7L,0L,4L,0L,0L,5L,6L,7L,6L,8L,6L,4L,5L,5L,2L,4L,8L,5L,8L,2L,3L,6L,9L,4L,8L,4L,1L,8L,0L,8L,1L,7L,7L,0L,0L,6L,8L,2L,3L,8L,4L,1L,4L,6L,4L,9L,0L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197017Inst : IEnumerable<long>
{
public static readonly long[] Value=A197017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197017.Bytes);
public long this[int i]=>Value[i];

public static A197017Inst Instance=new A197017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197018
{
public static readonly long[] Value={ 2L,1L,8L,7L,2L,9L,4L,8L,8L,8L,0L,3L,6L,4L,4L,0L,6L,5L,8L,9L,7L,2L,8L,5L,2L,2L,3L,2L,6L,8L,1L,2L,1L,0L,4L,9L,3L,0L,3L,6L,3L,6L,1L,9L,9L,7L,3L,1L,4L,1L,4L,9L,9L,5L,8L,2L,2L,1L,6L,6L,9L,4L,6L,6L,9L,0L,3L,1L,8L,5L,8L,6L,5L,0L,7L,6L,2L,9L,6L,0L,6L,3L,4L,5L,6L,6L,6L,1L,3L,7L,9L,4L,2L,8L,4L,3L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197018Inst : IEnumerable<long>
{
public static readonly long[] Value=A197018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197018.Bytes);
public long this[int i]=>Value[i];

public static A197018Inst Instance=new A197018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197019
{
public static readonly long[] Value={ 1L,7L,1L,9L,9L,4L,5L,1L,7L,3L,4L,8L,1L,0L,1L,6L,9L,0L,7L,3L,9L,0L,2L,4L,8L,6L,5L,4L,4L,8L,7L,1L,4L,9L,5L,4L,3L,9L,4L,8L,8L,2L,2L,2L,6L,6L,4L,9L,3L,9L,8L,1L,5L,8L,8L,7L,3L,3L,3L,6L,3L,7L,9L,7L,1L,0L,0L,0L,0L,9L,9L,8L,4L,8L,7L,9L,6L,2L,8L,7L,0L,9L,0L,3L,8L,6L,7L,0L,8L,8L,4L,8L,6L,8L,9L,7L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197019Inst : IEnumerable<long>
{
public static readonly long[] Value=A197019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197019.Bytes);
public long this[int i]=>Value[i];

public static A197019Inst Instance=new A197019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197020
{
public static readonly long[] Value={ 4L,6L,1L,9L,2L,3L,1L,8L,7L,7L,0L,5L,2L,2L,8L,2L,3L,8L,2L,1L,7L,1L,5L,3L,0L,3L,3L,3L,6L,9L,3L,8L,9L,9L,9L,9L,6L,2L,0L,4L,3L,4L,7L,2L,6L,7L,0L,5L,6L,8L,8L,6L,5L,7L,9L,7L,6L,7L,0L,6L,4L,3L,0L,3L,7L,9L,5L,1L,1L,3L,9L,4L,1L,1L,5L,2L,5L,1L,1L,1L,6L,7L,9L,9L,7L,9L,8L,7L,4L,3L,0L,9L,9L,4L,4L,1L,5L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197020Inst : IEnumerable<long>
{
public static readonly long[] Value=A197020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197020.Bytes);
public long this[int i]=>Value[i];

public static A197020Inst Instance=new A197020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197021
{
public static readonly long[] Value={ 3L,7L,1L,8L,1L,1L,0L,4L,1L,7L,3L,6L,1L,7L,2L,1L,8L,4L,0L,1L,9L,5L,6L,4L,7L,3L,5L,1L,5L,8L,8L,5L,7L,9L,0L,2L,8L,9L,7L,0L,6L,2L,6L,3L,9L,2L,8L,8L,3L,6L,4L,8L,1L,7L,8L,7L,7L,3L,4L,1L,4L,7L,3L,3L,1L,8L,5L,2L,8L,8L,2L,0L,5L,1L,3L,1L,2L,7L,3L,1L,4L,2L,0L,5L,9L,8L,0L,8L,0L,0L,1L,2L,2L,6L,8L,5L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197021Inst : IEnumerable<long>
{
public static readonly long[] Value=A197021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197021.Bytes);
public long this[int i]=>Value[i];

public static A197021Inst Instance=new A197021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197022
{
public static readonly long[] Value={ 3L,0L,4L,6L,7L,5L,3L,6L,3L,3L,0L,6L,6L,0L,7L,4L,5L,2L,4L,0L,2L,1L,6L,8L,4L,3L,1L,6L,6L,7L,7L,5L,8L,1L,9L,5L,4L,8L,5L,6L,3L,6L,3L,6L,9L,6L,8L,1L,4L,2L,8L,7L,7L,9L,1L,0L,1L,1L,4L,9L,8L,1L,8L,4L,3L,6L,2L,9L,3L,8L,8L,3L,2L,7L,2L,6L,0L,2L,1L,7L,2L,3L,5L,2L,6L,2L,5L,4L,5L,3L,2L,3L,4L,0L,4L,7L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197022Inst : IEnumerable<long>
{
public static readonly long[] Value=A197022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197022.Bytes);
public long this[int i]=>Value[i];

public static A197022Inst Instance=new A197022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197023
{
public static readonly long[] Value={ 3L,9L,5L,8L,6L,2L,4L,3L,7L,8L,4L,7L,4L,8L,0L,7L,9L,8L,2L,4L,0L,7L,0L,7L,7L,2L,2L,5L,6L,6L,3L,1L,5L,5L,2L,7L,3L,3L,4L,3L,4L,3L,9L,2L,9L,2L,4L,9L,1L,0L,0L,0L,8L,2L,5L,0L,4L,4L,2L,7L,9L,6L,3L,2L,5L,1L,2L,6L,4L,4L,3L,7L,9L,1L,1L,1L,8L,8L,1L,3L,0L,8L,6L,6L,5L,3L,8L,4L,8L,9L,0L,0L,5L,9L,1L,5L,8L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197023Inst : IEnumerable<long>
{
public static readonly long[] Value=A197023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197023.Bytes);
public long this[int i]=>Value[i];

public static A197023Inst Instance=new A197023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197024
{
public static readonly long[] Value={ 2L,3L,4L,0L,0L,5L,1L,4L,0L,5L,9L,5L,1L,3L,7L,9L,0L,1L,7L,3L,4L,7L,2L,7L,6L,2L,3L,7L,6L,7L,2L,2L,9L,9L,6L,0L,6L,2L,0L,4L,5L,8L,8L,8L,6L,4L,7L,4L,9L,5L,1L,1L,9L,4L,1L,4L,4L,3L,8L,1L,0L,3L,3L,4L,0L,3L,0L,6L,3L,4L,2L,1L,9L,4L,1L,8L,8L,9L,9L,4L,7L,3L,6L,2L,2L,0L,5L,9L,8L,6L,0L,2L,2L,8L,6L,1L,5L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197024Inst : IEnumerable<long>
{
public static readonly long[] Value=A197024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197024.Bytes);
public long this[int i]=>Value[i];

public static A197024Inst Instance=new A197024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197025
{
public static readonly long[] Value={ 7L,0L,9L,9L,1L,4L,9L,2L,6L,8L,6L,0L,4L,3L,9L,9L,2L,1L,4L,0L,9L,5L,9L,3L,8L,8L,9L,1L,6L,2L,5L,5L,8L,8L,7L,3L,4L,8L,0L,0L,2L,9L,4L,2L,6L,7L,8L,4L,6L,5L,6L,6L,5L,4L,0L,4L,6L,9L,1L,2L,2L,1L,1L,0L,5L,0L,6L,6L,9L,0L,1L,8L,1L,5L,4L,2L,7L,7L,6L,0L,0L,7L,2L,4L,9L,1L,9L,4L,6L,5L,3L,3L,2L,0L,2L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197025Inst : IEnumerable<long>
{
public static readonly long[] Value=A197025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197025.Bytes);
public long this[int i]=>Value[i];

public static A197025Inst Instance=new A197025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197026
{
public static readonly long[] Value={ 4L,2L,7L,4L,3L,2L,4L,5L,1L,6L,9L,3L,5L,8L,5L,8L,2L,7L,1L,9L,2L,6L,8L,0L,2L,4L,1L,7L,9L,6L,1L,6L,4L,7L,2L,0L,3L,6L,8L,0L,0L,9L,4L,8L,2L,8L,2L,9L,0L,5L,0L,9L,5L,2L,2L,1L,7L,3L,9L,7L,4L,6L,3L,4L,1L,8L,3L,1L,9L,9L,8L,4L,8L,5L,3L,6L,3L,3L,8L,1L,6L,4L,3L,8L,6L,8L,1L,5L,0L,4L,5L,9L,7L,8L,4L,7L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197026Inst : IEnumerable<long>
{
public static readonly long[] Value=A197026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197026.Bytes);
public long this[int i]=>Value[i];

public static A197026Inst Instance=new A197026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197027
{
public static readonly long[] Value={ 1L,3L,2L,1L,1L,3L,7L,4L,7L,6L,5L,2L,2L,8L,5L,9L,7L,8L,2L,8L,0L,9L,0L,0L,9L,8L,4L,9L,5L,8L,2L,5L,1L,6L,2L,4L,4L,3L,1L,5L,6L,3L,7L,9L,7L,6L,8L,2L,7L,5L,4L,6L,2L,6L,4L,4L,3L,4L,6L,5L,0L,4L,2L,9L,9L,8L,3L,5L,8L,8L,3L,0L,0L,9L,6L,6L,5L,9L,9L,7L,7L,4L,3L,6L,5L,9L,4L,4L,1L,1L,3L,4L,6L,0L,4L,5L,4L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197027Inst : IEnumerable<long>
{
public static readonly long[] Value=A197027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197027.Bytes);
public long this[int i]=>Value[i];

public static A197027Inst Instance=new A197027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197028
{
public static readonly long[] Value={ 7L,3L,6L,6L,0L,6L,6L,3L,4L,1L,4L,7L,1L,5L,1L,8L,2L,4L,9L,9L,2L,0L,7L,8L,9L,0L,5L,0L,8L,2L,4L,5L,2L,0L,6L,4L,8L,2L,2L,7L,6L,0L,6L,3L,9L,9L,8L,3L,9L,0L,2L,7L,9L,1L,5L,0L,8L,1L,4L,8L,0L,8L,0L,6L,8L,3L,6L,8L,0L,1L,0L,5L,1L,2L,3L,8L,5L,3L,9L,8L,9L,0L,6L,3L,9L,4L,3L,6L,5L,7L,3L,0L,8L,0L,0L,9L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197028Inst : IEnumerable<long>
{
public static readonly long[] Value=A197028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197028.Bytes);
public long this[int i]=>Value[i];

public static A197028Inst Instance=new A197028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197029
{
public static readonly long[] Value={ 5L,0L,6L,0L,6L,4L,3L,3L,3L,2L,1L,6L,5L,2L,4L,5L,1L,0L,0L,5L,4L,6L,3L,7L,6L,2L,1L,7L,7L,3L,4L,7L,1L,4L,4L,1L,1L,6L,9L,4L,8L,7L,3L,8L,8L,6L,1L,8L,3L,2L,2L,7L,7L,3L,2L,8L,6L,6L,4L,0L,3L,6L,7L,1L,7L,8L,8L,6L,3L,1L,4L,2L,1L,9L,5L,5L,2L,2L,8L,4L,0L,9L,3L,3L,8L,4L,7L,3L,0L,0L,8L,5L,2L,6L,1L,4L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197029Inst : IEnumerable<long>
{
public static readonly long[] Value=A197029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197029.Bytes);
public long this[int i]=>Value[i];

public static A197029Inst Instance=new A197029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197030
{
public static readonly long[] Value={ 5L,0L,6L,0L,9L,5L,4L,6L,4L,3L,7L,5L,4L,8L,9L,2L,5L,1L,4L,6L,3L,0L,1L,2L,3L,8L,5L,0L,4L,5L,3L,0L,6L,4L,4L,0L,9L,0L,0L,3L,3L,8L,5L,3L,3L,1L,4L,6L,5L,4L,0L,1L,5L,6L,1L,9L,5L,4L,2L,7L,4L,3L,1L,2L,0L,2L,7L,4L,0L,1L,6L,0L,2L,7L,6L,2L,4L,5L,2L,8L,2L,5L,8L,5L,5L,3L,7L,3L,3L,6L,6L,2L,2L,9L,6L,3L,7L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197030Inst : IEnumerable<long>
{
public static readonly long[] Value=A197030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197030.Bytes);
public long this[int i]=>Value[i];

public static A197030Inst Instance=new A197030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197031
{
public static readonly long[] Value={ 3L,3L,9L,7L,3L,4L,6L,9L,5L,1L,0L,1L,7L,6L,9L,3L,4L,4L,1L,2L,7L,7L,9L,1L,3L,7L,5L,5L,5L,0L,1L,4L,1L,0L,7L,9L,0L,4L,8L,9L,4L,8L,3L,4L,8L,7L,5L,2L,7L,1L,7L,7L,6L,3L,8L,3L,9L,0L,1L,6L,2L,1L,4L,8L,3L,4L,9L,4L,4L,0L,2L,8L,9L,4L,5L,1L,6L,7L,8L,5L,1L,6L,6L,0L,9L,9L,1L,1L,3L,2L,6L,0L,6L,7L,1L,8L,4L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197031Inst : IEnumerable<long>
{
public static readonly long[] Value=A197031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197031.Bytes);
public long this[int i]=>Value[i];

public static A197031Inst Instance=new A197031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197032
{
public static readonly long[] Value={ 2L,3L,5L,3L,2L,0L,9L,9L,6L,4L,1L,9L,9L,3L,2L,4L,4L,2L,9L,4L,8L,3L,1L,0L,1L,3L,3L,2L,5L,7L,7L,3L,8L,8L,4L,5L,7L,2L,7L,0L,7L,0L,5L,6L,1L,3L,8L,5L,6L,8L,4L,6L,8L,2L,6L,8L,0L,6L,6L,9L,3L,0L,4L,2L,6L,5L,1L,5L,1L,8L,9L,7L,2L,3L,2L,2L,0L,9L,2L,0L,8L,5L,9L,1L,8L,1L,6L,4L,7L,0L,6L,9L,1L,1L,1L,6L,4L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197032Inst : IEnumerable<long>
{
public static readonly long[] Value=A197032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197032.Bytes);
public long this[int i]=>Value[i];

public static A197032Inst Instance=new A197032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197033
{
public static readonly long[] Value={ 1L,8L,4L,4L,2L,7L,1L,6L,8L,1L,7L,0L,0L,1L,7L,1L,8L,6L,4L,7L,7L,9L,9L,5L,7L,7L,4L,4L,2L,7L,3L,5L,7L,0L,2L,9L,8L,4L,1L,3L,4L,8L,7L,6L,3L,3L,8L,7L,7L,0L,9L,5L,0L,9L,1L,5L,7L,4L,7L,9L,4L,0L,1L,7L,8L,6L,4L,8L,7L,6L,8L,3L,4L,3L,8L,5L,3L,8L,8L,6L,1L,2L,4L,8L,5L,0L,6L,4L,4L,7L,0L,9L,9L,7L,5L,8L,1L,8L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197033Inst : IEnumerable<long>
{
public static readonly long[] Value=A197033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197033.Bytes);
public long this[int i]=>Value[i];

public static A197033Inst Instance=new A197033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197034
{
public static readonly long[] Value={ 3L,4L,7L,7L,9L,6L,7L,2L,4L,3L,0L,0L,9L,0L,1L,2L,4L,7L,4L,6L,4L,6L,9L,2L,5L,0L,8L,1L,3L,4L,2L,1L,7L,5L,1L,0L,1L,4L,4L,7L,5L,4L,9L,5L,5L,2L,7L,5L,8L,1L,9L,3L,4L,4L,4L,2L,3L,5L,9L,0L,9L,9L,3L,8L,6L,0L,4L,6L,0L,4L,0L,6L,3L,1L,9L,6L,0L,1L,1L,8L,7L,6L,9L,8L,4L,9L,7L,7L,5L,3L,6L,2L,6L,5L,5L,3L,0L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197034Inst : IEnumerable<long>
{
public static readonly long[] Value=A197034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197034.Bytes);
public long this[int i]=>Value[i];

public static A197034Inst Instance=new A197034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197035
{
public static readonly long[] Value={ 2L,6L,0L,8L,1L,9L,4L,0L,2L,4L,9L,6L,1L,0L,1L,8L,9L,0L,1L,9L,9L,0L,1L,4L,4L,5L,4L,2L,8L,3L,5L,2L,2L,3L,9L,5L,9L,0L,8L,3L,5L,8L,9L,1L,1L,5L,8L,7L,9L,5L,9L,7L,6L,7L,4L,4L,9L,4L,9L,1L,7L,7L,5L,6L,3L,8L,5L,7L,7L,4L,4L,9L,2L,8L,8L,4L,1L,8L,9L,9L,6L,8L,0L,3L,9L,1L,0L,4L,3L,1L,5L,5L,9L,0L,5L,1L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197035Inst : IEnumerable<long>
{
public static readonly long[] Value=A197035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197035.Bytes);
public long this[int i]=>Value[i];

public static A197035Inst Instance=new A197035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197036
{
public static readonly long[] Value={ 1L,2L,6L,6L,0L,6L,5L,8L,7L,7L,7L,5L,2L,0L,0L,8L,3L,3L,5L,5L,9L,8L,2L,4L,4L,6L,2L,5L,2L,1L,4L,7L,1L,7L,5L,3L,7L,6L,0L,7L,6L,7L,0L,3L,1L,1L,3L,5L,4L,9L,6L,2L,2L,0L,6L,8L,0L,8L,1L,3L,5L,3L,3L,1L,2L,1L,3L,5L,7L,5L,0L,1L,6L,1L,2L,2L,7L,7L,5L,4L,7L,0L,3L,9L,4L,8L,1L,8L,3L,5L,7L,1L,4L,7L,2L,8L,0L,1L,0L,1L,8L,7L,1L,0L,3L,6L,1L,3L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197036Inst : IEnumerable<long>
{
public static readonly long[] Value=A197036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197036.Bytes);
public long this[int i]=>Value[i];

public static A197036Inst Instance=new A197036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197037
{
public static readonly long[] Value={ 7L,1L,0L,2L,4L,3L,1L,8L,5L,9L,3L,7L,8L,9L,0L,8L,8L,8L,7L,3L,8L,5L,2L,6L,6L,7L,7L,8L,1L,1L,6L,5L,0L,7L,4L,4L,9L,4L,4L,4L,0L,9L,9L,5L,8L,3L,2L,9L,7L,0L,3L,1L,9L,8L,1L,2L,3L,0L,1L,5L,1L,6L,5L,5L,7L,3L,9L,6L,9L,1L,1L,5L,6L,8L,8L,2L,3L,8L,1L,8L,0L,9L,7L,7L,3L,5L,4L,0L,3L,9L,1L,5L,7L,9L,1L,1L,7L,2L,5L,8L,3L,3L,6L,3L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197037Inst : IEnumerable<long>
{
public static readonly long[] Value=A197037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197037.Bytes);
public long this[int i]=>Value[i];

public static A197037Inst Instance=new A197037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197038
{
public static readonly long[] Value={ 12L,412L,436L,916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197038Inst : IEnumerable<long>
{
public static readonly long[] Value=A197038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197038.Bytes);
public long this[int i]=>Value[i];

public static A197038Inst Instance=new A197038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197039
{
public static readonly long[] Value={ 1L,4L,9L,10L,12L,21L,22L,40L,48L,84L,88L,90L,100L,102L,120L,123L,126L,132L,162L,168L,186L,201L,202L,210L,213L,216L,220L,231L,261L,312L,321L,333L,400L,408L,480L,612L,618L,621L,681L,804L,808L,816L,840L,861L,880L,900L,1000L,1002L,1020L,1023L,1026L,1032L,1062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197039Inst : IEnumerable<long>
{
public static readonly long[] Value=A197039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197039.Bytes);
public long this[int i]=>Value[i];

public static A197039Inst Instance=new A197039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197040
{
public static readonly long[] Value={ 3L,8L,9L,8L,9L,9L,6L,9L,10L,8L,7L,9L,6L,8L,7L,8L,11L,6L,7L,8L,9L,8L,7L,6L,8L,10L,6L,6L,6L,8L,8L,8L,8L,9L,6L,9L,7L,6L,7L,8L,8L,9L,7L,11L,7L,8L,5L,9L,8L,9L,9L,7L,6L,7L,9L,6L,7L,9L,7L,8L,10L,5L,9L,7L,7L,7L,7L,6L,9L,9L,6L,8L,7L,9L,8L,6L,9L,5L,9L,9L,8L,6L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197040Inst : IEnumerable<long>
{
public static readonly long[] Value=A197040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197040.Bytes);
public long this[int i]=>Value[i];

public static A197040Inst Instance=new A197040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197041
{
public static readonly long[] Value={ 1L,7L,120L,7407L,1563352L,1146653592L,2887590375825L,24713390632082079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197041Inst : IEnumerable<long>
{
public static readonly long[] Value=A197041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197041.Bytes);
public long this[int i]=>Value[i];

public static A197041Inst Instance=new A197041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197042
{
public static readonly long[] Value={ 2L,20L,120L,698L,4080L,24074L,141856L,833758L,4909544L,28899922L,170120402L,1001361542L,5894102732L,34694985108L,204224876622L,1202124327402L,7076038423114L,41651567268298L,245173129915012L,1443158678807678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197042Inst : IEnumerable<long>
{
public static readonly long[] Value=A197042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197042.Bytes);
public long this[int i]=>Value[i];

public static A197042Inst Instance=new A197042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197043
{
public static readonly long[] Value={ 3L,65L,698L,7407L,79785L,855746L,9248339L,99900759L,1077578216L,11625151797L,125460417513L,1353828298540L,14607942448781L,157629746459857L,1700936665665566L,18354053399564603L,198051140064611759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197043Inst : IEnumerable<long>
{
public static readonly long[] Value=A197043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197043.Bytes);
public long this[int i]=>Value[i];

public static A197043Inst Instance=new A197043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197044
{
public static readonly BigInteger[] Value={ 5L,203L,4080L,79785L,1563352L,31096170L,621506173L,12367566377L,246209727883L,4904183446578L,97655063600656L,1944656969992804L,38726607687532464L,771192417913040813L,15357390085688256362UL,BigInteger.Parse("305826177600042178901") };
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
public class A197044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197044Inst Instance=new A197044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197045
{
public static readonly BigInteger[] Value={ 8L,648L,24074L,855746L,31096170L,1146653592L,42346212260L,1557004531014L,57353100417462L,2112382332611192L,77779202686257778L,2864298209626136384L,BigInteger.Parse("105477500014169550206"),BigInteger.Parse("3884216011047782491710"),BigInteger.Parse("143037133564177615552516") };
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
public class A197045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197045Inst Instance=new A197045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197046
{
public static readonly BigInteger[] Value={ 13L,2057L,141856L,9248339L,621506173L,42346212260L,2887590375825L,196473830384459L,13380873189121311L,910764986424304753L,BigInteger.Parse("61996774523408648312"),BigInteger.Parse("4220890096247905089568"),BigInteger.Parse("287338357690684994223092") };
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
public class A197046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197046Inst Instance=new A197046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197047
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,20L,20L,3L,5L,65L,120L,65L,5L,8L,203L,698L,698L,203L,8L,13L,648L,4080L,7407L,4080L,648L,13L,21L,2057L,24074L,79785L,79785L,24074L,2057L,21L,34L,6527L,141856L,855746L,1563352L,855746L,141856L,6527L,34L,55L,20740L,833758L,9248339L,31096170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197047Inst : IEnumerable<long>
{
public static readonly long[] Value=A197047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197047.Bytes);
public long this[int i]=>Value[i];

public static A197047Inst Instance=new A197047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197048
{
public static readonly long[] Value={ 1L,2L,10L,42L,358L,4468L,88056L,2745186L,134355866L,10264692132L,1234801357470L,232966546265096L,68939282741912248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197048Inst : IEnumerable<long>
{
public static readonly long[] Value=A197048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197048.Bytes);
public long this[int i]=>Value[i];

public static A197048Inst Instance=new A197048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197049
{
public static readonly long[] Value={ 2L,4L,10L,18L,38L,78L,156L,320L,654L,1326L,2706L,5518L,11228L,22884L,46634L,94978L,193518L,394286L,803220L,1636448L,3334030L,6792334L,13838202L,28192958L,57437684L,117018884L,238404906L,485705682L,989536598L,2016000430L,4107230284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197049Inst : IEnumerable<long>
{
public static readonly long[] Value=A197049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197049.Bytes);
public long this[int i]=>Value[i];

public static A197049Inst Instance=new A197049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197050
{
public static readonly long[] Value={ 3L,6L,18L,42L,108L,274L,692L,1754L,4442L,11248L,28488L,72146L,182712L,462728L,1171876L,2967826L,7516146L,19034954L,48206826L,122085820L,309187486L,783030352L,1983057390L,5022176478L,12718873752L,32211084212L,81575929322L,206594481604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197050Inst : IEnumerable<long>
{
public static readonly long[] Value=A197050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197050.Bytes);
public long this[int i]=>Value[i];

public static A197050Inst Instance=new A197050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197051
{
public static readonly long[] Value={ 4L,10L,38L,108L,358L,1132L,3580L,11382L,36270L,114992L,365628L,1162290L,3692624L,11733828L,37293892L,118504546L,376583590L,1196750110L,3803034578L,12085297922L,38405269512L,122045123484L,387837623386L,1232482503260L,3916616317912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197051Inst : IEnumerable<long>
{
public static readonly long[] Value=A197051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197051.Bytes);
public long this[int i]=>Value[i];

public static A197051Inst Instance=new A197051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197052
{
public static readonly long[] Value={ 5L,16L,78L,274L,1132L,4468L,17742L,70616L,281202L,1117442L,4448148L,17693664L,70390082L,280040518L,1114106280L,4432207738L,17633023628L,70149839190L,279079644000L,1110273409628L,4417041071578L,17572471614384L,69909222737482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197052Inst : IEnumerable<long>
{
public static readonly long[] Value=A197052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197052.Bytes);
public long this[int i]=>Value[i];

public static A197052Inst Instance=new A197052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197053
{
public static readonly long[] Value={ 7L,26L,156L,692L,3580L,17742L,88056L,439338L,2192602L,10912392L,54394628L,271160024L,1351103246L,6733077562L,33557756016L,167232569172L,833404135538L,4153405692526L,20698773896328L,103153449929238L,514074952403758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197053Inst : IEnumerable<long>
{
public static readonly long[] Value=A197053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197053.Bytes);
public long this[int i]=>Value[i];

public static A197053Inst Instance=new A197053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197054
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,3L,4L,4L,3L,4L,6L,10L,6L,4L,5L,10L,18L,18L,10L,5L,7L,16L,38L,42L,38L,16L,7L,9L,26L,78L,108L,108L,78L,26L,9L,12L,42L,156L,274L,358L,274L,156L,42L,12L,16L,68L,320L,692L,1132L,1132L,692L,320L,68L,16L,21L,110L,654L,1754L,3580L,4468L,3580L,1754L,654L,110L,21L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197054Inst : IEnumerable<long>
{
public static readonly long[] Value=A197054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197054.Bytes);
public long this[int i]=>Value[i];

public static A197054Inst Instance=new A197054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197055
{
public static readonly long[] Value={ 1L,2L,6L,18L,48L,211L,1685L,17107L,194842L,2735810L,54757712L,1541398741L,56647655849L,2661035439470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197055Inst : IEnumerable<long>
{
public static readonly long[] Value=A197055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197055.Bytes);
public long this[int i]=>Value[i];

public static A197055Inst Instance=new A197055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197056
{
public static readonly long[] Value={ 1L,3L,6L,10L,14L,22L,38L,67L,111L,179L,291L,485L,812L,1348L,2220L,3660L,6060L,10053L,16653L,27541L,45541L,75367L,124786L,206574L,341850L,565666L,936146L,1549447L,2564507L,4244263L,7024071L,11624777L,19239384L,31841864L,52698776L,87216664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197056Inst : IEnumerable<long>
{
public static readonly long[] Value=A197056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197056.Bytes);
public long this[int i]=>Value[i];

public static A197056Inst Instance=new A197056Inst();

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