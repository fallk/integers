using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A270355
{
public static readonly BigInteger[] Value={ 2L,3L,5L,78L,4962L,15925310L,303532967750376L,BigInteger.Parse("72884922416996896007616951849"),BigInteger.Parse("3238110775186648021853203185875679911508503009261997468560"),BigInteger.Parse("7716186732679740909751872277405382774000613384297298421745471878603639986756704754013029661605882827711280194233739") };
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
public class A270355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270355Inst Instance=new A270355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270354
{
public static readonly BigInteger[] Value={ 3L,15L,207L,24777L,1797835772L,2401072239422894903L,BigInteger.Parse("36947191921380265723491992928675837908"),BigInteger.Parse("1242004943621920150072266455052958650167034792376067355585774287542963919184") };
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
public class A270354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270354Inst Instance=new A270354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270353
{
public static readonly BigInteger[] Value={ 8L,31L,540L,189864L,22502468823L,BigInteger.Parse("547694780221174920178"),BigInteger.Parse("287920070745319667821031437298831171428290"),BigInteger.Parse("271667810016366767427285213650617821610883263237085072498040538105208873088855853524") };
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
public class A270353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270353Inst Instance=new A270353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270352
{
public static readonly BigInteger[] Value={ 4L,8L,44L,977L,498723L,138012074956L,BigInteger.Parse("45087947486104434546449"),BigInteger.Parse("2223745971024423874814212532278502253766982404"),BigInteger.Parse("3439676840537267257806008796995789895364959784333600339427716437786254731225969490712842205") };
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
public class A270352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270352Inst Instance=new A270352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270351
{
public static readonly BigInteger[] Value={ 2L,5L,14L,707L,1470654L,1143462781221L,BigInteger.Parse("1805535113251940020114035"),BigInteger.Parse("2497859054491311040375647235065337168455108737151"),BigInteger.Parse("3189945744303964831068292153370103839290925070278698110007359838830245675325591867634500100743606") };
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
public class A270351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270351Inst Instance=new A270351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270350
{
public static readonly BigInteger[] Value={ 2L,3L,4L,44L,1446L,3423518L,263631451737996L,BigInteger.Parse("70985515555913904515293113895"),BigInteger.Parse("8645798497265822420998718966216306501746531100894289290802"),BigInteger.Parse("78713180847550502513757221862401308079612732875925186430170968601702893264445327722349352410275677392885249561650440") };
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
public class A270350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270350Inst Instance=new A270350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270349
{
public static readonly BigInteger[] Value={ 3L,7L,27L,650L,689392L,1130869248534L,BigInteger.Parse("2046949388776880512222550"),BigInteger.Parse("5664769376602746621028306587399157369622446276283"),BigInteger.Parse("61600875764518391286867927949695082949269716944423018977948114995142883041085134431474743108010213") };
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
public class A270349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270349Inst Instance=new A270349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270348
{
public static readonly BigInteger[] Value={ 2L,7L,43L,1161L,796510L,1101781866330L,BigInteger.Parse("648667164391834988511313"),BigInteger.Parse("521313118065995695198529265268104396429334449023"),BigInteger.Parse("177042477384698216444912803612486097958997328262217304760270340328784709181787835108737458616981") };
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
public class A270348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270348Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270348.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270348Inst Instance=new A270348Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270347
{
public static readonly BigInteger[] Value={ 2L,3L,7L,27L,650L,689392L,1130869248534L,BigInteger.Parse("2046949388776880512222550"),BigInteger.Parse("5664769376602746621028306587399157369622446276283"),BigInteger.Parse("61600875764518391286867927949695082949269716944423018977948114995142883041085134431474743108010213") };
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
public class A270347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270347Inst Instance=new A270347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270346
{
public static readonly BigInteger[] Value={ 2L,25L,280L,3087L,33959L,373552L,4109077L,45199854L,497198396L,5469182359L,60161005954L,661771065501L,7279481720513L,80074298925646L,880817288182111L,9688990170003228L,106578891870035510L,1172367810570390613L,12896045916274296748UL,BigInteger.Parse("141856505079017264235") };
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
public class A270346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270346Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270346.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270346Inst Instance=new A270346Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270345
{
public static readonly long[] Value={ 4L,8L,16L,24L,32L,48L,64L,72L,96L,120L,128L,144L,168L,169L,192L,216L,240L,256L,264L,272L,288L,336L,360L,384L,385L,432L,480L,504L,512L,528L,544L,576L,600L,648L,672L,720L,768L,792L,816L,840L,864L,960L,961L,1008L,1024L,1056L,1080L,1088L,1105L,1121L,1152L,1176L,1200L,1296L,1320L,1344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270345Inst : IEnumerable<long>
{
public static readonly long[] Value=A270345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270345.Bytes);
public long this[int i]=>Value[i];

public static A270345Inst Instance=new A270345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270344
{
public static readonly long[] Value={ 2L,17L,26L,2526L,5876126L,8061827L,8996188226L,5295909711327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270344Inst : IEnumerable<long>
{
public static readonly long[] Value=A270344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270344.Bytes);
public long this[int i]=>Value[i];

public static A270344Inst Instance=new A270344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270343
{
public static readonly long[] Value={ 0L,1L,81L,3144L,3256L,6225L,6484L,6576L,7121L,7529L,7676L,9100L,9324L,9361L,9729L,9784L,12144L,12256L,15225L,15484L,15576L,16121L,16529L,16676L,18100L,18324L,18361L,18729L,18784L,21144L,21256L,24225L,24484L,24576L,25121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270343Inst : IEnumerable<long>
{
public static readonly long[] Value=A270343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270343.Bytes);
public long this[int i]=>Value[i];

public static A270343Inst Instance=new A270343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270342
{
public static readonly long[] Value={ 3L,4L,5L,7L,8L,11L,13L,16L,17L,19L,23L,24L,29L,31L,32L,37L,41L,43L,47L,48L,53L,59L,61L,64L,67L,71L,72L,73L,79L,83L,89L,96L,97L,101L,103L,107L,109L,113L,120L,127L,128L,131L,137L,139L,144L,149L,151L,157L,163L,167L,168L,169L,173L,179L,181L,191L,192L,193L,197L,199L,211L,216L,223L,227L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270342Inst : IEnumerable<long>
{
public static readonly long[] Value=A270342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270342.Bytes);
public long this[int i]=>Value[i];

public static A270342Inst Instance=new A270342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270341
{
public static readonly long[] Value={ 0L,1L,136L,698L,3298L,4529L,4834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270341Inst : IEnumerable<long>
{
public static readonly long[] Value=A270341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270341.Bytes);
public long this[int i]=>Value[i];

public static A270341Inst Instance=new A270341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270340
{
public static readonly long[] Value={ 0L,1L,74L,130L,180L,192L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270340Inst : IEnumerable<long>
{
public static readonly long[] Value=A270340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270340.Bytes);
public long this[int i]=>Value[i];

public static A270340Inst Instance=new A270340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270227
{
public static readonly long[] Value={ 1L,2L,2L,4L,7L,4L,10L,32L,32L,10L,26L,193L,370L,193L,26L,76L,1382L,5950L,5950L,1382L,76L,232L,11719L,122984L,270529L,122984L,11719L,232L,764L,112604L,3175696L,16873930L,16873930L,3175696L,112604L,764L,2620L,1221889L,98815588L,1384880065L,3337807996L,1384880065L,98815588L,1221889L,2620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270227Inst : IEnumerable<long>
{
public static readonly long[] Value=A270227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270227.Bytes);
public long this[int i]=>Value[i];

public static A270227Inst Instance=new A270227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270226
{
public static readonly long[] Value={ 1L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270226Inst : IEnumerable<long>
{
public static readonly long[] Value=A270226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270226.Bytes);
public long this[int i]=>Value[i];

public static A270226Inst Instance=new A270226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270225
{
public static readonly long[] Value={ 3L,11L,17L,41L,59L,107L,137L,179L,227L,281L,347L,419L,521L,569L,617L,641L,659L,809L,827L,857L,881L,1019L,1049L,1091L,1289L,1427L,1451L,1481L,1619L,1667L,1697L,1721L,1787L,1931L,2027L,2081L,2129L,2267L,2339L,2657L,2729L,2801L,2969L,3251L,3257L,3299L,3329L,3371L,3467L,3539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270225Inst : IEnumerable<long>
{
public static readonly long[] Value=A270225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270225.Bytes);
public long this[int i]=>Value[i];

public static A270225Inst Instance=new A270225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270224
{
public static readonly long[] Value={ 4L,0L,28L,-20L,80L,-68L,136L,-108L,232L,-220L,352L,-324L,488L,-452L,576L,-476L,728L,-716L,976L,-948L,1240L,-1204L,1456L,-1364L,1720L,-1684L,2000L,-1916L,2264L,-2156L,2320L,-1980L,2488L,-2476L,2992L,-2964L,3512L,-3476L,3984L,-3892L,4504L,-4468L,5040L,-4956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270224Inst : IEnumerable<long>
{
public static readonly long[] Value=A270224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270224.Bytes);
public long this[int i]=>Value[i];

public static A270224Inst Instance=new A270224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270223
{
public static readonly long[] Value={ 1L,6L,11L,44L,57L,150L,175L,336L,389L,674L,739L,1156L,1249L,1830L,1959L,2664L,2893L,3850L,4091L,5308L,5577L,7086L,7391L,9152L,9549L,11666L,12099L,14532L,15049L,17830L,18455L,21400L,22365L,25818L,26795L,30764L,31769L,36286L,37327L,42352L,43485L,49122L,50291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270223Inst : IEnumerable<long>
{
public static readonly long[] Value=A270223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270223.Bytes);
public long this[int i]=>Value[i];

public static A270223Inst Instance=new A270223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270222
{
public static readonly long[] Value={ 1L,5L,33L,161L,705L,2945L,12033L,48641L,195585L,784385L,3141633L,12574721L,50315265L,201293825L,805240833L,3221094401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270222Inst : IEnumerable<long>
{
public static readonly long[] Value=A270222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270222.Bytes);
public long this[int i]=>Value[i];

public static A270222Inst Instance=new A270222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270221
{
public static readonly long[] Value={ 1L,5L,5L,33L,13L,93L,25L,161L,53L,285L,65L,417L,93L,581L,129L,705L,229L,957L,241L,1217L,269L,1509L,305L,1761L,397L,2117L,433L,2433L,517L,2781L,625L,2945L,965L,3453L,977L,3969L,1005L,4517L,1041L,5025L,1133L,5637L,1169L,6209L,1253L,6813L,1361L,7233L,1677L,7973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270221Inst : IEnumerable<long>
{
public static readonly long[] Value=A270221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270221.Bytes);
public long this[int i]=>Value[i];

public static A270221Inst Instance=new A270221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270220
{
public static readonly long[] Value={ 3L,1L,23L,-19L,75L,-63L,119L,-115L,235L,-223L,343L,-331L,483L,-447L,535L,-531L,779L,-767L,1015L,-1003L,1283L,-1247L,1463L,-1451L,1795L,-1759L,2039L,-2003L,2315L,-2207L,2263L,-2259L,2763L,-2751L,3255L,-3243L,3779L,-3743L,4215L,-4203L,4803L,-4767L,5303L,-5267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270220Inst : IEnumerable<long>
{
public static readonly long[] Value=A270220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270220.Bytes);
public long this[int i]=>Value[i];

public static A270220Inst Instance=new A270220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270219
{
public static readonly long[] Value={ 1L,5L,10L,38L,47L,131L,152L,292L,317L,577L,614L,994L,1043L,1575L,1660L,2280L,2369L,3237L,3338L,4454L,4567L,5963L,6112L,7724L,7885L,9841L,10038L,12274L,12507L,15055L,15396L,18000L,18345L,21453L,21810L,25422L,25791L,29939L,30344L,34964L,35381L,40601L,41054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270219Inst : IEnumerable<long>
{
public static readonly long[] Value=A270219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270219.Bytes);
public long this[int i]=>Value[i];

public static A270219Inst Instance=new A270219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270218
{
public static readonly long[] Value={ 1L,4L,28L,140L,620L,2604L,10668L,43180L,173740L,697004L,2792108L,11176620L,44722860L,178924204L,715762348L,2863180460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270218Inst : IEnumerable<long>
{
public static readonly long[] Value=A270218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270218.Bytes);
public long this[int i]=>Value[i];

public static A270218Inst Instance=new A270218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270217
{
public static readonly long[] Value={ 1L,4L,5L,28L,9L,84L,21L,140L,25L,260L,37L,380L,49L,532L,85L,620L,89L,868L,101L,1116L,113L,1396L,149L,1612L,161L,1956L,197L,2236L,233L,2548L,341L,2604L,345L,3108L,357L,3612L,369L,4148L,405L,4620L,417L,5220L,453L,5756L,489L,6324L,597L,6636L,609L,7364L,645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270217Inst : IEnumerable<long>
{
public static readonly long[] Value=A270217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270217.Bytes);
public long this[int i]=>Value[i];

public static A270217Inst Instance=new A270217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270216
{
public static readonly long[] Value={ 4L,7L,8L,16L,4L,40L,-28L,48L,4L,96L,-96L,96L,8L,200L,-292L,112L,4L,224L,-224L,224L,8L,448L,-680L,224L,8L,448L,-448L,448L,16L,904L,-1588L,240L,4L,480L,-480L,480L,8L,960L,-1448L,480L,8L,960L,-960L,960L,16L,1920L,-3384L,480L,8L,960L,-960L,960L,16L,1920L,-2896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270216Inst : IEnumerable<long>
{
public static readonly long[] Value=A270216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270216.Bytes);
public long this[int i]=>Value[i];

public static A270216Inst Instance=new A270216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270215
{
public static readonly long[] Value={ 1L,6L,18L,38L,74L,114L,194L,246L,346L,450L,650L,754L,954L,1162L,1570L,1686L,1914L,2146L,2602L,2834L,3290L,3754L,4666L,4898L,5354L,5818L,6730L,7194L,8106L,9034L,10866L,11110L,11594L,12082L,13050L,13538L,14506L,15482L,17418L,17906L,18874L,19850L,21786L,22762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270215Inst : IEnumerable<long>
{
public static readonly long[] Value=A270215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270215.Bytes);
public long this[int i]=>Value[i];

public static A270215Inst Instance=new A270215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270214
{
public static readonly long[] Value={ 1L,5L,12L,20L,36L,40L,80L,52L,100L,104L,200L,104L,200L,208L,408L,116L,228L,232L,456L,232L,456L,464L,912L,232L,456L,464L,912L,464L,912L,928L,1832L,244L,484L,488L,968L,488L,968L,976L,1936L,488L,968L,976L,1936L,976L,1936L,1952L,3872L,488L,968L,976L,1936L,976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270214Inst : IEnumerable<long>
{
public static readonly long[] Value=A270214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270214.Bytes);
public long this[int i]=>Value[i];

public static A270214Inst Instance=new A270214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270213
{
public static readonly long[] Value={ 4L,0L,36L,-29L,97L,-93L,193L,-189L,317L,-309L,473L,-473L,661L,-637L,861L,-853L,1101L,-1093L,1389L,-1401L,1701L,-1637L,1965L,-1917L,2261L,-2213L,2625L,-2617L,3025L,-2937L,3385L,-3373L,3869L,-3861L,4421L,-4457L,4981L,-4841L,5385L,-5257L,5797L,-5693L,6329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270213Inst : IEnumerable<long>
{
public static readonly long[] Value=A270213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270213.Bytes);
public long this[int i]=>Value[i];

public static A270213Inst Instance=new A270213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270212
{
public static readonly long[] Value={ 1L,6L,11L,52L,64L,173L,189L,398L,418L,755L,783L,1284L,1312L,2001L,2053L,2966L,3026L,4187L,4255L,5712L,5768L,7525L,7645L,9730L,9898L,12327L,12543L,15384L,15608L,18857L,19169L,22866L,23190L,27383L,27715L,32468L,32764L,38041L,38477L,44298L,44862L,51223L,51891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270212Inst : IEnumerable<long>
{
public static readonly long[] Value=A270212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270212.Bytes);
public long this[int i]=>Value[i];

public static A270212Inst Instance=new A270212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270035
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,10L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,10L,21L,11L,23L,12L,25L,13L,27L,14L,29L,10L,31L,16L,11L,17L,35L,12L,37L,19L,13L,10L,41L,14L,43L,11L,15L,23L,47L,12L,49L,10L,17L,13L,53L,18L,11L,14L,19L,29L,59L,10L,61L,31L,21L,16L,13L,11L,67L,17L,23L,10L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270035Inst : IEnumerable<long>
{
public static readonly long[] Value=A270035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270035.Bytes);
public long this[int i]=>Value[i];

public static A270035Inst Instance=new A270035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270034
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,0L,0L,0L,9L,10L,11L,12L,13L,14L,15L,16L,17L,9L,19L,10L,21L,11L,23L,12L,25L,13L,9L,14L,29L,10L,31L,16L,11L,17L,35L,9L,37L,19L,13L,10L,41L,14L,43L,11L,9L,23L,47L,12L,49L,10L,17L,13L,53L,9L,11L,14L,19L,29L,59L,10L,61L,31L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270034Inst : IEnumerable<long>
{
public static readonly long[] Value=A270034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270034.Bytes);
public long this[int i]=>Value[i];

public static A270034Inst Instance=new A270034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270033
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L,9L,19L,10L,21L,11L,23L,8L,25L,13L,9L,14L,29L,10L,31L,8L,11L,17L,35L,9L,37L,19L,13L,8L,41L,14L,43L,11L,9L,23L,47L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,8L,10L,10L,10L,10L,10L,10L,10L,8L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270033Inst : IEnumerable<long>
{
public static readonly long[] Value=A270033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270033.Bytes);
public long this[int i]=>Value[i];

public static A270033Inst Instance=new A270033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270032
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,7L,8L,9L,10L,11L,12L,13L,7L,15L,8L,17L,9L,19L,10L,7L,11L,23L,8L,25L,13L,9L,7L,29L,10L,31L,8L,11L,17L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,7L,9L,9L,9L,9L,9L,9L,7L,10L,10L,10L,10L,10L,10L,7L,8L,11L,11L,11L,11L,11L,7L,12L,8L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270032Inst : IEnumerable<long>
{
public static readonly long[] Value=A270032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270032.Bytes);
public long this[int i]=>Value[i];

public static A270032Inst Instance=new A270032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270031
{
public static readonly long[] Value={ 0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,7L,8L,9L,10L,11L,6L,13L,7L,15L,8L,17L,6L,19L,10L,7L,11L,23L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,6L,8L,8L,8L,8L,8L,6L,9L,9L,9L,9L,9L,6L,7L,10L,10L,10L,10L,6L,11L,7L,11L,11L,11L,6L,6L,6L,6L,6L,6L,6L,13L,13L,13L,7L,13L,6L,14L,14L,14L,14L,7L,6L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270031Inst : IEnumerable<long>
{
public static readonly long[] Value=A270031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270031.Bytes);
public long this[int i]=>Value[i];

public static A270031Inst Instance=new A270031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270030
{
public static readonly long[] Value={ 0L,0L,0L,5L,0L,0L,0L,0L,5L,6L,7L,8L,9L,5L,11L,6L,13L,7L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,5L,7L,7L,7L,7L,5L,8L,8L,8L,8L,5L,6L,9L,9L,9L,5L,5L,5L,5L,5L,5L,11L,11L,6L,7L,5L,12L,12L,12L,6L,5L,6L,6L,6L,6L,5L,6L,14L,7L,8L,5L,5L,5L,5L,5L,5L,16L,6L,7L,7L,5L,7L,7L,6L,7L,5L,9L,18L,18L,6L,5L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270030Inst : IEnumerable<long>
{
public static readonly long[] Value=A270030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270030.Bytes);
public long this[int i]=>Value[i];

public static A270030Inst Instance=new A270030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270029
{
public static readonly long[] Value={ 0L,0L,4L,0L,0L,0L,4L,5L,6L,7L,4L,4L,4L,4L,4L,5L,5L,5L,4L,6L,6L,6L,4L,7L,7L,7L,4L,4L,4L,4L,4L,9L,5L,9L,4L,10L,10L,5L,4L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,17L,5L,5L,4L,5L,5L,7L,4L,7L,5L,7L,4L,4L,4L,4L,4L,5L,5L,5L,4L,5L,5L,5L,4L,5L,5L,5L,4L,4L,4L,4L,4L,5L,5L,5L,4L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270029Inst : IEnumerable<long>
{
public static readonly long[] Value=A270029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270029.Bytes);
public long this[int i]=>Value[i];

public static A270029Inst Instance=new A270029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270028
{
public static readonly long[] Value={ 3L,0L,3L,3L,3L,4L,3L,5L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,4L,3L,3L,3L,4L,3L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,5L,3L,3L,3L,6L,3L,6L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,4L,3L,3L,3L,4L,3L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270028Inst : IEnumerable<long>
{
public static readonly long[] Value=A270028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270028.Bytes);
public long this[int i]=>Value[i];

public static A270028Inst Instance=new A270028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270027
{
public static readonly long[] Value={ 0L,0L,3L,4L,5L,3L,7L,4L,3L,3L,3L,3L,13L,7L,3L,4L,4L,3L,3L,3L,3L,11L,23L,3L,5L,5L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,6L,3L,43L,4L,3L,3L,3L,3L,4L,4L,3L,4L,5L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,3L,4L,4L,3L,3L,3L,3L,4L,4L,3L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270027Inst : IEnumerable<long>
{
public static readonly long[] Value=A270027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270027.Bytes);
public long this[int i]=>Value[i];

public static A270027Inst Instance=new A270027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270026
{
public static readonly long[] Value={ 0L,2L,3L,2L,2L,2L,7L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270026Inst : IEnumerable<long>
{
public static readonly long[] Value=A270026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270026.Bytes);
public long this[int i]=>Value[i];

public static A270026Inst Instance=new A270026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270025
{
public static readonly long[] Value={ 4L,3L,12L,8L,12L,4L,32L,24L,0L,24L,36L,36L,16L,-8L,72L,48L,20L,36L,48L,28L,36L,0L,124L,84L,0L,-4L,88L,124L,-92L,196L,-80L,344L,-128L,148L,76L,200L,-120L,124L,64L,204L,-132L,260L,-108L,404L,-356L,496L,-196L,432L,-184L,96L,240L,152L,-152L,128L,328L,188L,-136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270025Inst : IEnumerable<long>
{
public static readonly long[] Value=A270025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270025.Bytes);
public long this[int i]=>Value[i];

public static A270025Inst Instance=new A270025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270024
{
public static readonly long[] Value={ 1L,6L,14L,34L,62L,102L,146L,222L,322L,422L,546L,706L,902L,1114L,1318L,1594L,1918L,2262L,2642L,3070L,3526L,4018L,4510L,5126L,5826L,6526L,7222L,8006L,8914L,9730L,10742L,11674L,12950L,14098L,15394L,16766L,18338L,19790L,21366L,23006L,24850L,26562L,28534L,30398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270024Inst : IEnumerable<long>
{
public static readonly long[] Value=A270024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270024.Bytes);
public long this[int i]=>Value[i];

public static A270024Inst Instance=new A270024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270023
{
public static readonly long[] Value={ 1L,5L,20L,76L,276L,932L,3944L,15956L,65692L,259452L,1035464L,4159724L,16638488L,66605372L,266499652L,1065764840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270023Inst : IEnumerable<long>
{
public static readonly long[] Value=A270023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270023.Bytes);
public long this[int i]=>Value[i];

public static A270023Inst Instance=new A270023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270022
{
public static readonly long[] Value={ 1L,5L,8L,20L,28L,40L,44L,76L,100L,100L,124L,160L,196L,212L,204L,276L,324L,344L,380L,428L,456L,492L,492L,616L,700L,700L,696L,784L,908L,816L,1012L,932L,1276L,1148L,1296L,1372L,1572L,1452L,1576L,1640L,1844L,1712L,1972L,1864L,2268L,1912L,2408L,2212L,2644L,2460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270022Inst : IEnumerable<long>
{
public static readonly long[] Value=A270022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270022.Bytes);
public long this[int i]=>Value[i];

public static A270022Inst Instance=new A270022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270021
{
public static readonly long[] Value={ 4L,0L,32L,-28L,100L,-96L,200L,-200L,320L,-304L,464L,-460L,652L,-616L,808L,-800L,1056L,-1040L,1328L,-1336L,1640L,-1600L,1944L,-1932L,2320L,-2316L,2696L,-2672L,3128L,-3112L,3576L,-3548L,4000L,-3976L,4500L,-4444L,4996L,-4976L,5528L,-5528L,6172L,-6076L,6768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270021Inst : IEnumerable<long>
{
public static readonly long[] Value=A270021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270021.Bytes);
public long this[int i]=>Value[i];

public static A270021Inst Instance=new A270021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270020
{
public static readonly long[] Value={ 1L,6L,11L,48L,57L,166L,179L,392L,405L,738L,767L,1260L,1293L,1978L,2047L,2924L,3001L,4134L,4227L,5648L,5733L,7458L,7583L,9652L,9789L,12246L,12387L,15224L,15389L,18682L,18863L,22620L,22829L,27038L,27271L,32004L,32293L,37578L,37887L,43724L,44033L,50514L,50919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270020Inst : IEnumerable<long>
{
public static readonly long[] Value=A270020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270020.Bytes);
public long this[int i]=>Value[i];

public static A270020Inst Instance=new A270020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269955
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,6L,1L,0L,1L,14L,27L,1L,0L,1L,30L,123L,124L,1L,0L,1L,62L,459L,988L,645L,1L,0L,1L,126L,1563L,5788L,8165L,3906L,1L,0L,1L,254L,5067L,29404L,69765L,72426L,27391L,1L,0L,1L,510L,15963L,137884L,495845L,853146L,698719L,219192L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269955Inst : IEnumerable<long>
{
public static readonly long[] Value=A269955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269955.Bytes);
public long this[int i]=>Value[i];

public static A269955Inst Instance=new A269955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269954
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,2L,5L,3L,1L,0L,9L,20L,17L,6L,1L,0L,44L,109L,100L,45L,10L,1L,0L,265L,689L,694L,355L,100L,15L,1L,0L,1854L,5053L,5453L,3094L,1015L,196L,21L,1L,0L,14833L,42048L,48082L,29596L,10899L,2492L,350L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269954Inst : IEnumerable<long>
{
public static readonly long[] Value=A269954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269954.Bytes);
public long this[int i]=>Value[i];

public static A269954Inst Instance=new A269954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269953
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,1L,-1L,2L,0L,1L,1L,0L,5L,2L,1L,-1L,9L,15L,15L,5L,1L,1L,35L,94L,85L,40L,9L,1L,-1L,230L,595L,609L,315L,91L,14L,1L,1L,1624L,4458L,4844L,2779L,924L,182L,20L,1L,-1L,13209L,37590L,43238L,26817L,9975L,2310L,330L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269953Inst : IEnumerable<long>
{
public static readonly long[] Value=A269953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269953.Bytes);
public long this[int i]=>Value[i];

public static A269953Inst Instance=new A269953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269952
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,4L,5L,1L,0L,8L,19L,9L,1L,0L,16L,65L,55L,14L,1L,0L,32L,211L,285L,125L,20L,1L,0L,64L,665L,1351L,910L,245L,27L,1L,0L,128L,2059L,6069L,5901L,2380L,434L,35L,1L,0L,256L,6305L,26335L,35574L,20181L,5418L,714L,44L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269952Inst : IEnumerable<long>
{
public static readonly long[] Value=A269952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269952.Bytes);
public long this[int i]=>Value[i];

public static A269952Inst Instance=new A269952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269951
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,5L,5L,1L,0L,16L,23L,9L,1L,0L,65L,116L,65L,14L,1L,0L,326L,669L,470L,145L,20L,1L,0L,1957L,4429L,3634L,1415L,280L,27L,1L,0L,13700L,33375L,30681L,14084L,3535L,490L,35L,1L,0L,109601L,283072L,284066L,147532L,43939L,7756L,798L,44L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269951Inst : IEnumerable<long>
{
public static readonly long[] Value=A269951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269951.Bytes);
public long this[int i]=>Value[i];

public static A269951Inst Instance=new A269951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269950
{
public static readonly long[] Value={ 1L,3L,1L,15L,5L,1L,35L,35L,7L,1L,315L,105L,63L,9L,1L,693L,1155L,231L,99L,11L,1L,3003L,3003L,3003L,429L,143L,13L,1L,6435L,15015L,9009L,6435L,715L,195L,15L,1L,109395L,36465L,51051L,21879L,12155L,1105L,255L,17L,1L,230945L,692835L,138567L,138567L,46189L,20995L,1615L,323L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269950Inst : IEnumerable<long>
{
public static readonly long[] Value=A269950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269950.Bytes);
public long this[int i]=>Value[i];

public static A269950Inst Instance=new A269950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269949
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,5L,15L,5L,1L,35L,35L,35L,7L,1L,63L,315L,105L,63L,9L,1L,231L,693L,1155L,231L,99L,11L,1L,429L,3003L,3003L,3003L,429L,143L,13L,1L,6435L,6435L,15015L,9009L,6435L,715L,195L,15L,1L,12155L,109395L,36465L,51051L,21879L,12155L,1105L,255L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269949Inst : IEnumerable<long>
{
public static readonly long[] Value=A269949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269949.Bytes);
public long this[int i]=>Value[i];

public static A269949Inst Instance=new A269949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269948
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,9L,1L,0L,1L,73L,36L,1L,0L,1L,585L,1045L,100L,1L,0L,1L,4681L,28800L,7445L,225L,1L,0L,1L,37449L,782281L,505280L,35570L,441L,1L,0L,1L,299593L,21159036L,33120201L,4951530L,130826L,784L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269948Inst : IEnumerable<long>
{
public static readonly long[] Value=A269948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269948.Bytes);
public long this[int i]=>Value[i];

public static A269948Inst Instance=new A269948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269947
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,8L,9L,1L,0L,216L,251L,36L,1L,0L,13824L,16280L,2555L,100L,1L,0L,1728000L,2048824L,335655L,15055L,225L,1L,0L,373248000L,444273984L,74550304L,3587535L,63655L,441L,1L,0L,128024064000L,152759224512L,26015028256L,1305074809L,25421200L,214918L,784L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269947Inst : IEnumerable<long>
{
public static readonly long[] Value=A269947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269947.Bytes);
public long this[int i]=>Value[i];

public static A269947Inst Instance=new A269947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269946
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,18L,18L,1L,0L,504L,648L,72L,1L,0L,32760L,47160L,7200L,200L,1L,0L,4127760L,6305040L,1141560L,45000L,450L,1L,0L,895723920L,1416456720L,283704120L,13741560L,198450L,882L,1L,0L,308129028480L,498072032640L,106386981120L,5876519040L,106616160L,691488L,1568L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269946Inst : IEnumerable<long>
{
public static readonly long[] Value=A269946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269946.Bytes);
public long this[int i]=>Value[i];

public static A269946Inst Instance=new A269946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269945
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,5L,1L,0L,1L,21L,14L,1L,0L,1L,85L,147L,30L,1L,0L,1L,341L,1408L,627L,55L,1L,0L,1L,1365L,13013L,11440L,2002L,91L,1L,0L,1L,5461L,118482L,196053L,61490L,5278L,140L,1L,0L,1L,21845L,1071799L,3255330L,1733303L,251498L,12138L,204L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269945Inst : IEnumerable<long>
{
public static readonly long[] Value=A269945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269945.Bytes);
public long this[int i]=>Value[i];

public static A269945Inst Instance=new A269945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269944
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,4L,5L,1L,0L,36L,49L,14L,1L,0L,576L,820L,273L,30L,1L,0L,14400L,21076L,7645L,1023L,55L,1L,0L,518400L,773136L,296296L,44473L,3003L,91L,1L,0L,25401600L,38402064L,15291640L,2475473L,191620L,7462L,140L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269944Inst : IEnumerable<long>
{
public static readonly long[] Value=A269944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269944.Bytes);
public long this[int i]=>Value[i];

public static A269944Inst Instance=new A269944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269943
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,6L,0L,16L,60L,90L,0L,288L,1176L,2520L,2520L,0L,9216L,39360L,98280L,151200L,113400L,0L,460800L,2023296L,5504400L,10311840L,12474000L,7484400L,0L,33177600L,148442112L,426666240L,896575680L,1362160800L,1362160800L,681080400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269943Inst : IEnumerable<long>
{
public static readonly long[] Value=A269943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269943.Bytes);
public long this[int i]=>Value[i];

public static A269943Inst Instance=new A269943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269942
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-1L,1L,0L,-2L,1L,2L,-1L,0L,-5L,5L,-1L,5L,-2L,-3L,1L,0L,-14L,21L,-3L,-6L,1L,14L,-12L,2L,-9L,3L,4L,-1L,0L,-42L,84L,-28L,-28L,7L,7L,-1L,42L,-56L,7L,14L,-2L,-28L,21L,-3L,14L,-4L,-5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269942Inst : IEnumerable<long>
{
public static readonly long[] Value=A269942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269942.Bytes);
public long this[int i]=>Value[i];

public static A269942Inst Instance=new A269942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269941
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-1L,1L,0L,-1L,2L,-1L,0L,-1L,1L,2L,-3L,1L,0L,-1L,2L,2L,-3L,-3L,4L,-1L,0L,-1L,1L,2L,2L,-1L,-6L,-3L,6L,4L,-5L,1L,0L,-1L,2L,2L,2L,-3L,-3L,-6L,-3L,4L,12L,4L,-10L,-5L,6L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269941Inst : IEnumerable<long>
{
public static readonly long[] Value=A269941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269941.Bytes);
public long this[int i]=>Value[i];

public static A269941Inst Instance=new A269941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269940
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,3L,0L,6L,20L,15L,0L,24L,130L,210L,105L,0L,120L,924L,2380L,2520L,945L,0L,720L,7308L,26432L,44100L,34650L,10395L,0L,5040L,64224L,303660L,705320L,866250L,540540L,135135L,0L,40320L,623376L,3678840L,11098780L,18858840L,18288270L,9459450L,2027025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269940Inst : IEnumerable<long>
{
public static readonly long[] Value=A269940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269940.Bytes);
public long this[int i]=>Value[i];

public static A269940Inst Instance=new A269940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269891
{
public static readonly long[] Value={ 3L,11L,29L,41L,71L,137L,179L,239L,269L,281L,311L,347L,521L,617L,659L,857L,1019L,1031L,1061L,1277L,1319L,1481L,1487L,1787L,1871L,1997L,2027L,2111L,2129L,2381L,2549L,3167L,3251L,3371L,3539L,3557L,3581L,3671L,3767L,3917L,3929L,4001L,4019L,4049L,4091L,4229L,4337L,4421L,4481L,4517L,4547L,4799L,4967L,5639L,5657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269891Inst : IEnumerable<long>
{
public static readonly long[] Value=A269891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269891.Bytes);
public long this[int i]=>Value[i];

public static A269891Inst Instance=new A269891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269890
{
public static readonly long[] Value={ 2L,8L,33L,193L,953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269890Inst : IEnumerable<long>
{
public static readonly long[] Value=A269890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269890.Bytes);
public long this[int i]=>Value[i];

public static A269890Inst Instance=new A269890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269889
{
public static readonly BigInteger[] Value={ 1L,1L,2L,0L,12L,84L,576L,4320L,36000L,332640L,3386880L,37739520L,457228800L,5987520000L,84304281600L,1270312243200L,20399720140800L,347841381888000L,6276836966400000L,119510975840256000L,2394487765942272000L,BigInteger.Parse("50361071569256448000"),BigInteger.Parse("1109403315728547840000") };
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
public class A269889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269889Inst Instance=new A269889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269888
{
public static readonly long[] Value={ 0L,6L,6L,60L,432L,60L,450L,11280L,11280L,450L,3000L,250992L,943488L,250992L,3000L,18750L,5125008L,68182800L,68182800L,5125008L,18750L,112500L,99482544L,4546948272L,16086672048L,4546948272L,99482544L,112500L,656250L,1867222224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269888Inst : IEnumerable<long>
{
public static readonly long[] Value=A269888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269888.Bytes);
public long this[int i]=>Value[i];

public static A269888Inst Instance=new A269888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269887
{
public static readonly BigInteger[] Value={ 112500L,1867222224L,17784013336560L,148379658813705408L,BigInteger.Parse("1153865935196746139616"),BigInteger.Parse("8592417348512597988522360"),BigInteger.Parse("62120579251514053648879287744"),BigInteger.Parse("439567128842469596644913028893328") };
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
public class A269887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269887Inst Instance=new A269887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269886
{
public static readonly BigInteger[] Value={ 18750L,99482544L,288987039048L,733651366146384L,1733054018904626400L,BigInteger.Parse("3917218310933741356320"),BigInteger.Parse("8592417348512597988522360"),BigInteger.Parse("18442011794478916607017890864"),BigInteger.Parse("38934726067576779753040234742184") };
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
public class A269886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269886Inst Instance=new A269886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269885
{
public static readonly BigInteger[] Value={ 3000L,5125008L,4546948272L,3515869538472L,2524680110862912L,1733054018904626400L,BigInteger.Parse("1153865935196746139616"),BigInteger.Parse("751466744196523891197864"),BigInteger.Parse("481288296794232367244430960"),BigInteger.Parse("304238215502271049181330977896") };
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
public class A269885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269885Inst Instance=new A269885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269884
{
public static readonly BigInteger[] Value={ 450L,250992L,68182800L,16086672048L,3515869538472L,733651366146384L,148379658813705408L,BigInteger.Parse("29341273207567527696"),BigInteger.Parse("5704253667242854759944"),BigInteger.Parse("1094320479883646430148656"),BigInteger.Parse("207706999065060545864115696") };
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
public class A269884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269884Inst Instance=new A269884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269883
{
public static readonly BigInteger[] Value={ 60L,11280L,943488L,68182800L,4546948272L,288987039048L,17784013336560L,1069390341717552L,63195307974649056L,3684171438042095496L,BigInteger.Parse("212456461177871728704"),BigInteger.Parse("12143038817293086139824"),BigInteger.Parse("688894552975843324538640") };
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
public class A269883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269883Inst Instance=new A269883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269882
{
public static readonly BigInteger[] Value={ 6L,432L,11280L,250992L,5125008L,99482544L,1867222224L,34216907760L,615877284624L,10931855797296L,191890772032848L,3337772595455088L,57618604390530960L,988280162421210288L,16858064726292134352UL,BigInteger.Parse("286196732519053403376") };
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
public class A269882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269882Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269882.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269882Inst Instance=new A269882Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269881
{
public static readonly BigInteger[] Value={ 0L,432L,943488L,16086672048L,2524680110862912L,BigInteger.Parse("3917218310933741356320"),BigInteger.Parse("62120579251514053648879287744") };
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
public class A269881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269881Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269881.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269881Inst Instance=new A269881Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269880
{
public static readonly long[] Value={ 3L,0L,12L,-12L,12L,0L,48L,-60L,12L,0L,48L,-48L,48L,0L,192L,-252L,12L,0L,48L,-48L,48L,0L,192L,-240L,48L,0L,192L,-192L,192L,0L,768L,-1020L,12L,0L,48L,-48L,48L,0L,192L,-240L,48L,0L,192L,-192L,192L,0L,768L,-1008L,48L,0L,192L,-192L,192L,0L,768L,-960L,192L,0L,768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269880Inst : IEnumerable<long>
{
public static readonly long[] Value=A269880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269880.Bytes);
public long this[int i]=>Value[i];

public static A269880Inst Instance=new A269880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269879
{
public static readonly long[] Value={ 4L,0L,32L,-24L,84L,-72L,160L,-144L,260L,-240L,384L,-360L,532L,-504L,704L,-672L,900L,-864L,1120L,-1080L,1364L,-1320L,1632L,-1584L,1924L,-1872L,2240L,-2184L,2580L,-2520L,2944L,-2880L,3332L,-3264L,3744L,-3672L,4180L,-4104L,4640L,-4560L,5124L,-5040L,5632L,-5544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269879Inst : IEnumerable<long>
{
public static readonly long[] Value=A269879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269879.Bytes);
public long this[int i]=>Value[i];

public static A269879Inst Instance=new A269879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269878
{
public static readonly long[] Value={ 1L,6L,11L,48L,61L,158L,183L,368L,409L,710L,771L,1216L,1301L,1918L,2031L,2848L,2993L,4038L,4219L,5520L,5741L,7326L,7591L,9488L,9801L,12038L,12403L,15008L,15429L,18430L,18911L,22336L,22881L,26758L,27371L,31728L,32413L,37278L,38039L,43440L,44281L,50246L,51171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269878Inst : IEnumerable<long>
{
public static readonly long[] Value=A269878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269878.Bytes);
public long this[int i]=>Value[i];

public static A269878Inst Instance=new A269878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269877
{
public static readonly BigInteger[] Value={ 0L,8L,121728L,77214720L,12676235264L,1090372239360L,64922717257728L,3052335748087808L,121762580539637760L,4304417014325182464L,BigInteger.Parse("138706918527488491520"),BigInteger.Parse("4154140250223566389248"),BigInteger.Parse("117243264067548833906688"),BigInteger.Parse("3150495258536853477785600"),BigInteger.Parse("81236017376284183797694464") };
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
public class A269877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269877Inst Instance=new A269877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269876
{
public static readonly long[] Value={ 1L,5L,5L,37L,13L,97L,25L,185L,41L,301L,61L,445L,85L,617L,113L,817L,145L,1045L,181L,1301L,221L,1585L,265L,1897L,313L,2237L,365L,2605L,421L,3001L,481L,3425L,545L,3877L,613L,4357L,685L,4865L,761L,5401L,841L,5965L,925L,6557L,1013L,7177L,1105L,7825L,1201L,8501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269876Inst : IEnumerable<long>
{
public static readonly long[] Value=A269876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269876.Bytes);
public long this[int i]=>Value[i];

public static A269876Inst Instance=new A269876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269827
{
public static readonly BigInteger[] Value={ 6400L,5145736L,2472983556L,1109236460528L,467693538063508L,190428267451649488L,BigInteger.Parse("75641344262475714972"),BigInteger.Parse("29473512707098125940768"),BigInteger.Parse("11320636579997479605633644"),BigInteger.Parse("4297304706560967747684698760") };
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
public class A269827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269827Inst Instance=new A269827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269826
{
public static readonly BigInteger[] Value={ 1280L,462680L,90748696L,16644595392L,2840332868960L,467693538063508L,74936429415811576L,11771832152564634464UL,BigInteger.Parse("1821445245786662249776"),BigInteger.Parse("278444152926792624952684"),BigInteger.Parse("42152783102393213438270928") };
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
public class A269826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269826Inst Instance=new A269826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269825
{
public static readonly BigInteger[] Value={ 240L,39784L,3200604L,240637408L,16644595392L,1109236460528L,71730749075588L,4544255355000752L,283289815771686692L,17440137572474977008UL,BigInteger.Parse("1062799029214265825864"),BigInteger.Parse("64226079502012687928352") };
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
public class A269825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269825Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269825.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269825Inst Instance=new A269825Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269824
{
public static readonly BigInteger[] Value={ 40L,3096L,103296L,3200604L,90748696L,2472983556L,65284613232L,1686961414812L,42866673833128L,1075244105809044L,26689182058679264L,656784781178376396L,16046367933842361752UL,BigInteger.Parse("389645465813128015044"),BigInteger.Parse("9411830636459978769552") };
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
public class A269824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269824Inst Instance=new A269824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269823
{
public static readonly long[] Value={ 5L,216L,3096L,39784L,462680L,5145736L,55265336L,580002280L,5978552216L,60784629832L,611189228792L,6090202880680L,60229576820312L,591855697435912L,5784216137341880L,56261693581866856L,544976552619855128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269823Inst : IEnumerable<long>
{
public static readonly long[] Value=A269823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269823.Bytes);
public long this[int i]=>Value[i];

public static A269823Inst Instance=new A269823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269822
{
public static readonly long[] Value={ 0L,5L,40L,240L,1280L,6400L,30720L,143360L,655360L,2949120L,13107200L,57671680L,251658240L,1090519040L,4697620480L,20132659200L,85899345920L,365072220160L,1546188226560L,6528350289920L,27487790694400L,115448720916480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269822Inst : IEnumerable<long>
{
public static readonly long[] Value=A269822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269822.Bytes);
public long this[int i]=>Value[i];

public static A269822Inst Instance=new A269822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269821
{
public static readonly BigInteger[] Value={ 0L,216L,103296L,240637408L,2840332868960L,190428267451649488L,BigInteger.Parse("74703200829032822656704"),BigInteger.Parse("174692108176538512510958268440") };
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
public class A269821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269821Inst Instance=new A269821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269820
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,33L,265L,2657L,31949L,447809L,7170193L,129126849L,2583427349L,56849678689L,1364649651865L,35486043526177L,993722660727005L,29814403968536193L,954131785638216481L,BigInteger.Parse("32442465432874088321"),BigInteger.Parse("1167988313532759193637"),BigInteger.Parse("44385462193094951063201") };
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
public class A269820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269820Inst Instance=new A269820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269819
{
public static readonly long[] Value={ 5L,11L,13L,19L,29L,35L,37L,43L,53L,59L,61L,67L,77L,83L,85L,91L,101L,107L,109L,115L,125L,131L,133L,139L,149L,155L,157L,163L,173L,179L,181L,187L,197L,203L,205L,211L,221L,227L,229L,235L,245L,251L,253L,259L,269L,275L,277L,283L,293L,299L,301L,307L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269819Inst : IEnumerable<long>
{
public static readonly long[] Value=A269819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269819.Bytes);
public long this[int i]=>Value[i];

public static A269819Inst Instance=new A269819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269818
{
public static readonly long[] Value={ 1L,2L,8L,32L,50L,98L,128L,162L,200L,242L,338L,392L,512L,578L,722L,968L,1058L,1352L,1458L,1568L,1682L,1922L,2048L,2312L,2450L,2592L,2738L,2888L,3200L,3362L,3698L,3872L,4232L,4418L,4802L,5408L,5618L,6050L,6728L,6962L,7442L,7688L,8192L,8450L,8978L,9248L,9800L,10082L,10368L,10658L,10952L,11552L,11858L,12482L,12800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269818Inst : IEnumerable<long>
{
public static readonly long[] Value=A269818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269818.Bytes);
public long this[int i]=>Value[i];

public static A269818Inst Instance=new A269818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269817
{
public static readonly long[] Value={ 4L,0L,32L,-28L,92L,-80L,164L,-156L,284L,-272L,416L,-388L,560L,-528L,716L,-700L,956L,-944L,1216L,-1188L,1484L,-1432L,1728L,-1676L,2024L,-1976L,2332L,-2260L,2648L,-2576L,2972L,-2940L,3452L,-3440L,3968L,-3940L,4492L,-4440L,4992L,-4940L,5540L,-5472L,6064L,-5956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269817Inst : IEnumerable<long>
{
public static readonly long[] Value=A269817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269817.Bytes);
public long this[int i]=>Value[i];

public static A269817Inst Instance=new A269817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269816
{
public static readonly long[] Value={ 1L,6L,11L,48L,57L,158L,179L,364L,393L,706L,747L,1204L,1273L,1902L,2003L,2820L,2937L,4010L,4139L,5484L,5641L,7282L,7491L,9428L,9689L,11974L,12283L,14924L,15305L,18334L,18787L,22212L,22697L,26634L,27131L,31596L,32121L,37138L,37715L,43284L,43913L,50082L,50779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269816Inst : IEnumerable<long>
{
public static readonly long[] Value=A269816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269816.Bytes);
public long this[int i]=>Value[i];

public static A269816Inst Instance=new A269816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269815
{
public static readonly long[] Value={ 1L,5L,37L,185L,817L,3425L,14017L,56705L,228097L,914945L,3664897L,14669825L,58699777L,234840065L,939442177L,3757932545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269815Inst : IEnumerable<long>
{
public static readonly long[] Value=A269815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269815.Bytes);
public long this[int i]=>Value[i];

public static A269815Inst Instance=new A269815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269814
{
public static readonly long[] Value={ 1L,5L,5L,37L,9L,101L,21L,185L,29L,313L,41L,457L,69L,629L,101L,817L,117L,1073L,129L,1345L,157L,1641L,209L,1937L,261L,2285L,309L,2641L,381L,3029L,453L,3425L,485L,3937L,497L,4465L,525L,5017L,577L,5569L,629L,6169L,697L,6761L,805L,7369L,929L,7969L,1029L,8669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269814Inst : IEnumerable<long>
{
public static readonly long[] Value=A269814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269814.Bytes);
public long this[int i]=>Value[i];

public static A269814Inst Instance=new A269814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269813
{
public static readonly long[] Value={ 3L,1L,27L,-23L,83L,-71L,143L,-139L,263L,-251L,383L,-363L,515L,-487L,647L,-643L,895L,-883L,1143L,-1123L,1399L,-1355L,1607L,-1563L,1875L,-1815L,2143L,-2131L,2467L,-2399L,2735L,-2731L,3239L,-3227L,3743L,-3723L,4255L,-4211L,4719L,-4675L,5239L,-5163L,5711L,-5659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269813Inst : IEnumerable<long>
{
public static readonly long[] Value=A269813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269813.Bytes);
public long this[int i]=>Value[i];

public static A269813Inst Instance=new A269813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269812
{
public static readonly long[] Value={ 1L,5L,10L,42L,51L,143L,164L,328L,353L,641L,678L,1098L,1155L,1727L,1812L,2544L,2633L,3617L,3718L,4962L,5083L,6603L,6768L,8540L,8749L,10833L,11102L,13514L,13795L,16543L,16892L,19976L,20329L,23921L,24286L,28394L,28779L,33419L,33848L,38996L,39469L,45181L,45730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269812Inst : IEnumerable<long>
{
public static readonly long[] Value=A269812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269812.Bytes);
public long this[int i]=>Value[i];

public static A269812Inst Instance=new A269812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269763
{
public static readonly BigInteger[] Value={ 450L,524160L,326697720L,170119348800L,81208264293720L,36821411380183680L,16136599337765506680UL,BigInteger.Parse("6902518041829140001920"),BigInteger.Parse("2899610192068539725611800"),BigInteger.Parse("1201070898923243105905234560"),BigInteger.Parse("491952252969600904794435746040") };
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
public class A269763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269763Inst Instance=new A269763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269762
{
public static readonly BigInteger[] Value={ 60L,17520L,2624640L,326697720L,37212131520L,4022791852800L,420141188848320L,42818890099881480L,4284894917784397440L,BigInteger.Parse("422758967764941655440"),BigInteger.Parse("41241625930544770099200"),BigInteger.Parse("3986294332446031676572440") };
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
public class A269762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269762Inst Instance=new A269762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269761
{
public static readonly BigInteger[] Value={ 6L,480L,17520L,524160L,14288400L,368958240L,9195061680L,223482006720L,5331222081360L,125355762453600L,2913873085171440L,67100778335162880L,1533214659516235920L,BigInteger.Parse("34803572453875078560"),BigInteger.Parse("785602378216093258800") };
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
public class A269761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269761Inst Instance=new A269761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269760
{
public static readonly long[] Value={ 0L,6L,60L,450L,3000L,18750L,112500L,656250L,3750000L,21093750L,117187500L,644531250L,3515625000L,19042968750L,102539062500L,549316406250L,2929687500000L,15563964843750L,82397460937500L,434875488281250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269760Inst : IEnumerable<long>
{
public static readonly long[] Value=A269760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269760.Bytes);
public long this[int i]=>Value[i];

public static A269760Inst Instance=new A269760Inst();

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