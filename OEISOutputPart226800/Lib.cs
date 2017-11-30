using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277462
{
public static readonly BigInteger[] Value={ 1L,1L,3L,24L,233L,2860L,42875L,758856L,15488657L,358164432L,9254769459L,264273873600L,8264362186489L,280896392748608L,10310601442639147L,406479520869636480L,17129450693008029729UL,BigInteger.Parse("768404013933189112064"),BigInteger.Parse("36557893891263190204259"),BigInteger.Parse("1838650651518153170939904") };
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
public class A277462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277462Inst Instance=new A277462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277463
{
public static readonly BigInteger[] Value={ 0L,1L,2L,13L,112L,1321L,19296L,335637L,6764864L,154946449L,3973820800L,112789880413L,3509627281920L,118790978349369L,4344883388878592L,170767066282574821L,7177162988688031744L,BigInteger.Parse("321206181612447781921"),BigInteger.Parse("15250250261039350358016"),BigInteger.Parse("765586309042945067185581") };
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
public class A277463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277463Inst Instance=new A277463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277464
{
public static readonly BigInteger[] Value={ 1L,1L,5L,30L,281L,3400L,50557L,890120L,18101617L,417464064L,10764826421L,306893014912L,9584448407305L,325407839778944L,11933432488693549L,470087171351873280L,BigInteger.Parse("19796492491889197025"),BigInteger.Parse("887518214183286390784"),BigInteger.Parse("42202928616264032249701"),BigInteger.Parse("2121583256369642798845952") };
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
public class A277464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277464Inst Instance=new A277464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277465
{
public static readonly BigInteger[] Value={ 0L,1L,1L,11L,86L,1084L,15654L,275113L,5548024L,127423728L,3272008650L,92988690893L,2896148079516L,98104636748468L,3590611928294286L,141201205469361945L,5937400341113630032L,BigInteger.Parse("265833516437952849024"),BigInteger.Parse("12625912572901413474834"),BigInteger.Parse("634047172218326393377149") };
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
public class A277465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277465Inst Instance=new A277465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277466
{
public static readonly BigInteger[] Value={ 0L,1L,3L,17L,146L,1684L,24294L,419383L,8412760L,192078864L,4914973770L,139265564723L,4327699948956L,146323675764044L,5347193667136398L,210005149832116455L,8820722263274822992L,BigInteger.Parse("394546588041904397184"),BigInteger.Parse("18723398414958791004690"),BigInteger.Parse("939550079246853331267203") };
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
public class A277466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277466Inst Instance=new A277466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277467
{
public static readonly BigInteger[] Value={ 0L,1L,2L,14L,116L,1376L,19926L,346128L,6964712L,159396352L,4085415850L,115906440704L,3605365584732L,121998144397312L,4461190462108030L,175305587376883712L,7366747721719011280L,BigInteger.Parse("329646098258032459776"),BigInteger.Parse("15649117182518598570834"),BigInteger.Parse("785528920149992297070592") };
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
public class A277467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277467Inst Instance=new A277467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277468
{
public static readonly BigInteger[] Value={ 0L,1L,2L,10L,100L,1216L,17766L,309744L,6260360L,143641600L,3688352650L,104786813440L,3263080663404L,110514370068480L,4044232154193518L,159019302501971968L,6685886706336107536L,BigInteger.Parse("299315231931854749696"),BigInteger.Parse("14214873507079452102162"),BigInteger.Parse("713784039156929684963328") };
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
public class A277468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277468Inst Instance=new A277468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277469
{
public static readonly BigInteger[] Value={ 0L,1L,2L,13L,112L,1329L,19344L,336533L,6778752L,155247777L,3980956800L,112984562813L,3515475849216L,118984054897681L,4351800687259648L,171034439586509445L,7188243684485414912L,BigInteger.Parse("321696219477456836929"),BigInteger.Parse("15273278824827215388672"),BigInteger.Parse("766732102664665113137517") };
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
public class A277469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277469Inst Instance=new A277469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277470
{
public static readonly BigInteger[] Value={ 0L,1L,2L,11L,104L,1249L,18264L,318163L,6425152L,147344769L,3781848480L,107408279483L,3343875651456L,113227469886881L,4142804357946240L,162871544915116035L,6847004160475236352L,BigInteger.Parse("306495323034774157569"),BigInteger.Parse("14554502490109085839872"),BigInteger.Parse("730777840212988501198059") };
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
public class A277470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277470Inst Instance=new A277470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277471
{
public static readonly BigInteger[] Value={ 2L,1L,5L,105L,7007L,1298745L,619247475L,723733375365L,2006532782969715L,12889909959143502285UL,BigInteger.Parse("188494585656727188486375"),BigInteger.Parse("6188497678605937441851529425"),BigInteger.Parse("451101946262511157576785806552415"),BigInteger.Parse("72341127537387548941434093006996374625"),BigInteger.Parse("25326487488712595887856341442148826764706875") };
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
public class A277471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277471Inst Instance=new A277471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277472
{
public static readonly BigInteger[] Value={ 1L,2L,10L,60L,492L,4920L,59160L,828240L,13253520L,238563360L,4771297440L,104968543680L,2519245713600L,65500388553600L,1834010896798080L,55020326903942400L,1760650461445075200L,BigInteger.Parse("59862115689132556800"),BigInteger.Parse("2155036164826415270400"),BigInteger.Parse("81891374263403780275200") };
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
public class A277472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277472Inst Instance=new A277472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277473
{
public static readonly BigInteger[] Value={ 0L,1L,4L,18L,116L,1060L,12702L,187810L,3296120L,66897288L,1540762010L,39693752494L,1130866726596L,35300006582620L,1198036854980630L,43921652697277170L,1729775120233353968L,BigInteger.Parse("72831210167041246480"),BigInteger.Parse("3264674481128340280242"),BigInteger.Parse("155220967397580333229270") };
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
public class A277473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277473Inst Instance=new A277473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277474
{
public static readonly BigInteger[] Value={ 0L,1L,0L,6L,36L,380L,4830L,74382L,1342712L,27825912L,651274650L,16994464850L,489240628932L,15404364096420L,526634857318934L,19428038813967630L,769280055136105200L,BigInteger.Parse("32543192449030871792"),BigInteger.Parse("1464827827285673677746"),BigInteger.Parse("69903432558329996409642"),BigInteger.Parse("3525344776953738276010940") };
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
public class A277474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277474Inst Instance=new A277474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277475
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,32L,300L,3576L,52234L,906688L,18229176L,416505760L,10657541422L,301871501568L,9375794555556L,316817746172032L,11570642333807730L,454152692297009152L,BigInteger.Parse("19064517871187079408"),BigInteger.Parse("852278820775206658560"),BigInteger.Parse("40424330665968520135382"),BigInteger.Parse("2027524052626732381306880") };
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
public class A277475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277475Inst Instance=new A277475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277476
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,40L,340L,3936L,56714L,976704L,19535688L,444743680L,11349643822L,320813048832L,9947821243100L,335700998830848L,12246806941654770L,480247532548624384L,BigInteger.Parse("20144008859005187344"),BigInteger.Parse("899923326921333301248"),BigInteger.Parse("42658767419625168409814"),BigInteger.Parse("2138475182252830504796160") };
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
public class A277476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277476Inst Instance=new A277476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277477
{
public static readonly BigInteger[] Value={ 0L,1L,2L,6L,52L,540L,6846L,104832L,1883848L,38889360L,907247770L,23608391840L,678039307452L,21305543325248L,727095737061526L,26781816978470400L,1059020025979194128L,BigInteger.Parse("44746083421419997440"),BigInteger.Parse("2011929587198990154162"),BigInteger.Parse("95918808101232854969856") };
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
public class A277477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277477Inst Instance=new A277477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277478
{
public static readonly BigInteger[] Value={ 0L,1L,2L,12L,76L,720L,8766L,131096L,2319416L,47361600L,1096018330L,28344108672L,810053677764L,25352185339520L,862335856149782L,31674845755622400L,1249527587684729584L,BigInteger.Parse("52687201308036059136"),BigInteger.Parse("2364751154207006978994"),BigInteger.Parse("112562199977955164819456") };
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
public class A277478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277478Inst Instance=new A277478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277479
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,44L,360L,4206L,59584L,1021432L,20329344L,461596090L,11756157952L,331835099364L,10278341179392L,346555737301606L,12633922368061440L,495139124241620080L,BigInteger.Parse("20758413862397509632"),BigInteger.Parse("926980786260912379122"),BigInteger.Parse("43925328338613823078400"),BigInteger.Parse("2201264843743619567644700") };
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
public class A277479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277479Inst Instance=new A277479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277480
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,28L,280L,3486L,50624L,877080L,17677440L,404537050L,10360548352L,293676213876L,9126971869184L,308568877413174L,11274243944693760L,442681525701106096L,BigInteger.Parse("18588860836606935040"),BigInteger.Parse("831243363178769061426"),BigInteger.Parse("39436124829328468606976"),BigInteger.Parse("1978382154057910059275340") };
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
public class A277480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277480Inst Instance=new A277480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277481
{
public static readonly BigInteger[] Value={ 0L,0L,2L,3L,32L,240L,3114L,44065L,777720L,15582168L,357427770L,9151281293L,259607392164L,8070381333872L,272960010908662L,9976300661919345L,391837137436921072L,16458193396472517328UL,BigInteger.Parse("736145006794621566642"),BigInteger.Parse("34932117830021859779517"),BigInteger.Parse("1752782822664497750549660") };
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
public class A277481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277481Inst Instance=new A277481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277482
{
public static readonly BigInteger[] Value={ 0L,0L,2L,9L,56L,480L,5394L,75775L,1280376L,25270056L,569899770L,14444562803L,406204015524L,12545427045008L,422007399953398L,15354968442741135L,600807449737710832L,BigInteger.Parse("25153741340051795248"),BigInteger.Parse("1121917008608064151218"),BigInteger.Parse("53107023489332468636739"),BigInteger.Parse("2658946993059795072656540") };
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
public class A277482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277482Inst Instance=new A277482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277483
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,40L,340L,3984L,57050L,982528L,19616328L,446355840L,11384327438L,321701896704L,9973046260060L,336499112011776L,12274383608508450L,481282311712489472L,BigInteger.Parse("20185816487436968208"),BigInteger.Parse("901732370496365076480"),BigInteger.Parse("42742176871086712813974"),BigInteger.Parse("2142556308913381810012160") };
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
public class A277483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277483Inst Instance=new A277483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277484
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,32L,300L,3624L,52570L,908928L,18277560L,417634080L,10682763278L,302517156864L,9394763009060L,317429118686848L,11592017133950370L,454961391572119552L,BigInteger.Parse("19097430979664893168"),BigInteger.Parse("853711115246721262080"),BigInteger.Parse("40490675416206345889686"),BigInteger.Parse("2030782746261324446228480") };
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
public class A277484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277484Inst Instance=new A277484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277485
{
public static readonly BigInteger[] Value={ 0L,1L,6L,33L,216L,1865L,21228L,303765L,5222864L,104540337L,2383558740L,60933722069L,1725392415288L,53590463856345L,1811281159509500L,66172416761172885L,2598298697830360992L,BigInteger.Parse("109116931783034360801"),BigInteger.Parse("4880122696811960470692"),BigInteger.Parse("231565260558289051906965") };
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
public class A277485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277485Inst Instance=new A277485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277486
{
public static readonly long[] Value={ 1L,2L,0L,2L,2L,2L,0L,2L,1L,2L,1L,3L,1L,3L,1L,3L,3L,2L,3L,3L,5L,4L,1L,4L,3L,4L,2L,4L,4L,2L,4L,4L,4L,3L,3L,4L,3L,4L,5L,5L,5L,4L,4L,6L,6L,3L,3L,9L,4L,5L,6L,9L,4L,6L,4L,4L,8L,6L,5L,7L,5L,9L,5L,5L,7L,8L,6L,11L,5L,9L,4L,7L,9L,9L,6L,10L,5L,5L,17L,4L,10L,9L,10L,7L,3L,3L,10L,8L,7L,10L,6L,9L,5L,10L,10L,10L,8L,11L,6L,9L,10L,7L,7L,7L,7L,12L,9L,11L,13L,9L,12L,6L,10L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277486Inst : IEnumerable<long>
{
public static readonly long[] Value=A277486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277486.Bytes);
public long this[int i]=>Value[i];

public static A277486Inst Instance=new A277486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277487
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,2L,1L,1L,0L,2L,1L,2L,0L,3L,2L,0L,3L,0L,2L,0L,1L,4L,2L,3L,2L,4L,2L,0L,3L,3L,2L,5L,3L,4L,3L,3L,3L,2L,4L,2L,2L,4L,3L,3L,3L,6L,3L,1L,3L,4L,2L,6L,3L,3L,2L,5L,5L,5L,5L,4L,3L,7L,4L,4L,6L,4L,2L,4L,6L,5L,5L,5L,4L,7L,4L,4L,7L,4L,0L,5L,6L,7L,4L,4L,9L,4L,5L,2L,6L,6L,7L,11L,3L,6L,4L,9L,5L,7L,7L,7L,6L,8L,8L,7L,6L,4L,6L,5L,7L,8L,5L,9L,8L,8L,5L,12L,7L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277487Inst : IEnumerable<long>
{
public static readonly long[] Value=A277487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277487.Bytes);
public long this[int i]=>Value[i];

public static A277487Inst Instance=new A277487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277488
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,1L,0L,3L,2L,3L,2L,1L,1L,2L,1L,3L,2L,3L,1L,2L,4L,4L,1L,2L,3L,2L,2L,3L,4L,3L,3L,4L,3L,4L,3L,2L,4L,5L,5L,4L,4L,3L,4L,5L,4L,4L,3L,4L,6L,4L,6L,8L,4L,4L,3L,5L,7L,3L,7L,2L,6L,6L,4L,7L,7L,4L,5L,7L,4L,8L,6L,4L,4L,3L,6L,11L,4L,5L,5L,9L,6L,3L,6L,7L,6L,9L,9L,8L,11L,6L,5L,5L,7L,8L,7L,7L,5L,8L,9L,5L,7L,6L,5L,6L,7L,6L,8L,9L,6L,9L,6L,15L,8L,10L,9L,7L,10L,6L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277488Inst : IEnumerable<long>
{
public static readonly long[] Value=A277488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277488.Bytes);
public long this[int i]=>Value[i];

public static A277488Inst Instance=new A277488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277489
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,26L,224L,2244L,28496L,417976L,7122384L,136770960L,2937770472L,69626588976L,1806936836184L,50936933449752L,1550292926398680L,50661309325357824L,1769286989373994752L,BigInteger.Parse("65762170385201959680"),BigInteger.Parse("2591979585702305271552"),BigInteger.Parse("107982615297265761991680") };
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
public class A277489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277489Inst Instance=new A277489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277490
{
public static readonly BigInteger[] Value={ -1L,0L,2L,12L,72L,520L,5040L,67284L,1156736L,23655888L,549676800L,14216252380L,405068387328L,12624364306008L,427599019108352L,15646376279614500L,615155126821355520L,BigInteger.Parse("25861820048469628576"),BigInteger.Parse("1157706908035331457024"),BigInteger.Parse("54977324662490442177708"),BigInteger.Parse("2760439046217459138560000") };
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
public class A277490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277490Inst Instance=new A277490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277491
{
public static readonly BigInteger[] Value={ 1L,12L,120L,1128L,10344L,93864L,847848L,7642920L,68835432L,619715496L,5578225896L,50207178792L,451877192040L,4066945060008L,36602706866664L,329425167106344L,2964829725182568L,26683480411545000L,240151375243512552L,2161362583350043176L,BigInteger.Parse("19452264074784109416") };
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
public class A277491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277491Inst Instance=new A277491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277492
{
public static readonly long[] Value={ 3L,13L,96L,780L,6684L,58812L,523932L,4693884L,42158940L,379086396L,3410401308L,30688106748L,276170940636L,2485450385340L,22368701146524L,201316901032572L,1811846472148572L,16306595700758844L,146759271112516380L,1320833079235394556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277492Inst : IEnumerable<long>
{
public static readonly long[] Value=A277492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277492.Bytes);
public long this[int i]=>Value[i];

public static A277492Inst Instance=new A277492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277493
{
public static readonly long[] Value={ 1L,2L,10L,66L,504L,4216L,37548L,350090L,3380520L,33558024L,340670720L,3522993656L,37003723200L,393856445664L,4240313009272L,46109094112170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277493Inst : IEnumerable<long>
{
public static readonly long[] Value=A277493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277493.Bytes);
public long this[int i]=>Value[i];

public static A277493Inst Instance=new A277493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277494
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,10L,12L,14L,8L,16L,15L,22L,18L,26L,21L,20L,24L,34L,25L,38L,28L,30L,33L,46L,32L,35L,39L,27L,36L,58L,40L,62L,45L,44L,51L,42L,48L,74L,57L,52L,50L,82L,49L,86L,55L,54L,69L,94L,60L,56L,63L,68L,65L,106L,70L,66L,72L,76L,87L,118L,75L,122L,93L,77L,64L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277494Inst : IEnumerable<long>
{
public static readonly long[] Value=A277494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277494.Bytes);
public long this[int i]=>Value[i];

public static A277494Inst Instance=new A277494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277495
{
public static readonly long[] Value={ 1L,2L,2L,1L,5L,2L,3L,4L,3L,2L,3L,2L,3L,4L,6L,6L,7L,6L,4L,2L,3L,4L,5L,8L,4L,5L,3L,2L,4L,6L,6L,7L,9L,10L,8L,8L,9L,6L,4L,4L,5L,6L,3L,6L,5L,6L,7L,12L,5L,2L,4L,4L,5L,6L,5L,4L,6L,8L,10L,6L,6L,7L,3L,4L,2L,2L,3L,6L,9L,14L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277495Inst : IEnumerable<long>
{
public static readonly long[] Value=A277495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277495.Bytes);
public long this[int i]=>Value[i];

public static A277495Inst Instance=new A277495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277496
{
public static readonly long[] Value={ 3L,43L,909L,25264L,946088L,49916876L,3402999604L,295506405205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277496Inst : IEnumerable<long>
{
public static readonly long[] Value=A277496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277496.Bytes);
public long this[int i]=>Value[i];

public static A277496Inst Instance=new A277496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277497
{
public static readonly long[] Value={ 3L,49L,1020L,28666L,1099824L,57520786L,3882860433L,331811494082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277497Inst : IEnumerable<long>
{
public static readonly long[] Value=A277497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277497.Bytes);
public long this[int i]=>Value[i];

public static A277497Inst Instance=new A277497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277498
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,56L,536L,6528L,96592L,1683072L,33760576L,766283264L,19417068032L,543351873536L,16642224306176L,553782090473472L,19893884376859648L,767355755629215744L,BigInteger.Parse("31631864049541107712"),BigInteger.Parse("1387750771948607504384"),BigInteger.Parse("64561526675221208563712") };
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
public class A277498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277498Inst Instance=new A277498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277499
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,52L,476L,5646L,82368L,1426888L,28623376L,652516090L,16660233600L,470930272572L,14598765522368L,492441140292934L,17955574113204224L,703714660937658128L,BigInteger.Parse("29500170665998713088"),BigInteger.Parse("1317136516654501334898"),BigInteger.Parse("62399954043306802391040") };
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
public class A277499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277499Inst Instance=new A277499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277500
{
public static readonly BigInteger[] Value={ 0L,1L,2L,11L,80L,821L,10608L,167215L,3105024L,66433129L,1609025024L,43521156755L,1300287942656L,42528924900125L,1511407185512448L,57992816331075511L,2389444376908726272L,BigInteger.Parse("105219795048784564945"),BigInteger.Parse("4931495123285481881600"),BigInteger.Parse("245105773365008603770907") };
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
public class A277500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277500Inst Instance=new A277500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277501
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,48L,461L,5488L,79171L,1347328L,26396185L,585025024L,14473813311L,395433660416L,11824374817893L,384118189803520L,13470784014801787L,507233444671848448L,BigInteger.Parse("20411081546839908401"),BigInteger.Parse("874130806090067607552"),BigInteger.Parse("39696948293418345150327") };
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
public class A277501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277501Inst Instance=new A277501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277502
{
public static readonly BigInteger[] Value={ 0L,1L,2L,10L,72L,724L,9184L,142080L,2587392L,54290256L,1289277440L,34191270752L,1001513996288L,32113767783616L,1118831623585792L,42084750888906240L,1699836383279448064L,BigInteger.Parse("73377208318764134656"),BigInteger.Parse("3371248736937012363264"),BigInteger.Parse("164251735270613613412864") };
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
public class A277502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277502Inst Instance=new A277502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277503
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,48L,469L,5584L,80235L,1367040L,26840841L,595623680L,14752565807L,403579762688L,12084385256605L,393093330282496L,13804177426246995L,520496287836012544L,BigInteger.Parse("20973496057176404881"),BigInteger.Parse("899452315670554017792"),BigInteger.Parse("40903215737685386469847") };
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
public class A277503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277503Inst Instance=new A277503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277504
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,6L,6L,1L,5L,10L,18L,10L,1L,6L,15L,40L,45L,20L,1L,7L,21L,75L,136L,135L,36L,1L,8L,28L,126L,325L,544L,378L,72L,1L,9L,36L,196L,666L,1625L,2080L,1134L,136L,1L,10L,45L,288L,1225L,3996L,7875L,8320L,3321L,272L,1L,11L,55L,405L,2080L,8575L,23436L,39375L,32896L,9963L,528L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277504Inst : IEnumerable<long>
{
public static readonly long[] Value=A277504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277504.Bytes);
public long this[int i]=>Value[i];

public static A277504Inst Instance=new A277504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277505
{
public static readonly BigInteger[] Value={ 0L,1L,4L,21L,148L,1365L,15966L,229411L,3932440L,78438681L,1784386810L,45565679511L,1289796524820L,40065439945141L,1354630932486118L,49512390012682395L,1945119744809765296L,BigInteger.Parse("81728227537432878513"),BigInteger.Parse("3657019655412488345202"),BigInteger.Parse("173610723750748520091679") };
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
public class A277505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277505Inst Instance=new A277505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277506
{
public static readonly BigInteger[] Value={ 1L,2L,8L,51L,460L,5425L,79206L,1377985L,27801096L,637630353L,16376303530L,465451009441L,14501512561548L,491394769892377L,17991533604051294L,707766894441628785L,BigInteger.Parse("29771014384775612176"),BigInteger.Parse("1333347506427522171169"),BigInteger.Parse("63346663190991936656466"),BigInteger.Parse("3182006256289160385596833") };
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
public class A277506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277506Inst Instance=new A277506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277507
{
public static readonly BigInteger[] Value={ -1L,0L,0L,3L,28L,305L,3846L,57337L,998600L,20036529L,456403690L,11647754921L,329290975212L,10214585950153L,344897398385918L,12590837785019145L,494101941398352016L,BigInteger.Parse("20740772742716097377"),BigInteger.Parse("927276395603713539282"),BigInteger.Parse("43987299891665164562377"),BigInteger.Parse("2206610456287703987567540") };
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
public class A277507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277507Inst Instance=new A277507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277508
{
public static readonly BigInteger[] Value={ -1L,2L,-4L,15L,-44L,385L,-294L,32473L,280120L,8528049L,170757910L,4748977321L,132530188308L,4210910824393L,142940443542274L,5273270156096265L,208276214340505456L,8800344095155520353L,BigInteger.Parse("395536292522024420142"),BigInteger.Parse("18853858817276143333321"),BigInteger.Parse("949787282108877829653580") };
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
public class A277508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277508Inst Instance=new A277508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277509
{
public static readonly BigInteger[] Value={ 1L,0L,4L,15L,196L,2145L,33786L,587041L,12080888L,278692497L,7213075030L,205967845281L,6444486304884L,219096784628761L,8044651840755362L,317224112769528945L,13371158269397088496UL,BigInteger.Parse("599930571306586259745"),BigInteger.Parse("28547657791777984900014"),BigInteger.Parse("1436014157616531876023713") };
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
public class A277509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277509Inst Instance=new A277509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277510
{
public static readonly BigInteger[] Value={ -1L,2L,-2L,6L,8L,170L,1872L,29246L,519808L,10698642L,248787200L,6458737142L,185138721792L,5808233422394L,197952647108608L,7283047491096750L,287705410381709312L,12145740050403520034UL,BigInteger.Parse("545696709922799419392"),BigInteger.Parse("25998534614835587104742"),BigInteger.Parse("1309210567403228200960000") };
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
public class A277510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277510Inst Instance=new A277510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277511
{
public static readonly BigInteger[] Value={ 0L,1L,0L,9L,28L,485L,4866L,83587L,1428456L,30190617L,698093830L,18258392471L,523907661036L,16487285529013L,562892775847962L,20749534387671195L,820928954404107856L,BigInteger.Parse("34705399650797034929"),BigInteger.Parse("1561214366024349903246"),BigInteger.Parse("74464277343448593371167"),BigInteger.Parse("3753594453131028132576660") };
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
public class A277511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277511Inst Instance=new A277511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277512
{
public static readonly long[] Value={ 13L,88L,5708L,15095L,18300L,20718L,23424L,45625L,59638L,63958L,66438L,71747L,78239L,154992L,225235L,411285L,418434L,550190L,571439L,743873L,883958L,938420L,989479L,1169298L,1198004L,1256049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277512Inst : IEnumerable<long>
{
public static readonly long[] Value=A277512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277512.Bytes);
public long this[int i]=>Value[i];

public static A277512Inst Instance=new A277512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277513
{
public static readonly long[] Value={ 4L,12L,24L,16L,40L,80L,60L,240L,64L,84L,560L,448L,112L,1120L,1792L,256L,144L,2016L,5376L,2304L,180L,3360L,13440L,11520L,1024L,220L,5280L,29568L,42240L,11264L,264L,7920L,59136L,126720L,67584L,4096L,312L,11440L,109824L,329472L,292864L,53248L,364L,16016L,192192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277513Inst : IEnumerable<long>
{
public static readonly long[] Value=A277513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277513.Bytes);
public long this[int i]=>Value[i];

public static A277513Inst Instance=new A277513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277514
{
public static readonly long[] Value={ 4L,6L,8L,10L,7L,35L,11L,70L,30L,7L,129L,143L,10L,191L,458L,93L,11L,262L,1112L,605L,11L,370L,2209L,2513L,273L,8L,484L,4007L,7646L,2562L,10L,595L,6683L,19361L,12878L,938L,9L,765L,10697L,42633L,47555L,10311L,11L,917L,16103L,85860L,143382L,62541L,3183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277514Inst : IEnumerable<long>
{
public static readonly long[] Value=A277514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277514.Bytes);
public long this[int i]=>Value[i];

public static A277514Inst Instance=new A277514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277515
{
public static readonly long[] Value={ 3L,3L,3L,3L,7L,3L,3L,3L,3L,13L,3L,3L,3L,3L,3L,7L,3L,3L,3L,3L,11L,3L,3L,3L,3L,3L,19L,3L,3L,3L,3L,11L,3L,3L,3L,3L,3L,13L,3L,3L,3L,3L,7L,3L,3L,3L,3L,3L,5L,3L,3L,3L,3L,7L,3L,3L,3L,3L,7L,3L,3L,3L,3L,3L,7L,3L,3L,3L,3L,11L,3L,3L,3L,3L,3L,7L,3L,3L,3L,3L,13L,3L,3L,3L,3L,3L,7L,3L,3L,3L,3L,19L,3L,3L,3L,3L,3L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277515Inst : IEnumerable<long>
{
public static readonly long[] Value=A277515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277515.Bytes);
public long this[int i]=>Value[i];

public static A277515Inst Instance=new A277515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277516
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,5L,4L,2L,6L,0L,4L,2L,1L,5L,4L,3L,0L,2L,4L,4L,3L,6L,5L,3L,1L,0L,2L,6L,4L,6L,4L,2L,3L,5L,4L,5L,0L,5L,4L,3L,1L,7L,6L,4L,7L,5L,4L,2L,4L,0L,7L,6L,7L,6L,4L,3L,7L,6L,5L,3L,1L,5L,4L,4L,0L,8L,7L,8L,7L,6L,4L,2L,5L,4L,2L,8L,7L,6L,4L,4L,9L,0L,5L,3L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277516Inst : IEnumerable<long>
{
public static readonly long[] Value=A277516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277516.Bytes);
public long this[int i]=>Value[i];

public static A277516Inst Instance=new A277516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277517
{
public static readonly long[] Value={ 2L,4L,3L,8L,6L,5L,4L,4L,4L,16L,12L,10L,8L,8L,8L,7L,6L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,32L,24L,20L,16L,16L,16L,14L,12L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,9L,8L,7L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277517Inst : IEnumerable<long>
{
public static readonly long[] Value=A277517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277517.Bytes);
public long this[int i]=>Value[i];

public static A277517Inst Instance=new A277517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277518
{
public static readonly long[] Value={ 0L,2L,1L,3L,4L,5L,7L,9L,10L,6L,11L,13L,15L,8L,17L,19L,31L,33L,21L,12L,35L,23L,14L,37L,39L,25L,16L,51L,53L,55L,27L,18L,57L,59L,71L,73L,29L,30L,41L,75L,32L,77L,43L,79L,34L,91L,93L,45L,95L,36L,97L,99L,110L,47L,111L,49L,113L,61L,115L,112L,114L,117L,38L,119L,131L,116L,133L,135L,63L,137L,118L,139L,151L,130L,65L,153L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277518Inst : IEnumerable<long>
{
public static readonly long[] Value=A277518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277518.Bytes);
public long this[int i]=>Value[i];

public static A277518Inst Instance=new A277518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277519
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,20L,22L,21L,23L,24L,25L,26L,28L,27L,40L,42L,44L,29L,46L,48L,60L,62L,41L,43L,64L,45L,66L,68L,47L,80L,82L,84L,49L,86L,88L,200L,201L,61L,63L,202L,7L,204L,206L,65L,208L,203L,220L,9L,222L,224L,226L,10L,12L,14L,16L,18L,30L,205L,228L,207L,240L,242L,67L,244L,246L,69L,248L,260L,262L,32L,209L,264L,266L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277519Inst : IEnumerable<long>
{
public static readonly long[] Value=A277519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277519.Bytes);
public long this[int i]=>Value[i];

public static A277519Inst Instance=new A277519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277520
{
public static readonly long[] Value={ 1L,3L,25L,147L,1089L,20449L,48841L,312987L,55190041L,14322675L,100100025L,32065374675L,4546130625L,29873533563L,1859904071089L,4089135109921L,9399479144449L,22568149425822049L,1293753708921104809L,2835106739783283L,3289668853728536041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277520Inst : IEnumerable<long>
{
public static readonly long[] Value=A277520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277520.Bytes);
public long this[int i]=>Value[i];

public static A277520Inst Instance=new A277520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277521
{
public static readonly long[] Value={ 1L,6L,30L,66L,102L,210L,270L,318L,330L,420L,462L,510L,546L,570L,642L,672L,690L,714L,840L,870L,924L,930L,966L,1122L,1320L,1410L,1428L,1518L,1590L,1638L,1722L,1770L,1890L,1932L,2130L,2226L,2280L,2310L,2346L,2370L,2670L,2730L,2760L,2838L,2970L,2982L,3102L,3162L,3210L,3360L,3444L,3486L,3498L,3570L,3720L,3780L,3948L,3990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277521Inst : IEnumerable<long>
{
public static readonly long[] Value=A277521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277521.Bytes);
public long this[int i]=>Value[i];

public static A277521Inst Instance=new A277521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277522
{
public static readonly long[] Value={ 5L,6L,9L,2L,4L,5L,2L,0L,4L,4L,2L,6L,3L,4L,8L,0L,6L,1L,0L,6L,5L,3L,3L,0L,4L,7L,7L,8L,4L,1L,9L,6L,6L,9L,0L,5L,2L,6L,3L,8L,6L,5L,9L,7L,3L,1L,4L,6L,3L,0L,2L,7L,6L,4L,5L,4L,9L,8L,0L,1L,1L,6L,7L,9L,1L,8L,3L,1L,1L,5L,4L,2L,1L,1L,3L,4L,6L,7L,0L,8L,7L,6L,2L,3L,2L,4L,0L,6L,7L,4L,8L,7L,9L,2L,6L,3L,5L,0L,2L,4L,5L,1L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277522Inst : IEnumerable<long>
{
public static readonly long[] Value=A277522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277522.Bytes);
public long this[int i]=>Value[i];

public static A277522Inst Instance=new A277522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277523
{
public static readonly long[] Value={ 2L,2L,2L,1L,4L,0L,2L,1L,3L,6L,0L,1L,2L,2L,2L,1L,2L,6L,5L,5L,1L,5L,5L,3L,7L,3L,8L,5L,9L,6L,8L,0L,0L,3L,0L,8L,9L,5L,9L,1L,0L,8L,9L,7L,2L,6L,8L,6L,2L,8L,1L,5L,1L,7L,3L,8L,4L,7L,4L,4L,7L,7L,9L,8L,7L,0L,2L,1L,3L,9L,6L,9L,1L,7L,4L,7L,8L,5L,5L,1L,9L,0L,3L,9L,7L,5L,7L,2L,6L,5L,4L,2L,4L,2L,7L,1L,7L,8L,8L,4L,5L,2L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277523Inst : IEnumerable<long>
{
public static readonly long[] Value=A277523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277523.Bytes);
public long this[int i]=>Value[i];

public static A277523Inst Instance=new A277523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277524
{
public static readonly long[] Value={ 1L,9L,0L,1L,7L,1L,3L,9L,0L,7L,5L,2L,6L,0L,0L,3L,9L,8L,6L,2L,6L,2L,6L,3L,9L,9L,8L,2L,1L,2L,4L,6L,9L,9L,5L,1L,4L,4L,4L,6L,4L,8L,8L,5L,7L,4L,5L,2L,4L,0L,5L,0L,5L,3L,1L,6L,2L,0L,0L,0L,9L,0L,0L,9L,1L,3L,5L,1L,5L,9L,4L,3L,5L,4L,5L,0L,7L,5L,5L,4L,2L,9L,0L,3L,4L,9L,2L,6L,8L,4L,0L,1L,4L,2L,1L,2L,6L,0L,2L,6L,6L,8L,4L,7L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277524Inst : IEnumerable<long>
{
public static readonly long[] Value=A277524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277524.Bytes);
public long this[int i]=>Value[i];

public static A277524Inst Instance=new A277524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277525
{
public static readonly long[] Value={ 1L,7L,2L,9L,6L,3L,7L,6L,7L,7L,6L,7L,5L,5L,4L,3L,4L,1L,4L,4L,7L,5L,9L,9L,4L,3L,6L,6L,8L,6L,0L,8L,3L,4L,0L,4L,1L,1L,3L,7L,8L,5L,9L,2L,4L,8L,5L,8L,7L,6L,2L,4L,7L,5L,4L,3L,6L,2L,8L,4L,5L,2L,7L,3L,6L,5L,9L,6L,9L,2L,3L,4L,8L,6L,2L,8L,9L,4L,3L,3L,4L,5L,2L,1L,7L,5L,6L,7L,1L,2L,3L,8L,4L,8L,3L,8L,7L,0L,4L,5L,2L,4L,4L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277525Inst : IEnumerable<long>
{
public static readonly long[] Value=A277525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277525.Bytes);
public long this[int i]=>Value[i];

public static A277525Inst Instance=new A277525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277526
{
public static readonly long[] Value={ 4L,9L,2L,8L,5L,9L,0L,7L,6L,3L,7L,5L,8L,5L,1L,0L,1L,7L,7L,6L,0L,3L,3L,5L,1L,7L,8L,7L,8L,9L,2L,8L,5L,7L,1L,2L,5L,7L,9L,5L,7L,1L,4L,7L,8L,2L,5L,3L,8L,5L,0L,5L,4L,6L,8L,4L,6L,7L,2L,6L,6L,0L,0L,4L,7L,1L,2L,7L,6L,2L,0L,4L,1L,6L,3L,9L,6L,2L,1L,2L,9L,2L,1L,9L,5L,9L,8L,8L,5L,3L,1L,4L,8L,7L,9L,3L,7L,9L,1L,6L,2L,6L,4L,3L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277526Inst : IEnumerable<long>
{
public static readonly long[] Value=A277526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277526.Bytes);
public long this[int i]=>Value[i];

public static A277526Inst Instance=new A277526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277527
{
public static readonly long[] Value={ 2L,7L,7L,4L,4L,1L,3L,2L,0L,3L,5L,4L,0L,6L,1L,7L,9L,1L,0L,5L,8L,5L,6L,9L,5L,5L,1L,3L,9L,5L,9L,8L,4L,7L,5L,1L,4L,8L,8L,0L,3L,0L,9L,1L,5L,0L,5L,9L,4L,7L,0L,3L,9L,0L,8L,4L,1L,3L,5L,8L,3L,0L,8L,7L,8L,4L,7L,9L,7L,2L,0L,0L,0L,6L,0L,7L,2L,2L,5L,8L,9L,9L,7L,2L,5L,1L,5L,2L,7L,8L,1L,3L,3L,0L,5L,0L,1L,0L,8L,0L,0L,8L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277527Inst : IEnumerable<long>
{
public static readonly long[] Value=A277527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277527.Bytes);
public long this[int i]=>Value[i];

public static A277527Inst Instance=new A277527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277528
{
public static readonly long[] Value={ 4L,3L,4L,9L,0L,2L,8L,8L,5L,6L,7L,2L,8L,8L,3L,7L,8L,4L,8L,0L,0L,2L,2L,2L,5L,2L,1L,4L,0L,8L,3L,8L,9L,5L,1L,4L,9L,9L,1L,6L,9L,6L,1L,5L,3L,3L,9L,0L,0L,0L,4L,4L,3L,1L,4L,0L,1L,3L,9L,2L,2L,9L,5L,3L,7L,6L,1L,2L,6L,2L,8L,9L,6L,9L,8L,7L,1L,5L,7L,4L,4L,0L,8L,8L,5L,2L,1L,1L,6L,6L,7L,8L,1L,7L,3L,8L,1L,8L,5L,1L,7L,6L,7L,0L,9L,8L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277528Inst : IEnumerable<long>
{
public static readonly long[] Value=A277528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277528.Bytes);
public long this[int i]=>Value[i];

public static A277528Inst Instance=new A277528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277529
{
public static readonly long[] Value={ 5L,0L,1L,0L,9L,2L,7L,6L,2L,7L,5L,0L,3L,6L,6L,9L,6L,8L,9L,5L,8L,6L,8L,0L,1L,7L,2L,3L,5L,3L,2L,2L,9L,4L,5L,1L,2L,7L,2L,1L,8L,3L,9L,4L,2L,3L,8L,3L,2L,4L,2L,6L,2L,4L,4L,6L,0L,2L,8L,9L,9L,9L,1L,1L,8L,5L,8L,4L,6L,3L,2L,4L,1L,1L,0L,1L,8L,9L,6L,2L,0L,2L,8L,2L,1L,0L,6L,6L,7L,3L,8L,4L,1L,4L,3L,1L,6L,6L,8L,7L,3L,6L,1L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277529Inst : IEnumerable<long>
{
public static readonly long[] Value=A277529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277529.Bytes);
public long this[int i]=>Value[i];

public static A277529Inst Instance=new A277529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277530
{
public static readonly long[] Value={ 8L,4L,4L,6L,1L,7L,0L,8L,6L,7L,1L,0L,9L,3L,6L,1L,1L,9L,7L,5L,1L,5L,8L,2L,0L,7L,1L,1L,4L,9L,3L,8L,3L,2L,2L,3L,9L,5L,4L,6L,1L,0L,0L,2L,1L,7L,3L,6L,6L,2L,7L,5L,5L,1L,8L,4L,4L,1L,7L,2L,9L,4L,8L,3L,6L,5L,8L,0L,2L,4L,8L,4L,2L,5L,9L,8L,1L,7L,4L,6L,6L,3L,5L,1L,9L,8L,8L,5L,9L,6L,2L,2L,4L,9L,1L,5L,0L,1L,6L,9L,8L,4L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277530Inst : IEnumerable<long>
{
public static readonly long[] Value=A277530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277530.Bytes);
public long this[int i]=>Value[i];

public static A277530Inst Instance=new A277530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277531
{
public static readonly long[] Value={ 1L,4L,1L,0L,9L,5L,0L,8L,6L,0L,4L,5L,7L,8L,2L,5L,2L,1L,6L,6L,7L,4L,8L,0L,7L,9L,5L,6L,6L,6L,2L,1L,3L,8L,6L,1L,1L,5L,9L,2L,7L,6L,0L,7L,4L,9L,5L,2L,5L,0L,6L,8L,9L,5L,9L,1L,6L,1L,0L,1L,8L,4L,7L,0L,8L,2L,4L,0L,0L,4L,4L,5L,8L,4L,4L,8L,8L,7L,2L,4L,0L,0L,8L,9L,3L,2L,4L,1L,1L,6L,2L,1L,3L,3L,3L,3L,4L,9L,8L,0L,6L,7L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277531Inst : IEnumerable<long>
{
public static readonly long[] Value=A277531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277531.Bytes);
public long this[int i]=>Value[i];

public static A277531Inst Instance=new A277531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277532
{
public static readonly long[] Value={ 0L,1L,72L,2346L,3422L,3892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277532Inst : IEnumerable<long>
{
public static readonly long[] Value=A277532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277532.Bytes);
public long this[int i]=>Value[i];

public static A277532Inst Instance=new A277532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277533
{
public static readonly long[] Value={ 5L,77L,777L,0L,0L,333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277533Inst : IEnumerable<long>
{
public static readonly long[] Value=A277533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277533.Bytes);
public long this[int i]=>Value[i];

public static A277533Inst Instance=new A277533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277534
{
public static readonly long[] Value={ 5L,17L,0L,0L,65L,0L,0L,29L,65L,185L,0L,0L,169L,0L,0L,0L,221L,333L,0L,0L,273L,0L,0L,0L,157L,481L,0L,0L,1189L,0L,0L,641L,1353L,629L,0L,0L,1517L,0L,0L,425L,1681L,777L,0L,0L,1845L,0L,0L,0L,205L,925L,0L,0L,2173L,0L,0L,0L,2337L,1073L,0L,0L,2501L,0L,0L,0L,2665L,1221L,0L,0L,2829L,0L,0L,1405L,2993L,1369L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277534Inst : IEnumerable<long>
{
public static readonly long[] Value=A277534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277534.Bytes);
public long this[int i]=>Value[i];

public static A277534Inst Instance=new A277534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277535
{
public static readonly long[] Value={ 9L,9L,9L,9L,9L,9L,8L,3L,7L,2L,9L,7L,8L,0L,4L,9L,9L,5L,1L,0L,5L,9L,7L,3L,1L,7L,3L,2L,8L,1L,6L,0L,9L,6L,3L,1L,8L,5L,9L,5L,0L,2L,4L,4L,5L,9L,4L,5L,5L,3L,4L,6L,9L,0L,8L,3L,0L,2L,6L,4L,2L,5L,2L,2L,3L,0L,8L,2L,5L,3L,3L,4L,4L,6L,8L,5L,0L,3L,5L,2L,6L,1L,9L,3L,1L,1L,8L,8L,1L,7L,1L,0L,1L,0L,0L,0L,3L,1L,3L,7L,8L,3L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277535Inst : IEnumerable<long>
{
public static readonly long[] Value=A277535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277535.Bytes);
public long this[int i]=>Value[i];

public static A277535Inst Instance=new A277535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277536
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,3L,6L,0L,0L,8L,24L,24L,0L,0L,10L,170L,180L,120L,0L,0L,54L,900L,1980L,1440L,720L,0L,0L,-42L,6566L,19530L,21840L,12600L,5040L,0L,0L,944L,44072L,224112L,305760L,248640L,120960L,40320L,0L,0L,-5112L,365256L,2650536L,4818744L,4536000L,2993760L,1270080L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277536Inst : IEnumerable<long>
{
public static readonly long[] Value=A277536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277536.Bytes);
public long this[int i]=>Value[i];

public static A277536Inst Instance=new A277536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277537
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,2L,0L,0L,1L,1L,2L,3L,0L,0L,1L,1L,2L,9L,8L,0L,0L,1L,1L,2L,9L,32L,10L,0L,0L,1L,1L,2L,9L,56L,180L,54L,0L,0L,1L,1L,2L,9L,56L,360L,954L,-42L,0L,0L,1L,1L,2L,9L,56L,480L,2934L,6524L,944L,0L,0L,1L,1L,2L,9L,56L,480L,4374L,26054L,45016L,-5112L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277537Inst : IEnumerable<long>
{
public static readonly long[] Value=A277537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277537.Bytes);
public long this[int i]=>Value[i];

public static A277537Inst Instance=new A277537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277538
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,480L,5094L,65534L,944488L,15359184L,274118880L,5369469072L,114055774392L,2618129199504L,64505645760360L,1699067695202040L,47625773113856064L,1415693345589370368L,BigInteger.Parse("44474719907550007872"),BigInteger.Parse("1472352462644660486208"),BigInteger.Parse("51227002322058534554880") };
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
public class A277538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277538Inst Instance=new A277538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277539
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,480L,5094L,65534L,984808L,16629264L,312523680L,6425601072L,143775827832L,3471659156784L,90060216241800L,2496918043296840L,73703868906725184L,2307477802376274048L,BigInteger.Parse("76376765284713220032"),BigInteger.Parse("2664806795257276548288"),BigInteger.Parse("97747916619062963335680") };
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
public class A277539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277539Inst Instance=new A277539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277540
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,480L,5094L,65534L,984808L,16992144L,327038880L,6951172272L,160900135032L,4030551570864L,108477114581640L,3122444423175240L,95686679702270784L,3110711057099693568L,BigInteger.Parse("106921473349790826432"),BigInteger.Parse("3874480434910990168128"),BigInteger.Parse("147622208056015906586880") };
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
public class A277540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277540Inst Instance=new A277540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277541
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,480L,5094L,65534L,984808L,16992144L,330667680L,7130797872L,168564160632L,4321664793264L,119356965323400L,3528831476247240L,111173720474673984L,3716755785886791168L,BigInteger.Parse("131414199676568655552"),BigInteger.Parse("4899052003032070987968"),BigInteger.Parse("192050612714621129114880") };
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
public class A277541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277541Inst Instance=new A277541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277542
{
public static readonly long[] Value={ 1L,2L,27L,32L,125L,27L,343L,256L,729L,250L,1331L,864L,2197L,343L,3375L,2048L,4913L,1458L,6859L,4000L,9261L,1331L,12167L,6912L,15625L,4394L,19683L,10976L,24389L,3375L,29791L,16384L,35937L,9826L,42875L,23328L,50653L,6859L,59319L,32000L,68921L,18522L,79507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277542Inst : IEnumerable<long>
{
public static readonly long[] Value=A277542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277542.Bytes);
public long this[int i]=>Value[i];

public static A277542Inst Instance=new A277542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277543
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,1L,2L,3L,4L,3L,1L,2L,3L,4L,4L,1L,2L,3L,4L,1L,1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,1L,2L,3L,4L,3L,1L,2L,3L,4L,4L,1L,2L,3L,4L,2L,1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,1L,2L,3L,4L,3L,1L,2L,3L,4L,4L,1L,2L,3L,4L,3L,1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277543Inst : IEnumerable<long>
{
public static readonly long[] Value=A277543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277543.Bytes);
public long this[int i]=>Value[i];

public static A277543Inst Instance=new A277543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277544
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,2L,1L,2L,3L,4L,5L,3L,1L,2L,3L,4L,5L,4L,1L,2L,3L,4L,5L,5L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,2L,1L,2L,3L,4L,5L,3L,1L,2L,3L,4L,5L,4L,1L,2L,3L,4L,5L,5L,1L,2L,3L,4L,5L,2L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277544Inst : IEnumerable<long>
{
public static readonly long[] Value=A277544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277544.Bytes);
public long this[int i]=>Value[i];

public static A277544Inst Instance=new A277544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277545
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,2L,1L,2L,3L,4L,5L,6L,3L,1L,2L,3L,4L,5L,6L,4L,1L,2L,3L,4L,5L,6L,5L,1L,2L,3L,4L,5L,6L,6L,1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,2L,1L,2L,3L,4L,5L,6L,3L,1L,2L,3L,4L,5L,6L,4L,1L,2L,3L,4L,5L,6L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277545Inst : IEnumerable<long>
{
public static readonly long[] Value=A277545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277545.Bytes);
public long this[int i]=>Value[i];

public static A277545Inst Instance=new A277545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277546
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,2L,1L,2L,3L,4L,5L,6L,7L,3L,1L,2L,3L,4L,5L,6L,7L,4L,1L,2L,3L,4L,5L,6L,7L,5L,1L,2L,3L,4L,5L,6L,7L,6L,1L,2L,3L,4L,5L,6L,7L,7L,1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,2L,1L,2L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277546Inst : IEnumerable<long>
{
public static readonly long[] Value=A277546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277546.Bytes);
public long this[int i]=>Value[i];

public static A277546Inst Instance=new A277546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277547
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,1L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,2L,3L,4L,5L,6L,7L,8L,3L,1L,2L,3L,4L,5L,6L,7L,8L,4L,1L,2L,3L,4L,5L,6L,7L,8L,5L,1L,2L,3L,4L,5L,6L,7L,8L,6L,1L,2L,3L,4L,5L,6L,7L,8L,7L,1L,2L,3L,4L,5L,6L,7L,8L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277547Inst : IEnumerable<long>
{
public static readonly long[] Value=A277547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277547.Bytes);
public long this[int i]=>Value[i];

public static A277547Inst Instance=new A277547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277548
{
public static readonly long[] Value={ 4L,9L,14L,19L,20L,24L,29L,34L,39L,44L,45L,49L,54L,59L,64L,69L,70L,74L,79L,84L,89L,94L,95L,99L,100L,104L,109L,114L,119L,120L,124L,129L,134L,139L,144L,145L,149L,154L,159L,164L,169L,170L,174L,179L,184L,189L,194L,195L,199L,204L,209L,214L,219L,220L,224L,225L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277548Inst : IEnumerable<long>
{
public static readonly long[] Value=A277548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277548.Bytes);
public long this[int i]=>Value[i];

public static A277548Inst Instance=new A277548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277549
{
public static readonly long[] Value={ 1L,4L,5L,9L,13L,16L,17L,20L,21L,25L,29L,33L,36L,37L,41L,45L,49L,52L,53L,57L,61L,64L,65L,68L,69L,73L,77L,80L,81L,84L,85L,89L,93L,97L,100L,101L,105L,109L,113L,116L,117L,121L,125L,129L,132L,133L,137L,141L,144L,145L,148L,149L,153L,157L,161L,164L,165L,169L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277549Inst : IEnumerable<long>
{
public static readonly long[] Value=A277549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277549.Bytes);
public long this[int i]=>Value[i];

public static A277549Inst Instance=new A277549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277550
{
public static readonly long[] Value={ 1L,5L,6L,11L,16L,21L,25L,26L,30L,31L,36L,41L,46L,51L,55L,56L,61L,66L,71L,76L,80L,81L,86L,91L,96L,101L,105L,106L,111L,116L,121L,125L,126L,130L,131L,136L,141L,146L,150L,151L,155L,156L,161L,166L,171L,176L,180L,181L,186L,191L,196L,201L,205L,206L,211L,216L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277550Inst : IEnumerable<long>
{
public static readonly long[] Value=A277550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277550.Bytes);
public long this[int i]=>Value[i];

public static A277550Inst Instance=new A277550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277551
{
public static readonly long[] Value={ 2L,7L,10L,12L,17L,22L,27L,32L,35L,37L,42L,47L,50L,52L,57L,60L,62L,67L,72L,77L,82L,85L,87L,92L,97L,102L,107L,110L,112L,117L,122L,127L,132L,135L,137L,142L,147L,152L,157L,160L,162L,167L,172L,175L,177L,182L,185L,187L,192L,197L,202L,207L,210L,212L,217L,222L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277551Inst : IEnumerable<long>
{
public static readonly long[] Value=A277551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277551.Bytes);
public long this[int i]=>Value[i];

public static A277551Inst Instance=new A277551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277552
{
public static readonly long[] Value={ 3L,5L,11L,127L,1151L,1361L,19661L,31469L,156007L,360749L,370373L,1357333L,2010881L,17051887L,20831533L,191913031L,436273291L,2300942869L,3842611109L,4302407713L,10726905041L,25056082543L,304599509051L,461690510543L,1346294311331L,1408695494197L,1968188557063L,2614941711251L,13829048560417L,19581334193189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277552Inst : IEnumerable<long>
{
public static readonly long[] Value=A277552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277552.Bytes);
public long this[int i]=>Value[i];

public static A277552Inst Instance=new A277552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277553
{
public static readonly long[] Value={ 1L,20L,49L,169L,361L,500L,605L,961L,980L,1025L,1369L,1445L,1700L,1849L,2645L,3380L,3721L,4205L,4352L,4489L,4693L,5329L,6241L,7220L,8228L,8281L,8405L,9409L,9425L,10609L,11045L,11849L,11881L,12493L,12500L,14045L,14580L,14641L,15125L,16129L,17405L,17689L,18785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277553Inst : IEnumerable<long>
{
public static readonly long[] Value=A277553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277553.Bytes);
public long this[int i]=>Value[i];

public static A277553Inst Instance=new A277553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277554
{
public static readonly long[] Value={ 1L,2L,46L,2227L,6684830083L,12827743861L,151652531182L,155657642297L,3102126273955L,11006109076099L,50473807426174L,172794904196354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277554Inst : IEnumerable<long>
{
public static readonly long[] Value=A277554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277554.Bytes);
public long this[int i]=>Value[i];

public static A277554Inst Instance=new A277554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277555
{
public static readonly long[] Value={ 3L,8L,13L,15L,18L,23L,28L,33L,38L,40L,43L,48L,53L,58L,63L,65L,68L,73L,75L,78L,83L,88L,90L,93L,98L,103L,108L,113L,115L,118L,123L,128L,133L,138L,140L,143L,148L,153L,158L,163L,165L,168L,173L,178L,183L,188L,190L,193L,198L,200L,203L,208L,213L,215L,218L,223L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277555Inst : IEnumerable<long>
{
public static readonly long[] Value=A277555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277555.Bytes);
public long this[int i]=>Value[i];

public static A277555Inst Instance=new A277555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277556
{
public static readonly long[] Value={ 1L,0L,2L,2L,14L,42L,244L,1208L,7930L,52710L,405850L,3310702L,29742388L,285103536L,2943395390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277556Inst : IEnumerable<long>
{
public static readonly long[] Value=A277556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277556.Bytes);
public long this[int i]=>Value[i];

public static A277556Inst Instance=new A277556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277557
{
public static readonly long[] Value={ 8L,18L,19L,32L,33L,34L,50L,52L,53L,72L,73L,74L,75L,76L,98L,99L,100L,101L,102L,103L,128L,131L,133L,134L,162L,163L,164L,165L,166L,167L,168L,169L,200L,201L,202L,203L,204L,205L,206L,207L,208L,242L,244L,247L,248L,250L,251L,288L,289L,290L,291L,292L,293L,294L,295L,296L,297L,298L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277557Inst : IEnumerable<long>
{
public static readonly long[] Value=A277557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277557.Bytes);
public long this[int i]=>Value[i];

public static A277557Inst Instance=new A277557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277558
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,62L,42L,63L,41L,18L,40L,15L,39L,66L,38L,67L,37L,68L,36L,69L,35L,70L,34L,71L,33L,72L,32L,73L,31L,74L,30L,75L,29L,76L,28L,77L,27L,78L,26L,79L,133L,188L,132L,189L,131L,190L,130L,191L,129L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277558Inst : IEnumerable<long>
{
public static readonly long[] Value=A277558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277558.Bytes);
public long this[int i]=>Value[i];

public static A277558Inst Instance=new A277558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277559
{
public static readonly long[] Value={ 9L,2L,1L,7L,5L,3L,6L,7L,0L,0L,1L,9L,2L,3L,1L,5L,4L,4L,7L,0L,5L,1L,3L,1L,3L,6L,3L,2L,6L,5L,2L,4L,7L,9L,1L,9L,6L,0L,8L,2L,3L,9L,7L,9L,9L,6L,0L,3L,7L,9L,5L,4L,2L,9L,0L,3L,1L,1L,2L,0L,8L,4L,1L,2L,7L,3L,3L,3L,2L,2L,5L,3L,6L,7L,3L,5L,0L,3L,0L,2L,9L,0L,7L,5L,7L,4L,5L,7L,5L,1L,5L,2L,2L,5L,4L,3L,0L,7L,9L,3L,2L,4L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277559Inst : IEnumerable<long>
{
public static readonly long[] Value=A277559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277559.Bytes);
public long this[int i]=>Value[i];

public static A277559Inst Instance=new A277559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277560
{
public static readonly BigInteger[] Value={ 1L,11L,0L,1111L,0L,111111L,0L,11111111L,0L,1111111111L,0L,111111111111L,0L,11111111111111L,0L,1111111111111111L,0L,111111111111111111L,0L,11111111111111111111UL,0L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),0L,BigInteger.Parse("11111111111111111111111111"),0L };
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
public class A277560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277560Inst Instance=new A277560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277561
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,2L,2L,4L,4L,4L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,4L,4L,2L,4L,4L,4L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,4L,4L,4L,8L,8L,8L,4L,8L,4L,4L,2L,4L,4L,4L,4L,8L,4L,4L,2L,4L,4L,4L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,4L,4L,4L,8L,8L,8L,4L,8L,4L,4L,4L,8L,8L,8L,8L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277561Inst : IEnumerable<long>
{
public static readonly long[] Value=A277561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277561.Bytes);
public long this[int i]=>Value[i];

public static A277561Inst Instance=new A277561Inst();

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