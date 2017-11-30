using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A274062
{
public static readonly long[] Value={ 2L,14L,18L,230L,238L,4958L,53430L,57930L,64506L,65586L,68226L,70730L,77270L,78638L,81926L,84986L,88826L,90446L,91306L,1006350L,1248054L,1341950L,18177726L,19033854L,19603430L,21044030L,22356798L,22395522L,22876730L,23954170L,24241966L,24840710L,24883910L,25285666L,25306246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274062Inst : IEnumerable<long>
{
public static readonly long[] Value=A274062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274062.Bytes);
public long this[int i]=>Value[i];

public static A274062Inst Instance=new A274062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274063
{
public static readonly long[] Value={ 0L,1L,25L,26L,51L,119L,218L,771L,1754L,1799L,1921L,7967L,16147L,32639L,128129L,196611L,458759L,1044143L,2031647L,7190234L,8323199L,33464867L,536581571L,536813567L,1073691551L,2145328183L,7202169026L,8746826298L,17179612627L,68719005499L,797299610790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274063Inst : IEnumerable<long>
{
public static readonly long[] Value=A274063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274063.Bytes);
public long this[int i]=>Value[i];

public static A274063Inst Instance=new A274063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274064
{
public static readonly long[] Value={ 5L,50L,264L,435L,546L,1209L,3272L,8412L,20634L,52751L,137707L,362923L,962095L,2559621L,6811807L,18145756L,48384429L,129108567L,344635575L,920181094L,2457266397L,6562691188L,17528571958L,46820546020L,125067069103L,334088127067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274064Inst : IEnumerable<long>
{
public static readonly long[] Value=A274064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274064.Bytes);
public long this[int i]=>Value[i];

public static A274064Inst Instance=new A274064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274065
{
public static readonly long[] Value={ 1L,2L,2L,5L,9L,5L,14L,50L,50L,14L,41L,285L,264L,285L,41L,122L,1617L,435L,435L,1617L,122L,365L,9188L,546L,8L,546L,9188L,365L,1094L,52193L,1209L,1L,1L,1209L,52193L,1094L,3281L,296511L,3272L,0L,0L,0L,3272L,296511L,3281L,9842L,1684466L,8412L,0L,0L,0L,0L,8412L,1684466L,9842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274065Inst : IEnumerable<long>
{
public static readonly long[] Value=A274065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274065.Bytes);
public long this[int i]=>Value[i];

public static A274065Inst Instance=new A274065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274066
{
public static readonly long[] Value={ 2L,9L,50L,285L,1129L,4791L,17219L,63640L,182143L,598332L,1622713L,4807733L,12097755L,34041279L,81727927L,221397591L,519077550L,1343959858L,3089610203L,7776466084L,17320256047L,42922087359L,94826300116L,228462204560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274066Inst : IEnumerable<long>
{
public static readonly long[] Value=A274066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274066.Bytes);
public long this[int i]=>Value[i];

public static A274066Inst Instance=new A274066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274067
{
public static readonly long[] Value={ 5L,50L,136L,111L,97L,235L,197L,389L,305L,589L,447L,823L,621L,1089L,827L,1387L,1065L,1717L,1335L,2079L,1637L,2473L,1971L,2899L,2337L,3357L,2735L,3847L,3165L,4369L,3627L,4923L,4121L,5509L,4647L,6127L,5205L,6777L,5795L,7459L,6417L,8173L,7071L,8919L,7757L,9697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274067Inst : IEnumerable<long>
{
public static readonly long[] Value=A274067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274067.Bytes);
public long this[int i]=>Value[i];

public static A274067Inst Instance=new A274067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274068
{
public static readonly long[] Value={ 1L,2L,2L,5L,9L,5L,14L,50L,50L,14L,41L,285L,136L,285L,41L,122L,1129L,111L,111L,1129L,122L,365L,4791L,97L,0L,97L,4791L,365L,1094L,17219L,235L,0L,0L,235L,17219L,1094L,3281L,63640L,197L,0L,0L,0L,197L,63640L,3281L,9842L,182143L,389L,0L,0L,0L,0L,389L,182143L,9842L,29525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274068Inst : IEnumerable<long>
{
public static readonly long[] Value=A274068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274068.Bytes);
public long this[int i]=>Value[i];

public static A274068Inst Instance=new A274068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274069
{
public static readonly BigInteger[] Value={ 1L,10L,1010L,1010100L,101010010L,101010010110L,101010010110100L,101010010110100100L,BigInteger.Parse("1010100101101001001000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274069Inst Instance=new A274069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274070
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274070Inst : IEnumerable<long>
{
public static readonly long[] Value=A274070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274070.Bytes);
public long this[int i]=>Value[i];

public static A274070Inst Instance=new A274070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274071
{
public static readonly long[] Value={ 6L,20L,87L,304L,1398L,3582L,9218L,18270L,34873L,70451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274071Inst : IEnumerable<long>
{
public static readonly long[] Value=A274071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274071.Bytes);
public long this[int i]=>Value[i];

public static A274071Inst Instance=new A274071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274072
{
public static readonly long[] Value={ 0L,6L,24L,126L,624L,3126L,15624L,78126L,390624L,1953126L,9765624L,48828126L,244140624L,1220703126L,6103515624L,30517578126L,152587890624L,762939453126L,3814697265624L,19073486328126L,95367431640624L,476837158203126L,2384185791015624L,11920928955078126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274072Inst : IEnumerable<long>
{
public static readonly long[] Value=A274072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274072.Bytes);
public long this[int i]=>Value[i];

public static A274072Inst Instance=new A274072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274073
{
public static readonly long[] Value={ 0L,7L,35L,217L,1295L,7777L,46655L,279937L,1679615L,10077697L,60466175L,362797057L,2176782335L,13060694017L,78364164095L,470184984577L,2821109907455L,16926659444737L,101559956668415L,609359740010497L,3656158440062975L,21936950640377857L,131621703842267135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274073Inst : IEnumerable<long>
{
public static readonly long[] Value=A274073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274073.Bytes);
public long this[int i]=>Value[i];

public static A274073Inst Instance=new A274073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274074
{
public static readonly long[] Value={ 2L,5L,37L,215L,1297L,7775L,46657L,279935L,1679617L,10077695L,60466177L,362797055L,2176782337L,13060694015L,78364164097L,470184984575L,2821109907457L,16926659444735L,101559956668417L,609359740010495L,3656158440062977L,21936950640377855L,131621703842267137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274074Inst : IEnumerable<long>
{
public static readonly long[] Value=A274074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274074.Bytes);
public long this[int i]=>Value[i];

public static A274074Inst Instance=new A274074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274075
{
public static readonly long[] Value={ 3L,-1L,19L,-25L,195L,-401L,2131L,-5545L,24323L,-72097L,285459L,-910009L,3407043L,-11311665L,41065043L,-139462985L,497736707L,-1711838529L,6052005907L,-20960815961L,73717030595L,-256312368337L,898804827731L,-3131899112169L,10964830193411L,-38253117375201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274075Inst : IEnumerable<long>
{
public static readonly long[] Value=A274075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274075.Bytes);
public long this[int i]=>Value[i];

public static A274075Inst Instance=new A274075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274076
{
public static readonly long[] Value={ -2L,2L,-2L,-4L,8L,-20L,2L,-58L,14L,-70L,-4L,16L,-344L,112L,-28L,4L,-556L,1064L,-152L,308L,-308L,-8L,10256L,-3368L,4576L,-6248L,2288L,-1144L,2L,-1622L,33398L,-98794L,34606L,-4862L,2002L,-1430L,-4L,6688L,-187216L,140384L,-1242904L,59488L,-25168L,77792L,-48620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274076Inst : IEnumerable<long>
{
public static readonly long[] Value=A274076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274076.Bytes);
public long this[int i]=>Value[i];

public static A274076Inst Instance=new A274076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274077
{
public static readonly long[] Value={ 4L,5L,12L,31L,68L,129L,220L,347L,516L,733L,1004L,1335L,1732L,2201L,2748L,3379L,4100L,4917L,5836L,6863L,8004L,9265L,10652L,12171L,13828L,15629L,17580L,19687L,21956L,24393L,27004L,29795L,32772L,35941L,39308L,42879L,46660L,50657L,54876L,59323L,64004L,68925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274077Inst : IEnumerable<long>
{
public static readonly long[] Value=A274077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274077.Bytes);
public long this[int i]=>Value[i];

public static A274077Inst Instance=new A274077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274078
{
public static readonly long[] Value={ 3L,15L,3L,315L,27L,27L,2835L,945L,27L,81L,155925L,2025L,2025L,135L,27L,6081075L,779625L,30375L,405L,243L,243L,638512875L,212837625L,654885L,42525L,8505L,1215L,729L,10854718875L,638512875L,58046625L,4465125L,127575L,3645L,729L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274078Inst : IEnumerable<long>
{
public static readonly long[] Value=A274078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274078.Bytes);
public long this[int i]=>Value[i];

public static A274078Inst Instance=new A274078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274079
{
public static readonly long[] Value={ 2L,4L,5L,4L,7L,8L,7L,9L,8L,7L,11L,12L,11L,13L,12L,11L,14L,13L,12L,11L,16L,17L,16L,18L,17L,16L,19L,18L,17L,16L,20L,19L,18L,17L,16L,22L,23L,22L,24L,23L,22L,25L,24L,23L,22L,26L,25L,24L,23L,22L,27L,26L,25L,24L,23L,22L,29L,30L,29L,31L,30L,29L,32L,31L,30L,29L,33L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274079Inst : IEnumerable<long>
{
public static readonly long[] Value=A274079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274079.Bytes);
public long this[int i]=>Value[i];

public static A274079Inst Instance=new A274079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274080
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,3L,4L,1L,3L,4L,5L,1L,2L,4L,2L,3L,4L,5L,7L,2L,3L,5L,6L,7L,8L,1L,3L,6L,7L,8L,9L,1L,2L,4L,7L,3L,4L,5L,7L,8L,11L,1L,4L,5L,6L,8L,9L,11L,12L,2L,5L,6L,9L,10L,11L,12L,13L,1L,3L,6L,10L,11L,12L,13L,14L,1L,2L,4L,7L,11L,3L,5L,7L,8L,11L,12L,16L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274080Inst : IEnumerable<long>
{
public static readonly long[] Value=A274080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274080.Bytes);
public long this[int i]=>Value[i];

public static A274080Inst Instance=new A274080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274081
{
public static readonly BigInteger[] Value={ 1L,5L,560L,277200L,369969600L,1040623584000L,5318844410880000L,BigInteger.Parse("44743448895425280000"),BigInteger.Parse("577102758498249984000000"),BigInteger.Parse("10821132329283106871040000000"),BigInteger.Parse("283002122589833107696435200000000"),BigInteger.Parse("9986037506585076241055342592000000000"),BigInteger.Parse("462684151212030123561950840428953600000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274081Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274081.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274081Inst Instance=new A274081Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274082
{
public static readonly long[] Value={ 1L,5L,6L,3L,5L,3L,1L,7L,1L,1L,0L,7L,0L,5L,5L,8L,5L,1L,0L,7L,3L,8L,8L,7L,9L,0L,3L,8L,6L,7L,8L,0L,6L,3L,9L,2L,2L,6L,9L,7L,8L,3L,7L,3L,2L,2L,8L,8L,9L,9L,4L,1L,2L,7L,8L,9L,2L,8L,0L,0L,6L,7L,9L,4L,9L,3L,8L,1L,6L,5L,7L,8L,0L,2L,0L,9L,6L,8L,8L,2L,4L,4L,6L,1L,3L,6L,2L,4L,0L,6L,2L,9L,7L,8L,5L,9L,9L,1L,1L,5L,8L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274082Inst : IEnumerable<long>
{
public static readonly long[] Value=A274082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274082.Bytes);
public long this[int i]=>Value[i];

public static A274082Inst Instance=new A274082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274083
{
public static readonly BigInteger[] Value={ 1L,6L,3150L,12612600L,192972780000L,8046096548490000L,BigInteger.Parse("747480957758835300000"),BigInteger.Parse("135330984231708815550000000"),BigInteger.Parse("43401712634861734607093640000000"),BigInteger.Parse("22953694145310867501311470722000000000"),BigInteger.Parse("18935469872719334117190133449041218500000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274083Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274083.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274083Inst Instance=new A274083Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274084
{
public static readonly long[] Value={ 15L,21L,91L,171L,666L,703L,820L,1830L,1953L,3003L,3081L,4095L,7140L,7381L,10440L,12720L,14706L,16471L,16653L,18915L,23871L,24976L,30628L,47586L,47895L,48828L,66430L,71631L,79401L,95703L,101475L,104653L,119805L,128778L,148240L,148785L,173166L,191271L,221445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274084Inst : IEnumerable<long>
{
public static readonly long[] Value=A274084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274084.Bytes);
public long this[int i]=>Value[i];

public static A274084Inst Instance=new A274084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274085
{
public static readonly long[] Value={ 1L,2L,1L,6L,1L,9L,1L,1L,1L,2L,4L,9L,4L,4L,2L,2L,1L,8L,1L,2L,21L,10L,1L,13L,4L,1L,6L,2L,10L,2L,2L,3L,1L,12L,3L,2L,1L,1L,2L,1L,9L,7L,3L,1L,4L,2L,8L,1L,11L,1L,2L,4L,3L,1L,7L,6L,1L,1L,1L,11L,1L,2L,1L,9L,1L,2L,1L,2L,9L,44L,1L,1L,1L,1L,34L,1L,12L,1L,3L,2L,3L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274085Inst : IEnumerable<long>
{
public static readonly long[] Value=A274085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274085.Bytes);
public long this[int i]=>Value[i];

public static A274085Inst Instance=new A274085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274086
{
public static readonly long[] Value={ 0L,2L,-4L,0L,5L,-17L,-2L,6L,-54L,-4L,6L,-2485L,-8L,6L,101L,-13L,5L,59L,-20L,3L,45L,-32L,0L,37L,-51L,-3L,31L,-88L,-8L,26L,-192L,-14L,21L,-2485L,-21L,17L,279L,-31L,12L,141L,-45L,7L,96L,-64L,1L,73L,-96L,-6L,58L,-155L,-14L,46L,-315L,-23L,36L,-2485L,-34L,28L,483L,-49L,19L,228L,-68L,11L,150L,-96L,2L,111L,-139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274086Inst : IEnumerable<long>
{
public static readonly long[] Value=A274086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274086.Bytes);
public long this[int i]=>Value[i];

public static A274086Inst Instance=new A274086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274087
{
public static readonly long[] Value={ 0L,1L,4L,1L,-12L,-24L,-10L,32L,63L,33L,-54L,-121L,-77L,71L,194L,146L,-74L,-278L,-243L,54L,365L,369L,-4L,-448L,-522L,-83L,515L,697L,212L,-558L,-889L,-388L,565L,1089L,612L,-525L,-1285L,-881L,428L,1466L,1192L,-267L,-1617L,-1538L,34L,1723L,1908L,273L,-1770L,-2290L,-656L,1743L,2668L,1112L,-1629L,-3024L,-1636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274087Inst : IEnumerable<long>
{
public static readonly long[] Value=A274087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274087.Bytes);
public long this[int i]=>Value[i];

public static A274087Inst Instance=new A274087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274088
{
public static readonly long[] Value={ 0L,1L,4L,9L,15L,20L,23L,23L,20L,11L,-2L,-21L,-46L,-76L,-111L,-150L,-194L,-240L,-289L,-339L,-389L,-437L,-484L,-527L,-566L,-599L,-626L,-645L,-656L,-658L,-649L,-630L,-600L,-559L,-505L,-440L,-362L,-273L,-171L,-58L,66L,201L,346L,501L,664L,835L,1013L,1197L,1385L,1577L,1772L,1968L,2164L,2359L,2551L,2740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274088Inst : IEnumerable<long>
{
public static readonly long[] Value=A274088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274088.Bytes);
public long this[int i]=>Value[i];

public static A274088Inst Instance=new A274088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274089
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,6L,6L,7L,7L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L,38L,39L,39L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274089Inst : IEnumerable<long>
{
public static readonly long[] Value=A274089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274089.Bytes);
public long this[int i]=>Value[i];

public static A274089Inst Instance=new A274089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274090
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-7L,-15L,-28L,-43L,-61L,-80L,-100L,-119L,-137L,-151L,-162L,-167L,-167L,-161L,-147L,-125L,-95L,-57L,-11L,44L,107L,177L,255L,339L,429L,524L,623L,725L,830L,935L,1040L,1143L,1244L,1342L,1434L,1520L,1599L,1669L,1730L,1780L,1819L,1845L,1858L,1857L,1841L,1810L,1763L,1700L,1621L,1525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274090Inst : IEnumerable<long>
{
public static readonly long[] Value=A274090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274090.Bytes);
public long this[int i]=>Value[i];

public static A274090Inst Instance=new A274090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274091
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,1L,9L,-1L,15L,-7L,20L,-15L,23L,-28L,23L,-43L,20L,-61L,11L,-80L,-2L,-100L,-21L,-119L,-46L,-137L,-76L,-151L,-111L,-162L,-150L,-167L,-194L,-167L,-240L,-161L,-289L,-147L,-339L,-125L,-389L,-95L,-437L,-57L,-484L,-11L,-527L,44L,-566L,107L,-599L,177L,-626L,255L,-645L,339L,-656L,429L,-658L,524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274091Inst : IEnumerable<long>
{
public static readonly long[] Value=A274091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274091.Bytes);
public long this[int i]=>Value[i];

public static A274091Inst Instance=new A274091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274092
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,-1L,4L,1L,-4L,9L,-1L,-9L,15L,-7L,-15L,20L,-15L,-20L,23L,-28L,-23L,23L,-43L,-23L,20L,-61L,-20L,11L,-80L,-11L,-2L,-100L,2L,-21L,-119L,21L,-46L,-137L,46L,-76L,-151L,76L,-111L,-162L,111L,-150L,-167L,150L,-194L,-167L,194L,-240L,-161L,240L,-289L,-147L,289L,-339L,-125L,339L,-389L,-95L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274092Inst : IEnumerable<long>
{
public static readonly long[] Value=A274092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274092.Bytes);
public long this[int i]=>Value[i];

public static A274092Inst Instance=new A274092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274093
{
public static readonly long[] Value={ 0L,-1L,2L,2L,-3L,-3L,-3L,4L,4L,4L,4L,-5L,-5L,-5L,-5L,-5L,6L,6L,6L,6L,6L,6L,-7L,-7L,-7L,-7L,-7L,-7L,-7L,8L,8L,8L,8L,8L,8L,8L,8L,-9L,-9L,-9L,-9L,-9L,-9L,-9L,-9L,-9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,-11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274093Inst : IEnumerable<long>
{
public static readonly long[] Value=A274093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274093.Bytes);
public long this[int i]=>Value[i];

public static A274093Inst Instance=new A274093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274094
{
public static readonly long[] Value={ 0L,1L,-2L,-2L,3L,3L,3L,-4L,-4L,-4L,-4L,5L,5L,5L,5L,5L,-6L,-6L,-6L,-6L,-6L,-6L,7L,7L,7L,7L,7L,7L,7L,-8L,-8L,-8L,-8L,-8L,-8L,-8L,-8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,-10L,-10L,-10L,-10L,-10L,-10L,-10L,-10L,-10L,-10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,-12L,-12L,-12L,-12L,-12L,-12L,-12L,-12L,-12L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274094Inst : IEnumerable<long>
{
public static readonly long[] Value=A274094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274094.Bytes);
public long this[int i]=>Value[i];

public static A274094Inst Instance=new A274094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274095
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,4L,3L,2L,1L,0L,-2L,-4L,-6L,-8L,-10L,-12L,-14L,-16L,-18L,-19L,-21L,-22L,-23L,-24L,-24L,-24L,-24L,-23L,-23L,-22L,-20L,-19L,-17L,-15L,-13L,-10L,-7L,-5L,-1L,2L,5L,8L,12L,15L,19L,22L,25L,29L,32L,35L,39L,42L,45L,47L,50L,52L,54L,56L,58L,60L,61L,62L,63L,63L,64L,64L,63L,63L,62L,61L,60L,58L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274095Inst : IEnumerable<long>
{
public static readonly long[] Value=A274095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274095.Bytes);
public long this[int i]=>Value[i];

public static A274095Inst Instance=new A274095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274096
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,0L,3L,0L,4L,-2L,4L,-3L,4L,-5L,3L,-6L,2L,-8L,1L,-9L,0L,-10L,-2L,-11L,-4L,-11L,-6L,-12L,-8L,-12L,-10L,-11L,-12L,-10L,-14L,-9L,-16L,-8L,-18L,-7L,-19L,-5L,-21L,-3L,-22L,0L,-23L,2L,-24L,4L,-24L,7L,-24L,10L,-24L,13L,-23L,15L,-23L,18L,-22L,21L,-20L,23L,-19L,26L,-17L,28L,-15L,31L,-13L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274096Inst : IEnumerable<long>
{
public static readonly long[] Value=A274096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274096.Bytes);
public long this[int i]=>Value[i];

public static A274096Inst Instance=new A274096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274097
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,-1L,2L,0L,-2L,3L,0L,-3L,4L,-2L,-4L,4L,-3L,-4L,4L,-5L,-4L,3L,-6L,-3L,2L,-8L,-2L,1L,-9L,-1L,0L,-10L,0L,-2L,-11L,2L,-4L,-11L,4L,-6L,-12L,6L,-8L,-12L,8L,-10L,-11L,10L,-12L,-10L,12L,-14L,-9L,14L,-16L,-8L,16L,-18L,-7L,18L,-19L,-5L,19L,-21L,-3L,21L,-22L,0L,22L,-23L,2L,23L,-24L,4L,24L,-24L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274097Inst : IEnumerable<long>
{
public static readonly long[] Value=A274097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274097.Bytes);
public long this[int i]=>Value[i];

public static A274097Inst Instance=new A274097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274098
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,280L,8640L,233520L,23157120L,5329376640L,1314169920000L,1016970317932800L,1772428331094220800L,BigInteger.Parse("3441650619022551936000"),BigInteger.Parse("22088285526822118789785600"),BigInteger.Parse("291368298787833283829100288000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274098Inst Instance=new A274098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274099
{
public static readonly long[] Value={ 1L,1L,3L,9L,23L,54L,120L,249L,478L,864L,1495L,2484L,3969L,6136L,9234L,13561L,19464L,27378L,37845L,51488L,69012L,91260L,119239L,154078L,197026L,249535L,313290L,390144L,482120L,591519L,720954L,873264L,1051513L,1259130L,1499950L,1778097L,2097984L,2464489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274099Inst : IEnumerable<long>
{
public static readonly long[] Value=A274099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274099.Bytes);
public long this[int i]=>Value[i];

public static A274099Inst Instance=new A274099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274100
{
public static readonly long[] Value={ 1L,2L,5L,15L,64L,351L,2280L,16335L,123464L,959631L,7566280L,60090255L,478968264L,3824743311L,30569959880L,244447781775L,1955134763464L,15639288341391L,125107148059080L,1000828550570895L,8006513870533064L,64051652831273871L,512411390124519880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274100Inst : IEnumerable<long>
{
public static readonly long[] Value=A274100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274100.Bytes);
public long this[int i]=>Value[i];

public static A274100Inst Instance=new A274100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274101
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,-1L,-1L,2L,0L,-2L,0L,3L,0L,-3L,0L,4L,-2L,-4L,2L,4L,-3L,-4L,3L,4L,-5L,-4L,5L,3L,-6L,-3L,6L,2L,-8L,-2L,8L,1L,-9L,-1L,9L,0L,-10L,0L,10L,-2L,-11L,2L,11L,-4L,-11L,4L,11L,-6L,-12L,6L,12L,-8L,-12L,8L,12L,-10L,-11L,10L,11L,-12L,-10L,12L,10L,-14L,-9L,14L,9L,-16L,-8L,16L,8L,-18L,-7L,18L,7L,-19L,-5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274101Inst : IEnumerable<long>
{
public static readonly long[] Value=A274101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274101.Bytes);
public long this[int i]=>Value[i];

public static A274101Inst Instance=new A274101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274102
{
public static readonly long[] Value={ 0L,0L,1L,-1L,2L,-2L,3L,-3L,4L,-4L,4L,-4L,4L,-4L,3L,-3L,2L,-2L,1L,-1L,0L,0L,-2L,2L,-4L,4L,-6L,6L,-8L,8L,-10L,10L,-12L,12L,-14L,14L,-16L,16L,-18L,18L,-19L,19L,-21L,21L,-22L,22L,-23L,23L,-24L,24L,-24L,24L,-24L,24L,-24L,24L,-23L,23L,-23L,23L,-22L,22L,-20L,20L,-19L,19L,-17L,17L,-15L,15L,-13L,13L,-10L,10L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274102Inst : IEnumerable<long>
{
public static readonly long[] Value=A274102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274102.Bytes);
public long this[int i]=>Value[i];

public static A274102Inst Instance=new A274102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274103
{
public static readonly long[] Value={ 3L,6L,17L,66L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274103Inst : IEnumerable<long>
{
public static readonly long[] Value=A274103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274103.Bytes);
public long this[int i]=>Value[i];

public static A274103Inst Instance=new A274103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274104
{
public static readonly long[] Value={ 2L,7L,23L,78L,274L,988L,3628L,13495L,50675L,191673L,729145L,2786655L,10691111L,41150011L,158825371L,614483086L,2382366586L,9253540456L,36001307656L,140269835866L,547245301906L,2137552658206L,8358366985726L,32715599554876L,128168506456852L,502538379368656L,1971926625140816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274104Inst : IEnumerable<long>
{
public static readonly long[] Value=A274104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274104.Bytes);
public long this[int i]=>Value[i];

public static A274104Inst Instance=new A274104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274105
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,5L,4L,1L,8L,14L,4L,1L,13L,46L,46L,8L,1L,18L,98L,184L,100L,8L,1L,25L,206L,674L,836L,308L,16L,1L,32L,356L,1704L,3532L,2816L,632L,16L,1L,41L,612L,4196L,13756L,20476L,11896L,1912L,32L,1L,50L,940L,8480L,38932L,89256L,93800L,37600L,3856L,32L,1L,61L,1440L,16940L,106772L,361780L,629336L,506600L,154256L,11600L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274105Inst : IEnumerable<long>
{
public static readonly long[] Value=A274105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274105.Bytes);
public long this[int i]=>Value[i];

public static A274105Inst Instance=new A274105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274106
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,1L,8L,14L,4L,1L,12L,38L,32L,4L,1L,18L,98L,184L,100L,8L,1L,24L,188L,576L,652L,208L,8L,1L,32L,356L,1704L,3532L,2816L,632L,16L,1L,40L,580L,3840L,12052L,16944L,9080L,1280L,16L,1L,50L,940L,8480L,38932L,89256L,93800L,37600L,3856L,32L,1L,60L,1390L,16000L,98292L,322848L,540080L,412800L,116656L,7744L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274106Inst : IEnumerable<long>
{
public static readonly long[] Value=A274106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274106.Bytes);
public long this[int i]=>Value[i];

public static A274106Inst Instance=new A274106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274107
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,13L,-1L,-9L,4L,8L,0L,13L,8L,0L,49L,17L,-9L,34L,-7L,-33L,10L,-13L,-39L,28L,-4L,-30L,13L,26L,0L,43L,20L,-6L,61L,29L,3L,46L,32L,6L,49L,26L,0L,157L,71L,-9L,124L,29L,-51L,82L,5L,-75L,130L,44L,-36L,97L,-25L,-105L,28L,-49L,-129L,76L,-10L,-90L,43L,-25L,-105L,28L,-49L,-129L,100L,14L,-66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274107Inst : IEnumerable<long>
{
public static readonly long[] Value=A274107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274107.Bytes);
public long this[int i]=>Value[i];

public static A274107Inst Instance=new A274107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274108
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,5L,11L,11L,16L,17L,27L,21L,37L,33L,38L,42L,59L,46L,71L,57L,70L,75L,97L,72L,104L,99L,109L,103L,141L,102L,157L,133L,148L,153L,166L,140L,207L,183L,192L,174L,241L,180L,259L,215L,223L,247L,295L,219L,300L,260L,292L,279L,353L,275L,336L,300L,346L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274108Inst : IEnumerable<long>
{
public static readonly long[] Value=A274108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274108.Bytes);
public long this[int i]=>Value[i];

public static A274108Inst Instance=new A274108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274109
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,3L,3L,2L,2L,1L,2L,2L,2L,2L,2L,1L,3L,3L,2L,3L,2L,2L,1L,2L,2L,4L,1L,3L,2L,2L,1L,5L,5L,3L,4L,2L,3L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,1L,6L,6L,4L,5L,2L,4L,2L,3L,2L,2L,1L,3L,3L,5L,3L,4L,1L,4L,2L,3L,2L,2L,1L,4L,4L,3L,3L,4L,4L,2L,4L,2L,3L,2L,2L,1L,4L,4L,5L,3L,4L,3L,3L,2L,4L,2L,3L,2L,2L,1L,8L,8L,5L,7L,3L,5L,3L,4L,2L,4L,2L,3L,2L,2L,1L,3L,3L,5L,2L,5L,2L,4L,2L,4L,2L,4L,2L,3L,2L,2L,1L,9L,9L,6L,7L,3L,7L,3L,4L,3L,4L,2L,4L,2L,3L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274109Inst : IEnumerable<long>
{
public static readonly long[] Value=A274109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274109.Bytes);
public long this[int i]=>Value[i];

public static A274109Inst Instance=new A274109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274110
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,14L,24L,42L,73L,128L,224L,393L,689L,1209L,2121L,3722L,6531L,11461L,20112L,35294L,61936L,108690L,190737L,334720L,587392L,1030801L,1808929L,3174449L,5570769L,9776018L,17155715L,30106181L,52832664L,92714862L,162703240L,285524282L,501060185L,879299328L,1543062752L,2707886361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274110Inst : IEnumerable<long>
{
public static readonly long[] Value=A274110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274110.Bytes);
public long this[int i]=>Value[i];

public static A274110Inst Instance=new A274110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274111
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,5L,7L,10L,13L,20L,28L,45L,65L,101L,143L,222L,317L,500L,726L,1143L,1661L,2608L,3796L,5983L,8764L,13835L,20335L,32089L,47251L,74637L,110227L,174302L,258095L,408276L,605664L,958551L,1424659L,2256136L,3359446L,5322449L,7937666L,12580545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274111Inst : IEnumerable<long>
{
public static readonly long[] Value=A274111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274111.Bytes);
public long this[int i]=>Value[i];

public static A274111Inst Instance=new A274111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274112
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,8L,12L,17L,23L,35L,52L,75L,105L,157L,232L,337L,480L,712L,1049L,1529L,2199L,3248L,4777L,6976L,10092L,14869L,21845L,31937L,46377L,68222L,100159L,146536L,213328L,313487L,460023L,673351L,981976L,1441999L,2115350L,3097326L,4522529L,6637879L,9735205L,14257734L,20836827L,30572032L,44829766L,65666593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274112Inst : IEnumerable<long>
{
public static readonly long[] Value=A274112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274112.Bytes);
public long this[int i]=>Value[i];

public static A274112Inst Instance=new A274112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274113
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,5L,7L,11L,16L,26L,39L,63L,95L,154L,235L,381L,585L,948L,1464L,2373L,3682L,5967L,9293L,15060L,23531L,38131L,59741L,96801L,152020L,246310L,387611L,627985L,990027L,1603893L,2532609L,4102726L,6487600L,10509114L,16639214L,26952186L,42722941L,69199472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274113Inst : IEnumerable<long>
{
public static readonly long[] Value=A274113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274113.Bytes);
public long this[int i]=>Value[i];

public static A274113Inst Instance=new A274113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274114
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,17L,37L,81L,180L,405L,917L,2090L,4795L,11054L,25589L,59475L,138712L,324483L,761163L,1790028L,4219139L,9965328L,23582735L,55906518L,132751359L,315700152L,751837207L,1792853416L,4280568845L,10232005939L,24484563844L,58650123942L,140625967460L,337488663293L,810641635789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274114Inst : IEnumerable<long>
{
public static readonly long[] Value=A274114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274114.Bytes);
public long this[int i]=>Value[i];

public static A274114Inst Instance=new A274114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274115
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,17L,35L,75L,157L,337L,712L,1529L,3248L,6976L,14869L,31937L,68222L,146536L,313487L,673351L,1441999L,3097326L,6637879L,14257734L,30572032L,65666593L,140860379L,302557585L,649202036L,1394434685L,2992721902L,6428118868L,13798302512L,29637567305L,63626933527L,136665012979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274115Inst : IEnumerable<long>
{
public static readonly long[] Value=A274115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274115.Bytes);
public long this[int i]=>Value[i];

public static A274115Inst Instance=new A274115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274116
{
public static readonly long[] Value={ 220L,284L,366L,378L,2620L,2924L,3864L,4584L,5020L,5564L,16104L,16536L,16632L,16728L,26448L,28752L,29760L,30912L,43524L,53692L,63020L,67344L,69552L,69615L,76084L,87633L,100485L,122265L,124155L,139815L,142290L,142310L,168730L,179118L,196248L,196724L,198990L,202444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274116Inst : IEnumerable<long>
{
public static readonly long[] Value=A274116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274116.Bytes);
public long this[int i]=>Value[i];

public static A274116Inst Instance=new A274116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274117
{
public static readonly BigInteger[] Value={ 1L,12L,1064L,252160L,115315200L,86449126400L,96313245952000L,149342026677043200L,BigInteger.Parse("307513455044956160000"),BigInteger.Parse("811744577542368870400000"),BigInteger.Parse("2672529840751688498380800000"),BigInteger.Parse("10735527449319396895332761600000"),BigInteger.Parse("51677469466519591978527317032960000"),BigInteger.Parse("293652804750537765304678163152896000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274117Inst Instance=new A274117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274118
{
public static readonly long[] Value={ 108L,140L,195L,1050L,1925L,8892L,16587L,312620L,549219L,587460L,1057595L,1279950L,2576945L,5088650L,6446325L,7460004L,7875450L,10925915L,13922100L,16381925L,22559060L,26502315L,29864120L,30809415L,31213899L,41137620L,84854315L,89446860L,102019644L,114859884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274118Inst : IEnumerable<long>
{
public static readonly long[] Value=A274118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274118.Bytes);
public long this[int i]=>Value[i];

public static A274118Inst Instance=new A274118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274119
{
public static readonly long[] Value={ 11L,120L,435L,1064L,2115L,3696L,5915L,8880L,12699L,17480L,23331L,30360L,38675L,48384L,59595L,72416L,86955L,103320L,121619L,141960L,164451L,189200L,216315L,245904L,278075L,312936L,350595L,391160L,434739L,481440L,531371L,584640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274119Inst : IEnumerable<long>
{
public static readonly long[] Value=A274119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274119.Bytes);
public long this[int i]=>Value[i];

public static A274119Inst Instance=new A274119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274120
{
public static readonly long[] Value={ 961L,1369L,1849L,4225L,263169L,130919364L,758451600L,29682949232484409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274120Inst : IEnumerable<long>
{
public static readonly long[] Value=A274120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274120.Bytes);
public long this[int i]=>Value[i];

public static A274120Inst Instance=new A274120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274121
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,4L,3L,1L,5L,2L,4L,6L,5L,3L,4L,7L,5L,6L,8L,6L,7L,7L,1L,8L,9L,9L,10L,10L,1L,11L,8L,11L,1L,12L,9L,10L,12L,11L,12L,13L,2L,14L,13L,15L,1L,2L,14L,16L,15L,13L,17L,3L,14L,15L,16L,18L,17L,16L,19L,4L,2L,17L,20L,18L,3L,18L,5L,21L,19L,19L,2L,20L,21L,20L,22L,3L,21L,4L,6L,22L,7L,23L,23L,22L,24L,5L,23L,24L,24L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274121Inst : IEnumerable<long>
{
public static readonly long[] Value=A274121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274121.Bytes);
public long this[int i]=>Value[i];

public static A274121Inst Instance=new A274121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274122
{
public static readonly long[] Value={ 97L,103L,109L,137L,163L,397L,457L,463L,569L,613L,739L,821L,827L,857L,2111L,2137L,2203L,2239L,2269L,2309L,2347L,2381L,4127L,4217L,8803L,9337L,12487L,12739L,12889L,12917L,19991L,20021L,20717L,20747L,20771L,20959L,21187L,21313L,21319L,21379L,21599L,21613L,21817L,21859L,22037L,22091L,22129L,22157L,22271L,22277L,22481L,22567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274122Inst : IEnumerable<long>
{
public static readonly long[] Value=A274122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274122.Bytes);
public long this[int i]=>Value[i];

public static A274122Inst Instance=new A274122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274123
{
public static readonly long[] Value={ 2L,127L,149L,383L,431L,443L,487L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274123Inst : IEnumerable<long>
{
public static readonly long[] Value=A274123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274123.Bytes);
public long this[int i]=>Value[i];

public static A274123Inst Instance=new A274123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274124
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,22L,36L,44L,66L,88L,123L,138L,145L,159L,167L,189L,224L,235L,246L,257L,268L,279L,333L,345L,347L,357L,369L,448L,456L,459L,466L,578L,579L,666L,678L,789L,999L,1124L,1146L,1168L,1225L,1233L,1236L,1247L,1258L,1269L,1344L,1348L,1356L,1368L,1447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274124Inst : IEnumerable<long>
{
public static readonly long[] Value=A274124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274124.Bytes);
public long this[int i]=>Value[i];

public static A274124Inst Instance=new A274124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274125
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,111L,112L,113L,114L,115L,116L,117L,118L,119L,122L,123L,1111L,1112L,1113L,1114L,1115L,1116L,1117L,1118L,1119L,1122L,1123L,1124L,11111L,11112L,11113L,11114L,11115L,11116L,11117L,11118L,11119L,11122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274125Inst : IEnumerable<long>
{
public static readonly long[] Value=A274125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274125.Bytes);
public long this[int i]=>Value[i];

public static A274125Inst Instance=new A274125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274126
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,22L,23L,24L,222L,25L,33L,26L,27L,34L,223L,28L,29L,35L,44L,224L,2222L,36L,233L,37L,45L,225L,38L,46L,226L,39L,55L,234L,2223L,47L,227L,333L,56L,48L,228L,235L,244L,2224L,22222L,49L,57L,229L,66L,236L,334L,2233L,58L,67L,245L,2225L,237L,59L,68L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274126Inst : IEnumerable<long>
{
public static readonly long[] Value=A274126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274126.Bytes);
public long this[int i]=>Value[i];

public static A274126Inst Instance=new A274126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274127
{
public static readonly long[] Value={ 16L,18L,20L,24L,27L,28L,35L,44L,45L,52L,55L,60L,63L,65L,68L,70L,76L,77L,84L,85L,91L,92L,95L,99L,100L,105L,110L,115L,116L,117L,119L,124L,130L,132L,133L,140L,143L,145L,148L,153L,154L,155L,156L,161L,164L,165L,170L,171L,172L,175L,182L,185L,187L,188L,190L,195L,196L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274127Inst : IEnumerable<long>
{
public static readonly long[] Value=A274127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274127.Bytes);
public long this[int i]=>Value[i];

public static A274127Inst Instance=new A274127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274128
{
public static readonly long[] Value={ 39312L,251370L,314496L,432523L,948051L,1061424L,1536416L,2010960L,2515968L,3009825L,3460184L,4914000L,6786990L,6822900L,7154784L,7584408L,7825545L,8491392L,11678121L,12291328L,13484016L,16087680L,20127744L,24078600L,25501762L,25597377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274128Inst : IEnumerable<long>
{
public static readonly long[] Value=A274128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274128.Bytes);
public long this[int i]=>Value[i];

public static A274128Inst Instance=new A274128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274129
{
public static readonly BigInteger[] Value={ 11L,253L,4257L,63085L,872861L,11569833L,148920497L,1876301845L,23259261861L,284671240513L,3448396611737L,41419505367405L,493973128085261L,5855648668464793L,69053522207998977L,810643999691917765L,9478691806054675061UL,BigInteger.Parse("110443295770481522673") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274129Inst Instance=new A274129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274130
{
public static readonly long[] Value={ 1L,1L,11L,29L,1L,1L,491L,863L,6571L,4399L,13L,5L,1568551L,28783L,45187L,312643L,4351L,1117L,17L,35L,25935757L,81123251L,2226193L,2440117L,16025L,34246631L,18161L,35443L,49L,7L,5301974777L,22870237L,1603483793L,23507881213L,122574691L,122330761339L,903325919L,1976751869L,956873L,18551L,35L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274130Inst : IEnumerable<long>
{
public static readonly long[] Value=A274130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274130.Bytes);
public long this[int i]=>Value[i];

public static A274130Inst Instance=new A274130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274131
{
public static readonly long[] Value={ 6L,48L,96L,960L,160L,1536L,5760L,30720L,725760L,1935360L,34560L,165888L,23224320L,1161216L,4644864L,92897280L,4644864L,5806080L,663552L,21233664L,464486400L,3715891200L,232243200L,619315200L,11354112L,81749606400L,185794560L,2123366400L,26542080L,70778880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274131Inst : IEnumerable<long>
{
public static readonly long[] Value=A274131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274131.Bytes);
public long this[int i]=>Value[i];

public static A274131Inst Instance=new A274131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274132
{
public static readonly long[] Value={ 134L,153L,216L,225L,244L,251L,288L,342L,368L,405L,408L,415L,528L,532L,540L,577L,645L,729L,750L,755L,764L,855L,863L,882L,918L,919L,946L,972L,980L,1065L,1072L,1080L,1126L,1224L,1250L,1333L,1351L,1422L,1457L,1464L,1466L,1520L,1539L,1548L,1581L,1611L,1701L,1728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274132Inst : IEnumerable<long>
{
public static readonly long[] Value=A274132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274132.Bytes);
public long this[int i]=>Value[i];

public static A274132Inst Instance=new A274132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274133
{
public static readonly long[] Value={ 2L,9L,14L,15L,20L,27L,32L,37L,42L,47L,52L,57L,62L,129L,134L,139L,144L,149L,154L,159L,164L,169L,174L,179L,184L,189L,194L,195L,199L,200L,204L,205L,209L,210L,214L,215L,219L,220L,224L,225L,229L,230L,234L,235L,239L,240L,244L,245L,249L,250L,254L,255L,260L,265L,270L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274133Inst : IEnumerable<long>
{
public static readonly long[] Value=A274133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274133.Bytes);
public long this[int i]=>Value[i];

public static A274133Inst Instance=new A274133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274134
{
public static readonly long[] Value={ 3L,7L,11L,31L,43L,67L,79L,127L,131L,139L,167L,191L,211L,223L,227L,307L,331L,367L,487L,523L,631L,691L,743L,751L,883L,971L,1039L,1087L,1399L,2063L,2083L,2143L,2179L,2239L,2267L,2287L,2347L,2411L,2423L,2503L,2531L,2543L,2591L,2687L,2731L,2803L,2819L,2927L,2939L,2963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274134Inst : IEnumerable<long>
{
public static readonly long[] Value=A274134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274134.Bytes);
public long this[int i]=>Value[i];

public static A274134Inst Instance=new A274134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274135
{
public static readonly long[] Value={ 1L,4L,6L,9L,12L,15L,18L,21L,34L,36L,75L,102L,231L,256L,309L,513L,748L,3789L,12378L,36378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274135Inst : IEnumerable<long>
{
public static readonly long[] Value=A274135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274135.Bytes);
public long this[int i]=>Value[i];

public static A274135Inst Instance=new A274135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274136
{
public static readonly BigInteger[] Value={ 1L,16L,540L,32256L,3024000L,410572800L,76281004800L,18598035456000L,5762136335155200L,2211729098342400000L,BigInteger.Parse("1030334000462807040000"),BigInteger.Parse("572721601599913328640000"),BigInteger.Parse("374484928188990947328000000"),BigInteger.Parse("284562454970932936468070400000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274136Inst Instance=new A274136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274137
{
public static readonly long[] Value={ 6L,7L,8L,2L,3L,1L,5L,4L,3L,2L,0L,9L,10L,40L,100L,0L,15L,6L,6L,6L,0L,0L,7L,0L,2L,0L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274137Inst : IEnumerable<long>
{
public static readonly long[] Value=A274137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274137.Bytes);
public long this[int i]=>Value[i];

public static A274137Inst Instance=new A274137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274138
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,3L,1L,2L,2L,3L,3L,3L,1L,2L,3L,3L,3L,4L,4L,1L,2L,3L,3L,4L,4L,5L,5L,1L,2L,3L,4L,4L,4L,5L,5L,5L,1L,2L,3L,4L,4L,4L,5L,5L,5L,5L,1L,2L,3L,4L,4L,5L,5L,6L,5L,5L,5L,1L,2L,3L,4L,4L,5L,5L,6L,6L,6L,6L,6L,1L,2L,3L,4L,5L,5L,6L,6L,6L,7L,7L,7L,7L,1L,2L,3L,4L,5L,6L,6L,6L,6L,7L,7L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274138Inst : IEnumerable<long>
{
public static readonly long[] Value=A274138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274138.Bytes);
public long this[int i]=>Value[i];

public static A274138Inst Instance=new A274138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274139
{
public static readonly long[] Value={ 2L,2L,8L,2L,32L,8L,128L,2L,512L,32L,2048L,8L,8192L,128L,32768L,2L,131072L,512L,524288L,32L,2097152L,2048L,8388608L,8L,33554432L,8192L,134217728L,128L,536870912L,32768L,2147483648L,2L,8589934592L,131072L,34359738368L,512L,137438953472L,524288L,549755813888L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274139Inst : IEnumerable<long>
{
public static readonly long[] Value=A274139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274139.Bytes);
public long this[int i]=>Value[i];

public static A274139Inst Instance=new A274139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274140
{
public static readonly long[] Value={ 0L,3L,5L,7L,8L,10L,11L,10L,11L,16L,16L,18L,20L,15L,14L,23L,23L,25L,26L,17L,21L,34L,30L,17L,23L,22L,18L,38L,37L,39L,39L,22L,31L,29L,20L,45L,56L,35L,25L,50L,51L,53L,56L,24L,34L,70L,56L,23L,24L,30L,35L,68L,62L,25L,27L,33L,51L,88L,69L,71L,92L,44L,23L,28L,32L,81L,86L,45L,38L,83L,81L,83L,110L,50L,34L,39L,34L,95L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274140Inst : IEnumerable<long>
{
public static readonly long[] Value=A274140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274140.Bytes);
public long this[int i]=>Value[i];

public static A274140Inst Instance=new A274140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274141
{
public static readonly long[] Value={ 4L,8L,12L,16L,20L,24L,25L,27L,28L,32L,36L,40L,44L,48L,49L,50L,52L,54L,56L,60L,64L,68L,72L,75L,76L,80L,81L,84L,88L,92L,96L,98L,100L,104L,108L,112L,116L,120L,121L,124L,125L,128L,132L,135L,136L,140L,144L,147L,148L,150L,152L,156L,160L,162L,164L,168L,169L,172L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274141Inst : IEnumerable<long>
{
public static readonly long[] Value=A274141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274141.Bytes);
public long this[int i]=>Value[i];

public static A274141Inst Instance=new A274141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274142
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,8L,11L,17L,25L,37L,54L,81L,119L,177L,261L,388L,574L,851L,1260L,1868L,2767L,4101L,6077L,9006L,13347L,19781L,29315L,43448L,64392L,95436L,141444L,209636L,310705L,460501L,682519L,1011581L,1499295L,2222155L,3293534L,4881472L,7235018L,10723311L,15893460L,23556367L,34913897L,51747400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274142Inst : IEnumerable<long>
{
public static readonly long[] Value=A274142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274142.Bytes);
public long this[int i]=>Value[i];

public static A274142Inst Instance=new A274142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274143
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,4L,4L,5L,8L,9L,12L,16L,20L,26L,34L,44L,57L,74L,97L,125L,162L,212L,272L,356L,462L,597L,780L,1010L,1311L,1706L,2210L,2873L,3732L,4841L,6294L,8168L,10608L,13781L,17886L,23237L,30172L,39177L,50891L,66072L,85813L,111446L,144706L,187947L,244059L,316937L,411618L,534503L,694153L,901461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274143Inst : IEnumerable<long>
{
public static readonly long[] Value=A274143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274143.Bytes);
public long this[int i]=>Value[i];

public static A274143Inst Instance=new A274143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274144
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,4L,5L,8L,8L,9L,12L,16L,17L,21L,27L,32L,37L,47L,57L,67L,82L,102L,121L,145L,180L,219L,260L,317L,391L,470L,564L,691L,843L,1012L,1225L,1500L,1816L,2188L,2663L,3245L,3918L,4744L,5778L,7010L,8473L,10291L,12511L,15148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274144Inst : IEnumerable<long>
{
public static readonly long[] Value=A274144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274144.Bytes);
public long this[int i]=>Value[i];

public static A274144Inst Instance=new A274144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274145
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,9L,11L,14L,19L,25L,32L,43L,56L,73L,97L,128L,167L,222L,292L,384L,507L,670L,882L,1165L,1539L,2030L,2680L,3541L,4675L,6173L,8155L,10772L,14227L,18798L,24834L,32808L,43350L,57279L,75681L,100006L,132152L,174627L,230766L,304963L,403012L,532600L,703874L,930227L,1229386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274145Inst : IEnumerable<long>
{
public static readonly long[] Value=A274145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274145.Bytes);
public long this[int i]=>Value[i];

public static A274145Inst Instance=new A274145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274146
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,5L,5L,7L,8L,11L,12L,16L,18L,24L,28L,35L,41L,53L,63L,79L,95L,119L,145L,181L,221L,275L,339L,421L,519L,645L,798L,991L,1228L,1525L,1890L,2350L,2915L,3622L,4495L,5588L,6939L,8626L,10712L,13315L,16545L,20567L,25556L,31766L,39483L,49081L,61007L,75836L,94270L,117194L,145688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274146Inst : IEnumerable<long>
{
public static readonly long[] Value=A274146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274146.Bytes);
public long this[int i]=>Value[i];

public static A274146Inst Instance=new A274146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274147
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,6L,9L,13L,20L,31L,48L,70L,108L,165L,250L,379L,575L,875L,1332L,2017L,3066L,4661L,7076L,10751L,16328L,24801L,37684L,57229L,86931L,132062L,200588L,304701L,462844L,703043L,1067955L,1622207L,2464117L,3743047L,5685655L,8636525L,13118942L,19927624L,30270167L,45980452L,69844296L,106093768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274147Inst : IEnumerable<long>
{
public static readonly long[] Value=A274147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274147.Bytes);
public long this[int i]=>Value[i];

public static A274147Inst Instance=new A274147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274148
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,5L,6L,8L,12L,17L,23L,32L,44L,61L,86L,119L,164L,228L,318L,442L,614L,850L,1181L,1643L,2282L,3167L,4398L,6110L,8489L,11790L,16372L,22737L,31584L,43870L,60930L,84622L,117533L,163248L,226742L,314918L,437389L,607498L,843772L,1171927L,1627699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274148Inst : IEnumerable<long>
{
public static readonly long[] Value=A274148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274148.Bytes);
public long this[int i]=>Value[i];

public static A274148Inst Instance=new A274148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274149
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,4L,6L,7L,9L,12L,17L,22L,29L,38L,51L,68L,90L,119L,158L,209L,277L,368L,489L,648L,858L,1137L,1509L,2002L,2655L,3520L,4667L,6189L,8208L,10885L,14436L,19141L,25382L,33659L,44638L,59195L,78497L,104092L,138036L,183050L,242745L,321904L,426875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274149Inst : IEnumerable<long>
{
public static readonly long[] Value=A274149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274149.Bytes);
public long this[int i]=>Value[i];

public static A274149Inst Instance=new A274149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274150
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,4L,5L,7L,10L,14L,17L,23L,33L,43L,61L,82L,111L,150L,202L,278L,376L,516L,694L,941L,1281L,1731L,2369L,3208L,4364L,5915L,8015L,10911L,14792L,20139L,27314L,37082L,50358L,68309L,92891L,126054L,171277L,232504L,315584L,428704L,581880L,790589L,1073298L,1457466L,1979119L,2686767L,3649316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274150Inst : IEnumerable<long>
{
public static readonly long[] Value=A274150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274150.Bytes);
public long this[int i]=>Value[i];

public static A274150Inst Instance=new A274150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274151
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,4L,5L,6L,8L,11L,14L,17L,20L,26L,36L,45L,56L,74L,96L,120L,150L,191L,245L,318L,405L,517L,665L,850L,1073L,1364L,1749L,2233L,2860L,3660L,4678L,5970L,7610L,9691L,12357L,15808L,20190L,25815L,32990L,42127L,53730L,68537L,87474L,111636L,142653L,182214L,232784L,297231L,379421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274151Inst : IEnumerable<long>
{
public static readonly long[] Value=A274151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274151.Bytes);
public long this[int i]=>Value[i];

public static A274151Inst Instance=new A274151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274152
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,6L,8L,12L,18L,28L,42L,62L,96L,142L,210L,316L,474L,712L,1070L,1606L,2410L,3608L,5412L,8124L,12184L,18268L,27404L,41114L,61662L,92484L,138702L,208020L,311988L,467928L,701866L,1052812L,1579204L,2368764L,3553048L,5329306L,7993478L,11989564L,17983626L,26974744L,40461664L,60692460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274152Inst : IEnumerable<long>
{
public static readonly long[] Value=A274152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274152.Bytes);
public long this[int i]=>Value[i];

public static A274152Inst Instance=new A274152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274153
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,8L,12L,19L,27L,41L,60L,90L,136L,204L,306L,461L,692L,1036L,1557L,2330L,3498L,5247L,7872L,11803L,17715L,26558L,39851L,59781L,89651L,134482L,201736L,302605L,453892L,680800L,1021307L,1531944L,2297678L,3446694L,5170101L,7754719L,11632249L,17448162L,26172247L,39258668L,58886868L,88331299L,132497660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274153Inst : IEnumerable<long>
{
public static readonly long[] Value=A274153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274153.Bytes);
public long this[int i]=>Value[i];

public static A274153Inst Instance=new A274153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274154
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,8L,12L,18L,27L,41L,60L,92L,134L,206L,305L,463L,694L,1041L,1561L,2344L,3506L,5279L,7903L,11877L,17823L,26689L,40100L,60041L,90217L,135312L,202940L,304555L,456295L,685209L,1027291L,1541669L,2312510L,3466919L,5203662L,7801283L,11707295L,17559032L,26334864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274154Inst : IEnumerable<long>
{
public static readonly long[] Value=A274154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274154.Bytes);
public long this[int i]=>Value[i];

public static A274154Inst Instance=new A274154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274155
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,6L,8L,12L,19L,28L,42L,63L,95L,145L,212L,321L,479L,723L,1080L,1622L,2436L,3652L,5472L,8212L,12309L,18488L,27718L,41599L,62370L,93578L,140360L,210511L,315787L,473646L,710583L,1065773L,1598933L,2398260L,3597426L,5395845L,8093416L,12140388L,18210490L,27317995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274155Inst : IEnumerable<long>
{
public static readonly long[] Value=A274155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274155.Bytes);
public long this[int i]=>Value[i];

public static A274155Inst Instance=new A274155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274156
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,6L,7L,10L,14L,19L,25L,35L,47L,64L,87L,119L,161L,220L,300L,407L,554L,757L,1028L,1399L,1908L,2598L,3534L,4816L,6560L,8929L,12161L,16567L,22556L,30718L,41843L,56981L,77597L,105693L,143944L,196029L,266991L,363634L,495228L,674481L,918629L,1251106L,1703941L,2320726L,3160713L,4304733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274156Inst : IEnumerable<long>
{
public static readonly long[] Value=A274156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274156.Bytes);
public long this[int i]=>Value[i];

public static A274156Inst Instance=new A274156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274157
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,3L,4L,4L,6L,7L,9L,11L,14L,16L,22L,26L,33L,40L,53L,62L,82L,97L,127L,151L,198L,234L,309L,366L,480L,570L,749L,887L,1165L,1382L,1815L,2153L,2827L,3353L,4405L,5224L,6859L,8137L,10687L,12675L,16646L,19746L,25932L,30761L,40395L,47917L,62929L,74647L,98027L,116285L,152711L,181150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274157Inst : IEnumerable<long>
{
public static readonly long[] Value=A274157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274157.Bytes);
public long this[int i]=>Value[i];

public static A274157Inst Instance=new A274157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274158
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,5L,6L,8L,9L,13L,17L,22L,27L,36L,47L,61L,77L,101L,132L,171L,219L,285L,370L,480L,619L,803L,1042L,1351L,1747L,2264L,2936L,3805L,4927L,6385L,8276L,10725L,13894L,18004L,23333L,30238L,39179L,50770L,65794L,85261L,110483L,143171L,185534L,240432L,311566L,403749L,523216L,678031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274158Inst : IEnumerable<long>
{
public static readonly long[] Value=A274158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274158.Bytes);
public long this[int i]=>Value[i];

public static A274158Inst Instance=new A274158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274159
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,6L,7L,9L,11L,12L,16L,18L,23L,28L,33L,41L,49L,61L,72L,89L,107L,130L,159L,191L,234L,283L,345L,418L,507L,617L,747L,910L,1103L,1340L,1629L,1976L,2402L,2914L,3542L,4300L,5223L,6344L,7701L,9359L,11361L,13801L,16761L,20353L,24725L,30021L,36468L,44285L,53788L,65328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274159Inst : IEnumerable<long>
{
public static readonly long[] Value=A274159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274159.Bytes);
public long this[int i]=>Value[i];

public static A274159Inst Instance=new A274159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274160
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,10L,19L,33L,62L,112L,212L,394L,751L,1419L,2719L,5193L,10002L,19254L,37258L,72132L,140108L,272368L,530646L,1034798L,2021127L,3951147L,7733421L,15148711L,29702087L,58279135L,114438213L,224856997L,442099674L,869717486L,1711885120L,3371215170L,6642102554L,13092289634L,25817134600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274160Inst : IEnumerable<long>
{
public static readonly long[] Value=A274160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274160.Bytes);
public long this[int i]=>Value[i];

public static A274160Inst Instance=new A274160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274161
{
public static readonly long[] Value={ 2L,3L,7L,11L,17L,23L,27L,31L,37L,41L,45L,57L,61L,65L,75L,79L,91L,95L,99L,109L,113L,125L,129L,133L,143L,147L,159L,163L,167L,177L,181L,193L,197L,201L,211L,215L,227L,231L,235L,245L,249L,261L,265L,269L,279L,283L,295L,299L,303L,313L,317L,329L,333L,337L,347L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274161Inst : IEnumerable<long>
{
public static readonly long[] Value=A274161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274161.Bytes);
public long this[int i]=>Value[i];

public static A274161Inst Instance=new A274161Inst();

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