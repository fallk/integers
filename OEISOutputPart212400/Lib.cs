using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A263062
{
public static readonly BigInteger[] Value={ 1L,1L,8989L,1538743249L,1887593866439485L,BigInteger.Parse("10169807398958450670001"),BigInteger.Parse("179349571255187154941191217629"),BigInteger.Parse("8508048612432263410111274212273801489"),BigInteger.Parse("943457762940832669626002608045124343895474045"),BigInteger.Parse("220079308019032269943223432841210561656944209845808241") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263062Inst Instance=new A263062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263063
{
public static readonly BigInteger[] Value={ 1L,1L,265729L,3776339263873L,BigInteger.Parse("756051015055329306625"),BigInteger.Parse("1100327453912286201909924526081"),BigInteger.Parse("7835213566547395052871069325808866414849"),BigInteger.Parse("209691630817770382144439647416526247292909726379393"),BigInteger.Parse("17469051230066445323872793284679234619523576313653708533767425") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263063Inst Instance=new A263063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263064
{
public static readonly BigInteger[] Value={ 1L,75L,23917L,10681263L,5552351121L,3147728203035L,1887593866439485L,1177359342144641535L,BigInteger.Parse("756051015055329306625"),BigInteger.Parse("496505991344667030490635"),BigInteger.Parse("331910222316215755702672557"),BigInteger.Parse("225110028217225196478861017775"),BigInteger.Parse("154515942591851050758389232988689") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263064Inst Instance=new A263064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263065
{
public static readonly BigInteger[] Value={ 1L,541L,2244361L,14638956721L,117029959485121L,1050740615666453461L,BigInteger.Parse("10169807398958450670001"),BigInteger.Parse("103746115308050354021387521"),BigInteger.Parse("1100327453912286201909924526081"),BigInteger.Parse("12024609569670508078686022988554381"),BigInteger.Parse("134565509066155510620216211257550349401") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263065Inst Instance=new A263065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263066
{
public static readonly BigInteger[] Value={ 1L,4683L,308682013L,35941784497263L,5402040231378569121L,BigInteger.Parse("939073157252309315848923"),BigInteger.Parse("179349571255187154941191217629"),BigInteger.Parse("36585008462723983824862891403150079"),BigInteger.Parse("7835213566547395052871069325808866414849"),BigInteger.Parse("1742079663955078309800553960117733249663480043") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263066Inst Instance=new A263066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263067
{
public static readonly BigInteger[] Value={ 1L,47293L,58514835289L,143743469278461361L,BigInteger.Parse("480086443888959812703121"),BigInteger.Parse("1909946024633189859690880523893"),BigInteger.Parse("8508048612432263410111274212273801489"),BigInteger.Parse("41020870889694863957061607086939138327565057"),BigInteger.Parse("209691630817770382144439647416526247292909726379393") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263067Inst Instance=new A263067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263068
{
public static readonly BigInteger[] Value={ 1L,545835L,14623910308237L,BigInteger.Parse("874531783382503604463"),BigInteger.Parse("74896283763383392805211587121"),BigInteger.Parse("7868854300758955660834916406038038395"),BigInteger.Parse("943457762940832669626002608045124343895474045"),BigInteger.Parse("124069835911824710311393852646151897334844371419287295") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263068Inst Instance=new A263068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263069
{
public static readonly BigInteger[] Value={ 1L,7087261L,4659168491711401L,BigInteger.Parse("7687300579969605991710001"),BigInteger.Parse("19133358944433370977791260580721121"),BigInteger.Parse("60169662022264019813634467045726478557798101"),BigInteger.Parse("220079308019032269943223432841210561656944209845808241"),BigInteger.Parse("894709632166224106718347951886305028154659386016685862593012481") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263069Inst Instance=new A263069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263070
{
public static readonly BigInteger[] Value={ 1L,102247563L,1843200116875263613L,BigInteger.Parse("93777824804632275267836362863"),BigInteger.Parse("7581761490297442738124283591348762605121"),BigInteger.Parse("797656368265147949572521540584234236944835806750363"),BigInteger.Parse("99479717242433942914309980793245660313479486272546475327799069") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263070Inst Instance=new A263070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263071
{
public static readonly BigInteger[] Value={ 1L,1L,1462563L,191731486403293L,BigInteger.Parse("496505991344667030490635"),BigInteger.Parse("12024609569670508078686022988554381"),BigInteger.Parse("1742079663955078309800553960117733249663480043"),BigInteger.Parse("1121241285685659360225420876424590015281785102622410968973") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263071Inst Instance=new A263071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263072
{
public static readonly BigInteger[] Value={ 1L,1L,8097453L,9850349744182729L,BigInteger.Parse("331910222316215755702672557"),BigInteger.Parse("134565509066155510620216211257550349401"),BigInteger.Parse("399017534874989738901076297624977315332337599285373"),BigInteger.Parse("6213239693876579408708842528154872834110410698303331900339282569") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263072Inst Instance=new A263072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263073
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,3L,2L,4L,4L,4L,5L,6L,6L,8L,9L,9L,12L,12L,13L,16L,18L,18L,22L,24L,25L,29L,32L,34L,40L,43L,45L,52L,56L,60L,68L,74L,78L,88L,95L,101L,113L,122L,130L,145L,156L,166L,184L,198L,209L,231L,249L,264L,290L,311L,331L,361L,388L,412L,448L,480L,510L,554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263073Inst : IEnumerable<long>
{
public static readonly long[] Value=A263073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263073.Bytes);
public long this[int i]=>Value[i];

public static A263073Inst Instance=new A263073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263074
{
public static readonly long[] Value={ 1L,-2L,0L,1L,0L,1L,-1L,0L,1L,0L,-1L,-1L,0L,1L,0L,1L,-3L,0L,2L,0L,1L,-1L,0L,2L,0L,0L,-3L,0L,1L,0L,2L,-4L,0L,2L,0L,1L,-3L,0L,3L,0L,1L,-4L,0L,2L,0L,3L,-6L,0L,4L,0L,4L,-6L,0L,4L,0L,1L,-7L,0L,4L,0L,3L,-9L,0L,5L,0L,4L,-8L,0L,6L,0L,3L,-10L,0L,6L,0L,6L,-13L,0L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263074Inst : IEnumerable<long>
{
public static readonly long[] Value=A263074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263074.Bytes);
public long this[int i]=>Value[i];

public static A263074Inst Instance=new A263074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263075
{
public static readonly BigInteger[] Value={ 1L,1L,2L,31L,1150L,68713L,5914776L,692005074L,105932315154L,20617891510063L,4984425649932314L,1467604324373250545L,BigInteger.Parse("517561005098562714944"),BigInteger.Parse("215501019188749426210440"),BigInteger.Parse("104642607303457024105207408"),BigInteger.Parse("58625315029802441203026824094"),BigInteger.Parse("37541542090285460025870424920666") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263075Inst Instance=new A263075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263076
{
public static readonly long[] Value={ 2L,1810L,2458L,240926L,317602L,757730L,771610L,23993994L,58292586L,172616042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263076Inst : IEnumerable<long>
{
public static readonly long[] Value=A263076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263076.Bytes);
public long this[int i]=>Value[i];

public static A263076Inst Instance=new A263076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263077
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,2L,12L,6L,6L,6L,12L,6L,18L,12L,18L,18L,22L,12L,30L,18L,30L,18L,34L,22L,22L,22L,42L,22L,48L,22L,60L,30L,60L,30L,72L,48L,84L,34L,84L,34L,96L,34L,108L,42L,96L,42L,108L,42L,48L,48L,120L,48L,132L,48L,132L,48L,140L,60L,140L,48L,140L,72L,140L,140L,140L,72L,140L,84L,140L,84L,140L,60L,140L,96L,140L,96L,150L,96L,156L,96L,108L,108L,120L,72L,120L,120L,132L,108L,140L,108L,140L,132L,140L,120L,140L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263077Inst : IEnumerable<long>
{
public static readonly long[] Value=A263077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263077.Bytes);
public long this[int i]=>Value[i];

public static A263077Inst Instance=new A263077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263078
{
public static readonly long[] Value={ -1L,-2L,-1L,-2L,1L,-4L,5L,-2L,-3L,-4L,1L,-6L,5L,-2L,3L,2L,5L,-6L,11L,-2L,9L,-4L,11L,-2L,-3L,-4L,15L,-6L,19L,-8L,29L,-2L,27L,-4L,37L,12L,47L,-4L,45L,-6L,55L,-8L,65L,-2L,51L,-4L,61L,-6L,-1L,-2L,69L,-4L,79L,-6L,77L,-8L,83L,2L,81L,-12L,79L,10L,77L,76L,75L,6L,73L,16L,71L,14L,69L,-12L,67L,22L,65L,20L,73L,18L,77L,16L,27L,26L,37L,-12L,35L,34L,45L,20L,51L,18L,49L,40L,47L,26L,45L,-12L,43L,42L,41L,40L,39L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263078Inst : IEnumerable<long>
{
public static readonly long[] Value=A263078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263078.Bytes);
public long this[int i]=>Value[i];

public static A263078Inst Instance=new A263078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263079
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,12L,14L,18L,20L,22L,24L,25L,26L,28L,30L,32L,34L,38L,40L,42L,44L,46L,48L,49L,50L,52L,54L,56L,60L,72L,84L,96L,104L,108L,120L,128L,132L,136L,140L,142L,144L,150L,152L,156L,160L,162L,168L,170L,180L,182L,184L,186L,188L,190L,192L,194L,198L,200L,204L,208L,210L,216L,220L,225L,228L,240L,248L,252L,260L,264L,276L,280L,288L,296L,300L,308L,312L,320L,328L,340L,352L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263079Inst : IEnumerable<long>
{
public static readonly long[] Value=A263079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263079.Bytes);
public long this[int i]=>Value[i];

public static A263079Inst Instance=new A263079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263080
{
public static readonly long[] Value={ 5L,7L,11L,13L,15L,16L,17L,19L,21L,23L,27L,29L,31L,33L,35L,36L,37L,39L,41L,43L,45L,47L,51L,53L,55L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,105L,106L,107L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263080Inst : IEnumerable<long>
{
public static readonly long[] Value=A263080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263080.Bytes);
public long this[int i]=>Value[i];

public static A263080Inst Instance=new A263080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263081
{
public static readonly long[] Value={ 124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,124340L,24684000L,24684000L,24684000L,24684000L,24684000L,24684000L,24684000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263081Inst : IEnumerable<long>
{
public static readonly long[] Value=A263081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263081.Bytes);
public long this[int i]=>Value[i];

public static A263081Inst Instance=new A263081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263082
{
public static readonly long[] Value={ 0L,2L,6L,12L,18L,22L,30L,34L,42L,48L,60L,72L,84L,96L,108L,120L,132L,140L,140L,140L,140L,140L,140L,140L,150L,156L,168L,180L,180L,184L,192L,204L,216L,228L,240L,248L,264L,280L,280L,280L,280L,288L,296L,312L,312L,320L,328L,340L,352L,364L,372L,372L,372L,372L,384L,396L,420L,420L,420L,420L,432L,450L,468L,480L,504L,520L,540L,560L,572L,580L,594L,612L,612L,618L,622L,628L,648L,672L,672L,672L,672L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263082Inst : IEnumerable<long>
{
public static readonly long[] Value=A263082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263082.Bytes);
public long this[int i]=>Value[i];

public static A263082Inst Instance=new A263082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263083
{
public static readonly long[] Value={ 119196L,119196L,119232L,119280L,119280L,119952L,119970L,120120L,120120L,120132L,120132L,120320L,120330L,120400L,120432L,120750L,120780L,120960L,120960L,120960L,120960L,120960L,121500L,121600L,121856L,122112L,122304L,122304L,122310L,122310L,122850L,123000L,123240L,123240L,123264L,123264L,123300L,123840L,24660720L,24660720L,24662484L,24662484L,24663804L,24665130L,24665130L,24665472L,24666048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263083Inst : IEnumerable<long>
{
public static readonly long[] Value=A263083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263083.Bytes);
public long this[int i]=>Value[i];

public static A263083Inst Instance=new A263083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263084
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,11L,13L,14L,18L,22L,22L,28L,29L,31L,37L,41L,41L,46L,48L,52L,58L,62L,60L,68L,71L,73L,79L,83L,83L,93L,95L,96L,100L,104L,108L,118L,120L,120L,124L,132L,131L,141L,141L,145L,155L,157L,157L,165L,169L,172L,178L,184L,180L,190L,196L,202L,208L,210L,208L,220L,221L,223L,231L,237L,241L,251L,251L,251L,257L,267L,267L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263084Inst : IEnumerable<long>
{
public static readonly long[] Value=A263084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263084.Bytes);
public long this[int i]=>Value[i];

public static A263084Inst Instance=new A263084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263085
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,12L,14L,18L,20L,22L,26L,28L,31L,35L,37L,39L,43L,47L,49L,53L,55L,57L,63L,65L,68L,72L,74L,78L,82L,84L,86L,92L,96L,98L,102L,104L,106L,112L,116L,118L,123L,125L,129L,133L,135L,139L,143L,147L,149L,155L,157L,159L,167L,169L,171L,175L,177L,181L,187L,191L,194L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263085Inst : IEnumerable<long>
{
public static readonly long[] Value=A263085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263085.Bytes);
public long this[int i]=>Value[i];

public static A263085Inst Instance=new A263085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263086
{
public static readonly long[] Value={ 2L,5L,9L,13L,17L,23L,27L,32L,38L,44L,48L,56L,60L,66L,74L,80L,84L,93L,97L,105L,113L,119L,123L,133L,139L,145L,153L,161L,165L,177L,181L,188L,196L,202L,210L,222L,226L,232L,240L,250L,254L,266L,270L,278L,290L,296L,300L,312L,318L,327L,335L,343L,347L,359L,367L,377L,385L,391L,395L,411L,415L,421L,433L,441L,449L,461L,465L,473L,481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263086Inst : IEnumerable<long>
{
public static readonly long[] Value=A263086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263086.Bytes);
public long this[int i]=>Value[i];

public static A263086Inst Instance=new A263086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263087
{
public static readonly long[] Value={ 2L,2L,1L,1L,1L,0L,0L,0L,0L,2L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,2L,1L,0L,0L,0L,1L,1L,2L,1L,1L,0L,0L,2L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,2L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,2L,3L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263087Inst : IEnumerable<long>
{
public static readonly long[] Value=A263087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263087.Bytes);
public long this[int i]=>Value[i];

public static A263087Inst Instance=new A263087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263088
{
public static readonly long[] Value={ 0L,6L,2L,38L,2L,1L,1L,1L,1L,22L,1L,0L,0L,2L,1L,3L,1L,9L,1L,39L,1L,47L,1L,51L,4L,114L,1L,1L,1L,529L,2L,6L,2L,3L,1L,1L,22L,1L,11L,3L,2L,4L,7L,93L,7L,967L,1L,1L,3L,4L,1L,3L,2L,4L,1L,3L,1L,3L,1L,1L,1L,2L,1L,139L,2L,265L,2L,1L,6L,464L,12L,4L,22L,1L,2L,1503L,2L,6L,1L,5L,2L,2L,1L,2L,5L,1L,2L,4L,2L,1L,1L,6L,3L,386L,1L,1L,3L,800L,1L,2L,1L,7L,5L,1L,1L,3353L,1L,2L,21L,3L,1L,17L,3L,3L,1L,4L,1L,5L,1L,3L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263088Inst : IEnumerable<long>
{
public static readonly long[] Value=A263088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263088.Bytes);
public long this[int i]=>Value[i];

public static A263088Inst Instance=new A263088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263089
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,10L,10L,11L,11L,11L,11L,12L,12L,13L,13L,13L,13L,14L,14L,15L,15L,15L,15L,15L,15L,15L,15L,16L,16L,17L,17L,17L,17L,18L,18L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263089Inst : IEnumerable<long>
{
public static readonly long[] Value=A263089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263089.Bytes);
public long this[int i]=>Value[i];

public static A263089Inst Instance=new A263089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263090
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,29L,31L,41L,47L,53L,59L,61L,71L,73L,83L,89L,97L,101L,107L,127L,137L,139L,149L,151L,157L,173L,179L,181L,191L,197L,199L,211L,223L,227L,233L,239L,263L,269L,277L,281L,283L,311L,317L,331L,337L,347L,349L,367L,373L,389L,409L,419L,421L,431L,433L,443L,449L,457L,461L,467L,521L,523L,541L,547L,557L,569L,577L,587L,593L,599L,601L,607L,613L,617L,619L,631L,641L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263090Inst : IEnumerable<long>
{
public static readonly long[] Value=A263090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263090.Bytes);
public long this[int i]=>Value[i];

public static A263090Inst Instance=new A263090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263091
{
public static readonly long[] Value={ 7L,13L,19L,37L,43L,67L,79L,103L,109L,113L,131L,163L,167L,193L,229L,241L,251L,257L,271L,293L,307L,313L,353L,359L,379L,383L,397L,401L,439L,463L,479L,487L,491L,499L,503L,509L,563L,571L,647L,653L,661L,673L,701L,739L,743L,757L,761L,773L,823L,859L,863L,883L,887L,911L,937L,941L,953L,967L,971L,977L,983L,1009L,1093L,1103L,1109L,1171L,1181L,1193L,1217L,1279L,1283L,1291L,1297L,1307L,1321L,1361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263091Inst : IEnumerable<long>
{
public static readonly long[] Value=A263091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263091.Bytes);
public long this[int i]=>Value[i];

public static A263091Inst Instance=new A263091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263092
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,11L,12L,13L,15L,17L,19L,21L,23L,24L,25L,29L,30L,31L,32L,33L,36L,38L,39L,40L,41L,42L,43L,44L,45L,48L,49L,51L,52L,53L,55L,57L,61L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L,79L,80L,81L,83L,84L,86L,87L,88L,91L,92L,93L,96L,97L,99L,101L,102L,105L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263092Inst : IEnumerable<long>
{
public static readonly long[] Value=A263092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263092.Bytes);
public long this[int i]=>Value[i];

public static A263092Inst Instance=new A263092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263093
{
public static readonly long[] Value={ 5L,6L,7L,8L,10L,14L,16L,18L,20L,22L,26L,27L,28L,34L,35L,37L,46L,47L,50L,54L,56L,58L,59L,60L,62L,67L,73L,78L,82L,85L,89L,90L,94L,95L,98L,100L,103L,104L,106L,110L,114L,116L,118L,122L,124L,125L,126L,127L,128L,130L,135L,140L,141L,142L,148L,150L,155L,158L,161L,164L,170L,172L,174L,177L,178L,182L,184L,188L,190L,199L,202L,205L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263093Inst : IEnumerable<long>
{
public static readonly long[] Value=A263093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263093.Bytes);
public long this[int i]=>Value[i];

public static A263093Inst Instance=new A263093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263094
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,81L,121L,144L,169L,225L,289L,361L,441L,529L,576L,625L,841L,900L,961L,1024L,1089L,1296L,1444L,1521L,1600L,1681L,1764L,1849L,1936L,2025L,2304L,2401L,2601L,2704L,2809L,3025L,3249L,3721L,3969L,4096L,4225L,4356L,4624L,4761L,4900L,5041L,5184L,5476L,5625L,5776L,5929L,6241L,6400L,6561L,6889L,7056L,7396L,7569L,7744L,8281L,8464L,8649L,9216L,9409L,9801L,10201L,10404L,11025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263094Inst : IEnumerable<long>
{
public static readonly long[] Value=A263094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263094.Bytes);
public long this[int i]=>Value[i];

public static A263094Inst Instance=new A263094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263095
{
public static readonly long[] Value={ 25L,36L,49L,64L,100L,196L,256L,324L,400L,484L,676L,729L,784L,1156L,1225L,1369L,2116L,2209L,2500L,2916L,3136L,3364L,3481L,3600L,3844L,4489L,5329L,6084L,6724L,7225L,7921L,8100L,8836L,9025L,9604L,10000L,10609L,10816L,11236L,12100L,12996L,13456L,13924L,14884L,15376L,15625L,15876L,16129L,16384L,16900L,18225L,19600L,19881L,20164L,21904L,22500L,24025L,24964L,25921L,26896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263095Inst : IEnumerable<long>
{
public static readonly long[] Value=A263095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263095.Bytes);
public long this[int i]=>Value[i];

public static A263095Inst Instance=new A263095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263096
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,6L,6L,7L,10L,13L,15L,18L,26L,28L,35L,40L,50L,70L,86L,100L,122L,141L,158L,166L,212L,224L,235L,288L,332L,407L,470L,526L,576L,706L,744L,815L,848L,1039L,1200L,1470L,1697L,1898L,2079L,2546L,2684L,2940L,3287L,3796L,4158L,4649L,5694L,6062L,6575L,7826L,8573L,10500L,11068L,12125L,13556L,15653L,17147L,19172L,23480L,26426L,27113L,33206L,37373L,45772L,46961L,48248L,52853L,59092L,68233L,74746L,83568L,102350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263096Inst : IEnumerable<long>
{
public static readonly long[] Value=A263096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263096.Bytes);
public long this[int i]=>Value[i];

public static A263096Inst Instance=new A263096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263097
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,0L,1L,3L,3L,2L,3L,8L,2L,7L,5L,10L,20L,16L,14L,22L,19L,17L,8L,46L,12L,11L,53L,44L,75L,63L,56L,50L,130L,38L,71L,33L,191L,161L,270L,227L,201L,181L,467L,138L,256L,347L,509L,362L,491L,1045L,368L,513L,1251L,747L,1927L,568L,1057L,1431L,2097L,1494L,2025L,4308L,2946L,687L,6093L,4167L,8399L,1189L,1287L,4605L,6239L,9141L,6513L,8822L,18782L,15834L,26561L,22392L,37564L,16401L,32375L,17317L,12602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263097Inst : IEnumerable<long>
{
public static readonly long[] Value=A263097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263097.Bytes);
public long this[int i]=>Value[i];

public static A263097Inst Instance=new A263097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263098
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,10L,12L,12L,12L,16L,16L,16L,18L,18L,20L,20L,20L,24L,24L,24L,24L,24L,24L,24L,24L,30L,30L,32L,32L,32L,32L,32L,32L,32L,36L,36L,36L,36L,36L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263098Inst : IEnumerable<long>
{
public static readonly long[] Value=A263098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263098.Bytes);
public long this[int i]=>Value[i];

public static A263098Inst Instance=new A263098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263099
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,2L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,2L,0L,1L,0L,3L,0L,0L,0L,2L,0L,1L,0L,3L,0L,1L,0L,0L,0L,0L,0L,4L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263099Inst : IEnumerable<long>
{
public static readonly long[] Value=A263099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263099.Bytes);
public long this[int i]=>Value[i];

public static A263099Inst Instance=new A263099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263100
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,3L,2L,4L,2L,6L,2L,5L,2L,5L,4L,4L,4L,4L,5L,3L,5L,5L,4L,4L,6L,6L,1L,7L,4L,6L,4L,4L,7L,6L,4L,5L,5L,5L,6L,6L,4L,6L,3L,7L,6L,5L,6L,6L,6L,5L,5L,6L,4L,7L,8L,4L,3L,10L,2L,6L,6L,6L,6L,7L,5L,5L,9L,3L,6L,8L,6L,7L,5L,5L,6L,7L,7L,8L,3L,9L,3L,10L,2L,7L,9L,7L,2L,7L,8L,5L,8L,4L,6L,9L,5L,7L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263100Inst : IEnumerable<long>
{
public static readonly long[] Value=A263100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263100.Bytes);
public long this[int i]=>Value[i];

public static A263100Inst Instance=new A263100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263101
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,5L,12L,5L,33L,5L,1L,0L,232L,233L,55L,5L,1596L,2563L,1L,5L,987L,10946L,28656L,0L,0L,75025L,189653L,89L,1L,6765L,1L,5L,6765L,1L,9227460L,0L,24157816L,1L,63245985L,5L,1L,267914275L,433494436L,4181L,1134896405L,1L,2971215072L,0L,7778741816L,75025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263101Inst : IEnumerable<long>
{
public static readonly long[] Value=A263101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263101.Bytes);
public long this[int i]=>Value[i];

public static A263101Inst Instance=new A263101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263102
{
public static readonly BigInteger[] Value={ 0L,0L,1L,3L,12L,40L,225L,1071L,8848L,56232L,616185L,4880755L,66475596L,629398848L,10238194057L,112690225935L,2130537219840L,26719024870576L,575573407212753L,8099650628337987L,195807849389362540L,3054957193416951480L,BigInteger.Parse("81892400673047263761"),BigInteger.Parse("1402819397613793354063"),BigInteger.Parse("41294565798306731368272"),BigInteger.Parse("770446268109598573215000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263102Inst Instance=new A263102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263103
{
public static readonly long[] Value={ 1L,3L,8L,28L,103L,415L,2176L,12888L,77787L,585411L,4616376L,37165472L,359048127L,3547499455L,35666828200L,418731250432L,4974631473123L,59967609426243L,827065614194184L,11481419054280168L,161364022042775615L,2553658998728779999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263103Inst : IEnumerable<long>
{
public static readonly long[] Value=A263103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263103.Bytes);
public long this[int i]=>Value[i];

public static A263103Inst Instance=new A263103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263104
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,3L,2L,2L,3L,2L,3L,3L,1L,4L,4L,3L,3L,4L,3L,4L,4L,2L,5L,5L,4L,4L,5L,4L,5L,5L,3L,6L,6L,5L,5L,6L,5L,6L,6L,4L,7L,7L,6L,6L,7L,6L,7L,7L,5L,8L,8L,7L,7L,8L,7L,8L,8L,7L,8L,9L,8L,8L,9L,8L,9L,9L,8L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263104Inst : IEnumerable<long>
{
public static readonly long[] Value=A263104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263104.Bytes);
public long this[int i]=>Value[i];

public static A263104Inst Instance=new A263104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263105
{
public static readonly BigInteger[] Value={ 1L,33L,2916L,808300L,509131545L,605707523361L,1214620662420928L,3795417851074101456L,BigInteger.Parse("17444500147778706611145"),BigInteger.Parse("112823815631393432721650905"),BigInteger.Parse("991377088026896964421518306036"),BigInteger.Parse("11502248569873461404933124399742188") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263105Inst Instance=new A263105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263106
{
public static readonly long[] Value={ 4L,6L,9L,15L,22L,26L,33L,39L,49L,51L,55L,58L,62L,77L,85L,93L,94L,111L,122L,129L,134L,141L,145L,155L,158L,159L,161L,177L,178L,183L,185L,187L,202L,206L,214L,226L,254L,262L,298L,303L,309L,314L,321L,339L,341L,355L,358L,362L,371L,381L,391L,393L,394L,403L,407L,413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263106Inst : IEnumerable<long>
{
public static readonly long[] Value=A263106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263106.Bytes);
public long this[int i]=>Value[i];

public static A263106Inst Instance=new A263106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263107
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,1L,4L,5L,1L,6L,3L,4L,5L,2L,4L,5L,2L,5L,5L,3L,4L,5L,4L,6L,2L,4L,4L,6L,3L,4L,5L,2L,6L,8L,1L,5L,6L,2L,4L,7L,3L,6L,5L,2L,6L,7L,1L,4L,7L,3L,6L,5L,3L,7L,4L,5L,5L,6L,5L,5L,4L,2L,6L,10L,3L,4L,6L,5L,3L,6L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263107Inst : IEnumerable<long>
{
public static readonly long[] Value=A263107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263107.Bytes);
public long this[int i]=>Value[i];

public static A263107Inst Instance=new A263107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263108
{
public static readonly long[] Value={ 15L,26L,39L,49L,58L,122L,129L,134L,141L,145L,155L,158L,159L,161L,177L,178L,183L,185L,187L,226L,254L,262L,298L,339L,341L,355L,358L,362L,371L,381L,391L,393L,394L,445L,451L,469L,473L,493L,497L,565L,581L,583L,586L,589L,674L,781L,791L,889L,895L,899L,1114L,1119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263108Inst : IEnumerable<long>
{
public static readonly long[] Value=A263108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263108.Bytes);
public long this[int i]=>Value[i];

public static A263108Inst Instance=new A263108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263109
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,2L,1L,5L,5L,5L,5L,5L,5L,5L,5L,4L,3L,2L,1L,6L,6L,6L,6L,6L,6L,6L,5L,4L,3L,2L,1L,7L,7L,7L,7L,7L,7L,6L,5L,4L,3L,2L,1L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263109Inst : IEnumerable<long>
{
public static readonly long[] Value=A263109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263109.Bytes);
public long this[int i]=>Value[i];

public static A263109Inst Instance=new A263109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263110
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,2L,1L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,4L,3L,2L,1L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263110Inst : IEnumerable<long>
{
public static readonly long[] Value=A263110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263110.Bytes);
public long this[int i]=>Value[i];

public static A263110Inst Instance=new A263110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263111
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,4L,1L,1L,1L,5L,1L,6L,1L,1L,1L,7L,1L,8L,1L,1L,1L,9L,1L,2L,1L,1L,2L,10L,1L,11L,1L,1L,1L,2L,1L,12L,2L,2L,1L,13L,1L,14L,1L,1L,1L,15L,1L,2L,1L,1L,1L,16L,1L,3L,1L,1L,2L,17L,2L,18L,1L,1L,1L,1L,1L,19L,1L,1L,1L,20L,1L,21L,2L,1L,2L,2L,1L,22L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263111Inst : IEnumerable<long>
{
public static readonly long[] Value=A263111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263111.Bytes);
public long this[int i]=>Value[i];

public static A263111Inst Instance=new A263111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263112
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,3L,2L,2L,1L,5L,1L,0L,8L,13L,10L,2L,12L,15L,5L,10L,1L,1L,1L,0L,0L,25L,1L,2L,5L,15L,27L,2L,10L,33L,20L,0L,1L,1L,34L,10L,40L,21L,18L,2L,10L,1L,1L,0L,1L,25L,1L,2L,16L,21L,5L,26L,37L,1L,7L,0L,33L,27L,1L,2L,40L,21L,5L,2L,1L,15L,1L,0L,46L,1L,25L,2L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263112Inst : IEnumerable<long>
{
public static readonly long[] Value=A263112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263112.Bytes);
public long this[int i]=>Value[i];

public static A263112Inst Instance=new A263112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263113
{
public static readonly long[] Value={ 102L,690L,4614L,28626L,173010L,1049016L,6331494L,37989042L,228197310L,1370694210L,8222465730L,49340098992L,296102474742L,1776497631810L,10659057309654L,63956883880626L,383735173287090L,2302409993685096L,13814564261860614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263113Inst : IEnumerable<long>
{
public static readonly long[] Value=A263113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263113.Bytes);
public long this[int i]=>Value[i];

public static A263113Inst Instance=new A263113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263114
{
public static readonly long[] Value={ 690L,12295L,186793L,2451774L,32967539L,436704585L,5681806458L,74169569127L,966450565505L,12565068890934L,163422952675987L,2125079662900321L,27626397338646690L,359160833412536727L,4669231561448806233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263114Inst : IEnumerable<long>
{
public static readonly long[] Value=A263114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263114.Bytes);
public long this[int i]=>Value[i];

public static A263114Inst Instance=new A263114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263115
{
public static readonly BigInteger[] Value={ 4614L,186793L,6131873L,165679122L,4679372053L,129402530117L,3494107918878L,94864200490265L,2568991742459225L,69363731498249226L,1874047670735548853L,BigInteger.Parse("50617580641931920797"),BigInteger.Parse("1366677283235664365094"),BigInteger.Parse("36903016719523510116201") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263115Inst Instance=new A263115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263116
{
public static readonly BigInteger[] Value={ 28626L,2451774L,165679122L,8973167514L,510985828470L,28342984553670L,1530508039933938L,83206719012737838L,4508387196335847570L,BigInteger.Parse("243451005609403209066"),BigInteger.Parse("13157531041392145899030"),BigInteger.Parse("710808868574546427138918") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263116Inst Instance=new A263116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263117
{
public static readonly long[] Value={ 102L,690L,690L,4614L,12295L,4614L,28626L,186793L,186793L,28626L,173010L,2451774L,6131873L,2451774L,173010L,1049016L,32967539L,165679122L,165679122L,32967539L,1049016L,6331494L,436704585L,4679372053L,8973167514L,4679372053L,436704585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263117Inst : IEnumerable<long>
{
public static readonly long[] Value=A263117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263117.Bytes);
public long this[int i]=>Value[i];

public static A263117Inst Instance=new A263117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263118
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,10L,11L,18L,20L,29L,33L,70L,115L,116L,133L,136L,155L,156L,157L,212L,255L,360L,414L,468L,470L,477L,518L,519L,578L,771L,787L,830L,971L,1039L,1046L,1121L,1687L,1793L,2983L,3092L,3359L,3360L,3570L,4084L,4190L,4255L,5281L,7032L,7141L,7167L,8248L,8385L,8386L,8630L,8890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263118Inst : IEnumerable<long>
{
public static readonly long[] Value=A263118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263118.Bytes);
public long this[int i]=>Value[i];

public static A263118Inst Instance=new A263118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263119
{
public static readonly long[] Value={ 14L,29L,59L,119L,238L,477L,955L,1911L,3822L,7645L,15291L,30583L,61166L,122333L,244667L,489335L,978670L,1957341L,3914683L,7829367L,15658734L,31317469L,62634939L,125269879L,250539758L,501079517L,1002159035L,2004318071L,4008636142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263119Inst : IEnumerable<long>
{
public static readonly long[] Value=A263119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263119.Bytes);
public long this[int i]=>Value[i];

public static A263119Inst Instance=new A263119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263120
{
public static readonly long[] Value={ 36L,148L,522L,1708L,5124L,15640L,47602L,144236L,432708L,1295524L,3883594L,11649676L,34949028L,104703688L,313818418L,940969804L,2822909412L,8465899188L,25390861962L,76159749740L,228479249220L,685409187320L,2056136698226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263120Inst : IEnumerable<long>
{
public static readonly long[] Value=A263120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263120.Bytes);
public long this[int i]=>Value[i];

public static A263120Inst Instance=new A263120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263121
{
public static readonly long[] Value={ 168L,1664L,10356L,56288L,238104L,1294448L,6844676L,35274768L,166684808L,837700064L,4262833076L,21682367296L,106913755512L,530662478800L,2665248077636L,13441453266928L,67154044231144L,333650046421056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263121Inst : IEnumerable<long>
{
public static readonly long[] Value=A263121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263121.Bytes);
public long this[int i]=>Value[i];

public static A263121Inst Instance=new A263121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263122
{
public static readonly long[] Value={ 912L,28048L,316392L,3049840L,16751376L,216762400L,2168966344L,20154887792L,138240703248L,1449388911184L,14047136614696L,130631050676464L,1009951152099984L,9665650741329760L,91463371579618312L,848124382235101936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263122Inst : IEnumerable<long>
{
public static readonly long[] Value=A263122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263122.Bytes);
public long this[int i]=>Value[i];

public static A263122Inst Instance=new A263122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263123
{
public static readonly long[] Value={ 52446L,887805L,17782827L,344322375L,6946980030L,113558538589L,2022945129963L,36861501672007L,713132356848318L,12055652684915197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263123Inst : IEnumerable<long>
{
public static readonly long[] Value=A263123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263123.Bytes);
public long this[int i]=>Value[i];

public static A263123Inst Instance=new A263123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263124
{
public static readonly long[] Value={ 14L,36L,29L,168L,148L,59L,912L,1664L,522L,119L,52446L,28048L,10356L,1708L,238L,502800L,887805L,316392L,56288L,5124L,477L,5950176L,21881010L,17782827L,3049840L,238104L,15640L,955L,79674864L,583371100L,881938092L,344322375L,16751376L,1294448L,47602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263124Inst : IEnumerable<long>
{
public static readonly long[] Value=A263124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263124.Bytes);
public long this[int i]=>Value[i];

public static A263124Inst Instance=new A263124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263125
{
public static readonly long[] Value={ 14L,36L,168L,912L,52446L,502800L,5950176L,79674864L,1150876510L,15833668596L,219803283432L,3071596572336L,43104942680030L,602744107942848L,8433329018112000L,118048179597057360L,1652891095755395934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263125Inst : IEnumerable<long>
{
public static readonly long[] Value=A263125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263125.Bytes);
public long this[int i]=>Value[i];

public static A263125Inst Instance=new A263125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263126
{
public static readonly ulong[] Value={ 29L,148L,1664L,28048L,887805L,21881010L,583371100L,16245282600L,474350516221L,13614396562020L,392816467987240L,11368863651747952L,329881756982246141L,9560756720430691666UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263126Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A263126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263126.Bytes);
public ulong this[int i]=>Value[i];

public static A263126Inst Instance=new A263126Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263127
{
public static readonly long[] Value={ 59L,522L,10356L,316392L,17782827L,881938092L,47672389112L,2695098564336L,159284816028475L,9294738455527194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263127Inst : IEnumerable<long>
{
public static readonly long[] Value=A263127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263127.Bytes);
public long this[int i]=>Value[i];

public static A263127Inst Instance=new A263127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263128
{
public static readonly long[] Value={ 119L,1708L,56288L,3049840L,344322375L,33563774112L,3600054345088L,406348635796752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263128Inst : IEnumerable<long>
{
public static readonly long[] Value=A263128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263128.Bytes);
public long this[int i]=>Value[i];

public static A263128Inst Instance=new A263128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263129
{
public static readonly long[] Value={ 1024538L,1024675L,1024789L,1024837L,1024936L,1025347L,1025378L,1025384L,1026593L,10234987L,10236597L,10236758L,10258346L,10259347L,10267845L,10278534L,10283546L,10293486L,10293675L,10294837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263129Inst : IEnumerable<long>
{
public static readonly long[] Value=A263129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263129.Bytes);
public long this[int i]=>Value[i];

public static A263129Inst Instance=new A263129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263130
{
public static readonly BigInteger[] Value={ 1L,5L,21L,17L,633L,23L,36153L,65L,93L,635L,443122713L,71L,81474226713L,36155L,645L,113L,6069010670156313L,95L,2318037293294156313L,641L,36165L,443122715L,BigInteger.Parse("595774037991797891660313"),119L,4233L,81474226715L,453L,36161L,BigInteger.Parse("256727294482662730300616548940313"),647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263130Inst Instance=new A263130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263131
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,1L,2L,3L,4L,5L,16L,17L,18L,19L,6L,7L,8L,9L,10L,1L,20L,21L,22L,11L,12L,13L,14L,2L,15L,3L,23L,24L,16L,17L,18L,4L,19L,5L,20L,6L,25L,26L,21L,22L,23L,24L,7L,25L,8L,9L,27L,28L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263131Inst : IEnumerable<long>
{
public static readonly long[] Value=A263131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263131.Bytes);
public long this[int i]=>Value[i];

public static A263131Inst Instance=new A263131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263132
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,12L,16L,22L,24L,32L,43L,44L,48L,64L,86L,88L,96L,128L,171L,172L,176L,192L,256L,342L,344L,352L,384L,512L,683L,684L,688L,704L,768L,1024L,1366L,1368L,1376L,1408L,1536L,2048L,2731L,2732L,2736L,2752L,2816L,3072L,4096L,5462L,5464L,5472L,5504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263132Inst : IEnumerable<long>
{
public static readonly long[] Value=A263132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263132.Bytes);
public long this[int i]=>Value[i];

public static A263132Inst Instance=new A263132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263133
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,10L,11L,15L,21L,23L,31L,42L,43L,47L,63L,85L,87L,95L,127L,170L,171L,175L,191L,255L,341L,343L,351L,383L,511L,682L,683L,687L,703L,767L,1023L,1365L,1367L,1375L,1407L,1535L,2047L,2730L,2731L,2735L,2751L,2815L,3071L,4095L,5461L,5463L,5471L,5503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263133Inst : IEnumerable<long>
{
public static readonly long[] Value=A263133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263133.Bytes);
public long this[int i]=>Value[i];

public static A263133Inst Instance=new A263133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263134
{
public static readonly long[] Value={ 1L,5L,26L,146L,861L,5229L,32361L,202905L,1284480L,8191380L,52543545L,338641305L,2191124301L,14224347181L,92603307541L,604342068085L,3952451061076L,25898039418496L,169977746765071L,1117287239602471L,7353933943361866L,48461930821297546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263134Inst : IEnumerable<long>
{
public static readonly long[] Value=A263134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263134.Bytes);
public long this[int i]=>Value[i];

public static A263134Inst Instance=new A263134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263135
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,15L,16L,17L,19L,20L,21L,23L,24L,25L,27L,28L,30L,31L,32L,34L,35L,36L,38L,39L,41L,42L,43L,45L,46L,48L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,63L,64L,66L,67L,69L,70L,72L,73L,74L,76L,77L,79L,80L,81L,83L,84L,86L,87L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263135Inst : IEnumerable<long>
{
public static readonly long[] Value=A263135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263135.Bytes);
public long this[int i]=>Value[i];

public static A263135Inst Instance=new A263135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263136
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,2L,0L,1L,2L,3L,1L,2L,6L,5L,2L,6L,11L,7L,6L,15L,21L,12L,15L,30L,34L,22L,35L,58L,59L,43L,70L,108L,95L,85L,142L,187L,161L,167L,263L,318L,274L,318L,480L,534L,471L,595L,836L,879L,819L,1081L,1433L,1442L,1429L,1915L,2391L,2365L,2483L,3314L,3947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263136Inst : IEnumerable<long>
{
public static readonly long[] Value=A263136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263136.Bytes);
public long this[int i]=>Value[i];

public static A263136Inst Instance=new A263136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263137
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,3L,3L,3L,6L,9L,9L,9L,13L,19L,23L,23L,28L,42L,51L,56L,62L,84L,108L,120L,133L,170L,219L,253L,276L,335L,427L,503L,556L,650L,815L,977L,1090L,1244L,1525L,1836L,2079L,2344L,2808L,3386L,3876L,4348L,5107L,6121L,7069L,7932L,9176L,10918L,12671L,14257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263137Inst : IEnumerable<long>
{
public static readonly long[] Value=A263137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263137.Bytes);
public long this[int i]=>Value[i];

public static A263137Inst Instance=new A263137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263138
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,2L,0L,0L,2L,3L,0L,0L,4L,4L,0L,1L,10L,5L,0L,6L,16L,6L,0L,14L,28L,7L,3L,32L,40L,8L,10L,63L,60L,9L,33L,112L,80L,13L,74L,187L,110L,25L,161L,300L,140L,58L,308L,455L,183L,133L,568L,672L,236L,297L,968L,963L,321L,609L,1609L,1344L,468L,1188L,2546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263138Inst : IEnumerable<long>
{
public static readonly long[] Value=A263138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263138.Bytes);
public long this[int i]=>Value[i];

public static A263138Inst Instance=new A263138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263139
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,2L,2L,0L,0L,3L,4L,1L,0L,4L,10L,6L,0L,5L,16L,14L,3L,6L,28L,32L,10L,7L,40L,63L,33L,11L,60L,112L,74L,23L,80L,187L,161L,56L,111L,300L,308L,131L,152L,455L,568L,295L,223L,672L,968L,607L,356L,967L,1609L,1186L,618L,1367L,2546L,2189L,1132L,1926L,3941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263139Inst : IEnumerable<long>
{
public static readonly long[] Value=A263139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263139.Bytes);
public long this[int i]=>Value[i];

public static A263139Inst Instance=new A263139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263140
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,3L,4L,5L,10L,11L,16L,20L,31L,39L,50L,71L,93L,124L,154L,211L,271L,357L,449L,587L,762L,968L,1233L,1571L,2021L,2535L,3220L,4049L,5145L,6431L,8070L,10105L,12670L,15784L,19619L,24447L,30348L,37635L,46464L,57532L,70945L,87477L,107456L,132192L,162220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263140Inst : IEnumerable<long>
{
public static readonly long[] Value=A263140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263140.Bytes);
public long this[int i]=>Value[i];

public static A263140Inst Instance=new A263140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263141
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,1L,2L,6L,4L,1L,2L,6L,10L,6L,2L,6L,14L,20L,8L,6L,14L,29L,30L,13L,14L,34L,54L,50L,22L,34L,66L,99L,74L,43L,72L,133L,166L,119L,82L,148L,242L,276L,182L,166L,286L,438L,442L,301L,316L,541L,744L,701L,494L,608L,976L,1255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263141Inst : IEnumerable<long>
{
public static readonly long[] Value=A263141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263141.Bytes);
public long this[int i]=>Value[i];

public static A263141Inst Instance=new A263141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263142
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,2L,1L,3L,2L,1L,6L,2L,5L,6L,2L,11L,6L,7L,15L,6L,21L,15L,12L,30L,15L,34L,35L,22L,58L,35L,59L,70L,43L,108L,76L,95L,142L,85L,187L,157L,161L,263L,174L,318L,307L,274L,480L,336L,534L,583L,479L,836L,649L,879L,1068L,840L,1433L,1211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263142Inst : IEnumerable<long>
{
public static readonly long[] Value=A263142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263142.Bytes);
public long this[int i]=>Value[i];

public static A263142Inst Instance=new A263142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263143
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,4L,2L,7L,2L,7L,6L,7L,12L,7L,16L,12L,16L,26L,16L,35L,22L,40L,44L,40L,68L,47L,80L,84L,86L,133L,94L,167L,146L,182L,238L,198L,314L,274L,358L,431L,386L,593L,494L,696L,754L,761L,1056L,917L,1288L,1326L,1430L,1880L,1664L,2348L,2290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263143Inst : IEnumerable<long>
{
public static readonly long[] Value=A263143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263143.Bytes);
public long this[int i]=>Value[i];

public static A263143Inst Instance=new A263143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263144
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,3L,3L,3L,3L,6L,9L,9L,9L,9L,13L,19L,23L,23L,23L,28L,42L,51L,56L,56L,62L,84L,108L,120L,126L,133L,170L,219L,253L,268L,283L,335L,427L,503L,547L,574L,658L,815L,977L,1080L,1144L,1265L,1534L,1836L,2068L,2209L,2408L,2832L,3396L,3864L,4178L,4505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263144Inst : IEnumerable<long>
{
public static readonly long[] Value=A263144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263144.Bytes);
public long this[int i]=>Value[i];

public static A263144Inst Instance=new A263144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263145
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,2L,3L,0L,0L,0L,4L,4L,0L,0L,1L,10L,5L,0L,0L,6L,16L,6L,0L,0L,14L,28L,7L,0L,3L,32L,40L,8L,0L,10L,63L,60L,9L,0L,33L,112L,80L,10L,3L,74L,187L,110L,11L,14L,161L,300L,140L,12L,46L,308L,455L,182L,14L,120L,568L,672L,224L,26L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263145Inst : IEnumerable<long>
{
public static readonly long[] Value=A263145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263145.Bytes);
public long this[int i]=>Value[i];

public static A263145Inst Instance=new A263145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263146
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,2L,0L,3L,0L,0L,4L,0L,4L,1L,0L,10L,0L,5L,6L,0L,16L,0L,6L,14L,0L,28L,3L,7L,32L,0L,40L,10L,8L,63L,0L,60L,33L,9L,112L,3L,80L,74L,10L,187L,14L,110L,161L,11L,300L,46L,140L,308L,13L,455L,120L,182L,568L,25L,672L,283L,224L,968L,55L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263146Inst : IEnumerable<long>
{
public static readonly long[] Value=A263146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263146.Bytes);
public long this[int i]=>Value[i];

public static A263146Inst Instance=new A263146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263147
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,2L,0L,2L,0L,0L,3L,0L,4L,0L,1L,4L,0L,10L,0L,6L,5L,0L,16L,0L,14L,6L,3L,28L,0L,32L,7L,10L,40L,0L,63L,8L,33L,60L,3L,112L,9L,74L,80L,14L,187L,10L,161L,110L,46L,300L,12L,308L,140L,120L,455L,24L,568L,182L,283L,672L,54L,968L,224L,594L,963L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263147Inst : IEnumerable<long>
{
public static readonly long[] Value=A263147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263147.Bytes);
public long this[int i]=>Value[i];

public static A263147Inst Instance=new A263147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263148
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,2L,2L,0L,0L,0L,3L,4L,1L,0L,0L,4L,10L,6L,0L,0L,5L,16L,14L,3L,0L,6L,28L,32L,10L,0L,7L,40L,63L,33L,3L,8L,60L,112L,74L,14L,9L,80L,187L,161L,46L,11L,110L,300L,308L,120L,23L,140L,455L,568L,283L,53L,182L,672L,968L,594L,145L,228L,963L,1609L,1172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263148Inst : IEnumerable<long>
{
public static readonly long[] Value=A263148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263148.Bytes);
public long this[int i]=>Value[i];

public static A263148Inst Instance=new A263148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263149
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,2L,0L,3L,2L,4L,4L,5L,10L,7L,16L,13L,28L,22L,40L,41L,63L,73L,90L,123L,143L,199L,214L,316L,343L,483L,532L,733L,848L,1099L,1305L,1644L,2029L,2448L,3067L,3657L,4643L,5443L,6892L,8107L,10224L,12031L,14974L,17798L,21941L,26190L,31867L,38381L,46300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263149Inst : IEnumerable<long>
{
public static readonly long[] Value=A263149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263149.Bytes);
public long this[int i]=>Value[i];

public static A263149Inst Instance=new A263149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263150
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,2L,1L,3L,2L,5L,6L,7L,11L,12L,21L,22L,34L,38L,59L,67L,95L,118L,155L,198L,252L,330L,409L,540L,662L,867L,1067L,1382L,1705L,2187L,2705L,3430L,4267L,5348L,6666L,8303L,10352L,12812L,15964L,19681L,24467L,30091L,37282L,45769L,56539L,69296L,85304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263150Inst : IEnumerable<long>
{
public static readonly long[] Value=A263150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263150.Bytes);
public long this[int i]=>Value[i];

public static A263150Inst Instance=new A263150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263151
{
public static readonly long[] Value={ 4L,5L,9L,1L,1L,7L,4L,2L,9L,8L,7L,8L,5L,2L,7L,6L,1L,4L,8L,0L,6L,8L,5L,9L,6L,0L,9L,8L,3L,7L,8L,9L,8L,0L,7L,7L,5L,1L,9L,5L,6L,6L,4L,4L,0L,7L,2L,7L,7L,1L,6L,6L,9L,6L,7L,8L,5L,9L,9L,5L,0L,6L,9L,3L,2L,8L,8L,2L,1L,9L,3L,2L,5L,3L,6L,8L,2L,6L,6L,2L,5L,3L,3L,6L,8L,1L,8L,8L,8L,5L,2L,4L,7L,5L,7L,9L,5L,2L,3L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263151Inst : IEnumerable<long>
{
public static readonly long[] Value=A263151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263151.Bytes);
public long this[int i]=>Value[i];

public static A263151Inst Instance=new A263151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263152
{
public static readonly long[] Value={ 1L,5L,1L,1L,1L,1L,11L,13L,17L,1L,1L,19L,3L,23L,3L,25L,29L,1L,31L,1L,37L,41L,5L,43L,47L,7L,53L,3L,1L,55L,7L,2L,1L,59L,61L,9L,65L,67L,71L,9L,73L,11L,79L,83L,85L,11L,5L,5L,89L,11L,13L,95L,97L,101L,103L,13L,11L,107L,109L,113L,115L,4L,121L,17L,7L,125L,13L,127L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263152Inst : IEnumerable<long>
{
public static readonly long[] Value=A263152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263152.Bytes);
public long this[int i]=>Value[i];

public static A263152Inst Instance=new A263152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263153
{
public static readonly BigInteger[] Value={ 23966L,323572L,4345200L,63755349L,913603171L,12918908831L,180717447506L,2526833145412L,35334275421824L,495175192858165L,6936152367154135L,97125217002643101L,1359727874296720126L,BigInteger.Parse("19035465628546193860") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263153Inst Instance=new A263153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263154
{
public static readonly BigInteger[] Value={ 323572L,8931088L,245494656L,7221845601L,207234582577L,5870470309217L,164305252236788L,4597718152103888L,128663068539081984L,3605834760370442889L,BigInteger.Parse("101010828418284459649"),BigInteger.Parse("2828873918666109937857"),BigInteger.Parse("79207730255146359876596") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263154Inst Instance=new A263154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263155
{
public static readonly long[] Value={ 4345200L,245494656L,13895461376L,818220821498L,46999429421814L,2667613654543478L,149379294213832624L,8365622828874611456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263155Inst : IEnumerable<long>
{
public static readonly long[] Value=A263155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263155.Bytes);
public long this[int i]=>Value[i];

public static A263155Inst Instance=new A263155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263156
{
public static readonly long[] Value={ 23966L,323572L,323572L,4345200L,8931088L,4345200L,63755349L,245494656L,245494656L,63755349L,913603171L,7221845601L,13895461376L,7221845601L,913603171L,12918908831L,207234582577L,818220821498L,818220821498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263156Inst : IEnumerable<long>
{
public static readonly long[] Value=A263156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263156.Bytes);
public long this[int i]=>Value[i];

public static A263156Inst Instance=new A263156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263157
{
public static readonly long[] Value={ 1L,5L,3L,3L,7L,7L,2L,3L,0L,2L,3L,1L,0L,2L,4L,3L,5L,6L,7L,1L,7L,2L,8L,5L,6L,0L,1L,6L,7L,2L,2L,5L,7L,8L,9L,9L,4L,6L,1L,0L,1L,2L,9L,5L,1L,8L,9L,4L,2L,7L,5L,5L,4L,9L,1L,9L,6L,1L,7L,6L,0L,6L,6L,6L,0L,9L,5L,9L,3L,7L,9L,1L,3L,2L,0L,0L,6L,0L,8L,8L,8L,3L,3L,9L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263157Inst : IEnumerable<long>
{
public static readonly long[] Value=A263157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263157.Bytes);
public long this[int i]=>Value[i];

public static A263157Inst Instance=new A263157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263158
{
public static readonly BigInteger[] Value={ 1L,9L,241L,15177L,1871761L,400086249L,136109095921L,69234116652297L,50204612238691921L,BigInteger.Parse("49984961118827342889"),BigInteger.Parse("66285608345755685396401"),BigInteger.Parse("114183585213704219683871817"),BigInteger.Parse("250186610841184605935378238481"),BigInteger.Parse("684906688327788169186039802989929"),BigInteger.Parse("2306818395080969813211747978667981681") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263158Inst Instance=new A263158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263159
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,7L,13L,1L,1L,1L,15L,157L,63L,1L,1L,1L,31L,2101L,5419L,321L,1L,1L,1L,63L,32461L,717795L,220561L,1683L,1L,1L,1L,127L,580693L,142090291L,328504401L,9763807L,8989L,1L,1L,1L,255L,11917837L,39991899123L,944362553521L,172924236255L,454635973L,48639L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263159Inst : IEnumerable<long>
{
public static readonly long[] Value=A263159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263159.Bytes);
public long this[int i]=>Value[i];

public static A263159Inst Instance=new A263159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263160
{
public static readonly BigInteger[] Value={ 1L,1L,13L,5419L,328504401L,7622403922836151L,BigInteger.Parse("125076804896889941384267749"),BigInteger.Parse("2283244029676857615289372083169016508547"),BigInteger.Parse("66656513992169790340795231563272399566454175106315563265"),BigInteger.Parse("4218602489837041203989313097616905233039652652837921715487541815010092122991") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263160Inst Instance=new A263160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263161
{
public static readonly long[] Value={ 1L,240L,600L,768L,1008L,1200L,1320L,1800L,2160L,2688L,2736L,3000L,3360L,3888L,4800L,5280L,5520L,6120L,6479L,6480L,6720L,6840L,7320L,7680L,8208L,8640L,9000L,9600L,9720L,10368L,11160L,11663L,12240L,12288L,13200L,13248L,13440L,13680L,14400L,15120L,15360L,15456L,16560L,18048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263161Inst : IEnumerable<long>
{
public static readonly long[] Value=A263161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263161.Bytes);
public long this[int i]=>Value[i];

public static A263161Inst Instance=new A263161Inst();

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