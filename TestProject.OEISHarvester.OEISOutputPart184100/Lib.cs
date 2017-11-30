using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A214557
{
public static readonly long[] Value={ 864197532L,86431976532L,8643319766532L,864333197666532L,86433331976666532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214557Inst : IEnumerable<long>
{
public static readonly long[] Value=A214557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214557.Bytes);
public long this[int i]=>Value[i];

public static A214557Inst Instance=new A214557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214558
{
public static readonly BigInteger[] Value={ 864197532L,886644219977553312L,BigInteger.Parse("87765443219997765543222"),BigInteger.Parse("888666444221999777555333112"),BigInteger.Parse("88776654443221999977765554332212") };
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
public class A214558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214558Inst Instance=new A214558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214559
{
public static readonly long[] Value={ 97508421L,9753086421L,9975084201L,975330866421L,997530864201L,999750842001L,97533308666421L,97755108844221L,99753308664201L,99975308642001L,99997508420001L,9753333086666421L,9775531088644221L,9975333086664201L,9977551088442201L,9997533086642001L,9999753086420001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214559Inst : IEnumerable<long>
{
public static readonly long[] Value=A214559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214559.Bytes);
public long this[int i]=>Value[i];

public static A214559Inst Instance=new A214559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214560
{
public static readonly long[] Value={ 1L,0L,2L,2L,4L,2L,4L,3L,6L,4L,4L,2L,6L,4L,5L,4L,8L,6L,6L,4L,6L,3L,4L,7L,8L,5L,6L,4L,7L,5L,6L,5L,10L,8L,8L,6L,8L,5L,6L,4L,8L,6L,5L,4L,6L,3L,9L,8L,10L,7L,7L,7L,8L,4L,6L,5L,9L,6L,7L,5L,8L,6L,7L,6L,12L,10L,10L,8L,10L,7L,8L,6L,10L,7L,7L,4L,8L,6L,6L,8L,10L,7L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214560Inst : IEnumerable<long>
{
public static readonly long[] Value=A214560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214560.Bytes);
public long this[int i]=>Value[i];

public static A214560Inst Instance=new A214560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214561
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,6L,6L,11L,1L,14L,11L,20L,10L,28L,23L,33L,1L,31L,27L,41L,26L,49L,36L,59L,16L,58L,41L,68L,37L,62L,51L,83L,1L,79L,61L,88L,58L,97L,85L,98L,53L,115L,96L,116L,63L,123L,96L,128L,41L,138L,105L,144L,90L,163L,128L,164L,81L,172L,148L,181L,124L,167L,134L,201L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214561Inst : IEnumerable<long>
{
public static readonly long[] Value=A214561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214561.Bytes);
public long this[int i]=>Value[i];

public static A214561Inst Instance=new A214561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214562
{
public static readonly long[] Value={ 0L,0L,2L,1L,8L,6L,10L,9L,24L,15L,23L,19L,34L,21L,31L,26L,64L,39L,49L,40L,61L,44L,63L,46L,95L,59L,82L,61L,98L,79L,97L,71L,160L,88L,112L,92L,129L,96L,115L,109L,160L,105L,131L,118L,178L,125L,159L,134L,228L,138L,178L,146L,207L,141L,183L,154L,245L,161L,192L,167L,231L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214562Inst : IEnumerable<long>
{
public static readonly long[] Value=A214562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214562.Bytes);
public long this[int i]=>Value[i];

public static A214562Inst Instance=new A214562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214563
{
public static readonly long[] Value={ 40L,42L,40L,188L,209L,204L,210L,228L,204L,820L,1007L,1058L,1008L,907L,776L,3426L,4601L,5076L,4601L,4104L,3608L,5076L,3608L,2608L,13344L,18726L,21050L,18302L,17364L,15896L,21307L,15275L,11148L,50036L,71736L,81276L,69029L,67670L,63148L,80263L,61229L,46550L,82942L,60116L,44196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214563Inst : IEnumerable<long>
{
public static readonly long[] Value=A214563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214563.Bytes);
public long this[int i]=>Value[i];

public static A214563Inst Instance=new A214563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214564
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,3L,3L,4L,5L,5L,5L,6L,5L,5L,5L,4L,3L,3L,2L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,13L,15L,17L,18L,19L,20L,20L,20L,20L,19L,18L,17L,15L,13L,12L,10L,8L,7L,5L,4L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214564Inst : IEnumerable<long>
{
public static readonly long[] Value=A214564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214564.Bytes);
public long this[int i]=>Value[i];

public static A214564Inst Instance=new A214564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214565
{
public static readonly long[] Value={ 1L,1L,3L,12L,66L,426L,3392L,30412L,314994L,3622332L,46379994L,648971940L,9923253672L,163720448184L,2910558776412L,55341456735744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214565Inst : IEnumerable<long>
{
public static readonly long[] Value=A214565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214565.Bytes);
public long this[int i]=>Value[i];

public static A214565Inst Instance=new A214565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214566
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,1L,2L,2L,2L,1L,1L,3L,2L,1L,2L,1L,1L,2L,2L,1L,3L,1L,2L,2L,1L,1L,3L,2L,1L,2L,2L,1L,3L,1L,2L,2L,1L,1L,4L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214566Inst : IEnumerable<long>
{
public static readonly long[] Value=A214566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214566.Bytes);
public long this[int i]=>Value[i];

public static A214566Inst Instance=new A214566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214567
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,4L,3L,2L,3L,5L,5L,4L,5L,4L,6L,2L,4L,4L,3L,5L,5L,6L,4L,4L,4L,6L,3L,4L,6L,7L,6L,2L,7L,5L,6L,4L,5L,4L,7L,5L,6L,6L,5L,6L,6L,5L,7L,4L,3L,5L,6L,6L,3L,4L,8L,4L,5L,7L,5L,7L,5L,7L,5L,2L,8L,8L,4L,5L,6L,7L,6L,4L,6L,6L,6L,4L,7L,8L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214567Inst : IEnumerable<long>
{
public static readonly long[] Value=A214567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214567.Bytes);
public long this[int i]=>Value[i];

public static A214567Inst Instance=new A214567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214568
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,2L,3L,3L,0L,1L,1L,6L,6L,6L,0L,1L,3L,7L,11L,14L,12L,0L,1L,1L,11L,16L,29L,32L,25L,0L,1L,3L,11L,26L,46L,72L,75L,52L,0L,1L,2L,16L,27L,79L,122L,182L,177L,113L,0L,1L,3L,18L,42L,101L,217L,336L,457L,420L,247L,0L,1L,1L,20L,47L,149L,303L,621L,911L,1160L,1005L,548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214568Inst : IEnumerable<long>
{
public static readonly long[] Value=A214568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214568.Bytes);
public long this[int i]=>Value[i];

public static A214568Inst Instance=new A214568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214569
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,3L,1L,6L,8L,4L,2L,10L,17L,7L,8L,1L,5L,11L,34L,16L,25L,3L,18L,0L,3L,1L,1L,0L,3L,16L,63L,27L,65L,6L,56L,1L,16L,5L,4L,0L,22L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,0L,1L,19L,111L,47L,154L,12L,138L,3L,65L,13L,13L,0L,95L,0L,0L,3L,5L,0L,13L,0L,8L,1L,0L,0L,13L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,26L,186L,73L,348L,18L,319L,6L,208L,35L,32L,0L,308L,0L,2L,13L,34L,0L,58L,0L,29L,1L,0L,0L,88L,0L,0L,1L,1L,0L,16L,0L,0L,0L,0L,1L,18L,0L,0L,0L,8L,0L,2L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214569Inst : IEnumerable<long>
{
public static readonly long[] Value=A214569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214569.Bytes);
public long this[int i]=>Value[i];

public static A214569Inst Instance=new A214569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214570
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,12L,24L,40L,60L,120L,240L,420L,840L,1680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214570Inst : IEnumerable<long>
{
public static readonly long[] Value=A214570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214570.Bytes);
public long this[int i]=>Value[i];

public static A214570Inst Instance=new A214570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214571
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,6L,3L,6L,16L,12L,8L,10L,34L,21L,32L,5L,30L,11L,68L,48L,100L,15L,108L,0L,24L,9L,10L,0L,36L,16L,126L,81L,260L,30L,336L,7L,128L,45L,40L,0L,264L,0L,0L,15L,0L,0L,18L,0L,40L,0L,0L,0L,24L,19L,222L,141L,616L,60L,828L,21L,520L,117L,130L,0L,1140L,0L,0L,45L,80L,0L,234L,0L,160L,21L,0L,0L,312L,0L,0L,0L,0L,0L,120L,0L,0L,0L,0L,0L,36L,0L,0L,0L,40L,26L,372L,219L,1392L,90L,1914L,42L,1664L,315L,320L,0L,3696L,0L,28L,195L,544L,0L,1044L,0L,580L,21L,0L,0L,2112L,0L,0L,27L,28L,0L,480L,0L,0L,0L,0L,35L,648L,0L,0L,0L,320L,0L,84L,0L,0L,0L,0L,0L,240L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214571Inst : IEnumerable<long>
{
public static readonly long[] Value=A214571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214571.Bytes);
public long this[int i]=>Value[i];

public static A214571Inst Instance=new A214571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214572
{
public static readonly long[] Value={ 45L,50L,54L,55L,60L,63L,65L,66L,69L,70L,72L,77L,78L,80L,84L,85L,87L,88L,91L,92L,93L,94L,95L,96L,97L,98L,102L,103L,104L,111L,112L,113L,114L,116L,119L,122L,123L,124L,128L,129L,133L,136L,137L,142L,146L,148L,149L,151L,152L,158L,159L,164L,166L,167L,172L,173L,177L,178L,181L,193L,199L,201L,202L,211L,212L,214L,218L,223L,227L,233L,236L,239L,254L,262L,263L,268L,269L,271L,278L,283L,293L,311L,314L,326L,337L,353L,358L,367L,373L,382L,383L,401L,421L,431L,443L,461L,482L,547L,554L,577L,587L,599L,647L,662L,709L,739L,757L,797L,919L,967L,1063L,1153L,1523L,1787L,2221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214572Inst : IEnumerable<long>
{
public static readonly long[] Value=A214572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214572.Bytes);
public long this[int i]=>Value[i];

public static A214572Inst Instance=new A214572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214573
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,4L,3L,1L,2L,2L,3L,1L,4L,1L,4L,1L,5L,4L,1L,3L,2L,3L,2L,5L,1L,4L,1L,2L,3L,5L,1L,3L,2L,5L,1L,4L,2L,5L,1L,4L,2L,5L,1L,6L,1L,4L,2L,6L,1L,4L,2L,4L,2L,6L,1L,6L,5L,1L,6L,1L,3L,3L,5L,2L,6L,1L,4L,2L,4L,2L,5L,2L,6L,1L,3L,3L,5L,2L,3L,3L,6L,1L,7L,1L,5L,2L,5L,2L,6L,1L,4L,2L,1L,7L,1L,4L,3L,5L,2L,4L,2L,7L,1L,7L,1L,5L,2L,5L,2L,5L,2L,2L,4L,7L,1L,5L,2L,6L,1L,6L,2L,6L,1L,6L,2L,7L,1L,3L,3L,4L,3L,6L,2L,6L,2L,5L,2L,7L,1L,4L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214573Inst : IEnumerable<long>
{
public static readonly long[] Value=A214573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214573.Bytes);
public long this[int i]=>Value[i];

public static A214573Inst Instance=new A214573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214574
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214574Inst : IEnumerable<long>
{
public static readonly long[] Value=A214574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214574.Bytes);
public long this[int i]=>Value[i];

public static A214574Inst Instance=new A214574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214575
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,3L,2L,2L,1L,1L,1L,3L,2L,2L,1L,1L,1L,1L,4L,2L,4L,1L,2L,1L,1L,1L,4L,3L,4L,1L,3L,1L,1L,1L,1L,5L,3L,6L,2L,4L,1L,2L,1L,1L,1L,5L,3L,6L,2L,4L,1L,2L,1L,1L,1L,1L,6L,4L,9L,2L,7L,1L,4L,2L,2L,1L,1L,1L,6L,4L,9L,2L,7L,1L,4L,2L,2L,1L,1L,1L,1L,7L,4L,12L,2L,9L,2L,6L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214575Inst : IEnumerable<long>
{
public static readonly long[] Value=A214575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214575.Bytes);
public long this[int i]=>Value[i];

public static A214575Inst Instance=new A214575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214576
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,3L,1L,0L,1L,5L,0L,0L,0L,1L,6L,2L,1L,0L,0L,1L,10L,0L,0L,0L,0L,0L,1L,11L,3L,0L,1L,0L,0L,0L,1L,16L,0L,2L,0L,0L,0L,0L,0L,1L,19L,5L,0L,0L,1L,0L,0L,0L,0L,1L,26L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,27L,6L,3L,2L,0L,1L,0L,0L,0L,0L,0L,1L,40L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214576Inst : IEnumerable<long>
{
public static readonly long[] Value=A214576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214576.Bytes);
public long this[int i]=>Value[i];

public static A214576Inst Instance=new A214576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214577
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,16L,17L,19L,23L,25L,27L,31L,32L,49L,53L,59L,64L,67L,81L,83L,97L,103L,121L,125L,127L,128L,131L,227L,241L,243L,256L,277L,289L,311L,331L,343L,361L,419L,431L,509L,512L,529L,563L,625L,661L,691L,709L,719L,729L,739L,961L,1024L,1331L,1433L,1523L,1543L,1619L,1787L,1879L,2048L,2063L,2187L,2221L,2309L,2401L,2437L,2809L,2897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214577Inst : IEnumerable<long>
{
public static readonly long[] Value=A214577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214577.Bytes);
public long this[int i]=>Value[i];

public static A214577Inst Instance=new A214577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214578
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,1L,0L,2L,1L,3L,2L,2L,0L,1L,1L,1L,1L,0L,0L,0L,0L,4L,2L,1L,1L,0L,3L,1L,0L,0L,0L,2L,2L,1L,0L,2L,2L,2L,0L,3L,3L,0L,0L,0L,1L,1L,1L,1L,1L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,2L,0L,0L,0L,4L,1L,0L,0L,0L,0L,0L,2L,1L,1L,1L,0L,0L,0L,0L,6L,0L,0L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214578Inst : IEnumerable<long>
{
public static readonly long[] Value=A214578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214578.Bytes);
public long this[int i]=>Value[i];

public static A214578Inst Instance=new A214578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214579
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,4L,1L,5L,3L,7L,1L,13L,1L,12L,8L,16L,1L,26L,1L,29L,13L,28L,1L,51L,6L,42L,19L,56L,1L,87L,1L,77L,29L,79L,16L,134L,1L,106L,43L,145L,1L,195L,1L,178L,77L,177L,1L,288L,11L,253L,80L,278L,1L,379L,32L,361L,107L,352L,1L,573L,1L,440L,163L,516L,46L,699L,1L,627L,178L,701L,1L,961L,1L,776L,288L,884L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214579Inst : IEnumerable<long>
{
public static readonly long[] Value=A214579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214579.Bytes);
public long this[int i]=>Value[i];

public static A214579Inst Instance=new A214579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214580
{
public static readonly long[] Value={ 42L,2697L,29805L,163914L,616008L,1819539L,4550763L,10075380L,20321478L,38078781L,67224201L,112973694L,182160420L,283539207L,428117319L,629511528L,904331490L,1272589425L,1758136101L,2389123122L,3198491520L,4224486651L,5511199395L,7109133660L,9075800190L,11476336677L,14384154177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214580Inst : IEnumerable<long>
{
public static readonly long[] Value=A214580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214580.Bytes);
public long this[int i]=>Value[i];

public static A214580Inst Instance=new A214580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214581
{
public static readonly long[] Value={ 6L,6L,3L,30L,48L,57L,54L,45L,30L,12L,72L,126L,165L,186L,195L,186L,168L,138L,102L,66L,27L,132L,240L,327L,390L,435L,456L,462L,444L,414L,366L,309L,246L,177L,114L,48L,210L,390L,543L,666L,765L,834L,882L,900L,900L,870L,825L,756L,675L,582L,480L,378L,270L,174L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214581Inst : IEnumerable<long>
{
public static readonly long[] Value=A214581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214581.Bytes);
public long this[int i]=>Value[i];

public static A214581Inst Instance=new A214581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214582
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,3L,4L,5L,1L,5L,7L,10L,7L,1L,8L,11L,15L,20L,9L,1L,13L,18L,25L,35L,34L,11L,1L,21L,29L,40L,55L,75L,52L,13L,1L,34L,47L,65L,90L,125L,143L,74L,15L,1L,55L,76L,105L,145L,200L,275L,247L,100L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214582Inst : IEnumerable<long>
{
public static readonly long[] Value=A214582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214582.Bytes);
public long this[int i]=>Value[i];

public static A214582Inst Instance=new A214582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214583
{
public static readonly long[] Value={ 3L,4L,6L,8L,12L,14L,18L,20L,24L,30L,32L,38L,42L,48L,54L,60L,62L,68L,72L,80L,84L,90L,98L,108L,110L,132L,138L,140L,150L,180L,182L,198L,252L,318L,360L,398L,468L,570L,572L,930L,1722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214583Inst : IEnumerable<long>
{
public static readonly long[] Value=A214583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214583.Bytes);
public long this[int i]=>Value[i];

public static A214583Inst Instance=new A214583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214584
{
public static readonly long[] Value={ 4L,5L,7L,44L,45L,47L,54L,55L,57L,74L,75L,77L,444L,445L,447L,454L,455L,457L,474L,475L,477L,544L,545L,547L,554L,555L,557L,574L,575L,577L,744L,745L,747L,754L,755L,757L,774L,775L,777L,4444L,4445L,4447L,4454L,4455L,4457L,4474L,4475L,4477L,4544L,4545L,4547L,4554L,4555L,4557L,4574L,4575L,4577L,4744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214584Inst : IEnumerable<long>
{
public static readonly long[] Value=A214584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214584.Bytes);
public long this[int i]=>Value[i];

public static A214584Inst Instance=new A214584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214585
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,48L,49L,51L,53L,55L,57L,59L,60L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,80L,81L,83L,84L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214585Inst : IEnumerable<long>
{
public static readonly long[] Value=A214585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214585.Bytes);
public long this[int i]=>Value[i];

public static A214585Inst Instance=new A214585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214586
{
public static readonly long[] Value={ 2L,6L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,50L,52L,54L,56L,58L,62L,64L,66L,68L,70L,72L,74L,76L,78L,82L,86L,88L,90L,92L,94L,96L,98L,100L,102L,106L,110L,112L,114L,116L,118L,120L,122L,124L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214586Inst : IEnumerable<long>
{
public static readonly long[] Value=A214586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214586.Bytes);
public long this[int i]=>Value[i];

public static A214586Inst Instance=new A214586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214587
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,20L,1L,2L,1L,4L,5L,2L,1L,4L,1L,30L,1L,2L,3L,2L,5L,6L,1L,2L,3L,40L,1L,2L,1L,4L,5L,2L,1L,8L,1L,50L,1L,2L,1L,2L,5L,2L,1L,2L,1L,60L,1L,2L,3L,4L,5L,6L,1L,4L,3L,70L,1L,2L,1L,2L,5L,2L,7L,2L,1L,80L,1L,2L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214587Inst : IEnumerable<long>
{
public static readonly long[] Value=A214587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214587.Bytes);
public long this[int i]=>Value[i];

public static A214587Inst Instance=new A214587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214588
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,23L,37L,53L,67L,71L,83L,97L,101L,103L,113L,131L,149L,151L,163L,167L,179L,181L,193L,197L,199L,211L,227L,229L,241L,257L,263L,277L,293L,307L,311L,337L,353L,359L,373L,389L,401L,419L,421L,433L,439L,449L,467L,487L,499L,503L,547L,563L,577L,593L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214588Inst : IEnumerable<long>
{
public static readonly long[] Value=A214588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214588.Bytes);
public long this[int i]=>Value[i];

public static A214588Inst Instance=new A214588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214589
{
public static readonly BigInteger[] Value={ 3L,5L,23L,401L,20351L,2869211L,1127599139L,1248252244661L,3918263795984603L,BigInteger.Parse("35080215765450132755"),BigInteger.Parse("899912775031092255512711"),BigInteger.Parse("66403663756769266442027284403"),BigInteger.Parse("14140062564030204365431731967633343") };
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
public class A214589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214589Inst Instance=new A214589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214590
{
public static readonly BigInteger[] Value={ 4L,8L,62L,1862L,187862L,63120962L,71200442882L,272199293130242L,3552472974642762242L,BigInteger.Parse("159161446682919676638722"),BigInteger.Parse("24593308418551382594861736962"),BigInteger.Parse("13156534644821921838477614251069442") };
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
public class A214590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214590Inst Instance=new A214590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214591
{
public static readonly BigInteger[] Value={ 5L,13L,157L,10177L,3330677L,5495329427L,43988453613377L,1673440688496376877L,BigInteger.Parse("301618636251020715984377"),BigInteger.Parse("258456549967842122873898234377"),BigInteger.Parse("1057468726916674176186809546298140627") };
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
public class A214591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214591Inst Instance=new A214591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214592
{
public static readonly BigInteger[] Value={ 6L,18L,312L,33352L,20608352L,69920063852L,1279414854562952L,BigInteger.Parse("126404181535040391152"),BigInteger.Parse("67823930097039015417498752"),BigInteger.Parse("198754894778868023542228903871252") };
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
public class A214592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214592Inst Instance=new A214592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214593
{
public static readonly BigInteger[] Value={ 7L,25L,601L,103651L,121537201L,971302214871L,53475958137232241L,BigInteger.Parse("20261509828593742587755"),BigInteger.Parse("52256372938247946481045323041"),BigInteger.Parse("909113988784102810475556803145162725") };
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
public class A214593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214593Inst Instance=new A214593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214594
{
public static readonly BigInteger[] Value={ 8L,32L,986L,250042L,493575042L,7427553264322L,841074553776240002L,BigInteger.Parse("708809429969357784359042"),BigInteger.Parse("4431510042384136382251663178882"),BigInteger.Parse("205943724467315535144140586838561052162") };
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
public class A214594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214594Inst Instance=new A214594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214595
{
public static readonly long[] Value={ 2L,3L,2L,4L,5L,2L,5L,8L,23L,2L,6L,13L,62L,401L,2L,7L,18L,157L,1862L,20351L,2L,8L,25L,312L,10177L,187862L,2869211L,2L,9L,32L,601L,33352L,3330677L,63120962L,1127599139L,2L,10L,41L,986L,103651L,20608352L,5495329427L,71200442882L,1248252244661L,2L,11L,50L,1619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214595Inst : IEnumerable<long>
{
public static readonly long[] Value=A214595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214595.Bytes);
public long this[int i]=>Value[i];

public static A214595Inst Instance=new A214595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214596
{
public static readonly long[] Value={ 2L,23L,62L,157L,312L,601L,986L,1619L,2426L,3589L,5028L,6997L,9314L,12371L,15914L,20377L,25488L,31789L,38846L,47399L,56906L,68161L,80592L,95137L,111002L,129383L,149342L,172141L,196800L,224761L,254762L,288563L,324722L,365077L,408132L,455941L,506666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214596Inst : IEnumerable<long>
{
public static readonly long[] Value=A214596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214596.Bytes);
public long this[int i]=>Value[i];

public static A214596Inst Instance=new A214596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214597
{
public static readonly long[] Value={ 2L,401L,1862L,10177L,33352L,103651L,250042L,589763L,1199614L,2377843L,4299560L,7631589L,12644114L,20709813L,32235854L,49618485L,73512984L,107991735L,153683050L,217344807L,299596702L,410511063L,550861288L,735611705L,964611698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214597Inst : IEnumerable<long>
{
public static readonly long[] Value=A214597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214597.Bytes);
public long this[int i]=>Value[i];

public static A214597Inst Instance=new A214597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214598
{
public static readonly long[] Value={ 2L,20351L,187862L,3330677L,20608352L,121537201L,493575042L,1877543213L,5767190924L,16841357893L,42868858260L,105147415789L,233567627514L,505276944133L,1015252318954L,1995846081585L,3708725498234L,6772671546085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214598Inst : IEnumerable<long>
{
public static readonly long[] Value=A214598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214598.Bytes);
public long this[int i]=>Value[i];

public static A214598Inst Instance=new A214598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214599
{
public static readonly long[] Value={ 2L,2869211L,63120962L,5495329427L,69920063852L,971302214871L,7427553264322L,51611647496273L,265462242006596L,1257264229573585L,4911963280790040L,18044741780879451L,57852506775385206L,177133944592970795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214599Inst : IEnumerable<long>
{
public static readonly long[] Value=A214599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214599.Bytes);
public long this[int i]=>Value[i];

public static A214599Inst Instance=new A214599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214600
{
public static readonly BigInteger[] Value={ 2L,1127599139L,71200442882L,43988453613377L,1279414854562952L,53475958137232241L,841074553776240002L,12274806721494593819UL,BigInteger.Parse("116639524609385372432"),BigInteger.Parse("987544941072308915067"),BigInteger.Parse("6454982934188302466812") };
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
public class A214600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214600Inst Instance=new A214600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214601
{
public static readonly long[] Value={ 68L,70L,70L,418L,472L,479L,470L,524L,452L,2401L,3013L,3312L,3043L,2844L,2375L,13344L,18302L,21307L,18726L,17364L,15275L,21050L,15896L,11148L,68230L,98032L,117197L,98032L,95942L,89083L,117197L,89083L,64506L,335569L,494659L,599448L,482769L,488710L,463257L,577787L,465142L,353704L,600124L,458850L,341918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214601Inst : IEnumerable<long>
{
public static readonly long[] Value=A214601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214601.Bytes);
public long this[int i]=>Value[i];

public static A214601Inst Instance=new A214601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214602
{
public static readonly long[] Value={ 9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,102L,104L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214602Inst : IEnumerable<long>
{
public static readonly long[] Value=A214602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214602.Bytes);
public long this[int i]=>Value[i];

public static A214602Inst Instance=new A214602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214603
{
public static readonly long[] Value={ 1L,4L,8L,53L,48L,0L,62L,18L,38L,87L,0L,114L,260L,0L,221L,0L,568L,0L,627L,155L,0L,646L,0L,1724L,695L,0L,282L,0L,1433L,751L,0L,36460L,0L,949L,483379914L,0L,8018L,0L,1257L,0L,1553L,1858L,0L,4057L,0L,9262L,3825L,0L,10606L,0L,115835L,3153L,0L,0L,0L,6982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214603Inst : IEnumerable<long>
{
public static readonly long[] Value=A214603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214603.Bytes);
public long this[int i]=>Value[i];

public static A214603Inst Instance=new A214603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214604
{
public static readonly long[] Value={ 1L,5L,9L,11L,17L,25L,19L,27L,37L,49L,29L,39L,51L,65L,81L,41L,53L,67L,83L,101L,121L,55L,69L,85L,103L,123L,145L,169L,71L,87L,105L,125L,147L,171L,197L,225L,89L,107L,127L,149L,173L,199L,227L,257L,289L,109L,129L,151L,175L,201L,229L,259L,291L,325L,361L,131L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214604Inst : IEnumerable<long>
{
public static readonly long[] Value=A214604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214604.Bytes);
public long this[int i]=>Value[i];

public static A214604Inst Instance=new A214604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214605
{
public static readonly long[] Value={ 186L,190L,192L,202L,1943L,2219L,2250L,2333L,2170L,2472L,2222L,2200L,18630L,23979L,26077L,26479L,24035L,23261L,20216L,20016L,184991L,259387L,298358L,300853L,269833L,254971L,232802L,232923L,307936L,238766L,178292L,178350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214605Inst : IEnumerable<long>
{
public static readonly long[] Value=A214605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214605.Bytes);
public long this[int i]=>Value[i];

public static A214605Inst Instance=new A214605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214606
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,3L,2L,11L,2L,13L,2L,3L,2L,17L,2L,19L,2L,3L,2L,23L,2L,5L,2L,3L,14L,29L,2L,31L,2L,3L,2L,1L,2L,37L,2L,3L,2L,41L,2L,43L,2L,15L,2L,47L,2L,7L,2L,3L,2L,53L,2L,1L,2L,3L,2L,59L,2L,61L,2L,3L,2L,5L,2L,67L,2L,3L,14L,71L,2L,73L,2L,3L,2L,1L,2L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214606Inst : IEnumerable<long>
{
public static readonly long[] Value=A214606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214606.Bytes);
public long this[int i]=>Value[i];

public static A214606Inst Instance=new A214606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214607
{
public static readonly long[] Value={ 1105L,1387L,1729L,2701L,2821L,4033L,4681L,5461L,6601L,8911L,10261L,10585L,11305L,13741L,13981L,14491L,15841L,16705L,18721L,29341L,30121L,30889L,31609L,31621L,39865L,41041L,41665L,46657L,49141L,52633L,57421L,63973L,65281L,68101L,75361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214607Inst : IEnumerable<long>
{
public static readonly long[] Value=A214607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214607.Bytes);
public long this[int i]=>Value[i];

public static A214607Inst Instance=new A214607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214608
{
public static readonly long[] Value={ 304L,310L,314L,334L,334L,4137L,4754L,4811L,4929L,4920L,4610L,5260L,4738L,4784L,4924L,50775L,66474L,72137L,71469L,69764L,65977L,63790L,55400L,55907L,57274L,676474L,969677L,1118226L,1096104L,1058044L,1003962L,946620L,864012L,870946L,884912L,1154902L,887242L,651592L,669896L,710904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214608Inst : IEnumerable<long>
{
public static readonly long[] Value=A214608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214608.Bytes);
public long this[int i]=>Value[i];

public static A214608Inst Instance=new A214608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214609
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,2L,2L,1L,1L,12L,6L,4L,2L,2L,1L,1L,60L,30L,16L,11L,10L,6L,3L,3L,3L,1L,1L,360L,180L,90L,48L,60L,30L,18L,10L,15L,9L,4L,3L,3L,1L,1L,2520L,1260L,630L,318L,171L,420L,210L,108L,70L,38L,105L,54L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214609Inst : IEnumerable<long>
{
public static readonly long[] Value=A214609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214609.Bytes);
public long this[int i]=>Value[i];

public static A214609Inst Instance=new A214609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214610
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,25L,107L,363L,1248L,4460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214610Inst : IEnumerable<long>
{
public static readonly long[] Value=A214610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214610.Bytes);
public long this[int i]=>Value[i];

public static A214610Inst Instance=new A214610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214611
{
public static readonly long[] Value={ 1L,2L,6L,24L,120L,685L,4148L,25661L,159829L,997870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214611Inst : IEnumerable<long>
{
public static readonly long[] Value=A214611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214611.Bytes);
public long this[int i]=>Value[i];

public static A214611Inst Instance=new A214611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214612
{
public static readonly long[] Value={ 0L,16L,98L,304L,680L,1308L,2292L,3652L,5496L,7890L,10926L,14716L,19362L,24766L,31272L,38820L,47598L,57498L,68964L,81728L,96064L,112212L,129990L,149628L,171432L,194942L,220758L,248744L,279322L,312470L,347580L,385962L,427032L,470794L,517404L,567720L,620374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214612Inst : IEnumerable<long>
{
public static readonly long[] Value=A214612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214612.Bytes);
public long this[int i]=>Value[i];

public static A214612Inst Instance=new A214612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214613
{
public static readonly long[] Value={ 2L,3L,4L,3L,4L,5L,4L,3L,4L,5L,6L,5L,4L,5L,4L,3L,4L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214613Inst : IEnumerable<long>
{
public static readonly long[] Value=A214613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214613.Bytes);
public long this[int i]=>Value[i];

public static A214613Inst Instance=new A214613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214614
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,4L,1L,2L,4L,5L,1L,2L,3L,4L,5L,6L,1L,2L,4L,5L,7L,1L,2L,4L,8L,1L,2L,4L,5L,7L,8L,9L,1L,2L,4L,5L,8L,10L,1L,2L,4L,5L,8L,10L,11L,1L,2L,3L,4L,5L,6L,8L,10L,12L,1L,2L,4L,5L,8L,10L,13L,1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,1L,2L,4L,5L,8L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214614Inst : IEnumerable<long>
{
public static readonly long[] Value=A214614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214614.Bytes);
public long this[int i]=>Value[i];

public static A214614Inst Instance=new A214614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214615
{
public static readonly long[] Value={ 1L,1L,0L,-4L,-4L,60L,160L,-2000L,-9840L,118160L,915200L,-10900800L,-121640000L,1448075200L,22005235200L,-261817504000L,-5212995424000L,61812285600000L,1568367963136000L,-18458812571264000L,-584639647263360000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214615Inst : IEnumerable<long>
{
public static readonly long[] Value=A214615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214615.Bytes);
public long this[int i]=>Value[i];

public static A214615Inst Instance=new A214615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214616
{
public static readonly long[] Value={ 0L,9L,89L,439L,1519L,4214L,10038L,21378L,41778L,76263L,131703L,217217L,344617L,528892L,788732L,1147092L,1631796L,2276181L,3119781L,4209051L,5598131L,7349650L,9535570L,12238070L,15550470L,19578195L,24439779L,30267909L,37210509L,45431864L,55113784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214616Inst : IEnumerable<long>
{
public static readonly long[] Value=A214616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214616.Bytes);
public long this[int i]=>Value[i];

public static A214616Inst Instance=new A214616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214617
{
public static readonly long[] Value={ 10L,11L,21L,101L,121L,201L,221L,301L,321L,1021L,1101L,1201L,1221L,1301L,1321L,2021L,2121L,2201L,2301L,2321L,3001L,3101L,3121L,3221L,4001L,4021L,4101L,4121L,4201L,4221L,10101L,10121L,10221L,10301L,11021L,11101L,11201L,11301L,11321L,12021L,12121L,12201L,12321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214617Inst : IEnumerable<long>
{
public static readonly long[] Value=A214617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214617.Bytes);
public long this[int i]=>Value[i];

public static A214617Inst Instance=new A214617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214618
{
public static readonly long[] Value={ 9L,81L,512L,5041L,14884L,3805914951397L,4902227890625L,235260548044817L,443689062789184L,902576261010649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214618Inst : IEnumerable<long>
{
public static readonly long[] Value=A214618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214618.Bytes);
public long this[int i]=>Value[i];

public static A214618Inst Instance=new A214618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214619
{
public static readonly long[] Value={ 148L,162L,180L,216L,264L,270L,296L,324L,432L,450L,462L,486L,540L,648L,720L,810L,814L,864L,962L,1035L,1056L,1072L,1080L,1089L,1107L,1125L,1215L,1224L,1248L,1250L,1260L,1269L,1296L,1320L,1326L,1359L,1386L,1395L,1426L,1443L,1450L,1458L,1480L,1482L,1485L,1488L,1515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214619Inst : IEnumerable<long>
{
public static readonly long[] Value=A214619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214619.Bytes);
public long this[int i]=>Value[i];

public static A214619Inst Instance=new A214619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214620
{
public static readonly long[] Value={ 18L,24L,36L,42L,48L,56L,70L,72L,84L,90L,96L,98L,112L,120L,135L,140L,144L,150L,154L,168L,170L,175L,180L,182L,186L,192L,196L,198L,204L,220L,224L,225L,234L,240L,242L,245L,248L,266L,270L,276L,279L,280L,286L,288L,294L,300L,304L,306L,308L,310L,312L,315L,322L,330L,336L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214620Inst : IEnumerable<long>
{
public static readonly long[] Value=A214620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214620.Bytes);
public long this[int i]=>Value[i];

public static A214620Inst Instance=new A214620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214621
{
public static readonly long[] Value={ 1080L,1260L,1800L,2016L,2673L,3024L,3267L,3402L,4032L,4500L,4653L,4950L,5346L,5400L,5670L,5757L,5940L,6048L,6345L,6534L,6804L,7056L,7560L,7575L,8064L,11084L,11542L,12654L,12915L,13026L,13068L,13260L,13860L,14018L,14490L,14652L,14904L,15124L,15129L,16032L,16320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214621Inst : IEnumerable<long>
{
public static readonly long[] Value=A214621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214621.Bytes);
public long this[int i]=>Value[i];

public static A214621Inst Instance=new A214621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214622
{
public static readonly long[] Value={ 1L,-1L,1L,3L,-2L,1L,-10L,9L,-3L,1L,45L,-40L,18L,-4L,1L,-256L,225L,-100L,30L,-5L,1L,1743L,-1536L,675L,-200L,45L,-6L,1L,-13840L,12201L,-5376L,1575L,-350L,63L,-7L,1L,125625L,-110720L,48804L,-14336L,3150L,-560L,84L,-8L,1L,-1282816L,1130625L,-498240L,146412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214622Inst : IEnumerable<long>
{
public static readonly long[] Value=A214622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214622.Bytes);
public long this[int i]=>Value[i];

public static A214622Inst Instance=new A214622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214623
{
public static readonly long[] Value={ 1L,2L,16L,128L,1156L,10952L,107584L,1083392L,11115556L,115702472L,1218289216L,12948910592L,138708574096L,1495661223968L,16218468710656L,176727219273728L,1933956651447076L,21243204576601928L,234121111199439424L,2587943032046002688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214623Inst : IEnumerable<long>
{
public static readonly long[] Value=A214623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214623.Bytes);
public long this[int i]=>Value[i];

public static A214623Inst Instance=new A214623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214624
{
public static readonly BigInteger[] Value={ 1L,1L,16L,504L,28800L,2620800L,348364800L,63707212800L,15343379251200L,4707627724800000L,1792664637603840000L,BigInteger.Parse("829619584788234240000"),BigInteger.Parse("458592296933263933440000"),BigInteger.Parse("298435681233688170332160000"),BigInteger.Parse("225843218230899155927040000000"),BigInteger.Parse("196652982274555440023470080000000") };
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
public class A214624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214624Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214624.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214624Inst Instance=new A214624Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214625
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,1L,0L,0L,1L,0L,3L,2L,1L,0L,4L,0L,3L,2L,1L,0L,6L,0L,5L,4L,3L,2L,1L,0L,7L,6L,5L,0L,4L,0L,3L,2L,1L,0L,1L,0L,3L,2L,1L,0L,3L,3L,2L,2L,1L,0L,16L,0L,15L,15L,13L,12L,11L,0L,10L,9L,8L,0L,7L,0L,6L,5L,4L,3L,2L,0L,1L,0L,1L,0L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214625Inst : IEnumerable<long>
{
public static readonly long[] Value=A214625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214625.Bytes);
public long this[int i]=>Value[i];

public static A214625Inst Instance=new A214625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214626
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,8L,3L,8L,2L,5L,13L,15L,4L,17L,32L,9L,26L,29L,38L,32L,61L,99L,131L,192L,97L,228L,35L,132L,30L,13L,145L,35L,48L,193L,228L,23L,216L,37L,60L,23L,60L,2L,25L,17L,19L,44L,61L,80L,31L,92L,43L,74L,83L,126L,100L,183L,103L,203L,386L,489L,692L,539L,1028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214626Inst : IEnumerable<long>
{
public static readonly long[] Value=A214626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214626.Bytes);
public long this[int i]=>Value[i];

public static A214626Inst Instance=new A214626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214627
{
public static readonly long[] Value={ 2L,3L,7L,19L,29L,43L,47L,71L,83L,101L,113L,193L,197L,229L,241L,271L,283L,293L,311L,347L,383L,439L,457L,463L,491L,499L,523L,587L,619L,643L,683L,733L,797L,827L,857L,863L,919L,991L,1021L,1031L,1091L,1151L,1187L,1289L,1367L,1549L,1567L,1619L,1637L,1693L,1697L,1733L,1741L,1811L,1867L,1871L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214627Inst : IEnumerable<long>
{
public static readonly long[] Value=A214627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214627.Bytes);
public long this[int i]=>Value[i];

public static A214627Inst Instance=new A214627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214628
{
public static readonly long[] Value={ 2L,2L,2L,2L,4L,4L,4L,6L,6L,6L,8L,8L,8L,8L,10L,10L,10L,12L,12L,12L,14L,14L,14L,16L,16L,16L,18L,18L,18L,20L,20L,20L,22L,22L,22L,22L,24L,24L,24L,26L,26L,26L,28L,28L,28L,30L,30L,30L,32L,32L,32L,34L,34L,34L,36L,36L,36L,36L,38L,38L,38L,40L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214628Inst : IEnumerable<long>
{
public static readonly long[] Value=A214628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214628.Bytes);
public long this[int i]=>Value[i];

public static A214628Inst Instance=new A214628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214629
{
public static readonly long[] Value={ 11L,13L,19L,23L,29L,31L,37L,43L,53L,59L,61L,73L,79L,89L,97L,101L,223L,263L,283L,401L,409L,443L,601L,607L,809L,823L,829L,883L,1013L,1019L,1031L,1033L,1039L,1051L,1091L,1093L,1097L,1103L,1109L,1117L,1123L,1129L,1151L,1163L,1171L,1181L,1187L,1193L,1213L,1231L,1259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214629Inst : IEnumerable<long>
{
public static readonly long[] Value=A214629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214629.Bytes);
public long this[int i]=>Value[i];

public static A214629Inst Instance=new A214629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214630
{
public static readonly long[] Value={ -1L,0L,0L,2L,3L,6L,2L,12L,15L,20L,6L,30L,35L,42L,12L,56L,63L,72L,20L,90L,99L,110L,30L,132L,143L,156L,42L,182L,195L,210L,56L,240L,255L,272L,72L,306L,323L,342L,90L,380L,399L,420L,110L,462L,483L,506L,132L,552L,575L,600L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214630Inst : IEnumerable<long>
{
public static readonly long[] Value=A214630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214630.Bytes);
public long this[int i]=>Value[i];

public static A214630Inst Instance=new A214630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214631
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,16L,1L,1L,20L,936L,192L,1L,1L,70L,85800L,379366L,2816L,1L,1L,252L,9962680L,1825221320L,249664758L,46592L,1L,1L,924L,1340103744L,14336196893200L,89261675900020L,221005209058L,835584L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214631Inst : IEnumerable<long>
{
public static readonly long[] Value=A214631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214631.Bytes);
public long this[int i]=>Value[i];

public static A214631Inst Instance=new A214631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214632
{
public static readonly BigInteger[] Value={ 17L,103L,619L,2477L,34679L,416149L,7490683L,29962733L,419478263L,5872695683L,82217739563L,986612874757L,27625160493197L,994505777755093L,5967034666530559L,71604415998366709L,6444397439853003811L,BigInteger.Parse("180443128315884106709"),BigInteger.Parse("9743928929057741762287") };
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
public class A214632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214632Inst Instance=new A214632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214633
{
public static readonly BigInteger[] Value={ 2L,5L,13L,29L,61L,491L,3931L,15727L,157273L,314549L,4403689L,17614759L,387524701L,5425345817L,119357607977L,9787323854117L,78298590832939L,1722568998324661L,68902759932986443L,4685387675443078127L,BigInteger.Parse("318606361930129312639"),BigInteger.Parse("637212723860258625281") };
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
public class A214633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214633Inst Instance=new A214633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214634
{
public static readonly BigInteger[] Value={ 7L,17L,37L,151L,607L,1217L,2437L,4877L,39019L,78041L,624331L,6243313L,174812767L,1398502139L,19579029949L,39158059901L,1957902995053L,15663223960427L,156632239604273L,3132644792085463L,181693397940956857L,726773591763827431L,7267735917638274313L,BigInteger.Parse("1148302274986847341457"),BigInteger.Parse("4593209099947389365831") };
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
public class A214634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214634Inst Instance=new A214634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214635
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,3L,3L,1L,1L,4L,1L,3L,1L,6L,3L,1L,3L,1L,1L,1L,1L,3L,4L,3L,1L,1L,3L,1L,1L,1L,6L,3L,3L,1L,1L,4L,3L,7L,1L,1L,1L,3L,1L,4L,1L,6L,3L,6L,4L,1L,3L,3L,1L,1L,1L,3L,3L,10L,1L,3L,1L,12L,1L,1L,6L,1L,3L,11L,3L,6L,1L,3L,1L,1L,4L,4L,3L,9L,7L,5L,1L,6L,1L,1L,1L,14L,3L,4L,1L,1L,4L,3L,1L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214635Inst : IEnumerable<long>
{
public static readonly long[] Value=A214635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214635.Bytes);
public long this[int i]=>Value[i];

public static A214635Inst Instance=new A214635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214636
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,3L,4L,3L,3L,1L,5L,3L,1L,4L,3L,4L,3L,3L,6L,2L,4L,5L,7L,3L,2L,1L,3L,4L,10L,3L,5L,4L,5L,3L,4L,3L,6L,6L,3L,3L,1L,4L,8L,5L,3L,7L,11L,4L,4L,2L,3L,2L,8L,3L,5L,4L,6L,10L,9L,3L,6L,5L,4L,5L,1L,5L,11L,3L,7L,4L,8L,3L,4L,6L,3L,6L,5L,3L,5L,4L,3L,1L,7L,4L,3L,8L,10L,5L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214636Inst : IEnumerable<long>
{
public static readonly long[] Value=A214636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214636.Bytes);
public long this[int i]=>Value[i];

public static A214636Inst Instance=new A214636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214637
{
public static readonly BigInteger[] Value={ 1L,16L,17086L,61189172L,404233159860L,3880365678824980L,BigInteger.Parse("47959061464818182058"),BigInteger.Parse("711513280222442751394224"),BigInteger.Parse("12121127323153614807021655742"),BigInteger.Parse("230127245538294682127207785787376"),BigInteger.Parse("4767460278053986542112719904243778834"),BigInteger.Parse("106115342273795146740243750912097789131600") };
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
public class A214637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214637Inst Instance=new A214637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214638
{
public static readonly BigInteger[] Value={ 1L,6L,936L,379366L,249664758L,221005209058L,239143562020194L,299233941746052998L,BigInteger.Parse("417999868371999142276"),BigInteger.Parse("636568066798406010872120"),BigInteger.Parse("1039267652960081699025215774"),BigInteger.Parse("1796704965351078502372895796786"),BigInteger.Parse("3258764657213579008313421745034602") };
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
public class A214638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214638Inst Instance=new A214638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214639
{
public static readonly long[] Value={ 0L,1L,1L,0L,-1L,-2L,-2L,0L,3L,5L,4L,0L,-6L,-10L,-8L,0L,11L,18L,15L,0L,-20L,-32L,-26L,0L,34L,55L,44L,0L,-56L,-90L,-72L,0L,91L,144L,114L,0L,-143L,-226L,-178L,0L,220L,346L,272L,0L,-334L,-522L,-408L,0L,498L,777L,605L,0L,-732L,-1138L,-884L,0L,1064L,1648L,1276L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214639Inst : IEnumerable<long>
{
public static readonly long[] Value=A214639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214639.Bytes);
public long this[int i]=>Value[i];

public static A214639Inst Instance=new A214639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214640
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,2L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,2L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,2L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L,1L,2L,1L,2L,3L,1L,2L,2L,1L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214640Inst : IEnumerable<long>
{
public static readonly long[] Value=A214640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214640.Bytes);
public long this[int i]=>Value[i];

public static A214640Inst Instance=new A214640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214641
{
public static readonly long[] Value={ 1L,4L,7L,10L,12L,14L,17L,20L,23L,25L,28L,30L,33L,36L,39L,41L,43L,46L,49L,52L,54L,57L,60L,63L,65L,68L,71L,74L,76L,78L,81L,84L,87L,89L,92L,94L,97L,100L,103L,105L,107L,110L,113L,116L,118L,121L,124L,127L,129L,131L,134L,137L,140L,142L,145L,148L,151L,153L,155L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214641Inst : IEnumerable<long>
{
public static readonly long[] Value=A214641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214641.Bytes);
public long this[int i]=>Value[i];

public static A214641Inst Instance=new A214641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214642
{
public static readonly long[] Value={ 2L,5L,6L,8L,11L,13L,15L,18L,19L,21L,24L,26L,29L,31L,34L,35L,37L,40L,42L,44L,47L,48L,50L,53L,55L,58L,59L,61L,64L,66L,69L,70L,72L,75L,77L,79L,82L,83L,85L,88L,90L,93L,95L,98L,99L,101L,104L,106L,108L,111L,112L,114L,117L,119L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214642Inst : IEnumerable<long>
{
public static readonly long[] Value=A214642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214642.Bytes);
public long this[int i]=>Value[i];

public static A214642Inst Instance=new A214642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214643
{
public static readonly long[] Value={ 41L,73L,97L,137L,193L,233L,257L,353L,449L,457L,521L,577L,617L,641L,673L,769L,809L,929L,937L,1033L,1097L,1129L,1153L,1193L,1217L,1249L,1289L,1321L,1409L,1481L,1601L,1609L,1697L,1801L,1889L,1993L,2017L,2081L,2089L,2113L,2153L,2273L,2281L,2377L,2441L,2473L,2593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214643Inst : IEnumerable<long>
{
public static readonly long[] Value=A214643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214643.Bytes);
public long this[int i]=>Value[i];

public static A214643Inst Instance=new A214643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214644
{
public static readonly long[] Value={ 3L,9L,16L,22L,27L,32L,38L,45L,51L,56L,62L,67L,73L,80L,86L,91L,96L,102L,109L,115L,120L,126L,133L,139L,144L,150L,157L,163L,168L,173L,179L,186L,192L,197L,203L,208L,214L,221L,227L,232L,237L,243L,250L,256L,261L,267L,274L,280L,285L,290L,296L,303L,309L,314L,320L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214644Inst : IEnumerable<long>
{
public static readonly long[] Value=A214644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214644.Bytes);
public long this[int i]=>Value[i];

public static A214644Inst Instance=new A214644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214645
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,126L,1333L,17895L,293461L,5721390L,129948787L,3384796695L,99848190706L,3301868304168L,121369298328835L,4923587573624940L,219090125559917698L,10637377855875861600UL,BigInteger.Parse("560928617456424367993"),BigInteger.Parse("31993928581562975604588"),BigInteger.Parse("1966682218962058310721178") };
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
public class A214645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214645Inst Instance=new A214645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214646
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,2L,5L,5L,7L,2L,12L,9L,7L,7L,16L,2L,23L,9L,25L,32L,34L,57L,33L,91L,30L,124L,121L,77L,245L,18L,46L,263L,32L,309L,295L,341L,604L,636L,945L,310L,527L,251L,27L,778L,278L,805L,528L,1083L,1333L,537L,2416L,1870L,2953L,2143L,4823L,5096L,6966L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214646Inst : IEnumerable<long>
{
public static readonly long[] Value=A214646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214646.Bytes);
public long this[int i]=>Value[i];

public static A214646Inst Instance=new A214646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214647
{
public static readonly BigInteger[] Value={ 1L,4L,18L,136L,1575L,23346L,411796L,8388640L,193710285L,5000000050L,142655835366L,4458050224200L,151437553296211L,5556003412779106L,218946945190429800L,9223372036854775936UL,BigInteger.Parse("413620130943168382233"),BigInteger.Parse("19673204037648268787874"),BigInteger.Parse("989209827830156794562170") };
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
public class A214647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214647Inst Instance=new A214647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214648
{
public static readonly long[] Value={ 2L,5L,125L,51875L,8114028125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214648Inst : IEnumerable<long>
{
public static readonly long[] Value=A214648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214648.Bytes);
public long this[int i]=>Value[i];

public static A214648Inst Instance=new A214648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214649
{
public static readonly long[] Value={ 1L,-1L,1L,1L,0L,-2L,-3L,1L,11L,15L,-13L,-77L,-86L,144L,595L,495L,-1520L,-4810L,-2485L,15675L,39560L,6290L,-159105L,-324805L,87075L,1592843L,2616757L,-2136539L,-15726114L,-20247800L,32296693L,152909577L,145139491L,-417959049L,-1460704685L,-885536173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214649Inst : IEnumerable<long>
{
public static readonly long[] Value=A214649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214649.Bytes);
public long this[int i]=>Value[i];

public static A214649Inst Instance=new A214649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214650
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,5L,10L,34L,85L,254L,690L,1997L,5582L,15975L,45244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214650Inst : IEnumerable<long>
{
public static readonly long[] Value=A214650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214650.Bytes);
public long this[int i]=>Value[i];

public static A214650Inst Instance=new A214650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214651
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,1L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214651Inst : IEnumerable<long>
{
public static readonly long[] Value=A214651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214651.Bytes);
public long this[int i]=>Value[i];

public static A214651Inst Instance=new A214651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214652
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,7L,10L,7L,12L,19L,29L,36L,4L,23L,52L,22L,13L,36L,22L,2L,15L,17L,39L,41L,56L,73L,112L,153L,209L,282L,197L,350L,559L,841L,1038L,694L,1253L,2094L,522L,608L,1861L,3955L,4477L,5085L,6946L,10901L,1398L,2161L,9107L,20008L,10703L,12864L,21971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214652Inst : IEnumerable<long>
{
public static readonly long[] Value=A214652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214652.Bytes);
public long this[int i]=>Value[i];

public static A214652Inst Instance=new A214652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214653
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,11L,12L,13L,14L,20L,21L,22L,23L,24L,25L,27L,29L,30L,31L,32L,34L,36L,38L,43L,44L,45L,46L,49L,50L,51L,54L,62L,63L,64L,66L,67L,69L,70L,71L,73L,74L,76L,77L,78L,79L,80L,81L,83L,85L,86L,87L,88L,89L,90L,92L,94L,95L,96L,99L,101L,103L,105L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214653Inst : IEnumerable<long>
{
public static readonly long[] Value=A214653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214653.Bytes);
public long this[int i]=>Value[i];

public static A214653Inst Instance=new A214653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214654
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,307L,4288L,74511L,1550203L,37588412L,1041217039L,32446359005L,1123624632224L,42814687805649L,1780347364682777L,80231627759556196L,3895332991309376213L,BigInteger.Parse("202713074683790193475"),BigInteger.Parse("11256955024502873008864"),BigInteger.Parse("664444403260495390747071") };
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
public class A214654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214654Inst Instance=new A214654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214655
{
public static readonly long[] Value={ 3L,5L,29L,54799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214655Inst : IEnumerable<long>
{
public static readonly long[] Value=A214655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214655.Bytes);
public long this[int i]=>Value[i];

public static A214655Inst Instance=new A214655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214656
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,10L,10L,11L,11L,12L,12L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,26L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,38L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214656Inst : IEnumerable<long>
{
public static readonly long[] Value=A214656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214656.Bytes);
public long this[int i]=>Value[i];

public static A214656Inst Instance=new A214656Inst();

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