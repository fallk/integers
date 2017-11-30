using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A009885
{
public static readonly long[] Value={ 1L,4L,9L,19L,39L,59L,78L,117L,155L,189L,235L,288L,330L,407L,463L,524L,588L,695L,768L,839L,946L,1036L,1131L,1260L,1347L,1490L,1568L,1718L,1881L,1982L,2095L,2242L,2434L,2581L,2675L,2947L,2992L,3266L,3454L,3540L,3800L,3929L,4117L,4430L,4515L,4772L,4934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009885Inst : IEnumerable<long>
{
public static readonly long[] Value=A009885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009885.Bytes);
public long this[int i]=>Value[i];

public static A009885Inst Instance=new A009885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009966
{
public static readonly BigInteger[] Value={ 1L,22L,484L,10648L,234256L,5153632L,113379904L,2494357888L,54875873536L,1207269217792L,26559922791424L,584318301411328L,12855002631049216L,282810057883082752L,6221821273427820544L,BigInteger.Parse("136880068015412051968"),BigInteger.Parse("3011361496339065143296"),BigInteger.Parse("66249952919459433152512"),BigInteger.Parse("1457498964228107529355264"),BigInteger.Parse("32064977213018365645815808"),BigInteger.Parse("705429498686404044207947776") };
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
public class A009966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009966Inst Instance=new A009966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009967
{
public static readonly BigInteger[] Value={ 1L,23L,529L,12167L,279841L,6436343L,148035889L,3404825447L,78310985281L,1801152661463L,41426511213649L,952809757913927L,21914624432020321L,504036361936467383L,11592836324538749809UL,BigInteger.Parse("266635235464391245607"),BigInteger.Parse("6132610415680998648961"),BigInteger.Parse("141050039560662968926103"),BigInteger.Parse("3244150909895248285300369"),BigInteger.Parse("74615470927590710561908487"),BigInteger.Parse("1716155831334586342923895201") };
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
public class A009967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009967Inst Instance=new A009967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009968
{
public static readonly BigInteger[] Value={ 1L,24L,576L,13824L,331776L,7962624L,191102976L,4586471424L,110075314176L,2641807540224L,63403380965376L,1521681143169024L,36520347436056576L,876488338465357824L,BigInteger.Parse("21035720123168587776"),BigInteger.Parse("504857282956046106624"),BigInteger.Parse("12116574790945106558976"),BigInteger.Parse("290797794982682557415424"),BigInteger.Parse("6979147079584381377970176"),BigInteger.Parse("167499529910025153071284224"),BigInteger.Parse("4019988717840603673710821376") };
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
public class A009968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009968Inst Instance=new A009968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009969
{
public static readonly BigInteger[] Value={ 1L,25L,625L,15625L,390625L,9765625L,244140625L,6103515625L,152587890625L,3814697265625L,95367431640625L,2384185791015625L,59604644775390625L,1490116119384765625L,BigInteger.Parse("37252902984619140625"),BigInteger.Parse("931322574615478515625"),BigInteger.Parse("23283064365386962890625"),BigInteger.Parse("582076609134674072265625"),BigInteger.Parse("14551915228366851806640625"),BigInteger.Parse("363797880709171295166015625"),BigInteger.Parse("9094947017729282379150390625") };
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
public class A009969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009969Inst Instance=new A009969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009970
{
public static readonly BigInteger[] Value={ 1L,26L,676L,17576L,456976L,11881376L,308915776L,8031810176L,208827064576L,5429503678976L,141167095653376L,3670344486987776L,95428956661682176L,2481152873203736576L,BigInteger.Parse("64509974703297150976"),BigInteger.Parse("1677259342285725925376"),BigInteger.Parse("43608742899428874059776"),BigInteger.Parse("1133827315385150725554176"),BigInteger.Parse("29479510200013918864408576"),BigInteger.Parse("766467265200361890474622976"),BigInteger.Parse("19928148895209409152340197376") };
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
public class A009970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009970Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009970.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009970Inst Instance=new A009970Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009971
{
public static readonly BigInteger[] Value={ 1L,27L,729L,19683L,531441L,14348907L,387420489L,10460353203L,282429536481L,7625597484987L,205891132094649L,5559060566555523L,150094635296999121L,4052555153018976267L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("2954312706550833698643") };
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
public class A009971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009971Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009971.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009971Inst Instance=new A009971Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009972
{
public static readonly BigInteger[] Value={ 1L,28L,784L,21952L,614656L,17210368L,481890304L,13492928512L,377801998336L,10578455953408L,296196766695424L,8293509467471872L,232218265089212416L,6502111422497947648L,BigInteger.Parse("182059119829942534144"),BigInteger.Parse("5097655355238390956032") };
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
public class A009972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009972Inst Instance=new A009972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009973
{
public static readonly BigInteger[] Value={ 1L,29L,841L,24389L,707281L,20511149L,594823321L,17249876309L,500246412961L,14507145975869L,420707233300201L,12200509765705829L,353814783205469041L,10260628712958602189UL,BigInteger.Parse("297558232675799463481"),BigInteger.Parse("8629188747598184440949") };
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
public class A009973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009973Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009973.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009973Inst Instance=new A009973Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009974
{
public static readonly BigInteger[] Value={ 1L,30L,900L,27000L,810000L,24300000L,729000000L,21870000000L,656100000000L,19683000000000L,590490000000000L,17714700000000000L,531441000000000000L,15943230000000000000UL,BigInteger.Parse("478296900000000000000"),BigInteger.Parse("14348907000000000000000") };
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
public class A009974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009974Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009974.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009974Inst Instance=new A009974Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009975
{
public static readonly BigInteger[] Value={ 1L,31L,961L,29791L,923521L,28629151L,887503681L,27512614111L,852891037441L,26439622160671L,819628286980801L,25408476896404831L,787662783788549761L,BigInteger.Parse("24417546297445042591"),BigInteger.Parse("756943935220796320321"),BigInteger.Parse("23465261991844685929951") };
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
public class A009975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009975Inst Instance=new A009975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009976
{
public static readonly BigInteger[] Value={ 1L,32L,1024L,32768L,1048576L,33554432L,1073741824L,34359738368L,1099511627776L,35184372088832L,1125899906842624L,36028797018963968L,1152921504606846976L,BigInteger.Parse("36893488147419103232"),BigInteger.Parse("1180591620717411303424") };
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
public class A009976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009976Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009976.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009976Inst Instance=new A009976Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009977
{
public static readonly BigInteger[] Value={ 1L,33L,1089L,35937L,1185921L,39135393L,1291467969L,42618442977L,1406408618241L,46411484401953L,1531578985264449L,50542106513726817L,1667889514952984961L,BigInteger.Parse("55040353993448503713"),BigInteger.Parse("1816331681783800622529") };
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
public class A009977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009977Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009977.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009977Inst Instance=new A009977Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009978
{
public static readonly BigInteger[] Value={ 1L,34L,1156L,39304L,1336336L,45435424L,1544804416L,52523350144L,1785793904896L,60716992766464L,2064377754059776L,70188843638032384L,2386420683693101056L,BigInteger.Parse("81138303245565435904"),BigInteger.Parse("2758702310349224820736") };
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
public class A009978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009978Inst Instance=new A009978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009979
{
public static readonly BigInteger[] Value={ 1L,35L,1225L,42875L,1500625L,52521875L,1838265625L,64339296875L,2251875390625L,78815638671875L,2758547353515625L,96549157373046875L,3379220508056640625L,BigInteger.Parse("118272717781982421875"),BigInteger.Parse("4139545122369384765625") };
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
public class A009979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009979Inst Instance=new A009979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009980
{
public static readonly BigInteger[] Value={ 1L,36L,1296L,46656L,1679616L,60466176L,2176782336L,78364164096L,2821109907456L,101559956668416L,3656158440062976L,131621703842267136L,4738381338321616896L,BigInteger.Parse("170581728179578208256"),BigInteger.Parse("6140942214464815497216") };
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
public class A009980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009980Inst Instance=new A009980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009981
{
public static readonly BigInteger[] Value={ 1L,37L,1369L,50653L,1874161L,69343957L,2565726409L,94931877133L,3512479453921L,129961739795077L,4808584372417849L,177917621779460413L,6582952005840035281L,BigInteger.Parse("243569224216081305397"),BigInteger.Parse("9012061295995008299689") };
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
public class A009981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009981Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009981.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009981Inst Instance=new A009981Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009998
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,3L,1L,1L,8L,9L,4L,1L,1L,16L,27L,16L,5L,1L,1L,32L,81L,64L,25L,6L,1L,1L,64L,243L,256L,125L,36L,7L,1L,1L,128L,729L,1024L,625L,216L,49L,8L,1L,1L,256L,2187L,4096L,3125L,1296L,343L,64L,9L,1L,1L,512L,6561L,16384L,15625L,7776L,2401L,512L,81L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009998Inst : IEnumerable<long>
{
public static readonly long[] Value=A009998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009998.Bytes);
public long this[int i]=>Value[i];

public static A009998Inst Instance=new A009998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009999
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,9L,8L,1L,1L,5L,16L,27L,16L,1L,1L,6L,25L,64L,81L,32L,1L,1L,7L,36L,125L,256L,243L,64L,1L,1L,8L,49L,216L,625L,1024L,729L,128L,1L,1L,9L,64L,343L,1296L,3125L,4096L,2187L,256L,1L,1L,10L,81L,512L,2401L,7776L,15625L,16384L,6561L,512L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009999Inst : IEnumerable<long>
{
public static readonly long[] Value=A009999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009999.Bytes);
public long this[int i]=>Value[i];

public static A009999Inst Instance=new A009999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010000
{
public static readonly long[] Value={ 1L,3L,6L,11L,18L,27L,38L,51L,66L,83L,102L,123L,146L,171L,198L,227L,258L,291L,326L,363L,402L,443L,486L,531L,578L,627L,678L,731L,786L,843L,902L,963L,1026L,1091L,1158L,1227L,1298L,1371L,1446L,1523L,1602L,1683L,1766L,1851L,1938L,2027L,2118L,2211L,2306L,2403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010000Inst : IEnumerable<long>
{
public static readonly long[] Value=A010000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010000.Bytes);
public long this[int i]=>Value[i];

public static A010000Inst Instance=new A010000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010001
{
public static readonly long[] Value={ 1L,7L,22L,47L,82L,127L,182L,247L,322L,407L,502L,607L,722L,847L,982L,1127L,1282L,1447L,1622L,1807L,2002L,2207L,2422L,2647L,2882L,3127L,3382L,3647L,3922L,4207L,4502L,4807L,5122L,5447L,5782L,6127L,6482L,6847L,7222L,7607L,8002L,8407L,8822L,9247L,9682L,10127L,10582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010001Inst : IEnumerable<long>
{
public static readonly long[] Value=A010001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010001.Bytes);
public long this[int i]=>Value[i];

public static A010001Inst Instance=new A010001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010002
{
public static readonly long[] Value={ 1L,11L,38L,83L,146L,227L,326L,443L,578L,731L,902L,1091L,1298L,1523L,1766L,2027L,2306L,2603L,2918L,3251L,3602L,3971L,4358L,4763L,5186L,5627L,6086L,6563L,7058L,7571L,8102L,8651L,9218L,9803L,10406L,11027L,11666L,12323L,12998L,13691L,14402L,15131L,15878L,16643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010002Inst : IEnumerable<long>
{
public static readonly long[] Value=A010002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010002.Bytes);
public long this[int i]=>Value[i];

public static A010002Inst Instance=new A010002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010003
{
public static readonly long[] Value={ 1L,13L,46L,101L,178L,277L,398L,541L,706L,893L,1102L,1333L,1586L,1861L,2158L,2477L,2818L,3181L,3566L,3973L,4402L,4853L,5326L,5821L,6338L,6877L,7438L,8021L,8626L,9253L,9902L,10573L,11266L,11981L,12718L,13477L,14258L,15061L,15886L,16733L,17602L,18493L,19406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010003Inst : IEnumerable<long>
{
public static readonly long[] Value=A010003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010003.Bytes);
public long this[int i]=>Value[i];

public static A010003Inst Instance=new A010003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010004
{
public static readonly long[] Value={ 1L,15L,54L,119L,210L,327L,470L,639L,834L,1055L,1302L,1575L,1874L,2199L,2550L,2927L,3330L,3759L,4214L,4695L,5202L,5735L,6294L,6879L,7490L,8127L,8790L,9479L,10194L,10935L,11702L,12495L,13314L,14159L,15030L,15927L,16850L,17799L,18774L,19775L,20802L,21855L,22934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010004Inst : IEnumerable<long>
{
public static readonly long[] Value=A010004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010004.Bytes);
public long this[int i]=>Value[i];

public static A010004Inst Instance=new A010004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010005
{
public static readonly long[] Value={ 1L,17L,62L,137L,242L,377L,542L,737L,962L,1217L,1502L,1817L,2162L,2537L,2942L,3377L,3842L,4337L,4862L,5417L,6002L,6617L,7262L,7937L,8642L,9377L,10142L,10937L,11762L,12617L,13502L,14417L,15362L,16337L,17342L,18377L,19442L,20537L,21662L,22817L,24002L,25217L,26462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010005Inst : IEnumerable<long>
{
public static readonly long[] Value=A010005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010005.Bytes);
public long this[int i]=>Value[i];

public static A010005Inst Instance=new A010005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010006
{
public static readonly long[] Value={ 1L,18L,66L,146L,258L,402L,578L,786L,1026L,1298L,1602L,1938L,2306L,2706L,3138L,3602L,4098L,4626L,5186L,5778L,6402L,7058L,7746L,8466L,9218L,10002L,10818L,11666L,12546L,13458L,14402L,15378L,16386L,17426L,18498L,19602L,20738L,21906L,23106L,24338L,25602L,26898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010006Inst : IEnumerable<long>
{
public static readonly long[] Value=A010006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010006.Bytes);
public long this[int i]=>Value[i];

public static A010006Inst Instance=new A010006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010007
{
public static readonly long[] Value={ 1L,19L,70L,155L,274L,427L,614L,835L,1090L,1379L,1702L,2059L,2450L,2875L,3334L,3827L,4354L,4915L,5510L,6139L,6802L,7499L,8230L,8995L,9794L,10627L,11494L,12395L,13330L,14299L,15302L,16339L,17410L,18515L,19654L,20827L,22034L,23275L,24550L,25859L,27202L,28579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010007Inst : IEnumerable<long>
{
public static readonly long[] Value=A010007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010007.Bytes);
public long this[int i]=>Value[i];

public static A010007Inst Instance=new A010007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010008
{
public static readonly long[] Value={ 1L,20L,74L,164L,290L,452L,650L,884L,1154L,1460L,1802L,2180L,2594L,3044L,3530L,4052L,4610L,5204L,5834L,6500L,7202L,7940L,8714L,9524L,10370L,11252L,12170L,13124L,14114L,15140L,16202L,17300L,18434L,19604L,20810L,22052L,23330L,24644L,25994L,27380L,28802L,30260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010008Inst : IEnumerable<long>
{
public static readonly long[] Value=A010008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010008.Bytes);
public long this[int i]=>Value[i];

public static A010008Inst Instance=new A010008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010009
{
public static readonly long[] Value={ 1L,21L,78L,173L,306L,477L,686L,933L,1218L,1541L,1902L,2301L,2738L,3213L,3726L,4277L,4866L,5493L,6158L,6861L,7602L,8381L,9198L,10053L,10946L,11877L,12846L,13853L,14898L,15981L,17102L,18261L,19458L,20693L,21966L,23277L,24626L,26013L,27438L,28901L,30402L,31941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010009Inst : IEnumerable<long>
{
public static readonly long[] Value=A010009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010009.Bytes);
public long this[int i]=>Value[i];

public static A010009Inst Instance=new A010009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010010
{
public static readonly long[] Value={ 1L,22L,82L,182L,322L,502L,722L,982L,1282L,1622L,2002L,2422L,2882L,3382L,3922L,4502L,5122L,5782L,6482L,7222L,8002L,8822L,9682L,10582L,11522L,12502L,13522L,14582L,15682L,16822L,18002L,19222L,20482L,21782L,23122L,24502L,25922L,27382L,28882L,30422L,32002L,33622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010010Inst : IEnumerable<long>
{
public static readonly long[] Value=A010010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010010.Bytes);
public long this[int i]=>Value[i];

public static A010010Inst Instance=new A010010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010011
{
public static readonly long[] Value={ 1L,23L,86L,191L,338L,527L,758L,1031L,1346L,1703L,2102L,2543L,3026L,3551L,4118L,4727L,5378L,6071L,6806L,7583L,8402L,9263L,10166L,11111L,12098L,13127L,14198L,15311L,16466L,17663L,18902L,20183L,21506L,22871L,24278L,25727L,27218L,28751L,30326L,31943L,33602L,35303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010011Inst : IEnumerable<long>
{
public static readonly long[] Value=A010011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010011.Bytes);
public long this[int i]=>Value[i];

public static A010011Inst Instance=new A010011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010012
{
public static readonly long[] Value={ 1L,24L,90L,200L,354L,552L,794L,1080L,1410L,1784L,2202L,2664L,3170L,3720L,4314L,4952L,5634L,6360L,7130L,7944L,8802L,9704L,10650L,11640L,12674L,13752L,14874L,16040L,17250L,18504L,19802L,21144L,22530L,23960L,25434L,26952L,28514L,30120L,31770L,33464L,35202L,36984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010012Inst : IEnumerable<long>
{
public static readonly long[] Value=A010012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010012.Bytes);
public long this[int i]=>Value[i];

public static A010012Inst Instance=new A010012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010013
{
public static readonly long[] Value={ 1L,25L,94L,209L,370L,577L,830L,1129L,1474L,1865L,2302L,2785L,3314L,3889L,4510L,5177L,5890L,6649L,7454L,8305L,9202L,10145L,11134L,12169L,13250L,14377L,15550L,16769L,18034L,19345L,20702L,22105L,23554L,25049L,26590L,28177L,29810L,31489L,33214L,34985L,36802L,38665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010013Inst : IEnumerable<long>
{
public static readonly long[] Value=A010013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010013.Bytes);
public long this[int i]=>Value[i];

public static A010013Inst Instance=new A010013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010030
{
public static readonly long[] Value={ 1L,1L,0L,3L,0L,3L,8L,1L,25L,28L,7L,17L,155L,143L,45L,259L,1005L,933L,323L,131L,2770L,7488L,7150L,2621L,3177L,27978L,64164L,62310L,23811L,1281L,51433L,294602L,619986L,607445L,239653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010030Inst : IEnumerable<long>
{
public static readonly long[] Value=A010030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010030.Bytes);
public long this[int i]=>Value[i];

public static A010030Inst Instance=new A010030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010031
{
public static readonly long[] Value={ 1L,0L,620L,13888L,36518L,13888L,620L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010031Inst : IEnumerable<long>
{
public static readonly long[] Value=A010031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010031.Bytes);
public long this[int i]=>Value[i];

public static A010031Inst Instance=new A010031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010032
{
public static readonly long[] Value={ 1L,0L,0L,112L,30L,112L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010032Inst : IEnumerable<long>
{
public static readonly long[] Value=A010032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010032.Bytes);
public long this[int i]=>Value[i];

public static A010032Inst Instance=new A010032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010033
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,20L,36L,66L,121L,223L,415L,774L,1452L,2724L,5133L,9695L,18358L,34867L,66320L,126499L,241563L,462479L,886150L,1707353L,3270338L,6295073L,12133953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010033Inst : IEnumerable<long>
{
public static readonly long[] Value=A010033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010033.Bytes);
public long this[int i]=>Value[i];

public static A010033Inst Instance=new A010033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010034
{
public static readonly BigInteger[] Value={ BigInteger.Parse("8424432925592889329288197322308900672459420460792433"),BigInteger.Parse("17361015163508605989239159575667846308252873717727992"),BigInteger.Parse("26297597401424322649190121829026791944046326974663551") };
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
public class A010034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010034Inst Instance=new A010034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010035
{
public static readonly BigInteger[] Value={ 1L,15L,153L,1431L,13041L,117855L,1062153L,9563751L,86086881L,774821295L,6973509753L,62761942071L,564858541521L,5083730062335L,45753580126953L,411782249840391L,3706040334656961L,33354363270192975L,300189270206577753L,2701703434183722711L,BigInteger.Parse("24315330914627073201") };
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
public class A010035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010035Inst Instance=new A010035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010036
{
public static readonly long[] Value={ 1L,5L,22L,92L,376L,1520L,6112L,24512L,98176L,392960L,1572352L,6290432L,25163776L,100659200L,402644992L,1610596352L,6442418176L,25769738240L,103079084032L,412316598272L,1649266917376L,6597068718080L,26388276969472L,105553112072192L,422212456677376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010036Inst : IEnumerable<long>
{
public static readonly long[] Value=A010036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010036.Bytes);
public long this[int i]=>Value[i];

public static A010036Inst Instance=new A010036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010037
{
public static readonly long[] Value={ 533360L,2502111L,4470862L,6439613L,8408364L,10377115L,12345866L,14314617L,16283368L,18252119L,20220870L,22189621L,24158372L,26127123L,28095874L,30064625L,32033376L,34002127L,35970878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010037Inst : IEnumerable<long>
{
public static readonly long[] Value=A010037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010037.Bytes);
public long this[int i]=>Value[i];

public static A010037Inst Instance=new A010037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010038
{
public static readonly long[] Value={ 5L,3L,3L,5L,3L,4L,4L,3L,5L,5L,8L,7L,7L,7L,7L,8L,8L,7L,10L,6L,11L,9L,9L,11L,9L,10L,10L,9L,11L,6L,11L,9L,9L,11L,9L,10L,10L,9L,11L,8L,13L,11L,11L,13L,11L,12L,12L,11L,13L,7L,12L,10L,10L,12L,10L,11L,11L,10L,12L,7L,12L,10L,10L,12L,10L,11L,11L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010038Inst : IEnumerable<long>
{
public static readonly long[] Value=A010038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010038.Bytes);
public long this[int i]=>Value[i];

public static A010038Inst Instance=new A010038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010039
{
public static readonly long[] Value={ 1L,4L,24L,208L,2208L,28864L,440064L,7752448L,153604608L,3398247424L,82812002304L,2208100261888L,63835179614208L,1991789102301184L,66630050985836544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010039Inst : IEnumerable<long>
{
public static readonly long[] Value=A010039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010039.Bytes);
public long this[int i]=>Value[i];

public static A010039Inst Instance=new A010039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010040
{
public static readonly BigInteger[] Value={ 1L,6L,60L,888L,16944L,403296L,11342400L,371718528L,13814409984L,577113570816L,26660675466240L,1354001083680768L,74774085533159424L,4471493494982516736L,BigInteger.Parse("287295290091420794880") };
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
public class A010040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010040Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010040.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010040Inst Instance=new A010040Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010041
{
public static readonly BigInteger[] Value={ 1L,8L,112L,2336L,63808L,2177408L,88532992L,4198893056L,226756461568L,13774782507008L,927722457014272L,68724458864869376L,5545864378385072128L,BigInteger.Parse("484804579241630302208"),BigInteger.Parse("45594217495265300119552") };
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
public class A010041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010041Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010041.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010041Inst Instance=new A010041Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010042
{
public static readonly long[] Value={ 0L,4L,64L,976L,16384L,305344L,6313984L,143915776L,3592290304L,97533174784L,2863801237504L,90450422603776L,3058671365914624L,110277389360103424L,4223330682610253824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010042Inst : IEnumerable<long>
{
public static readonly long[] Value=A010042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010042.Bytes);
public long this[int i]=>Value[i];

public static A010042Inst Instance=new A010042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010043
{
public static readonly BigInteger[] Value={ 0L,6L,144L,3480L,95616L,2995296L,106308864L,4224923520L,186254217216L,9025003101696L,477123118608384L,27334467671746560L,1687499455653052416L,BigInteger.Parse("111689161007888080896"),BigInteger.Parse("7890849624188124463104") };
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
public class A010043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010043Inst Instance=new A010043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010044
{
public static readonly BigInteger[] Value={ 0L,8L,256L,8480L,323584L,14219648L,712769536L,40231339520L,2529742618624L,175465112250368L,13316649656713216L,1097902932846018560L,BigInteger.Parse("97741786751619825664"),BigInteger.Parse("9345711964094187634688"),BigInteger.Parse("955350654371934426628096") };
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
public class A010044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010044Inst Instance=new A010044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010045
{
public static readonly BigInteger[] Value={ 2L,32L,528L,9728L,197568L,4424192L,108461568L,2895515648L,83657776128L,2602257293312L,86733041246208L,3084465770528768L,116595295651135488L,4668952802696364032L,BigInteger.Parse("197452751427562242048") };
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
public class A010045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010045Inst Instance=new A010045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010062
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,12L,14L,17L,19L,22L,25L,28L,31L,36L,38L,41L,44L,47L,52L,55L,60L,64L,65L,67L,70L,73L,76L,79L,84L,87L,92L,96L,98L,101L,105L,109L,114L,118L,123L,129L,131L,134L,137L,140L,143L,148L,151L,156L,160L,162L,165L,169L,173L,178L,182L,187L,193L,196L,199L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010062Inst : IEnumerable<long>
{
public static readonly long[] Value=A010062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010062.Bytes);
public long this[int i]=>Value[i];

public static A010062Inst Instance=new A010062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010063
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,14L,18L,20L,24L,28L,30L,32L,36L,38L,42L,46L,50L,56L,60L,64L,68L,74L,80L,88L,92L,96L,100L,104L,110L,114L,118L,122L,128L,134L,142L,148L,154L,160L,168L,172L,176L,182L,188L,196L,202L,208L,214L,222L,228L,234L,240L,248L,252L,254L,258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010063Inst : IEnumerable<long>
{
public static readonly long[] Value=A010063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010063.Bytes);
public long this[int i]=>Value[i];

public static A010063Inst Instance=new A010063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010064
{
public static readonly long[] Value={ 1L,3L,8L,13L,18L,20L,25L,30L,35L,37L,42L,47L,52L,54L,59L,64L,73L,78L,83L,85L,90L,95L,100L,102L,107L,112L,117L,119L,124L,129L,138L,143L,148L,150L,155L,160L,165L,167L,172L,177L,182L,184L,189L,194L,203L,208L,213L,215L,220L,225L,230L,232L,237L,242L,247L,249L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010064Inst : IEnumerable<long>
{
public static readonly long[] Value=A010064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010064.Bytes);
public long this[int i]=>Value[i];

public static A010064Inst Instance=new A010064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010065
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,11L,16L,17L,19L,23L,28L,32L,34L,38L,43L,50L,55L,62L,70L,74L,79L,86L,91L,98L,103L,110L,118L,125L,133L,137L,142L,149L,154L,161L,166L,173L,181L,188L,196L,200L,205L,212L,217L,224L,229L,236L,244L,251L,262L,266L,271L,278L,283L,290L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010065Inst : IEnumerable<long>
{
public static readonly long[] Value=A010065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010065.Bytes);
public long this[int i]=>Value[i];

public static A010065Inst Instance=new A010065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010066
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,20L,24L,32L,36L,40L,44L,52L,56L,60L,64L,72L,80L,84L,92L,100L,104L,112L,120L,128L,132L,136L,140L,144L,152L,156L,160L,164L,172L,180L,184L,192L,200L,204L,212L,220L,228L,236L,244L,256L,260L,264L,272L,280L,284L,292L,300L,304L,312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010066Inst : IEnumerable<long>
{
public static readonly long[] Value=A010066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010066.Bytes);
public long this[int i]=>Value[i];

public static A010066Inst Instance=new A010066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010067
{
public static readonly long[] Value={ 1L,3L,5L,12L,19L,26L,33L,40L,42L,49L,56L,63L,70L,77L,79L,86L,93L,100L,107L,114L,116L,123L,130L,137L,144L,151L,153L,160L,167L,174L,181L,188L,190L,197L,204L,211L,218L,229L,236L,243L,250L,257L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010067Inst : IEnumerable<long>
{
public static readonly long[] Value=A010067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010067.Bytes);
public long this[int i]=>Value[i];

public static A010067Inst Instance=new A010067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010068
{
public static readonly long[] Value={ 1L,2L,4L,8L,11L,17L,24L,28L,36L,37L,39L,43L,46L,52L,59L,68L,76L,82L,89L,98L,106L,117L,124L,133L,141L,152L,159L,168L,176L,187L,194L,203L,216L,217L,219L,223L,226L,232L,239L,248L,256L,262L,269L,278L,286L,297L,304L,313L,321L,332L,339L,348L,356L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010068Inst : IEnumerable<long>
{
public static readonly long[] Value=A010068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010068.Bytes);
public long this[int i]=>Value[i];

public static A010068Inst Instance=new A010068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010069
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,14L,16L,20L,28L,32L,40L,50L,52L,56L,58L,62L,70L,74L,82L,92L,100L,104L,112L,116L,124L,134L,142L,152L,160L,170L,178L,188L,202L,212L,220L,230L,244L,260L,268L,278L,292L,308L,316L,326L,340L,356L,364L,368L,376L,386L,394L,398L,406L,410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010069Inst : IEnumerable<long>
{
public static readonly long[] Value=A010069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010069.Bytes);
public long this[int i]=>Value[i];

public static A010069Inst Instance=new A010069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010070
{
public static readonly long[] Value={ 1L,3L,5L,7L,16L,25L,34L,43L,52L,61L,70L,72L,81L,90L,99L,108L,117L,126L,135L,137L,146L,155L,164L,173L,182L,191L,200L,202L,211L,220L,229L,238L,247L,256L,265L,267L,276L,285L,294L,303L,312L,321L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010070Inst : IEnumerable<long>
{
public static readonly long[] Value=A010070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010070.Bytes);
public long this[int i]=>Value[i];

public static A010070Inst Instance=new A010070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010071
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,11L,15L,23L,32L,36L,44L,53L,64L,65L,67L,71L,79L,88L,92L,100L,109L,120L,128L,130L,134L,142L,151L,162L,170L,179L,190L,205L,214L,225L,233L,242L,253L,268L,277L,288L,296L,305L,316L,331L,340L,351L,366L,382L,400L,408L,417L,428L,443L,459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010071Inst : IEnumerable<long>
{
public static readonly long[] Value=A010071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010071.Bytes);
public long this[int i]=>Value[i];

public static A010071Inst Instance=new A010071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010072
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,24L,32L,40L,48L,56L,64L,72L,80L,96L,104L,112L,120L,128L,136L,144L,152L,168L,176L,184L,192L,200L,208L,216L,224L,240L,256L,264L,272L,280L,288L,296L,312L,328L,336L,344L,352L,360L,368L,384L,400L,416L,424L,432L,440L,456L,472L,488L,496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010072Inst : IEnumerable<long>
{
public static readonly long[] Value=A010072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010072.Bytes);
public long this[int i]=>Value[i];

public static A010072Inst Instance=new A010072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010073
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,8L,6L,4L,5L,9L,9L,8L,7L,5L,7L,7L,4L,6L,5L,6L,6L,2L,3L,5L,8L,8L,6L,4L,5L,9L,9L,8L,7L,5L,7L,7L,4L,6L,5L,6L,6L,2L,3L,5L,8L,8L,6L,4L,5L,9L,9L,8L,7L,5L,7L,7L,4L,6L,5L,6L,6L,2L,3L,5L,8L,8L,6L,4L,5L,9L,9L,8L,7L,5L,7L,7L,4L,6L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010073Inst : IEnumerable<long>
{
public static readonly long[] Value=A010073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010073.Bytes);
public long this[int i]=>Value[i];

public static A010073Inst Instance=new A010073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010074
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,7L,3L,4L,7L,5L,6L,11L,11L,10L,9L,7L,4L,5L,9L,8L,5L,7L,6L,7L,7L,2L,3L,5L,8L,7L,3L,4L,7L,5L,6L,11L,11L,10L,9L,7L,4L,5L,9L,8L,5L,7L,6L,7L,7L,2L,3L,5L,8L,7L,3L,4L,7L,5L,6L,11L,11L,10L,9L,7L,4L,5L,9L,8L,5L,7L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010074Inst : IEnumerable<long>
{
public static readonly long[] Value=A010074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010074.Bytes);
public long this[int i]=>Value[i];

public static A010074Inst Instance=new A010074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010075
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,6L,7L,13L,13L,12L,11L,9L,6L,8L,7L,8L,8L,2L,3L,5L,8L,6L,7L,13L,13L,12L,11L,9L,6L,8L,7L,8L,8L,2L,3L,5L,8L,6L,7L,13L,13L,12L,11L,9L,6L,8L,7L,8L,8L,2L,3L,5L,8L,6L,7L,13L,13L,12L,11L,9L,6L,8L,7L,8L,8L,2L,3L,5L,8L,6L,7L,13L,13L,12L,11L,9L,6L,8L,7L,8L,8L,2L,3L,5L,8L,6L,7L,13L,13L,12L,11L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010075Inst : IEnumerable<long>
{
public static readonly long[] Value=A010075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010075.Bytes);
public long this[int i]=>Value[i];

public static A010075Inst Instance=new A010075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010076
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,13L,13L,10L,7L,9L,8L,9L,9L,2L,3L,5L,8L,13L,13L,10L,7L,9L,8L,9L,9L,2L,3L,5L,8L,13L,13L,10L,7L,9L,8L,9L,9L,2L,3L,5L,8L,13L,13L,10L,7L,9L,8L,9L,9L,2L,3L,5L,8L,13L,13L,10L,7L,9L,8L,9L,9L,2L,3L,5L,8L,13L,13L,10L,7L,9L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010076Inst : IEnumerable<long>
{
public static readonly long[] Value=A010076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010076.Bytes);
public long this[int i]=>Value[i];

public static A010076Inst Instance=new A010076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010077
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,13L,12L,7L,10L,8L,9L,17L,17L,16L,15L,13L,10L,5L,6L,11L,8L,10L,9L,10L,10L,2L,3L,5L,8L,13L,12L,7L,10L,8L,9L,17L,17L,16L,15L,13L,10L,5L,6L,11L,8L,10L,9L,10L,10L,2L,3L,5L,8L,13L,12L,7L,10L,8L,9L,17L,17L,16L,15L,13L,10L,5L,6L,11L,8L,10L,9L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010077Inst : IEnumerable<long>
{
public static readonly long[] Value=A010077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010077.Bytes);
public long this[int i]=>Value[i];

public static A010077Inst Instance=new A010077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010142
{
public static readonly long[] Value={ 7L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L,4L,1L,1L,14L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010142Inst : IEnumerable<long>
{
public static readonly long[] Value=A010142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010142.Bytes);
public long this[int i]=>Value[i];

public static A010142Inst Instance=new A010142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010143
{
public static readonly long[] Value={ 7L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L,14L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010143Inst : IEnumerable<long>
{
public static readonly long[] Value=A010143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010143.Bytes);
public long this[int i]=>Value[i];

public static A010143Inst Instance=new A010143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010144
{
public static readonly long[] Value={ 7L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L,7L,2L,1L,14L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010144Inst : IEnumerable<long>
{
public static readonly long[] Value=A010144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010144.Bytes);
public long this[int i]=>Value[i];

public static A010144Inst Instance=new A010144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010145
{
public static readonly long[] Value={ 7L,1L,4L,3L,1L,2L,2L,1L,3L,4L,1L,14L,1L,4L,3L,1L,2L,2L,1L,3L,4L,1L,14L,1L,4L,3L,1L,2L,2L,1L,3L,4L,1L,14L,1L,4L,3L,1L,2L,2L,1L,3L,4L,1L,14L,1L,4L,3L,1L,2L,2L,1L,3L,4L,1L,14L,1L,4L,3L,1L,2L,2L,1L,3L,4L,1L,14L,1L,4L,3L,1L,2L,2L,1L,3L,4L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010145Inst : IEnumerable<long>
{
public static readonly long[] Value=A010145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010145.Bytes);
public long this[int i]=>Value[i];

public static A010145Inst Instance=new A010145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010146
{
public static readonly long[] Value={ 7L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L,1L,6L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010146Inst : IEnumerable<long>
{
public static readonly long[] Value=A010146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010146.Bytes);
public long this[int i]=>Value[i];

public static A010146Inst Instance=new A010146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010147
{
public static readonly long[] Value={ 8L,5L,2L,1L,1L,7L,1L,1L,2L,5L,16L,5L,2L,1L,1L,7L,1L,1L,2L,5L,16L,5L,2L,1L,1L,7L,1L,1L,2L,5L,16L,5L,2L,1L,1L,7L,1L,1L,2L,5L,16L,5L,2L,1L,1L,7L,1L,1L,2L,5L,16L,5L,2L,1L,1L,7L,1L,1L,2L,5L,16L,5L,2L,1L,1L,7L,1L,1L,2L,5L,16L,5L,2L,1L,1L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010147Inst : IEnumerable<long>
{
public static readonly long[] Value=A010147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010147.Bytes);
public long this[int i]=>Value[i];

public static A010147Inst Instance=new A010147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010148
{
public static readonly long[] Value={ 8L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L,3L,3L,16L,3L,3L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010148Inst : IEnumerable<long>
{
public static readonly long[] Value=A010148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010148.Bytes);
public long this[int i]=>Value[i];

public static A010148Inst Instance=new A010148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010149
{
public static readonly long[] Value={ 8L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L,2L,1L,2L,16L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010149Inst : IEnumerable<long>
{
public static readonly long[] Value=A010149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010149.Bytes);
public long this[int i]=>Value[i];

public static A010149Inst Instance=new A010149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010150
{
public static readonly long[] Value={ 8L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L,2L,2L,16L,2L,2L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010150Inst : IEnumerable<long>
{
public static readonly long[] Value=A010150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010150.Bytes);
public long this[int i]=>Value[i];

public static A010150Inst Instance=new A010150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010151
{
public static readonly long[] Value={ 8L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L,16L,1L,1L,5L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010151Inst : IEnumerable<long>
{
public static readonly long[] Value=A010151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010151.Bytes);
public long this[int i]=>Value[i];

public static A010151Inst Instance=new A010151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010152
{
public static readonly long[] Value={ 8L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L,16L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010152Inst : IEnumerable<long>
{
public static readonly long[] Value=A010152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010152.Bytes);
public long this[int i]=>Value[i];

public static A010152Inst Instance=new A010152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010153
{
public static readonly long[] Value={ 8L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L,1L,1L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010153Inst : IEnumerable<long>
{
public static readonly long[] Value=A010153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010153.Bytes);
public long this[int i]=>Value[i];

public static A010153Inst Instance=new A010153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010154
{
public static readonly long[] Value={ 8L,1L,2L,1L,1L,5L,4L,5L,1L,1L,2L,1L,16L,1L,2L,1L,1L,5L,4L,5L,1L,1L,2L,1L,16L,1L,2L,1L,1L,5L,4L,5L,1L,1L,2L,1L,16L,1L,2L,1L,1L,5L,4L,5L,1L,1L,2L,1L,16L,1L,2L,1L,1L,5L,4L,5L,1L,1L,2L,1L,16L,1L,2L,1L,1L,5L,4L,5L,1L,1L,2L,1L,16L,1L,2L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010154Inst : IEnumerable<long>
{
public static readonly long[] Value=A010154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010154.Bytes);
public long this[int i]=>Value[i];

public static A010154Inst Instance=new A010154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010155
{
public static readonly long[] Value={ 8L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L,2L,3L,1L,16L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010155Inst : IEnumerable<long>
{
public static readonly long[] Value=A010155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010155.Bytes);
public long this[int i]=>Value[i];

public static A010155Inst Instance=new A010155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010156
{
public static readonly long[] Value={ 8L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010156Inst : IEnumerable<long>
{
public static readonly long[] Value=A010156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010156.Bytes);
public long this[int i]=>Value[i];

public static A010156Inst Instance=new A010156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010157
{
public static readonly long[] Value={ 8L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010157Inst : IEnumerable<long>
{
public static readonly long[] Value=A010157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010157.Bytes);
public long this[int i]=>Value[i];

public static A010157Inst Instance=new A010157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010158
{
public static readonly long[] Value={ 9L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010158Inst : IEnumerable<long>
{
public static readonly long[] Value=A010158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010158.Bytes);
public long this[int i]=>Value[i];

public static A010158Inst Instance=new A010158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010159
{
public static readonly long[] Value={ 9L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010159Inst : IEnumerable<long>
{
public static readonly long[] Value=A010159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010159.Bytes);
public long this[int i]=>Value[i];

public static A010159Inst Instance=new A010159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010160
{
public static readonly long[] Value={ 9L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010160Inst : IEnumerable<long>
{
public static readonly long[] Value=A010160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010160.Bytes);
public long this[int i]=>Value[i];

public static A010160Inst Instance=new A010160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010161
{
public static readonly long[] Value={ 9L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010161Inst : IEnumerable<long>
{
public static readonly long[] Value=A010161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010161.Bytes);
public long this[int i]=>Value[i];

public static A010161Inst Instance=new A010161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010162
{
public static readonly long[] Value={ 9L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010162Inst : IEnumerable<long>
{
public static readonly long[] Value=A010162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010162.Bytes);
public long this[int i]=>Value[i];

public static A010162Inst Instance=new A010162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010163
{
public static readonly long[] Value={ 9L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010163Inst : IEnumerable<long>
{
public static readonly long[] Value=A010163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010163.Bytes);
public long this[int i]=>Value[i];

public static A010163Inst Instance=new A010163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010164
{
public static readonly long[] Value={ 9L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010164Inst : IEnumerable<long>
{
public static readonly long[] Value=A010164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010164.Bytes);
public long this[int i]=>Value[i];

public static A010164Inst Instance=new A010164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010165
{
public static readonly long[] Value={ 9L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L,18L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L,18L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L,18L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L,18L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010165Inst : IEnumerable<long>
{
public static readonly long[] Value=A010165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010165.Bytes);
public long this[int i]=>Value[i];

public static A010165Inst Instance=new A010165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010166
{
public static readonly long[] Value={ 9L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010166Inst : IEnumerable<long>
{
public static readonly long[] Value=A010166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010166.Bytes);
public long this[int i]=>Value[i];

public static A010166Inst Instance=new A010166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010167
{
public static readonly long[] Value={ 9L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010167Inst : IEnumerable<long>
{
public static readonly long[] Value=A010167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010167.Bytes);
public long this[int i]=>Value[i];

public static A010167Inst Instance=new A010167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010168
{
public static readonly long[] Value={ 9L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010168Inst : IEnumerable<long>
{
public static readonly long[] Value=A010168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010168.Bytes);
public long this[int i]=>Value[i];

public static A010168Inst Instance=new A010168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010169
{
public static readonly long[] Value={ 9L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010169Inst : IEnumerable<long>
{
public static readonly long[] Value=A010169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010169.Bytes);
public long this[int i]=>Value[i];

public static A010169Inst Instance=new A010169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010170
{
public static readonly long[] Value={ 9L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010170Inst : IEnumerable<long>
{
public static readonly long[] Value=A010170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010170.Bytes);
public long this[int i]=>Value[i];

public static A010170Inst Instance=new A010170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010171
{
public static readonly long[] Value={ 10L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010171Inst : IEnumerable<long>
{
public static readonly long[] Value=A010171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010171.Bytes);
public long this[int i]=>Value[i];

public static A010171Inst Instance=new A010171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010172
{
public static readonly long[] Value={ 10L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010172Inst : IEnumerable<long>
{
public static readonly long[] Value=A010172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010172.Bytes);
public long this[int i]=>Value[i];

public static A010172Inst Instance=new A010172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010173
{
public static readonly long[] Value={ 10L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010173Inst : IEnumerable<long>
{
public static readonly long[] Value=A010173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010173.Bytes);
public long this[int i]=>Value[i];

public static A010173Inst Instance=new A010173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010206
{
public static readonly long[] Value={ 12L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L,2L,5L,1L,7L,1L,1L,24L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L,2L,5L,1L,7L,1L,1L,24L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L,2L,5L,1L,7L,1L,1L,24L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L,2L,5L,1L,7L,1L,1L,24L,1L,1L,7L,1L,5L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010206Inst : IEnumerable<long>
{
public static readonly long[] Value=A010206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010206.Bytes);
public long this[int i]=>Value[i];

public static A010206Inst Instance=new A010206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010207
{
public static readonly long[] Value={ 12L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L,24L,1L,1L,3L,12L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010207Inst : IEnumerable<long>
{
public static readonly long[] Value=A010207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010207.Bytes);
public long this[int i]=>Value[i];

public static A010207Inst Instance=new A010207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010208
{
public static readonly long[] Value={ 12L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L,1L,1L,24L,1L,1L,1L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010208Inst : IEnumerable<long>
{
public static readonly long[] Value=A010208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010208.Bytes);
public long this[int i]=>Value[i];

public static A010208Inst Instance=new A010208Inst();

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