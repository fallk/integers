using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A176364
{
public static readonly BigInteger[] Value={ 0L,226153980L,798920165762330040L,BigInteger.Parse("2822295814832482312327709940"),BigInteger.Parse("9970149719303180503641083029374964080"),BigInteger.Parse("35220930741174421456911021812718768924061809900") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176364Inst Instance=new A176364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176365
{
public static readonly BigInteger[] Value={ 1L,1L,11L,151L,15619L,655177L,27085381L,2330931341L,12157712239L,37307713155613L,339781108897078469L,BigInteger.Parse("75489558096433522049"),BigInteger.Parse("11482547005345338463969"),BigInteger.Parse("3607856726470666022715979"),BigInteger.Parse("18497593486903125823791655511"),BigInteger.Parse("520679973964725199436393399689") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176365Inst Instance=new A176365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176366
{
public static readonly BigInteger[] Value={ 2L,3L,40L,630L,72576L,3326400L,148262400L,13621608000L,75277762560L,243290200817664L,2322315553259520000L,BigInteger.Parse("538583682060103680000"),BigInteger.Parse("85226428809510912000000"),BigInteger.Parse("27777728189842735104000000"),BigInteger.Parse("147362699895661699242393600000"),BigInteger.Parse("4282728465717668134232064000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176366Inst Instance=new A176366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176367
{
public static readonly BigInteger[] Value={ 0L,8L,1008L,127000L,16000992L,2015997992L,253999746000L,32001951998008L,4031991952003008L,507998984000381000L,BigInteger.Parse("64003839992096002992"),BigInteger.Parse("8063975840020095995992"),BigInteger.Parse("1015996952002539999492000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176367Inst Instance=new A176367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176368
{
public static readonly BigInteger[] Value={ 1L,129L,33281L,8586369L,2215249921L,571525893249L,147451465208321L,38041906497853569L,9814664424981012481UL,BigInteger.Parse("2532145379738603366529"),BigInteger.Parse("653283693308134687552001"),BigInteger.Parse("168544660728119010785049729") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176368Inst Instance=new A176368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176369
{
public static readonly BigInteger[] Value={ 0L,16L,4128L,1065008L,274767936L,70889062480L,18289103351904L,4718517775728752L,1217359297034666112L,BigInteger.Parse("314073980117168128144"),BigInteger.Parse("81029869510932342395040"),BigInteger.Parse("20905392259840427169792176") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176369Inst Instance=new A176369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176370
{
public static readonly BigInteger[] Value={ 1L,65L,8449L,1098305L,142771201L,18559157825L,2412547746049L,313612647828545L,40767231669964801L,5299426504447595585L,BigInteger.Parse("688884678346517461249"),BigInteger.Parse("89549708758542822366785"),BigInteger.Parse("11640773253932220390220801") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176370Inst Instance=new A176370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176371
{
public static readonly long[] Value={ 31L,41L,71L,83L,281L,311L,431L,479L,733L,751L,797L,2011L,2857L,3163L,4373L,4397L,4943L,7541L,7577L,7583L,9413L,9491L,20533L,20731L,20771L,24151L,24547L,24767L,26249L,28979L,31121L,41201L,41609L,43321L,43391L,43753L,45641L,49459L,49463L,49811L,49891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176371Inst : IEnumerable<long>
{
public static readonly long[] Value=A176371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176371.Bytes);
public long this[int i]=>Value[i];

public static A176371Inst Instance=new A176371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176372
{
public static readonly BigInteger[] Value={ 0L,8L,1040L,135192L,17573920L,2284474408L,296964099120L,38603048411192L,5018099329355840L,652314309767848008L,BigInteger.Parse("84795842170490885200"),BigInteger.Parse("11022807167854047227992"),BigInteger.Parse("1432880135978855648753760") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176372Inst Instance=new A176372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176373
{
public static readonly BigInteger[] Value={ 1L,48842L,4771081927L,466058366908226L,BigInteger.Parse("45526445508292066657"),BigInteger.Parse("4447205302565943872414162"),BigInteger.Parse("434420802730325215724612934151"),BigInteger.Parse("42435961689461883070277145987192122"),BigInteger.Parse("4145314481238973783106627512888262311297") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176373Inst Instance=new A176373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176374
{
public static readonly BigInteger[] Value={ 0L,5967L,582880428L,56938091722785L,5561940551265649512L,BigInteger.Parse("543312600752895615207423"),BigInteger.Parse("53072948086383914724656258820"),BigInteger.Parse("5184377860327013725210426371365457"),BigInteger.Parse("506430766855111060647071374935807042768") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176374Inst Instance=new A176374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176375
{
public static readonly BigInteger[] Value={ 1L,7775L,120901249L,1880014414175L,29234224019520001L,BigInteger.Parse("454592181623521601375"),BigInteger.Parse("7068908395011536881861249"),BigInteger.Parse("109921525087837216889420820575"),BigInteger.Parse("1709279708046960327618956878080001") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176375Inst Instance=new A176375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176376
{
public static readonly BigInteger[] Value={ 0L,936L,14554800L,226327139064L,3519386997890400L,BigInteger.Parse("54726467590868580936"),BigInteger.Parse("850996567518619435664400"),BigInteger.Parse("13232996570188064633712839064") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176376Inst Instance=new A176376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176377
{
public static readonly BigInteger[] Value={ 1L,251L,126001L,63252251L,31752504001L,15939693756251L,8001694513134001L,4016834705899512251L,BigInteger.Parse("2016443020667042016001"),BigInteger.Parse("1012250379540149192520251"),BigInteger.Parse("508147674086134227603150001"),BigInteger.Parse("255089120140859842107588780251") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176377Inst Instance=new A176377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176378
{
public static readonly BigInteger[] Value={ 0L,30L,15060L,7560090L,3795150120L,1905157800150L,956385420525180L,480103575945840210L,BigInteger.Parse("241011038739391260240"),BigInteger.Parse("120987061343598466800270"),BigInteger.Parse("60735263783447690942475300"),BigInteger.Parse("30488981432229397254655800330") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176378Inst Instance=new A176378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176379
{
public static readonly long[] Value={ 2L,7L,2L,31L,2L,7L,11L,7L,19L,5L,5L,19L,2L,13L,13L,61L,11L,17L,61L,5L,5L,7L,139L,5L,19L,2L,103L,29L,7L,2L,109L,7L,59L,31L,41L,5L,5L,127L,13L,31L,5L,109L,2L,7L,41L,11L,2L,7L,101L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176379Inst : IEnumerable<long>
{
public static readonly long[] Value=A176379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176379.Bytes);
public long this[int i]=>Value[i];

public static A176379Inst Instance=new A176379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176380
{
public static readonly BigInteger[] Value={ 1L,3480L,24220799L,168576757560L,1173294208396801L,8166127521864977400L,BigInteger.Parse("56836246378886034307199"),BigInteger.Parse("395580266630919276913127640"),BigInteger.Parse("2753238598914951788429334067201") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176380Inst Instance=new A176380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176381
{
public static readonly BigInteger[] Value={ 0L,413L,2874480L,20006380387L,139244404619040L,969141036142138013L,BigInteger.Parse("6745221472304875951440"),BigInteger.Parse("46946740478100900479884387"),BigInteger.Parse("326749306982360795035119382080") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176381Inst Instance=new A176381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176382
{
public static readonly BigInteger[] Value={ 1L,2281249L,10408194000001L,BigInteger.Parse("47487364308614281249"),BigInteger.Parse("216661004683313632776000001"),BigInteger.Parse("988515400545561595548925838281249"),BigInteger.Parse("4510099537958107027564099725673746000001") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176382Inst Instance=new A176382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176383
{
public static readonly long[] Value={ 2L,2L,3L,8L,3L,8L,3L,5L,16L,9L,5L,16L,9L,5L,7L,128L,9L,5L,7L,128L,81L,5L,7L,256L,81L,25L,7L,256L,81L,25L,7L,11L,1024L,243L,25L,7L,11L,1024L,243L,25L,7L,11L,13L,2048L,243L,25L,49L,11L,13L,2048L,729L,125L,49L,11L,13L,32768L,729L,125L,49L,11L,13L,32768L,729L,125L,49L,11L,13L,17L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176383Inst : IEnumerable<long>
{
public static readonly long[] Value=A176383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176383.Bytes);
public long this[int i]=>Value[i];

public static A176383Inst Instance=new A176383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176384
{
public static readonly BigInteger[] Value={ 0L,267000L,1218186966000L,5557975596000801000L,BigInteger.Parse("25358252540801244373932000"),BigInteger.Parse("115696976500895037877980001335000"),BigInteger.Parse("527867223891355250275667198886560898000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176384Inst Instance=new A176384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176385
{
public static readonly long[] Value={ 4L,2L,6L,56L,32L,97L,6L,95L,176L,4L,32L,309L,68L,68L,194L,616L,175L,96L,1540L,4L,816L,14L,1540L,95L,840L,32L,5L,437L,50L,10336L,95L,5L,995L,976L,175L,14L,40L,570L,1976L,995L,1400L,294L,1994L,176L,544L,507L,328L,392L,77L,11020L,18905L,18050L,9995L,779L,4L,805L,669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176385Inst : IEnumerable<long>
{
public static readonly long[] Value=A176385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176385.Bytes);
public long this[int i]=>Value[i];

public static A176385Inst Instance=new A176385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176386
{
public static readonly BigInteger[] Value={ 1L,3699L,27365201L,202447753299L,1497708451540801L,11080046922051092499UL,BigInteger.Parse("81970185631625530766801"),BigInteger.Parse("606415422222718754561701299"),BigInteger.Parse("4486261211633487714621935443201") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176386Inst Instance=new A176386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176387
{
public static readonly BigInteger[] Value={ 0L,430L,3181140L,23534073290L,174105071018280L,1288029291859162150L,BigInteger.Parse("9528840527069010567420"),BigInteger.Parse("70494360931227248318611010"),BigInteger.Parse("521517272640378655992073684560") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176387Inst Instance=new A176387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176388
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,3L,5L,3L,1L,1L,11L,21L,21L,11L,1L,1L,6L,13L,16L,13L,6L,1L,1L,34L,76L,106L,106L,76L,34L,1L,1L,15L,33L,50L,56L,50L,33L,15L,1L,1L,112L,258L,402L,493L,493L,402L,258L,112L,1L,1L,40L,91L,146L,188L,204L,188L,146L,91L,40L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176388Inst : IEnumerable<long>
{
public static readonly long[] Value=A176388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176388.Bytes);
public long this[int i]=>Value[i];

public static A176388Inst Instance=new A176388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176389
{
public static readonly long[] Value={ 2L,2L,2L,1L,0L,1L,4L,-12L,-12L,4L,791L,0L,-120L,0L,791L,6L,16260L,-280L,-280L,16260L,6L,-41312053L,0L,364560L,0L,364560L,0L,-41312053L,8L,-3163111000L,-5544L,7035000L,7035000L,-5544L,-3163111000L,8L,383801047294219L,0L,-343384323744L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176389Inst : IEnumerable<long>
{
public static readonly long[] Value=A176389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176389.Bytes);
public long this[int i]=>Value[i];

public static A176389Inst Instance=new A176389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176390
{
public static readonly long[] Value={ 1L,1L,1L,1L,16L,1L,1L,273L,273L,1L,1L,4856L,6246L,4856L,1L,1L,95065L,134785L,134785L,95065L,1L,1L,2073408L,3094575L,3410240L,3094575L,2073408L,1L,1L,50255905L,77413889L,89782273L,89782273L,77413889L,50255905L,1L,1L,1345053808L,2116602172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176390Inst : IEnumerable<long>
{
public static readonly long[] Value=A176390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176390.Bytes);
public long this[int i]=>Value[i];

public static A176390Inst Instance=new A176390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176391
{
public static readonly long[] Value={ 1L,2L,12L,1396L,5147608L,14289569180818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176391Inst : IEnumerable<long>
{
public static readonly long[] Value=A176391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176391.Bytes);
public long this[int i]=>Value[i];

public static A176391Inst Instance=new A176391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176392
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,55L,55L,1L,1L,561L,609L,561L,1L,1L,7151L,7705L,7705L,7151L,1L,1L,109873L,117017L,117523L,117017L,109873L,1L,1L,1979503L,2089369L,2096465L,2096465L,2089369L,1979503L,1L,1L,40949569L,42929065L,43038883L,43045473L,43038883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176392Inst : IEnumerable<long>
{
public static readonly long[] Value=A176392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176392.Bytes);
public long this[int i]=>Value[i];

public static A176392Inst Instance=new A176392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176393
{
public static readonly long[] Value={ 1L,3L,9L,13L,17L,19L,21L,25L,29L,31L,33L,37L,41L,43L,45L,49L,51L,53L,55L,57L,61L,65L,67L,69L,71L,73L,77L,79L,81L,85L,89L,91L,93L,97L,99L,101L,103L,105L,109L,111L,113L,115L,117L,121L,125L,127L,129L,131L,133L,137L,139L,141L,145L,149L,151L,153L,155L,157L,161L,163L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176393Inst : IEnumerable<long>
{
public static readonly long[] Value=A176393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176393.Bytes);
public long this[int i]=>Value[i];

public static A176393Inst Instance=new A176393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176394
{
public static readonly long[] Value={ 6L,4L,6L,4L,1L,0L,1L,6L,1L,5L,1L,3L,7L,7L,5L,4L,5L,8L,7L,0L,5L,4L,8L,9L,2L,6L,8L,3L,0L,1L,1L,7L,4L,4L,7L,3L,3L,8L,8L,5L,6L,1L,0L,5L,0L,7L,6L,2L,0L,7L,6L,1L,2L,5L,6L,1L,1L,1L,6L,1L,3L,9L,5L,8L,9L,0L,3L,8L,6L,6L,0L,3L,3L,8L,1L,7L,6L,0L,0L,0L,7L,4L,1L,6L,2L,2L,9L,2L,3L,7L,3L,5L,1L,4L,4L,9L,7L,1L,5L,1L,3L,5L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176394Inst : IEnumerable<long>
{
public static readonly long[] Value=A176394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176394.Bytes);
public long this[int i]=>Value[i];

public static A176394Inst Instance=new A176394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176395
{
public static readonly long[] Value={ 6L,3L,1L,6L,6L,2L,4L,7L,9L,0L,3L,5L,5L,3L,9L,9L,8L,4L,9L,1L,1L,4L,9L,3L,2L,7L,3L,6L,6L,7L,0L,6L,8L,6L,6L,8L,3L,9L,2L,7L,0L,8L,8L,5L,4L,5L,5L,8L,9L,3L,5L,3L,5L,9L,7L,0L,5L,8L,6L,8L,2L,1L,4L,6L,1L,1L,6L,4L,8L,4L,6L,4L,2L,6L,0L,9L,0L,4L,3L,8L,4L,6L,7L,0L,8L,8L,4L,3L,3L,9L,9L,1L,2L,8L,2L,9L,0L,6L,5L,0L,9L,0L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176395Inst : IEnumerable<long>
{
public static readonly long[] Value=A176395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176395.Bytes);
public long this[int i]=>Value[i];

public static A176395Inst Instance=new A176395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176396
{
public static readonly long[] Value={ 6L,2L,4L,0L,3L,7L,0L,3L,4L,9L,2L,0L,3L,9L,3L,0L,1L,1L,5L,4L,8L,2L,9L,8L,3L,7L,1L,8L,0L,4L,3L,9L,9L,8L,3L,2L,8L,8L,5L,2L,6L,0L,2L,1L,5L,3L,5L,2L,9L,1L,7L,3L,2L,7L,4L,8L,5L,5L,6L,7L,7L,1L,9L,8L,9L,0L,4L,8L,0L,8L,6L,8L,8L,9L,2L,2L,0L,2L,2L,1L,8L,5L,7L,0L,0L,1L,8L,0L,4L,5L,3L,3L,0L,2L,8L,0L,5L,1L,1L,7L,8L,3L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176396Inst : IEnumerable<long>
{
public static readonly long[] Value=A176396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176396.Bytes);
public long this[int i]=>Value[i];

public static A176396Inst Instance=new A176396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176397
{
public static readonly long[] Value={ 6L,1L,9L,3L,7L,4L,3L,8L,8L,4L,5L,3L,4L,2L,6L,2L,3L,9L,9L,8L,1L,4L,0L,4L,9L,0L,3L,5L,3L,9L,6L,1L,2L,2L,7L,6L,8L,3L,1L,3L,4L,6L,9L,9L,4L,0L,8L,7L,5L,0L,8L,5L,3L,3L,4L,6L,4L,7L,3L,6L,7L,5L,2L,9L,2L,1L,2L,4L,7L,8L,9L,0L,5L,1L,7L,5L,2L,6L,8L,5L,8L,4L,5L,6L,9L,3L,1L,2L,4L,6L,2L,2L,8L,5L,1L,6L,7L,8L,3L,8L,7L,5L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176397Inst : IEnumerable<long>
{
public static readonly long[] Value=A176397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176397.Bytes);
public long this[int i]=>Value[i];

public static A176397Inst Instance=new A176397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176398
{
public static readonly long[] Value={ 6L,1L,6L,2L,2L,7L,7L,6L,6L,0L,1L,6L,8L,3L,7L,9L,3L,3L,1L,9L,9L,8L,8L,9L,3L,5L,4L,4L,4L,3L,2L,7L,1L,8L,5L,3L,3L,7L,1L,9L,5L,5L,5L,1L,3L,9L,3L,2L,5L,2L,1L,6L,8L,2L,6L,8L,5L,7L,5L,0L,4L,8L,5L,2L,7L,9L,2L,5L,9L,4L,4L,3L,8L,6L,3L,9L,2L,3L,8L,2L,2L,1L,3L,4L,4L,2L,4L,8L,1L,0L,8L,3L,7L,9L,3L,0L,0L,2L,9L,5L,1L,8L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176398Inst : IEnumerable<long>
{
public static readonly long[] Value=A176398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176398.Bytes);
public long this[int i]=>Value[i];

public static A176398Inst Instance=new A176398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176399
{
public static readonly long[] Value={ 6L,1L,3L,9L,6L,0L,8L,7L,1L,0L,8L,3L,3L,7L,0L,1L,5L,0L,9L,6L,0L,0L,2L,3L,3L,6L,9L,4L,4L,1L,3L,6L,5L,0L,1L,3L,0L,9L,3L,0L,8L,4L,6L,5L,3L,8L,5L,9L,9L,9L,0L,2L,3L,6L,5L,9L,7L,1L,1L,5L,5L,4L,2L,6L,8L,7L,7L,4L,2L,1L,2L,3L,5L,8L,0L,2L,9L,7L,4L,4L,4L,0L,1L,0L,0L,8L,7L,3L,8L,2L,4L,8L,8L,1L,1L,0L,3L,4L,6L,5L,4L,7L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176399Inst : IEnumerable<long>
{
public static readonly long[] Value=A176399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176399.Bytes);
public long this[int i]=>Value[i];

public static A176399Inst Instance=new A176399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176400
{
public static readonly long[] Value={ 2L,1L,9L,7L,7L,2L,6L,0L,9L,7L,5L,8L,3L,5L,9L,1L,0L,5L,6L,7L,2L,0L,1L,6L,3L,5L,8L,6L,0L,8L,9L,5L,5L,5L,0L,9L,1L,6L,5L,1L,5L,9L,2L,5L,7L,7L,0L,1L,9L,9L,3L,1L,6L,5L,6L,1L,7L,9L,8L,0L,8L,7L,9L,8L,8L,1L,4L,1L,9L,4L,8L,6L,5L,0L,6L,2L,0L,8L,2L,1L,0L,8L,0L,7L,0L,6L,1L,1L,6L,7L,7L,4L,1L,6L,7L,7L,2L,4L,2L,5L,8L,3L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176400Inst : IEnumerable<long>
{
public static readonly long[] Value=A176400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176400.Bytes);
public long this[int i]=>Value[i];

public static A176400Inst Instance=new A176400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176401
{
public static readonly long[] Value={ 6L,1L,2L,2L,4L,9L,8L,9L,9L,9L,1L,9L,9L,1L,9L,9L,1L,0L,2L,9L,2L,3L,4L,4L,6L,5L,6L,0L,4L,6L,9L,8L,9L,7L,2L,3L,0L,5L,3L,6L,4L,7L,9L,9L,8L,8L,9L,9L,5L,8L,2L,8L,1L,5L,4L,2L,2L,6L,4L,8L,5L,9L,6L,5L,3L,0L,4L,8L,0L,5L,6L,0L,0L,2L,9L,1L,7L,5L,7L,2L,5L,0L,3L,1L,6L,6L,6L,8L,0L,5L,6L,1L,1L,0L,6L,7L,0L,2L,9L,3L,5L,5L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176401Inst : IEnumerable<long>
{
public static readonly long[] Value=A176401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176401.Bytes);
public long this[int i]=>Value[i];

public static A176401Inst Instance=new A176401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176402
{
public static readonly long[] Value={ 6L,1L,0L,9L,1L,2L,6L,3L,5L,1L,0L,2L,9L,6L,0L,5L,0L,1L,5L,1L,8L,4L,8L,2L,5L,1L,8L,0L,7L,7L,3L,5L,1L,8L,9L,9L,4L,4L,2L,5L,4L,1L,3L,5L,6L,4L,7L,3L,0L,5L,5L,1L,5L,5L,7L,0L,1L,8L,7L,3L,2L,4L,3L,2L,8L,1L,5L,5L,9L,4L,8L,4L,9L,6L,0L,2L,4L,1L,6L,5L,5L,9L,4L,7L,1L,4L,0L,6L,8L,5L,4L,3L,0L,3L,9L,6L,0L,6L,7L,2L,0L,0L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176402Inst : IEnumerable<long>
{
public static readonly long[] Value=A176402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176402.Bytes);
public long this[int i]=>Value[i];

public static A176402Inst Instance=new A176402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176403
{
public static readonly long[] Value={ 6L,0L,9L,8L,3L,8L,6L,6L,7L,6L,9L,6L,5L,9L,3L,3L,5L,0L,8L,1L,4L,3L,4L,1L,2L,3L,1L,9L,8L,2L,5L,9L,1L,9L,6L,8L,8L,6L,6L,6L,3L,3L,7L,3L,6L,4L,2L,3L,3L,2L,7L,2L,6L,6L,1L,2L,7L,0L,0L,5L,9L,0L,1L,2L,8L,9L,0L,7L,8L,6L,4L,7L,3L,5L,4L,9L,5L,8L,3L,2L,2L,6L,8L,1L,5L,4L,2L,9L,9L,0L,1L,4L,8L,6L,9L,3L,8L,8L,1L,4L,3L,3L,3L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176403Inst : IEnumerable<long>
{
public static readonly long[] Value=A176403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176403.Bytes);
public long this[int i]=>Value[i];

public static A176403Inst Instance=new A176403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176404
{
public static readonly long[] Value={ 9L,15L,25L,33L,39L,49L,55L,57L,65L,87L,95L,111L,119L,121L,129L,143L,145L,159L,161L,169L,177L,183L,185L,201L,209L,215L,217L,247L,249L,265L,287L,289L,295L,303L,305L,319L,321L,327L,329L,335L,361L,377L,391L,393L,407L,415L,417L,447L,471L,473L,481L,489L,497L,505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176404Inst : IEnumerable<long>
{
public static readonly long[] Value=A176404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176404.Bytes);
public long this[int i]=>Value[i];

public static A176404Inst Instance=new A176404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176405
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176405Inst : IEnumerable<long>
{
public static readonly long[] Value=A176405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176405.Bytes);
public long this[int i]=>Value[i];

public static A176405Inst Instance=new A176405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176406
{
public static readonly long[] Value={ 7L,13L,19L,23L,31L,33L,37L,47L,49L,53L,55L,63L,67L,75L,83L,85L,89L,91L,93L,109L,113L,117L,119L,121L,127L,131L,139L,141L,143L,153L,157L,159L,167L,175L,181L,183L,185L,199L,201L,203L,207L,211L,213L,215L,217L,219L,233L,235L,245L,247L,251L,257L,263L,265L,285L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176406Inst : IEnumerable<long>
{
public static readonly long[] Value=A176406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176406.Bytes);
public long this[int i]=>Value[i];

public static A176406Inst Instance=new A176406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176407
{
public static readonly long[] Value={ 0L,0L,0L,3L,4L,5L,6L,7L,8L,9L,0L,0L,0L,3L,4L,5L,6L,7L,8L,9L,0L,0L,0L,3L,4L,5L,6L,7L,8L,9L,30L,3L,3L,33L,34L,35L,36L,37L,38L,39L,40L,4L,4L,43L,44L,45L,46L,47L,48L,49L,50L,5L,5L,53L,54L,55L,56L,57L,58L,59L,60L,6L,6L,63L,64L,65L,66L,67L,68L,69L,70L,7L,7L,73L,74L,75L,76L,77L,78L,79L,80L,8L,8L,83L,84L,85L,86L,87L,88L,89L,90L,9L,9L,93L,94L,95L,96L,97L,98L,99L,0L,0L,0L,3L,4L,5L,6L,7L,8L,9L,0L,0L,0L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176407Inst : IEnumerable<long>
{
public static readonly long[] Value=A176407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176407.Bytes);
public long this[int i]=>Value[i];

public static A176407Inst Instance=new A176407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176408
{
public static readonly long[] Value={ 1L,0L,3L,12L,75L,522L,4179L,37608L,376083L,4136910L,49642923L,645357996L,9035011947L,135525179202L,2168402867235L,36862848742992L,663531277373859L,12607094270103318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176408Inst : IEnumerable<long>
{
public static readonly long[] Value=A176408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176408.Bytes);
public long this[int i]=>Value[i];

public static A176408Inst Instance=new A176408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176409
{
public static readonly long[] Value={ 3L,6L,7L,9L,12L,14L,15L,18L,21L,24L,27L,28L,30L,33L,35L,36L,39L,42L,45L,48L,49L,51L,54L,56L,57L,60L,63L,66L,69L,70L,72L,75L,77L,78L,81L,84L,87L,90L,91L,93L,96L,98L,99L,102L,105L,108L,111L,112L,114L,117L,119L,120L,123L,126L,129L,132L,133L,135L,138L,140L,141L,144L,147L,150L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176409Inst : IEnumerable<long>
{
public static readonly long[] Value=A176409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176409.Bytes);
public long this[int i]=>Value[i];

public static A176409Inst Instance=new A176409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176410
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,-191L,2113L,-191L,1L,1L,1L,1L,1L,1L,1L,1L,7681L,-337919L,7681L,-337919L,7681L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-430079L,47738881L,-430079L,180203521L,-430079L,47738881L,-430079L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,30965761L,-6936330239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176410Inst : IEnumerable<long>
{
public static readonly long[] Value=A176410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176410.Bytes);
public long this[int i]=>Value[i];

public static A176410Inst Instance=new A176410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176411
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,-19L,-19L,1L,1L,-27L,-123L,-27L,1L,1L,89L,-191L,-191L,89L,1L,1L,57L,297L,57L,297L,57L,1L,1L,-1807L,-1471L,3233L,3233L,-1471L,-1807L,1L,1L,-1935L,-18959L,-1935L,24945L,-1935L,-18959L,-1935L,1L,1L,29729L,-9727L,-81151L,47873L,47873L,-81151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176411Inst : IEnumerable<long>
{
public static readonly long[] Value=A176411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176411.Bytes);
public long this[int i]=>Value[i];

public static A176411Inst Instance=new A176411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176412
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176412Inst : IEnumerable<long>
{
public static readonly long[] Value=A176412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176412.Bytes);
public long this[int i]=>Value[i];

public static A176412Inst Instance=new A176412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176413
{
public static readonly long[] Value={ 19L,57L,171L,513L,1539L,4617L,13851L,41553L,124659L,373977L,1121931L,3365793L,10097379L,30292137L,90876411L,272629233L,817887699L,2453663097L,7360989291L,22082967873L,66248903619L,198746710857L,596240132571L,1788720397713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176413Inst : IEnumerable<long>
{
public static readonly long[] Value=A176413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176413.Bytes);
public long this[int i]=>Value[i];

public static A176413Inst Instance=new A176413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176414
{
public static readonly long[] Value={ 7L,-6L,12L,-24L,48L,-96L,192L,-384L,768L,-1536L,3072L,-6144L,12288L,-24576L,49152L,-98304L,196608L,-393216L,786432L,-1572864L,3145728L,-6291456L,12582912L,-25165824L,50331648L,-100663296L,201326592L,-402653184L,805306368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176414Inst : IEnumerable<long>
{
public static readonly long[] Value=A176414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176414.Bytes);
public long this[int i]=>Value[i];

public static A176414Inst Instance=new A176414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176415
{
public static readonly long[] Value={ 7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176415Inst : IEnumerable<long>
{
public static readonly long[] Value=A176415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176415.Bytes);
public long this[int i]=>Value[i];

public static A176415Inst Instance=new A176415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176416
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,-1L,0L,-1L,0L,1L,1L,-1L,-1L,0L,-1L,0L,1L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,-1L,0L,1L,0L,1L,1L,-1L,-1L,0L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176416Inst : IEnumerable<long>
{
public static readonly long[] Value=A176416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176416.Bytes);
public long this[int i]=>Value[i];

public static A176416Inst Instance=new A176416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176417
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,9L,9L,1L,1L,67L,117L,67L,1L,1L,625L,1741L,1741L,625L,1L,1L,6841L,30529L,49501L,30529L,6841L,1L,1L,86401L,635041L,1695745L,1695745L,635041L,86401L,1L,1L,1244881L,15504481L,69911281L,115612993L,69911281L,15504481L,1244881L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176417Inst : IEnumerable<long>
{
public static readonly long[] Value=A176417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176417.Bytes);
public long this[int i]=>Value[i];

public static A176417Inst Instance=new A176417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176418
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,21L,21L,1L,1L,217L,497L,217L,1L,1L,2785L,14401L,14401L,2785L,1L,1L,42961L,527809L,1218961L,527809L,42961L,1L,1L,781921L,23866081L,133305985L,133305985L,23866081L,781921L,1L,1L,16490881L,1290574081L,18068561281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176418Inst : IEnumerable<long>
{
public static readonly long[] Value=A176418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176418.Bytes);
public long this[int i]=>Value[i];

public static A176418Inst Instance=new A176418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176419
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,37L,37L,1L,1L,487L,1405L,487L,1L,1L,8065L,69445L,69445L,8065L,1L,1L,163081L,4467745L,13564261L,4467745L,163081L,1L,1L,3926881L,357799681L,3486035233L,3486035233L,357799681L,3926881L,1L,1L,110058481L,34357076641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176419Inst : IEnumerable<long>
{
public static readonly long[] Value=A176419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176419.Bytes);
public long this[int i]=>Value[i];

public static A176419Inst Instance=new A176419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176420
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,12L,30L,12L,1L,1L,27L,146L,146L,27L,1L,1L,58L,637L,1376L,637L,58L,1L,1L,121L,2647L,11777L,11777L,2647L,121L,1L,1L,248L,10768L,97100L,200718L,97100L,10768L,248L,1L,1L,503L,43400L,787952L,3309622L,3309622L,787952L,43400L,503L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176420Inst : IEnumerable<long>
{
public static readonly long[] Value=A176420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176420.Bytes);
public long this[int i]=>Value[i];

public static A176420Inst Instance=new A176420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176421
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,11L,11L,1L,1L,37L,125L,37L,1L,1L,117L,1201L,1201L,117L,1L,1L,359L,10997L,33861L,10997L,359L,1L,1L,1087L,99443L,925737L,925737L,99443L,1087L,1L,1L,3273L,896233L,25095225L,75913153L,25095225L,896233L,3273L,1L,1L,9833L,8069585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176421Inst : IEnumerable<long>
{
public static readonly long[] Value=A176421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176421.Bytes);
public long this[int i]=>Value[i];

public static A176421Inst Instance=new A176421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176422
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,19L,19L,1L,1L,82L,352L,82L,1L,1L,337L,5788L,5788L,337L,1L,1L,1360L,93079L,376786L,93079L,1360L,1L,1L,5455L,1490833L,24208579L,24208579L,1490833L,5455L,1L,1L,21838L,23859082L,1550842030L,6221613472L,1550842030L,23859082L,21838L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176422Inst : IEnumerable<long>
{
public static readonly long[] Value=A176422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176422.Bytes);
public long this[int i]=>Value[i];

public static A176422Inst Instance=new A176422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176423
{
public static readonly long[] Value={ 3L,6L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176423Inst : IEnumerable<long>
{
public static readonly long[] Value=A176423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176423.Bytes);
public long this[int i]=>Value[i];

public static A176423Inst Instance=new A176423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176424
{
public static readonly long[] Value={ 1L,3L,6L,23L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176424Inst : IEnumerable<long>
{
public static readonly long[] Value=A176424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176424.Bytes);
public long this[int i]=>Value[i];

public static A176424Inst Instance=new A176424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176425
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,23L,53L,132L,359L,1068L,3386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176425Inst : IEnumerable<long>
{
public static readonly long[] Value=A176425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176425.Bytes);
public long this[int i]=>Value[i];

public static A176425Inst Instance=new A176425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176426
{
public static readonly long[] Value={ 1L,1L,4L,9L,7L,0L,5L,0L,8L,8L,1L,2L,6L,6L,9L,0L,2L,1L,5L,7L,4L,0L,6L,3L,3L,4L,4L,2L,8L,9L,5L,9L,1L,6L,5L,9L,1L,7L,3L,3L,4L,7L,0L,4L,1L,9L,1L,2L,3L,3L,9L,8L,8L,2L,3L,7L,0L,0L,2L,3L,4L,7L,2L,6L,6L,8L,9L,9L,8L,5L,5L,8L,6L,6L,4L,4L,0L,6L,1L,3L,4L,8L,6L,2L,1L,8L,5L,5L,8L,6L,5L,2L,8L,2L,9L,9L,8L,7L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176426Inst : IEnumerable<long>
{
public static readonly long[] Value=A176426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176426.Bytes);
public long this[int i]=>Value[i];

public static A176426Inst Instance=new A176426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176427
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,4L,4L,1L,1L,5L,8L,8L,5L,1L,1L,6L,111L,374L,111L,6L,1L,1L,7L,1041L,8003L,8003L,1041L,7L,1L,1L,8L,6982L,106076L,245384L,106076L,6982L,8L,1L,1L,9L,39030L,1120878L,5309140L,5309140L,1120878L,39030L,9L,1L,1L,10L,195865L,10491942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176427Inst : IEnumerable<long>
{
public static readonly long[] Value=A176427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176427.Bytes);
public long this[int i]=>Value[i];

public static A176427Inst Instance=new A176427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176428
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,15L,15L,1L,1L,54L,194L,54L,1L,1L,185L,2118L,2118L,185L,1L,1L,608L,20831L,65344L,20831L,608L,1L,1L,1939L,194633L,1835923L,1835923L,194633L,1939L,1L,1L,6058L,1777912L,50102326L,151670254L,50102326L,1777912L,6058L,1L,1L,18669L,16091400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176428Inst : IEnumerable<long>
{
public static readonly long[] Value=A176428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176428.Bytes);
public long this[int i]=>Value[i];

public static A176428Inst Instance=new A176428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176429
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,31L,31L,1L,1L,144L,648L,144L,1L,1L,625L,11292L,11292L,625L,1L,1L,2610L,184995L,751194L,184995L,2610L,1L,1L,10675L,2977413L,48401607L,48401607L,2977413L,10675L,1L,1L,43188L,47703610L,3101595936L,12443070892L,3101595936L,47703610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176429Inst : IEnumerable<long>
{
public static readonly long[] Value=A176429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176429.Bytes);
public long this[int i]=>Value[i];

public static A176429Inst Instance=new A176429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176430
{
public static readonly BigInteger[] Value={ 3L,21L,903L,1631721L,5325028475403L,BigInteger.Parse("56711856527710922180500221"),BigInteger.Parse("82753323662259982099234097722219590008756576353188748920925694383267934319786203404455994065868822592721") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176430Inst Instance=new A176430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176431
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,5L,3L,1L,9L,5L,1L,1L,16L,9L,2L,1L,28L,16L,4L,2L,50L,28L,7L,4L,89L,50L,12L,7L,1L,159L,89L,22L,12L,2L,1L,285L,159L,39L,22L,3L,2L,510L,285L,70L,39L,22L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176431Inst : IEnumerable<long>
{
public static readonly long[] Value=A176431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176431.Bytes);
public long this[int i]=>Value[i];

public static A176431Inst Instance=new A176431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176432
{
public static readonly BigInteger[] Value={ 4L,295L,1123804L,426617588624L,BigInteger.Parse("26305269856043508288"),BigInteger.Parse("389245361792549353494110384128"),BigInteger.Parse("1914052488896530295354369845193677065142272") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176432Inst Instance=new A176432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176433
{
public static readonly long[] Value={ 1L,1L,3L,8L,15L,35L,96L,186L,419L,1035L,2021L,4353L,10171L,19721L,41466L,93118L,180018L,371539L,813425L,1566398L,3194133L,6859558L,13179004L,26617619L,56371355L,108060479L,216736146L,453947049L,868857655L,1732792511L,3598157885L,6877348410L,13655273038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176433Inst : IEnumerable<long>
{
public static readonly long[] Value=A176433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176433.Bytes);
public long this[int i]=>Value[i];

public static A176433Inst Instance=new A176433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176434
{
public static readonly long[] Value={ 7L,4L,6L,8L,6L,2L,6L,9L,6L,6L,5L,9L,6L,8L,8L,5L,8L,8L,5L,7L,5L,2L,4L,2L,3L,6L,3L,0L,4L,5L,8L,8L,9L,0L,6L,3L,8L,5L,6L,5L,3L,8L,8L,7L,7L,4L,6L,2L,3L,6L,7L,5L,2L,7L,0L,5L,5L,2L,5L,0L,1L,6L,8L,8L,8L,0L,1L,6L,0L,3L,2L,3L,4L,8L,4L,5L,4L,2L,5L,4L,4L,1L,6L,4L,0L,5L,8L,9L,3L,2L,9L,7L,1L,1L,8L,1L,5L,4L,1L,5L,9L,2L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176434Inst : IEnumerable<long>
{
public static readonly long[] Value=A176434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176434.Bytes);
public long this[int i]=>Value[i];

public static A176434Inst Instance=new A176434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176435
{
public static readonly long[] Value={ 7L,3L,1L,8L,8L,1L,3L,0L,7L,9L,1L,2L,9L,8L,6L,6L,6L,7L,2L,1L,5L,6L,7L,0L,5L,9L,9L,4L,7L,7L,3L,3L,4L,0L,4L,0L,7L,4L,8L,7L,0L,4L,7L,1L,4L,7L,3L,0L,6L,6L,4L,3L,2L,5L,2L,1L,7L,2L,7L,0L,1L,7L,6L,9L,9L,2L,2L,3L,9L,0L,3L,5L,4L,6L,2L,3L,1L,4L,2L,4L,0L,5L,5L,0L,3L,6L,3L,4L,6L,3L,2L,9L,1L,1L,2L,0L,4L,1L,9L,3L,8L,9L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176435Inst : IEnumerable<long>
{
public static readonly long[] Value=A176435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176435.Bytes);
public long this[int i]=>Value[i];

public static A176435Inst Instance=new A176435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176436
{
public static readonly long[] Value={ 7L,2L,4L,1L,6L,5L,7L,3L,8L,6L,7L,7L,3L,9L,4L,1L,3L,8L,5L,5L,8L,3L,7L,4L,8L,7L,3L,2L,3L,1L,6L,5L,4L,9L,3L,0L,1L,7L,5L,6L,0L,1L,9L,8L,0L,7L,7L,7L,8L,7L,2L,6L,9L,4L,6L,3L,0L,3L,7L,4L,5L,4L,6L,7L,3L,2L,0L,0L,3L,5L,1L,5L,6L,3L,0L,6L,9L,3L,9L,0L,2L,7L,9L,7L,6L,8L,0L,9L,8L,9L,5L,1L,9L,4L,3L,7L,9L,5L,7L,1L,5L,0L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176436Inst : IEnumerable<long>
{
public static readonly long[] Value=A176436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176436.Bytes);
public long this[int i]=>Value[i];

public static A176436Inst Instance=new A176436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176437
{
public static readonly long[] Value={ 7L,1L,9L,4L,5L,9L,0L,6L,4L,0L,3L,8L,2L,2L,3L,3L,1L,9L,9L,1L,6L,3L,5L,6L,1L,1L,5L,9L,9L,7L,9L,7L,1L,4L,2L,0L,5L,6L,5L,1L,5L,9L,7L,4L,2L,2L,3L,1L,7L,1L,5L,5L,8L,7L,4L,6L,3L,9L,0L,6L,4L,1L,8L,8L,8L,4L,9L,2L,6L,6L,0L,6L,6L,7L,2L,5L,1L,5L,9L,4L,7L,0L,2L,0L,9L,0L,3L,0L,4L,0L,6L,0L,5L,4L,4L,6L,5L,2L,9L,0L,3L,8L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176437Inst : IEnumerable<long>
{
public static readonly long[] Value=A176437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176437.Bytes);
public long this[int i]=>Value[i];

public static A176437Inst Instance=new A176437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176438
{
public static readonly long[] Value={ 7L,1L,6L,2L,8L,7L,6L,8L,2L,9L,3L,0L,5L,9L,8L,5L,0L,9L,4L,5L,3L,3L,6L,0L,5L,9L,7L,6L,8L,1L,5L,9L,2L,5L,1L,5L,2L,7L,5L,2L,6L,5L,4L,2L,9L,5L,0L,3L,3L,2L,1L,9L,4L,2L,6L,9L,6L,6L,3L,4L,7L,9L,9L,8L,0L,2L,3L,6L,5L,8L,1L,0L,8L,4L,3L,6L,8L,0L,3L,5L,1L,3L,4L,5L,1L,0L,1L,9L,4L,6L,2L,3L,6L,1L,2L,8L,7L,3L,7L,6L,3L,8L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176438Inst : IEnumerable<long>
{
public static readonly long[] Value=A176438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176438.Bytes);
public long this[int i]=>Value[i];

public static A176438Inst Instance=new A176438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176439
{
public static readonly long[] Value={ 7L,1L,4L,0L,0L,5L,4L,9L,4L,4L,6L,4L,0L,2L,5L,9L,1L,3L,5L,5L,4L,8L,6L,5L,1L,2L,4L,5L,7L,6L,3L,5L,1L,6L,3L,9L,6L,8L,8L,8L,8L,3L,4L,8L,4L,1L,2L,8L,8L,2L,3L,8L,7L,1L,9L,1L,8L,9L,0L,9L,0L,8L,9L,5L,6L,4L,2L,0L,5L,7L,8L,6L,9L,3L,1L,2L,4L,5L,2L,5L,9L,1L,6L,6L,4L,7L,8L,9L,7L,0L,4L,5L,4L,0L,4L,6L,3L,3L,7L,6L,0L,9L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176439Inst : IEnumerable<long>
{
public static readonly long[] Value=A176439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176439.Bytes);
public long this[int i]=>Value[i];

public static A176439Inst Instance=new A176439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176440
{
public static readonly long[] Value={ 7L,1L,2L,2L,8L,4L,4L,1L,8L,6L,5L,4L,7L,3L,5L,9L,6L,4L,3L,4L,2L,9L,6L,6L,6L,0L,3L,9L,2L,9L,2L,4L,4L,2L,9L,3L,0L,7L,8L,5L,0L,3L,3L,2L,1L,8L,6L,8L,9L,7L,4L,3L,2L,7L,2L,1L,7L,3L,9L,8L,1L,2L,0L,1L,7L,7L,9L,5L,3L,6L,0L,9L,3L,1L,6L,3L,4L,2L,0L,1L,0L,5L,4L,2L,8L,1L,4L,0L,7L,9L,8L,0L,0L,0L,9L,0L,4L,3L,7L,4L,4L,3L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176440Inst : IEnumerable<long>
{
public static readonly long[] Value=A176440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176440.Bytes);
public long this[int i]=>Value[i];

public static A176440Inst Instance=new A176440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176441
{
public static readonly long[] Value={ 1L,4L,4L,9L,1L,3L,7L,6L,7L,4L,6L,1L,8L,9L,4L,3L,8L,5L,7L,3L,7L,1L,8L,6L,6L,4L,1L,5L,7L,1L,6L,9L,7L,7L,1L,7L,2L,3L,1L,4L,0L,1L,3L,2L,8L,7L,4L,7L,5L,8L,9L,7L,3L,0L,8L,8L,6L,9L,5L,9L,2L,4L,8L,0L,7L,1L,1L,8L,1L,4L,4L,3L,7L,2L,6L,5L,3L,6L,8L,0L,4L,2L,1L,7L,1L,2L,5L,6L,3L,1L,9L,2L,0L,0L,3L,6L,1L,7L,4L,9L,7L,7L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176441Inst : IEnumerable<long>
{
public static readonly long[] Value=A176441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176441.Bytes);
public long this[int i]=>Value[i];

public static A176441Inst Instance=new A176441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176442
{
public static readonly long[] Value={ 7L,1L,0L,9L,4L,0L,1L,3L,0L,4L,6L,1L,7L,9L,5L,2L,5L,3L,3L,6L,3L,1L,0L,3L,3L,5L,1L,4L,4L,6L,5L,1L,9L,6L,2L,1L,6L,2L,4L,1L,5L,5L,2L,9L,2L,2L,7L,9L,7L,7L,6L,2L,9L,7L,7L,4L,9L,4L,0L,2L,1L,2L,7L,3L,4L,8L,4L,8L,7L,9L,4L,5L,6L,3L,0L,7L,0L,3L,7L,8L,2L,6L,6L,2L,9L,8L,7L,3L,3L,0L,9L,6L,9L,6L,2L,1L,7L,4L,9L,3L,3L,7L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176442Inst : IEnumerable<long>
{
public static readonly long[] Value=A176442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176442.Bytes);
public long this[int i]=>Value[i];

public static A176442Inst Instance=new A176442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176443
{
public static readonly long[] Value={ 2L,1L,6L,5L,6L,4L,0L,7L,8L,2L,7L,7L,0L,7L,7L,1L,5L,2L,0L,1L,7L,8L,6L,2L,0L,1L,0L,8L,6L,7L,9L,1L,1L,7L,7L,2L,9L,7L,4L,4L,9L,3L,1L,7L,5L,3L,6L,7L,8L,6L,5L,7L,7L,8L,6L,4L,9L,6L,4L,1L,2L,7L,6L,4L,0L,9L,0L,9L,2L,7L,6L,7L,3L,7L,8L,4L,2L,2L,2L,6L,9L,5L,9L,7L,7L,9L,2L,3L,9L,8L,5L,8L,1L,7L,7L,3L,0L,4L,9L,6L,0L,2L,6L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176443Inst : IEnumerable<long>
{
public static readonly long[] Value=A176443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176443.Bytes);
public long this[int i]=>Value[i];

public static A176443Inst Instance=new A176443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176444
{
public static readonly long[] Value={ 7L,0L,9L,8L,6L,1L,0L,8L,4L,3L,0L,8L,9L,3L,1L,6L,3L,1L,9L,4L,1L,2L,8L,7L,1L,6L,4L,5L,5L,7L,7L,7L,2L,9L,1L,0L,1L,4L,5L,4L,9L,1L,1L,9L,1L,9L,8L,5L,9L,9L,1L,5L,4L,4L,0L,6L,2L,6L,0L,2L,6L,7L,3L,6L,5L,5L,5L,1L,8L,6L,5L,6L,0L,2L,6L,7L,0L,3L,2L,2L,1L,0L,0L,9L,5L,2L,2L,9L,0L,0L,2L,1L,3L,9L,1L,1L,3L,1L,6L,8L,6L,9L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176444Inst : IEnumerable<long>
{
public static readonly long[] Value=A176444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176444.Bytes);
public long this[int i]=>Value[i];

public static A176444Inst Instance=new A176444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176445
{
public static readonly long[] Value={ 3L,5L,9L,8L,6L,1L,0L,8L,4L,3L,0L,8L,9L,3L,1L,6L,3L,1L,9L,4L,1L,2L,8L,7L,1L,6L,4L,5L,5L,7L,7L,7L,2L,9L,1L,0L,1L,4L,5L,4L,9L,1L,1L,9L,1L,9L,8L,5L,9L,9L,1L,5L,4L,4L,0L,6L,2L,6L,0L,2L,6L,7L,3L,6L,5L,5L,5L,1L,8L,6L,5L,6L,0L,2L,6L,7L,0L,3L,2L,2L,1L,0L,0L,9L,5L,2L,2L,9L,0L,0L,2L,1L,3L,9L,1L,1L,3L,1L,6L,8L,6L,9L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176445Inst : IEnumerable<long>
{
public static readonly long[] Value=A176445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176445.Bytes);
public long this[int i]=>Value[i];

public static A176445Inst Instance=new A176445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176446
{
public static readonly BigInteger[] Value={ 1L,21L,8841L,1563274461L,BigInteger.Parse("48876540809860084881"),BigInteger.Parse("47778324830758366441099687810020355768101"),BigInteger.Parse("45655366472669229704532780257129479597227844595083706917185803648786109654138692121") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176446Inst Instance=new A176446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176447
{
public static readonly long[] Value={ 0L,1L,-1L,3L,-2L,5L,-3L,7L,-4L,9L,-5L,11L,-6L,13L,-7L,15L,-8L,17L,-9L,19L,-10L,21L,-11L,23L,-12L,25L,-13L,27L,-14L,29L,-15L,31L,-16L,33L,-17L,35L,-18L,37L,-19L,39L,-20L,41L,-21L,43L,-22L,45L,-23L,47L,-24L,49L,-25L,51L,-26L,53L,-27L,55L,-28L,57L,-29L,59L,-30L,61L,-31L,63L,-32L,65L,-33L,67L,-34L,69L,-35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176447Inst : IEnumerable<long>
{
public static readonly long[] Value=A176447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176447.Bytes);
public long this[int i]=>Value[i];

public static A176447Inst Instance=new A176447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176448
{
public static readonly long[] Value={ 5L,12L,26L,54L,110L,222L,446L,894L,1790L,3582L,7166L,14334L,28670L,57342L,114686L,229374L,458750L,917502L,1835006L,3670014L,7340030L,14680062L,29360126L,58720254L,117440510L,234881022L,469762046L,939524094L,1879048190L,3758096382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176448Inst : IEnumerable<long>
{
public static readonly long[] Value=A176448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176448.Bytes);
public long this[int i]=>Value[i];

public static A176448Inst Instance=new A176448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176449
{
public static readonly long[] Value={ 7L,16L,34L,70L,142L,286L,574L,1150L,2302L,4606L,9214L,18430L,36862L,73726L,147454L,294910L,589822L,1179646L,2359294L,4718590L,9437182L,18874366L,37748734L,75497470L,150994942L,301989886L,603979774L,1207959550L,2415919102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176449Inst : IEnumerable<long>
{
public static readonly long[] Value=A176449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176449.Bytes);
public long this[int i]=>Value[i];

public static A176449Inst Instance=new A176449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176450
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,21L,54L,73L,187L,345L,768L,955L,4989L,5620L,12347L,30326L,84807L,92518L,544421L,572016L,2390850L,3811427L,6182184L,6546907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176450Inst : IEnumerable<long>
{
public static readonly long[] Value=A176450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176450.Bytes);
public long this[int i]=>Value[i];

public static A176450Inst Instance=new A176450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176451
{
public static readonly long[] Value={ 2L,1L,1L,0L,2L,0L,2L,0L,1L,0L,2L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,2L,0L,1L,2L,0L,1L,1L,0L,0L,1L,0L,0L,0L,3L,2L,1L,0L,0L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,0L,2L,1L,0L,0L,1L,1L,1L,0L,2L,0L,0L,2L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,3L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176451Inst : IEnumerable<long>
{
public static readonly long[] Value=A176451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176451.Bytes);
public long this[int i]=>Value[i];

public static A176451Inst Instance=new A176451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176452
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,2L,1L,7L,4L,2L,13L,7L,4L,1L,25L,13L,7L,2L,1L,48L,25L,13L,3L,2L,1L,92L,48L,25L,6L,3L,2L,176L,92L,48L,12L,6L,3L,1L,338L,176L,92L,23L,12L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176452Inst : IEnumerable<long>
{
public static readonly long[] Value=A176452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176452.Bytes);
public long this[int i]=>Value[i];

public static A176452Inst Instance=new A176452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176453
{
public static readonly long[] Value={ 8L,4L,7L,2L,1L,3L,5L,9L,5L,4L,9L,9L,9L,5L,7L,9L,3L,9L,2L,8L,1L,8L,3L,4L,7L,3L,3L,7L,4L,6L,2L,5L,5L,2L,4L,7L,0L,8L,8L,1L,2L,3L,6L,7L,1L,9L,2L,2L,3L,0L,5L,1L,4L,4L,8L,5L,4L,1L,7L,9L,4L,4L,9L,0L,8L,2L,1L,0L,4L,1L,8L,5L,1L,2L,7L,5L,6L,0L,9L,7L,9L,8L,8L,2L,8L,8L,2L,8L,8L,1L,6L,7L,5L,7L,5L,6L,4L,5L,4L,9L,9L,3L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176453Inst : IEnumerable<long>
{
public static readonly long[] Value=A176453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176453.Bytes);
public long this[int i]=>Value[i];

public static A176453Inst Instance=new A176453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176454
{
public static readonly long[] Value={ 8L,3L,2L,0L,4L,9L,3L,7L,9L,8L,9L,3L,8L,5L,7L,3L,4L,8L,7L,3L,1L,0L,6L,4L,4L,9L,5L,7L,3L,9L,1L,9L,9L,7L,7L,7L,1L,8L,0L,3L,4L,6L,9L,5L,3L,8L,0L,3L,8L,8L,9L,7L,6L,9L,9L,8L,0L,7L,5L,6L,9L,5L,9L,8L,5L,3L,9L,7L,4L,4L,9L,1L,8L,5L,6L,2L,6L,9L,6L,2L,4L,7L,6L,0L,0L,2L,4L,0L,6L,0L,4L,4L,0L,3L,7L,4L,0L,1L,5L,7L,1L,1L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176454Inst : IEnumerable<long>
{
public static readonly long[] Value=A176454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176454.Bytes);
public long this[int i]=>Value[i];

public static A176454Inst Instance=new A176454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176455
{
public static readonly long[] Value={ 8L,1L,9L,5L,2L,3L,5L,3L,9L,2L,6L,8L,0L,6L,0L,6L,1L,8L,7L,9L,6L,5L,8L,1L,4L,0L,5L,4L,7L,1L,9L,7L,5L,0L,3L,9L,3L,9L,0L,1L,0L,8L,7L,4L,3L,0L,7L,2L,6L,0L,1L,5L,9L,3L,9L,5L,0L,3L,0L,2L,3L,0L,5L,4L,3L,2L,0L,0L,2L,3L,7L,0L,2L,0L,0L,4L,4L,0L,2L,7L,6L,5L,6L,7L,7L,5L,4L,1L,1L,5L,5L,7L,3L,2L,7L,7L,7L,6L,7L,1L,2L,1L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176455Inst : IEnumerable<long>
{
public static readonly long[] Value=A176455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176455.Bytes);
public long this[int i]=>Value[i];

public static A176455Inst Instance=new A176455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176456
{
public static readonly long[] Value={ 8L,1L,6L,3L,3L,3L,1L,9L,9L,8L,9L,3L,2L,2L,6L,5L,4L,7L,0L,5L,6L,4L,5L,9L,5L,4L,1L,3L,9L,5L,9L,8L,6L,2L,9L,7L,4L,0L,4L,8L,6L,3L,9L,9L,8L,5L,3L,2L,7L,7L,7L,0L,8L,7L,2L,3L,0L,1L,9L,8L,1L,2L,8L,7L,0L,7L,3L,0L,7L,4L,1L,3L,3L,7L,2L,2L,3L,4L,3L,0L,0L,0L,4L,2L,2L,2L,2L,4L,0L,7L,4L,8L,1L,4L,2L,2L,7L,0L,5L,8L,0L,7L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176456Inst : IEnumerable<long>
{
public static readonly long[] Value=A176456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176456.Bytes);
public long this[int i]=>Value[i];

public static A176456Inst Instance=new A176456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176457
{
public static readonly long[] Value={ 8L,1L,4L,0L,3L,9L,3L,3L,5L,6L,0L,5L,4L,1L,2L,5L,3L,0L,6L,7L,7L,6L,7L,6L,1L,1L,8L,7L,7L,6L,2L,7L,9L,1L,9L,2L,0L,8L,9L,7L,1L,8L,0L,8L,2L,1L,3L,5L,9L,7L,0L,6L,5L,9L,6L,7L,7L,0L,2L,6L,4L,2L,3L,0L,6L,0L,5L,1L,8L,4L,1L,0L,6L,4L,7L,2L,4L,8L,0L,1L,2L,0L,4L,8L,9L,3L,0L,3L,7L,6L,9L,1L,4L,3L,8L,9L,0L,7L,1L,3L,6L,4L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176457Inst : IEnumerable<long>
{
public static readonly long[] Value=A176457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176457.Bytes);
public long this[int i]=>Value[i];

public static A176457Inst Instance=new A176457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176458
{
public static readonly long[] Value={ 8L,1L,2L,3L,1L,0L,5L,6L,2L,5L,6L,1L,7L,6L,6L,0L,5L,4L,9L,8L,2L,1L,4L,0L,9L,8L,5L,5L,9L,7L,4L,0L,7L,7L,0L,2L,5L,1L,4L,7L,1L,9L,9L,2L,2L,5L,3L,7L,3L,6L,2L,0L,4L,3L,4L,3L,9L,8L,6L,3L,3L,5L,7L,3L,0L,9L,4L,9L,5L,4L,3L,4L,6L,3L,3L,7L,6L,2L,1L,5L,9L,3L,5L,8L,7L,8L,6L,3L,6L,5L,0L,8L,1L,0L,6L,8L,4L,2L,9L,6L,6L,8L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176458Inst : IEnumerable<long>
{
public static readonly long[] Value=A176458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176458.Bytes);
public long this[int i]=>Value[i];

public static A176458Inst Instance=new A176458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176459
{
public static readonly long[] Value={ 8L,1L,0L,9L,6L,0L,9L,3L,3L,5L,3L,1L,2L,6L,5L,0L,9L,6L,6L,8L,3L,3L,4L,6L,1L,5L,8L,7L,6L,3L,6L,1L,6L,2L,8L,1L,6L,8L,2L,3L,7L,4L,9L,3L,4L,8L,9L,6L,3L,0L,4L,9L,6L,9L,6L,5L,8L,3L,0L,4L,8L,0L,4L,8L,3L,0L,5L,5L,9L,9L,7L,6L,6L,8L,4L,2L,4L,4L,2L,8L,0L,8L,6L,4L,4L,4L,8L,6L,5L,3L,2L,7L,9L,9L,2L,6L,6L,6L,3L,0L,0L,9L,9L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176459Inst : IEnumerable<long>
{
public static readonly long[] Value=A176459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176459.Bytes);
public long this[int i]=>Value[i];

public static A176459Inst Instance=new A176459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176460
{
public static readonly long[] Value={ 8L,0L,9L,8L,7L,8L,0L,3L,0L,6L,3L,8L,3L,8L,3L,9L,3L,5L,3L,2L,8L,8L,4L,1L,5L,4L,7L,2L,2L,0L,8L,4L,2L,0L,7L,9L,6L,2L,9L,4L,0L,1L,3L,0L,6L,5L,3L,8L,1L,9L,3L,3L,1L,7L,1L,8L,1L,6L,7L,9L,1L,3L,9L,9L,9L,5L,6L,1L,3L,9L,1L,9L,4L,2L,8L,2L,1L,4L,1L,6L,2L,9L,1L,7L,0L,8L,9L,2L,6L,5L,1L,3L,5L,1L,4L,1L,8L,6L,9L,4L,7L,8L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176460Inst : IEnumerable<long>
{
public static readonly long[] Value=A176460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176460.Bytes);
public long this[int i]=>Value[i];

public static A176460Inst Instance=new A176460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176461
{
public static readonly long[] Value={ 1L,0L,2L,4L,6L,9L,5L,0L,7L,6L,5L,9L,5L,9L,5L,9L,8L,3L,8L,3L,2L,2L,1L,0L,3L,8L,6L,8L,0L,5L,2L,1L,0L,5L,1L,9L,9L,0L,7L,3L,5L,0L,3L,2L,6L,6L,3L,4L,5L,4L,8L,3L,2L,9L,2L,9L,5L,4L,1L,9L,7L,8L,4L,9L,9L,8L,9L,0L,3L,4L,7L,9L,8L,5L,7L,0L,5L,3L,5L,4L,0L,7L,2L,9L,2L,7L,2L,3L,1L,6L,2L,8L,3L,7L,8L,5L,4L,6L,7L,3L,6L,9L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176461Inst : IEnumerable<long>
{
public static readonly long[] Value=A176461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176461.Bytes);
public long this[int i]=>Value[i];

public static A176461Inst Instance=new A176461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176462
{
public static readonly long[] Value={ 0L,17L,19L,29L,31L,41L,43L,49L,51L,53L,55L,65L,67L,69L,71L,77L,79L,89L,91L,97L,99L,101L,103L,109L,111L,113L,115L,125L,127L,129L,131L,137L,139L,149L,151L,153L,155L,161L,163L,169L,171L,173L,175L,181L,183L,185L,187L,189L,191L,197L,199L,209L,211L,221L,223L,229L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176462Inst : IEnumerable<long>
{
public static readonly long[] Value=A176462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176462.Bytes);
public long this[int i]=>Value[i];

public static A176462Inst Instance=new A176462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176463
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,8L,4L,2L,1L,15L,8L,4L,2L,29L,15L,8L,4L,1L,57L,29L,15L,8L,2L,1L,112L,57L,29L,15L,4L,2L,1L,220L,112L,57L,29L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176463Inst : IEnumerable<long>
{
public static readonly long[] Value=A176463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176463.Bytes);
public long this[int i]=>Value[i];

public static A176463Inst Instance=new A176463Inst();

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