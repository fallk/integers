using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197457
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,10L,10L,3L,5L,23L,31L,23L,5L,8L,57L,84L,84L,57L,8L,13L,122L,290L,583L,290L,122L,13L,21L,275L,923L,2233L,2233L,923L,275L,21L,34L,623L,2887L,10758L,15825L,10758L,2887L,623L,34L,55L,1394L,9216L,53337L,104318L,104318L,53337L,9216L,1394L,55L,89L,3133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197457Inst : IEnumerable<long>
{
public static readonly long[] Value=A197457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197457.Bytes);
public long this[int i]=>Value[i];

public static A197457Inst Instance=new A197457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197458
{
public static readonly BigInteger[] Value={ 1L,2L,16L,265L,7343L,304186L,17525812L,1336221251L,129980132305L,15686404067098L,2297230134084416L,400977650310256537L,BigInteger.Parse("82188611938415464231"),BigInteger.Parse("19536244019455339261970"),BigInteger.Parse("5328019975275896220786388"),BigInteger.Parse("1651867356348327784988233291"),BigInteger.Parse("577522171260292028520919811777") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197458Inst Instance=new A197458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197459
{
public static readonly long[] Value={ 1L,1L,3L,4L,12L,27L,78L,208L,635L,1859L,5726L,17526L,54620L,170479L,536714L,1694567L,5376764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197459Inst : IEnumerable<long>
{
public static readonly long[] Value=A197459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197459.Bytes);
public long this[int i]=>Value[i];

public static A197459Inst Instance=new A197459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197460
{
public static readonly long[] Value={ 1L,1L,4L,6L,19L,49L,143L,403L,1235L,3681L,11354L,34944L,108956L,340635L,1072593L,3388161L,10751029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197460Inst : IEnumerable<long>
{
public static readonly long[] Value=A197460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197460.Bytes);
public long this[int i]=>Value[i];

public static A197460Inst Instance=new A197460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197461
{
public static readonly long[] Value={ 3L,6L,14L,36L,99L,281L,816L,2415L,7260L,22074L,67743L,209552L,652566L,2043672L,6431715L,20328504L,64494678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197461Inst : IEnumerable<long>
{
public static readonly long[] Value=A197461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197461.Bytes);
public long this[int i]=>Value[i];

public static A197461Inst Instance=new A197461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197462
{
public static readonly long[] Value={ 1L,3L,3L,9L,14L,38L,74L,185L,414L,1026L,2440L,6077L,14926L,37454L,93749L,237035L,599815L,1526020L,3889117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197462Inst : IEnumerable<long>
{
public static readonly long[] Value=A197462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197462.Bytes);
public long this[int i]=>Value[i];

public static A197462Inst Instance=new A197462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197463
{
public static readonly long[] Value={ 2L,3L,6L,13L,28L,66L,148L,349L,828L,2005L,4880L,12043L,29852L,74645L,187498L,473448L,1199630L,3050554L,7778234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197463Inst : IEnumerable<long>
{
public static readonly long[] Value=A197463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197463.Bytes);
public long this[int i]=>Value[i];

public static A197463Inst Instance=new A197463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197464
{
public static readonly long[] Value={ 12L,18L,36L,75L,168L,386L,888L,2079L,4960L,11988L,29280L,72145L,179112L,447636L,1124956L,2840097L,7197780L,18301738L,46669404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197464Inst : IEnumerable<long>
{
public static readonly long[] Value=A197464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197464.Bytes);
public long this[int i]=>Value[i];

public static A197464Inst Instance=new A197464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197465
{
public static readonly long[] Value={ 1L,2L,2L,6L,8L,22L,42L,112L,252L,650L,1584L,4091L,10369L,26938L,69651L,182116L,476272L,1253067L,3302187L,8733551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197465Inst : IEnumerable<long>
{
public static readonly long[] Value=A197465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197465.Bytes);
public long this[int i]=>Value[i];

public static A197465Inst Instance=new A197465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197466
{
public static readonly long[] Value={ 1L,2L,3L,8L,14L,36L,80L,206L,494L,1259L,3144L,8085L,20676L,53635L,139144L,363630L,952148L,2504626L,6603367L,17463287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197466Inst : IEnumerable<long>
{
public static readonly long[] Value=A197466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197466.Bytes);
public long this[int i]=>Value[i];

public static A197466Inst Instance=new A197466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197467
{
public static readonly long[] Value={ 4L,6L,12L,25L,56L,132L,320L,792L,1976L,4962L,12576L,32140L,82704L,214044L,556576L,1453210L,3808592L,10015134L,26413468L,69844263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197467Inst : IEnumerable<long>
{
public static readonly long[] Value=A197467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197467.Bytes);
public long this[int i]=>Value[i];

public static A197467Inst Instance=new A197467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197468
{
public static readonly long[] Value={ 1L,2L,26L,184L,5408L,165200L,16544206L,2117012786L,779857304215L,396015611721478L,546971557228648382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197468Inst : IEnumerable<long>
{
public static readonly long[] Value=A197468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197468.Bytes);
public long this[int i]=>Value[i];

public static A197468Inst Instance=new A197468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197469
{
public static readonly long[] Value={ 1L,2L,6L,12L,24L,50L,98L,194L,394L,786L,1562L,3138L,6282L,12530L,25082L,50210L,100330L,200658L,401498L,802818L,1605450L,3211442L,6422714L,12844514L,25690282L,51381138L,102759194L,205520322L,411044874L,822081650L,1644162938L,3288342434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197469Inst : IEnumerable<long>
{
public static readonly long[] Value=A197469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197469.Bytes);
public long this[int i]=>Value[i];

public static A197469Inst Instance=new A197469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197470
{
public static readonly long[] Value={ 3L,6L,26L,46L,181L,374L,1300L,2886L,9446L,22060L,69096L,167466L,507600L,1265434L,3741192L,9529514L,27644128L,71580304L,204668940L,536641128L,1517618972L,4017418484L,11266355518L,30042504088L,83713614532L,224474050480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197470Inst : IEnumerable<long>
{
public static readonly long[] Value=A197470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197470.Bytes);
public long this[int i]=>Value[i];

public static A197470Inst Instance=new A197470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197471
{
public static readonly long[] Value={ 1L,12L,46L,184L,748L,2824L,10934L,42474L,164782L,638460L,2473902L,9589038L,37167908L,144059050L,558354234L,2164121964L,8387927204L,32510787510L,126008566828L,488396574430L,1892976376006L,7336987712088L,28437432700816L,110220652223106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197471Inst : IEnumerable<long>
{
public static readonly long[] Value=A197471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197471.Bytes);
public long this[int i]=>Value[i];

public static A197471Inst Instance=new A197471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197472
{
public static readonly long[] Value={ 4L,24L,181L,748L,5408L,22672L,151748L,684002L,4368923L,20344854L,126020110L,603916958L,3643523708L,17866994674L,105586791488L,527450827498L,3064686007756L,15542757419162L,89084044386061L,457335065118848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197472Inst : IEnumerable<long>
{
public static readonly long[] Value=A197472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197472.Bytes);
public long this[int i]=>Value[i];

public static A197472Inst Instance=new A197472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197473
{
public static readonly long[] Value={ 4L,50L,374L,2824L,22672L,165200L,1265828L,9507212L,72145488L,544829612L,4121917612L,31166838320L,235726500646L,1782712177744L,13482608699280L,101968288116918L,771180418816752L,5832406885650952L,44110365514811080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197473Inst : IEnumerable<long>
{
public static readonly long[] Value=A197473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197473.Bytes);
public long this[int i]=>Value[i];

public static A197473Inst Instance=new A197473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197474
{
public static readonly long[] Value={ 5L,98L,1300L,10934L,151748L,1265828L,16544206L,145244408L,1830370547L,16537658774L,202870487557L,1878224690406L,22527034080238L,212875475502774L,2505004507267645L,24087191716817350L,278905922435987885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197474Inst : IEnumerable<long>
{
public static readonly long[] Value=A197474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197474.Bytes);
public long this[int i]=>Value[i];

public static A197474Inst Instance=new A197474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197475
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,3L,1L,6L,6L,1L,4L,12L,26L,12L,4L,4L,24L,46L,46L,24L,4L,5L,50L,181L,184L,181L,50L,5L,8L,98L,374L,748L,748L,374L,98L,8L,9L,194L,1300L,2824L,5408L,2824L,1300L,194L,9L,13L,394L,2886L,10934L,22672L,22672L,10934L,2886L,394L,13L,17L,786L,9446L,42474L,151748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197475Inst : IEnumerable<long>
{
public static readonly long[] Value=A197475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197475.Bytes);
public long this[int i]=>Value[i];

public static A197475Inst Instance=new A197475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197476
{
public static readonly long[] Value={ 1L,1L,3L,7L,7L,4L,3L,9L,3L,2L,9L,0L,5L,4L,5L,5L,5L,5L,7L,7L,8L,9L,4L,4L,9L,8L,6L,0L,0L,5L,5L,0L,0L,8L,3L,4L,9L,5L,8L,4L,8L,0L,4L,2L,9L,0L,3L,4L,9L,5L,7L,5L,2L,7L,2L,0L,1L,5L,1L,8L,2L,5L,2L,6L,7L,3L,6L,0L,9L,8L,3L,4L,7L,3L,4L,7L,2L,7L,2L,1L,7L,7L,9L,8L,8L,0L,3L,2L,8L,0L,5L,1L,7L,6L,4L,4L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197476Inst : IEnumerable<long>
{
public static readonly long[] Value=A197476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197476.Bytes);
public long this[int i]=>Value[i];

public static A197476Inst Instance=new A197476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197477
{
public static readonly long[] Value={ 8L,4L,1L,8L,3L,5L,5L,3L,5L,6L,1L,4L,3L,6L,3L,8L,0L,7L,4L,8L,5L,7L,3L,2L,6L,7L,6L,5L,6L,2L,1L,6L,4L,3L,0L,7L,6L,5L,3L,5L,8L,5L,7L,8L,5L,5L,3L,3L,9L,3L,6L,3L,3L,0L,6L,4L,3L,9L,5L,3L,0L,8L,4L,2L,8L,3L,1L,2L,0L,2L,8L,3L,2L,1L,4L,7L,6L,8L,9L,1L,4L,5L,1L,4L,8L,3L,3L,7L,8L,4L,4L,7L,7L,7L,4L,5L,5L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197477Inst : IEnumerable<long>
{
public static readonly long[] Value=A197477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197477.Bytes);
public long this[int i]=>Value[i];

public static A197477Inst Instance=new A197477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197478
{
public static readonly long[] Value={ 6L,6L,5L,3L,7L,5L,3L,1L,9L,8L,2L,0L,6L,9L,4L,5L,9L,9L,9L,4L,1L,0L,9L,7L,6L,2L,4L,1L,4L,1L,6L,9L,7L,3L,2L,1L,2L,9L,4L,4L,4L,0L,0L,4L,9L,3L,7L,5L,9L,6L,0L,2L,5L,5L,6L,0L,6L,2L,0L,9L,0L,9L,6L,7L,4L,4L,0L,1L,3L,1L,7L,1L,1L,4L,8L,5L,3L,7L,9L,5L,5L,8L,6L,5L,1L,2L,8L,2L,4L,6L,6L,5L,1L,3L,5L,5L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197478Inst : IEnumerable<long>
{
public static readonly long[] Value=A197478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197478.Bytes);
public long this[int i]=>Value[i];

public static A197478Inst Instance=new A197478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197479
{
public static readonly long[] Value={ 6L,8L,1L,0L,8L,9L,8L,1L,8L,2L,4L,2L,8L,7L,4L,0L,0L,6L,1L,8L,5L,0L,5L,2L,8L,1L,6L,3L,2L,7L,8L,2L,8L,5L,2L,4L,9L,2L,5L,1L,8L,5L,8L,5L,6L,2L,5L,7L,5L,2L,2L,5L,5L,9L,6L,2L,2L,9L,7L,5L,8L,1L,5L,4L,8L,1L,2L,3L,5L,4L,3L,9L,3L,2L,9L,2L,9L,2L,8L,1L,4L,2L,2L,6L,5L,5L,2L,2L,7L,3L,7L,8L,6L,5L,8L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197479Inst : IEnumerable<long>
{
public static readonly long[] Value=A197479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197479.Bytes);
public long this[int i]=>Value[i];

public static A197479Inst Instance=new A197479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197480
{
public static readonly long[] Value={ 5L,6L,8L,8L,7L,1L,9L,6L,6L,4L,5L,2L,7L,2L,7L,7L,7L,8L,8L,9L,4L,7L,2L,4L,9L,3L,0L,0L,2L,7L,5L,0L,4L,1L,7L,4L,7L,9L,2L,4L,0L,2L,1L,4L,5L,1L,7L,4L,7L,8L,7L,6L,3L,6L,0L,0L,7L,5L,9L,1L,2L,6L,3L,3L,6L,8L,0L,4L,9L,1L,7L,3L,6L,7L,3L,6L,3L,6L,0L,8L,8L,9L,9L,4L,0L,1L,6L,4L,0L,2L,5L,8L,8L,2L,2L,3L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197480Inst : IEnumerable<long>
{
public static readonly long[] Value=A197480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197480.Bytes);
public long this[int i]=>Value[i];

public static A197480Inst Instance=new A197480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197481
{
public static readonly long[] Value={ 3L,7L,9L,2L,4L,7L,9L,7L,7L,6L,3L,5L,1L,5L,1L,8L,5L,2L,5L,9L,6L,4L,8L,3L,2L,8L,6L,6L,8L,5L,0L,0L,2L,7L,8L,3L,1L,9L,4L,9L,3L,4L,7L,6L,3L,4L,4L,9L,8L,5L,8L,4L,2L,4L,0L,0L,5L,0L,6L,0L,8L,4L,2L,2L,4L,5L,3L,6L,6L,1L,1L,5L,7L,8L,2L,4L,2L,4L,0L,5L,9L,3L,2L,9L,3L,4L,4L,2L,6L,8L,3L,9L,2L,1L,4L,9L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197481Inst : IEnumerable<long>
{
public static readonly long[] Value=A197481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197481.Bytes);
public long this[int i]=>Value[i];

public static A197481Inst Instance=new A197481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197482
{
public static readonly long[] Value={ 1L,8L,4L,3L,7L,6L,8L,1L,7L,6L,0L,3L,1L,7L,2L,1L,5L,6L,9L,6L,3L,9L,9L,3L,8L,4L,9L,7L,7L,2L,3L,6L,2L,1L,2L,7L,3L,1L,4L,5L,9L,9L,1L,3L,5L,1L,6L,5L,3L,9L,9L,3L,0L,9L,3L,2L,5L,4L,2L,7L,2L,3L,0L,7L,6L,3L,8L,2L,4L,4L,1L,3L,0L,1L,5L,3L,3L,2L,5L,3L,8L,9L,7L,4L,9L,9L,4L,1L,8L,9L,9L,1L,0L,2L,9L,9L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197482Inst : IEnumerable<long>
{
public static readonly long[] Value=A197482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197482.Bytes);
public long this[int i]=>Value[i];

public static A197482Inst Instance=new A197482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197483
{
public static readonly long[] Value={ 4L,8L,2L,3L,9L,5L,0L,9L,8L,8L,1L,1L,1L,2L,6L,5L,7L,7L,2L,3L,0L,9L,1L,1L,3L,9L,5L,0L,2L,4L,5L,6L,5L,4L,4L,2L,8L,4L,2L,0L,7L,8L,7L,1L,4L,4L,9L,5L,2L,9L,7L,2L,8L,3L,0L,9L,9L,1L,3L,5L,2L,3L,9L,6L,5L,1L,4L,0L,9L,1L,0L,6L,5L,4L,5L,6L,0L,9L,7L,1L,3L,1L,6L,8L,1L,7L,2L,4L,8L,9L,8L,7L,7L,6L,9L,3L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197483Inst : IEnumerable<long>
{
public static readonly long[] Value=A197483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197483.Bytes);
public long this[int i]=>Value[i];

public static A197483Inst Instance=new A197483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197484
{
public static readonly long[] Value={ 1L,1L,7L,93L,2584L,141328L,17631774L,4677852344L,2704563311389L,3400269169904466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197484Inst : IEnumerable<long>
{
public static readonly long[] Value=A197484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197484.Bytes);
public long this[int i]=>Value[i];

public static A197484Inst Instance=new A197484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197485
{
public static readonly long[] Value={ 3L,4L,0L,5L,4L,4L,9L,0L,9L,1L,2L,1L,4L,3L,7L,0L,0L,3L,0L,9L,2L,5L,2L,6L,4L,0L,8L,1L,6L,3L,9L,1L,4L,2L,6L,2L,4L,6L,2L,5L,9L,2L,9L,2L,8L,1L,2L,8L,7L,6L,1L,2L,7L,9L,8L,1L,1L,4L,8L,7L,9L,0L,7L,7L,4L,0L,6L,1L,7L,7L,1L,9L,6L,6L,4L,6L,4L,6L,4L,0L,7L,1L,1L,3L,2L,7L,6L,1L,3L,6L,8L,9L,3L,2L,9L,1L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197485Inst : IEnumerable<long>
{
public static readonly long[] Value=A197485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197485.Bytes);
public long this[int i]=>Value[i];

public static A197485Inst Instance=new A197485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197486
{
public static readonly long[] Value={ 2L,8L,4L,4L,3L,5L,9L,8L,3L,2L,2L,6L,3L,6L,3L,8L,8L,9L,4L,4L,7L,3L,6L,2L,4L,6L,5L,0L,1L,3L,7L,5L,2L,0L,8L,7L,3L,9L,6L,2L,0L,1L,0L,7L,2L,5L,8L,7L,3L,9L,3L,8L,1L,8L,0L,0L,3L,7L,9L,5L,6L,3L,1L,6L,8L,4L,0L,2L,4L,5L,8L,6L,8L,3L,6L,8L,1L,8L,0L,4L,4L,4L,9L,7L,0L,0L,8L,2L,0L,1L,2L,9L,4L,1L,1L,1L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197486Inst : IEnumerable<long>
{
public static readonly long[] Value=A197486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197486.Bytes);
public long this[int i]=>Value[i];

public static A197486Inst Instance=new A197486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197487
{
public static readonly long[] Value={ 2L,50L,12792L,30844560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197487Inst : IEnumerable<long>
{
public static readonly long[] Value=A197487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197487.Bytes);
public long this[int i]=>Value[i];

public static A197487Inst Instance=new A197487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197488
{
public static readonly long[] Value={ 9L,2L,1L,8L,8L,4L,0L,8L,8L,0L,1L,5L,8L,6L,0L,7L,8L,4L,8L,1L,9L,9L,6L,9L,2L,4L,8L,8L,6L,1L,8L,1L,0L,6L,3L,6L,5L,7L,2L,9L,9L,5L,6L,7L,5L,8L,2L,6L,9L,9L,6L,5L,4L,6L,6L,2L,7L,1L,3L,6L,1L,5L,3L,8L,1L,9L,1L,2L,2L,0L,6L,5L,0L,7L,6L,6L,6L,2L,6L,9L,4L,8L,7L,4L,9L,7L,0L,9L,4L,9L,5L,5L,1L,4L,9L,9L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197488Inst : IEnumerable<long>
{
public static readonly long[] Value=A197488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197488.Bytes);
public long this[int i]=>Value[i];

public static A197488Inst Instance=new A197488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197489
{
public static readonly long[] Value={ 2L,4L,1L,1L,9L,7L,5L,4L,9L,4L,0L,5L,5L,6L,3L,2L,8L,8L,6L,1L,5L,4L,5L,5L,6L,9L,7L,5L,1L,2L,2L,8L,2L,7L,2L,1L,4L,2L,1L,0L,3L,9L,3L,5L,7L,2L,4L,7L,6L,4L,8L,6L,4L,1L,5L,4L,9L,5L,6L,7L,6L,1L,9L,8L,2L,5L,7L,0L,4L,5L,5L,3L,2L,7L,2L,8L,0L,4L,8L,5L,6L,5L,8L,4L,0L,8L,6L,2L,4L,4L,9L,3L,8L,8L,4L,6L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197489Inst : IEnumerable<long>
{
public static readonly long[] Value=A197489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197489.Bytes);
public long this[int i]=>Value[i];

public static A197489Inst Instance=new A197489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197490
{
public static readonly long[] Value={ 5L,6L,4L,4L,2L,5L,4L,7L,6L,0L,6L,2L,6L,5L,9L,0L,9L,9L,3L,8L,4L,0L,0L,3L,2L,2L,8L,9L,3L,7L,7L,8L,8L,2L,9L,7L,6L,7L,7L,4L,9L,8L,5L,5L,2L,8L,2L,2L,8L,6L,1L,8L,0L,6L,1L,3L,5L,9L,1L,0L,5L,4L,9L,2L,1L,7L,4L,1L,1L,0L,3L,1L,7L,3L,3L,4L,6L,2L,5L,7L,9L,7L,5L,7L,0L,3L,5L,6L,1L,7L,0L,5L,0L,5L,5L,0L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197490Inst : IEnumerable<long>
{
public static readonly long[] Value=A197490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197490.Bytes);
public long this[int i]=>Value[i];

public static A197490Inst Instance=new A197490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197491
{
public static readonly long[] Value={ 5L,7L,8L,5L,4L,8L,9L,2L,5L,4L,2L,5L,7L,1L,8L,3L,8L,3L,2L,0L,4L,0L,7L,3L,6L,7L,3L,2L,4L,8L,8L,0L,2L,1L,1L,8L,2L,8L,6L,8L,1L,7L,0L,1L,7L,9L,2L,0L,6L,9L,1L,2L,1L,4L,6L,3L,7L,8L,2L,7L,3L,3L,1L,7L,8L,5L,0L,1L,2L,8L,6L,9L,6L,2L,4L,5L,6L,6L,9L,4L,3L,2L,0L,2L,7L,2L,4L,1L,7L,9L,2L,6L,8L,1L,8L,2L,6L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197491Inst : IEnumerable<long>
{
public static readonly long[] Value=A197491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197491.Bytes);
public long this[int i]=>Value[i];

public static A197491Inst Instance=new A197491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197492
{
public static readonly long[] Value={ 8L,1L,1L,4L,9L,3L,3L,2L,1L,5L,0L,2L,4L,9L,6L,4L,3L,0L,2L,3L,2L,1L,6L,9L,5L,5L,4L,1L,1L,6L,6L,1L,3L,8L,1L,0L,6L,4L,0L,0L,1L,9L,8L,7L,8L,3L,2L,4L,0L,9L,3L,7L,5L,1L,0L,6L,4L,1L,4L,0L,8L,0L,6L,9L,3L,2L,9L,2L,5L,7L,1L,3L,8L,8L,9L,0L,4L,4L,0L,1L,6L,0L,0L,9L,7L,1L,1L,4L,4L,6L,6L,4L,0L,1L,1L,5L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197492Inst : IEnumerable<long>
{
public static readonly long[] Value=A197492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197492.Bytes);
public long this[int i]=>Value[i];

public static A197492Inst Instance=new A197492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197493
{
public static readonly long[] Value={ 1L,3L,2L,6L,9L,8L,0L,0L,9L,2L,1L,1L,3L,2L,7L,4L,6L,4L,1L,5L,7L,9L,6L,7L,2L,3L,3L,3L,8L,3L,0L,3L,8L,0L,4L,2L,6L,6L,4L,3L,0L,0L,6L,5L,5L,9L,2L,9L,1L,7L,3L,6L,1L,2L,0L,1L,8L,7L,8L,5L,5L,7L,7L,6L,3L,4L,2L,1L,8L,6L,5L,6L,9L,5L,8L,4L,3L,8L,9L,3L,8L,4L,7L,3L,2L,9L,4L,3L,5L,3L,6L,8L,0L,5L,2L,7L,7L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197493Inst : IEnumerable<long>
{
public static readonly long[] Value=A197493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197493.Bytes);
public long this[int i]=>Value[i];

public static A197493Inst Instance=new A197493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197494
{
public static readonly long[] Value={ 1L,5L,6L,6L,0L,2L,3L,6L,1L,3L,6L,2L,2L,2L,8L,9L,7L,0L,2L,3L,0L,3L,8L,2L,0L,8L,2L,3L,9L,4L,8L,9L,4L,6L,1L,1L,0L,5L,0L,0L,2L,3L,7L,1L,8L,4L,2L,4L,8L,4L,9L,7L,1L,8L,2L,1L,8L,6L,5L,9L,9L,3L,4L,1L,5L,9L,8L,6L,8L,2L,4L,0L,3L,9L,2L,3L,5L,2L,3L,3L,2L,6L,4L,2L,1L,9L,4L,2L,2L,7L,2L,3L,3L,1L,9L,9L,4L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197494Inst : IEnumerable<long>
{
public static readonly long[] Value=A197494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197494.Bytes);
public long this[int i]=>Value[i];

public static A197494Inst Instance=new A197494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197495
{
public static readonly long[] Value={ 1L,2L,7L,8L,3L,9L,8L,3L,8L,5L,6L,7L,4L,4L,4L,9L,6L,8L,0L,8L,8L,7L,2L,9L,5L,7L,3L,2L,3L,0L,6L,8L,3L,6L,5L,7L,6L,6L,6L,8L,6L,4L,4L,2L,3L,6L,3L,9L,9L,7L,2L,8L,3L,4L,7L,5L,1L,2L,7L,9L,7L,8L,0L,9L,3L,3L,7L,8L,0L,5L,1L,8L,8L,6L,9L,9L,2L,4L,1L,1L,7L,0L,9L,4L,4L,9L,7L,8L,0L,2L,3L,2L,1L,9L,3L,7L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197495Inst : IEnumerable<long>
{
public static readonly long[] Value=A197495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197495.Bytes);
public long this[int i]=>Value[i];

public static A197495Inst Instance=new A197495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197496
{
public static readonly long[] Value={ 1L,1L,22L,181L,7845L,755338L,182232300L,122868970059L,214646199763320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197496Inst : IEnumerable<long>
{
public static readonly long[] Value=A197496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197496.Bytes);
public long this[int i]=>Value[i];

public static A197496Inst Instance=new A197496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197497
{
public static readonly long[] Value={ 1L,1L,9L,9L,19L,45L,73L,147L,291L,539L,1051L,2025L,3863L,7451L,14313L,27465L,52817L,101457L,194891L,374517L,719505L,1382347L,2655995L,5102835L,9804019L,18836497L,36190191L,69531891L,133591057L,256666833L,493131481L,947448537L,1820322627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197497Inst : IEnumerable<long>
{
public static readonly long[] Value=A197497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197497.Bytes);
public long this[int i]=>Value[i];

public static A197497Inst Instance=new A197497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197498
{
public static readonly long[] Value={ 1L,9L,22L,53L,162L,526L,1605L,5011L,15073L,46562L,143487L,440836L,1353988L,4162099L,12795741L,39330623L,120882310L,371559669L,1142099870L,3510484802L,10790188695L,33166049781L,101943428843L,313345715556L,963137000727L,2960415365620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197498Inst : IEnumerable<long>
{
public static readonly long[] Value=A197498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197498.Bytes);
public long this[int i]=>Value[i];

public static A197498Inst Instance=new A197498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197499
{
public static readonly long[] Value={ 1L,9L,53L,181L,967L,4447L,20411L,99367L,473509L,2249979L,10740561L,51245685L,244406613L,1165674879L,5559988993L,26520385505L,126494970513L,603345410731L,2877810161871L,13726438785461L,65471603280973L,312282907797439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197499Inst : IEnumerable<long>
{
public static readonly long[] Value=A197499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197499.Bytes);
public long this[int i]=>Value[i];

public static A197499Inst Instance=new A197499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197500
{
public static readonly long[] Value={ 1L,19L,162L,967L,7845L,58434L,462825L,3560859L,27478512L,213540131L,1655543599L,12828732416L,99455874997L,771029045491L,5977169558845L,46336520563805L,359215034469100L,2784731837712288L,21587977565996803L,167356072621226437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197500Inst : IEnumerable<long>
{
public static readonly long[] Value=A197500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197500.Bytes);
public long this[int i]=>Value[i];

public static A197500Inst Instance=new A197500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197501
{
public static readonly long[] Value={ 1L,45L,526L,4447L,58434L,755338L,9343735L,115041017L,1444324039L,18148792772L,226805049125L,2837702507896L,35532382009820L,444833549598339L,5568581339404147L,69708374269567517L,872630491310203892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197501Inst : IEnumerable<long>
{
public static readonly long[] Value=A197501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197501.Bytes);
public long this[int i]=>Value[i];

public static A197501Inst Instance=new A197501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197502
{
public static readonly BigInteger[] Value={ 1L,73L,1605L,20411L,462825L,9343735L,182232300L,3721024215L,75873083886L,1533554674879L,31095240897403L,631619193851873L,12815959990096973L,260019107905052450L,5276671977231304874L,BigInteger.Parse("107080511710187498485") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197502Inst Instance=new A197502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197503
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,9L,1L,1L,9L,22L,9L,1L,1L,19L,53L,53L,19L,1L,1L,45L,162L,181L,162L,45L,1L,1L,73L,526L,967L,967L,526L,73L,1L,1L,147L,1605L,4447L,7845L,4447L,1605L,147L,1L,1L,291L,5011L,20411L,58434L,58434L,20411L,5011L,291L,1L,1L,539L,15073L,99367L,462825L,755338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197503Inst : IEnumerable<long>
{
public static readonly long[] Value=A197503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197503.Bytes);
public long this[int i]=>Value[i];

public static A197503Inst Instance=new A197503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197504
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,19L,23L,27L,31L,43L,47L,49L,59L,67L,71L,79L,81L,83L,103L,107L,121L,127L,131L,139L,151L,163L,167L,179L,191L,199L,211L,223L,227L,239L,243L,251L,263L,271L,283L,307L,311L,331L,343L,347L,359L,361L,367L,379L,383L,419L,431L,439L,443L,463L,467L,479L,487L,491L,499L,503L,523L,529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197504Inst : IEnumerable<long>
{
public static readonly long[] Value=A197504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197504.Bytes);
public long this[int i]=>Value[i];

public static A197504Inst Instance=new A197504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197505
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,121L,1665L,43883L,2437423L,289320049L,71423435521L,35912764315347L,36427941634714575L,BigInteger.Parse("74226534887938021609"),BigInteger.Parse("303199273967377493113473"),BigInteger.Parse("2480131664037469755458069819"),BigInteger.Parse("40602053121132407513785975382767"),BigInteger.Parse("1329877926764331449042460153768864481") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197505Inst Instance=new A197505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197506
{
public static readonly long[] Value={ 1L,1L,0L,1L,9L,6L,9L,5L,6L,5L,5L,4L,4L,0L,6L,8L,6L,6L,9L,4L,9L,6L,9L,1L,2L,8L,3L,5L,8L,8L,6L,2L,6L,7L,2L,2L,1L,9L,9L,8L,4L,4L,3L,3L,3L,3L,6L,0L,6L,2L,2L,9L,1L,2L,0L,7L,6L,6L,2L,5L,7L,2L,2L,0L,0L,8L,3L,9L,8L,9L,8L,7L,2L,1L,8L,9L,7L,9L,5L,0L,2L,9L,0L,3L,6L,9L,0L,5L,9L,2L,5L,5L,5L,0L,2L,6L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197506Inst : IEnumerable<long>
{
public static readonly long[] Value=A197506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197506.Bytes);
public long this[int i]=>Value[i];

public static A197506Inst Instance=new A197506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197507
{
public static readonly long[] Value={ 3L,9L,4L,2L,6L,8L,2L,5L,8L,5L,3L,5L,5L,9L,1L,5L,9L,0L,5L,6L,3L,3L,0L,9L,1L,5L,4L,5L,7L,5L,1L,3L,7L,7L,4L,0L,9L,5L,5L,0L,1L,7L,2L,9L,4L,0L,8L,4L,1L,8L,3L,4L,3L,9L,7L,9L,6L,1L,7L,3L,6L,5L,7L,1L,0L,4L,6L,0L,0L,7L,0L,3L,2L,6L,3L,8L,1L,8L,2L,0L,2L,5L,0L,1L,0L,2L,9L,6L,6L,1L,0L,1L,0L,2L,0L,3L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197507Inst : IEnumerable<long>
{
public static readonly long[] Value=A197507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197507.Bytes);
public long this[int i]=>Value[i];

public static A197507Inst Instance=new A197507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197508
{
public static readonly long[] Value={ 5L,0L,6L,2L,9L,7L,8L,9L,9L,2L,3L,4L,0L,5L,9L,8L,2L,6L,7L,5L,0L,0L,1L,1L,5L,6L,2L,7L,8L,3L,6L,9L,7L,0L,3L,2L,5L,2L,8L,6L,5L,8L,1L,6L,3L,9L,5L,8L,2L,8L,9L,4L,7L,4L,1L,9L,1L,4L,3L,2L,4L,7L,4L,1L,1L,1L,0L,7L,6L,9L,2L,2L,7L,8L,9L,7L,5L,3L,6L,7L,6L,3L,4L,2L,8L,4L,5L,7L,9L,5L,4L,3L,5L,4L,0L,0L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197508Inst : IEnumerable<long>
{
public static readonly long[] Value=A197508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197508.Bytes);
public long this[int i]=>Value[i];

public static A197508Inst Instance=new A197508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197509
{
public static readonly long[] Value={ 4L,0L,5L,7L,4L,6L,6L,6L,0L,7L,5L,1L,2L,4L,8L,2L,1L,5L,1L,1L,6L,0L,8L,4L,7L,7L,7L,0L,5L,8L,3L,0L,6L,9L,0L,5L,3L,2L,0L,0L,0L,9L,9L,3L,9L,1L,6L,2L,0L,4L,6L,8L,7L,5L,5L,3L,2L,0L,7L,0L,4L,0L,3L,4L,6L,6L,4L,6L,2L,8L,5L,6L,9L,4L,4L,5L,2L,2L,0L,0L,8L,0L,0L,4L,8L,5L,5L,7L,2L,3L,3L,2L,0L,0L,5L,7L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197509Inst : IEnumerable<long>
{
public static readonly long[] Value=A197509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197509.Bytes);
public long this[int i]=>Value[i];

public static A197509Inst Instance=new A197509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197510
{
public static readonly long[] Value={ 6L,6L,3L,4L,9L,0L,0L,4L,6L,0L,5L,6L,6L,3L,7L,3L,2L,0L,7L,8L,9L,8L,3L,6L,1L,6L,6L,9L,1L,5L,1L,9L,0L,2L,1L,3L,3L,2L,1L,5L,0L,3L,2L,7L,9L,6L,4L,5L,8L,6L,8L,0L,6L,0L,0L,9L,3L,9L,2L,7L,8L,8L,8L,1L,7L,1L,0L,9L,3L,2L,8L,4L,7L,9L,2L,1L,9L,4L,6L,9L,2L,3L,6L,6L,4L,7L,1L,7L,6L,8L,4L,0L,2L,6L,3L,8L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197510Inst : IEnumerable<long>
{
public static readonly long[] Value=A197510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197510.Bytes);
public long this[int i]=>Value[i];

public static A197510Inst Instance=new A197510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197511
{
public static readonly long[] Value={ 6L,3L,9L,1L,9L,9L,1L,9L,2L,8L,3L,7L,2L,2L,4L,8L,4L,0L,4L,4L,3L,6L,4L,7L,8L,6L,6L,1L,5L,3L,4L,1L,8L,2L,8L,8L,3L,3L,4L,3L,2L,2L,1L,1L,8L,1L,9L,9L,8L,6L,4L,1L,7L,3L,7L,5L,6L,3L,9L,8L,9L,0L,4L,6L,6L,8L,9L,0L,2L,5L,9L,4L,3L,4L,9L,6L,2L,0L,5L,8L,5L,4L,7L,2L,4L,8L,9L,0L,1L,1L,6L,0L,9L,6L,8L,5L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197511Inst : IEnumerable<long>
{
public static readonly long[] Value=A197511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197511.Bytes);
public long this[int i]=>Value[i];

public static A197511Inst Instance=new A197511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197512
{
public static readonly long[] Value={ 3L,0L,8L,1L,3L,7L,3L,5L,9L,9L,2L,8L,2L,3L,2L,6L,4L,6L,2L,3L,1L,7L,7L,0L,5L,6L,9L,9L,4L,5L,5L,4L,1L,1L,1L,9L,3L,9L,0L,5L,4L,8L,4L,3L,4L,9L,6L,7L,8L,8L,9L,4L,1L,4L,9L,5L,9L,3L,0L,9L,7L,0L,7L,6L,0L,3L,0L,2L,3L,7L,2L,0L,2L,2L,2L,4L,8L,1L,5L,5L,7L,2L,2L,9L,9L,5L,9L,9L,0L,2L,1L,0L,2L,1L,6L,1L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197512Inst : IEnumerable<long>
{
public static readonly long[] Value=A197512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197512.Bytes);
public long this[int i]=>Value[i];

public static A197512Inst Instance=new A197512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197513
{
public static readonly long[] Value={ 2L,4L,0L,5L,2L,3L,3L,7L,0L,3L,8L,7L,7L,0L,3L,6L,5L,3L,6L,0L,3L,8L,1L,1L,2L,8L,0L,2L,5L,2L,2L,8L,2L,7L,2L,4L,6L,0L,2L,6L,4L,4L,9L,5L,6L,3L,9L,6L,4L,4L,8L,2L,0L,1L,5L,0L,2L,8L,6L,6L,8L,2L,4L,5L,4L,3L,2L,2L,4L,5L,9L,6L,2L,3L,0L,7L,1L,7L,7L,3L,8L,0L,7L,2L,7L,9L,9L,8L,0L,9L,0L,1L,1L,6L,1L,1L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197513Inst : IEnumerable<long>
{
public static readonly long[] Value=A197513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197513.Bytes);
public long this[int i]=>Value[i];

public static A197513Inst Instance=new A197513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197514
{
public static readonly long[] Value={ 2L,4L,0L,3L,4L,7L,6L,9L,7L,8L,9L,9L,9L,9L,2L,5L,2L,2L,5L,4L,5L,1L,2L,9L,6L,4L,6L,3L,2L,4L,8L,1L,1L,8L,3L,1L,0L,8L,3L,7L,9L,2L,0L,0L,5L,2L,9L,0L,9L,6L,8L,0L,9L,5L,2L,8L,3L,5L,5L,5L,5L,7L,2L,2L,5L,3L,4L,8L,5L,7L,9L,3L,2L,2L,9L,5L,8L,4L,4L,3L,5L,5L,2L,3L,2L,9L,9L,5L,9L,4L,6L,7L,9L,3L,2L,7L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197514Inst : IEnumerable<long>
{
public static readonly long[] Value=A197514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197514.Bytes);
public long this[int i]=>Value[i];

public static A197514Inst Instance=new A197514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197515
{
public static readonly long[] Value={ 1L,5L,0L,1L,5L,2L,4L,9L,8L,0L,4L,5L,5L,7L,6L,2L,5L,5L,0L,6L,8L,3L,9L,4L,7L,2L,6L,2L,8L,8L,6L,2L,7L,8L,1L,5L,7L,1L,3L,6L,5L,1L,4L,4L,5L,3L,0L,7L,2L,3L,4L,1L,1L,2L,5L,6L,3L,8L,4L,9L,9L,4L,4L,2L,6L,0L,3L,3L,6L,3L,3L,7L,7L,9L,5L,5L,4L,5L,0L,0L,8L,4L,2L,8L,5L,0L,5L,8L,5L,0L,5L,1L,3L,5L,3L,6L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197515Inst : IEnumerable<long>
{
public static readonly long[] Value=A197515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197515.Bytes);
public long this[int i]=>Value[i];

public static A197515Inst Instance=new A197515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197516
{
public static readonly long[] Value={ 1L,7L,9L,8L,5L,9L,1L,0L,3L,7L,0L,2L,8L,6L,9L,8L,4L,4L,2L,7L,7L,5L,5L,7L,2L,9L,2L,8L,4L,5L,2L,1L,6L,1L,3L,1L,1L,7L,0L,8L,8L,7L,0L,5L,1L,1L,1L,7L,5L,7L,5L,5L,6L,1L,5L,0L,4L,0L,8L,7L,1L,5L,6L,4L,2L,6L,4L,7L,6L,4L,6L,4L,9L,7L,8L,2L,0L,0L,6L,9L,9L,0L,1L,9L,0L,4L,3L,4L,6L,4L,0L,4L,9L,1L,3L,8L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197516Inst : IEnumerable<long>
{
public static readonly long[] Value=A197516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197516.Bytes);
public long this[int i]=>Value[i];

public static A197516Inst Instance=new A197516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197517
{
public static readonly long[] Value={ 1L,6L,5L,1L,9L,5L,8L,3L,1L,3L,6L,2L,2L,5L,0L,0L,7L,8L,9L,7L,6L,4L,6L,7L,8L,2L,8L,5L,7L,3L,4L,4L,4L,7L,2L,0L,3L,8L,1L,2L,6L,5L,5L,8L,3L,9L,5L,5L,9L,0L,7L,8L,4L,0L,3L,0L,1L,0L,6L,8L,1L,8L,8L,8L,7L,1L,2L,5L,4L,2L,3L,1L,3L,9L,5L,6L,6L,8L,9L,4L,5L,8L,7L,7L,0L,0L,5L,2L,4L,1L,4L,1L,2L,3L,4L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197517Inst : IEnumerable<long>
{
public static readonly long[] Value=A197517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197517.Bytes);
public long this[int i]=>Value[i];

public static A197517Inst Instance=new A197517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197518
{
public static readonly long[] Value={ 8L,2L,5L,9L,7L,9L,1L,5L,6L,8L,1L,1L,2L,5L,0L,3L,9L,4L,8L,8L,2L,3L,3L,9L,1L,4L,2L,8L,6L,7L,2L,2L,3L,6L,0L,1L,9L,0L,6L,3L,2L,7L,9L,1L,9L,7L,7L,9L,5L,3L,9L,2L,0L,1L,5L,0L,5L,3L,4L,0L,9L,4L,4L,3L,5L,6L,2L,7L,1L,1L,5L,6L,9L,7L,8L,3L,4L,4L,7L,2L,9L,3L,8L,5L,0L,2L,6L,2L,0L,7L,0L,6L,1L,7L,2L,0L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197518Inst : IEnumerable<long>
{
public static readonly long[] Value=A197518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197518.Bytes);
public long this[int i]=>Value[i];

public static A197518Inst Instance=new A197518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197519
{
public static readonly long[] Value={ 7L,5L,0L,7L,6L,2L,4L,9L,0L,2L,2L,7L,8L,8L,1L,2L,7L,5L,3L,4L,1L,9L,7L,3L,6L,3L,1L,4L,4L,3L,1L,3L,9L,0L,7L,8L,5L,6L,8L,2L,5L,7L,2L,2L,6L,5L,3L,6L,1L,7L,0L,5L,6L,2L,8L,1L,9L,2L,4L,9L,7L,2L,1L,3L,0L,1L,6L,8L,1L,6L,8L,8L,9L,7L,7L,7L,2L,5L,0L,4L,2L,1L,4L,2L,5L,2L,9L,2L,5L,2L,5L,6L,7L,6L,8L,3L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197519Inst : IEnumerable<long>
{
public static readonly long[] Value=A197519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197519.Bytes);
public long this[int i]=>Value[i];

public static A197519Inst Instance=new A197519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197520
{
public static readonly long[] Value={ 9L,0L,6L,3L,6L,2L,2L,3L,6L,5L,3L,8L,7L,2L,1L,4L,1L,7L,5L,1L,9L,6L,9L,1L,9L,2L,2L,7L,5L,8L,8L,4L,6L,9L,1L,0L,3L,1L,2L,0L,8L,8L,7L,1L,0L,3L,0L,1L,9L,2L,0L,1L,8L,0L,4L,1L,4L,4L,0L,8L,9L,3L,8L,8L,7L,3L,7L,2L,3L,9L,2L,8L,6L,2L,0L,8L,5L,9L,6L,8L,1L,5L,6L,0L,8L,2L,0L,2L,8L,8L,5L,2L,4L,6L,7L,6L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197520Inst : IEnumerable<long>
{
public static readonly long[] Value=A197520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197520.Bytes);
public long this[int i]=>Value[i];

public static A197520Inst Instance=new A197520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197521
{
public static readonly long[] Value={ 3L,5L,2L,1L,3L,3L,7L,8L,2L,9L,5L,7L,1L,7L,1L,5L,6L,9L,8L,6L,9L,1L,9L,8L,8L,5L,6L,4L,4L,5L,4L,9L,1L,7L,9L,7L,7L,3L,0L,9L,1L,8L,1L,3L,9L,4L,7L,3L,3L,6L,8L,8L,7L,1L,9L,5L,4L,9L,1L,8L,4L,8L,6L,2L,5L,1L,5L,5L,9L,0L,6L,0L,9L,6L,1L,0L,2L,5L,9L,8L,8L,8L,9L,7L,4L,9L,7L,5L,6L,9L,0L,0L,3L,9L,4L,9L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197521Inst : IEnumerable<long>
{
public static readonly long[] Value=A197521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197521.Bytes);
public long this[int i]=>Value[i];

public static A197521Inst Instance=new A197521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197522
{
public static readonly long[] Value={ 2L,1L,2L,0L,7L,1L,0L,7L,1L,9L,1L,8L,1L,0L,4L,2L,8L,2L,0L,4L,4L,3L,5L,1L,1L,7L,5L,6L,9L,4L,2L,8L,3L,5L,2L,2L,5L,6L,8L,5L,2L,0L,3L,0L,5L,0L,9L,1L,1L,6L,4L,7L,9L,0L,9L,2L,9L,7L,8L,5L,0L,4L,1L,1L,7L,5L,6L,7L,9L,8L,7L,1L,8L,7L,3L,8L,4L,5L,8L,1L,6L,1L,5L,5L,0L,9L,7L,0L,5L,7L,4L,7L,6L,0L,0L,1L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197522Inst : IEnumerable<long>
{
public static readonly long[] Value=A197522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197522.Bytes);
public long this[int i]=>Value[i];

public static A197522Inst Instance=new A197522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197523
{
public static readonly BigInteger[] Value={ 1L,1L,32L,289L,26282L,4538784L,2095251333L,2629509487169L,9372400936796449L,BigInteger.Parse("87780282753696748644") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197523Inst Instance=new A197523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197524
{
public static readonly long[] Value={ 1L,3L,32L,69L,308L,1444L,5048L,20265L,83277L,322864L,1280598L,5112008L,20189827L,80032884L,317712722L,1258773307L,4990157041L,19788837323L,78445935632L,310998937948L,1233039388705L,4888402255720L,19380385472489L,76835860723308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197524Inst : IEnumerable<long>
{
public static readonly long[] Value=A197524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197524.Bytes);
public long this[int i]=>Value[i];

public static A197524Inst Instance=new A197524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197525
{
public static readonly long[] Value={ 1L,7L,69L,289L,2131L,12071L,74637L,454685L,2748523L,16739531L,101635341L,617647081L,3752641091L,22798729927L,138527481045L,841658638245L,5113753205699L,31070163145411L,188776416736109L,1146970428535417L,6968770713230523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197525Inst : IEnumerable<long>
{
public static readonly long[] Value=A197525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197525.Bytes);
public long this[int i]=>Value[i];

public static A197525Inst Instance=new A197525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197526
{
public static readonly long[] Value={ 1L,17L,308L,2131L,26282L,266240L,2818424L,29249599L,308300414L,3239050114L,33917534848L,356001407488L,3736740898853L,39200753974016L,411284436121799L,4315679852563777L,45282304376141812L,475113528147885886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197526Inst : IEnumerable<long>
{
public static readonly long[] Value=A197526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197526.Bytes);
public long this[int i]=>Value[i];

public static A197526Inst Instance=new A197526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197527
{
public static readonly long[] Value={ 1L,41L,1444L,12071L,266240L,4538784L,73297686L,1237970513L,21169912001L,353504327702L,5958282895132L,100604292119446L,1693082387823415L,28523128648184140L,480717546283691822L,8098057861011371455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197527Inst : IEnumerable<long>
{
public static readonly long[] Value=A197527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197527.Bytes);
public long this[int i]=>Value[i];

public static A197527Inst Instance=new A197527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197528
{
public static readonly BigInteger[] Value={ 1L,99L,5048L,74637L,2818424L,73297686L,2095251333L,58226014909L,1640490253969L,46006820800296L,1290659247439150L,36216071381563588L,1016338870833268879L,BigInteger.Parse("28519809510464622005"),BigInteger.Parse("800263279008322539229"),BigInteger.Parse("22456612946242234293115") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197528Inst Instance=new A197528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197529
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,32L,7L,1L,1L,17L,69L,69L,17L,1L,1L,41L,308L,289L,308L,41L,1L,1L,99L,1444L,2131L,2131L,1444L,99L,1L,1L,239L,5048L,12071L,26282L,12071L,5048L,239L,1L,1L,577L,20265L,74637L,266240L,266240L,74637L,20265L,577L,1L,1L,1393L,83277L,454685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197529Inst : IEnumerable<long>
{
public static readonly long[] Value=A197529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197529.Bytes);
public long this[int i]=>Value[i];

public static A197529Inst Instance=new A197529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197530
{
public static readonly long[] Value={ 1L,9L,56L,1419L,107655L,23325250L,14991391782L,27504159228709L,145843735771766573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197530Inst : IEnumerable<long>
{
public static readonly long[] Value=A197530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197530.Bytes);
public long this[int i]=>Value[i];

public static A197530Inst Instance=new A197530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197531
{
public static readonly long[] Value={ 3L,9L,16L,33L,73L,160L,361L,835L,1966L,4703L,11399L,27914L,68903L,171121L,426940L,1068865L,2682789L,6746336L,16988333L,42822747L,108024178L,272648551L,688426371L,1738750602L,4392467427L,11098043841L,28043540864L,70868720569L,179102669081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197531Inst : IEnumerable<long>
{
public static readonly long[] Value=A197531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197531.Bytes);
public long this[int i]=>Value[i];

public static A197531Inst Instance=new A197531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197532
{
public static readonly long[] Value={ 4L,16L,56L,216L,868L,3500L,14085L,56842L,229706L,928664L,3755722L,15191220L,61451640L,248596817L,1005703793L,4068662528L,16460279703L,66592450774L,269410213656L,1089943115100L,4409547400430L,17839571907124L,72173035560719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197532Inst : IEnumerable<long>
{
public static readonly long[] Value=A197532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197532.Bytes);
public long this[int i]=>Value[i];

public static A197532Inst Instance=new A197532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197533
{
public static readonly long[] Value={ 5L,33L,216L,1419L,9373L,62586L,423085L,2879723L,19671764L,134643523L,922592723L,6325665762L,43386843099L,297644913045L,2042157812212L,14012277918367L,96148923597911L,659765081841360L,4527301927394765L,31066516652385893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197533Inst : IEnumerable<long>
{
public static readonly long[] Value=A197533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197533.Bytes);
public long this[int i]=>Value[i];

public static A197533Inst Instance=new A197533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197534
{
public static readonly long[] Value={ 9L,73L,868L,9373L,107655L,1220630L,14056707L,162042137L,1874230689L,21698542215L,251403042154L,2913819348602L,33779087426950L,391635814747885L,4540933400612193L,52653016886940873L,610534294176601038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197534Inst : IEnumerable<long>
{
public static readonly long[] Value=A197534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197534.Bytes);
public long this[int i]=>Value[i];

public static A197534Inst Instance=new A197534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197535
{
public static readonly BigInteger[] Value={ 16L,160L,3500L,62586L,1220630L,23325250L,454280983L,8844380028L,172982554332L,3386294190736L,66356347688978L,1300795127521094L,25506585069158562L,500211695453958433L,9810478953775130079UL,BigInteger.Parse("192417797960470740096") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197535Inst Instance=new A197535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197536
{
public static readonly BigInteger[] Value={ 25L,361L,14085L,423085L,14056707L,454280983L,14991391782L,493785636151L,16343961543732L,541269402906501L,17943273862788427L,595019891173209941L,BigInteger.Parse("19736497896904338854"),BigInteger.Parse("654726724059190203302"),BigInteger.Parse("21721092108797190824889") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197536Inst Instance=new A197536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197537
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,16L,16L,5L,9L,33L,56L,33L,9L,16L,73L,216L,216L,73L,16L,25L,160L,868L,1419L,868L,160L,25L,39L,361L,3500L,9373L,9373L,3500L,361L,39L,64L,835L,14085L,62586L,107655L,62586L,14085L,835L,64L,105L,1966L,56842L,423085L,1220630L,1220630L,423085L,56842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197537Inst : IEnumerable<long>
{
public static readonly long[] Value=A197537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197537.Bytes);
public long this[int i]=>Value[i];

public static A197537Inst Instance=new A197537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197538
{
public static readonly long[] Value={ 1L,5L,11L,131L,494L,12019L,223832L,9712913L,396593739L,39500650780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197538Inst : IEnumerable<long>
{
public static readonly long[] Value=A197538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197538.Bytes);
public long this[int i]=>Value[i];

public static A197538Inst Instance=new A197538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197539
{
public static readonly long[] Value={ 1L,5L,8L,19L,28L,58L,119L,219L,395L,776L,1529L,2826L,5300L,10299L,19763L,37051L,70380L,135411L,257788L,487412L,929135L,1776855L,3377845L,6414026L,12229725L,23320560L,44346952L,84364697L,160777089L,306229857L,582642042L,1109154715L,2112783972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197539Inst : IEnumerable<long>
{
public static readonly long[] Value=A197539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197539.Bytes);
public long this[int i]=>Value[i];

public static A197539Inst Instance=new A197539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197540
{
public static readonly long[] Value={ 2L,8L,11L,24L,61L,121L,270L,614L,1296L,2973L,6574L,14527L,32621L,72032L,160402L,357304L,792903L,1765982L,3926185L,8727963L,19420018L,43174998L,96024756L,213571465L,474912978L,1056243677L,2348975193L,5223841988L,11617743070L,25836617638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197540Inst : IEnumerable<long>
{
public static readonly long[] Value=A197540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197540.Bytes);
public long this[int i]=>Value[i];

public static A197540Inst Instance=new A197540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197541
{
public static readonly long[] Value={ 3L,19L,24L,131L,206L,834L,2081L,6653L,15931L,48796L,135249L,391078L,1061878L,3054971L,8582689L,24243393L,67728862L,192162581L,541573358L,1525969004L,4291400929L,12116692925L,34147187837L,96210697228L,271054147869L,764411232314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197541Inst : IEnumerable<long>
{
public static readonly long[] Value=A197541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197541.Bytes);
public long this[int i]=>Value[i];

public static A197541Inst Instance=new A197541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197542
{
public static readonly long[] Value={ 4L,28L,61L,206L,494L,2095L,6279L,21530L,69977L,248366L,813400L,2838023L,9457181L,32284759L,108523371L,370702868L,1251432293L,4258479323L,14389442735L,48816423022L,165305055080L,561221682936L,1901461841900L,6447263273359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197542Inst : IEnumerable<long>
{
public static readonly long[] Value=A197542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197542.Bytes);
public long this[int i]=>Value[i];

public static A197542Inst Instance=new A197542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197543
{
public static readonly long[] Value={ 6L,58L,121L,834L,2095L,12019L,48014L,225222L,831160L,3944345L,16773428L,72763421L,300929135L,1319535052L,5704373966L,24566253078L,104395539577L,449962758422L,1938348799951L,8344538708719L,35799140191716L,153820463246984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197543Inst : IEnumerable<long>
{
public static readonly long[] Value=A197543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197543.Bytes);
public long this[int i]=>Value[i];

public static A197543Inst Instance=new A197543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197544
{
public static readonly long[] Value={ 9L,119L,270L,2081L,6279L,48014L,223832L,1258673L,6255191L,36099651L,182317148L,1002566978L,5243822530L,28535482208L,150520120228L,809991814859L,4299042626683L,23075139229373L,122959297359243L,658044273422935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197544Inst : IEnumerable<long>
{
public static readonly long[] Value=A197544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197544.Bytes);
public long this[int i]=>Value[i];

public static A197544Inst Instance=new A197544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197545
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,3L,8L,8L,3L,4L,19L,11L,19L,4L,6L,28L,24L,24L,28L,6L,9L,58L,61L,131L,61L,58L,9L,13L,119L,121L,206L,206L,121L,119L,13L,19L,219L,270L,834L,494L,834L,270L,219L,19L,28L,395L,614L,2081L,2095L,2095L,2081L,614L,395L,28L,41L,776L,1296L,6653L,6279L,12019L,6279L,6653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197545Inst : IEnumerable<long>
{
public static readonly long[] Value=A197545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197545.Bytes);
public long this[int i]=>Value[i];

public static A197545Inst Instance=new A197545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197546
{
public static readonly long[] Value={ 1L,4L,7L,13L,40L,264L,888L,2335L,22885L,134738L,1291220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197546Inst : IEnumerable<long>
{
public static readonly long[] Value=A197546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197546.Bytes);
public long this[int i]=>Value[i];

public static A197546Inst Instance=new A197546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197547
{
public static readonly long[] Value={ 0L,2L,1L,1L,2L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,2L,0L,1L,1L,0L,1L,2L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,2L,0L,1L,0L,2L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,0L,0L,1L,1L,1L,1L,0L,2L,1L,0L,1L,1L,2L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197547Inst : IEnumerable<long>
{
public static readonly long[] Value=A197547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197547.Bytes);
public long this[int i]=>Value[i];

public static A197547Inst Instance=new A197547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197548
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,0L,0L,1L,1L,1L,1L,1L,2L,0L,1L,1L,2L,1L,2L,1L,0L,0L,2L,1L,1L,0L,1L,2L,0L,1L,1L,1L,1L,1L,1L,2L,0L,0L,0L,0L,2L,0L,1L,1L,2L,2L,0L,0L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197548Inst : IEnumerable<long>
{
public static readonly long[] Value=A197548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197548.Bytes);
public long this[int i]=>Value[i];

public static A197548Inst Instance=new A197548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197549
{
public static readonly long[] Value={ 1L,1L,5L,16L,62L,276L,1222L,5563L,25805L,120909L,572011L,2727485L,13089106L,63164265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197549Inst : IEnumerable<long>
{
public static readonly long[] Value=A197549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197549.Bytes);
public long this[int i]=>Value[i];

public static A197549Inst Instance=new A197549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197550
{
public static readonly long[] Value={ 1L,3L,7L,28L,99L,433L,1852L,8463L,38798L,181889L,858570L,4093739L,19636172L,94759074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197550Inst : IEnumerable<long>
{
public static readonly long[] Value=A197550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197550.Bytes);
public long this[int i]=>Value[i];

public static A197550Inst Instance=new A197550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197551
{
public static readonly long[] Value={ 1L,1L,4L,10L,37L,147L,637L,2823L,13020L,60649L,286549L,1364667L,6547108L,31586568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197551Inst : IEnumerable<long>
{
public static readonly long[] Value=A197551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197551.Bytes);
public long this[int i]=>Value[i];

public static A197551Inst Instance=new A197551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197552
{
public static readonly long[] Value={ 1L,1L,4L,10L,36L,146L,631L,2815L,12987L,60601L,286376L,1364399L,6546220L,31585133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197552Inst : IEnumerable<long>
{
public static readonly long[] Value=A197552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197552.Bytes);
public long this[int i]=>Value[i];

public static A197552Inst Instance=new A197552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197553
{
public static readonly long[] Value={ 1L,2L,7L,24L,99L,416L,1852L,8386L,38797L,181530L,858560L,4092031L,19636098L,94750833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197553Inst : IEnumerable<long>
{
public static readonly long[] Value=A197553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197553.Bytes);
public long this[int i]=>Value[i];

public static A197553Inst Instance=new A197553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197554
{
public static readonly long[] Value={ 1L,2L,7L,24L,98L,415L,1846L,8378L,38764L,181482L,858387L,4091763L,19635210L,94749398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197554Inst : IEnumerable<long>
{
public static readonly long[] Value=A197554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197554.Bytes);
public long this[int i]=>Value[i];

public static A197554Inst Instance=new A197554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197555
{
public static readonly long[] Value={ 1L,7L,35L,927L,36877L,4706533L,1435938748L,1096211683589L,2097209821463073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197555Inst : IEnumerable<long>
{
public static readonly long[] Value=A197555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197555.Bytes);
public long this[int i]=>Value[i];

public static A197555Inst Instance=new A197555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197556
{
public static readonly long[] Value={ 2L,10L,35L,106L,410L,1479L,5280L,18882L,67751L,242440L,867925L,3107159L,11124592L,39826674L,142586969L,510485048L,1827627898L,6543219347L,23425871440L,83868676944L,300264436266L,1074998739399L,3848682051842L,13778949324677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197556Inst : IEnumerable<long>
{
public static readonly long[] Value=A197556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197556.Bytes);
public long this[int i]=>Value[i];

public static A197556Inst Instance=new A197556Inst();

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