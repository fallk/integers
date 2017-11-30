using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A114741
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,29L,23L,151L,79L,223L,251L,641L,1367L,3761L,4441L,78301L,1637L,311567L,6011L,8094731L,32141L,161862479L,321007L,2589478657L,1047833L,46609567993L,52531163L,10813367243213L,803034293L,151386338370689L,17747231531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114741Inst : IEnumerable<long>
{
public static readonly long[] Value=A114741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114741.Bytes);
public long this[int i]=>Value[i];

public static A114741Inst Instance=new A114741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114742
{
public static readonly long[] Value={ 4L,4L,4L,6L,4L,6L,10L,2L,6L,4L,8L,8L,6L,22L,18L,4L,194L,26L,1352L,20L,5046L,16L,8070L,18L,44532L,232L,205862L,14L,188540L,80L,682452L,34L,553220L,72L,3310756L,78L,31907920L,60L,147850530L,82L,174357156L,6L,120995076L,6L,37671114L,22L,15590712L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114742Inst : IEnumerable<long>
{
public static readonly long[] Value=A114742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114742.Bytes);
public long this[int i]=>Value[i];

public static A114742Inst Instance=new A114742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114743
{
public static readonly long[] Value={ 4L,6L,10L,8L,12L,20L,16L,24L,40L,32L,48L,80L,64L,96L,160L,128L,192L,320L,256L,384L,640L,512L,768L,1280L,1024L,1536L,2560L,2048L,3072L,5120L,4096L,6144L,10240L,8192L,12288L,20480L,16384L,24576L,40960L,32768L,49152L,81920L,65536L,98304L,163840L,131072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114743Inst : IEnumerable<long>
{
public static readonly long[] Value=A114743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114743.Bytes);
public long this[int i]=>Value[i];

public static A114743Inst Instance=new A114743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114744
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,10L,8L,12L,20L,16L,24L,40L,32L,48L,80L,64L,96L,160L,128L,192L,320L,256L,384L,640L,512L,768L,1280L,1024L,2560L,2048L,3072L,5120L,4096L,6144L,10240L,8192L,12288L,20480L,16384L,24576L,40960L,32768L,49152L,81920L,65536L,98304L,131072L,196608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114744Inst : IEnumerable<long>
{
public static readonly long[] Value=A114744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114744.Bytes);
public long this[int i]=>Value[i];

public static A114744Inst Instance=new A114744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114745
{
public static readonly long[] Value={ 1L,3L,2L,4L,6L,10L,8L,12L,20L,16L,24L,40L,32L,48L,80L,64L,96L,160L,128L,192L,320L,256L,384L,640L,512L,768L,1280L,1024L,1536L,2560L,2048L,3072L,5120L,4096L,6144L,10240L,8192L,12288L,20480L,16384L,24576L,40960L,32768L,49152L,81920L,65536L,98304L,163840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114745Inst : IEnumerable<long>
{
public static readonly long[] Value=A114745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114745.Bytes);
public long this[int i]=>Value[i];

public static A114745Inst Instance=new A114745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114746
{
public static readonly long[] Value={ 1L,5L,2L,3L,7L,8L,6L,10L,14L,16L,12L,4L,20L,24L,36L,60L,48L,72L,120L,96L,144L,240L,192L,288L,480L,384L,576L,960L,768L,1152L,1920L,1536L,2304L,3840L,3072L,4608L,7680L,6144L,9216L,15360L,12288L,18432L,30720L,24576L,36864L,61440L,49152L,73728L,122880L,98304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114746Inst : IEnumerable<long>
{
public static readonly long[] Value=A114746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114746.Bytes);
public long this[int i]=>Value[i];

public static A114746Inst Instance=new A114746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114747
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,13L,377L,10946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114747Inst : IEnumerable<long>
{
public static readonly long[] Value=A114747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114747.Bytes);
public long this[int i]=>Value[i];

public static A114747Inst Instance=new A114747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114748
{
public static readonly long[] Value={ 3L,5L,4L,6L,78L,11001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114748Inst : IEnumerable<long>
{
public static readonly long[] Value=A114748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114748.Bytes);
public long this[int i]=>Value[i];

public static A114748Inst Instance=new A114748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114749
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,21L,50L,161L,501L,1532L,4723L,14551L,44800L,137971L,424901L,1308512L,4029693L,12409831L,38217250L,117693681L,362448951L,1116196192L,3437432913L,10585903361L,32600301650L,100395746291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114749Inst : IEnumerable<long>
{
public static readonly long[] Value=A114749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114749.Bytes);
public long this[int i]=>Value[i];

public static A114749Inst Instance=new A114749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114750
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,22L,8L,212L,44L,2112112L,636L,214997010799412L,692296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114750Inst : IEnumerable<long>
{
public static readonly long[] Value=A114750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114750.Bytes);
public long this[int i]=>Value[i];

public static A114750Inst Instance=new A114750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114751
{
public static readonly long[] Value={ 1L,3L,2L,3L,4L,5L,7L,6L,5L,4L,5L,6L,7L,8L,9L,11L,10L,9L,8L,7L,6L,7L,8L,9L,10L,11L,12L,13L,15L,14L,13L,12L,11L,10L,9L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114751Inst : IEnumerable<long>
{
public static readonly long[] Value=A114751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114751.Bytes);
public long this[int i]=>Value[i];

public static A114751Inst Instance=new A114751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114752
{
public static readonly long[] Value={ 1L,2L,5L,4L,9L,6L,13L,8L,17L,10L,21L,12L,25L,14L,29L,16L,33L,18L,37L,20L,41L,22L,45L,24L,49L,26L,53L,28L,57L,30L,61L,32L,65L,34L,69L,36L,73L,38L,77L,40L,81L,42L,85L,44L,89L,46L,93L,48L,97L,50L,101L,52L,105L,54L,109L,56L,113L,58L,117L,60L,121L,62L,125L,64L,129L,66L,133L,68L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114752Inst : IEnumerable<long>
{
public static readonly long[] Value=A114752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114752.Bytes);
public long this[int i]=>Value[i];

public static A114752Inst Instance=new A114752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114753
{
public static readonly long[] Value={ 1L,3L,3L,7L,5L,11L,7L,15L,9L,19L,11L,23L,13L,27L,15L,31L,17L,35L,19L,39L,21L,43L,23L,47L,25L,51L,27L,55L,29L,59L,31L,63L,33L,67L,35L,71L,37L,75L,39L,79L,41L,83L,43L,87L,45L,91L,47L,95L,49L,99L,51L,103L,53L,107L,55L,111L,57L,115L,59L,119L,61L,123L,63L,127L,65L,131L,67L,135L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114753Inst : IEnumerable<long>
{
public static readonly long[] Value=A114753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114753.Bytes);
public long this[int i]=>Value[i];

public static A114753Inst Instance=new A114753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114754
{
public static readonly BigInteger[] Value={ 11L,10111L,1231L,67891L,9101112131L,3456781L,91011121314151L,45678910111L,1234567891L,BigInteger.Parse("303132333435363738391"),12345678910111L,BigInteger.Parse("939495969798991001011021031041"),BigInteger.Parse("91011121314151617181920211") };
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
public class A114754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114754Inst Instance=new A114754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114755
{
public static readonly BigInteger[] Value={ 13L,233L,0L,12343L,345673L,0L,5678910113L,54555657585960613L,0L,BigInteger.Parse("373839404142434445463"),BigInteger.Parse("17181920212223242526273"),0L,2345678910111213143L,BigInteger.Parse("23242526272829303132333435363"),0L,BigInteger.Parse("8910111213141516171819202122233") };
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
public class A114755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114755Inst Instance=new A114755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114756
{
public static readonly BigInteger[] Value={ 17L,127L,1237L,12347L,123457L,56789107L,456789107L,3456789107L,4567891011127L,BigInteger.Parse("616263646566676869707"),BigInteger.Parse("13141516171819202122237"),BigInteger.Parse("2021222324252627282930317"),BigInteger.Parse("151617181920212223242526277") };
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
public class A114756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114756Inst Instance=new A114756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114757
{
public static readonly BigInteger[] Value={ 19L,239L,0L,23459L,345679L,0L,23456789L,234567899L,0L,2345678910119L,6789101112131415169L,0L,BigInteger.Parse("313233343536373839404142439"),BigInteger.Parse("36373839404142434445464748499"),0L,BigInteger.Parse("123456789101112131415169") };
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
public class A114757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114757Inst Instance=new A114757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114758
{
public static readonly BigInteger[] Value={ 11L,211L,5431L,76541L,17161514131L,1211109871L,98765431L,876543211L,9876543211L,BigInteger.Parse("242322212019181716151"),11109876543211L,BigInteger.Parse("1131121111101091081071061051041031021"),BigInteger.Parse("555453525150494847464544431") };
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
public class A114758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114758Inst Instance=new A114758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114759
{
public static readonly BigInteger[] Value={ 13L,433L,0L,54323L,654323L,0L,292827262524233L,987654323L,0L,1716151413121110983L,BigInteger.Parse("181716151413121110983"),0L,1413121110987654323L,BigInteger.Parse("27262524232221201918171615143"),0L,BigInteger.Parse("1716151413121110987654323") };
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
public class A114759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114759Inst Instance=new A114759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114760
{
public static readonly long[] Value={ 0L,0L,6L,0L,0L,4L,6L,5L,8L,0L,5L,2L,5L,4L,1L,2L,7L,9L,8L,7L,6L,8L,6L,8L,3L,3L,5L,0L,1L,2L,7L,1L,0L,2L,4L,6L,1L,5L,8L,0L,2L,4L,6L,9L,3L,3L,7L,1L,7L,2L,0L,7L,2L,8L,8L,0L,1L,0L,4L,3L,7L,1L,6L,4L,1L,2L,7L,9L,5L,6L,5L,4L,2L,2L,3L,1L,3L,8L,5L,8L,9L,7L,2L,4L,9L,9L,5L,5L,7L,4L,2L,3L,1L,6L,6L,0L,6L,9L,4L,8L,0L,7L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114760Inst : IEnumerable<long>
{
public static readonly long[] Value=A114760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114760.Bytes);
public long this[int i]=>Value[i];

public static A114760Inst Instance=new A114760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114761
{
public static readonly BigInteger[] Value={ 1L,196L,19881L,1999396L,199996164L,19999899241L,1999998409369L,199999982358225L,19999999932878736L,1999999998944727844L,BigInteger.Parse("199999999979325598129"),BigInteger.Parse("19999999999912458800169"),BigInteger.Parse("1999999999999731161391129"),BigInteger.Parse("199999999999973116139112900"),BigInteger.Parse("19999999999999857198323561481") };
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
public class A114761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114761Inst Instance=new A114761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114762
{
public static readonly BigInteger[] Value={ 1L,289L,29929L,2999824L,299982400L,29999972025L,2999997202500L,299999997378064L,29999999737806400L,2999999998029351249L,BigInteger.Parse("299999999976140205625"),BigInteger.Parse("29999999999692481531536"),BigInteger.Parse("2999999999996960966074624"),BigInteger.Parse("299999999999973224736673344") };
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
public class A114762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114762Inst Instance=new A114762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114763
{
public static readonly BigInteger[] Value={ 4L,484L,49729L,4999696L,499969600L,49999643236L,4999995628489L,499999965341041L,49999999664599209L,4999999997764872529L,BigInteger.Parse("499999999955372691076"),BigInteger.Parse("49999999999562191467001"),BigInteger.Parse("4999999999996468370295001"),BigInteger.Parse("499999999999959886546350009"),BigInteger.Parse("49999999999999566363399000484") };
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
public class A114763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114763Inst Instance=new A114763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114764
{
public static readonly BigInteger[] Value={ 4L,576L,59536L,5997601L,599956036L,59999522704L,5999996361121L,599999979040609L,59999999863652676L,5999999996163226564L,BigInteger.Parse("599999999959251220329"),BigInteger.Parse("59999999999844305621284"),BigInteger.Parse("5999999999999127500585089"),BigInteger.Parse("599999999999961739853364561"),BigInteger.Parse("59999999999999603270976352489") };
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
public class A114764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114764Inst Instance=new A114764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114765
{
public static readonly BigInteger[] Value={ 4L,676L,69696L,6996025L,699972849L,69999930625L,6999998354001L,699999994145169L,69999999943667161L,6999999999658218721L,BigInteger.Parse("699999999965821872100"),BigInteger.Parse("69999999999757088783236") };
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
public class A114765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114765Inst Instance=new A114765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114766
{
public static readonly BigInteger[] Value={ 4L,784L,79524L,7997584L,799984656L,79999596964L,7999999294329L,799999986001441L,79999999731514944L,7999999995778911376L,BigInteger.Parse("799999999973870935009"),BigInteger.Parse("79999999999649835200676"),BigInteger.Parse("7999999999998924645564516"),BigInteger.Parse("799999999999949033098946521"),BigInteger.Parse("79999999999999994478719195161") };
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
public class A114766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114766Inst Instance=new A114766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114767
{
public static readonly BigInteger[] Value={ 1L,1728L,1953125L,1995616979L,1999899757799L,1999995000191488L,1999999762390486961L,BigInteger.Parse("1999999762390486961000"),BigInteger.Parse("1999999952878604157540864"),BigInteger.Parse("1999999995738432193638080649"),BigInteger.Parse("1999999999548194715368954025992") };
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
public class A114767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114767Inst Instance=new A114767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114768
{
public static readonly BigInteger[] Value={ 2744L,2985984L,2998442888L,2999690679448L,2999940279271424L,2999996441139764249L,BigInteger.Parse("2999999561264112937375"),BigInteger.Parse("2999999998081694390995493"),BigInteger.Parse("2999999998081694390995493000"),BigInteger.Parse("2999999999953769831333566793927") };
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
public class A114768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114768Inst Instance=new A114768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114769
{
public static readonly BigInteger[] Value={ 1L,3375L,3944312L,3996969003L,3999992047624L,3999992047624000L,3999999607145042201L,BigInteger.Parse("3999999607145042201000"),BigInteger.Parse("3999999985121344326657625"),BigInteger.Parse("3999999992680870612043135651"),BigInteger.Parse("3999999999484444277033462628359") };
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
public class A114769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114769Inst Instance=new A114769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114770
{
public static readonly BigInteger[] Value={ 1L,4913L,4913000L,4991443829L,4999333821299L,4999947835616973L,4999991695706234375L,BigInteger.Parse("4999999590549541302479"),BigInteger.Parse("4999999941431658940060584"),BigInteger.Parse("4999999994063978001557890536"),BigInteger.Parse("4999999999327209928022135406696") };
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
public class A114770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114770Inst Instance=new A114770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114771
{
public static readonly BigInteger[] Value={ 1L,5832L,5929741L,5998805513L,5999796014211L,5999994127536128L,5999994127536128000L,BigInteger.Parse("5999999080425132440125"),BigInteger.Parse("5999999971945442706621379"),BigInteger.Parse("5999999991757006160038514688"),BigInteger.Parse("5999999999681631553616419338752") };
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
public class A114771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114771Inst Instance=new A114771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114772
{
public static readonly BigInteger[] Value={ 1L,6859L,6967871L,6989782528L,6999657683689L,6999987015630757L,6999997993540050491L,BigInteger.Parse("6999999091331611107231"),BigInteger.Parse("6999999969564942238839032"),BigInteger.Parse("6999999991520776458291360568"),BigInteger.Parse("6999999999205318445945995366283") };
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
public class A114772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114772Inst Instance=new A114772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114773
{
public static readonly BigInteger[] Value={ 8L,8000L,8998912L,8998912000L,8998912000000L,8999950375936512L,8999989316587931787L,BigInteger.Parse("8999999700780614080472"),BigInteger.Parse("8999999960385533477918968"),BigInteger.Parse("8999999999326271818113362767"),BigInteger.Parse("8999999999326271818113362767000"),BigInteger.Parse("8999999999975284124734907695022625") };
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
public class A114773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114773Inst Instance=new A114773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114774
{
public static readonly BigInteger[] Value={ 1L,484L,36926037L,390028372746496L,BigInteger.Parse("529195033467961989221875"),BigInteger.Parse("87790968451248283566530809327319616"),BigInteger.Parse("1721822624232088780005005254858227864441470903953") };
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
public class A114774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114774Inst Instance=new A114774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114775
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,4L,3L,4L,5L,7L,5L,7L,9L,12L,9L,12L,16L,21L,16L,21L,28L,37L,28L,37L,49L,65L,49L,65L,86L,114L,86L,114L,151L,200L,151L,200L,265L,351L,265L,351L,465L,616L,465L,616L,816L,1081L,816L,1081L,1432L,1897L,1432L,1897L,2513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114775Inst : IEnumerable<long>
{
public static readonly long[] Value=A114775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114775.Bytes);
public long this[int i]=>Value[i];

public static A114775Inst Instance=new A114775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114776
{
public static readonly BigInteger[] Value={ 10L,2116L,328509L,43046721L,5277319168L,646990183449L,75144747810816L,8507630225817856L,913517247483640899L,BigInteger.Parse("100848928101691211234384765625"),BigInteger.Parse("109720136792337134058077437970432"),BigInteger.Parse("119930107665749784656446787900870656") };
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
public class A114776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114776Inst Instance=new A114776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114777
{
public static readonly BigInteger[] Value={ 100L,2116L,33124L,443556L,5555449L,66650896L,777740544L,8888718400L,99999515529L,BigInteger.Parse("1010101010089161070864"),BigInteger.Parse("111111111110888888888889"),BigInteger.Parse("12121212121212422272144996"),BigInteger.Parse("1313131313131245483985582729") };
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
public class A114777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114777Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114777.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114777Inst Instance=new A114777Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114778
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,240L,4320L,120960L,9676800L,1567641600L,438939648000L,386266890240000L,750902834626560000L,BigInteger.Parse("2733286318040678400000"),BigInteger.Parse("33674087438261157888000000"),BigInteger.Parse("981936389699695364014080000000") };
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
public class A114778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114778Inst Instance=new A114778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114779
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,1440L,30240L,967680L,43545600L,5225472000L,1207084032000L,463520268288000L,271159356948480000L,BigInteger.Parse("455547719673446400000"),BigInteger.Parse("1578472848668491776000000"),BigInteger.Parse("9698137182219213471744000000") };
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
public class A114779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114779Inst Instance=new A114779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114780
{
public static readonly long[] Value={ 2L,3L,5L,7L,711L,913L,117L,0L,323L,1729L,231L,437L,0L,243L,1247L,1953L,759L,0L,3367L,3471L,2173L,2279L,0L,4089L,2597L,28101L,45103L,0L,2109L,18113L,43127L,40131L,0L,1139L,22149L,34151L,37157L,0L,13167L,62173L,37179L,17181L,0L,38193L,33197L,17199L,86211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114780Inst : IEnumerable<long>
{
public static readonly long[] Value=A114780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114780.Bytes);
public long this[int i]=>Value[i];

public static A114780Inst Instance=new A114780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114781
{
public static readonly long[] Value={ 2L,1L,1L,1L,79L,83L,9L,0L,19L,91L,11L,19L,0L,9L,43L,63L,23L,0L,91L,89L,53L,53L,0L,87L,53L,551L,851L,0L,37L,307L,707L,637L,0L,17L,321L,481L,509L,0L,171L,787L,459L,207L,0L,439L,373L,189L,927L,0L,291L,871L,933L,313L,0L,993L,773L,633L,613L,0L,481L,599L,523L,791L,0L,593L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114781Inst : IEnumerable<long>
{
public static readonly long[] Value=A114781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114781.Bytes);
public long this[int i]=>Value[i];

public static A114781Inst Instance=new A114781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114782
{
public static readonly BigInteger[] Value={ 0L,13L,0L,17L,0L,113L,0L,1019L,0L,0L,131L,137L,0L,100043L,0L,0L,0L,1061L,167L,0L,173L,179L,0L,0L,197L,0L,1103L,0L,1109L,0L,100000127L,0L,0L,10139L,0L,1151L,BigInteger.Parse("100000000000000000000157"),1163L,0L,0L,0L,1181L,0L,1193L,0L,1000199L,10211L,1223L,0L,1229L,0L,0L,1000000241L,0L,0L,0L,0L,10271L,1277L,0L,1283L,0L };
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
public class A114782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114782Inst Instance=new A114782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114783
{
public static readonly BigInteger[] Value={ 0L,13L,0L,17L,1111111111111111111L,113L,1117L,11119L,1123L,1129L,131L,137L,11111141L,111143L,BigInteger.Parse("11111111111111111111111111111147"),1153L,11159L,11161L,167L,1171L,173L,179L,1111183L,1111189L,197L,11111101L,1103L,11111111111111107L,1109L };
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
public class A114783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114783Inst Instance=new A114783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114784
{
public static readonly BigInteger[] Value={ 0L,23L,0L,227L,211L,2213L,BigInteger.Parse("22222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222217"),2222219L,223L,229L,BigInteger.Parse("2222222222222222222222222231"),2237L,241L,2243L,22247L };
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
public class A114784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114784Inst Instance=new A114784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114785
{
public static readonly long[] Value={ 0L,0L,0L,37L,311L,313L,317L,3319L,3323L,3329L,331L,337L,333341L,3343L,347L,353L,359L,3361L,367L,3371L,373L,379L,383L,389L,397L,333101L,333103L,33107L,3109L,33113L,3333333127L,333131L,3137L,333139L,33149L,33151L,33333333157L,3163L,3167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114785Inst : IEnumerable<long>
{
public static readonly long[] Value=A114785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114785.Bytes);
public long this[int i]=>Value[i];

public static A114785Inst Instance=new A114785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114786
{
public static readonly long[] Value={ 0L,43L,0L,47L,44444444444444411L,44444444413L,44417L,419L,4423L,4444444429L,431L,444444437L,4441L,443L,4447L,44453L,44444459L,461L,467L,4444471L,444473L,479L,4483L,44444489L,44497L,44101L,444444103L,444444444444107L,444109L,444113L,4127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114786Inst : IEnumerable<long>
{
public static readonly long[] Value=A114786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114786.Bytes);
public long this[int i]=>Value[i];

public static A114786Inst Instance=new A114786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114787
{
public static readonly BigInteger[] Value={ 0L,53L,0L,557L,55511L,BigInteger.Parse("55555555555555555555555555555555555555555555555555555555555555555555513"),55555517L,5519L,523L,55529L,5531L,0L,541L,55555543L,547L,55555553L,55555559L };
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
public class A114787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114787Inst Instance=new A114787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114788
{
public static readonly long[] Value={ 3L,7L,9L,11L,55L,29L,4913L,289L,21L,23L,325L,53L,15L,46L,81L,103L,325L,191L,261L,22L,111L,47L,3625L,10201L,183L,6859L,477L,59L,1771L,311L,28629151L,34L,35L,106L,1225L,149L,39L,118L,1161L,83L,715L,173L,45L,316L,93L,283L,60625L,9409L,801L,205L,261L,107L,11125L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114788Inst : IEnumerable<long>
{
public static readonly long[] Value=A114788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114788.Bytes);
public long this[int i]=>Value[i];

public static A114788Inst Instance=new A114788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114789
{
public static readonly BigInteger[] Value={ 1L,3L,7L,169L,677L,1355L,2711L,4304496906163L,BigInteger.Parse("1852869361516769972676380161"),BigInteger.Parse("66703297014603719016349685797"),BigInteger.Parse("400219782087622314098098114783"),BigInteger.Parse("31217143002834540499651652953075"),BigInteger.Parse("307176687147891878516572265058259") };
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
public class A114789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114789Inst Instance=new A114789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114790
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,10080L,241920L,8709120L,435456000L,28740096000L,4828336128000L,1506440871936000L,759246199455744000L,BigInteger.Parse("569434649591808000000"),BigInteger.Parse("601322989968949248000000") };
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
public class A114790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114790Inst Instance=new A114790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114791
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,1L,2L,6L,6L,1L,2L,7L,10L,11L,1L,2L,7L,13L,22L,18L,1L,2L,7L,14L,30L,42L,31L,1L,2L,7L,15L,34L,60L,82L,54L,1L,2L,7L,15L,36L,71L,125L,157L,97L,1L,2L,7L,15L,37L,77L,152L,256L,304L,172L,1L,2L,7L,15L,37L,81L,168L,325L,513L,589L,309L,1L,2L,7L,15L,37L,83L,177L,367L,669L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114791Inst : IEnumerable<long>
{
public static readonly long[] Value=A114791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114791.Bytes);
public long this[int i]=>Value[i];

public static A114791Inst Instance=new A114791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114792
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,8L,10L,7L,12L,11L,9L,14L,16L,17L,13L,19L,18L,15L,22L,21L,24L,26L,23L,20L,27L,25L,29L,35L,30L,32L,28L,37L,31L,36L,38L,34L,40L,41L,33L,45L,39L,43L,42L,50L,51L,46L,44L,48L,52L,47L,56L,54L,55L,57L,49L,59L,58L,53L,64L,67L,61L,60L,63L,71L,66L,70L,62L,68L,72L,74L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114792Inst : IEnumerable<long>
{
public static readonly long[] Value=A114792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114792.Bytes);
public long this[int i]=>Value[i];

public static A114792Inst Instance=new A114792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114793
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,33L,1214L,1509733L,2281082919633L,BigInteger.Parse("5203342727366374356990526"),BigInteger.Parse("27074775538448408469117040958804384971249439965813"),BigInteger.Parse("733043470457364306745565389055274337169526356099299839341244874661931850021760795731279812250002545") };
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
public class A114793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114793Inst Instance=new A114793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114794
{
public static readonly BigInteger[] Value={ 2L,23L,2351L,2357L,2357119L,2357111357L,23571113171L,23571113171939L,2357111317192343L,23571113171923297L,2357111317192329319L,BigInteger.Parse("235711131719232931373"),BigInteger.Parse("235711131719232931374149") };
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
public class A114794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114794Inst Instance=new A114794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114795
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,3L,3L,1L,0L,1L,6L,9L,2L,1L,6L,1L,4L,9L,0L,1L,12L,17L,4L,9L,21L,21L,0L,13L,11L,21L,20L,17L,6L,29L,1L,9L,8L,25L,36L,1L,0L,33L,41L,17L,36L,23L,26L,33L,34L,21L,30L,41L,38L,27L,6L,1L,36L,39L,7L,21L,31L,59L,54L,49L,21L,39L,57L,45L,60L,41L,31L,9L,37L,41L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114795Inst : IEnumerable<long>
{
public static readonly long[] Value=A114795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114795.Bytes);
public long this[int i]=>Value[i];

public static A114795Inst Instance=new A114795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114796
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,80640L,2177280L,87091200L,4790016000L,344881152000L,31384184832000L,7030057402368000L,2847173247959040000L,BigInteger.Parse("1822190878693785600000"),BigInteger.Parse("1703748471578689536000000") };
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
public class A114796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114796Inst Instance=new A114796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114797
{
public static readonly long[] Value={ 6L,12L,10L,24L,14L,24L,18L,30L,22L,60L,26L,42L,30L,48L,34L,72L,38L,60L,42L,66L,46L,120L,50L,78L,54L,84L,58L,120L,62L,96L,66L,102L,70L,180L,74L,114L,78L,120L,82L,168L,86L,132L,90L,138L,94L,240L,98L,150L,102L,156L,106L,216L,110L,168L,114L,174L,118L,420L,122L,186L,126L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114797Inst : IEnumerable<long>
{
public static readonly long[] Value=A114797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114797.Bytes);
public long this[int i]=>Value[i];

public static A114797Inst Instance=new A114797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114798
{
public static readonly long[] Value={ 3L,2L,12L,16L,27L,54L,48L,128L,75L,250L,108L,432L,147L,686L,192L,1024L,243L,1458L,300L,2000L,363L,2662L,432L,3456L,507L,4394L,588L,5488L,675L,6750L,768L,8192L,867L,9826L,972L,11664L,1083L,13718L,1200L,16000L,1323L,18522L,1452L,21296L,1587L,24334L,1728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114798Inst : IEnumerable<long>
{
public static readonly long[] Value=A114798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114798.Bytes);
public long this[int i]=>Value[i];

public static A114798Inst Instance=new A114798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114799
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,7L,8L,18L,30L,44L,60L,78L,98L,120L,288L,510L,792L,1140L,1560L,2058L,2640L,6624L,12240L,19800L,29640L,42120L,57624L,76560L,198720L,379440L,633600L,978120L,1432080L,2016840L,2756160L,7352640L,14418720L,24710400L,39124800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114799Inst : IEnumerable<long>
{
public static readonly long[] Value=A114799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114799.Bytes);
public long this[int i]=>Value[i];

public static A114799Inst Instance=new A114799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114800
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,20L,33L,48L,65L,84L,105L,128L,153L,360L,627L,960L,1365L,1848L,2415L,3072L,3825L,9360L,16929L,26880L,39585L,55440L,74865L,98304L,126225L,318240L,592515L,967680L,1464645L,2106720L,2919735L,3932160L,5175225L,13366080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114800Inst : IEnumerable<long>
{
public static readonly long[] Value=A114800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114800.Bytes);
public long this[int i]=>Value[i];

public static A114800Inst Instance=new A114800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114801
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,22L,30L,33L,40L,44L,50L,55L,60L,66L,70L,77L,80L,88L,90L,99L,100L,121L,123L,124L,125L,126L,127L,128L,129L,131L,132L,134L,135L,136L,137L,138L,139L,141L,142L,143L,145L,146L,147L,148L,149L,151L,152L,153L,154L,156L,157L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114801Inst : IEnumerable<long>
{
public static readonly long[] Value=A114801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114801.Bytes);
public long this[int i]=>Value[i];

public static A114801Inst Instance=new A114801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114802
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,22L,30L,33L,40L,44L,50L,55L,60L,66L,70L,77L,80L,88L,90L,99L,100L,121L,131L,141L,151L,161L,171L,181L,191L,200L,212L,232L,242L,252L,262L,272L,282L,292L,300L,313L,323L,343L,353L,363L,373L,383L,393L,400L,414L,424L,434L,454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114802Inst : IEnumerable<long>
{
public static readonly long[] Value=A114802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114802.Bytes);
public long this[int i]=>Value[i];

public static A114802Inst Instance=new A114802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114803
{
public static readonly long[] Value={ 1L,3L,8L,12L,27L,27L,64L,48L,125L,75L,216L,108L,343L,147L,512L,192L,729L,243L,1000L,300L,1331L,363L,1728L,432L,2197L,507L,2744L,588L,3375L,675L,4096L,768L,4913L,867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114803Inst : IEnumerable<long>
{
public static readonly long[] Value=A114803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114803.Bytes);
public long this[int i]=>Value[i];

public static A114803Inst Instance=new A114803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114804
{
public static readonly long[] Value={ 282L,680L,242L,728L,218L,665L,601L,968L,259L,48L,177L,146L,531L,440L,159L,432L,247L,829L,681L,434L,890L,643L,46L,720L,129L,140L,162L,387L,420L,488L,116L,226L,146L,634L,867L,844L,1L,46L,35L,320L,231L,381L,59L,608L,941L,431L,788L,262L,824L,295L,364L,808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114804Inst : IEnumerable<long>
{
public static readonly long[] Value=A114804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114804.Bytes);
public long this[int i]=>Value[i];

public static A114804Inst Instance=new A114804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114805
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,36L,60L,96L,146L,212L,380L,692L,1196L,1946L,3002L,5858L,11474L,21050L,36050L,58226L,121058L,250226L,480050L,855050L,1431626L,3128090L,6744794L,13409690L,24659690L,42533546L,96820394L,216171626L,442778090L,836528090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114805Inst : IEnumerable<long>
{
public static readonly long[] Value=A114805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114805.Bytes);
public long this[int i]=>Value[i];

public static A114805Inst Instance=new A114805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114806
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,22L,36L,52L,70L,90L,112L,136L,162L,190L,440L,756L,1144L,1610L,2160L,2800L,3536L,4374L,5320L,12760L,22680L,35464L,51520L,71280L,95200L,123760L,157464L,196840L,484880L,884520L,1418560L,2112320L,2993760L,4093600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114806Inst : IEnumerable<long>
{
public static readonly long[] Value=A114806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114806.Bytes);
public long this[int i]=>Value[i];

public static A114806Inst Instance=new A114806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114807
{
public static readonly long[] Value={ 315L,632L,551L,234L,951L,638L,365L,535L,262L,143L,104L,857L,541L,943L,316L,777L,215L,671L,886L,326L,843L,545L,510L,737L,418L,234L,294L,967L,295L,171L,798L,691L,836L,871L,947L,673L,527L,487L,790L,694L,310L,995L,116L,277L,754L,398L,465L,111L,317L,592L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114807Inst : IEnumerable<long>
{
public static readonly long[] Value=A114807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114807.Bytes);
public long this[int i]=>Value[i];

public static A114807Inst Instance=new A114807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114808
{
public static readonly long[] Value={ 424L,124L,624L,312L,415L,624L,781L,243L,906L,241L,953L,124L,976L,562L,448L,828L,124L,244L,140L,624L,122L,70L,312L,461L,35L,156L,243L,51L,757L,812L,415L,258L,789L,62L,476L,293L,945L,312L,438L,146L,972L,656L,241L,907L,348L,632L,812L,495L,367L,431L,640L,624L,476L,837L,158L,203L,124L,238L,418L,579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114808Inst : IEnumerable<long>
{
public static readonly long[] Value=A114808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114808.Bytes);
public long this[int i]=>Value[i];

public static A114808Inst Instance=new A114808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114809
{
public static readonly BigInteger[] Value={ 12L,945L,20L,18L,12L,5391411025L,12L,12L,12L,81081L,12L,70L,12L,6435L,56L,24L,12L,5775L,12L,18L,20L,945L,12L,20L,20L,945L,18L,18L,12L,BigInteger.Parse("20169691981106018776756331"),12L,48L,20L,945L,12L,30L,12L,945L,20L,12L,12L,366005822969340125L,12L,18L,12L,945L };
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
public class A114809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114809Inst Instance=new A114809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114810
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,2L,4L,4L,10L,2L,12L,6L,8L,4L,16L,4L,18L,4L,12L,10L,22L,4L,16L,12L,12L,6L,28L,8L,30L,8L,20L,16L,24L,4L,36L,18L,24L,8L,40L,12L,42L,10L,16L,22L,46L,8L,36L,16L,32L,12L,52L,12L,40L,12L,36L,28L,58L,8L,60L,30L,24L,16L,48L,20L,66L,16L,44L,24L,70L,8L,72L,36L,32L,18L,60L,24L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114810Inst : IEnumerable<long>
{
public static readonly long[] Value=A114810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114810.Bytes);
public long this[int i]=>Value[i];

public static A114810Inst Instance=new A114810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114811
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,2L,0L,2L,2L,2L,2L,2L,4L,0L,2L,0L,2L,2L,4L,2L,2L,4L,0L,2L,0L,2L,2L,4L,2L,0L,4L,2L,4L,0L,2L,2L,4L,4L,2L,4L,2L,2L,0L,2L,2L,0L,0L,0L,4L,2L,2L,0L,4L,4L,4L,2L,2L,4L,2L,2L,0L,0L,4L,4L,2L,2L,4L,4L,2L,0L,2L,2L,0L,2L,4L,4L,2L,0L,0L,2L,2L,4L,4L,2L,4L,4L,2L,0L,4L,2L,4L,2L,4L,0L,2L,0L,0L,0L,2L,4L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114811Inst : IEnumerable<long>
{
public static readonly long[] Value=A114811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114811.Bytes);
public long this[int i]=>Value[i];

public static A114811Inst Instance=new A114811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114812
{
public static readonly long[] Value={ 6L,15L,16L,21L,25L,33L,35L,37L,38L,39L,46L,49L,51L,58L,62L,65L,67L,82L,86L,103L,106L,119L,122L,139L,142L,145L,158L,166L,179L,181L,226L,233L,235L,241L,257L,263L,274L,281L,299L,301L,317L,337L,383L,389L,419L,457L,463L,473L,479L,491L,521L,541L,557L,619L,643L,659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114812Inst : IEnumerable<long>
{
public static readonly long[] Value=A114812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114812.Bytes);
public long this[int i]=>Value[i];

public static A114812Inst Instance=new A114812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114813
{
public static readonly long[] Value={ 20L,27L,28L,32L,52L,55L,74L,77L,85L,87L,93L,97L,115L,123L,143L,146L,149L,157L,161L,163L,178L,187L,197L,209L,211L,214L,215L,221L,223L,239L,242L,249L,262L,269L,283L,287L,307L,311L,313L,321L,334L,349L,379L,391L,393L,409L,421L,453L,487L,493L,499L,523L,581L,586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114813Inst : IEnumerable<long>
{
public static readonly long[] Value=A114813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114813.Bytes);
public long this[int i]=>Value[i];

public static A114813Inst Instance=new A114813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114814
{
public static readonly long[] Value={ 18L,44L,45L,57L,63L,68L,69L,76L,91L,98L,111L,118L,124L,125L,134L,141L,169L,172L,183L,185L,201L,202L,203L,213L,218L,229L,247L,253L,267L,302L,303L,329L,335L,347L,363L,371L,373L,377L,381L,382L,386L,395L,398L,413L,415L,439L,443L,461L,497L,501L,529L,547L,563L,579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114814Inst : IEnumerable<long>
{
public static readonly long[] Value=A114814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114814.Bytes);
public long this[int i]=>Value[i];

public static A114814Inst Instance=new A114814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114815
{
public static readonly long[] Value={ 12L,40L,50L,64L,75L,92L,95L,99L,116L,117L,129L,133L,153L,155L,159L,177L,188L,194L,205L,206L,219L,237L,245L,265L,278L,314L,323L,327L,339L,341L,343L,346L,356L,358L,361L,362L,394L,407L,411L,417L,422L,427L,437L,446L,454L,466L,482L,502L,503L,505L,514L,515L,527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114815Inst : IEnumerable<long>
{
public static readonly long[] Value=A114815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114815.Bytes);
public long this[int i]=>Value[i];

public static A114815Inst Instance=new A114815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114816
{
public static readonly long[] Value={ 30L,42L,56L,66L,70L,81L,104L,105L,136L,148L,152L,164L,175L,195L,207L,212L,244L,254L,259L,289L,291L,292L,298L,305L,319L,326L,332L,344L,365L,367L,403L,404L,423L,445L,447L,451L,458L,478L,489L,511L,517L,519L,526L,533L,537L,543L,554L,565L,566L,597L,605L,679L,681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114816Inst : IEnumerable<long>
{
public static readonly long[] Value=A114816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114816.Bytes);
public long this[int i]=>Value[i];

public static A114816Inst Instance=new A114816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114817
{
public static readonly long[] Value={ 54L,78L,102L,128L,130L,135L,147L,154L,170L,171L,182L,217L,231L,236L,238L,279L,290L,309L,316L,338L,355L,374L,436L,442L,452L,471L,481L,524L,538L,548L,553L,649L,694L,725L,796L,801L,818L,833L,838L,847L,849L,851L,886L,889L,922L,923L,926L,939L,949L,958L,963L,965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114817Inst : IEnumerable<long>
{
public static readonly long[] Value=A114817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114817.Bytes);
public long this[int i]=>Value[i];

public static A114817Inst Instance=new A114817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114818
{
public static readonly long[] Value={ 24L,80L,88L,110L,112L,184L,186L,189L,196L,225L,232L,243L,246L,248L,255L,268L,272L,275L,284L,286L,295L,328L,333L,357L,370L,412L,418L,425L,435L,477L,539L,556L,559L,561L,575L,591L,602L,603L,604L,625L,628L,629L,639L,689L,692L,695L,712L,717L,722L,747L,763L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114818Inst : IEnumerable<long>
{
public static readonly long[] Value=A114818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114818.Bytes);
public long this[int i]=>Value[i];

public static A114818Inst Instance=new A114818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114819
{
public static readonly long[] Value={ 36L,100L,114L,165L,174L,256L,266L,273L,282L,296L,304L,322L,325L,366L,369L,376L,406L,424L,428L,429L,484L,494L,506L,574L,578L,589L,633L,637L,642L,646L,652L,658L,663L,664L,668L,669L,670L,687L,705L,716L,724L,742L,754L,779L,782L,807L,845L,892L,909L,921L,946L,956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114819Inst : IEnumerable<long>
{
public static readonly long[] Value=A114819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114819.Bytes);
public long this[int i]=>Value[i];

public static A114819Inst Instance=new A114819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114820
{
public static readonly long[] Value={ 138L,140L,160L,190L,208L,222L,230L,250L,261L,285L,310L,318L,345L,351L,387L,388L,399L,402L,426L,469L,470L,483L,485L,488L,498L,507L,508L,518L,531L,534L,549L,568L,596L,598L,632L,656L,671L,678L,686L,688L,703L,715L,786L,788L,806L,808L,844L,872L,873L,874L,902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114820Inst : IEnumerable<long>
{
public static readonly long[] Value=A114820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114820.Bytes);
public long this[int i]=>Value[i];

public static A114820Inst Instance=new A114820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114821
{
public static readonly long[] Value={ 48L,60L,90L,126L,176L,258L,297L,315L,375L,385L,410L,430L,441L,459L,474L,475L,496L,555L,609L,621L,627L,638L,682L,710L,711L,729L,734L,759L,805L,814L,826L,854L,875L,897L,903L,906L,908L,925L,932L,935L,981L,987L,994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114821Inst : IEnumerable<long>
{
public static readonly long[] Value=A114821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114821.Bytes);
public long this[int i]=>Value[i];

public static A114821Inst Instance=new A114821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114822
{
public static readonly long[] Value={ 84L,132L,156L,162L,224L,234L,260L,354L,364L,368L,405L,434L,438L,455L,472L,512L,536L,584L,585L,595L,610L,615L,645L,693L,741L,775L,777L,822L,830L,834L,867L,904L,931L,957L,962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114822Inst : IEnumerable<long>
{
public static readonly long[] Value=A114822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114822.Bytes);
public long this[int i]=>Value[i];

public static A114822Inst Instance=new A114822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114823
{
public static readonly long[] Value={ 120L,200L,220L,228L,260L,368L,392L,405L,414L,434L,472L,492L,512L,536L,584L,585L,595L,610L,615L,618L,645L,654L,693L,741L,762L,777L,830L,867L,894L,904L,931L,942L,957L,962L,978L,1045L,1066L,1070L,1074L,1102L,1106L,1108L,1147L,1194L,1209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114823Inst : IEnumerable<long>
{
public static readonly long[] Value=A114823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114823.Bytes);
public long this[int i]=>Value[i];

public static A114823Inst Instance=new A114823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114824
{
public static readonly long[] Value={ 176L,192L,198L,224L,297L,315L,364L,385L,410L,430L,441L,455L,496L,555L,582L,606L,609L,621L,627L,638L,682L,710L,711L,726L,729L,734L,759L,775L,805L,814L,826L,846L,854L,897L,903L,908L,932L,935L,981L,987L,994L,1001L,1002L,1022L,1025L,1067L,1086L,1089L,1105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114824Inst : IEnumerable<long>
{
public static readonly long[] Value=A114824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114824.Bytes);
public long this[int i]=>Value[i];

public static A114824Inst Instance=new A114824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114825
{
public static readonly long[] Value={ 140L,144L,150L,160L,162L,190L,204L,208L,230L,234L,261L,285L,306L,310L,345L,351L,354L,372L,387L,388L,399L,438L,459L,469L,470L,475L,483L,485L,488L,507L,508L,518L,531L,549L,568L,596L,598L,632L,656L,671L,686L,688L,715L,788L,806L,808L,822L,834L,844L,872L,873L,874L,902L,925L,1005L,1048L,1052L,1058L,1073L,1076L,1083L,1101L,1113L,1124L,1131L,1146L,1158L,1162L,1166L,1173L,1195L,1205L,1221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114825Inst : IEnumerable<long>
{
public static readonly long[] Value=A114825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114825.Bytes);
public long this[int i]=>Value[i];

public static A114825Inst Instance=new A114825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114826
{
public static readonly long[] Value={ 90L,126L,165L,256L,258L,266L,296L,304L,322L,369L,375L,376L,424L,428L,429L,474L,484L,494L,506L,574L,578L,589L,633L,646L,652L,658L,663L,664L,668L,669L,670L,687L,703L,705L,716L,724L,742L,754L,779L,782L,807L,845L,875L,892L,906L,909L,921L,946L,956L,964L,986L,1004L,1054L,1075L,1084L,1119L,1126L,1132L,1149L,1169L,1171L,1214L,1222L,1227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114826Inst : IEnumerable<long>
{
public static readonly long[] Value=A114826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114826.Bytes);
public long this[int i]=>Value[i];

public static A114826Inst Instance=new A114826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114827
{
public static readonly long[] Value={ 648L,342L,240L,16L,806L,117L,648L,823L,542L,576L,480L,40L,353L,606L,282L,475L,248L,197L,732L,674L,213L,841L,287L,200L,968L,890L,104L,66L,782L,230L,728L,484L,747L,561L,509L,942L,332L,329L,305L,696L,2L,326L,305L,139L,872L,61L,628L,413L,597L,910L,448L,113L,988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114827Inst : IEnumerable<long>
{
public static readonly long[] Value=A114827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114827.Bytes);
public long this[int i]=>Value[i];

public static A114827Inst Instance=new A114827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114828
{
public static readonly long[] Value={ 64L,96L,128L,144L,162L,182L,198L,216L,224L,234L,246L,270L,278L,288L,304L,310L,320L,324L,352L,390L,414L,416L,432L,438L,480L,504L,528L,544L,550L,558L,584L,594L,600L,646L,648L,654L,662L,684L,694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114828Inst : IEnumerable<long>
{
public static readonly long[] Value=A114828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114828.Bytes);
public long this[int i]=>Value[i];

public static A114828Inst Instance=new A114828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114829
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,14L,18L,23L,29L,36L,44L,53L,63L,74L,87L,101L,117L,135L,155L,177L,201L,227L,256L,287L,321L,358L,398L,442L,489L,540L,595L,654L,717L,785L,858L,936L,1019L,1107L,1201L,1301L,1408L,1521L,1641L,1768L,1903L,2046L,2197L,2356L,2524L,2701L,2888L,3085L,3292L,3510L,3739L,3979L,4231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114829Inst : IEnumerable<long>
{
public static readonly long[] Value=A114829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114829.Bytes);
public long this[int i]=>Value[i];

public static A114829Inst Instance=new A114829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114830
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,13L,18L,24L,31L,39L,48L,59L,71L,85L,101L,119L,139L,162L,187L,215L,246L,280L,318L,359L,404L,453L,507L,565L,628L,697L,771L,851L,937L,1029L,1128L,1234L,1348L,1470L,1600L,1738L,1885L,2042L,2209L,2386L,2574L,2773L,2984L,3207L,3443L,3692L,3955L,4232L,4524L,4831L,5154L,5494L,5851L,6226L,6620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114830Inst : IEnumerable<long>
{
public static readonly long[] Value=A114830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114830.Bytes);
public long this[int i]=>Value[i];

public static A114830Inst Instance=new A114830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114831
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,14L,24L,41L,71L,122L,211L,365L,632L,1094L,1895L,3282L,5684L,9845L,17052L,29534L,51154L,88601L,153461L,265802L,460382L,797405L,1381145L,2392213L,4143434L,7176638L,12430301L,21529913L,37290903L,64589738L,111872708L,193769214L,335618123L,581307641L,1006854369L,174392292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114831Inst : IEnumerable<long>
{
public static readonly long[] Value=A114831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114831.Bytes);
public long this[int i]=>Value[i];

public static A114831Inst Instance=new A114831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114832
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,23L,40L,70L,121L,210L,364L,631L,1093L,1894L,3281L,5683L,9844L,17050L,29532L,51151L,88597L,153455L,265792L,460366L,797377L,1381098L,2392132L,4143295L,7176398L,12429886L,21529195L,37289660L,64587586L,111868981L,193762759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114832Inst : IEnumerable<long>
{
public static readonly long[] Value=A114832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114832.Bytes);
public long this[int i]=>Value[i];

public static A114832Inst Instance=new A114832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114833
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,15L,28L,51L,93L,168L,304L,550L,995L,1799L,3253L,5882L,10635L,19229L,34767L,62861L,113656L,205497L,371550L,671782L,1214618L,2196094L,3970654L,7179153L,12980288L,23469047L,42433278L,76721609L,138716724L,250807167L,453472612L,819902445L,1482426947L,2680306255L,4846135343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114833Inst : IEnumerable<long>
{
public static readonly long[] Value=A114833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114833.Bytes);
public long this[int i]=>Value[i];

public static A114833Inst Instance=new A114833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114834
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,16L,28L,50L,90L,162L,293L,529L,956L,1728L,3124L,5648L,10211L,18462L,33380L,60352L,109119L,197293L,356716L,644961L,1166123L,2108412L,3812120L,6892514L,12462029L,22532007L,40739059L,73658371L,133178227L,240793271L,435366958L,787166465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114834Inst : IEnumerable<long>
{
public static readonly long[] Value=A114834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114834.Bytes);
public long this[int i]=>Value[i];

public static A114834Inst Instance=new A114834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114835
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,919L,94049L,94649L,94849L,94949L,96469L,98689L,9809089L,9888889L,9889889L,9908099L,9980899L,9989899L,900808009L,906686609L,906989609L,908000809L,908444809L,908808809L,909848909L,960898069L,968999869L,988000889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114835Inst : IEnumerable<long>
{
public static readonly long[] Value=A114835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114835.Bytes);
public long this[int i]=>Value[i];

public static A114835Inst Instance=new A114835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114836
{
public static readonly long[] Value={ 80L,84L,88L,96L,100L,108L,132L,138L,156L,184L,189L,196L,222L,232L,243L,248L,250L,255L,268L,272L,273L,284L,286L,295L,318L,325L,328L,333L,357L,370L,402L,406L,412L,418L,426L,435L,477L,498L,534L,539L,556L,559L,561L,591L,602L,603L,604L,628L,629L,637L,639L,678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114836Inst : IEnumerable<long>
{
public static readonly long[] Value=A114836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114836.Bytes);
public long this[int i]=>Value[i];

public static A114836Inst Instance=new A114836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114837
{
public static readonly long[] Value={ 60L,72L,110L,112L,114L,128L,130L,135L,147L,154L,170L,171L,174L,217L,225L,231L,236L,238L,275L,279L,282L,290L,309L,316L,338L,355L,366L,374L,425L,436L,442L,452L,471L,481L,524L,538L,548L,553L,575L,642L,649L,694L,796L,801L,818L,833L,838L,847L,849L,851L,886L,889L,922L,923L,926L,939L,949L,958L,963L,965L,971L,979L,1037L,1041L,1077L,1079L,1094L,1111L,1127L,1137L,1141L,1153L,1154L,1189L,1211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114837Inst : IEnumerable<long>
{
public static readonly long[] Value=A114837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114837.Bytes);
public long this[int i]=>Value[i];

public static A114837Inst Instance=new A114837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114838
{
public static readonly long[] Value={ 70L,81L,104L,105L,136L,148L,152L,164L,182L,186L,195L,207L,212L,244L,246L,254L,259L,289L,291L,292L,298L,305L,319L,326L,332L,344L,365L,367L,403L,404L,423L,445L,447L,451L,458L,478L,489L,511L,517L,519L,526L,533L,537L,543L,554L,565L,566L,597L,605L,679L,681L,685L,698L,699L,701L,721L,723L,725L,737L,745L,746L,749L,753L,758L,766L,767L,785L,813L,817L,831L,842L,871L,879L,901L,905L,914L,955L,967L,973L,985L,998L,1006L,1007L,1009L,1043L,1046L,1051L,1133L,1139L,1159L,1167L,1174L,1175L,1177L,1191L,1199L,1207L,1219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114838Inst : IEnumerable<long>
{
public static readonly long[] Value=A114838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114838.Bytes);
public long this[int i]=>Value[i];

public static A114838Inst Instance=new A114838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114839
{
public static readonly long[] Value={ 40L,48L,54L,56L,64L,78L,92L,95L,99L,102L,116L,117L,129L,133L,155L,159L,175L,177L,188L,194L,205L,206L,219L,237L,245L,265L,278L,314L,323L,327L,339L,341L,343L,346L,356L,358L,361L,362L,394L,407L,411L,417L,422L,427L,437L,446L,454L,466L,482L,502L,503L,505L,514L,515L,527L,535L,542L,545L,551L,562L,573L,577L,583L,593L,607L,614L,622L,623L,625L,634L,655L,662L,667L,674L,713L,727L,731L,769L,781L,789L,791L,803L,809L,821L,835L,893L,917L,919L,974L,977L,982L,993L,995L,1013L,1039L,1047L,1057L,1081L,1097L,1103L,1121L,1138L,1151L,1165L,1172L,1202L,1203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114839Inst : IEnumerable<long>
{
public static readonly long[] Value=A114839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114839.Bytes);
public long this[int i]=>Value[i];

public static A114839Inst Instance=new A114839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114840
{
public static readonly long[] Value={ 30L,36L,42L,44L,45L,50L,57L,63L,66L,68L,69L,75L,76L,98L,111L,118L,124L,134L,141L,153L,169L,172L,183L,185L,201L,202L,203L,213L,218L,229L,247L,253L,267L,302L,303L,329L,335L,347L,363L,371L,373L,377L,381L,382L,386L,395L,398L,413L,415L,439L,443L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114840Inst : IEnumerable<long>
{
public static readonly long[] Value=A114840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114840.Bytes);
public long this[int i]=>Value[i];

public static A114840Inst Instance=new A114840Inst();

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