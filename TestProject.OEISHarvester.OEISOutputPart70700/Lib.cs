using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A143337
{
public static readonly long[] Value={ 1L,24L,-72L,96L,-168L,144L,-288L,192L,-360L,312L,-432L,288L,-672L,336L,-576L,576L,-744L,432L,-936L,480L,-1008L,768L,-864L,576L,-1440L,744L,-1008L,960L,-1344L,720L,-1728L,768L,-1512L,1152L,-1296L,1152L,-2184L,912L,-1440L,1344L,-2160L,1008L,-2304L,1056L,-2016L,1872L,-1728L,1152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143337Inst : IEnumerable<long>
{
public static readonly long[] Value=A143337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143337.Bytes);
public long this[int i]=>Value[i];

public static A143337Inst Instance=new A143337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143338
{
public static readonly long[] Value={ 1L,1L,2L,8L,26L,127L,478L,2536L,10250L,56900L,239880L,1370272L,5940054L,34607146L,153018932L,904441648L,4058644842L,24254529036L,110096276440L,663665021280L,3040205250984L,18455364854839L,85176971647470L,520059936017128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143338Inst : IEnumerable<long>
{
public static readonly long[] Value=A143338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143338.Bytes);
public long this[int i]=>Value[i];

public static A143338Inst Instance=new A143338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143339
{
public static readonly long[] Value={ 1L,1L,3L,7L,25L,73L,283L,911L,3697L,12561L,52467L,184471L,785929L,2829401L,12229259L,44795167L,195742177L,726541345L,3202144483L,12010174247L,53300753657L,201608659561L,899838791419L,3427434566831L,15370709035601L,58890032580913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143339Inst : IEnumerable<long>
{
public static readonly long[] Value=A143339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143339.Bytes);
public long this[int i]=>Value[i];

public static A143339Inst Instance=new A143339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143340
{
public static readonly long[] Value={ 1L,1L,4L,15L,84L,402L,2520L,13339L,88484L,494814L,3395816L,19657398L,137999048L,818024484L,5836517808L,35201610387L,254231733188L,1553691459558L,11327637588552L,69948932919906L,513856752260184L,3199802098978428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143340Inst : IEnumerable<long>
{
public static readonly long[] Value=A143340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143340.Bytes);
public long this[int i]=>Value[i];

public static A143340Inst Instance=new A143340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143341
{
public static readonly long[] Value={ 1L,1L,5L,26L,195L,1303L,11076L,81910L,740151L,5782175L,54176573L,438029432L,4203769940L,34798104500L,339699218160L,2860590892318L,28283147265023L,241296800029199L,2409437282086511L,20767852798378330L,209017295575667771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143341Inst : IEnumerable<long>
{
public static readonly long[] Value=A143341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143341.Bytes);
public long this[int i]=>Value[i];

public static A143341Inst Instance=new A143341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143342
{
public static readonly long[] Value={ 1L,1L,6L,40L,374L,3215L,34298L,326360L,3710278L,37289620L,440121880L,4577214736L,55375589594L,589530372890L,7258264793564L,78597770766160L,980423896907046L,10754940952651740L,135521929778850952L,1501817992511869280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143342Inst : IEnumerable<long>
{
public static readonly long[] Value=A143342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143342.Bytes);
public long this[int i]=>Value[i];

public static A143342Inst Instance=new A143342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143343
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,1L,1L,1L,1L,2L,3L,1L,5L,1L,1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,1L,5L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,1L,1L,11L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,1L,5L,1L,7L,1L,1L,1L,1L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143343Inst : IEnumerable<long>
{
public static readonly long[] Value=A143343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143343.Bytes);
public long this[int i]=>Value[i];

public static A143343Inst Instance=new A143343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143344
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143344Inst : IEnumerable<long>
{
public static readonly long[] Value=A143344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143344.Bytes);
public long this[int i]=>Value[i];

public static A143344Inst Instance=new A143344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143345
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,4L,9L,13L,17L,19L,8L,15L,23L,29L,31L,14L,25L,27L,37L,41L,16L,35L,33L,43L,47L,26L,49L,45L,53L,59L,22L,61L,21L,65L,67L,32L,71L,51L,55L,73L,28L,79L,39L,83L,85L,38L,77L,69L,89L,97L,10L,91L,57L,101L,103L,20L,107L,63L,109L,113L,34L,95L,81L,121L,127L,46L,119L,75L,131L,137L,44L,133L,87L,115L,139L,52L,149L,93L,125L,151L,56L,143L,111L,145L,157L,62L,161L,99L,163L,167L,40L,169L,123L,173L,179L,50L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143345Inst : IEnumerable<long>
{
public static readonly long[] Value=A143345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143345.Bytes);
public long this[int i]=>Value[i];

public static A143345Inst Instance=new A143345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143346
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,12L,13L,14L,17L,18L,20L,22L,23L,26L,25L,29L,30L,32L,33L,36L,37L,37L,41L,42L,44L,45L,45L,51L,49L,53L,54L,53L,58L,57L,62L,62L,65L,63L,66L,70L,70L,72L,73L,74L,78L,77L,79L,84L,81L,86L,85L,90L,87L,93L,93L,94L,97L,99L,99L,100L,102L,105L,105L,109L,109L,109L,115L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143346Inst : IEnumerable<long>
{
public static readonly long[] Value=A143346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143346.Bytes);
public long this[int i]=>Value[i];

public static A143346Inst Instance=new A143346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143347
{
public static readonly long[] Value={ 8L,5L,0L,7L,3L,6L,1L,8L,8L,2L,0L,1L,8L,6L,7L,2L,6L,0L,3L,6L,7L,7L,9L,7L,7L,6L,0L,5L,3L,2L,0L,6L,6L,6L,0L,4L,4L,1L,1L,3L,9L,9L,4L,9L,3L,0L,8L,2L,7L,1L,0L,6L,4L,7L,7L,2L,8L,1L,6L,8L,2L,6L,1L,0L,3L,1L,8L,3L,0L,1L,5L,8L,4L,5L,9L,3L,1L,9L,4L,4L,5L,3L,4L,8L,5L,4L,5L,9L,8L,2L,6L,4L,2L,1L,9L,3L,9L,2L,3L,9L,9L,6L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143347Inst : IEnumerable<long>
{
public static readonly long[] Value=A143347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143347.Bytes);
public long this[int i]=>Value[i];

public static A143347Inst Instance=new A143347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143348
{
public static readonly long[] Value={ 1L,-3L,4L,-7L,6L,-12L,8L,-15L,13L,-18L,12L,-28L,14L,-24L,24L,-31L,18L,-39L,20L,-42L,32L,-36L,24L,-60L,31L,-42L,40L,-56L,30L,-72L,32L,-63L,48L,-54L,48L,-91L,38L,-60L,56L,-90L,42L,-96L,44L,-84L,78L,-72L,48L,-124L,57L,-93L,72L,-98L,54L,-120L,72L,-120L,80L,-90L,60L,-168L,62L,-96L,104L,-127L,84L,-144L,68L,-126L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143348Inst : IEnumerable<long>
{
public static readonly long[] Value=A143348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143348.Bytes);
public long this[int i]=>Value[i];

public static A143348Inst Instance=new A143348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143349
{
public static readonly long[] Value={ 1L,2L,-1L,3L,-1L,-1L,4L,-2L,-1L,0L,5L,-2L,-1L,0L,-1L,6L,-3L,-2L,0L,-1L,1L,7L,-3L,-2L,0L,-1L,1L,-1L,8L,-4L,-2L,0L,-1L,1L,-1L,0L,9L,-4L,-4L,0L,-1L,1L,-1L,0L,10L,-5L,-3L,0L,-2L,1L,-1L,0L,0L,1L,11L,-5L,-3L,0L,-2L,1L,-1L,0L,0L,1L,-1L,12L,-6L,-4L,0L,-2L,2L,-1L,0L,0L,1L,-1L,0L,13L,-6L,-4L,0L,-2L,2L,-1L,0L,0L,1L,-1L,0L,-1L,14L,-7L,-4L,0L,-2L,2L,-2L,0L,0L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143349Inst : IEnumerable<long>
{
public static readonly long[] Value=A143349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143349.Bytes);
public long this[int i]=>Value[i];

public static A143349Inst Instance=new A143349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143350
{
public static readonly long[] Value={ 2L,4L,-1L,7L,-1L,-1L,10L,-2L,-1L,0L,15L,-2L,-1L,0L,-1L,18L,-3L,-2L,0L,-1L,1L,23L,-3L,-2L,0L,-1L,1L,-1L,26L,-4L,-2L,0L,-1L,1L,-1L,0L,31L,-4L,-3L,0L,-1L,1L,-1L,0L,0L,38L,-5L,-3L,0L,-2L,1L,-1L,0L,0L,1L,41L,-5L,-3L,0L,-2L,1L,-1L,0L,0L,1L,-1L,48L,-6L,-4L,0L,-2L,2L,-1L,0L,0L,1L,-1L,0L,53L,-6L,-4L,0L,-2L,2L,-1L,0L,0L,1L,-1L,0L,-1L,56L,-7L,-4L,0L,-2L,2L,-2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143350Inst : IEnumerable<long>
{
public static readonly long[] Value=A143350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143350.Bytes);
public long this[int i]=>Value[i];

public static A143350Inst Instance=new A143350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143351
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,3L,1L,6L,3L,11L,7L,20L,15L,37L,32L,70L,68L,134L,141L,257L,288L,495L,583L,959L,1175L,1867L,2358L,3646L,4714L,7136L,9397L,13994L,18695L,27489L,37138L,54068L,73687L,106450L,146066L,209740L,289328L,413506L,572784L,815628L,1133455L,1609405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143351Inst : IEnumerable<long>
{
public static readonly long[] Value=A143351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143351.Bytes);
public long this[int i]=>Value[i];

public static A143351Inst Instance=new A143351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143480
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,72L,49L,104L,81L,160L,121L,348L,143L,322L,285L,352L,221L,648L,323L,800L,567L,814L,437L,1272L,575L,1066L,729L,1204L,667L,2370L,713L,1376L,1221L,1598L,1225L,2592L,1073L,2242L,1833L,2840L,1271L,4326L,1333L,2816L,2565L,2806L,1457L,4272L,1813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143480Inst : IEnumerable<long>
{
public static readonly long[] Value=A143480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143480.Bytes);
public long this[int i]=>Value[i];

public static A143480Inst Instance=new A143480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143481
{
public static readonly long[] Value={ 1L,2L,6L,8L,20L,24L,42L,48L,54L,64L,110L,112L,120L,132L,144L,160L,192L,216L,288L,320L,324L,360L,396L,416L,440L,480L,486L,504L,616L,624L,660L,672L,720L,736L,840L,864L,1008L,1044L,1104L,1120L,1200L,1224L,1260L,1280L,1296L,1320L,1380L,1408L,1512L,1560L,1632L,1680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143481Inst : IEnumerable<long>
{
public static readonly long[] Value=A143481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143481.Bytes);
public long this[int i]=>Value[i];

public static A143481Inst Instance=new A143481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143482
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,12L,7L,16L,27L,50L,33L,72L,39L,56L,45L,64L,51L,108L,57L,100L,105L,154L,115L,288L,125L,286L,243L,392L,203L,690L,217L,416L,363L,544L,455L,864L,407L,836L,663L,1000L,451L,1512L,559L,1276L,1125L,1334L,799L,2256L,931L,2000L,1377L,1924L,1007L,2862L,1375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143482Inst : IEnumerable<long>
{
public static readonly long[] Value=A143482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143482.Bytes);
public long this[int i]=>Value[i];

public static A143482Inst Instance=new A143482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143483
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,8L,18L,20L,20L,24L,24L,24L,24L,32L,32L,36L,36L,40L,48L,60L,88L,96L,100L,120L,162L,168L,168L,176L,180L,192L,220L,256L,288L,288L,360L,360L,384L,400L,400L,432L,504L,560L,600L,616L,736L,736L,756L,800L,864L,864L,936L,936L,1000L,1008L,1008L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143483Inst : IEnumerable<long>
{
public static readonly long[] Value=A143483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143483.Bytes);
public long this[int i]=>Value[i];

public static A143483Inst Instance=new A143483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143484
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143484Inst : IEnumerable<long>
{
public static readonly long[] Value=A143484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143484.Bytes);
public long this[int i]=>Value[i];

public static A143484Inst Instance=new A143484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143485
{
public static readonly long[] Value={ 2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143485Inst : IEnumerable<long>
{
public static readonly long[] Value=A143485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143485.Bytes);
public long this[int i]=>Value[i];

public static A143485Inst Instance=new A143485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143486
{
public static readonly long[] Value={ 3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L,4L,1L,1L,2L,2L,4L,1L,1L,4L,3L,3L,1L,1L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143486Inst : IEnumerable<long>
{
public static readonly long[] Value=A143486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143486.Bytes);
public long this[int i]=>Value[i];

public static A143486Inst Instance=new A143486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143487
{
public static readonly long[] Value={ 4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,3L,3L,3L,4L,4L,3L,3L,3L,2L,2L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143487Inst : IEnumerable<long>
{
public static readonly long[] Value=A143487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143487.Bytes);
public long this[int i]=>Value[i];

public static A143487Inst Instance=new A143487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143488
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143488Inst : IEnumerable<long>
{
public static readonly long[] Value=A143488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143488.Bytes);
public long this[int i]=>Value[i];

public static A143488Inst Instance=new A143488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143489
{
public static readonly long[] Value={ 2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143489Inst : IEnumerable<long>
{
public static readonly long[] Value=A143489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143489.Bytes);
public long this[int i]=>Value[i];

public static A143489Inst Instance=new A143489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143490
{
public static readonly long[] Value={ 3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143490Inst : IEnumerable<long>
{
public static readonly long[] Value=A143490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143490.Bytes);
public long this[int i]=>Value[i];

public static A143490Inst Instance=new A143490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143491
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,1L,24L,26L,9L,1L,120L,154L,71L,14L,1L,720L,1044L,580L,155L,20L,1L,5040L,8028L,5104L,1665L,295L,27L,1L,40320L,69264L,48860L,18424L,4025L,511L,35L,1L,362880L,663696L,509004L,214676L,54649L,8624L,826L,44L,1L,3628800L,6999840L,5753736L,2655764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143491Inst : IEnumerable<long>
{
public static readonly long[] Value=A143491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143491.Bytes);
public long this[int i]=>Value[i];

public static A143491Inst Instance=new A143491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143492
{
public static readonly long[] Value={ 1L,3L,1L,12L,7L,1L,60L,47L,12L,1L,360L,342L,119L,18L,1L,2520L,2754L,1175L,245L,25L,1L,20160L,24552L,12154L,3135L,445L,33L,1L,181440L,241128L,133938L,40369L,7140L,742L,42L,1L,1814400L,2592720L,1580508L,537628L,111769L,14560L,1162L,52L,1L,19958400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143492Inst : IEnumerable<long>
{
public static readonly long[] Value=A143492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143492.Bytes);
public long this[int i]=>Value[i];

public static A143492Inst Instance=new A143492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143493
{
public static readonly long[] Value={ 1L,4L,1L,20L,9L,1L,120L,74L,15L,1L,840L,638L,179L,22L,1L,6720L,5944L,2070L,355L,30L,1L,60480L,60216L,24574L,5265L,625L,39L,1L,604800L,662640L,305956L,77224L,11515L,1015L,49L,1L,6652800L,7893840L,4028156L,1155420L,203889L,22680L,1554L,60L,1L,79833600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143493Inst : IEnumerable<long>
{
public static readonly long[] Value=A143493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143493.Bytes);
public long this[int i]=>Value[i];

public static A143493Inst Instance=new A143493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143494
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,1L,8L,19L,9L,1L,16L,65L,55L,14L,1L,32L,211L,285L,125L,20L,1L,64L,665L,1351L,910L,245L,27L,1L,128L,2059L,6069L,5901L,2380L,434L,35L,1L,256L,6305L,26335L,35574L,20181L,5418L,714L,44L,1L,512L,19171L,111645L,204205L,156660L,58107L,11130L,1110L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143494Inst : IEnumerable<long>
{
public static readonly long[] Value=A143494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143494.Bytes);
public long this[int i]=>Value[i];

public static A143494Inst Instance=new A143494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143495
{
public static readonly long[] Value={ 1L,3L,1L,9L,7L,1L,27L,37L,12L,1L,81L,175L,97L,18L,1L,243L,781L,660L,205L,25L,1L,729L,3367L,4081L,1890L,380L,33L,1L,2187L,14197L,23772L,15421L,4550L,644L,42L,1L,6561L,58975L,133057L,116298L,47271L,9702L,1022L,52L,1L,19683L,242461L,724260L,830845L,447195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143495Inst : IEnumerable<long>
{
public static readonly long[] Value=A143495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143495.Bytes);
public long this[int i]=>Value[i];

public static A143495Inst Instance=new A143495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143560
{
public static readonly long[] Value={ 1L,1L,3L,6L,16L,38L,110L,276L,818L,2158L,6528L,17766L,54622L,151852L,472674L,1334886L,4195328L,11992486L,37981982L,109622228L,349384626L,1016304750L,3256170672L,9533400198L,30680043630L,90318157804L,291763419458L,862944630022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143560Inst : IEnumerable<long>
{
public static readonly long[] Value=A143560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143560.Bytes);
public long this[int i]=>Value[i];

public static A143560Inst Instance=new A143560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143561
{
public static readonly long[] Value={ 1L,2L,9L,24L,88L,280L,1064L,3672L,14456L,52184L,210504L,782232L,3210904L,12176792L,50638440L,194956248L,818961080L,3189915224L,13508052104L,53105011480L,226355549400L,896636646936L,3842662060200L,15317408281944L,65946510374136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143561Inst : IEnumerable<long>
{
public static readonly long[] Value=A143561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143561.Bytes);
public long this[int i]=>Value[i];

public static A143561Inst Instance=new A143561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143562
{
public static readonly long[] Value={ 1L,1L,5L,17L,105L,481L,3261L,16801L,119697L,656129L,4819061L,27447601L,205776121L,1202943457L,9152680109L,54524185409L,419491297313L,2534963932417L,19673179986661L,120224135048273L,939543098579081L,5793676726569697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143562Inst : IEnumerable<long>
{
public static readonly long[] Value=A143562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143562.Bytes);
public long this[int i]=>Value[i];

public static A143562Inst Instance=new A143562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143563
{
public static readonly long[] Value={ 1L,1L,6L,29L,242L,1554L,14476L,104061L,1024122L,7818662L,79523444L,630256402L,6552401972L,53271202948L,562560238232L,4658979320605L,49780348483530L,418091057783582L,4508111500966628L,38281314209625862L,415790041176520092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143563Inst : IEnumerable<long>
{
public static readonly long[] Value=A143563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143563.Bytes);
public long this[int i]=>Value[i];

public static A143563Inst Instance=new A143563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143564
{
public static readonly long[] Value={ 1L,1L,7L,31L,273L,1697L,16471L,116159L,1186081L,8928193L,94017703L,736522975L,7917810225L,63722594657L,695248655095L,5705316231551L,62944217175617L,524183926274433L,5833380674885959L,49141433498848159L,550674827214221137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143564Inst : IEnumerable<long>
{
public static readonly long[] Value=A143564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143564.Bytes);
public long this[int i]=>Value[i];

public static A143564Inst Instance=new A143564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143565
{
public static readonly long[] Value={ 1L,3L,1L,16L,4L,1L,125L,13L,5L,1L,1296L,46L,21L,6L,1L,16807L,241L,61L,31L,7L,1L,262144L,1471L,211L,106L,43L,8L,1L,4782969L,9409L,1401L,281L,169L,57L,9L,1L,100000000L,67348L,8065L,946L,505L,253L,73L,10L,1L,2357947691L,564841L,37241L,7561L,1261L,841L,361L,91L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143565Inst : IEnumerable<long>
{
public static readonly long[] Value=A143565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143565.Bytes);
public long this[int i]=>Value[i];

public static A143565Inst Instance=new A143565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143566
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,13L,46L,241L,1471L,9409L,67348L,564841L,4771801L,45459481L,463867834L,5060656693L,58878140686L,730612429681L,9556314730456L,131627520296929L,1912237000523623L,29032781640572881L,462811831018070206L,7687624300327129621L,BigInteger.Parse("133275225843052767244") };
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
public class A143566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143566Inst Instance=new A143566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143567
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,21L,61L,211L,1401L,8065L,37241L,240021L,1997821L,14657501L,105629525L,958412911L,9201199281L,86311594881L,871038486001L,9432024424585L,106531641929781L,1271523772132741L,15583607760968941L,194983864950339851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143567Inst : IEnumerable<long>
{
public static readonly long[] Value=A143567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143567.Bytes);
public long this[int i]=>Value[i];

public static A143567Inst Instance=new A143567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143568
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,31L,106L,281L,946L,7561L,54286L,281161L,1207636L,7997991L,81996916L,701522641L,4580581916L,29742355441L,306369616636L,3632198902321L,34977922146721L,282526761829621L,2720464688299821L,36188717552636881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143568Inst : IEnumerable<long>
{
public static readonly long[] Value=A143568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143568.Bytes);
public long this[int i]=>Value[i];

public static A143568Inst Instance=new A143568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143569
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,7L,43L,169L,505L,1261L,4159L,38809L,334621L,2036035L,9489481L,38390353L,257371297L,3131783929L,32230292725L,246760346161L,1493969858641L,9196517088991L,101815213853431L,1450104259874425L,16645720979718601L,147298665834676357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143569Inst : IEnumerable<long>
{
public static readonly long[] Value=A143569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143569.Bytes);
public long this[int i]=>Value[i];

public static A143569Inst Instance=new A143569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143570
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,8L,57L,253L,841L,2311L,5545L,18019L,192193L,1936936L,13533521L,71607537L,308979217L,1195354525L,8070684721L,113661781381L,1368278263969L,12100291273456L,83294670263113L,474179436692501L,2787857745272601L,32561274444909211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143570Inst : IEnumerable<long>
{
public static readonly long[] Value=A143570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143570.Bytes);
public long this[int i]=>Value[i];

public static A143570Inst Instance=new A143570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143571
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,9L,73L,361L,1321L,3961L,10297L,24025L,77221L,926641L,10696401L,84365425L,499445857L,2395445521L,9778915441L,36584246161L,248210675593L,3971313933049L,54773770095001L,549282704399001L,4258482133019401L,27025791550397641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143571Inst : IEnumerable<long>
{
public static readonly long[] Value=A143571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143571.Bytes);
public long this[int i]=>Value[i];

public static A143571Inst Instance=new A143571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143572
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,91L,496L,1981L,6436L,18019L,45046L,102961L,328186L,4375801L,56951038L,500352841L,3276290746L,17289324361L,77309034166L,302908144177L,1104328093276L,7519851360451L,134741602227376L,2095457847783301L,23492070829121896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143572Inst : IEnumerable<long>
{
public static readonly long[] Value=A143572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143572.Bytes);
public long this[int i]=>Value[i];

public static A143572Inst Instance=new A143572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143573
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,111L,661L,2861L,10011L,30031L,80081L,194481L,437581L,1385671L,20323161L,294517861L,2851708861L,20461620411L,117812647921L,572637720601L,2430703053351L,9228958338601L,32965820988101L,225123959060001L,4466029537119151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143573Inst : IEnumerable<long>
{
public static readonly long[] Value=A143573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143573.Bytes);
public long this[int i]=>Value[i];

public static A143573Inst Instance=new A143573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143574
{
public static readonly long[] Value={ 0L,1L,1L,0L,4L,5L,0L,0L,4L,9L,10L,0L,0L,13L,0L,0L,16L,17L,9L,0L,20L,0L,0L,0L,0L,50L,26L,0L,0L,29L,0L,0L,16L,0L,34L,0L,36L,37L,0L,0L,40L,41L,0L,0L,0L,45L,0L,0L,0L,49L,75L,0L,52L,53L,0L,0L,0L,0L,58L,0L,0L,61L,0L,0L,64L,130L,0L,0L,68L,0L,0L,0L,36L,73L,74L,0L,0L,0L,0L,0L,80L,81L,82L,0L,0L,170L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143574Inst : IEnumerable<long>
{
public static readonly long[] Value=A143574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143574.Bytes);
public long this[int i]=>Value[i];

public static A143574Inst Instance=new A143574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143575
{
public static readonly long[] Value={ 0L,1L,4L,5L,9L,10L,13L,16L,17L,20L,26L,29L,34L,36L,37L,40L,41L,45L,49L,52L,53L,58L,61L,64L,68L,73L,74L,80L,81L,82L,89L,90L,97L,101L,104L,106L,109L,113L,116L,117L,121L,122L,136L,137L,144L,146L,148L,149L,153L,157L,160L,164L,173L,178L,180L,181L,193L,194L,196L,197L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143575Inst : IEnumerable<long>
{
public static readonly long[] Value=A143575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143575.Bytes);
public long this[int i]=>Value[i];

public static A143575Inst Instance=new A143575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143608
{
public static readonly long[] Value={ 0L,1L,4L,7L,24L,41L,140L,239L,816L,1393L,4756L,8119L,27720L,47321L,161564L,275807L,941664L,1607521L,5488420L,9369319L,31988856L,54608393L,186444716L,318281039L,1086679440L,1855077841L,6333631924L,10812186007L,36915112104L,63018038201L,215157040700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143608Inst : IEnumerable<long>
{
public static readonly long[] Value=A143608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143608.Bytes);
public long this[int i]=>Value[i];

public static A143608Inst Instance=new A143608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143609
{
public static readonly long[] Value={ 2L,3L,10L,17L,58L,99L,338L,577L,1970L,3363L,11482L,19601L,66922L,114243L,390050L,665857L,2273378L,3880899L,13250218L,22619537L,77227930L,131836323L,450117362L,768398401L,2623476242L,4478554083L,15290740090L,26102926097L,89120964298L,152139002499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143609Inst : IEnumerable<long>
{
public static readonly long[] Value=A143609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143609.Bytes);
public long this[int i]=>Value[i];

public static A143609Inst Instance=new A143609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143610
{
public static readonly long[] Value={ 72L,108L,200L,392L,500L,675L,968L,1125L,1323L,1352L,1372L,2312L,2888L,3087L,3267L,4232L,4563L,5324L,6125L,6728L,7688L,7803L,8575L,8788L,9747L,10952L,11979L,13448L,14283L,14792L,15125L,17672L,19652L,19773L,21125L,22472L,22707L,25947L,27436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143610Inst : IEnumerable<long>
{
public static readonly long[] Value=A143610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143610.Bytes);
public long this[int i]=>Value[i];

public static A143610Inst Instance=new A143610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143611
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,8L,11L,14L,18L,23L,29L,36L,45L,55L,67L,82L,99L,120L,144L,173L,207L,247L,295L,351L,417L,495L,587L,695L,823L,973L,1150L,1358L,1603L,1892L,2231L,2631L,3101L,3654L,4305L,5071L,5972L,7032L,8279L,9746L,11472L,13502L,15891L,18700L,22005L,25893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143611Inst : IEnumerable<long>
{
public static readonly long[] Value=A143611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143611.Bytes);
public long this[int i]=>Value[i];

public static A143611Inst Instance=new A143611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143612
{
public static readonly long[] Value={ 1L,1L,0L,3L,2L,0L,4L,3L,3L,0L,10L,9L,7L,4L,0L,6L,5L,5L,5L,5L,0L,21L,20L,18L,15L,11L,6L,0L,16L,15L,15L,12L,12L,7L,7L,0L,27L,26L,24L,24L,20L,15L,15L,8L,0L,20L,19L,19L,16L,16L,16L,16L,9L,9L,0L,55L,54L,52L,49L,45L,40L,34L,27L,19L,10L,0L,24L,23L,23L,23L,23L,18L,18L,11L,11L,11L,11L,0L,78L,77L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143612Inst : IEnumerable<long>
{
public static readonly long[] Value=A143612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143612.Bytes);
public long this[int i]=>Value[i];

public static A143612Inst Instance=new A143612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143613
{
public static readonly long[] Value={ 1L,2L,0L,2L,2L,0L,3L,0L,3L,0L,2L,2L,3L,4L,0L,4L,2L,0L,0L,5L,0L,2L,2L,3L,4L,5L,6L,0L,4L,0L,6L,0L,5L,0L,7L,0L,3L,4L,0L,4L,5L,0L,7L,8L,0L,4L,2L,6L,4L,0L,0L,7L,0L,9L,0L,2L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,6L,2L,3L,0L,10L,0L,7L,0L,0L,0L,11L,2L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143613Inst : IEnumerable<long>
{
public static readonly long[] Value=A143613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143613.Bytes);
public long this[int i]=>Value[i];

public static A143613Inst Instance=new A143613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143614
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,2L,0L,1L,0L,4L,2L,1L,1L,0L,2L,0L,0L,0L,1L,0L,6L,3L,2L,1L,1L,1L,0L,4L,0L,1L,0L,1L,0L,1L,0L,6L,3L,0L,2L,1L,0L,1L,1L,0L,4L,0L,2L,0L,0L,0L,1L,0L,1L,0L,10L,5L,3L,2L,2L,1L,1L,1L,1L,1L,0L,4L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,12L,6L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,0L,6L,0L,2L,0L,10L,0L,0L,1L,0L,10L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143614Inst : IEnumerable<long>
{
public static readonly long[] Value=A143614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143614.Bytes);
public long this[int i]=>Value[i];

public static A143614Inst Instance=new A143614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143615
{
public static readonly long[] Value={ 1L,1L,3L,3L,8L,3L,14L,7L,14L,8L,27L,7L,35L,12L,20L,18L,50L,11L,58L,16L,35L,24L,74L,15L,68L,29L,54L,29L,101L,15L,111L,39L,64L,41L,84L,26L,140L,47L,78L,40L,158L,24L,168L,51L,75L,61L,186L,34L,170L,49L,111L,66L,217L,39L,160L,65L,131L,80L,247L,32L,261L,84L,122L,92L,197L,45L,292L,92L,162L,60L,312L,55L,326L,104L,135L,106L,263L,55L,356L,85L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143615Inst : IEnumerable<long>
{
public static readonly long[] Value=A143615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143615.Bytes);
public long this[int i]=>Value[i];

public static A143615Inst Instance=new A143615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143616
{
public static readonly long[] Value={ 6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143616Inst : IEnumerable<long>
{
public static readonly long[] Value=A143616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143616.Bytes);
public long this[int i]=>Value[i];

public static A143616Inst Instance=new A143616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143617
{
public static readonly long[] Value={ 0L,8L,10L,18L,20L,28L,68L,88L,108L,188L,200L,208L,288L,688L,888L,1088L,1888L,2008L,2088L,2888L,6888L,8888L,10888L,18888L,20088L,20888L,28888L,68888L,88888L,108888L,188888L,200888L,208888L,288888L,688888L,888888L,1088888L,1888888L,2008888L,2088888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143617Inst : IEnumerable<long>
{
public static readonly long[] Value=A143617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143617.Bytes);
public long this[int i]=>Value[i];

public static A143617Inst Instance=new A143617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143618
{
public static readonly long[] Value={ 5L,8L,7L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143618Inst : IEnumerable<long>
{
public static readonly long[] Value=A143618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143618.Bytes);
public long this[int i]=>Value[i];

public static A143618Inst Instance=new A143618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143619
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,1L,2L,1L,3L,2L,4L,3L,5L,5L,6L,8L,9L,12L,13L,17L,19L,24L,28L,34L,41L,49L,59L,71L,86L,103L,124L,149L,179L,215L,259L,311L,375L,450L,542L,651L,784L,942L,1133L,1363L,1638L,1971L,2369L,2851L,3427L,4123L,4957L,5962L,7170L,8622L,10370L,12470L,14998L,18035L,21691L,26085L,31371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143619Inst : IEnumerable<long>
{
public static readonly long[] Value=A143619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143619.Bytes);
public long this[int i]=>Value[i];

public static A143619Inst Instance=new A143619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143620
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,2L,1L,0L,0L,4L,1L,1L,0L,0L,2L,1L,1L,1L,0L,0L,6L,2L,2L,1L,1L,0L,0L,4L,3L,2L,2L,1L,1L,0L,0L,6L,2L,4L,2L,2L,1L,1L,0L,0L,4L,3L,1L,2L,2L,1L,1L,1L,0L,0L,10L,4L,5L,3L,4L,1L,3L,1L,1L,0L,0L,4L,3L,3L,3L,2L,2L,1L,1L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143620Inst : IEnumerable<long>
{
public static readonly long[] Value=A143620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143620.Bytes);
public long this[int i]=>Value[i];

public static A143620Inst Instance=new A143620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143621
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143621Inst : IEnumerable<long>
{
public static readonly long[] Value=A143621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143621.Bytes);
public long this[int i]=>Value[i];

public static A143621Inst Instance=new A143621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143622
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143622Inst : IEnumerable<long>
{
public static readonly long[] Value=A143622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143622.Bytes);
public long this[int i]=>Value[i];

public static A143622Inst Instance=new A143622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143623
{
public static readonly long[] Value={ 1L,3L,8L,1L,7L,7L,3L,2L,9L,0L,6L,7L,6L,0L,3L,6L,2L,2L,4L,0L,5L,3L,4L,3L,8L,9L,2L,9L,0L,7L,3L,2L,7L,5L,6L,0L,3L,3L,5L,4L,8L,7L,3L,4L,8L,1L,4L,1L,6L,2L,9L,3L,2L,9L,3L,3L,4L,2L,8L,4L,8L,9L,6L,5L,3L,7L,3L,0L,1L,0L,7L,9L,9L,1L,6L,5L,7L,1L,1L,4L,3L,3L,4L,6L,6L,5L,9L,1L,5L,9L,9L,6L,3L,0L,2L,3L,5L,7L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143623Inst : IEnumerable<long>
{
public static readonly long[] Value=A143623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143623.Bytes);
public long this[int i]=>Value[i];

public static A143623Inst Instance=new A143623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143624
{
public static readonly long[] Value={ 3L,0L,1L,1L,6L,8L,6L,7L,8L,9L,3L,9L,7L,5L,6L,7L,8L,9L,2L,5L,1L,5L,6L,5L,7L,1L,4L,1L,8L,7L,3L,2L,2L,3L,9L,5L,8L,9L,0L,2L,5L,2L,6L,4L,0L,1L,8L,0L,4L,4L,8L,8L,3L,8L,0L,0L,2L,6L,5L,4L,4L,5L,4L,6L,1L,0L,8L,1L,0L,0L,0L,9L,6L,1L,6L,7L,6L,7L,9L,0L,4L,4L,3L,0L,6L,8L,7L,8L,8L,7L,4L,5L,5L,8L,6L,9L,6L,0L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143624Inst : IEnumerable<long>
{
public static readonly long[] Value=A143624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143624.Bytes);
public long this[int i]=>Value[i];

public static A143624Inst Instance=new A143624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143625
{
public static readonly long[] Value={ 2L,2L,8L,4L,9L,4L,2L,3L,8L,2L,4L,0L,9L,6L,3L,5L,2L,0L,8L,9L,9L,9L,0L,5L,0L,0L,1L,9L,2L,6L,3L,0L,8L,2L,7L,0L,2L,1L,6L,1L,5L,1L,3L,2L,6L,2L,9L,9L,4L,9L,5L,8L,9L,7L,8L,5L,9L,8L,2L,8L,8L,9L,8L,0L,0L,3L,7L,3L,7L,1L,0L,1L,5L,7L,5L,1L,9L,7L,3L,4L,5L,9L,4L,0L,3L,7L,4L,4L,9L,5L,1L,2L,5L,2L,4L,6L,3L,4L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143625Inst : IEnumerable<long>
{
public static readonly long[] Value=A143625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143625.Bytes);
public long this[int i]=>Value[i];

public static A143625Inst Instance=new A143625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143626
{
public static readonly long[] Value={ 1L,3L,0L,1L,5L,5L,9L,4L,9L,5L,9L,8L,2L,9L,7L,9L,6L,0L,2L,8L,4L,3L,0L,4L,2L,7L,0L,8L,2L,5L,5L,1L,9L,9L,2L,7L,4L,2L,3L,4L,9L,4L,6L,9L,7L,2L,9L,6L,4L,7L,7L,1L,7L,0L,0L,7L,4L,7L,5L,5L,3L,4L,1L,4L,2L,0L,7L,7L,2L,4L,0L,7L,2L,9L,9L,2L,5L,4L,4L,6L,4L,4L,4L,3L,7L,4L,5L,3L,0L,1L,0L,3L,2L,0L,4L,9L,5L,8L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143626Inst : IEnumerable<long>
{
public static readonly long[] Value=A143626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143626.Bytes);
public long this[int i]=>Value[i];

public static A143626Inst Instance=new A143626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143627
{
public static readonly long[] Value={ 6L,8L,6L,0L,5L,6L,0L,5L,0L,7L,2L,7L,7L,6L,6L,3L,1L,8L,2L,8L,2L,5L,5L,9L,1L,6L,7L,4L,0L,8L,7L,7L,6L,7L,1L,3L,7L,5L,4L,1L,9L,1L,8L,1L,3L,9L,6L,6L,3L,5L,2L,2L,5L,7L,4L,0L,4L,6L,5L,4L,6L,5L,0L,0L,7L,5L,5L,3L,8L,6L,2L,5L,9L,7L,8L,0L,1L,5L,6L,3L,2L,8L,2L,8L,3L,0L,8L,3L,4L,3L,7L,3L,4L,4L,4L,7L,8L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143627Inst : IEnumerable<long>
{
public static readonly long[] Value=A143627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143627.Bytes);
public long this[int i]=>Value[i];

public static A143627Inst Instance=new A143627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143628
{
public static readonly long[] Value={ 1L,0L,0L,-1L,-6L,-25L,-89L,-280L,-700L,-380L,13452L,149831L,1214852L,8700263L,57515640L,351296151L,1909757620L,8017484274L,5703377941L,-428273438434L,-7295220035921L,-89868583754993L,-970185398785810L,-9657428906237364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143628Inst : IEnumerable<long>
{
public static readonly long[] Value=A143628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143628.Bytes);
public long this[int i]=>Value[i];

public static A143628Inst Instance=new A143628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143629
{
public static readonly long[] Value={ 0L,1L,0L,-2L,-7L,-23L,-80L,-271L,-750L,-647L,13039L,152011L,1232583L,8750796L,57405464L,349329354L,1899818951L,8008845556L,5981853002L,-425732481925L,-7285403175563L,-89895756043392L,-970910901819211L,-9663021449412616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143629Inst : IEnumerable<long>
{
public static readonly long[] Value=A143629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143629.Bytes);
public long this[int i]=>Value[i];

public static A143629Inst Instance=new A143629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143630
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,14L,16L,-77L,-922L,-6660L,-41264L,-233828L,-1218392L,-5607225L,-19220589L,4397930L,1016675382L,14251497833L,151695504253L,1432992328055L,12527186450276L,102042171190168L,760272520469199L,4849866087637364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143630Inst : IEnumerable<long>
{
public static readonly long[] Value=A143630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143630.Bytes);
public long this[int i]=>Value[i];

public static A143630Inst Instance=new A143630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143631
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,-9L,-64L,-348L,-1672L,-7307L,-28225L,-81817L,14191L,3143571L,38184875L,353727284L,2916494333L,22260343389L,157677357255L,1007259846130L,5241783274713L,12146415146776L,-210638381350012L,-4813155361775252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143631Inst : IEnumerable<long>
{
public static readonly long[] Value=A143631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143631.Bytes);
public long this[int i]=>Value[i];

public static A143631Inst Instance=new A143631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143632
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,16L,1L,1L,1L,3L,19L,125L,1L,1L,1L,3L,22L,185L,1296L,1L,1L,1L,3L,25L,253L,2541L,16807L,1L,1L,1L,3L,28L,329L,4256L,45787L,262144L,1L,1L,1L,3L,31L,413L,6471L,96727L,1037359L,4782969L,1L,1L,1L,3L,34L,505L,9216L,175747L,2828274L,28649553L,100000000L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143632Inst : IEnumerable<long>
{
public static readonly long[] Value=A143632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143632.Bytes);
public long this[int i]=>Value[i];

public static A143632Inst Instance=new A143632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143633
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,185L,2541L,45787L,1037359L,28649553L,942585625L,36294146171L,1612599520599L,81729515092777L,4679679856932133L,300257015404355115L,BigInteger.Parse("21436580394615666991"),BigInteger.Parse("1692530428442960006753"),BigInteger.Parse("146987828523665177048241") };
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
public class A143633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143633Inst Instance=new A143633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143634
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,253L,4256L,96727L,2828274L,102988937L,4553158024L,239618067211L,14775790894734L,1053758625896077L,85965003368491300L,7947211237328151167L,BigInteger.Parse("825821792546485330306"),BigInteger.Parse("95772123012223308982673") };
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
public class A143634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143634Inst Instance=new A143634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143635
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,329L,6471L,175747L,6222259L,277683681L,15206462497L,1000136567591L,77666331244239L,7021789807671817L,730394622232111747L,BigInteger.Parse("86529393614846902371"),BigInteger.Parse("11573498785704862459891"),BigInteger.Parse("1734360074041552070631713") };
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
public class A143635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143635Inst Instance=new A143635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143636
{
public static readonly BigInteger[] Value={ 1L,1L,3L,28L,413L,9216L,289111L,11925964L,624637785L,40422282112L,3159287760491L,292875271947468L,31733363437993285L,3969285168539789008L,BigInteger.Parse("567118401777735330447"),BigInteger.Parse("91714059231986721233596") };
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
public class A143636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143636Inst Instance=new A143636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143637
{
public static readonly BigInteger[] Value={ 1L,1L,3L,31L,505L,12521L,443227L,20766159L,1240975409L,92068494625L,8282460205891L,886498379552919L,111190541933344777L,16136424098890466281UL,BigInteger.Parse("2680205744964849259355"),BigInteger.Parse("504746978220729054647911"),BigInteger.Parse("106901213223866930807470433"),BigInteger.Parse("25280598116469824339521406081") };
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
public class A143637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143637Inst Instance=new A143637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143638
{
public static readonly BigInteger[] Value={ 1L,1L,3L,34L,605L,16416L,644647L,33690574L,2252245353L,187575203080L,19000833293771L,2295318297423834L,325536649109809117L,BigInteger.Parse("53508774130762119508"),BigInteger.Parse("10080999100649218887615"),BigInteger.Parse("2156137639664134179951166"),BigInteger.Parse("519200838601168582073365073"),BigInteger.Parse("139740129055162031424178122096") };
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
public class A143638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143638Inst Instance=new A143638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143639
{
public static readonly BigInteger[] Value={ 1L,1L,3L,37L,713L,20931L,900067L,51768739L,3815631297L,351259985449L,39429531406511L,5287999813256799L,833815716731955817L,BigInteger.Parse("152569133029591977895"),BigInteger.Parse("32033950906843181020467"),BigInteger.Parse("7643291957710224206903131"),BigInteger.Parse("2055010408602517321146955553"),BigInteger.Parse("618032357523179035120686532401") };
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
public class A143639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143639Inst Instance=new A143639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143672
{
public static readonly BigInteger[] Value={ 1L,2L,4L,24L,816L,239968L,808814912L,38764383658368L,BigInteger.Parse("31491961129357837056"),BigInteger.Parse("503091371552266970507912704"),BigInteger.Parse("179763631086276515267399940231898112"),BigInteger.Parse("1609791936564515363272979180683040232936253440") };
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
public class A143672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143672Inst Instance=new A143672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143673
{
public static readonly long[] Value={ 2L,2L,3L,7L,42L,2361L,37620704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143673Inst : IEnumerable<long>
{
public static readonly long[] Value=A143673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143673.Bytes);
public long this[int i]=>Value[i];

public static A143673Inst Instance=new A143673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143674
{
public static readonly long[] Value={ 1L,1L,2L,4L,17L,379L,526913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143674Inst : IEnumerable<long>
{
public static readonly long[] Value=A143674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143674.Bytes);
public long this[int i]=>Value[i];

public static A143674Inst Instance=new A143674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143675
{
public static readonly BigInteger[] Value={ 0L,81L,390625L,5764801L,81L,BigInteger.Parse("3761581922631320025499956919111186169019729781670680068828005460090935230255126953125") };
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
public class A143675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143675Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143675.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143675Inst Instance=new A143675Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143676
{
public static readonly long[] Value={ 3L,1L,0L,2L,1L,8L,14L,8L,1L,12L,19L,6L,6L,18L,4L,14L,1L,24L,33L,6L,8L,4L,3L,16L,12L,43L,8L,39L,6L,20L,41L,6L,5L,16L,64L,4L,8L,7L,12L,55L,63L,32L,7L,12L,12L,63L,9L,10L,66L,72L,38L,1L,24L,6L,68L,4L,39L,79L,9L,28L,28L,97L,3L,15L,23L,30L,23L,6L,88L,3L,7L,98L,18L,98L,5L,48L,103L,109L,14L,36L,116L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143676Inst : IEnumerable<long>
{
public static readonly long[] Value=A143676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143676.Bytes);
public long this[int i]=>Value[i];

public static A143676Inst Instance=new A143676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143677
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,0L,0L,6L,0L,10L,5L,2L,2L,15L,1L,17L,3L,4L,9L,21L,0L,3L,11L,0L,0L,22L,1L,26L,3L,8L,15L,2L,0L,1L,35L,16L,11L,2L,39L,4L,41L,9L,1L,3L,24L,2L,4L,0L,3L,14L,0L,40L,1L,2L,9L,4L,16L,27L,57L,1L,56L,29L,1L,5L,1L,11L,8L,65L,15L,20L,3L,64L,1L,1L,71L,34L,3L,0L,12L,9L,10L,77L,1L,1L,39L,81L,1L,2L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143677Inst : IEnumerable<long>
{
public static readonly long[] Value=A143677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143677.Bytes);
public long this[int i]=>Value[i];

public static A143677Inst Instance=new A143677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143678
{
public static readonly long[] Value={ 2L,5L,6L,2L,5L,11L,8L,9L,15L,1L,19L,9L,14L,2L,5L,13L,7L,30L,24L,13L,10L,7L,38L,14L,14L,34L,39L,11L,6L,26L,1L,7L,6L,17L,38L,5L,12L,23L,32L,3L,54L,30L,11L,6L,59L,17L,18L,69L,2L,69L,39L,2L,23L,12L,81L,6L,44L,3L,19L,38L,30L,76L,6L,4L,18L,76L,12L,99L,3L,12L,5L,97L,89L,12L,5L,56L,3L,104L,3L,39L,104L,11L,23L,28L,70L,8L,5L,11L,99L,31L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143678Inst : IEnumerable<long>
{
public static readonly long[] Value=A143678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143678.Bytes);
public long this[int i]=>Value[i];

public static A143678Inst Instance=new A143678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143679
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,15L,15L,1L,1L,22L,78L,22L,1L,1L,29L,190L,190L,29L,1L,1L,36L,351L,848L,351L,36L,1L,1L,43L,561L,2339L,2339L,561L,43L,1L,1L,50L,820L,5006L,9766L,5006L,820L,50L,1L,1L,57L,1128L,9192L,28806L,28806L,9192L,1128L,57L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143679Inst : IEnumerable<long>
{
public static readonly long[] Value=A143679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143679.Bytes);
public long this[int i]=>Value[i];

public static A143679Inst Instance=new A143679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143680
{
public static readonly long[] Value={ 3L,4L,11L,16L,320L,438L,1302L,1594L,3324L,8235L,9417L,17950L,24759L,27349L,36252L,55002L,78861L,84711L,115866L,138056L,146440L,190374L,220857L,277626L,370572L,417629L,435933L,488096L,507799L,565157L,850338L,930999L,1072092L,1107343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143680Inst : IEnumerable<long>
{
public static readonly long[] Value=A143680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143680.Bytes);
public long this[int i]=>Value[i];

public static A143680Inst Instance=new A143680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143681
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,1L,1L,17L,17L,1L,1L,25L,97L,25L,1L,1L,33L,241L,241L,33L,1L,1L,41L,449L,1161L,449L,41L,1L,1L,49L,721L,3297L,3297L,721L,49L,1L,1L,57L,1057L,7161L,14721L,7161L,1057L,57L,1L,1L,65L,1457L,13265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143681Inst : IEnumerable<long>
{
public static readonly long[] Value=A143681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143681.Bytes);
public long this[int i]=>Value[i];

public static A143681Inst Instance=new A143681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143682
{
public static readonly long[] Value={ 7L,14L,103L,391L,5002L,8967L,31065L,45724L,107077L,301276L,382000L,820141L,1246909L,1479730L,2129740L,3534420L,5523879L,6237871L,9209731L,11625564L,12865129L,17844972L,21754756L,28999632L,41437737L,48684207L,52341667L,60941856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143682Inst : IEnumerable<long>
{
public static readonly long[] Value=A143682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143682.Bytes);
public long this[int i]=>Value[i];

public static A143682Inst Instance=new A143682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143683
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,19L,19L,1L,1L,28L,118L,28L,1L,1L,37L,298L,298L,37L,1L,1L,46L,559L,1540L,559L,46L,1L,1L,55L,901L,4483L,4483L,901L,55L,1L,1L,64L,1324L,9856L,21286L,9856L,1324L,64L,1L,1L,73L,1828L,18388L,67006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143683Inst : IEnumerable<long>
{
public static readonly long[] Value=A143683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143683.Bytes);
public long this[int i]=>Value[i];

public static A143683Inst Instance=new A143683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143684
{
public static readonly BigInteger[] Value={ 0L,0L,1L,1L,3L,7L,43L,603L,51859L,62541955L,6486726488691L,BigInteger.Parse("811385112306041061811"),BigInteger.Parse("10526466601050236861337066646958803"),BigInteger.Parse("17082036570557873538131893815781561362696563088187144467"),BigInteger.Parse("359626974875792367278553795120318710475396935851854517275793126801351587742904492716786003") };
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
public class A143684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143684Inst Instance=new A143684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143685
{
public static readonly long[] Value={ 1L,1L,1L,1L,11L,1L,1L,21L,21L,1L,1L,31L,141L,31L,1L,1L,41L,361L,361L,41L,1L,1L,51L,681L,1991L,681L,51L,1L,1L,61L,1101L,5921L,5921L,1101L,61L,1L,1L,71L,1621L,13151L,29761L,13151L,1621L,71L,1L,1L,81L,2241L,24681L,96201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143685Inst : IEnumerable<long>
{
public static readonly long[] Value=A143685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143685.Bytes);
public long this[int i]=>Value[i];

public static A143685Inst Instance=new A143685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143686
{
public static readonly long[] Value={ 5575680L,13620639744L,21296209880678400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143686Inst : IEnumerable<long>
{
public static readonly long[] Value=A143686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143686.Bytes);
public long this[int i]=>Value[i];

public static A143686Inst Instance=new A143686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143687
{
public static readonly long[] Value={ 4920320L,12681574400L,20926651432960000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143687Inst : IEnumerable<long>
{
public static readonly long[] Value=A143687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143687.Bytes);
public long this[int i]=>Value[i];

public static A143687Inst Instance=new A143687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143720
{
public static readonly long[] Value={ 8L,9L,16L,18L,25L,27L,32L,40L,45L,49L,50L,54L,56L,60L,63L,64L,75L,80L,81L,84L,88L,90L,96L,98L,99L,104L,108L,112L,117L,120L,121L,125L,126L,128L,132L,135L,136L,140L,147L,150L,152L,153L,156L,160L,162L,168L,169L,171L,175L,176L,180L,184L,189L,192L,198L,200L,204L,207L,208L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143720Inst : IEnumerable<long>
{
public static readonly long[] Value=A143720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143720.Bytes);
public long this[int i]=>Value[i];

public static A143720Inst Instance=new A143720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143721
{
public static readonly long[] Value={ 38L,22L,14L,10L,8L,7L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143721Inst : IEnumerable<long>
{
public static readonly long[] Value=A143721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143721.Bytes);
public long this[int i]=>Value[i];

public static A143721Inst Instance=new A143721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143722
{
public static readonly long[] Value={ 48L,76L,64L,63L,41L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143722Inst : IEnumerable<long>
{
public static readonly long[] Value=A143722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143722.Bytes);
public long this[int i]=>Value[i];

public static A143722Inst Instance=new A143722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143723
{
public static readonly long[] Value={ 52L,46L,26L,16L,15L,9L,4L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143723Inst : IEnumerable<long>
{
public static readonly long[] Value=A143723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143723.Bytes);
public long this[int i]=>Value[i];

public static A143723Inst Instance=new A143723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143724
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,4L,1L,2L,0L,5L,1L,0L,0L,0L,9L,1L,2L,4L,0L,0L,7L,1L,0L,0L,0L,0L,0L,15L,1L,2L,0L,5L,0L,0L,0L,12L,1L,0L,4L,0L,0L,0L,0L,0L,18L,1L,2L,0L,0L,9L,0L,0L,0L,0L,15L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,28L,1L,2L,4L,5L,0L,7L,0L,0L,0L,0L,0L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143724Inst : IEnumerable<long>
{
public static readonly long[] Value=A143724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143724.Bytes);
public long this[int i]=>Value[i];

public static A143724Inst Instance=new A143724Inst();

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