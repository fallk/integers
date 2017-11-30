using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A160064
{
public static readonly BigInteger[] Value={ 1L,38L,194L,-87628L,-4057364L,283960168L,36149011384L,-756038827408L,-345033325051504L,-5550878077877152L,3670691539870088224L,BigInteger.Parse("208872254488527752512"),BigInteger.Parse("-42534863002649658484544"),BigInteger.Parse("-4749408611428603310092672"),BigInteger.Parse("510713996558770024590318464"),BigInteger.Parse("102521782569233818861053861632") };
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
public class A160064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160064Inst Instance=new A160064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160065
{
public static readonly BigInteger[] Value={ 1L,42L,514L,-83412L,-5430804L,188966232L,41879106744L,341675743248L,-352091802793584L,-18204613149810528L,3196439029135777824L,BigInteger.Parse("361808103596334268608"),BigInteger.Parse("-28755096299570905798464"),BigInteger.Parse("-6634835598526992072655488"),BigInteger.Parse("188607219729893552173509504"),BigInteger.Parse("124031126202877890462758439168") };
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
public class A160065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160065Inst Instance=new A160065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160066
{
public static readonly BigInteger[] Value={ 1L,44L,686L,-79816L,-6084404L,131366224L,43807638856L,942289429664L,-341856105084784L,-24464562920370496L,2769440413707518176L,BigInteger.Parse("427662414707761999744"),BigInteger.Parse("-19262659441336846931264"),BigInteger.Parse("-7262493236035251261135616"),BigInteger.Parse("-6531486463827292856927104"),BigInteger.Parse("126806246226208496184168487424") };
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
public class A160066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160066Inst Instance=new A160066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160067
{
public static readonly BigInteger[] Value={ 1L,46L,866L,-75164L,-6705044L,67387976L,45006371896L,1564883287216L,-321821122878064L,-30452604524550944L,2219667824248876576L,BigInteger.Parse("482762276472335122496"),BigInteger.Parse("-8313367865694637285184"),BigInteger.Parse("-7623849068906980152558464"),BigInteger.Parse("-215604829352183231133449344") };
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
public class A160067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160067Inst Instance=new A160067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160068
{
public static readonly BigInteger[] Value={ 1L,48L,1054L,-69408L,-7284084L,-2596032L,45400915464L,2198714182272L,-291719729560944L,-35989688841645312L,1554341893161645024L,BigInteger.Parse("524479521392325361152"),BigInteger.Parse("3802815995858998255296"),BigInteger.Parse("-7684657653083648501025792"),BigInteger.Parse("-430659327280723849697798016") };
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
public class A160068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160068Inst Instance=new A160068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160069
{
public static readonly BigInteger[] Value={ 1L,1L,-337L,-1013L,340705L,1710281L,-574081169L,-4042531037L,1354233514817L,12285237438865L,-4107293114634449L,-45631395657998149L,15225284404552883233UL,BigInteger.Parse("200306225193393375577"),BigInteger.Parse("-66699593448411975550225"),BigInteger.Parse("-1014548651063549428780589"),BigInteger.Parse("337152390132385166610860161") };
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
public class A160069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160069Inst Instance=new A160069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160070
{
public static readonly BigInteger[] Value={ 1L,3L,-329L,-3015L,324561L,5049963L,-533358201L,-11841399567L,1226401304865L,35698348343763L,-3623617724368041L,-131531270575023063L,13078016887475307249UL,BigInteger.Parse("572724884114719465275"),BigInteger.Parse("-55746631551222341656281"),BigInteger.Parse("-2877374046284519534650143"),BigInteger.Parse("274003299825843713593394241") };
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
public class A160070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160070Inst Instance=new A160070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160071
{
public static readonly BigInteger[] Value={ 1L,5L,-313L,-4945L,292657L,8148925L,-453845705L,-18795248425L,979822695905L,55721465220725L,-2702013314839385L,-201848619020247425L,9036842409471596305L,BigInteger.Parse("863882210793481537325"),BigInteger.Parse("-35388474493250786477545"),BigInteger.Parse("-4264832993941008567009625"),BigInteger.Parse("158095400711076444606105025") };
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
public class A160071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160071Inst Instance=new A160071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160072
{
public static readonly BigInteger[] Value={ 1L,7L,-289L,-6755L,245761L,10853087L,-339364481L,-24385611803L,632237079425L,70364353871287L,-1430714718511841L,-247846519114532947L,3584471689625294209L,BigInteger.Parse("1030356783355922692495"),BigInteger.Parse("-8537671120722083906881"),BigInteger.Parse("-4935411996685280768234507"),BigInteger.Parse("8738108605264000030245121") };
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
public class A160072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160072Inst Instance=new A160072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160073
{
public static readonly BigInteger[] Value={ 1L,9L,-257L,-8397L,185025L,13017969L,-195530529L,-28160215893L,209183288577L,78027873371865L,65915296495551L,-263140974328443741L,-2613341841326452287L,BigInteger.Parse("1043779715304229742913"),BigInteger.Parse("20877041488526499035295"),BigInteger.Parse("-4751272239422876652146661"),BigInteger.Parse("-148608050501635239978265599") };
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
public class A160073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160073Inst Instance=new A160073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160074
{
public static readonly BigInteger[] Value={ 1L,11L,-217L,-9823L,111985L,14512531L,-29616809L,-29757197767L,-257255805343L,77633648903195L,1636542297788551L,-244399768017125039L,-8773061711366208047L,BigInteger.Parse("894781780252430869667"),BigInteger.Parse("48391432742519857724855"),BigInteger.Parse("-3701801623986784440290839"),BigInteger.Parse("-286064381868430307508214079") };
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
public class A160074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160074Inst Instance=new A160074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160075
{
public static readonly BigInteger[] Value={ 1L,15L,-113L,-11835L,-62943L,15056775L,332225295L,-25551760275L,-1169321452095L,51552138002175L,4330357927305615L,-109290857537767275L,BigInteger.Parse("-17739633636788785695"),BigInteger.Parse("177189213621352281975"),BigInteger.Parse("80605788404370208573455"),BigInteger.Parse("370627467209314130296125"),BigInteger.Parse("-403111935202017245512974975") };
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
public class A160075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160075Inst Instance=new A160075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160076
{
public static readonly BigInteger[] Value={ 1L,17L,-49L,-12325L,-159839L,13946137L,507212239L,-19660157773L,-1534286839615L,27078190344737L,5127629801969359L,-4354576731731957L,BigInteger.Parse("-19138555408161520031"),BigInteger.Parse("-307693278714841022935"),BigInteger.Parse("78864026725309421626319"),BigInteger.Parse("2796693049208887888175843"),BigInteger.Parse("-352296833660767673546447999") };
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
public class A160076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160076Inst Instance=new A160076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160077
{
public static readonly BigInteger[] Value={ 1L,19L,23L,-12407L,-259055L,11852219L,662995111L,-11439393023L,-1785994900063L,-3001784367005L,5375962583018551L,112289320237829369L,BigInteger.Parse("-17854331799144214607"),BigInteger.Parse("-794677787068375998197"),BigInteger.Parse("63353055971140535017415"),BigInteger.Parse("4964123351859225388799089"),BigInteger.Parse("-226881650088357230151111359") };
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
public class A160077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160077Inst Instance=new A160077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160078
{
public static readonly long[] Value={ 22L,26L,28L,35L,37L,41L,45L,46L,47L,49L,60L,61L,67L,75L,77L,78L,84L,86L,89L,90L,93L,94L,95L,97L,105L,106L,108L,110L,116L,120L,122L,124L,125L,131L,135L,139L,141L,147L,149L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160078Inst : IEnumerable<long>
{
public static readonly long[] Value=A160078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160078.Bytes);
public long this[int i]=>Value[i];

public static A160078Inst Instance=new A160078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160079
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,5L,8L,7L,6L,10L,13L,11L,9L,14L,17L,16L,12L,19L,22L,20L,15L,23L,26L,25L,18L,28L,31L,29L,21L,32L,35L,34L,24L,37L,40L,38L,27L,41L,44L,43L,30L,46L,49L,47L,33L,50L,53L,52L,36L,55L,58L,56L,39L,59L,62L,61L,42L,64L,67L,65L,45L,68L,71L,70L,48L,73L,76L,74L,51L,77L,80L,79L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160079Inst : IEnumerable<long>
{
public static readonly long[] Value=A160079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160079.Bytes);
public long this[int i]=>Value[i];

public static A160079Inst Instance=new A160079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160080
{
public static readonly long[] Value={ 0L,1L,5L,2L,3L,9L,4L,13L,17L,6L,7L,21L,8L,25L,29L,10L,11L,33L,12L,37L,41L,14L,15L,45L,16L,49L,53L,18L,19L,57L,20L,61L,65L,22L,23L,69L,24L,73L,77L,26L,27L,81L,28L,85L,89L,30L,31L,93L,32L,97L,101L,34L,35L,105L,36L,109L,113L,38L,39L,117L,40L,121L,125L,42L,43L,129L,44L,133L,137L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160080Inst : IEnumerable<long>
{
public static readonly long[] Value=A160080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160080.Bytes);
public long this[int i]=>Value[i];

public static A160080Inst Instance=new A160080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160081
{
public static readonly long[] Value={ 0L,1L,6L,2L,3L,5L,8L,13L,11L,4L,10L,9L,14L,18L,7L,15L,12L,17L,19L,16L,20L,21L,26L,22L,23L,25L,28L,33L,31L,24L,30L,29L,34L,38L,27L,35L,32L,37L,39L,36L,40L,41L,46L,42L,43L,45L,48L,53L,51L,44L,50L,49L,54L,58L,47L,55L,52L,57L,59L,56L,60L,61L,66L,62L,63L,65L,68L,73L,71L,64L,70L,69L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160081Inst : IEnumerable<long>
{
public static readonly long[] Value=A160081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160081.Bytes);
public long this[int i]=>Value[i];

public static A160081Inst Instance=new A160081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160082
{
public static readonly BigInteger[] Value={ 1L,21L,103L,-12033L,-357135L,8768781L,787702551L,-1241334297L,-1889772255903L,-36328649434875L,4985785564324551L,227492331940693071L,BigInteger.Parse("-13759811757404126127"),BigInteger.Parse("-1211664945256937744643"),BigInteger.Parse("35015649011638037564535"),BigInteger.Parse("6468927150200228196505911"),BigInteger.Parse("-41681870334800058325568319") };
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
public class A160082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160082Inst Instance=new A160082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160083
{
public static readonly BigInteger[] Value={ 1L,23L,191L,-11155L,-450239L,4726063L,869603359L,10416421493L,-1817903853055L,-69977792337337L,3920574297234559L,326698146936593917L,-7062637857576430271L,BigInteger.Parse("-1487528354699082823585"),BigInteger.Parse("-3179921411888070331681"),BigInteger.Parse("6965845981962634303575557"),BigInteger.Parse("176336659143413105563860481") };
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
public class A160083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160083Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160083.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160083Inst Instance=new A160083Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160084
{
public static readonly BigInteger[] Value={ 1L,25L,287L,-9725L,-534143L,-205375L,897567295L,22855682875L,-1552252148095L,-100608070196375L,2206749279595615L,395224009253637875L,1675906409804450305L,BigInteger.Parse("-1561130921287643963375"),BigInteger.Parse("-46392205796871853724545"),BigInteger.Parse("6227466374611334891576875"),BigInteger.Parse("390895142755423670672865025") };
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
public class A160084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160084Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160084.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160084Inst Instance=new A160084Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160085
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,5L,1L,13L,3L,5L,1L,33L,1L,5L,5L,75L,1L,33L,1L,33L,5L,5L,1L,261L,3L,5L,13L,33L,1L,61L,1L,541L,5L,5L,5L,375L,1L,5L,5L,261L,1L,61L,1L,33L,33L,5L,1L,2405L,3L,33L,5L,33L,1L,261L,5L,261L,5L,5L,1L,717L,1L,5L,33L,4683L,5L,61L,1L,33L,5L,61L,1L,4549L,1L,5L,33L,33L,5L,61L,1L,2405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160085Inst : IEnumerable<long>
{
public static readonly long[] Value=A160085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160085.Bytes);
public long this[int i]=>Value[i];

public static A160085Inst Instance=new A160085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160086
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,7L,0L,3L,0L,3L,0L,0L,0L,25L,0L,0L,1L,3L,0L,6L,0L,36L,0L,0L,0L,36L,0L,0L,0L,25L,0L,6L,0L,3L,3L,0L,0L,152L,0L,3L,0L,3L,0L,25L,0L,25L,0L,0L,0L,69L,0L,0L,3L,171L,0L,6L,0L,3L,0L,6L,0L,279L,0L,0L,3L,3L,0L,6L,0L,152L,7L,0L,0L,69L,0L,0L,0L,25L,0L,69L,0L,3L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160086Inst : IEnumerable<long>
{
public static readonly long[] Value=A160086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160086.Bytes);
public long this[int i]=>Value[i];

public static A160086Inst Instance=new A160086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160087
{
public static readonly BigInteger[] Value={ 1L,2L,-1454L,-8740L,6342316L,63656312L,-46108171016L,-649081759408L,469281829870480L,8509453301475872L,-6140897264957486816L,BigInteger.Parse("-136349623665433187392"),BigInteger.Parse("98215011088057307180224"),BigInteger.Parse("2582003037826533660970880"),BigInteger.Parse("-1856403314087385132972023936") };
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
public class A160087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160087Inst Instance=new A160087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160088
{
public static readonly BigInteger[] Value={ 1L,4L,-1442L,-17432L,6237580L,126613744L,-44965503224L,-1287479045408L,453768009722512L,16832227624528960L,-5887014913080686624L,BigInteger.Parse("-268961938417954983296"),BigInteger.Parse("93340097422316232142528"),BigInteger.Parse("5079118464249805316316928"),BigInteger.Parse("-1748851732685582642764208000") };
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
public class A160088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160088Inst Instance=new A160088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160089
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,4L,3L,3L,4L,6L,5L,6L,7L,8L,8L,10L,11L,16L,16L,19L,21L,28L,29L,34L,41L,50L,56L,68L,80L,100L,114L,135L,158L,196L,225L,269L,320L,388L,455L,544L,644L,786L,921L,1111L,1321L,1600L,1891L,2274L,2711L,3280L,3895L,4694L,5591L,6780L,8051L,9729L,11624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160089Inst : IEnumerable<long>
{
public static readonly long[] Value=A160089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160089.Bytes);
public long this[int i]=>Value[i];

public static A160089Inst Instance=new A160089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160090
{
public static readonly long[] Value={ 485L,569L,689L,2221L,2845L,3649L,12841L,16501L,21205L,74825L,96161L,123581L,436109L,560465L,720281L,2541829L,3266629L,4198105L,14814865L,19039309L,24468349L,86347361L,110969225L,142611989L,503269301L,646776041L,831203585L,2933268445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160090Inst : IEnumerable<long>
{
public static readonly long[] Value=A160090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160090.Bytes);
public long this[int i]=>Value[i];

public static A160090Inst Instance=new A160090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160091
{
public static readonly long[] Value={ 1L,2L,8L,5L,1L,4L,9L,0L,0L,4L,1L,5L,1L,2L,4L,0L,2L,3L,7L,2L,1L,9L,2L,8L,3L,3L,9L,1L,6L,8L,6L,0L,9L,7L,0L,1L,9L,3L,5L,6L,9L,5L,3L,4L,8L,2L,0L,5L,3L,5L,1L,2L,6L,5L,9L,8L,6L,6L,4L,6L,9L,8L,3L,0L,0L,0L,8L,8L,8L,3L,5L,0L,2L,2L,9L,0L,2L,1L,9L,5L,3L,9L,4L,7L,7L,5L,7L,3L,8L,6L,3L,7L,9L,8L,6L,2L,8L,1L,9L,0L,5L,4L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160091Inst : IEnumerable<long>
{
public static readonly long[] Value=A160091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160091.Bytes);
public long this[int i]=>Value[i];

public static A160091Inst Instance=new A160091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160092
{
public static readonly long[] Value={ 3L,5L,2L,8L,9L,4L,1L,0L,4L,1L,5L,6L,2L,2L,2L,8L,1L,2L,9L,9L,4L,8L,6L,8L,2L,4L,4L,7L,6L,4L,2L,3L,8L,1L,0L,5L,6L,3L,0L,2L,0L,8L,3L,3L,2L,2L,0L,2L,2L,3L,8L,6L,8L,1L,8L,2L,5L,7L,5L,0L,5L,6L,5L,8L,3L,7L,4L,3L,4L,7L,1L,9L,7L,6L,9L,6L,6L,2L,6L,1L,7L,1L,7L,8L,5L,0L,7L,4L,4L,0L,0L,1L,8L,4L,2L,7L,8L,2L,8L,1L,4L,6L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160092Inst : IEnumerable<long>
{
public static readonly long[] Value=A160092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160092.Bytes);
public long this[int i]=>Value[i];

public static A160092Inst Instance=new A160092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160093
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160093Inst : IEnumerable<long>
{
public static readonly long[] Value=A160093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160093.Bytes);
public long this[int i]=>Value[i];

public static A160093Inst Instance=new A160093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160094
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160094Inst : IEnumerable<long>
{
public static readonly long[] Value=A160094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160094.Bytes);
public long this[int i]=>Value[i];

public static A160094Inst Instance=new A160094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160095
{
public static readonly long[] Value={ 3L,4L,6L,6L,7L,8L,8L,9L,10L,11L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,21L,21L,22L,22L,23L,23L,24L,25L,25L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,31L,31L,31L,32L,32L,33L,33L,33L,34L,35L,35L,35L,36L,37L,37L,37L,37L,38L,39L,40L,40L,40L,41L,41L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160095Inst : IEnumerable<long>
{
public static readonly long[] Value=A160095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160095.Bytes);
public long this[int i]=>Value[i];

public static A160095Inst Instance=new A160095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160096
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160096Inst : IEnumerable<long>
{
public static readonly long[] Value=A160096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160096.Bytes);
public long this[int i]=>Value[i];

public static A160096Inst Instance=new A160096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160097
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,4L,1L,3L,3L,2L,1L,4L,1L,4L,3L,3L,1L,6L,1L,3L,2L,4L,1L,7L,1L,4L,3L,3L,3L,5L,1L,3L,3L,6L,1L,7L,1L,4L,4L,3L,1L,7L,1L,4L,3L,4L,1L,6L,3L,6L,3L,3L,1L,10L,1L,3L,4L,3L,3L,7L,1L,4L,3L,7L,1L,8L,1L,3L,4L,4L,3L,7L,1L,7L,2L,3L,1L,10L,3L,3L,3L,6L,1L,10L,3L,4L,3L,3L,3L,10L,1L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160097Inst : IEnumerable<long>
{
public static readonly long[] Value=A160097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160097.Bytes);
public long this[int i]=>Value[i];

public static A160097Inst Instance=new A160097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160098
{
public static readonly long[] Value={ 425L,601L,1261L,1289L,3005L,7141L,7309L,17429L,41585L,42565L,101569L,242369L,248081L,591985L,1412629L,1445921L,3450341L,8233405L,8427445L,20110061L,47987801L,49118749L,117210025L,279693401L,286285049L,683150089L,1630172605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160098Inst : IEnumerable<long>
{
public static readonly long[] Value=A160098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160098.Bytes);
public long this[int i]=>Value[i];

public static A160098Inst Instance=new A160098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160099
{
public static readonly long[] Value={ 2L,3L,8L,6L,2L,5L,8L,3L,5L,1L,2L,0L,1L,2L,5L,4L,1L,2L,7L,1L,1L,9L,9L,7L,6L,5L,1L,7L,0L,0L,4L,4L,1L,5L,6L,3L,5L,3L,4L,4L,6L,3L,0L,3L,5L,5L,9L,1L,9L,4L,0L,8L,1L,4L,4L,0L,7L,2L,9L,6L,5L,2L,7L,5L,3L,4L,1L,3L,0L,8L,1L,1L,3L,1L,4L,0L,0L,3L,4L,5L,1L,2L,8L,7L,7L,6L,4L,0L,5L,8L,1L,2L,7L,9L,4L,5L,7L,8L,6L,5L,8L,9L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160099Inst : IEnumerable<long>
{
public static readonly long[] Value=A160099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160099.Bytes);
public long this[int i]=>Value[i];

public static A160099Inst Instance=new A160099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160100
{
public static readonly long[] Value={ 1L,0L,2L,3L,5L,6L,7L,4L,0L,6L,2L,2L,5L,6L,7L,4L,6L,6L,7L,4L,0L,2L,2L,7L,7L,5L,3L,4L,9L,7L,0L,9L,6L,5L,4L,8L,3L,3L,9L,4L,2L,5L,8L,4L,5L,3L,4L,8L,8L,4L,8L,1L,0L,4L,2L,5L,0L,9L,2L,9L,8L,8L,2L,3L,7L,6L,0L,3L,0L,2L,0L,4L,3L,0L,3L,6L,5L,6L,2L,8L,4L,6L,9L,4L,9L,9L,2L,4L,8L,5L,0L,2L,3L,3L,6L,6L,3L,4L,3L,7L,6L,9L,1L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160100Inst : IEnumerable<long>
{
public static readonly long[] Value=A160100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160100.Bytes);
public long this[int i]=>Value[i];

public static A160100Inst Instance=new A160100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160101
{
public static readonly long[] Value={ 0L,1L,7L,2L,3L,5L,8L,13L,9L,4L,19L,11L,6L,17L,23L,10L,15L,25L,16L,29L,21L,14L,35L,31L,12L,37L,43L,20L,27L,41L,26L,49L,33L,22L,55L,47L,18L,53L,59L,28L,39L,61L,34L,65L,45L,32L,71L,67L,24L,73L,79L,38L,51L,77L,44L,85L,57L,40L,91L,83L,30L,89L,95L,46L,63L,97L,52L,101L,69L,50L,107L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160101Inst : IEnumerable<long>
{
public static readonly long[] Value=A160101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160101.Bytes);
public long this[int i]=>Value[i];

public static A160101Inst Instance=new A160101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160102
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,6L,11L,10L,13L,14L,17L,15L,19L,22L,21L,23L,29L,26L,31L,35L,33L,34L,37L,30L,41L,38L,39L,55L,43L,42L,47L,46L,51L,58L,77L,65L,53L,62L,57L,70L,59L,66L,61L,85L,91L,74L,67L,69L,71L,82L,87L,95L,73L,78L,119L,110L,93L,86L,79L,105L,83L,94L,143L,115L,133L,102L,89L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160102Inst : IEnumerable<long>
{
public static readonly long[] Value=A160102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160102.Bytes);
public long this[int i]=>Value[i];

public static A160102Inst Instance=new A160102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160103
{
public static readonly BigInteger[] Value={ 1L,8L,-1394L,-34480L,5821516L,247659488L,-40457575736L,-2490185806912L,392988531506320L,32189435503872128L,-4899280026394954016L,BigInteger.Parse("-508516209857615258368"),BigInteger.Parse("74506523384461350441664"),BigInteger.Parse("9493051794744527363939840"),BigInteger.Parse("-1336252229871124217359780736") };
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
public class A160103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160103Inst Instance=new A160103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160104
{
public static readonly BigInteger[] Value={ 1L,10L,-1358L,-42740L,5512492L,304384600L,-37142220680L,-3034178687600L,348731717384080L,38877977386007200L,-4187277821653825760L,BigInteger.Parse("-608713688504523233600"),BigInteger.Parse("61068424818638825202880"),BigInteger.Parse("11260738942261526747094400"),BigInteger.Parse("-1044883534589865025424443520") };
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
public class A160104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160104Inst Instance=new A160104Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160105
{
public static readonly long[] Value={ 0L,1L,8L,2L,3L,5L,15L,6L,7L,13L,20L,12L,4L,9L,27L,22L,14L,29L,36L,16L,10L,19L,43L,34L,21L,41L,48L,26L,11L,23L,55L,50L,28L,57L,64L,30L,17L,33L,71L,62L,35L,69L,76L,40L,18L,37L,83L,78L,42L,85L,92L,44L,24L,47L,99L,90L,49L,97L,104L,54L,25L,51L,111L,106L,56L,113L,120L,58L,31L,61L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160105Inst : IEnumerable<long>
{
public static readonly long[] Value=A160105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160105.Bytes);
public long this[int i]=>Value[i];

public static A160105Inst Instance=new A160105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160106
{
public static readonly long[] Value={ 3L,2L,5L,9L,1L,5L,3L,8L,4L,7L,9L,8L,6L,1L,8L,9L,9L,1L,6L,2L,5L,7L,1L,7L,8L,0L,6L,8L,8L,5L,0L,1L,5L,8L,8L,1L,1L,2L,0L,8L,6L,2L,1L,1L,5L,0L,5L,8L,7L,7L,8L,0L,7L,7L,6L,4L,5L,0L,7L,2L,8L,7L,0L,2L,5L,0L,4L,8L,0L,9L,7L,0L,2L,1L,2L,5L,0L,1L,7L,4L,1L,3L,3L,1L,7L,5L,6L,1L,7L,3L,6L,5L,3L,6L,4L,5L,8L,7L,4L,3L,2L,3L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160106Inst : IEnumerable<long>
{
public static readonly long[] Value=A160106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160106.Bytes);
public long this[int i]=>Value[i];

public static A160106Inst Instance=new A160106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160107
{
public static readonly BigInteger[] Value={ 1L,14L,-1262L,-58492L,4701100L,406940744L,-28573848584L,-3959951508688L,236185377526672L,49495469682710240L,-2406287948347046624L,BigInteger.Parse("-755331979250773951936"),BigInteger.Parse("28017398406079098428608"),BigInteger.Parse("13607531886656648441072768"),BigInteger.Parse("-340536322975630153440817280") };
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
public class A160107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160107Inst Instance=new A160107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160108
{
public static readonly long[] Value={ 0L,1L,9L,2L,3L,5L,8L,13L,21L,10L,7L,17L,16L,25L,33L,18L,11L,29L,24L,37L,45L,26L,15L,41L,32L,49L,57L,34L,19L,53L,40L,61L,69L,42L,23L,65L,48L,73L,81L,50L,27L,77L,56L,85L,93L,58L,31L,89L,64L,97L,105L,66L,35L,101L,72L,109L,117L,74L,39L,113L,80L,121L,129L,82L,43L,125L,88L,133L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160108Inst : IEnumerable<long>
{
public static readonly long[] Value=A160108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160108.Bytes);
public long this[int i]=>Value[i];

public static A160108Inst Instance=new A160108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160109
{
public static readonly long[] Value={ 5L,6L,15L,16L,24L,25L,26L,75L,76L,85L,94L,165L,166L,184L,194L,235L,256L,275L,475L,476L,485L,515L,516L,525L,526L,535L,594L,606L,615L,725L,734L,744L,765L,766L,816L,826L,856L,874L,875L,876L,885L,915L,924L,925L,934L,1524L,1525L,1526L,1535L,1624L,1635L,1665L,1666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160109Inst : IEnumerable<long>
{
public static readonly long[] Value=A160109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160109.Bytes);
public long this[int i]=>Value[i];

public static A160109Inst Instance=new A160109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160110
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,1L,10L,1382L,28L,3617L,87734L,349222L,3418052L,472728182L,34212412L,94997844116L,68926730208040L,7709321041217L,5155375716734L,BigInteger.Parse("52630543106106954746"),11719975655366236L,BigInteger.Parse("522165436992898244102") };
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
public class A160110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160110Inst Instance=new A160110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160111
{
public static readonly long[] Value={ 24L,874L,1524L,4874L,5124L,48874L,93474L,271524L,506524L,1500874L,1528474L,2373474L,2501524L,2506524L,2526524L,2555124L,7521524L,7531524L,18805124L,24951124L,25005124L,47778474L,153794874L,194506524L,250271524L,515126524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160111Inst : IEnumerable<long>
{
public static readonly long[] Value=A160111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160111.Bytes);
public long this[int i]=>Value[i];

public static A160111Inst Instance=new A160111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160112
{
public static readonly long[] Value={ 1L,9L,85L,833L,8319L,83190L,831910L,8319081L,83190727L,831907372L,8319073719L,83190737244L,831907372522L,8319073725828L,83190737258105L,831907372580692L,8319073725807178L,83190737258070643L,831907372580707771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160112Inst : IEnumerable<long>
{
public static readonly long[] Value=A160112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160112.Bytes);
public long this[int i]=>Value[i];

public static A160112Inst Instance=new A160112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160113
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,27L,54L,107L,214L,427L,854L,1706L,3410L,6815L,13629L,27259L,54521L,109042L,218080L,436158L,872318L,1744638L,3489278L,6978546L,13957092L,27914186L,55828364L,111656716L,223313428L,446626866L,893253744L,1786507472L,3573014938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160113Inst : IEnumerable<long>
{
public static readonly long[] Value=A160113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160113.Bytes);
public long this[int i]=>Value[i];

public static A160113Inst Instance=new A160113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160114
{
public static readonly long[] Value={ 0L,1L,2L,1L,0L,-1L,3L,7L,-10L,-1L,-7L,-14L,-59L,21L,34L,-15L,103L,-104L,302L,-38L,-514L,-290L,1130L,504L,2466L,6813L,-1854L,1590L,-4879L,3963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160114Inst : IEnumerable<long>
{
public static readonly long[] Value=A160114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160114.Bytes);
public long this[int i]=>Value[i];

public static A160114Inst Instance=new A160114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160115
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,2L,3L,0L,-1L,-1L,1L,2L,0L,-1L,0L,2L,6L,1L,2L,7L,5L,-1L,-7L,-4L,4L,-7L,-21L,-7L,-2L,30L,2L,14L,-8L,7L,-1L,-7L,-12L,-1L,21L,28L,7L,-29L,-33L,-76L,-88L,15L,47L,58L,-51L,-112L,293L,122L,316L,-96L,-42L,-259L,140L,-111L,6L,-790L,-342L,146L,395L,1087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160115Inst : IEnumerable<long>
{
public static readonly long[] Value=A160115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160115.Bytes);
public long this[int i]=>Value[i];

public static A160115Inst Instance=new A160115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160116
{
public static readonly BigInteger[] Value={ 279L,3348L,497842924845L,360L,1120426251L,84L,BigInteger.Parse("1034482758620689655172413793"),2745L,764237181279L,8878058443575583668L,107984565L,103551L,BigInteger.Parse("316069797264352410612542355"),25056L,BigInteger.Parse("10641813669975233258166411970121148474098929093423000284337408425") };
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
public class A160116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160116Inst Instance=new A160116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160117
{
public static readonly long[] Value={ 0L,1L,9L,13L,41L,49L,101L,113L,189L,205L,305L,325L,449L,473L,621L,649L,821L,853L,1049L,1085L,1305L,1345L,1589L,1633L,1901L,1949L,2241L,2293L,2609L,2665L,3005L,3065L,3429L,3493L,3881L,3949L,4361L,4433L,4869L,4945L,5405L,5485L,5969L,6053L,6561L,6649L,7181L,7273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160117Inst : IEnumerable<long>
{
public static readonly long[] Value=A160117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160117.Bytes);
public long this[int i]=>Value[i];

public static A160117Inst Instance=new A160117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160118
{
public static readonly long[] Value={ 0L,1L,9L,13L,41L,45L,73L,85L,169L,173L,201L,213L,297L,309L,393L,429L,681L,685L,713L,725L,809L,821L,905L,941L,1193L,1205L,1289L,1325L,1577L,1613L,1865L,1973L,2729L,2733L,2761L,2773L,2857L,2869L,2953L,2989L,3241L,3253L,3337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160118Inst : IEnumerable<long>
{
public static readonly long[] Value=A160118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160118.Bytes);
public long this[int i]=>Value[i];

public static A160118Inst Instance=new A160118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160119
{
public static readonly long[] Value={ 0L,1L,27L,35L,235L,243L,443L,499L,1899L,1907L,2107L,2163L,3563L,3619L,5019L,5411L,15211L,15219L,15419L,15475L,16875L,16931L,18331L,18723L,28523L,28579L,29979L,30371L,40171L,40563L,50363L,53107L,121707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160119Inst : IEnumerable<long>
{
public static readonly long[] Value=A160119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160119.Bytes);
public long this[int i]=>Value[i];

public static A160119Inst Instance=new A160119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160120
{
public static readonly long[] Value={ 0L,1L,4L,7L,16L,19L,28L,37L,58L,67L,76L,85L,106L,121L,142L,169L,220L,247L,256L,265L,286L,301L,322L,349L,400L,433L,454L,481L,532L,583L,640L,709L,826L,907L,928L,937L,958L,973L,994L,1021L,1072L,1105L,1126L,1153L,1204L,1255L,1312L,1381L,1498L,1585L,1618L,1645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160120Inst : IEnumerable<long>
{
public static readonly long[] Value=A160120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160120.Bytes);
public long this[int i]=>Value[i];

public static A160120Inst Instance=new A160120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160121
{
public static readonly long[] Value={ 1L,3L,3L,9L,3L,9L,9L,21L,9L,9L,9L,21L,15L,21L,27L,51L,27L,9L,9L,21L,15L,21L,27L,51L,33L,21L,27L,51L,51L,57L,69L,117L,81L,21L,9L,21L,15L,21L,27L,51L,33L,21L,27L,51L,51L,57L,69L,117L,87L,33L,27L,51L,51L,57L,75L,129L,117L,75L,69L,117L,135L,141L,171L,279L,231L,69L,9L,21L,15L,21L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160121Inst : IEnumerable<long>
{
public static readonly long[] Value=A160121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160121.Bytes);
public long this[int i]=>Value[i];

public static A160121Inst Instance=new A160121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160122
{
public static readonly long[] Value={ 2L,2L,6L,2L,6L,6L,14L,6L,6L,6L,14L,10L,14L,18L,34L,18L,6L,6L,14L,10L,14L,18L,34L,22L,14L,18L,34L,34L,38L,46L,78L,54L,14L,6L,14L,10L,14L,18L,34L,22L,14L,18L,34L,34L,38L,46L,78L,58L,22L,18L,34L,34L,38L,50L,86L,78L,50L,46L,78L,90L,94L,114L,186L,154L,46L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160122Inst : IEnumerable<long>
{
public static readonly long[] Value=A160122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160122.Bytes);
public long this[int i]=>Value[i];

public static A160122Inst Instance=new A160122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160123
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,3L,7L,3L,3L,3L,7L,5L,7L,9L,17L,9L,3L,3L,7L,5L,7L,9L,17L,11L,7L,9L,17L,17L,19L,23L,39L,27L,7L,3L,7L,5L,7L,9L,17L,11L,7L,9L,17L,17L,19L,23L,39L,29L,11L,9L,17L,17L,19L,25L,43L,39L,25L,23L,39L,45L,47L,57L,93L,77L,23L,3L,7L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160123Inst : IEnumerable<long>
{
public static readonly long[] Value=A160123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160123.Bytes);
public long this[int i]=>Value[i];

public static A160123Inst Instance=new A160123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160124
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,4L,8L,18L,24L,24L,28L,36L,40L,44L,64L,94L,108L,108L,112L,120L,124L,128L,148L,176L,188L,192L,208L,228L,240L,268L,340L,418L,448L,448L,452L,460L,464L,468L,488L,516L,528L,532L,548L,568L,580L,608L,680L,756L,784L,788L,804L,824L,836L,864L,932L,1000L,1028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160124Inst : IEnumerable<long>
{
public static readonly long[] Value=A160124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160124.Bytes);
public long this[int i]=>Value[i];

public static A160124Inst Instance=new A160124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160125
{
public static readonly long[] Value={ 0L,0L,2L,2L,0L,4L,10L,6L,0L,4L,8L,4L,4L,20L,30L,14L,0L,4L,8L,4L,4L,20L,28L,12L,4L,16L,20L,12L,28L,72L,78L,30L,0L,4L,8L,4L,4L,20L,28L,12L,4L,16L,20L,12L,28L,72L,76L,28L,4L,16L,20L,12L,28L,68L,68L,28L,24L,52L,52L,52L,128L,224L,190L,62L,0L,4L,8L,4L,4L,20L,28L,12L,4L,16L,20L,12L,28L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160125Inst : IEnumerable<long>
{
public static readonly long[] Value=A160125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160125.Bytes);
public long this[int i]=>Value[i];

public static A160125Inst Instance=new A160125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160126
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,4L,9L,12L,12L,14L,18L,20L,22L,32L,47L,54L,54L,56L,60L,62L,64L,74L,88L,94L,96L,104L,114L,120L,134L,170L,209L,224L,224L,226L,230L,232L,234L,244L,258L,264L,266L,274L,284L,290L,304L,340L,378L,392L,394L,402L,412L,418L,432L,466L,500L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160126Inst : IEnumerable<long>
{
public static readonly long[] Value=A160126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160126.Bytes);
public long this[int i]=>Value[i];

public static A160126Inst Instance=new A160126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160127
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,5L,3L,0L,2L,4L,2L,2L,10L,15L,7L,0L,2L,4L,2L,2L,10L,14L,6L,2L,8L,10L,6L,14L,36L,39L,15L,0L,2L,4L,2L,2L,10L,14L,6L,2L,8L,10L,6L,14L,36L,38L,14L,2L,8L,10L,6L,14L,34L,34L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160127Inst : IEnumerable<long>
{
public static readonly long[] Value=A160127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160127.Bytes);
public long this[int i]=>Value[i];

public static A160127Inst Instance=new A160127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160128
{
public static readonly long[] Value={ 3L,7L,19L,63L,235L,919L,3651L,14575L,58267L,233031L,932083L,3728287L,14913099L,59652343L,238609315L,954437199L,3817748731L,15270994855L,61083979347L,244335917311L,977343669163L,3909374676567L,15637498706179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160128Inst : IEnumerable<long>
{
public static readonly long[] Value=A160128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160128.Bytes);
public long this[int i]=>Value[i];

public static A160128Inst Instance=new A160128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160129
{
public static readonly long[] Value={ 11L,17L,23L,29L,37L,43L,47L,53L,59L,67L,71L,79L,89L,89L,101L,101L,109L,131L,127L,131L,131L,137L,179L,149L,157L,193L,191L,179L,179L,193L,193L,197L,211L,227L,223L,223L,227L,233L,257L,251L,257L,257L,263L,277L,277L,281L,311L,311L,307L,307L,311L,331L,359L,337L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160129Inst : IEnumerable<long>
{
public static readonly long[] Value=A160129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160129.Bytes);
public long this[int i]=>Value[i];

public static A160129Inst Instance=new A160129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160130
{
public static readonly long[] Value={ 13L,11L,12L,18L,82L,74L,50L,58L,34L,44L,60L,121L,81L,36L,51L,19L,13L,49L,52L,48L,36L,12L,44L,53L,33L,68L,59L,9L,41L,53L,48L,30L,4L,36L,104L,100L,35L,52L,94L,51L,26L,87L,63L,81L,108L,45L,81L,108L,54L,9L,45L,85L,54L,14L,81L,123L,66L,105L,105L,52L,58L,48L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160130Inst : IEnumerable<long>
{
public static readonly long[] Value=A160130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160130.Bytes);
public long this[int i]=>Value[i];

public static A160130Inst Instance=new A160130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160131
{
public static readonly BigInteger[] Value={ 1L,16L,-1202L,-65888L,4203340L,451512256L,-23418152504L,-4324519655552L,169813349966992L,53158210861830400L,-1377759404477582624L,BigInteger.Parse("-797090864837128553984"),BigInteger.Parse("9343051491617413259968"),BigInteger.Parse("14095390595056279792663552"),BigInteger.Parse("48438051548784025753183360"),BigInteger.Parse("-286940104001508238715797489664") };
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
public class A160131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160131Inst Instance=new A160131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160132
{
public static readonly BigInteger[] Value={ 1L,20L,-1058L,-79480L,3038092L,524289200L,-11661906680L,-4819720055200L,22627018472080L,56669755093294400L,836483365475254240L,BigInteger.Parse("-809515361950727267200"),BigInteger.Parse("-29605827454506672845120"),BigInteger.Parse("13571164223599790810028800"),BigInteger.Parse("832572138044715293306980480") };
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
public class A160132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160132Inst Instance=new A160132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160133
{
public static readonly long[] Value={ 1L,6L,8L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,27L,29L,31L,32L,33L,35L,37L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,59L,61L,62L,63L,64L,65L,67L,69L,71L,73L,74L,75L,76L,77L,79L,81L,83L,85L,87L,89L,90L,91L,92L,93L,95L,97L,99L,100L,101L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160133Inst : IEnumerable<long>
{
public static readonly long[] Value=A160133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160133.Bytes);
public long this[int i]=>Value[i];

public static A160133Inst Instance=new A160133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160134
{
public static readonly long[] Value={ 180L,252L,396L,468L,612L,684L,828L,1044L,1116L,1260L,1332L,1476L,1548L,1692L,1908L,1980L,2124L,2196L,2340L,2412L,2556L,2628L,2772L,2844L,2988L,3060L,3204L,3276L,3420L,3492L,3636L,3708L,3852L,3924L,4068L,4140L,4284L,4572L,4716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160134Inst : IEnumerable<long>
{
public static readonly long[] Value=A160134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160134.Bytes);
public long this[int i]=>Value[i];

public static A160134Inst Instance=new A160134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160135
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,1L,5L,1L,8L,1L,10L,1L,10L,9L,9L,1L,15L,1L,12L,11L,14L,1L,30L,1L,16L,10L,14L,1L,42L,1L,29L,15L,20L,13L,19L,1L,22L,17L,40L,1L,54L,1L,18L,18L,26L,1L,58L,1L,33L,21L,20L,1L,60L,17L,50L,23L,32L,1L,78L,1L,34L,20L,49L,19L,78L,1L,24L,27L,74L,1L,75L,1L,40L,34L,26L,19L,90L,1L,76L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160135Inst : IEnumerable<long>
{
public static readonly long[] Value=A160135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160135.Bytes);
public long this[int i]=>Value[i];

public static A160135Inst Instance=new A160135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160136
{
public static readonly long[] Value={ 0L,1L,10L,2L,3L,5L,8L,4L,12L,7L,19L,17L,9L,26L,35L,16L,6L,13L,28L,14L,15L,11L,44L,37L,18L,46L,55L,20L,21L,23L,53L,22L,30L,25L,64L,62L,27L,71L,80L,34L,24L,31L,73L,32L,33L,29L,89L,82L,36L,91L,100L,38L,39L,41L,98L,40L,48L,43L,109L,107L,45L,116L,125L,52L,42L,49L,118L,50L,51L,47L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160136Inst : IEnumerable<long>
{
public static readonly long[] Value=A160136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160136.Bytes);
public long this[int i]=>Value[i];

public static A160136Inst Instance=new A160136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160137
{
public static readonly long[] Value={ 0L,1L,11L,2L,3L,5L,8L,13L,21L,4L,15L,9L,14L,23L,7L,10L,17L,27L,24L,31L,25L,6L,41L,37L,18L,35L,33L,28L,51L,19L,20L,29L,39L,38L,47L,45L,12L,57L,49L,16L,55L,61L,26L,67L,43L,30L,53L,63L,36L,59L,65L,34L,69L,73L,22L,75L,77L,32L,79L,71L,40L,81L,91L,42L,83L,85L,48L,93L,101L,44L,95L,89L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160137Inst : IEnumerable<long>
{
public static readonly long[] Value=A160137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160137.Bytes);
public long this[int i]=>Value[i];

public static A160137Inst Instance=new A160137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160138
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,6L,7L,9L,11L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160138Inst : IEnumerable<long>
{
public static readonly long[] Value=A160138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160138.Bytes);
public long this[int i]=>Value[i];

public static A160138Inst Instance=new A160138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160139
{
public static readonly BigInteger[] Value={ 1L,22L,-974L,-85580L,2377516L,551407912L,-5201117576L,-4938141000848L,-55556496038000L,56376233721055072L,1969289482873847584L,BigInteger.Parse("-778641119029758302912"),BigInteger.Parse("-48713569344985450216256"),BigInteger.Parse("12551406492954971362990720"),BigInteger.Parse("1199447936209863593384712064") };
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
public class A160139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160139Inst Instance=new A160139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160140
{
public static readonly BigInteger[] Value={ 1L,26L,-782L,-96148L,920620L,584671256L,8490132856L,-4893960693232L,-213893273952368L,51521932403096480L,4146277783283481376L,BigInteger.Parse("-643386552071776162624"),BigInteger.Parse("-83226053442166654536512"),BigInteger.Parse("9092813725551462723320192"),BigInteger.Parse("1813879773807164800891373440") };
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
public class A160140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160140Inst Instance=new A160140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160141
{
public static readonly BigInteger[] Value={ 1L,28L,-674L,-100520L,133516L,589971088L,15545858824L,-4725783030752L,-290982960018800L,46974010390164928L,5133550692291311584L,BigInteger.Parse("-541141652104447925888"),BigInteger.Parse("-97483852261892597109056"),BigInteger.Parse("6738266481886428192282880"),BigInteger.Parse("2036380397264732274988968064"),BigInteger.Parse("-80522844304853268561187040768") };
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
public class A160141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160141Inst Instance=new A160141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160142
{
public static readonly BigInteger[] Value={ 1L,32L,-434L,-107200L,-1532084L,576163712L,29606131144L,-4092883955968L,-433132461046640L,33879159708918272L,6767697264539394784L,BigInteger.Parse("-277391836090767772672"),BigInteger.Parse("-117416867483587382271296"),BigInteger.Parse("1095907804769276717987840"),BigInteger.Parse("2260588356036532098545755264") };
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
public class A160142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160142Inst Instance=new A160142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160143
{
public static readonly BigInteger[] Value={ 1L,3L,25L,427L,12465L,555731L,35135945L,2990414715L,329655706465L,45692713833379L,1111113564712575L,1595024111042171723L,BigInteger.Parse("387863354088927172625"),BigInteger.Parse("110350957750914345093747") };
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
public class A160143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160143Inst Instance=new A160143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160144
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,3L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,9L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,15L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160144Inst : IEnumerable<long>
{
public static readonly long[] Value=A160144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160144.Bytes);
public long this[int i]=>Value[i];

public static A160144Inst Instance=new A160144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160145
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,18L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,54L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,90L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,144L,0L,0L,0L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160145Inst : IEnumerable<long>
{
public static readonly long[] Value=A160145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160145.Bytes);
public long this[int i]=>Value[i];

public static A160145Inst Instance=new A160145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160146
{
public static readonly BigInteger[] Value={ 1L,34L,-302L,-109412L,-2399060L,556522744L,36410920696L,-3630489660848L,-495046505092208L,25514450230996000L,7363491547673817376L,BigInteger.Parse("-121641971747011889216"),BigInteger.Parse("-122231504480991087309632"),BigInteger.Parse("-2027623214667976954804352"),BigInteger.Parse("2247836746633993852403416960") };
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
public class A160146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160146Inst Instance=new A160146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160147
{
public static readonly BigInteger[] Value={ 1L,38L,-14L,-111340L,-4169684L,490886888L,49050698104L,-2430351968272L,-592964799643760L,5814962971461728L,8001852693840964384L,BigInteger.Parse("219288242242044652352"),BigInteger.Parse("-120000760298623690001216"),BigInteger.Parse("-8396695977614513457596800"),BigInteger.Parse("1955419963550761908894369664") };
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
public class A160147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160147Inst Instance=new A160147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160148
{
public static readonly BigInteger[] Value={ 1L,40L,142L,-110960L,-5059508L,444738400L,54673349320L,-1703637550400L,-626141705175920L,-5174439819171200L,8009253862551574240L,BigInteger.Parse("395813487065579065600"),BigInteger.Parse("-112619873964978985037120"),BigInteger.Parse("-11429947728298530733222400"),BigInteger.Parse("1677399182000270453064676480") };
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
public class A160148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160148Inst Instance=new A160148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160149
{
public static readonly BigInteger[] Value={ 1L,596L,175294L,49483138L,13916993782L,3913787773536L,1100831164969864L,309656520296472068L,BigInteger.Parse("87106950271042689032"),BigInteger.Parse("24503579727182933530758"),BigInteger.Parse("6892987382635818948665404"),BigInteger.Parse("1939035566761570513740174424") };
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
public class A160149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160149Inst Instance=new A160149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160150
{
public static readonly BigInteger[] Value={ 1L,44L,478L,-107272L,-6810740L,325937744L,63991555336L,-35674949728L,-654667511547248L,-28389257894451520L,7341419739167121376L,BigInteger.Parse("736937848624456502144"),BigInteger.Parse("-85316424437286206533952"),BigInteger.Parse("-16647387274774084049005312"),BigInteger.Parse("884602468694263060488292480") };
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
public class A160150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160150Inst Instance=new A160150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160151
{
public static readonly BigInteger[] Value={ 1L,46L,658L,-103868L,-7656020L,253581256L,67477123576L,885618857008L,-647933055794288L,-40134778914678560L,6655977728057433376L,BigInteger.Parse("891340052066655340096"),BigInteger.Parse("-65746928407518970839872"),BigInteger.Parse("-18619244257704074488953728"),BigInteger.Parse("389682045181727146807062400") };
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
public class A160151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160151Inst Instance=new A160151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160152
{
public static readonly BigInteger[] Value={ 1L,50L,1042L,-93700L,-9242708L,84323000L,71595491320L,2842116962000L,-588597736311920L,-62580339060364000L,4594562542866814240L,BigInteger.Parse("1142149470643447832000"),BigInteger.Parse("-16580120530325575181120"),BigInteger.Parse("-20812053164894042027728000"),BigInteger.Parse("-726343053712911149403451520") };
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
public class A160152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160152Inst Instance=new A160152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160153
{
public static readonly BigInteger[] Value={ 1L,52L,1246L,-86840L,-9965684L,-11764688L,72038072584L,3848897264992L,-535077911012720L,-72717589071528128L,3239977716589449184L,BigInteger.Parse("1228701289925531463808"),BigInteger.Parse("11929704457466050105024"),BigInteger.Parse("-20877013136748863885323520"),BigInteger.Parse("-1311720301397752435727447936") };
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
public class A160153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160153Inst Instance=new A160153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160154
{
public static readonly long[] Value={ 0L,1L,82L,973L,9964L,99955L,999946L,9999937L,99999928L,999999919L,9999999910L,99999999901L,999999999892L,9999999999883L,99999999999874L,999999999999865L,9999999999999856L,99999999999999847L,999999999999999838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160154Inst : IEnumerable<long>
{
public static readonly long[] Value=A160154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160154.Bytes);
public long this[int i]=>Value[i];

public static A160154Inst Instance=new A160154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160155
{
public static readonly long[] Value={ 1L,1L,6L,7L,3L,0L,3L,9L,7L,8L,2L,6L,1L,4L,1L,8L,6L,8L,4L,2L,5L,6L,0L,4L,5L,8L,9L,9L,8L,5L,4L,8L,4L,2L,1L,8L,0L,7L,2L,0L,5L,6L,0L,3L,7L,1L,5L,2L,5L,4L,8L,9L,0L,3L,9L,1L,4L,0L,0L,8L,2L,4L,4L,9L,2L,7L,5L,6L,5L,1L,9L,0L,3L,4L,2L,9L,5L,2L,7L,0L,5L,3L,1L,8L,0L,6L,8L,5L,2L,0L,5L,0L,4L,9L,7L,2L,8L,6L,7L,2L,8L,9L,5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160155Inst : IEnumerable<long>
{
public static readonly long[] Value=A160155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160155.Bytes);
public long this[int i]=>Value[i];

public static A160155Inst Instance=new A160155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160156
{
public static readonly long[] Value={ 1L,4L,15L,58L,229L,912L,3643L,14566L,58257L,233020L,932071L,3728274L,14913085L,59652328L,238609299L,954437182L,3817748713L,15270994836L,61083979327L,244335917290L,977343669141L,3909374676544L,15637498706155L,62549994824598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160156Inst : IEnumerable<long>
{
public static readonly long[] Value=A160156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160156.Bytes);
public long this[int i]=>Value[i];

public static A160156Inst Instance=new A160156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160157
{
public static readonly long[] Value={ 0L,2L,8L,14L,32L,38L,56L,74L,116L,134L,152L,170L,212L,242L,284L,338L,440L,494L,512L,530L,572L,602L,644L,698L,800L,866L,908L,962L,1064L,1166L,1280L,1418L,1652L,1814L,1856L,1874L,1916L,1946L,1988L,2042L,2144L,2210L,2252L,2306L,2408L,2510L,2624L,2762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160157Inst : IEnumerable<long>
{
public static readonly long[] Value=A160157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160157.Bytes);
public long this[int i]=>Value[i];

public static A160157Inst Instance=new A160157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160158
{
public static readonly long[] Value={ 0L,2L,4L,8L,16L,24L,28L,36L,48L,56L,64L,80L,104L,124L,136L,156L,176L,184L,192L,208L,232L,252L,268L,296L,328L,352L,384L,440L,508L,560L,600L,652L,688L,696L,704L,720L,744L,764L,780L,808L,840L,864L,896L,952L,1020L,1072L,1116L,1176L,1224L,1248L,1280L,1336L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160158Inst : IEnumerable<long>
{
public static readonly long[] Value=A160158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160158.Bytes);
public long this[int i]=>Value[i];

public static A160158Inst Instance=new A160158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160159
{
public static readonly long[] Value={ 2L,2L,4L,8L,8L,4L,8L,12L,8L,8L,16L,24L,20L,12L,20L,20L,8L,8L,16L,24L,20L,16L,28L,32L,24L,32L,56L,68L,52L,40L,52L,36L,8L,8L,16L,24L,20L,16L,28L,32L,24L,32L,56L,68L,52L,44L,60L,48L,24L,32L,56L,68L,56L,60L,88L,88L,80L,120L,180L,188L,144L,128L,132L,68L,8L,8L,16L,24L,20L,16L,28L,32L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160159Inst : IEnumerable<long>
{
public static readonly long[] Value=A160159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160159.Bytes);
public long this[int i]=>Value[i];

public static A160159Inst Instance=new A160159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160160
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,23L,31L,39L,55L,87L,143L,175L,191L,199L,215L,247L,303L,359L,423L,503L,655L,887L,1239L,1383L,1431L,1463L,1487L,1527L,1583L,1639L,1703L,1783L,1935L,2167L,2519L,2735L,2903L,3079L,3351L,3711L,4207L,4655L,5191L,5855L,7023L,8511L,10511L,11279L,11583L,11919L,12183L,12375L,12487L,12607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160160Inst : IEnumerable<long>
{
public static readonly long[] Value=A160160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160160.Bytes);
public long this[int i]=>Value[i];

public static A160160Inst Instance=new A160160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160161
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,8L,8L,8L,16L,32L,56L,32L,16L,8L,16L,32L,56L,56L,64L,80L,152L,232L,352L,144L,48L,32L,24L,40L,56L,56L,64L,80L,152L,232L,352L,216L,168L,176L,272L,360L,496L,448L,536L,664L,1168L,1488L,2000L,768L,304L,336L,264L,192L,112L,120L,128L,112L,168L,240L,352L,216L,168L,176L,272L,360L,496L,448L,536L,664L,1168L,1488L,2000L,984L,656L,736L,928L,928L,928L,808L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160161Inst : IEnumerable<long>
{
public static readonly long[] Value=A160161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160161.Bytes);
public long this[int i]=>Value[i];

public static A160161Inst Instance=new A160161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160162
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,12L,14L,18L,24L,28L,32L,40L,52L,62L,68L,78L,88L,92L,96L,104L,116L,126L,134L,148L,164L,176L,192L,220L,254L,280L,300L,326L,344L,348L,352L,360L,372L,382L,390L,404L,420L,432L,448L,476L,510L,536L,558L,588L,612L,624L,640L,668L,702L,730L,760L,804L,848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160162Inst : IEnumerable<long>
{
public static readonly long[] Value=A160162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160162.Bytes);
public long this[int i]=>Value[i];

public static A160162Inst Instance=new A160162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160163
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,2L,4L,6L,4L,4L,8L,12L,10L,6L,10L,10L,4L,4L,8L,12L,10L,8L,14L,16L,12L,16L,28L,34L,26L,20L,26L,18L,4L,4L,8L,12L,10L,8L,14L,16L,12L,16L,28L,34L,26L,22L,30L,24L,12L,16L,28L,34L,28L,30L,44L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160163Inst : IEnumerable<long>
{
public static readonly long[] Value=A160163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160163.Bytes);
public long this[int i]=>Value[i];

public static A160163Inst Instance=new A160163Inst();

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