using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245062
{
public static readonly long[] Value={ 1L,2L,10L,3L,20L,100L,4L,12L,110L,1000L,5L,40L,21L,200L,10000L,6L,50L,112L,30L,1010L,100000L,7L,24L,140L,220L,102L,1100L,1000000L,8L,70L,42L,230L,400L,111L,2000L,10000000L,9L,80L,133L,60L,320L,1012L,120L,10010L,100000000L,190L,18L,152L,322L,114L,410L,1120L,201L,10100L,1000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245062Inst : IEnumerable<long>
{
public static readonly long[] Value=A245062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245062.Bytes);
public long this[int i]=>Value[i];

public static A245062Inst Instance=new A245062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245063
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,17L,19L,29L,31L,37L,43L,53L,59L,61L,67L,71L,73L,79L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,239L,241L,263L,269L,271L,277L,283L,293L,307L,311L,313L,317L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245063Inst : IEnumerable<long>
{
public static readonly long[] Value=A245063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245063.Bytes);
public long this[int i]=>Value[i];

public static A245063Inst Instance=new A245063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245064
{
public static readonly long[] Value={ 2L,3L,5L,7L,31L,37L,223L,227L,229L,743L,1741L,1747L,3391L,5851L,5857L,9281L,9283L,13841L,19709L,27011L,27017L,35963L,35969L,46681L,46687L,59341L,74101L,91141L,110603L,110609L,132679L,373273L,474581L,474583L,729023L,804383L,1061227L,1259743L,1259749L,1481573L,2000393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245064Inst : IEnumerable<long>
{
public static readonly long[] Value=A245064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245064.Bytes);
public long this[int i]=>Value[i];

public static A245064Inst Instance=new A245064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245065
{
public static readonly long[] Value={ 10L,20L,12L,40L,50L,24L,70L,80L,18L,280L,308L,84L,364L,392L,285L,592L,629L,288L,1387L,4880L,588L,2596L,1886L,1896L,5875L,5876L,1998L,8596L,7598L,48990L,9796L,27968L,43989L,37978L,59885L,38988L,38998L,76988L,67899L,789880L,188969L,189798L,179998L,489896L,589995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245065Inst : IEnumerable<long>
{
public static readonly long[] Value=A245065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245065.Bytes);
public long this[int i]=>Value[i];

public static A245065Inst Instance=new A245065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245066
{
public static readonly BigInteger[] Value={ 1L,3L,45L,1260L,51975L,2837835L,192972780L,15713497800L,1490818103775L,161505294575625L,19671344879311125L,2660996470946814000L,BigInteger.Parse("395823225053338582500"),BigInteger.Parse("64214706279807005422500"),BigInteger.Parse("11283441246308945238525000"),BigInteger.Parse("2134827083801652439128930000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245066Inst Instance=new A245066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245067
{
public static readonly BigInteger[] Value={ 1L,2L,12L,120L,1610L,25956L,474012L,9475752L,202921290L,4587734580L,108376022040L,2654745191280L,67043341981980L,1737717447946200L,46062204663294000L,1245096242017227360L,BigInteger.Parse("34239776369652506970"),BigInteger.Parse("956050033694583839220") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245067Inst Instance=new A245067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245068
{
public static readonly long[] Value={ 1L,10L,64L,326L,1445L,5819L,21858L,77878L,266265L,880883L,2837412L,8940811L,27661849L,84275206L,253424332L,753616430L,2219633033L,6483334299L,18800362216L,54171793605L,155219693611L,442551961032L,1256207931637L,3551733610431L,10006315323755L,28100400701241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245068Inst : IEnumerable<long>
{
public static readonly long[] Value=A245068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245068.Bytes);
public long this[int i]=>Value[i];

public static A245068Inst Instance=new A245068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245069
{
public static readonly BigInteger[] Value={ 1L,3L,15L,153L,3567L,196833L,25604415L,7727833473L,5321887813887L,8241841773665793L,BigInteger.Parse("28359559029362676735"),BigInteger.Parse("214672167825864945784833"),BigInteger.Parse("3545389677599343390373285887"),BigInteger.Parse("126865139766788531002690137546753"),BigInteger.Parse("9777654677248888055040528691642187775") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245069Inst Instance=new A245069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245070
{
public static readonly long[] Value={ 3L,2L,2L,3L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,4L,2L,2L,3L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245070Inst : IEnumerable<long>
{
public static readonly long[] Value=A245070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245070.Bytes);
public long this[int i]=>Value[i];

public static A245070Inst Instance=new A245070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245071
{
public static readonly long[] Value={ 10L,21L,31L,41L,49L,59L,67L,77L,85L,91L,101L,107L,115L,125L,133L,139L,145L,155L,161L,169L,179L,185L,193L,199L,203L,211L,221L,229L,239L,247L,245L,253L,259L,269L,271L,281L,287L,293L,301L,307L,313L,323L,325L,335L,343L,353L,353L,353L,361L,371L,379L,385L,395L,397L,403L,409L,415L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245071Inst : IEnumerable<long>
{
public static readonly long[] Value=A245071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245071.Bytes);
public long this[int i]=>Value[i];

public static A245071Inst Instance=new A245071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245072
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,281L,293L,307L,311L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245072Inst : IEnumerable<long>
{
public static readonly long[] Value=A245072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245072.Bytes);
public long this[int i]=>Value[i];

public static A245072Inst Instance=new A245072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245073
{
public static readonly long[] Value={ 1L,5L,4L,7L,9L,8L,2L,4L,0L,2L,1L,5L,7L,7L,4L,2L,3L,0L,4L,6L,5L,6L,0L,7L,6L,7L,6L,7L,7L,5L,3L,0L,2L,0L,6L,3L,2L,5L,5L,2L,2L,5L,6L,7L,7L,6L,9L,1L,3L,6L,1L,2L,0L,6L,5L,2L,5L,1L,4L,4L,1L,1L,6L,0L,6L,1L,3L,2L,8L,9L,1L,5L,8L,5L,3L,1L,4L,8L,6L,0L,6L,9L,3L,5L,5L,1L,1L,7L,0L,7L,2L,8L,2L,9L,3L,8L,1L,2L,5L,8L,5L,4L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245073Inst : IEnumerable<long>
{
public static readonly long[] Value=A245073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245073.Bytes);
public long this[int i]=>Value[i];

public static A245073Inst Instance=new A245073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245074
{
public static readonly long[] Value={ 7L,4L,4L,3L,4L,1L,2L,7L,6L,3L,9L,1L,4L,5L,6L,6L,4L,0L,4L,3L,9L,0L,0L,6L,0L,3L,6L,7L,8L,5L,6L,9L,4L,6L,1L,5L,6L,9L,1L,3L,7L,7L,8L,0L,8L,8L,3L,9L,4L,2L,7L,0L,4L,7L,5L,8L,5L,2L,9L,2L,0L,9L,4L,8L,7L,7L,3L,6L,4L,0L,8L,4L,0L,1L,4L,8L,2L,5L,8L,4L,1L,6L,2L,0L,5L,7L,0L,1L,9L,8L,7L,4L,8L,8L,7L,1L,8L,5L,0L,0L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245074Inst : IEnumerable<long>
{
public static readonly long[] Value=A245074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245074.Bytes);
public long this[int i]=>Value[i];

public static A245074Inst Instance=new A245074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245075
{
public static readonly long[] Value={ 0L,0L,-2L,0L,-4L,0L,-6L,-6L,1L,9L,-1L,9L,-3L,-3L,-5L,9L,-7L,18L,0L,0L,-2L,18L,-4L,-2L,-6L,-6L,1L,27L,-1L,27L,-3L,-3L,-5L,-3L,-7L,36L,0L,0L,-2L,36L,-4L,36L,-6L,-6L,1L,45L,-1L,3L,-3L,-3L,-5L,45L,-7L,4L,0L,0L,-2L,54L,-4L,54L,-6L,-6L,1L,3L,-1L,63L,-3L,-3L,-5L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245075Inst : IEnumerable<long>
{
public static readonly long[] Value=A245075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245075.Bytes);
public long this[int i]=>Value[i];

public static A245075Inst Instance=new A245075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245076
{
public static readonly BigInteger[] Value={ 1L,1L,11L,226L,17001L,2671876L,1242300001L,1250703890626L,3363964848750001L,BigInteger.Parse("20117722302277734376"),BigInteger.Parse("302329590133667187500001"),BigInteger.Parse("10299774530356369019736328126"),BigInteger.Parse("846958190132982653045661328125001"),BigInteger.Parse("160085716663876329020695686381591796876") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245076Inst Instance=new A245076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245077
{
public static readonly long[] Value={ 2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,3L,3L,2L,1L,3L,2L,3L,3L,2L,3L,2L,2L,3L,2L,2L,3L,3L,2L,2L,3L,2L,3L,3L,2L,2L,4L,2L,4L,2L,2L,4L,2L,2L,1L,4L,2L,4L,4L,2L,4L,4L,2L,4L,2L,2L,1L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245077Inst : IEnumerable<long>
{
public static readonly long[] Value=A245077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245077.Bytes);
public long this[int i]=>Value[i];

public static A245077Inst Instance=new A245077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245078
{
public static readonly long[] Value={ 4L,5L,4L,5L,5L,2L,1L,1L,1L,2L,7L,1L,7L,1L,2L,3L,3L,4L,7L,5L,2L,4L,2L,5L,6L,0L,4L,1L,7L,4L,5L,4L,3L,0L,1L,2L,1L,9L,3L,9L,8L,1L,9L,4L,3L,0L,2L,3L,5L,4L,7L,6L,2L,5L,9L,8L,2L,6L,2L,3L,3L,9L,2L,3L,5L,1L,6L,4L,3L,8L,1L,2L,7L,1L,8L,9L,4L,8L,1L,1L,3L,5L,0L,8L,6L,3L,4L,5L,9L,8L,7L,8L,6L,0L,4L,7L,0L,5L,8L,7L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245078Inst : IEnumerable<long>
{
public static readonly long[] Value=A245078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245078.Bytes);
public long this[int i]=>Value[i];

public static A245078Inst Instance=new A245078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245079
{
public static readonly long[] Value={ 2L,4L,14L,104L,2170L,230540L,499596550L,30907579915064L,5483950159845307762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245079Inst : IEnumerable<long>
{
public static readonly long[] Value=A245079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245079.Bytes);
public long this[int i]=>Value[i];

public static A245079Inst Instance=new A245079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245080
{
public static readonly long[] Value={ 4L,8L,9L,16L,24L,25L,27L,32L,36L,40L,49L,54L,56L,64L,81L,88L,96L,100L,104L,121L,125L,128L,135L,136L,144L,152L,160L,169L,184L,189L,196L,216L,224L,225L,232L,240L,243L,248L,250L,256L,289L,296L,297L,324L,328L,336L,343L,344L,351L,352L,360L,361L,375L,376L,384L,400L,416L,424L,441L,459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245080Inst : IEnumerable<long>
{
public static readonly long[] Value=A245080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245080.Bytes);
public long this[int i]=>Value[i];

public static A245080Inst Instance=new A245080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245081
{
public static readonly long[] Value={ 1L,3L,9L,1L,4L,7L,0L,3L,8L,1L,0L,4L,1L,0L,9L,5L,1L,7L,3L,4L,5L,1L,0L,4L,8L,8L,5L,8L,4L,7L,4L,3L,2L,1L,5L,0L,0L,3L,0L,6L,7L,3L,5L,0L,3L,3L,9L,7L,7L,0L,0L,2L,2L,8L,1L,7L,7L,5L,9L,9L,6L,7L,7L,4L,2L,0L,5L,3L,1L,9L,4L,3L,4L,4L,7L,2L,4L,9L,9L,2L,2L,5L,1L,3L,4L,3L,1L,4L,6L,4L,9L,7L,8L,7L,0L,4L,9L,1L,7L,0L,3L,5L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245081Inst : IEnumerable<long>
{
public static readonly long[] Value=A245081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245081.Bytes);
public long this[int i]=>Value[i];

public static A245081Inst Instance=new A245081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245082
{
public static readonly long[] Value={ 1L,0L,7L,3L,0L,5L,1L,7L,8L,5L,6L,8L,3L,1L,0L,1L,1L,5L,6L,8L,1L,0L,9L,5L,0L,7L,4L,9L,2L,7L,9L,4L,5L,6L,7L,2L,8L,6L,9L,4L,7L,2L,4L,9L,0L,3L,0L,9L,5L,6L,2L,9L,5L,7L,6L,0L,9L,0L,2L,8L,0L,1L,3L,7L,0L,8L,5L,7L,7L,9L,7L,3L,5L,1L,0L,7L,3L,2L,4L,0L,7L,7L,6L,7L,7L,2L,6L,8L,6L,9L,5L,5L,7L,2L,1L,4L,3L,0L,8L,7L,9L,4L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245082Inst : IEnumerable<long>
{
public static readonly long[] Value=A245082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245082.Bytes);
public long this[int i]=>Value[i];

public static A245082Inst Instance=new A245082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245083
{
public static readonly long[] Value={ 2L,5L,5L,7L,6L,6L,3L,9L,3L,2L,7L,8L,9L,0L,1L,9L,4L,3L,4L,2L,2L,1L,4L,4L,0L,6L,0L,0L,4L,9L,9L,3L,5L,5L,0L,2L,0L,3L,5L,2L,2L,9L,0L,8L,3L,1L,9L,9L,9L,0L,4L,2L,6L,4L,8L,2L,4L,2L,5L,6L,2L,1L,7L,4L,1L,8L,6L,0L,3L,5L,8L,5L,1L,7L,7L,9L,7L,2L,2L,0L,5L,7L,3L,8L,4L,9L,7L,2L,9L,0L,8L,1L,1L,2L,8L,0L,1L,1L,6L,5L,0L,0L,4L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245083Inst : IEnumerable<long>
{
public static readonly long[] Value=A245083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245083.Bytes);
public long this[int i]=>Value[i];

public static A245083Inst Instance=new A245083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245084
{
public static readonly long[] Value={ 9L,4L,6L,8L,4L,5L,6L,0L,5L,2L,6L,9L,7L,0L,6L,1L,1L,3L,8L,7L,3L,3L,6L,7L,8L,8L,4L,5L,1L,3L,3L,4L,1L,9L,3L,1L,6L,3L,9L,5L,6L,9L,3L,5L,6L,7L,9L,8L,8L,9L,7L,2L,0L,5L,0L,0L,5L,5L,3L,7L,4L,9L,8L,4L,4L,1L,0L,3L,1L,7L,2L,0L,8L,8L,9L,0L,3L,1L,2L,2L,0L,3L,7L,7L,7L,0L,2L,9L,5L,2L,8L,9L,1L,1L,3L,7L,8L,7L,4L,0L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245084Inst : IEnumerable<long>
{
public static readonly long[] Value=A245084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245084.Bytes);
public long this[int i]=>Value[i];

public static A245084Inst Instance=new A245084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245085
{
public static readonly long[] Value={ 4L,5L,3L,8L,5L,4L,7L,5L,9L,12L,6L,10L,9L,11L,4L,15L,7L,8L,7L,13L,18L,9L,18L,13L,17L,9L,10L,10L,23L,11L,11L,18L,17L,17L,18L,21L,15L,14L,28L,13L,26L,36L,8L,13L,32L,22L,16L,6L,24L,15L,22L,28L,21L,15L,28L,16L,42L,23L,32L,25L,8L,20L,18L,20L,33L,26L,10L,35L,14L,5L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245085Inst : IEnumerable<long>
{
public static readonly long[] Value=A245085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245085.Bytes);
public long this[int i]=>Value[i];

public static A245085Inst Instance=new A245085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245086
{
public static readonly BigInteger[] Value={ 1L,0L,-6L,0L,90L,0L,-1680L,0L,34650L,0L,-756756L,0L,17153136L,0L,-399072960L,0L,9465511770L,0L,-227873431500L,0L,5550996791340L,0L,-136526995463040L,0L,3384731762521200L,0L,-84478098072866400L,0L,2120572665910728000L,0L,BigInteger.Parse("-53494979785374631680"),0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245086Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245086.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245086Inst Instance=new A245086Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245087
{
public static readonly BigInteger[] Value={ 0L,0L,1L,4L,22L,116L,716L,5034L,40314L,362874L,3628789L,39916793L,479001588L,6227020788L,87178291188L,1307674367982L,20922789887982L,355687428095978L,6402373705727977L,121645100408831983L,2432902008176639978L,BigInteger.Parse("51090942171709439975"),BigInteger.Parse("1124000727777607679972") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245087Inst Instance=new A245087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245088
{
public static readonly long[] Value={ 5L,-5L,-9L,115L,-397L,85L,6625L,-36181L,63915L,377365L,-3357175L,10579245L,12408269L,-295386005L,1383403247L,-1317964405L,-23051599205L,159765455077L,-392146366775L,-1358686166755L,16622987639325L,-64283150090725L,-10522422920465L,1532928077704325L,-8583492124492507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245088Inst : IEnumerable<long>
{
public static readonly long[] Value=A245088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245088.Bytes);
public long this[int i]=>Value[i];

public static A245088Inst Instance=new A245088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245089
{
public static readonly long[] Value={ -2L,-1L,4L,-6L,8L,-6L,-10L,-5L,3L,-16L,4L,6L,3L,6L,-11L,-29L,2L,7L,21L,4L,-16L,-23L,-5L,43L,14L,3L,-32L,26L,13L,-23L,64L,52L,-30L,-74L,-17L,-33L,37L,-82L,-68L,55L,-78L,96L,79L,22L,-81L,-26L,-7L,70L,-38L,9L,3L,-118L,128L,-123L,-67L,-69L,-78L,-138L,30L,-60L,-19L,88L,-26L,110L,27L,63L,-82L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245089Inst : IEnumerable<long>
{
public static readonly long[] Value=A245089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245089.Bytes);
public long this[int i]=>Value[i];

public static A245089Inst Instance=new A245089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245090
{
public static readonly long[] Value={ 0L,1L,1L,2L,8L,34L,149L,672L,3078L,14232L,66278L,310408L,1460390L,6896417L,32668860L,155166468L,738679240L,3523549192L,16837094932L,80580576022L,386187326865L,1853144445292L,8902504243912L,42811658101548L,206072505914938L,992778384676916L,4786621055083592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245090Inst : IEnumerable<long>
{
public static readonly long[] Value=A245090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245090.Bytes);
public long this[int i]=>Value[i];

public static A245090Inst Instance=new A245090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245091
{
public static readonly long[] Value={ 1L,0L,0L,2L,12L,61L,301L,1460L,7019L,33628L,160934L,770109L,3686706L,17661288L,84675601L,406319271L,1951428049L,9380072046L,45124798445L,217252113080L,1046731684143L,5046754081095L,24348794377704L,117547968556766L,567818803946292L,2744396907325759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245091Inst : IEnumerable<long>
{
public static readonly long[] Value=A245091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245091.Bytes);
public long this[int i]=>Value[i];

public static A245091Inst Instance=new A245091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245092
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,6L,7L,8L,6L,10L,12L,12L,8L,14L,15L,16L,13L,18L,18L,20L,12L,22L,28L,24L,14L,26L,24L,28L,24L,30L,31L,32L,18L,34L,39L,36L,20L,38L,42L,40L,32L,42L,36L,44L,24L,46L,60L,48L,31L,50L,42L,52L,40L,54L,56L,56L,30L,58L,72L,60L,32L,62L,63L,64L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245092Inst : IEnumerable<long>
{
public static readonly long[] Value=A245092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245092.Bytes);
public long this[int i]=>Value[i];

public static A245092Inst Instance=new A245092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245093
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,4L,1L,3L,4L,7L,1L,3L,4L,7L,6L,1L,3L,4L,7L,6L,12L,1L,3L,4L,7L,6L,12L,8L,1L,3L,4L,7L,6L,12L,8L,15L,1L,3L,4L,7L,6L,12L,8L,15L,13L,1L,3L,4L,7L,6L,12L,8L,15L,13L,18L,1L,3L,4L,7L,6L,12L,8L,15L,13L,18L,12L,1L,3L,4L,7L,6L,12L,8L,15L,13L,18L,12L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245093Inst : IEnumerable<long>
{
public static readonly long[] Value=A245093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245093.Bytes);
public long this[int i]=>Value[i];

public static A245093Inst Instance=new A245093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245094
{
public static readonly long[] Value={ 1L,2L,4L,8L,13L,20L,24L,27L,33L,36L,42L,45L,51L,54L,60L,63L,69L,72L,78L,81L,87L,90L,96L,99L,105L,108L,114L,117L,123L,126L,132L,135L,141L,144L,150L,153L,159L,162L,168L,171L,177L,180L,186L,189L,195L,198L,204L,207L,213L,216L,222L,225L,231L,234L,240L,243L,249L,252L,258L,261L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245094Inst : IEnumerable<long>
{
public static readonly long[] Value=A245094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245094.Bytes);
public long this[int i]=>Value[i];

public static A245094Inst Instance=new A245094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245095
{
public static readonly long[] Value={ 1L,0L,3L,1L,0L,5L,1L,3L,0L,8L,2L,3L,5L,0L,10L,2L,6L,5L,8L,0L,14L,4L,6L,10L,8L,10L,0L,16L,4L,12L,10L,16L,10L,14L,0L,20L,7L,12L,20L,16L,20L,14L,16L,0L,23L,8L,21L,20L,32L,20L,28L,16L,20L,0L,27L,12L,24L,35L,32L,40L,28L,32L,20L,23L,0L,29L,14L,36L,40L,56L,40L,56L,32L,40L,23L,27L,0L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245095Inst : IEnumerable<long>
{
public static readonly long[] Value=A245095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245095.Bytes);
public long this[int i]=>Value[i];

public static A245095Inst Instance=new A245095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245096
{
public static readonly long[] Value={ 4L,9L,10L,20L,30L,35L,46L,54L,96L,100L,200L,300L,325L,395L,411L,520L,800L,1000L,1470L,2000L,2448L,2700L,3000L,3144L,4000L,4209L,4633L,6400L,6947L,9000L,9051L,10000L,12500L,13719L,20000L,21600L,25300L,30000L,34300L,35000L,46000L,51200L,54000L,61632L,72900L,96000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245096Inst : IEnumerable<long>
{
public static readonly long[] Value=A245096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245096.Bytes);
public long this[int i]=>Value[i];

public static A245096Inst Instance=new A245096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245097
{
public static readonly long[] Value={ 2L,67L,22L,4L,27L,8L,5L,0L,5L,7L,1L,13L,2L,0L,62L,9L,7L,2L,6L,0L,8L,11L,2L,0L,0L,0L,9L,5L,1L,5L,4L,0L,12L,0L,4L,13L,2L,0L,12L,12L,14L,33L,7L,0L,7L,18L,3L,0L,3L,0L,3L,8L,2L,0L,2L,0L,2L,16L,6L,51L,6L,0L,50L,0L,11L,6L,4L,0L,4L,20L,7L,3L,8L,0L,3L,0L,32L,47L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245097Inst : IEnumerable<long>
{
public static readonly long[] Value=A245097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245097.Bytes);
public long this[int i]=>Value[i];

public static A245097Inst Instance=new A245097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245098
{
public static readonly long[] Value={ 1L,5L,11L,11L,16L,14L,20L,23L,21L,22L,31L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245098Inst : IEnumerable<long>
{
public static readonly long[] Value=A245098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245098.Bytes);
public long this[int i]=>Value[i];

public static A245098Inst Instance=new A245098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245099
{
public static readonly long[] Value={ 1L,0L,4L,1L,0L,8L,1L,4L,0L,15L,2L,4L,8L,0L,21L,2L,8L,8L,15L,0L,33L,4L,8L,16L,15L,21L,0L,41L,4L,16L,16L,30L,21L,33L,0L,56L,7L,16L,32L,30L,42L,33L,41L,0L,69L,8L,28L,32L,60L,42L,66L,41L,56L,0L,87L,12L,32L,56L,60L,84L,66L,82L,56L,69L,0L,99L,14L,48L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245099Inst : IEnumerable<long>
{
public static readonly long[] Value=A245099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245099.Bytes);
public long this[int i]=>Value[i];

public static A245099Inst Instance=new A245099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245100
{
public static readonly long[] Value={ 1L,6L,6L,6L,28L,15L,15L,72L,28L,28L,120L,45L,27L,45L,90L,90L,66L,66L,336L,91L,91L,168L,168L,120L,120L,120L,496L,153L,153L,702L,190L,190L,840L,231L,105L,105L,231L,396L,396L,276L,276L,1440L,325L,125L,325L,546L,546L,378L,162L,162L,378L,1568L,435L,435L,2160L,496L,496L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245100Inst : IEnumerable<long>
{
public static readonly long[] Value=A245100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245100.Bytes);
public long this[int i]=>Value[i];

public static A245100Inst Instance=new A245100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245101
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,5L,5L,5L,5L,11L,11L,11L,16L,14L,14L,20L,20L,23L,21L,22L,31L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245101Inst : IEnumerable<long>
{
public static readonly long[] Value=A245101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245101.Bytes);
public long this[int i]=>Value[i];

public static A245101Inst Instance=new A245101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245102
{
public static readonly long[] Value={ 0L,1L,2L,8L,36L,180L,941L,5079L,27961L,156129L,880883L,5009625L,28668920L,164897622L,952418882L,5520254925L,32090787577L,187030223470L,1092467751427L,6393706661582L,37484034980109L,220093799592140L,1294100839792723L,7618482099893824L,44901233075819275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245102Inst : IEnumerable<long>
{
public static readonly long[] Value=A245102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245102.Bytes);
public long this[int i]=>Value[i];

public static A245102Inst Instance=new A245102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245103
{
public static readonly long[] Value={ 1L,1L,4L,18L,93L,498L,2744L,15349L,86802L,494769L,2837412L,16351036L,94599339L,549118128L,3196397701L,18651028188L,109057492901L,638863803720L,3748605725140L,22027421351633L,129606128716906L,763484925360476L,4502370205339221L,26577052185126059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245103Inst : IEnumerable<long>
{
public static readonly long[] Value=A245103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245103.Bytes);
public long this[int i]=>Value[i];

public static A245103Inst Instance=new A245103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245104
{
public static readonly BigInteger[] Value={ 1L,6L,136L,23526L,45511576L,865387222026L,151344908458334956L,BigInteger.Parse("240068450677328881760046"),BigInteger.Parse("3437876688953125801990264400656"),BigInteger.Parse("443629347005368885975552423301544246546"),BigInteger.Parse("515464815896035690815550079747899012312444122676") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245104Inst Instance=new A245104Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245105
{
public static readonly BigInteger[] Value={ 1L,5L,115L,23075L,45885991L,868409174855L,151498753814478835L,BigInteger.Parse("240133851527473763171555"),BigInteger.Parse("3438118287689020571362466454991"),BigInteger.Parse("443637201221274201739533177428155842575"),BigInteger.Parse("515467077892246286863741619710574352065592734875") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245105Inst Instance=new A245105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245106
{
public static readonly BigInteger[] Value={ 1L,5L,109L,20825L,43283641L,847757178125L,150104882696162149L,BigInteger.Parse("239301431405467344190625"),BigInteger.Parse("3433687649167507509801752071921"),BigInteger.Parse("443426550049486796441016276819404703125"),BigInteger.Parse("515377529600543569431994967945053326153797481949") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245106Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245106.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245106Inst Instance=new A245106Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245107
{
public static readonly BigInteger[] Value={ 1L,2L,3L,15L,71L,444L,3156L,24021L,195445L,1678810L,15109730L,141918887L,1387000940L,14077705892L,148201957507L,1616833069407L,18267949067293L,213646700978736L,2584967961734726L,32337901074348415L,417993768656658465L,5578096978483927773L,BigInteger.Parse("76784593772859188463"),BigInteger.Parse("1089213101301826525900") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245107Inst Instance=new A245107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245108
{
public static readonly BigInteger[] Value={ 1L,2L,5L,17L,89L,556L,3982L,31177L,261069L,2309922L,21435122L,207605687L,2091924418L,21883241424L,237301377573L,2664817940085L,30965904565393L,372114924929070L,4621600351308022L,59287502088944355L,785045224973677569L,10721533799643490991UL,BigInteger.Parse("150898539708638128793"),BigInteger.Parse("2186680325880161158424") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245108Inst Instance=new A245108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245109
{
public static readonly BigInteger[] Value={ 1L,3L,31L,520L,11991L,350889L,12428746L,516450792L,24619176153L,1323971052261L,79280864647205L,5231080689880500L,377062508515478306L,BigInteger.Parse("29479066783583059530"),BigInteger.Parse("2484534527715953700780"),BigInteger.Parse("224559818606249783480400"),BigInteger.Parse("21666961097367611148157815"),BigInteger.Parse("2222844864226101120054773295") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245109Inst Instance=new A245109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245110
{
public static readonly BigInteger[] Value={ 1L,1L,4L,23L,161L,1302L,11810L,117889L,1277890L,14894043L,185226966L,2442933979L,33998594943L,497207012018L,7613797641286L,121711037138949L,2025687745708717L,35020194893837462L,627586143525936866L,11636932722633705392UL,BigInteger.Parse("222893347544826491780"),BigInteger.Parse("4403534468187986689781") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245110Inst Instance=new A245110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245111
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,1L,12L,10L,0L,1L,35L,90L,35L,0L,1L,90L,525L,560L,126L,0L,1L,217L,2520L,5460L,3150L,462L,0L,1L,504L,10836L,42000L,46200L,16632L,1716L,0L,1L,1143L,43470L,280665L,519750L,342342L,84084L,6435L,0L,1L,2550L,166375L,1709400L,4969965L,5297292L,2312310L,411840L,24310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245111Inst : IEnumerable<long>
{
public static readonly long[] Value=A245111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245111.Bytes);
public long this[int i]=>Value[i];

public static A245111Inst Instance=new A245111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245112
{
public static readonly BigInteger[] Value={ 1L,2L,18L,224L,3230L,50688L,840420L,14483456L,256856886L,4656988160L,85929839996L,1608379269120L,30463651429484L,582796191989760L,11245047027447240L,218581150665277440L,4276257634911525670L,BigInteger.Parse("84135742205488791552"),BigInteger.Parse("1663738200769421021580"),BigInteger.Parse("33047906167191995678720") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245112Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245112.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245112Inst Instance=new A245112Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245113
{
public static readonly BigInteger[] Value={ 1L,2L,22L,340L,6118L,120060L,2492028L,53798888L,1195684230L,27175425004L,628705751828L,14756641134872L,350529497005532L,8410852483002200L,203561027031883320L,4963404936414528720L,BigInteger.Parse("121810229481173225670"),BigInteger.Parse("3006555636255509030220"),BigInteger.Parse("74585744314812449403300"),BigInteger.Parse("1858695101618327423328312") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245113Inst Instance=new A245113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245114
{
public static readonly BigInteger[] Value={ 1L,3L,36L,585L,10935L,221697L,4740120L,105225318L,2402040420L,56029889025L,1329627118248L,31998624800220L,779102941714461L,19157195459506230L,475034438632316400L,11865382635213387504UL,BigInteger.Parse("298265217964573747095"),BigInteger.Parse("7539795161286074350785"),BigInteger.Parse("191548870595159091038640"),BigInteger.Parse("4888023169106780049244275") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245114Inst Instance=new A245114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245115
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,7L,25L,117L,567L,2931L,20165L,140169L,1008691L,8756711L,80546609L,736667037L,7767188015L,87947663355L,983717687645L,12138623741969L,162832820098219L,2156307692882095L,30489019112863689L,470349294170629989L,7212155129160617511L,BigInteger.Parse("114968617914648215939") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245115Inst Instance=new A245115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245116
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,9L,31L,141L,823L,5009L,32671L,252181L,2203143L,20062809L,194886511L,2105627421L,24559293463L,298779205409L,3849283295551L,53331796237861L,780608097567783L,11900618940664809L,190559301996683791L,3219596479104915501L,BigInteger.Parse("56821283929863042103"),BigInteger.Parse("1041441834338061113009") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245116Inst Instance=new A245116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245117
{
public static readonly BigInteger[] Value={ 1L,3L,9L,55L,417L,4063L,47089L,638815L,9893057L,172430463L,3338825169L,71119417375L,1652583598497L,41600978876863L,1127787743366449L,32757802728304735L,1014917534672868737L,BigInteger.Parse("33409942701676459263"),BigInteger.Parse("1164512820203174614929"),BigInteger.Parse("42844385538424750452895"),BigInteger.Parse("1659281060494160725575777") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245117Inst Instance=new A245117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245118
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,103L,879L,8799L,99711L,1250175L,17077215L,251414175L,3958086015L,66245028447L,1173340901695L,21914481618591L,430320455540223L,8861927054203743L,190989549802914495L,4299479144808402975L,BigInteger.Parse("100927457271249951615"),BigInteger.Parse("2466702562122306371295"),BigInteger.Parse("62678175995432599506495") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245118Inst Instance=new A245118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245119
{
public static readonly BigInteger[] Value={ 1L,0L,1L,2L,6L,22L,100L,554L,3654L,28014L,244572L,2392042L,25877610L,306553246L,3944541224L,54764396346L,815786104186L,12976263731454L,219490418886728L,3933636232278866L,74453982353188846L,1484056255756797222L,BigInteger.Parse("31071499784792496588"),BigInteger.Parse("681729867750992165514"),BigInteger.Parse("15641641334118250802462") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245119Inst Instance=new A245119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245120
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,3L,0L,1L,4L,1L,0L,1L,8L,2L,0L,1L,12L,4L,0L,1L,22L,9L,0L,1L,36L,17L,2L,0L,1L,63L,35L,3L,0L,1L,107L,67L,9L,0L,1L,188L,131L,20L,0L,1L,327L,249L,46L,1L,0L,1L,578L,484L,94L,4L,0L,1L,1020L,922L,202L,11L,0L,1L,1820L,1775L,412L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245120Inst : IEnumerable<long>
{
public static readonly long[] Value=A245120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245120.Bytes);
public long this[int i]=>Value[i];

public static A245120Inst Instance=new A245120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245121
{
public static readonly long[] Value={ 1L,1L,3L,4L,8L,12L,22L,36L,63L,107L,188L,327L,578L,1020L,1820L,3248L,5839L,10511L,19022L,34484L,62755L,114421L,209234L,383327L,703901L,1294822L,2386376L,4405083L,8144701L,15080416L,27961728L,51912054L,96496481L,179577543L,334558479L,623936240L,1164765120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245121Inst : IEnumerable<long>
{
public static readonly long[] Value=A245121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245121.Bytes);
public long this[int i]=>Value[i];

public static A245121Inst Instance=new A245121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245122
{
public static readonly long[] Value={ 1L,2L,4L,9L,17L,35L,67L,131L,249L,484L,922L,1775L,3393L,6513L,12461L,23910L,45806L,87903L,168619L,323796L,621816L,1195123L,2297617L,4420093L,8506487L,16380013L,31554394L,60817066L,117266799L,226217218L,436572777L,842895506L,1628036630L,3145780899L,6080759314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245122Inst : IEnumerable<long>
{
public static readonly long[] Value=A245122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245122.Bytes);
public long this[int i]=>Value[i];

public static A245122Inst Instance=new A245122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245123
{
public static readonly long[] Value={ 2L,3L,9L,20L,46L,94L,202L,412L,850L,1719L,3483L,6987L,14026L,27990L,55830L,111022L,220589L,437451L,866898L,1715821L,3393973L,6708016L,13251455L,26163174L,51635765L,101868226L,200908954L,396129137L,780868821L,1538971204L,3032575428L,5974874666L,11770477038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245123Inst : IEnumerable<long>
{
public static readonly long[] Value=A245123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245123.Bytes);
public long this[int i]=>Value[i];

public static A245123Inst Instance=new A245123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245124
{
public static readonly long[] Value={ 1L,4L,11L,28L,70L,160L,366L,804L,1748L,3734L,7918L,16597L,34601L,71628L,147631L,302857L,619231L,1261849L,2564795L,5200248L,10522565L,21252174L,42854194L,86286963L,173517189L,348523105L,699311092L,1401837776L,2807733181L,5619221464L,11238041122L,22460777472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245124Inst : IEnumerable<long>
{
public static readonly long[] Value=A245124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245124.Bytes);
public long this[int i]=>Value[i];

public static A245124Inst Instance=new A245124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245125
{
public static readonly long[] Value={ 2L,6L,23L,60L,162L,397L,960L,2223L,5085L,11355L,25088L,54654L,118051L,252601L,536973L,1133925L,2382281L,4980512L,10370545L,21512821L,44483291L,91708748L,188580249L,386854596L,791909788L,1617922147L,3299701619L,6718766927L,13660421145L,27736326713L,56246087592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245125Inst : IEnumerable<long>
{
public static readonly long[] Value=A245125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245125.Bytes);
public long this[int i]=>Value[i];

public static A245125Inst Instance=new A245125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245126
{
public static readonly long[] Value={ 1L,8L,26L,86L,247L,669L,1709L,4251L,10214L,24066L,55551L,126369L,283505L,629261L,1382778L,3013846L,6519955L,14015077L,29952488L,63690016L,134807361L,284170813L,596800591L,1249172169L,2606663357L,5424220543L,11258470062L,23313312932L,48171597034L,99337649116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245126Inst : IEnumerable<long>
{
public static readonly long[] Value=A245126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245126.Bytes);
public long this[int i]=>Value[i];

public static A245126Inst Instance=new A245126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245127
{
public static readonly long[] Value={ 4L,18L,75L,241L,732L,2048L,5507L,14149L,35406L,86251L,206060L,483503L,1118366L,2553371L,5766634L,12896468L,28598143L,62934478L,137565845L,298871089L,645779488L,1388442085L,2971788670L,6334659311L,13452368784L,28469327221L,60059197787L,126331495950L,265014539903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245127Inst : IEnumerable<long>
{
public static readonly long[] Value=A245127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245127.Bytes);
public long this[int i]=>Value[i];

public static A245127Inst Instance=new A245127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245128
{
public static readonly long[] Value={ 6L,32L,140L,490L,1582L,4679L,13207L,35579L,92848L,235364L,583368L,1417164L,3386221L,7972754L,18536344L,42613503L,97001737L,218855237L,489889224L,1088756521L,2404139499L,5277595013L,11523611147L,25038756870L,54160808489L,116670213947L,250366691420L,535375247787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245128Inst : IEnumerable<long>
{
public static readonly long[] Value=A245128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245128.Bytes);
public long this[int i]=>Value[i];

public static A245128Inst Instance=new A245128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245129
{
public static readonly long[] Value={ 4L,38L,176L,709L,2461L,7877L,23564L,67260L,184289L,489321L,1264330L,3194192L,7913035L,19276841L,46269287L,109625994L,256748635L,595150930L,1366840825L,3112999517L,7036328521L,15794921314L,35233087579L,78140317345L,172382151706L,378427107050L,826999312010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245129Inst : IEnumerable<long>
{
public static readonly long[] Value=A245129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245129.Bytes);
public long this[int i]=>Value[i];

public static A245129Inst Instance=new A245129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245130
{
public static readonly long[] Value={ 5L,5L,25L,41L,275L,505L,4005L,8193L,68855L,147117L,1277485L,2807617L,24937335L,55854349L,504209895L,1145384915L,10467805625L,24038991995L,221828315005L,513848349931L,4778788229935L,11147995960319L,104342997162795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245130Inst : IEnumerable<long>
{
public static readonly long[] Value=A245130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245130.Bytes);
public long this[int i]=>Value[i];

public static A245130Inst Instance=new A245130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245131
{
public static readonly long[] Value={ 6L,6L,36L,66L,552L,1248L,11856L,29182L,294024L,754712L,7864656L,20741082L,221051304L,594135812L,6435862704L,17543490552L,192393047844L,530178286952L,5870767076544L,16318715568296L,182113708337928L,509795775623836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245131Inst : IEnumerable<long>
{
public static readonly long[] Value=A245131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245131.Bytes);
public long this[int i]=>Value[i];

public static A245131Inst Instance=new A245131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245132
{
public static readonly long[] Value={ 7L,7L,49L,107L,1029L,2687L,29813L,85529L,1006089L,3011889L,36616279L,112656837L,1400740383L,4392222905L,55506486357L,176519274957L,2258424885703L,7260708228631L,93797950158381L,304177053610679L,3960276884051145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245132Inst : IEnumerable<long>
{
public static readonly long[] Value=A245132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245132.Bytes);
public long this[int i]=>Value[i];

public static A245132Inst Instance=new A245132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245133
{
public static readonly long[] Value={ 8L,8L,64L,158L,1728L,5220L,66256L,217336L,2920784L,9995864L,138879808L,488324280L,6938896320L,24865974872L,359129619952L,1305229141238L,19084811616288L,70121208253128L,1035266773525472L,3836844883595142L,57090322839615456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245133Inst : IEnumerable<long>
{
public static readonly long[] Value=A245133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245133.Bytes);
public long this[int i]=>Value[i];

public static A245133Inst Instance=new A245133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245134
{
public static readonly long[] Value={ 2L,3L,2L,4L,3L,4L,5L,4L,9L,4L,6L,5L,16L,9L,8L,7L,6L,25L,22L,39L,8L,8L,7L,36L,41L,112L,43L,20L,9L,8L,49L,66L,275L,172L,195L,18L,10L,9L,64L,107L,552L,505L,1064L,243L,52L,11L,10L,81L,158L,1029L,1248L,4005L,1742L,1209L,48L,12L,11L,100L,219L,1728L,2687L,11856L,8193L,11664L,1539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245134Inst : IEnumerable<long>
{
public static readonly long[] Value=A245134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245134.Bytes);
public long this[int i]=>Value[i];

public static A245134Inst Instance=new A245134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245135
{
public static readonly long[] Value={ 8L,39L,112L,275L,552L,1029L,1728L,2781L,4200L,6171L,8688L,11999L,16072L,21225L,27392L,34969L,43848L,54511L,66800L,81291L,97768L,116909L,138432L,163125L,190632L,221859L,256368L,295191L,337800L,385361L,437248L,494769L,557192L,625975L,700272L,781699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245135Inst : IEnumerable<long>
{
public static readonly long[] Value=A245135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245135.Bytes);
public long this[int i]=>Value[i];

public static A245135Inst Instance=new A245135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245136
{
public static readonly long[] Value={ 8L,43L,172L,505L,1248L,2687L,5220L,9385L,15868L,25539L,39428L,58805L,85144L,120163L,165900L,224593L,298832L,391539L,505928L,645645L,814656L,1017335L,1258484L,1543341L,1877624L,2267451L,2719516L,3240965L,3839476L,4523383L,5301420L,6183009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245136Inst : IEnumerable<long>
{
public static readonly long[] Value=A245136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245136.Bytes);
public long this[int i]=>Value[i];

public static A245136Inst Instance=new A245136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245137
{
public static readonly long[] Value={ 20L,195L,1064L,4005L,11856L,29813L,66256L,134091L,252060L,446193L,751536L,1214369L,1893612L,2863755L,4217056L,6065957L,8545968L,11819349L,16076760L,21542115L,28475524L,37176625L,47988672L,61303825L,77564708L,97271523L,120985592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245137Inst : IEnumerable<long>
{
public static readonly long[] Value=A245137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245137.Bytes);
public long this[int i]=>Value[i];

public static A245137Inst Instance=new A245137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245138
{
public static readonly BigInteger[] Value={ 1L,1L,1L,13L,49L,361L,3121L,39733L,409249L,6410641L,91979041L,1716516253L,29795642449L,660718214521L,13656276138961L,345794520085573L,8290832204163649L,237409681243284001L,6465138777774530881L,BigInteger.Parse("206263448435258395693"),BigInteger.Parse("6296129943088315156849"),BigInteger.Parse("221484543685548532051081") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245138Inst Instance=new A245138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245139
{
public static readonly BigInteger[] Value={ 1L,2L,4L,14L,64L,602L,5344L,58214L,661504L,9666482L,145897984L,2611988414L,47548524544L,1002692887562L,21581168410624L,527328466446614L,13084553110749184L,362312592419199842L,10175324275879051264UL,BigInteger.Parse("315223836841156264814"),BigInteger.Parse("9889646730551557095424"),BigInteger.Parse("338833067799589889659322") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245139Inst Instance=new A245139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245140
{
public static readonly BigInteger[] Value={ 1L,3L,9L,45L,297L,2433L,23949L,275145L,3612177L,53348193L,875453589L,15802999545L,311196040857L,6638817262353L,152521855979229L,3754366520240745L,98575724288354337L,2749997026637342913L,BigInteger.Parse("81230299711952152869"),BigInteger.Parse("2532707187355266614745"),BigInteger.Parse("83124358113443446120617"),BigInteger.Parse("2864579803637260793877873") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245140Inst Instance=new A245140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245141
{
public static readonly BigInteger[] Value={ 1L,3L,50L,1626L,83736L,6026120L,571350096L,67996818960L,9862902275456L,1700092943088768L,342087177215788800L,BigInteger.Parse("79115601821198404352"),BigInteger.Parse("20779757607847901690880"),BigInteger.Parse("6133520505473954148381696"),BigInteger.Parse("2017134796016735182500521984"),BigInteger.Parse("733523863838078950241395968000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245141Inst Instance=new A245141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245142
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,3L,8L,9L,21L,28L,56L,81L,159L,237L,444L,701L,1273L,2060L,3699L,6099L,10840L,18180L,32079L,54417L,95787L,163868L,287914L,496171L,871270L,1509676L,2652068L,4615810L,8114578L,14176261L,24947471L,43718822L,77031659L,135350915L,238791685L,420544851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245142Inst : IEnumerable<long>
{
public static readonly long[] Value=A245142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245142.Bytes);
public long this[int i]=>Value[i];

public static A245142Inst Instance=new A245142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245143
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,3L,3L,5L,9L,12L,17L,32L,42L,64L,106L,157L,232L,379L,563L,866L,1362L,2081L,3186L,5028L,7710L,11924L,18659L,28938L,44842L,70254L,109245L,170266L,266562L,416378L,650513L,1020431L,1597803L,2504070L,3932672L,6174777L,9698203L,15258753L,24005178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245143Inst : IEnumerable<long>
{
public static readonly long[] Value=A245143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245143.Bytes);
public long this[int i]=>Value[i];

public static A245143Inst Instance=new A245143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245144
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,3L,3L,5L,5L,11L,12L,19L,24L,41L,51L,78L,101L,163L,215L,320L,431L,661L,908L,1333L,1846L,2745L,3847L,5630L,7913L,11620L,16481L,23991L,34134L,49782L,71196L,103416L,148178L,215511L,309881L,449941L,647868L,941279L,1358857L,1973315L,2851880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245144Inst : IEnumerable<long>
{
public static readonly long[] Value=A245144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245144.Bytes);
public long this[int i]=>Value[i];

public static A245144Inst Instance=new A245144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245145
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,3L,3L,5L,5L,7L,11L,14L,19L,26L,32L,49L,63L,87L,114L,157L,215L,292L,396L,536L,719L,1002L,1345L,1849L,2496L,3395L,4644L,6344L,8647L,11800L,16049L,21990L,29980L,41087L,56048L,76642L,104863L,143498L,196454L,269057L,368191L,504806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245145Inst : IEnumerable<long>
{
public static readonly long[] Value=A245145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245145.Bytes);
public long this[int i]=>Value[i];

public static A245145Inst Instance=new A245145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245146
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,3L,3L,5L,5L,7L,7L,13L,14L,21L,26L,34L,40L,61L,72L,100L,127L,171L,209L,295L,367L,499L,638L,851L,1083L,1469L,1879L,2512L,3257L,4320L,5576L,7454L,9662L,12833L,16752L,22163L,28874L,38308L,50056L,66232L,86865L,114784L,150429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245146Inst : IEnumerable<long>
{
public static readonly long[] Value=A245146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245146.Bytes);
public long this[int i]=>Value[i];

public static A245146Inst Instance=new A245146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245147
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,3L,3L,5L,5L,7L,7L,9L,13L,16L,21L,28L,34L,42L,52L,70L,85L,113L,141L,185L,227L,290L,371L,474L,602L,771L,983L,1254L,1583L,2038L,2582L,3315L,4217L,5405L,6867L,8783L,11201L,14318L,18285L,23395L,29886L,38207L,48765L,62428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245147Inst : IEnumerable<long>
{
public static readonly long[] Value=A245147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245147.Bytes);
public long this[int i]=>Value[i];

public static A245147Inst Instance=new A245147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245148
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,5L,5L,7L,7L,9L,9L,15L,16L,23L,28L,36L,42L,54L,61L,83L,98L,127L,155L,203L,242L,309L,370L,479L,578L,739L,904L,1155L,1420L,1790L,2194L,2786L,3425L,4323L,5350L,6747L,8362L,10522L,13022L,16397L,20346L,25558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245148Inst : IEnumerable<long>
{
public static readonly long[] Value=A245148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245148.Bytes);
public long this[int i]=>Value[i];

public static A245148Inst Instance=new A245148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245149
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,5L,5L,7L,7L,9L,9L,11L,15L,18L,23L,30L,36L,44L,54L,63L,74L,96L,112L,141L,173L,218L,261L,328L,390L,479L,587L,716L,873L,1080L,1322L,1628L,1998L,2446L,2982L,3677L,4481L,5507L,6744L,8296L,10155L,12521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245149Inst : IEnumerable<long>
{
public static readonly long[] Value=A245149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245149.Bytes);
public long this[int i]=>Value[i];

public static A245149Inst Instance=new A245149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245150
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,5L,5L,7L,7L,9L,9L,11L,11L,17L,18L,25L,30L,38L,44L,56L,63L,76L,87L,110L,126L,159L,188L,237L,280L,348L,410L,503L,588L,726L,854L,1050L,1248L,1534L,1837L,2251L,2694L,3282L,3921L,4784L,5717L,6955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245150Inst : IEnumerable<long>
{
public static readonly long[] Value=A245150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245150.Bytes);
public long this[int i]=>Value[i];

public static A245150Inst Instance=new A245150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245151
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,0L,1L,0L,3L,1L,0L,1L,0L,5L,1L,0L,0L,1L,0L,7L,3L,1L,0L,0L,1L,0L,12L,3L,1L,0L,0L,0L,1L,0L,17L,8L,1L,1L,0L,0L,0L,1L,0L,28L,9L,3L,1L,0L,0L,0L,0L,1L,0L,42L,21L,3L,1L,1L,0L,0L,0L,0L,1L,0L,69L,28L,5L,1L,1L,0L,0L,0L,0L,0L,1L,0L,105L,56L,9L,3L,1L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245151Inst : IEnumerable<long>
{
public static readonly long[] Value=A245151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245151.Bytes);
public long this[int i]=>Value[i];

public static A245151Inst Instance=new A245151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245152
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,12L,17L,28L,42L,69L,105L,176L,275L,460L,740L,1244L,2030L,3440L,5695L,9688L,16243L,27758L,46948L,80610L,137401L,236796L,406258L,702720L,1211954L,2103536L,3644413L,6344632L,11035287L,19265731L,33621510L,58848963L,103003059L,180712466L,317122290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245152Inst : IEnumerable<long>
{
public static readonly long[] Value=A245152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245152.Bytes);
public long this[int i]=>Value[i];

public static A245152Inst Instance=new A245152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245153
{
public static readonly BigInteger[] Value={ 1L,1L,1L,28L,109L,1036L,12421L,189568L,2377369L,50888656L,889772041L,21056972608L,463426778629L,13171920918976L,338302052475661L,11024635871323648L,331174000888419889L,12111179923298826496UL,BigInteger.Parse("413871819030803915281"),BigInteger.Parse("16886967133601994738688") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245153Inst Instance=new A245153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245154
{
public static readonly BigInteger[] Value={ 1L,3L,9L,36L,189L,2148L,26109L,371136L,5407929L,95795568L,1832049009L,41428038336L,972380766069L,25736128903488L,705111069908709L,21600790506395136L,683861855417706609L,BigInteger.Parse("23836956839153265408"),BigInteger.Parse("853476673589938069209"),BigInteger.Parse("33263825890074489025536") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245154Inst Instance=new A245154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245155
{
public static readonly BigInteger[] Value={ 1L,4L,16L,100L,832L,8644L,107776L,1567780L,26063872L,487466884L,10129985536L,231560895460L,5774444019712L,155997355725124L,4538464905527296L,141469868440031140L,4703786933664612352L,BigInteger.Parse("166172927821116399364"),BigInteger.Parse("6215792183431115309056"),BigInteger.Parse("245422172388559255422820") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245155Inst Instance=new A245155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245156
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,13L,51L,234L,1205L,6861L,42696L,287893L,2088343L,16195822L,133582909L,1166593665L,10746339324L,104072482781L,1056515903547L,11213782563474L,124152537651877L,1430804512710901L,17131971790847440L,212761333257548485L,2736258689605227615L,BigInteger.Parse("36389676240341831766") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245156Inst Instance=new A245156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245157
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,25L,108L,525L,2841L,16926L,109795L,768721L,5769848L,46170841L,392042257L,3517885530L,33240220095L,329703176361L,3423448119588L,37121182883557L,419414109036649L,4927952017449398L,60105139223521051L,759744837538329121L,9937680363610804080UL,BigInteger.Parse("134328047043765078705") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245157Inst Instance=new A245157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245158
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,23L,65L,199L,653L,2275L,8313L,31439L,121637L,477307L,1888721L,7509799L,29940861L,119550419L,477742889L,1909988479L,7637856725L,30546970411L,122178444417L,488693854679L,1954733475629L,7818845822083L,31275198738905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245158Inst : IEnumerable<long>
{
public static readonly long[] Value=A245158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245158.Bytes);
public long this[int i]=>Value[i];

public static A245158Inst Instance=new A245158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245159
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,23L,65L,199L,654L,2296L,8568L,33794L,140039L,605869L,2718531L,12564289L,59419764L,285878342L,1392536354L,6842206084L,33819153429L,167827213315L,835048228437L,4162123757579L,20768689294634L,103709892420388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245159Inst : IEnumerable<long>
{
public static readonly long[] Value=A245159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245159.Bytes);
public long this[int i]=>Value[i];

public static A245159Inst Instance=new A245159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245160
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,23L,65L,199L,654L,2296L,8569L,33825L,140580L,612890L,2794159L,13280627L,65597882L,335521900L,1770176005L,9593485125L,53183385680L,300371056446L,1721926382427L,9987133305239L,58446578859494L,344361988828048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245160Inst : IEnumerable<long>
{
public static readonly long[] Value=A245160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245160.Bytes);
public long this[int i]=>Value[i];

public static A245160Inst Instance=new A245160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245161
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,23L,65L,199L,654L,2296L,8569L,33825L,140581L,612933L,2795181L,13298407L,65851100L,338654554L,1805083341L,9952373825L,56645932971L,332111798479L,2000990363889L,12357518954759L,78010845456554L,501994699807228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245161Inst : IEnumerable<long>
{
public static readonly long[] Value=A245161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245161.Bytes);
public long this[int i]=>Value[i];

public static A245161Inst Instance=new A245161Inst();

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