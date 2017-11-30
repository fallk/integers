using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A073625
{
public static readonly long[] Value={ 11L,61L,13L,809L,3L,31L,97L,83L,89L,7L,41L,907L,811L,911L,43L,821L,47L,823L,2003L,401L,5L,827L,67L,829L,37L,409L,307L,601L,53L,607L,311L,839L,17L,19L,71L,73L,2011L,3001L,919L,101L,79L,929L,8009L,59L,701L,613L,2L,853L,617L,23L,103L,313L,503L,419L,421L,857L,619L,29L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073625Inst : IEnumerable<long>
{
public static readonly long[] Value=A073625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073625.Bytes);
public long this[int i]=>Value[i];

public static A073625Inst Instance=new A073625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073626
{
public static readonly long[] Value={ 11L,41L,13L,43L,2L,17L,3L,5L,61L,23L,31L,7L,307L,97L,503L,47L,83L,809L,19L,67L,89L,811L,71L,29L,401L,2003L,907L,601L,911L,8009L,73L,821L,53L,607L,919L,613L,79L,101L,823L,701L,59L,37L,709L,617L,929L,409L,8011L,719L,311L,103L,727L,619L,631L,733L,937L,739L,313L,743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073626Inst : IEnumerable<long>
{
public static readonly long[] Value=A073626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073626.Bytes);
public long this[int i]=>Value[i];

public static A073626Inst Instance=new A073626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073627
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,10L,13L,16L,21L,22L,25L,28L,31L,36L,37L,42L,47L,50L,51L,52L,55L,58L,69L,70L,79L,84L,89L,90L,91L,100L,111L,112L,115L,118L,121L,130L,133L,136L,141L,142L,151L,156L,157L,160L,171L,176L,177L,182L,185L,188L,191L,192L,197L,200L,201L,208L,211L,220L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073627Inst : IEnumerable<long>
{
public static readonly long[] Value=A073627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073627.Bytes);
public long this[int i]=>Value[i];

public static A073627Inst Instance=new A073627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073628
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,10L,11L,16L,20L,23L,24L,26L,29L,34L,38L,41L,48L,50L,51L,56L,60L,63L,68L,80L,81L,90L,92L,95L,96L,102L,109L,120L,124L,129L,130L,138L,141L,142L,148L,149L,152L,156L,159L,164L,168L,171L,182L,188L,193L,196L,198L,199L,202L,206L,209L,216L,218L,219L,222L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073628Inst : IEnumerable<long>
{
public static readonly long[] Value=A073628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073628.Bytes);
public long this[int i]=>Value[i];

public static A073628Inst Instance=new A073628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073629
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,9L,13L,17L,20L,21L,25L,31L,32L,39L,47L,49L,56L,59L,63L,73L,74L,83L,87L,93L,96L,97L,103L,105L,114L,117L,121L,127L,134L,139L,141L,143L,146L,147L,151L,155L,160L,165L,167L,169L,172L,175L,185L,187L,192L,193L,197L,205L,214L,223L,235L,239L,240L,253L,259L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073629Inst : IEnumerable<long>
{
public static readonly long[] Value=A073629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073629.Bytes);
public long this[int i]=>Value[i];

public static A073629Inst Instance=new A073629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073630
{
public static readonly long[] Value={ 1L,2L,8L,1849L,22912L,40328L,646912L,3607298L,6323422L,7520900L,8962893L,23879700L,38043325L,157944268L,1105942626L,3604734726L,5239828426L,8179002096L,8179002106L,37234260225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073630Inst : IEnumerable<long>
{
public static readonly long[] Value=A073630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073630.Bytes);
public long this[int i]=>Value[i];

public static A073630Inst Instance=new A073630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073631
{
public static readonly long[] Value={ 1L,65L,133L,529L,793L,1105L,1649L,1729L,2059L,2321L,2465L,2701L,2821L,4187L,5185L,6305L,6541L,6601L,6697L,6817L,7471L,7613L,8113L,8911L,10585L,10963L,11521L,13213L,13333L,13427L,14701L,14981L,15841L,18721L,19171L,19201L,19909L,21349L,21667L,22177L,26065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073631Inst : IEnumerable<long>
{
public static readonly long[] Value=A073631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073631.Bytes);
public long this[int i]=>Value[i];

public static A073631Inst Instance=new A073631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073632
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,10L,12L,14L,15L,17L,18L,20L,21L,22L,25L,27L,30L,32L,33L,34L,35L,38L,42L,45L,46L,48L,52L,53L,55L,57L,58L,59L,61L,62L,63L,64L,65L,69L,71L,74L,76L,82L,83L,85L,89L,90L,93L,96L,97L,98L,100L,104L,106L,107L,109L,110L,112L,113L,114L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073632Inst : IEnumerable<long>
{
public static readonly long[] Value=A073632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073632.Bytes);
public long this[int i]=>Value[i];

public static A073632Inst Instance=new A073632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073633
{
public static readonly long[] Value={ 1L,2L,3L,16L,43L,50L,56L,193L,283L,961L,970L,4958L,9439L,10493L,11375L,18552L,57051L,81602L,617287L,917186L,1525995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073633Inst : IEnumerable<long>
{
public static readonly long[] Value=A073633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073633.Bytes);
public long this[int i]=>Value[i];

public static A073633Inst Instance=new A073633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073634
{
public static readonly long[] Value={ 0L,2L,9L,11L,13L,16L,19L,23L,24L,26L,28L,29L,31L,36L,37L,39L,40L,41L,43L,44L,47L,49L,50L,51L,54L,56L,60L,66L,67L,68L,70L,72L,73L,75L,77L,78L,79L,80L,81L,84L,86L,87L,88L,91L,92L,94L,95L,99L,101L,102L,103L,105L,108L,111L,115L,121L,123L,126L,127L,132L,134L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073634Inst : IEnumerable<long>
{
public static readonly long[] Value=A073634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073634.Bytes);
public long this[int i]=>Value[i];

public static A073634Inst Instance=new A073634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073635
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,9L,10L,9L,8L,9L,8L,9L,8L,7L,8L,7L,8L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073635Inst : IEnumerable<long>
{
public static readonly long[] Value=A073635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073635.Bytes);
public long this[int i]=>Value[i];

public static A073635Inst Instance=new A073635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073684
{
public static readonly long[] Value={ 2L,3L,5L,3L,5L,3L,3L,7L,9L,5L,9L,7L,3L,7L,5L,3L,3L,3L,5L,3L,3L,3L,5L,5L,57L,25L,49L,3L,9L,5L,11L,3L,5L,5L,5L,5L,17L,25L,3L,3L,5L,3L,7L,9L,5L,3L,3L,3L,15L,3L,3L,3L,3L,3L,3L,3L,15L,3L,5L,33L,5L,3L,3L,9L,7L,3L,33L,3L,3L,5L,3L,15L,3L,5L,9L,7L,13L,5L,11L,3L,3L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073684Inst : IEnumerable<long>
{
public static readonly long[] Value=A073684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073684.Bytes);
public long this[int i]=>Value[i];

public static A073684Inst Instance=new A073684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073685
{
public static readonly long[] Value={ 5L,3L,5L,25L,2L,5L,2L,2L,5L,8L,6L,4L,2L,3L,5L,2L,2L,18L,2L,35L,8L,21L,2L,2L,2L,6L,17L,3L,6L,9L,2L,8L,11L,7L,5L,15L,27L,3L,4L,2L,18L,3L,7L,2L,2L,22L,4L,12L,27L,31L,2L,16L,16L,5L,2L,16L,2L,21L,7L,12L,2L,2L,4L,22L,8L,10L,2L,7L,2L,2L,8L,7L,8L,2L,4L,22L,2L,30L,8L,21L,2L,3L,28L,24L,4L,10L,7L,4L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073685Inst : IEnumerable<long>
{
public static readonly long[] Value=A073685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073685.Bytes);
public long this[int i]=>Value[i];

public static A073685Inst Instance=new A073685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073686
{
public static readonly long[] Value={ 37L,41L,97L,983L,113L,307L,131L,137L,367L,653L,541L,383L,199L,311L,547L,229L,233L,2293L,281L,5689L,1511L,4349L,439L,443L,449L,1381L,4159L,769L,1571L,2441L,557L,2281L,3253L,2137L,1567L,4877L,9439L,1103L,1487L,751L,6977L,1201L,2843L,823L,827L,9413L,1777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073686Inst : IEnumerable<long>
{
public static readonly long[] Value=A073686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073686.Bytes);
public long this[int i]=>Value[i];

public static A073686Inst Instance=new A073686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073687
{
public static readonly long[] Value={ 4L,12L,16L,24L,56L,58L,65L,68L,70L,77L,87L,94L,99L,102L,106L,114L,116L,118L,140L,142L,185L,195L,219L,221L,224L,226L,235L,255L,259L,266L,278L,280L,290L,302L,310L,318L,334L,366L,370L,375L,377L,399L,403L,411L,413L,415L,442L,447L,462L,494L,530L,532L,550L,568L,575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073687Inst : IEnumerable<long>
{
public static readonly long[] Value=A073687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073687.Bytes);
public long this[int i]=>Value[i];

public static A073687Inst Instance=new A073687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073688
{
public static readonly BigInteger[] Value={ 2L,3L,13L,31L,55441L,13L,2731L,17L,307L,4037881L,601L,530122321L,63606090241L,115511761L,91081L,2307336935904001L,185137L,3541L,238267L,1250895361L,4831L,5113L,2370937801L,79L,292666711681L,BigInteger.Parse("32808912827897606401") };
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
public class A073688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073688Inst Instance=new A073688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073689
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,12L,13L,16L,17L,19L,24L,26L,32L,39L,44L,47L,56L,59L,61L,64L,69L,71L,73L,78L,79L,85L,95L,108L,109L,120L,128L,131L,133L,136L,137L,144L,151L,169L,212L,219L,225L,232L,233L,260L,276L,277L,284L,290L,292L,293L,295L,311L,317L,326L,329L,331L,355L,358L,359L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073689Inst : IEnumerable<long>
{
public static readonly long[] Value=A073689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073689.Bytes);
public long this[int i]=>Value[i];

public static A073689Inst Instance=new A073689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073690
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,1L,3L,1L,2L,5L,2L,6L,7L,5L,3L,9L,3L,2L,3L,5L,2L,2L,5L,1L,6L,10L,13L,1L,11L,8L,3L,2L,3L,1L,7L,7L,18L,43L,7L,6L,7L,1L,27L,16L,1L,7L,6L,2L,1L,2L,16L,6L,9L,3L,2L,24L,3L,1L,6L,8L,6L,8L,6L,19L,6L,1L,12L,5L,7L,13L,1L,7L,3L,7L,6L,6L,1L,7L,20L,20L,20L,2L,1L,5L,1L,10L,3L,1L,7L,2L,1L,13L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073690Inst : IEnumerable<long>
{
public static readonly long[] Value=A073690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073690.Bytes);
public long this[int i]=>Value[i];

public static A073690Inst Instance=new A073690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073691
{
public static readonly long[] Value={ 1L,3L,5L,7L,9011L,17L,19L,401L,577L,29L,31L,51666617L,43L,90947L,410006013351009077L,71L,73L,5477L,79L,45144947L,89L,8101L,8837L,13579634496890387L,1520417L,14401L,15377L,5279231461457L,2802659L,21317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073691Inst : IEnumerable<long>
{
public static readonly long[] Value=A073691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073691.Bytes);
public long this[int i]=>Value[i];

public static A073691Inst Instance=new A073691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073692
{
public static readonly long[] Value={ 1L,3L,5L,7L,15L,17L,19L,23L,27L,29L,31L,41L,43L,49L,69L,71L,73L,77L,79L,87L,89L,93L,97L,113L,119L,123L,127L,139L,145L,149L,151L,175L,179L,181L,187L,195L,197L,199L,213L,221L,223L,227L,229L,233L,245L,251L,263L,267L,269L,271L,285L,323L,375L,385L,389L,395L,397L,559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073692Inst : IEnumerable<long>
{
public static readonly long[] Value=A073692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073692.Bytes);
public long this[int i]=>Value[i];

public static A073692Inst Instance=new A073692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073693
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,2L,2L,1L,1L,5L,1L,3L,10L,1L,1L,2L,1L,4L,1L,2L,2L,8L,3L,2L,2L,6L,3L,2L,1L,12L,2L,1L,3L,4L,1L,1L,7L,4L,1L,2L,1L,2L,6L,3L,6L,2L,1L,1L,7L,19L,26L,5L,2L,3L,1L,81L,3L,56L,28L,23L,2L,2L,17L,1L,6L,4L,9L,1L,2L,4L,1L,5L,9L,1L,7L,3L,1L,2L,16L,1L,6L,49L,7L,1L,2L,6L,3L,1L,6L,17L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073693Inst : IEnumerable<long>
{
public static readonly long[] Value=A073693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073693.Bytes);
public long this[int i]=>Value[i];

public static A073693Inst Instance=new A073693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073694
{
public static readonly long[] Value={ 5L,32L,50L,162L,512L,1984L,2450L,3784L,5408L,7564L,9248L,15488L,19208L,22684L,26680L,30752L,53792L,79600L,85698L,102604L,113764L,131584L,189112L,199712L,279752L,336200L,435244L,514098L,546012L,581042L,658952L,712818L,727218L,752764L,767560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073694Inst : IEnumerable<long>
{
public static readonly long[] Value=A073694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073694.Bytes);
public long this[int i]=>Value[i];

public static A073694Inst Instance=new A073694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073695
{
public static readonly BigInteger[] Value={ 3L,5L,7L,13441L,17L,19L,7380172801L,7591472824321L,140401L,51036733441L,BigInteger.Parse("146109005759529941022461793072270221794657871709130281512574451086642415308955967454343059210240000000000001"),173L,BigInteger.Parse("123607727923097573594325460106230958516233681919759351808000001"),229L,40733079612825601L,15732964097851392001UL };
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
public class A073695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073695Inst Instance=new A073695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073696
{
public static readonly long[] Value={ 2L,4L,6L,8L,16L,18L,20L,34L,50L,56L,68L,172L,174L,228L,230L,244L,260L,268L,270L,272L,296L,460L,462L,464L,486L,488L,498L,500L,510L,516L,662L,676L,678L,762L,806L,822L,824L,864L,880L,882L,884L,894L,906L,908L,932L,938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073696Inst : IEnumerable<long>
{
public static readonly long[] Value=A073696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073696.Bytes);
public long this[int i]=>Value[i];

public static A073696Inst Instance=new A073696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073697
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,7L,8L,3L,6L,52L,1L,27L,1L,7L,8L,4L,1L,1L,12L,82L,1L,1L,11L,1L,5L,1L,5L,3L,73L,7L,1L,42L,22L,8L,1L,20L,8L,1L,1L,5L,6L,1L,12L,3L,30L,5L,1L,5L,1L,14L,1L,25L,1L,35L,4L,75L,7L,45L,12L,3L,9L,10L,17L,31L,1L,7L,3L,3L,4L,1L,3L,16L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073697Inst : IEnumerable<long>
{
public static readonly long[] Value=A073697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073697.Bytes);
public long this[int i]=>Value[i];

public static A073697Inst Instance=new A073697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073698
{
public static readonly BigInteger[] Value={ 2L,7L,503L,113L,7151L,109873L,162287L,2251875110689L,1423309560546093919L,1831931738588396657L,BigInteger.Parse("266306005917953213327"),BigInteger.Parse("13573982207668041076860262513"),BigInteger.Parse("4485809513902758532742979512207") };
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
public class A073698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073698Inst Instance=new A073698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073699
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,8L,82L,7L,89L,6L,96L,1450L,23201L,1364L,24565L,1292L,25858L,543035L,11946780L,519425L,12466205L,311655142L,8103033711L,218781910200L,6125893485615L,211237706400L,6337131192016L,204423586839L,6541554778855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073699Inst : IEnumerable<long>
{
public static readonly long[] Value=A073699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073699.Bytes);
public long this[int i]=>Value[i];

public static A073699Inst Instance=new A073699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073780
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,3L,3L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,3L,1L,3L,3L,3L,3L,1L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,3L,1L,3L,3L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,3L,3L,3L,5L,3L,3L,3L,3L,1L,3L,5L,3L,3L,3L,3L,5L,5L,3L,3L,3L,3L,3L,3L,3L,3L,1L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073780Inst : IEnumerable<long>
{
public static readonly long[] Value=A073780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073780.Bytes);
public long this[int i]=>Value[i];

public static A073780Inst Instance=new A073780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073781
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,2L,1L,2L,1L,0L,0L,1L,1L,2L,3L,2L,2L,1L,3L,2L,3L,1L,2L,1L,2L,1L,3L,0L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,3L,2L,2L,1L,3L,1L,2L,3L,3L,2L,4L,4L,4L,2L,1L,2L,3L,0L,1L,1L,0L,2L,1L,2L,2L,3L,1L,0L,2L,2L,1L,2L,1L,1L,1L,2L,2L,2L,3L,1L,2L,2L,4L,1L,2L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073781Inst : IEnumerable<long>
{
public static readonly long[] Value=A073781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073781.Bytes);
public long this[int i]=>Value[i];

public static A073781Inst Instance=new A073781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073782
{
public static readonly long[] Value={ 9L,6L,19L,48L,89L,190L,391L,784L,1577L,3142L,6219L,12256L,24041L,46974L,91471L,177568L,343753L,663814L,1278979L,2459152L,4719417L,9041470L,17294039L,33030320L,62999145L,120006214L,228327099L,433939904L,823854793L,1562602238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073782Inst : IEnumerable<long>
{
public static readonly long[] Value=A073782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073782.Bytes);
public long this[int i]=>Value[i];

public static A073782Inst Instance=new A073782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073783
{
public static readonly long[] Value={ 2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073783Inst : IEnumerable<long>
{
public static readonly long[] Value=A073783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073783.Bytes);
public long this[int i]=>Value[i];

public static A073783Inst Instance=new A073783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073784
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073784Inst : IEnumerable<long>
{
public static readonly long[] Value=A073784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073784.Bytes);
public long this[int i]=>Value[i];

public static A073784Inst Instance=new A073784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073785
{
public static readonly long[] Value={ 0L,1L,2L,120L,121L,122L,110L,111L,112L,100L,101L,102L,220L,221L,222L,210L,211L,212L,200L,201L,202L,12020L,12021L,12022L,12010L,12011L,12012L,12000L,12001L,12002L,12120L,12121L,12122L,12110L,12111L,12112L,12100L,12101L,12102L,12220L,12221L,12222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073785Inst : IEnumerable<long>
{
public static readonly long[] Value=A073785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073785.Bytes);
public long this[int i]=>Value[i];

public static A073785Inst Instance=new A073785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073786
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,140L,141L,142L,143L,144L,130L,131L,132L,133L,134L,120L,121L,122L,123L,124L,110L,111L,112L,113L,114L,100L,101L,102L,103L,104L,240L,241L,242L,243L,244L,230L,231L,232L,233L,234L,220L,221L,222L,223L,224L,210L,211L,212L,213L,214L,200L,201L,202L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073786Inst : IEnumerable<long>
{
public static readonly long[] Value=A073786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073786.Bytes);
public long this[int i]=>Value[i];

public static A073786Inst Instance=new A073786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073787
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,150L,151L,152L,153L,154L,155L,140L,141L,142L,143L,144L,145L,130L,131L,132L,133L,134L,135L,120L,121L,122L,123L,124L,125L,110L,111L,112L,113L,114L,115L,100L,101L,102L,103L,104L,105L,250L,251L,252L,253L,254L,255L,240L,241L,242L,243L,244L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073787Inst : IEnumerable<long>
{
public static readonly long[] Value=A073787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073787.Bytes);
public long this[int i]=>Value[i];

public static A073787Inst Instance=new A073787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073788
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,160L,161L,162L,163L,164L,165L,166L,150L,151L,152L,153L,154L,155L,156L,140L,141L,142L,143L,144L,145L,146L,130L,131L,132L,133L,134L,135L,136L,120L,121L,122L,123L,124L,125L,126L,110L,111L,112L,113L,114L,115L,116L,100L,101L,102L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073788Inst : IEnumerable<long>
{
public static readonly long[] Value=A073788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073788.Bytes);
public long this[int i]=>Value[i];

public static A073788Inst Instance=new A073788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073789
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,170L,171L,172L,173L,174L,175L,176L,177L,160L,161L,162L,163L,164L,165L,166L,167L,150L,151L,152L,153L,154L,155L,156L,157L,140L,141L,142L,143L,144L,145L,146L,147L,130L,131L,132L,133L,134L,135L,136L,137L,120L,121L,122L,123L,124L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073789Inst : IEnumerable<long>
{
public static readonly long[] Value=A073789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073789.Bytes);
public long this[int i]=>Value[i];

public static A073789Inst Instance=new A073789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073790
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,180L,181L,182L,183L,184L,185L,186L,187L,188L,170L,171L,172L,173L,174L,175L,176L,177L,178L,160L,161L,162L,163L,164L,165L,166L,167L,168L,150L,151L,152L,153L,154L,155L,156L,157L,158L,140L,141L,142L,143L,144L,145L,146L,147L,148L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073790Inst : IEnumerable<long>
{
public static readonly long[] Value=A073790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073790.Bytes);
public long this[int i]=>Value[i];

public static A073790Inst Instance=new A073790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073791
{
public static readonly long[] Value={ 0L,1L,2L,3L,-4L,-3L,-2L,-1L,-8L,-7L,-6L,-5L,-12L,-11L,-10L,-9L,16L,17L,18L,19L,12L,13L,14L,15L,8L,9L,10L,11L,4L,5L,6L,7L,32L,33L,34L,35L,28L,29L,30L,31L,24L,25L,26L,27L,20L,21L,22L,23L,48L,49L,50L,51L,44L,45L,46L,47L,40L,41L,42L,43L,36L,37L,38L,39L,-64L,-63L,-62L,-61L,-68L,-67L,-66L,-65L,-72L,-71L,-70L,-69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073791Inst : IEnumerable<long>
{
public static readonly long[] Value=A073791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073791.Bytes);
public long this[int i]=>Value[i];

public static A073791Inst Instance=new A073791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073792
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,-5L,-4L,-3L,-2L,-1L,-10L,-9L,-8L,-7L,-6L,-15L,-14L,-13L,-12L,-11L,-20L,-19L,-18L,-17L,-16L,25L,26L,27L,28L,29L,20L,21L,22L,23L,24L,15L,16L,17L,18L,19L,10L,11L,12L,13L,14L,5L,6L,7L,8L,9L,50L,51L,52L,53L,54L,45L,46L,47L,48L,49L,40L,41L,42L,43L,44L,35L,36L,37L,38L,39L,30L,31L,32L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073792Inst : IEnumerable<long>
{
public static readonly long[] Value=A073792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073792.Bytes);
public long this[int i]=>Value[i];

public static A073792Inst Instance=new A073792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073793
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,-6L,-5L,-4L,-3L,-2L,-1L,-12L,-11L,-10L,-9L,-8L,-7L,-18L,-17L,-16L,-15L,-14L,-13L,-24L,-23L,-22L,-21L,-20L,-19L,-30L,-29L,-28L,-27L,-26L,-25L,36L,37L,38L,39L,40L,41L,30L,31L,32L,33L,34L,35L,24L,25L,26L,27L,28L,29L,18L,19L,20L,21L,22L,23L,12L,13L,14L,15L,16L,17L,6L,7L,8L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073793Inst : IEnumerable<long>
{
public static readonly long[] Value=A073793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073793.Bytes);
public long this[int i]=>Value[i];

public static A073793Inst Instance=new A073793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073794
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,-7L,-6L,-5L,-4L,-3L,-2L,-1L,-14L,-13L,-12L,-11L,-10L,-9L,-8L,-21L,-20L,-19L,-18L,-17L,-16L,-15L,-28L,-27L,-26L,-25L,-24L,-23L,-22L,-35L,-34L,-33L,-32L,-31L,-30L,-29L,-42L,-41L,-40L,-39L,-38L,-37L,-36L,49L,50L,51L,52L,53L,54L,55L,42L,43L,44L,45L,46L,47L,48L,35L,36L,37L,38L,39L,40L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073794Inst : IEnumerable<long>
{
public static readonly long[] Value=A073794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073794.Bytes);
public long this[int i]=>Value[i];

public static A073794Inst Instance=new A073794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073795
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,-8L,-7L,-6L,-5L,-4L,-3L,-2L,-1L,-16L,-15L,-14L,-13L,-12L,-11L,-10L,-9L,-24L,-23L,-22L,-21L,-20L,-19L,-18L,-17L,-32L,-31L,-30L,-29L,-28L,-27L,-26L,-25L,-40L,-39L,-38L,-37L,-36L,-35L,-34L,-33L,-48L,-47L,-46L,-45L,-44L,-43L,-42L,-41L,-56L,-55L,-54L,-53L,-52L,-51L,-50L,-49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073795Inst : IEnumerable<long>
{
public static readonly long[] Value=A073795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073795.Bytes);
public long this[int i]=>Value[i];

public static A073795Inst Instance=new A073795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073812
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,3L,2L,4L,4L,1L,2L,2L,2L,2L,3L,2L,2L,3L,1L,4L,2L,3L,2L,4L,2L,1L,3L,2L,8L,1L,2L,4L,4L,2L,2L,6L,2L,3L,4L,2L,2L,3L,2L,1L,4L,2L,2L,4L,4L,8L,3L,2L,2L,4L,2L,4L,3L,1L,6L,3L,2L,2L,3L,8L,2L,2L,2L,4L,3L,3L,6L,8L,2L,2L,1L,2L,2L,4L,3L,4L,4L,6L,2L,4L,4L,3L,3L,2L,8L,3L,2L,2L,6L,1L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073812Inst : IEnumerable<long>
{
public static readonly long[] Value=A073812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073812.Bytes);
public long this[int i]=>Value[i];

public static A073812Inst Instance=new A073812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073813
{
public static readonly long[] Value={ 0L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,5L,2L,3L,2L,2L,2L,3L,2L,5L,2L,2L,3L,2L,2L,2L,3L,2L,2L,7L,2L,3L,2L,2L,5L,2L,3L,2L,2L,2L,3L,2L,5L,2L,2L,3L,2L,2L,2L,3L,2L,7L,2L,2L,3L,2L,2L,5L,2L,3L,2L,2L,7L,2L,3L,2L,5L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,5L,2L,3L,2L,7L,2L,11L,2L,3L,2L,5L,2L,2L,3L,2L,2L,7L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073813Inst : IEnumerable<long>
{
public static readonly long[] Value=A073813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073813.Bytes);
public long this[int i]=>Value[i];

public static A073813Inst Instance=new A073813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073814
{
public static readonly long[] Value={ 2L,4L,15L,33L,90L,129L,227L,288L,429L,694L,798L,1149L,1417L,1565L,1879L,2399L,2993L,3201L,3879L,4365L,4623L,5429L,6002L,6920L,8245L,8948L,9314L,10067L,10457L,11245L,14251L,15184L,16627L,17130L,19711L,20253L,21919L,23653L,24845L,26687L,28604L,29248L,32612L,33303L,34719L,35436L,39893L,44622L,46254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073814Inst : IEnumerable<long>
{
public static readonly long[] Value=A073814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073814.Bytes);
public long this[int i]=>Value[i];

public static A073814Inst Instance=new A073814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073815
{
public static readonly long[] Value={ 1L,3L,18L,12L,200L,14L,3364L,15L,722L,328L,9801L,42L,25281L,116L,1800L,165L,36992L,810L,4414201L,88L,196L,29161L,541696L,35L,2928200L,1413L,103968L,172L,98942809L,488L,1547536L,336L,19602L,17536L,814088L,370L,49042009L,55297L,1521L,319L,3150464641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073815Inst : IEnumerable<long>
{
public static readonly long[] Value=A073815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073815.Bytes);
public long this[int i]=>Value[i];

public static A073815Inst Instance=new A073815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073816
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,4L,4L,0L,2L,4L,4L,4L,4L,8L,1L,0L,4L,8L,4L,4L,4L,20L,4L,16L,23L,12L,16L,4L,4L,16L,4L,0L,25L,30L,1L,20L,4L,26L,22L,24L,4L,22L,4L,16L,19L,18L,4L,16L,36L,42L,1L,4L,4L,46L,26L,8L,28L,6L,4L,16L,4L,2L,4L,0L,1L,16L,4L,64L,49L,36L,4L,8L,4L,64L,16L,44L,64L,40L,4L,64L,11L,64L,4L,4L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073816Inst : IEnumerable<long>
{
public static readonly long[] Value=A073816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073816.Bytes);
public long this[int i]=>Value[i];

public static A073816Inst Instance=new A073816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073817
{
public static readonly long[] Value={ 4L,1L,3L,7L,15L,26L,51L,99L,191L,367L,708L,1365L,2631L,5071L,9775L,18842L,36319L,70007L,134943L,260111L,501380L,966441L,1862875L,3590807L,6921503L,13341626L,25716811L,49570747L,95550687L,184179871L,355018116L,684319421L,1319068095L,2542585503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073817Inst : IEnumerable<long>
{
public static readonly long[] Value=A073817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073817.Bytes);
public long this[int i]=>Value[i];

public static A073817Inst Instance=new A073817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073818
{
public static readonly long[] Value={ 2L,4L,6L,10L,15L,22L,33L,44L,55L,68L,85L,102L,119L,145L,174L,203L,232L,261L,296L,333L,370L,410L,451L,492L,533L,590L,649L,708L,767L,826L,885L,944L,1005L,1072L,1139L,1207L,1278L,1358L,1455L,1552L,1649L,1746L,1843L,1940L,2037L,2134L,2231L,2328L,2425L,2540L,2667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073818Inst : IEnumerable<long>
{
public static readonly long[] Value=A073818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073818.Bytes);
public long this[int i]=>Value[i];

public static A073818Inst Instance=new A073818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073819
{
public static readonly long[] Value={ 2L,2L,2L,5L,5L,11L,11L,11L,11L,17L,17L,17L,17L,29L,29L,29L,29L,29L,37L,37L,37L,41L,41L,41L,41L,59L,59L,59L,59L,59L,59L,59L,67L,67L,67L,71L,71L,97L,97L,97L,97L,97L,97L,97L,97L,97L,97L,97L,97L,127L,127L,127L,127L,127L,127L,127L,127L,149L,149L,149L,149L,149L,149L,149L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073819Inst : IEnumerable<long>
{
public static readonly long[] Value=A073819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073819.Bytes);
public long this[int i]=>Value[i];

public static A073819Inst Instance=new A073819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073820
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,6L,7L,5L,6L,7L,8L,9L,8L,9L,10L,10L,11L,12L,13L,10L,11L,12L,13L,14L,15L,16L,15L,16L,17L,17L,18L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,20L,21L,22L,23L,24L,25L,26L,27L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,32L,33L,31L,30L,31L,32L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073820Inst : IEnumerable<long>
{
public static readonly long[] Value=A073820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073820.Bytes);
public long this[int i]=>Value[i];

public static A073820Inst Instance=new A073820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073821
{
public static readonly long[] Value={ 4L,4L,6L,3L,8L,9L,9L,6L,5L,8L,9L,6L,5L,3L,4L,5L,0L,7L,0L,4L,7L,6L,8L,1L,7L,9L,5L,1L,9L,2L,6L,4L,2L,6L,6L,9L,7L,7L,6L,2L,5L,3L,1L,4L,7L,4L,0L,0L,3L,8L,7L,8L,2L,2L,8L,6L,1L,1L,9L,8L,9L,8L,6L,5L,4L,9L,5L,1L,4L,8L,9L,3L,1L,4L,4L,3L,6L,7L,5L,6L,2L,5L,6L,8L,6L,0L,7L,6L,8L,8L,0L,0L,6L,9L,9L,5L,1L,3L,6L,5L,8L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073821Inst : IEnumerable<long>
{
public static readonly long[] Value=A073821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073821.Bytes);
public long this[int i]=>Value[i];

public static A073821Inst Instance=new A073821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073822
{
public static readonly long[] Value={ 5L,8L,8L,8L,7L,3L,9L,5L,2L,5L,4L,8L,9L,3L,3L,5L,0L,7L,6L,7L,1L,2L,3L,1L,1L,2L,1L,2L,4L,6L,7L,8L,7L,3L,8L,4L,0L,7L,9L,9L,9L,0L,8L,4L,8L,3L,9L,1L,3L,1L,8L,7L,5L,9L,5L,6L,8L,8L,2L,2L,7L,9L,5L,6L,4L,5L,9L,4L,7L,2L,4L,5L,9L,3L,5L,2L,0L,5L,8L,7L,7L,9L,1L,5L,1L,5L,0L,1L,1L,4L,0L,1L,3L,8L,2L,0L,6L,8L,9L,5L,2L,7L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073822Inst : IEnumerable<long>
{
public static readonly long[] Value=A073822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073822.Bytes);
public long this[int i]=>Value[i];

public static A073822Inst Instance=new A073822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073823
{
public static readonly long[] Value={ 7L,5L,9L,8L,4L,3L,5L,4L,3L,0L,6L,2L,0L,6L,1L,4L,7L,0L,1L,0L,5L,2L,7L,7L,8L,4L,1L,7L,9L,1L,8L,0L,9L,7L,0L,8L,8L,6L,4L,6L,8L,0L,2L,4L,3L,8L,5L,1L,7L,2L,6L,1L,5L,8L,1L,7L,8L,5L,9L,8L,8L,5L,2L,3L,0L,4L,3L,0L,9L,9L,4L,2L,0L,2L,9L,8L,1L,2L,4L,7L,1L,8L,8L,3L,5L,5L,6L,1L,4L,5L,9L,6L,1L,4L,7L,9L,1L,9L,4L,0L,0L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073823Inst : IEnumerable<long>
{
public static readonly long[] Value=A073823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073823.Bytes);
public long this[int i]=>Value[i];

public static A073823Inst Instance=new A073823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073824
{
public static readonly long[] Value={ 8L,0L,4L,3L,1L,8L,5L,6L,1L,1L,1L,7L,1L,5L,7L,9L,5L,0L,7L,6L,7L,6L,8L,0L,4L,4L,1L,3L,9L,3L,4L,1L,9L,2L,9L,9L,0L,5L,7L,3L,2L,7L,2L,7L,3L,9L,6L,4L,1L,9L,6L,8L,5L,2L,8L,5L,5L,9L,9L,2L,7L,3L,5L,9L,5L,1L,9L,1L,4L,5L,4L,5L,5L,3L,1L,0L,2L,2L,7L,8L,0L,8L,2L,1L,3L,4L,5L,3L,2L,4L,9L,3L,1L,1L,2L,0L,2L,0L,4L,4L,9L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073824Inst : IEnumerable<long>
{
public static readonly long[] Value=A073824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073824.Bytes);
public long this[int i]=>Value[i];

public static A073824Inst Instance=new A073824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073825
{
public static readonly long[] Value={ 2L,5L,6L,10L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073825Inst : IEnumerable<long>
{
public static readonly long[] Value=A073825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073825.Bytes);
public long this[int i]=>Value[i];

public static A073825Inst Instance=new A073825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073826
{
public static readonly BigInteger[] Value={ 5L,3413L,50069L,10405071317L,BigInteger.Parse("208492413443704093346554910065262730566475781") };
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
public class A073826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073826Inst Instance=new A073826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073827
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073827Inst : IEnumerable<long>
{
public static readonly long[] Value=A073827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073827.Bytes);
public long this[int i]=>Value[i];

public static A073827Inst Instance=new A073827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073844
{
public static readonly long[] Value={ 1L,3L,41L,617L,823L,643L,9721L,14593L,3803L,3803L,14405693L,10288065751L,116216501L,12079920647L,7552031L,435503L,1763668414462081L,106377431L,27961L,27961L,205126079L,84225392753L,7347135846537257L,437274720469L,12792129877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073844Inst : IEnumerable<long>
{
public static readonly long[] Value=A073844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073844.Bytes);
public long this[int i]=>Value[i];

public static A073844Inst Instance=new A073844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073845
{
public static readonly long[] Value={ 1L,1L,0L,5L,-3L,18L,-17L,65L,-80L,241L,-351L,914L,-1485L,3525L,-6152L,13757L,-25163L,54130L,-102105L,214169L,-412224L,850521L,-1658855L,3385970L,-6661493L,13501693L,-26714232L,53896325L,-107035635L,215296146L,-428610401L,860427569L,-1715666480L,3439728385L,-6865872687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073845Inst : IEnumerable<long>
{
public static readonly long[] Value=A073845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073845.Bytes);
public long this[int i]=>Value[i];

public static A073845Inst Instance=new A073845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073846
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,8L,7L,9L,11L,10L,13L,12L,17L,14L,19L,15L,23L,16L,29L,18L,31L,20L,37L,21L,41L,22L,43L,24L,47L,25L,53L,26L,59L,27L,61L,28L,67L,30L,71L,32L,73L,33L,79L,34L,83L,35L,89L,36L,97L,38L,101L,39L,103L,40L,107L,42L,109L,44L,113L,45L,127L,46L,131L,48L,137L,49L,139L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073846Inst : IEnumerable<long>
{
public static readonly long[] Value=A073846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073846.Bytes);
public long this[int i]=>Value[i];

public static A073846Inst Instance=new A073846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073847
{
public static readonly long[] Value={ 1L,5L,11L,19L,29L,41L,59L,79L,101L,127L,157L,191L,227L,269L,313L,359L,409L,461L,521L,587L,659L,733L,809L,887L,967L,1049L,1151L,1259L,1373L,1489L,1607L,1733L,1861L,1993L,2129L,2267L,2411L,2557L,2707L,2861L,3019L,3181L,3347L,3517L,3691L,3877L,4073L,4271L,4481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073847Inst : IEnumerable<long>
{
public static readonly long[] Value=A073847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073847.Bytes);
public long this[int i]=>Value[i];

public static A073847Inst Instance=new A073847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073848
{
public static readonly BigInteger[] Value={ 1L,1L,6L,58L,615L,7761L,117628L,4L,2151L,999999955L,25937424546L,181398462L,23298085122403L,793714773254053L,29192926025390520L,3976L,BigInteger.Parse("48661191875666868345"),5642219814759L,BigInteger.Parse("104127350297911241532670") };
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
public class A073848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073848Inst Instance=new A073848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073849
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073849Inst : IEnumerable<long>
{
public static readonly long[] Value=A073849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073849.Bytes);
public long this[int i]=>Value[i];

public static A073849Inst Instance=new A073849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073850
{
public static readonly long[] Value={ 0L,1L,3L,6L,7L,8L,9L,10L,12L,14L,16L,18L,21L,24L,27L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,81L,84L,87L,90L,93L,96L,99L,102L,105L,108L,111L,114L,117L,120L,123L,126L,127L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073850Inst : IEnumerable<long>
{
public static readonly long[] Value=A073850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073850.Bytes);
public long this[int i]=>Value[i];

public static A073850Inst Instance=new A073850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073851
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,11L,12L,13L,14L,15L,17L,19L,21L,23L,25L,28L,31L,34L,37L,40L,44L,48L,52L,56L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073851Inst : IEnumerable<long>
{
public static readonly long[] Value=A073851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073851.Bytes);
public long this[int i]=>Value[i];

public static A073851Inst Instance=new A073851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073852
{
public static readonly long[] Value={ 1L,4L,36L,576L,144L,2916L,324L,1296L,900L,2304L,3600L,7056L,1764L,8100L,4356L,5184L,9216L,6084L,14400L,15876L,10404L,22500L,20736L,11664L,24336L,12996L,19044L,17424L,32400L,41616L,44100L,28224L,34596L,36864L,54756L,30276L,26244L,46656L,39204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073852Inst : IEnumerable<long>
{
public static readonly long[] Value=A073852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073852.Bytes);
public long this[int i]=>Value[i];

public static A073852Inst Instance=new A073852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073853
{
public static readonly long[] Value={ 0L,5L,9L,12L,24L,45L,60L,65L,179L,764L,1268L,5891L,16135L,29909L,71774L,173310L,200040L,1454560L,2485272L,86430343L,92439810L,115854652L,7208007982L,17016737751L,17589706947L,24531053552L,33113576855L,80692537585L,234365843350L,266484243960L,285357252641L,426388494035L,975986718040L,1505420538689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073853Inst : IEnumerable<long>
{
public static readonly long[] Value=A073853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073853.Bytes);
public long this[int i]=>Value[i];

public static A073853Inst Instance=new A073853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073854
{
public static readonly long[] Value={ 1L,5L,41L,617L,761L,3677L,4001L,5297L,6197L,8501L,12101L,19157L,20921L,29021L,33377L,38561L,47777L,53861L,68261L,84137L,94541L,117041L,137777L,149441L,173777L,186773L,205817L,223241L,255641L,297257L,341357L,369581L,404177L,441041L,495797L,526073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073854Inst : IEnumerable<long>
{
public static readonly long[] Value=A073854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073854.Bytes);
public long this[int i]=>Value[i];

public static A073854Inst Instance=new A073854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073855
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,4L,2L,3L,2L,3L,3L,3L,2L,4L,3L,3L,3L,3L,2L,3L,2L,3L,3L,3L,3L,4L,2L,3L,3L,4L,2L,3L,2L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,4L,3L,4L,3L,3L,2L,4L,2L,3L,3L,4L,3L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,3L,3L,3L,2L,3L,4L,3L,2L,4L,3L,3L,3L,4L,2L,4L,3L,3L,3L,3L,3L,4L,2L,3L,3L,4L,2L,3L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073855Inst : IEnumerable<long>
{
public static readonly long[] Value=A073855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073855.Bytes);
public long this[int i]=>Value[i];

public static A073855Inst Instance=new A073855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073856
{
public static readonly BigInteger[] Value={ 1L,4L,8L,16L,32L,4096L,279936L,656100000000L,19683000000000L,3656158440062976L,36028797018963968L,BigInteger.Parse("417030640378345864542952820736"),6502111422497947648L,BigInteger.Parse("329539482806454424642350193846115106816"),BigInteger.Parse("24066838317339048730709164032") };
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
public class A073856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073856Inst Instance=new A073856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073857
{
public static readonly BigInteger[] Value={ 1L,5L,13L,29L,61L,4157L,284093L,656100284093L,20339100284093L,3676497540347069L,39705294559311037L,BigInteger.Parse("417030640378385569837512131773"),BigInteger.Parse("417030640384887681260010079421"),BigInteger.Parse("329539483223485065027237875106125186237") };
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
public class A073857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073857Inst Instance=new A073857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073858
{
public static readonly long[] Value={ 1L,2L,4L,9L,16L,18L,64L,100L,225L,242L,450L,516L,729L,1458L,3872L,4096L,4624L,13932L,14406L,17672L,18225L,20124L,21780L,28900L,29262L,29616L,36450L,45996L,62500L,65025L,65536L,76832L,92778L,95916L,106092L,106308L,114630L,114930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073858Inst : IEnumerable<long>
{
public static readonly long[] Value=A073858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073858.Bytes);
public long this[int i]=>Value[i];

public static A073858Inst Instance=new A073858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073859
{
public static readonly long[] Value={ 1L,7L,19L,37L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073859Inst : IEnumerable<long>
{
public static readonly long[] Value=A073859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073859.Bytes);
public long this[int i]=>Value[i];

public static A073859Inst Instance=new A073859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073860
{
public static readonly long[] Value={ 2L,7L,503L,1889L,30367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073860Inst : IEnumerable<long>
{
public static readonly long[] Value=A073860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073860.Bytes);
public long this[int i]=>Value[i];

public static A073860Inst Instance=new A073860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073861
{
public static readonly long[] Value={ 3L,89L,887L,9551L,31397L,492113L,4652353L,47326693L,436273009L,4302407359L,42652618343L,738832927927L,7177162611713L,90874329411493L,218209405436543L,1693182318746371L,80873624627234849L,804212830686677669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073861Inst : IEnumerable<long>
{
public static readonly long[] Value=A073861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073861.Bytes);
public long this[int i]=>Value[i];

public static A073861Inst Instance=new A073861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073862
{
public static readonly long[] Value={ 5L,86L,896L,8964L,89984L,899980L,8999988L,89999970L,899999930L,8999999960L,89999999958L,899999999986L,8999999999932L,89999999999936L,899999999999958L,8999999999999900L,89999999999999936L,899999999999999986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073862Inst : IEnumerable<long>
{
public static readonly long[] Value=A073862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073862.Bytes);
public long this[int i]=>Value[i];

public static A073862Inst Instance=new A073862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073863
{
public static readonly long[] Value={ 4L,54L,549L,5491L,54999L,549993L,5499997L,55000004L,549999972L,5499999987L,54999999998L,549999999996L,5500000000005L,55000000000005L,550000000000010L,5499999999999987L,55000000000000029L,549999999999999996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073863Inst : IEnumerable<long>
{
public static readonly long[] Value=A073863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073863.Bytes);
public long this[int i]=>Value[i];

public static A073863Inst Instance=new A073863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073864
{
public static readonly BigInteger[] Value={ 0L,11L,0L,1021L,10103L,0L,1000033L,10000223L,0L,1000000009L,10000000019L,0L,1000000000039L,10000000000283L,0L,1000000000000159L,10000000000000079L,0L,1000000000000000387L,10000000000000000667UL,0L,BigInteger.Parse("1000000000000000000399") };
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
public class A073864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073864Inst Instance=new A073864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073865
{
public static readonly long[] Value={ 0L,11L,0L,3001L,30011L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073865Inst : IEnumerable<long>
{
public static readonly long[] Value=A073865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073865.Bytes);
public long this[int i]=>Value[i];

public static A073865Inst Instance=new A073865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073866
{
public static readonly long[] Value={ 4L,6L,8L,9L,28L,39L,68L,69L,88L,99L,299L,399L,589L,699L,799L,899L,999L,2899L,3999L,5999L,6999L,7999L,9899L,9999L,29999L,39999L,58999L,69999L,89999L,99999L,299899L,399999L,499999L,689999L,699999L,889999L,999999L,1999999L,3899999L,3999999L,5899999L,6999999L,8999999L,9999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073866Inst : IEnumerable<long>
{
public static readonly long[] Value=A073866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073866.Bytes);
public long this[int i]=>Value[i];

public static A073866Inst Instance=new A073866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073867
{
public static readonly long[] Value={ 13L,0L,17L,0L,19L,0L,59L,0L,79L,0L,389L,0L,499L,0L,997L,1889L,0L,1999L,0L,6899L,0L,17989L,8999L,0L,39989L,0L,49999L,0L,98999L,0L,199999L,0L,598999L,599999L,0L,799999L,0L,2998999L,2999999L,0L,4999999L,0L,9899999L,0L,19999999L,29999999L,0L,59999999L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073867Inst : IEnumerable<long>
{
public static readonly long[] Value=A073867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073867.Bytes);
public long this[int i]=>Value[i];

public static A073867Inst Instance=new A073867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073868
{
public static readonly long[] Value={ 20L,12L,14L,16L,38L,49L,98L,289L,689L,3899L,5899L,19999L,68999L,88999L,299999L,899999L,5999999L,7999999L,49999999L,98999999L,199999999L,889999999L,2999999999L,8999999999L,88999999999L,299999999999L,499999999999L,899999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073868Inst : IEnumerable<long>
{
public static readonly long[] Value=A073868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073868.Bytes);
public long this[int i]=>Value[i];

public static A073868Inst Instance=new A073868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073869
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,30L,31L,32L,32L,33L,33L,34L,35L,35L,36L,37L,37L,38L,38L,39L,40L,40L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073869Inst : IEnumerable<long>
{
public static readonly long[] Value=A073869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073869.Bytes);
public long this[int i]=>Value[i];

public static A073869Inst Instance=new A073869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073870
{
public static readonly long[] Value={ 4L,6L,9L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,15L,32L,34L,36L,38L,40L,21L,44L,46L,48L,25L,52L,27L,56L,58L,30L,62L,64L,33L,68L,35L,72L,74L,76L,39L,80L,82L,42L,86L,88L,45L,92L,94L,96L,49L,50L,51L,104L,106L,54L,55L,112L,57L,116L,118L,60L,122L,124L,63L,128L,65L,66L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073870Inst : IEnumerable<long>
{
public static readonly long[] Value=A073870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073870.Bytes);
public long this[int i]=>Value[i];

public static A073870Inst Instance=new A073870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073871
{
public static readonly long[] Value={ 4L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073871Inst : IEnumerable<long>
{
public static readonly long[] Value=A073871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073871.Bytes);
public long this[int i]=>Value[i];

public static A073871Inst Instance=new A073871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073872
{
public static readonly long[] Value={ 1L,6L,3L,28L,10L,36L,21L,120L,45L,190L,55L,276L,78L,210L,15L,496L,136L,378L,171L,300L,105L,66L,253L,528L,325L,780L,351L,1176L,406L,630L,465L,2016L,231L,1326L,595L,2556L,666L,1596L,741L,2080L,820L,3486L,903L,1540L,990L,2346L,1081L,4560L,1225L,2850L,153L,5356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073872Inst : IEnumerable<long>
{
public static readonly long[] Value=A073872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073872.Bytes);
public long this[int i]=>Value[i];

public static A073872Inst Instance=new A073872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073873
{
public static readonly long[] Value={ 1L,45L,325L,1225L,1653L,2145L,3321L,3655L,4371L,7381L,8911L,11781L,14365L,17205L,20301L,21945L,23653L,25425L,32131L,34191L,41905L,44253L,45451L,46665L,47895L,54285L,55611L,59685L,65341L,68265L,72771L,74305L,77421L,87153L,97461L,110215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073873Inst : IEnumerable<long>
{
public static readonly long[] Value=A073873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073873.Bytes);
public long this[int i]=>Value[i];

public static A073873Inst Instance=new A073873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073874
{
public static readonly long[] Value={ 1L,3L,1L,7L,2L,6L,3L,15L,5L,19L,5L,23L,6L,15L,1L,31L,8L,21L,9L,15L,5L,3L,11L,22L,13L,30L,13L,42L,14L,21L,15L,63L,7L,39L,17L,71L,18L,42L,19L,52L,20L,83L,21L,35L,22L,51L,23L,95L,25L,57L,3L,103L,26L,60L,27L,111L,29L,66L,29L,91L,30L,69L,31L,127L,33L,75L,33L,105L,15L,51L,35L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073874Inst : IEnumerable<long>
{
public static readonly long[] Value=A073874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073874.Bytes);
public long this[int i]=>Value[i];

public static A073874Inst Instance=new A073874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073875
{
public static readonly BigInteger[] Value={ 1L,2L,3L,8L,5L,144L,21L,2584L,46368L,610L,55L,14930352L,13L,4807526976L,6765L,1548008755920L,34L,498454011879264L,86267571272L,832040L,987L,2880067194370816120L,BigInteger.Parse("51680708854858323072"),160500643816367088L,75025L };
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
public class A073875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073875Inst Instance=new A073875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073892
{
public static readonly long[] Value={ 1L,3L,-1L,2L,-4L,1L,-7L,0L,-9L,2L,-8L,5L,-7L,10L,-4L,15L,0L,23L,7L,36L,18L,49L,29L,66L,45L,86L,64L,107L,83L,130L,105L,158L,132L,191L,164L,225L,197L,264L,234L,305L,273L,346L,313L,392L,358L,441L,406L,495L,459L,556L,518L,619L,580L,683L,643L,750L,708L,817L,773L,886L,841L,968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073892Inst : IEnumerable<long>
{
public static readonly long[] Value=A073892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073892.Bytes);
public long this[int i]=>Value[i];

public static A073892Inst Instance=new A073892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073893
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,5L,6L,1L,0L,8L,4L,9L,4L,5L,6L,25L,2L,15L,0L,15L,10L,28L,16L,25L,16L,28L,16L,13L,0L,14L,4L,22L,36L,5L,16L,35L,14L,47L,0L,16L,8L,42L,28L,35L,18L,49L,44L,27L,0L,42L,4L,26L,6L,45L,52L,53L,38L,62L,0L,44L,50L,25L,28L,15L,32L,43L,72L,29L,0L,61L,44L,45L,8L,25L,56L,82L,84L,85L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073893Inst : IEnumerable<long>
{
public static readonly long[] Value=A073893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073893.Bytes);
public long this[int i]=>Value[i];

public static A073893Inst Instance=new A073893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073894
{
public static readonly long[] Value={ 1L,0L,2L,4L,5L,6L,9L,12L,15L,10L,11L,24L,25L,8L,30L,40L,41L,18L,28L,20L,27L,46L,31L,52L,50L,32L,38L,60L,61L,80L,55L,36L,44L,120L,45L,48L,78L,26L,64L,160L,93L,14L,23L,140L,95L,98L,21L,76L,51L,100L,56L,92L,84L,34L,85L,68L,3L,62L,115L,180L,81L,74L,88L,128L,75L,58L,72L,124L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073894Inst : IEnumerable<long>
{
public static readonly long[] Value=A073894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073894.Bytes);
public long this[int i]=>Value[i];

public static A073894Inst Instance=new A073894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073895
{
public static readonly long[] Value={ 1L,5L,7L,10L,16L,24L,33L,43L,48L,60L,74L,89L,96L,112L,130L,150L,171L,193L,204L,228L,253L,279L,306L,334L,364L,396L,429L,463L,476L,511L,547L,564L,602L,641L,660L,700L,742L,786L,831L,877L,900L,948L,997L,1026L,1076L,1127L,1179L,1233L,1288L,1344L,1401L,1459L,1490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073895Inst : IEnumerable<long>
{
public static readonly long[] Value=A073895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073895.Bytes);
public long this[int i]=>Value[i];

public static A073895Inst Instance=new A073895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073896
{
public static readonly long[] Value={ 1L,3L,7L,13L,21L,24L,29L,38L,45L,56L,69L,86L,105L,128L,157L,167L,179L,193L,208L,239L,255L,292L,333L,376L,423L,476L,535L,596L,663L,734L,807L,886L,969L,1058L,1155L,1256L,1359L,1466L,1575L,1688L,1815L,1946L,2083L,2101L,2240L,2389L,2409L,2560L,2717L,2880L,3047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073896Inst : IEnumerable<long>
{
public static readonly long[] Value=A073896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073896.Bytes);
public long this[int i]=>Value[i];

public static A073896Inst Instance=new A073896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073897
{
public static readonly long[] Value={ 1L,3L,5L,2L,7L,4L,9L,6L,8L,10L,11L,12L,13L,14L,16L,18L,15L,20L,17L,22L,24L,26L,19L,28L,30L,32L,34L,36L,21L,38L,23L,40L,42L,44L,46L,48L,25L,50L,52L,54L,27L,56L,29L,58L,60L,62L,31L,64L,66L,68L,70L,72L,33L,74L,76L,78L,80L,82L,35L,84L,37L,86L,88L,90L,92L,94L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073897Inst : IEnumerable<long>
{
public static readonly long[] Value=A073897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073897.Bytes);
public long this[int i]=>Value[i];

public static A073897Inst Instance=new A073897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073898
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,8L,7L,9L,11L,10L,13L,12L,15L,17L,19L,14L,21L,16L,23L,25L,27L,18L,29L,31L,33L,35L,37L,20L,39L,22L,41L,43L,45L,47L,49L,24L,51L,53L,55L,26L,57L,28L,59L,61L,63L,30L,65L,67L,69L,71L,73L,32L,75L,77L,79L,81L,83L,34L,85L,36L,87L,89L,91L,93L,95L,38L,97L,99L,101L,40L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073898Inst : IEnumerable<long>
{
public static readonly long[] Value=A073898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073898.Bytes);
public long this[int i]=>Value[i];

public static A073898Inst Instance=new A073898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073899
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,8L,9L,10L,5L,12L,14L,15L,16L,18L,7L,20L,21L,22L,24L,25L,26L,27L,11L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,13L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,17L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073899Inst : IEnumerable<long>
{
public static readonly long[] Value=A073899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073899.Bytes);
public long this[int i]=>Value[i];

public static A073899Inst Instance=new A073899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073900
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,8L,9L,10L,12L,14L,15L,16L,5L,18L,20L,21L,22L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,44L,7L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073900Inst : IEnumerable<long>
{
public static readonly long[] Value=A073900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073900.Bytes);
public long this[int i]=>Value[i];

public static A073900Inst Instance=new A073900Inst();

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