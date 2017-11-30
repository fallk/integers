using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A258382
{
public static readonly long[] Value={ 144L,441L,1584L,4851L,10404L,12544L,14544L,14884L,15984L,27648L,40401L,44521L,44541L,48841L,48951L,84672L,114444L,137984L,144144L,159984L,409739L,441441L,444411L,489731L,489951L,937904L,1004004L,1022121L,1024144L,1042441L,1044484L,1050804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258382Inst : IEnumerable<long>
{
public static readonly long[] Value=A258382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258382.Bytes);
public long this[int i]=>Value[i];

public static A258382Inst Instance=new A258382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258383
{
public static readonly long[] Value={ 2L,2L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258383Inst : IEnumerable<long>
{
public static readonly long[] Value=A258383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258383.Bytes);
public long this[int i]=>Value[i];

public static A258383Inst Instance=new A258383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258384
{
public static readonly BigInteger[] Value={ 2L,18L,576L,40000L,4860000L,914838624L,246727835648L,90275517038592L,43046721000000000L,BigInteger.Parse("25937424601000000000"),BigInteger.Parse("19271723592631858495488"),BigInteger.Parse("17310672267004940730236928"),BigInteger.Parse("18492034350245752657180811264"),BigInteger.Parse("23170856660867919150000000000000") };
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
public class A258384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258384Inst Instance=new A258384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258385
{
public static readonly BigInteger[] Value={ 0L,8L,648L,82944L,16000000L,4374000000L,1613775332736L,773738492592128L,467988280328060928L,BigInteger.Parse("348678440100000000000"),BigInteger.Parse("313842837672100000000000"),BigInteger.Parse("335790511878017502425382912"),BigInteger.Parse("421272520289832237611045879808"),BigInteger.Parse("612530145817540311016457192308736") };
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
public class A258385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258385Inst Instance=new A258385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258386
{
public static readonly long[] Value={ 1L,0L,3L,2L,11L,10L,35L,40L,107L,138L,310L,432L,871L,1262L,2355L,3504L,6186L,9318L,15799L,23934L,39351L,59672L,95772L,144970L,228258L,344244L,533552L,800952L,1225164L,1829530L,2767227L,4109504L,6155310L,9089834L,13497964L,19822252L,29208812L,42660456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258386Inst : IEnumerable<long>
{
public static readonly long[] Value=A258386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258386.Bytes);
public long this[int i]=>Value[i];

public static A258386Inst Instance=new A258386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258387
{
public static readonly BigInteger[] Value={ 3L,11L,73L,689L,8401L,125425L,2214801L,45143873L,1043046721L,26937424601L,768945795289L,24041093493169L,817012858376625L,29986640798644769L,1182114430632237601L,BigInteger.Parse("49814113380273715457"),BigInteger.Parse("2234572751614363400449"),BigInteger.Parse("106313261857649938064809") };
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
public class A258387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258387Inst Instance=new A258387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258388
{
public static readonly BigInteger[] Value={ 1L,1L,9L,89L,1105L,16649L,295561L,6044737L,139982529L,3621002129L,103486784401L,3238428376721L,110131633755793L,4044369591078361L,159505471943511513L,6723976451270702849L,BigInteger.Parse("301716313535065716481"),BigInteger.Parse("14358232357247077816865"),BigInteger.Parse("722298429807405401348641") };
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
public class A258388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258388Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258388.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258388Inst Instance=new A258388Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258389
{
public static readonly BigInteger[] Value={ 2L,14L,128L,1504L,21752L,374184L,7464368L,169402496L,4309519952L,121450640200L,3755499322808L,126409853754144L,4600799868451880L,180029930424249416L,7536568838736534752L,BigInteger.Parse("336087767194699956736"),BigInteger.Parse("15905186914751401828640"),BigInteger.Parse("796113699641442496367496") };
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
public class A258389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258389Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258389.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258389Inst Instance=new A258389Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258390
{
public static readonly long[] Value={ 2L,15L,98L,630L,4092L,27027L,181610L,1239810L,8582756L,60138078L,425800564L,3042175500L,21906338040L,158830645635L,1158564772890L,8496271312650L,62604582047700L,463275674416170L,3441483002640540L,25654715940496500L,191852749820189640L,1438895966711035950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258390Inst : IEnumerable<long>
{
public static readonly long[] Value=A258390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258390.Bytes);
public long this[int i]=>Value[i];

public static A258390Inst Instance=new A258390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258391
{
public static readonly BigInteger[] Value={ 5L,84L,1050L,11880L,129129L,1381380L,14707550L,156706680L,1675459786L,17998446312L,194361212500L,2110052926800L,23026236054345L,252513376831620L,2781895215981750L,30778564965687000L,341873708072702190L,3811170628172227320L,BigInteger.Parse("42628644369844747500") };
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
public class A258391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258391Inst Instance=new A258391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258392
{
public static readonly BigInteger[] Value={ 14L,420L,8580L,150150L,2432430L,37777740L,572827580L,8568059500L,127199546012L,1881416537000L,27792098497800L,410634370077750L,6074408847920670L,90017212151219100L,1336818529866319500L,BigInteger.Parse("19898794932394570500"),BigInteger.Parse("296909055625560798420"),BigInteger.Parse("4440849374395184751000") };
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
public class A258392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258392Inst Instance=new A258392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258393
{
public static readonly BigInteger[] Value={ 42L,1980L,60060L,1501500L,33795762L,714249900L,14504269780L,286931752800L,5578065392900L,107178276605400L,2043352620527400L,38758743724018500L,732849800716048290L,13831507110589591500UL,BigInteger.Parse("260829110106412824900"),BigInteger.Parse("4917878997439418010000"),BigInteger.Parse("92758042341429880435020") };
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
public class A258393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258393Inst Instance=new A258393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258394
{
public static readonly BigInteger[] Value={ 132L,9009L,380380L,12864852L,383402292L,10551322782L,275335499824L,6924802684800L,169656773406120L,4078556074277685L,96700630711999860L,2269529269318731420L,BigInteger.Parse("52868514692841609300"),BigInteger.Parse("1224857602490265215010"),BigInteger.Parse("28265620407321158141280"),BigInteger.Parse("650452332645092821924080") };
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
public class A258394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258394Inst Instance=new A258394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258395
{
public static readonly BigInteger[] Value={ 429L,40040L,2246244L,98760480L,3761539782L,130505896752L,4245988489600L,131928199603200L,3962683868528385L,116039722090972680L,3332921846278964940L,BigInteger.Parse("94315723869947580000"),BigInteger.Parse("2638390752595156276410"),BigInteger.Parse("73147630662437905413840"),BigInteger.Parse("2013841857892713303414960") };
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
public class A258395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258395Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258395.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258395Inst Instance=new A258395Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258396
{
public static readonly BigInteger[] Value={ 1430L,175032L,12597000L,698377680L,33079524324L,1411221754800L,55928745100800L,2100173331484800L,75727786603836510L,2646827388046104120L,BigInteger.Parse("90290940344491887000"),BigInteger.Parse("3021580012515765901200"),BigInteger.Parse("99583828881536195805180"),BigInteger.Parse("3242049884573075122369680") };
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
public class A258396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258396Inst Instance=new A258396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258397
{
public static readonly BigInteger[] Value={ 4862L,755820L,67897830L,4633467300L,267074035800L,13733597077200L,650800305634050L,29021018652697500L,1235362166419751370L,BigInteger.Parse("50713478000403718500"),BigInteger.Parse("2022835296688063807950"),BigInteger.Parse("78843505678630977784500"),BigInteger.Parse("3016017325414346802772080"),BigInteger.Parse("113617986954086473298668800") };
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
public class A258397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258397Inst Instance=new A258397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258398
{
public static readonly BigInteger[] Value={ 16796L,3233230L,354660460L,29214542500L,2013190058880L,122762429039250L,6850724997273300L,357603651626578500L,17726205673051976100UL,BigInteger.Parse("843509478504416874150"),BigInteger.Parse("38843740303576863755100"),BigInteger.Parse("1741683387026398566250500"),BigInteger.Parse("76401095775145069217992560") };
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
public class A258398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258398Inst Instance=new A258398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258399
{
public static readonly BigInteger[] Value={ 1L,2L,98L,11880L,2432430L,714249900L,275335499824L,131928199603200L,75727786603836510L,BigInteger.Parse("50713478000403718500"),BigInteger.Parse("38843740303576863755100"),BigInteger.Parse("33508462196084294380001040"),BigInteger.Parse("32157574295254903735909896240"),BigInteger.Parse("33990046387543889224733323929120") };
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
public class A258399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258399Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258399.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258399Inst Instance=new A258399Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258400
{
public static readonly long[] Value={ 8L,9L,25L,32L,121L,289L,841L,1681L,2048L,3481L,5041L,10201L,11449L,18769L,22201L,32041L,36481L,38809L,51529L,57121L,72361L,78961L,96721L,120409L,131072L,175561L,185761L,212521L,271441L,323761L,358801L,380689L,410881L,434281L,654481L,674041L,683929L,734449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258400Inst : IEnumerable<long>
{
public static readonly long[] Value=A258400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258400.Bytes);
public long this[int i]=>Value[i];

public static A258400Inst Instance=new A258400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258401
{
public static readonly long[] Value={ 4030L,5830L,45356L,91388L,243892L,254012L,338572L,343876L,388076L,1713592L,4199030L,8812312L,9928792L,11339816L,11547352L,15126992L,17999992L,29465852L,29581424L,38546576L,74899952L,85389368L,89283592L,95327216L,120888092L,141659096L,146764264L,162079768L,173482552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258401Inst : IEnumerable<long>
{
public static readonly long[] Value=A258401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258401.Bytes);
public long this[int i]=>Value[i];

public static A258401Inst Instance=new A258401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258402
{
public static readonly long[] Value={ 0L,11L,72L,243L,608L,1275L,2376L,4067L,6528L,9963L,14600L,20691L,28512L,38363L,50568L,65475L,83456L,104907L,130248L,159923L,194400L,234171L,279752L,331683L,390528L,456875L,531336L,614547L,707168L,809883L,923400L,1048451L,1185792L,1336203L,1500488L,1679475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258402Inst : IEnumerable<long>
{
public static readonly long[] Value=A258402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258402.Bytes);
public long this[int i]=>Value[i];

public static A258402Inst Instance=new A258402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258403
{
public static readonly long[] Value={ 2L,9L,3L,8L,9L,2L,6L,2L,6L,1L,4L,6L,2L,3L,6L,5L,6L,4L,5L,8L,4L,3L,5L,2L,9L,7L,7L,3L,1L,9L,5L,3L,6L,3L,8L,4L,2L,9L,8L,8L,2L,6L,2L,1L,8L,8L,2L,1L,5L,7L,2L,9L,9L,5L,5L,3L,6L,1L,3L,6L,2L,4L,0L,3L,7L,8L,6L,3L,9L,2L,3L,7L,0L,8L,1L,1L,7L,5L,9L,7L,8L,7L,5L,4L,2L,5L,2L,0L,2L,4L,9L,3L,1L,3L,7L,0L,6L,6L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258403Inst : IEnumerable<long>
{
public static readonly long[] Value=A258403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258403.Bytes);
public long this[int i]=>Value[i];

public static A258403Inst Instance=new A258403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258404
{
public static readonly long[] Value={ 1L,6L,1L,8L,2L,0L,2L,4L,2L,2L,9L,4L,8L,5L,6L,5L,6L,1L,8L,0L,2L,6L,1L,3L,3L,4L,9L,8L,5L,7L,8L,6L,5L,3L,4L,3L,1L,3L,0L,6L,8L,5L,7L,8L,2L,8L,8L,0L,1L,8L,9L,9L,0L,3L,9L,8L,0L,4L,2L,9L,4L,5L,3L,5L,7L,9L,5L,3L,4L,1L,5L,3L,8L,0L,4L,3L,7L,1L,4L,8L,9L,6L,8L,8L,5L,3L,3L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258404Inst : IEnumerable<long>
{
public static readonly long[] Value=A258404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258404.Bytes);
public long this[int i]=>Value[i];

public static A258404Inst Instance=new A258404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258405
{
public static readonly long[] Value={ 1L,3L,7L,8L,0L,1L,0L,7L,0L,8L,4L,6L,5L,5L,4L,6L,4L,2L,8L,4L,5L,3L,8L,6L,1L,3L,1L,4L,0L,2L,1L,9L,3L,8L,4L,3L,0L,8L,4L,5L,2L,2L,5L,4L,1L,2L,3L,2L,6L,2L,5L,9L,8L,2L,6L,8L,3L,9L,3L,7L,0L,0L,3L,7L,0L,9L,2L,4L,8L,6L,3L,1L,0L,7L,7L,3L,1L,8L,1L,7L,0L,4L,8L,9L,3L,6L,2L,9L,1L,7L,6L,9L,8L,5L,9L,2L,4L,3L,4L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258405Inst : IEnumerable<long>
{
public static readonly long[] Value=A258405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258405.Bytes);
public long this[int i]=>Value[i];

public static A258405Inst Instance=new A258405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258406
{
public static readonly long[] Value={ 2L,5L,3L,8L,7L,4L,0L,8L,2L,3L,7L,8L,2L,7L,6L,0L,0L,2L,9L,8L,8L,5L,0L,8L,8L,9L,3L,8L,1L,6L,3L,3L,2L,9L,1L,2L,3L,8L,4L,7L,6L,3L,6L,3L,4L,3L,1L,9L,3L,3L,1L,3L,5L,1L,4L,7L,5L,6L,0L,6L,7L,6L,0L,5L,8L,8L,6L,9L,6L,6L,3L,0L,9L,2L,7L,3L,5L,4L,6L,9L,1L,6L,8L,5L,9L,8L,1L,6L,6L,0L,3L,1L,4L,9L,6L,8L,3L,7L,8L,6L,5L,4L,1L,2L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258406Inst : IEnumerable<long>
{
public static readonly long[] Value=A258406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258406.Bytes);
public long this[int i]=>Value[i];

public static A258406Inst Instance=new A258406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258407
{
public static readonly long[] Value={ 1L,9L,6L,8L,8L,0L,6L,1L,5L,3L,1L,4L,5L,8L,8L,9L,7L,5L,3L,5L,3L,3L,5L,1L,3L,5L,8L,4L,7L,6L,9L,6L,6L,6L,8L,2L,9L,6L,6L,7L,3L,4L,3L,1L,7L,8L,3L,9L,1L,7L,5L,7L,5L,8L,6L,0L,9L,3L,3L,5L,7L,0L,6L,2L,6L,8L,9L,9L,0L,1L,5L,1L,1L,1L,1L,0L,5L,6L,2L,0L,9L,2L,2L,2L,9L,0L,5L,1L,0L,6L,0L,2L,7L,8L,3L,7L,4L,5L,6L,7L,3L,5L,4L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258407Inst : IEnumerable<long>
{
public static readonly long[] Value=A258407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258407.Bytes);
public long this[int i]=>Value[i];

public static A258407Inst Instance=new A258407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258408
{
public static readonly long[] Value={ 5L,7L,7L,3L,3L,2L,1L,2L,0L,1L,8L,3L,9L,7L,9L,7L,0L,5L,5L,5L,2L,5L,4L,6L,9L,6L,2L,0L,1L,5L,9L,0L,4L,1L,5L,5L,0L,8L,0L,1L,1L,9L,3L,1L,3L,8L,3L,5L,6L,3L,4L,9L,2L,4L,5L,5L,8L,9L,0L,8L,8L,0L,3L,7L,5L,1L,5L,2L,5L,2L,1L,6L,4L,5L,1L,9L,8L,7L,7L,8L,1L,3L,5L,0L,6L,3L,7L,1L,0L,7L,0L,0L,0L,0L,0L,7L,1L,5L,4L,0L,9L,7L,8L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258408Inst : IEnumerable<long>
{
public static readonly long[] Value=A258408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258408.Bytes);
public long this[int i]=>Value[i];

public static A258408Inst Instance=new A258408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258409
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,6L,1L,2L,1L,10L,1L,12L,1L,2L,1L,16L,1L,18L,1L,2L,1L,22L,1L,4L,1L,2L,1L,28L,1L,30L,1L,2L,1L,2L,1L,36L,1L,2L,1L,40L,1L,42L,1L,2L,1L,46L,1L,6L,1L,2L,1L,52L,1L,2L,1L,2L,1L,58L,1L,60L,1L,2L,1L,4L,1L,66L,1L,2L,1L,70L,1L,72L,1L,2L,1L,2L,1L,78L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258409Inst : IEnumerable<long>
{
public static readonly long[] Value=A258409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258409.Bytes);
public long this[int i]=>Value[i];

public static A258409Inst Instance=new A258409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258410
{
public static readonly long[] Value={ 4L,5L,18L,20L,21L,24L,25L,27L,70L,74L,76L,77L,82L,84L,85L,88L,89L,91L,98L,100L,101L,104L,105L,107L,112L,113L,115L,119L,270L,278L,282L,284L,285L,294L,298L,300L,301L,306L,308L,309L,312L,313L,315L,326L,330L,332L,333L,338L,340L,341L,344L,345L,347L,354L,356L,357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258410Inst : IEnumerable<long>
{
public static readonly long[] Value=A258410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258410.Bytes);
public long this[int i]=>Value[i];

public static A258410Inst Instance=new A258410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258411
{
public static readonly long[] Value={ 5L,9L,17L,33L,41L,42L,65L,74L,77L,84L,85L,90L,129L,138L,145L,146L,148L,162L,166L,168L,173L,180L,257L,266L,274L,276L,279L,282L,285L,292L,296L,297L,301L,307L,310L,322L,324L,330L,332L,336L,341L,345L,349L,354L,360L,513L,522L,530L,532L,538L,545L,546L,548L,552L,562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258411Inst : IEnumerable<long>
{
public static readonly long[] Value=A258411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258411.Bytes);
public long this[int i]=>Value[i];

public static A258411Inst Instance=new A258411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258412
{
public static readonly long[] Value={ 2L,9L,8L,7L,8L,3L,3L,6L,5L,1L,0L,6L,5L,6L,7L,2L,9L,8L,7L,7L,0L,9L,5L,3L,7L,7L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258412Inst : IEnumerable<long>
{
public static readonly long[] Value=A258412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258412.Bytes);
public long this[int i]=>Value[i];

public static A258412Inst Instance=new A258412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258413
{
public static readonly long[] Value={ 34L,79L,479L,1529L,2879L,4895L,8873L,14243L,26879L,62498L,79999L,295285L,559571L,589219L,644735L,799999L,2012897L,2181600L,2233033L,2395488L,6399839L,7453541L,7922023L,8598719L,22928034L,26861727L,37894930L,55056372L,63652895L,76820471L,144726608L,174044214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258413Inst : IEnumerable<long>
{
public static readonly long[] Value=A258413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258413.Bytes);
public long this[int i]=>Value[i];

public static A258413Inst Instance=new A258413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258414
{
public static readonly long[] Value={ 9L,4L,9L,7L,0L,3L,1L,2L,6L,2L,9L,4L,0L,0L,9L,3L,9L,5L,2L,6L,3L,4L,9L,8L,4L,9L,1L,7L,4L,5L,7L,4L,1L,5L,1L,5L,8L,7L,3L,6L,5L,1L,9L,5L,0L,9L,0L,9L,6L,9L,2L,9L,4L,4L,8L,8L,0L,9L,1L,7L,6L,5L,4L,3L,6L,8L,3L,0L,5L,1L,9L,5L,5L,6L,8L,7L,9L,2L,8L,8L,1L,7L,2L,6L,0L,0L,6L,8L,0L,3L,2L,8L,4L,8L,3L,5L,3L,5L,0L,1L,6L,8L,7L,2L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258414Inst : IEnumerable<long>
{
public static readonly long[] Value=A258414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258414.Bytes);
public long this[int i]=>Value[i];

public static A258414Inst Instance=new A258414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258415
{
public static readonly long[] Value={ 1L,4L,3L,2L,8L,5L,14L,10L,12L,7L,6L,30L,18L,16L,9L,54L,38L,46L,26L,20L,11L,22L,118L,70L,62L,34L,24L,13L,214L,150L,182L,102L,78L,42L,28L,15L,86L,470L,278L,246L,134L,94L,50L,32L,17L,854L,598L,726L,406L,310L,166L,110L,58L,36L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258415Inst : IEnumerable<long>
{
public static readonly long[] Value=A258415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258415.Bytes);
public long this[int i]=>Value[i];

public static A258415Inst Instance=new A258415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258416
{
public static readonly long[] Value={ 4L,29L,184L,1148L,7228L,46224L,300476L,1983102L,13266032L,89795420L,614058228L,4236652416L,29457698192L,206215486597L,1452248529432L,10281676045348L,73137772914324L,522472109334560L,3746685545297640L,26961148855455180L,194626321451800800L,1409026233004925340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258416Inst : IEnumerable<long>
{
public static readonly long[] Value=A258416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258416.Bytes);
public long this[int i]=>Value[i];

public static A258416Inst Instance=new A258416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258417
{
public static readonly BigInteger[] Value={ 30L,486L,5880L,64464L,679195L,7043814L,72707844L,751082244L,7785793080L,81092511276L,849060054420L,8937364804760L,94564644817767L,1005496779910572L,10740560345206680L,115218669255806304L,1240869923563291014L,13412271463669969704UL,BigInteger.Parse("145454088924589697192") };
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
public class A258417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258417Inst Instance=new A258417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258418
{
public static readonly BigInteger[] Value={ 336L,9744L,192984L,3279060L,51622600L,779602164L,11499880768L,167393051696L,2419080596520L,34838703973728L,501182126787744L,7212689238965297L,103937431212291680L,1500609318117978064L,BigInteger.Parse("21713411768745550544"),BigInteger.Parse("314940143510352714144"),BigInteger.Parse("4579270473409470432352") };
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
public class A258418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258418Inst Instance=new A258418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258419
{
public static readonly BigInteger[] Value={ 5040L,230400L,6792750L,165293700L,3624918660L,74699100720L,1479942440340L,28577108044800L,542482698531000L,10181610525525360L,189663357076785270L,3515970161266821510L,BigInteger.Parse("64985380300281057950"),BigInteger.Parse("1199146771516702098500"),BigInteger.Parse("22111945264260791498090") };
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
public class A258419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258419Inst Instance=new A258419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258420
{
public static readonly BigInteger[] Value={ 95040L,6308280L,259518600L,8563232700L,249224561040L,6703099068120L,171052924578480L,4209175565848800L,100941470303368480L,2376150752752629210L,BigInteger.Parse("55182874193888254800"),BigInteger.Parse("1268931845185709426820"),BigInteger.Parse("28968880808493233206500"),BigInteger.Parse("657875495503038733415880") };
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
public class A258420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258420Inst Instance=new A258420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258421
{
public static readonly BigInteger[] Value={ 2162160L,196756560L,10778727960L,463305056760L,17266750912320L,586609859314080L,18699578507549520L,569565504689176800L,16777853060738524020UL,BigInteger.Parse("482011338862966969980"),BigInteger.Parse("13586929812483090607600"),BigInteger.Parse("377442353035435719228120"),BigInteger.Parse("10367784656620152180344310") };
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
public class A258421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258421Inst Instance=new A258421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258422
{
public static readonly BigInteger[] Value={ 57657600L,6895848960L,485566099200L,26364414061440L,1224007231940640L,51216101151626880L,1991943704397427200L,BigInteger.Parse("73440737647137519120"),BigInteger.Parse("2601107886874207253760"),BigInteger.Parse("89332305977055996111040"),BigInteger.Parse("2995343867463073686769440"),BigInteger.Parse("98555316817167057069129600") };
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
public class A258422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258422Inst Instance=new A258422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258423
{
public static readonly BigInteger[] Value={ 1764322560L,268497815040L,23638153069440L,1582270134681600L,89523597871058400L,4521537191138385600L,BigInteger.Parse("210558053896067770200"),BigInteger.Parse("9231136974969952417200"),BigInteger.Parse("386479930120038746283600"),BigInteger.Parse("15609810973119409265234400"),BigInteger.Parse("612788961533595085909010880"),BigInteger.Parse("23513250306172521375772885440") };
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
public class A258423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258423Inst Instance=new A258423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258424
{
public static readonly BigInteger[] Value={ 60949324800L,11504185056000L,1238502000960000L,100203614366688000L,6786584967157027200L,BigInteger.Parse("406962991813415247000"),BigInteger.Parse("22343812436173975084800"),BigInteger.Parse("1147985274106305649476000"),BigInteger.Parse("56030531363859577353444000"),BigInteger.Parse("2626132408521540739815456000"),BigInteger.Parse("119149819949135773678717267200") };
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
public class A258424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258424Inst Instance=new A258424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258425
{
public static readonly BigInteger[] Value={ 1L,1L,6L,64L,1020L,21854L,590248L,19268098L,738194780L,32481348812L,1614506203400L,89478362311442L,5471239864890436L,365900668319641264L,BigInteger.Parse("26569358218427144576"),BigInteger.Parse("2081825562568924254126"),BigInteger.Parse("175078869470374599592604"),BigInteger.Parse("15730138729512408087404292") };
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
public class A258425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258425Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258425.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258425Inst Instance=new A258425Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258426
{
public static readonly BigInteger[] Value={ 1L,2L,184L,64464L,51622600L,74699100720L,171052924578480L,569565504689176800L,BigInteger.Parse("2601107886874207253760"),BigInteger.Parse("15609810973119409265234400"),BigInteger.Parse("119149819949135773678717267200"),BigInteger.Parse("1127426871984268618976053945104000"),BigInteger.Parse("12953029027945569352833762868999449600") };
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
public class A258426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258426Inst Instance=new A258426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258427
{
public static readonly long[] Value={ 1L,12L,18L,112L,420L,336L,956L,6816L,12936L,7200L,7830L,95579L,324540L,414450L,178200L,62744L,1244466L,6755720L,14886300L,14355000L,5045040L,496518L,15537456L,127063596L,430572780L,699460740L,542341800L,161441280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258427Inst : IEnumerable<long>
{
public static readonly long[] Value=A258427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258427.Bytes);
public long this[int i]=>Value[i];

public static A258427Inst Instance=new A258427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258428
{
public static readonly long[] Value={ 3L,5L,2L,5L,1L,3L,4L,2L,1L,7L,7L,7L,6L,1L,8L,9L,9L,7L,4L,7L,0L,8L,5L,9L,9L,2L,2L,7L,2L,3L,9L,5L,3L,5L,0L,0L,3L,5L,9L,4L,5L,2L,7L,5L,0L,2L,1L,9L,3L,9L,6L,4L,0L,5L,4L,3L,7L,8L,1L,2L,0L,3L,3L,2L,0L,5L,7L,2L,9L,9L,8L,6L,8L,4L,2L,3L,4L,3L,7L,3L,5L,5L,5L,2L,0L,4L,8L,2L,4L,4L,5L,1L,5L,2L,8L,6L,4L,0L,3L,2L,8L,8L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258428Inst : IEnumerable<long>
{
public static readonly long[] Value=A258428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258428.Bytes);
public long this[int i]=>Value[i];

public static A258428Inst Instance=new A258428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258429
{
public static readonly long[] Value={ 2L,5L,17L,65537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258429Inst : IEnumerable<long>
{
public static readonly long[] Value=A258429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258429.Bytes);
public long this[int i]=>Value[i];

public static A258429Inst Instance=new A258429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258430
{
public static readonly long[] Value={ 2L,5L,7L,13L,19L,13L,29L,19L,43L,37L,61L,43L,41L,31L,73L,61L,43L,97L,79L,73L,73L,73L,61L,97L,127L,97L,73L,97L,127L,109L,181L,113L,157L,103L,211L,193L,163L,109L,281L,241L,211L,181L,157L,313L,337L,241L,271L,139L,337L,193L,181L,223L,229L,151L,373L,193L,241L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258430Inst : IEnumerable<long>
{
public static readonly long[] Value=A258430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258430.Bytes);
public long this[int i]=>Value[i];

public static A258430Inst Instance=new A258430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258431
{
public static readonly long[] Value={ 0L,1L,5L,23L,102L,443L,1898L,8054L,33932L,142163L,592962L,2464226L,10209620L,42190558L,173962532L,715908428L,2941192472L,12065310083L,49428043442L,202249741418L,826671597572L,3375609654698L,13771567556012L,56138319705908L,228669994187432L,930803778591278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258431Inst : IEnumerable<long>
{
public static readonly long[] Value=A258431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258431.Bytes);
public long this[int i]=>Value[i];

public static A258431Inst Instance=new A258431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258432
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,66L,67L,68L,69L,71L,72L,73L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258432Inst : IEnumerable<long>
{
public static readonly long[] Value=A258432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258432.Bytes);
public long this[int i]=>Value[i];

public static A258432Inst Instance=new A258432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258433
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,31L,79L,137L,193L,257L,317L,389L,457L,523L,607L,1399L,2239L,3119L,4019L,4973L,5903L,6907L,7907L,8933L,19583L,30911L,42473L,54581L,66889L,79357L,92003L,104723L,117763L,252233L,393191L,538259L,686671L,836833L,989999L,1144153L,1299689L,1456667L,3080969L,4767181L,6495109L,8251153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258433Inst : IEnumerable<long>
{
public static readonly long[] Value=A258433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258433.Bytes);
public long this[int i]=>Value[i];

public static A258433Inst Instance=new A258433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258434
{
public static readonly long[] Value={ 0L,3L,7L,14L,21L,34L,43L,60L,75L,96L,111L,140L,157L,190L,217L,248L,273L,318L,343L,392L,429L,474L,507L,568L,605L,664L,711L,772L,813L,892L,931L,1008L,1069L,1140L,1201L,1284L,1333L,1426L,1497L,1584L,1641L,1752L,1807L,1916L,2001L,2094L,2163L,2288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258434Inst : IEnumerable<long>
{
public static readonly long[] Value=A258434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258434.Bytes);
public long this[int i]=>Value[i];

public static A258434Inst Instance=new A258434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258435
{
public static readonly long[] Value={ 3L,7L,43L,157L,1069L,1201L,4177L,4423L,5869L,6163L,8209L,17581L,19183L,22651L,26407L,37057L,48649L,60793L,61837L,82129L,89137L,102829L,113233L,115981L,121453L,141793L,143263L,190573L,208393L,230929L,283609L,292141L,303097L,314401L,337069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258435Inst : IEnumerable<long>
{
public static readonly long[] Value=A258435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258435.Bytes);
public long this[int i]=>Value[i];

public static A258435Inst Instance=new A258435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258436
{
public static readonly long[] Value={ 157L,1069L,61837L,190573L,840109L,1950349L,2485453L,20616397L,38844349L,57648589L,133091053L,144685357L,188582029L,222029869L,276773389L,346282477L,399067213L,472656589L,827175949L,929558797L,1137622957L,1352220109L,1369037389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258436Inst : IEnumerable<long>
{
public static readonly long[] Value=A258436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258436.Bytes);
public long this[int i]=>Value[i];

public static A258436Inst Instance=new A258436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258437
{
public static readonly long[] Value={ 9L,1L,302L,332L,465460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258437Inst : IEnumerable<long>
{
public static readonly long[] Value=A258437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258437.Bytes);
public long this[int i]=>Value[i];

public static A258437Inst Instance=new A258437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258438
{
public static readonly long[] Value={ 0L,1L,9L,24L,64L,117L,189L,280L,456L,657L,889L,1152L,1464L,1813L,2205L,2640L,3376L,4161L,5001L,5896L,6864L,7893L,8989L,10152L,11448L,12817L,14265L,15792L,17416L,19125L,20925L,22816L,25824L,28929L,32137L,35448L,38880L,42421L,46077L,49848L,53800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258438Inst : IEnumerable<long>
{
public static readonly long[] Value=A258438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258438.Bytes);
public long this[int i]=>Value[i];

public static A258438Inst Instance=new A258438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258439
{
public static readonly long[] Value={ 1L,1L,3L,2L,9L,4L,27L,8L,81L,16L,243L,32L,729L,64L,2187L,128L,6561L,256L,19683L,512L,59049L,1024L,177147L,2048L,531441L,4096L,1594323L,8192L,4782969L,16384L,14348907L,32768L,43046721L,65536L,129140163L,131072L,387420489L,262144L,1162261467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258439Inst : IEnumerable<long>
{
public static readonly long[] Value=A258439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258439.Bytes);
public long this[int i]=>Value[i];

public static A258439Inst Instance=new A258439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258440
{
public static readonly long[] Value={ 3L,11L,25L,49L,84L,132L,196L,278L,379L,503L,651L,825L,1028L,1262L,1528L,1830L,2169L,2547L,2967L,3431L,3940L,4498L,5106L,5766L,6481L,7253L,8083L,8975L,9930L,10950L,12038L,13196L,14425L,15729L,17109L,18567L,20106L,21728L,23434L,25228L,27111L,29085L,31153L,33317L,35578L,37940L,40404L,42972L,45647L,48431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258440Inst : IEnumerable<long>
{
public static readonly long[] Value=A258440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258440.Bytes);
public long this[int i]=>Value[i];

public static A258440Inst Instance=new A258440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258441
{
public static readonly BigInteger[] Value={ 24486L,959892121L,37629690894906L,1475159141502204841L,BigInteger.Parse("57829188627539743273926"),BigInteger.Parse("2267019851101653874322234161"),BigInteger.Parse("88871712145057846553640480297546"),BigInteger.Parse("3483948857243537849494160234302156081"),BigInteger.Parse("136577763012789458630812222951472642381766") };
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
public class A258441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258441Inst Instance=new A258441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258442
{
public static readonly BigInteger[] Value={ 2484L,3706711688304L,BigInteger.Parse("5696462668411740751524"),BigInteger.Parse("8754305611527549602378580888144"),BigInteger.Parse("13453588867526192558135312033676410914164"),BigInteger.Parse("20675432347037054365824241005098474993236683565584"),BigInteger.Parse("31773938310893899311445242803186409506547794898889170298404") };
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
public class A258442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258442Inst Instance=new A258442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258443
{
public static readonly BigInteger[] Value={ 10039491L,9002622519L,632913667646139L,567557703066557511L,BigInteger.Parse("39901154831776816303176"),BigInteger.Parse("35780879673931397997716604"),BigInteger.Parse("2515512364950294599811639195654"),BigInteger.Parse("2255755394249701567388335466918226"),BigInteger.Parse("158586950299955622830941025383070794461") };
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
public class A258443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258443Inst Instance=new A258443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258444
{
public static readonly BigInteger[] Value={ 1349094322576L,BigInteger.Parse("1910746510353532612000"),BigInteger.Parse("2706224588156555124000697809136"),BigInteger.Parse("3832874471762384783002138104903925699456"),BigInteger.Parse("5428568929785331587316097630206410288870519307600"),BigInteger.Parse("7688579639781530489126233275115806835015504771403279234656") };
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
public class A258444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258444Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258444.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258444Inst Instance=new A258444Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258445
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,3L,3L,1L,1L,1L,1L,4L,4L,6L,4L,4L,1L,1L,1L,1L,5L,5L,10L,10L,10L,5L,5L,1L,1L,1L,1L,6L,6L,15L,15L,20L,15L,15L,6L,6L,1L,1L,1L,1L,7L,7L,21L,21L,35L,35L,35L,21L,21L,7L,7L,1L,1L,1L,1L,8L,8L,28L,28L,56L,56L,70L,56L,56L,28L,28L,8L,8L,1L,1L,1L,1L,9L,9L,36L,36L,84L,84L,126L,126L,126L,84L,84L,36L,36L,9L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258445Inst : IEnumerable<long>
{
public static readonly long[] Value=A258445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258445.Bytes);
public long this[int i]=>Value[i];

public static A258445Inst Instance=new A258445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258446
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,2L,6L,4L,10L,2L,2L,12L,6L,4L,2L,4L,2L,16L,6L,18L,4L,2L,6L,2L,10L,22L,2L,2L,2L,20L,12L,18L,6L,2L,28L,4L,2L,30L,8L,2L,10L,2L,16L,12L,2L,6L,2L,36L,18L,12L,2L,4L,2L,2L,40L,6L,2L,42L,10L,2L,12L,2L,22L,46L,4L,2L,2L,42L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258446Inst : IEnumerable<long>
{
public static readonly long[] Value=A258446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258446.Bytes);
public long this[int i]=>Value[i];

public static A258446Inst Instance=new A258446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258447
{
public static readonly long[] Value={ 1L,4L,3L,2L,1L,0L,1L,3L,2L,2L,4L,4L,3L,4L,3L,3L,3L,4L,3L,4L,3L,5L,5L,5L,4L,5L,4L,4L,4L,6L,5L,5L,4L,4L,5L,4L,4L,6L,5L,4L,4L,6L,5L,5L,4L,4L,6L,5L,4L,4L,4L,4L,5L,5L,4L,4L,4L,6L,6L,5L,4L,6L,5L,4L,4L,4L,5L,6L,5L,5L,5L,5L,4L,6L,5L,4L,5L,4L,5L,5L,4L,4L,6L,5L,4L,6L,5L,5L,5L,6L,5L,4L,5L,6L,5L,5L,4L,6L,5L,4L,4L,7L,6L,6L,5L,5L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258447Inst : IEnumerable<long>
{
public static readonly long[] Value=A258447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258447.Bytes);
public long this[int i]=>Value[i];

public static A258447Inst Instance=new A258447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258448
{
public static readonly long[] Value={ 1L,8L,21L,44L,69L,117L,153L,205L,241L,344L,417L,493L,545L,717L,793L,901L,945L,1185L,1313L,1413L,1481L,1793L,1953L,2069L,2201L,2445L,2633L,2793L,2881L,3341L,3489L,3633L,3785L,4173L,4457L,4653L,4785L,5309L,5585L,5877L,6097L,6429L,6801L,7061L,7337L,7833L,8161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258448Inst : IEnumerable<long>
{
public static readonly long[] Value=A258448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258448.Bytes);
public long this[int i]=>Value[i];

public static A258448Inst Instance=new A258448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258449
{
public static readonly long[] Value={ 302L,336L,384L,805L,1016L,1043L,1963L,2201L,2364L,2398L,2495L,2506L,2528L,2574L,2683L,2734L,3208L,4267L,4561L,4659L,5234L,5415L,5525L,5620L,5759L,5903L,6044L,6258L,6543L,7737L,7928L,8019L,8039L,8115L,8521L,8717L,8833L,9056L,9165L,9379L,9730L,10302L,10495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258449Inst : IEnumerable<long>
{
public static readonly long[] Value=A258449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258449.Bytes);
public long this[int i]=>Value[i];

public static A258449Inst Instance=new A258449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258450
{
public static readonly long[] Value={ 1L,0L,1L,2L,5L,13L,35L,100L,298L,926L,2995L,10045L,34871L,125040L,462283L,1759340L,6882479L,27639252L,113809750L,479993898L,2071411798L,9138568984L,41182104446L,189418562699L,888607018626L,4248949407337L,20695172225549L,102617378820155L,517728263280060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258450Inst : IEnumerable<long>
{
public static readonly long[] Value=A258450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258450.Bytes);
public long this[int i]=>Value[i];

public static A258450Inst Instance=new A258450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258451
{
public static readonly long[] Value={ 3L,4L,3L,2L,2L,3L,2L,3L,4L,5L,2L,3L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,2L,3L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,2L,3L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,2L,3L,2L,3L,4L,5L,2L,3L,2L,3L,4L,5L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258451Inst : IEnumerable<long>
{
public static readonly long[] Value=A258451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258451.Bytes);
public long this[int i]=>Value[i];

public static A258451Inst Instance=new A258451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258452
{
public static readonly long[] Value={ 9L,11L,21L,23L,45L,65L,79L,153L,155L,199L,361L,799L,883L,1237L,1253L,1753L,4975L,5117L,5843L,8179L,12831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258452Inst : IEnumerable<long>
{
public static readonly long[] Value=A258452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258452.Bytes);
public long this[int i]=>Value[i];

public static A258452Inst Instance=new A258452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258453
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,0L,0L,2L,-1L,-1L,0L,2L,0L,0L,-2L,2L,-1L,0L,1L,2L,-2L,0L,-2L,2L,0L,1L,0L,0L,0L,0L,-2L,2L,-1L,0L,0L,2L,1L,0L,-2L,0L,-2L,0L,2L,2L,-2L,2L,-2L,2L,0L,-1L,-1L,0L,0L,0L,-2L,4L,0L,0L,0L,2L,-2L,0L,-2L,0L,-1L,0L,2L,2L,0L,0L,-2L,2L,-1L,0L,0L,2L,-2L,-2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258453Inst : IEnumerable<long>
{
public static readonly long[] Value=A258453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258453.Bytes);
public long this[int i]=>Value[i];

public static A258453Inst Instance=new A258453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258454
{
public static readonly long[] Value={ 3L,4L,5L,8L,17L,32L,257L,512L,527L,992L,1952L,2522L,5252L,6512L,7412L,10376L,23432L,23717L,26732L,27302L,35114L,36632L,37442L,45872L,47027L,49022L,51092L,65537L,78899L,84242L,92432L,98432L,98672L,114767L,115292L,131072L,227222L,231167L,240977L,328352L,369272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258454Inst : IEnumerable<long>
{
public static readonly long[] Value=A258454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258454.Bytes);
public long this[int i]=>Value[i];

public static A258454Inst Instance=new A258454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258455
{
public static readonly long[] Value={ 2L,3L,37L,101L,197L,677L,5477L,8837L,17957L,21317L,42437L,98597L,106277L,148997L,217157L,331777L,401957L,454277L,1196837L,1378277L,1674437L,1705637L,1833317L,1865957L,2390117L,2735717L,3118757L,3147077L,3587237L,3865157L,4104677L,4519877L,4726277L,5410277L,6728837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258455Inst : IEnumerable<long>
{
public static readonly long[] Value=A258455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258455.Bytes);
public long this[int i]=>Value[i];

public static A258455Inst Instance=new A258455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258456
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,9L,11L,12L,13L,17L,18L,19L,20L,23L,25L,28L,29L,31L,32L,36L,37L,41L,43L,44L,45L,47L,48L,49L,50L,52L,53L,59L,61L,63L,64L,67L,68L,71L,73L,75L,76L,79L,80L,83L,89L,92L,97L,98L,99L,100L,101L,103L,107L,109L,112L,113L,116L,117L,121L,124L,127L,131L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258456Inst : IEnumerable<long>
{
public static readonly long[] Value=A258456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258456.Bytes);
public long this[int i]=>Value[i];

public static A258456Inst Instance=new A258456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258457
{
public static readonly long[] Value={ 1L,4L,12L,30L,72L,160L,351L,743L,1561L,3219L,6616L,13456L,27312L,55139L,111166L,223472L,448902L,900305L,1804838L,3615137L,7239325L,14490368L,29000050L,58025059L,116090823L,232234573L,464554483L,929220024L,1858618215L,3717468189L,7435305664L,14871092926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258457Inst : IEnumerable<long>
{
public static readonly long[] Value=A258457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258457.Bytes);
public long this[int i]=>Value[i];

public static A258457Inst Instance=new A258457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258458
{
public static readonly long[] Value={ 1L,7L,33L,130L,463L,1557L,5031L,15877L,49240L,151116L,460173L,1394645L,4212071L,12693724L,38195286L,114817389L,344911117L,1035659955L,3108817911L,9330152740L,27997803871L,84008165515L,252053831034L,756220333901L,2268778132337L,6806569134920L,20420175154486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258458Inst : IEnumerable<long>
{
public static readonly long[] Value=A258458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258458.Bytes);
public long this[int i]=>Value[i];

public static A258458Inst Instance=new A258458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258459
{
public static readonly long[] Value={ 1L,11L,77L,438L,2216L,10422L,46731L,202814L,860586L,3593561L,14834956L,60735095L,247155292L,1001318246L,4043482110L,16288762319L,65500024027L,263035832734L,1055252430510L,4230340216034L,16949359882259L,67881449170593L,271777855641517L,1087867649157513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258459Inst : IEnumerable<long>
{
public static readonly long[] Value=A258459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258459.Bytes);
public long this[int i]=>Value[i];

public static A258459Inst Instance=new A258459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258460
{
public static readonly long[] Value={ 1L,16L,157L,1223L,8331L,52078L,307122L,1738441L,9552809L,51357781L,271624053L,1418856775L,7341440755L,37708531955L,192586153199L,979219591861L,4961598056587L,25071026497266L,126410385360189L,636282269208285L,3198360708483673L,16059685003763157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258460Inst : IEnumerable<long>
{
public static readonly long[] Value=A258460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258460.Bytes);
public long this[int i]=>Value[i];

public static A258460Inst Instance=new A258460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258461
{
public static readonly long[] Value={ 1L,22L,289L,2957L,26073L,208516L,1558219L,11087756L,76079368L,507834013L,3318628444L,21330627775L,135325210699L,849659799754L,5290544981423L,32722489513367L,201296535378562L,1232850239039750L,7523511821431264L,45777353199866275L,277862479920868778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258461Inst : IEnumerable<long>
{
public static readonly long[] Value=A258461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258461.Bytes);
public long this[int i]=>Value[i];

public static A258461Inst Instance=new A258461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258462
{
public static readonly long[] Value={ 1L,29L,492L,6401L,70880L,704676L,6490951L,56524414L,471750267L,3810085912L,29989229859L,231255237311L,1754111872429L,13128442913712L,97189645384884L,713050007285941L,5192646586465458L,37581376345088462L,270593146237918806L,1939929376872664097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258462Inst : IEnumerable<long>
{
public static readonly long[] Value=A258462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258462.Bytes);
public long this[int i]=>Value[i];

public static A258462Inst Instance=new A258462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258463
{
public static readonly long[] Value={ 1L,37L,788L,12705L,172520L,2084836L,23169639L,241881526L,2406802476L,23064505721L,214505275665L,1947297442670L,17332491414616L,151788374231505L,1311496639250495L,11205023121304298L,94832831557086797L,796244028801983324L,6640545376656071546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258463Inst : IEnumerable<long>
{
public static readonly long[] Value=A258463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258463.Bytes);
public long this[int i]=>Value[i];

public static A258463Inst Instance=new A258463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258464
{
public static readonly BigInteger[] Value={ 1L,46L,1202L,23523L,384227L,5542879L,73055550L,899381476L,10501235760L,117575627562L,1272685923724L,13401470756233L,137945728220761L,1393299928219604L,13851195993228228L,135865787060383171L,1317624915100561406L,12654868264707446322UL,BigInteger.Parse("120534359759023523561") };
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
public class A258464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258464Inst Instance=new A258464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258465
{
public static readonly BigInteger[] Value={ 1L,56L,1762L,41143L,795657L,13499449L,208050040L,2979881876L,40300054520L,520576172762L,6478447651345L,78185947269684L,919805200917658L,10591351937396242L,119764715367192468L,1333512940732309728L,14652754322423701707UL,BigInteger.Parse("159182411488944508232") };
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
public class A258465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258465Inst Instance=new A258465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258466
{
public static readonly long[] Value={ 1L,1L,3L,8L,25L,82L,307L,1256L,5688L,28044L,149598L,855811L,5217604L,33711592L,229798958L,1646312694L,12355368849L,96861178984L,791258781708L,6720627124140L,59234364096426L,540812222095821L,5106663817156741L,49798678280227488L,500857393908312587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258466Inst : IEnumerable<long>
{
public static readonly long[] Value=A258466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258466.Bytes);
public long this[int i]=>Value[i];

public static A258466Inst Instance=new A258466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258467
{
public static readonly BigInteger[] Value={ 1L,2L,12L,130L,2216L,52078L,1558219L,56524414L,2406802476L,117575627562L,6478447651345L,397345158550386L,26842747368209994L,1980156804133210116L,BigInteger.Parse("158365138356099680582"),BigInteger.Parse("13647670818304698139989"),BigInteger.Parse("1260732993182758276252088"),BigInteger.Parse("124273946254095006307105363") };
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
public class A258467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258467Inst Instance=new A258467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258468
{
public static readonly long[] Value={ 0L,0L,3L,4L,15L,6L,35L,8L,18L,30L,99L,12L,143L,70L,165L,176L,255L,36L,323L,140L,357L,198L,483L,48L,550L,286L,621L,308L,783L,330L,899L,416L,957L,510L,1085L,108L,1295L,646L,1365L,160L,1599L,714L,1763L,836L,585L,966L,2115L,912L,2254L,1100L,2397L,1196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258468Inst : IEnumerable<long>
{
public static readonly long[] Value=A258468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258468.Bytes);
public long this[int i]=>Value[i];

public static A258468Inst Instance=new A258468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258469
{
public static readonly long[] Value={ 9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,45L,46L,47L,48L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,66L,67L,68L,71L,72L,73L,74L,75L,76L,77L,80L,81L,82L,83L,84L,85L,86L,87L,88L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258469Inst : IEnumerable<long>
{
public static readonly long[] Value=A258469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258469.Bytes);
public long this[int i]=>Value[i];

public static A258469Inst Instance=new A258469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258470
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,3L,4L,6L,7L,9L,11L,13L,16L,18L,21L,25L,28L,33L,36L,41L,46L,51L,57L,62L,68L,76L,82L,91L,97L,106L,115L,124L,134L,143L,153L,166L,176L,190L,200L,214L,228L,242L,257L,271L,286L,305L,320L,340L,355L,375L,395L,415L,436L,456L,477L,503L,524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258470Inst : IEnumerable<long>
{
public static readonly long[] Value=A258470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258470.Bytes);
public long this[int i]=>Value[i];

public static A258470Inst Instance=new A258470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258471
{
public static readonly long[] Value={ 1L,3L,11L,41L,155L,590L,2258L,8677L,33454L,129335L,501180L,1945997L,7569223L,29487091L,115029830L,449288570L,1756808604L,6876430799L,26940317004L,105635470645L,414528962220L,1627841401281L,6396735649200L,25152046015693L,98955167336425L,389526824102747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258471Inst : IEnumerable<long>
{
public static readonly long[] Value=A258471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258471.Bytes);
public long this[int i]=>Value[i];

public static A258471Inst Instance=new A258471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258472
{
public static readonly long[] Value={ 1L,4L,11L,24L,49L,89L,158L,262L,428L,667L,1033L,1542L,2289L,3313L,4765L,6717L,9427L,13011L,17882L,24260L,32763L,43775L,58268L,76837L,100953L,131629L,171003L,220683L,283877L,363016L,462794L,587005L,742332L,934536L,1173293L,1467022L,1829538L,2273365L,2817858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258472Inst : IEnumerable<long>
{
public static readonly long[] Value=A258472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258472.Bytes);
public long this[int i]=>Value[i];

public static A258472Inst Instance=new A258472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258473
{
public static readonly long[] Value={ 1L,5L,16L,41L,91L,186L,351L,635L,1090L,1824L,2939L,4652L,7162L,10875L,16159L,23758L,34321L,49145L,69389L,97213L,134608L,185172L,252182L,341443L,458413L,612186L,811567L,1070826L,1403784L,1832370L,2378320L,3074642L,3954869L,5068684L,6466697L,8222640L,10412903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258473Inst : IEnumerable<long>
{
public static readonly long[] Value=A258473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258473.Bytes);
public long this[int i]=>Value[i];

public static A258473Inst Instance=new A258473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258474
{
public static readonly long[] Value={ 1L,6L,22L,63L,155L,342L,700L,1343L,2463L,4323L,7361L,12139L,19581L,30819L,47697L,72388L,108390L,159752L,232833L,334917L,477270L,672589L,940222L,1301954L,1790117L,2441168L,3308341L,4451294L,5955870L,7918574L,10475192L,13779096L,18042899L,23506156L,30496836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258474Inst : IEnumerable<long>
{
public static readonly long[] Value=A258474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258474.Bytes);
public long this[int i]=>Value[i];

public static A258474Inst Instance=new A258474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258475
{
public static readonly long[] Value={ 1L,7L,29L,92L,247L,590L,1291L,2642L,5114L,9475L,16882L,29159L,48914L,80160L,128405L,201958L,311878L,474540L,711222L,1052949L,1539214L,2226774L,3186866L,4520230L,6351925L,8856519L,12248350L,16822982L,22940863L,31092121L,41871405L,56078299L,74676693L,98949447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258475Inst : IEnumerable<long>
{
public static readonly long[] Value=A258475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258475.Bytes);
public long this[int i]=>Value[i];

public static A258475Inst Instance=new A258475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258476
{
public static readonly long[] Value={ 1L,8L,37L,129L,376L,966L,2258L,4901L,10024L,19509L,36438L,65653L,114753L,195144L,324164L,526911L,840581L,1317461L,2033445L,3092660L,4643571L,6885877L,10099775L,14655962L,21067353L,30002794L,42376093L,59364880L,82558632L,113985165L,156352359L,213082865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258476Inst : IEnumerable<long>
{
public static readonly long[] Value=A258476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258476.Bytes);
public long this[int i]=>Value[i];

public static A258476Inst Instance=new A258476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258477
{
public static readonly long[] Value={ 1L,9L,46L,175L,551L,1517L,3775L,8677L,18702L,38221L,74670L,140380L,255200L,450587L,775050L,1302820L,2144491L,3464614L,5501502L,8601609L,13254960L,20160072L,30285308L,44987881L,66117110L,96226698L,138744972L,198343467L,281212898L,395689440L,552693604L,766773242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258477Inst : IEnumerable<long>
{
public static readonly long[] Value=A258477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258477.Bytes);
public long this[int i]=>Value[i];

public static A258477Inst Instance=new A258477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258478
{
public static readonly long[] Value={ 1L,10L,56L,231L,782L,2299L,6074L,14751L,33454L,71676L,146357L,286749L,542017L,992683L,1768044L,3071242L,5216904L,8682987L,14188324L,22794857L,36061113L,56235914L,86551836L,131580012L,197774522L,294103819L,433033550L,631622692L,913255789L,1309504156L,1863113073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258478Inst : IEnumerable<long>
{
public static readonly long[] Value=A258478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258478.Bytes);
public long this[int i]=>Value[i];

public static A258478Inst Instance=new A258478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258479
{
public static readonly long[] Value={ 1L,11L,67L,298L,1080L,3379L,9453L,24204L,57658L,129335L,275693L,562454L,1104484L,2097247L,3865383L,6937016L,12154390L,20838939L,35029203L,57829458L,93897437L,150150058L,236723504L,368350864L,566187387L,860416074L,1293614426L,1925547270L,2839214222L,4149449828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258479Inst : IEnumerable<long>
{
public static readonly long[] Value=A258479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258479.Bytes);
public long this[int i]=>Value[i];

public static A258479Inst Instance=new A258479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258480
{
public static readonly long[] Value={ 1L,12L,79L,377L,1457L,4836L,14289L,38493L,96151L,225486L,501180L,1063635L,2168132L,4265393L,8130869L,15067991L,27222865L,48062380L,83093629L,140925603L,234830485L,384989926L,621737584L,990119455L,1556378360L,2416887471L,3710698393L,5636503638L,8476224739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258480Inst : IEnumerable<long>
{
public static readonly long[] Value=A258480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258480.Bytes);
public long this[int i]=>Value[i];

public static A258480Inst Instance=new A258480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258481
{
public static readonly long[] Value={ 1L,3L,9L,48L,4L,8L,9L,9L,6L,5L,5L,0L,28L,70L,0L,89L,11L,48L,5L,8L,7L,8L,53L,3L,0L,26L,4L,6L,5L,9L,5L,8L,26L,3L,6L,20L,9L,1L,3L,43L,6L,86L,43L,4L,0L,0L,80L,7L,4L,4L,9L,1L,3L,86L,4L,77L,4L,70L,8L,74L,4L,2L,7L,6L,9L,88L,74L,7L,57L,8L,4L,0L,0L,28L,4L,62L,3L,4L,170L,6L,69L,87L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258481Inst : IEnumerable<long>
{
public static readonly long[] Value=A258481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258481.Bytes);
public long this[int i]=>Value[i];

public static A258481Inst Instance=new A258481Inst();

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