using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190373
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,14L,16L,18L,22L,24L,26L,29L,32L,33L,37L,38L,41L,45L,46L,49L,51L,54L,56L,59L,61L,64L,67L,69L,72L,74L,77L,79L,82L,85L,87L,90L,91L,95L,97L,99L,102L,104L,107L,110L,112L,114L,118L,119L,122L,124L,127L,130L,132L,135L,137L,140L,142L,145L,147L,150L,153L,155L,157L,160L,163L,164L,168L,171L,172L,176L,177L,180L,183L,185L,187L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190373Inst : IEnumerable<long>
{
public static readonly long[] Value=A190373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190373.Bytes);
public long this[int i]=>Value[i];

public static A190373Inst Instance=new A190373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190374
{
public static readonly long[] Value={ 3L,8L,12L,17L,21L,25L,30L,34L,39L,44L,48L,53L,58L,62L,66L,70L,75L,80L,84L,89L,93L,98L,103L,106L,111L,116L,120L,125L,129L,134L,139L,143L,148L,152L,156L,161L,165L,170L,175L,179L,184L,188L,192L,197L,201L,206L,211L,215L,220L,224L,229L,234L,237L,242L,246L,251L,256L,260L,265L,270L,274L,278L,282L,287L,292L,296L,301L,306L,310L,315L,319L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190374Inst : IEnumerable<long>
{
public static readonly long[] Value=A190374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190374.Bytes);
public long this[int i]=>Value[i];

public static A190374Inst Instance=new A190374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190375
{
public static readonly long[] Value={ 2L,7L,10L,15L,19L,23L,27L,31L,36L,40L,43L,47L,52L,55L,60L,63L,68L,73L,76L,81L,83L,88L,92L,96L,100L,105L,109L,113L,117L,121L,126L,128L,133L,138L,141L,146L,149L,154L,158L,162L,166L,169L,174L,178L,182L,186L,191L,194L,199L,202L,207L,212L,214L,219L,222L,227L,231L,235L,239L,244L,248L,252L,255L,259L,264L,267L,272L,277L,280L,285L,288L,293L,297L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190375Inst : IEnumerable<long>
{
public static readonly long[] Value=A190375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190375.Bytes);
public long this[int i]=>Value[i];

public static A190375Inst Instance=new A190375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190376
{
public static readonly long[] Value={ 1L,4L,12L,31L,75L,175L,393L,864L,1868L,3978L,8394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190376Inst : IEnumerable<long>
{
public static readonly long[] Value=A190376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190376.Bytes);
public long this[int i]=>Value[i];

public static A190376Inst Instance=new A190376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190377
{
public static readonly long[] Value={ 44100L,108900L,152100L,213444L,260100L,298116L,324900L,476100L,509796L,592900L,636804L,736164L,756900L,828100L,864900L,933156L,1232100L,1258884L,1334025L,1416100L,1483524L,1512900L,1572516L,1664100L,1695204L,1758276L,1768900L,1863225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190377Inst : IEnumerable<long>
{
public static readonly long[] Value=A190377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190377.Bytes);
public long this[int i]=>Value[i];

public static A190377Inst Instance=new A190377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190378
{
public static readonly long[] Value={ 120120L,157080L,175560L,185640L,207480L,212520L,251160L,267960L,270270L,271320L,286440L,291720L,316680L,326040L,328440L,338520L,341880L,353430L,367080L,378840L,394680L,395010L,397320L,404040L,408408L,414120L,417690L,426360L,434280L,442680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190378Inst : IEnumerable<long>
{
public static readonly long[] Value=A190378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190378.Bytes);
public long this[int i]=>Value[i];

public static A190378Inst Instance=new A190378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190379
{
public static readonly long[] Value={ 69300L,81900L,97020L,107100L,114660L,119700L,128700L,144900L,149940L,152460L,161700L,167580L,168300L,182700L,188100L,191100L,195300L,198900L,202860L,212940L,222300L,227700L,233100L,242550L,249900L,252252L,254100L,255780L,258300L,269100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190379Inst : IEnumerable<long>
{
public static readonly long[] Value=A190379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190379.Bytes);
public long this[int i]=>Value[i];

public static A190379Inst Instance=new A190379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190428
{
public static readonly long[] Value={ 5L,10L,13L,18L,26L,31L,34L,39L,47L,52L,60L,65L,68L,73L,81L,86L,89L,94L,99L,102L,107L,115L,120L,123L,128L,136L,141L,149L,154L,157L,162L,170L,175L,178L,183L,188L,191L,196L,204L,209L,212L,217L,225L,230L,233L,238L,243L,246L,251L,259L,264L,267L,272L,280L,285L,293L,298L,301L,306L,314L,319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190428Inst : IEnumerable<long>
{
public static readonly long[] Value=A190428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190428.Bytes);
public long this[int i]=>Value[i];

public static A190428Inst Instance=new A190428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190429
{
public static readonly long[] Value={ 1L,2L,4L,7L,9L,12L,14L,15L,17L,20L,22L,23L,25L,27L,28L,30L,33L,35L,36L,38L,41L,43L,44L,46L,48L,49L,51L,54L,56L,57L,59L,62L,64L,67L,69L,70L,72L,75L,77L,78L,80L,82L,83L,85L,88L,90L,91L,93L,96L,98L,101L,103L,104L,106L,109L,111L,112L,114L,117L,119L,122L,124L,125L,127L,130L,132L,133L,135L,137L,138L,140L,143L,145L,146L,148L,151L,153L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190429Inst : IEnumerable<long>
{
public static readonly long[] Value=A190429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190429.Bytes);
public long this[int i]=>Value[i];

public static A190429Inst Instance=new A190429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190430
{
public static readonly long[] Value={ 3L,6L,8L,11L,16L,19L,21L,24L,29L,32L,37L,40L,42L,45L,50L,53L,55L,58L,61L,63L,66L,71L,74L,76L,79L,84L,87L,92L,95L,97L,100L,105L,108L,110L,113L,116L,118L,121L,126L,129L,131L,134L,139L,142L,144L,147L,150L,152L,155L,160L,163L,165L,168L,173L,176L,181L,184L,186L,189L,194L,197L,199L,202L,205L,207L,210L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190430Inst : IEnumerable<long>
{
public static readonly long[] Value=A190430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190430.Bytes);
public long this[int i]=>Value[i];

public static A190430Inst Instance=new A190430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190431
{
public static readonly long[] Value={ 2L,1L,3L,2L,0L,2L,1L,3L,2L,1L,3L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,1L,3L,1L,0L,2L,1L,3L,2L,1L,2L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,1L,3L,1L,0L,2L,1L,3L,2L,1L,2L,1L,3L,2L,1L,3L,2L,0L,2L,1L,3L,2L,1L,2L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,1L,3L,1L,0L,2L,1L,3L,2L,1L,2L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,1L,3L,1L,0L,2L,1L,3L,2L,1L,2L,1L,3L,2L,1L,3L,1L,0L,2L,1L,3L,2L,1L,2L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,1L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190431Inst : IEnumerable<long>
{
public static readonly long[] Value=A190431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190431.Bytes);
public long this[int i]=>Value[i];

public static A190431Inst Instance=new A190431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190432
{
public static readonly long[] Value={ 5L,13L,18L,26L,34L,39L,47L,60L,68L,73L,81L,89L,94L,102L,115L,123L,128L,136L,149L,157L,162L,170L,178L,183L,191L,204L,212L,217L,225L,233L,238L,246L,251L,259L,267L,272L,280L,293L,301L,306L,314L,322L,327L,335L,348L,356L,361L,369L,382L,390L,395L,403L,411L,416L,424L,437L,445L,450L,458L,466L,471L,479L,492L,500L,505L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190432Inst : IEnumerable<long>
{
public static readonly long[] Value=A190432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190432.Bytes);
public long this[int i]=>Value[i];

public static A190432Inst Instance=new A190432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190433
{
public static readonly long[] Value={ 2L,7L,10L,12L,15L,20L,23L,25L,28L,31L,33L,36L,41L,44L,46L,49L,52L,54L,57L,62L,65L,67L,70L,75L,78L,80L,83L,86L,88L,91L,96L,99L,101L,104L,107L,109L,112L,114L,117L,120L,122L,125L,130L,133L,135L,138L,141L,143L,146L,151L,154L,156L,159L,164L,167L,169L,172L,175L,177L,180L,185L,188L,190L,193L,196L,198L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190433Inst : IEnumerable<long>
{
public static readonly long[] Value=A190433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190433.Bytes);
public long this[int i]=>Value[i];

public static A190433Inst Instance=new A190433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190434
{
public static readonly long[] Value={ 1L,4L,6L,9L,14L,17L,19L,22L,27L,30L,32L,35L,38L,40L,43L,48L,51L,53L,56L,59L,61L,64L,66L,69L,72L,74L,77L,82L,85L,87L,90L,93L,95L,98L,103L,106L,108L,111L,116L,119L,121L,124L,127L,129L,132L,137L,140L,142L,145L,148L,150L,153L,158L,161L,163L,166L,171L,174L,176L,179L,182L,184L,187L,192L,195L,197L,200L,203L,205L,208L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190434Inst : IEnumerable<long>
{
public static readonly long[] Value=A190434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190434.Bytes);
public long this[int i]=>Value[i];

public static A190434Inst Instance=new A190434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190435
{
public static readonly long[] Value={ 3L,8L,11L,16L,21L,24L,29L,37L,42L,45L,50L,55L,58L,63L,71L,76L,79L,84L,92L,97L,100L,105L,110L,113L,118L,126L,131L,134L,139L,144L,147L,152L,155L,160L,165L,168L,173L,181L,186L,189L,194L,199L,202L,207L,215L,220L,223L,228L,236L,241L,244L,249L,254L,257L,262L,270L,275L,278L,283L,288L,291L,296L,304L,309L,312L,317L,325L,330L,333L,338L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190435Inst : IEnumerable<long>
{
public static readonly long[] Value=A190435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190435.Bytes);
public long this[int i]=>Value[i];

public static A190435Inst Instance=new A190435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190436
{
public static readonly long[] Value={ 2L,0L,2L,1L,0L,2L,1L,3L,1L,0L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,3L,2L,0L,2L,1L,0L,2L,1L,3L,1L,0L,2L,1L,0L,2L,0L,2L,1L,0L,2L,1L,3L,1L,0L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,3L,2L,0L,2L,1L,0L,2L,1L,3L,1L,0L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,3L,2L,0L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,0L,2L,0L,2L,1L,0L,2L,1L,3L,1L,0L,2L,1L,0L,2L,1L,2L,1L,0L,2L,1L,3L,2L,0L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190436Inst : IEnumerable<long>
{
public static readonly long[] Value=A190436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190436.Bytes);
public long this[int i]=>Value[i];

public static A190436Inst Instance=new A190436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190437
{
public static readonly long[] Value={ 2L,5L,10L,13L,18L,23L,26L,31L,34L,36L,39L,44L,47L,52L,57L,60L,65L,68L,73L,78L,81L,86L,89L,91L,94L,99L,102L,107L,112L,115L,120L,123L,125L,128L,133L,136L,141L,146L,149L,154L,157L,162L,167L,170L,175L,178L,180L,183L,188L,191L,196L,201L,204L,209L,212L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190437Inst : IEnumerable<long>
{
public static readonly long[] Value=A190437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190437.Bytes);
public long this[int i]=>Value[i];

public static A190437Inst Instance=new A190437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190438
{
public static readonly long[] Value={ 4L,7L,9L,12L,15L,17L,20L,25L,28L,30L,33L,38L,41L,43L,46L,49L,51L,54L,59L,62L,64L,67L,70L,72L,75L,80L,83L,85L,88L,93L,96L,98L,101L,104L,106L,109L,114L,117L,119L,122L,127L,130L,132L,135L,138L,140L,143L,148L,151L,153L,156L,159L,161L,164L,169L,172L,174L,177L,182L,185L,187L,190L,193L,195L,198L,203L,206L,208L,211L,214L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190438Inst : IEnumerable<long>
{
public static readonly long[] Value=A190438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190438.Bytes);
public long this[int i]=>Value[i];

public static A190438Inst Instance=new A190438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190439
{
public static readonly long[] Value={ 1L,3L,6L,11L,14L,16L,19L,22L,24L,27L,32L,35L,37L,40L,45L,48L,50L,53L,56L,58L,61L,66L,69L,71L,74L,77L,79L,82L,84L,87L,90L,92L,95L,100L,103L,105L,108L,111L,113L,116L,121L,124L,126L,129L,134L,137L,139L,142L,145L,147L,150L,155L,158L,160L,163L,166L,168L,171L,173L,176L,179L,181L,184L,189L,192L,194L,197L,200L,202L,205L,210L,213L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190439Inst : IEnumerable<long>
{
public static readonly long[] Value=A190439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190439.Bytes);
public long this[int i]=>Value[i];

public static A190439Inst Instance=new A190439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190440
{
public static readonly long[] Value={ 2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,2L,1L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190440Inst : IEnumerable<long>
{
public static readonly long[] Value=A190440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190440.Bytes);
public long this[int i]=>Value[i];

public static A190440Inst Instance=new A190440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190441
{
public static readonly long[] Value={ 0L,1L,4L,55L,376L,3649L,29260L,259351L,2178544L,18828865L,160278676L,1375440439L,11752630120L,100652697601L,860963365084L,7369308666775L,63054805905376L,539622261625729L,4617626476812580L,39515774110653751L,338150529038305624L,2893717306468718785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190441Inst : IEnumerable<long>
{
public static readonly long[] Value=A190441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190441.Bytes);
public long this[int i]=>Value[i];

public static A190441Inst Instance=new A190441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190442
{
public static readonly long[] Value={ 4L,7L,12L,15L,20L,25L,28L,33L,38L,41L,46L,49L,54L,59L,62L,67L,70L,72L,75L,80L,83L,88L,93L,96L,101L,104L,109L,114L,117L,122L,125L,127L,130L,135L,138L,143L,148L,151L,156L,159L,164L,169L,172L,177L,182L,185L,190L,193L,198L,203L,206L,211L,214L,216L,219L,224L,227L,232L,237L,240L,245L,248L,253L,258L,261L,266L,269L,271L,274L,279L,282L,287L,292L,295L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190442Inst : IEnumerable<long>
{
public static readonly long[] Value=A190442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190442.Bytes);
public long this[int i]=>Value[i];

public static A190442Inst Instance=new A190442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190443
{
public static readonly long[] Value={ 1L,6L,9L,14L,17L,19L,22L,27L,30L,35L,40L,43L,48L,51L,56L,61L,64L,69L,74L,77L,82L,85L,90L,95L,98L,103L,106L,108L,111L,116L,119L,124L,129L,132L,137L,140L,145L,150L,153L,158L,161L,163L,166L,171L,174L,179L,184L,187L,192L,195L,200L,205L,208L,213L,218L,221L,226L,229L,234L,239L,242L,247L,250L,252L,255L,260L,263L,268L,273L,276L,281L,284L,289L,294L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190443Inst : IEnumerable<long>
{
public static readonly long[] Value=A190443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190443.Bytes);
public long this[int i]=>Value[i];

public static A190443Inst Instance=new A190443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190492
{
public static readonly long[] Value={ 5L,10L,17L,22L,27L,29L,34L,39L,46L,51L,58L,63L,68L,75L,80L,87L,92L,97L,99L,104L,109L,116L,121L,126L,128L,133L,138L,145L,150L,157L,162L,167L,169L,174L,179L,186L,191L,196L,198L,203L,208L,215L,220L,227L,232L,237L,244L,249L,256L,261L,266L,268L,273L,278L,285L,290L,295L,297L,302L,307L,314L,319L,326L,331L,336L,338L,343L,348L,355L,360L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190492Inst : IEnumerable<long>
{
public static readonly long[] Value=A190492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190492.Bytes);
public long this[int i]=>Value[i];

public static A190492Inst Instance=new A190492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190493
{
public static readonly long[] Value={ 1L,3L,6L,8L,13L,15L,18L,20L,23L,25L,30L,32L,35L,37L,42L,44L,47L,49L,54L,56L,59L,61L,64L,66L,71L,73L,76L,78L,83L,85L,88L,90L,93L,95L,100L,102L,105L,107L,112L,114L,117L,119L,124L,129L,131L,134L,136L,141L,143L,146L,148L,153L,155L,158L,160L,163L,165L,170L,172L,175L,177L,182L,184L,187L,189L,194L,199L,201L,204L,206L,211L,213L,216L,218L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190493Inst : IEnumerable<long>
{
public static readonly long[] Value=A190493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190493.Bytes);
public long this[int i]=>Value[i];

public static A190493Inst Instance=new A190493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190494
{
public static readonly long[] Value={ 2L,4L,9L,11L,14L,16L,21L,26L,28L,31L,33L,38L,40L,43L,45L,50L,52L,55L,57L,60L,62L,67L,69L,72L,74L,79L,81L,84L,86L,91L,96L,98L,101L,103L,108L,110L,113L,115L,120L,122L,125L,127L,130L,132L,137L,139L,142L,144L,149L,151L,154L,156L,159L,161L,166L,168L,171L,173L,178L,180L,183L,185L,190L,192L,195L,197L,200L,202L,207L,209L,212L,214L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190494Inst : IEnumerable<long>
{
public static readonly long[] Value=A190494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190494.Bytes);
public long this[int i]=>Value[i];

public static A190494Inst Instance=new A190494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190495
{
public static readonly long[] Value={ 7L,12L,19L,24L,36L,41L,48L,53L,65L,70L,77L,82L,89L,94L,106L,111L,118L,123L,135L,140L,147L,152L,164L,176L,181L,188L,193L,205L,210L,217L,222L,234L,239L,246L,251L,258L,263L,275L,280L,287L,292L,304L,309L,316L,321L,328L,333L,345L,350L,357L,362L,374L,379L,386L,391L,403L,408L,415L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190495Inst : IEnumerable<long>
{
public static readonly long[] Value=A190495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190495.Bytes);
public long this[int i]=>Value[i];

public static A190495Inst Instance=new A190495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190496
{
public static readonly long[] Value={ 2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190496Inst : IEnumerable<long>
{
public static readonly long[] Value=A190496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190496.Bytes);
public long this[int i]=>Value[i];

public static A190496Inst Instance=new A190496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190497
{
public static readonly long[] Value={ 17L,29L,46L,58L,87L,99L,116L,128L,157L,169L,186L,198L,215L,227L,256L,268L,285L,297L,326L,338L,355L,367L,396L,425L,437L,454L,466L,495L,507L,524L,536L,565L,577L,594L,606L,623L,635L,664L,676L,693L,705L,734L,746L,763L,775L,792L,804L,833L,845L,862L,874L,903L,915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190497Inst : IEnumerable<long>
{
public static readonly long[] Value=A190497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190497.Bytes);
public long this[int i]=>Value[i];

public static A190497Inst Instance=new A190497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190498
{
public static readonly long[] Value={ 3L,5L,8L,10L,13L,15L,20L,22L,25L,27L,32L,34L,37L,39L,44L,49L,51L,54L,56L,61L,63L,66L,68L,73L,75L,78L,80L,83L,85L,90L,92L,95L,97L,102L,104L,107L,109L,114L,119L,121L,124L,126L,131L,133L,136L,138L,143L,145L,148L,150L,153L,155L,160L,162L,165L,167L,172L,174L,177L,179L,182L,184L,189L,191L,194L,196L,201L,203L,206L,208L,213L,218L,220L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190498Inst : IEnumerable<long>
{
public static readonly long[] Value=A190498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190498.Bytes);
public long this[int i]=>Value[i];

public static A190498Inst Instance=new A190498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190499
{
public static readonly long[] Value={ 1L,4L,6L,11L,16L,18L,21L,23L,28L,30L,33L,35L,40L,42L,45L,47L,50L,52L,57L,59L,62L,64L,69L,71L,74L,76L,79L,81L,86L,88L,91L,93L,98L,100L,103L,105L,110L,112L,115L,117L,120L,122L,127L,129L,132L,134L,139L,141L,144L,146L,149L,151L,156L,158L,161L,163L,168L,170L,173L,175L,180L,185L,187L,190L,192L,197L,199L,202L,204L,209L,211L,214L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190499Inst : IEnumerable<long>
{
public static readonly long[] Value=A190499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190499.Bytes);
public long this[int i]=>Value[i];

public static A190499Inst Instance=new A190499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190500
{
public static readonly long[] Value={ 2L,7L,9L,12L,14L,19L,24L,26L,31L,36L,38L,41L,43L,48L,53L,55L,60L,65L,67L,70L,72L,77L,82L,84L,89L,94L,96L,101L,106L,108L,111L,113L,118L,123L,125L,130L,135L,137L,140L,142L,147L,152L,154L,159L,164L,166L,171L,176L,178L,181L,183L,188L,193L,195L,200L,205L,207L,210L,212L,217L,222L,224L,229L,234L,236L,239L,241L,246L,248L,251L,253L,258L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190500Inst : IEnumerable<long>
{
public static readonly long[] Value=A190500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190500.Bytes);
public long this[int i]=>Value[i];

public static A190500Inst Instance=new A190500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190501
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,2L,3L,6L,10L,19L,33L,62L,118L,208L,409L,740L,1418L,2676L,5043L,9638L,18248L,34949L,66752L,127880L,245489L,472113L,908302L,1751624L,3381546L,6534616L,12645372L,24490255L,47485123L,92152929L,178987716L,347943866L,676925069L,1317911597L,2567659990L,5005877954L,9765539069L,19062301793L,37230980158L,72756216207L,142253989491L,278275735952L,544621563320L,1066382258001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190501Inst : IEnumerable<long>
{
public static readonly long[] Value=A190501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190501.Bytes);
public long this[int i]=>Value[i];

public static A190501Inst Instance=new A190501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190502
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,4L,7L,13L,23L,42L,75L,137L,255L,463L,872L,1612L,3030L,5706L,10749L,20387L,38635L,73584L,140336L,268216L,513705L,985818L,1894120L,3645744L,7027290L,13561906L,26207278L,50697533L,98182656L,190335585L,369323301L,717267167L,1394192236L,2712103833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190502Inst : IEnumerable<long>
{
public static readonly long[] Value=A190502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190502.Bytes);
public long this[int i]=>Value[i];

public static A190502Inst Instance=new A190502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190503
{
public static readonly long[] Value={ 1L,2L,6L,12L,14L,22L,24L,28L,44L,46L,48L,56L,68L,87L,88L,92L,94L,96L,112L,118L,166L,174L,176L,184L,188L,192L,214L,224L,236L,332L,334L,352L,358L,362L,368L,376L,384L,390L,410L,428L,448L,454L,472L,526L,664L,668L,694L,704L,716L,718L,736L,752L,766L,768L,856L,896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190503Inst : IEnumerable<long>
{
public static readonly long[] Value=A190503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190503.Bytes);
public long this[int i]=>Value[i];

public static A190503Inst Instance=new A190503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190504
{
public static readonly long[] Value={ 6L,14L,21L,29L,38L,45L,52L,59L,68L,76L,83L,91L,100L,106L,114L,121L,130L,138L,145L,153L,159L,168L,176L,183L,191L,200L,207L,214L,221L,230L,238L,245L,253L,262L,268L,276L,283L,291L,300L,307L,315L,321L,330L,338L,345L,353L,362L,368L,376L,383L,392L,400L,407L,415L,421L,430L,438L,445L,453L,462L,469L,476L,483L,492L,500L,507L,515L,524L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190504Inst : IEnumerable<long>
{
public static readonly long[] Value=A190504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190504.Bytes);
public long this[int i]=>Value[i];

public static A190504Inst Instance=new A190504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190505
{
public static readonly long[] Value={ 3L,8L,13L,18L,22L,27L,32L,37L,41L,46L,51L,56L,60L,65L,70L,75L,79L,84L,89L,94L,99L,103L,108L,113L,118L,122L,127L,132L,137L,141L,146L,151L,156L,160L,165L,170L,175L,180L,184L,189L,194L,199L,203L,208L,213L,218L,222L,227L,232L,237L,241L,246L,251L,256L,261L,265L,270L,275L,280L,284L,289L,294L,299L,303L,308L,313L,318L,322L,327L,332L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190505Inst : IEnumerable<long>
{
public static readonly long[] Value=A190505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190505.Bytes);
public long this[int i]=>Value[i];

public static A190505Inst Instance=new A190505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190506
{
public static readonly long[] Value={ 2L,5L,9L,12L,16L,19L,23L,26L,30L,33L,36L,40L,43L,47L,50L,54L,57L,61L,64L,67L,71L,74L,78L,81L,85L,88L,92L,95L,98L,102L,105L,109L,112L,116L,119L,123L,126L,129L,133L,136L,140L,143L,147L,150L,154L,157L,161L,164L,167L,171L,174L,178L,181L,185L,188L,192L,195L,198L,202L,205L,209L,212L,216L,219L,223L,226L,229L,233L,236L,240L,243L,247L,250L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190506Inst : IEnumerable<long>
{
public static readonly long[] Value=A190506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190506.Bytes);
public long this[int i]=>Value[i];

public static A190506Inst Instance=new A190506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190507
{
public static readonly long[] Value={ 1L,4L,7L,10L,11L,15L,17L,20L,24L,25L,28L,31L,34L,35L,39L,42L,44L,48L,49L,53L,55L,58L,62L,63L,66L,69L,72L,73L,77L,80L,82L,86L,87L,90L,93L,96L,97L,101L,104L,107L,110L,111L,115L,117L,120L,124L,125L,128L,131L,134L,135L,139L,142L,144L,148L,149L,152L,155L,158L,162L,163L,166L,169L,172L,173L,177L,179L,182L,186L,187L,190L,193L,196L,197L,201L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190507Inst : IEnumerable<long>
{
public static readonly long[] Value=A190507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190507.Bytes);
public long this[int i]=>Value[i];

public static A190507Inst Instance=new A190507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190540
{
public static readonly long[] Value={ 0L,5L,45L,335L,2385L,16775L,117585L,823415L,5764545L,40353095L,282474225L,1977324695L,13841283105L,96889002215L,678223056465L,4747561477175L,33232930504065L,232630513856135L,1628413597648305L,11398895184848855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190540Inst : IEnumerable<long>
{
public static readonly long[] Value=A190540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190540.Bytes);
public long this[int i]=>Value[i];

public static A190540Inst Instance=new A190540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190541
{
public static readonly long[] Value={ 0L,4L,40L,316L,2320L,16564L,116920L,821356L,5758240L,40333924L,282416200L,1977149596L,13840755760L,96887416084L,678218289880L,4747547161036L,33232887522880L,232630384847044L,1628413210489960L,11398894023111676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190541Inst : IEnumerable<long>
{
public static readonly long[] Value=A190541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190541.Bytes);
public long this[int i]=>Value[i];

public static A190541Inst Instance=new A190541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190542
{
public static readonly long[] Value={ 0L,3L,33L,279L,2145L,15783L,113553L,807159L,5699265L,40091463L,281426673L,1973132439L,13824509985L,96821901543L,677954637393L,4746487768119L,33228635602305L,232613334118023L,1628344878433713L,11398620307466199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190542Inst : IEnumerable<long>
{
public static readonly long[] Value=A190542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190542.Bytes);
public long this[int i]=>Value[i];

public static A190542Inst Instance=new A190542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190543
{
public static readonly long[] Value={ 0L,5L,55L,485L,4015L,32525L,261415L,2094965L,16770655L,134198045L,1073682775L,8589757445L,68718945295L,549754219565L,4398041728135L,35184357739925L,281474933663935L,2251799684545085L,18014398122061495L,144115186913594405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190543Inst : IEnumerable<long>
{
public static readonly long[] Value=A190543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190543.Bytes);
public long this[int i]=>Value[i];

public static A190543Inst Instance=new A190543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190544
{
public static readonly long[] Value={ 1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190544Inst : IEnumerable<long>
{
public static readonly long[] Value=A190544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190544.Bytes);
public long this[int i]=>Value[i];

public static A190544Inst Instance=new A190544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190545
{
public static readonly long[] Value={ 3L,5L,10L,15L,17L,22L,27L,29L,34L,39L,44L,46L,51L,56L,58L,63L,68L,73L,75L,80L,85L,87L,92L,97L,99L,102L,104L,109L,114L,116L,121L,126L,128L,133L,138L,143L,145L,150L,155L,157L,162L,167L,169L,172L,174L,179L,184L,186L,191L,196L,198L,203L,208L,213L,215L,220L,225L,227L,232L,237L,242L,244L,249L,254L,256L,261L,266L,268L,273L,278L,283L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190545Inst : IEnumerable<long>
{
public static readonly long[] Value=A190545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190545.Bytes);
public long this[int i]=>Value[i];

public static A190545Inst Instance=new A190545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190546
{
public static readonly long[] Value={ 1L,6L,8L,13L,18L,20L,25L,30L,32L,35L,37L,42L,47L,49L,54L,59L,61L,66L,71L,76L,78L,83L,88L,90L,95L,100L,105L,107L,112L,117L,119L,124L,129L,131L,136L,141L,146L,148L,153L,158L,160L,165L,170L,175L,177L,182L,187L,189L,194L,199L,201L,204L,206L,211L,216L,218L,223L,228L,230L,235L,240L,245L,247L,252L,257L,259L,264L,269L,271L,274L,276L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190546Inst : IEnumerable<long>
{
public static readonly long[] Value=A190546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190546.Bytes);
public long this[int i]=>Value[i];

public static A190546Inst Instance=new A190546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190547
{
public static readonly long[] Value={ 4L,9L,11L,16L,21L,23L,28L,33L,38L,40L,45L,50L,52L,57L,62L,64L,69L,74L,79L,81L,86L,91L,93L,98L,103L,108L,110L,115L,120L,122L,127L,132L,134L,137L,139L,144L,149L,151L,156L,161L,163L,168L,173L,178L,180L,185L,190L,192L,197L,202L,207L,209L,214L,219L,221L,226L,231L,233L,238L,243L,248L,250L,255L,260L,262L,267L,272L,277L,279L,284L,289L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190547Inst : IEnumerable<long>
{
public static readonly long[] Value=A190547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190547.Bytes);
public long this[int i]=>Value[i];

public static A190547Inst Instance=new A190547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190548
{
public static readonly long[] Value={ 2L,7L,12L,14L,19L,24L,26L,31L,36L,41L,43L,48L,53L,55L,60L,65L,67L,70L,72L,77L,82L,84L,89L,94L,96L,101L,106L,111L,113L,118L,123L,125L,130L,135L,140L,142L,147L,152L,154L,159L,164L,166L,171L,176L,181L,183L,188L,193L,195L,200L,205L,210L,212L,217L,222L,224L,229L,234L,236L,239L,241L,246L,251L,253L,258L,263L,265L,270L,275L,280L,282L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190548Inst : IEnumerable<long>
{
public static readonly long[] Value=A190548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190548.Bytes);
public long this[int i]=>Value[i];

public static A190548Inst Instance=new A190548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190549
{
public static readonly long[] Value={ 2L,3L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190549Inst : IEnumerable<long>
{
public static readonly long[] Value=A190549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190549.Bytes);
public long this[int i]=>Value[i];

public static A190549Inst Instance=new A190549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190550
{
public static readonly long[] Value={ 5L,10L,17L,22L,29L,34L,46L,51L,58L,63L,75L,80L,87L,92L,99L,104L,116L,121L,128L,133L,145L,150L,157L,162L,169L,174L,179L,186L,191L,198L,203L,215L,220L,227L,232L,244L,249L,256L,261L,268L,273L,285L,290L,297L,302L,314L,319L,326L,331L,338L,343L,348L,355L,360L,367L,372L,384L,389L,396L,401L,413L,418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190550Inst : IEnumerable<long>
{
public static readonly long[] Value=A190550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190550.Bytes);
public long this[int i]=>Value[i];

public static A190550Inst Instance=new A190550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190551
{
public static readonly long[] Value={ 3L,8L,13L,15L,20L,25L,27L,32L,37L,39L,44L,49L,54L,56L,61L,66L,68L,73L,78L,83L,85L,90L,95L,97L,102L,107L,109L,112L,114L,119L,124L,126L,131L,136L,138L,143L,148L,153L,155L,160L,165L,167L,172L,177L,182L,184L,189L,194L,196L,201L,206L,208L,213L,218L,223L,225L,230L,235L,237L,242L,247L,252L,254L,259L,264L,266L,271L,276L,278L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190551Inst : IEnumerable<long>
{
public static readonly long[] Value=A190551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190551.Bytes);
public long this[int i]=>Value[i];

public static A190551Inst Instance=new A190551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190552
{
public static readonly long[] Value={ 1L,6L,11L,16L,18L,23L,28L,30L,35L,40L,42L,45L,47L,52L,57L,59L,64L,69L,71L,76L,81L,86L,88L,93L,98L,100L,105L,110L,115L,117L,122L,127L,129L,134L,139L,141L,146L,151L,156L,158L,163L,168L,170L,175L,180L,185L,187L,192L,197L,199L,204L,209L,211L,214L,216L,221L,226L,228L,233L,238L,240L,245L,250L,255L,257L,262L,267L,269L,274L,279L,284L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190552Inst : IEnumerable<long>
{
public static readonly long[] Value=A190552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190552.Bytes);
public long this[int i]=>Value[i];

public static A190552Inst Instance=new A190552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190553
{
public static readonly long[] Value={ 2L,4L,9L,14L,19L,21L,26L,31L,33L,38L,43L,48L,50L,55L,60L,62L,67L,72L,74L,77L,79L,84L,89L,91L,96L,101L,103L,108L,113L,118L,120L,125L,130L,132L,137L,142L,144L,147L,149L,154L,159L,161L,166L,171L,173L,178L,183L,188L,190L,195L,200L,202L,207L,212L,217L,219L,224L,229L,231L,236L,241L,243L,248L,253L,258L,260L,265L,270L,272L,277L,282L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190553Inst : IEnumerable<long>
{
public static readonly long[] Value=A190553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190553.Bytes);
public long this[int i]=>Value[i];

public static A190553Inst Instance=new A190553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190554
{
public static readonly long[] Value={ 7L,12L,24L,36L,41L,53L,65L,70L,82L,94L,106L,111L,123L,135L,140L,152L,164L,176L,181L,193L,205L,210L,222L,234L,239L,246L,251L,263L,275L,280L,292L,304L,309L,321L,333L,345L,350L,362L,374L,379L,391L,403L,408L,415L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190554Inst : IEnumerable<long>
{
public static readonly long[] Value=A190554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190554.Bytes);
public long this[int i]=>Value[i];

public static A190554Inst Instance=new A190554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190555
{
public static readonly long[] Value={ 2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,2L,4L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,1L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190555Inst : IEnumerable<long>
{
public static readonly long[] Value=A190555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190555.Bytes);
public long this[int i]=>Value[i];

public static A190555Inst Instance=new A190555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190604
{
public static readonly BigInteger[] Value={ 56L,672L,14112L,522144L,33939360L,3869087040L,773817408000L,271609910208000L,167311704688128000L,BigInteger.Parse("180863952767866368000"),BigInteger.Parse("343098918400642500096000"),BigInteger.Parse("1142176299355738882819584000"),BigInteger.Parse("6672593940836226553432009728000") };
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
public class A190604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190604Inst Instance=new A190604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190605
{
public static readonly BigInteger[] Value={ 44L,392L,5328L,119883L,4524432L,264917871L,24691633610L,3695710760736L,889996573057683L,344208553873787552L,BigInteger.Parse("212232817711368447264"),BigInteger.Parse("209378526541030232270145"),BigInteger.Parse("331234853208637544240698701") };
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
public class A190605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190605Inst Instance=new A190605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190606
{
public static readonly BigInteger[] Value={ 39L,240L,2271L,35661L,836514L,27940563L,1374170474L,102369944843L,11464683896495L,1905358977494462L,469934471799881606L,BigInteger.Parse("172863979596481949179"),BigInteger.Parse("94947989820190085424440") };
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
public class A190606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190606Inst Instance=new A190606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190607
{
public static readonly BigInteger[] Value={ 34L,168L,1135L,12814L,224705L,5127157L,154820497L,6857389175L,450847078335L,41610167180266L,5282145722452860L,946058243422221058L,BigInteger.Parse("244167133066656271715"),BigInteger.Parse("89943772503552797451562") };
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
public class A190607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190607Inst Instance=new A190607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190608
{
public static readonly long[] Value={ 1L,1L,0L,0L,-2L,0L,0L,0L,-4L,0L,4L,0L,0L,0L,0L,0L,-8L,0L,8L,0L,8L,0L,-8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-16L,0L,16L,0L,16L,0L,-16L,0L,16L,0L,-16L,0L,-16L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-32L,0L,32L,0L,32L,0L,-32L,0L,32L,0L,-32L,0L,-32L,0L,32L,0L,32L,0L,-32L,0L,-32L,0L,32L,0L,-32L,0L,32L,0L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190608Inst : IEnumerable<long>
{
public static readonly long[] Value=A190608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190608.Bytes);
public long this[int i]=>Value[i];

public static A190608Inst Instance=new A190608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190609
{
public static readonly long[] Value={ 1L,1L,0L,0L,-3L,0L,0L,0L,-9L,0L,9L,0L,0L,0L,0L,0L,-27L,0L,27L,0L,27L,0L,-27L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-81L,0L,81L,0L,81L,0L,-81L,0L,81L,0L,-81L,0L,-81L,0L,81L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-243L,0L,243L,0L,243L,0L,-243L,0L,243L,0L,-243L,0L,-243L,0L,243L,0L,243L,0L,-243L,0L,-243L,0L,243L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190609Inst : IEnumerable<long>
{
public static readonly long[] Value=A190609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190609.Bytes);
public long this[int i]=>Value[i];

public static A190609Inst Instance=new A190609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190610
{
public static readonly long[] Value={ 1L,1L,0L,0L,-1L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190610Inst : IEnumerable<long>
{
public static readonly long[] Value=A190610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190610.Bytes);
public long this[int i]=>Value[i];

public static A190610Inst Instance=new A190610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190611
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,-2L,1L,-2L,1L,-1L,2L,-2L,1L,0L,2L,-2L,1L,0L,1L,0L,2L,-2L,2L,0L,1L,-3L,0L,-1L,2L,-2L,2L,-2L,1L,-2L,0L,-4L,1L,0L,0L,0L,2L,0L,2L,0L,2L,-2L,0L,0L,1L,-3L,3L,0L,0L,-2L,1L,-4L,2L,0L,2L,-2L,2L,0L,2L,-2L,1L,0L,2L,0L,0L,0L,4L,0L,1L,-2L,0L,-3L,0L,-4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190611Inst : IEnumerable<long>
{
public static readonly long[] Value=A190611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190611.Bytes);
public long this[int i]=>Value[i];

public static A190611Inst Instance=new A190611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190612
{
public static readonly long[] Value={ 6L,7L,11L,13L,19L,20L,23L,25L,28L,29L,31L,32L,34L,39L,41L,43L,46L,47L,51L,52L,53L,55L,56L,57L,59L,61L,62L,67L,68L,71L,73L,74L,79L,83L,85L,86L,87L,89L,94L,95L,97L,103L,107L,109L,113L,119L,127L,129L,131L,133L,134L,137L,139L,141L,142L,149L,151L,152L,155L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190612Inst : IEnumerable<long>
{
public static readonly long[] Value=A190612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190612.Bytes);
public long this[int i]=>Value[i];

public static A190612Inst Instance=new A190612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190613
{
public static readonly long[] Value={ 0L,1L,1L,5L,4L,6L,2L,12L,12L,11L,1L,21L,17L,9L,7L,37L,18L,16L,10L,28L,30L,30L,-6L,52L,48L,11L,17L,59L,19L,39L,9L,53L,65L,27L,9L,83L,44L,30L,10L,98L,54L,28L,36L,50L,68L,82L,-34L,128L,98L,13L,49L,91L,47L,59L,21L,119L,85L,71L,-11L,129L,107L,15L,49L,153L,92L,72L,24L,110L,68L,120L,-24L,166L,166L,-20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190613Inst : IEnumerable<long>
{
public static readonly long[] Value=A190613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190613.Bytes);
public long this[int i]=>Value[i];

public static A190613Inst Instance=new A190613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190614
{
public static readonly long[] Value={ 22L,46L,58L,70L,73L,78L,94L,106L,118L,126L,142L,145L,154L,166L,178L,190L,193L,214L,238L,241L,250L,262L,278L,286L,289L,298L,310L,313L,318L,334L,337L,346L,358L,361L,382L,406L,414L,418L,421L,430L,433L,438L,442L,446L,466L,478L,481L,498L,502L,505L,526L,538L,550L,558L,570L,574L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190614Inst : IEnumerable<long>
{
public static readonly long[] Value=A190614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190614.Bytes);
public long this[int i]=>Value[i];

public static A190614Inst Instance=new A190614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190615
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,1L,-2L,0L,-2L,0L,0L,2L,0L,3L,-1L,2L,-2L,2L,-4L,0L,0L,0L,0L,2L,0L,3L,0L,2L,-4L,0L,-2L,0L,-2L,0L,0L,0L,0L,2L,-3L,4L,-2L,1L,-2L,0L,-2L,0L,0L,2L,0L,2L,-2L,2L,-2L,4L,-2L,0L,0L,0L,0L,0L,0L,3L,0L,4L,-2L,0L,-2L,0L,-2L,0L,0L,0L,0L,4L,-3L,2L,-2L,0L,-4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190615Inst : IEnumerable<long>
{
public static readonly long[] Value=A190615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190615.Bytes);
public long this[int i]=>Value[i];

public static A190615Inst Instance=new A190615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190616
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,1L,0L,3L,8L,3L,16L,5L,16L,15L,0L,17L,48L,27L,128L,63L,192L,89L,0L,205L,637L,171L,1011L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190616Inst : IEnumerable<long>
{
public static readonly long[] Value=A190616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190616.Bytes);
public long this[int i]=>Value[i];

public static A190616Inst Instance=new A190616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190617
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,3L,0L,19L,13L,13L,2L,11L,0L,3L,0L,7L,3L,2L,0L,0L,3L,0L,2L,0L,7L,2L,0L,0L,7L,2L,0L,0L,5L,13L,17L,5L,0L,29L,73L,53L,0L,41L,17L,0L,61L,113L,67L,0L,23L,7L,31L,53L,3L,0L,0L,109L,13L,43L,101L,67L,113L,0L,181L,37L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190617Inst : IEnumerable<long>
{
public static readonly long[] Value=A190617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190617.Bytes);
public long this[int i]=>Value[i];

public static A190617Inst Instance=new A190617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190618
{
public static readonly long[] Value={ 5L,13L,25L,29L,34L,35L,36L,41L,52L,60L,65L,76L,81L,88L,93L,94L,95L,100L,111L,123L,128L,147L,152L,167L,172L,183L,188L,195L,200L,201L,202L,207L,218L,222L,227L,228L,229L,234L,245L,250L,261L,266L,267L,268L,273L,274L,275L,280L,281L,282L,287L,298L,303L,314L,319L,320L,321L,326L,337L,342L,361L,366L,381L,386L,397L,402L,409L,414L,415L,416L,421L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190618Inst : IEnumerable<long>
{
public static readonly long[] Value=A190618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190618.Bytes);
public long this[int i]=>Value[i];

public static A190618Inst Instance=new A190618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190619
{
public static readonly long[] Value={ 101L,1011L,1101L,10111L,11011L,11101L,101111L,110111L,111011L,111101L,1011111L,1101111L,1110111L,1111011L,1111101L,10111111L,11011111L,11101111L,11110111L,11111011L,11111101L,101111111L,110111111L,111011111L,111101111L,111110111L,111111011L,111111101L,1011111111L,1101111111L,1110111111L,1111011111L,1111101111L,1111110111L,1111111011L,1111111101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190619Inst : IEnumerable<long>
{
public static readonly long[] Value=A190619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190619.Bytes);
public long this[int i]=>Value[i];

public static A190619Inst Instance=new A190619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190684
{
public static readonly long[] Value={ 11L,26L,37L,41L,52L,67L,82L,93L,97L,108L,123L,138L,149L,153L,164L,179L,194L,205L,220L,235L,246L,250L,261L,276L,291L,302L,306L,317L,332L,347L,358L,362L,373L,388L,399L,403L,414L,429L,444L,455L,459L,470L,485L,500L,511L,515L,526L,541L,556L,567L,571L,582L,597L,608L,612L,623L,638L,653L,664L,668L,679L,694L,709L,720L,724L,735L,750L,765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190684Inst : IEnumerable<long>
{
public static readonly long[] Value=A190684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190684.Bytes);
public long this[int i]=>Value[i];

public static A190684Inst Instance=new A190684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190685
{
public static readonly long[] Value={ 3L,6L,7L,10L,14L,18L,21L,22L,25L,29L,33L,36L,40L,44L,47L,48L,51L,55L,59L,62L,63L,66L,70L,74L,77L,78L,81L,85L,88L,89L,92L,96L,100L,103L,104L,107L,111L,115L,118L,119L,122L,126L,130L,133L,134L,137L,141L,144L,145L,148L,152L,156L,159L,160L,163L,167L,171L,174L,175L,178L,182L,186L,189L,190L,193L,197L,200L,201L,204L,208L,212L,215L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190685Inst : IEnumerable<long>
{
public static readonly long[] Value=A190685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190685.Bytes);
public long this[int i]=>Value[i];

public static A190685Inst Instance=new A190685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190686
{
public static readonly long[] Value={ 1L,2L,5L,9L,13L,16L,17L,20L,24L,28L,31L,32L,35L,39L,42L,43L,46L,50L,54L,57L,58L,61L,65L,69L,72L,73L,76L,80L,84L,87L,91L,95L,98L,99L,102L,106L,110L,113L,114L,117L,121L,125L,128L,129L,132L,136L,139L,140L,143L,147L,151L,154L,155L,158L,162L,166L,169L,170L,173L,177L,181L,184L,185L,188L,192L,195L,196L,199L,203L,207L,210L,211L,214L,218L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190686Inst : IEnumerable<long>
{
public static readonly long[] Value=A190686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190686.Bytes);
public long this[int i]=>Value[i];

public static A190686Inst Instance=new A190686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190687
{
public static readonly long[] Value={ 4L,8L,12L,15L,19L,23L,27L,30L,34L,38L,45L,49L,53L,56L,60L,64L,68L,71L,75L,79L,83L,86L,90L,94L,101L,105L,109L,112L,116L,120L,124L,127L,131L,135L,142L,146L,150L,157L,161L,165L,168L,172L,176L,180L,183L,187L,191L,198L,202L,206L,209L,213L,217L,221L,224L,228L,232L,236L,239L,243L,247L,254L,258L,262L,265L,269L,273L,277L,280L,284L,288L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190687Inst : IEnumerable<long>
{
public static readonly long[] Value=A190687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190687.Bytes);
public long this[int i]=>Value[i];

public static A190687Inst Instance=new A190687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190688
{
public static readonly long[] Value={ 2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190688Inst : IEnumerable<long>
{
public static readonly long[] Value=A190688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190688.Bytes);
public long this[int i]=>Value[i];

public static A190688Inst Instance=new A190688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190689
{
public static readonly long[] Value={ 7L,11L,18L,22L,26L,33L,37L,41L,48L,52L,63L,67L,74L,78L,82L,89L,93L,97L,104L,108L,119L,123L,130L,134L,138L,145L,149L,153L,160L,164L,175L,179L,186L,190L,194L,201L,205L,216L,220L,227L,231L,235L,242L,246L,250L,257L,261L,272L,276L,283L,287L,291L,298L,302L,306L,313L,317L,328L,332L,339L,343L,347L,354L,358L,362L,369L,373L,384L,388L,395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190689Inst : IEnumerable<long>
{
public static readonly long[] Value=A190689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190689.Bytes);
public long this[int i]=>Value[i];

public static A190689Inst Instance=new A190689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190690
{
public static readonly long[] Value={ 2L,3L,6L,10L,14L,17L,21L,25L,28L,29L,32L,36L,40L,43L,44L,47L,51L,55L,58L,59L,62L,66L,69L,70L,73L,77L,81L,84L,85L,88L,92L,96L,99L,100L,103L,107L,111L,114L,115L,118L,122L,125L,126L,129L,133L,137L,140L,141L,144L,148L,152L,155L,156L,159L,163L,167L,170L,171L,174L,178L,181L,182L,185L,189L,193L,196L,197L,200L,204L,208L,211L,212L,215L,219L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190690Inst : IEnumerable<long>
{
public static readonly long[] Value=A190690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190690.Bytes);
public long this[int i]=>Value[i];

public static A190690Inst Instance=new A190690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190691
{
public static readonly long[] Value={ 1L,5L,9L,12L,13L,16L,20L,23L,24L,27L,31L,35L,38L,39L,42L,46L,50L,53L,54L,57L,61L,65L,68L,72L,76L,79L,80L,83L,87L,91L,94L,95L,98L,102L,106L,109L,110L,113L,117L,121L,124L,128L,132L,135L,136L,139L,143L,147L,150L,151L,154L,158L,162L,165L,166L,169L,173L,176L,177L,180L,184L,188L,191L,192L,195L,199L,203L,206L,207L,210L,214L,218L,221L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190691Inst : IEnumerable<long>
{
public static readonly long[] Value=A190691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190691.Bytes);
public long this[int i]=>Value[i];

public static A190691Inst Instance=new A190691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190692
{
public static readonly long[] Value={ 4L,8L,15L,19L,30L,34L,45L,49L,56L,60L,64L,71L,75L,86L,90L,101L,105L,112L,116L,120L,127L,131L,142L,146L,157L,161L,168L,172L,183L,187L,198L,202L,209L,213L,217L,224L,228L,239L,243L,254L,258L,265L,269L,273L,280L,284L,295L,299L,310L,314L,321L,325L,336L,340L,351L,355L,366L,370L,377L,381L,392L,396L,407L,411L,418L,422L,426L,433L,437L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190692Inst : IEnumerable<long>
{
public static readonly long[] Value=A190692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190692.Bytes);
public long this[int i]=>Value[i];

public static A190692Inst Instance=new A190692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190693
{
public static readonly long[] Value={ 2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,0L,3L,2L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190693Inst : IEnumerable<long>
{
public static readonly long[] Value=A190693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190693.Bytes);
public long this[int i]=>Value[i];

public static A190693Inst Instance=new A190693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190694
{
public static readonly long[] Value={ 3L,7L,11L,14L,18L,22L,26L,29L,33L,37L,41L,44L,48L,52L,59L,63L,67L,70L,74L,78L,82L,85L,89L,93L,97L,100L,104L,108L,115L,119L,123L,126L,130L,134L,138L,141L,145L,149L,153L,156L,160L,164L,171L,175L,179L,182L,186L,190L,194L,197L,201L,205L,212L,216L,220L,223L,227L,231L,235L,238L,242L,246L,250L,253L,257L,261L,268L,272L,276L,279L,283L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190694Inst : IEnumerable<long>
{
public static readonly long[] Value=A190694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190694.Bytes);
public long this[int i]=>Value[i];

public static A190694Inst Instance=new A190694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190695
{
public static readonly long[] Value={ 2L,6L,10L,17L,21L,25L,28L,32L,36L,40L,43L,47L,51L,55L,58L,62L,66L,73L,77L,81L,84L,88L,92L,96L,99L,103L,107L,111L,114L,118L,122L,129L,133L,137L,140L,144L,148L,152L,155L,159L,163L,167L,170L,174L,178L,185L,189L,193L,196L,200L,204L,208L,211L,215L,219L,226L,230L,234L,237L,241L,245L,249L,252L,256L,260L,264L,267L,271L,275L,282L,286L,290L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190695Inst : IEnumerable<long>
{
public static readonly long[] Value=A190695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190695.Bytes);
public long this[int i]=>Value[i];

public static A190695Inst Instance=new A190695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190696
{
public static readonly long[] Value={ 1L,5L,9L,13L,16L,20L,24L,31L,35L,39L,42L,46L,50L,54L,57L,61L,65L,69L,72L,76L,80L,87L,91L,95L,98L,102L,106L,110L,113L,117L,121L,125L,128L,132L,136L,143L,147L,151L,154L,158L,162L,166L,169L,173L,177L,181L,184L,188L,192L,195L,199L,203L,207L,210L,214L,218L,222L,225L,229L,233L,240L,244L,248L,251L,255L,259L,263L,266L,270L,274L,278L,281L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190696Inst : IEnumerable<long>
{
public static readonly long[] Value=A190696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190696.Bytes);
public long this[int i]=>Value[i];

public static A190696Inst Instance=new A190696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190697
{
public static readonly long[] Value={ 4L,8L,12L,15L,19L,23L,27L,30L,34L,38L,45L,49L,53L,56L,60L,64L,68L,71L,75L,79L,83L,86L,90L,94L,101L,105L,109L,112L,116L,120L,124L,127L,131L,135L,139L,142L,146L,150L,157L,161L,165L,168L,172L,176L,180L,183L,187L,191L,198L,202L,206L,209L,213L,217L,221L,224L,228L,232L,236L,239L,243L,247L,254L,258L,262L,265L,269L,273L,277L,280L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190697Inst : IEnumerable<long>
{
public static readonly long[] Value=A190697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190697.Bytes);
public long this[int i]=>Value[i];

public static A190697Inst Instance=new A190697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190698
{
public static readonly long[] Value={ 3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190698Inst : IEnumerable<long>
{
public static readonly long[] Value=A190698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190698.Bytes);
public long this[int i]=>Value[i];

public static A190698Inst Instance=new A190698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190699
{
public static readonly long[] Value={ 11L,26L,41L,52L,67L,82L,97L,108L,123L,138L,153L,164L,179L,194L,220L,235L,250L,261L,276L,291L,306L,317L,332L,347L,362L,373L,388L,403L,429L,444L,459L,470L,485L,500L,515L,526L,541L,556L,571L,582L,597L,612L,638L,653L,668L,679L,694L,709L,724L,735L,750L,765L,791L,806L,821L,832L,847L,862L,877L,888L,903L,918L,933L,944L,959L,974L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190699Inst : IEnumerable<long>
{
public static readonly long[] Value=A190699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190699.Bytes);
public long this[int i]=>Value[i];

public static A190699Inst Instance=new A190699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190748
{
public static readonly long[] Value={ 4L,12L,20L,28L,34L,42L,49L,58L,64L,71L,78L,86L,93L,101L,109L,117L,123L,130L,139L,145L,153L,159L,167L,176L,183L,190L,197L,205L,212L,219L,226L,235L,241L,248L,257L,264L,273L,278L,285L,293L,301L,308L,315L,322L,331L,338L,345L,353L,359L,368L,374L,382L,390L,397L,403L,412L,419L,427L,433L,440L,449L,456L,464L,471L,478L,486L,493L,499L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190748Inst : IEnumerable<long>
{
public static readonly long[] Value=A190748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190748.Bytes);
public long this[int i]=>Value[i];

public static A190748Inst Instance=new A190748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190749
{
public static readonly long[] Value={ 8L,17L,27L,37L,46L,56L,66L,76L,85L,95L,104L,114L,124L,134L,143L,154L,162L,172L,182L,192L,202L,210L,221L,231L,240L,250L,259L,268L,280L,289L,298L,309L,317L,326L,337L,347L,357L,365L,376L,387L,396L,407L,415L,424L,435L,445L,454L,465L,473L,483L,492L,503L,513L,521L,531L,541L,550L,562L,570L,579L,590L,599L,610L,620L,628L,638L,647L,657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190749Inst : IEnumerable<long>
{
public static readonly long[] Value=A190749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190749.Bytes);
public long this[int i]=>Value[i];

public static A190749Inst Instance=new A190749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190750
{
public static readonly long[] Value={ 2L,7L,11L,16L,21L,26L,32L,36L,41L,44L,50L,54L,60L,65L,69L,74L,79L,84L,90L,92L,98L,102L,108L,112L,118L,122L,127L,132L,136L,141L,146L,150L,156L,160L,166L,170L,175L,180L,184L,189L,194L,199L,203L,208L,214L,218L,224L,227L,232L,237L,242L,247L,252L,256L,261L,266L,271L,275L,281L,284L,290L,294L,300L,305L,310L,314L,318L,323L,329L,333L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190750Inst : IEnumerable<long>
{
public static readonly long[] Value=A190750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190750.Bytes);
public long this[int i]=>Value[i];

public static A190750Inst Instance=new A190750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190751
{
public static readonly long[] Value={ 2L,4L,8L,10L,13L,18L,21L,24L,27L,29L,34L,38L,42L,44L,47L,51L,54L,58L,61L,63L,66L,70L,74L,78L,80L,84L,87L,91L,94L,97L,100L,104L,107L,111L,114L,118L,120L,125L,127L,129L,134L,136L,141L,143L,147L,150L,154L,158L,161L,163L,167L,170L,175L,177L,180L,184L,187L,191L,194L,197L,200L,203L,206L,211L,213L,217L,220L,224L,227L,231L,234L,237L,240L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190751Inst : IEnumerable<long>
{
public static readonly long[] Value=A190751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190751.Bytes);
public long this[int i]=>Value[i];

public static A190751Inst Instance=new A190751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190752
{
public static readonly long[] Value={ 1L,3L,7L,9L,12L,16L,20L,22L,25L,28L,31L,35L,37L,41L,43L,45L,49L,52L,56L,59L,62L,65L,67L,71L,73L,77L,79L,83L,86L,89L,92L,95L,99L,101L,105L,108L,110L,113L,116L,119L,122L,126L,128L,132L,135L,137L,142L,144L,146L,149L,153L,157L,160L,162L,165L,168L,171L,176L,178L,181L,183L,185L,190L,193L,196L,199L,202L,204L,207L,212L,214L,218L,219L,223L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190752Inst : IEnumerable<long>
{
public static readonly long[] Value=A190752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190752.Bytes);
public long this[int i]=>Value[i];

public static A190752Inst Instance=new A190752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190753
{
public static readonly long[] Value={ 6L,14L,23L,30L,39L,48L,57L,64L,72L,81L,90L,98L,106L,115L,123L,131L,140L,148L,156L,164L,172L,182L,188L,198L,205L,215L,222L,232L,239L,249L,255L,265L,273L,282L,289L,298L,306L,315L,322L,331L,339L,347L,356L,365L,373L,380L,389L,398L,407L,414L,423L,431L,440L,448L,457L,465L,473L,481L,490L,499L,506L,514L,523L,532L,540L,548L,557L,565L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190753Inst : IEnumerable<long>
{
public static readonly long[] Value=A190753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190753.Bytes);
public long this[int i]=>Value[i];

public static A190753Inst Instance=new A190753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190754
{
public static readonly long[] Value={ 15L,33L,50L,69L,85L,103L,121L,139L,155L,174L,192L,210L,226L,244L,261L,279L,297L,314L,332L,350L,368L,386L,402L,421L,437L,455L,471L,491L,508L,526L,544L,561L,578L,597L,614L,631L,648L,667L,684L,701L,719L,737L,754L,773L,789L,808L,825L,844L,859L,877L,895L,913L,930L,947L,967L,984L,1002L,1019L,1037L,1054L,1072L,1089L,1106L,1124L,1143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190754Inst : IEnumerable<long>
{
public static readonly long[] Value=A190754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190754.Bytes);
public long this[int i]=>Value[i];

public static A190754Inst Instance=new A190754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190755
{
public static readonly long[] Value={ 17L,36L,55L,75L,93L,112L,133L,151L,169L,189L,209L,228L,247L,267L,286L,304L,325L,343L,361L,381L,401L,420L,438L,459L,478L,497L,515L,535L,554L,574L,593L,611L,630L,652L,670L,688L,708L,727L,746L,765L,785L,803L,822L,843L,862L,880L,900L,920L,938L,957L,977L,996L,1014L,1033L,1053L,1073L,1092L,1111L,1130L,1150L,1169L,1188L,1206L,1226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190755Inst : IEnumerable<long>
{
public static readonly long[] Value=A190755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190755.Bytes);
public long this[int i]=>Value[i];

public static A190755Inst Instance=new A190755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190756
{
public static readonly long[] Value={ 5L,11L,19L,26L,32L,40L,46L,53L,60L,68L,76L,82L,88L,96L,102L,109L,117L,124L,130L,138L,145L,152L,159L,166L,173L,179L,186L,195L,201L,208L,216L,221L,229L,236L,242L,250L,258L,264L,271L,278L,285L,292L,299L,307L,312L,320L,328L,335L,341L,349L,355L,362L,369L,376L,384L,391L,397L,405L,411L,418L,426L,432L,439L,447L,453L,461L,468L,475L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190756Inst : IEnumerable<long>
{
public static readonly long[] Value=A190756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190756.Bytes);
public long this[int i]=>Value[i];

public static A190756Inst Instance=new A190756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190757
{
public static readonly long[] Value={ 1L,1L,101L,71L,181L,39161L,24571L,12301L,1158551L,87382901L,21211L,373270451L,28143378001L,32414581L,1322154751061L,9062194370461L,1550853481L,2819407321151L,265272771839851L,2366632711L,137083914639998701L,85417012034751151L,3455782010101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190757Inst : IEnumerable<long>
{
public static readonly long[] Value=A190757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190757.Bytes);
public long this[int i]=>Value[i];

public static A190757Inst Instance=new A190757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190758
{
public static readonly long[] Value={ 17467L,18287L,31817L,42641L,116359L,139483L,163673L,172283L,176383L,181549L,190979L,225829L,226813L,231323L,259531L,288313L,299137L,307009L,352109L,404507L,421891L,445097L,464777L,484621L,528163L,592861L,604997L,609179L,611393L,629843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190758Inst : IEnumerable<long>
{
public static readonly long[] Value=A190758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190758.Bytes);
public long this[int i]=>Value[i];

public static A190758Inst Instance=new A190758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190759
{
public static readonly long[] Value={ 1L,0L,4L,0L,16L,0L,136L,0L,1128L,384L,8120L,6912L,60904L,75136L,491960L,720640L,4023592L,6828928L,32819320L,63472640L,270471784L,574543744L,2256221368L,5119155712L,18940876712L,45266369152L,159625747960L,397949457408L,1350573713256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190759Inst : IEnumerable<long>
{
public static readonly long[] Value=A190759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190759.Bytes);
public long this[int i]=>Value[i];

public static A190759Inst Instance=new A190759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190760
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,34L,36L,38L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,52L,54L,56L,58L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L,74L,76L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,92L,94L,96L,98L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,113L,116L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190760Inst : IEnumerable<long>
{
public static readonly long[] Value=A190760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190760.Bytes);
public long this[int i]=>Value[i];

public static A190760Inst Instance=new A190760Inst();

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