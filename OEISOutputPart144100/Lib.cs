using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A178064
{
public static readonly long[] Value={ 2L,1L,2L,2L,1L,0L,2L,2L,2L,2L,4L,4L,3L,3L,2L,2L,3L,2L,1L,2L,2L,1L,5L,4L,4L,3L,4L,3L,3L,2L,2L,2L,2L,1L,3L,1L,2L,2L,1L,2L,2L,1L,6L,5L,5L,4L,4L,3L,5L,5L,3L,3L,2L,5L,4L,4L,4L,4L,2L,3L,2L,5L,4L,4L,3L,3L,3L,4L,3L,3L,2L,3L,3L,2L,2L,4L,2L,2L,1L,2L,1L,1L,6L,6L,6L,5L,6L,5L,3L,6L,5L,4L,5L,4L,4L,4L,3L,5L,4L,4L,2L,6L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178064Inst : IEnumerable<long>
{
public static readonly long[] Value=A178064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178064.Bytes);
public long this[int i]=>Value[i];

public static A178064Inst Instance=new A178064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178065
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,3L,3L,3L,3L,2L,2L,3L,3L,4L,4L,3L,4L,5L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,5L,5L,5L,5L,6L,4L,6L,5L,5L,6L,5L,5L,6L,2L,3L,3L,4L,4L,5L,3L,3L,5L,5L,6L,3L,4L,4L,4L,4L,6L,5L,6L,3L,4L,4L,5L,5L,5L,4L,5L,5L,6L,5L,5L,6L,6L,4L,6L,6L,7L,6L,7L,7L,3L,3L,3L,4L,3L,4L,6L,3L,4L,5L,4L,5L,5L,5L,6L,4L,5L,5L,7L,3L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178065Inst : IEnumerable<long>
{
public static readonly long[] Value=A178065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178065.Bytes);
public long this[int i]=>Value[i];

public static A178065Inst Instance=new A178065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178066
{
public static readonly long[] Value={ 59L,108959L,176459L,4040159L,5904959L,10497659L,25401659L,26625659L,38192459L,89302559L,105884159L,117288959L,155750459L,156500159L,228614459L,251856959L,306950459L,432224159L,491508959L,508953659L,624500159L,682776959L,934524959L,1092963659L,1106892959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178066Inst : IEnumerable<long>
{
public static readonly long[] Value=A178066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178066.Bytes);
public long this[int i]=>Value[i];

public static A178066Inst Instance=new A178066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178067
{
public static readonly long[] Value={ 1L,5L,3L,15L,11L,6L,34L,27L,19L,10L,65L,54L,42L,29L,15L,111L,95L,78L,60L,41L,21L,175L,153L,130L,106L,81L,55L,28L,260L,231L,201L,170L,138L,105L,71L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178067Inst : IEnumerable<long>
{
public static readonly long[] Value=A178067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178067.Bytes);
public long this[int i]=>Value[i];

public static A178067Inst Instance=new A178067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178068
{
public static readonly long[] Value={ 3L,5L,23L,89L,173L,233L,239L,1223L,1409L,1559L,2549L,2693L,3389L,3803L,4373L,4919L,9059L,10313L,16493L,17159L,20879L,20939L,22013L,24473L,25229L,31649L,32933L,34253L,34883L,37049L,38453L,39089L,40283L,41399L,43793L,44543L,49103L,49919L,50993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178068Inst : IEnumerable<long>
{
public static readonly long[] Value=A178068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178068.Bytes);
public long this[int i]=>Value[i];

public static A178068Inst Instance=new A178068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178069
{
public static readonly long[] Value={ 12345679L,24691358L,49382716L,61728395L,86419753L,98765432L,123456790L,135802469L,160493827L,172839506L,197530864L,209876543L,234567901L,246913580L,271604938L,283950617L,308641975L,320987654L,345679012L,358024691L,382716049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178069Inst : IEnumerable<long>
{
public static readonly long[] Value=A178069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178069.Bytes);
public long this[int i]=>Value[i];

public static A178069Inst Instance=new A178069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178070
{
public static readonly long[] Value={ 11L,17L,41L,73L,101L,137L,251L,257L,271L,353L,401L,449L,641L,751L,1201L,1409L,1601L,3541L,4001L,4801L,5051L,9091L,10753L,15361L,16001L,19841L,21001L,21401L,24001L,25601L,27961L,37501L,40961L,43201L,60101L,62501L,65537L,69857L,76001L,76801L,160001L,162251L,163841L,307201L,453377L,524801L,544001L,670001L,952001L,976193L,980801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178070Inst : IEnumerable<long>
{
public static readonly long[] Value=A178070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178070.Bytes);
public long this[int i]=>Value[i];

public static A178070Inst Instance=new A178070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178071
{
public static readonly long[] Value={ 14L,16L,18L,22L,27L,28L,39L,55L,65L,77L,85L,221L,437L,1517L,2021L,4757L,6557L,9797L,11021L,12317L,16637L,27221L,38021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178071Inst : IEnumerable<long>
{
public static readonly long[] Value=A178071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178071.Bytes);
public long this[int i]=>Value[i];

public static A178071Inst Instance=new A178071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178072
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,-1L,-1L,1L,8L,23L,45L,55L,-14L,-317L,-1095L,-2459L,-3574L,-681L,16124L,64605L,159483L,260869L,134374L,-906919L,-4228769L,-11317061L,-20327731L,-15742753L,52640154L,293447719L,847451759L,1648865921L,1636313816L,-2986606297L,-21074495982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178072Inst : IEnumerable<long>
{
public static readonly long[] Value=A178072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178072.Bytes);
public long this[int i]=>Value[i];

public static A178072Inst Instance=new A178072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178073
{
public static readonly long[] Value={ 1L,10L,41L,116L,265L,526L,945L,1576L,2481L,3730L,5401L,7580L,10361L,13846L,18145L,23376L,29665L,37146L,45961L,56260L,68201L,81950L,97681L,115576L,135825L,158626L,184185L,212716L,244441L,279590L,318401L,361120L,408001L,459306L,515305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178073Inst : IEnumerable<long>
{
public static readonly long[] Value=A178073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178073.Bytes);
public long this[int i]=>Value[i];

public static A178073Inst Instance=new A178073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178074
{
public static readonly long[] Value={ 1L,0L,-2L,1L,3L,-5L,1L,10L,-24L,18L,52L,-182L,180L,348L,-1474L,1733L,2407L,-12557L,17145L,16561L,-111041L,172625L,107783L,-1006217L,1759149L,592699L,-9265399L,18081483L,1574873L,-86180045L,186977185L,-25366798L,-805909936L,1941467634L,-657563052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178074Inst : IEnumerable<long>
{
public static readonly long[] Value=A178074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178074.Bytes);
public long this[int i]=>Value[i];

public static A178074Inst Instance=new A178074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178075
{
public static readonly long[] Value={ 0L,1L,1L,-2L,1L,9L,-16L,-73L,-145L,1442L,3951L,-49121L,273184L,4095073L,-13134671L,-609740514L,-7877081935L,206841213449L,153991537616L,-138343392420553L,3626684171795871L,187758843981508546L,2146096698964614559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178075Inst : IEnumerable<long>
{
public static readonly long[] Value=A178075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178075.Bytes);
public long this[int i]=>Value[i];

public static A178075Inst Instance=new A178075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178076
{
public static readonly long[] Value={ 1L,0L,2L,-2L,8L,-20L,64L,-200L,656L,-2184L,7408L,-25456L,88480L,-310464L,1098304L,-3912896L,14026752L,-50557184L,183110400L,-666079872L,2432399104L,-8914099840L,32772922112L,-120844493056L,446793362944L,-1656004554752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178076Inst : IEnumerable<long>
{
public static readonly long[] Value=A178076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178076.Bytes);
public long this[int i]=>Value[i];

public static A178076Inst Instance=new A178076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178077
{
public static readonly BigInteger[] Value={ 1L,2L,4L,-16L,-256L,-3072L,-81920L,-524288L,184549376L,20401094656L,3848290697216L,932385860354048L,-229683580995895296L,BigInteger.Parse("-514202991054653751296"),BigInteger.Parse("-608004684669466821263360") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178077Inst Instance=new A178077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178078
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,12L,42L,147L,527L,1914L,7039L,26159L,98110L,370919L,1412211L,5410273L,20841886L,80685792L,313747624L,1224895416L,4799435482L,18867423751L,74394859297L,294152650731L,1166021396660L,4632969618849L,18448290723435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178078Inst : IEnumerable<long>
{
public static readonly long[] Value=A178078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178078.Bytes);
public long this[int i]=>Value[i];

public static A178078Inst Instance=new A178078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178079
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,-3L,-7L,-8L,-25L,-37L,47L,318L,559L,2023L,7039L,-496L,-90431L,-314775L,-1139599L,-8007614L,-13512079L,154788437L,1247862041L,5097732072L,56844671623L,290379801907L,-1403230649825L,-32188159859842L,-199066111517153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178079Inst : IEnumerable<long>
{
public static readonly long[] Value=A178079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178079.Bytes);
public long this[int i]=>Value[i];

public static A178079Inst Instance=new A178079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178080
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,-2L,-6L,-14L,-27L,-39L,-4L,269L,1415L,5258L,16321L,43705L,98459L,163216L,49326L,-1120684L,-6502098L,-25711856L,-83830889L,-233926105L,-545916369L,-932372648L,-280663557L,6802456973L,40262637059L,162298734532L,538385811978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178080Inst : IEnumerable<long>
{
public static readonly long[] Value=A178080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178080.Bytes);
public long this[int i]=>Value[i];

public static A178080Inst Instance=new A178080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178081
{
public static readonly long[] Value={ 0L,1L,-1L,2L,3L,1L,-11L,-16L,35L,-129L,-299L,-386L,3977L,8063L,-42489L,269344L,1000009L,3727745L,-47166649L,-123526014L,1764203419L,-18228952703L,-113727892147L,-1065812586544L,18344075481339L,52130069331199L,-2470319425874195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178081Inst : IEnumerable<long>
{
public static readonly long[] Value=A178081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178081.Bytes);
public long this[int i]=>Value[i];

public static A178081Inst Instance=new A178081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178082
{
public static readonly long[] Value={ 3L,21L,39L,165L,297L,375L,417L,651L,693L,1131L,1887L,2601L,3129L,3147L,3213L,3609L,3783L,3885L,4203L,4455L,5061L,6345L,6969L,8757L,10269L,11067L,12597L,13443L,13899L,14445L,15453L,15939L,16209L,16545L,17763L,19569L,19827L,20223L,21969L,23307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178082Inst : IEnumerable<long>
{
public static readonly long[] Value=A178082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178082.Bytes);
public long this[int i]=>Value[i];

public static A178082Inst Instance=new A178082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178083
{
public static readonly long[] Value={ 1L,148L,16570L,32614L,66109L,102250L,106870L,124636L,146140L,191773L,305887L,415591L,421828L,552700L,834415L,1013440L,1176505L,1190050L,1306432L,1572082L,1576009L,1850437L,1873684L,1912954L,1921144L,2004997L,2103613L,2376340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178083Inst : IEnumerable<long>
{
public static readonly long[] Value=A178083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178083.Bytes);
public long this[int i]=>Value[i];

public static A178083Inst Instance=new A178083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178084
{
public static readonly long[] Value={ 1L,10L,148L,1606L,1942L,2101L,2227L,4378L,5533L,14416L,16570L,16684L,19573L,20182L,22534L,24760L,26881L,32614L,34798L,36121L,39775L,46516L,51880L,53644L,63346L,63379L,66109L,76819L,79579L,82972L,85795L,87601L,95854L,100885L,102250L,106396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178084Inst : IEnumerable<long>
{
public static readonly long[] Value=A178084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178084.Bytes);
public long this[int i]=>Value[i];

public static A178084Inst Instance=new A178084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178085
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,0L,0L,0L,0L,1L,1L,4L,2L,3L,2L,4L,1L,1L,-2L,0L,-1L,-1L,0L,-2L,1L,1L,4L,0L,3L,1L,3L,0L,4L,1L,1L,0L,2L,-1L,1L,1L,-1L,2L,0L,1L,1L,4L,2L,5L,1L,5L,1L,5L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178085Inst : IEnumerable<long>
{
public static readonly long[] Value=A178085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178085.Bytes);
public long this[int i]=>Value[i];

public static A178085Inst Instance=new A178085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178086
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,-1L,0L,-1L,1L,1L,3L,2L,2L,3L,1L,1L,-3L,0L,-2L,0L,-3L,1L,1L,3L,0L,2L,2L,0L,3L,1L,1L,-1L,2L,-2L,2L,-2L,2L,-1L,1L,1L,3L,2L,4L,2L,2L,4L,2L,3L,1L,1L,-5L,-2L,-4L,0L,-6L,0L,-4L,-2L,-5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178086Inst : IEnumerable<long>
{
public static readonly long[] Value=A178086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178086.Bytes);
public long this[int i]=>Value[i];

public static A178086Inst Instance=new A178086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178087
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,25L,141L,1071L,11011L,154739L,3005187L,81434048L,3101253384L,166823865867L,12719913809811L,1378095292930494L,212524751143894194L,BigInteger.Parse("46713381928627546015"),BigInteger.Parse("14648866052370410611923"),BigInteger.Parse("6558913185973371123604314"),BigInteger.Parse("4195585528812861561212654010") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178087Inst Instance=new A178087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178088
{
public static readonly long[] Value={ 127L,149L,211L,223L,307L,331L,479L,521L,541L,787L,853L,877L,907L,967L,1087L,1151L,1277L,1361L,1399L,1597L,1657L,1693L,1777L,1847L,1931L,1949L,1973L,2129L,2179L,2203L,2237L,2267L,2333L,2503L,2521L,2579L,2609L,2819L,2879L,2999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178088Inst : IEnumerable<long>
{
public static readonly long[] Value=A178088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178088.Bytes);
public long this[int i]=>Value[i];

public static A178088Inst Instance=new A178088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178089
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,26L,164L,1548L,22612L,527016L,20075480L,1272488296L,136039530768L,24791209794352L,7767414503113808L,4214117431305739680L,BigInteger.Parse("3983248890848252043616"),BigInteger.Parse("6594358097712974323610528"),BigInteger.Parse("19210839739434953100591639104"),BigInteger.Parse("98895926239537023373263092515008") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178089Inst Instance=new A178089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178090
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,-1L,0L,1L,0L,0L,-2L,0L,1L,0L,2L,0L,-4L,0L,1L,0L,0L,6L,0L,-6L,0L,1L,0L,-6L,0L,18L,0L,-9L,0L,1L,0L,0L,-24L,0L,36L,0L,-12L,0L,1L,0L,24L,0L,-96L,0L,72L,0L,-16L,0L,1L,0L,0L,120L,0L,-240L,0L,120L,0L,-20L,0L,1L,0L,-120L,0L,600L,0L,-600L,0L,200L,0L,-25L,0L,1L,0L,0L,-720L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178090Inst : IEnumerable<long>
{
public static readonly long[] Value=A178090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178090.Bytes);
public long this[int i]=>Value[i];

public static A178090Inst Instance=new A178090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178091
{
public static readonly long[] Value={ 157L,179L,337L,359L,733L,751L,953L,971L,1097L,1237L,1259L,1381L,1439L,1453L,1471L,1583L,1619L,1723L,1741L,1831L,3019L,3109L,3163L,3257L,3271L,3343L,3347L,3433L,3527L,3541L,3613L,3851L,7253L,7321L,7433L,7523L,7699L,7879L,7901L,9013L,9103L,9161L,9341L,9521L,9679L,9769L,9787L,9967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178091Inst : IEnumerable<long>
{
public static readonly long[] Value=A178091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178091.Bytes);
public long this[int i]=>Value[i];

public static A178091Inst Instance=new A178091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178092
{
public static readonly long[] Value={ 157L,179L,337L,359L,1097L,1237L,1259L,1381L,1439L,1453L,1471L,1583L,1619L,1723L,3019L,3109L,3163L,3257L,3343L,3347L,3527L,7699L,7879L,9679L,10039L,10079L,10273L,10453L,10457L,10651L,10781L,10853L,11083L,11159L,11353L,11447L,11551L,11717L,11731L,11933L,12073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178092Inst : IEnumerable<long>
{
public static readonly long[] Value=A178092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178092.Bytes);
public long this[int i]=>Value[i];

public static A178092Inst Instance=new A178092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178093
{
public static readonly long[] Value={ 733L,751L,953L,971L,1741L,1831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178093Inst : IEnumerable<long>
{
public static readonly long[] Value=A178093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178093.Bytes);
public long this[int i]=>Value[i];

public static A178093Inst Instance=new A178093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178094
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L,2L,3L,5L,2L,7L,3L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178094Inst : IEnumerable<long>
{
public static readonly long[] Value=A178094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178094.Bytes);
public long this[int i]=>Value[i];

public static A178094Inst Instance=new A178094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178095
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,11L,19L,3L,3L,5L,11L,19L,5L,5L,29L,3L,37L,3L,43L,83L,3L,3L,89L,5L,97L,191L,293L,7L,491L,7L,5L,503L,5L,3L,7L,3L,13L,23L,3L,3L,29L,5L,37L,71L,113L,13L,197L,17L,227L,3L,13L,3L,19L,5L,3L,3L,11L,17L,31L,59L,107L,197L,3L,307L,3L,313L,7L,17L,337L,19L,373L,3L,5L,3L,11L,19L,3L,3L,5L,11L,19L,5L,5L,29L,3L,37L,3L,43L,83L,3L,3L,89L,5L,97L,191L,293L,7L,491L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178095Inst : IEnumerable<long>
{
public static readonly long[] Value=A178095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178095.Bytes);
public long this[int i]=>Value[i];

public static A178095Inst Instance=new A178095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178096
{
public static readonly long[] Value={ 5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178096Inst : IEnumerable<long>
{
public static readonly long[] Value=A178096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178096.Bytes);
public long this[int i]=>Value[i];

public static A178096Inst Instance=new A178096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178097
{
public static readonly long[] Value={ 1L,3L,6L,13L,21L,73L,126L,414L,1623L,6870L,12118L,83513L,154909L,530688L,7488221L,59799083L,112109946L,1264732499L,2417355053L,47993257518L,1344401112069L,2924929100020L,4505457087972L,77750773769171L,662158294591369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178097Inst : IEnumerable<long>
{
public static readonly long[] Value=A178097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178097.Bytes);
public long this[int i]=>Value[i];

public static A178097Inst Instance=new A178097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178098
{
public static readonly long[] Value={ 26L,30L,36L,40L,42L,44L,91L,95L,115L,119L,133L,161L,187L,247L,391L,667L,1147L,1591L,1927L,2491L,3127L,4087L,4891L,5767L,7387L,9991L,10807L,11227L,12091L,17947L,23707L,25591L,28891L,30967L,37627L,38407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178098Inst : IEnumerable<long>
{
public static readonly long[] Value=A178098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178098.Bytes);
public long this[int i]=>Value[i];

public static A178098Inst Instance=new A178098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178099
{
public static readonly long[] Value={ 32L,38L,45L,51L,52L,56L,57L,63L,69L,87L,145L,209L,713L,1073L,3233L,3953L,5609L,8633L,11009L,18209L,23393L,31313L,38009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178099Inst : IEnumerable<long>
{
public static readonly long[] Value=A178099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178099.Bytes);
public long this[int i]=>Value[i];

public static A178099Inst Instance=new A178099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178100
{
public static readonly long[] Value={ 26L,45L,50L,51L,54L,56L,57L,62L,63L,64L,65L,69L,77L,80L,81L,85L,86L,87L,90L,92L,93L,94L,98L,99L,110L,114L,116L,117L,118L,119L,122L,123L,124L,125L,128L,129L,132L,133L,134L,135L,140L,141L,144L,146L,147L,152L,153L,154L,155L,158L,159L,160L,161L,164L,165L,170L,171L,174L,175L,176L,177L,182L,183L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178100Inst : IEnumerable<long>
{
public static readonly long[] Value=A178100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178100.Bytes);
public long this[int i]=>Value[i];

public static A178100Inst Instance=new A178100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178101
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,1L,0L,2L,0L,3L,0L,4L,0L,2L,0L,3L,1L,2L,0L,2L,0L,2L,3L,5L,0L,5L,0L,6L,3L,3L,0L,6L,1L,3L,3L,8L,0L,5L,0L,11L,3L,8L,1L,8L,0L,5L,3L,7L,0L,6L,0L,8L,4L,5L,1L,7L,0L,7L,5L,10L,0L,4L,1L,9L,3L,6L,0L,10L,2L,8L,4L,15L,2L,10L,0L,16L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178101Inst : IEnumerable<long>
{
public static readonly long[] Value=A178101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178101.Bytes);
public long this[int i]=>Value[i];

public static A178101Inst Instance=new A178101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178102
{
public static readonly long[] Value={ 1L,2L,1L,8L,4L,4L,16L,6L,1L,20L,25L,26L,4L,10L,10L,12L,1L,13L,9L,43L,44L,16L,61L,52L,56L,16L,62L,16L,22L,22L,64L,70L,24L,44L,80L,28L,59L,30L,72L,1L,92L,31L,97L,106L,34L,106L,36L,4L,136L,110L,64L,40L,40L,9L,42L,1L,133L,134L,46L,81L,64L,146L,151L,152L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178102Inst : IEnumerable<long>
{
public static readonly long[] Value=A178102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178102.Bytes);
public long this[int i]=>Value[i];

public static A178102Inst Instance=new A178102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178103
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-4L,0L,1L,5L,0L,-9L,0L,1L,0L,33L,0L,-16L,0L,1L,-45L,0L,114L,0L,-25L,0L,1L,0L,-408L,0L,290L,0L,-36L,0L,1L,585L,0L,-1890L,0L,615L,0L,-49L,0L,1L,0L,6705L,0L,-6240L,0L,1155L,0L,-64L,0L,1L,-9945L,0L,38835L,0L,-16695L,0L,1988L,0L,-81L,0L,1L,0L,-137340L,0L,157395L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178103Inst : IEnumerable<long>
{
public static readonly long[] Value=A178103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178103.Bytes);
public long this[int i]=>Value[i];

public static A178103Inst Instance=new A178103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178104
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,4L,0L,1L,4L,0L,9L,0L,1L,0L,31L,0L,16L,0L,1L,31L,0L,111L,0L,25L,0L,1L,0L,364L,0L,286L,0L,36L,0L,1L,364L,0L,1794L,0L,610L,0L,49L,0L,1L,0L,5746L,0L,6064L,0L,1149L,0L,64L,0L,1L,5746L,0L,36066L,0L,16405L,0L,1981L,0L,81L,0L,1L,0L,113944L,0L,150901L,0L,38196L,0L,3196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178104Inst : IEnumerable<long>
{
public static readonly long[] Value=A178104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178104.Bytes);
public long this[int i]=>Value[i];

public static A178104Inst Instance=new A178104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178105
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,6L,0L,6L,0L,0L,0L,4L,0L,0L,0L,6L,6L,10L,0L,4L,0L,6L,0L,6L,0L,14L,0L,4L,9L,6L,0L,8L,0L,8L,6L,4L,0L,10L,0L,6L,15L,12L,0L,4L,20L,6L,18L,6L,0L,18L,0L,4L,6L,6L,10L,9L,0L,14L,9L,4L,0L,6L,0L,6L,12L,8L,21L,4L,0L,6L,6L,6L,0L,16L,20L,4L,18L,6L,0L,6L,28L,10L,9L,4L,15L,9L,0L,6L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178105Inst : IEnumerable<long>
{
public static readonly long[] Value=A178105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178105.Bytes);
public long this[int i]=>Value[i];

public static A178105Inst Instance=new A178105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178106
{
public static readonly long[] Value={ 33820044L,28133728L,18569808L,10127744L,5015108L,2289760L,1036368L,435040L,184104L,73056L,28064L,10336L,3760L,1088L,352L,96L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178106Inst : IEnumerable<long>
{
public static readonly long[] Value=A178106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178106.Bytes);
public long this[int i]=>Value[i];

public static A178106Inst Instance=new A178106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178107
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-2L,0L,1L,3L,0L,-5L,0L,1L,0L,9L,0L,-8L,0L,1L,-15L,0L,34L,0L,-13L,0L,1L,0L,-60L,0L,74L,0L,-18L,0L,1L,105L,0L,-298L,0L,165L,0L,-25L,0L,1L,0L,525L,0L,-816L,0L,291L,0L,-32L,0L,1L,-945L,0L,3207L,0L,-2301L,0L,516L,0L,-41L,0L,1L,0L,-5670L,0L,10551L,0L,-4920L,0L,804L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178107Inst : IEnumerable<long>
{
public static readonly long[] Value=A178107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178107.Bytes);
public long this[int i]=>Value[i];

public static A178107Inst Instance=new A178107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178108
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,2L,0L,5L,0L,1L,0L,7L,0L,8L,0L,1L,7L,0L,31L,0L,13L,0L,1L,0L,38L,0L,70L,0L,18L,0L,1L,38L,0L,248L,0L,160L,0L,25L,0L,1L,0L,286L,0L,728L,0L,285L,0L,32L,0L,1L,286L,0L,2470L,0L,2153L,0L,509L,0L,41L,0L,1L,0L,2756L,0L,8929L,0L,4698L,0L,796L,0L,50L,0L,1L,2756L,0L,29543L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178108Inst : IEnumerable<long>
{
public static readonly long[] Value=A178108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178108.Bytes);
public long this[int i]=>Value[i];

public static A178108Inst Instance=new A178108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178109
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,6L,0L,6L,0L,0L,0L,4L,0L,0L,0L,8L,6L,10L,0L,8L,0L,14L,0L,14L,0L,15L,0L,14L,9L,14L,0L,9L,0L,10L,15L,20L,0L,22L,0L,22L,21L,18L,0L,21L,20L,22L,24L,24L,0L,26L,0L,28L,24L,30L,10L,28L,0L,30L,24L,26L,0L,33L,0L,30L,20L,30L,21L,28L,0L,38L,33L,38L,0L,28L,20L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178109Inst : IEnumerable<long>
{
public static readonly long[] Value=A178109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178109.Bytes);
public long this[int i]=>Value[i];

public static A178109Inst Instance=new A178109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178110
{
public static readonly long[] Value={ 16L,18L,26L,27L,32L,34L,40L,45L,50L,56L,58L,63L,64L,72L,74L,80L,81L,82L,88L,90L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178110Inst : IEnumerable<long>
{
public static readonly long[] Value=A178110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178110.Bytes);
public long this[int i]=>Value[i];

public static A178110Inst Instance=new A178110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178111
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,-1L,0L,3L,0L,-3L,0L,1L,0L,-1L,0L,3L,0L,-3L,0L,1L,1L,0L,-4L,0L,6L,0L,-4L,0L,1L,0L,1L,0L,-4L,0L,6L,0L,-4L,0L,1L,-1L,0L,5L,0L,-10L,0L,10L,0L,-5L,0L,1L,0L,-1L,0L,5L,0L,-10L,0L,10L,0L,-5L,0L,1L,1L,0L,-6L,0L,15L,0L,-20L,0L,15L,0L,-6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178111Inst : IEnumerable<long>
{
public static readonly long[] Value=A178111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178111.Bytes);
public long this[int i]=>Value[i];

public static A178111Inst Instance=new A178111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178112
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,1L,0L,3L,0L,3L,0L,1L,0L,1L,0L,3L,0L,3L,0L,1L,1L,0L,4L,0L,6L,0L,4L,0L,1L,0L,1L,0L,4L,0L,6L,0L,4L,0L,1L,1L,0L,5L,0L,10L,0L,10L,0L,5L,0L,1L,0L,1L,0L,5L,0L,10L,0L,10L,0L,5L,0L,1L,1L,0L,6L,0L,15L,0L,20L,0L,15L,0L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178112Inst : IEnumerable<long>
{
public static readonly long[] Value=A178112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178112.Bytes);
public long this[int i]=>Value[i];

public static A178112Inst Instance=new A178112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178113
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,10L,13L,26L,35L,70L,96L,192L,267L,534L,750L,1500L,2123L,4246L,6046L,12092L,17303L,34606L,49721L,99442L,143365L,286730L,414584L,829168L,1201917L,2403834L,3492117L,6984234L,10165779L,20331558L,29643870L,59287740L,86574831L,173149662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178113Inst : IEnumerable<long>
{
public static readonly long[] Value=A178113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178113.Bytes);
public long this[int i]=>Value[i];

public static A178113Inst Instance=new A178113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178114
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,0L,8L,6L,-21L,-37L,45L,175L,-22L,-703L,-533L,2370L,4321L,-5930L,-23560L,3534L,104035L,81083L,-376267L,-705158L,993738L,4047745L,-604007L,-18622243L,-14895477L,69622834L,133284470L,-188549209L,-784970693L,110402283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178114Inst : IEnumerable<long>
{
public static readonly long[] Value=A178114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178114.Bytes);
public long this[int i]=>Value[i];

public static A178114Inst Instance=new A178114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178115
{
public static readonly long[] Value={ 1L,-2L,-2L,5L,5L,-13L,-13L,34L,34L,-89L,-89L,233L,233L,-610L,-610L,1597L,1597L,-4181L,-4181L,10946L,10946L,-28657L,-28657L,75025L,75025L,-196418L,-196418L,514229L,514229L,-1346269L,-1346269L,3524578L,3524578L,-9227465L,-9227465L,24157817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178115Inst : IEnumerable<long>
{
public static readonly long[] Value=A178115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178115.Bytes);
public long this[int i]=>Value[i];

public static A178115Inst Instance=new A178115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178116
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,3L,0L,1L,4L,0L,7L,0L,1L,0L,22L,0L,13L,0L,1L,36L,0L,85L,0L,22L,0L,1L,0L,300L,0L,241L,0L,34L,0L,1L,576L,0L,1660L,0L,593L,0L,50L,0L,1L,0L,6576L,0L,6480L,0L,1273L,0L,70L,0L,1L,14400L,0L,48076L,0L,21305L,0L,2523L,0L,95L,0L,1L,0L,211680L,0L,242476L,0L,59495L,0L,4623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178116Inst : IEnumerable<long>
{
public static readonly long[] Value=A178116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178116.Bytes);
public long this[int i]=>Value[i];

public static A178116Inst Instance=new A178116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178117
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-3L,0L,1L,3L,0L,-7L,0L,1L,0L,17L,0L,-13L,0L,1L,-17L,0L,69L,0L,-22L,0L,1L,0L,-155L,0L,201L,0L,-34L,0L,1L,155L,0L,-959L,0L,507L,0L,-50L,0L,1L,0L,2073L,0L,-4001L,0L,1107L,0L,-70L,0L,1L,-2073L,0L,18077L,0L,-13964L,0L,2227L,0L,-95L,0L,1L,0L,-38227L,0L,101861L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178117Inst : IEnumerable<long>
{
public static readonly long[] Value=A178117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178117.Bytes);
public long this[int i]=>Value[i];

public static A178117Inst Instance=new A178117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178118
{
public static readonly long[] Value={ 0L,1L,1L,2L,7L,25L,100L,469L,2481L,14406L,90995L,621553L,4561112L,35736921L,297435521L,2618575194L,24297706927L,236870849417L,2419213831452L,25820011544781L,287327296473585L,3326999636488190L,40011485288491131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178118Inst : IEnumerable<long>
{
public static readonly long[] Value=A178118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178118.Bytes);
public long this[int i]=>Value[i];

public static A178118Inst Instance=new A178118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178119
{
public static readonly long[] Value={ 1L,2L,5L,16L,64L,308L,1727L,11008L,78244L,611060L,5184338L,47366320L,462782080L,4807659368L,52853722811L,612426360832L,7453621425532L,94997205901940L,1264555335831662L,17540102647480336L,252979919852470672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178119Inst : IEnumerable<long>
{
public static readonly long[] Value=A178119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178119.Bytes);
public long this[int i]=>Value[i];

public static A178119Inst Instance=new A178119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178120
{
public static readonly long[] Value={ 1L,-2L,1L,7L,-6L,1L,-36L,40L,-12L,1L,253L,-326L,131L,-20L,1L,-2278L,3233L,-1552L,324L,-30L,1L,25059L,-38140L,20678L,-5260L,675L,-42L,1L,-325768L,523456L,-310560L,90754L,-14380L,1252L,-56L,1L,4886521L,-8205244L,5223602L,-1694244L,312059L,-33866L,2135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178120Inst : IEnumerable<long>
{
public static readonly long[] Value=A178120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178120.Bytes);
public long this[int i]=>Value[i];

public static A178120Inst Instance=new A178120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178121
{
public static readonly long[] Value={ 1L,2L,1L,5L,6L,1L,16L,32L,12L,1L,64L,180L,109L,20L,1L,308L,1111L,934L,276L,30L,1L,1727L,7554L,8095L,3352L,585L,42L,1L,11008L,56228L,72884L,39006L,9580L,1100L,56L,1L,78244L,454572L,688562L,451992L,144706L,23396L,1897L,72L,1L,611060L,3962218L,6845904L,5317440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178121Inst : IEnumerable<long>
{
public static readonly long[] Value=A178121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178121.Bytes);
public long this[int i]=>Value[i];

public static A178121Inst Instance=new A178121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178122
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,27L,27L,1L,1L,82L,240L,82L,1L,1L,245L,1700L,1700L,245L,1L,1L,732L,10571L,23586L,10571L,732L,1L,1L,2191L,60697L,259791L,259791L,60697L,2191L,1L,1L,6566L,331666L,2485398L,4675152L,2485398L,331666L,6566L,1L,1L,19689L,1756410L,21708138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178122Inst : IEnumerable<long>
{
public static readonly long[] Value=A178122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178122.Bytes);
public long this[int i]=>Value[i];

public static A178122Inst Instance=new A178122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178123
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,61L,269L,1337L,7354L,44155L,286397L,1990427L,14725738L,115356349L,952592288L,8261093885L,74994333994L,710656444489L,7012302313061L,71892455879393L,764331907463476L,8411953721081635L,95684448908132498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178123Inst : IEnumerable<long>
{
public static readonly long[] Value=A178123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178123.Bytes);
public long this[int i]=>Value[i];

public static A178123Inst Instance=new A178123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178124
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-3L,1L,0L,7L,-6L,1L,-5L,-13L,26L,-10L,1L,25L,11L,-101L,69L,-15L,1L,-105L,76L,383L,-425L,150L,-21L,1L,460L,-758L,-1494L,2599L,-1310L,286L,-28L,1L,-2315L,5536L,6215L,-16761L,11129L,-3325L,497L,-36L,1L,13935L,-40769L,-27989L,118079L,-97272L,36764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178124Inst : IEnumerable<long>
{
public static readonly long[] Value=A178124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178124.Bytes);
public long this[int i]=>Value[i];

public static A178124Inst Instance=new A178124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178125
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,5L,11L,6L,1L,16L,45L,34L,10L,1L,61L,208L,197L,81L,15L,1L,269L,1068L,1204L,626L,165L,21L,1L,1337L,6017L,7810L,4863L,1640L,302L,28L,1L,7354L,36801L,53762L,38742L,15781L,3760L,511L,36L,1L,44155L,242242L,391797L,319197L,151487L,43962L,7805L,814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178125Inst : IEnumerable<long>
{
public static readonly long[] Value=A178125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178125.Bytes);
public long this[int i]=>Value[i];

public static A178125Inst Instance=new A178125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178126
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,9L,9L,24L,56L,24L,16L,120L,250L,275L,50L,25L,720L,1884L,1350L,960L,90L,36L,5040L,12348L,14896L,5145L,2695L,147L,49L,40320L,114624L,105056L,80416L,15680L,6496L,224L,64L,362880L,986256L,1282284L,605556L,336609L,40824L,13986L,324L,81L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178126Inst : IEnumerable<long>
{
public static readonly long[] Value=A178126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178126.Bytes);
public long this[int i]=>Value[i];

public static A178126Inst Instance=new A178126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178127
{
public static readonly long[] Value={ 149L,179L,227L,239L,347L,431L,569L,599L,641L,821L,1019L,1049L,1061L,1427L,1487L,1607L,1787L,1997L,2081L,2129L,2237L,2267L,2657L,2687L,2711L,2789L,2999L,3167L,3257L,3299L,3359L,3527L,3539L,3581L,3671L,3917L,4091L,4127L,4229L,4241L,4337L,4547L,4637L,4649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178127Inst : IEnumerable<long>
{
public static readonly long[] Value=A178127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178127.Bytes);
public long this[int i]=>Value[i];

public static A178127Inst Instance=new A178127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178128
{
public static readonly long[] Value={ 11L,17L,29L,41L,59L,71L,101L,107L,149L,179L,227L,239L,269L,281L,311L,347L,419L,431L,461L,569L,599L,641L,659L,809L,821L,827L,857L,881L,1019L,1031L,1049L,1061L,1091L,1151L,1229L,1277L,1289L,1301L,1427L,1451L,1481L,1487L,1607L,1667L,1721L,1787L,1871L,1877L,1997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178128Inst : IEnumerable<long>
{
public static readonly long[] Value=A178128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178128.Bytes);
public long this[int i]=>Value[i];

public static A178128Inst Instance=new A178128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178129
{
public static readonly long[] Value={ 0L,2L,8L,23L,47L,87L,147L,224L,328L,463L,623L,821L,1049L,1322L,1644L,2004L,2420L,2896L,3418L,4007L,4647L,5361L,6153L,7004L,7940L,8940L,10032L,11220L,12480L,13843L,15313L,16863L,18527L,20276L,22146L,24141L,26229L,28449L,30767L,33224L,35824L,38530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178129Inst : IEnumerable<long>
{
public static readonly long[] Value=A178129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178129.Bytes);
public long this[int i]=>Value[i];

public static A178129Inst Instance=new A178129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178130
{
public static readonly long[] Value={ 8L,19L,24L,28L,32L,36L,75L,81L,88L,96L,136L,176L,224L,225L,250L,328L,369L,395L,432L,432L,468L,500L,512L,537L,648L,701L,710L,864L,980L,1000L,1078L,1089L,1125L,1216L,1225L,1296L,1440L,1536L,1620L,1734L,1764L,1792L,1800L,1944L,1944L,2000L,2028L,2048L,2178L,2304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178130Inst : IEnumerable<long>
{
public static readonly long[] Value=A178130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178130.Bytes);
public long this[int i]=>Value[i];

public static A178130Inst Instance=new A178130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178131
{
public static readonly long[] Value={ 1L,4L,5L,5L,7L,4L,8L,6L,5L,2L,0L,5L,1L,0L,3L,0L,5L,8L,9L,3L,9L,7L,8L,9L,0L,6L,8L,1L,2L,4L,6L,1L,1L,9L,1L,4L,5L,1L,1L,4L,9L,0L,4L,1L,0L,1L,7L,8L,2L,5L,8L,3L,2L,7L,6L,9L,3L,0L,6L,8L,9L,7L,8L,6L,5L,7L,1L,8L,0L,0L,3L,1L,0L,3L,9L,0L,7L,8L,3L,0L,9L,7L,6L,3L,6L,0L,6L,3L,8L,0L,4L,6L,1L,6L,4L,9L,0L,2L,9L,9L,8L,8L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178131Inst : IEnumerable<long>
{
public static readonly long[] Value=A178131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178131.Bytes);
public long this[int i]=>Value[i];

public static A178131Inst Instance=new A178131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178132
{
public static readonly long[] Value={ 0L,1L,5L,10L,19L,29L,42L,56L,72L,89L,109L,130L,155L,181L,210L,240L,274L,309L,345L,382L,420L,459L,499L,540L,582L,627L,673L,722L,772L,823L,875L,928L,982L,1037L,1093L,1150L,1208L,1267L,1328L,1390L,1453L,1517L,1582L,1648L,1716L,1785L,1855L,1926L,1999L,2073L,2148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178132Inst : IEnumerable<long>
{
public static readonly long[] Value=A178132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178132.Bytes);
public long this[int i]=>Value[i];

public static A178132Inst Instance=new A178132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178133
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,3L,5L,3L,5L,4L,4L,9L,5L,4L,10L,6L,7L,8L,8L,11L,10L,8L,8L,14L,11L,12L,11L,13L,10L,13L,14L,15L,14L,16L,17L,12L,14L,14L,18L,19L,17L,19L,15L,21L,16L,17L,23L,22L,17L,16L,21L,24L,28L,24L,21L,23L,20L,24L,22L,24L,21L,27L,28L,28L,26L,28L,32L,19L,31L,29L,27L,29L,28L,22L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178133Inst : IEnumerable<long>
{
public static readonly long[] Value=A178133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178133.Bytes);
public long this[int i]=>Value[i];

public static A178133Inst Instance=new A178133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178134
{
public static readonly long[] Value={ 0L,1L,1L,2L,-3L,-2L,-32L,-81L,-311L,-810L,-2515L,-6864L,-19944L,-55043L,-156023L,-433522L,-1217427L,-3391226L,-9488456L,-26462205L,-73933535L,-206293134L,-576040339L,-1607642688L,-4488069168L,-12526662167L,-34967630447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178134Inst : IEnumerable<long>
{
public static readonly long[] Value=A178134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178134.Bytes);
public long this[int i]=>Value[i];

public static A178134Inst Instance=new A178134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178135
{
public static readonly long[] Value={ 6314447L,7855163L,9715103L,10133467L,10851497L,12820427L,13442537L,14064317L,14172007L,15945437L,18715547L,20208163L,21488263L,22916767L,23924827L,24079357L,25660883L,27099283L,27245627L,27613093L,29162977L,31215643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178135Inst : IEnumerable<long>
{
public static readonly long[] Value=A178135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178135.Bytes);
public long this[int i]=>Value[i];

public static A178135Inst Instance=new A178135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178136
{
public static readonly long[] Value={ 4911311L,5309599L,9113323L,11355857L,11397163L,13940117L,14306263L,14313587L,14585149L,17172581L,21126169L,24419341L,24581863L,24861691L,24922351L,25308859L,26241811L,26722583L,27408253L,28740979L,29675197L,30045871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178136Inst : IEnumerable<long>
{
public static readonly long[] Value=A178136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178136.Bytes);
public long this[int i]=>Value[i];

public static A178136Inst Instance=new A178136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178137
{
public static readonly long[] Value={ 2L,5L,10L,17L,28L,51L,94L,161L,250L,351L,460L,671L,894L,1127L,1560L,2003L,2680L,3467L,4344L,5231L,6240L,7349L,8472L,9695L,11806L,14027L,16360L,19581L,22904L,26247L,29680L,34247L,39690L,47479L,55356L,64243L,73242L,82243L,91254L,101141L,111042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178137Inst : IEnumerable<long>
{
public static readonly long[] Value=A178137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178137.Bytes);
public long this[int i]=>Value[i];

public static A178137Inst Instance=new A178137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178138
{
public static readonly long[] Value={ 2L,11L,37L,97L,219L,444L,830L,1454L,2416L,3845L,5901L,8781L,12723L,18008L,24964L,33972L,45472L,59965L,78019L,100273L,127439L,160308L,199754L,246740L,302326L,367673L,444045L,532813L,635457L,753570L,888872L,1043214L,1218584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178138Inst : IEnumerable<long>
{
public static readonly long[] Value=A178138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178138.Bytes);
public long this[int i]=>Value[i];

public static A178138Inst Instance=new A178138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178139
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,4L,1L,4L,2L,6L,4L,1L,6L,8L,2L,2L,4L,7L,1L,3L,6L,12L,1L,7L,1L,2L,2L,12L,6L,16L,1L,1L,3L,4L,4L,1L,7L,14L,2L,2L,4L,1L,5L,3L,6L,24L,2L,2L,4L,11L,6L,2L,2L,4L,1L,4L,2L,21L,6L,3L,3L,32L,4L,2L,4L,2L,5L,5L,2L,8L,6L,3L,1L,2L,5L,14L,4L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178139Inst : IEnumerable<long>
{
public static readonly long[] Value=A178139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178139.Bytes);
public long this[int i]=>Value[i];

public static A178139Inst Instance=new A178139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178140
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,5040L,589824L,6531840L,98304000L,548856000L,3822059520L,14841066240L,67711795200L,208702494000L,726855843840L,1906252508160L,5500708061184L,12796310741760L,32142458880000L,68146033536000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178140Inst : IEnumerable<long>
{
public static readonly long[] Value=A178140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178140.Bytes);
public long this[int i]=>Value[i];

public static A178140Inst Instance=new A178140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178141
{
public static readonly long[] Value={ 4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178141Inst : IEnumerable<long>
{
public static readonly long[] Value=A178141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178141.Bytes);
public long this[int i]=>Value[i];

public static A178141Inst Instance=new A178141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178142
{
public static readonly long[] Value={ 0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178142Inst : IEnumerable<long>
{
public static readonly long[] Value=A178142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178142.Bytes);
public long this[int i]=>Value[i];

public static A178142Inst Instance=new A178142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178143
{
public static readonly long[] Value={ 0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178143Inst : IEnumerable<long>
{
public static readonly long[] Value=A178143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178143.Bytes);
public long this[int i]=>Value[i];

public static A178143Inst Instance=new A178143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178144
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,5L,0L,2L,3L,7L,0L,5L,0L,2L,8L,2L,0L,5L,0L,7L,3L,2L,0L,5L,5L,2L,3L,2L,0L,10L,0L,2L,3L,2L,5L,5L,0L,2L,3L,7L,0L,5L,0L,2L,8L,2L,0L,5L,0L,7L,3L,2L,0L,5L,5L,2L,3L,2L,0L,10L,0L,2L,3L,2L,5L,5L,0L,2L,3L,7L,0L,5L,0L,2L,8L,2L,0L,5L,0L,7L,3L,2L,0L,5L,5L,2L,3L,2L,0L,10L,0L,2L,3L,2L,5L,5L,0L,2L,3L,7L,0L,5L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178144Inst : IEnumerable<long>
{
public static readonly long[] Value=A178144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178144.Bytes);
public long this[int i]=>Value[i];

public static A178144Inst Instance=new A178144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178145
{
public static readonly long[] Value={ 1L,2L,17L,32L,137L,247L,312L,347L,542L,577L,942L,1572L,2167L,2607L,2622L,2677L,3007L,3152L,3237L,3502L,3712L,4217L,5287L,5807L,7297L,8557L,9222L,10497L,11202L,11582L,12037L,12877L,13282L,13507L,13787L,14802L,16307L,16522L,16852L,18307L,19422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178145Inst : IEnumerable<long>
{
public static readonly long[] Value=A178145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178145.Bytes);
public long this[int i]=>Value[i];

public static A178145Inst Instance=new A178145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178146
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,2L,1L,0L,2L,0L,2L,1L,1L,0L,2L,1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,2L,1L,0L,2L,0L,2L,1L,1L,0L,2L,1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,2L,1L,0L,2L,0L,2L,1L,1L,0L,2L,1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178146Inst : IEnumerable<long>
{
public static readonly long[] Value=A178146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178146.Bytes);
public long this[int i]=>Value[i];

public static A178146Inst Instance=new A178146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178147
{
public static readonly long[] Value={ 0L,4L,9L,4L,25L,13L,0L,4L,9L,29L,0L,13L,0L,4L,34L,4L,0L,13L,0L,29L,9L,4L,0L,13L,25L,4L,9L,4L,0L,38L,0L,4L,9L,4L,25L,13L,0L,4L,9L,29L,0L,13L,0L,4L,34L,4L,0L,13L,0L,29L,9L,4L,0L,13L,25L,4L,9L,4L,0L,38L,0L,4L,9L,4L,25L,13L,0L,4L,9L,29L,0L,13L,0L,4L,34L,4L,0L,13L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178147Inst : IEnumerable<long>
{
public static readonly long[] Value=A178147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178147.Bytes);
public long this[int i]=>Value[i];

public static A178147Inst Instance=new A178147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178148
{
public static readonly long[] Value={ 1L,3L,1L,8L,3L,9L,0L,6L,2L,5L,0L,6L,0L,3L,9L,8L,6L,2L,4L,6L,5L,9L,1L,7L,1L,9L,4L,0L,2L,0L,3L,6L,7L,1L,3L,1L,7L,9L,3L,6L,3L,7L,8L,3L,8L,7L,2L,6L,2L,7L,4L,2L,5L,8L,0L,0L,8L,7L,1L,8L,0L,7L,5L,4L,6L,6L,3L,8L,1L,6L,2L,5L,5L,1L,1L,2L,0L,9L,6L,3L,6L,7L,7L,9L,0L,0L,3L,0L,7L,6L,7L,5L,7L,3L,7L,2L,1L,6L,4L,2L,5L,1L,8L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178148Inst : IEnumerable<long>
{
public static readonly long[] Value=A178148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178148.Bytes);
public long this[int i]=>Value[i];

public static A178148Inst Instance=new A178148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178149
{
public static readonly long[] Value={ 1L,7L,3L,1L,5L,3L,0L,2L,1L,3L,4L,6L,0L,7L,4L,4L,3L,9L,9L,7L,2L,1L,1L,8L,7L,0L,5L,3L,3L,2L,6L,5L,7L,1L,4L,0L,1L,8L,8L,3L,8L,6L,5L,8L,0L,7L,4L,3L,9L,0L,5L,1L,9L,5L,8L,2L,1L,3L,0L,2L,1L,3L,9L,6L,2L,8L,3L,0L,8L,8L,6L,8L,8L,9L,0L,8L,3L,8L,6L,4L,9L,0L,0L,6L,9L,6L,7L,6L,8L,0L,2L,0L,1L,8L,1L,5L,5L,0L,9L,6L,7L,9L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178149Inst : IEnumerable<long>
{
public static readonly long[] Value=A178149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178149.Bytes);
public long this[int i]=>Value[i];

public static A178149Inst Instance=new A178149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178150
{
public static readonly long[] Value={ 11L,19L,31L,71L,79L,101L,103L,109L,167L,211L,223L,263L,293L,337L,367L,379L,419L,431L,461L,479L,503L,571L,601L,659L,769L,839L,967L,1009L,1039L,1049L,1087L,1151L,1223L,1231L,1427L,1451L,1511L,1553L,1559L,1663L,1699L,1741L,1747L,1759L,1931L,1951L,2011L,2089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178150Inst : IEnumerable<long>
{
public static readonly long[] Value=A178150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178150.Bytes);
public long this[int i]=>Value[i];

public static A178150Inst Instance=new A178150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178151
{
public static readonly long[] Value={ 1L,1L,2L,4L,3L,4L,6L,7L,7L,9L,9L,10L,12L,14L,13L,19L,15L,18L,21L,18L,22L,25L,22L,24L,25L,28L,31L,27L,28L,34L,40L,34L,39L,37L,41L,39L,42L,47L,43L,52L,45L,54L,48L,49L,54L,57L,59L,64L,57L,58L,67L,60L,73L,64L,72L,67L,73L,69L,70L,75L,73L,81L,87L,78L,79L,87L,84L,94L,87L,88L,99L,96L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178151Inst : IEnumerable<long>
{
public static readonly long[] Value=A178151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178151.Bytes);
public long this[int i]=>Value[i];

public static A178151Inst Instance=new A178151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178152
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,4L,3L,4L,7L,6L,9L,10L,9L,9L,13L,10L,15L,15L,14L,18L,17L,16L,22L,24L,25L,23L,22L,27L,28L,29L,25L,34L,30L,37L,34L,39L,39L,36L,43L,37L,45L,41L,48L,49L,45L,48L,52L,49L,57L,58L,52L,60L,52L,64L,59L,67L,62L,69L,70L,66L,73L,72L,68L,78L,79L,78L,84L,79L,87L,88L,80L,87L,93L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178152Inst : IEnumerable<long>
{
public static readonly long[] Value=A178152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178152.Bytes);
public long this[int i]=>Value[i];

public static A178152Inst Instance=new A178152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178153
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,0L,3L,3L,0L,3L,0L,0L,3L,5L,0L,9L,0L,3L,7L,0L,5L,9L,0L,0L,0L,5L,9L,0L,0L,5L,15L,0L,9L,0L,7L,0L,3L,11L,0L,15L,0L,13L,0L,0L,9L,9L,7L,15L,0L,0L,15L,0L,21L,0L,13L,0L,11L,0L,0L,9L,0L,9L,19L,0L,0L,9L,0L,15L,0L,0L,19L,9L,0L,9L,17L,0L,0L,0L,0L,27L,0L,21L,0L,15L,15L,0L,0L,0L,7L,21L,25L,7L,27L,9L,21L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178153Inst : IEnumerable<long>
{
public static readonly long[] Value=A178153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178153.Bytes);
public long this[int i]=>Value[i];

public static A178153Inst Instance=new A178153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178154
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,3L,3L,5L,9L,3L,7L,5L,9L,5L,9L,5L,15L,9L,7L,3L,11L,15L,13L,9L,9L,7L,15L,15L,21L,13L,11L,9L,9L,19L,9L,15L,19L,9L,9L,17L,27L,21L,15L,15L,7L,21L,25L,7L,27L,9L,21L,15L,9L,27L,15L,21L,25L,13L,15L,13L,9L,23L,33L,15L,15L,31L,13L,15L,21L,15L,15L,21L,9L,21L,33L,21L,21L,9L,29L,9L,31L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178154Inst : IEnumerable<long>
{
public static readonly long[] Value=A178154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178154.Bytes);
public long this[int i]=>Value[i];

public static A178154Inst Instance=new A178154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178155
{
public static readonly long[] Value={ 1L,3L,7L,17L,37L,85L,189L,471L,967L,2033L,4493L,10621L,23461L,52841L,127745L,340473L,708489L,1367785L,2738841L,5675977L,12313209L,27929825L,66361381L,162909213L,361319381L,780460693L,1722272781L,3904263759L,9528920767L,24294326763L,66213009251L,187941084483L,395937137667L,756194730883L,1395731222259L,2540709556499L,4903320997075L,9814465115099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178155Inst : IEnumerable<long>
{
public static readonly long[] Value=A178155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178155.Bytes);
public long this[int i]=>Value[i];

public static A178155Inst Instance=new A178155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178156
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,17L,19L,22L,23L,26L,29L,31L,34L,37L,38L,41L,43L,46L,47L,53L,58L,59L,61L,62L,67L,71L,73L,74L,79L,82L,83L,86L,89L,94L,97L,101L,103L,106L,107L,109L,113L,118L,122L,127L,131L,134L,137L,139L,142L,146L,149L,151L,157L,158L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178156Inst : IEnumerable<long>
{
public static readonly long[] Value=A178156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178156.Bytes);
public long this[int i]=>Value[i];

public static A178156Inst Instance=new A178156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178157
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,24L,26L,28L,30L,33L,36L,39L,40L,44L,48L,50L,55L,60L,66L,70L,77L,80L,88L,90L,99L,100L,110L,120L,130L,140L,150L,160L,170L,180L,190L,200L,210L,220L,230L,240L,250L,260L,270L,280L,290L,300L,330L,360L,390L,400L,420L,440L,460L,480L,500L,510L,520L,530L,540L,550L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178157Inst : IEnumerable<long>
{
public static readonly long[] Value=A178157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178157.Bytes);
public long this[int i]=>Value[i];

public static A178157Inst Instance=new A178157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178158
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,15L,21L,22L,24L,25L,31L,32L,33L,35L,36L,41L,42L,44L,45L,48L,51L,52L,55L,61L,62L,63L,64L,65L,66L,71L,72L,75L,77L,81L,82L,84L,85L,88L,91L,92L,93L,95L,96L,99L,101L,102L,104L,105L,125L,201L,202L,204L,205L,208L,225L,301L,302L,303L,304L,305L,306L,312L,315L,325L,375L,401L,402L,404L,405L,408L,425L,501L,502L,504L,505L,525L,601L,602L,603L,604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178158Inst : IEnumerable<long>
{
public static readonly long[] Value=A178158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178158.Bytes);
public long this[int i]=>Value[i];

public static A178158Inst Instance=new A178158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178159
{
public static readonly long[] Value={ 1L,2L,8L,22L,68L,188L,532L,1444L,3921L,10446L,27704L,72714L,189912L,492760L,1273064L,3273896L,8389489L,21423994L,54550728L,138520286L,350899964L,886925652L,2237284668L,5633150988L,14159465505L,35535456518L,89053087224L,222870328210L,557074041840L,1390807477040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178159Inst : IEnumerable<long>
{
public static readonly long[] Value=A178159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178159.Bytes);
public long this[int i]=>Value[i];

public static A178159Inst Instance=new A178159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178160
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,21L,22L,23L,24L,25L,26L,27L,31L,32L,33L,34L,35L,36L,37L,42L,43L,44L,45L,46L,47L,48L,52L,53L,54L,55L,56L,57L,58L,62L,63L,64L,65L,66L,67L,68L,72L,73L,74L,75L,76L,77L,78L,82L,83L,84L,85L,86L,87L,88L,92L,93L,94L,95L,96L,97L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178160Inst : IEnumerable<long>
{
public static readonly long[] Value=A178160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178160.Bytes);
public long this[int i]=>Value[i];

public static A178160Inst Instance=new A178160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178161
{
public static readonly long[] Value={ 9L,63L,296L,693L,4117L,14071L,79586L,232069L,1356627L,4222935L,24394044L,73910079L,429075206L,1314629842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178161Inst : IEnumerable<long>
{
public static readonly long[] Value=A178161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178161.Bytes);
public long this[int i]=>Value[i];

public static A178161Inst Instance=new A178161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178162
{
public static readonly long[] Value={ 3755L,48269854L,15751525912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178162Inst : IEnumerable<long>
{
public static readonly long[] Value=A178162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178162.Bytes);
public long this[int i]=>Value[i];

public static A178162Inst Instance=new A178162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178163
{
public static readonly long[] Value={ 1L,1L,8L,1L,1L,6L,9L,1L,1L,1L,8L,1L,1L,1L,6L,1L,1L,1L,6L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,1L,6L,1L,1L,3L,9L,1L,1L,1L,6L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,3L,8L,1L,1L,8L,9L,1L,1L,1L,5L,1L,1L,1L,9L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,2L,9L,1L,1L,8L,9L,1L,1L,5L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178163Inst : IEnumerable<long>
{
public static readonly long[] Value=A178163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178163.Bytes);
public long this[int i]=>Value[i];

public static A178163Inst Instance=new A178163Inst();

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