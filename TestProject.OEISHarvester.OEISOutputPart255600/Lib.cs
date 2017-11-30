using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A134046
{
public static readonly BigInteger[] Value={ 1L,2L,-2L,-20L,-394L,-72756L,-38636660L,-62621451464L,-320115036508314L,-5370757579794299764L,BigInteger.Parse("-307243789286348665328060"),BigInteger.Parse("-61750332256061511777753774808"),BigInteger.Parse("-44549932891827456895274618101297860"),BigInteger.Parse("-117151486172958209318246658698308578710856") };
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
public class A134046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134046Inst Instance=new A134046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134047
{
public static readonly BigInteger[] Value={ 1L,2L,6L,50L,1586L,182274L,70856770L,91955753218L,404598404260610L,6173936430806583298L,BigInteger.Parse("333433524033498566071298"),BigInteger.Parse("64757369178015130100982820866"),BigInteger.Parse("45786845522362297626576735328694274") };
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
public class A134047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134047Inst Instance=new A134047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134048
{
public static readonly BigInteger[] Value={ 1L,4L,28L,548L,35108L,7507972L,5383397764L,13122109416964L,110735166982705668L,BigInteger.Parse("3291956693540520243204"),BigInteger.Parse("349880644048154072353961988"),BigInteger.Parse("134569675810924626719483447943172") };
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
public class A134048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134048Inst Instance=new A134048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134049
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,23L,40L,16L,1L,512L,1072L,576L,64L,1L,34939L,84736L,56064L,8704L,256L,1L,7637688L,20930240L,16261120L,3190784L,135168L,1024L,1L,5539372954L,16855075840L,14918594560L,3501457408L,191561728L,2129920L,4096L,1L,13703105571256L,45696508860928L,45120522420224L,12230958252032L,813938245632L,11856248832L,33816576L,16384L,1L,118149647382446899L,427467706869837824L,463647865862488064L,141682892446105600L,11040640699727872L,197960679817216L,745898246144L,538968064L,65536L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134049Inst : IEnumerable<long>
{
public static readonly long[] Value=A134049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134049.Bytes);
public long this[int i]=>Value[i];

public static A134049Inst Instance=new A134049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134050
{
public static readonly BigInteger[] Value={ 1L,1L,3L,23L,512L,34939L,7637688L,5539372954L,13703105571256L,118149647382446899L,BigInteger.Parse("3611029954044991125872"),BigInteger.Parse("396437704741571722701763726"),BigInteger.Parse("158000007601023255711816905096600"),BigInteger.Parse("230573407734730856178976755626889887934"),BigInteger.Parse("1240859469782266733203067689710529642528338320"),BigInteger.Parse("24774501349228223607795736923546381007921447933762900"),BigInteger.Parse("1844552309599593759846481462075800633418691335116469275638832"),BigInteger.Parse("514424614172853969912935745275645969935778834184491996786063734076739") };
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
public class A134050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134050Inst Instance=new A134050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134051
{
public static readonly BigInteger[] Value={ 1L,2L,10L,134L,5296L,654070L,263360560L,357003975476L,1669795729960304L,BigInteger.Parse("27463303283181254246"),BigInteger.Parse("1611997717693371814854368"),BigInteger.Parse("341658984940005114542280763676"),BigInteger.Parse("263970944698309599873282861747395376"),BigInteger.Parse("749286382285580603530480750573407791776124"),BigInteger.Parse("7865298802379026632132665433693770690173266977568"),BigInteger.Parse("307033171145749412684239046186235780900756052952468535976"),BigInteger.Parse("44787318088048191911792372704769709799574702261206913048329680992") };
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
public class A134051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134051Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134051.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134051Inst Instance=new A134051Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134052
{
public static readonly BigInteger[] Value={ 1L,4L,36L,876L,63520L,14568940L,11015752544L,28298819937896L,252647456547947232L,BigInteger.Parse("7975964313047992544460"),BigInteger.Parse("902538504812752048885181888"),BigInteger.Parse("370060584941821136890734642254392"),BigInteger.Parse("554686213433000991860635347227024504416"),BigInteger.Parse("3061850209996287672654225041045426728192508664"),BigInteger.Parse("62630012990169232252394969915444571881064532934837824"),BigInteger.Parse("4772629734773204290203117007836601388039453077250181639664976"),BigInteger.Parse("1361188462171480354335535757250707673963106696295682082795368090890432") };
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
public class A134052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134052Inst Instance=new A134052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134053
{
public static readonly BigInteger[] Value={ 1L,8L,136L,6232L,854848L,373259224L,540477342400L,2672052251004112L,BigInteger.Parse("46088422295844824512"),BigInteger.Parse("2819594595499446574537112"),BigInteger.Parse("619804662273405542773923781504"),BigInteger.Parse("494669890490702036481614523776214128"),BigInteger.Parse("1445689562032160359098054773761542867676352"),BigInteger.Parse("15582205179106128515694061249394708070061006521840"),BigInteger.Parse("623164384826393004269624677225320058520632702496162024576"),BigInteger.Parse("92950754406669433360560292231532867334028809841256765779355298464"),BigInteger.Parse("51944751631411703759398930923077536382840396924192243346470672357124333952") };
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
public class A134053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134053Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134053.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134053Inst Instance=new A134053Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134054
{
public static readonly BigInteger[] Value={ 1L,2L,8L,80L,2225L,184700L,48156025L,41008196507L,117576923431865L,1162187460377703220L,BigInteger.Parse("40342092016795699709297"),BigInteger.Parse("4989979910857539524339725455"),BigInteger.Parse("2225169577804416081963640015838617"),BigInteger.Parse("3611404965468239375529128539282974032063"),BigInteger.Parse("21500912257369373138838006883103647202061119889"),BigInteger.Parse("472700949365256437455861341996789835116478103190166869"),BigInteger.Parse("38594839432514958712997836406329517947410813633064955364162609"),BigInteger.Parse("11760334792404044930820367474465749383281197807007630470152427553813828") };
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
public class A134054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134054Inst Instance=new A134054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134055
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,41L,252L,1782L,14121L,123244L,1169832L,11960978L,130742196L,1518514076L,18645970943L,241030821566L,3268214127548L,46338504902485L,685145875623056L,10538790233183702L,168282662416550040L,2784205185437851772L,BigInteger.Parse("47646587512911994120") };
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
public class A134055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134055Inst Instance=new A134055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134088
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,154L,7994L,1411258L,848676922L,1764762791994L,12941488236663354L,BigInteger.Parse("340293140598066707002"),BigInteger.Parse("32482040675729485295718970"),BigInteger.Parse("11360194868358667204706510295610") };
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
public class A134088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134088Inst Instance=new A134088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134089
{
public static readonly BigInteger[] Value={ 1L,2L,8L,84L,2676L,275700L,94775156L,111378681460L,457034829332596L,6660551038769802356L,BigInteger.Parse("349287637698829559108724"),BigInteger.Parse("66597190541338218944629998708"),BigInteger.Parse("46556095585511177615107782087451764") };
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
public class A134089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134089Inst Instance=new A134089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134090
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,13L,9L,3L,1L,71L,46L,18L,4L,1L,456L,285L,110L,30L,5L,1L,3337L,2021L,780L,215L,45L,6L,1L,27203L,16023L,6167L,1729L,371L,63L,7L,1L,243203L,139812L,53494L,15176L,3346L,588L,84L,8L,1L,2357356L,1326111L,504030L,143814L,32376L,5886L,876L,108L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134090Inst : IEnumerable<long>
{
public static readonly long[] Value=A134090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134090.Bytes);
public long this[int i]=>Value[i];

public static A134090Inst Instance=new A134090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134091
{
public static readonly long[] Value={ 1L,2L,9L,46L,285L,2021L,16023L,139812L,1326111L,13544857L,147880458L,1715413558L,21036674321L,271585117428L,3677831536291L,52081368845176L,769123715337395L,11816582501728389L,188470925178659344L,3114771205613655362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134091Inst : IEnumerable<long>
{
public static readonly long[] Value=A134091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134091.Bytes);
public long this[int i]=>Value[i];

public static A134091Inst Instance=new A134091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134092
{
public static readonly long[] Value={ 1L,3L,18L,110L,780L,6167L,53494L,504030L,5112090L,55411697L,638154165L,7770348170L,99618149267L,1339889000543L,18848892749144L,276573551651632L,4222814264496510L,66947348027905977L,1099955438013660173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134092Inst : IEnumerable<long>
{
public static readonly long[] Value=A134092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134092.Bytes);
public long this[int i]=>Value[i];

public static A134092Inst Instance=new A134092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134093
{
public static readonly long[] Value={ 1L,4L,30L,215L,1729L,15176L,143814L,1462995L,15876410L,182811992L,2223580281L,28458251185L,381943459065L,5359649816728L,78430018675440L,1194057733357517L,18873870914263424L,309154787519651284L,5238840625331179517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134093Inst : IEnumerable<long>
{
public static readonly long[] Value=A134093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134093.Bytes);
public long this[int i]=>Value[i];

public static A134093Inst Instance=new A134093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134094
{
public static readonly long[] Value={ 1L,2L,6L,26L,140L,887L,6405L,51564L,455712L,4370567L,45081476L,496556194L,5806502663L,71734434956L,932447207866L,12707973761320L,181033752071568L,2688530124711819L,41525910256013832L,665674913113633582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134094Inst : IEnumerable<long>
{
public static readonly long[] Value=A134094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134094.Bytes);
public long this[int i]=>Value[i];

public static A134094Inst Instance=new A134094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134095
{
public static readonly BigInteger[] Value={ 1L,0L,2L,12L,120L,1480L,22320L,396564L,8118656L,188185680L,4871980800L,139342178140L,4363291266048L,148470651659928L,5455056815237120L,215238256785814500L,9077047768435752960L,BigInteger.Parse("407449611073696325536") };
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
public class A134095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134095Inst Instance=new A134095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134096
{
public static readonly BigInteger[] Value={ 1L,2L,11L,247L,87453L,30392377L,83081803051L,447717938403725L,BigInteger.Parse("76261525038193025805"),BigInteger.Parse("6426287262393575837153381"),BigInteger.Parse("4292008745048222678362226977889"),BigInteger.Parse("5685934933249315447199351722237681091") };
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
public class A134096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134096Inst Instance=new A134096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134097
{
public static readonly BigInteger[] Value={ 1L,1L,5L,51L,9163L,1789359L,2966784613L,10246481110899L,1164644624885859315L,BigInteger.Parse("67519816893223600328475"),BigInteger.Parse("31778915061906077887063371935"),BigInteger.Parse("30252957250679839624103772879830589") };
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
public class A134097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134097Inst Instance=new A134097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134098
{
public static readonly BigInteger[] Value={ 1L,1L,-3L,35L,-7285L,1570863L,-2762459931L,9861642254451L,-1141290059372782605L,BigInteger.Parse("66806775363324062981915"),BigInteger.Parse("-31603810290612531279241668449"),BigInteger.Parse("30166547730607848261858185370275389"),BigInteger.Parse("-464256425980552239880944863449968127087425") };
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
public class A134098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134098Inst Instance=new A134098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134099
{
public static readonly long[] Value={ 25L,33L,49L,55L,63L,75L,85L,91L,115L,133L,141L,153L,159L,169L,175L,183L,201L,213L,235L,243L,253L,259L,265L,273L,285L,295L,319L,333L,339L,355L,361L,369L,375L,385L,391L,403L,411L,423L,435L,445L,451L,469L,481L,493L,505L,511L,525L,543L,549L,559L,565L,573L,579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134099Inst : IEnumerable<long>
{
public static readonly long[] Value=A134099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134099.Bytes);
public long this[int i]=>Value[i];

public static A134099Inst Instance=new A134099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134100
{
public static readonly long[] Value={ 29L,37L,53L,59L,67L,79L,89L,97L,127L,137L,149L,157L,163L,173L,179L,191L,211L,223L,239L,251L,257L,263L,269L,277L,293L,307L,331L,337L,347L,359L,367L,373L,379L,389L,397L,409L,419L,431L,439L,449L,457L,479L,487L,499L,509L,521L,541L,547L,557L,563L,569L,577L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134100Inst : IEnumerable<long>
{
public static readonly long[] Value=A134100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134100.Bytes);
public long this[int i]=>Value[i];

public static A134100Inst Instance=new A134100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134101
{
public static readonly long[] Value={ 27L,35L,51L,57L,65L,77L,87L,95L,125L,135L,147L,155L,161L,171L,177L,189L,209L,221L,237L,249L,255L,261L,267L,275L,291L,305L,329L,335L,345L,357L,365L,371L,377L,387L,395L,407L,417L,429L,437L,447L,455L,477L,485L,497L,507L,519L,539L,545L,555L,561L,567L,575L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134101Inst : IEnumerable<long>
{
public static readonly long[] Value=A134101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134101.Bytes);
public long this[int i]=>Value[i];

public static A134101Inst Instance=new A134101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134102
{
public static readonly long[] Value={ 3L,10L,15L,17L,21L,35L,60L,165L,465L,2415L,6159L,6576L,611085363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134102Inst : IEnumerable<long>
{
public static readonly long[] Value=A134102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134102.Bytes);
public long this[int i]=>Value[i];

public static A134102Inst Instance=new A134102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134103
{
public static readonly long[] Value={ -6L,-5L,0L,4L,6L,10L,15L,30L,60L,180L,336L,351L,720114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134103Inst : IEnumerable<long>
{
public static readonly long[] Value=A134103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134103.Bytes);
public long this[int i]=>Value[i];

public static A134103Inst Instance=new A134103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134168
{
public static readonly long[] Value={ 1L,3L,9L,30L,111L,438L,1779L,7290L,29871L,121998L,496299L,2011650L,8129031L,32769558L,131850819L,529745610L,2126058591L,8525561118L,34166421339L,136858609170L,548013994551L,2193796224678L,8780408783859L,35137313082330L,140596298752911L,562526359448238L,2250528981434379L,9003386657325090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134168Inst : IEnumerable<long>
{
public static readonly long[] Value=A134168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134168.Bytes);
public long this[int i]=>Value[i];

public static A134168Inst Instance=new A134168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134169
{
public static readonly long[] Value={ 1L,2L,7L,29L,121L,497L,2017L,8129L,32641L,130817L,523777L,2096129L,8386561L,33550337L,134209537L,536854529L,2147450881L,8589869057L,34359607297L,137438691329L,549755289601L,2199022206977L,8796090925057L,35184367894529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134169Inst : IEnumerable<long>
{
public static readonly long[] Value=A134169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134169.Bytes);
public long this[int i]=>Value[i];

public static A134169Inst Instance=new A134169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134170
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,12L,21L,24L,36L,40L,60L,60L,84L,84L,112L,112L,144L,144L,180L,180L,240L,252L,308L,336L,336L,400L,432L,432L,504L,540L,540L,651L,660L,660L,792L,792L,792L,936L,936L,936L,1080L,1092L,1092L,1260L,1260L,1260L,1440L,1440L,1440L,1680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134170Inst : IEnumerable<long>
{
public static readonly long[] Value=A134170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134170.Bytes);
public long this[int i]=>Value[i];

public static A134170Inst Instance=new A134170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134171
{
public static readonly long[] Value={ 0L,0L,0L,27L,108L,270L,540L,945L,1512L,2268L,3240L,4455L,5940L,7722L,9828L,12285L,15120L,18360L,22032L,26163L,30780L,35910L,41580L,47817L,54648L,62100L,70200L,78975L,88452L,98658L,109620L,121365L,133920L,147312L,161568L,176715L,192780L,209790L,227772L,246753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134171Inst : IEnumerable<long>
{
public static readonly long[] Value=A134171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134171.Bytes);
public long this[int i]=>Value[i];

public static A134171Inst Instance=new A134171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134172
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,1L,4L,5L,2L,2L,7L,8L,3L,3L,10L,11L,4L,4L,13L,14L,5L,5L,16L,17L,6L,6L,19L,20L,7L,7L,22L,23L,8L,8L,25L,26L,9L,9L,28L,29L,10L,10L,31L,32L,11L,11L,34L,35L,12L,12L,37L,38L,13L,13L,40L,41L,14L,14L,43L,44L,15L,15L,46L,47L,16L,16L,49L,50L,17L,17L,52L,53L,18L,18L,55L,56L,19L,19L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134172Inst : IEnumerable<long>
{
public static readonly long[] Value=A134172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134172.Bytes);
public long this[int i]=>Value[i];

public static A134172Inst Instance=new A134172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134173
{
public static readonly BigInteger[] Value={ 1L,3L,8L,68L,2106L,223776L,80532200L,98945392200L,421225839051260L,6310402120912239968L,BigInteger.Parse("337401124757628967733136"),BigInteger.Parse("65171905481441631827737564000"),BigInteger.Parse("45944096973025484590366745753166436") };
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
public class A134173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134173Inst Instance=new A134173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134174
{
public static readonly BigInteger[] Value={ 1L,1L,4L,44L,1546L,180096L,69656776L,90247564712L,398349418563148L,6107204301234263072L,BigInteger.Parse("331155704662551903747856"),BigInteger.Parse("64494012244416274972130226976"),BigInteger.Parse("45679970430008422082570864807000804"),BigInteger.Parse("118841746271330792971612314663523090972880"),BigInteger.Parse("1144692720783363684402532942114790915481788335224") };
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
public class A134174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134174Inst Instance=new A134174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134175
{
public static readonly long[] Value={ 0L,0L,0L,0L,384L,1920L,5760L,13440L,26880L,48384L,80640L,126720L,190080L,274560L,384384L,524160L,698880L,913920L,1175040L,1488384L,1860480L,2298240L,2808960L,3400320L,4080384L,4857600L,5740800L,6739200L,7862400L,9120384L,10523520L,12082560L,13808640L,15713280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134175Inst : IEnumerable<long>
{
public static readonly long[] Value=A134175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134175.Bytes);
public long this[int i]=>Value[i];

public static A134175Inst Instance=new A134175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134176
{
public static readonly long[] Value={ 0L,0L,9L,144L,765L,2475L,6120L,12789L,23814L,40770L,65475L,99990L,146619L,207909L,286650L,385875L,508860L,659124L,840429L,1056780L,1312425L,1611855L,1959804L,2361249L,2821410L,3345750L,3939975L,4610034L,5362119L,6202665L,7138350L,8176095L,9323064L,10586664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134176Inst : IEnumerable<long>
{
public static readonly long[] Value=A134176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134176.Bytes);
public long this[int i]=>Value[i];

public static A134176Inst Instance=new A134176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134177
{
public static readonly long[] Value={ 1L,1L,-2L,-2L,1L,2L,0L,-2L,0L,0L,-2L,0L,3L,1L,-2L,-2L,2L,4L,0L,0L,0L,0L,-2L,0L,3L,0L,-2L,-4L,0L,2L,0L,-2L,0L,0L,0L,0L,2L,3L,-4L,-2L,1L,2L,0L,-2L,0L,0L,-2L,0L,2L,2L,-2L,-2L,4L,2L,0L,0L,0L,0L,0L,0L,3L,0L,-4L,-2L,0L,2L,0L,-2L,0L,0L,0L,0L,4L,3L,-2L,-2L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134177Inst : IEnumerable<long>
{
public static readonly long[] Value=A134177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134177.Bytes);
public long this[int i]=>Value[i];

public static A134177Inst Instance=new A134177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134178
{
public static readonly long[] Value={ 1L,1L,-2L,-2L,0L,1L,2L,0L,0L,-1L,-4L,0L,1L,0L,6L,2L,0L,1L,-8L,0L,0L,0L,12L,0L,-1L,-1L,-18L,-4L,0L,-1L,24L,0L,0L,2L,-32L,0L,0L,1L,44L,6L,0L,-2L,-58L,0L,0L,-1L,76L,0L,1L,2L,-100L,-8L,0L,1L,128L,0L,0L,-3L,-164L,0L,0L,-1L,210L,12L,0L,4L,-264L,0L,0L,2L,332L,0L,-1L,-5L,-416L,-18L,0L,-2L,516L,0L,0L,5L,-640L,0L,-1L,2L,790L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134178Inst : IEnumerable<long>
{
public static readonly long[] Value=A134178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134178.Bytes);
public long this[int i]=>Value[i];

public static A134178Inst Instance=new A134178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134179
{
public static readonly long[] Value={ 2L,31L,199L,659L,1601L,5693L,38917L,51797L,84463L,697373L,8059169L,8510617L,9465251L,28268543L,36254039L,40121999L,48667219L,54973229L,63627491L,90443813L,97626083L,102534899L,110364689L,139100699L,161967391L,183528421L,219566989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134179Inst : IEnumerable<long>
{
public static readonly long[] Value=A134179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134179.Bytes);
public long this[int i]=>Value[i];

public static A134179Inst Instance=new A134179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134180
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,23L,25L,29L,55L,117L,119L,123L,173L,187L,193L,205L,213L,223L,249L,255L,259L,265L,285L,299L,311L,329L,351L,393L,397L,411L,483L,487L,513L,515L,525L,563L,587L,597L,607L,637L,645L,647L,679L,709L,789L,871L,877L,911L,953L,971L,985L,1015L,1051L,1075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134180Inst : IEnumerable<long>
{
public static readonly long[] Value=A134180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134180.Bytes);
public long this[int i]=>Value[i];

public static A134180Inst Instance=new A134180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134181
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,8L,12L,18L,28L,38L,52L,68L,84L,102L,124L,150L,176L,206L,238L,270L,306L,344L,386L,434L,484L,534L,586L,638L,692L,758L,826L,898L,970L,1050L,1130L,1214L,1302L,1392L,1486L,1584L,1682L,1788L,1894L,2002L,2110L,2228L,2356L,2486L,2616L,2748L,2884L,3020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134181Inst : IEnumerable<long>
{
public static readonly long[] Value=A134181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134181.Bytes);
public long this[int i]=>Value[i];

public static A134181Inst Instance=new A134181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134182
{
public static readonly long[] Value={ 38L,14478L,2688838L,396250152L,52261798440L,6472980453364L,770530574266708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134182Inst : IEnumerable<long>
{
public static readonly long[] Value=A134182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134182.Bytes);
public long this[int i]=>Value[i];

public static A134182Inst Instance=new A134182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134183
{
public static readonly BigInteger[] Value={ 0L,1L,16L,768L,131072L,83886080L,206158430208L,1970324836974592L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("10880332376531662572355584"),BigInteger.Parse("6338253001141147007483516026880") };
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
public class A134183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134183Inst Instance=new A134183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134328
{
public static readonly long[] Value={ 0L,121L,125L,625L,32L,64L,128L,256L,512L,0L,0L,219122L,24344L,4802L,6250L,31250L,4374L,13122L,39366L,0L,10170397L,24964L,8575L,2500L,12500L,2916L,8748L,26244L,78732L,31855013L,118459L,6125L,2744L,5000L,25000L,5832L,17496L,52488L,157464L,279841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134328Inst : IEnumerable<long>
{
public static readonly long[] Value=A134328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134328.Bytes);
public long this[int i]=>Value[i];

public static A134328Inst Instance=new A134328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134329
{
public static readonly long[] Value={ 7L,10L,24L,26L,43L,57L,74L,76L,107L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134329Inst : IEnumerable<long>
{
public static readonly long[] Value=A134329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134329.Bytes);
public long this[int i]=>Value[i];

public static A134329Inst Instance=new A134329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134330
{
public static readonly long[] Value={ 1L,4L,16L,27L,30L,60L,70L,72L,84L,105L,150L,180L,220L,231L,240L,256L,286L,288L,308L,378L,440L,450L,476L,528L,540L,560L,576L,588L,594L,624L,627L,646L,648L,650L,728L,800L,805L,840L,884L,897L,900L,945L,960L,1008L,1040L,1056L,1080L,1100L,1122L,1134L,1160L,1170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134330Inst : IEnumerable<long>
{
public static readonly long[] Value=A134330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134330.Bytes);
public long this[int i]=>Value[i];

public static A134330Inst Instance=new A134330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134331
{
public static readonly long[] Value={ 0L,4L,6L,8L,10L,12L,14L,12L,12L,18L,22L,19L,26L,22L,19L,16L,34L,22L,38L,22L,23L,32L,46L,23L,20L,36L,18L,26L,58L,37L,62L,20L,34L,46L,29L,29L,74L,50L,38L,31L,82L,38L,86L,36L,30L,58L,94L,30L,28L,32L,46L,40L,106L,30L,37L,37L,50L,70L,118L,41L,122L,74L,36L,24L,41L,48L,134L,50L,58L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134331Inst : IEnumerable<long>
{
public static readonly long[] Value=A134331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134331.Bytes);
public long this[int i]=>Value[i];

public static A134331Inst Instance=new A134331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134332
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,3L,3L,11L,2L,13L,3L,3L,2L,17L,2L,19L,2L,4L,4L,23L,2L,5L,5L,3L,3L,29L,3L,31L,2L,5L,5L,5L,2L,37L,6L,6L,2L,41L,3L,43L,4L,3L,7L,47L,2L,7L,3L,7L,4L,53L,2L,7L,3L,8L,8L,59L,2L,61L,9L,4L,2L,8L,3L,67L,5L,9L,3L,71L,2L,73L,9L,4L,5L,8L,4L,79L,2L,3L,9L,83L,3L,9L,11L,10L,3L,89L,2L,9L,6L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134332Inst : IEnumerable<long>
{
public static readonly long[] Value=A134332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134332.Bytes);
public long this[int i]=>Value[i];

public static A134332Inst Instance=new A134332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134333
{
public static readonly long[] Value={ 4L,6L,10L,12L,14L,18L,22L,26L,27L,30L,34L,38L,42L,45L,46L,58L,62L,63L,66L,74L,75L,78L,80L,82L,86L,94L,99L,102L,105L,106L,114L,117L,118L,120L,122L,134L,138L,142L,146L,147L,153L,158L,165L,166L,171L,174L,178L,180L,186L,194L,195L,200L,202L,206L,207L,214L,218L,222L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134333Inst : IEnumerable<long>
{
public static readonly long[] Value=A134333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134333.Bytes);
public long this[int i]=>Value[i];

public static A134333Inst Instance=new A134333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134334
{
public static readonly long[] Value={ 8L,9L,15L,20L,21L,25L,28L,32L,33L,35L,39L,44L,48L,49L,50L,51L,52L,54L,55L,57L,64L,65L,68L,69L,70L,72L,76L,77L,81L,85L,87L,90L,91L,92L,93L,95L,98L,108L,110L,111L,112L,115L,116L,119L,121L,123L,124L,125L,126L,128L,129L,130L,133L,135L,141L,143L,145L,148L,150L,154L,155L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134334Inst : IEnumerable<long>
{
public static readonly long[] Value=A134334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134334.Bytes);
public long this[int i]=>Value[i];

public static A134334Inst Instance=new A134334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134335
{
public static readonly long[] Value={ 15L,35L,39L,42L,50L,51L,55L,65L,77L,78L,87L,91L,92L,95L,110L,111L,114L,115L,119L,123L,140L,141L,143L,155L,159L,161L,164L,170L,183L,185L,186L,187L,189L,201L,203L,204L,209L,215L,219L,221L,222L,225L,230L,235L,236L,242L,247L,258L,259L,264L,267L,284L,285L,287L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134335Inst : IEnumerable<long>
{
public static readonly long[] Value=A134335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134335.Bytes);
public long this[int i]=>Value[i];

public static A134335Inst Instance=new A134335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134336
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,21L,22L,23L,32L,33L,34L,43L,44L,45L,54L,55L,56L,65L,66L,67L,76L,77L,78L,87L,88L,89L,98L,99L,100L,101L,102L,110L,111L,112L,120L,121L,122L,123L,132L,201L,210L,211L,212L,213L,221L,222L,223L,231L,232L,233L,234L,243L,312L,321L,322L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134336Inst : IEnumerable<long>
{
public static readonly long[] Value=A134336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134336.Bytes);
public long this[int i]=>Value[i];

public static A134336Inst Instance=new A134336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134337
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,3L,4L,3L,4L,5L,5L,6L,6L,7L,8L,7L,8L,9L,9L,11L,10L,12L,14L,14L,16L,17L,20L,21L,21L,25L,27L,27L,29L,31L,35L,35L,36L,42L,44L,45L,49L,55L,59L,61L,66L,74L,77L,81L,87L,93L,99L,102L,110L,117L,123L,131L,138L,148L,159L,167L,178L,190L,204L,215L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134337Inst : IEnumerable<long>
{
public static readonly long[] Value=A134337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134337.Bytes);
public long this[int i]=>Value[i];

public static A134337Inst Instance=new A134337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134338
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,6L,7L,32L,27L,50L,11L,72L,13L,98L,225L,512L,17L,972L,19L,200L,441L,242L,23L,13824L,125L,338L,729L,10976L,29L,4500L,31L,16384L,1089L,578L,1225L,419904L,37L,722L,1521L,64000L,41L,12348L,43L,42592L,91125L,1058L,47L,10616832L,343L,62500L,2601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134338Inst : IEnumerable<long>
{
public static readonly long[] Value=A134338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134338.Bytes);
public long this[int i]=>Value[i];

public static A134338Inst Instance=new A134338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134339
{
public static readonly long[] Value={ 2L,2L,6L,2L,2L,24L,2L,2L,6L,40L,2L,24L,2L,2L,180L,2L,2L,24L,2L,40L,252L,2L,2L,24L,2L,2L,6L,112L,2L,720L,2L,2L,6L,2L,2L,1728L,2L,2L,6L,40L,2L,1008L,2L,2L,16200L,2L,2L,24L,2L,40L,6L,2L,2L,24L,220L,112L,6L,2L,2L,720L,2L,2L,252L,2L,2L,3168L,2L,2L,6L,40L,2L,1728L,2L,2L,180L,2L,2L,3744L,2L,40L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134339Inst : IEnumerable<long>
{
public static readonly long[] Value=A134339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134339.Bytes);
public long this[int i]=>Value[i];

public static A134339Inst Instance=new A134339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134340
{
public static readonly long[] Value={ 1L,5L,12L,22L,35L,50L,70L,92L,117L,145L,170L,210L,250L,287L,330L,362L,425L,477L,532L,600L,626L,715L,782L,850L,925L,962L,1100L,1162L,1247L,1335L,1370L,1520L,1617L,1750L,1810L,1850L,2040L,2147L,2262L,2380L,2451L,2625L,2752L,2882L,3015L,3005L,3290L,3500L,3577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134340Inst : IEnumerable<long>
{
public static readonly long[] Value=A134340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134340.Bytes);
public long this[int i]=>Value[i];

public static A134340Inst Instance=new A134340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134341
{
public static readonly long[] Value={ 144L,288L,432L,576L,720L,864L,1008L,1152L,1296L,1440L,1584L,1728L,1872L,2016L,2160L,2304L,2448L,2592L,2736L,2880L,3024L,3168L,3312L,3456L,3600L,3744L,3888L,4032L,4176L,4320L,4464L,4608L,4752L,4896L,5040L,5184L,5328L,5472L,5616L,5760L,5904L,6048L,6192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134341Inst : IEnumerable<long>
{
public static readonly long[] Value=A134341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134341.Bytes);
public long this[int i]=>Value[i];

public static A134341Inst Instance=new A134341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134342
{
public static readonly long[] Value={ 0L,2L,5L,9L,15L,24L,38L,59L,90L,137L,207L,312L,470L,707L,1062L,1595L,2394L,3593L,5391L,8088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134342Inst : IEnumerable<long>
{
public static readonly long[] Value=A134342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134342.Bytes);
public long this[int i]=>Value[i];

public static A134342Inst Instance=new A134342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134343
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,2L,0L,3L,-2L,0L,-2L,2L,-2L,1L,-2L,0L,-2L,4L,0L,2L,0L,1L,-4L,2L,0L,2L,-2L,0L,-2L,2L,-2L,1L,-4L,0L,0L,2L,0L,4L,-2L,2L,-2L,0L,0L,3L,-2L,0L,-2L,4L,0L,2L,-2L,0L,-4L,0L,0L,0L,-4L,3L,-2L,2L,0L,2L,-2L,0L,0L,2L,-2L,4L,-2L,0L,-2L,2L,0L,3L,-2L,0L,0L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134343Inst : IEnumerable<long>
{
public static readonly long[] Value=A134343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134343.Bytes);
public long this[int i]=>Value[i];

public static A134343Inst Instance=new A134343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134376
{
public static readonly long[] Value={ 1L,4L,8L,9L,14L,15L,16L,18L,20L,21L,24L,25L,26L,27L,30L,32L,33L,35L,36L,38L,39L,42L,44L,46L,49L,50L,51L,55L,57L,60L,62L,64L,65L,66L,68L,69L,70L,72L,74L,77L,78L,81L,84L,85L,86L,87L,91L,92L,93L,94L,95L,98L,100L,102L,105L,106L,110L,111L,112L,114L,115L,116L,119L,120L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134376Inst : IEnumerable<long>
{
public static readonly long[] Value=A134376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134376.Bytes);
public long this[int i]=>Value[i];

public static A134376Inst Instance=new A134376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134377
{
public static readonly long[] Value={ 1L,3L,10L,32L,101L,315L,975L,3001L,9199L,28109L,85680L,260650L,791663L,2401313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134377Inst : IEnumerable<long>
{
public static readonly long[] Value=A134377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134377.Bytes);
public long this[int i]=>Value[i];

public static A134377Inst Instance=new A134377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134378
{
public static readonly BigInteger[] Value={ 1L,2L,5L,14L,44L,158L,663L,3310L,19759L,139660L,1147120L,10729684L,112309193L,1297522650L,16371057801L,223716758346L,3289199827236L,51745234494858L,867023125576027L,15411557297930534L,289610871340870883L,5736017561257017128L,BigInteger.Parse("119413599371241577016") };
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
public class A134378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134378Inst Instance=new A134378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134379
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,5L,3L,1L,15L,15L,9L,4L,1L,54L,54L,30L,14L,5L,1L,235L,235L,115L,51L,20L,6L,1L,1237L,1237L,517L,205L,79L,27L,7L,1L,7790L,7790L,2750L,938L,332L,115L,35L,8L,1L,57581L,57581L,17261L,4973L,1545L,505L,160L,44L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134379Inst : IEnumerable<long>
{
public static readonly long[] Value=A134379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134379.Bytes);
public long this[int i]=>Value[i];

public static A134379Inst Instance=new A134379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134380
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,8L,5L,1L,1L,24L,19L,7L,1L,1L,89L,71L,34L,9L,1L,1L,415L,290L,150L,53L,11L,1L,1L,2372L,1362L,672L,269L,76L,13L,1L,1L,16072L,7486L,3252L,1319L,436L,103L,15L,1L,1L,125673L,48054L,17618L,6671L,2331L,659L,134L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134380Inst : IEnumerable<long>
{
public static readonly long[] Value=A134380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134380.Bytes);
public long this[int i]=>Value[i];

public static A134380Inst Instance=new A134380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134381
{
public static readonly BigInteger[] Value={ 1L,2L,5L,15L,52L,205L,921L,4766L,28685L,201159L,1630840L,15071725L,156331161L,1794763970L,22548418541L,307236496071L,4507944378004L,70813851019717L,1185225078743601L,21049903662123422L,395303080572770549L,7825181077750155999L,BigInteger.Parse("162835332607069248760") };
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
public class A134381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134381Inst Instance=new A134381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134382
{
public static readonly long[] Value={ 20L,140L,464L,660L,1276L,1365L,2204L,2508L,2805L,2907L,5590L,5698L,5742L,6006L,7395L,8680L,14645L,15052L,18875L,19170L,19740L,23871L,34579L,34804L,35164L,35244L,35934L,38121L,106805L,114953L,261536L,503082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134382Inst : IEnumerable<long>
{
public static readonly long[] Value=A134382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134382.Bytes);
public long this[int i]=>Value[i];

public static A134382Inst Instance=new A134382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134383
{
public static readonly long[] Value={ 6L,12L,10L,24L,12L,16L,12L,24L,16L,12L,16L,16L,24L,32L,16L,32L,8L,12L,8L,32L,48L,8L,4L,24L,12L,36L,16L,8L,8L,4L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134383Inst : IEnumerable<long>
{
public static readonly long[] Value=A134383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134383.Bytes);
public long this[int i]=>Value[i];

public static A134383Inst Instance=new A134383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134384
{
public static readonly long[] Value={ 7L,14L,31L,21L,42L,28L,50L,35L,36L,39L,63L,57L,45L,36L,54L,45L,135L,126L,156L,81L,64L,185L,380L,133L,210L,105L,171L,231L,567L,966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134384Inst : IEnumerable<long>
{
public static readonly long[] Value=A134384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134384.Bytes);
public long this[int i]=>Value[i];

public static A134384Inst Instance=new A134384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134385
{
public static readonly long[] Value={ 42L,168L,310L,504L,504L,448L,600L,840L,576L,468L,1008L,912L,1080L,1152L,864L,1440L,1080L,1512L,1248L,2592L,3072L,1480L,1520L,3192L,2520L,3780L,2736L,1848L,4536L,3864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134385Inst : IEnumerable<long>
{
public static readonly long[] Value=A134385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134385.Bytes);
public long this[int i]=>Value[i];

public static A134385Inst Instance=new A134385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134386
{
public static readonly long[] Value={ 42L,336L,930L,2016L,2520L,2688L,4200L,6720L,5184L,4680L,11088L,10944L,14040L,16128L,12960L,23040L,18360L,27216L,23712L,51840L,64512L,32560L,34960L,76608L,63000L,98280L,73872L,51744L,131544L,115920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134386Inst : IEnumerable<long>
{
public static readonly long[] Value=A134386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134386.Bytes);
public long this[int i]=>Value[i];

public static A134386Inst Instance=new A134386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134387
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,1L,4L,9L,3L,9L,14L,2L,2L,5L,18L,10L,10L,2L,7L,26L,9L,29L,1L,30L,2L,33L,9L,2L,7L,21L,2L,4L,41L,3L,2L,18L,15L,9L,24L,5L,50L,8L,53L,9L,18L,9L,14L,6L,15L,50L,7L,2L,65L,5L,26L,9L,3L,34L,69L,3L,9L,7L,21L,74L,5L,3L,26L,13L,81L,9L,86L,14L,2L,29L,89L,90L,4L,5L,18L,9L,48L,98L,11L,10L,17L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134387Inst : IEnumerable<long>
{
public static readonly long[] Value=A134387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134387.Bytes);
public long this[int i]=>Value[i];

public static A134387Inst Instance=new A134387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134388
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,2L,1L,3L,6L,4L,2L,1L,6L,10L,8L,5L,2L,1L,10L,20L,15L,10L,6L,2L,1L,20L,35L,30L,21L,12L,7L,2L,1L,35L,70L,56L,42L,28L,14L,8L,2L,1L,70L,126L,112L,84L,56L,36L,16L,9L,2L,1L,126L,252L,210L,168L,120L,72L,45L,18L,10L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134388Inst : IEnumerable<long>
{
public static readonly long[] Value=A134388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134388.Bytes);
public long this[int i]=>Value[i];

public static A134388Inst Instance=new A134388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134389
{
public static readonly long[] Value={ 1L,2L,5L,11L,24L,51L,108L,226L,472L,979L,2028L,4182L,8616L,17694L,36312L,74340L,152112L,310659L,634188L,1292686L,2633992L,5360362L,10905480L,22163676L,45032784L,91417646L,185539448L,376279196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134389Inst : IEnumerable<long>
{
public static readonly long[] Value=A134389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134389.Bytes);
public long this[int i]=>Value[i];

public static A134389Inst Instance=new A134389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134390
{
public static readonly long[] Value={ 1L,4L,3L,8L,8L,3L,13L,14L,12L,7L,19L,21L,20L,16L,9L,26L,29L,29L,26L,20L,11L,34L,38L,39L,37L,32L,24L,13L,43L,48L,50L,49L,45L,38L,28L,15L,53L,59L,62L,62L,59L,5344L,32L,17L,64L,71L,75L,76L,64L,69L,61L,50L,36L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134390Inst : IEnumerable<long>
{
public static readonly long[] Value=A134390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134390.Bytes);
public long this[int i]=>Value[i];

public static A134390Inst Instance=new A134390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134391
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134391Inst : IEnumerable<long>
{
public static readonly long[] Value=A134391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134391.Bytes);
public long this[int i]=>Value[i];

public static A134391Inst Instance=new A134391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134440
{
public static readonly long[] Value={ 1L,3L,6L,3L,10L,5L,18L,9L,28L,14L,7L,38L,19L,60L,30L,15L,68L,34L,17L,84L,42L,21L,100L,50L,25L,122L,61L,164L,82L,41L,154L,77L,208L,104L,52L,26L,13L,170L,85L,252L,126L,63L,244L,122L,61L,258L,129L,340L,170L,85L,314L,157L,396L,198L,99L,356L,178L,89L,360L,180L,90L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134440Inst : IEnumerable<long>
{
public static readonly long[] Value=A134440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134440.Bytes);
public long this[int i]=>Value[i];

public static A134440Inst Instance=new A134440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134441
{
public static readonly long[] Value={ 1L,9L,13L,17L,21L,29L,33L,37L,41L,49L,53L,57L,61L,69L,73L,77L,81L,89L,93L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134441Inst : IEnumerable<long>
{
public static readonly long[] Value=A134441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134441.Bytes);
public long this[int i]=>Value[i];

public static A134441Inst Instance=new A134441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134442
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,27L,31L,39L,43L,47L,51L,59L,63L,67L,71L,79L,83L,87L,91L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134442Inst : IEnumerable<long>
{
public static readonly long[] Value=A134442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134442.Bytes);
public long this[int i]=>Value[i];

public static A134442Inst Instance=new A134442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134443
{
public static readonly long[] Value={ 1L,22L,22L,92L,255L,538L,978L,1684L,3267L,8350L,25150L,72580L,178012L,334564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134443Inst : IEnumerable<long>
{
public static readonly long[] Value=A134443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134443.Bytes);
public long this[int i]=>Value[i];

public static A134443Inst Instance=new A134443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134444
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,5L,3L,3L,1L,1L,5L,5L,3L,3L,1L,1L,7L,5L,5L,3L,3L,1L,1L,7L,7L,5L,5L,3L,3L,1L,1L,9L,7L,7L,5L,5L,3L,3L,1L,1L,9L,9L,7L,7L,5L,5L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134444Inst : IEnumerable<long>
{
public static readonly long[] Value=A134444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134444.Bytes);
public long this[int i]=>Value[i];

public static A134444Inst Instance=new A134444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134445
{
public static readonly long[] Value={ 8L,14L,23L,28L,34L,42L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134445Inst : IEnumerable<long>
{
public static readonly long[] Value=A134445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134445.Bytes);
public long this[int i]=>Value[i];

public static A134445Inst Instance=new A134445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134446
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,4L,3L,4L,3L,4L,6L,4L,5L,3L,6L,6L,8L,5L,6L,4L,6L,9L,8L,10L,6L,7L,4L,8L,9L,12L,10L,12L,7L,8L,5L,8L,12L,12L,15L,12L,14L,8L,9L,5L,10L,12L,16L,15L,18L,14L,16L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134446Inst : IEnumerable<long>
{
public static readonly long[] Value=A134446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134446.Bytes);
public long this[int i]=>Value[i];

public static A134446Inst Instance=new A134446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134447
{
public static readonly long[] Value={ 1L,1L,2L,4L,2L,3L,4L,6L,3L,4L,9L,6L,8L,4L,5L,9L,12L,8L,10L,5L,6L,16L,12L,15L,10L,12L,6L,7L,16L,20L,15L,18L,12L,14L,7L,8L,25L,20L,24L,18L,21L,14L,16L,8L,9L,25L,30L,24L,28L,21L,24L,16L,18L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134447Inst : IEnumerable<long>
{
public static readonly long[] Value=A134447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134447.Bytes);
public long this[int i]=>Value[i];

public static A134447Inst Instance=new A134447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134448
{
public static readonly BigInteger[] Value={ 9320403125L,9549620000000L,550785472903125L,9781641420800000L,91103907470703125L,564113147623200000L,2635397242528203125L,10017850209075200000UL,BigInteger.Parse("32531698595851003125"),BigInteger.Parse("93301200312500000000"),BigInteger.Parse("242001831271659903125"),BigInteger.Parse("577707584762880000000"),BigInteger.Parse("1286270633097318903125") };
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
public class A134448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134448Inst Instance=new A134448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134449
{
public static readonly long[] Value={ 0L,2L,5L,29L,39L,129L,150L,374L,410L,860L,915L,1707L,1785L,3059L,3164L,5084L,5220L,7974L,8145L,11945L,12155L,17237L,17490L,24114L,24414L,32864L,33215L,43799L,44205L,57255L,57720L,73592L,74120L,93194L,93789L,116469L,117135L,143849L,144590L,175790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134449Inst : IEnumerable<long>
{
public static readonly long[] Value=A134449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134449.Bytes);
public long this[int i]=>Value[i];

public static A134449Inst Instance=new A134449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134450
{
public static readonly long[] Value={ 43175L,1382000L,10495575L,44230400L,134984375L,335890800L,726002375L,1415475200L,2550752775L,4319750000L,6957037175L,10749024000L,16039143575L,23233036400L,32803734375L,45296844800L,61335734375L,81626713200L,106964218775L,138236000000L,176428301175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134450Inst : IEnumerable<long>
{
public static readonly long[] Value=A134450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134450.Bytes);
public long this[int i]=>Value[i];

public static A134450Inst Instance=new A134450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134451
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134451Inst : IEnumerable<long>
{
public static readonly long[] Value=A134451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134451.Bytes);
public long this[int i]=>Value[i];

public static A134451Inst Instance=new A134451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134452
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134452Inst : IEnumerable<long>
{
public static readonly long[] Value=A134452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134452.Bytes);
public long this[int i]=>Value[i];

public static A134452Inst Instance=new A134452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134453
{
public static readonly long[] Value={ 5L,15L,17L,23L,41L,43L,45L,47L,51L,53L,59L,69L,71L,77L,95L,121L,123L,125L,127L,129L,131L,133L,135L,137L,141L,143L,149L,151L,153L,155L,159L,161L,167L,177L,179L,185L,203L,205L,207L,209L,213L,215L,221L,231L,233L,239L,257L,283L,285L,287L,293L,311L,337L,355L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134453Inst : IEnumerable<long>
{
public static readonly long[] Value=A134453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134453.Bytes);
public long this[int i]=>Value[i];

public static A134453Inst Instance=new A134453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134454
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,13L,19L,21L,25L,27L,29L,31L,33L,35L,37L,39L,49L,55L,57L,61L,63L,65L,67L,73L,75L,79L,81L,83L,85L,87L,89L,91L,93L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,139L,145L,147L,157L,163L,165L,169L,171L,173L,175L,181L,183L,187L,189L,191L,193L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134454Inst : IEnumerable<long>
{
public static readonly long[] Value=A134454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134454.Bytes);
public long this[int i]=>Value[i];

public static A134454Inst Instance=new A134454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134455
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,8L,24L,112L,944L,22880L,2564448L,2420884672L,55389846424256L,BigInteger.Parse("142044380887832220032"),BigInteger.Parse("343873064435082883562892998016"),BigInteger.Parse("19047076228497528742755382412205052966716160") };
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
public class A134455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134455Inst Instance=new A134455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134488
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,9L,9L,10L,12L,15L,14L,15L,16L,18L,20L,21L,20L,23L,20L,25L,23L,23L,24L,31L,26L,29L,28L,33L,32L,35L,34L,35L,36L,42L,42L,43L,38L,41L,40L,47L,42L,49L,45L,49L,47L,47L,48L,57L,52L,55L,54L,59L,54L,61L,56L,63L,62L,61L,60L,71L,62L,65L,66L,71L,66L,73L,68L,73L,70L,77L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134488Inst : IEnumerable<long>
{
public static readonly long[] Value=A134488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134488.Bytes);
public long this[int i]=>Value[i];

public static A134488Inst Instance=new A134488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134489
{
public static readonly long[] Value={ 1L,13L,144L,1597L,17711L,196418L,2178309L,24157817L,267914296L,2971215073L,32951280099L,365435296162L,4052739537881L,44945570212853L,498454011879264L,5527939700884757L,61305790721611591L,679891637638612258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134489Inst : IEnumerable<long>
{
public static readonly long[] Value=A134489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134489.Bytes);
public long this[int i]=>Value[i];

public static A134489Inst Instance=new A134489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134490
{
public static readonly long[] Value={ 2L,21L,233L,2584L,28657L,317811L,3524578L,39088169L,433494437L,4807526976L,53316291173L,591286729879L,6557470319842L,72723460248141L,806515533049393L,8944394323791464L,99194853094755497L,1100087778366101931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134490Inst : IEnumerable<long>
{
public static readonly long[] Value=A134490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134490.Bytes);
public long this[int i]=>Value[i];

public static A134490Inst Instance=new A134490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134491
{
public static readonly long[] Value={ 3L,34L,377L,4181L,46368L,514229L,5702887L,63245986L,701408733L,7778742049L,86267571272L,956722026041L,10610209857723L,117669030460994L,1304969544928657L,14472334024676221L,160500643816367088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134491Inst : IEnumerable<long>
{
public static readonly long[] Value=A134491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134491.Bytes);
public long this[int i]=>Value[i];

public static A134491Inst Instance=new A134491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134492
{
public static readonly BigInteger[] Value={ 0L,8L,144L,2584L,46368L,832040L,14930352L,267914296L,4807526976L,86267571272L,1548008755920L,27777890035288L,498454011879264L,8944394323791464L,160500643816367088L,2880067194370816120L,BigInteger.Parse("51680708854858323072"),BigInteger.Parse("927372692193078999176"),BigInteger.Parse("16641027750620563662096") };
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
public class A134492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134492Inst Instance=new A134492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134493
{
public static readonly BigInteger[] Value={ 1L,13L,233L,4181L,75025L,1346269L,24157817L,433494437L,7778742049L,139583862445L,2504730781961L,44945570212853L,806515533049393L,14472334024676221L,259695496911122585L,4660046610375530309L,BigInteger.Parse("83621143489848422977"),BigInteger.Parse("1500520536206896083277"),BigInteger.Parse("26925748508234281076009") };
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
public class A134493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134493Inst Instance=new A134493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134494
{
public static readonly BigInteger[] Value={ 1L,21L,377L,6765L,121393L,2178309L,39088169L,701408733L,12586269025L,225851433717L,4052739537881L,72723460248141L,1304969544928657L,23416728348467685L,420196140727489673L,7540113804746346429L,BigInteger.Parse("135301852344706746049"),BigInteger.Parse("2427893228399975082453") };
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
public class A134494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134494Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134494.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134494Inst Instance=new A134494Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134495
{
public static readonly ulong[] Value={ 2L,34L,610L,10946L,196418L,3524578L,63245986L,1134903170L,20365011074L,365435296162L,6557470319842L,117669030460994L,2111485077978050L,37889062373143906L,679891637638612258L,12200160415121876738UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134495Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A134495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134495.Bytes);
public ulong this[int i]=>Value[i];

public static A134495Inst Instance=new A134495Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134496
{
public static readonly long[] Value={ 100L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,150L,151L,152L,153L,154L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134496Inst : IEnumerable<long>
{
public static readonly long[] Value=A134496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134496.Bytes);
public long this[int i]=>Value[i];

public static A134496Inst Instance=new A134496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134497
{
public static readonly BigInteger[] Value={ 5L,89L,1597L,28657L,514229L,9227465L,165580141L,2971215073L,53316291173L,956722026041L,17167680177565L,308061521170129L,5527939700884757L,99194853094755497L,1779979416004714189L,BigInteger.Parse("31940434634990099905"),BigInteger.Parse("573147844013817084101"),BigInteger.Parse("10284720757613717413913") };
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
public class A134497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134497Inst Instance=new A134497Inst();

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