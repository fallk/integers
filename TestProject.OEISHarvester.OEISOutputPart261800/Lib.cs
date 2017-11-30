using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278690
{
public static readonly long[] Value={ 1L,2L,5L,9L,18L,31L,54L,88L,144L,225L,351L,531L,800L,1179L,1728L,2492L,3573L,5058L,7119L,9918L,13743L,18882L,25810L,35028L,47313L,63513L,84883L,112833L,149373L,196803L,258309L,337590L,439650L,570357L,737496L,950270L,1220688L,1563021L,1995642L,2540466L,3225386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278690Inst : IEnumerable<long>
{
public static readonly long[] Value=A278690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278690.Bytes);
public long this[int i]=>Value[i];

public static A278690Inst Instance=new A278690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278691
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,22L,60L,176L,565L,1980L,7528L,30843L,135248L,630004L,3097780L,15991395L,86267557L,484446620L,2822677523L,17017165987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278691Inst : IEnumerable<long>
{
public static readonly long[] Value=A278691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278691.Bytes);
public long this[int i]=>Value[i];

public static A278691Inst Instance=new A278691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278740
{
public static readonly long[] Value={ 577L,5569L,29251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278740Inst : IEnumerable<long>
{
public static readonly long[] Value=A278740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278740.Bytes);
public long this[int i]=>Value[i];

public static A278740Inst Instance=new A278740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278741
{
public static readonly BigInteger[] Value={ 3L,5L,17L,65L,1025L,4097L,65537L,262145L,4194305L,268435457L,1073741825L,68719476737L,1099511627777L,4398046511105L,70368744177665L,4503599627370497L,288230376151711745L,1152921504606846977L,BigInteger.Parse("73786976294838206465"),BigInteger.Parse("1180591620717411303425"),BigInteger.Parse("4722366482869645213697") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278741Inst Instance=new A278741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278742
{
public static readonly long[] Value={ 1L,2L,3L,10L,11L,12L,20L,30L,100L,110L,200L,300L,1000L,1100L,2000L,2100L,3000L,10000L,20000L,30000L,100000L,110000L,120000L,200000L,300000L,1000000L,1100000L,2000000L,3000000L,10000000L,11000000L,20000000L,21000000L,30000000L,100000000L,200000000L,300000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278742Inst : IEnumerable<long>
{
public static readonly long[] Value=A278742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278742.Bytes);
public long this[int i]=>Value[i];

public static A278742Inst Instance=new A278742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278743
{
public static readonly long[] Value={ 1L,3L,2L,5L,9L,3L,7L,4L,17L,4L,9L,15L,21L,11L,5L,11L,25L,25L,13L,7L,6L,13L,7L,29L,15L,16L,25L,7L,15L,9L,33L,17L,10L,28L,57L,8L,17L,49L,37L,19L,10L,31L,63L,21L,9L,19L,43L,41L,21L,34L,34L,69L,23L,12L,10L,21L,13L,45L,23L,51L,37L,75L,25L,13L,67L,11L,23L,42L,49L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278743Inst : IEnumerable<long>
{
public static readonly long[] Value=A278743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278743.Bytes);
public long this[int i]=>Value[i];

public static A278743Inst Instance=new A278743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278744
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,2L,3L,3L,3L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,2L,2L,5L,5L,3L,2L,2L,3L,2L,2L,3L,3L,3L,2L,2L,2L,2L,3L,3L,3L,2L,2L,5L,2L,4L,2L,2L,3L,3L,2L,2L,3L,3L,5L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,3L,4L,3L,3L,4L,2L,2L,2L,4L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278744Inst : IEnumerable<long>
{
public static readonly long[] Value=A278744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278744.Bytes);
public long this[int i]=>Value[i];

public static A278744Inst Instance=new A278744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278745
{
public static readonly BigInteger[] Value={ 1L,-3L,23L,-232L,2671L,-33247L,435732L,-5923596L,82761455L,-1181085841L,17143012047L,-252288796800L,3755832135428L,-56459641712052L,855828940166728L,-13066760979482436L,200764834403473647L,-3101861571115286485L,BigInteger.Parse("48161808069368073765"),BigInteger.Parse("-751107354803633628504"),BigInteger.Parse("11760546724914570170423"),BigInteger.Parse("-184805245095048170080367"),BigInteger.Parse("2913533082844307942651984"),BigInteger.Parse("-46070266558711138024672784"),BigInteger.Parse("730480047034266200626268676") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278745Inst Instance=new A278745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278746
{
public static readonly BigInteger[] Value={ 2L,0L,6L,-24L,-1206L,8280L,-52858L,938952L,6413418L,-322109160L,4068033894L,-98801788536L,1090129290506L,34232660705880L,-1166338051942842L,34835919349322568L,-1017978660373211478L,3062745246204921240L,BigInteger.Parse("652008392567134637606"),BigInteger.Parse("-31153686390303760362744"),BigInteger.Parse("1444941725264797489895754"),BigInteger.Parse("-36336350568529387378761000"),BigInteger.Parse("-147853882235572672805585658"),BigInteger.Parse("47707556073396637481524345032") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278746Inst Instance=new A278746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278747
{
public static readonly BigInteger[] Value={ 1L,0L,-8L,16L,-72L,640L,6104L,-111888L,1030936L,-20710880L,100278648L,4259777104L,-94939798408L,2751909451200L,-58236639534824L,-39216365862992L,24727871486377944L,-1101102078005724320L,BigInteger.Parse("44631782004871587512"),BigInteger.Parse("-817413918683643301104"),BigInteger.Parse("-4171285737904116490952"),BigInteger.Parse("886660889034497668791040"),BigInteger.Parse("-61749974510623878990175656"),BigInteger.Parse("2477592883027309467158246512"),BigInteger.Parse("-46339606028330299058527712104"),BigInteger.Parse("-475992376656052398134320429920") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278747Inst Instance=new A278747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278748
{
public static readonly BigInteger[] Value={ 2L,0L,2L,-8L,-90L,520L,-566L,50904L,396710L,-18390200L,131511978L,-3005766632L,33380803270L,1757150970120L,-44857682845174L,950900072932696L,-28165020555314970L,-73025855982929720L,BigInteger.Parse("24480067437941915242"),BigInteger.Parse("-834839712703258127208"),BigInteger.Parse("34458996334508149067270"),BigInteger.Parse("-773502135061735864720760"),BigInteger.Parse("-12427737319809527785823286"),BigInteger.Parse("1295375801958445816867049944"),BigInteger.Parse("-74746823183505251943756410330"),BigInteger.Parse("3392808342679593497307739258440") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278748Inst Instance=new A278748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278749
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,9L,39L,189L,1137L,7521L,58221L,487521L,4615623L,46747449L,523484019L,6218441469L,80413567317L,1095843999681L,16072230046041L,247107215918241L,4053246141598443L,69395454770712489L,1258826280827924799L,BigInteger.Parse("23749475226740969949"),BigInteger.Parse("472083799922946212697"),BigInteger.Parse("9730211267060692468641"),BigInteger.Parse("210327336751547848824261"),BigInteger.Parse("4701988645468367963255361"),BigInteger.Parse("109812853605044722106919663") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278749Inst Instance=new A278749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278750
{
public static readonly BigInteger[] Value={ 1L,3L,39L,1137L,58221L,4615623L,523484019L,80413567317L,16072230046041L,4053246141598443L,1258826280827924799L,BigInteger.Parse("472083799922946212697"),BigInteger.Parse("210327336751547848824261"),BigInteger.Parse("109812853605044722106919663"),BigInteger.Parse("66408636977597058929358851979"),BigInteger.Parse("46050900932480002492822649518077"),BigInteger.Parse("36298045342567148350546493472175281"),BigInteger.Parse("32270728864033978097224807327165446483") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278750Inst Instance=new A278750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278751
{
public static readonly BigInteger[] Value={ 1L,1L,9L,189L,7521L,487521L,46747449L,6218441469L,1095843999681L,247107215918241L,69395454770712489L,BigInteger.Parse("23749475226740969949"),BigInteger.Parse("9730211267060692468641"),BigInteger.Parse("4701988645468367963255361"),BigInteger.Parse("2646445420099664470709050329"),BigInteger.Parse("1716219921297572244824026206429"),BigInteger.Parse("1270397446103310826052689818531201"),BigInteger.Parse("1064625039709386056552002053304422081"),BigInteger.Parse("1002754938675070351849016638991347652169") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278751Inst Instance=new A278751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278752
{
public static readonly BigInteger[] Value={ 1L,1L,6L,114L,4224L,258696L,23685696L,3030422544L,516368179584L,113039478326016L,30915842271630336L,10330366155858849024UL,BigInteger.Parse("4141017299122378758144"),BigInteger.Parse("1961342355370645525671936"),BigInteger.Parse("1083606291089708175858917376"),BigInteger.Parse("690681085734140756895484053504"),BigInteger.Parse("503068200949361929673857570504704"),BigInteger.Parse("415234815803178624028164344747360256"),BigInteger.Parse("385549194671700625768876635402899030016") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278752Inst Instance=new A278752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278753
{
public static readonly BigInteger[] Value={ 1L,0L,11L,1000L,111L,110000L,1111L,11100000L,11111L,1111000000L,111111L,111110000000L,1111111L,11111100000000L,11111111L,1111111000000000L,111111111L,111111110000000000L,1111111111L,11111111100000000000UL,11111111111L,BigInteger.Parse("1111111111000000000000"),111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278753Inst Instance=new A278753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278754
{
public static readonly BigInteger[] Value={ 1L,0L,110L,1L,11100L,11L,1111000L,111L,111110000L,1111L,11111100000L,11111L,1111111000000L,111111L,111111110000000L,1111111L,11111111100000000L,11111111L,1111111111000000000L,111111111L,BigInteger.Parse("111111111110000000000"),1111111111L,BigInteger.Parse("11111111111100000000000"),11111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278754Inst Instance=new A278754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278755
{
public static readonly long[] Value={ 1L,0L,3L,8L,7L,48L,15L,224L,31L,960L,63L,3968L,127L,16128L,255L,65024L,511L,261120L,1023L,1046528L,2047L,4190208L,4095L,16769024L,8191L,67092480L,16383L,268402688L,32767L,1073676288L,65535L,4294836224L,131071L,17179607040L,262143L,68718952448L,524287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278755Inst : IEnumerable<long>
{
public static readonly long[] Value=A278755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278755.Bytes);
public long this[int i]=>Value[i];

public static A278755Inst Instance=new A278755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278804
{
public static readonly long[] Value={ 21L,336L,5767L,110455L,2179956L,41299256L,725674326L,11698232451L,172994405326L,2356249442222L,29713542257399L,348752692539813L,3828597575581476L,39486426123589674L,384123325152744838L,3537191225894230125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278804Inst : IEnumerable<long>
{
public static readonly long[] Value=A278804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278804.Bytes);
public long this[int i]=>Value[i];

public static A278804Inst Instance=new A278804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278805
{
public static readonly BigInteger[] Value={ 28L,672L,20972L,870473L,41299256L,1976588468L,89730161098L,3776527762052L,146582077597322L,5255148833158068L,174697385422916429L,5408652963998274118L,BigInteger.Parse("156617481905320805788"),BigInteger.Parse("4258375831859896074183"),BigInteger.Parse("109105728055490259454053") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278805Inst Instance=new A278805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278806
{
public static readonly BigInteger[] Value={ 36L,1254L,69834L,6275546L,725674326L,89730161098L,10811999412826L,1224101415304069L,128795068372302728L,12581278164317910030UL,BigInteger.Parse("1143931690129837256876"),BigInteger.Parse("97156838914464540981998") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278806Inst Instance=new A278806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278807
{
public static readonly long[] Value={ 3L,6L,6L,10L,22L,10L,15L,63L,63L,15L,21L,154L,322L,154L,21L,28L,336L,1439L,1439L,336L,28L,36L,672L,5767L,12958L,5767L,672L,36L,45L,1254L,20972L,110455L,110455L,20972L,1254L,45L,55L,2211L,69834L,870473L,2179956L,870473L,69834L,2211L,55L,66L,3718L,214774L,6275546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278807Inst : IEnumerable<long>
{
public static readonly long[] Value=A278807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278807.Bytes);
public long this[int i]=>Value[i];

public static A278807Inst Instance=new A278807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278808
{
public static readonly long[] Value={ 2L,8L,7L,1L,8L,8L,0L,8L,2L,7L,0L,4L,5L,4L,5L,4L,6L,5L,8L,8L,9L,0L,5L,5L,1L,7L,5L,5L,0L,4L,5L,7L,5L,0L,4L,5L,8L,6L,5L,6L,5L,2L,5L,1L,1L,8L,4L,7L,9L,6L,5L,6L,5L,6L,7L,9L,2L,9L,9L,5L,4L,0L,1L,0L,8L,4L,0L,4L,5L,7L,9L,6L,8L,3L,0L,8L,9L,2L,7L,0L,3L,6L,0L,1L,8L,2L,8L,6L,3L,8L,1L,8L,6L,7L,6L,7L,8L,7L,5L,4L,8L,0L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278808Inst : IEnumerable<long>
{
public static readonly long[] Value=A278808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278808.Bytes);
public long this[int i]=>Value[i];

public static A278808Inst Instance=new A278808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278809
{
public static readonly long[] Value={ 1L,0L,8L,2L,8L,7L,3L,6L,0L,9L,5L,2L,0L,7L,3L,8L,6L,9L,4L,0L,8L,2L,8L,5L,0L,3L,1L,3L,4L,5L,3L,1L,0L,0L,8L,0L,2L,5L,7L,8L,6L,3L,4L,5L,4L,7L,8L,5L,3L,8L,5L,0L,6L,4L,3L,2L,8L,8L,4L,7L,8L,2L,1L,6L,8L,0L,6L,9L,2L,2L,7L,8L,8L,9L,5L,2L,9L,9L,5L,5L,7L,4L,7L,0L,6L,8L,1L,4L,4L,8L,7L,8L,6L,2L,3L,9L,2L,4L,4L,3L,1L,1L,5L,4L,5L,9L,9L,1L,8L,9L,2L,4L,3L,8L,8L,4L,0L,6L,3L,6L,2L,6L,1L,3L,5L,9L,3L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278809Inst : IEnumerable<long>
{
public static readonly long[] Value=A278809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278809.Bytes);
public long this[int i]=>Value[i];

public static A278809Inst Instance=new A278809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278810
{
public static readonly long[] Value={ 0L,4L,9L,7L,0L,4L,5L,0L,0L,0L,0L,7L,5L,8L,9L,4L,5L,0L,7L,7L,3L,7L,8L,3L,7L,6L,1L,5L,5L,2L,9L,6L,6L,8L,9L,3L,6L,1L,4L,2L,3L,9L,3L,2L,4L,7L,9L,8L,5L,9L,3L,8L,9L,5L,9L,8L,3L,0L,3L,6L,8L,4L,6L,1L,2L,7L,6L,0L,5L,6L,6L,4L,4L,3L,1L,8L,7L,3L,5L,5L,7L,9L,7L,8L,8L,3L,6L,3L,2L,4L,9L,8L,4L,6L,7L,7L,2L,1L,6L,2L,5L,2L,9L,5L,7L,5L,7L,6L,5L,3L,0L,8L,0L,1L,4L,5L,3L,8L,6L,4L,1L,6L,3L,9L,7L,6L,9L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278810Inst : IEnumerable<long>
{
public static readonly long[] Value=A278810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278810.Bytes);
public long this[int i]=>Value[i];

public static A278810Inst Instance=new A278810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278811
{
public static readonly long[] Value={ 0L,1L,7L,7L,5L,8L,1L,9L,1L,8L,8L,0L,2L,5L,1L,4L,0L,3L,3L,3L,8L,3L,5L,0L,3L,1L,8L,1L,3L,0L,8L,6L,6L,9L,8L,5L,7L,8L,8L,3L,2L,9L,7L,7L,0L,3L,4L,6L,8L,1L,0L,5L,2L,1L,5L,6L,4L,2L,3L,6L,3L,5L,7L,4L,3L,3L,3L,1L,7L,4L,8L,3L,6L,8L,4L,2L,2L,1L,1L,8L,3L,5L,1L,4L,8L,4L,6L,9L,0L,7L,6L,9L,7L,1L,4L,2L,7L,2L,6L,5L,7L,5L,1L,5L,6L,9L,2L,7L,7L,0L,1L,6L,5L,4L,1L,3L,4L,9L,9L,8L,6L,1L,3L,5L,5L,3L,1L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278811Inst : IEnumerable<long>
{
public static readonly long[] Value=A278811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278811.Bytes);
public long this[int i]=>Value[i];

public static A278811Inst Instance=new A278811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278812
{
public static readonly long[] Value={ 1L,3L,6L,7L,9L,0L,1L,2L,6L,1L,7L,9L,7L,0L,8L,5L,1L,6L,9L,6L,6L,8L,9L,0L,9L,1L,7L,5L,7L,6L,0L,4L,8L,8L,5L,3L,8L,3L,8L,4L,6L,2L,4L,5L,2L,6L,1L,8L,2L,1L,3L,5L,7L,7L,0L,4L,1L,4L,6L,0L,3L,7L,1L,3L,8L,6L,3L,3L,1L,7L,9L,4L,4L,8L,8L,0L,1L,5L,6L,8L,6L,5L,6L,6L,7L,1L,5L,8L,8L,6L,8L,3L,7L,2L,7L,7L,3L,7L,4L,9L,5L,6L,2L,4L,7L,7L,4L,3L,3L,4L,9L,8L,1L,9L,3L,3L,3L,6L,1L,7L,1L,9L,6L,1L,1L,1L,3L,2L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278812Inst : IEnumerable<long>
{
public static readonly long[] Value=A278812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278812.Bytes);
public long this[int i]=>Value[i];

public static A278812Inst Instance=new A278812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278813
{
public static readonly long[] Value={ 5L,7L,5L,8L,1L,9L,5L,9L,3L,9L,1L,1L,0L,3L,7L,4L,9L,4L,1L,9L,7L,4L,0L,2L,8L,8L,6L,5L,0L,0L,9L,3L,2L,9L,0L,9L,2L,4L,7L,4L,2L,4L,2L,6L,4L,7L,0L,5L,5L,3L,1L,5L,4L,1L,5L,1L,4L,1L,2L,5L,9L,9L,0L,6L,1L,9L,7L,1L,0L,7L,5L,9L,8L,9L,1L,5L,8L,7L,2L,3L,0L,8L,3L,3L,3L,7L,8L,7L,0L,6L,9L,5L,8L,7L,9L,1L,1L,5L,7L,2L,0L,0L,5L,6L,2L,9L,5L,0L,5L,6L,3L,2L,1L,1L,0L,5L,7L,1L,4L,7L,1L,3L,5L,9L,5L,0L,6L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278813Inst : IEnumerable<long>
{
public static readonly long[] Value=A278813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278813.Bytes);
public long this[int i]=>Value[i];

public static A278813Inst Instance=new A278813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278814
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278814Inst : IEnumerable<long>
{
public static readonly long[] Value=A278814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278814.Bytes);
public long this[int i]=>Value[i];

public static A278814Inst Instance=new A278814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278815
{
public static readonly long[] Value={ 1L,2L,7L,29L,109L,416L,1596L,6105L,23362L,89415L,342193L,1309593L,5011920L,19180976L,73406985L,280933906L,1075154535L,4114694797L,15747237101L,60265824784L,230641706484L,882682631025L,3378090801226L,12928199853783L,49477163668857L,189352713633433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278815Inst : IEnumerable<long>
{
public static readonly long[] Value=A278815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278815.Bytes);
public long this[int i]=>Value[i];

public static A278815Inst Instance=new A278815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278816
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278816Inst : IEnumerable<long>
{
public static readonly long[] Value=A278816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278816.Bytes);
public long this[int i]=>Value[i];

public static A278816Inst Instance=new A278816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278817
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,5L,2L,2L,6L,1L,3L,3L,2L,4L,3L,3L,1L,2L,4L,3L,3L,5L,2L,2L,2L,1L,3L,4L,4L,2L,2L,2L,3L,4L,4L,6L,1L,5L,3L,2L,2L,5L,5L,5L,3L,3L,3L,3L,2L,1L,6L,6L,3L,3L,3L,3L,6L,6L,2L,2L,2L,4L,4L,3L,1L,7L,7L,4L,4L,2L,2L,2L,3L,3L,3L,5L,5L,5L,5L,4L,2L,1L,2L,2L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278817Inst : IEnumerable<long>
{
public static readonly long[] Value=A278817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278817.Bytes);
public long this[int i]=>Value[i];

public static A278817Inst Instance=new A278817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278818
{
public static readonly long[] Value={ 1L,3L,7L,6L,5L,11L,10L,9L,17L,16L,15L,14L,13L,23L,22L,21L,20L,19L,31L,30L,29L,28L,27L,26L,25L,39L,38L,37L,36L,35L,34L,33L,49L,48L,47L,46L,45L,44L,43L,42L,41L,59L,58L,57L,56L,55L,54L,53L,52L,51L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,83L,82L,81L,80L,79L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278818Inst : IEnumerable<long>
{
public static readonly long[] Value=A278818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278818.Bytes);
public long this[int i]=>Value[i];

public static A278818Inst Instance=new A278818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278819
{
public static readonly ulong[] Value={ 1L,11L,110L,1100L,11010L,110000L,1101000L,11000100L,110101010L,1100010000L,11010101000L,110001000100L,1101010101010L,11000100000000L,110101010000000L,1100010001001000L,11010101010110100L,110001000000011010L,1101010100000100110L,11000100010001011000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278819Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278819.Bytes);
public ulong this[int i]=>Value[i];

public static A278819Inst Instance=new A278819Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278868
{
public static readonly BigInteger[] Value={ 1L,1L,6183L,5772211367657472L,BigInteger.Parse("76148812142946816440318638031477145600000"),BigInteger.Parse("3940613226283843476344831941863494501303228636304800836707599745608602091520000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278868Inst Instance=new A278868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278869
{
public static readonly long[] Value={ 11L,23L,53L,173L,233L,593L,653L,1103L,1223L,2693L,2903L,2963L,4793L,5303L,6263L,6323L,7823L,9473L,10253L,11783L,12653L,13463L,15803L,20753L,25673L,27743L,27773L,29873L,31253L,33623L,38183L,38453L,39233L,40283L,41603L,44273L,44543L,54443L,54773L,59393L,60083L,62213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278869Inst : IEnumerable<long>
{
public static readonly long[] Value=A278869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278869.Bytes);
public long this[int i]=>Value[i];

public static A278869Inst Instance=new A278869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278870
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1111L,100L,110111L,0L,11110111L,0L,1111111101L,10001L,111111111111L,1010000L,11111101010111L,1010000L,1111111111011111L,100000100L,111111110101111111L,100010100L,11111111110101010111UL,101010000L,BigInteger.Parse("1111111111110101010101"),101010101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278870Inst Instance=new A278870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278871
{
public static readonly ulong[] Value={ 1L,10L,100L,1111L,100L,111011L,0L,11101111L,0L,1011111111L,10001000000L,111111111111L,101000000L,11101010111111L,10100000000L,1111101111111111L,100000100000000L,111111101011111111L,10100010000000000L,11101010101111111111UL,10101000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278871Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278871.Bytes);
public ulong this[int i]=>Value[i];

public static A278871Inst Instance=new A278871Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278872
{
public static readonly long[] Value={ 1L,1L,1L,15L,4L,55L,0L,247L,0L,1021L,17L,4095L,80L,16215L,80L,65503L,260L,261503L,276L,1047895L,336L,4193621L,341L,16774485L,1365L,67108181L,4437L,268432725L,17749L,1073700181L,16725L,4294964565L,66901L,17179737429L,20821L,68719301973L,87381L,274877863253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278872Inst : IEnumerable<long>
{
public static readonly long[] Value=A278872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278872.Bytes);
public long this[int i]=>Value[i];

public static A278872Inst Instance=new A278872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278873
{
public static readonly long[] Value={ 1L,2L,4L,15L,4L,59L,0L,239L,0L,767L,1088L,4095L,320L,15039L,1280L,64511L,16640L,260863L,82944L,961535L,86016L,2797567L,5586944L,11186175L,22364160L,44761087L,89407488L,178978815L,357842944L,716095487L,1430323200L,2863661055L,5725290496L,11458772991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278873Inst : IEnumerable<long>
{
public static readonly long[] Value=A278873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278873.Bytes);
public long this[int i]=>Value[i];

public static A278873Inst Instance=new A278873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278874
{
public static readonly long[] Value={ 1L,1L,1L,7L,25L,50L,155L,508L,1343L,3800L,11438L,32525L,92333L,268766L,774302L,2216976L,6392865L,18425916L,52958070L,152425812L,438973764L,1263109849L,3634965137L,10463959311L,30116734921L,86675829307L,249478723992L,718056248229L,2066658063664L,5948257601097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278874Inst : IEnumerable<long>
{
public static readonly long[] Value=A278874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278874.Bytes);
public long this[int i]=>Value[i];

public static A278874Inst Instance=new A278874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278875
{
public static readonly long[] Value={ 1L,1L,7L,50L,311L,1954L,11914L,76003L,467221L,2943211L,18261840L,114360149L,712196192L,4449548684L,27749537725L,173227638835L,1080825788517L,6745415139188L,42092502492537L,262680587755837L,1639226363457986L,10229514197548963L,63836523795617745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278875Inst : IEnumerable<long>
{
public static readonly long[] Value=A278875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278875.Bytes);
public long this[int i]=>Value[i];

public static A278875Inst Instance=new A278875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278876
{
public static readonly BigInteger[] Value={ 1L,1L,25L,311L,4101L,56864L,728857L,9616962L,127040707L,1669454156L,22011707486L,289906000417L,3817261693883L,50281947199556L,662232832054368L,8721984517729672L,114875834939622917L,1512983475914685706L,BigInteger.Parse("19927016855891011234"),BigInteger.Parse("262452496836729312910") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278876Inst Instance=new A278876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278877
{
public static readonly BigInteger[] Value={ 1L,3L,155L,11914L,728857L,42238426L,2492016728L,147382229321L,8704392890599L,514207059584879L,30367424047335204L,1793195869965086337L,BigInteger.Parse("105893252956708204722"),BigInteger.Parse("6253339527216096201144"),BigInteger.Parse("369279138864066223011929"),BigInteger.Parse("21807048314051213226593407") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278877Inst Instance=new A278877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278878
{
public static readonly BigInteger[] Value={ 1L,4L,508L,76003L,9616962L,1178422563L,147382229321L,18446349150367L,2306845502243104L,288660593026069762L,BigInteger.Parse("36110872742261362007"),BigInteger.Parse("4516714276347536995415"),BigInteger.Parse("564976767651757484324113"),BigInteger.Parse("70671912291059592748455901"),BigInteger.Parse("8840222401663200361818980813") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278878Inst Instance=new A278878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278879
{
public static readonly BigInteger[] Value={ 1L,1L,5L,52L,931L,25516L,992799L,52032702L,3533592843L,301810098928L,31663565386063L,4002675000842794L,600053009189628075L,BigInteger.Parse("105257275528784647932"),BigInteger.Parse("21358127184625653306447"),BigInteger.Parse("4963922750189468652517318"),BigInteger.Parse("1310048479903507430878396651"),BigInteger.Parse("389626915538187147603694911208"),BigInteger.Parse("129712358816242576287065101448751"),BigInteger.Parse("48047325215595869387366562525477954") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278879Inst Instance=new A278879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278880
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,14L,14L,1L,1L,30L,81L,30L,1L,1L,55L,308L,308L,55L,1L,1L,91L,910L,1872L,910L,91L,1L,1L,140L,2268L,8250L,8250L,2268L,140L,1L,1L,204L,4998L,29172L,51425L,29172L,4998L,204L,1L,1L,285L,10032L,87780L,247247L,247247L,87780L,10032L,285L,1L,1L,385L,18711L,233376L,980980L,1565109L,980980L,233376L,18711L,385L,1L,1L,506L,32890L,562419L,3354780L,7970144L,7970144L,3354780L,562419L,32890L,506L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278880Inst : IEnumerable<long>
{
public static readonly long[] Value=A278880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278880.Bytes);
public long this[int i]=>Value[i];

public static A278880Inst Instance=new A278880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278881
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,8L,3L,0L,1L,20L,30L,4L,0L,1L,40L,147L,80L,5L,0L,1L,70L,504L,672L,175L,6L,0L,1L,112L,1386L,3600L,2310L,336L,7L,0L,1L,168L,3276L,14520L,18150L,6552L,588L,8L,0L,1L,240L,6930L,48048L,102245L,72072L,16170L,960L,9L,0L,1L,330L,13464L,137280L,455455L,546546L,240240L,35904L,1485L,10L,0L,1L,440L,24453L,350064L,1701700L,3179904L,2382380L,700128L,73359L,2200L,11L,0L,1L,572L,42042L,815100L,5542680L,15148224L,17672928L,8868288L,1833975L,140140L,3146L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278881Inst : IEnumerable<long>
{
public static readonly long[] Value=A278881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278881.Bytes);
public long this[int i]=>Value[i];

public static A278881Inst Instance=new A278881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278882
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,3L,8L,1L,0L,4L,30L,20L,1L,0L,5L,80L,147L,40L,1L,0L,6L,175L,672L,504L,70L,1L,0L,7L,336L,2310L,3600L,1386L,112L,1L,0L,8L,588L,6552L,18150L,14520L,3276L,168L,1L,0L,9L,960L,16170L,72072L,102245L,48048L,6930L,240L,1L,0L,10L,1485L,35904L,240240L,546546L,455455L,137280L,13464L,330L,1L,0L,11L,2200L,73359L,700128L,2382380L,3179904L,1701700L,350064L,24453L,440L,1L,0L,12L,3146L,140140L,1833975L,8868288L,17672928L,15148224L,5542680L,815100L,42042L,572L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278882Inst : IEnumerable<long>
{
public static readonly long[] Value=A278882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278882.Bytes);
public long this[int i]=>Value[i];

public static A278882Inst Instance=new A278882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278883
{
public static readonly BigInteger[] Value={ 1L,5L,81L,1872L,51425L,1565109L,50979600L,1742711616L,61765676577L,2251396558125L,83924761860225L,3186277484832000L,122829049870699536L,4796448751641900752L,BigInteger.Parse("189381233826675892800"),BigInteger.Parse("7549371503605704934656"),BigInteger.Parse("303473219026059360959265"),BigInteger.Parse("12289574902507266828093525"),BigInteger.Parse("500960076377670398672062425"),BigInteger.Parse("20540854991655352005504930000"),BigInteger.Parse("846696245823312839372671355025"),BigInteger.Parse("35068049224094584278339245227125"),BigInteger.Parse("1458752047374053912228252043321600") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278883Inst Instance=new A278883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278932
{
public static readonly long[] Value={ 1122659L,2164229L,2329469L,10257809L,10309889L,12314699L,14030309L,14145539L,19099919L,23103659L,24176129L,28843649L,37088729L,38199839L,42389519L,49160099L,50785439L,52554569L,62800169L,68718059L,85864769L,88174049L,95831189L,105109139L,105388169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278932Inst : IEnumerable<long>
{
public static readonly long[] Value=A278932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278932.Bytes);
public long this[int i]=>Value[i];

public static A278932Inst Instance=new A278932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278933
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,4L,8L,8L,12L,12L,20L,20L,24L,28L,32L,32L,40L,40L,48L,52L,56L,56L,68L,68L,72L,76L,84L,84L,96L,96L,104L,108L,112L,116L,128L,128L,132L,136L,148L,148L,160L,160L,168L,176L,180L,180L,196L,196L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278933Inst : IEnumerable<long>
{
public static readonly long[] Value=A278933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278933.Bytes);
public long this[int i]=>Value[i];

public static A278933Inst Instance=new A278933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278934
{
public static readonly BigInteger[] Value={ 1L,3L,29L,303L,3501L,42663L,538769L,6977547L,92078989L,1232902023L,16700233689L,228356672547L,3147087003201L,43659275921667L,609117615688149L,8539863624592023L,120242239301247309L,1699411957967345127L,BigInteger.Parse("24098616839012623769"),BigInteger.Parse("342754384909199620803") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278934Inst Instance=new A278934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278935
{
public static readonly long[] Value={ 126L,84L,63L,3231L,42L,4154L,2143L,1143L,4105263158L,6440909347642L,21L,11L,2077L,1077L,18063L,1206L,16056L,105882353L,2052631579L,43304763L,3220454673821L,8044L,12042L,30411L,6039L,5037593985L,321603571507896L,5035L,14033492823L,3033L,17403126122889L,20713030303119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278935Inst : IEnumerable<long>
{
public static readonly long[] Value=A278935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278935.Bytes);
public long this[int i]=>Value[i];

public static A278935Inst Instance=new A278935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278936
{
public static readonly long[] Value={ 1331L,1030301L,1331000L,1003003001L,1030301000L,1331000000L,1000300030001L,1003003001000L,1030301000000L,1331000000000L,1000030000300001L,1000300030001000L,1003003001000000L,1030301000000000L,1331000000000000L,321302302131323213L,1000003000003000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278936Inst : IEnumerable<long>
{
public static readonly long[] Value=A278936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278936.Bytes);
public long this[int i]=>Value[i];

public static A278936Inst Instance=new A278936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278937
{
public static readonly long[] Value={ 11L,101L,110L,1001L,1010L,1100L,10001L,10010L,10100L,11000L,100001L,100010L,100100L,101000L,110000L,684917L,1000001L,1000010L,1000100L,1001000L,1010000L,1100000L,6849170L,10000001L,10000010L,10000100L,10001000L,10010000L,10100000L,11000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278937Inst : IEnumerable<long>
{
public static readonly long[] Value=A278937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278937.Bytes);
public long this[int i]=>Value[i];

public static A278937Inst Instance=new A278937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278938
{
public static readonly long[] Value={ 0L,1L,2L,20L,21L,3L,23L,4L,5L,24L,6L,7L,8L,25L,9L,10L,12L,11L,13L,14L,26L,15L,16L,17L,27L,18L,19L,30L,32L,31L,33L,34L,35L,42L,36L,37L,38L,39L,40L,28L,41L,43L,44L,45L,46L,29L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,62L,59L,60L,61L,63L,64L,65L,66L,200L,67L,68L,69L,70L,71L,73L,72L,74L,75L,76L,77L,78L,79L,80L,81L,201L,83L,84L,85L,86L,87L,88L,89L,82L,90L,91L,93L,94L,95L,96L,97L,98L,99L,203L,100L,101L,103L,104L,105L,102L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278938Inst : IEnumerable<long>
{
public static readonly long[] Value=A278938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278938.Bytes);
public long this[int i]=>Value[i];

public static A278938Inst Instance=new A278938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278939
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,40L,41L,5L,42L,6L,7L,43L,8L,9L,14L,10L,11L,24L,12L,13L,15L,45L,16L,17L,18L,46L,19L,20L,21L,34L,22L,23L,25L,26L,54L,27L,28L,29L,30L,31L,47L,32L,33L,35L,36L,37L,48L,38L,39L,50L,51L,52L,64L,53L,55L,56L,57L,58L,59L,74L,60L,61L,62L,63L,65L,66L,67L,49L,68L,69L,70L,71L,72L,73L,75L,400L,76L,77L,78L,79L,80L,81L,82L,401L,83L,85L,86L,87L,88L,89L,90L,84L,91L,92L,93L,95L,96L,97L,98L,99L,104L,100L,101L,102L,103L,105L,106L,94L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278939Inst : IEnumerable<long>
{
public static readonly long[] Value=A278939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278939.Bytes);
public long this[int i]=>Value[i];

public static A278939Inst Instance=new A278939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278940
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,50L,51L,6L,52L,7L,8L,53L,9L,10L,54L,11L,12L,56L,13L,14L,15L,16L,17L,18L,25L,19L,20L,21L,22L,57L,23L,24L,26L,27L,58L,28L,29L,30L,31L,35L,32L,33L,34L,36L,37L,45L,38L,39L,40L,41L,42L,43L,59L,44L,46L,47L,48L,49L,60L,500L,61L,62L,63L,64L,66L,67L,501L,68L,69L,70L,71L,72L,73L,65L,74L,76L,77L,78L,79L,80L,81L,82L,502L,83L,84L,86L,87L,88L,89L,90L,75L,91L,92L,93L,94L,96L,97L,98L,99L,105L,100L,101L,102L,103L,104L,106L,85L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278940Inst : IEnumerable<long>
{
public static readonly long[] Value=A278940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278940.Bytes);
public long this[int i]=>Value[i];

public static A278940Inst Instance=new A278940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278941
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,60L,61L,7L,62L,8L,9L,63L,10L,16L,11L,12L,26L,13L,14L,15L,64L,17L,18L,19L,65L,20L,21L,22L,36L,23L,24L,25L,27L,46L,28L,29L,30L,31L,32L,67L,33L,34L,35L,37L,38L,68L,39L,40L,41L,42L,43L,56L,44L,45L,47L,48L,49L,50L,76L,51L,52L,53L,54L,55L,57L,58L,69L,59L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278941Inst : IEnumerable<long>
{
public static readonly long[] Value=A278941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278941.Bytes);
public long this[int i]=>Value[i];

public static A278941Inst Instance=new A278941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278942
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,70L,71L,8L,72L,9L,17L,10L,11L,73L,12L,13L,74L,14L,15L,27L,16L,18L,19L,37L,20L,21L,22L,23L,75L,24L,25L,26L,28L,76L,29L,30L,31L,32L,47L,33L,34L,35L,36L,38L,57L,39L,40L,41L,42L,43L,44L,78L,45L,46L,48L,49L,50L,51L,79L,52L,53L,54L,55L,56L,58L,67L,59L,60L,61L,62L,63L,64L,65L,87L,66L,68L,69L,80L,81L,82L,83L,84L,700L,85L,86L,88L,89L,90L,91L,92L,97L,93L,94L,95L,96L,98L,99L,100L,101L,701L,102L,103L,104L,105L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278942Inst : IEnumerable<long>
{
public static readonly long[] Value=A278942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278942.Bytes);
public long this[int i]=>Value[i];

public static A278942Inst Instance=new A278942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278943
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,80L,81L,9L,82L,10L,83L,11L,18L,12L,13L,28L,14L,15L,16L,84L,17L,19L,20L,85L,21L,22L,23L,38L,24L,25L,26L,27L,48L,29L,30L,31L,32L,33L,86L,34L,35L,36L,37L,39L,87L,40L,41L,42L,43L,44L,58L,45L,46L,47L,49L,50L,51L,68L,52L,53L,54L,55L,56L,57L,59L,89L,60L,61L,62L,63L,64L,65L,66L,800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278943Inst : IEnumerable<long>
{
public static readonly long[] Value=A278943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278943.Bytes);
public long this[int i]=>Value[i];

public static A278943Inst Instance=new A278943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278944
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,90L,91L,19L,10L,29L,11L,12L,92L,13L,14L,93L,15L,16L,39L,17L,18L,20L,49L,21L,22L,23L,24L,94L,25L,26L,27L,28L,95L,30L,31L,32L,33L,59L,34L,35L,36L,37L,38L,69L,40L,41L,42L,43L,44L,45L,96L,46L,47L,48L,50L,51L,52L,97L,53L,54L,55L,56L,57L,58L,79L,60L,61L,62L,63L,64L,65L,66L,89L,67L,68L,70L,71L,72L,73L,74L,75L,98L,76L,77L,78L,80L,81L,82L,83L,84L,900L,85L,86L,87L,88L,100L,101L,109L,102L,103L,104L,105L,106L,107L,190L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278944Inst : IEnumerable<long>
{
public static readonly long[] Value=A278944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278944.Bytes);
public long this[int i]=>Value[i];

public static A278944Inst Instance=new A278944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278945
{
public static readonly long[] Value={ 0L,1L,7L,16L,35L,46L,88L,92L,155L,169L,242L,232L,392L,326L,476L,496L,651L,562L,871L,704L,1050L,968L,1184L,1036L,1640L,1271L,1658L,1600L,2044L,1654L,2528L,1892L,2667L,2392L,2846L,2552L,3731L,2702L,3560L,3344L,4330L,3322L,4904L,3656L,5040L,4654L,5228L,4372L,6696L,4845L,6417L,5728L,7042L,5566L,8080L,6272L,8380L,7160L,8330L,6904L,10752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278945Inst : IEnumerable<long>
{
public static readonly long[] Value=A278945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278945.Bytes);
public long this[int i]=>Value[i];

public static A278945Inst Instance=new A278945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278946
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,20L,110L,11L,30L,12L,120L,13L,14L,40L,15L,16L,130L,17L,18L,19L,50L,21L,22L,23L,140L,24L,25L,26L,27L,60L,28L,29L,31L,32L,150L,33L,34L,35L,36L,37L,70L,38L,39L,41L,42L,43L,160L,44L,45L,46L,47L,48L,49L,80L,51L,52L,53L,54L,55L,56L,170L,57L,58L,59L,61L,62L,63L,64L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278946Inst : IEnumerable<long>
{
public static readonly long[] Value=A278946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278946.Bytes);
public long this[int i]=>Value[i];

public static A278946Inst Instance=new A278946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278947
{
public static readonly long[] Value={ 0L,1L,8L,19L,42L,56L,107L,113L,190L,208L,298L,287L,483L,404L,589L,614L,806L,698L,1079L,875L,1302L,1202L,1471L,1289L,2035L,1581L,2062L,1990L,2541L,2060L,3142L,2357L,3318L,2978L,3544L,3178L,4641L,3368L,4435L,4166L,5390L,4142L,6106L,4559L,6279L,5798L,6517L,5453L,8339L,6042L,7998L,7142L,8778L,6944L,10070L,7822L,10445L,8930L,10390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278947Inst : IEnumerable<long>
{
public static readonly long[] Value=A278947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278947.Bytes);
public long this[int i]=>Value[i];

public static A278947Inst Instance=new A278947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278996
{
public static readonly long[] Value={ 0L,3L,5L,6L,8L,9L,12L,14L,15L,18L,21L,23L,24L,27L,30L,32L,33L,35L,36L,39L,41L,42L,45L,48L,50L,51L,53L,54L,57L,59L,60L,62L,63L,66L,68L,69L,72L,75L,77L,78L,80L,81L,84L,86L,87L,89L,90L,93L,95L,96L,99L,102L,104L,105L,108L,111L,113L,114L,116L,117L,120L,122L,123L,126L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278996Inst : IEnumerable<long>
{
public static readonly long[] Value=A278996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278996.Bytes);
public long this[int i]=>Value[i];

public static A278996Inst Instance=new A278996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278997
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,11L,13L,16L,17L,19L,20L,22L,25L,26L,28L,29L,31L,34L,37L,38L,40L,43L,44L,46L,47L,49L,52L,55L,56L,58L,61L,64L,65L,67L,70L,71L,73L,74L,76L,79L,82L,83L,85L,88L,91L,92L,94L,97L,98L,100L,101L,103L,106L,107L,109L,110L,112L,115L,118L,119L,121L,124L,125L,127L,128L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278997Inst : IEnumerable<long>
{
public static readonly long[] Value=A278997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278997.Bytes);
public long this[int i]=>Value[i];

public static A278997Inst Instance=new A278997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278998
{
public static readonly long[] Value={ 0L,3L,4L,5L,8L,10L,13L,15L,18L,19L,20L,23L,24L,25L,28L,29L,30L,33L,35L,38L,40L,43L,44L,45L,48L,50L,53L,54L,55L,58L,60L,63L,65L,68L,69L,70L,73L,75L,78L,79L,80L,83L,85L,88L,90L,93L,94L,95L,98L,99L,100L,103L,104L,105L,108L,110L,113L,115L,118L,119L,120L,123L,124L,125L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278998Inst : IEnumerable<long>
{
public static readonly long[] Value=A278998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278998.Bytes);
public long this[int i]=>Value[i];

public static A278998Inst Instance=new A278998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278999
{
public static readonly long[] Value={ 1L,2L,6L,7L,9L,11L,12L,14L,16L,17L,21L,22L,26L,27L,31L,32L,34L,36L,37L,39L,41L,42L,46L,47L,49L,51L,52L,56L,57L,59L,61L,62L,64L,66L,67L,71L,72L,74L,76L,77L,81L,82L,84L,86L,87L,89L,91L,92L,96L,97L,101L,102L,106L,107L,109L,111L,112L,114L,116L,117L,121L,122L,126L,127L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278999Inst : IEnumerable<long>
{
public static readonly long[] Value=A278999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278999.Bytes);
public long this[int i]=>Value[i];

public static A278999Inst Instance=new A278999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279000
{
public static readonly long[] Value={ 0L,2L,3L,4L,8L,10L,11L,13L,14L,15L,19L,22L,24L,25L,26L,30L,32L,33L,35L,36L,37L,41L,43L,44L,46L,47L,48L,52L,54L,55L,57L,58L,59L,63L,66L,68L,69L,70L,74L,77L,79L,80L,81L,85L,88L,90L,91L,92L,96L,98L,99L,101L,102L,103L,107L,110L,112L,113L,114L,118L,120L,121L,123L,124L,125L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279000Inst : IEnumerable<long>
{
public static readonly long[] Value=A279000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279000.Bytes);
public long this[int i]=>Value[i];

public static A279000Inst Instance=new A279000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279001
{
public static readonly long[] Value={ 1L,5L,6L,7L,9L,12L,16L,17L,18L,20L,21L,23L,27L,28L,29L,31L,34L,38L,39L,40L,42L,45L,49L,50L,51L,53L,56L,60L,61L,62L,64L,65L,67L,71L,72L,73L,75L,76L,78L,82L,83L,84L,86L,87L,89L,93L,94L,95L,97L,100L,104L,105L,106L,108L,109L,111L,115L,116L,117L,119L,122L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279001Inst : IEnumerable<long>
{
public static readonly long[] Value=A279001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279001.Bytes);
public long this[int i]=>Value[i];

public static A279001Inst Instance=new A279001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279002
{
public static readonly long[] Value={ 1L,2L,7L,26L,100L,404L,1691L,7254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279002Inst : IEnumerable<long>
{
public static readonly long[] Value=A279002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279002.Bytes);
public long this[int i]=>Value[i];

public static A279002Inst Instance=new A279002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279003
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,9L,15L,1L,1L,14L,49L,35L,1L,1L,20L,112L,200L,70L,1L,1L,27L,216L,654L,666L,126L,1L,1L,35L,375L,1660L,3070L,1902L,210L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279003Inst : IEnumerable<long>
{
public static readonly long[] Value=A279003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279003.Bytes);
public long this[int i]=>Value[i];

public static A279003Inst Instance=new A279003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279004
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,3L,1L,3L,6L,9L,9L,1L,4L,10L,19L,28L,28L,1L,5L,15L,34L,62L,90L,90L,1L,6L,21L,55L,117L,207L,297L,297L,1L,7L,28L,83L,200L,407L,704L,1001L,1001L,1L,8L,36L,119L,319L,726L,1430L,2431L,3432L,3432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279004Inst : IEnumerable<long>
{
public static readonly long[] Value=A279004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279004.Bytes);
public long this[int i]=>Value[i];

public static A279004Inst Instance=new A279004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279005
{
public static readonly long[] Value={ 1L,-1L,-1L,-6L,6L,7L,9L,-8L,-15L,13L,-19L,-4L,-49L,57L,61L,32L,-14L,-75L,47L,-98L,-23L,-124L,130L,152L,116L,-37L,-182L,96L,-168L,0L,-335L,352L,342L,196L,-117L,-390L,230L,-440L,-107L,-600L,637L,671L,480L,-184L,-704L,469L,-727L,-112L,-1235L,1241L,1291L,722L,-341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279005Inst : IEnumerable<long>
{
public static readonly long[] Value=A279005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279005.Bytes);
public long this[int i]=>Value[i];

public static A279005Inst Instance=new A279005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279006
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-1L,1L,1L,1L,-2L,2L,0L,1L,1L,-3L,4L,-2L,1L,1L,1L,-4L,7L,-6L,3L,0L,1L,1L,-5L,11L,-13L,9L,-3L,1L,1L,1L,-6L,16L,-24L,22L,-12L,4L,0L,1L,1L,-7L,22L,-40L,46L,-34L,16L,-4L,1L,1L,1L,-8L,29L,-62L,86L,-80L,50L,-20L,5L,0L,1L,1L,-9L,37L,-91L,148L,-166L,130L,-70L,25L,-5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279006Inst : IEnumerable<long>
{
public static readonly long[] Value=A279006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279006.Bytes);
public long this[int i]=>Value[i];

public static A279006Inst Instance=new A279006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279007
{
public static readonly long[] Value={ 2L,1L,10L,9L,52L,65L,278L,429L,1520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279007Inst : IEnumerable<long>
{
public static readonly long[] Value=A279007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279007.Bytes);
public long this[int i]=>Value[i];

public static A279007Inst Instance=new A279007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279008
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,2L,2L,-1L,1L,4L,0L,3L,-2L,1L,4L,4L,-3L,5L,-3L,1L,8L,0L,7L,-8L,8L,-4L,1L,8L,8L,-7L,15L,-16L,12L,-5L,1L,16L,0L,15L,-22L,31L,-28L,17L,-6L,1L,16L,16L,-15L,37L,-53L,59L,-45L,23L,-7L,1L,32L,0L,31L,-52L,90L,-112L,104L,-68L,30L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279008Inst : IEnumerable<long>
{
public static readonly long[] Value=A279008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279008.Bytes);
public long this[int i]=>Value[i];

public static A279008Inst Instance=new A279008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279009
{
public static readonly long[] Value={ 1L,1L,1L,-2L,0L,1L,-2L,-2L,-1L,1L,4L,0L,-1L,-2L,1L,4L,4L,1L,1L,-3L,1L,-8L,0L,3L,0L,4L,-4L,1L,-8L,-8L,-3L,3L,-4L,8L,-5L,1L,16L,0L,-5L,-6L,7L,-12L,13L,-6L,1L,16L,16L,5L,1L,-13L,19L,-25L,19L,-7L,1L,-32L,0L,11L,4L,14L,-32L,44L,-44L,26L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279009Inst : IEnumerable<long>
{
public static readonly long[] Value=A279009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279009.Bytes);
public long this[int i]=>Value[i];

public static A279009Inst Instance=new A279009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279010
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,3L,3L,-1L,1L,9L,0L,4L,-2L,1L,9L,9L,-4L,6L,-3L,1L,27L,0L,13L,-10L,9L,-4L,1L,27L,27L,-13L,23L,-19L,13L,-5L,1L,81L,0L,40L,-36L,42L,-32L,18L,-6L,1L,81L,81L,-40L,76L,-78L,74L,-50L,24L,-7L,1L,243L,0L,121L,-116L,154L,-152L,124L,-74L,31L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279010Inst : IEnumerable<long>
{
public static readonly long[] Value=A279010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279010.Bytes);
public long this[int i]=>Value[i];

public static A279010Inst Instance=new A279010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279011
{
public static readonly long[] Value={ 1L,2L,12L,152L,222L,268L,362L,432L,723L,992L,1517L,2532L,2567L,8472L,9718L,9858L,13498L,15738L,34732L,35898L,44092L,60363L,69312L,75168L,75973L,82752L,87208L,88888L,98198L,105852L,114392L,126848L,128672L,135368L,141093L,161268L,221223L,233788L,301513L,328358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279011Inst : IEnumerable<long>
{
public static readonly long[] Value=A279011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279011.Bytes);
public long this[int i]=>Value[i];

public static A279011Inst Instance=new A279011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279060
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,4L,1L,2L,1L,2L,1L,2L,3L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279060Inst : IEnumerable<long>
{
public static readonly long[] Value=A279060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279060.Bytes);
public long this[int i]=>Value[i];

public static A279060Inst Instance=new A279060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279061
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,2L,2L,3L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279061Inst : IEnumerable<long>
{
public static readonly long[] Value=A279061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279061.Bytes);
public long this[int i]=>Value[i];

public static A279061Inst Instance=new A279061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279062
{
public static readonly long[] Value={ 3L,3L,5L,353L,13297L,1561423L,291461857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279062Inst : IEnumerable<long>
{
public static readonly long[] Value=A279062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279062.Bytes);
public long this[int i]=>Value[i];

public static A279062Inst Instance=new A279062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279063
{
public static readonly long[] Value={ 0L,0L,0L,16L,56L,136L,296L,512L,864L,1280L,1912L,2616L,3680L,4760L,6200L,7848L,9792L,11832L,14632L,17280L,20784L,24352L,28480L,32584L,38200L,43168L,49160L,55472L,62936L,69784L,79008L,86944L,96952L,106816L,117672L,128592L,142352L,154088L,167968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279063Inst : IEnumerable<long>
{
public static readonly long[] Value=A279063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279063.Bytes);
public long this[int i]=>Value[i];

public static A279063Inst Instance=new A279063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279064
{
public static readonly long[] Value={ 1L,2L,3L,7L,9L,11L,12L,15L,18L,19L,20L,23L,24L,25L,27L,28L,31L,35L,39L,40L,43L,44L,47L,48L,49L,50L,51L,52L,55L,56L,59L,60L,63L,67L,68L,71L,75L,76L,79L,80L,81L,83L,84L,87L,88L,91L,92L,95L,96L,98L,99L,103L,104L,107L,108L,111L,112L,115L,116L,119L,120L,121L,123L,124L,127L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279064Inst : IEnumerable<long>
{
public static readonly long[] Value=A279064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279064.Bytes);
public long this[int i]=>Value[i];

public static A279064Inst Instance=new A279064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279065
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,11L,19L,47L,169L,907L,6829L,67931L,851891L,13034887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279065Inst : IEnumerable<long>
{
public static readonly long[] Value=A279065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279065.Bytes);
public long this[int i]=>Value[i];

public static A279065Inst Instance=new A279065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279066
{
public static readonly long[] Value={ 5L,3L,31L,23L,8123L,89L,139L,7963L,337L,409L,199L,797L,45439L,113L,953L,88547L,293L,2633L,1933L,3643L,137029L,13381L,523L,2861L,1381L,1259L,7621L,7433L,156157L,3089L,546781L,30911L,1951L,294563L,1129L,3229L,285871L,10369L,14221L,3651341L,25819L,3967L,1669L,6173L,23473L,51383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279066Inst : IEnumerable<long>
{
public static readonly long[] Value=A279066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279066.Bytes);
public long this[int i]=>Value[i];

public static A279066Inst Instance=new A279066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279067
{
public static readonly long[] Value={ 5L,11L,29L,37L,6421L,367L,149L,14281L,251L,701L,521L,631L,84913L,127L,331L,75479L,787L,7057L,1949L,3407L,388621L,1847L,1277L,1087L,2879L,1399L,13859L,4621L,43391L,1657L,743507L,40213L,1151L,162209L,1973L,3491L,736577L,2579L,8039L,1264129L,14369L,43691L,4547L,4201L,8147L,29101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279067Inst : IEnumerable<long>
{
public static readonly long[] Value=A279067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279067.Bytes);
public long this[int i]=>Value[i];

public static A279067Inst Instance=new A279067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279068
{
public static readonly BigInteger[] Value={ 3L,13L,31L,2801L,50544702849929377L,30941L,307L,BigInteger.Parse("109912203092239643840221"),292561L,732541L,917087137L,6765811783780036261L,1723L,3500201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279068Inst Instance=new A279068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279069
{
public static readonly long[] Value={ 1L,2L,2L,4L,16L,4L,2L,18L,4L,4L,6L,12L,2L,4L,126L,10L,2L,6L,18L,2L,4L,4L,4L,2L,16L,2L,18L,16L,16L,22L,4L,2L,10L,162L,6L,12L,16L,6L,2L,2L,18L,16L,16L,4L,30L,576L,40L,238L,4L,10L,112L,4L,16L,6L,22L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279069Inst : IEnumerable<long>
{
public static readonly long[] Value=A279069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279069.Bytes);
public long this[int i]=>Value[i];

public static A279069Inst Instance=new A279069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279070
{
public static readonly long[] Value={ 2187L,2401L,3125L,6561L,12167L,14641L,15625L,16384L,16807L,19683L,24389L,28561L,29791L,32768L,50653L,59049L,65536L,68921L,78125L,79507L,83521L,100489L,103823L,109375L,109561L,113569L,117649L,120409L,121801L,124609L,128881L,130321L,131072L,134689L,137781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279070Inst : IEnumerable<long>
{
public static readonly long[] Value=A279070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279070.Bytes);
public long this[int i]=>Value[i];

public static A279070Inst Instance=new A279070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279071
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,11L,13L,14L,17L,19L,22L,23L,26L,29L,31L,34L,37L,38L,41L,43L,46L,47L,53L,58L,59L,61L,62L,67L,71L,73L,74L,79L,82L,83L,86L,89L,94L,97L,101L,103L,106L,107L,109L,113L,118L,122L,127L,131L,134L,137L,139L,142L,146L,149L,151L,157L,158L,163L,166L,167L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279071Inst : IEnumerable<long>
{
public static readonly long[] Value=A279071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279071.Bytes);
public long this[int i]=>Value[i];

public static A279071Inst Instance=new A279071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279072
{
public static readonly long[] Value={ 323L,572L,646L,754L,2737L,3782L,4181L,5474L,5777L,6479L,6721L,7654L,7743L,8362L,10877L,11554L,11663L,12958L,13201L,13202L,13442L,15251L,16298L,17261L,17302L,18407L,19043L,21754L,23042L,23326L,23407L,26402L,26978L,27071L,27962L,30502L,34238L,34561L,34943L,35207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279072Inst : IEnumerable<long>
{
public static readonly long[] Value=A279072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279072.Bytes);
public long this[int i]=>Value[i];

public static A279072Inst Instance=new A279072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279073
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,87L,116L,129L,129L,129L,129L,129L,129L,202L,202L,202L,202L,202L,6753L,7769L,14614L,14614L,16574L,30777L,30777L,30777L,30777L,30777L,90878L,99483L,99483L,99483L,99483L,99483L,99483L,99483L,99483L,680384L,845662L,1719404L,1787204L,1787204L,1787204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279073Inst : IEnumerable<long>
{
public static readonly long[] Value=A279073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279073.Bytes);
public long this[int i]=>Value[i];

public static A279073Inst Instance=new A279073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279074
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,87L,116L,164L,203L,413L,712L,1478L,129L,472L,3033L,356L,6509L,202L,6753L,7769L,33724L,14614L,16574L,43844L,33164L,70988L,59405L,30777L,90878L,437408L,239644L,158944L,1088128L,359433L,171155L,390155L,99483L,680384L,845662L,1719404L,5597092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279074Inst : IEnumerable<long>
{
public static readonly long[] Value=A279074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279074.Bytes);
public long this[int i]=>Value[i];

public static A279074Inst Instance=new A279074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279075
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,11L,14L,18L,23L,29L,37L,47L,59L,74L,93L,117L,147L,184L,231L,289L,362L,453L,567L,709L,887L,1109L,1387L,1734L,2168L,2711L,3389L,4237L,5297L,6622L,8278L,10348L,12936L,16171L,20214L,25268L,31586L,39483L,49354L,61693L,77117L,96397L,120497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279075Inst : IEnumerable<long>
{
public static readonly long[] Value=A279075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279075.Bytes);
public long this[int i]=>Value[i];

public static A279075Inst Instance=new A279075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279140
{
public static readonly long[] Value={ 1L,1L,2L,3L,28L,15L,96L,111L,16L,799L,288L,3391L,448L,14079L,1280L,53759L,5632L,215039L,4096L,808959L,460800L,3805183L,1060864L,14532607L,11206656L,507903L,129056768L,6586367L,513048576L,13041663L,2079850496L,720895L,8317370368L,6684671L,32983089152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279140Inst : IEnumerable<long>
{
public static readonly long[] Value=A279140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279140.Bytes);
public long this[int i]=>Value[i];

public static A279140Inst Instance=new A279140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279141
{
public static readonly BigInteger[] Value={ 1L,0L,101L,0L,10101L,0L,1010101L,0L,101011101L,10100L,10101000001L,11100L,1010111010101L,101000000L,101010000010101L,111000000L,10101110101010101L,1010000000000L,1010100000111010101L,1110101000000L,BigInteger.Parse("101011101010000010101"),10100000111000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279141Inst Instance=new A279141Inst();

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