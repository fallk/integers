using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276662
{
public static readonly long[] Value={ 311L,1129L,37L,773L,313L,311L,1129L,313L,3119014487L,31079L,317L,773L,1129L,3110647L,3103819425079L,310397L,5113L,31079L,3109L,3137L,310361L,31259L,331L,36389L,191176757654383L,31063L,337L,523L,324941L,31393L,127139L,33769L,31034567124791L,32369L,719L,5623L,347L,3371L,131777L,349L,31039L,34412909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276662Inst : IEnumerable<long>
{
public static readonly long[] Value=A276662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276662.Bytes);
public long this[int i]=>Value[i];

public static A276662Inst Instance=new A276662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276663
{
public static readonly BigInteger[] Value={ 5L,11L,39L,139L,8215L,131103L,524323L,2147483707L,2305843009213694071L,BigInteger.Parse("618970019642690137449562287"),BigInteger.Parse("162259276829213363391578010288339"),BigInteger.Parse("170141183460469231731687303715884105979") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276663Inst Instance=new A276663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276664
{
public static readonly long[] Value={ 2L,1L,6L,9L,11L,11L,23L,15L,29L,23L,27L,35L,35L,33L,41L,59L,71L,59L,69L,59L,71L,87L,89L,95L,95L,95L,117L,101L,107L,119L,129L,131L,119L,135L,155L,171L,179L,153L,185L,179L,167L,191L,179L,167L,179L,207L,195L,213L,221L,215L,239L,215L,227L,251L,263L,245L,251L,291L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276664Inst : IEnumerable<long>
{
public static readonly long[] Value=A276664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276664.Bytes);
public long this[int i]=>Value[i];

public static A276664Inst Instance=new A276664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276665
{
public static readonly long[] Value={ 1L,2L,3L,7L,27L,703L,26623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276665Inst : IEnumerable<long>
{
public static readonly long[] Value=A276665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276665.Bytes);
public long this[int i]=>Value[i];

public static A276665Inst Instance=new A276665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276666
{
public static readonly long[] Value={ -1L,0L,2L,10L,42L,168L,660L,2574L,10010L,38896L,151164L,587860L,2288132L,8914800L,34767720L,135727830L,530365050L,2074316640L,8119857900L,31810737420L,124718287980L,489325340400L,1921133836440L,7547311500300L,29667795388452L,116686713634848L,459183826803800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276666Inst : IEnumerable<long>
{
public static readonly long[] Value=A276666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276666.Bytes);
public long this[int i]=>Value[i];

public static A276666Inst Instance=new A276666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276667
{
public static readonly BigInteger[] Value={ 1L,-1L,7L,-31L,381L,-268275L,190954395L,-8940271725L,336335206772565L,-174821527924918875L,BigInteger.Parse("54202314805255255275"),BigInteger.Parse("-5543854406384412644150625"),BigInteger.Parse("3114120189113602279924264875"),BigInteger.Parse("-14151357141482747539875264868125"),BigInteger.Parse("10216485085859695459247479126412709375") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276667Inst Instance=new A276667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276668
{
public static readonly long[] Value={ 1L,12L,120L,56L,16L,88L,208L,16L,544L,152L,16L,368L,32L,16L,928L,992L,64L,8L,592L,16L,1312L,688L,32L,1504L,64L,16L,1696L,32L,64L,1888L,3904L,64L,128L,536L,16L,1136L,2336L,16L,32L,2528L,64L,1328L,32L,32L,5696L,32L,64L,64L,12416L,16L,3232L,3296L,64L,3424L,6976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276668Inst : IEnumerable<long>
{
public static readonly long[] Value=A276668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276668.Bytes);
public long this[int i]=>Value[i];

public static A276668Inst Instance=new A276668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276669
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,2L,0L,3L,4L,2L,1L,3L,0L,4L,6L,5L,2L,3L,1L,4L,0L,5L,8L,6L,7L,3L,2L,4L,1L,5L,0L,6L,10L,7L,9L,8L,3L,4L,2L,5L,1L,6L,0L,7L,12L,8L,11L,9L,10L,4L,3L,5L,2L,6L,1L,7L,0L,8L,14L,9L,13L,10L,12L,11L,4L,5L,3L,6L,2L,7L,1L,8L,0L,9L,16L,10L,15L,11L,14L,12L,13L,5L,4L,6L,3L,7L,2L,8L,1L,9L,0L,10L,18L,11L,17L,12L,16L,13L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276669Inst : IEnumerable<long>
{
public static readonly long[] Value=A276669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276669.Bytes);
public long this[int i]=>Value[i];

public static A276669Inst Instance=new A276669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276670
{
public static readonly long[] Value={ 0L,0L,3L,6L,15L,30L,105L,84L,126L,180L,495L,330L,429L,546L,1365L,840L,1020L,1224L,2907L,1710L,1995L,2310L,5313L,3036L,3450L,3900L,8775L,4914L,5481L,6090L,13485L,7440L,8184L,8976L,19635L,10710L,11655L,12654L,27417L,14820L,15990L,17220L,37023L,19866L,21285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276670Inst : IEnumerable<long>
{
public static readonly long[] Value=A276670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276670.Bytes);
public long this[int i]=>Value[i];

public static A276670Inst Instance=new A276670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276671
{
public static readonly long[] Value={ 1L,2929L,9742277641L,23341869101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276671Inst : IEnumerable<long>
{
public static readonly long[] Value=A276671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276671.Bytes);
public long this[int i]=>Value[i];

public static A276671Inst Instance=new A276671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276672
{
public static readonly long[] Value={ 1L,3L,4L,9L,10L,12L,13L,16L,20L,37L,57L,66L,106L,116L,127L,355L,396L,547L,2289L,3777L,4500L,7821L,15663L,22746L,25978L,30434L,39682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276672Inst : IEnumerable<long>
{
public static readonly long[] Value=A276672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276672.Bytes);
public long this[int i]=>Value[i];

public static A276672Inst Instance=new A276672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276673
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,19L,23L,25L,28L,65L,171L,183L,187L,295L,351L,471L,561L,634L,710L,1726L,3947L,4247L,6009L,11065L,13567L,94493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276673Inst : IEnumerable<long>
{
public static readonly long[] Value=A276673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276673.Bytes);
public long this[int i]=>Value[i];

public static A276673Inst Instance=new A276673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276674
{
public static readonly long[] Value={ 21L,28L,45L,46L,51L,64L,65L,77L,82L,85L,91L,106L,111L,126L,129L,133L,136L,148L,155L,166L,172L,175L,185L,189L,205L,208L,209L,217L,221L,225L,231L,232L,235L,237L,244L,247L,267L,273L,274L,276L,286L,291L,298L,305L,316L,319L,326L,333L,339L,341L,358L,362L,364L,365L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276674Inst : IEnumerable<long>
{
public static readonly long[] Value=A276674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276674.Bytes);
public long this[int i]=>Value[i];

public static A276674Inst Instance=new A276674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276675
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,0L,0L,1L,1L,0L,1L,2L,0L,1L,3L,0L,0L,0L,0L,2L,1L,0L,0L,0L,3L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,4L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,1L,0L,0L,0L,1L,2L,0L,0L,0L,0L,4L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,1L,0L,3L,1L,0L,1L,0L,1L,1L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276675Inst : IEnumerable<long>
{
public static readonly long[] Value=A276675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276675.Bytes);
public long this[int i]=>Value[i];

public static A276675Inst Instance=new A276675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276676
{
public static readonly long[] Value={ 2L,11L,2L,47L,47L,2L,47L,47L,11L,2L,47L,47L,17L,17L,2L,683L,683L,683L,683L,683L,2L,683L,683L,683L,683L,683L,11L,2L,683L,683L,683L,683L,683L,17L,17L,2L,683L,683L,683L,683L,683L,467L,467L,467L,2L,683L,683L,683L,683L,683L,467L,467L,467L,11L,2L,683L,683L,683L,683L,683L,467L,467L,467L,79L,79L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276676Inst : IEnumerable<long>
{
public static readonly long[] Value=A276676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276676.Bytes);
public long this[int i]=>Value[i];

public static A276676Inst Instance=new A276676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276677
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,28L,48L,76L,120L,180L,272L,396L,584L,836L,1216L,1724L,2488L,3508L,5040L,7084L,10152L,14244L,20384L,28572L,40856L,57236L,81808L,114572L,163720L,229252L,327552L,458620L,655224L,917364L,1310576L,1834860L,2621288L,3669860L,5242720L,7339868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276677Inst : IEnumerable<long>
{
public static readonly long[] Value=A276677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276677.Bytes);
public long this[int i]=>Value[i];

public static A276677Inst Instance=new A276677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276678
{
public static readonly long[] Value={ 1L,2L,6L,4L,4L,4L,8L,6L,6L,4L,10L,16L,4L,4L,16L,8L,6L,6L,12L,8L,8L,8L,8L,12L,6L,8L,32L,8L,4L,8L,8L,20L,12L,4L,24L,12L,8L,4L,16L,24L,4L,16L,14L,8L,12L,4L,16L,32L,6L,6L,24L,16L,4L,16L,16L,12L,16L,4L,16L,16L,8L,8L,24L,12L,8L,8L,18L,16L,8L,16L,8L,36L,4L,8L,60L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276678Inst : IEnumerable<long>
{
public static readonly long[] Value=A276678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276678.Bytes);
public long this[int i]=>Value[i];

public static A276678Inst Instance=new A276678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276679
{
public static readonly long[] Value={ 1L,4L,4L,6L,6L,8L,4L,16L,6L,8L,8L,12L,6L,16L,8L,10L,8L,24L,4L,24L,8L,8L,12L,16L,9L,16L,8L,24L,8L,16L,4L,36L,16L,8L,16L,18L,4L,24L,16L,16L,10L,16L,8L,24L,12L,16L,8L,40L,6L,36L,8L,12L,16L,16L,8L,32L,8L,16L,12L,48L,6L,16L,24L,14L,16L,16L,8L,48L,8L,16L,8L,48L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276679Inst : IEnumerable<long>
{
public static readonly long[] Value=A276679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276679.Bytes);
public long this[int i]=>Value[i];

public static A276679Inst Instance=new A276679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276680
{
public static readonly long[] Value={ 1L,2L,6L,4L,4L,5L,10L,6L,8L,4L,8L,12L,4L,4L,24L,16L,4L,8L,8L,8L,12L,4L,16L,24L,6L,4L,20L,8L,4L,18L,12L,10L,12L,4L,16L,16L,8L,8L,36L,12L,4L,16L,8L,16L,16L,4L,12L,24L,9L,12L,32L,8L,4L,10L,32L,12L,12L,8L,8L,40L,4L,4L,48L,12L,16L,12L,8L,8L,16L,8L,20L,48L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276680Inst : IEnumerable<long>
{
public static readonly long[] Value=A276680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276680.Bytes);
public long this[int i]=>Value[i];

public static A276680Inst Instance=new A276680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276681
{
public static readonly long[] Value={ 1L,4L,4L,8L,4L,12L,4L,10L,9L,16L,4L,16L,4L,20L,8L,12L,6L,24L,8L,16L,8L,16L,4L,40L,6L,16L,8L,16L,8L,40L,8L,14L,8L,24L,8L,24L,4L,24L,16L,20L,6L,32L,4L,32L,24L,20L,4L,24L,12L,24L,8L,32L,4L,56L,8L,20L,12L,16L,12L,32L,4L,20L,24L,32L,8L,48L,4L,16L,16L,48L,4L,30L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276681Inst : IEnumerable<long>
{
public static readonly long[] Value=A276681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276681.Bytes);
public long this[int i]=>Value[i];

public static A276681Inst Instance=new A276681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276682
{
public static readonly long[] Value={ 1L,3L,8L,4L,6L,4L,8L,12L,6L,6L,18L,8L,4L,8L,16L,8L,8L,9L,14L,24L,8L,4L,16L,12L,8L,8L,24L,8L,12L,12L,8L,20L,8L,4L,48L,24L,4L,12L,16L,24L,8L,12L,12L,16L,18L,4L,20L,16L,9L,16L,40L,8L,8L,8L,24L,36L,8L,4L,24L,24L,4L,16L,24L,12L,24L,8L,16L,16L,8L,12L,16L,18L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276682Inst : IEnumerable<long>
{
public static readonly long[] Value=A276682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276682.Bytes);
public long this[int i]=>Value[i];

public static A276682Inst Instance=new A276682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276683
{
public static readonly long[] Value={ 1L,4L,4L,6L,4L,12L,6L,8L,8L,8L,4L,24L,6L,8L,12L,10L,8L,16L,4L,24L,12L,16L,4L,24L,6L,8L,20L,12L,4L,32L,6L,24L,12L,16L,8L,24L,8L,8L,16L,16L,8L,48L,6L,12L,16L,8L,8L,50L,6L,12L,12L,24L,8L,20L,16L,32L,24L,8L,4L,36L,4L,24L,16L,28L,8L,32L,8L,12L,24L,16L,4L,64L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276683Inst : IEnumerable<long>
{
public static readonly long[] Value=A276683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276683.Bytes);
public long this[int i]=>Value[i];

public static A276683Inst Instance=new A276683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276684
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,7L,4L,9L,11L,10L,13L,15L,17L,6L,19L,8L,31L,33L,35L,21L,14L,37L,22L,23L,30L,39L,25L,34L,41L,12L,27L,50L,51L,29L,53L,16L,55L,43L,32L,57L,44L,45L,36L,59L,47L,52L,71L,49L,56L,61L,18L,73L,63L,38L,75L,65L,54L,77L,66L,67L,58L,79L,69L,74L,91L,93L,81L,76L,95L,83L,96L,97L,85L,99L,94L,111L,70L,112L,110L,113L,115L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276684Inst : IEnumerable<long>
{
public static readonly long[] Value=A276684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276684.Bytes);
public long this[int i]=>Value[i];

public static A276684Inst Instance=new A276684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276685
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,6L,5L,8L,20L,21L,10L,22L,24L,26L,29L,9L,28L,7L,40L,42L,30L,25L,44L,32L,41L,11L,12L,23L,33L,34L,45L,46L,36L,48L,27L,60L,50L,43L,38L,61L,14L,62L,64L,47L,66L,52L,63L,68L,16L,80L,65L,54L,67L,70L,49L,82L,72L,69L,84L,74L,85L,55L,56L,83L,86L,18L,88L,200L,76L,89L,90L,87L,77L,78L,202L,201L,100L,204L,206L,92L,208L,58L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276685Inst : IEnumerable<long>
{
public static readonly long[] Value=A276685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276685.Bytes);
public long this[int i]=>Value[i];

public static A276685Inst Instance=new A276685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276686
{
public static readonly long[] Value={ 3141L,582L,9999L,2796L,6549L,2019L,2916L,8352L,5485L,5485L,5485L,5485L,5485L,5485L,5485L,1177L,1177L,5485L,1177L,3718L,5485L,5485L,1766L,1766L,5485L,4608L,4608L,4608L,4608L,4608L,5485L,5485L,504L,504L,504L,504L,504L,504L,504L,2103L,504L,504L,9479L,504L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276686Inst : IEnumerable<long>
{
public static readonly long[] Value=A276686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276686.Bytes);
public long this[int i]=>Value[i];

public static A276686Inst Instance=new A276686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276687
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,30L,122L,336L,1412L,15129L,44561L,417542L,2479120L,7540843L,35983502L,451454834L,5313515136L,16809858904L,190077477328L,1124302066470L,3521811953565L,38563707677633L,240966297786218L,3192420711942298L,95433674596402663L,567734580765228356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276687Inst : IEnumerable<long>
{
public static readonly long[] Value=A276687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276687.Bytes);
public long this[int i]=>Value[i];

public static A276687Inst Instance=new A276687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276688
{
public static readonly BigInteger[] Value={ 0L,0L,1L,8L,5L,-220L,1895L,-9140L,-302175L,-2778300L,-95631825L,-10071428100L,-236788407375L,57706241794500L,-7412904844112625L,525300693117661500L,BigInteger.Parse("348922898045520800625"),BigInteger.Parse("55166584329677385922500"),BigInteger.Parse("28368558145043150339199375"),BigInteger.Parse("46873210124734003815040957500") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276688Inst Instance=new A276688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276689
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,4L,2L,1L,1L,0L,6L,3L,2L,1L,1L,1L,0L,8L,4L,1L,2L,1L,1L,1L,1L,0L,10L,5L,2L,1L,2L,1L,1L,1L,1L,1L,0L,12L,6L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,0L,14L,7L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,0L,16L,8L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,0L,18L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276689Inst : IEnumerable<long>
{
public static readonly long[] Value=A276689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276689.Bytes);
public long this[int i]=>Value[i];

public static A276689Inst Instance=new A276689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276690
{
public static readonly long[] Value={ 2L,3L,6L,13L,14L,29L,114L,1810L,7989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276690Inst : IEnumerable<long>
{
public static readonly long[] Value=A276690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276690.Bytes);
public long this[int i]=>Value[i];

public static A276690Inst Instance=new A276690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276691
{
public static readonly long[] Value={ 1L,4L,11L,27L,63L,142L,314L,684L,1474L,3150L,6685L,14110L,29640L,62022L,129337L,268930L,557752L,1154164L,2383587L,4913835L,10113983L,20787252L,42668775L,87479539L,179157497L,366547820L,749256450L,1530251194L,3122882776L,6368433118L,12978230568L,26431617730L,53799078716L,109442256914L,222519713892L,452208698216L,918560947022L,1865036287632L,3785181059505L,7679199158098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276691Inst : IEnumerable<long>
{
public static readonly long[] Value=A276691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276691.Bytes);
public long this[int i]=>Value[i];

public static A276691Inst Instance=new A276691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276692
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,11L,23L,46L,85L,341L,1471L,2942L,5461L,21845L,349525L,1398101L,6025215L,12050430L,22369621L,89478485L,1431655765L,5726623061L,91625968981L,366503875925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276692Inst : IEnumerable<long>
{
public static readonly long[] Value=A276692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276692.Bytes);
public long this[int i]=>Value[i];

public static A276692Inst Instance=new A276692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276693
{
public static readonly BigInteger[] Value={ 3L,5L,7L,8L,27L,29L,187L,596L,4827L,106625L,2770267L,511908608L,294867810267L,1417828655948069L,BigInteger.Parse("150943952469132130267"),BigInteger.Parse("418071880169258361764894156"),BigInteger.Parse("214012660834726939177944668730210267"),BigInteger.Parse("63105422008735225121538219609433904551328809385") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276693Inst Instance=new A276693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276694
{
public static readonly long[] Value={ 0L,11L,13L,101L,107L,177L,357L,1001L,1011L,10759L,11487L,42189L,113183L,344253L,1851759L,4787769L,15848679L,139367847L,240889077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276694Inst : IEnumerable<long>
{
public static readonly long[] Value=A276694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276694.Bytes);
public long this[int i]=>Value[i];

public static A276694Inst Instance=new A276694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276695
{
public static readonly long[] Value={ 0L,2L,-1L,-2L,0L,2L,-6L,4L,-6L,6L,4L,2L,6L,10L,6L,-6L,-12L,2L,-2L,12L,2L,-8L,-6L,-6L,2L,6L,-14L,6L,2L,-6L,-2L,0L,18L,4L,-6L,-20L,-22L,10L,-18L,-6L,12L,-10L,12L,26L,18L,-8L,16L,10L,6L,14L,-6L,24L,14L,0L,-6L,18L,18L,-20L,26L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276695Inst : IEnumerable<long>
{
public static readonly long[] Value=A276695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276695.Bytes);
public long this[int i]=>Value[i];

public static A276695Inst Instance=new A276695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276696
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,4L,2L,1L,1L,3L,6L,5L,3L,1L,1L,3L,9L,8L,8L,3L,1L,1L,4L,12L,14L,16L,9L,4L,1L,1L,4L,16L,20L,30L,19L,13L,4L,1L,1L,5L,20L,30L,50L,39L,32L,14L,5L,1L,1L,5L,25L,40L,80L,69L,71L,36L,19L,5L,1L,1L,6L,30L,55L,120L,119L,140L,85L,55L,20L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276696Inst : IEnumerable<long>
{
public static readonly long[] Value=A276696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276696.Bytes);
public long this[int i]=>Value[i];

public static A276696Inst Instance=new A276696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276697
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1000L,1042L,2000L,3000L,4000L,5000L,6000L,7000L,8000L,9000L,321213L,642426L,1000000L,1042000L,2000000L,3000000L,4000000L,5000000L,6000000L,7000000L,8000000L,9000000L,10121026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276697Inst : IEnumerable<long>
{
public static readonly long[] Value=A276697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276697.Bytes);
public long this[int i]=>Value[i];

public static A276697Inst Instance=new A276697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276698
{
public static readonly long[] Value={ 1L,2L,7L,17L,24L,32L,66L,67L,74L,92L,104L,117L,188L,260L,279L,336L,348L,369L,547L,619L,860L,2735L,7932L,11874L,14867L,40153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276698Inst : IEnumerable<long>
{
public static readonly long[] Value=A276698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276698.Bytes);
public long this[int i]=>Value[i];

public static A276698Inst Instance=new A276698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276699
{
public static readonly long[] Value={ 14L,297L,869L,1241L,1349L,1541L,1769L,1829L,1961L,2021L,82091L,88931L,98171L,100739L,105779L,111899L,116651L,122411L,125771L,130139L,135419L,139499L,150971L,152771L,157979L,158819L,165251L,169739L,173939L,174611L,177851L,182051L,183731L,188339L,189731L,193091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276699Inst : IEnumerable<long>
{
public static readonly long[] Value=A276699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276699.Bytes);
public long this[int i]=>Value[i];

public static A276699Inst Instance=new A276699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276700
{
public static readonly long[] Value={ 1L,21L,25L,30L,32L,36L,392L,441L,525L,560L,625L,630L,672L,750L,756L,800L,900L,960L,979L,1024L,1080L,1152L,1215L,1296L,1411L,1458L,1463L,1547L,1742L,1947L,2059L,2090L,2210L,2318L,2405L,2419L,2444L,2491L,2508L,2552L,2652L,2703L,2871L,2886L,2924L,2945L,3116L,3128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276700Inst : IEnumerable<long>
{
public static readonly long[] Value=A276700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276700.Bytes);
public long this[int i]=>Value[i];

public static A276700Inst Instance=new A276700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276701
{
public static readonly long[] Value={ 1L,3L,6L,20259L,43912L,563103L,18895035L,119847148L,305478634710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276701Inst : IEnumerable<long>
{
public static readonly long[] Value=A276701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276701.Bytes);
public long this[int i]=>Value[i];

public static A276701Inst Instance=new A276701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276702
{
public static readonly long[] Value={ 28L,2056L,2865L,7157404L,10181420L,39593464L,92261602845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276702Inst : IEnumerable<long>
{
public static readonly long[] Value=A276702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276702.Bytes);
public long this[int i]=>Value[i];

public static A276702Inst Instance=new A276702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276703
{
public static readonly long[] Value={ 0L,4L,14L,14L,14L,70L,70L,70L,90L,90L,90L,90L,90L,90L,90L,90L,90L,121L,121L,121L,121L,121L,121L,126L,126L,126L,126L,126L,172L,172L,172L,172L,172L,172L,174L,174L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276703Inst : IEnumerable<long>
{
public static readonly long[] Value=A276703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276703.Bytes);
public long this[int i]=>Value[i];

public static A276703Inst Instance=new A276703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276704
{
public static readonly long[] Value={ 3L,5L,6L,21L,45L,77L,117L,165L,221L,285L,357L,437L,525L,621L,725L,837L,957L,1085L,1221L,1365L,1517L,1677L,1845L,2021L,2205L,2397L,2597L,2805L,3021L,3245L,3477L,3717L,3965L,4221L,4485L,4757L,5037L,5325L,5621L,5925L,6237L,6557L,6885L,7221L,7565L,7917L,8277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276704Inst : IEnumerable<long>
{
public static readonly long[] Value=A276704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276704.Bytes);
public long this[int i]=>Value[i];

public static A276704Inst Instance=new A276704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276705
{
public static readonly long[] Value={ 4L,5L,7L,8L,9L,20L,55L,91L,187L,247L,391L,475L,667L,775L,1015L,1147L,1435L,1591L,1927L,2107L,2491L,2695L,3127L,3355L,3835L,4087L,4615L,4891L,5467L,5767L,6391L,6715L,7387L,7735L,8455L,8827L,9595L,9991L,10807L,11227L,12091L,12535L,13447L,13915L,14875L,15367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276705Inst : IEnumerable<long>
{
public static readonly long[] Value=A276705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276705.Bytes);
public long this[int i]=>Value[i];

public static A276705Inst Instance=new A276705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276706
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,10L,14L,16L,20L,22L,26L,28L,32L,34L,38L,40L,44L,46L,50L,52L,56L,58L,62L,64L,68L,70L,74L,76L,80L,82L,86L,88L,92L,94L,98L,100L,104L,106L,110L,112L,116L,118L,122L,124L,128L,130L,134L,136L,140L,142L,146L,148L,152L,154L,158L,160L,164L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276706Inst : IEnumerable<long>
{
public static readonly long[] Value=A276706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276706.Bytes);
public long this[int i]=>Value[i];

public static A276706Inst Instance=new A276706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276707
{
public static readonly long[] Value={ 4L,12L,60L,381L,2522L,19094L,151286L,1237792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276707Inst : IEnumerable<long>
{
public static readonly long[] Value=A276707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276707.Bytes);
public long this[int i]=>Value[i];

public static A276707Inst Instance=new A276707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276708
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1100L,1L,111100L,1L,11110100L,1L,1111110100L,1L,111111110100L,1L,11111111010100L,1L,1111111101010100L,1L,111111111101010100L,1L,11111111111101010100UL,1L,BigInteger.Parse("1111111111111101010100"),1L,BigInteger.Parse("111111111111111101010100"),1L,BigInteger.Parse("11111111111111110101010100"),1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276708Inst Instance=new A276708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276709
{
public static readonly long[] Value={ 2L,6L,8L,4L,5L,1L,0L,3L,5L,0L,8L,2L,0L,7L,0L,7L,6L,5L,2L,5L,0L,2L,3L,8L,2L,6L,4L,0L,4L,8L,7L,2L,3L,8L,6L,8L,5L,3L,1L,0L,1L,7L,9L,7L,3L,4L,5L,9L,8L,5L,5L,1L,6L,3L,5L,2L,2L,0L,4L,1L,4L,8L,6L,4L,5L,0L,2L,6L,4L,1L,1L,3L,3L,6L,3L,1L,7L,6L,7L,2L,4L,4L,8L,9L,3L,6L,2L,5L,0L,2L,2L,0L,1L,2L,5L,4L,8L,5L,2L,1L,5L,3L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276709Inst : IEnumerable<long>
{
public static readonly long[] Value=A276709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276709.Bytes);
public long this[int i]=>Value[i];

public static A276709Inst Instance=new A276709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276710
{
public static readonly long[] Value={ 36L,40L,63L,80L,84L,90L,105L,108L,132L,144L,150L,154L,160L,165L,168L,175L,176L,180L,182L,195L,198L,200L,208L,210L,220L,260L,264L,270L,273L,275L,280L,286L,288L,297L,300L,306L,308L,312L,315L,320L,324L,330L,340L,351L,357L,360L,364L,374L,378L,380L,385L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276710Inst : IEnumerable<long>
{
public static readonly long[] Value=A276710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276710.Bytes);
public long this[int i]=>Value[i];

public static A276710Inst Instance=new A276710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276711
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,2L,2L,1L,1L,1L,4L,2L,2L,2L,2L,1L,2L,2L,3L,2L,3L,1L,3L,1L,1L,1L,4L,2L,3L,3L,2L,4L,2L,2L,3L,1L,3L,5L,4L,2L,3L,2L,3L,3L,4L,2L,4L,2L,3L,2L,4L,2L,3L,3L,3L,4L,2L,1L,3L,2L,3L,4L,3L,1L,2L,3L,4L,5L,4L,2L,3L,3L,3L,2L,5L,1L,4L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276711Inst : IEnumerable<long>
{
public static readonly long[] Value=A276711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276711.Bytes);
public long this[int i]=>Value[i];

public static A276711Inst Instance=new A276711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276712
{
public static readonly long[] Value={ 1L,5L,0L,2L,5L,7L,1L,1L,2L,8L,9L,4L,9L,4L,9L,2L,8L,5L,6L,7L,4L,9L,6L,7L,2L,7L,0L,1L,8L,8L,9L,3L,1L,2L,4L,8L,8L,4L,5L,6L,2L,3L,2L,8L,6L,5L,4L,2L,5L,6L,2L,3L,6L,0L,2L,2L,4L,0L,3L,3L,9L,4L,4L,4L,1L,7L,7L,2L,9L,7L,7L,5L,7L,2L,3L,2L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276712Inst : IEnumerable<long>
{
public static readonly long[] Value=A276712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276712.Bytes);
public long this[int i]=>Value[i];

public static A276712Inst Instance=new A276712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276713
{
public static readonly long[] Value={ 2L,35L,55L,62L,74L,82L,91L,102L,115L,119L,122L,135L,142L,143L,155L,158L,172L,186L,202L,203L,206L,214L,215L,218L,242L,255L,259L,262L,282L,295L,298L,299L,302L,323L,326L,343L,351L,354L,355L,362L,391L,395L,399L,425L,426L,435L,451L,466L,478L,482L,492L,502L,511L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276713Inst : IEnumerable<long>
{
public static readonly long[] Value=A276713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276713.Bytes);
public long this[int i]=>Value[i];

public static A276713Inst Instance=new A276713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276714
{
public static readonly long[] Value={ 42677635L,276742235L,6439057062L,7512673242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276714Inst : IEnumerable<long>
{
public static readonly long[] Value=A276714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276714.Bytes);
public long this[int i]=>Value[i];

public static A276714Inst Instance=new A276714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276715
{
public static readonly long[] Value={ 1L,14L,33L,42677635L,51L,46L,155L,62L,69L,46L,174L,154L,285L,182L,141L,62L,138L,142L,235L,158L,123L,94L,213L,322L,295L,94L,177L,118L,159L,406L,376L,266L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276715Inst : IEnumerable<long>
{
public static readonly long[] Value=A276715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276715.Bytes);
public long this[int i]=>Value[i];

public static A276715Inst Instance=new A276715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276716
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,2L,6L,8L,10L,12L,14L,16L,18L,20L,4L,6L,4L,10L,12L,14L,16L,18L,20L,22L,6L,8L,10L,6L,14L,16L,18L,20L,22L,24L,8L,10L,12L,14L,8L,18L,20L,22L,24L,26L,10L,12L,14L,16L,18L,10L,22L,24L,26L,28L,12L,14L,16L,18L,20L,22L,12L,26L,28L,30L,14L,16L,18L,20L,22L,24L,26L,14L,30L,32L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276716Inst : IEnumerable<long>
{
public static readonly long[] Value=A276716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276716.Bytes);
public long this[int i]=>Value[i];

public static A276716Inst Instance=new A276716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276717
{
public static readonly long[] Value={ 1L,1L,5L,7L,17L,11L,13L,37L,17L,19L,89L,19L,41L,71L,29L,13L,73L,199L,37L,157L,41L,43L,17L,47L,113L,433L,53L,541L,809L,59L,61L,997L,89L,67L,1009L,71L,73L,113L,521L,79L,1553L,83L,1721L,1693L,89L,1873L,1697L,107L,97L,313L,101L,103L,761L,107L,109L,11L,113L,239L,1433L,2269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276717Inst : IEnumerable<long>
{
public static readonly long[] Value=A276717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276717.Bytes);
public long this[int i]=>Value[i];

public static A276717Inst Instance=new A276717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276718
{
public static readonly long[] Value={ 4L,52655L,57343L,443749L,526559L,573439L,656249L,2515624L,4437499L,5265599L,5734399L,6562499L,8484374L,44374999L,52655999L,57343999L,65624999L,401953124L,443749999L,526559999L,573439999L,656249999L,698046874L,4437499999L,5265599999L,5734399999L,6562499999L,44374999999L,52655999999L,57343999999L,65624999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276718Inst : IEnumerable<long>
{
public static readonly long[] Value=A276718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276718.Bytes);
public long this[int i]=>Value[i];

public static A276718Inst Instance=new A276718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276719
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,1L,2L,3L,1L,0L,1L,1L,2L,5L,5L,1L,0L,1L,1L,2L,5L,10L,8L,1L,0L,1L,1L,2L,5L,15L,20L,13L,1L,0L,1L,1L,2L,5L,15L,37L,42L,21L,1L,0L,1L,1L,2L,5L,15L,52L,87L,87L,34L,1L,0L,1L,1L,2L,5L,15L,52L,151L,208L,179L,55L,1L,0L,1L,1L,2L,5L,15L,52L,203L,409L,515L,370L,89L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276719Inst : IEnumerable<long>
{
public static readonly long[] Value=A276719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276719.Bytes);
public long this[int i]=>Value[i];

public static A276719Inst Instance=new A276719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276720
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,37L,87L,208L,515L,1271L,3112L,7594L,18578L,45510L,111464L,272839L,667809L,1634784L,4002217L,9797781L,23985131L,58715973L,143739040L,351879841L,861416293L,2108779100L,5162371032L,12637686756L,30937555540L,75736343956L,185405513889L,453879917561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276720Inst : IEnumerable<long>
{
public static readonly long[] Value=A276720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276720.Bytes);
public long this[int i]=>Value[i];

public static A276720Inst Instance=new A276720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276721
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,151L,409L,1100L,3012L,8487L,23949L,67179L,187431L,521889L,1455667L,4066220L,11363476L,31747666L,88659265L,247559056L,691294366L,1930595096L,5391864630L,15058449487L,42054270461L,117445036871L,327989716409L,915985822220L,2558107420307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276721Inst : IEnumerable<long>
{
public static readonly long[] Value=A276721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276721.Bytes);
public long this[int i]=>Value[i];

public static A276721Inst Instance=new A276721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276722
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,674L,2066L,6184L,18587L,56867L,178317L,561319L,1760125L,5489888L,17057701L,52931331L,164466672L,511758485L,1593612234L,4962950389L,15451453190L,48088784307L,149640967002L,465653853729L,1449146745582L,4510183339086L,14037494547193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276722Inst : IEnumerable<long>
{
public static readonly long[] Value=A276722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276722.Bytes);
public long this[int i]=>Value[i];

public static A276722Inst Instance=new A276722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276723
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,3263L,11155L,36810L,120635L,398736L,1340561L,4605989L,15908448L,54826671L,188085307L,642431001L,2188102307L,7446095610L,25366540627L,86531467800L,295449388797L,1009134603216L,3446558809107L,11767813404774L,40167156826109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276723Inst : IEnumerable<long>
{
public static readonly long[] Value=A276723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276723.Bytes);
public long this[int i]=>Value[i];

public static A276723Inst Instance=new A276723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276724
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,4140L,17007L,64077L,231180L,821132L,2918753L,10483154L,38264066L,142423894L,533308705L,1995314365L,7437442700L,27604521795L,102095937121L,376790770192L,1389739254904L,5130664114644L,18964932885093L,70170215134155L,259770146382666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276724Inst : IEnumerable<long>
{
public static readonly long[] Value=A276724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276724.Bytes);
public long this[int i]=>Value[i];

public static A276724Inst Instance=new A276724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276725
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,4140L,21147L,94828L,389946L,1527058L,5846917L,22257299L,85116719L,329147169L,1292371138L,5165744159L,20781403539L,83617668276L,335483033770L,1340729704086L,5338181115652L,21193583922048L,84001778063348L,332811761809618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276725Inst : IEnumerable<long>
{
public static readonly long[] Value=A276725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276725.Bytes);
public long this[int i]=>Value[i];

public static A276725Inst Instance=new A276725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276726
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,4140L,21147L,115975L,562595L,2504665L,10579224L,43453459L,176472854L,716369167L,2927448727L,12099445274L,50734619570L,216264854789L,928045216933L,3986352066095L,17086933963355L,72987960721209L,310631150855373L,1317808552742134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276726Inst : IEnumerable<long>
{
public static readonly long[] Value=A276726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276726.Bytes);
public long this[int i]=>Value[i];

public static A276726Inst Instance=new A276726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276727
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,4L,5L,5L,0L,1L,7L,12L,17L,15L,0L,1L,12L,29L,45L,64L,52L,0L,1L,20L,66L,121L,201L,265L,203L,0L,1L,33L,145L,336L,585L,966L,1197L,877L,0L,1L,54L,315L,901L,1741L,3172L,4971L,5852L,4140L,0L,1L,88L,676L,2347L,5375L,10100L,18223L,27267L,30751L,21147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276727Inst : IEnumerable<long>
{
public static readonly long[] Value=A276727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276727.Bytes);
public long this[int i]=>Value[i];

public static A276727Inst Instance=new A276727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276728
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,336L,5375L,111138L,2845864L,87597223L,3170429794L,132647186513L,6328769607152L,340517379645028L,20469645334387763L,1363935094328964210L,BigInteger.Parse("100052662656438620359"),BigInteger.Parse("8032243625863280744704") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276728Inst Instance=new A276728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276729
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276729Inst : IEnumerable<long>
{
public static readonly long[] Value=A276729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276729.Bytes);
public long this[int i]=>Value[i];

public static A276729Inst Instance=new A276729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276730
{
public static readonly long[] Value={ 2L,3L,7L,7L,11L,7L,15L,19L,23L,39L,31L,39L,31L,43L,47L,39L,59L,71L,67L,71L,79L,79L,83L,79L,79L,103L,103L,107L,103L,127L,127L,131L,159L,139L,135L,151L,135L,163L,167L,199L,179L,199L,191L,207L,199L,199L,211L,223L,227L,199L,207L,239L,271L,251L,255L,263L,295L,271L,295L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276730Inst : IEnumerable<long>
{
public static readonly long[] Value=A276730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276730.Bytes);
public long this[int i]=>Value[i];

public static A276730Inst Instance=new A276730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276731
{
public static readonly long[] Value={ 2L,3L,5L,8L,11L,8L,17L,26L,23L,29L,35L,26L,41L,35L,47L,53L,59L,62L,62L,71L,80L,62L,83L,89L,116L,101L,116L,107L,107L,113L,107L,131L,137L,116L,149L,170L,143L,188L,167L,173L,179L,188L,191L,170L,197L,188L,224L,251L,227L,251L,233L,239L,224L,251L,257L,263L,269L,242L,251L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276731Inst : IEnumerable<long>
{
public static readonly long[] Value=A276731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276731.Bytes);
public long this[int i]=>Value[i];

public static A276731Inst Instance=new A276731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276732
{
public static readonly long[] Value={ 19L,29L,109L,229L,409L,709L,829L,1009L,1069L,1129L,1489L,1669L,1789L,2269L,2389L,2689L,3109L,3169L,3469L,3529L,3889L,4789L,4909L,5209L,5569L,5689L,5869L,6469L,6529L,6829L,8089L,8209L,8269L,8389L,8629L,9109L,9769L,9829L,10909L,12289L,12589L,12829L,12889L,13009L,13669L,13729L,14389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276732Inst : IEnumerable<long>
{
public static readonly long[] Value=A276732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276732.Bytes);
public long this[int i]=>Value[i];

public static A276732Inst Instance=new A276732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276733
{
public static readonly long[] Value={ 341L,1247L,1387L,2047L,2701L,3277L,3683L,4033L,4369L,4681L,5461L,5963L,7957L,8321L,9017L,9211L,10261L,13747L,14351L,14491L,15709L,17593L,18721L,19951L,20191L,23377L,24929L,25351L,29041L,31417L,31609L,31621L,33227L,35333L,37901L,42799L,45761L,46513L,49141L,49601L,49981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276733Inst : IEnumerable<long>
{
public static readonly long[] Value=A276733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276733.Bytes);
public long this[int i]=>Value[i];

public static A276733Inst Instance=new A276733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276734
{
public static readonly long[] Value={ 1L,5L,7L,9L,21L,22L,44L,45L,66L,70L,78L,112L,150L,156L,160L,264L,270L,280L,432L,600L,1080L,1680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276734Inst : IEnumerable<long>
{
public static readonly long[] Value=A276734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276734.Bytes);
public long this[int i]=>Value[i];

public static A276734Inst Instance=new A276734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276735
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,3L,5L,12L,87L,261L,324L,1433L,5881L,37444L,196797L,708901L,2020836L,12375966L,105896734L,955344450L,11136621319L,95274505723L,590283352231L,4285001635230L,36417581252044L,272699023606314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276735Inst : IEnumerable<long>
{
public static readonly long[] Value=A276735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276735.Bytes);
public long this[int i]=>Value[i];

public static A276735Inst Instance=new A276735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276736
{
public static readonly long[] Value={ 1L,2L,5L,11L,7L,10L,9L,13L,2L,14L,13L,55L,15L,18L,7L,57L,19L,4L,21L,77L,15L,26L,25L,65L,38L,30L,58L,99L,31L,14L,33L,15L,65L,38L,9L,11L,39L,42L,25L,91L,43L,30L,45L,13L,14L,50L,49L,95L,66L,76L,95L,165L,55L,116L,91L,117L,35L,62L,61L,77L,63L,66L,18L,247L,21L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276736Inst : IEnumerable<long>
{
public static readonly long[] Value=A276736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276736.Bytes);
public long this[int i]=>Value[i];

public static A276736Inst Instance=new A276736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276737
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,3L,7L,4L,1L,5L,11L,12L,13L,7L,3L,16L,17L,1L,19L,20L,7L,11L,23L,12L,25L,13L,27L,28L,29L,3L,31L,4L,33L,17L,5L,2L,37L,19L,13L,20L,41L,7L,43L,4L,5L,23L,47L,16L,49L,25L,51L,52L,53L,27L,55L,28L,19L,29L,59L,12L,61L,31L,7L,64L,13L,33L,67L,68L,69L,5L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276737Inst : IEnumerable<long>
{
public static readonly long[] Value=A276737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276737.Bytes);
public long this[int i]=>Value[i];

public static A276737Inst Instance=new A276737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276738
{
public static readonly long[] Value={ -1L,-1L,5L,-1L,12L,-32L,-1L,14L,7L,-126L,231L,-1L,16L,16L,-160L,-160L,1280L,-1792L,-1L,18L,18L,-198L,9L,-396L,1716L,-66L,2574L,-12870L,14586L,-1L,20L,20L,-240L,20L,-480L,2240L,-240L,-240L,6720L,-17920L,2240L,-35840L,129024L,-122880L,-1L,22L,22L,-286L,22L,-572L,2860L,11L,-572L,-286L,8580L,-24310L,-286L,4290L,8580L,-97240L,184756L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276738Inst : IEnumerable<long>
{
public static readonly long[] Value=A276738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276738.Bytes);
public long this[int i]=>Value[i];

public static A276738Inst Instance=new A276738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276739
{
public static readonly long[] Value={ 1L,19L,10699L,102589L,10000112389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276739Inst : IEnumerable<long>
{
public static readonly long[] Value=A276739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276739.Bytes);
public long this[int i]=>Value[i];

public static A276739Inst Instance=new A276739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276740
{
public static readonly long[] Value={ 1L,2L,4L,76L,418L,1102L,4687L,7637L,139183L,2543923L,1614895738L,9083990938L,23149317409L,497240757797L,4447730232523L,16000967516764L,65262766108619L,141644055557882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276740Inst : IEnumerable<long>
{
public static readonly long[] Value=A276740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276740.Bytes);
public long this[int i]=>Value[i];

public static A276740Inst Instance=new A276740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276741
{
public static readonly long[] Value={ 0L,1L,7L,31L,37L,71L,235L,515L,1199L,1815L,6587L,30429L,35589L,42147L,58571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276741Inst : IEnumerable<long>
{
public static readonly long[] Value=A276741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276741.Bytes);
public long this[int i]=>Value[i];

public static A276741Inst Instance=new A276741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276742
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,9L,76L,980L,17304L,393463L,11072376L,375015501L,14973327740L,693507063942L,36782159095080L,2210369895001450L,149163550608705780L,11218246110724502325UL,BigInteger.Parse("934089674706365890832"),BigInteger.Parse("85613718583699681233208"),BigInteger.Parse("8593417105404547807210554"),BigInteger.Parse("940306481313403267058365853"),BigInteger.Parse("111703159299047925885976523740"),BigInteger.Parse("14352698749278209896668891217608"),BigInteger.Parse("1987913848425789150258188910598408"),BigInteger.Parse("295873533681557805541331625248339120") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276742Inst Instance=new A276742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276743
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,63L,447L,4286L,56185L,1008317L,24917676L,849963761L,40142633815L,2633061525012L,240207555735097L,30578843349537575L,5434894746337720676L,BigInteger.Parse("1352812180415380719387"),BigInteger.Parse("471689727423751377883607"),BigInteger.Parse("230943183470327388401886858"),BigInteger.Parse("158839247095790148049487792081"),BigInteger.Parse("153694547774391577758847456894905") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276743Inst Instance=new A276743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276744
{
public static readonly BigInteger[] Value={ 1L,-2L,13L,-248L,12526L,-1568368L,466802541L,-321051272000L,500039245711658L,-1737306124802148608L,BigInteger.Parse("13308275973878544047746"),BigInteger.Parse("-222688458529322994469714944"),BigInteger.Parse("8077969377058605224894763722940"),BigInteger.Parse("-631225844487016628864332741755017216"),BigInteger.Parse("105685667980009079816649620724931814050429") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276744Inst Instance=new A276744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276745
{
public static readonly BigInteger[] Value={ 1L,-3L,28L,-707L,44576L,-6695766L,2324916672L,-1827405843363L,3201960457239040L,BigInteger.Parse("-12360766887879809858"),BigInteger.Parse("104155804285010077051904"),BigInteger.Parse("-1901288103716422362163490318"),BigInteger.Parse("74716157012390526276910403768320"),BigInteger.Parse("-6287554722733254962685763077329845772"),BigInteger.Parse("1127914878748595440161120152354758317867008") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276745Inst Instance=new A276745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276746
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,11L,59L,439L,4472L,62935L,1209430L,32051191L,1166861194L,58721422238L,4088067759572L,394939948283555L,53103347018217191L,9947926726521152127UL,BigInteger.Parse("2605793744856238449900"),BigInteger.Parse("954325686563453398851948"),BigInteger.Parse("490307345827423220333318823"),BigInteger.Parse("353233139353798743949103145806"),BigInteger.Parse("357764578484543977966398255436596"),BigInteger.Parse("509302875450935550273793437784438990"),BigInteger.Parse("1020636223630190179625684042390508142277") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276746Inst Instance=new A276746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276747
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,14L,96L,989L,14264L,293081L,8291372L,326486284L,17606371379L,1311003529532L,133789640100606L,18842361596022104L,3651812223033372781L,BigInteger.Parse("979595054829206809506"),BigInteger.Parse("363619011980801177687068"),BigInteger.Parse("187594865162514096249150130"),BigInteger.Parse("134684579087971548803896902904"),BigInteger.Parse("134956937109764143572996094860839"),BigInteger.Parse("189135846049140695927044178145555683"),BigInteger.Parse("371258683769470709816610430835777163052") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276747Inst Instance=new A276747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276748
{
public static readonly BigInteger[] Value={ 1L,1L,3L,6L,20L,31L,278L,337L,17412L,24798L,6772374L,6838020L,11484638201L,11505059694L,80455953355044L,80659880546429L,2306084675313241000L,2306326405122809872L,BigInteger.Parse("268657126294137376567236"),BigInteger.Parse("268664044710902946519968"),BigInteger.Parse("126765866019584067600135507174"),BigInteger.Parse("126766706181193131138562011916"),BigInteger.Parse("241678197716027150352300025709078423"),BigInteger.Parse("241678578014230878979840920532089312"),BigInteger.Parse("1858396158247302094721803368957703312268486"),BigInteger.Parse("1858396883282148773045801834086535278817434") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276748Inst Instance=new A276748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276749
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,749L,349707L,6584568222L,2542670826073083L,BigInteger.Parse("87482825374559636232439"),BigInteger.Parse("1084004198573118046271860417698544"),BigInteger.Parse("947790766920144318254338856937912501990845477"),BigInteger.Parse("546110521982991331256716555878135043551458467258822092049841"),BigInteger.Parse("1013482348116310649878997474896504367633097553028647215670516799670576593506574") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276749Inst Instance=new A276749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276750
{
public static readonly BigInteger[] Value={ 1L,5L,22L,117L,821L,7796L,101417L,1810093L,44561794L,1515368605L,71428667861L,4677209119632L,426268582440013L,54220470799325101L,9632796180856419722UL,BigInteger.Parse("2397253932245127919389"),BigInteger.Parse("835827069207839232602401"),BigInteger.Parse("409329501365419311969616628"),BigInteger.Parse("281600921299273941316256813501"),BigInteger.Parse("272632759803890415543364253988037"),BigInteger.Parse("371636574592049013061911521355729422"),BigInteger.Parse("713832787857018847209335427225631327093") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276750Inst Instance=new A276750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276751
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,111L,1813L,57846L,3941129L,515554887L,139563384274L,73929755773659L,78682910542834037L,BigInteger.Parse("169524995438153307498"),BigInteger.Parse("712160156293232925362965"),BigInteger.Parse("6241130803695426404771763891"),BigInteger.Parse("104223975880844169453617144998346"),BigInteger.Parse("3697419824526049703366356719095712903"),BigInteger.Parse("247087719554207540966918934263865223952113"),BigInteger.Parse("35252698554630762784745670915756020139337705854"),BigInteger.Parse("9472029798481852471047526788494040155248502738148149") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276751Inst Instance=new A276751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276752
{
public static readonly BigInteger[] Value={ 1L,1L,5L,30L,327L,7085L,307280L,28472653L,5000661017L,1886425568702L,1331753751874235L,2008313162512681569L,BigInteger.Parse("5765904212733638946976"),BigInteger.Parse("34525801618218187545094977"),BigInteger.Parse("406111805399407205212602871837"),BigInteger.Parse("9635669704681654899673855841540822"),BigInteger.Parse("464496624513770925349468939192278531231"),BigInteger.Parse("43718131231809168093455159164707384418710045"),BigInteger.Parse("8598321846236415035740539472279473819390935625008") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276752Inst Instance=new A276752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276753
{
public static readonly BigInteger[] Value={ 1L,5L,34L,381L,8401L,334688L,27151993L,4091831133L,1251353635162L,737891198902325L,864695662715974585L,BigInteger.Parse("2033353960345783330704"),BigInteger.Parse("9255876152303901497918425"),BigInteger.Parse("87365856252845525476020365429"),BigInteger.Parse("1563265999862817889675899566032954"),BigInteger.Parse("59157049408983740505063226640565220029"),BigInteger.Parse("4200428372739940183291465697348398947046393"),BigInteger.Parse("634544126271277747190512917479290795324884131840") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276753Inst Instance=new A276753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276754
{
public static readonly BigInteger[] Value={ 1L,9L,76L,1157L,33291L,1792296L,196919213L,39766253741L,16931726147956L,13298466280839329L,BigInteger.Parse("22076711237844558263"),BigInteger.Parse("69166686377284889199104"),BigInteger.Parse("448760359479425463648647769"),BigInteger.Parse("5685081590883001302122022078913"),BigInteger.Parse("144528951819771627855280850227089996"),BigInteger.Parse("7431791795502279858136165452572662669213"),BigInteger.Parse("743200333842768450767851829731370148558347843"),BigInteger.Parse("154769006272445896954868694741314742556915451805336") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276754Inst Instance=new A276754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276755
{
public static readonly BigInteger[] Value={ 1L,1L,5L,65L,1625L,66625L,4330625L,489360625L,110106140625L,52961053640625L,54285079981640625L,BigInteger.Parse("114704374001206640625"),BigInteger.Parse("484625980155098056640625"),BigInteger.Parse("4032572780870570929306640625") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276755Inst Instance=new A276755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276756
{
public static readonly long[] Value={ 1L,21L,30L,979L,1411L,1463L,1547L,1742L,1947L,2059L,2090L,2210L,2318L,2405L,2419L,2491L,2703L,2886L,2945L,3182L,3243L,3534L,3567L,16102L,17654L,20559L,21243L,25543L,25705L,27145L,27307L,27805L,28045L,29323L,29370L,29631L,30485L,30846L,32574L,33366L,33465L,33654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276756Inst : IEnumerable<long>
{
public static readonly long[] Value=A276756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276756.Bytes);
public long this[int i]=>Value[i];

public static A276756Inst Instance=new A276756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276757
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276757Inst : IEnumerable<long>
{
public static readonly long[] Value=A276757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276757.Bytes);
public long this[int i]=>Value[i];

public static A276757Inst Instance=new A276757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276758
{
public static readonly long[] Value={ 10L,1010L,1100L,1119L,1339L,1519L,3139L,5119L,8899L,27799L,46699L,48499L,50559L,55059L,64699L,72799L,84499L,100110L,101010L,101100L,110010L,110100L,111000L,111229L,112129L,117799L,121129L,136699L,147499L,163699L,168199L,171799L,174499L,177199L,186199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276758Inst : IEnumerable<long>
{
public static readonly long[] Value=A276758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276758.Bytes);
public long this[int i]=>Value[i];

public static A276758Inst Instance=new A276758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276759
{
public static readonly long[] Value={ 1L,5L,3L,3L,9L,1L,3L,3L,1L,9L,7L,9L,3L,5L,7L,4L,5L,0L,7L,9L,1L,9L,7L,4L,1L,0L,8L,2L,0L,7L,2L,7L,3L,3L,7L,7L,9L,7L,8L,5L,2L,9L,8L,6L,1L,0L,6L,5L,0L,7L,6L,6L,6L,7L,1L,7L,3L,3L,0L,7L,6L,0L,0L,5L,6L,8L,9L,4L,4L,9L,0L,8L,1L,1L,0L,0L,4L,3L,9L,2L,4L,4L,9L,9L,0L,6L,1L,0L,5L,6L,5L,5L,3L,4L,6L,3L,7L,0L,9L,6L,2L,0L,7L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276759Inst : IEnumerable<long>
{
public static readonly long[] Value=A276759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276759.Bytes);
public long this[int i]=>Value[i];

public static A276759Inst Instance=new A276759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276760
{
public static readonly long[] Value={ 4L,3L,7L,5L,1L,8L,5L,1L,5L,3L,0L,6L,1L,8L,9L,8L,3L,8L,5L,4L,7L,0L,9L,0L,6L,5L,6L,4L,8L,5L,2L,5L,8L,4L,2L,9L,1L,6L,2L,3L,8L,2L,3L,1L,1L,4L,6L,7L,7L,0L,1L,1L,8L,6L,4L,9L,6L,1L,0L,4L,4L,4L,9L,1L,8L,0L,3L,7L,2L,1L,5L,6L,3L,0L,8L,9L,3L,4L,7L,2L,8L,1L,7L,5L,9L,8L,8L,1L,8L,2L,3L,9L,9L,0L,9L,5L,9L,5L,1L,4L,1L,7L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276760Inst : IEnumerable<long>
{
public static readonly long[] Value=A276760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276760.Bytes);
public long this[int i]=>Value[i];

public static A276760Inst Instance=new A276760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276761
{
public static readonly long[] Value={ 4L,6L,3L,6L,2L,8L,4L,6L,3L,2L,7L,8L,6L,6L,2L,5L,1L,8L,9L,5L,4L,4L,9L,5L,2L,3L,1L,8L,0L,3L,4L,2L,0L,5L,3L,8L,7L,0L,4L,4L,6L,9L,9L,3L,5L,5L,6L,7L,7L,5L,7L,5L,2L,5L,2L,9L,6L,3L,9L,3L,5L,1L,0L,1L,9L,3L,0L,2L,5L,4L,4L,9L,3L,1L,0L,4L,5L,0L,9L,4L,5L,2L,4L,9L,4L,6L,6L,2L,2L,6L,1L,9L,3L,7L,3L,2L,8L,7L,8L,3L,9L,2L,7L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276761Inst : IEnumerable<long>
{
public static readonly long[] Value=A276761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276761.Bytes);
public long this[int i]=>Value[i];

public static A276761Inst Instance=new A276761Inst();

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