using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A232297
{
public static readonly long[] Value={ 1L,73L,1313L,20563L,336079L,5546705L,91293443L,1501960031L,24713799985L,406656992827L,6691352475451L,110103034876825L,1811693873275549L,29810574840844381L,490519050740934291L,8071261298331724901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232297Inst : IEnumerable<long>
{
public static readonly long[] Value=A232297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232297.Bytes);
public long this[int i]=>Value[i];

public static A232297Inst Instance=new A232297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232298
{
public static readonly BigInteger[] Value={ 1L,355L,17759L,718483L,31119789L,1370434057L,60054788123L,2629547976059L,115168967578383L,5044363984412427L,220938351417726213L,9676874008509774099UL,BigInteger.Parse("423837490846852109695"),BigInteger.Parse("18563663237964339458229"),BigInteger.Parse("813070077580205734910151") };
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
public class A232298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232298Inst Instance=new A232298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232299
{
public static readonly BigInteger[] Value={ 1L,1727L,240241L,25116353L,2885285507L,339565321435L,39660722273643L,4626194825153697L,539876319125367771L,BigInteger.Parse("63007847133734278905"),BigInteger.Parse("7353315697711530754635"),BigInteger.Parse("858164092027643141044841") };
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
public class A232299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232299Inst Instance=new A232299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232300
{
public static readonly BigInteger[] Value={ 1L,8401L,3249889L,877968487L,267483142619L,84130295708483L,26187902385019287L,8136241891839631865L,BigInteger.Parse("2529645200623557298353"),BigInteger.Parse("786580592473211934495715"),BigInteger.Parse("244572157423387608710030975"),BigInteger.Parse("76044579489609299365492556559") };
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
public class A232300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232300Inst Instance=new A232300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232301
{
public static readonly BigInteger[] Value={ 1L,40867L,43963319L,30690409685L,24797475083765L,20843967523877175L,17291702408190208843UL,BigInteger.Parse("14309005468246109828087"),BigInteger.Parse("11852395942038473338742213"),BigInteger.Parse("9819088600464792990304624339"),BigInteger.Parse("8134045894315455725212916395019") };
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
public class A232301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232301Inst Instance=new A232301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232302
{
public static readonly BigInteger[] Value={ 1L,37L,5149L,6363511L,66287652717L,5637591065064585L,BigInteger.Parse("3953611274692252664219"),BigInteger.Parse("22845060732287997693078487339"),BigInteger.Parse("1087328305739985850553848837289874701"),BigInteger.Parse("426327214385010895269748977017138080515645751") };
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
public class A232302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232302Inst Instance=new A232302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232303
{
public static readonly long[] Value={ 3L,37L,257L,1915L,14223L,105411L,781873L,5798587L,43004317L,318935945L,2365343683L,17542244471L,130099628443L,964865884537L,7155794283827L,53069957831125L,393585996554193L,2918976065097931L,21648181955586463L,160550745032206387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232303Inst : IEnumerable<long>
{
public static readonly long[] Value=A232303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232303.Bytes);
public long this[int i]=>Value[i];

public static A232303Inst Instance=new A232303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232368
{
public static readonly long[] Value={ 1L,3L,3L,7L,23L,7L,15L,145L,145L,15L,33L,887L,2411L,887L,33L,73L,5487L,39321L,39321L,5487L,73L,161L,33957L,647287L,1704619L,647287L,33957L,161L,355L,210039L,10652849L,74665511L,74665511L,10652849L,210039L,355L,783L,1299219L,175284259L,3271362341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232368Inst : IEnumerable<long>
{
public static readonly long[] Value=A232368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232368.Bytes);
public long this[int i]=>Value[i];

public static A232368Inst Instance=new A232368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232369
{
public static readonly BigInteger[] Value={ 1L,14L,586L,63744L,27133338L,47301712998L,319646954776850L,8418146420087467712L,BigInteger.Parse("876192348419528567402450") };
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
public class A232369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232369Inst Instance=new A232369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232370
{
public static readonly long[] Value={ 2L,14L,58L,230L,934L,3794L,15354L,62266L,252346L,1022806L,4145638L,16802922L,68105158L,276041834L,1118844570L,4534868126L,18380594246L,74499685134L,301959937342L,1223895154962L,4960655920226L,20106384977054L,81494609451994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232370Inst : IEnumerable<long>
{
public static readonly long[] Value=A232370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232370.Bytes);
public long this[int i]=>Value[i];

public static A232370Inst Instance=new A232370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232371
{
public static readonly long[] Value={ 4L,74L,586L,4550L,36574L,292122L,2324142L,18574882L,148225606L,1182879814L,9441116934L,75346596778L,601334070966L,4799220047514L,38302112010658L,305686073938078L,2439655331781498L,19470682813562030L,155393901867403394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232371Inst : IEnumerable<long>
{
public static readonly long[] Value=A232371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232371.Bytes);
public long this[int i]=>Value[i];

public static A232371Inst Instance=new A232371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232372
{
public static readonly long[] Value={ 8L,296L,4404L,63744L,957232L,14297980L,213082596L,3180405572L,47457708756L,708101568772L,10565916295512L,157657615301852L,2352456485793908L,35101771262909316L,523764821849080236L,7815262731268162904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232372Inst : IEnumerable<long>
{
public static readonly long[] Value=A232372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232372.Bytes);
public long this[int i]=>Value[i];

public static A232372Inst Instance=new A232372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232373
{
public static readonly BigInteger[] Value={ 14L,1130L,32722L,927706L,27133338L,789866870L,22946925502L,667514680522L,19413840326186L,564595278464614L,16420169035941450L,477546295651389890L,13888417395173915122UL,BigInteger.Parse("403915461426343969950"),BigInteger.Parse("11747031027223155160682") };
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
public class A232373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232373Inst Instance=new A232373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232374
{
public static readonly BigInteger[] Value={ 26L,4682L,259458L,14326374L,825606450L,47301712998L,2706080691402L,154987416800398L,8875595994390694L,508249649361525870L,BigInteger.Parse("29105003808620979142"),BigInteger.Parse("1666700158869294743494"),BigInteger.Parse("95443569491003523718078") };
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
public class A232374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232374Inst Instance=new A232374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232375
{
public static readonly BigInteger[] Value={ 48L,19448L,2046700L,219597458L,24945468636L,2824295623804L,319646954776850L,36234058732024820L,4107330198377776652L,BigInteger.Parse("465585399247158982768"),BigInteger.Parse("52778440824390526548132"),BigInteger.Parse("5982947009339446194736266") };
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
public class A232375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232375Inst Instance=new A232375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232376
{
public static readonly long[] Value={ 1L,2L,1L,4L,14L,1L,8L,74L,58L,1L,14L,296L,586L,230L,1L,26L,1130L,4404L,4550L,934L,1L,48L,4682L,32722L,63744L,36574L,3794L,1L,88L,19448L,259458L,927706L,957232L,292122L,15354L,1L,162L,79592L,2046700L,14326374L,27133338L,14297980L,2324142L,62266L,1L,298L,326810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232376Inst : IEnumerable<long>
{
public static readonly long[] Value=A232376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232376.Bytes);
public long this[int i]=>Value[i];

public static A232376Inst Instance=new A232376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232377
{
public static readonly long[] Value={ 1L,14L,74L,296L,1130L,4682L,19448L,79592L,326810L,1343042L,5516132L,22658744L,93073958L,382310690L,1570402928L,6450645104L,26496901994L,108839752922L,447074397188L,1836420218672L,7543351642070L,30985365821066L,127276699845344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232377Inst : IEnumerable<long>
{
public static readonly long[] Value=A232377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232377.Bytes);
public long this[int i]=>Value[i];

public static A232377Inst Instance=new A232377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232378
{
public static readonly long[] Value={ 1L,58L,586L,4404L,32722L,259458L,2046700L,16005328L,125458506L,984034642L,7715900888L,60499523096L,474378832026L,3719632557790L,29165838646828L,228690711059796L,1793174932294258L,14060373065557530L,110248073913792604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232378Inst : IEnumerable<long>
{
public static readonly long[] Value=A232378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232378.Bytes);
public long this[int i]=>Value[i];

public static A232378Inst Instance=new A232378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232379
{
public static readonly ulong[] Value={ 1L,230L,4550L,63744L,927706L,14326374L,219597458L,3342549408L,50948669958L,777136688838L,11852126079904L,180743308881776L,2756349347909628L,42034903671321438L,641040165008121734L,9775973027252581380UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232379Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A232379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232379.Bytes);
public ulong this[int i]=>Value[i];

public static A232379Inst Instance=new A232379Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232380
{
public static readonly BigInteger[] Value={ 1L,934L,36574L,957232L,27133338L,825606450L,24945468636L,747913169216L,22460676406974L,675143834470462L,20291549259837168L,609804313253059260L,18326215546732616794UL,BigInteger.Parse("550758040677362295570"),BigInteger.Parse("16551923665278410826856") };
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
public class A232380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232380Inst Instance=new A232380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232381
{
public static readonly BigInteger[] Value={ 1L,3794L,292122L,14297980L,789866870L,47301712998L,2824295623804L,167360596895808L,9942352809180050L,591329072696504102L,BigInteger.Parse("35169449829022038068"),BigInteger.Parse("2091545018566304198936"),BigInteger.Parse("124389459762131184280364") };
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
public class A232381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232381Inst Instance=new A232381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232382
{
public static readonly BigInteger[] Value={ 1L,15354L,2324142L,213082596L,22946925502L,2706080691402L,319646954776850L,37494469061522404L,4414758747409076838L,BigInteger.Parse("520602557203321831906"),BigInteger.Parse("61403145242482284875036"),BigInteger.Parse("7242121207883084184401892") };
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
public class A232382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232382Inst Instance=new A232382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232383
{
public static readonly long[] Value={ 12L,64L,1192L,28752L,1535188L,148762628L,24233926664L,7435365877376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232383Inst : IEnumerable<long>
{
public static readonly long[] Value=A232383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232383.Bytes);
public long this[int i]=>Value[i];

public static A232383Inst Instance=new A232383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232432
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,11L,21L,34L,59L,114L,178L,284L,522L,823L,1352L,2133L,3739L,5807L,9063L,14074L,23639L,36006L,56914L,87296L,131142L,214933L,324644L,487659L,739291L,1108457L,1724673L,2558386L,3879335L,5772348L,8471344L,12413666L,19109304L,27886339L,40816496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232432Inst : IEnumerable<long>
{
public static readonly long[] Value=A232432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232432.Bytes);
public long this[int i]=>Value[i];

public static A232432Inst Instance=new A232432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232433
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,6L,2L,1L,24L,36L,22L,14L,6L,2L,1L,120L,240L,210L,160L,104L,56L,32L,14L,6L,2L,1L,720L,1800L,2040L,1830L,1448L,992L,674L,408L,232L,128L,68L,32L,14L,6L,2L,1L,5040L,15120L,21000L,21840L,19824L,15834L,12144L,8758L,5904L,3860L,2442L,1482L,870L,492L,260L,142L,68L,32L,14L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232433Inst : IEnumerable<long>
{
public static readonly long[] Value=A232433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232433.Bytes);
public long this[int i]=>Value[i];

public static A232433Inst Instance=new A232433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232434
{
public static readonly long[] Value={ 1L,2L,6L,14L,32L,68L,142L,276L,542L,1022L,1876L,3394L,6066L,10628L,18412L,31344L,52868L,88370L,146180L,239310L,388370L,624688L,997586L,1582640L,2493908L,3902574L,6069194L,9378078L,14411150L,22034860L,33520642L,50747992L,76471200L,114689926L,171242092L,254587046L,376981800L,556129468L,817412048L,1197096472L,1747047580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232434Inst : IEnumerable<long>
{
public static readonly long[] Value=A232434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232434.Bytes);
public long this[int i]=>Value[i];

public static A232434Inst Instance=new A232434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232435
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,7L,0L,1L,13L,2L,0L,1L,24L,5L,2L,0L,1L,46L,11L,4L,2L,0L,1L,89L,21L,11L,4L,2L,0L,1L,170L,45L,23L,11L,4L,2L,0L,1L,324L,99L,47L,23L,12L,4L,2L,0L,1L,618L,209L,102L,52L,23L,13L,4L,2L,0L,1L,1183L,427L,226L,112L,55L,24L,14L,4L,2L,0L,1L,2260L,883L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232435Inst : IEnumerable<long>
{
public static readonly long[] Value=A232435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232435.Bytes);
public long this[int i]=>Value[i];

public static A232435Inst Instance=new A232435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232436
{
public static readonly long[] Value={ 7L,13L,19L,21L,28L,31L,37L,39L,43L,52L,57L,61L,63L,67L,73L,76L,79L,84L,93L,97L,103L,109L,111L,112L,117L,124L,127L,129L,139L,148L,151L,156L,157L,163L,171L,172L,175L,181L,183L,189L,193L,199L,201L,208L,211L,219L,223L,228L,229L,237L,241L,244L,252L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232436Inst : IEnumerable<long>
{
public static readonly long[] Value=A232436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232436.Bytes);
public long this[int i]=>Value[i];

public static A232436Inst Instance=new A232436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232437
{
public static readonly long[] Value={ 7L,13L,14L,19L,21L,26L,28L,31L,35L,37L,38L,39L,42L,43L,52L,56L,57L,61L,62L,63L,65L,67L,70L,73L,74L,76L,77L,78L,79L,84L,86L,93L,95L,97L,103L,104L,105L,109L,111L,112L,114L,117L,119L,122L,124L,126L,127L,129L,130L,134L,139L,140L,143L,146L,148L,151L,152L,154L,155L,156L,157L,158L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232437Inst : IEnumerable<long>
{
public static readonly long[] Value=A232437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232437.Bytes);
public long this[int i]=>Value[i];

public static A232437Inst Instance=new A232437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232438
{
public static readonly long[] Value={ 25L,50L,100L,169L,200L,225L,289L,338L,400L,450L,578L,676L,800L,841L,900L,1156L,1225L,1352L,1369L,1521L,1600L,1681L,1682L,1800L,2025L,2312L,2450L,2601L,2704L,2738L,2809L,3025L,3042L,3200L,3362L,3364L,3600L,3721L,4050L,4624L,4900L,5202L,5329L,5408L,5476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232438Inst : IEnumerable<long>
{
public static readonly long[] Value=A232438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232438.Bytes);
public long this[int i]=>Value[i];

public static A232438Inst Instance=new A232438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232439
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,2L,3L,4L,4L,4L,3L,2L,1L,1L,1L,1L,2L,4L,5L,7L,9L,9L,9L,9L,7L,5L,4L,2L,1L,1L,1L,1L,2L,4L,6L,9L,13L,16L,19L,22L,23L,23L,22L,19L,16L,13L,9L,6L,4L,2L,1L,1L,1L,1L,2L,4L,7L,10L,16L,22L,30L,37L,46L,52L,60L,62L,64L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232439Inst : IEnumerable<long>
{
public static readonly long[] Value=A232439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232439.Bytes);
public long this[int i]=>Value[i];

public static A232439Inst Instance=new A232439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232440
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,1L,3L,1L,3L,1L,1L,4L,2L,1L,4L,4L,1L,5L,6L,1L,5L,9L,1L,6L,12L,1L,1L,6L,16L,2L,1L,7L,20L,6L,1L,7L,25L,10L,1L,8L,30L,19L,1L,8L,36L,28L,1L,1L,9L,42L,44L,3L,1L,9L,49L,60L,9L,1L,10L,56L,85L,19L,1L,10L,64L,110L,38L,1L,11L,72L,146L,66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232440Inst : IEnumerable<long>
{
public static readonly long[] Value=A232440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232440.Bytes);
public long this[int i]=>Value[i];

public static A232440Inst Instance=new A232440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232441
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,3L,4L,1L,3L,4L,7L,8L,1L,3L,5L,10L,18L,16L,1L,4L,6L,13L,28L,47L,32L,1L,4L,7L,16L,38L,82L,123L,64L,1L,5L,8L,19L,48L,117L,244L,322L,128L,1L,5L,9L,22L,58L,152L,370L,730L,843L,256L,1L,6L,10L,25L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232441Inst : IEnumerable<long>
{
public static readonly long[] Value=A232441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232441.Bytes);
public long this[int i]=>Value[i];

public static A232441Inst Instance=new A232441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232442
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,2L,1L,1L,0L,0L,1L,1L,6L,1L,2L,2L,0L,0L,1L,2L,3L,0L,1L,2L,0L,1L,2L,4L,1L,1L,0L,1L,2L,2L,2L,4L,0L,0L,1L,2L,0L,3L,3L,3L,2L,0L,1L,1L,2L,1L,2L,0L,1L,1L,14L,3L,2L,2L,2L,2L,3L,4L,5L,3L,2L,3L,1L,3L,3L,4L,6L,3L,0L,5L,3L,1L,0L,5L,2L,0L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232442Inst : IEnumerable<long>
{
public static readonly long[] Value=A232442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232442.Bytes);
public long this[int i]=>Value[i];

public static A232442Inst Instance=new A232442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232443
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,1L,2L,2L,2L,1L,2L,3L,4L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,2L,2L,5L,4L,5L,5L,3L,3L,4L,4L,4L,5L,4L,2L,6L,5L,5L,5L,3L,4L,8L,5L,5L,6L,2L,4L,7L,6L,6L,5L,3L,5L,7L,6L,7L,6L,4L,6L,6L,5L,7L,5L,6L,6L,7L,7L,7L,6L,4L,5L,7L,8L,8L,7L,7L,7L,7L,8L,9L,5L,6L,9L,9L,7L,6L,7L,6L,7L,8L,3L,8L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232443Inst : IEnumerable<long>
{
public static readonly long[] Value=A232443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232443.Bytes);
public long this[int i]=>Value[i];

public static A232443Inst Instance=new A232443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232444
{
public static readonly long[] Value={ 2L,4L,64L,289L,729L,15625L,7091569L,7778521L,11607649L,15912121L,43546801L,56957209L,138980521L,143688169L,171845881L,210801361L,211673401L,253541929L,256224049L,275792449L,308810329L,329386201L,357172201L,408807961L,499477801L,531625249L,769341169L,1073741824L,1260747049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232444Inst : IEnumerable<long>
{
public static readonly long[] Value=A232444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232444.Bytes);
public long this[int i]=>Value[i];

public static A232444Inst Instance=new A232444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232445
{
public static readonly long[] Value={ 1L,11177320L,182937066L,159839399818L,166474679436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232445Inst : IEnumerable<long>
{
public static readonly long[] Value=A232445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232445.Bytes);
public long this[int i]=>Value[i];

public static A232445Inst Instance=new A232445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232446
{
public static readonly long[] Value={ 7L,151L,787L,1549L,1579L,2029L,2083L,2179L,2833L,2971L,4549L,4591L,4801L,4999L,5077L,5167L,5179L,5209L,5227L,5407L,6343L,6529L,6547L,6553L,6577L,6679L,7027L,7753L,7867L,7873L,7927L,7963L,7993L,8167L,8191L,8311L,9091L,9103L,9151L,9283L,14251L,14281L,14389L,14437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232446Inst : IEnumerable<long>
{
public static readonly long[] Value=A232446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232446.Bytes);
public long this[int i]=>Value[i];

public static A232446Inst Instance=new A232446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232447
{
public static readonly long[] Value={ 13597L,13759L,15739L,15937L,15973L,17359L,17539L,19753L,31957L,37159L,37591L,37951L,39157L,51973L,53197L,53719L,53791L,53917L,57139L,57193L,71359L,71593L,73951L,75193L,75391L,75913L,75931L,79153L,79531L,91573L,91753L,95317L,95713L,95731L,105379L,105397L,109357L,109537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232447Inst : IEnumerable<long>
{
public static readonly long[] Value=A232447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232447.Bytes);
public long this[int i]=>Value[i];

public static A232447Inst Instance=new A232447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232496
{
public static readonly long[] Value={ 4L,13L,13L,40L,122L,40L,121L,1042L,1042L,121L,364L,8683L,23544L,8683L,364L,1093L,72271L,510835L,510835L,72271L,1093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232496Inst : IEnumerable<long>
{
public static readonly long[] Value=A232496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232496.Bytes);
public long this[int i]=>Value[i];

public static A232496Inst Instance=new A232496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232497
{
public static readonly long[] Value={ 1L,0L,2L,6L,14L,32L,102L,238L,652L,1696L,4480L,11658L,30870L,80644L,212292L,556858L,1463390L,3840686L,10090218L,26490280L,69575414L,182693434L,479789138L,1259906496L,3308668718L,8688615148L,22817011182L,59918425698L,157349755400L,413208421354L,1085110433096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232497Inst : IEnumerable<long>
{
public static readonly long[] Value=A232497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232497.Bytes);
public long this[int i]=>Value[i];

public static A232497Inst Instance=new A232497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232498
{
public static readonly BigInteger[] Value={ 2L,3L,19L,4567L,52267L,325219L,BigInteger.Parse("2967036956187340614662532876709507060271690954641131383") };
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
public class A232498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232498Inst Instance=new A232498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232499
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,11L,13L,15L,17L,19L,20L,22L,24L,26L,28L,30L,33L,35L,37L,39L,41L,45L,47L,48L,50L,52L,54L,56L,60L,62L,64L,66L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,89L,90L,94L,96L,98L,102L,104L,106L,108L,110L,112L,114L,115L,117L,119L,123L,125L,127L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232499Inst : IEnumerable<long>
{
public static readonly long[] Value=A232499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232499.Bytes);
public long this[int i]=>Value[i];

public static A232499Inst Instance=new A232499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232500
{
public static readonly long[] Value={ -1L,-1L,0L,0L,2L,10L,10L,70L,42L,378L,168L,1848L,660L,8580L,2574L,38610L,10010L,170170L,38896L,739024L,151164L,3174444L,587860L,13520780L,2288132L,57203300L,8914800L,240699600L,34767720L,1008263880L,135727830L,4207562730L,530365050L,17502046650L,2074316640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232500Inst : IEnumerable<long>
{
public static readonly long[] Value=A232500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232500.Bytes);
public long this[int i]=>Value[i];

public static A232500Inst Instance=new A232500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232501
{
public static readonly long[] Value={ 1L,10L,15L,19L,26L,197L,253L,325L,631L,1090L,1522L,2395L,3601L,4434L,4625L,6571L,9026L,11026L,11116L,14631L,15454L,19045L,22501L,35722L,38431L,41210L,53036L,61505L,65521L,66239L,69697L,69949L,70291L,85384L,99226L,110890L,152101L,152803L,160021L,168101L,181801L,189631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232501Inst : IEnumerable<long>
{
public static readonly long[] Value=A232501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232501.Bytes);
public long this[int i]=>Value[i];

public static A232501Inst Instance=new A232501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232502
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,1L,2L,1L,3L,2L,1L,2L,3L,1L,5L,2L,3L,1L,4L,5L,3L,4L,2L,3L,2L,3L,5L,5L,3L,7L,1L,5L,4L,8L,3L,4L,5L,6L,5L,1L,6L,4L,9L,3L,8L,4L,6L,3L,10L,5L,8L,4L,8L,3L,9L,6L,4L,4L,4L,10L,6L,10L,4L,11L,5L,11L,6L,9L,5L,10L,9L,8L,6L,9L,7L,9L,11L,9L,11L,5L,10L,9L,12L,6L,6L,10L,9L,8L,13L,4L,12L,10L,12L,8L,7L,12L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232502Inst : IEnumerable<long>
{
public static readonly long[] Value=A232502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232502.Bytes);
public long this[int i]=>Value[i];

public static A232502Inst Instance=new A232502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232503
{
public static readonly long[] Value={ 1L,2L,16L,4L,16L,16L,16L,8L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,64L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,32L,16L,16L,16L,16L,16L,16L,16L,16L,16L,64L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,64L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232503Inst : IEnumerable<long>
{
public static readonly long[] Value=A232503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232503.Bytes);
public long this[int i]=>Value[i];

public static A232503Inst Instance=new A232503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232504
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,1L,4L,1L,5L,4L,5L,4L,4L,3L,5L,5L,6L,2L,4L,8L,4L,3L,6L,5L,3L,5L,5L,8L,5L,6L,4L,7L,5L,5L,2L,6L,9L,8L,3L,10L,7L,9L,7L,4L,7L,8L,8L,5L,6L,8L,5L,4L,8L,5L,5L,7L,11L,7L,7L,9L,8L,7L,9L,11L,8L,10L,4L,7L,8L,7L,9L,13L,7L,8L,4L,6L,11L,8L,13L,3L,8L,10L,5L,7L,11L,11L,6L,9L,6L,5L,10L,6L,9L,5L,10L,11L,9L,8L,11L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232504Inst : IEnumerable<long>
{
public static readonly long[] Value=A232504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232504.Bytes);
public long this[int i]=>Value[i];

public static A232504Inst Instance=new A232504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232505
{
public static readonly long[] Value={ 1L,1L,1L,1L,18L,13L,38L,50L,26L,83L,66L,137L,224L,242L,147L,303L,509L,395L,578L,364L,714L,563L,965L,1046L,1254L,1155L,1043L,1565L,1323L,1676L,1667L,2440L,2456L,2589L,2563L,2284L,2827L,3362L,2526L,3503L,4408L,3765L,3271L,4902L,4557L,4005L,5829L,5380L,6952L,6093L,7046L,5288L,7626L,8691L,8552L,6871L,8563L,7622L,9007L,10250L,10365L,10233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232505Inst : IEnumerable<long>
{
public static readonly long[] Value=A232505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232505.Bytes);
public long this[int i]=>Value[i];

public static A232505Inst Instance=new A232505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232506
{
public static readonly long[] Value={ 1L,-2L,-1L,2L,1L,2L,-2L,0L,-2L,-2L,1L,0L,0L,2L,3L,-2L,2L,0L,0L,-2L,-2L,0L,0L,-4L,3L,2L,-2L,0L,-6L,6L,1L,6L,4L,0L,-2L,-2L,-2L,-6L,2L,-4L,-4L,0L,4L,4L,1L,-2L,3L,4L,3L,-6L,-3L,4L,-1L,-4L,-2L,4L,-3L,4L,4L,-8L,-3L,4L,-2L,6L,2L,2L,-2L,-2L,4L,2L,-4L,-4L,2L,-2L,2L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232506Inst : IEnumerable<long>
{
public static readonly long[] Value=A232506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232506.Bytes);
public long this[int i]=>Value[i];

public static A232506Inst Instance=new A232506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232507
{
public static readonly BigInteger[] Value={ 4L,52L,128L,19138L,64290L,105188684L,476578496L,8457919671084L,50905137040126L,9932347839826344524UL,BigInteger.Parse("79686710905619007242"),BigInteger.Parse("170326243514575075459988044"),BigInteger.Parse("1825631340786716600141970578"),BigInteger.Parse("42650500910965333565149003898471568") };
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
public class A232507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232507Inst Instance=new A232507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232508
{
public static readonly long[] Value={ 4L,4L,8L,16L,28L,52L,96L,176L,324L,596L,1096L,2016L,3708L,6820L,12544L,23072L,42436L,78052L,143560L,264048L,485660L,893268L,1642976L,3021904L,5558148L,10223028L,18803080L,34584256L,63610364L,116997700L,215192320L,395800384L,727990404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232508Inst : IEnumerable<long>
{
public static readonly long[] Value=A232508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232508.Bytes);
public long this[int i]=>Value[i];

public static A232508Inst Instance=new A232508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232509
{
public static readonly long[] Value={ 16L,52L,200L,784L,3052L,11900L,46432L,181184L,707044L,2759212L,10767816L,42021520L,163989692L,639972924L,2497507216L,9746573088L,38036202612L,148437067820L,579278732344L,2260647259184L,8822222791628L,34428907339516L,134359524664384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232509Inst : IEnumerable<long>
{
public static readonly long[] Value=A232509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232509.Bytes);
public long this[int i]=>Value[i];

public static A232509Inst Instance=new A232509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232510
{
public static readonly long[] Value={ 16L,32L,128L,400L,1344L,4416L,14608L,48224L,159296L,526096L,1737600L,5738880L,18954256L,62601632L,206759168L,682879120L,2255396544L,7449068736L,24602602768L,81256877024L,268373233856L,886376578576L,2927502969600L,9668885487360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232510Inst : IEnumerable<long>
{
public static readonly long[] Value=A232510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232510.Bytes);
public long this[int i]=>Value[i];

public static A232510Inst Instance=new A232510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232511
{
public static readonly long[] Value={ 54L,326L,2516L,19138L,145682L,1110752L,8470018L,64594290L,492627324L,3757052022L,28653492802L,218528696816L,1666631440922L,12710736921242L,96939753662116L,739321100203858L,5638509196177426L,43002676390969828L,327964380966543498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232511Inst : IEnumerable<long>
{
public static readonly long[] Value=A232511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232511.Bytes);
public long this[int i]=>Value[i];

public static A232511Inst Instance=new A232511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232544
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232544Inst : IEnumerable<long>
{
public static readonly long[] Value=A232544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232544.Bytes);
public long this[int i]=>Value[i];

public static A232544Inst Instance=new A232544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232545
{
public static readonly long[] Value={ 1L,3L,256L,972000L,247669456896L,6022251970560000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232545Inst : IEnumerable<long>
{
public static readonly long[] Value=A232545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232545.Bytes);
public long this[int i]=>Value[i];

public static A232545Inst Instance=new A232545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232546
{
public static readonly BigInteger[] Value={ 1L,-18L,54L,108L,486L,2916L,20412L,157464L,1299078L,11258676L,101328084L,939587688L,8926083036L,86514343272L,852784240824L,8527842408240L,86344404383430L,883760374277460L,9132190534200420L,95167038198509640L,999253901084351220L,10563541240034570040UL };
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
public class A232546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232546Inst Instance=new A232546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232547
{
public static readonly long[] Value={ 7581L,988893L,1658073L,468539757L,35124206517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232547Inst : IEnumerable<long>
{
public static readonly long[] Value=A232547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232547.Bytes);
public long this[int i]=>Value[i];

public static A232547Inst Instance=new A232547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232548
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,3L,2L,3L,4L,4L,3L,3L,4L,4L,3L,3L,5L,4L,2L,3L,4L,4L,3L,3L,4L,6L,4L,5L,6L,4L,4L,5L,4L,6L,4L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,3L,4L,5L,5L,6L,4L,4L,5L,4L,5L,6L,7L,7L,4L,5L,5L,6L,4L,7L,6L,6L,6L,4L,6L,4L,7L,8L,7L,6L,6L,6L,6L,5L,4L,9L,7L,5L,4L,4L,7L,6L,3L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232548Inst : IEnumerable<long>
{
public static readonly long[] Value=A232548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232548.Bytes);
public long this[int i]=>Value[i];

public static A232548Inst Instance=new A232548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232549
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,69L,780L,12015L,240254L,6022121L,184115728L,6718994385L,287695076790L,14253791802085L,807709767584928L,51832973461142601L,3734821283563097350L,BigInteger.Parse("299928689437970776785"),BigInteger.Parse("26669987585007924913536"),BigInteger.Parse("2610872906937221730434977"),BigInteger.Parse("279949862628226582759321542"),BigInteger.Parse("32727135115533487802060517885") };
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
public class A232549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232549Inst Instance=new A232549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232550
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,3L,1L,2L,2L,1L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,5L,1L,2L,3L,2L,2L,2L,2L,2L,3L,2L,1L,4L,1L,2L,3L,2L,2L,2L,1L,3L,2L,2L,2L,5L,2L,1L,3L,2L,1L,4L,2L,2L,2L,1L,3L,3L,2L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232550Inst : IEnumerable<long>
{
public static readonly long[] Value=A232550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232550.Bytes);
public long this[int i]=>Value[i];

public static A232550Inst Instance=new A232550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232551
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,4L,2L,2L,4L,2L,4L,2L,2L,4L,4L,2L,3L,4L,3L,4L,3L,2L,4L,3L,4L,5L,4L,2L,4L,4L,3L,3L,4L,3L,4L,4L,3L,4L,4L,3L,6L,4L,2L,5L,4L,4L,5L,3L,3L,6L,6L,2L,5L,6L,4L,4L,4L,3L,6L,4L,4L,6L,4L,3L,6L,4L,3L,5L,6L,4L,6L,4L,4L,7L,6L,4L,4L,4L,5L,5L,6L,3L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232551Inst : IEnumerable<long>
{
public static readonly long[] Value=A232551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232551.Bytes);
public long this[int i]=>Value[i];

public static A232551Inst Instance=new A232551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232552
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,64L,630L,8030L,126247L,2371612L,52026293L,1309661828L,37318672196L,1190672836246L,42159850045181L,1644546319080848L,70233352188006641L,3266637689293293616L,BigInteger.Parse("164720219739258021686"),BigInteger.Parse("8969422973088951968070"),BigInteger.Parse("525585300443124229026511"),BigInteger.Parse("33039986976855724686082476") };
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
public class A232552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232552Inst Instance=new A232552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232553
{
public static readonly long[] Value={ 6L,9L,13L,36L,54L,81L,216L,324L,486L,1296L,1944L,2916L,7776L,11664L,17496L,46656L,69984L,104976L,279936L,419904L,629856L,1679616L,2519424L,3779136L,10077696L,15116544L,22674816L,60466176L,90699264L,136048896L,362797056L,544195584L,816293376L,2176782336L,3265173504L,4897760256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232553Inst : IEnumerable<long>
{
public static readonly long[] Value=A232553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232553.Bytes);
public long this[int i]=>Value[i];

public static A232553Inst Instance=new A232553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232554
{
public static readonly long[] Value={ 1L,1764L,60516L,82369L,529984L,2056356L,2798929L,3534400L,18181696L,38900169L,96020401L,97121025L,335988900L,455907904L,457318225L,617820736L,1334513961L,1599200100L,2176689025L,3279852900L,4464244225L,8586616896L,15688815025L,24514164900L,33366502225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232554Inst : IEnumerable<long>
{
public static readonly long[] Value=A232554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232554.Bytes);
public long this[int i]=>Value[i];

public static A232554Inst Instance=new A232554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232555
{
public static readonly long[] Value={ 3528L,5292L,8820L,10584L,12348L,17640L,19404L,22932L,24696L,26460L,29988L,33516L,37044L,38808L,40572L,45864L,51156L,52920L,54684L,58212L,59976L,61740L,65268L,67032L,68796L,72324L,74088L,75852L,81144L,82908L,89964L,93492L,97020L,100548L,102312L,104076L,107604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232555Inst : IEnumerable<long>
{
public static readonly long[] Value=A232555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232555.Bytes);
public long this[int i]=>Value[i];

public static A232555Inst Instance=new A232555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232556
{
public static readonly long[] Value={ 900L,3528L,4900L,5292L,8820L,10404L,10584L,12348L,17640L,19404L,22932L,24696L,26460L,29988L,33516L,37044L,38808L,40572L,45864L,51156L,52920L,54684L,58212L,59976L,61740L,65268L,67032L,68796L,72324L,74088L,75852L,79524L,81144L,81796L,82908L,89964L,93492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232556Inst : IEnumerable<long>
{
public static readonly long[] Value=A232556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232556.Bytes);
public long this[int i]=>Value[i];

public static A232556Inst Instance=new A232556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232557
{
public static readonly long[] Value={ 900L,4900L,10404L,79524L,81796L,417316L,532900L,846400L,1542564L,2464900L,3232804L,3334276L,3496900L,12432676L,43850884L,50836900L,51811204L,71470116L,107453956L,236975236L,253892356L,432889636L,544102276L,864948100L,1192597156L,1450543396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232557Inst : IEnumerable<long>
{
public static readonly long[] Value=A232557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232557.Bytes);
public long this[int i]=>Value[i];

public static A232557Inst Instance=new A232557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232558
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,31L,47L,59L,61L,83L,97L,109L,131L,137L,139L,173L,193L,211L,233L,239L,241L,257L,271L,277L,281L,283L,307L,389L,397L,409L,431L,433L,457L,467L,491L,523L,563L,569L,571L,653L,661L,673L,701L,709L,733L,821L,823L,859L,887L,911L,967L,983L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232558Inst : IEnumerable<long>
{
public static readonly long[] Value=A232558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232558.Bytes);
public long this[int i]=>Value[i];

public static A232558Inst Instance=new A232558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232559
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,8L,7L,12L,10L,9L,16L,14L,13L,24L,11L,20L,18L,17L,32L,15L,28L,26L,25L,48L,22L,21L,40L,19L,36L,34L,33L,64L,30L,29L,56L,27L,52L,50L,49L,96L,23L,44L,42L,41L,80L,38L,37L,72L,35L,68L,66L,65L,128L,31L,60L,58L,57L,112L,54L,53L,104L,51L,100L,98L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232559Inst : IEnumerable<long>
{
public static readonly long[] Value=A232559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232559.Bytes);
public long this[int i]=>Value[i];

public static A232559Inst Instance=new A232559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232576
{
public static readonly BigInteger[] Value={ 18944L,4252876L,1481426938L,497042884074L,164594058779448L,55003296878624386L,18327756561362881814UL,BigInteger.Parse("6110458911406869788438"),BigInteger.Parse("2037216128067372778661334"),BigInteger.Parse("679162377779498001275419430"),BigInteger.Parse("226425284263301453440825435238") };
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
public class A232576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232576Inst Instance=new A232576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232577
{
public static readonly BigInteger[] Value={ 115892L,67979266L,65570285646L,60461419039912L,55003296878624386L,BigInteger.Parse("50532651470537361772"),BigInteger.Parse("46278886456613682856386"),BigInteger.Parse("42408950854673793812571570"),BigInteger.Parse("38862452306601885549176579162"),BigInteger.Parse("35610280769061697377460193039044") };
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
public class A232577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232577Inst Instance=new A232577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232578
{
public static readonly BigInteger[] Value={ 713488L,1090643352L,2886850804200L,7337689178112392L,18327756561362881814UL,BigInteger.Parse("46278886456613682856386"),BigInteger.Parse("116497839389906889442230276"),BigInteger.Parse("293382075796380506972162629078"),BigInteger.Parse("738899273693426798595707423879670") };
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
public class A232578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232578Inst Instance=new A232578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232579
{
public static readonly long[] Value={ 16L,72L,72L,516L,1064L,516L,3048L,16316L,16316L,3048L,18944L,265670L,767942L,265670L,18944L,115892L,4252876L,33815878L,33815878L,4252876L,115892L,713488L,67979266L,1481426938L,4107586864L,1481426938L,67979266L,713488L,4389504L,1090643352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232579Inst : IEnumerable<long>
{
public static readonly long[] Value=A232579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232579.Bytes);
public long this[int i]=>Value[i];

public static A232579Inst Instance=new A232579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232580
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,12L,31L,74L,168L,369L,792L,1672L,3487L,7206L,14788L,30185L,61356L,124308L,251199L,506578L,1019920L,2050785L,4119280L,8267216L,16580799L,33236622L,66594636L,133385689L,267089188L,534692604L,1070217247L,2141780762L,4285739832L,8575004241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232580Inst : IEnumerable<long>
{
public static readonly long[] Value=A232580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232580.Bytes);
public long this[int i]=>Value[i];

public static A232580Inst Instance=new A232580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232581
{
public static readonly BigInteger[] Value={ 0L,34L,42L,6406L,14398L,12486510L,41969054L,255585490674L,1079163298316L,54986925928451542L,282118997571150630L,BigInteger.Parse("124284077001521518573820"),BigInteger.Parse("748107850423156991103192"),BigInteger.Parse("2951299844035743073442451486916") };
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
public class A232581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232581Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232581.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232581Inst Instance=new A232581Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232582
{
public static readonly long[] Value={ 0L,2L,4L,6L,10L,18L,32L,56L,98L,172L,302L,530L,930L,1632L,2864L,5026L,8820L,15478L,27162L,47666L,83648L,146792L,257602L,452060L,793310L,1392162L,2443074L,4287296L,7523680L,13203138L,23169892L,40660326L,71353898L,125217362L,219741152L,385618840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232582Inst : IEnumerable<long>
{
public static readonly long[] Value=A232582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232582.Bytes);
public long this[int i]=>Value[i];

public static A232582Inst Instance=new A232582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232583
{
public static readonly long[] Value={ 10L,34L,124L,456L,1686L,6232L,23034L,85130L,314626L,1162804L,4297528L,15882942L,58700688L,216947890L,801802986L,2963329250L,10951967500L,40476633544L,149594843398L,552877431048L,2043342182250L,7551849721642L,27910368960066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232583Inst : IEnumerable<long>
{
public static readonly long[] Value=A232583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232583.Bytes);
public long this[int i]=>Value[i];

public static A232583Inst Instance=new A232583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232584
{
public static readonly long[] Value={ 2L,12L,42L,122L,332L,882L,2322L,6092L,15962L,41802L,109452L,286562L,750242L,1964172L,5142282L,13462682L,35245772L,92274642L,241578162L,632459852L,1655801402L,4334944362L,11349031692L,29712150722L,77787420482L,203650110732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232584Inst : IEnumerable<long>
{
public static readonly long[] Value=A232584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232584.Bytes);
public long this[int i]=>Value[i];

public static A232584Inst Instance=new A232584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232585
{
public static readonly long[] Value={ 26L,152L,996L,6406L,41328L,266490L,1718514L,11082034L,71463916L,460844060L,2971811106L,19164098964L,123582110878L,796934839170L,5139134890906L,33140359949992L,213709793755260L,1378134577168966L,8887074754111400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232585Inst : IEnumerable<long>
{
public static readonly long[] Value=A232585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232585.Bytes);
public long this[int i]=>Value[i];

public static A232585Inst Instance=new A232585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232586
{
public static readonly long[] Value={ 20L,108L,606L,3002L,14398L,66950L,306022L,1382638L,6200520L,27671244L,123093664L,546418140L,2422183000L,10727201704L,47478696368L,210055317910L,929074602120L,4108554199540L,18166666165648L,80320554722730L,355103563888676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232586Inst : IEnumerable<long>
{
public static readonly long[] Value=A232586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232586.Bytes);
public long this[int i]=>Value[i];

public static A232586Inst Instance=new A232586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232587
{
public static readonly long[] Value={ 70L,690L,8104L,93236L,1079300L,12486510L,144506106L,1672314806L,19353375198L,223972627480L,2591990800908L,29996594823464L,347144643738454L,4017436125487796L,46492991691492538L,538054174106467882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232587Inst : IEnumerable<long>
{
public static readonly long[] Value=A232587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232587.Bytes);
public long this[int i]=>Value[i];

public static A232587Inst Instance=new A232587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232588
{
public static readonly long[] Value={ 90L,744L,7568L,68072L,595304L,5045772L,41969054L,344123498L,2791211292L,22459482618L,179631450494L,1430206865644L,11348368440492L,89814921458080L,709441275635178L,5595533382083776L,44083691591740368L,347010348931531478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232588Inst : IEnumerable<long>
{
public static readonly long[] Value=A232588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232588.Bytes);
public long this[int i]=>Value[i];

public static A232588Inst Instance=new A232588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232589
{
public static readonly long[] Value={ 0L,10L,2L,2L,34L,4L,26L,12L,124L,6L,20L,152L,42L,456L,10L,70L,108L,996L,122L,1686L,18L,90L,690L,606L,6406L,332L,6232L,32L,210L,744L,8104L,3002L,41328L,882L,23034L,56L,336L,3232L,7568L,93236L,14398L,266490L,2322L,85130L,98L,674L,4516L,66744L,68072L,1079300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232589Inst : IEnumerable<long>
{
public static readonly long[] Value=A232589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232589.Bytes);
public long this[int i]=>Value[i];

public static A232589Inst Instance=new A232589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232590
{
public static readonly long[] Value={ 0L,10L,2L,26L,20L,70L,90L,210L,336L,674L,1178L,2234L,4036L,7502L,13714L,25314L,46464L,85562L,157266L,289370L,532116L,978838L,1800234L,3311282L,6090256L,11201874L,20603306L,37895546L,69700612L,128199582L,235795618L,433695938L,797691008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232590Inst : IEnumerable<long>
{
public static readonly long[] Value=A232590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232590.Bytes);
public long this[int i]=>Value[i];

public static A232590Inst Instance=new A232590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232591
{
public static readonly long[] Value={ 2L,34L,12L,152L,108L,690L,744L,3232L,4516L,15592L,25724L,76914L,141516L,385622L,762648L,1955944L,4058152L,10001440L,21421592L,51425362L,112496648L,265415854L,588810972L,1373336224L,3075128652L,7118096080L,16037159652L,36935382354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232591Inst : IEnumerable<long>
{
public static readonly long[] Value=A232591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232591.Bytes);
public long this[int i]=>Value[i];

public static A232591Inst Instance=new A232591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232624
{
public static readonly long[] Value={ -2L,1L,2L,1L,1L,1L,0L,1L,-1L,1L,1L,-1L,1L,-1L,-2L,1L,1L,-2L,0L,1L,1L,-3L,0L,1L,-1L,-1L,1L,1L,3L,-3L,-4L,1L,1L,-3L,0L,1L,-1L,3L,6L,-4L,-5L,1L,1L,1L,-2L,-1L,1L,1L,4L,-4L,-1L,1L,2L,0L,-4L,0L,1L,1L,-4L,-10L,10L,15L,-6L,-7L,1L,1L,-1L,-3L,0L,1L,1L,5L,-10L,-20L,15L,21L,-7L,-8L,1L,1L,5L,0L,-5L,0L,1L,1L,-8L,8L,6L,-6L,-1L,1L,-1L,3L,3L,-4L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232624Inst : IEnumerable<long>
{
public static readonly long[] Value=A232624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232624.Bytes);
public long this[int i]=>Value[i];

public static A232624Inst Instance=new A232624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232625
{
public static readonly long[] Value={ 2L,2L,6L,2L,10L,6L,14L,1L,18L,10L,22L,6L,26L,14L,30L,4L,34L,18L,38L,10L,42L,22L,46L,3L,50L,26L,54L,14L,58L,30L,62L,8L,66L,34L,70L,18L,74L,38L,78L,5L,82L,42L,86L,22L,90L,46L,94L,12L,98L,50L,102L,26L,106L,54L,110L,7L,114L,58L,118L,30L,122L,62L,126L,16L,130L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232625Inst : IEnumerable<long>
{
public static readonly long[] Value=A232625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232625.Bytes);
public long this[int i]=>Value[i];

public static A232625Inst Instance=new A232625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232626
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,1L,6L,4L,10L,2L,12L,6L,8L,2L,16L,6L,18L,4L,12L,10L,22L,1L,20L,12L,18L,6L,28L,8L,30L,4L,20L,16L,24L,6L,36L,18L,24L,2L,40L,12L,42L,10L,24L,22L,46L,4L,42L,20L,32L,12L,52L,18L,40L,3L,36L,28L,58L,8L,60L,30L,36L,8L,48L,20L,66L,16L,44L,24L,70L,3L,72L,36L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232626Inst : IEnumerable<long>
{
public static readonly long[] Value=A232626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232626.Bytes);
public long this[int i]=>Value[i];

public static A232626Inst Instance=new A232626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232627
{
public static readonly BigInteger[] Value={ 1L,1L,12L,1L,2000L,12L,1075648L,8L,1259712L,2000L,2414538435584L,1L,7340688973975552L,1075648L,324000000L,2048L,BigInteger.Parse("187591757103747287810048"),1259712L,BigInteger.Parse("1436650532447139184230793216"),5L,843466573910016L,2414538435584L };
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
public class A232627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232627Inst Instance=new A232627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232628
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232628Inst : IEnumerable<long>
{
public static readonly long[] Value=A232628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232628.Bytes);
public long this[int i]=>Value[i];

public static A232628Inst Instance=new A232628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232629
{
public static readonly long[] Value={ 0L,0L,0L,-1L,0L,0L,-3L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-3L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,5L,0L,-5L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-3L,0L,1L,0L,0L,0L,-7L,0L,14L,0L,-7L,0L,1L,0L,1L,0L,9L,0L,-30L,0L,27L,0L,-9L,0L,1L,0L,0L,0L,0L,0L,0L,0L,5L,0L,-5L,0L,1L,0L,-11L,0L,55L,0L,-77L,0L,44L,0L,-11L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232629Inst : IEnumerable<long>
{
public static readonly long[] Value=A232629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232629.Bytes);
public long this[int i]=>Value[i];

public static A232629Inst Instance=new A232629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232630
{
public static readonly long[] Value={ 0L,1L,0L,1L,-3L,0L,1L,0L,1L,5L,0L,-5L,0L,1L,-3L,0L,1L,-7L,0L,14L,0L,-7L,0L,1L,-2L,1L,-3L,0L,9L,0L,-6L,0L,1L,5L,0L,-5L,0L,1L,-11L,0L,55L,0L,-77L,0L,44L,0L,-11L,0L,1L,-3L,0L,1L,13L,0L,-91L,0L,182L,0L,-156L,0L,65L,0L,-13L,0L,1L,-7L,0L,14L,0L,-7L,0L,1L,1L,0L,-8L,0L,14L,0L,-7L,0L,1L,-2L,0L,1L,17L,0L,-204L,0L,714L,0L,-1122L,0L,935L,0L,-442L,0L,119L,0L,-17L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232630Inst : IEnumerable<long>
{
public static readonly long[] Value=A232630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232630.Bytes);
public long this[int i]=>Value[i];

public static A232630Inst Instance=new A232630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232631
{
public static readonly long[] Value={ -4L,1L,-2L,1L,-1L,1L,2L,-4L,1L,1L,-3L,1L,1L,-4L,1L,-1L,6L,-5L,1L,2L,-16L,20L,-8L,1L,-1L,9L,-6L,1L,1L,-12L,19L,-8L,1L,-1L,15L,-35L,28L,-9L,1L,1L,-16L,20L,-8L,1L,1L,-21L,70L,-84L,45L,-11L,1L,1L,-24L,86L,-104L,53L,-12L,1L,1L,-24L,26L,-9L,1L,2L,-64L,336L,-672L,660L,-352L,104L,-16L,1L,1L,-36L,210L,-462L,495L,-286L,91L,-15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232631Inst : IEnumerable<long>
{
public static readonly long[] Value=A232631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232631.Bytes);
public long this[int i]=>Value[i];

public static A232631Inst Instance=new A232631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232632
{
public static readonly long[] Value={ 0L,1L,-3L,1L,5L,-5L,1L,-7L,14L,-7L,1L,-3L,9L,-6L,1L,-11L,55L,-77L,44L,-11L,1L,13L,-91L,182L,-156L,65L,-13L,1L,1L,-8L,14L,-7L,1L,17L,-204L,714L,-1122L,935L,-442L,119L,-17L,1L,-19L,285L,-1254L,2508L,-2717L,1729L,-665L,152L,-19L,1L,1L,-16L,60L,-78L,44L,-11L,1L,-23L,506L,-3289L,9867L,-16445L,16744L,-10948L,4692L,-1311L,230L,-23L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232632Inst : IEnumerable<long>
{
public static readonly long[] Value=A232632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232632.Bytes);
public long this[int i]=>Value[i];

public static A232632Inst Instance=new A232632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232633
{
public static readonly long[] Value={ 0L,1L,-4L,1L,-3L,1L,-2L,1L,5L,-5L,1L,-1L,1L,-7L,14L,-7L,1L,2L,-4L,1L,-3L,9L,-6L,1L,1L,-3L,1L,-11L,55L,-77L,44L,-11L,1L,1L,-4L,1L,13L,-91L,182L,-156L,65L,-13L,1L,-1L,6L,-5L,1L,1L,-8L,14L,-7L,1L,2L,-16L,20L,-8L,1L,17L,-204L,714L,-1122L,935L,-442L,119L,-17L,1L,-1L,9L,-6L,1L,-19L,285L,-1254L,2508L,-2717L,1729L,-665L,152L,-19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232633Inst : IEnumerable<long>
{
public static readonly long[] Value=A232633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232633.Bytes);
public long this[int i]=>Value[i];

public static A232633Inst Instance=new A232633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232634
{
public static readonly long[] Value={ 67L,97L,127L,151L,181L,229L,241L,307L,349L,367L,373L,409L,433L,439L,487L,571L,601L,607L,643L,727L,739L,751L,769L,823L,853L,937L,967L,1009L,1021L,1051L,1063L,1087L,1249L,1297L,1423L,1429L,1447L,1489L,1549L,1567L,1579L,1597L,1609L,1663L,1693L,1777L,1783L,1789L,1861L,1867L,1987L,1999L,2083L,2131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232634Inst : IEnumerable<long>
{
public static readonly long[] Value=A232634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232634.Bytes);
public long this[int i]=>Value[i];

public static A232634Inst Instance=new A232634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232635
{
public static readonly long[] Value={ 1L,1L,4L,5L,4L,8L,1L,4L,8L,4L,13L,12L,4L,8L,8L,1L,12L,8L,8L,12L,16L,13L,4L,16L,4L,12L,20L,8L,5L,12L,12L,12L,16L,8L,8L,20L,17L,16L,16L,8L,20L,24L,8L,8L,16L,1L,24L,16L,8L,12L,20L,16L,12L,28L,12L,33L,20L,8L,16L,12L,16L,20L,24L,8L,16L,32L,1L,12L,32L,8L,16L,32L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232635Inst : IEnumerable<long>
{
public static readonly long[] Value=A232635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232635.Bytes);
public long this[int i]=>Value[i];

public static A232635Inst Instance=new A232635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232636
{
public static readonly long[] Value={ 34012224L,53747712L,131010048L,204073344L,322486272L,786060288L,1224440064L,1934917632L,4716361728L,7346640384L,11609505792L,28298170368L,44079842304L,69657034752L,169789022208L,264479053824L,417942208512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232636Inst : IEnumerable<long>
{
public static readonly long[] Value=A232636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232636.Bytes);
public long this[int i]=>Value[i];

public static A232636Inst Instance=new A232636Inst();

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