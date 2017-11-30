using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A244882
{
public static readonly long[] Value={ 1L,8L,35L,110L,280L,616L,1218L,2220L,3795L,6160L,9581L,14378L,20930L,29680L,41140L,55896L,74613L,98040L,127015L,162470L,205436L,257048L,318550L,391300L,476775L,576576L,692433L,826210L,979910L,1155680L,1355816L,1582768L,1839145L,2127720L,2451435L,2813406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244882Inst : IEnumerable<long>
{
public static readonly long[] Value=A244882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244882.Bytes);
public long this[int i]=>Value[i];

public static A244882Inst Instance=new A244882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244883
{
public static readonly long[] Value={ 1L,14L,100L,472L,1691L,4988L,12744L,29160L,61149L,119482L,220220L,386464L,650455L,1056056L,1661648L,2543472L,3799449L,5553510L,7960468L,11211464L,15540019L,21228724L,28616600L,38107160L,50177205L,65386386L,84387564L,107938000L,136911407L,172310896L,215282848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244883Inst : IEnumerable<long>
{
public static readonly long[] Value=A244883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244883.Bytes);
public long this[int i]=>Value[i];

public static A244883Inst Instance=new A244883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244884
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,12L,30L,76L,196L,512L,1353L,3610L,9713L,26324L,71799L,196938L,542895L,1503312L,4179603L,11662902L,32652735L,91695540L,258215664L,728997192L,2062967382L,5850674704L,16626415975L,47337954326L,135015505407L,385719506620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244884Inst : IEnumerable<long>
{
public static readonly long[] Value=A244884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244884.Bytes);
public long this[int i]=>Value[i];

public static A244884Inst Instance=new A244884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244885
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,41L,121L,354L,1021L,2901L,8130L,22513L,61713L,167746L,452789L,1215197L,3246050L,8637641L,22912633L,60624546L,160075117L,421960101L,1110785922L,2920883425L,7673884449L,20146907266L,52863306341L,138644338349L,363489139106L,952695494201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244885Inst : IEnumerable<long>
{
public static readonly long[] Value=A244885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244885.Bytes);
public long this[int i]=>Value[i];

public static A244885Inst Instance=new A244885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244886
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,22L,56L,147L,393L,1065L,2915L,8042L,22330L,62339L,174837L,492313L,1391134L,3943130L,11207594L,31934552L,91197474L,260969372L,748176873L,2148622932L,6180146228L,17801978083L,51347929943L,148293450023L,428774359142L,1241110916678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244886Inst : IEnumerable<long>
{
public static readonly long[] Value=A244886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244886.Bytes);
public long this[int i]=>Value[i];

public static A244886Inst Instance=new A244886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244887
{
public static readonly long[] Value={ 2L,20L,135L,770L,4004L,19656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244887Inst : IEnumerable<long>
{
public static readonly long[] Value=A244887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244887.Bytes);
public long this[int i]=>Value[i];

public static A244887Inst Instance=new A244887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244888
{
public static readonly long[] Value={ 1L,-2L,1L,6L,-6L,1L,-23L,36L,-15L,1L,106L,-229L,160L,-37L,1L,-567L,1574L,-1566L,650L,-93L,1L,3434L,-11706L,15248L,-9310L,2572L,-238L,1L,-23137L,93831L,-151933L,123814L,-52136L,10175L,-616L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244888Inst : IEnumerable<long>
{
public static readonly long[] Value=A244888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244888.Bytes);
public long this[int i]=>Value[i];

public static A244888Inst Instance=new A244888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244889
{
public static readonly long[] Value={ 1L,-6L,36L,-229L,1574L,-11706L,93831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244889Inst : IEnumerable<long>
{
public static readonly long[] Value=A244889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244889.Bytes);
public long this[int i]=>Value[i];

public static A244889Inst Instance=new A244889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244890
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,30L,40L,50L,60L,70L,80L,90L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,120L,130L,140L,150L,160L,170L,180L,190L,200L,201L,300L,301L,400L,401L,500L,501L,600L,601L,700L,701L,800L,801L,900L,901L,1000L,1001L,1002L,1003L,1004L,1005L,1006L,1007L,1008L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244890Inst : IEnumerable<long>
{
public static readonly long[] Value=A244890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244890.Bytes);
public long this[int i]=>Value[i];

public static A244890Inst Instance=new A244890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244891
{
public static readonly long[] Value={ 3L,4L,1L,1L,6L,7L,2L,9L,2L,2L,12L,13L,3L,16L,3L,18L,19L,3L,69L,22L,4L,4L,5L,31L,28L,5L,5L,39L,38L,6L,44L,7L,49L,7L,50L,47L,8L,54L,8L,61L,10L,9L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244891Inst : IEnumerable<long>
{
public static readonly long[] Value=A244891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244891.Bytes);
public long this[int i]=>Value[i];

public static A244891Inst Instance=new A244891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244892
{
public static readonly long[] Value={ 5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L,2L,5L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244892Inst : IEnumerable<long>
{
public static readonly long[] Value=A244892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244892.Bytes);
public long this[int i]=>Value[i];

public static A244892Inst Instance=new A244892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244893
{
public static readonly long[] Value={ 2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244893Inst : IEnumerable<long>
{
public static readonly long[] Value=A244893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244893.Bytes);
public long this[int i]=>Value[i];

public static A244893Inst Instance=new A244893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244894
{
public static readonly long[] Value={ 10L,14L,22L,26L,34L,38L,44L,46L,52L,58L,62L,68L,74L,76L,78L,82L,86L,92L,94L,102L,106L,114L,116L,118L,122L,124L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244894Inst : IEnumerable<long>
{
public static readonly long[] Value=A244894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244894.Bytes);
public long this[int i]=>Value[i];

public static A244894Inst Instance=new A244894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244895
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L,1L,-1L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244895Inst : IEnumerable<long>
{
public static readonly long[] Value=A244895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244895.Bytes);
public long this[int i]=>Value[i];

public static A244895Inst Instance=new A244895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244896
{
public static readonly long[] Value={ 2L,4L,6L,12L,24L,42L,84L,168L,312L,624L,1140L,2280L,4560L,8700L,17400L,32820L,65640L,131280L,254460L,508920L,978120L,1956240L,3743880L,7487760L,14975520L,29270220L,58540440L,113716680L,227433360L,440389320L,880778640L,1761557280L,3463686240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244896Inst : IEnumerable<long>
{
public static readonly long[] Value=A244896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244896.Bytes);
public long this[int i]=>Value[i];

public static A244896Inst Instance=new A244896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244897
{
public static readonly long[] Value={ 3L,7L,21L,59L,163L,447L,1341L,3905L,11271L,32357L,92607L,277821L,820177L,2408409L,7047447L,20576017L,59979511L,174642457L,523927371L,1555935031L,4604936281L,13597391065L,40088645243L,118057542207L,347369262425L,1021399936433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244897Inst : IEnumerable<long>
{
public static readonly long[] Value=A244897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244897.Bytes);
public long this[int i]=>Value[i];

public static A244897Inst Instance=new A244897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244898
{
public static readonly long[] Value={ 4L,14L,52L,198L,764L,2740L,10484L,40696L,159332L,627156L,2382476L,9325816L,36745928L,140449732L,551401060L,2177363676L,8627713732L,33486205428L,132260864136L,524379503740L,2041541080656L,8075260485044L,32050426949496L,125201330295448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244898Inst : IEnumerable<long>
{
public static readonly long[] Value=A244898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244898.Bytes);
public long this[int i]=>Value[i];

public static A244898Inst Instance=new A244898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244899
{
public static readonly long[] Value={ 5L,19L,89L,431L,2009L,9257L,45207L,215411L,1061375L,5141999L,24766533L,118872175L,587442511L,2866643947L,13932274863L,69083122581L,339373310671L,1661743983845L,8119703068571L,39618948133555L,196723509789245L,969498651960475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244899Inst : IEnumerable<long>
{
public static readonly long[] Value=A244899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244899.Bytes);
public long this[int i]=>Value[i];

public static A244899Inst Instance=new A244899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244900
{
public static readonly long[] Value={ 4L,22L,118L,646L,3602L,20358L,116272L,669516L,3880216L,22605350L,132252980L,776446672L,4571648804L,26982643512L,156306697586L,918491822736L,5419056033902L,32057939582902L,190020627554666L,1111060374626770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244900Inst : IEnumerable<long>
{
public static readonly long[] Value=A244900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244900.Bytes);
public long this[int i]=>Value[i];

public static A244900Inst Instance=new A244900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244901
{
public static readonly long[] Value={ 5L,33L,199L,1299L,8695L,56609L,382743L,2617609L,17614513L,117799671L,807296221L,5463639421L,37630855591L,256561142539L,1742907035667L,12032004860023L,82373364752855L,570457424074539L,3923440041693405L,26914592912747451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244901Inst : IEnumerable<long>
{
public static readonly long[] Value=A244901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244901.Bytes);
public long this[int i]=>Value[i];

public static A244901Inst Instance=new A244901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244902
{
public static readonly long[] Value={ 6L,42L,316L,2336L,17392L,130548L,1019188L,7890336L,61161968L,475132844L,3699945144L,28879091744L,225894152416L,1770414640688L,13899856847820L,107593063689176L,841538380150180L,6603291331821456L,51928633005911364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244902Inst : IEnumerable<long>
{
public static readonly long[] Value=A244902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244902.Bytes);
public long this[int i]=>Value[i];

public static A244902Inst Instance=new A244902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244903
{
public static readonly long[] Value={ 2L,3L,4L,4L,7L,6L,5L,14L,21L,12L,4L,19L,52L,59L,24L,5L,22L,89L,198L,163L,42L,6L,33L,118L,431L,764L,447L,84L,7L,42L,199L,646L,2009L,2740L,1341L,168L,8L,57L,316L,1299L,3602L,9257L,10484L,3905L,312L,9L,68L,469L,2336L,8695L,20358L,45207L,40696L,11271L,624L,10L,87L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244903Inst : IEnumerable<long>
{
public static readonly long[] Value=A244903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244903.Bytes);
public long this[int i]=>Value[i];

public static A244903Inst Instance=new A244903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244904
{
public static readonly long[] Value={ 2L,3L,4L,5L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,57L,58L,59L,60L,61L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244904Inst : IEnumerable<long>
{
public static readonly long[] Value=A244904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244904.Bytes);
public long this[int i]=>Value[i];

public static A244904Inst Instance=new A244904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244905
{
public static readonly long[] Value={ 4L,7L,14L,19L,22L,33L,42L,57L,68L,87L,100L,123L,148L,165L,194L,191L,222L,243L,278L,315L,340L,381L,408L,453L,500L,531L,544L,577L,630L,665L,722L,781L,820L,883L,924L,991L,1034L,1053L,1124L,1171L,1246L,1295L,1374L,1425L,1508L,1593L,1648L,1737L,1728L,1819L,1912L,1973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244905Inst : IEnumerable<long>
{
public static readonly long[] Value=A244905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244905.Bytes);
public long this[int i]=>Value[i];

public static A244905Inst Instance=new A244905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244906
{
public static readonly long[] Value={ 6L,21L,52L,89L,118L,199L,316L,469L,624L,857L,1080L,1479L,1882L,2255L,2782L,3027L,3674L,4253L,5056L,5943L,6920L,8019L,8976L,10275L,11680L,13197L,13912L,15303L,17140L,18723L,21212L,23485L,25436L,27993L,30170L,33573L,36016L,37427L,40720L,43531L,47852L,50965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244906Inst : IEnumerable<long>
{
public static readonly long[] Value=A244906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244906.Bytes);
public long this[int i]=>Value[i];

public static A244906Inst Instance=new A244906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244907
{
public static readonly long[] Value={ 12L,59L,198L,431L,646L,1299L,2336L,3949L,5912L,8647L,12060L,17757L,24538L,31795L,42082L,47189L,61078L,75249L,94666L,117397L,139842L,170359L,200296L,239887L,284742L,333251L,359840L,412199L,479400L,543589L,633732L,715979L,802704L,912357L,1015446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244907Inst : IEnumerable<long>
{
public static readonly long[] Value=A244907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244907.Bytes);
public long this[int i]=>Value[i];

public static A244907Inst Instance=new A244907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244908
{
public static readonly long[] Value={ 24L,163L,764L,2009L,3602L,8695L,17392L,33803L,55282L,91661L,137532L,215673L,325444L,446739L,638142L,758909L,1029158L,1352913L,1775360L,2332605L,2906746L,3671903L,4543460L,5627131L,6997168L,8441423L,9570836L,11289793L,13501056L,15921997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244908Inst : IEnumerable<long>
{
public static readonly long[] Value=A244908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244908.Bytes);
public long this[int i]=>Value[i];

public static A244908Inst Instance=new A244908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244909
{
public static readonly long[] Value={ 42L,447L,2740L,9257L,20358L,56609L,130548L,282785L,518428L,942207L,1551632L,2647009L,4275204L,6319643L,9579864L,12169949L,17537316L,24230201L,33579138L,46141187L,60471140L,80074953L,103034670L,133258191L,171772880L,215614417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244909Inst : IEnumerable<long>
{
public static readonly long[] Value=A244909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244909.Bytes);
public long this[int i]=>Value[i];

public static A244909Inst Instance=new A244909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244910
{
public static readonly long[] Value={ 84L,1341L,10484L,45207L,116272L,382743L,1019188L,2438447L,5021116L,9893555L,17949000L,33399751L,57424168L,91599865L,146569250L,199270525L,301571992L,442068299L,648265576L,928007973L,1281100472L,1762449201L,2375613576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244910Inst : IEnumerable<long>
{
public static readonly long[] Value=A244910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244910.Bytes);
public long this[int i]=>Value[i];

public static A244910Inst Instance=new A244910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244911
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,7L,7L,1L,1L,5L,10L,13L,11L,1L,1L,6L,13L,19L,21L,16L,1L,1L,7L,16L,25L,31L,31L,22L,1L,1L,8L,19L,31L,41L,46L,43L,29L,1L,1L,9L,22L,37L,51L,61L,64L,57L,37L,1L,1L,10L,25L,43L,61L,76L,85L,85L,73L,46L,1L,1L,11L,28L,49L,71L,91L,106L,113L,109L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244911Inst : IEnumerable<long>
{
public static readonly long[] Value=A244911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244911.Bytes);
public long this[int i]=>Value[i];

public static A244911Inst Instance=new A244911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244912
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,9L,11L,12L,15L,16L,18L,20L,20L,21L,25L,26L,29L,31L,33L,34L,38L,36L,38L,39L,42L,43L,47L,48L,52L,54L,56L,58L,58L,59L,61L,63L,67L,68L,72L,73L,76L,79L,81L,82L,88L,84L,88L,90L,93L,94L,99L,101L,105L,107L,109L,110L,116L,117L,119L,122L,117L,119L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244912Inst : IEnumerable<long>
{
public static readonly long[] Value=A244912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244912.Bytes);
public long this[int i]=>Value[i];

public static A244912Inst Instance=new A244912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244913
{
public static readonly long[] Value={ 11L,13L,17L,19L,23L,37L,61L,233L,257L,1553L,2879L,4919L,6389L,7621L,8081L,35593L,37951L,96263L,206419L,596803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244913Inst : IEnumerable<long>
{
public static readonly long[] Value=A244913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244913.Bytes);
public long this[int i]=>Value[i];

public static A244913Inst Instance=new A244913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244914
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,167L,193L,197L,433L,4111L,9173L,42929L,95279L,98897L,139409L,142567L,228617L,329333L,344209L,791191L,829177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244914Inst : IEnumerable<long>
{
public static readonly long[] Value=A244914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244914.Bytes);
public long this[int i]=>Value[i];

public static A244914Inst Instance=new A244914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244915
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,5L,2L,7L,8L,13L,2L,15L,4L,1L,6L,5L,4L,9L,10L,1L,14L,9L,16L,1L,20L,3L,10L,7L,12L,13L,10L,17L,2L,27L,10L,19L,6L,11L,4L,21L,10L,29L,4L,25L,6L,29L,16L,5L,18L,7L,20L,11L,14L,15L,22L,5L,24L,1L,26L,5L,28L,13L,20L,19L,14L,25L,12L,17L,8L,23L,12L,43L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244915Inst : IEnumerable<long>
{
public static readonly long[] Value=A244915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244915.Bytes);
public long this[int i]=>Value[i];

public static A244915Inst Instance=new A244915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244916
{
public static readonly long[] Value={ 3L,31L,71L,97L,107L,277L,307L,641L,907L,967L,1009L,1447L,3463L,3527L,7757L,8167L,250867L,279047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244916Inst : IEnumerable<long>
{
public static readonly long[] Value=A244916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244916.Bytes);
public long this[int i]=>Value[i];

public static A244916Inst Instance=new A244916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244917
{
public static readonly long[] Value={ 2L,3L,7L,19L,139L,829L,3331L,32941L,176417L,854929L,2233531L,12699571L,47924959L,763597201L,5775760189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244917Inst : IEnumerable<long>
{
public static readonly long[] Value=A244917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244917.Bytes);
public long this[int i]=>Value[i];

public static A244917Inst Instance=new A244917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244918
{
public static readonly long[] Value={ 59999999L,69999899L,69999989L,78998999L,88989899L,88999979L,89699999L,89799989L,89989799L,89989979L,89997899L,89997989L,89999699L,89999969L,97889999L,98699999L,98879999L,98899799L,98979989L,98988899L,98989889L,98997989L,98998979L,98999969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244918Inst : IEnumerable<long>
{
public static readonly long[] Value=A244918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244918.Bytes);
public long this[int i]=>Value[i];

public static A244918Inst Instance=new A244918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244919
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244919Inst : IEnumerable<long>
{
public static readonly long[] Value=A244919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244919.Bytes);
public long this[int i]=>Value[i];

public static A244919Inst Instance=new A244919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244920
{
public static readonly long[] Value={ 1L,7L,6L,2L,7L,4L,7L,1L,7L,4L,0L,3L,9L,0L,8L,6L,0L,5L,0L,4L,6L,5L,2L,1L,8L,6L,4L,9L,9L,5L,9L,5L,8L,4L,6L,1L,8L,0L,5L,6L,3L,2L,0L,6L,5L,6L,5L,2L,3L,2L,7L,0L,8L,2L,1L,5L,0L,6L,5L,9L,1L,2L,1L,7L,3L,0L,6L,7L,5L,4L,3L,6L,8L,4L,4L,4L,0L,5L,2L,1L,7L,5L,6L,6L,7L,4L,1L,3L,7L,8L,3L,8L,2L,0L,5L,1L,2L,0L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244920Inst : IEnumerable<long>
{
public static readonly long[] Value=A244920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244920.Bytes);
public long this[int i]=>Value[i];

public static A244920Inst Instance=new A244920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244921
{
public static readonly long[] Value={ 7L,6L,5L,1L,9L,5L,7L,1L,6L,4L,6L,4L,2L,1L,2L,6L,9L,1L,3L,4L,4L,7L,6L,6L,0L,1L,6L,3L,9L,6L,4L,9L,6L,7L,9L,5L,8L,6L,5L,9L,4L,4L,0L,6L,7L,8L,7L,9L,5L,2L,7L,8L,2L,7L,9L,7L,6L,6L,5L,8L,4L,4L,8L,8L,8L,1L,3L,6L,9L,8L,8L,7L,5L,6L,1L,3L,7L,7L,7L,0L,8L,8L,9L,4L,6L,9L,8L,1L,4L,2L,0L,7L,9L,2L,9L,9L,2L,0L,5L,1L,9L,7L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244921Inst : IEnumerable<long>
{
public static readonly long[] Value=A244921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244921.Bytes);
public long this[int i]=>Value[i];

public static A244921Inst Instance=new A244921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244922
{
public static readonly long[] Value={ 6L,2L,7L,1L,8L,0L,7L,8L,4L,8L,8L,3L,5L,1L,4L,7L,2L,0L,8L,6L,5L,4L,8L,2L,4L,5L,2L,2L,2L,0L,3L,6L,3L,1L,7L,3L,8L,5L,3L,6L,0L,9L,2L,0L,5L,6L,2L,1L,1L,7L,7L,1L,3L,7L,2L,2L,4L,8L,3L,2L,2L,4L,9L,5L,9L,4L,7L,6L,2L,9L,4L,5L,0L,9L,5L,0L,4L,1L,3L,7L,6L,7L,7L,2L,6L,9L,1L,6L,7L,0L,8L,0L,1L,2L,1L,2L,9L,5L,6L,8L,8L,5L,7L,6L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244922Inst : IEnumerable<long>
{
public static readonly long[] Value=A244922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244922.Bytes);
public long this[int i]=>Value[i];

public static A244922Inst Instance=new A244922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244923
{
public static readonly long[] Value={ 1L,13L,61L,73L,97L,217L,349L,649L,937L,1477L,1513L,1729L,2005L,2077L,2209L,3265L,3649L,3889L,4093L,4609L,4945L,5497L,5749L,5929L,6109L,7309L,7441L,8041L,8389L,8821L,9925L,10525L,10669L,11605L,13201L,13345L,16021L,18529L,18649L,20293L,21481L,22573L,22729L,24169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244923Inst : IEnumerable<long>
{
public static readonly long[] Value=A244923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244923.Bytes);
public long this[int i]=>Value[i];

public static A244923Inst Instance=new A244923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244924
{
public static readonly long[] Value={ 73520771L,108288041L,127499219L,141239113L,160792529L,198545797L,205293103L,217763051L,227258803L,262056089L,269931509L,303224819L,307060289L,353982553L,368427809L,430034677L,525141899L,581603107L,585721991L,600824113L,612314921L,644606467L,718519237L,723522461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244924Inst : IEnumerable<long>
{
public static readonly long[] Value=A244924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244924.Bytes);
public long this[int i]=>Value[i];

public static A244924Inst Instance=new A244924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244925
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,2L,2L,1L,1L,0L,1L,4L,3L,2L,1L,1L,0L,1L,4L,5L,3L,2L,1L,1L,0L,1L,7L,7L,6L,3L,2L,1L,1L,0L,1L,8L,12L,8L,6L,3L,2L,1L,1L,0L,1L,12L,18L,15L,9L,6L,3L,2L,1L,1L,0L,1L,14L,27L,23L,16L,9L,6L,3L,2L,1L,1L,0L,1L,21L,42L,39L,26L,17L,9L,6L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244925Inst : IEnumerable<long>
{
public static readonly long[] Value=A244925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244925.Bytes);
public long this[int i]=>Value[i];

public static A244925Inst Instance=new A244925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244926
{
public static readonly long[] Value={ 1L,2L,247L,2279L,9167L,57479L,200479L,518039L,2119207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244926Inst : IEnumerable<long>
{
public static readonly long[] Value=A244926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244926.Bytes);
public long this[int i]=>Value[i];

public static A244926Inst Instance=new A244926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244927
{
public static readonly BigInteger[] Value={ 1L,5L,37L,25L,2L,185L,15873L,125L,12345679L,1L,1L,925L,8547L,79365L,74L,625L,65359477124183L,61728395L,5847953216374269L,5L,5291L,5L,BigInteger.Parse("48309178743961352657"),4625L,4L,42735L,BigInteger.Parse("4115226337448559670781893"),396825L };
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
public class A244927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244927Inst Instance=new A244927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244928
{
public static readonly long[] Value={ 2L,6L,5L,8L,6L,4L,9L,5L,8L,2L,7L,9L,3L,0L,6L,9L,8L,2L,6L,9L,1L,8L,7L,5L,0L,8L,6L,3L,9L,7L,1L,2L,0L,6L,8L,7L,6L,4L,2L,7L,8L,3L,8L,2L,3L,9L,7L,5L,1L,3L,8L,9L,9L,9L,3L,8L,0L,5L,9L,7L,4L,1L,5L,3L,2L,8L,5L,7L,4L,3L,9L,5L,1L,3L,0L,2L,7L,7L,1L,1L,4L,0L,5L,4L,4L,1L,1L,4L,0L,7L,0L,3L,2L,0L,5L,7L,7L,1L,7L,4L,0L,4L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244928Inst : IEnumerable<long>
{
public static readonly long[] Value=A244928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244928.Bytes);
public long this[int i]=>Value[i];

public static A244928Inst Instance=new A244928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244929
{
public static readonly long[] Value={ 2L,3L,3L,4L,5L,3L,7L,5L,8L,5L,3L,1L,2L,3L,4L,1L,1L,4L,6L,7L,5L,9L,0L,3L,8L,6L,2L,7L,7L,4L,3L,9L,3L,3L,0L,0L,4L,8L,8L,2L,6L,7L,8L,3L,7L,7L,2L,5L,0L,9L,9L,3L,5L,4L,0L,1L,6L,3L,0L,0L,5L,4L,0L,1L,8L,4L,4L,1L,8L,0L,1L,0L,3L,4L,5L,3L,6L,3L,3L,5L,0L,7L,6L,4L,5L,3L,6L,9L,0L,1L,6L,5L,4L,4L,1L,7L,1L,8L,3L,7L,9L,7L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244929Inst : IEnumerable<long>
{
public static readonly long[] Value=A244929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244929.Bytes);
public long this[int i]=>Value[i];

public static A244929Inst Instance=new A244929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244930
{
public static readonly long[] Value={ 3L,4L,7L,8L,16L,26L,34L,42L,78L,94L,101L,107L,216L,255L,543L,562L,851L,981L,1099L,1528L,1824L,1955L,2122L,2488L,2500L,15331L,15961L,24107L,24938L,26051L,58504L,61617L,81034L,85119L,89768L,90597L,97191L,116899L,195346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244930Inst : IEnumerable<long>
{
public static readonly long[] Value=A244930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244930.Bytes);
public long this[int i]=>Value[i];

public static A244930Inst Instance=new A244930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244931
{
public static readonly BigInteger[] Value={ 19L,37L,223L,409L,53617L,23757289L,3111662089L,407556643177L,BigInteger.Parse("1372675688565303822697"),BigInteger.Parse("23548271681390871672120649"),BigInteger.Parse("1676892190264006259992141409"),BigInteger.Parse("64923481849284379431377700019") };
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
public class A244931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244931Inst Instance=new A244931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244932
{
public static readonly long[] Value={ 2L,13L,10L,17L,6L,37L,12L,13L,16L,27L,24L,71L,16L,31L,64L,43L,18L,43L,26L,23L,32L,29L,24L,79L,32L,53L,34L,61L,92L,47L,40L,33L,34L,57L,36L,47L,40L,53L,40L,79L,44L,43L,68L,91L,68L,57L,66L,61L,60L,53L,58L,83L,60L,91L,94L,61L,82L,61L,70L,101L,82L,71L,68L,145L,82L,67L,76L,69L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244932Inst : IEnumerable<long>
{
public static readonly long[] Value=A244932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244932.Bytes);
public long this[int i]=>Value[i];

public static A244932Inst Instance=new A244932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244933
{
public static readonly long[] Value={ 2L,4L,8L,14L,28L,56L,104L,208L,416L,796L,1592L,3184L,6192L,12384L,23860L,47720L,95440L,186916L,373832L,727432L,1454864L,2909728L,5730524L,11461048L,22462924L,44925848L,89851696L,177656224L,355312448L,699923364L,1399846728L,2751354244L,5502708488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244933Inst : IEnumerable<long>
{
public static readonly long[] Value=A244933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244933.Bytes);
public long this[int i]=>Value[i];

public static A244933Inst Instance=new A244933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244934
{
public static readonly long[] Value={ 3L,9L,25L,69L,207L,603L,1741L,5223L,15445L,45423L,133083L,388931L,1166793L,3468159L,10273893L,30362903L,89585413L,268756239L,801503303L,2384949771L,7085216455L,21024282907L,62328987385L,184644664807L,553933994421L,1654527949377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244934Inst : IEnumerable<long>
{
public static readonly long[] Value=A244934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244934.Bytes);
public long this[int i]=>Value[i];

public static A244934Inst Instance=new A244934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244935
{
public static readonly long[] Value={ 4L,14L,52L,198L,764L,2976L,11668L,45960L,181652L,719784L,2788796L,11002420L,43580832L,173051000L,688262544L,2700639584L,10713025424L,42598244032L,167252123936L,663795796428L,2640605536256L,10519121286540L,41513829916044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244935Inst : IEnumerable<long>
{
public static readonly long[] Value=A244935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244935.Bytes);
public long this[int i]=>Value[i];

public static A244935Inst Instance=new A244935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244936
{
public static readonly long[] Value={ 5L,23L,111L,517L,2529L,12497L,60773L,293467L,1452027L,7098491L,35241785L,173448115L,850635919L,4228509605L,20877802955L,102809521997L,511702568833L,2533299689123L,12515437416587L,61741060077517L,307496253699899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244936Inst : IEnumerable<long>
{
public static readonly long[] Value=A244936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244936.Bytes);
public long this[int i]=>Value[i];

public static A244936Inst Instance=new A244936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244937
{
public static readonly long[] Value={ 6L,34L,190L,1076L,6370L,37364L,219382L,1290578L,7608118L,44939408L,265918210L,1575976530L,9352941946L,55573587890L,326410728932L,1933435659676L,11479125656242L,68259739629464L,406369954381170L,2421492122342238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244937Inst : IEnumerable<long>
{
public static readonly long[] Value=A244937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244937.Bytes);
public long this[int i]=>Value[i];

public static A244937Inst Instance=new A244937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244938
{
public static readonly long[] Value={ 7L,43L,295L,1939L,13139L,89937L,619567L,4214681L,29077603L,198628937L,1373663131L,9534987699L,65754164573L,452049647057L,3137150763987L,21650603674011L,150498748944463L,1041251352601661L,7246617431848573L,50233805965036479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244938Inst : IEnumerable<long>
{
public static readonly long[] Value=A244938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244938.Bytes);
public long this[int i]=>Value[i];

public static A244938Inst Instance=new A244938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244939
{
public static readonly long[] Value={ 8L,58L,444L,3358L,26256L,203496L,1606524L,12610616L,98974880L,777361848L,6111929616L,48109349232L,379117702232L,2990823713232L,23618400643440L,186690033943144L,1476967053450912L,11694155696863040L,92658793731655808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244939Inst : IEnumerable<long>
{
public static readonly long[] Value=A244939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244939.Bytes);
public long this[int i]=>Value[i];

public static A244939Inst Instance=new A244939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244940
{
public static readonly long[] Value={ 2L,3L,4L,4L,9L,8L,5L,14L,25L,14L,6L,23L,52L,69L,28L,7L,34L,111L,198L,207L,56L,8L,43L,190L,517L,764L,603L,104L,9L,58L,295L,1076L,2529L,2976L,1741L,208L,10L,75L,444L,1939L,6370L,12497L,11668L,5223L,416L,11L,94L,631L,3358L,13139L,37364L,60773L,45960L,15445L,796L,12L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244940Inst : IEnumerable<long>
{
public static readonly long[] Value=A244940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244940.Bytes);
public long this[int i]=>Value[i];

public static A244940Inst Instance=new A244940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244941
{
public static readonly long[] Value={ 4L,9L,14L,23L,34L,43L,58L,75L,94L,109L,132L,157L,176L,205L,236L,269L,294L,331L,370L,399L,442L,487L,520L,569L,620L,673L,712L,769L,828L,871L,934L,999L,1066L,1115L,1186L,1259L,1312L,1389L,1468L,1525L,1608L,1693L,1780L,1843L,1934L,2027L,2094L,2191L,2290L,2391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244941Inst : IEnumerable<long>
{
public static readonly long[] Value=A244941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244941.Bytes);
public long this[int i]=>Value[i];

public static A244941Inst Instance=new A244941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244942
{
public static readonly long[] Value={ 8L,25L,52L,111L,190L,295L,444L,631L,896L,1143L,1484L,1941L,2344L,2885L,3586L,4293L,5072L,5967L,6952L,8015L,9220L,10529L,11920L,13481L,15376L,17211L,18886L,21251L,23520L,25571L,28458L,31207L,34112L,37133L,40408L,44295L,47412L,51259L,55808L,59431L,63896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244942Inst : IEnumerable<long>
{
public static readonly long[] Value=A244942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244942.Bytes);
public long this[int i]=>Value[i];

public static A244942Inst Instance=new A244942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244943
{
public static readonly long[] Value={ 14L,69L,198L,517L,1076L,1939L,3358L,5405L,8450L,11963L,17018L,23943L,31336L,41455L,54646L,69719L,86956L,108249L,133076L,160671L,194020L,232099L,273540L,322805L,381626L,444347L,507028L,589109L,675482L,760691L,871474L,986801L,1112774L,1244873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244943Inst : IEnumerable<long>
{
public static readonly long[] Value=A244943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244943.Bytes);
public long this[int i]=>Value[i];

public static A244943Inst Instance=new A244943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244944
{
public static readonly long[] Value={ 28L,207L,764L,2529L,6370L,13139L,26256L,47837L,81956L,128615L,197458L,302511L,428826L,602837L,850858L,1144577L,1518420L,2003265L,2576020L,3277575L,4160136L,5175043L,6383388L,7807095L,9623276L,11669449L,13753106L,16586033L,19723102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244944Inst : IEnumerable<long>
{
public static readonly long[] Value=A244944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244944.Bytes);
public long this[int i]=>Value[i];

public static A244944Inst Instance=new A244944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244945
{
public static readonly long[] Value={ 56L,603L,2976L,12497L,37364L,89937L,203496L,414005L,802938L,1378237L,2310160L,3810249L,5865308L,8838281L,13242174L,18940579L,26744586L,37115425L,50263184L,66920399L,88714404L,116303039L,149262316L,190238065L,243142772L,307379445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244945Inst : IEnumerable<long>
{
public static readonly long[] Value=A244945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244945.Bytes);
public long this[int i]=>Value[i];

public static A244945Inst Instance=new A244945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244946
{
public static readonly long[] Value={ 104L,1741L,11668L,60773L,219382L,619567L,1606524L,3633503L,7812680L,14809785L,27187896L,48673171L,79655094L,129140579L,206834018L,315266151L,470493868L,690411851L,979409260L,1371679055L,1908300954L,2613538897L,3504769562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244946Inst : IEnumerable<long>
{
public static readonly long[] Value=A244946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244946.Bytes);
public long this[int i]=>Value[i];

public static A244946Inst Instance=new A244946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244947
{
public static readonly long[] Value={ 2L,85L,4L,33L,6L,7L,8L,13L,22L,13L,16L,41L,28L,15L,22L,19L,24L,23L,54L,31L,22L,27L,56L,61L,38L,29L,40L,37L,34L,61L,32L,35L,82L,35L,46L,43L,40L,49L,58L,67L,42L,55L,58L,49L,46L,61L,58L,61L,68L,73L,92L,63L,94L,77L,166L,57L,82L,63L,72L,109L,76L,121L,82L,79L,86L,67L,72L,77L,82L,71L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244947Inst : IEnumerable<long>
{
public static readonly long[] Value=A244947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244947.Bytes);
public long this[int i]=>Value[i];

public static A244947Inst Instance=new A244947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244948
{
public static readonly long[] Value={ 30L,29L,40L,33L,34L,131L,50L,9L,44L,11L,38L,13L,18L,97L,166L,221L,200L,37L,82L,61L,176L,23L,102L,65L,94L,151L,352L,87L,38L,37L,38L,39L,46L,37L,48L,137L,54L,55L,68L,43L,60L,55L,146L,51L,106L,87L,82L,65L,134L,53L,106L,103L,90L,71L,96L,71L,148L,91L,94L,139L,74L,69L,94L,75L,86L,169L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244948Inst : IEnumerable<long>
{
public static readonly long[] Value=A244948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244948.Bytes);
public long this[int i]=>Value[i];

public static A244948Inst Instance=new A244948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244949
{
public static readonly long[] Value={ 102L,37L,32L,39L,118L,13L,16L,11L,154L,41L,94L,29L,158L,17L,64L,291L,70L,107L,66L,63L,58L,87L,38L,397L,282L,69L,32L,129L,142L,67L,210L,87L,200L,227L,82L,55L,70L,137L,388L,541L,140L,103L,64L,167L,286L,71L,60L,593L,262L,459L,62L,69L,92L,91L,128L,81L,98L,149L,164L,107L,192L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244949Inst : IEnumerable<long>
{
public static readonly long[] Value=A244949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244949.Bytes);
public long this[int i]=>Value[i];

public static A244949Inst Instance=new A244949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244950
{
public static readonly long[] Value={ 120L,113L,106L,259L,304L,85L,212L,135L,158L,47L,62L,985L,84L,47L,518L,485L,178L,169L,106L,27L,88L,139L,632L,47L,44L,643L,194L,209L,606L,1529L,32L,113L,1094L,139L,754L,647L,38L,45L,262L,69L,94L,631L,90L,527L,326L,195L,54L,277L,232L,187L,554L,189L,78L,799L,216L,131L,1132L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244950Inst : IEnumerable<long>
{
public static readonly long[] Value=A244950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244950.Bytes);
public long this[int i]=>Value[i];

public static A244950Inst Instance=new A244950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244951
{
public static readonly long[] Value={ 4L,3L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244951Inst : IEnumerable<long>
{
public static readonly long[] Value=A244951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244951.Bytes);
public long this[int i]=>Value[i];

public static A244951Inst Instance=new A244951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244952
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,9L,12L,16L,17L,27L,30L,33L,36L,45L,54L,57L,60L,81L,120L,135L,171L,210L,225L,267L,366L,378L,390L,432L,435L,564L,654L,675L,741L,825L,858L,894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244952Inst : IEnumerable<long>
{
public static readonly long[] Value=A244952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244952.Bytes);
public long this[int i]=>Value[i];

public static A244952Inst Instance=new A244952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244953
{
public static readonly long[] Value={ 0L,3L,5L,6L,6L,9L,11L,12L,12L,15L,17L,18L,18L,21L,23L,24L,24L,27L,29L,30L,30L,33L,35L,36L,36L,39L,41L,42L,42L,45L,47L,48L,48L,51L,53L,54L,54L,57L,59L,60L,60L,63L,65L,66L,66L,69L,71L,72L,72L,75L,77L,78L,78L,81L,83L,84L,84L,87L,89L,90L,90L,93L,95L,96L,96L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244953Inst : IEnumerable<long>
{
public static readonly long[] Value=A244953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244953.Bytes);
public long this[int i]=>Value[i];

public static A244953Inst Instance=new A244953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244954
{
public static readonly long[] Value={ 0L,1L,4L,3L,4L,10L,12L,28L,40L,9L,10L,121L,12L,13L,28L,30L,112L,85L,36L,247L,40L,84L,352L,253L,120L,325L,364L,27L,28L,841L,30L,31L,256L,363L,850L,280L,36L,37L,760L,39L,40L,82L,84L,3010L,352L,90L,1012L,94L,336L,2548L,850L,255L,364L,742L,108L,2200L,112L,741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244954Inst : IEnumerable<long>
{
public static readonly long[] Value=A244954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244954.Bytes);
public long this[int i]=>Value[i];

public static A244954Inst Instance=new A244954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244955
{
public static readonly long[] Value={ 0L,1L,4L,21L,4L,5L,84L,21L,16L,81L,20L,341L,84L,65L,84L,1365L,16L,17L,324L,1045L,20L,21L,1364L,69L,336L,325L,260L,81L,84L,261L,5460L,341L,64L,1089L,68L,1365L,324L,4181L,4180L,273L,80L,1025L,84L,5461L,1364L,5445L,276L,20821L,336L,1029L,1300L,4437L,260L,5141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244955Inst : IEnumerable<long>
{
public static readonly long[] Value=A244955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244955.Bytes);
public long this[int i]=>Value[i];

public static A244955Inst Instance=new A244955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244956
{
public static readonly long[] Value={ 0L,1L,6L,6L,156L,5L,6L,126L,656L,126L,30L,781L,156L,26L,126L,30L,656L,3281L,126L,3781L,780L,126L,3256L,3151L,97656L,25L,26L,756L,756L,15631L,30L,31L,3776L,16401L,3876L,630L,756L,3256L,3876L,156L,3280L,656L,126L,15781L,3256L,630L,16376L,3901L,472656L,15631L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244956Inst : IEnumerable<long>
{
public static readonly long[] Value=A244956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244956.Bytes);
public long this[int i]=>Value[i];

public static A244956Inst Instance=new A244956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244957
{
public static readonly long[] Value={ 0L,1L,6L,6L,36L,1555L,6L,7L,216L,36L,9330L,253L,36L,1339L,42L,9330L,1296L,1513L,36L,7999L,55980L,42L,1518L,253L,216L,9325L,8034L,216L,252L,47995L,9330L,217L,7776L,1518L,9078L,12093235L,36L,37L,47994L,8034L,335880L,46699L,42L,43L,9108L,55980L,1518L,48175L,1296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244957Inst : IEnumerable<long>
{
public static readonly long[] Value=A244957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244957.Bytes);
public long this[int i]=>Value[i];

public static A244957Inst Instance=new A244957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244958
{
public static readonly long[] Value={ 0L,1L,8L,57L,8L,50L,19608L,7L,8L,351L,50L,2409L,19608L,351L,56L,2745L,400L,16864L,134856L,57L,400L,399L,2794L,17158L,19608L,50L,19552L,351L,56L,137257L,120450L,16864L,2752L,2409L,16864L,350L,134856L,117993L,19608L,351L,400L,134849L,137256L,344L,16808L,2745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244958Inst : IEnumerable<long>
{
public static readonly long[] Value=A244958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244958.Bytes);
public long this[int i]=>Value[i];

public static A244958Inst Instance=new A244958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244959
{
public static readonly long[] Value={ 0L,1L,8L,9L,8L,65L,72L,299593L,8L,9L,520L,4169L,72L,65L,2396744L,585L,64L,4097L,72L,513L,520L,17044041L,33352L,33281L,72L,266825L,520L,513L,2396744L,266249L,4680L,4681L,64L,32769L,32776L,16814665L,72L,262145L,4104L,585L,520L,32841L,136352328L,36937L,33352L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244959Inst : IEnumerable<long>
{
public static readonly long[] Value=A244959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244959.Bytes);
public long this[int i]=>Value[i];

public static A244959Inst Instance=new A244959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244960
{
public static readonly long[] Value={ 0L,1L,10L,9L,820L,10L,90L,91L,5380840L,9L,10L,7381L,7380L,91L,66430L,90L,43644592L,6562L,90L,7372L,820L,819L,65692L,7291L,48427560L,7300L,66430L,81L,532252L,59131L,90L,66340L,48368512L,66429L,6562L,66430L,7380L,532171L,7372L,819L,5380840L,82L,597870L,66349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244960Inst : IEnumerable<long>
{
public static readonly long[] Value=A244960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244960.Bytes);
public long this[int i]=>Value[i];

public static A244960Inst Instance=new A244960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244961
{
public static readonly BigInteger[] Value={ 1L,6L,84L,4680L,1118480L,1108378656L,4467856773184L,72624976668147840L,BigInteger.Parse("4740885567116192841984"),BigInteger.Parse("1240362622532514091484054016"),BigInteger.Parse("1299343104384081987198247370753024"),BigInteger.Parse("5447177625434934817180194985991294945280") };
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
public class A244961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244961Inst Instance=new A244961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244962
{
public static readonly long[] Value={ 1L,2L,5L,7L,15L,22L,77L,176L,4565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244962Inst : IEnumerable<long>
{
public static readonly long[] Value=A244962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244962.Bytes);
public long this[int i]=>Value[i];

public static A244962Inst Instance=new A244962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244963
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,3L,1L,0L,0L,4L,0L,0L,0L,7L,0L,3L,0L,6L,0L,0L,0L,12L,1L,0L,4L,8L,0L,0L,0L,15L,0L,0L,0L,19L,0L,0L,0L,18L,0L,0L,0L,12L,6L,0L,0L,28L,1L,3L,0L,14L,0L,12L,0L,24L,0L,0L,0L,24L,0L,0L,8L,31L,0L,0L,0L,18L,0L,0L,0L,51L,0L,0L,4L,20L,0L,0L,0L,42L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244963Inst : IEnumerable<long>
{
public static readonly long[] Value=A244963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244963.Bytes);
public long this[int i]=>Value[i];

public static A244963Inst Instance=new A244963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244964
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,2L,2L,1L,3L,1L,3L,1L,3L,3L,2L,1L,2L,1L,3L,2L,3L,1L,3L,2L,3L,1L,3L,1L,4L,1L,2L,1L,2L,4L,3L,1L,2L,1L,4L,1L,3L,1L,3L,3L,2L,1L,3L,2L,3L,2L,3L,1L,2L,2L,3L,2L,2L,1L,5L,1L,2L,2L,2L,2L,3L,1L,2L,1L,6L,1L,3L,1L,2L,3L,2L,3L,3L,1L,4L,1L,2L,1L,4L,2L,2L,1L,3L,1L,4L,2L,3L,1L,2L,2L,3L,1L,3L,1L,4L,1L,3L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244964Inst : IEnumerable<long>
{
public static readonly long[] Value=A244964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244964.Bytes);
public long this[int i]=>Value[i];

public static A244964Inst Instance=new A244964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244965
{
public static readonly long[] Value={ 1L,3L,1L,3L,3L,4L,1L,5L,6L,6L,1L,7L,3L,4L,8L,1L,3L,9L,3L,5L,10L,1L,11L,10L,6L,12L,1L,13L,3L,7L,14L,1L,3L,5L,15L,3L,4L,8L,16L,1L,17L,6L,6L,9L,18L,1L,19L,3L,9L,10L,20L,1L,3L,7L,21L,3L,11L,22L,1L,23L,10L,6L,8L,12L,24L,1L,5L,25L,3L,13L,26L,1L,3L,9L,27L,3L,4L,7L,14L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244965Inst : IEnumerable<long>
{
public static readonly long[] Value=A244965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244965.Bytes);
public long this[int i]=>Value[i];

public static A244965Inst Instance=new A244965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244966
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,0L,1L,2L,1L,3L,1L,0L,0L,1L,2L,1L,3L,2L,4L,0L,2L,0L,0L,0L,1L,2L,1L,3L,2L,4L,1L,3L,2L,5L,1L,3L,1L,0L,0L,1L,2L,1L,3L,2L,4L,1L,3L,2L,5L,2L,4L,3L,6L,0L,2L,1L,4L,2L,0L,0L,0L,1L,2L,1L,3L,2L,4L,1L,3L,2L,5L,2L,4L,3L,6L,1L,3L,2L,5L,4L,3L,7L,1L,3L,2L,5L,0L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244966Inst : IEnumerable<long>
{
public static readonly long[] Value=A244966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244966.Bytes);
public long this[int i]=>Value[i];

public static A244966Inst Instance=new A244966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244967
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,1L,3L,2L,5L,2L,4L,3L,6L,1L,3L,2L,5L,4L,3L,7L,2L,4L,3L,6L,2L,5L,4L,8L,1L,3L,2L,5L,4L,3L,7L,3L,6L,5L,4L,9L,2L,4L,3L,6L,2L,5L,4L,8L,4L,3L,7L,6L,5L,10L,1L,3L,2L,5L,4L,3L,7L,3L,6L,5L,4L,9L,2L,5L,4L,8L,3L,7L,6L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244967Inst : IEnumerable<long>
{
public static readonly long[] Value=A244967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244967.Bytes);
public long this[int i]=>Value[i];

public static A244967Inst Instance=new A244967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244968
{
public static readonly long[] Value={ 1L,4L,9L,28L,54L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244968Inst : IEnumerable<long>
{
public static readonly long[] Value=A244968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244968.Bytes);
public long this[int i]=>Value[i];

public static A244968Inst Instance=new A244968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244969
{
public static readonly long[] Value={ 15L,35L,45L,63L,75L,77L,91L,99L,105L,117L,135L,143L,153L,165L,175L,187L,189L,195L,209L,221L,225L,231L,245L,247L,255L,273L,285L,297L,299L,315L,323L,325L,345L,351L,357L,375L,385L,391L,399L,405L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244969Inst : IEnumerable<long>
{
public static readonly long[] Value=A244969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244969.Bytes);
public long this[int i]=>Value[i];

public static A244969Inst Instance=new A244969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244970
{
public static readonly long[] Value={ 1L,2L,6L,7L,11L,12L,16L,17L,25L,29L,33L,34L,38L,42L,50L,51L,55L,56L,60L,61L,73L,77L,81L,82L,90L,94L,106L,107L,111L,112L,116L,117L,129L,133L,141L,142L,146L,150L,162L,163L,167L,168L,172L,176L,184L,188L,192L,193L,201L,209L,221L,225L,229L,230L,242L,243L,255L,259L,263L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244970Inst : IEnumerable<long>
{
public static readonly long[] Value=A244970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244970.Bytes);
public long this[int i]=>Value[i];

public static A244970Inst Instance=new A244970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244971
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,1L,4L,1L,8L,4L,4L,1L,4L,4L,8L,1L,4L,1L,4L,1L,12L,4L,4L,1L,8L,4L,12L,1L,4L,1L,4L,1L,12L,4L,8L,1L,4L,4L,12L,1L,4L,1L,4L,4L,8L,4L,4L,1L,8L,8L,12L,4L,4L,1L,12L,1L,12L,4L,4L,1L,4L,4L,16L,1L,12L,1L,4L,4L,12L,8L,4L,1L,4L,4L,12L,4L,8L,4L,4L,1L,16L,4L,4L,1L,12L,4L,12L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244971Inst : IEnumerable<long>
{
public static readonly long[] Value=A244971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244971.Bytes);
public long this[int i]=>Value[i];

public static A244971Inst Instance=new A244971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244972
{
public static readonly long[] Value={ 3L,9L,21L,27L,45L,81L,153L,243L,441L,495L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244972Inst : IEnumerable<long>
{
public static readonly long[] Value=A244972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244972.Bytes);
public long this[int i]=>Value[i];

public static A244972Inst Instance=new A244972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244973
{
public static readonly long[] Value={ 1L,-1L,-1L,17L,-65L,49L,881L,-5489L,12223L,42785L,-479951L,1746271L,440881L,-39651457L,212039855L,-326783183L,-2817155137L,23175692033L,-68726927071L,-128775914225L,2285692892785L,-10156877725985L,6169206210815L,196882990135745L,-1274770281690575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244973Inst : IEnumerable<long>
{
public static readonly long[] Value=A244973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244973.Bytes);
public long this[int i]=>Value[i];

public static A244973Inst Instance=new A244973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244974
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,16L,8L,15L,13L,30L,12L,45L,14L,36L,33L,31L,18L,79L,20L,66L,41L,64L,24L,103L,31L,70L,40L,80L,30L,235L,32L,63L,84L,114L,73L,198L,38L,120L,92L,163L,42L,310L,44L,140L,130L,132L,48L,246L,57L,213L,108L,154L,54L,300L,97L,217L,116L,150L,60L,600L,62L,156L,180L,127L,109L,540L,68L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244974Inst : IEnumerable<long>
{
public static readonly long[] Value=A244974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244974.Bytes);
public long this[int i]=>Value[i];

public static A244974Inst Instance=new A244974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244975
{
public static readonly long[] Value={ 0L,1L,11L,84L,598L,4199L,29409L,205882L,1441196L,10088397L,70618807L,494331680L,3460321794L,24222252595L,169555768205L,1186890377478L,8308232642392L,58157628496793L,407103399477603L,2849723796343276L,19948066574402990L,139636466020820991L,977455262145747001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244975Inst : IEnumerable<long>
{
public static readonly long[] Value=A244975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244975.Bytes);
public long this[int i]=>Value[i];

public static A244975Inst Instance=new A244975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244976
{
public static readonly long[] Value={ 2L,7L,7L,6L,8L,0L,1L,8L,3L,6L,3L,4L,8L,9L,7L,8L,9L,0L,4L,3L,8L,4L,9L,2L,5L,6L,1L,8L,7L,8L,7L,9L,3L,3L,5L,6L,1L,6L,3L,4L,1L,3L,8L,5L,5L,5L,8L,5L,9L,8L,0L,6L,3L,8L,9L,4L,2L,8L,3L,7L,2L,2L,5L,4L,3L,4L,7L,7L,7L,1L,7L,4L,5L,6L,8L,7L,1L,7L,1L,1L,9L,4L,1L,0L,9L,5L,7L,9L,3L,3L,4L,2L,2L,7L,9L,7L,8L,2L,7L,3L,3L,5L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244976Inst : IEnumerable<long>
{
public static readonly long[] Value=A244976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244976.Bytes);
public long this[int i]=>Value[i];

public static A244976Inst Instance=new A244976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244977
{
public static readonly long[] Value={ 1L,5L,1L,1L,4L,9L,9L,4L,7L,0L,1L,9L,5L,1L,8L,1L,5L,4L,2L,1L,6L,1L,7L,3L,1L,8L,8L,1L,3L,6L,8L,4L,6L,3L,1L,1L,0L,2L,3L,6L,7L,2L,1L,8L,7L,3L,4L,1L,0L,6L,1L,7L,1L,4L,6L,3L,0L,8L,2L,3L,7L,4L,4L,6L,1L,5L,6L,7L,6L,9L,3L,1L,7L,6L,0L,5L,2L,9L,4L,9L,0L,3L,0L,7L,0L,1L,0L,4L,1L,5L,6L,8L,4L,3L,3L,8L,3L,4L,7L,4L,0L,4L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244977Inst : IEnumerable<long>
{
public static readonly long[] Value=A244977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244977.Bytes);
public long this[int i]=>Value[i];

public static A244977Inst Instance=new A244977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244978
{
public static readonly long[] Value={ 0L,9L,8L,1L,7L,4L,7L,7L,0L,4L,2L,4L,6L,8L,1L,0L,3L,8L,7L,0L,1L,9L,5L,7L,6L,0L,5L,7L,2L,7L,4L,8L,4L,4L,6L,5L,1L,3L,1L,1L,6L,1L,5L,4L,3L,7L,3L,0L,4L,7L,2L,0L,5L,6L,9L,0L,5L,4L,6L,7L,0L,1L,8L,5L,0L,9L,6L,1L,9L,2L,6L,2L,6L,9L,6L,4L,4L,4L,0L,3L,1L,2L,0L,7L,1L,2L,6L,0L,8L,8L,2L,9L,1L,9L,4L,1L,1L,5L,8L,3L,7L,4L,4L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244978Inst : IEnumerable<long>
{
public static readonly long[] Value=A244978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244978.Bytes);
public long this[int i]=>Value[i];

public static A244978Inst Instance=new A244978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244979
{
public static readonly long[] Value={ 7L,0L,2L,4L,8L,1L,4L,7L,3L,1L,0L,4L,0L,7L,2L,6L,3L,9L,3L,1L,5L,6L,3L,7L,4L,6L,4L,3L,2L,0L,4L,8L,9L,4L,7L,9L,9L,4L,6L,6L,5L,0L,9L,1L,8L,7L,0L,6L,7L,2L,0L,2L,4L,1L,9L,9L,8L,9L,7L,2L,1L,0L,2L,6L,1L,9L,2L,1L,4L,1L,8L,8L,0L,6L,1L,9L,1L,8L,8L,2L,0L,5L,1L,0L,4L,1L,4L,2L,4L,1L,5L,3L,6L,5L,7L,6L,7L,2L,4L,0L,2L,1L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244979Inst : IEnumerable<long>
{
public static readonly long[] Value=A244979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244979.Bytes);
public long this[int i]=>Value[i];

public static A244979Inst Instance=new A244979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244980
{
public static readonly long[] Value={ 6L,4L,1L,2L,7L,4L,9L,1L,5L,0L,8L,0L,9L,3L,2L,0L,4L,7L,7L,7L,2L,0L,1L,8L,1L,7L,9L,8L,3L,5L,5L,0L,3L,2L,0L,5L,7L,3L,3L,6L,3L,0L,3L,3L,3L,7L,8L,2L,0L,4L,6L,1L,6L,1L,5L,5L,0L,6L,9L,4L,8L,0L,3L,3L,7L,8L,1L,9L,9L,4L,1L,1L,7L,5L,6L,5L,1L,1L,0L,5L,0L,5L,1L,6L,6L,4L,3L,4L,5L,9L,5L,2L,6L,1L,9L,7L,2L,2L,0L,3L,7L,2L,5L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244980Inst : IEnumerable<long>
{
public static readonly long[] Value=A244980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244980.Bytes);
public long this[int i]=>Value[i];

public static A244980Inst Instance=new A244980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244981
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,32L,12L,9L,64L,128L,10L,18L,24L,256L,7L,48L,20L,512L,15L,1024L,36L,96L,27L,2048L,192L,72L,14L,4096L,30L,8192L,40L,25L,384L,16384L,11L,144L,80L,32768L,54L,28L,288L,768L,65536L,21L,131072L,1536L,50L,108L,60L,262144L,160L,576L,45L,524288L,1048576L,3072L,320L,81L,120L,2097152L,22L,6144L,4194304L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244981Inst : IEnumerable<long>
{
public static readonly long[] Value=A244981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244981.Bytes);
public long this[int i]=>Value[i];

public static A244981Inst Instance=new A244981Inst();

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