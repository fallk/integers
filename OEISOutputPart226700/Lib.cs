using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277362
{
public static readonly BigInteger[] Value={ 1L,2L,14L,164L,2646L,53852L,1316364L,37467080L,1215510118L,44249471916L,1785942489700L,79150848980216L,3821494523507708L,199668288426274968L,11225643465179779544UL,BigInteger.Parse("675769562728962818448"),BigInteger.Parse("43370783734391689628294"),BigInteger.Parse("2956329387192674856638668") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277362Inst Instance=new A277362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277363
{
public static readonly BigInteger[] Value={ 1L,2L,6L,52L,646L,13756L,458780L,24525352L,2094232006L,287618113900L,63647556127412L,22739228686869592L,13126310109506278556UL,BigInteger.Parse("12250085882856201785816"),BigInteger.Parse("18488349380363585366790264"),BigInteger.Parse("45134497176992058331312333648"),BigInteger.Parse("178246891228174428563552421395782") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277363Inst Instance=new A277363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277364
{
public static readonly long[] Value={ 1L,0L,1L,1L,8L,16L,122L,365L,2795L,11051L,86472L,422005L,3403127L,19628064L,164029595L,1084948961L,9433737120L,69998462014L,635182667816L,5199414528808L,49344452550230L,439841775811967L,4371727233798927L,42000637216351225L,437489737355466560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277364Inst : IEnumerable<long>
{
public static readonly long[] Value=A277364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277364.Bytes);
public long this[int i]=>Value[i];

public static A277364Inst Instance=new A277364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277365
{
public static readonly long[] Value={ 2L,6L,12L,20L,34L,49L,56L,72L,98L,112L,144L,176L,196L,228L,224L,272L,344L,406L,392L,384L,448L,520L,576L,688L,688L,772L,913L,912L,912L,1028L,992L,1040L,1220L,1152L,1376L,1624L,1624L,1708L,1624L,1728L,1728L,1824L,2160L,2080L,2080L,2215L,2559L,2752L,2884L,2884L,2752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277365Inst : IEnumerable<long>
{
public static readonly long[] Value=A277365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277365.Bytes);
public long this[int i]=>Value[i];

public static A277365Inst Instance=new A277365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277366
{
public static readonly long[] Value={ 1729L,670033L,6840001L,83099521L,193708801L,321197185L,367804801L,484662529L,1752710401L,2320690177L,5064928705L,12820178449L,32220147601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277366Inst : IEnumerable<long>
{
public static readonly long[] Value=A277366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277366.Bytes);
public long this[int i]=>Value[i];

public static A277366Inst Instance=new A277366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277367
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,1L,1L,1L,4L,3L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,5L,2L,1L,1L,3L,3L,3L,1L,1L,1L,1L,1L,4L,4L,4L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,10L,10L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277367Inst : IEnumerable<long>
{
public static readonly long[] Value=A277367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277367.Bytes);
public long this[int i]=>Value[i];

public static A277367Inst Instance=new A277367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277368
{
public static readonly long[] Value={ 1L,4L,10L,16L,25L,26L,34L,56L,58L,60L,64L,74L,81L,82L,90L,96L,100L,106L,120L,121L,122L,132L,146L,178L,184L,194L,202L,204L,216L,218L,226L,234L,248L,274L,276L,289L,298L,306L,312L,314L,346L,348L,362L,364L,376L,386L,394L,408L,440L,458L,466L,480L,482L,492L,504L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277368Inst : IEnumerable<long>
{
public static readonly long[] Value=A277368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277368.Bytes);
public long this[int i]=>Value[i];

public static A277368Inst Instance=new A277368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277369
{
public static readonly long[] Value={ 5L,8L,21L,50L,121L,292L,705L,1702L,4109L,9920L,23949L,57818L,139585L,336988L,813561L,1964110L,4741781L,11447672L,27637125L,66721922L,161080969L,388883860L,938848689L,2266581238L,5472011165L,13210603568L,31893218301L,76997040170L,185887298641L,448771637452L,1083430573545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277369Inst : IEnumerable<long>
{
public static readonly long[] Value=A277369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277369.Bytes);
public long this[int i]=>Value[i];

public static A277369Inst Instance=new A277369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277370
{
public static readonly long[] Value={ 1L,3L,15L,69L,2155L,34073L,876047637L,97090036327L,420397381695L,2125899832395L,3177544777277L,34434175473881L,40845965389135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277370Inst : IEnumerable<long>
{
public static readonly long[] Value=A277370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277370.Bytes);
public long this[int i]=>Value[i];

public static A277370Inst Instance=new A277370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277371
{
public static readonly long[] Value={ 1L,2L,4L,5L,26L,205L,2404L,88171L,1785134L,2010899L,58796834L,639723359L,657788549L,2050134685L,4809019972L,6114530474L,11931055777L,1292089439947L,1294667166242L,4586221808305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277371Inst : IEnumerable<long>
{
public static readonly long[] Value=A277371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277371.Bytes);
public long this[int i]=>Value[i];

public static A277371Inst Instance=new A277371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277372
{
public static readonly BigInteger[] Value={ 0L,1L,10L,141L,2584L,58745L,1602576L,51165205L,1874935168L,77644293201L,3588075308800L,183111507687581L,10230243235200000L,621111794820235849L,BigInteger.Parse("40722033570202507264"),BigInteger.Parse("2867494972696071121125"),BigInteger.Parse("215840579093024990396416"),BigInteger.Parse("17294837586403146090259745"),BigInteger.Parse("1469799445329208661211021312") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277372Inst Instance=new A277372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277373
{
public static readonly BigInteger[] Value={ 1L,2L,14L,168L,2840L,61870L,1649232L,51988748L,1891712384L,78031713690L,3598075308800L,183396819358192L,10239159335648256L,621414669926828102L,BigInteger.Parse("40733145577028065280"),BigInteger.Parse("2867932866586451980500"),BigInteger.Parse("215859025837098699948032"),BigInteger.Parse("17295664826665032427023922"),BigInteger.Parse("1469838791737283957748596736") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277373Inst Instance=new A277373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277374
{
public static readonly BigInteger[] Value={ 1L,2L,3L,6L,50L,100L,1794L,3588L,114840L,229680L,11483880L,22967760L,1653679440L,3307358880L,324121165200L,648242330400L,82975018331520L,165950036663040L,26883905939049600L,53767811878099200L,10753562375623468800UL,BigInteger.Parse("21507124751246937600"),BigInteger.Parse("5204724189801718982400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277374Inst Instance=new A277374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277375
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,11L,6L,13L,17L,19L,23L,29L,31L,8L,37L,41L,43L,47L,53L,59L,61L,67L,9L,71L,73L,79L,83L,89L,97L,101L,103L,107L,10L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,12L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,14L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,15L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277375Inst : IEnumerable<long>
{
public static readonly long[] Value=A277375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277375.Bytes);
public long this[int i]=>Value[i];

public static A277375Inst Instance=new A277375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277376
{
public static readonly long[] Value={ 2L,1L,4L,3L,6L,8L,9L,5L,10L,12L,14L,15L,16L,7L,18L,20L,21L,22L,24L,25L,26L,11L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,13L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,17L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,19L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277376Inst : IEnumerable<long>
{
public static readonly long[] Value=A277376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277376.Bytes);
public long this[int i]=>Value[i];

public static A277376Inst Instance=new A277376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277377
{
public static readonly long[] Value={ 1L,0L,3L,2L,4L,6L,5L,8L,10L,12L,14L,16L,7L,18L,20L,22L,24L,26L,28L,30L,9L,32L,34L,36L,38L,40L,42L,44L,46L,48L,11L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,13L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,15L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,17L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277377Inst : IEnumerable<long>
{
public static readonly long[] Value=A277377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277377.Bytes);
public long this[int i]=>Value[i];

public static A277377Inst Instance=new A277377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277378
{
public static readonly BigInteger[] Value={ 1L,2L,9L,50L,361L,3042L,29929L,331298L,4100625L,55777922L,828691369L,13316140818L,230256982201L,4257449540450L,83834039024649L,1750225301567618L,38614608429012001L,897325298084953602L,BigInteger.Parse("21904718673762721225"),BigInteger.Parse("560258287738117292018"),BigInteger.Parse("14981472258320814527241") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277378Inst Instance=new A277378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277379
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,40L,296L,1936L,17872L,164480L,1820800L,21442816L,279255296L,3967316992L,59837670400L,988024924160L,17009993230336L,318566665977856L,6177885274406912L,129053377688043520L,2786107670662021120L,BigInteger.Parse("64136976817284448256"),BigInteger.Parse("1525720008470138454016") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277379Inst Instance=new A277379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277380
{
public static readonly BigInteger[] Value={ 1L,2L,10L,92L,1068L,15352L,265752L,5368400L,123919248L,3217983008L,92851377312L,2947037232064L,102040223376576L,3827536020146048L,154615082607931776L,6691872388083371264L,BigInteger.Parse("308938595472492867840"),BigInteger.Parse("15153942107317778727424"),BigInteger.Parse("787050616613300039649792") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277380Inst Instance=new A277380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277381
{
public static readonly BigInteger[] Value={ 1L,2L,6L,28L,156L,984L,7112L,57488L,508688L,4887840L,50639200L,561416640L,6621963712L,82719611264L,1089925195904L,15094182365440L,219035852333312L,3321573144437248L,52511336993334784L,863594855161338880L,14746060593172585472UL,BigInteger.Parse("260971042697438779392") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277381Inst Instance=new A277381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277382
{
public static readonly BigInteger[] Value={ 1L,4L,23L,168L,1473L,14988L,173007L,2228544L,31636449L,490102164L,8219695239L,148262469336L,2860241078817L,58736954622492L,1278727896354687L,29406849577341552L,712119108949808193L,18108134430393657636UL,BigInteger.Parse("482306685868464422391"),BigInteger.Parse("13425231879291031821576") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277382Inst Instance=new A277382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277383
{
public static readonly long[] Value={ 0L,2L,1L,3L,4L,5L,7L,9L,11L,6L,13L,15L,17L,19L,21L,23L,8L,25L,27L,29L,31L,33L,35L,37L,39L,10L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,12L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,14L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,16L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277383Inst : IEnumerable<long>
{
public static readonly long[] Value=A277383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277383.Bytes);
public long this[int i]=>Value[i];

public static A277383Inst Instance=new A277383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277384
{
public static readonly long[] Value={ 15L,6L,7L,0L,9L,10L,33L,12L,65L,42L,105L,16L,153L,90L,209L,60L,273L,154L,345L,48L,425L,234L,513L,140L,609L,330L,713L,96L,825L,442L,945L,252L,1073L,570L,1209L,160L,1353L,714L,1505L,396L,1665L,874L,1833L,240L,2009L,1050L,2193L,572L,2385L,1242L,2585L,336L,2793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277384Inst : IEnumerable<long>
{
public static readonly long[] Value=A277384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277384.Bytes);
public long this[int i]=>Value[i];

public static A277384Inst Instance=new A277384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277385
{
public static readonly long[] Value={ 15L,33L,65L,105L,153L,209L,273L,345L,425L,513L,609L,713L,825L,945L,1073L,1209L,1353L,1505L,1665L,1833L,2009L,2193L,2385L,2585L,2793L,3009L,3233L,3465L,3705L,3953L,4209L,4473L,4745L,5025L,5313L,5609L,5913L,6225L,6545L,6873L,7209L,7553L,7905L,8265L,8633L,9009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277385Inst : IEnumerable<long>
{
public static readonly long[] Value=A277385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277385.Bytes);
public long this[int i]=>Value[i];

public static A277385Inst Instance=new A277385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277386
{
public static readonly BigInteger[] Value={ 1L,4L,35L,438L,6873L,127488L,2703447L,64121130L,1674999009L,47638235484L,1461975938379L,48068355965886L,1683311251028265L,62477888170824792L,2447583053876363727L,BigInteger.Parse("100842325515959413842"),BigInteger.Parse("4356021203508275392833"),BigInteger.Parse("196739133595421931988020"),BigInteger.Parse("9268144156277932321747251") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277386Inst Instance=new A277386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277387
{
public static readonly long[] Value={ 1L,17L,138L,670L,2355L,6671L,16212L,35148L,69765L,129085L,225566L,375882L,601783L,931035L,1398440L,2046936L,2928777L,4106793L,5655730L,7663670L,10233531L,13484647L,17554428L,22600100L,28800525L,36358101L,45500742L,56483938L,69592895L,85144755L,103490896L,125019312L,150157073L,179372865L,213179610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277387Inst : IEnumerable<long>
{
public static readonly long[] Value=A277387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277387.Bytes);
public long this[int i]=>Value[i];

public static A277387Inst Instance=new A277387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277388
{
public static readonly long[] Value={ 3L,47L,306L,1270L,4005L,10493L,24052L,49836L,95415L,171435L,292358L,477282L,750841L,1144185L,1696040L,2453848L,3474987L,4828071L,6594330L,8869070L,11763213L,15404917L,19941276L,25540100L,32391775L,40711203L,50739822L,62747706L,77035745L,93937905L,113823568L,137099952L,164214611L,195658015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277388Inst : IEnumerable<long>
{
public static readonly long[] Value=A277388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277388.Bytes);
public long this[int i]=>Value[i];

public static A277388Inst Instance=new A277388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277389
{
public static readonly long[] Value={ 1L,2L,1729L,19683001L,367804801L,631071001L,2064236401L,2320690177L,24899816449L,40017045601L,110592000001L,137299665601L,432081216001L,479534887801L,760355883001L,1111195454401L,3176523000001L,3495866888449L,3837165696001L,8571867768001L,14373832968001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277389Inst : IEnumerable<long>
{
public static readonly long[] Value=A277389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277389.Bytes);
public long this[int i]=>Value[i];

public static A277389Inst Instance=new A277389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277390
{
public static readonly long[] Value={ 1L,4L,2L,5L,9L,1L,9L,9L,9L,8L,1L,5L,9L,5L,9L,1L,3L,5L,2L,0L,6L,5L,5L,4L,2L,9L,6L,6L,1L,3L,2L,5L,0L,1L,1L,0L,4L,2L,7L,7L,1L,8L,8L,2L,4L,5L,4L,1L,9L,1L,1L,5L,5L,9L,0L,2L,4L,7L,1L,6L,2L,7L,7L,7L,5L,1L,6L,5L,7L,3L,2L,6L,1L,6L,8L,2L,4L,3L,1L,8L,5L,4L,3L,6L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277390Inst : IEnumerable<long>
{
public static readonly long[] Value=A277390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277390.Bytes);
public long this[int i]=>Value[i];

public static A277390Inst Instance=new A277390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277391
{
public static readonly BigInteger[] Value={ 1L,3L,34L,654L,17688L,616120L,26252496L,1322624016L,76909665664L,5069558461824L,373529452588800L,30422117430022912L,2713911389090970624L,BigInteger.Parse("263171888496899625984"),BigInteger.Parse("27563036166079327578112"),BigInteger.Parse("3100736138961250867968000"),BigInteger.Parse("372888702864658105915244544") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277391Inst Instance=new A277391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277392
{
public static readonly BigInteger[] Value={ 1L,4L,62L,1626L,59928L,2844120L,165100752L,11331597942L,897635712384L,80602042275756L,8090067511468800L,897561658361441106L,BigInteger.Parse("109072492644378442752"),BigInteger.Parse("14407931244544181001216"),BigInteger.Parse("2055559499598438969956352"),BigInteger.Parse("314997663481165477898736750"),BigInteger.Parse("51601245736595962597616222208") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277392Inst Instance=new A277392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277393
{
public static readonly BigInteger[] Value={ 1L,2L,6L,36L,300L,3000L,35880L,502320L,8038800L,144698400L,2893937760L,63666630720L,1527999802560L,39727994866560L,1112383838966400L,33371515168992000L,1067888485926662400L,BigInteger.Parse("36308208521506521600"),BigInteger.Parse("1307095506756591552000"),BigInteger.Parse("49669629256750478976000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277393Inst Instance=new A277393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277394
{
public static readonly long[] Value={ 1L,-2L,10L,1L,-280L,56L,-1L,15400L,-4260L,120L,126L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277394Inst : IEnumerable<long>
{
public static readonly long[] Value=A277394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277394.Bytes);
public long this[int i]=>Value[i];

public static A277394Inst Instance=new A277394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277395
{
public static readonly long[] Value={ 1L,3L,9L,33L,145L,713L,3745L,20513L,115713L,667329L,3916033L,23305857L,140327681L,853262465L,5231925761L,32313686529L,200843829249L,1255308123137L,7884792852481L,49745076576257L,315091155558401L,2003009460686849L,12774610185633793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277395Inst : IEnumerable<long>
{
public static readonly long[] Value=A277395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277395.Bytes);
public long this[int i]=>Value[i];

public static A277395Inst Instance=new A277395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277396
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,31L,163L,979L,6556L,48150L,383219L,3275121L,29841176L,288196506L,2936030427L,31425237185L,352166075233L,4119800015129L,50180781755797L,634948818421481L,8329111076372852L,113065244341635514L,1585699911447149109L,BigInteger.Parse("22942071009006046159") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277396Inst Instance=new A277396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277397
{
public static readonly long[] Value={ 0L,1L,1000L,11110L,14638L,15628L,17170L,18217L,19305L,19999L,21649L,22320L,25234L,29041L,30195L,31428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277397Inst : IEnumerable<long>
{
public static readonly long[] Value=A277397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277397.Bytes);
public long this[int i]=>Value[i];

public static A277397Inst Instance=new A277397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277398
{
public static readonly long[] Value={ 1L,10000L,73440L,95120L,218510L,221220L,222220L,242900L,245610L,289970L,344070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277398Inst : IEnumerable<long>
{
public static readonly long[] Value=A277398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277398.Bytes);
public long this[int i]=>Value[i];

public static A277398Inst Instance=new A277398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277399
{
public static readonly long[] Value={ 0L,1L,100000L,1705330L,1818180L,1941030L,2046807L,2227770L,2285010L,2414880L,2598400L,2694600L,2727270L,2728270L,2758239L,2760940L,2857140L,2890810L,2979315L,3040660L,3085911L,3317050L,3541014L,3636460L,4543174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277399Inst : IEnumerable<long>
{
public static readonly long[] Value=A277399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277399.Bytes);
public long this[int i]=>Value[i];

public static A277399Inst Instance=new A277399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277400
{
public static readonly long[] Value={ 0L,1L,1000000L,20585070L,25104356L,25975583L,27483737L,27940490L,27941490L,28133416L,29069509L,32345773L,32482961L,32581773L,33332330L,34310934L,34676272L,35530163L,35707886L,36067139L,41716867L,42163087L,42568703L,44444440L,47745130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277400Inst : IEnumerable<long>
{
public static readonly long[] Value=A277400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277400.Bytes);
public long this[int i]=>Value[i];

public static A277400Inst Instance=new A277400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277401
{
public static readonly long[] Value={ 1L,5L,143L,1133L,2171L,8567L,16805L,208091L,1887043L,517295383L,878436591673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277401Inst : IEnumerable<long>
{
public static readonly long[] Value=A277401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277401.Bytes);
public long this[int i]=>Value[i];

public static A277401Inst Instance=new A277401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277402
{
public static readonly long[] Value={ 1L,6L,19L,30L,61L,78L,127L,150L,217L,234L,331L,366L,469L,510L,631L,678L,817L,870L,1027L,1074L,1261L,1326L,1519L,1590L,1801L,1878L,2107L,2190L,2437L,2514L,2791L,2886L,3169L,3270L,3571L,3678L,3997L,4110L,4447L,4554L,4921L,5046L,5419L,5550L,5941L,6078L,6487L,6630L,7057L,7194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277402Inst : IEnumerable<long>
{
public static readonly long[] Value=A277402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277402.Bytes);
public long this[int i]=>Value[i];

public static A277402Inst Instance=new A277402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277403
{
public static readonly BigInteger[] Value={ 1L,2L,10L,90L,1190L,20930L,462070L,12326790L,386855630L,14000898310L,575440398330L,26532920708070L,1358954912773010L,76682330257445570L,4734315243483414890L,BigInteger.Parse("317932511564758225170"),BigInteger.Parse("23106045191162625194230"),BigInteger.Parse("1809303767549542227341490"),BigInteger.Parse("152057767850058496005946030"),BigInteger.Parse("13668688227104664304597942910"),BigInteger.Parse("1310201986290043690952261887230"),BigInteger.Parse("133552478071366935949713096470670"),BigInteger.Parse("14440878313638992240490923468851610") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277403Inst Instance=new A277403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277404
{
public static readonly BigInteger[] Value={ 1L,4L,36L,508L,10020L,253804L,7853076L,287078908L,12106864260L,578586544204L,30901130685876L,1823983173981148L,117911755067635620L,8284976875099852204L,BigInteger.Parse("628692318063511556436"),BigInteger.Parse("51240154266491883376828"),BigInteger.Parse("4464155216699369664399300"),BigInteger.Parse("414013560595951627772296204"),BigInteger.Parse("40722939746084736801890208756") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277404Inst Instance=new A277404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277405
{
public static readonly BigInteger[] Value={ 1L,5L,40L,524L,10776L,327732L,13920096L,788050944L,57348311040L,5215111879680L,579420628853760L,77220215372770560L,12157472554474222080UL,BigInteger.Parse("2232192933566250681600"),BigInteger.Parse("472721150641130889523200"),BigInteger.Parse("114371049117960857921126400"),BigInteger.Parse("31350167446592485414541721600"),BigInteger.Parse("9664519305841281076219121664000"),BigInteger.Parse("3328880054333616589332111409152000"),BigInteger.Parse("1273663039174670323519439513960448000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277405Inst Instance=new A277405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277406
{
public static readonly BigInteger[] Value={ 1L,2L,9L,76L,1100L,25176L,846132L,39321696L,2413753344L,189030205440L,18383301319680L,2172771551093760L,306662748175330560L,BigInteger.Parse("50933260598106862080"),BigInteger.Parse("9832247390118248121600"),BigInteger.Parse("2182733403365330313523200"),BigInteger.Parse("552134185815355910465126400"),BigInteger.Parse("157863713952139655599757721600"),BigInteger.Parse("50654908373638564216229105664000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277406Inst Instance=new A277406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277407
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,220L,4196L,120876L,4915212L,268194816L,18903020544L,1671209210880L,181064295924480L,23589442167333120L,3638090042721918720L,BigInteger.Parse("655483159341216541440"),BigInteger.Parse("136420837710333144595200"),BigInteger.Parse("32478481518550347674419200"),BigInteger.Parse("8770206330674425311097651200"),BigInteger.Parse("2666047809138871800854163456000"),BigInteger.Parse("906320525390421790143785781657600"),BigInteger.Parse("342508343836409428996994343026688000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277407Inst Instance=new A277407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277408
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,12L,22L,36L,24L,60L,140L,300L,576L,120L,360L,1020L,2700L,6576L,14400L,720L,2520L,8400L,26460L,77952L,211680L,518400L,5040L,20160L,77280L,282240L,974736L,3151680L,9408960L,25401600L,40320L,181440L,786240L,3265920L,12930624L,48444480L,170098560L,552303360L,1625702400L,362880L,1814400L,8769600L,40824000L,182226240L,775656000L,3126297600L,11820816000L,41391544320L,131681894400L,3628800L,19958400L,106444800L,548856000L,2726317440L,12989592000L,59044550400L,254303280000L,1028448368640L,3856920883200L,13168189440000L,39916800L,239500800L,1397088000L,7903526400L,43233886080L,227885011200L,1152535824000L,5563643500800L,25464033745920L,109530230261760L,437429486592000L,1593350922240000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277408Inst : IEnumerable<long>
{
public static readonly long[] Value=A277408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277408.Bytes);
public long this[int i]=>Value[i];

public static A277408Inst Instance=new A277408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277409
{
public static readonly BigInteger[] Value={ 1L,1L,2L,37L,13921L,207504608L,193499235977786L,BigInteger.Parse("16390183551007874514674"),BigInteger.Parse("173238206541606827885872411575542"),BigInteger.Parse("300679807333480520851459179939426369369129736"),BigInteger.Parse("109110688416565628491410454990885244124132946665282604804584"),BigInteger.Parse("10269686361506102165964632192322962717141565478713927846953403915348531319392"),BigInteger.Parse("304583662721691547994723721287871614789227410136168948343531184046989057630321931742841867554016") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277409Inst Instance=new A277409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277410
{
public static readonly long[] Value={ 1L,1L,0L,1L,3L,0L,1L,13L,15L,0L,1L,38L,165L,105L,0L,1L,94L,1033L,2310L,945L,0L,1L,213L,4953L,26229L,36330L,10395L,0L,1L,459L,20370L,213511L,674520L,640710L,135135L,0L,1L,960L,76056L,1421225L,8559675L,18127935L,12588345L,2027025L,0L,1L,1972L,266334L,8283234L,85654979L,337805535L,515903850L,273544425L,34459425L,0L,1L,4007L,892542L,44013478L,729292193L,4822487682L,13506364410L,15631793100L,6529047525L,654729075L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277410Inst : IEnumerable<long>
{
public static readonly long[] Value=A277410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277410.Bytes);
public long this[int i]=>Value[i];

public static A277410Inst Instance=new A277410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277411
{
public static readonly long[] Value={ 0L,3L,13L,38L,94L,213L,459L,960L,1972L,4007L,8089L,16266L,32634L,65385L,130903L,261956L,524080L,1048347L,2096901L,4194030L,8388310L,16776893L,33554083L,67108488L,134217324L,268435023L,536870449L,1073741330L,2147483122L,4294966737L,8589933999L,17179868556L,34359737704L,68719476035L,137438952733L,274877906166L,549755813070L,1099511626917L,2199023254651L,4398046510160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277411Inst : IEnumerable<long>
{
public static readonly long[] Value=A277411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277411.Bytes);
public long this[int i]=>Value[i];

public static A277411Inst Instance=new A277411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277412
{
public static readonly BigInteger[] Value={ 1L,13L,165L,2310L,36330L,640710L,12588345L,273544425L,6529047525L,170116046100L,4812116809500L,147071309685300L,4835838768886125L,170422360844360625L,6415409821472276625L,BigInteger.Parse("257182138353489599250"),BigInteger.Parse("10948868951071241940750"),BigInteger.Parse("493742086990731259931250"),BigInteger.Parse("23529007012831307040178125"),BigInteger.Parse("1182267810558397149214753125"),BigInteger.Parse("62507026744534189248771965625"),BigInteger.Parse("3470421725511913171914539625000"),BigInteger.Parse("201956614461150241288627906875000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277412Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277412.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277412Inst Instance=new A277412Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277413
{
public static readonly BigInteger[] Value={ 1L,3L,70L,4620L,599256L,128648520L,41281606080L,18507916627200L,11049593741746560L,8474451191616009600L,BigInteger.Parse("8119493428719228192000"),BigInteger.Parse("9504049395027168805824000"),BigInteger.Parse("13345312208487981260926464000"),BigInteger.Parse("22140681034117932250214874624000"),BigInteger.Parse("42846437958647788197412779939840000"),BigInteger.Parse("95657301566159892238019686222356480000"),BigInteger.Parse("244038306493164073323605513327887380480000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277413Inst Instance=new A277413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277414
{
public static readonly BigInteger[] Value={ 1L,2L,20L,504L,23968L,1851520L,211575936L,33566973440L,7062343608320L,1903365244784640L,639521861269258240L,BigInteger.Parse("262112584945787699200"),BigInteger.Parse("128722417690687207833600"),BigInteger.Parse("74622047155540651999232000"),BigInteger.Parse("50422787106606997974155264000"),BigInteger.Parse("39283625022760603948312795545600"),BigInteger.Parse("34956170646455883939814603698995200"),BigInteger.Parse("35235028408984566235493250881290240000"),BigInteger.Parse("39938723513704723231184585043746173747200") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277414Inst Instance=new A277414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277415
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,8L,16L,32L,6L,64L,5L,128L,256L,512L,7L,1024L,12L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,10L,24L,2097152L,4194304L,8388608L,9L,16777216L,33554432L,67108864L,14L,134217728L,268435456L,536870912L,1073741824L,2147483648L,4294967296L,8589934592L,48L,17179869184L,34359738368L,68719476736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277415Inst : IEnumerable<long>
{
public static readonly long[] Value=A277415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277415.Bytes);
public long this[int i]=>Value[i];

public static A277415Inst Instance=new A277415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277416
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,10L,8L,14L,5L,32L,27L,71L,16L,105L,36L,57L,6L,134L,118L,918L,66L,2361L,415L,1224L,28L,1902L,551L,4969L,92L,2545L,217L,374L,7L,940L,803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277416Inst : IEnumerable<long>
{
public static readonly long[] Value=A277416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277416.Bytes);
public long this[int i]=>Value[i];

public static A277416Inst Instance=new A277416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277417
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,11L,13L,15L,16L,17L,19L,23L,25L,29L,30L,31L,35L,36L,37L,41L,43L,47L,49L,53L,59L,61L,64L,67L,71L,73L,77L,79L,81L,83L,89L,97L,100L,101L,103L,105L,107L,109L,113L,121L,127L,131L,137L,139L,143L,144L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,196L,197L,199L,210L,211L,221L,223L,225L,227L,229L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277417Inst : IEnumerable<long>
{
public static readonly long[] Value=A277417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277417.Bytes);
public long this[int i]=>Value[i];

public static A277417Inst Instance=new A277417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277418
{
public static readonly BigInteger[] Value={ 1L,5L,98L,3246L,151064L,9052120L,663449040L,57490690544L,5749754436992L,651830574374784L,82599621627948800L,11569798584488362240UL,BigInteger.Parse("1775052172071446510592"),BigInteger.Parse("296026752508667034942464"),BigInteger.Parse("53320241823337034415908864"),BigInteger.Parse("10315767337287172256717568000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277418Inst Instance=new A277418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277419
{
public static readonly BigInteger[] Value={ 1L,6L,142L,5676L,318744L,23046370L,2038090320L,213094791840L,25714702990720L,3517403388684030L,537798502938028800L,BigInteger.Parse("90890936781714193300"),BigInteger.Parse("16825134146527678233600"),BigInteger.Parse("3385560150770468257273050"),BigInteger.Parse("735772370353606135149107200"),BigInteger.Parse("171753027520961356975091493000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277419Inst Instance=new A277419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277420
{
public static readonly BigInteger[] Value={ 1L,7L,194L,9078L,596760L,50508120L,5228520912L,639915545808L,90390815432064L,14472947716917120L,2590274418097708800L,BigInteger.Parse("512433683486806447872"),BigInteger.Parse("111036605823697437490176"),BigInteger.Parse("26153418409614396515976192"),BigInteger.Parse("6653213794092052464421939200"),BigInteger.Parse("1817951594633556391548903168000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277420Inst Instance=new A277420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277421
{
public static readonly BigInteger[] Value={ 1L,8L,254L,13614L,1025048L,99368620L,11781698256L,1651548277946L,267197019684224L,49000715036948304L,10044513851042988800UL,BigInteger.Parse("2275926588768085912582"),BigInteger.Parse("564838094735322988575744"),BigInteger.Parse("152378369304839730672573044"),BigInteger.Parse("44397985962782115253758973952") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277421Inst Instance=new A277421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277422
{
public static readonly BigInteger[] Value={ 1L,9L,322L,19446L,1649688L,180184120L,24070390992L,3801662863152L,692979602529664L,143184960501077376L,BigInteger.Parse("33069665092749868800"),BigInteger.Parse("8442378658666161822976"),BigInteger.Parse("2360674573114695421197312"),BigInteger.Parse("717531421372546588398529536"),BigInteger.Parse("235551703250624390582942574592") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277422Inst Instance=new A277422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277423
{
public static readonly BigInteger[] Value={ 1L,0L,-2L,6L,24L,-380L,720L,31794L,-361088L,-2104056L,101548800L,-612792290L,-25534891008L,593660731404L,2831189530624L,-361541172525750L,4481749181890560L,169464194149739536L,-6805365045197340672L,BigInteger.Parse("-9663483091971306186"),BigInteger.Parse("6883830206467440640000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277423Inst Instance=new A277423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277424
{
public static readonly BigInteger[] Value={ 1L,5L,39L,379L,4457L,61503L,974107L,17412317L,346662981L,7605810685L,182298744203L,4738700778123L,132767583248917L,3988244997744743L,127859570155253607L,4357113615504651565L,BigInteger.Parse("157266354405499307369"),BigInteger.Parse("5993377455733610208885"),BigInteger.Parse("240479249123008267155343") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277424Inst Instance=new A277424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277425
{
public static readonly long[] Value={ 0L,2L,3L,4L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,11L,12L,8L,9L,10L,11L,12L,13L,14L,15L,16L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277425Inst : IEnumerable<long>
{
public static readonly long[] Value=A277425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277425.Bytes);
public long this[int i]=>Value[i];

public static A277425Inst Instance=new A277425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277426
{
public static readonly BigInteger[] Value={ 32L,2048L,131072L,8388608L,536870912L,34359738368L,2199023255552L,140737488355328L,9007199254740992L,576460752303423488L,BigInteger.Parse("36893488147419103232"),BigInteger.Parse("2361183241434822606848"),BigInteger.Parse("151115727451828646838272"),BigInteger.Parse("9671406556917033397649408"),BigInteger.Parse("618970019642690137449562112"),BigInteger.Parse("39614081257132168796771975168") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277426Inst Instance=new A277426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277427
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,3L,2L,1L,4L,1L,2L,3L,4L,1L,3L,2L,4L,2L,1L,3L,4L,2L,3L,1L,4L,3L,1L,2L,4L,3L,2L,1L,5L,1L,2L,3L,4L,5L,1L,2L,4L,3L,5L,1L,3L,2L,4L,5L,1L,3L,4L,2L,5L,1L,4L,2L,3L,5L,1L,4L,3L,2L,5L,2L,1L,3L,4L,5L,2L,1L,4L,3L,5L,2L,3L,1L,4L,5L,2L,3L,4L,1L,5L,2L,4L,1L,3L,5L,2L,4L,3L,1L,5L,3L,1L,2L,4L,5L,3L,1L,4L,2L,5L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277427Inst : IEnumerable<long>
{
public static readonly long[] Value=A277427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277427.Bytes);
public long this[int i]=>Value[i];

public static A277427Inst Instance=new A277427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277428
{
public static readonly long[] Value={ 0L,1L,4L,9L,11L,22L,75L,105L,449L,425L,1426L,2837L,4765L,2775L,21895L,57558L,87602L,145177L,123788L,694479L,677326L,1516496L,3363284L,2048443L,26968428L,24488513L,98733728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277428Inst : IEnumerable<long>
{
public static readonly long[] Value=A277428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277428.Bytes);
public long this[int i]=>Value[i];

public static A277428Inst Instance=new A277428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277429
{
public static readonly BigInteger[] Value={ 67L,73L,46657L,25219L,29407171L,10997359L,109661317247L,31733679209L,558462830097043L,132566737763827L,BigInteger.Parse("646476041042787542443"),BigInteger.Parse("130499244418507180561"),BigInteger.Parse("2411172049639892707896547"),BigInteger.Parse("424191560077453917728503"),BigInteger.Parse("84883189962706557116984038531"),BigInteger.Parse("172244289373664036915914887721") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277429Inst Instance=new A277429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277430
{
public static readonly BigInteger[] Value={ 72L,288L,2073600L,33177600L,2809213747200L,179789679820800L,BigInteger.Parse("704200217922109440000"),BigInteger.Parse("180275255788060016640000"),BigInteger.Parse("6231974256792696936191754240000"),BigInteger.Parse("6381541638955721662660356341760000"),BigInteger.Parse("292214732887898713986916575925267070976000000"),BigInteger.Parse("1196911545908833132490410294989893922717696000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277430Inst Instance=new A277430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277431
{
public static readonly BigInteger[] Value={ 1L,1L,4L,12L,52L,260L,1568L,10976L,87824L,790416L,7904192L,86946112L,1043353408L,13563594304L,189890320384L,2848354805760L,45573676892416L,774752507171072L,13945545129079808L,264965357452516352L,5299307149050328064L,BigInteger.Parse("111285450130056889344"),BigInteger.Parse("2448279902861251567616") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277431Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277431.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277431Inst Instance=new A277431Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277432
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,32L,164L,984L,6896L,55168L,496528L,4965280L,54618112L,655417344L,8520425536L,119285957504L,1789289362688L,28628629803008L,486686706651392L,8760360719725056L,166446853674776576L,3328937073495531520L,BigInteger.Parse("69907678543406162944"),BigInteger.Parse("1537968927954935584768") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277432Inst Instance=new A277432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277433
{
public static readonly long[] Value={ 1L,4L,4L,4L,6L,6L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277433Inst : IEnumerable<long>
{
public static readonly long[] Value=A277433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277433.Bytes);
public long this[int i]=>Value[i];

public static A277433Inst Instance=new A277433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277434
{
public static readonly long[] Value={ 2L,7L,97L,708158977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277434Inst : IEnumerable<long>
{
public static readonly long[] Value=A277434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277434.Bytes);
public long this[int i]=>Value[i];

public static A277434Inst Instance=new A277434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277435
{
public static readonly long[] Value={ 6L,3L,2L,0L,9L,8L,6L,6L,1L,0L,5L,0L,8L,2L,9L,2L,5L,0L,3L,5L,5L,4L,5L,0L,6L,4L,5L,9L,9L,0L,7L,8L,0L,8L,6L,2L,7L,9L,9L,4L,7L,4L,5L,5L,2L,3L,2L,4L,1L,6L,4L,4L,7L,9L,6L,6L,9L,7L,2L,3L,3L,8L,2L,4L,3L,2L,5L,8L,6L,1L,6L,2L,7L,6L,1L,5L,0L,9L,6L,2L,1L,4L,7L,0L,9L,1L,7L,6L,6L,4L,9L,4L,2L,6L,6L,7L,7L,3L,7L,1L,6L,3L,7L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277435Inst : IEnumerable<long>
{
public static readonly long[] Value=A277435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277435.Bytes);
public long this[int i]=>Value[i];

public static A277435Inst Instance=new A277435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277436
{
public static readonly BigInteger[] Value={ 1L,2L,5L,34L,569L,14426L,518557L,25400810L,1625695409L,131681938834L,13168189962101L,1593350918236562L,229442532743676265L,BigInteger.Parse("38775788044161003434"),BigInteger.Parse("7600054456561351409549"),BigInteger.Parse("1710012252724103327072026"),BigInteger.Parse("437763136697393060993682017"),BigInteger.Parse("126513546505547193228474910370") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277436Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277436.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277436Inst Instance=new A277436Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277437
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,9L,7L,6L,12L,20L,8L,10L,21L,36L,72L,11L,13L,25L,50L,91L,144L,14L,16L,32L,56L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277437Inst : IEnumerable<long>
{
public static readonly long[] Value=A277437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277437.Bytes);
public long this[int i]=>Value[i];

public static A277437Inst Instance=new A277437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277438
{
public static readonly long[] Value={ 2L,5L,10L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277438Inst : IEnumerable<long>
{
public static readonly long[] Value=A277438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277438.Bytes);
public long this[int i]=>Value[i];

public static A277438Inst Instance=new A277438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277439
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,16L,27L,20L,11L,12L,13L,56L,135L,64L,85L,18L,19L,320L,567L,352L,115L,144L,175L,832L,1215L,2240L,29L,30L,217L,2560L,8019L,78336L,70L,5184L,925L,1064L,199017L,1120L,451L,42L,5375L,315392L,5670L,329728L,2585L,1152L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277439Inst : IEnumerable<long>
{
public static readonly long[] Value=A277439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277439.Bytes);
public long this[int i]=>Value[i];

public static A277439Inst Instance=new A277439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277440
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,1L,24L,3L,40L,3L,120L,1L,42L,5L,224L,5L,2592L,1L,540L,7L,220L,7L,4224L,5L,19968L,27L,728L,81L,1575L,1L,230400L,11L,8704L,77L,1377L,35L,18468L,13L,3891200L,13L,18063360L,1L,698544L,3645L,253L,3645L,5087232L,7L,307200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277440Inst : IEnumerable<long>
{
public static readonly long[] Value=A277440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277440.Bytes);
public long this[int i]=>Value[i];

public static A277440Inst Instance=new A277440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277441
{
public static readonly long[] Value={ 0L,10L,95L,950L,9500L,89476L,894760L,8946105L,89448001L,894438005L,8944300005L,89442827780L,894427300005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277441Inst : IEnumerable<long>
{
public static readonly long[] Value=A277441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277441.Bytes);
public long this[int i]=>Value[i];

public static A277441Inst Instance=new A277441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277442
{
public static readonly long[] Value={ 0L,10L,101L,100L,10006L,950005L,1001L,9569005L,100105L,100500L,1000L,95370001L,1000201L,102100005L,9957800L,100006L,9500005L,1100005L,100100L,1010005L,10001L,10000096L,10005005L,1000105L,1001005L,999578000L,1002600005L,12500100L,100010505L,1050500005L,1000500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277442Inst : IEnumerable<long>
{
public static readonly long[] Value=A277442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277442.Bytes);
public long this[int i]=>Value[i];

public static A277442Inst Instance=new A277442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277443
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,18L,0L,0L,2L,12L,84L,0L,0L,0L,114L,264L,260L,0L,0L,2L,180L,2652L,1920L,630L,0L,0L,0L,858L,16080L,29660L,8520L,1302L,0L,0L,2L,1932L,119844L,367080L,198030L,28140L,2408L,0L,0L,0L,7074L,816984L,4843460L,4067280L,932862L,76272L,4104L,0L,0L,2L,18660L,5784492L,62682480L,85847910L,28576380L,3440024L,179424L,6570L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277443Inst : IEnumerable<long>
{
public static readonly long[] Value=A277443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277443.Bytes);
public long this[int i]=>Value[i];

public static A277443Inst Instance=new A277443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277444
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,6L,0L,2L,0L,12L,0L,0L,42L,24L,20L,0L,2L,48L,420L,120L,30L,0L,0L,306L,2160L,2420L,360L,42L,0L,2L,600L,17532L,27600L,9750L,840L,56L,0L,0L,2442L,115464L,375260L,191760L,30702L,1680L,72L,0L,2L,6048L,830100L,4810680L,4098510L,917280L,81032L,3024L,90L,0L,0L,20706L,5745120L,62813540L,85691640L,28669662L,3406368L,187560L,5040L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277444Inst : IEnumerable<long>
{
public static readonly long[] Value=A277444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277444.Bytes);
public long this[int i]=>Value[i];

public static A277444Inst Instance=new A277444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277445
{
public static readonly BigInteger[] Value={ 1L,-2L,-4L,4L,48L,-160L,-32L,2176L,6912L,0L,-273408L,41984L,19456L,-37027840L,-141705216L,0L,3833856L,-34359869440L,0L,1625620480000L,11045440585728L,-47710208L,-520279482695680L,7719016726528L,909115392000L,-207717914210467840L,0L,0L,BigInteger.Parse("100736516652659638272"),BigInteger.Parse("-721057900040447590400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277445Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277445.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277445Inst Instance=new A277445Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277446
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,1L,2L,2L,3L,4L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,3L,4L,5L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,4L,3L,4L,4L,5L,6L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277446Inst : IEnumerable<long>
{
public static readonly long[] Value=A277446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277446.Bytes);
public long this[int i]=>Value[i];

public static A277446Inst Instance=new A277446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277447
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,1L,1L,3L,4L,2L,1L,2L,3L,1L,1L,2L,1L,3L,3L,5L,1L,2L,1L,4L,1L,3L,2L,3L,4L,1L,1L,2L,1L,3L,1L,3L,1L,3L,2L,3L,3L,5L,6L,1L,1L,2L,1L,2L,1L,4L,1L,2L,2L,3L,2L,5L,2L,4L,3L,4L,5L,1L,1L,1L,1L,3L,1L,3L,1L,3L,1L,4L,1L,3L,2L,2L,3L,3L,2L,4L,3L,3L,3L,3L,4L,5L,4L,8L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,4L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277447Inst : IEnumerable<long>
{
public static readonly long[] Value=A277447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277447.Bytes);
public long this[int i]=>Value[i];

public static A277447Inst Instance=new A277447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277448
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,3L,1L,1L,1L,6L,1L,3L,1L,4L,2L,1L,1L,2L,2L,6L,1L,4L,2L,3L,4L,2L,3L,4L,1L,4L,3L,1L,1L,2L,1L,2L,2L,4L,3L,6L,1L,2L,1L,4L,3L,2L,2L,3L,3L,5L,1L,2L,1L,3L,1L,4L,2L,2L,2L,4L,3L,5L,4L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,2L,4L,2L,4L,4L,6L,1L,1L,1L,3L,1L,2L,1L,4L,1L,3L,2L,2L,2L,3L,2L,3L,3L,4L,3L,6L,5L,1L,1L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277448Inst : IEnumerable<long>
{
public static readonly long[] Value=A277448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277448.Bytes);
public long this[int i]=>Value[i];

public static A277448Inst Instance=new A277448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277449
{
public static readonly long[] Value={ 34L,74L,100L,130L,202L,244L,290L,394L,452L,514L,650L,724L,802L,970L,1060L,1154L,1354L,1460L,1570L,1802L,1924L,2050L,2314L,2452L,2594L,2890L,3044L,3202L,3364L,3530L,3700L,3874L,4234L,4420L,4610L,5002L,5204L,5410L,5834L,6052L,6274L,6730L,6964L,7202L,7690L,7940L,8194L,8714L,8980L,9250L,9802L,10084L,10370L,10954L,11252L,11554L,12170L,12484L,12802L,13450L,13780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277449Inst : IEnumerable<long>
{
public static readonly long[] Value=A277449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277449.Bytes);
public long this[int i]=>Value[i];

public static A277449Inst Instance=new A277449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277450
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277450Inst : IEnumerable<long>
{
public static readonly long[] Value=A277450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277450.Bytes);
public long this[int i]=>Value[i];

public static A277450Inst Instance=new A277450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277451
{
public static readonly long[] Value={ 1L,30L,120L,480L,1920L,7680L,30720L,122880L,491520L,1966080L,7864320L,31457280L,125829120L,503316480L,2013265920L,8053063680L,32212254720L,128849018880L,515396075520L,2061584302080L,8246337208320L,32985348833280L,131941395333120L,527765581332480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277451Inst : IEnumerable<long>
{
public static readonly long[] Value=A277451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277451.Bytes);
public long this[int i]=>Value[i];

public static A277451Inst Instance=new A277451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277452
{
public static readonly BigInteger[] Value={ 1L,2L,13L,226L,7889L,458026L,39684637L,4788052298L,766526598721L,157108817646514L,40104442275129101L,12472587843118746322UL,BigInteger.Parse("4641978487740740993233"),BigInteger.Parse("2036813028164774540010266"),BigInteger.Parse("1040451608604560812273060189"),BigInteger.Parse("612098707457003526384666111226") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277452Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277452.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277452Inst Instance=new A277452Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277453
{
public static readonly BigInteger[] Value={ 1L,3L,41L,1531L,111393L,13262051L,2336744233L,570621092091L,184341785557121L,76092709735150723L,BigInteger.Parse("39064090158380196201"),BigInteger.Parse("24408768326642565035963"),BigInteger.Parse("18237590837527919131499041"),BigInteger.Parse("16056004231253610384348995811"),BigInteger.Parse("16448689708899063469247204152553") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277453Inst Instance=new A277453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277454
{
public static readonly BigInteger[] Value={ 1L,3L,21L,271L,5065L,122811L,3651997L,128566663L,5227782161L,241072839667L,12430169195941L,708612945554559L,44253858433505497L,3004570398043291819L,BigInteger.Parse("220341964157226260525"),BigInteger.Parse("17357760973540312138231"),BigInteger.Parse("1461813975265547356467745"),BigInteger.Parse("131061164660246579394042339") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277454Inst Instance=new A277454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277455
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,10L,20L,1L,36L,172L,2192L,3371L,1L,22327L,135561L,517656L,284492L,933118L,5446991L,24265724L,18238138L,93800069L,334654476L,1368408363L,2584589232L,1823879615L,25669818480L,41583822879L,1967330543L,29409700520L,1265785403L,3239855363874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277455Inst : IEnumerable<long>
{
public static readonly long[] Value=A277455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277455.Bytes);
public long this[int i]=>Value[i];

public static A277455Inst Instance=new A277455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277456
{
public static readonly BigInteger[] Value={ 1L,4L,43L,847L,23881L,870721L,38894653L,2055873037L,125480383153L,8684069883409L,671922832985941L,57475677232902589L,5385592533714824521L,BigInteger.Parse("548596467532888667257"),BigInteger.Parse("60358911366712739334541"),BigInteger.Parse("7133453715771227363127301"),BigInteger.Parse("901261693601873814393568993") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277456Inst Instance=new A277456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277457
{
public static readonly BigInteger[] Value={ 1L,3L,12L,71L,616L,7197L,105052L,1829291L,36922928L,846851993L,21744781684L,617832652527L,19242299657896L,651815827343189L,23857403245171724L,938247816632341043L,BigInteger.Parse("39455261828928309088"),BigInteger.Parse("1766645684585351990961"),BigInteger.Parse("83913998998426051745764"),BigInteger.Parse("4214295288128637488870327"),BigInteger.Parse("223120214856875472660345176") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277457Inst Instance=new A277457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277458
{
public static readonly BigInteger[] Value={ -1L,1L,0L,3L,16L,165L,2016L,30415L,539904L,11049129L,256038400L,6627314331L,189517916160L,5933803272397L,201893195083776L,7417376809230375L,292648536838045696L,12341039738944113105UL,BigInteger.Parse("553942486234823786496"),BigInteger.Parse("26369048375194607316019"),BigInteger.Parse("1326864458454400696320000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277458Inst Instance=new A277458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277459
{
public static readonly long[] Value={ 102L,387L,433L,436L,527L,656L,882L,1108L,1181L,1531L,1546L,1555L,1667L,1797L,1822L,1823L,1913L,1991L,2009L,2074L,2083L,2151L,2311L,2353L,2370L,2615L,2626L,2646L,2671L,3202L,3232L,3256L,3278L,3293L,3371L,3413L,3511L,3599L,3634L,3904L,3929L,3934L,4123L,4152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277459Inst : IEnumerable<long>
{
public static readonly long[] Value=A277459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277459.Bytes);
public long this[int i]=>Value[i];

public static A277459Inst Instance=new A277459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277460
{
public static readonly long[] Value={ 103L,388L,434L,437L,528L,657L,883L,1109L,1182L,1532L,1547L,1556L,1668L,1798L,1823L,1824L,1914L,1992L,2010L,2075L,2084L,2152L,2312L,2354L,2371L,2616L,2627L,2647L,2672L,3203L,3233L,3257L,3279L,3294L,3372L,3414L,3512L,3600L,3635L,3905L,3930L,3935L,4124L,4153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277460Inst : IEnumerable<long>
{
public static readonly long[] Value=A277460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277460.Bytes);
public long this[int i]=>Value[i];

public static A277460Inst Instance=new A277460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277461
{
public static readonly BigInteger[] Value={ 0L,1L,2L,11L,104L,1241L,18216L,317715L,6414848L,147107953L,3776164000L,107253230171L,3339157316736L,113070818225353L,4137170839854976L,162653198951193059L,6837934005096620032L,BigInteger.Parse("306093463368534049761"),BigInteger.Parse("14535589272368159900160"),BigInteger.Parse("729835620496621069643179") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277461Inst Instance=new A277461Inst();

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