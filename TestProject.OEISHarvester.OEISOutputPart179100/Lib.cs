using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A209557
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,2L,7L,7L,1L,3L,9L,18L,15L,1L,3L,16L,30L,41L,31L,1L,4L,18L,60L,87L,88L,63L,1L,4L,28L,78L,189L,232L,183L,127L,1L,5L,30L,136L,285L,535L,585L,374L,255L,1L,5L,43L,160L,541L,931L,1410L,1418L,757L,511L,1L,6L,45L,255L,705L,1886L,2808L,3534L,3339L,1524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209557Inst : IEnumerable<long>
{
public static readonly long[] Value=A209557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209557.Bytes);
public long this[int i]=>Value[i];

public static A209557Inst Instance=new A209557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209558
{
public static readonly long[] Value={ 1L,2L,2L,2L,5L,4L,3L,7L,11L,8L,3L,13L,21L,23L,16L,4L,15L,44L,57L,47L,32L,4L,24L,60L,129L,145L,95L,64L,5L,26L,108L,207L,346L,353L,191L,128L,5L,38L,130L,405L,646L,875L,833L,383L,256L,6L,40L,212L,545L,1345L,1877L,2124L,1921L,767L,512L,6L,55L,240L,965L,2021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209558Inst : IEnumerable<long>
{
public static readonly long[] Value=A209558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209558.Bytes);
public long this[int i]=>Value[i];

public static A209558Inst Instance=new A209558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209559
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,5L,8L,3L,1L,9L,17L,15L,4L,1L,15L,38L,39L,24L,5L,1L,25L,76L,104L,74L,35L,6L,1L,41L,149L,242L,229L,125L,48L,7L,1L,67L,282L,543L,607L,440L,195L,63L,8L,1L,109L,524L,1159L,1531L,1308L,769L,287L,80L,9L,1L,177L,957L,2401L,3631L,3660L,2533L,1253L,404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209559Inst : IEnumerable<long>
{
public static readonly long[] Value=A209559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209559.Bytes);
public long this[int i]=>Value[i];

public static A209559Inst Instance=new A209559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209560
{
public static readonly long[] Value={ 1L,3L,1L,5L,5L,1L,9L,12L,7L,1L,15L,29L,22L,9L,1L,25L,61L,66L,35L,11L,1L,41L,124L,166L,125L,51L,13L,1L,67L,241L,394L,365L,211L,70L,15L,1L,109L,457L,877L,988L,701L,329L,92L,17L,1L,177L,848L,1877L,2472L,2129L,1225L,484L,117L,19L,1L,287L,1549L,3884L,5880L,5909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209560Inst : IEnumerable<long>
{
public static readonly long[] Value=A209560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209560.Bytes);
public long this[int i]=>Value[i];

public static A209560Inst Instance=new A209560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209561
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,4L,3L,1L,4L,7L,7L,4L,1L,5L,11L,14L,11L,5L,1L,6L,16L,25L,25L,16L,6L,1L,7L,22L,41L,50L,41L,22L,7L,1L,8L,29L,63L,91L,91L,63L,29L,8L,1L,9L,37L,92L,154L,182L,154L,92L,37L,9L,1L,10L,46L,129L,246L,336L,336L,246L,129L,46L,10L,1L,11L,56L,175L,375L,582L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209561Inst : IEnumerable<long>
{
public static readonly long[] Value=A209561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209561.Bytes);
public long this[int i]=>Value[i];

public static A209561Inst Instance=new A209561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209562
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,4L,3L,1L,5L,7L,7L,4L,1L,6L,11L,14L,11L,5L,1L,7L,16L,25L,25L,16L,6L,1L,8L,22L,41L,50L,41L,22L,7L,1L,9L,29L,63L,91L,91L,63L,29L,8L,1L,10L,37L,92L,154L,182L,154L,92L,37L,9L,1L,11L,46L,129L,246L,336L,336L,246L,129L,46L,10L,1L,12L,56L,175L,375L,582L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209562Inst : IEnumerable<long>
{
public static readonly long[] Value=A209562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209562.Bytes);
public long this[int i]=>Value[i];

public static A209562Inst Instance=new A209562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209563
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,3L,6L,1L,1L,3L,8L,10L,1L,1L,3L,8L,19L,15L,1L,1L,3L,8L,21L,40L,21L,1L,1L,3L,8L,21L,53L,76L,28L,1L,1L,3L,8L,21L,55L,125L,133L,36L,1L,1L,3L,8L,21L,55L,142L,273L,218L,45L,1L,1L,3L,8L,21L,55L,144L,354L,554L,339L,55L,1L,1L,3L,8L,21L,55L,144L,375L,839L,1053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209563Inst : IEnumerable<long>
{
public static readonly long[] Value=A209563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209563.Bytes);
public long this[int i]=>Value[i];

public static A209563Inst Instance=new A209563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209564
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,5L,4L,1L,2L,5L,11L,5L,1L,2L,5L,13L,21L,6L,1L,2L,5L,13L,32L,36L,7L,1L,2L,5L,13L,34L,72L,57L,8L,1L,2L,5L,13L,34L,87L,148L,85L,9L,1L,2L,5L,13L,34L,89L,212L,281L,121L,10L,1L,2L,5L,13L,34L,89L,231L,485L,499L,166L,11L,1L,2L,5L,13L,34L,89L,233L,585L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209564Inst : IEnumerable<long>
{
public static readonly long[] Value=A209564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209564.Bytes);
public long this[int i]=>Value[i];

public static A209564Inst Instance=new A209564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209565
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,4L,11L,1L,1L,4L,14L,26L,1L,1L,4L,14L,45L,57L,1L,1L,4L,14L,48L,133L,120L,1L,1L,4L,14L,48L,161L,366L,247L,1L,1L,4L,14L,48L,164L,520L,952L,502L,1L,1L,4L,14L,48L,164L,557L,1604L,2371L,1013L,1L,1L,4L,14L,48L,164L,560L,1863L,4724L,5711L,2036L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209565Inst : IEnumerable<long>
{
public static readonly long[] Value=A209565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209565.Bytes);
public long this[int i]=>Value[i];

public static A209565Inst Instance=new A209565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209566
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,7L,1L,3L,10L,15L,1L,3L,10L,31L,31L,1L,3L,10L,34L,88L,63L,1L,3L,10L,34L,113L,233L,127L,1L,3L,10L,34L,116L,359L,586L,255L,1L,3L,10L,34L,116L,393L,1084L,1419L,511L,1L,3L,10L,34L,116L,396L,1306L,3120L,3340L,1023L,1L,3L,10L,34L,116L,396L,1349L,4216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209566Inst : IEnumerable<long>
{
public static readonly long[] Value=A209566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209566.Bytes);
public long this[int i]=>Value[i];

public static A209566Inst Instance=new A209566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209567
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,3L,7L,6L,1L,4L,13L,18L,10L,1L,5L,21L,41L,39L,15L,1L,6L,31L,79L,108L,75L,21L,1L,7L,43L,136L,245L,250L,132L,28L,1L,8L,57L,216L,486L,661L,524L,217L,36L,1L,9L,73L,323L,875L,1497L,1601L,1015L,338L,45L,1L,10L,91L,461L,1464L,3031L,4109L,3556L,1844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209567Inst : IEnumerable<long>
{
public static readonly long[] Value=A209567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209567.Bytes);
public long this[int i]=>Value[i];

public static A209567Inst Instance=new A209567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209568
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,10L,11L,4L,5L,17L,28L,21L,5L,6L,26L,58L,67L,36L,6L,7L,37L,105L,166L,142L,57L,7L,8L,50L,173L,350L,416L,274L,85L,8L,9L,65L,266L,659L,1011L,940L,491L,121L,9L,10L,82L,388L,1141L,2156L,2612L,1955L,829L,166L,10L,11L,101L,543L,1852L,4172L,6265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209568Inst : IEnumerable<long>
{
public static readonly long[] Value=A209568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209568.Bytes);
public long this[int i]=>Value[i];

public static A209568Inst Instance=new A209568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209569
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,3L,6L,5L,1L,4L,11L,14L,7L,1L,5L,18L,31L,26L,9L,1L,6L,27L,60L,71L,42L,11L,1L,7L,38L,105L,162L,139L,62L,13L,1L,8L,51L,170L,327L,372L,243L,86L,15L,1L,9L,66L,259L,602L,861L,754L,391L,114L,17L,1L,10L,83L,376L,1031L,1790L,1987L,1388L,591L,146L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209569Inst : IEnumerable<long>
{
public static readonly long[] Value=A209569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209569.Bytes);
public long this[int i]=>Value[i];

public static A209569Inst Instance=new A209569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209570
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,2L,4L,8L,8L,2L,5L,14L,20L,12L,2L,6L,22L,42L,40L,16L,2L,7L,32L,78L,102L,68L,20L,2L,8L,44L,132L,222L,210L,104L,24L,2L,9L,58L,208L,432L,534L,382L,148L,28L,2L,10L,74L,310L,772L,1188L,1126L,634L,200L,32L,2L,11L,92L,442L,1290L,2392L,2848L,2142L,982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209570Inst : IEnumerable<long>
{
public static readonly long[] Value=A209570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209570.Bytes);
public long this[int i]=>Value[i];

public static A209570Inst Instance=new A209570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209571
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,4L,9L,1L,1L,4L,15L,16L,1L,1L,4L,15L,44L,25L,1L,1L,4L,15L,56L,105L,36L,1L,1L,4L,15L,56L,185L,216L,49L,1L,1L,4L,15L,56L,209L,524L,399L,64L,1L,1L,4L,15L,56L,209L,732L,1295L,680L,81L,1L,1L,4L,15L,56L,209L,780L,2303L,2864L,1089L,100L,1L,1L,4L,15L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209571Inst : IEnumerable<long>
{
public static readonly long[] Value=A209571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209571.Bytes);
public long this[int i]=>Value[i];

public static A209571Inst Instance=new A209571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209572
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,5L,1L,3L,11L,7L,1L,3L,11L,29L,9L,1L,3L,11L,41L,61L,11L,1L,3L,11L,41L,129L,111L,13L,1L,3L,11L,41L,153L,339L,183L,15L,1L,3L,11L,41L,153L,523L,771L,281L,17L,1L,3L,11L,41L,153L,571L,1571L,1569L,409L,19L,1L,3L,11L,41L,153L,571L,2035L,4161L,2929L,571L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209572Inst : IEnumerable<long>
{
public static readonly long[] Value=A209572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209572.Bytes);
public long this[int i]=>Value[i];

public static A209572Inst Instance=new A209572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209573
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,1L,3L,9L,9L,1L,4L,17L,29L,16L,1L,5L,28L,69L,74L,25L,1L,6L,42L,138L,224L,160L,36L,1L,7L,59L,245L,541L,613L,307L,49L,1L,8L,79L,399L,1127L,1781L,1469L,539L,64L,1L,9L,102L,609L,2111L,4331L,5103L,3171L,884L,81L,1L,10L,128L,884L,3649L,9281L,14419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209573Inst : IEnumerable<long>
{
public static readonly long[] Value=A209573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209573.Bytes);
public long this[int i]=>Value[i];

public static A209573Inst Instance=new A209573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209574
{
public static readonly long[] Value={ 1L,2L,3L,3L,7L,5L,4L,14L,20L,7L,5L,24L,52L,45L,9L,6L,37L,110L,155L,86L,11L,7L,53L,203L,403L,389L,147L,13L,8L,72L,340L,882L,1240L,856L,232L,15L,9L,94L,530L,1712L,3204L,3322L,1702L,345L,17L,10L,119L,782L,3040L,7170L,10088L,7962L,3125L,490L,19L,11L,147L,1105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209574Inst : IEnumerable<long>
{
public static readonly long[] Value=A209574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209574.Bytes);
public long this[int i]=>Value[i];

public static A209574Inst Instance=new A209574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209575
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,5L,15L,1L,1L,5L,23L,37L,1L,1L,5L,23L,89L,83L,1L,1L,5L,23L,105L,295L,177L,1L,1L,5L,23L,105L,447L,873L,367L,1L,1L,5L,23L,105L,479L,1721L,2383L,749L,1L,1L,5L,23L,105L,479L,2121L,6015L,6137L,1515L,1L,1L,5L,23L,105L,479L,2185L,8847L,19369L,15143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209575Inst : IEnumerable<long>
{
public static readonly long[] Value=A209575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209575.Bytes);
public long this[int i]=>Value[i];

public static A209575Inst Instance=new A209575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209576
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,10L,1L,4L,18L,22L,1L,4L,18L,66L,46L,1L,4L,18L,82L,206L,94L,1L,4L,18L,82L,342L,578L,190L,1L,4L,18L,82L,374L,1274L,1510L,382L,1L,4L,18L,82L,374L,1642L,4294L,3754L,766L,1L,4L,18L,82L,374L,1706L,6726L,13354L,9006L,1534L,1L,4L,18L,82L,374L,1706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209576Inst : IEnumerable<long>
{
public static readonly long[] Value=A209576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209576.Bytes);
public long this[int i]=>Value[i];

public static A209576Inst Instance=new A209576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209577
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,5L,6L,3L,1L,9L,13L,10L,4L,1L,15L,28L,26L,15L,5L,1L,25L,56L,64L,45L,21L,6L,1L,41L,109L,146L,124L,71L,28L,7L,1L,67L,206L,319L,315L,216L,105L,36L,8L,1L,109L,382L,671L,758L,602L,349L,148L,45L,9L,1L,177L,697L,1372L,1744L,1576L,1056L,533L,201L,55L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209577Inst : IEnumerable<long>
{
public static readonly long[] Value=A209577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209577.Bytes);
public long this[int i]=>Value[i];

public static A209577Inst Instance=new A209577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209578
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,1L,9L,8L,4L,1L,15L,19L,13L,5L,1L,25L,41L,36L,19L,6L,1L,41L,84L,90L,60L,26L,7L,1L,67L,165L,210L,169L,92L,34L,8L,1L,109L,315L,465L,439L,287L,133L,43L,9L,1L,177L,588L,990L,1073L,818L,454L,184L,53L,10L,1L,287L,1079L,2043L,2502L,2178L,1405L,681L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209578Inst : IEnumerable<long>
{
public static readonly long[] Value=A209578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209578.Bytes);
public long this[int i]=>Value[i];

public static A209578Inst Instance=new A209578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209579
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,2L,6L,6L,1L,3L,9L,14L,10L,1L,3L,14L,28L,29L,15L,1L,4L,18L,48L,71L,55L,21L,1L,4L,25L,75L,139L,158L,97L,28L,1L,5L,30L,112L,251L,356L,321L,161L,36L,1L,5L,39L,156L,413L,724L,828L,609L,254L,45L,1L,6L,45L,215L,645L,1321L,1874L,1782L,1094L,384L,55L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209579Inst : IEnumerable<long>
{
public static readonly long[] Value=A209579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209579.Bytes);
public long this[int i]=>Value[i];

public static A209579Inst Instance=new A209579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209580
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,3L,7L,8L,4L,3L,11L,19L,15L,5L,4L,15L,34L,43L,26L,6L,4L,21L,57L,91L,87L,42L,7L,5L,26L,87L,176L,217L,163L,64L,8L,5L,34L,126L,301L,473L,472L,288L,93L,9L,6L,40L,176L,489L,908L,1150L,954L,485L,130L,10L,6L,50L,235L,745L,1626L,2460L,2587L,1817L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209580Inst : IEnumerable<long>
{
public static readonly long[] Value=A209580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209580.Bytes);
public long this[int i]=>Value[i];

public static A209580Inst Instance=new A209580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209581
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,1L,2L,8L,11L,1L,3L,12L,25L,26L,1L,3L,19L,51L,71L,57L,1L,4L,24L,88L,180L,190L,120L,1L,4L,34L,136L,348L,566L,486L,247L,1L,5L,40L,206L,628L,1238L,1648L,1199L,502L,1L,5L,53L,282L,1034L,2526L,4070L,4545L,2873L,1013L,1L,6L,60L,395L,1600L,4556L,9208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209581Inst : IEnumerable<long>
{
public static readonly long[] Value=A209581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209581.Bytes);
public long this[int i]=>Value[i];

public static A209581Inst Instance=new A209581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209582
{
public static readonly long[] Value={ 1L,2L,3L,2L,6L,7L,3L,10L,17L,15L,3L,16L,39L,46L,31L,4L,21L,69L,129L,119L,63L,4L,30L,112L,260L,386L,296L,127L,5L,36L,172L,492L,890L,1082L,713L,255L,5L,48L,242L,828L,1898L,2832L,2897L,1674L,511L,6L,55L,342L,1318L,3522L,6682L,8511L,7495L,3851L,1023L,6L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209582Inst : IEnumerable<long>
{
public static readonly long[] Value=A209582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209582.Bytes);
public long this[int i]=>Value[i];

public static A209582Inst Instance=new A209582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209583
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,5L,10L,6L,1L,9L,23L,24L,10L,1L,15L,51L,71L,49L,15L,1L,25L,104L,188L,178L,90L,21L,1L,41L,205L,452L,552L,390L,153L,28L,1L,67L,391L,1025L,1530L,1396L,776L,245L,36L,1L,109L,730L,2218L,3927L,4394L,3169L,1435L,374L,45L,1L,177L,1339L,4636L,9502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209583Inst : IEnumerable<long>
{
public static readonly long[] Value=A209583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209583.Bytes);
public long this[int i]=>Value[i];

public static A209583Inst Instance=new A209583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209584
{
public static readonly long[] Value={ 1L,3L,2L,5L,7L,3L,9L,18L,14L,4L,15L,42L,48L,25L,5L,25L,89L,137L,107L,41L,6L,41L,180L,348L,364L,212L,63L,7L,67L,350L,820L,1078L,844L,386L,92L,8L,109L,663L,1827L,2902L,2864L,1773L,659L,129L,9L,177L,1230L,3906L,7284L,8692L,6809L,3453L,1069L,175L,10L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209584Inst : IEnumerable<long>
{
public static readonly long[] Value=A209584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209584.Bytes);
public long this[int i]=>Value[i];

public static A209584Inst Instance=new A209584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209585
{
public static readonly BigInteger[] Value={ 2L,81L,28672L,791015625L,191221621088256L,BigInteger.Parse("7860041410116536427241"),BigInteger.Parse("2836619246897071128576000000000"),BigInteger.Parse("304913968803300753908857213381006097576481") };
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
public class A209585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209585Inst Instance=new A209585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209586
{
public static readonly BigInteger[] Value={ 2L,16L,192L,9216L,663552L,191102976L,82556485632L,142657607172096L,369768517790072832L,BigInteger.Parse("3833759992447475122176"),BigInteger.Parse("59622635402543133100081152"),BigInteger.Parse("3709004903121403223889848303616"),BigInteger.Parse("346094665520064377627609524907016192") };
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
public class A209586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209586Inst Instance=new A209586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209587
{
public static readonly BigInteger[] Value={ 3L,81L,3645L,1476225L,996451875L,6053445140625L,61291132048828125L,BigInteger.Parse("5585154407949462890625"),BigInteger.Parse("848245325707324676513671875"),BigInteger.Parse("1159445329576199417209625244140625") };
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
public class A209587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209587Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209587.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209587Inst Instance=new A209587Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209588
{
public static readonly BigInteger[] Value={ 4L,256L,28672L,51380224L,161128382464L,8084777718513664L,BigInteger.Parse("709908161907247808512"),BigInteger.Parse("997369854092025849117147136"),BigInteger.Parse("2452157460147152961259796760100864") };
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
public class A209588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209588Inst Instance=new A209588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209589
{
public static readonly BigInteger[] Value={ 5L,625L,140625L,791015625L,8009033203125L,2027286529541015625L,BigInteger.Parse("923682425022125244140625"),BigInteger.Parse("10521320122517645359039306640625"),BigInteger.Parse("215719941636994597502052783966064453125") };
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
public class A209589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209589Inst Instance=new A209589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209590
{
public static readonly BigInteger[] Value={ 6L,1296L,513216L,7316407296L,191221621088256L,BigInteger.Parse("179919658395455717376"),BigInteger.Parse("310357092660359621536382976"),BigInteger.Parse("19272907305680273946696375374708736"),BigInteger.Parse("2194189968466526991277450769351996054962176") };
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
public class A209590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209590Inst Instance=new A209590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209591
{
public static readonly BigInteger[] Value={ 7L,2401L,1529437L,47738317081L,2767247026234327L,BigInteger.Parse("7860041410116536427241"),BigInteger.Parse("41461694858240499304086993277"),BigInteger.Parse("10716805483614568896270487886484563281"),BigInteger.Parse("5144331626584186407654932265866559478676249287") };
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
public class A209591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209591Inst Instance=new A209591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209592
{
public static readonly BigInteger[] Value={ 8L,4096L,3932160L,241591910400L,27831388078080000L,BigInteger.Parse("205195258022068224000000"),BigInteger.Parse("2836619246897071128576000000000"),BigInteger.Parse("2509659166022727122011815936000000000000") };
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
public class A209592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209592Inst Instance=new A209592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209593
{
public static readonly long[] Value={ 2L,3L,16L,4L,81L,192L,5L,256L,3645L,9216L,6L,625L,28672L,1476225L,663552L,7L,1296L,140625L,51380224L,996451875L,191102976L,8L,2401L,513216L,791015625L,161128382464L,6053445140625L,82556485632L,9L,4096L,1529437L,7316407296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209593Inst : IEnumerable<long>
{
public static readonly long[] Value=A209593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209593.Bytes);
public long this[int i]=>Value[i];

public static A209593Inst Instance=new A209593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209594
{
public static readonly long[] Value={ 192L,3645L,28672L,140625L,513216L,1529437L,3932160L,9034497L,19000000L,37202781L,68677632L,120670225L,203297472L,330328125L,520093696L,796539777L,1190427840L,1740697597L,2496000000L,3516410961L,4875335872L,6661615005L,8981839872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209594Inst : IEnumerable<long>
{
public static readonly long[] Value=A209594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209594.Bytes);
public long this[int i]=>Value[i];

public static A209594Inst Instance=new A209594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209595
{
public static readonly long[] Value={ 9216L,1476225L,51380224L,791015625L,7316407296L,47738317081L,241591910400L,1007680691889L,3610000000000L,11438404249041L,32754285674496L,86161557405625L,210866643477504L,484962978515625L,1056630674292736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209595Inst : IEnumerable<long>
{
public static readonly long[] Value=A209595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209595.Bytes);
public long this[int i]=>Value[i];

public static A209595Inst Instance=new A209595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209596
{
public static readonly BigInteger[] Value={ 663552L,996451875L,161128382464L,8009033203125L,191221621088256L,2767247026234327L,27831388078080000L,212299175847866409L,1303210000000000000L,6714011580463844811L,BigInteger.Parse("29941085586484887552") };
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
public class A209596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209596Inst Instance=new A209596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209597
{
public static readonly BigInteger[] Value={ 191102976L,6053445140625L,8084777718513664L,2027286529541015625L,BigInteger.Parse("179919658395455717376"),BigInteger.Parse("7860041410116536427241"),BigInteger.Parse("205195258022068224000000"),BigInteger.Parse("3622919616011151776076849"),BigInteger.Parse("47045881000000000000000000") };
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
public class A209597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209597Inst Instance=new A209597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209598
{
public static readonly BigInteger[] Value={ 82556485632L,61291132048828125L,BigInteger.Parse("709908161907247808512"),BigInteger.Parse("923682425022125244140625"),BigInteger.Parse("310357092660359621536382976"),BigInteger.Parse("41461694858240499304086993277"),BigInteger.Parse("2836619246897071128576000000000") };
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
public class A209598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209598Inst Instance=new A209598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209599
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,5L,3L,0L,0L,8L,7L,1L,0L,0L,13L,15L,4L,0L,0L,0L,21L,30L,12L,1L,0L,0L,0L,34L,58L,31L,5L,0L,0L,0L,0L,55L,109L,73L,18L,1L,0L,0L,0L,0L,89L,201L,162L,54L,6L,0L,0L,0L,0L,0L,144L,365L,344L,145L,25L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209599Inst : IEnumerable<long>
{
public static readonly long[] Value=A209599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209599.Bytes);
public long this[int i]=>Value[i];

public static A209599Inst Instance=new A209599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209600
{
public static readonly long[] Value={ 1L,3L,2L,16L,17L,21L,24L,26L,29L,412L,788L,1045L,369625L,369636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209600Inst : IEnumerable<long>
{
public static readonly long[] Value=A209600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209600.Bytes);
public long this[int i]=>Value[i];

public static A209600Inst Instance=new A209600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209601
{
public static readonly long[] Value={ 1L,1L,14L,1L,2L,3L,1L,3L,2L,5L,194L,1L,14L,1L,2L,2L,2L,40L,1L,1L,1L,4L,4L,1L,5L,1L,4L,4L,1L,3L,18L,1L,1L,7L,28L,2L,5L,1L,4L,13L,3L,2L,2L,3L,9L,2L,3L,6L,1L,3L,3L,3L,3L,1L,1L,3L,8L,1L,184L,3L,2L,1L,1L,1L,3L,1L,1L,12L,1L,10L,2L,3L,2L,6L,18L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209601Inst : IEnumerable<long>
{
public static readonly long[] Value=A209601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209601.Bytes);
public long this[int i]=>Value[i];

public static A209601Inst Instance=new A209601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209602
{
public static readonly BigInteger[] Value={ 0L,2L,125L,11879L,3833954L,4623938410L,20901164219657L,362655247706368404L,BigInteger.Parse("23827622765333417390234") };
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
public class A209602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209602Inst Instance=new A209602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209603
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,4L,6L,9L,13L,19L,27L,39L,57L,84L,124L,183L,269L,394L,576L,842L,1232L,1805L,2647L,3883L,5695L,8349L,12235L,17926L,26264L,38485L,56401L,82666L,121166L,177592L,260282L,381457L,559033L,819275L,1200683L,1759683L,2578965L,3779704L,5539476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209603Inst : IEnumerable<long>
{
public static readonly long[] Value=A209603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209603.Bytes);
public long this[int i]=>Value[i];

public static A209603Inst Instance=new A209603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209604
{
public static readonly long[] Value={ 1L,2L,11L,45L,170L,538L,1674L,5410L,18001L,60486L,202486L,674159L,2238695L,7433743L,24704751L,82150290L,273210105L,908536081L,3020918528L,10044214676L,33396046046L,111040661940L,369210326847L,1227626858414L,4081857794878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209604Inst : IEnumerable<long>
{
public static readonly long[] Value=A209604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209604.Bytes);
public long this[int i]=>Value[i];

public static A209604Inst Instance=new A209604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209605
{
public static readonly long[] Value={ 1L,11L,125L,955L,6218L,39667L,260861L,1735169L,11583064L,77177265L,513065936L,3410493065L,22677826673L,150811145600L,1002946696389L,6669821781399L,44354925109263L,294963866816031L,1961539878519870L,13044456725291363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209605Inst : IEnumerable<long>
{
public static readonly long[] Value=A209605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209605.Bytes);
public long this[int i]=>Value[i];

public static A209605Inst Instance=new A209605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209606
{
public static readonly long[] Value={ 2L,45L,955L,11879L,151736L,1947347L,24912066L,322047969L,4162324219L,53725706448L,693454797025L,8950269164167L,115522311347383L,1491104128677150L,19246371866665817L,248421180186787884L,3206476873520078239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209606Inst : IEnumerable<long>
{
public static readonly long[] Value=A209606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209606.Bytes);
public long this[int i]=>Value[i];

public static A209606Inst Instance=new A209606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209607
{
public static readonly BigInteger[] Value={ 2L,170L,6218L,151736L,3833954L,95442732L,2375975754L,59592537600L,1495366951690L,37503163842366L,940455006943040L,23582406579072110L,591339672010632278L,14828301442081160268UL,BigInteger.Parse("371832301227736747532"),BigInteger.Parse("9324007193364231632484") };
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
public class A209607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209607Inst Instance=new A209607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209608
{
public static readonly BigInteger[] Value={ 4L,538L,39667L,1947347L,95442732L,4623938410L,223164388883L,10856162934984L,528920119608746L,25753779566714769L,1253886238749742186L,BigInteger.Parse("61044670504573175803"),BigInteger.Parse("2971820260865357745857"),BigInteger.Parse("144678418539833929320007") };
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
public class A209608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209608Inst Instance=new A209608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209609
{
public static readonly BigInteger[] Value={ 6L,1674L,260861L,24912066L,2375975754L,223164388883L,20901164219657L,1975174382937912L,186937030477768141L,17682588982309202487UL,BigInteger.Parse("1672438305942540396968"),BigInteger.Parse("158166123891896203653358") };
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
public class A209609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209609Inst Instance=new A209609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209610
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,11L,11L,2L,2L,45L,125L,45L,2L,4L,170L,955L,955L,170L,4L,6L,538L,6218L,11879L,6218L,538L,6L,9L,1674L,39667L,151736L,151736L,39667L,1674L,9L,13L,5410L,260861L,1947347L,3833954L,1947347L,260861L,5410L,13L,19L,18001L,1735169L,24912066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209610Inst : IEnumerable<long>
{
public static readonly long[] Value=A209610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209610.Bytes);
public long this[int i]=>Value[i];

public static A209610Inst Instance=new A209610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209611
{
public static readonly long[] Value={ 2L,113L,199L,211L,293L,317L,523L,773L,839L,863L,887L,953L,1069L,1129L,1259L,1327L,1381L,1637L,1669L,1759L,1831L,1913L,1933L,1951L,2113L,2161L,2179L,2221L,2251L,2311L,2477L,2503L,2557L,2593L,2803L,2861L,2971L,3089L,3121L,3137L,3229L,3271L,3373L,3391L,3413L,3433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209611Inst : IEnumerable<long>
{
public static readonly long[] Value=A209611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209611.Bytes);
public long this[int i]=>Value[i];

public static A209611Inst Instance=new A209611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209612
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,4L,2L,1L,1L,3L,8L,8L,3L,1L,1L,3L,12L,17L,12L,3L,1L,1L,4L,19L,41L,41L,19L,4L,1L,1L,4L,27L,78L,116L,78L,27L,4L,1L,1L,5L,38L,148L,298L,298L,148L,38L,5L,1L,1L,5L,50L,250L,680L,932L,680L,250L,50L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209612Inst : IEnumerable<long>
{
public static readonly long[] Value=A209612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209612.Bytes);
public long this[int i]=>Value[i];

public static A209612Inst Instance=new A209612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209613
{
public static readonly long[] Value={ 1L,-1L,-3L,1L,4L,3L,-6L,-1L,9L,-4L,-12L,-3L,14L,6L,-12L,1L,16L,-9L,-18L,4L,18L,12L,-24L,3L,21L,-14L,-27L,-6L,28L,12L,-30L,-1L,36L,-16L,-24L,9L,38L,18L,-42L,-4L,40L,-18L,-42L,-12L,36L,24L,-48L,-3L,43L,-21L,-48L,14L,52L,27L,-48L,6L,54L,-28L,-60L,-12L,62L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209613Inst : IEnumerable<long>
{
public static readonly long[] Value=A209613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209613.Bytes);
public long this[int i]=>Value[i];

public static A209613Inst Instance=new A209613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209614
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,21L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,196418L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10610209857723L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209614Inst : IEnumerable<long>
{
public static readonly long[] Value=A209614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209614.Bytes);
public long this[int i]=>Value[i];

public static A209614Inst Instance=new A209614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209615
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209615Inst : IEnumerable<long>
{
public static readonly long[] Value=A209615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209615.Bytes);
public long this[int i]=>Value[i];

public static A209615Inst Instance=new A209615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209616
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,12L,18L,29L,42L,63L,89L,128L,176L,246L,333L,453L,603L,807L,1058L,1393L,1807L,2346L,3011L,3867L,4915L,6248L,7879L,9926L,12421L,15529L,19297L,23954L,29585L,36486L,44802L,54937L,67096L,81831L,99459L,120700L,146026L,176410L,212512L,255636L,306734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209616Inst : IEnumerable<long>
{
public static readonly long[] Value=A209616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209616.Bytes);
public long this[int i]=>Value[i];

public static A209616Inst Instance=new A209616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209617
{
public static readonly long[] Value={ 23L,37L,47L,53L,67L,79L,83L,89L,97L,113L,127L,131L,157L,163L,167L,173L,211L,223L,233L,257L,263L,277L,307L,317L,331L,353L,359L,367L,373L,379L,383L,389L,397L,401L,439L,443L,449L,457L,467L,479L,487L,491L,499L,503L,509L,541L,563L,593L,607L,613L,647L,653L,673L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209617Inst : IEnumerable<long>
{
public static readonly long[] Value=A209617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209617.Bytes);
public long this[int i]=>Value[i];

public static A209617Inst Instance=new A209617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209618
{
public static readonly long[] Value={ 139L,181L,241L,283L,337L,409L,421L,547L,577L,631L,691L,709L,787L,811L,829L,919L,1021L,1039L,1051L,1129L,1153L,1171L,1249L,1327L,1399L,1471L,1627L,1699L,1723L,1801L,1831L,1879L,1933L,1951L,2017L,2029L,2053L,2089L,2113L,2143L,2221L,2251L,2311L,2477L,2521L,2557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209618Inst : IEnumerable<long>
{
public static readonly long[] Value=A209618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209618.Bytes);
public long this[int i]=>Value[i];

public static A209618Inst Instance=new A209618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209619
{
public static readonly long[] Value={ 149L,191L,251L,293L,347L,419L,431L,557L,587L,641L,701L,719L,797L,821L,839L,929L,1031L,1049L,1061L,1151L,1163L,1181L,1259L,1361L,1409L,1481L,1637L,1709L,1733L,1811L,1847L,1889L,1949L,1973L,2027L,2039L,2063L,2099L,2129L,2153L,2237L,2267L,2333L,2503L,2531L,2579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209619Inst : IEnumerable<long>
{
public static readonly long[] Value=A209619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209619.Bytes);
public long this[int i]=>Value[i];

public static A209619Inst Instance=new A209619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209620
{
public static readonly long[] Value={ 1021L,1151L,1181L,1201L,1511L,1811L,10151L,11551L,15101L,15511L,100511L,101281L,102181L,102551L,105211L,105251L,108881L,110051L,110221L,110281L,110881L,111211L,111821L,112111L,112181L,112501L,115001L,115021L,118081L,120121L,120511L,121021L,121151L,122011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209620Inst : IEnumerable<long>
{
public static readonly long[] Value=A209620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209620.Bytes);
public long this[int i]=>Value[i];

public static A209620Inst Instance=new A209620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209621
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3451L,9156L,28155L,76491L,240015L,664363L,2118804L,5954414L,19246816L,54772539L,179063855L,515006165L,1700131496L,4934242781L,16427135058L,48050970367L,161163698861L,474656662565L,1602509174036L,4748224219223L,16125057102402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209621Inst : IEnumerable<long>
{
public static readonly long[] Value=A209621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209621.Bytes);
public long this[int i]=>Value[i];

public static A209621Inst Instance=new A209621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209622
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9157L,28176L,76514L,240318L,664718L,2122557L,5959052L,19289899L,54828151L,179538447L,515641437L,1705240090L,4941294887L,16481424379L,48127922888L,161736798007L,475487875843L,1608541737898L,4757151493126L,16188528696215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209622Inst : IEnumerable<long>
{
public static readonly long[] Value=A209622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209622.Bytes);
public long this[int i]=>Value[i];

public static A209622Inst Instance=new A209622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209623
{
public static readonly long[] Value={ 7L,13L,19L,23L,31L,37L,43L,47L,53L,61L,67L,73L,79L,83L,89L,97L,103L,109L,113L,127L,131L,151L,157L,163L,167L,173L,193L,199L,211L,223L,229L,233L,251L,257L,263L,271L,277L,293L,307L,313L,317L,331L,349L,353L,359L,367L,373L,379L,383L,389L,397L,401L,433L,439L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209623Inst : IEnumerable<long>
{
public static readonly long[] Value=A209623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209623.Bytes);
public long this[int i]=>Value[i];

public static A209623Inst Instance=new A209623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209624
{
public static readonly long[] Value={ 11L,17L,23L,29L,37L,41L,47L,53L,59L,67L,71L,79L,83L,89L,97L,101L,107L,113L,127L,131L,137L,157L,163L,167L,173L,179L,197L,211L,223L,227L,233L,239L,257L,263L,269L,277L,281L,307L,311L,317L,331L,337L,353L,359L,367L,373L,379L,383L,389L,397L,401L,409L,439L,443L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209624Inst : IEnumerable<long>
{
public static readonly long[] Value=A209624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209624.Bytes);
public long this[int i]=>Value[i];

public static A209624Inst Instance=new A209624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209625
{
public static readonly long[] Value={ 1L,2L,6L,24L,114L,600L,3372L,19824L,120422L,749848L,4760228L,30688560L,200338740L,1321408656L,8791205496L,58912586784L,397228820742L,2692522813848L,18333530047428L,125325068538672L,859639878194844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209625Inst : IEnumerable<long>
{
public static readonly long[] Value=A209625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209625.Bytes);
public long this[int i]=>Value[i];

public static A209625Inst Instance=new A209625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209626
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9158L,28177L,76537L,240343L,665073L,2122968L,5963685L,19295541L,54883588L,179608831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209626Inst : IEnumerable<long>
{
public static readonly long[] Value=A209626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209626.Bytes);
public long this[int i]=>Value[i];

public static A209626Inst Instance=new A209626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209627
{
public static readonly BigInteger[] Value={ 1L,2L,12L,124L,1820L,34476L,796600L,21647088L,674894736L,23727325600L,929120132336L,40145865303072L,1899037891380448L,97624128373666272L,5416162739385169920L,BigInteger.Parse("322369745413410839296"),BigInteger.Parse("20496143199154076929280") };
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
public class A209627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209627Inst Instance=new A209627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209628
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,5L,5L,5L,5L,5L,5L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,10L,11L,12L,12L,12L,13L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,19L,20L,20L,20L,20L,21L,21L,21L,22L,23L,23L,23L,24L,25L,25L,25L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209628Inst : IEnumerable<long>
{
public static readonly long[] Value=A209628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209628.Bytes);
public long this[int i]=>Value[i];

public static A209628Inst Instance=new A209628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209629
{
public static readonly long[] Value={ 2L,6L,16L,44L,134L,468L,1880L,8534L,42804L,232972L,1359186L,8431288L,55297064L,381815026L,2765949856L,20960349828L,165729870678L,1364153874460L,11665484934400L,103448317519318L,949739634410652L,9013431481088948L,88304011718557298L,891917738606387792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209629Inst : IEnumerable<long>
{
public static readonly long[] Value=A209629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209629.Bytes);
public long this[int i]=>Value[i];

public static A209629Inst Instance=new A209629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209630
{
public static readonly long[] Value={ 1L,2L,7L,11L,13L,31L,47L,59L,61L,127L,191L,223L,239L,251L,895L,991L,1007L,1019L,1021L,2047L,3071L,3583L,3967L,4031L,4079L,4091L,4093L,8191L,15359L,16127L,16255L,16319L,16351L,16375L,16381L,49151L,63487L,65279L,65407L,65519L,65531L,131071L,196607L,229375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209630Inst : IEnumerable<long>
{
public static readonly long[] Value=A209630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209630.Bytes);
public long this[int i]=>Value[i];

public static A209630Inst Instance=new A209630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209631
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,10L,4L,1L,1L,5L,20L,41L,5L,1L,1L,6L,33L,127L,196L,6L,1L,1L,7L,49L,280L,967L,1057L,7L,1L,1L,8L,68L,518L,2883L,8549L,6322L,8L,1L,1L,9L,90L,859L,6689L,34817L,85829L,41393L,9L,1L,1L,10L,115L,1321L,13310L,101841L,481477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209631Inst : IEnumerable<long>
{
public static readonly long[] Value=A209631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209631.Bytes);
public long this[int i]=>Value[i];

public static A209631Inst Instance=new A209631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209632
{
public static readonly BigInteger[] Value={ 2L,39L,625L,10008L,160130L,2562088L,40993409L,655894552L,10494312834L,167909005352L,2686544085636L,42984705370181L,687755285922905L,11004084574766480L,176065353196263684L,2817045651140218949L,BigInteger.Parse("45072730418243503186"),BigInteger.Parse("721163686691896050979") };
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
public class A209632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209632Inst Instance=new A209632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209633
{
public static readonly long[] Value={ 1L,2L,7L,15L,33L,59L,111L,182L,307L,481L,757L,1134L,1713L,2483L,3611L,5117L,7238L,10029L,13888L,18900L,25682L,34442L,46057L,60934L,80428L,105159L,137137L,177495L,229069L,293694L,375582L,477499L,605526L,764060L,961603L,1204898L,1506142L,1875150L,2329185L,2882939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209633Inst : IEnumerable<long>
{
public static readonly long[] Value=A209633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209633.Bytes);
public long this[int i]=>Value[i];

public static A209633Inst Instance=new A209633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209634
{
public static readonly long[] Value={ 1L,4L,7L,1L,10L,4L,13L,7L,1L,16L,10L,4L,19L,13L,7L,1L,22L,16L,10L,4L,25L,19L,13L,7L,1L,28L,22L,16L,10L,4L,31L,25L,19L,13L,7L,1L,34L,28L,22L,16L,10L,4L,37L,31L,25L,19L,13L,7L,1L,40L,34L,28L,22L,16L,10L,4L,43L,37L,31L,25L,19L,13L,7L,1L,46L,40L,34L,28L,22L,16L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209634Inst : IEnumerable<long>
{
public static readonly long[] Value=A209634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209634.Bytes);
public long this[int i]=>Value[i];

public static A209634Inst Instance=new A209634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209635
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,-1L,-1L,1L,0L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,0L,-1L,-1L,1L,-1L,-1L,-1L,0L,-1L,0L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,0L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,0L,-1L,-1L,-1L,0L,0L,1L,-1L,-1L,0L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,0L,1L,1L,1L,-1L,-1L,1L,1L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209635Inst : IEnumerable<long>
{
public static readonly long[] Value=A209635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209635.Bytes);
public long this[int i]=>Value[i];

public static A209635Inst Instance=new A209635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209636
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,7L,5L,16L,12L,14L,10L,19L,13L,17L,11L,32L,24L,28L,20L,38L,26L,34L,22L,53L,37L,43L,29L,67L,41L,59L,31L,64L,48L,56L,40L,76L,52L,68L,44L,106L,74L,86L,58L,134L,82L,118L,62L,131L,89L,107L,71L,163L,101L,139L,79L,241L,157L,191L,109L,331L,179L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209636Inst : IEnumerable<long>
{
public static readonly long[] Value=A209636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209636.Bytes);
public long this[int i]=>Value[i];

public static A209636Inst Instance=new A209636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209637
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,11L,17L,13L,19L,10L,14L,12L,16L,31L,59L,41L,67L,29L,43L,37L,53L,22L,34L,26L,38L,20L,28L,24L,32L,127L,277L,179L,331L,109L,191L,157L,241L,79L,139L,101L,163L,71L,107L,89L,131L,62L,118L,82L,134L,58L,86L,74L,106L,44L,68L,52L,76L,40L,56L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209637Inst : IEnumerable<long>
{
public static readonly long[] Value=A209637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209637.Bytes);
public long this[int i]=>Value[i];

public static A209637Inst Instance=new A209637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209638
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,19L,20L,22L,24L,26L,28L,29L,31L,32L,34L,37L,38L,40L,41L,43L,44L,48L,52L,53L,56L,58L,59L,62L,64L,67L,68L,71L,74L,76L,79L,80L,82L,86L,88L,89L,96L,101L,104L,106L,107L,109L,112L,116L,118L,124L,127L,128L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209638Inst : IEnumerable<long>
{
public static readonly long[] Value=A209638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209638.Bytes);
public long this[int i]=>Value[i];

public static A209638Inst Instance=new A209638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209639
{
public static readonly long[] Value={ 1L,3L,2L,7L,2L,5L,6L,15L,2L,5L,4L,11L,6L,13L,14L,31L,2L,5L,4L,11L,4L,9L,10L,23L,6L,13L,12L,27L,14L,29L,30L,63L,2L,5L,4L,11L,4L,9L,10L,23L,4L,9L,8L,19L,10L,21L,22L,47L,6L,13L,12L,27L,12L,25L,26L,55L,14L,29L,28L,59L,30L,61L,62L,127L,2L,5L,4L,11L,4L,9L,10L,23L,4L,9L,8L,19L,10L,21L,22L,47L,4L,9L,8L,19L,8L,17L,18L,39L,10L,21L,20L,43L,22L,45L,46L,95L,6L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209639Inst : IEnumerable<long>
{
public static readonly long[] Value=A209639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209639.Bytes);
public long this[int i]=>Value[i];

public static A209639Inst Instance=new A209639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209640
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,5L,0L,6L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209640Inst : IEnumerable<long>
{
public static readonly long[] Value=A209640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209640.Bytes);
public long this[int i]=>Value[i];

public static A209640Inst Instance=new A209640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209641
{
public static readonly long[] Value={ 0L,2L,10L,12L,42L,50L,52L,56L,170L,202L,210L,212L,226L,228L,232L,240L,682L,810L,842L,850L,852L,906L,914L,916L,930L,932L,936L,962L,964L,968L,976L,992L,2730L,3242L,3370L,3402L,3410L,3412L,3626L,3658L,3666L,3668L,3722L,3730L,3732L,3746L,3748L,3752L,3850L,3858L,3860L,3874L,3876L,3880L,3906L,3908L,3912L,3920L,3970L,3972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209641Inst : IEnumerable<long>
{
public static readonly long[] Value=A209641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209641.Bytes);
public long this[int i]=>Value[i];

public static A209641Inst Instance=new A209641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209642
{
public static readonly long[] Value={ 0L,2L,10L,12L,42L,50L,52L,56L,170L,202L,210L,226L,212L,228L,232L,240L,682L,810L,842L,906L,850L,914L,930L,962L,852L,916L,932L,964L,936L,968L,976L,992L,2730L,3242L,3370L,3626L,3402L,3658L,3722L,3850L,3410L,3666L,3730L,3858L,3746L,3874L,3906L,3970L,3412L,3668L,3732L,3860L,3748L,3876L,3908L,3972L,3752L,3880L,3912L,3976L,3920L,3984L,4000L,4032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209642Inst : IEnumerable<long>
{
public static readonly long[] Value=A209642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209642.Bytes);
public long this[int i]=>Value[i];

public static A209642Inst Instance=new A209642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209643
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,14L,16L,17L,19L,20L,21L,22L,23L,37L,42L,44L,45L,51L,53L,54L,56L,57L,58L,60L,61L,62L,63L,64L,65L,107L,121L,126L,128L,129L,149L,154L,156L,157L,163L,165L,166L,168L,169L,170L,177L,179L,180L,182L,183L,184L,186L,187L,188L,189L,191L,192L,193L,194L,195L,196L,197L,329L,371L,385L,390L,392L,393L,461L,475L,480L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209643Inst : IEnumerable<long>
{
public static readonly long[] Value=A209643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209643.Bytes);
public long this[int i]=>Value[i];

public static A209643Inst Instance=new A209643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209644
{
public static readonly long[] Value={ 0L,1L,20L,11L,300L,210L,120L,111L,4000L,3100L,2200L,1300L,2110L,1210L,1120L,1111L,50000L,41000L,32000L,23000L,14000L,31100L,22100L,13100L,21200L,12200L,11300L,21110L,12110L,11210L,11120L,11111L,600000L,510000L,420000L,330000L,240000L,150000L,411000L,321000L,231000L,141000L,312000L,222000L,132000L,213000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209644Inst : IEnumerable<long>
{
public static readonly long[] Value=A209644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209644.Bytes);
public long this[int i]=>Value[i];

public static A209644Inst Instance=new A209644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209645
{
public static readonly long[] Value={ 2L,16L,102L,630L,4690L,34012L,287140L,2364992L,22028490L,200930125L,2026692954L,20118254688L,217071252489L,2316174126448L,26506083938686L,301219138880440L,3632894429145798L,43657425153387876L,552138493209771090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209645Inst : IEnumerable<long>
{
public static readonly long[] Value=A209645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209645.Bytes);
public long this[int i]=>Value[i];

public static A209645Inst Instance=new A209645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209646
{
public static readonly long[] Value={ 9L,81L,270L,630L,1215L,2079L,3276L,4860L,6885L,9405L,12474L,16146L,20475L,25515L,31320L,37944L,45441L,53865L,63270L,73710L,85239L,97911L,111780L,126900L,143325L,161109L,180306L,200970L,223155L,246915L,272304L,299376L,328185L,358785L,391230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209646Inst : IEnumerable<long>
{
public static readonly long[] Value=A209646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209646.Bytes);
public long this[int i]=>Value[i];

public static A209646Inst Instance=new A209646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209647
{
public static readonly long[] Value={ 14L,196L,798L,2156L,4690L,8904L,15386L,24808L,37926L,55580L,78694L,108276L,145418L,191296L,247170L,314384L,394366L,488628L,598766L,726460L,873474L,1041656L,1232938L,1449336L,1692950L,1965964L,2270646L,2609348L,2984506L,3398640L,3854354L,4354336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209647Inst : IEnumerable<long>
{
public static readonly long[] Value=A209647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209647.Bytes);
public long this[int i]=>Value[i];

public static A209647Inst Instance=new A209647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209648
{
public static readonly long[] Value={ 22L,484L,2354L,7128L,16830L,34012L,61754L,103664L,163878L,247060L,358402L,503624L,688974L,921228L,1207690L,1556192L,1975094L,2473284L,3060178L,3745720L,4540382L,5455164L,6501594L,7691728L,9038150L,10553972L,12252834L,14148904L,16256878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209648Inst : IEnumerable<long>
{
public static readonly long[] Value=A209648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209648.Bytes);
public long this[int i]=>Value[i];

public static A209648Inst Instance=new A209648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209649
{
public static readonly long[] Value={ 35L,1225L,7210L,24990L,65765L,145775L,287140L,518700L,876855L,1406405L,2161390L,3205930L,4615065L,6475595L,8886920L,11961880L,15827595L,20626305L,26516210L,33672310L,42287245L,52572135L,64757420L,79093700L,95852575L,115327485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209649Inst : IEnumerable<long>
{
public static readonly long[] Value=A209649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209649.Bytes);
public long this[int i]=>Value[i];

public static A209649Inst Instance=new A209649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209650
{
public static readonly long[] Value={ 2L,4L,4L,6L,16L,6L,9L,36L,36L,8L,14L,81L,102L,64L,10L,22L,196L,270L,216L,100L,12L,35L,484L,798L,630L,390L,144L,14L,56L,1225L,2354L,2156L,1215L,636L,196L,16L,90L,3136L,7210L,7128L,4690L,2079L,966L,256L,18L,145L,8100L,22232L,24990L,16830L,8904L,3276L,1392L,324L,20L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209650Inst : IEnumerable<long>
{
public static readonly long[] Value=A209650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209650.Bytes);
public long this[int i]=>Value[i];

public static A209650Inst Instance=new A209650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209651
{
public static readonly long[] Value={ 8L,64L,216L,630L,2156L,7128L,24990L,87136L,311040L,1112150L,4018716L,14563584L,53065350L,193861408L,710502760L,2609417910L,9603620076L,35401092264L,130688898510L,483039609408L,1787282764624L,6619084515926L,24532925650268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209651Inst : IEnumerable<long>
{
public static readonly long[] Value=A209651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209651.Bytes);
public long this[int i]=>Value[i];

public static A209651Inst Instance=new A209651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209652
{
public static readonly long[] Value={ 10L,100L,390L,1215L,4690L,16830L,65765L,251160L,994050L,3911375L,15639390L,62524602L,251961125L,1016913820L,4122470862L,16742504735L,68184829338L,278147046150L,1136817652005L,4652769761136L,19069624615146L,78246585726191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209652Inst : IEnumerable<long>
{
public static readonly long[] Value=A209652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209652.Bytes);
public long this[int i]=>Value[i];

public static A209652Inst Instance=new A209652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209653
{
public static readonly long[] Value={ 12L,144L,636L,2079L,8904L,34012L,145775L,597856L,2579940L,10954895L,47622744L,205998660L,901433351L,3942155568L,17346881260L,76402898495L,337745931240L,1495044223756L,6633766629567L,29474645542848L,131183330978644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209653Inst : IEnumerable<long>
{
public static readonly long[] Value=A209653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209653.Bytes);
public long this[int i]=>Value[i];

public static A209653Inst Instance=new A209653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209654
{
public static readonly long[] Value={ 14L,196L,966L,3276L,15386L,61754L,287140L,1247736L,5805450L,26247900L,122620446L,566352486L,2658874036L,12435237724L,58661967966L,276563762860L,1310299936722L,6211941942146L,29540255436804L,140624053199280L,670822454889090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209654Inst : IEnumerable<long>
{
public static readonly long[] Value=A209654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209654.Bytes);
public long this[int i]=>Value[i];

public static A209654Inst Instance=new A209654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209655
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,5L,4L,1L,2L,2L,1L,1L,2L,1L,1L,7L,6L,1L,4L,2L,1L,2L,3L,1L,1L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209655Inst : IEnumerable<long>
{
public static readonly long[] Value=A209655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209655.Bytes);
public long this[int i]=>Value[i];

public static A209655Inst Instance=new A209655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209656
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9158L,28178L,76538L,240368L,665100L,2123379L,5964156L,19301178L,54890366L,179679030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209656Inst : IEnumerable<long>
{
public static readonly long[] Value=A209656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209656.Bytes);
public long this[int i]=>Value[i];

public static A209656Inst Instance=new A209656Inst();

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