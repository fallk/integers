using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A132529
{
public static readonly BigInteger[] Value={ 2L,4L,34L,2846L,68332176L,173179730402274707L,BigInteger.Parse("405658215857116287742915458079857834"),BigInteger.Parse("4783618482246368529251712244532373228925929958989275794663200127988594953") };
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
public class A132529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132529Inst Instance=new A132529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132530
{
public static readonly BigInteger[] Value={ 2L,4L,19L,3117L,16525788L,486443169214192L,BigInteger.Parse("577595651505239612618544288429"),BigInteger.Parse("556584886614239434217223047318874889087430624498576366519471") };
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
public class A132530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132530Inst Instance=new A132530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132531
{
public static readonly BigInteger[] Value={ 2L,4L,14L,226L,110922L,90668884073L,BigInteger.Parse("31375692791338977559896"),BigInteger.Parse("1035722220160720305983134998154467619082188866"),BigInteger.Parse("1574505377241042824611694236664328803401494200370493990085680210494642200738262320979837837") };
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
public class A132531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132531Inst Instance=new A132531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132532
{
public static readonly BigInteger[] Value={ 2L,3L,66L,61415L,8009245057L,BigInteger.Parse("267877546083711148718"),BigInteger.Parse("144120297092904294557353487304315326585556"),BigInteger.Parse("49351618285326832060405463423903965096844044169968421322099605331829400133538958567") };
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
public class A132532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132532Inst Instance=new A132532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132533
{
public static readonly BigInteger[] Value={ 2L,3L,27L,1976L,5066295L,30938196963071L,BigInteger.Parse("1046281665980548868071666945"),BigInteger.Parse("2694045416033001453689961948450775927564028502803056062") };
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
public class A132533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132533Inst Instance=new A132533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132534
{
public static readonly BigInteger[] Value={ 2L,3L,17L,1192L,1595015L,3181399537600L,BigInteger.Parse("19206951151850850668969384"),BigInteger.Parse("609405107959734253845629228248496877079162949813293") };
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
public class A132534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132534Inst Instance=new A132534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132535
{
public static readonly BigInteger[] Value={ 2L,3L,13L,217L,340602L,284463373484L,BigInteger.Parse("128928429895063791527231"),BigInteger.Parse("24743166714108233562749190481870376395129571472"),BigInteger.Parse("647035878199198528186676602257274797090264539487696578002221165004966562727016349210912064208") };
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
public class A132535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132535Inst Instance=new A132535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132568
{
public static readonly BigInteger[] Value={ 2L,22L,724L,5468899L,41219812915806L,BigInteger.Parse("9830404123951216001398242604"),BigInteger.Parse("175501018567713056443099287241463851479147427159806448659") };
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
public class A132568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132568Inst Instance=new A132568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132569
{
public static readonly BigInteger[] Value={ 2L,16L,2484L,16978669L,530279187050256L,BigInteger.Parse("290149946264656357060596770106"),BigInteger.Parse("84762263808047240224281135743497356848176381110020502438604") };
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
public class A132569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132569Inst Instance=new A132569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132570
{
public static readonly BigInteger[] Value={ 2L,13L,518L,294867L,3931788485135L,BigInteger.Parse("789762815199205645609347669"),BigInteger.Parse("2777400274596078368562463268089427466325733188125361616") };
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
public class A132570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132570Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132570.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132570Inst Instance=new A132570Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132571
{
public static readonly BigInteger[] Value={ 2L,11L,264L,254939L,320773392241L,BigInteger.Parse("276158498360667413783636"),BigInteger.Parse("120374248754875521713677716478235536915748863225"),BigInteger.Parse("20864278671228389349439892902143806794553502721485328660888213260233616113815320954494065070564") };
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
public class A132571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132571Inst Instance=new A132571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132572
{
public static readonly BigInteger[] Value={ 2L,10L,96L,50955L,4304306138L,BigInteger.Parse("51232640406779712941"),BigInteger.Parse("3080601775735377439643033734981837198105"),BigInteger.Parse("24654825482179104483590660314479645184201465447817020032817452337074859467766378") };
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
public class A132572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132572Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132572.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132572Inst Instance=new A132572Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132573
{
public static readonly BigInteger[] Value={ 2L,8L,939L,21525543L,583800017138353L,BigInteger.Parse("389129377207344584150234464055"),BigInteger.Parse("322329972486630717438831184068725403247163006781447886216160") };
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
public class A132573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132573Inst Instance=new A132573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132574
{
public static readonly BigInteger[] Value={ 2L,8L,61L,5118L,461665855L,623226225881980511L,BigInteger.Parse("414504377324573765293514801448728784"),BigInteger.Parse("236902165576254773155426469727218731977450593637429985699626109166408392") };
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
public class A132574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132574Inst Instance=new A132574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132575
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,1L,1L,1L,1L,1L,1L,1L,1L,22L,5L,21L,27L,29L,31L,33L,27L,37L,29L,41L,8L,33L,32L,48L,50L,52L,34L,56L,58L,60L,9L,63L,34L,67L,69L,71L,35L,47L,77L,49L,10L,5L,84L,86L,88L,54L,92L,56L,96L,58L,11L,102L,62L,107L,57L,97L,66L,87L,68L,98L,13L,25L,126L,47L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132575Inst : IEnumerable<long>
{
public static readonly long[] Value=A132575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132575.Bytes);
public long this[int i]=>Value[i];

public static A132575Inst Instance=new A132575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132576
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,61L,11L,71L,121L,81L,92L,455L,922L,293L,244L,22L,20L,733L,6030L,72L,93L,23L,41207L,24L,1010L,25L,33L,26L,37L,47L,94L,28L,4955L,619L,9611L,30L,486L,23250L,852L,599L,616L,48L,34L,50L,35L,6118L,36L,75L,56L,805L,38L,65L,39L,84L,40L,258L,63L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132576Inst : IEnumerable<long>
{
public static readonly long[] Value=A132576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132576.Bytes);
public long this[int i]=>Value[i];

public static A132576Inst Instance=new A132576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132577
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,22L,27L,29L,31L,33L,37L,41L,48L,50L,52L,56L,58L,60L,63L,67L,69L,71L,77L,84L,86L,88L,92L,96L,102L,107L,126L,142L,147L,150L,164L,183L,188L,194L,197L,200L,206L,212L,219L,222L,228L,231L,234L,237L,240L,248L,261L,264L,267L,270L,279L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132577Inst : IEnumerable<long>
{
public static readonly long[] Value=A132577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132577.Bytes);
public long this[int i]=>Value[i];

public static A132577Inst Instance=new A132577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132578
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,23L,24L,25L,26L,28L,30L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,49L,53L,54L,55L,57L,59L,62L,64L,73L,80L,82L,83L,90L,98L,100L,103L,104L,105L,107L,109L,112L,113L,115L,116L,117L,118L,119L,122L,127L,128L,129L,130L,134L,135L,136L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132578Inst : IEnumerable<long>
{
public static readonly long[] Value=A132578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132578.Bytes);
public long this[int i]=>Value[i];

public static A132578Inst Instance=new A132578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132579
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,27L,29L,108L,438L,2032L,3367L,6070L,8230L,21410L,27527L,41733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132579Inst : IEnumerable<long>
{
public static readonly long[] Value=A132579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132579.Bytes);
public long this[int i]=>Value[i];

public static A132579Inst Instance=new A132579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132580
{
public static readonly long[] Value={ 13L,14L,15L,16L,17L,18L,19L,1192L,1193L,11431L,18738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132580Inst : IEnumerable<long>
{
public static readonly long[] Value=A132580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132580.Bytes);
public long this[int i]=>Value[i];

public static A132580Inst Instance=new A132580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132581
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,14L,19L,20L,39L,53L,78L,84L,134L,148L,167L,168L,335L,483L,765L,849L,1466L,1681L,1988L,2008L,3700L,4414L,5489L,5573L,7265L,7413L,7580L,7581L,15161L,22574L,37252L,42825L,77388L,92864L,116454L,118462L,227503L,286776L,382574L,392247L,555662L,574114L,595481L,595649L,1176304L,1563955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132581Inst : IEnumerable<long>
{
public static readonly long[] Value=A132581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132581.Bytes);
public long this[int i]=>Value[i];

public static A132581Inst Instance=new A132581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132582
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,3L,5L,1L,19L,14L,25L,6L,50L,14L,19L,1L,167L,148L,282L,84L,617L,215L,307L,20L,1692L,714L,1075L,84L,1692L,148L,167L,1L,7580L,7413L,14678L,5573L,34563L,15476L,23590L,2008L,109041L,59273L,95798L,9673L,163415L,18452L,21367L,168L,580655L,387651L,668175L,82404L,1226845L,169396L,201394L,2008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132582Inst : IEnumerable<long>
{
public static readonly long[] Value=A132582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132582.Bytes);
public long this[int i]=>Value[i];

public static A132582Inst Instance=new A132582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132583
{
public static readonly long[] Value={ 11L,121L,1221L,12221L,122221L,1222221L,12222221L,122222221L,1222222221L,12222222221L,122222222221L,1222222222221L,12222222222221L,122222222222221L,1222222222222221L,12222222222222221L,122222222222222221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132583Inst : IEnumerable<long>
{
public static readonly long[] Value=A132583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132583.Bytes);
public long this[int i]=>Value[i];

public static A132583Inst Instance=new A132583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132600
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,11L,12L,13L,20L,27L,29L,35L,38L,41L,44L,45L,47L,54L,56L,72L,80L,81L,87L,99L,101L,105L,126L,135L,160L,162L,163L,164L,170L,182L,231L,242L,243L,244L,245L,248L,252L,260L,261L,263L,266L,267L,284L,296L,299L,305L,308L,311L,314L,315L,317L,320L,331L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132600Inst : IEnumerable<long>
{
public static readonly long[] Value=A132600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132600.Bytes);
public long this[int i]=>Value[i];

public static A132600Inst Instance=new A132600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132601
{
public static readonly long[] Value={ 1L,2L,1L,5L,1L,2L,7L,14L,18L,16L,2L,1L,3L,7L,1L,6L,40L,46L,20L,20L,7L,62L,13L,31L,80L,8L,12L,6L,20L,4L,23L,111L,76L,9L,4L,132L,15L,9L,9L,20L,20L,18L,48L,134L,71L,45L,39L,3L,51L,13L,4L,10L,9L,31L,71L,34L,2L,8L,71L,25L,78L,56L,178L,280L,184L,106L,8L,185L,8L,276L,44L,5L,7L,12L,143L,24L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132601Inst : IEnumerable<long>
{
public static readonly long[] Value=A132601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132601.Bytes);
public long this[int i]=>Value[i];

public static A132601Inst Instance=new A132601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132602
{
public static readonly long[] Value={ 1L,2L,13L,30L,4L,16L,7L,26L,34L,52L,122L,27L,23L,8L,37L,10L,424L,9L,346L,19L,107L,89L,31L,76L,60L,185L,413L,121L,103L,116L,24L,390L,311L,56L,163L,210L,871L,118L,47L,17L,206L,142L,177L,71L,46L,18L,482L,43L,273L,152L,49L,119L,647L,160L,855L,62L,555L,379L,292L,125L,108L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132602Inst : IEnumerable<long>
{
public static readonly long[] Value=A132602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132602.Bytes);
public long this[int i]=>Value[i];

public static A132602Inst Instance=new A132602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132603
{
public static readonly long[] Value={ 1L,2L,5L,7L,14L,18L,40L,46L,62L,80L,111L,132L,134L,178L,280L,298L,438L,441L,682L,700L,727L,786L,1109L,1565L,1576L,1604L,1642L,1720L,1812L,1902L,1976L,2566L,3754L,3828L,3908L,3929L,4004L,4156L,4524L,4790L,4941L,5481L,8645L,8716L,8740L,8891L,8952L,9013L,9400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132603Inst : IEnumerable<long>
{
public static readonly long[] Value=A132603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132603.Bytes);
public long this[int i]=>Value[i];

public static A132603Inst Instance=new A132603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132604
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,9L,17L,18L,22L,25L,32L,36L,44L,63L,64L,100L,127L,129L,130L,132L,137L,156L,193L,256L,257L,260L,264L,280L,284L,294L,302L,511L,515L,522L,530L,532L,540L,556L,594L,624L,640L,770L,1030L,1036L,1038L,1052L,1072L,1090L,1100L,1106L,1108L,1116L,1148L,1170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132604Inst : IEnumerable<long>
{
public static readonly long[] Value=A132604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132604.Bytes);
public long this[int i]=>Value[i];

public static A132604Inst Instance=new A132604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132605
{
public static readonly long[] Value={ 1L,2L,7L,20L,169L,742L,2025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132605Inst : IEnumerable<long>
{
public static readonly long[] Value=A132605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132605.Bytes);
public long this[int i]=>Value[i];

public static A132605Inst Instance=new A132605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132606
{
public static readonly long[] Value={ 20L,39L,41L,90L,159L,169L,1790L,4041L,4371L,22894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132606Inst : IEnumerable<long>
{
public static readonly long[] Value=A132606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132606.Bytes);
public long this[int i]=>Value[i];

public static A132606Inst Instance=new A132606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132607
{
public static readonly BigInteger[] Value={ 0L,99L,39600L,15760899L,6272798400L,2496558002499L,993623812196400L,395459780696164899L,BigInteger.Parse("157391999093261433600"),BigInteger.Parse("62641620179337354408099"),BigInteger.Parse("24931207439377173792990000"),BigInteger.Parse("9922557919251935832255612099") };
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
public class A132607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132607Inst Instance=new A132607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132608
{
public static readonly long[] Value={ 1L,2L,9L,58L,469L,4530L,50491L,634790L,8861043L,135750454L,2262315973L,40726646802L,787471241647L,16275700505510L,358103286781293L,8357593147404346L,206241859929682177L,5366082228239257410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132608Inst : IEnumerable<long>
{
public static readonly long[] Value=A132608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132608.Bytes);
public long this[int i]=>Value[i];

public static A132608Inst Instance=new A132608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132609
{
public static readonly long[] Value={ 1L,2L,6L,26L,147L,1026L,8532L,82394L,906485L,11194402L,153347766L,2307805402L,37851581159L,672037936898L,12841521329896L,262772642843802L,5733086299727913L,132853067341477538L,3258726189638877610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132609Inst : IEnumerable<long>
{
public static readonly long[] Value=A132609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132609.Bytes);
public long this[int i]=>Value[i];

public static A132609Inst Instance=new A132609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132610
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,14L,4L,1L,1L,194L,39L,6L,1L,1L,4114L,648L,76L,8L,1L,1L,118042L,15465L,1510L,125L,10L,1L,1L,4274612L,483240L,41121L,2908L,186L,12L,1L,1L,186932958L,18685905L,1424178L,89670L,4970L,259L,14L,1L,1L,9577713250L,861282832L,59857416L,3437248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132610Inst : IEnumerable<long>
{
public static readonly long[] Value=A132610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132610.Bytes);
public long this[int i]=>Value[i];

public static A132610Inst Instance=new A132610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132611
{
public static readonly BigInteger[] Value={ 1L,1L,2L,14L,194L,4114L,118042L,4274612L,186932958L,9577713250L,562450162646L,37232881004442L,2742420824107648L,222414345991567630L,BigInteger.Parse("19691735781407563460"),BigInteger.Parse("1889658596054736522248"),BigInteger.Parse("195353325211864635176182"),BigInteger.Parse("21643625444562045727620930") };
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
public class A132611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132611Inst Instance=new A132611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132612
{
public static readonly BigInteger[] Value={ 1L,1L,4L,39L,648L,15465L,483240L,18685905L,861282832L,46085893011L,2807152825020L,191731595897600L,14510053796849640L,1205013817282706730L,BigInteger.Parse("108941005329522201360"),BigInteger.Parse("10650027832902977866245"),BigInteger.Parse("1119401271751383414197280"),BigInteger.Parse("125879457463215695125460535") };
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
public class A132612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132612Inst Instance=new A132612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132613
{
public static readonly BigInteger[] Value={ 1L,1L,6L,76L,1510L,41121L,1424178L,59857416L,2957282370L,167852629965L,10757980606208L,768190770422700L,60461731639747100L,5199414726620992073L,BigInteger.Parse("484974399630368105130"),BigInteger.Parse("48763257278485285019472") };
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
public class A132613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132613Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132613.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132613Inst Instance=new A132613Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132614
{
public static readonly BigInteger[] Value={ 1L,2L,13L,162L,3093L,80540L,2669415L,107660354L,5120654779L,280715282502L,17430145081600L,1209171149737470L,92693370560208210L,7781500380680157240L,BigInteger.Parse("710001855526865191083"),BigInteger.Parse("69962579484461463387330") };
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
public class A132614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132614Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132614.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132614Inst Instance=new A132614Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132615
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,6L,3L,1L,1L,80L,25L,5L,1L,1L,1666L,378L,56L,7L,1L,1L,47232L,8460L,1020L,99L,9L,1L,1L,1694704L,252087L,26015L,2134L,154L,11L,1L,1L,73552752L,9392890L,855478L,61919L,3848L,221L,13L,1L,1L,3744491970L,420142350L,34461260L,2257413L,125760L,6290L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132615Inst : IEnumerable<long>
{
public static readonly long[] Value=A132615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132615.Bytes);
public long this[int i]=>Value[i];

public static A132615Inst Instance=new A132615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132696
{
public static readonly long[] Value={ 1L,9L,0L,9L,8L,5L,9L,3L,1L,7L,1L,0L,2L,7L,4L,4L,0L,2L,9L,2L,2L,6L,6L,0L,5L,1L,6L,0L,4L,7L,0L,1L,7L,2L,3L,4L,4L,4L,1L,3L,5L,1L,5L,7L,4L,8L,8L,8L,5L,4L,7L,7L,3L,8L,4L,9L,7L,2L,0L,0L,8L,1L,2L,8L,7L,0L,6L,7L,6L,1L,5L,7L,1L,6L,1L,0L,7L,1L,8L,4L,2L,1L,0L,8L,1L,3L,6L,5L,6L,3L,3L,1L,9L,5L,0L,3L,7L,0L,3L,1L,4L,7L,2L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132696Inst : IEnumerable<long>
{
public static readonly long[] Value=A132696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132696.Bytes);
public long this[int i]=>Value[i];

public static A132696Inst Instance=new A132696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132697
{
public static readonly long[] Value={ 2L,2L,2L,8L,1L,6L,9L,2L,0L,3L,2L,8L,6L,5L,3L,4L,7L,0L,0L,7L,6L,4L,3L,7L,2L,6L,8L,7L,2L,1L,5L,2L,0L,1L,0L,6L,8L,4L,8L,2L,4L,3L,5L,0L,4L,0L,3L,6L,6L,3L,9L,0L,2L,8L,2L,4L,6L,7L,3L,4L,2L,8L,1L,6L,8L,2L,4L,5L,5L,5L,1L,6L,6L,8L,7L,9L,1L,7L,1L,4L,9L,1L,2L,6L,1L,5L,9L,3L,2L,3L,8L,7L,2L,7L,5L,4L,3L,2L,0L,3L,3L,8L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132697Inst : IEnumerable<long>
{
public static readonly long[] Value=A132697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132697.Bytes);
public long this[int i]=>Value[i];

public static A132697Inst Instance=new A132697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132698
{
public static readonly long[] Value={ 2L,5L,4L,6L,4L,7L,9L,0L,8L,9L,4L,7L,0L,3L,2L,5L,3L,7L,2L,3L,0L,2L,1L,4L,0L,2L,1L,3L,9L,6L,0L,2L,2L,9L,7L,9L,2L,5L,5L,1L,3L,5L,4L,3L,3L,1L,8L,4L,7L,3L,0L,3L,1L,7L,9L,9L,6L,2L,6L,7L,7L,5L,0L,4L,9L,4L,2L,3L,4L,8L,7L,6L,2L,1L,4L,7L,6L,2L,4L,5L,6L,1L,4L,4L,1L,8L,2L,0L,8L,4L,4L,2L,6L,0L,0L,4L,9L,3L,7L,5L,2L,9L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132698Inst : IEnumerable<long>
{
public static readonly long[] Value=A132698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132698.Bytes);
public long this[int i]=>Value[i];

public static A132698Inst Instance=new A132698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132699
{
public static readonly long[] Value={ 2L,8L,6L,4L,7L,8L,8L,9L,7L,5L,6L,5L,4L,1L,1L,6L,0L,4L,3L,8L,3L,9L,9L,0L,7L,7L,4L,0L,7L,0L,5L,2L,5L,8L,5L,1L,6L,6L,2L,0L,2L,7L,3L,6L,2L,3L,3L,2L,8L,2L,1L,6L,0L,7L,7L,4L,5L,8L,0L,1L,2L,1L,9L,3L,0L,6L,0L,1L,4L,2L,3L,5L,7L,4L,1L,6L,0L,7L,7L,6L,3L,1L,6L,2L,2L,0L,4L,8L,4L,4L,9L,7L,9L,2L,5L,5L,5L,5L,4L,7L,2L,0L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132699Inst : IEnumerable<long>
{
public static readonly long[] Value=A132699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132699.Bytes);
public long this[int i]=>Value[i];

public static A132699Inst Instance=new A132699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132700
{
public static readonly long[] Value={ 1L,0L,1L,3L,4L,1L,6L,9L,8L,5L,0L,2L,8L,9L,6L,5L,5L,6L,0L,7L,9L,4L,4L,0L,1L,0L,9L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132700Inst : IEnumerable<long>
{
public static readonly long[] Value=A132700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132700.Bytes);
public long this[int i]=>Value[i];

public static A132700Inst Instance=new A132700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132701
{
public static readonly long[] Value={ 3L,5L,0L,1L,4L,0L,8L,7L,4L,8L,0L,2L,1L,6L,9L,7L,3L,8L,6L,9L,1L,5L,4L,4L,2L,7L,9L,4L,1L,9L,5L,3L,1L,5L,9L,6L,4L,7L,5L,8L,1L,1L,2L,2L,0L,6L,2L,9L,0L,0L,4L,1L,8L,7L,2L,4L,4L,8L,6L,8L,1L,5L,6L,9L,2L,9L,5L,7L,2L,9L,5L,4L,7L,9L,5L,2L,9L,8L,3L,7L,7L,1L,9L,8L,2L,5L,0L,3L,6L,6L,0L,8L,5L,7L,5L,6L,7L,8L,9L,1L,0L,3L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132701Inst : IEnumerable<long>
{
public static readonly long[] Value=A132701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132701.Bytes);
public long this[int i]=>Value[i];

public static A132701Inst Instance=new A132701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132702
{
public static readonly long[] Value={ 3L,8L,1L,9L,7L,1L,8L,6L,3L,4L,2L,0L,5L,4L,8L,8L,0L,5L,8L,4L,5L,3L,2L,1L,0L,3L,2L,0L,9L,4L,0L,3L,4L,4L,6L,8L,8L,8L,2L,7L,0L,3L,1L,4L,9L,7L,7L,7L,0L,9L,5L,4L,7L,6L,9L,9L,4L,4L,0L,1L,6L,2L,5L,7L,4L,1L,3L,5L,2L,3L,1L,4L,3L,2L,2L,1L,4L,3L,6L,8L,4L,2L,1L,6L,2L,7L,3L,1L,2L,6L,6L,3L,9L,0L,0L,7L,4L,0L,6L,2L,9L,4L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132702Inst : IEnumerable<long>
{
public static readonly long[] Value=A132702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132702.Bytes);
public long this[int i]=>Value[i];

public static A132702Inst Instance=new A132702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132703
{
public static readonly long[] Value={ 4L,1L,3L,8L,0L,2L,8L,5L,2L,0L,3L,8L,9L,2L,7L,8L,7L,2L,9L,9L,9L,0L,9L,7L,7L,8L,4L,7L,6L,8L,5L,3L,7L,3L,4L,1L,2L,8L,9L,5L,9L,5L,0L,7L,8L,9L,2L,5L,1L,8L,6L,7L,6L,6L,7L,4L,3L,9L,3L,5L,0L,9L,4L,5L,5L,3L,1L,3L,1L,6L,7L,3L,8L,4L,8L,9L,8L,8L,9L,9L,1L,2L,3L,4L,2L,9L,5L,8L,8L,7L,1L,9L,2L,2L,5L,8L,0L,2L,3L,4L,8L,5L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132703Inst : IEnumerable<long>
{
public static readonly long[] Value=A132703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132703.Bytes);
public long this[int i]=>Value[i];

public static A132703Inst Instance=new A132703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132704
{
public static readonly long[] Value={ 4L,4L,5L,6L,3L,3L,8L,4L,0L,6L,5L,7L,3L,0L,6L,9L,4L,0L,1L,5L,2L,8L,7L,4L,5L,3L,7L,4L,4L,3L,0L,4L,0L,2L,1L,3L,6L,9L,6L,4L,8L,7L,0L,0L,8L,0L,7L,3L,2L,7L,8L,0L,5L,6L,4L,9L,3L,4L,6L,8L,5L,6L,3L,3L,6L,4L,9L,1L,1L,0L,3L,3L,3L,7L,5L,8L,3L,4L,2L,9L,8L,2L,5L,2L,3L,1L,8L,6L,4L,7L,7L,4L,5L,5L,0L,8L,6L,4L,0L,6L,7L,7L,0L,0L,3L,9L,5L,9L,6L,3L,4L,9L,2L,2L,2L,8L,2L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132704Inst : IEnumerable<long>
{
public static readonly long[] Value=A132704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132704.Bytes);
public long this[int i]=>Value[i];

public static A132704Inst Instance=new A132704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132705
{
public static readonly long[] Value={ 2L,3L,4L,5L,16L,7L,20L,9L,64L,25L,28L,13L,80L,15L,36L,35L,256L,19L,100L,21L,112L,45L,52L,25L,320L,49L,60L,125L,144L,31L,140L,33L,128L,65L,76L,63L,400L,49L,84L,75L,448L,43L,180L,45L,208L,175L,100L,49L,1280L,81L,196L,95L,240L,55L,500L,91L,576L,105L,124L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132705Inst : IEnumerable<long>
{
public static readonly long[] Value=A132705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132705.Bytes);
public long this[int i]=>Value[i];

public static A132705Inst Instance=new A132705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132706
{
public static readonly long[] Value={ 5L,0L,9L,2L,9L,5L,8L,1L,7L,8L,9L,4L,0L,6L,5L,0L,7L,4L,4L,6L,0L,4L,2L,8L,0L,4L,2L,7L,9L,2L,0L,4L,5L,9L,5L,8L,5L,1L,0L,2L,7L,0L,8L,6L,6L,3L,6L,9L,4L,6L,0L,6L,3L,5L,9L,9L,2L,5L,3L,5L,5L,0L,0L,9L,8L,8L,4L,6L,9L,7L,5L,2L,4L,2L,9L,5L,2L,4L,9L,1L,2L,2L,8L,8L,3L,6L,4L,1L,6L,8L,8L,5L,2L,0L,0L,9L,8L,7L,5L,0L,5L,9L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132706Inst : IEnumerable<long>
{
public static readonly long[] Value=A132706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132706.Bytes);
public long this[int i]=>Value[i];

public static A132706Inst Instance=new A132706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132707
{
public static readonly long[] Value={ 5L,4L,1L,1L,2L,6L,8L,0L,6L,5L,1L,2L,4L,4L,4L,1L,4L,1L,6L,1L,4L,2L,0L,4L,7L,9L,5L,4L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132707Inst : IEnumerable<long>
{
public static readonly long[] Value=A132707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132707.Bytes);
public long this[int i]=>Value[i];

public static A132707Inst Instance=new A132707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132708
{
public static readonly long[] Value={ 4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L,4L,2L,1L,-4L,-2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132708Inst : IEnumerable<long>
{
public static readonly long[] Value=A132708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132708.Bytes);
public long this[int i]=>Value[i];

public static A132708Inst Instance=new A132708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132709
{
public static readonly long[] Value={ 6L,0L,4L,7L,8L,8L,7L,8L,3L,7L,4L,9L,2L,0L,2L,2L,7L,5L,9L,2L,1L,7L,5L,8L,3L,0L,0L,8L,1L,5L,5L,5L,4L,5L,7L,5L,7L,3L,0L,9L,4L,6L,6L,5L,3L,8L,1L,3L,7L,3L,4L,5L,0L,5L,2L,4L,1L,1L,3L,5L,9L,0L,7L,4L,2L,3L,8L,0L,7L,8L,3L,1L,0L,1L,0L,0L,6L,0L,8L,3L,3L,3L,4L,2L,4L,3L,2L,4L,5L,0L,5L,1L,1L,7L,6L,1L,7L,2L,6L,6L,3L,3L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132709Inst : IEnumerable<long>
{
public static readonly long[] Value=A132709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132709.Bytes);
public long this[int i]=>Value[i];

public static A132709Inst Instance=new A132709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132710
{
public static readonly long[] Value={ 0L,2L,0L,0L,6L,0L,0L,0L,12L,0L,0L,0L,0L,20L,0L,0L,0L,0L,0L,30L,0L,0L,0L,0L,0L,0L,42L,0L,0L,0L,0L,0L,0L,0L,56L,0L,0L,0L,0L,0L,0L,0L,0L,72L,0L,0L,0L,0L,0L,0L,0L,0L,0L,90L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,110L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,132L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132710Inst : IEnumerable<long>
{
public static readonly long[] Value=A132710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132710.Bytes);
public long this[int i]=>Value[i];

public static A132710Inst Instance=new A132710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132711
{
public static readonly long[] Value={ 6L,6L,8L,4L,5L,0L,7L,6L,0L,9L,8L,5L,9L,6L,0L,4L,1L,0L,2L,2L,9L,3L,1L,1L,8L,0L,6L,1L,6L,4L,5L,6L,0L,3L,2L,0L,5L,4L,4L,7L,3L,0L,5L,1L,2L,1L,0L,9L,9L,1L,7L,0L,8L,4L,7L,4L,0L,2L,0L,2L,8L,4L,5L,0L,4L,7L,3L,6L,6L,5L,5L,0L,0L,6L,3L,7L,5L,1L,4L,4L,7L,3L,7L,8L,4L,7L,7L,9L,7L,1L,6L,1L,8L,2L,6L,2L,9L,6L,1L,0L,1L,5L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132711Inst : IEnumerable<long>
{
public static readonly long[] Value=A132711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132711.Bytes);
public long this[int i]=>Value[i];

public static A132711Inst Instance=new A132711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132744
{
public static readonly long[] Value={ 1L,1L,2L,1L,9L,9L,7L,3L,7L,6L,2L,8L,2L,0L,6L,9L,0L,1L,3L,7L,3L,6L,6L,5L,8L,3L,5L,1L,1L,7L,1L,2L,5L,1L,0L,3L,0L,0L,7L,0L,4L,1L,7L,6L,4L,2L,6L,3L,3L,9L,6L,6L,3L,6L,4L,6L,3L,3L,9L,0L,8L,7L,8L,2L,9L,6L,7L,0L,7L,7L,2L,8L,7L,9L,5L,9L,3L,6L,0L,3L,5L,6L,6L,5L,2L,8L,6L,9L,5L,8L,0L,4L,7L,9L,3L,2L,7L,5L,2L,4L,2L,7L,9L,3L,3L,8L,6L,0L,2L,3L,2L,6L,1L,7L,2L,2L,5L,2L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132744Inst : IEnumerable<long>
{
public static readonly long[] Value=A132744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132744.Bytes);
public long this[int i]=>Value[i];

public static A132744Inst Instance=new A132744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132745
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,32L,114L,467L,2130L,10642L,57629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132745Inst : IEnumerable<long>
{
public static readonly long[] Value=A132745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132745.Bytes);
public long this[int i]=>Value[i];

public static A132745Inst Instance=new A132745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132746
{
public static readonly long[] Value={ 2L,7L,15L,18L,20L,28L,61L,152L,190L,293L,377L,492L,558L,564L,789L,919L,942L,1332L,1768L,2343L,2429L,2693L,2952L,3136L,3720L,3928L,4837L,5421L,5722L,6870L,7347L,8126L,8193L,9465L,9857L,9927L,10410L,10483L,10653L,12685L,13005L,13763L,13955L,16033L,16342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132746Inst : IEnumerable<long>
{
public static readonly long[] Value=A132746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132746.Bytes);
public long this[int i]=>Value[i];

public static A132746Inst Instance=new A132746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132747
{
public static readonly long[] Value={ 0L,2L,0L,2L,0L,3L,0L,2L,0L,2L,0L,4L,0L,2L,0L,2L,0L,3L,0L,4L,0L,2L,0L,4L,0L,2L,0L,2L,0L,5L,0L,2L,0L,2L,0L,4L,0L,2L,0L,4L,0L,5L,0L,2L,0L,2L,0L,4L,0L,2L,0L,2L,0L,3L,0L,4L,0L,2L,0L,6L,0L,2L,0L,2L,0L,3L,0L,2L,0L,2L,0L,6L,0L,2L,0L,2L,0L,3L,0L,4L,0L,2L,0L,6L,0L,2L,0L,2L,0L,7L,0L,2L,0L,2L,0L,4L,0L,2L,0L,4L,0L,3L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132747Inst : IEnumerable<long>
{
public static readonly long[] Value=A132747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132747.Bytes);
public long this[int i]=>Value[i];

public static A132747Inst Instance=new A132747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132748
{
public static readonly long[] Value={ 0L,3L,0L,3L,0L,6L,0L,3L,0L,3L,0L,10L,0L,3L,0L,3L,0L,6L,0L,12L,0L,3L,0L,10L,0L,3L,0L,3L,0L,17L,0L,3L,0L,3L,0L,10L,0L,3L,0L,12L,0L,19L,0L,3L,0L,3L,0L,10L,0L,3L,0L,3L,0L,6L,0L,18L,0L,3L,0L,21L,0L,3L,0L,3L,0L,6L,0L,3L,0L,3L,0L,27L,0L,3L,0L,3L,0L,6L,0L,12L,0L,3L,0L,23L,0L,3L,0L,3L,0L,36L,0L,3L,0L,3L,0L,10L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132748Inst : IEnumerable<long>
{
public static readonly long[] Value=A132748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132748.Bytes);
public long this[int i]=>Value[i];

public static A132748Inst Instance=new A132748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132749
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,2L,3L,3L,1L,2L,4L,6L,4L,1L,2L,5L,10L,10L,5L,1L,2L,6L,15L,20L,15L,6L,1L,2L,7L,21L,35L,35L,21L,7L,1L,2L,8L,28L,56L,70L,56L,28L,8L,1L,2L,9L,36L,84L,126L,126L,84L,36L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132749Inst : IEnumerable<long>
{
public static readonly long[] Value=A132749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132749.Bytes);
public long this[int i]=>Value[i];

public static A132749Inst Instance=new A132749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132750
{
public static readonly long[] Value={ 1L,4L,9L,21L,49L,113L,257L,577L,1281L,2817L,6145L,13313L,28673L,61441L,131073L,278529L,589825L,1245185L,2621441L,5505025L,11534337L,24117249L,50331649L,104857601L,218103809L,452984833L,939524097L,1946157057L,4026531841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132750Inst : IEnumerable<long>
{
public static readonly long[] Value=A132750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132750.Bytes);
public long this[int i]=>Value[i];

public static A132750Inst Instance=new A132750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132751
{
public static readonly long[] Value={ 1L,3L,3L,5L,11L,5L,7L,23L,23L,7L,9L,39L,59L,39L,9L,11L,59L,119L,119L,59L,11L,13L,83L,209L,279L,209L,83L,13L,15L,111L,335L,559L,559L,335L,111L,15L,17L,143L,503L,1007L,1259L,1007L,503L,143L,17L,19L,179L,719L,1679L,2519L,2519L,1679L,719L,179L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132751Inst : IEnumerable<long>
{
public static readonly long[] Value=A132751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132751.Bytes);
public long this[int i]=>Value[i];

public static A132751Inst Instance=new A132751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132752
{
public static readonly long[] Value={ 1L,3L,1L,3L,3L,1L,3L,5L,5L,1L,3L,7L,11L,7L,1L,3L,9L,19L,19L,9L,1L,3L,11L,29L,39L,29L,11L,1L,3L,13L,41L,69L,69L,41L,13L,1L,3L,15L,55L,111L,139L,111L,55L,15L,1L,3L,17L,71L,167L,251L,251L,167L,71L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132752Inst : IEnumerable<long>
{
public static readonly long[] Value=A132752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132752.Bytes);
public long this[int i]=>Value[i];

public static A132752Inst Instance=new A132752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132753
{
public static readonly long[] Value={ 3L,4L,7L,14L,29L,60L,123L,250L,505L,1016L,2039L,4086L,8181L,16372L,32755L,65522L,131057L,262128L,524271L,1048558L,2097133L,4194284L,8388587L,16777194L,33554409L,67108840L,134217703L,268435430L,536870885L,1073741796L,2147483619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132753Inst : IEnumerable<long>
{
public static readonly long[] Value=A132753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132753.Bytes);
public long this[int i]=>Value[i];

public static A132753Inst Instance=new A132753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132754
{
public static readonly long[] Value={ 0L,12L,25L,39L,54L,70L,87L,105L,124L,144L,165L,187L,210L,234L,259L,285L,312L,340L,369L,399L,430L,462L,495L,529L,564L,600L,637L,675L,714L,754L,795L,837L,880L,924L,969L,1015L,1062L,1110L,1159L,1209L,1260L,1312L,1365L,1419L,1474L,1530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132754Inst : IEnumerable<long>
{
public static readonly long[] Value=A132754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132754.Bytes);
public long this[int i]=>Value[i];

public static A132754Inst Instance=new A132754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132755
{
public static readonly long[] Value={ 0L,13L,27L,42L,58L,75L,93L,112L,132L,153L,175L,198L,222L,247L,273L,300L,328L,357L,387L,418L,450L,483L,517L,552L,588L,625L,663L,702L,742L,783L,825L,868L,912L,957L,1003L,1050L,1098L,1147L,1197L,1248L,1300L,1353L,1407L,1462L,1518L,1575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132755Inst : IEnumerable<long>
{
public static readonly long[] Value=A132755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132755.Bytes);
public long this[int i]=>Value[i];

public static A132755Inst Instance=new A132755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132756
{
public static readonly long[] Value={ 0L,14L,29L,45L,62L,80L,99L,119L,140L,162L,185L,209L,234L,260L,287L,315L,344L,374L,405L,437L,470L,504L,539L,575L,612L,650L,689L,729L,770L,812L,855L,899L,944L,990L,1037L,1085L,1134L,1184L,1235L,1287L,1340L,1394L,1449L,1505L,1562L,1620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132756Inst : IEnumerable<long>
{
public static readonly long[] Value=A132756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132756.Bytes);
public long this[int i]=>Value[i];

public static A132756Inst Instance=new A132756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132757
{
public static readonly long[] Value={ 0L,15L,31L,48L,66L,85L,105L,126L,148L,171L,195L,220L,246L,273L,301L,330L,360L,391L,423L,456L,490L,525L,561L,598L,636L,675L,715L,756L,798L,841L,885L,930L,976L,1023L,1071L,1120L,1170L,1221L,1273L,1326L,1380L,1435L,1491L,1548L,1606L,1665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132757Inst : IEnumerable<long>
{
public static readonly long[] Value=A132757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132757.Bytes);
public long this[int i]=>Value[i];

public static A132757Inst Instance=new A132757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132758
{
public static readonly long[] Value={ 0L,16L,33L,51L,70L,90L,111L,133L,156L,180L,205L,231L,258L,286L,315L,345L,376L,408L,441L,475L,510L,546L,583L,621L,660L,700L,741L,783L,826L,870L,915L,961L,1008L,1056L,1105L,1155L,1206L,1258L,1311L,1365L,1420L,1476L,1533L,1591L,1650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132758Inst : IEnumerable<long>
{
public static readonly long[] Value=A132758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132758.Bytes);
public long this[int i]=>Value[i];

public static A132758Inst Instance=new A132758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132759
{
public static readonly long[] Value={ 0L,14L,30L,48L,68L,90L,114L,140L,168L,198L,230L,264L,300L,338L,378L,420L,464L,510L,558L,608L,660L,714L,770L,828L,888L,950L,1014L,1080L,1148L,1218L,1290L,1364L,1440L,1518L,1598L,1680L,1764L,1850L,1938L,2028L,2120L,2214L,2310L,2408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132759Inst : IEnumerable<long>
{
public static readonly long[] Value=A132759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132759.Bytes);
public long this[int i]=>Value[i];

public static A132759Inst Instance=new A132759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132792
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,6L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,20L,0L,0L,0L,0L,0L,0L,30L,0L,0L,0L,0L,0L,0L,0L,42L,0L,0L,0L,0L,0L,0L,0L,0L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,72L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,90L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,110L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132792Inst : IEnumerable<long>
{
public static readonly long[] Value=A132792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132792.Bytes);
public long this[int i]=>Value[i];

public static A132792Inst Instance=new A132792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132793
{
public static readonly long[] Value={ 3L,70L,138L,792L,924L,1692L,1932L,2124L,2250L,2988L,3852L,30936L,112644L,189252L,240120L,261660L,263928L,338760L,364308L,379470L,390432L,504216L,529110L,785568L,862290L,917700L,979596L,1022310L,1124220L,1404270L,1434072L,2004372L,2526000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132793Inst : IEnumerable<long>
{
public static readonly long[] Value=A132793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132793.Bytes);
public long this[int i]=>Value[i];

public static A132793Inst Instance=new A132793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132794
{
public static readonly long[] Value={ 8L,16L,64L,256L,16384L,262144L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132794Inst : IEnumerable<long>
{
public static readonly long[] Value=A132794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132794.Bytes);
public long this[int i]=>Value[i];

public static A132794Inst Instance=new A132794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132795
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,5L,0L,1L,0L,16L,6L,1L,1L,0L,42L,56L,21L,0L,1L,0L,99L,316L,267L,36L,1L,1L,0L,219L,1408L,2367L,960L,85L,0L,1L,0L,466L,5482L,16578L,14212L,3418L,162L,1L,1L,0L,968L,19624L,99330L,153824L,77440L,11352L,341L,0L,1L,0L,1981L,66496L,534898L,1364848L,1233970L,389104L,36829L,672L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132795Inst : IEnumerable<long>
{
public static readonly long[] Value=A132795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132795.Bytes);
public long this[int i]=>Value[i];

public static A132795Inst Instance=new A132795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132796
{
public static readonly long[] Value={ 0L,1L,0L,5L,6L,21L,36L,85L,162L,341L,672L,1365L,2718L,5461L,10908L,21845L,43674L,87381L,174744L,349525L,699030L,1398101L,2796180L,5592405L,11184786L,22369621L,44739216L,89478485L,178956942L,357913941L,715827852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132796Inst : IEnumerable<long>
{
public static readonly long[] Value=A132796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132796.Bytes);
public long this[int i]=>Value[i];

public static A132796Inst Instance=new A132796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132797
{
public static readonly long[] Value={ 0L,4L,8L,3L,3L,2L,8L,2L,1L,3L,0L,0L,5L,6L,3L,2L,3L,2L,6L,9L,1L,6L,6L,3L,4L,7L,1L,2L,5L,1L,5L,6L,6L,5L,9L,6L,5L,2L,2L,7L,0L,2L,3L,4L,1L,0L,3L,4L,0L,1L,5L,8L,2L,7L,2L,2L,9L,4L,9L,6L,7L,7L,4L,6L,8L,3L,9L,2L,7L,9L,1L,6L,6L,9L,7L,5L,0L,9L,6L,0L,6L,5L,1L,5L,2L,7L,2L,3L,8L,6L,6L,3L,8L,6L,6L,1L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132797Inst : IEnumerable<long>
{
public static readonly long[] Value=A132797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132797.Bytes);
public long this[int i]=>Value[i];

public static A132797Inst Instance=new A132797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132798
{
public static readonly long[] Value={ 0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L,0L,2L,1L,0L,-2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132798Inst : IEnumerable<long>
{
public static readonly long[] Value=A132798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132798.Bytes);
public long this[int i]=>Value[i];

public static A132798Inst Instance=new A132798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132799
{
public static readonly long[] Value={ 0L,1L,7L,6L,0L,9L,1L,1L,9L,5L,3L,3L,5L,1L,7L,9L,6L,5L,3L,8L,5L,2L,7L,8L,4L,9L,7L,3L,5L,6L,6L,3L,1L,3L,4L,2L,6L,2L,3L,8L,1L,8L,1L,8L,0L,1L,0L,7L,9L,4L,9L,6L,9L,9L,4L,0L,6L,4L,8L,0L,1L,2L,6L,8L,4L,1L,2L,8L,7L,5L,4L,9L,4L,1L,2L,3L,2L,1L,4L,4L,4L,7L,2L,5L,7L,5L,7L,7L,3L,6L,2L,4L,6L,3L,2L,1L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132799Inst : IEnumerable<long>
{
public static readonly long[] Value=A132799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132799.Bytes);
public long this[int i]=>Value[i];

public static A132799Inst Instance=new A132799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132800
{
public static readonly long[] Value={ 1L,5L,2L,7L,2L,6L,9L,0L,2L,7L,2L,5L,7L,2L,2L,4L,7L,1L,5L,2L,8L,1L,7L,5L,4L,1L,8L,7L,4L,4L,2L,5L,9L,1L,2L,4L,3L,0L,3L,4L,2L,3L,6L,4L,2L,7L,1L,4L,6L,3L,2L,9L,8L,5L,0L,8L,6L,2L,8L,8L,3L,7L,5L,3L,6L,7L,3L,2L,1L,3L,2L,2L,2L,3L,0L,9L,2L,1L,1L,0L,6L,2L,7L,0L,3L,7L,0L,9L,5L,9L,5L,5L,8L,9L,8L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132800Inst : IEnumerable<long>
{
public static readonly long[] Value=A132800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132800.Bytes);
public long this[int i]=>Value[i];

public static A132800Inst Instance=new A132800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132801
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,2L,7L,5L,8L,6L,17L,8L,23L,11L,20L,20L,44L,15L,57L,25L,40L,35L,94L,40L,101L,62L,114L,79L,184L,50L,215L,118L,155L,133L,247L,123L,378L,189L,311L,194L,532L,117L,597L,295L,373L,337L,801L,297L,825L,393L,741L,530L,1239L,399L,1088L,673L,1042L,833L,1871L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132801Inst : IEnumerable<long>
{
public static readonly long[] Value=A132801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132801.Bytes);
public long this[int i]=>Value[i];

public static A132801Inst Instance=new A132801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132802
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,5L,3L,8L,6L,7L,4L,12L,6L,7L,7L,16L,9L,15L,7L,16L,11L,9L,5L,28L,15L,13L,12L,16L,8L,20L,8L,32L,21L,19L,14L,37L,16L,15L,14L,36L,17L,28L,12L,20L,20L,11L,6L,64L,31L,34L,25L,28L,14L,33L,18L,36L,24L,17L,9L,54L,21L,17L,23L,64L,40L,49L,22L,40L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132802Inst : IEnumerable<long>
{
public static readonly long[] Value=A132802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132802.Bytes);
public long this[int i]=>Value[i];

public static A132802Inst Instance=new A132802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132803
{
public static readonly long[] Value={ 1L,2L,6L,16L,48L,204L,876L,3636L,18756L,105480L,561672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132803Inst : IEnumerable<long>
{
public static readonly long[] Value=A132803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132803.Bytes);
public long this[int i]=>Value[i];

public static A132803Inst Instance=new A132803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132804
{
public static readonly long[] Value={ 0L,6L,42L,342L,2730L,21846L,174762L,1398102L,11184810L,89478486L,715827882L,5726623062L,45812984490L,366503875926L,2932031007402L,23456248059222L,187649984473770L,1501199875790166L,12009599006321322L,96076792050570582L,768614336404564650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132804Inst : IEnumerable<long>
{
public static readonly long[] Value=A132804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132804.Bytes);
public long this[int i]=>Value[i];

public static A132804Inst Instance=new A132804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132805
{
public static readonly long[] Value={ 0L,3L,21L,171L,1365L,10923L,87381L,699051L,5592405L,44739243L,357913941L,2863311531L,22906492245L,183251937963L,1466015503701L,11728124029611L,93824992236885L,750599937895083L,6004799503160661L,48038396025285291L,384307168202282325L,3074457345618258603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132805Inst : IEnumerable<long>
{
public static readonly long[] Value=A132805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132805.Bytes);
public long this[int i]=>Value[i];

public static A132805Inst Instance=new A132805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132806
{
public static readonly long[] Value={ 0L,7L,9L,1L,6L,2L,8L,5L,1L,0L,3L,7L,8L,5L,0L,1L,4L,9L,6L,7L,1L,7L,7L,1L,1L,1L,7L,9L,6L,2L,2L,0L,8L,1L,8L,4L,6L,1L,3L,0L,3L,8L,5L,6L,9L,7L,5L,1L,8L,7L,8L,0L,8L,4L,1L,7L,9L,0L,9L,9L,9L,1L,5L,2L,3L,1L,2L,0L,9L,6L,3L,2L,6L,6L,1L,3L,8L,1L,7L,1L,1L,5L,8L,2L,7L,8L,0L,6L,7L,0L,3L,6L,0L,2L,2L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132806Inst : IEnumerable<long>
{
public static readonly long[] Value=A132806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132806.Bytes);
public long this[int i]=>Value[i];

public static A132806Inst Instance=new A132806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132807
{
public static readonly long[] Value={ 1L,2L,5L,12L,29L,73L,195L,556L,1685L,5373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132807Inst : IEnumerable<long>
{
public static readonly long[] Value=A132807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132807.Bytes);
public long this[int i]=>Value[i];

public static A132807Inst Instance=new A132807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132840
{
public static readonly long[] Value={ 1L,1L,3L,11L,44L,184L,800L,3544L,15950L,72666L,334276L,1549876L,7232910L,33939590L,160002964L,757355152L,3597467523L,17140996739L,81896369733L,392242556233L,1882772831063L,9055276934011L,43630125033845L,210563441647421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132840Inst : IEnumerable<long>
{
public static readonly long[] Value=A132840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132840.Bytes);
public long this[int i]=>Value[i];

public static A132840Inst Instance=new A132840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132841
{
public static readonly long[] Value={ 1L,3L,4L,7L,11L,12L,15L,23L,31L,33L,34L,40L,53L,59L,74L,87L,103L,111L,115L,117L,123L,124L,139L,152L,161L,185L,193L,203L,204L,222L,249L,279L,301L,309L,340L,355L,371L,383L,407L,413L,452L,467L,474L,480L,506L,509L,518L,552L,554L,583L,616L,657L,690L,705L,759L,779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132841Inst : IEnumerable<long>
{
public static readonly long[] Value=A132841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132841.Bytes);
public long this[int i]=>Value[i];

public static A132841Inst Instance=new A132841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132842
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,12L,18L,27L,40L,58L,83L,118L,167L,234L,326L,451L,621L,850L,1157L,1567L,2113L,2837L,3794L,5054L,6708L,8873L,11697L,15371L,20137L,26305L,34267L,44520L,57692L,74576L,96172L,123736L,158846L,203480L,260115L,331845L,422532L,536985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132842Inst : IEnumerable<long>
{
public static readonly long[] Value=A132842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132842.Bytes);
public long this[int i]=>Value[i];

public static A132842Inst Instance=new A132842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132843
{
public static readonly BigInteger[] Value={ 1L,2L,9L,72L,1296L,52407L,5240052L,1314516033L,853923545352L,1457086698392796L,6631460154689418828L,BigInteger.Parse("81384300080656595328843"),BigInteger.Parse("2719577128999047606509974434"),BigInteger.Parse("249432083657086432899494832228657") };
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
public class A132843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132843Inst Instance=new A132843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132844
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,3L,1L,1L,3L,9L,3L,4L,1L,1L,13L,9L,18L,4L,5L,1L,1L,13L,42L,18L,30L,5L,6L,1L,1L,73L,42L,95L,30L,45L,6L,7L,1L,1L,73L,270L,95L,179L,45L,63L,7L,8L,1L,1L,466L,270L,693L,179L,301L,63L,84L,8L,9L,1L,1L,466L,1785L,693L,1463L,301L,468L,84L,108L,9L,10L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132844Inst : IEnumerable<long>
{
public static readonly long[] Value=A132844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132844.Bytes);
public long this[int i]=>Value[i];

public static A132844Inst Instance=new A132844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132845
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,13L,9L,3L,1L,73L,42L,18L,4L,1L,466L,270L,95L,30L,5L,1L,3309L,1785L,693L,179L,45L,6L,1L,25425L,13657L,4893L,1463L,301L,63L,7L,1L,209717L,108606L,40506L,11104L,2726L,468L,84L,8L,1L,1837168L,943677L,338277L,99177L,22239L,4653L,687L,108L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132845Inst : IEnumerable<long>
{
public static readonly long[] Value=A132845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132845.Bytes);
public long this[int i]=>Value[i];

public static A132845Inst Instance=new A132845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132846
{
public static readonly long[] Value={ 1L,1L,3L,13L,73L,466L,3309L,25425L,209717L,1837168L,16995545L,164906160L,1671977735L,17635855420L,193014602116L,2185071349740L,25536219128057L,307379906553394L,3804874686396912L,48350298542927709L,629940434070025851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132846Inst : IEnumerable<long>
{
public static readonly long[] Value=A132846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132846.Bytes);
public long this[int i]=>Value[i];

public static A132846Inst Instance=new A132846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132847
{
public static readonly long[] Value={ 1L,2L,9L,42L,270L,1785L,13657L,108606L,943677L,8534290L,82099523L,819569205L,8575756709L,92782439316L,1042810799150L,12077608219410L,144446181373140L,1774918640030754L,22425992057948620L,290381947113460848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132847Inst : IEnumerable<long>
{
public static readonly long[] Value=A132847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132847.Bytes);
public long this[int i]=>Value[i];

public static A132847Inst Instance=new A132847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132848
{
public static readonly long[] Value={ 1L,3L,18L,95L,693L,4893L,40506L,338277L,3110310L,29270549L,294099936L,3036380607L,32913111931L,366636699553L,4245071555734L,50447432122893L,619067368928568L,7783987091482635L,100610823839282548L,1330119345038208405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132848Inst : IEnumerable<long>
{
public static readonly long[] Value=A132848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132848.Bytes);
public long this[int i]=>Value[i];

public static A132848Inst Instance=new A132848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132849
{
public static readonly long[] Value={ 1L,4L,30L,179L,1463L,11104L,99177L,873440L,8495091L,83411515L,875891198L,9369874178L,105309532739L,1209529820548L,14440652379524L,176281552206096L,2221616619449536L,28610926728444102L,378616619059602201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132849Inst : IEnumerable<long>
{
public static readonly long[] Value=A132849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132849.Bytes);
public long this[int i]=>Value[i];

public static A132849Inst Instance=new A132849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132850
{
public static readonly long[] Value={ 1L,2L,2L,5L,3L,2L,2L,3L,11L,2L,2L,13L,5L,2L,2L,17L,3L,2L,2L,3L,23L,2L,2L,5L,29L,2L,2L,29L,3L,2L,2L,3L,5L,2L,2L,37L,73L,2L,2L,41L,3L,2L,2L,3L,47L,2L,2L,7L,5L,2L,2L,53L,3L,2L,2L,3L,59L,2L,2L,61L,11L,2L,2L,5L,3L,2L,2L,3L,71L,2L,2L,73L,5L,2L,2L,7L,83L,2L,2L,3L,83L,2L,2L,5L,89L,2L,2L,89L,3L,2L,2L,3L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132850Inst : IEnumerable<long>
{
public static readonly long[] Value=A132850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132850.Bytes);
public long this[int i]=>Value[i];

public static A132850Inst Instance=new A132850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132851
{
public static readonly long[] Value={ 1L,2L,2L,5L,3L,2L,2L,3L,11L,10L,10L,21L,33L,46L,30L,15L,31L,6L,6L,5L,5L,26L,6L,29L,53L,78L,26L,53L,3L,2L,2L,33L,65L,14L,6L,41L,77L,114L,38L,77L,39L,10L,26L,69L,113L,158L,102L,149L,197L,246L,74L,5L,57L,110L,82L,137L,193L,10L,34L,93L,51L,14L,38L,101L,165L,230L,74L,141L,209L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132851Inst : IEnumerable<long>
{
public static readonly long[] Value=A132851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132851.Bytes);
public long this[int i]=>Value[i];

public static A132851Inst Instance=new A132851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132852
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,14L,62L,462L,5380L,105626L,3440686L,196429906L,19603795552L,3496015313038L,1120368106124268L,653253602487886098L,BigInteger.Parse("697073727912597623594"),BigInteger.Parse("1371575342274982257650434") };
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
public class A132852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132852Inst Instance=new A132852Inst();

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