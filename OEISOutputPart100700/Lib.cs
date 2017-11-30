using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A121379
{
public static readonly long[] Value={ 218L,219L,220L,221L,222L,223L,224L,225L,226L,227L,228L,229L,230L,231L,232L,233L,234L,235L,236L,237L,238L,239L,240L,241L,242L,246L,248L,250L,253L,254L,257L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121379Inst : IEnumerable<long>
{
public static readonly long[] Value=A121379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121379.Bytes);
public long this[int i]=>Value[i];

public static A121379Inst Instance=new A121379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121380
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,5L,8L,0L,7L,10L,23L,0L,26L,8L,0L,0L,68L,16L,57L,0L,0L,56L,139L,0L,100L,52L,75L,0L,174L,0L,123L,0L,0L,136L,0L,0L,222L,114L,0L,0L,328L,0L,257L,0L,0L,208L,612L,0L,300L,200L,0L,0L,636L,156L,0L,0L,0L,348L,886L,0L,488L,216L,0L,0L,0L,0L,669L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121380Inst : IEnumerable<long>
{
public static readonly long[] Value=A121380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121380.Bytes);
public long this[int i]=>Value[i];

public static A121380Inst Instance=new A121380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121381
{
public static readonly long[] Value={ 0L,4L,7L,10L,13L,16L,19L,22L,26L,29L,32L,35L,38L,41L,44L,48L,51L,54L,57L,60L,63L,66L,70L,73L,76L,79L,82L,85L,88L,92L,95L,98L,101L,104L,107L,110L,114L,117L,120L,123L,126L,129L,132L,136L,139L,142L,145L,148L,151L,154L,158L,161L,164L,167L,170L,173L,176L,180L,183L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121381Inst : IEnumerable<long>
{
public static readonly long[] Value=A121381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121381.Bytes);
public long this[int i]=>Value[i];

public static A121381Inst Instance=new A121381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121382
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,3L,1L,2L,1L,2L,1L,5L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,5L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,7L,1L,2L,2L,1L,2L,5L,1L,2L,2L,5L,1L,2L,1L,2L,2L,2L,2L,5L,1L,3L,1L,2L,1L,6L,2L,2L,2L,2L,1L,6L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,1L,5L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121382Inst : IEnumerable<long>
{
public static readonly long[] Value=A121382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121382.Bytes);
public long this[int i]=>Value[i];

public static A121382Inst Instance=new A121382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121383
{
public static readonly long[] Value={ 3L,1L,0L,1L,1L,0L,1L,0L,4L,3L,0L,0L,1L,2L,1L,6L,5L,0L,0L,1L,1L,1L,2L,2L,9L,7L,0L,1L,0L,1L,1L,1L,1L,2L,4L,14L,9L,0L,0L,0L,2L,0L,1L,1L,1L,2L,2L,7L,17L,13L,1L,1L,0L,0L,0L,2L,0L,2L,1L,1L,2L,2L,11L,21L,18L,0L,0L,1L,1L,0L,1L,0L,2L,0L,2L,1L,1L,2L,2L,16L,26L,22L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121383Inst : IEnumerable<long>
{
public static readonly long[] Value=A121383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121383.Bytes);
public long this[int i]=>Value[i];

public static A121383Inst Instance=new A121383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121384
{
public static readonly long[] Value={ 0L,3L,6L,9L,11L,14L,17L,20L,22L,25L,28L,30L,33L,36L,39L,41L,44L,47L,49L,52L,55L,58L,60L,63L,66L,68L,71L,74L,77L,79L,82L,85L,87L,90L,93L,96L,98L,101L,104L,107L,109L,112L,115L,117L,120L,123L,126L,128L,131L,134L,136L,139L,142L,145L,147L,150L,153L,155L,158L,161L,164L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121384Inst : IEnumerable<long>
{
public static readonly long[] Value=A121384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121384.Bytes);
public long this[int i]=>Value[i];

public static A121384Inst Instance=new A121384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121385
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,3L,4L,5L,6L,7L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,31L,34L,37L,40L,43L,46L,49L,52L,55L,58L,62L,66L,70L,74L,78L,82L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121385Inst : IEnumerable<long>
{
public static readonly long[] Value=A121385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121385.Bytes);
public long this[int i]=>Value[i];

public static A121385Inst Instance=new A121385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121386
{
public static readonly long[] Value={ 2L,4L,6L,10L,14L,20L,16L,6L,36L,8L,44L,10L,8L,30L,16L,8L,12L,2L,12L,28L,64L,110L,96L,134L,56L,44L,16L,2L,16L,74L,116L,188L,200L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121386Inst : IEnumerable<long>
{
public static readonly long[] Value=A121386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121386.Bytes);
public long this[int i]=>Value[i];

public static A121386Inst Instance=new A121386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121387
{
public static readonly long[] Value={ 25L,65L,85L,145L,169L,185L,205L,221L,265L,289L,305L,365L,377L,445L,481L,485L,493L,505L,533L,545L,565L,629L,685L,689L,697L,745L,785L,793L,841L,865L,901L,905L,949L,965L,985L,1037L,1073L,1145L,1157L,1165L,1189L,1205L,1241L,1261L,1285L,1313L,1345L,1369L,1385L,1405L,1417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121387Inst : IEnumerable<long>
{
public static readonly long[] Value=A121387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121387.Bytes);
public long this[int i]=>Value[i];

public static A121387Inst Instance=new A121387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121388
{
public static readonly long[] Value={ 3L,5L,7L,9L,13L,11L,15L,21L,17L,19L,25L,35L,33L,29L,23L,27L,65L,39L,49L,37L,31L,45L,63L,85L,51L,57L,41L,43L,75L,105L,99L,145L,55L,69L,53L,47L,125L,175L,117L,147L,169L,87L,77L,61L,59L,81L,325L,195L,153L,171L,185L,91L,93L,73L,67L,135L,189L,425L,255L,165L,207L,205L,95L,121L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121388Inst : IEnumerable<long>
{
public static readonly long[] Value=A121388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121388.Bytes);
public long this[int i]=>Value[i];

public static A121388Inst Instance=new A121388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121389
{
public static readonly BigInteger[] Value={ 0L,9L,9L,99L,999L,99999L,99999999L,9999999999999L,BigInteger.Parse("999999999999999999999"),BigInteger.Parse("9999999999999999999999999999999999"),BigInteger.Parse("9999999999999999999999999999999999999999999999999999999") };
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
public class A121389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121389Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121389.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121389.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121389Inst Instance=new A121389Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121390
{
public static readonly BigInteger[] Value={ 2L,8607769L,25823309L,222281113118699L,BigInteger.Parse("5740034091209256896999"),BigInteger.Parse("1275901167133279185594625154673899999"),BigInteger.Parse("7323716196358702385046852882006552347670105360888299999999") };
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
public class A121390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121390Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121390.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121390Inst Instance=new A121390Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121391
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,3L,1L,1L,1L,15L,12L,4L,1L,1L,1L,55L,58L,22L,5L,1L,1L,1L,252L,333L,146L,35L,6L,1L,1L,1L,1449L,2268L,1131L,295L,51L,7L,1L,1L,1L,10305L,18281L,10120L,2870L,521L,70L,8L,1L,1L,1L,88611L,173127L,104015L,31731L,6096L,840L,92L,9L,1L,1L,1L,901204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121391Inst : IEnumerable<long>
{
public static readonly long[] Value=A121391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121391.Bytes);
public long this[int i]=>Value[i];

public static A121391Inst Instance=new A121391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121392
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,55L,252L,1449L,10305L,88611L,901204L,10642707L,143771206L,2194484737L,37458097842L,708733666387L,14751543118320L,335523928599914L,8290931998724535L,221426442466072303L,6362084485200488267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121392Inst : IEnumerable<long>
{
public static readonly long[] Value=A121392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121392.Bytes);
public long this[int i]=>Value[i];

public static A121392Inst Instance=new A121392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121393
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,58L,333L,2268L,18281L,173127L,1905500L,24080964L,345381551L,5563259860L,99716732043L,1973012968122L,42792555114812L,1011125250589597L,25886430637780776L,714600877541340733L,BigInteger.Parse("21178498962170286988") };
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
public class A121393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121393Inst Instance=new A121393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121394
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,146L,1131L,10120L,104015L,1220957L,16253289L,243450538L,4070466861L,75393600728L,1536160429870L,34213493149270L,828220957918213L,21680478452572459L,610911511290740374L,BigInteger.Parse("18453811792850260925") };
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
public class A121394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121394Inst Instance=new A121394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121395
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,4L,1L,1L,1L,16L,22L,8L,1L,1L,1L,75L,164L,92L,16L,1L,1L,1L,594L,1837L,1464L,376L,32L,1L,1L,1L,8420L,34176L,35190L,12336L,1520L,64L,1L,1L,1L,212790L,1106012L,1393400L,612316L,101216L,6112L,128L,1L,1L,1L,9542280L,63053480L,95005100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121395Inst : IEnumerable<long>
{
public static readonly long[] Value=A121395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121395.Bytes);
public long this[int i]=>Value[i];

public static A121395Inst Instance=new A121395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121396
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,16L,75L,594L,8420L,212790L,9542280L,763184598L,109735708579L,28582820337914L,13580038203578493L,11845224434439055236UL,BigInteger.Parse("19084161956327789507755"),BigInteger.Parse("57113015617717986294647190") };
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
public class A121396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121396Inst Instance=new A121396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121397
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,164L,1837L,34176L,1106012L,63053480L,6385424679L,1160549661044L,382452061644152L,230599430810507856L,BigInteger.Parse("256385360437413619926"),BigInteger.Parse("529174935800200166078372"),BigInteger.Parse("2039277788771681728279205788") };
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
public class A121397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121397Inst Instance=new A121397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121398
{
public static readonly long[] Value={ 1L,2L,5L,11L,28L,70L,184L,486L,1313L,3576L,9851L,27319L,76286L,214120L,603858L,1709719L,4857959L,13845948L,39572583L,113380652L,325576692L,936796592L,2700456452L,7797587816L,22550434989L,65308288346L,189388557677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121398Inst : IEnumerable<long>
{
public static readonly long[] Value=A121398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121398.Bytes);
public long this[int i]=>Value[i];

public static A121398Inst Instance=new A121398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121399
{
public static readonly long[] Value={ 1L,1L,3L,6L,17L,42L,114L,302L,827L,2263L,6275L,17468L,48967L,137834L,389738L,1105861L,3148240L,8987989L,25726635L,73808069L,212196040L,611219900L,1763659860L,5097131364L,14752847173L,42757853357L,124080269331L,360493591232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121399Inst : IEnumerable<long>
{
public static readonly long[] Value=A121399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121399.Bytes);
public long this[int i]=>Value[i];

public static A121399Inst Instance=new A121399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121400
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,6L,11L,8L,11L,17L,25L,30L,19L,28L,42L,72L,74L,77L,47L,70L,114L,188L,223L,198L,194L,117L,184L,302L,525L,609L,615L,509L,495L,301L,486L,827L,1436L,1749L,1733L,1619L,1305L,1282L,787L,1313L,2263L,4012L,4918L,5101L,4657L,4206L,3374L,3382L,2100L,3576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121400Inst : IEnumerable<long>
{
public static readonly long[] Value=A121400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121400.Bytes);
public long this[int i]=>Value[i];

public static A121400Inst Instance=new A121400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121401
{
public static readonly long[] Value={ 2L,3L,8L,27L,98L,363L,1352L,5043L,18818L,70227L,262088L,978123L,3650402L,13623483L,50843528L,189750627L,708158978L,2642885283L,9863382152L,36810643323L,137379191138L,512706121227L,1913445293768L,7141075053843L,26650854921602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121401Inst : IEnumerable<long>
{
public static readonly long[] Value=A121401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121401.Bytes);
public long this[int i]=>Value[i];

public static A121401Inst Instance=new A121401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121402
{
public static readonly long[] Value={ 11L,101L,211L,311L,1021L,1201L,1301L,1321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121402Inst : IEnumerable<long>
{
public static readonly long[] Value=A121402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121402.Bytes);
public long this[int i]=>Value[i];

public static A121402Inst Instance=new A121402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121403
{
public static readonly long[] Value={ 2L,1L,6L,4L,9L,9L,5L,6L,5L,9L,7L,0L,9L,1L,4L,0L,1L,9L,1L,1L,4L,7L,4L,0L,2L,5L,9L,1L,0L,0L,6L,0L,5L,5L,8L,5L,4L,4L,9L,6L,7L,6L,5L,6L,6L,3L,5L,1L,0L,5L,4L,3L,6L,0L,9L,1L,9L,7L,4L,1L,4L,3L,1L,0L,8L,7L,1L,2L,6L,1L,7L,6L,2L,1L,6L,9L,3L,3L,0L,9L,6L,2L,3L,9L,9L,4L,1L,7L,3L,2L,5L,3L,9L,1L,1L,7L,6L,3L,2L,9L,9L,8L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121403Inst : IEnumerable<long>
{
public static readonly long[] Value=A121403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121403.Bytes);
public long this[int i]=>Value[i];

public static A121403Inst Instance=new A121403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121404
{
public static readonly long[] Value={ 0L,2L,6L,12L,36L,96L,342L,22266L,79806L,187122L,347976L,2171616L,4219797672L,98059918332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121404Inst : IEnumerable<long>
{
public static readonly long[] Value=A121404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121404.Bytes);
public long this[int i]=>Value[i];

public static A121404Inst Instance=new A121404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121405
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,9L,10L,11L,14L,15L,16L,19L,20L,21L,24L,25L,26L,29L,30L,31L,32L,33L,37L,38L,42L,43L,44L,45L,46L,49L,50L,54L,55L,59L,60L,61L,65L,66L,67L,72L,77L,80L,81L,84L,89L,94L,95L,96L,100L,101L,102L,107L,112L,116L,124L,136L,137L,141L,142L,147L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121405Inst : IEnumerable<long>
{
public static readonly long[] Value=A121405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121405.Bytes);
public long this[int i]=>Value[i];

public static A121405Inst Instance=new A121405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121406
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,30L,270L,2970L,44550L,757350L,15904350L,429417450L,12453106050L,435858711750L,16998489758250L,696938080088250L,31362213603971250L,1599472893802533750L,BigInteger.Parse("91169954946744423750"),BigInteger.Parse("5379027341857921001250") };
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
public class A121406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121406Inst Instance=new A121406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121407
{
public static readonly BigInteger[] Value={ 0L,0L,0L,2L,18L,210L,2790L,47610L,901530L,20591010L,592452630L,18202996350L,667760974650L,27146297697750L,1157142993063750L,53925515761020750L,2835489033177050250L,BigInteger.Parse("166057836818071448250"),BigInteger.Parse("10054640164031031318750") };
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
public class A121407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121407Inst Instance=new A121407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121408
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,4L,0L,1L,9L,0L,10L,0L,1L,0L,64L,0L,20L,0L,1L,225L,0L,259L,0L,35L,0L,1L,0L,2304L,0L,784L,0L,56L,0L,1L,11025L,0L,12916L,0L,1974L,0L,84L,0L,1L,0L,147456L,0L,52480L,0L,4368L,0L,120L,0L,1L,893025L,0L,1057221L,0L,172810L,0L,8778L,0L,165L,0L,1L,0L,14745600L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121408Inst : IEnumerable<long>
{
public static readonly long[] Value=A121408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121408.Bytes);
public long this[int i]=>Value[i];

public static A121408Inst Instance=new A121408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121409
{
public static readonly long[] Value={ 2L,3L,17L,19L,89L,317L,563L,1091L,2099L,3181L,5023L,44221L,53899L,410747L,410801L,448373L,451181L,481133L,519151L,617657L,738523L,882979L,992087L,1611433L,2167421L,2688299L,2723627L,2811089L,3331033L,3411043L,3499411L,3983911L,3988889L,6233933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121409Inst : IEnumerable<long>
{
public static readonly long[] Value=A121409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121409.Bytes);
public long this[int i]=>Value[i];

public static A121409Inst Instance=new A121409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121410
{
public static readonly long[] Value={ 1L,2L,4L,5L,14L,21L,31L,54L,65L,69L,77L,171L,205L,674L,675L,705L,717L,740L,782L,919L,1069L,1204L,1273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121410Inst : IEnumerable<long>
{
public static readonly long[] Value=A121410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121410.Bytes);
public long this[int i]=>Value[i];

public static A121410Inst Instance=new A121410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121411
{
public static readonly long[] Value={ 2L,5L,6L,8L,10L,12L,13L,17L,18L,20L,21L,22L,26L,28L,30L,32L,33L,37L,38L,40L,42L,45L,46L,48L,50L,52L,53L,56L,58L,60L,61L,62L,65L,66L,68L,70L,72L,76L,77L,78L,80L,82L,85L,86L,88L,90L,92L,93L,96L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121411Inst : IEnumerable<long>
{
public static readonly long[] Value=A121411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121411.Bytes);
public long this[int i]=>Value[i];

public static A121411Inst Instance=new A121411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121412
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,18L,4L,1L,1L,170L,30L,5L,1L,1L,2220L,335L,45L,6L,1L,1L,37149L,4984L,581L,63L,7L,1L,1L,758814L,92652L,9730L,924L,84L,8L,1L,1L,18301950L,2065146L,199692L,17226L,1380L,108L,9L,1L,1L,508907970L,53636520L,4843125L,387567L,28365L,1965L,135L,10L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121412Inst : IEnumerable<long>
{
public static readonly long[] Value=A121412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121412.Bytes);
public long this[int i]=>Value[i];

public static A121412Inst Instance=new A121412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121413
{
public static readonly BigInteger[] Value={ 1L,1L,4L,30L,335L,4984L,92652L,2065146L,53636520L,1589752230L,52926799310L,1954793723688L,79297921097850L,3504206787532290L,167533486104374420L,8615231103973721610L,BigInteger.Parse("474145710046504872894"),BigInteger.Parse("27806642356199323970739") };
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
public class A121413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121413Inst Instance=new A121413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121414
{
public static readonly BigInteger[] Value={ 1L,1L,5L,45L,581L,9730L,199692L,4843125L,135345925L,4278317373L,150818840250L,5863215069621L,249105031449435L,11480173020040450L,570303168053225908L,BigInteger.Parse("30375972794764190385"),BigInteger.Parse("1726700205634807475115"),BigInteger.Parse("104332294453480284687895") };
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
public class A121414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121414Inst Instance=new A121414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121415
{
public static readonly BigInteger[] Value={ 1L,1L,6L,63L,924L,17226L,387567L,10182744L,305379129L,10280074116L,383492465902L,15692864353299L,698622377024472L,33604795914668178L,1736477536255603281L,BigInteger.Parse("95918139377302294980"),BigInteger.Parse("5639487915973132301793"),BigInteger.Parse("351611645300506492405623") };
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
public class A121415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121415Inst Instance=new A121415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121416
{
public static readonly long[] Value={ 1L,2L,1L,7L,2L,1L,43L,9L,2L,1L,403L,69L,11L,2L,1L,5188L,769L,101L,13L,2L,1L,85569L,11346L,1305L,139L,15L,2L,1L,1725291L,208914L,21745L,2043L,183L,17L,2L,1L,41145705L,4613976L,443329L,37971L,3015L,233L,19L,2L,1L,1133047596L,118840164L,10679494L,850260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121416Inst : IEnumerable<long>
{
public static readonly long[] Value=A121416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121416.Bytes);
public long this[int i]=>Value[i];

public static A121416Inst Instance=new A121416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121417
{
public static readonly BigInteger[] Value={ 1L,2L,9L,69L,769L,11346L,208914L,4613976L,118840164L,3496297632L,115638728395L,4246267163601L,171369282105510L,7538270885559264L,358926669220446804L,18389706733665138450UL,BigInteger.Parse("1008742283718489346668"),BigInteger.Parse("58981158542987625464424") };
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
public class A121417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121417Inst Instance=new A121417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121418
{
public static readonly BigInteger[] Value={ 1L,2L,7L,43L,403L,5188L,85569L,1725291L,41145705L,1133047596L,35377360292L,1234796503280L,47636225803285L,2012509471127885L,92398547122062997L,4580472438441602301L,BigInteger.Parse("243822925502110419105"),BigInteger.Parse("13870297863425823346284") };
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
public class A121418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121418Inst Instance=new A121418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121419
{
public static readonly BigInteger[] Value={ 1L,2L,11L,101L,1305L,21745L,443329L,10679494L,296547736L,9319259500L,326788327650L,12643827604842L,534889691765631L,24555735428777265L,1215611513578215355L,BigInteger.Parse("64542477563559758310"),BigInteger.Parse("3658333757447085090365") };
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
public class A121419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121419Inst Instance=new A121419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121420
{
public static readonly long[] Value={ 1L,3L,1L,12L,3L,1L,76L,15L,3L,1L,711L,118L,18L,3L,1L,9054L,1317L,169L,21L,3L,1L,147471L,19311L,2190L,229L,24L,3L,1L,2938176L,352636L,36360L,3378L,298L,27L,3L,1L,69328365L,7722840L,737051L,62655L,4929L,376L,30L,3L,1L,1891371807L,197354133L,17645187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121420Inst : IEnumerable<long>
{
public static readonly long[] Value=A121420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121420.Bytes);
public long this[int i]=>Value[i];

public static A121420Inst Instance=new A121420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121421
{
public static readonly BigInteger[] Value={ 1L,3L,12L,76L,711L,9054L,147471L,2938176L,69328365L,1891371807L,58575539361L,2030011517685L,77827890696820L,3270046577551695L,149407542447596319L,7374639622066056408L,BigInteger.Parse("391044078030333899385"),BigInteger.Parse("22168014954558449549349") };
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
public class A121421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121421Inst Instance=new A121421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121422
{
public static readonly BigInteger[] Value={ 1L,3L,15L,118L,1317L,19311L,352636L,7722840L,197354133L,5764942816L,189460961985L,6917588290044L,277765971072770L,12163275845132298L,576793897136731632L,BigInteger.Parse("29444368084753254610"),BigInteger.Parse("1609805318425385690712"),BigInteger.Parse("93843785859803533422675") };
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
public class A121422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121422Inst Instance=new A121422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121423
{
public static readonly BigInteger[] Value={ 1L,3L,18L,169L,2190L,36360L,737051L,17645187L,487025244L,15219471545L,530951735025L,20447695079658L,861389893507518L,39394187817328680L,1943446826192453505L,BigInteger.Parse("102863050524539640435"),BigInteger.Parse("5813722327999905078450") };
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
public class A121423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121423Inst Instance=new A121423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121424
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,7L,18L,1L,4L,12L,43L,170L,1L,5L,18L,76L,403L,2220L,1L,6L,25L,118L,711L,5188L,37149L,1L,7L,33L,170L,1107L,9054L,85569L,758814L,1L,8L,42L,233L,1605L,13986L,147471L,1725291L,18301950L,1L,9L,52L,308L,2220L,20171L,225363L,2938176L,41145705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121424Inst : IEnumerable<long>
{
public static readonly long[] Value=A121424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121424.Bytes);
public long this[int i]=>Value[i];

public static A121424Inst Instance=new A121424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121425
{
public static readonly BigInteger[] Value={ 1L,2L,12L,118L,1605L,27816L,585046L,14459138L,410368743L,13146830110L,469123986529L,18447791712945L,792514583941223L,36925394368325295L,1854525584914459755L,BigInteger.Parse("99872579714406393286"),BigInteger.Parse("5740977285851988017769") };
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
public class A121425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121425Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121425.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121425Inst Instance=new A121425Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121426
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,9L,30L,1L,4L,15L,69L,335L,1L,5L,22L,118L,769L,4984L,1L,6L,30L,178L,1317L,11346L,92652L,1L,7L,39L,250L,1995L,19311L,208914L,2065146L,1L,8L,49L,335L,2820L,29126L,352636L,4613976L,53636520L,1L,9L,60L,434L,3810L,41061L,528097L,7722840L,118840164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121426Inst : IEnumerable<long>
{
public static readonly long[] Value=A121426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121426.Bytes);
public long this[int i]=>Value[i];

public static A121426Inst Instance=new A121426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121427
{
public static readonly BigInteger[] Value={ 1L,2L,15L,178L,2820L,55410L,1294776L,35003430L,1073540871L,36805249870L,1394346324624L,57831360118800L,2605921998840420L,126757491839620950L,6619466939158637640L,BigInteger.Parse("369368127676399990338"),BigInteger.Parse("21932876159270004129285") };
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
public class A121427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121427Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121427.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121427Inst Instance=new A121427Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121428
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,5L,1L,3L,11L,45L,1L,4L,18L,101L,581L,1L,5L,26L,169L,1305L,9730L,1L,6L,35L,250L,2190L,21745L,199692L,1L,7L,45L,345L,3255L,36360L,443329L,4843125L,1L,8L,56L,455L,4520L,53916L,737051L,10679494L,135345925L,1L,9L,68L,581L,6006L,74781L,1087583L,17645187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121428Inst : IEnumerable<long>
{
public static readonly long[] Value=A121428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121428.Bytes);
public long this[int i]=>Value[i];

public static A121428Inst Instance=new A121428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121429
{
public static readonly BigInteger[] Value={ 1L,2L,18L,250L,4520L,99351L,2556806L,75190410L,2483617140L,90955908010L,3655774038653L,159938142409890L,7564604603286913L,384576889110665055L,BigInteger.Parse("20912407157570989950"),BigInteger.Parse("1211142337261176799610"),BigInteger.Parse("74427504634177621877538") };
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
public class A121429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121429Inst Instance=new A121429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121430
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,12L,18L,43L,76L,118L,170L,403L,711L,1107L,1605L,2220L,5188L,9054L,13986L,20171L,27816L,37149L,85569L,147471L,225363L,322075L,440785L,585046L,758814L,1725291L,2938176L,4441557L,6285390L,8526057L,11226958L,14459138L,18301950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121430Inst : IEnumerable<long>
{
public static readonly long[] Value=A121430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121430.Bytes);
public long this[int i]=>Value[i];

public static A121430Inst Instance=new A121430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121431
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,9L,15L,22L,30L,69L,118L,178L,250L,335L,769L,1317L,1995L,2820L,3810L,4984L,11346L,19311L,29126L,41061L,55410L,72492L,92652L,208914L,352636L,528097L,740035L,993678L,1294776L,1649634L,2065146L,4613976L,7722840L,11476963L,15971180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121431Inst : IEnumerable<long>
{
public static readonly long[] Value=A121431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121431.Bytes);
public long this[int i]=>Value[i];

public static A121431Inst Instance=new A121431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121432
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,11L,18L,26L,35L,45L,101L,169L,250L,345L,455L,581L,1305L,2190L,3255L,4520L,6006L,7735L,9730L,21745L,36360L,53916L,74781L,99351L,128051L,161336L,199692L,443329L,737051L,1087583L,1502270L,1989113L,2556806L,3214774L,3973212L,4843125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121432Inst : IEnumerable<long>
{
public static readonly long[] Value=A121432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121432.Bytes);
public long this[int i]=>Value[i];

public static A121432Inst Instance=new A121432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121433
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,13L,21L,30L,40L,51L,63L,139L,229L,334L,455L,593L,749L,924L,2043L,3378L,4951L,6785L,8904L,11333L,14098L,17226L,37971L,62655L,91728L,125671L,164997L,210252L,262016L,320904L,387567L,850260L,1397268L,2038545L,2784850L,3647788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121433Inst : IEnumerable<long>
{
public static readonly long[] Value=A121433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121433.Bytes);
public long this[int i]=>Value[i];

public static A121433Inst Instance=new A121433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121434
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,2L,-3L,1L,0L,-7L,12L,-6L,1L,0L,37L,-67L,39L,-10L,1L,0L,-268L,498L,-311L,95L,-15L,1L,0L,2496L,-4701L,3045L,-1015L,195L,-21L,1L,0L,-28612L,54298L,-35901L,12560L,-2675L,357L,-28L,1L,0L,391189L,-745734L,499157L,-179717L,40635L,-6097L,602L,-36L,1L,0L,-6230646L,11911221L,-8034267L,2945010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121434Inst : IEnumerable<long>
{
public static readonly long[] Value=A121434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121434.Bytes);
public long this[int i]=>Value[i];

public static A121434Inst Instance=new A121434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121435
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,-2L,5L,-4L,1L,7L,-19L,18L,-7L,1L,-37L,104L,-106L,49L,-11L,1L,268L,-766L,809L,-406L,110L,-16L,1L,-2496L,7197L,-7746L,4060L,-1210L,216L,-22L,1L,28612L,-82910L,90199L,-48461L,15235L,-3032L,385L,-29L,1L,-391189L,1136923L,-1244891L,678874L,-220352L,46732L,-6699L,638L,-37L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121435Inst : IEnumerable<long>
{
public static readonly long[] Value=A121435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121435.Bytes);
public long this[int i]=>Value[i];

public static A121435Inst Instance=new A121435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121436
{
public static readonly long[] Value={ 1L,-2L,1L,3L,-3L,1L,-7L,9L,-5L,1L,26L,-37L,25L,-8L,1L,-141L,210L,-155L,60L,-12L,1L,1034L,-1575L,1215L,-516L,126L,-17L,1L,-9693L,14943L,-11806L,5270L,-1426L,238L,-23L,1L,111522L,-173109L,138660L,-63696L,18267L,-3417L,414L,-30L,1L,-1528112L,2381814L,-1923765L,899226L,-267084L,53431L,-7337L,675L,-38L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121436Inst : IEnumerable<long>
{
public static readonly long[] Value=A121436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121436.Bytes);
public long this[int i]=>Value[i];

public static A121436Inst Instance=new A121436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121437
{
public static readonly long[] Value={ 1L,-3L,1L,6L,-4L,1L,-16L,14L,-6L,1L,63L,-62L,33L,-9L,1L,-351L,365L,-215L,72L,-13L,1L,2609L,-2790L,1731L,-642L,143L,-18L,1L,-24636L,26749L,-17076L,6696L,-1664L,261L,-24L,1L,284631L,-311769L,202356L,-81963L,21684L,-3831L,444L,-31L,1L,-3909926L,4305579L,-2822991L,1166310L,-320515L,60768L,-8012L,713L,-39L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121437Inst : IEnumerable<long>
{
public static readonly long[] Value=A121437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121437.Bytes);
public long this[int i]=>Value[i];

public static A121437Inst Instance=new A121437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121438
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,-3L,1L,-17L,-3L,-6L,1L,-160L,-25L,5L,-10L,1L,-2088L,-285L,-35L,30L,-15L,1L,-34307L,-4179L,-420L,-91L,84L,-21L,1L,-675091L,-74823L,-6916L,-497L,-322L,182L,-28L,1L,-15428619L,-1577763L,-135639L,-10080L,-63L,-1002L,342L,-36L,1L,-400928675L,-38209725L,-3082905L,-215700L,-14139L,2655L,-2625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121438Inst : IEnumerable<long>
{
public static readonly long[] Value=A121438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121438.Bytes);
public long this[int i]=>Value[i];

public static A121438Inst Instance=new A121438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121439
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,-4L,1L,-14L,0L,-7L,1L,-143L,-22L,11L,-11L,1L,-1928L,-260L,-40L,40L,-16L,1L,-32219L,-3894L,-385L,-121L,99L,-22L,1L,-640784L,-70644L,-6496L,-406L,-406L,203L,-29L,1L,-14753528L,-1502940L,-128723L,-9583L,259L,-1184L,370L,-37L,1L,-385500056L,-36631962L,-2947266L,-205620L,-14076L,3657L,-2967L,621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121439Inst : IEnumerable<long>
{
public static readonly long[] Value=A121439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121439.Bytes);
public long this[int i]=>Value[i];

public static A121439Inst Instance=new A121439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121440
{
public static readonly long[] Value={ 1L,-3L,1L,0L,-5L,1L,-12L,4L,-8L,1L,-129L,-22L,18L,-12L,1L,-1785L,-238L,-51L,51L,-17L,1L,-30291L,-3634L,-345L,-161L,115L,-23L,1L,-608565L,-66750L,-6111L,-285L,-505L,225L,-30L,1L,-14112744L,-1432296L,-122227L,-9177L,665L,-1387L,399L,-38L,1L,-370746528L,-35129022L,-2818543L,-196037L,-14335L,4841L,-3337L,658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121440Inst : IEnumerable<long>
{
public static readonly long[] Value=A121440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121440.Bytes);
public long this[int i]=>Value[i];

public static A121440Inst Instance=new A121440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121441
{
public static readonly long[] Value={ 1L,-4L,1L,3L,-6L,1L,-12L,9L,-9L,1L,-117L,-26L,26L,-13L,1L,-1656L,-216L,-69L,63L,-18L,1L,-28506L,-3396L,-294L,-212L,132L,-24L,1L,-578274L,-63116L,-5766L,-124L,-620L,248L,-31L,1L,-13504179L,-1365546L,-116116L,-8892L,1170L,-1612L,429L,-39L,1L,-356633784L,-33696726L,-2696316L,-186860L,-15000L,6228L,-3736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121441Inst : IEnumerable<long>
{
public static readonly long[] Value=A121441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121441.Bytes);
public long this[int i]=>Value[i];

public static A121441Inst Instance=new A121441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121442
{
public static readonly long[] Value={ 1L,1L,9L,17L,97L,241L,1097L,3169L,12801L,40225L,152265L,501489L,1831649L,6192785L,22176137L,76079553L,269472001L,932011841L,3281180297L,11399814865L,39998425697L,139315579185L,487901595593L,1701743382561L,5953542163713L,20781331011169L,72661467102025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121442Inst : IEnumerable<long>
{
public static readonly long[] Value=A121442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121442.Bytes);
public long this[int i]=>Value[i];

public static A121442Inst Instance=new A121442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121443
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,3L,8L,1L,9L,6L,12L,3L,14L,8L,18L,1L,18L,9L,20L,6L,24L,12L,24L,3L,31L,14L,27L,8L,30L,18L,32L,1L,36L,18L,48L,9L,38L,20L,42L,6L,42L,24L,44L,12L,54L,24L,48L,3L,57L,31L,54L,14L,54L,27L,72L,8L,60L,30L,60L,18L,62L,32L,72L,1L,84L,36L,68L,18L,72L,48L,72L,9L,74L,38L,93L,20L,96L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121443Inst : IEnumerable<long>
{
public static readonly long[] Value=A121443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121443.Bytes);
public long this[int i]=>Value[i];

public static A121443Inst Instance=new A121443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121444
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,2L,1L,1L,0L,1L,2L,1L,0L,2L,1L,1L,1L,1L,1L,1L,2L,1L,0L,0L,1L,2L,2L,1L,1L,0L,3L,0L,1L,1L,0L,2L,0L,1L,1L,2L,2L,1L,1L,0L,1L,1L,1L,2L,1L,1L,0L,1L,2L,1L,0L,3L,0L,0L,1L,1L,2L,1L,1L,1L,1L,3L,1L,0L,1L,0L,2L,0L,1L,1L,1L,2L,1L,0L,0L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121444Inst : IEnumerable<long>
{
public static readonly long[] Value=A121444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121444.Bytes);
public long this[int i]=>Value[i];

public static A121444Inst Instance=new A121444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121445
{
public static readonly long[] Value={ 3L,3L,9L,10L,18L,27L,42L,69L,81L,81L,198L,312L,351L,324L,243L,1001L,1540L,1701L,1566L,1215L,729L,5304L,8034L,8784L,8100L,6480L,4374L,2187L,29070L,43554L,47313L,43713L,35640L,25515L,15309L,6561L,163438L,242896L,262684L,243108L,200745L,148716L,96957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121445Inst : IEnumerable<long>
{
public static readonly long[] Value=A121445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121445.Bytes);
public long this[int i]=>Value[i];

public static A121445Inst Instance=new A121445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121446
{
public static readonly long[] Value={ 3L,3L,10L,42L,198L,1001L,5304L,29070L,163438L,937365L,5462730L,32256120L,192565800L,1160346492L,7048030544L,43108428198L,265276342782L,1641229898525L,10202773534590L,63698396932170L,399223286267190L,2510857763851185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121446Inst : IEnumerable<long>
{
public static readonly long[] Value=A121446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121446.Bytes);
public long this[int i]=>Value[i];

public static A121446Inst Instance=new A121446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121447
{
public static readonly long[] Value={ 3L,21L,127L,747L,4386L,25897L,154077L,923910L,5581485L,33949836L,207787668L,1278900412L,7911394686L,49165322241L,306809507561L,1921849861260L,12079999018605L,76170034283805L,481680300300255L,3054157623774495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121447Inst : IEnumerable<long>
{
public static readonly long[] Value=A121447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121447.Bytes);
public long this[int i]=>Value[i];

public static A121447Inst Instance=new A121447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121448
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,4L,0L,6L,0L,8L,2L,0L,24L,0L,16L,0L,20L,0L,80L,0L,32L,5L,0L,120L,0L,240L,0L,64L,0L,70L,0L,560L,0L,672L,0L,128L,14L,0L,560L,0L,2240L,0L,1792L,0L,256L,0L,252L,0L,3360L,0L,8064L,0L,4608L,0L,512L,42L,0L,2520L,0L,16800L,0L,26880L,0L,11520L,0L,1024L,0L,924L,0L,18480L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121448Inst : IEnumerable<long>
{
public static readonly long[] Value=A121448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121448.Bytes);
public long this[int i]=>Value[i];

public static A121448Inst Instance=new A121448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121449
{
public static readonly long[] Value={ 1L,1L,3L,8L,22L,61L,170L,475L,1329L,3721L,10422L,29196L,81797L,229178L,642125L,1799169L,5041123L,14124860L,39576902L,110891905L,310712054L,870595599L,2439354329L,6834918465L,19151015274L,53659951372L,150351841201L,421276495414L,1180390506681L,3307380699281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121449Inst : IEnumerable<long>
{
public static readonly long[] Value=A121449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121449.Bytes);
public long this[int i]=>Value[i];

public static A121449Inst Instance=new A121449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121450
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,2L,1L,0L,-1L,1L,-2L,0L,1L,2L,0L,-2L,-1L,2L,-1L,0L,-2L,0L,0L,0L,1L,3L,-2L,-1L,0L,2L,2L,0L,-1L,0L,-2L,0L,-1L,2L,0L,-2L,-2L,2L,0L,0L,0L,2L,0L,0L,1L,1L,-3L,-2L,-2L,2L,1L,0L,0L,0L,-2L,0L,2L,2L,0L,0L,-1L,4L,0L,0L,-2L,0L,0L,0L,-1L,2L,-2L,-3L,0L,0L,2L,0L,-2L,1L,-2L,0L,0L,4L,0L,-2L,0L,2L,-2L,0L,0L,0L,0L,0L,1L,2L,-1L,0L,-3L,2L,2L,0L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121450Inst : IEnumerable<long>
{
public static readonly long[] Value=A121450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121450.Bytes);
public long this[int i]=>Value[i];

public static A121450Inst Instance=new A121450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121451
{
public static readonly long[] Value={ 0L,2L,0L,4L,5L,8L,10L,16L,20L,32L,40L,64L,80L,128L,160L,256L,320L,512L,640L,1024L,1280L,2048L,2560L,4096L,5120L,8192L,10240L,16384L,20480L,32768L,40960L,65536L,81920L,131072L,163840L,262144L,327680L,524288L,655360L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121451Inst : IEnumerable<long>
{
public static readonly long[] Value=A121451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121451.Bytes);
public long this[int i]=>Value[i];

public static A121451Inst Instance=new A121451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121452
{
public static readonly long[] Value={ 1L,1L,1L,4L,13L,71L,391L,2836L,21729L,198829L,1939501L,21515836L,254169301L,3319328299L,45979476635L,691443303916L,10979537304961L,186915474027321L,3345563762493049L,63613875064443796L,1266776073045809341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121452Inst : IEnumerable<long>
{
public static readonly long[] Value=A121452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121452.Bytes);
public long this[int i]=>Value[i];

public static A121452Inst Instance=new A121452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121453
{
public static readonly long[] Value={ 9L,24L,33L,48L,69L,84L,93L,108L,129L,144L,153L,168L,189L,204L,213L,228L,249L,264L,273L,288L,309L,324L,333L,348L,369L,384L,393L,408L,429L,444L,453L,468L,489L,504L,513L,528L,549L,564L,573L,588L,609L,624L,633L,648L,669L,684L,693L,708L,729L,744L,753L,768L,789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121453Inst : IEnumerable<long>
{
public static readonly long[] Value=A121453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121453.Bytes);
public long this[int i]=>Value[i];

public static A121453Inst Instance=new A121453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121454
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,0L,0L,1L,-1L,1L,0L,2L,0L,0L,-1L,0L,-1L,0L,-1L,0L,0L,0L,-2L,2L,0L,1L,0L,0L,-1L,2L,0L,0L,-1L,0L,0L,0L,-1L,2L,0L,0L,0L,0L,0L,2L,-2L,0L,-2L,0L,0L,1L,-1L,0L,0L,2L,0L,0L,-1L,0L,-2L,0L,0L,0L,0L,1L,-1L,0L,0L,2L,0L,0L,0L,2L,-1L,0L,-2L,0L,0L,2L,0L,2L,0L,1L,0L,0L,0L,0L,-2L,0L,-2L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,-1L,2L,-1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121454Inst : IEnumerable<long>
{
public static readonly long[] Value=A121454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121454.Bytes);
public long this[int i]=>Value[i];

public static A121454Inst Instance=new A121454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121455
{
public static readonly long[] Value={ 1L,-4L,4L,0L,6L,-16L,8L,0L,13L,-24L,12L,0L,14L,-32L,24L,0L,18L,-52L,20L,0L,32L,-48L,24L,0L,31L,-56L,40L,0L,30L,-96L,32L,0L,48L,-72L,48L,0L,38L,-80L,56L,0L,42L,-128L,44L,0L,78L,-96L,48L,0L,57L,-124L,72L,0L,54L,-160L,72L,0L,80L,-120L,60L,0L,62L,-128L,104L,0L,84L,-192L,68L,0L,96L,-192L,72L,0L,74L,-152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121455Inst : IEnumerable<long>
{
public static readonly long[] Value=A121455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121455.Bytes);
public long this[int i]=>Value[i];

public static A121455Inst Instance=new A121455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121456
{
public static readonly long[] Value={ 1L,-2L,1L,-4L,6L,-2L,8L,-8L,1L,-12L,12L,-4L,14L,-16L,6L,-16L,18L,-2L,20L,-24L,8L,-24L,24L,-8L,31L,-28L,1L,-32L,30L,-12L,32L,-32L,12L,-36L,48L,-4L,38L,-40L,14L,-48L,42L,-16L,44L,-48L,6L,-48L,48L,-16L,57L,-62L,18L,-56L,54L,-2L,72L,-64L,20L,-60L,60L,-24L,62L,-64L,8L,-64L,84L,-24L,68L,-72L,24L,-96L,72L,-8L,74L,-76L,31L,-80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121456Inst : IEnumerable<long>
{
public static readonly long[] Value=A121456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121456.Bytes);
public long this[int i]=>Value[i];

public static A121456Inst Instance=new A121456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121457
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,6L,6L,8L,6L,12L,24L,24L,30L,20L,40L,30L,60L,120L,120L,144L,90L,80L,180L,120L,90L,240L,180L,360L,720L,720L,840L,504L,420L,1008L,630L,560L,420L,1260L,840L,630L,1680L,1260L,2520L,5040L,5040L,5760L,3360L,2688L,2520L,6720L,4032L,3360L,2520L,2240L,8064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121457Inst : IEnumerable<long>
{
public static readonly long[] Value=A121457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121457.Bytes);
public long this[int i]=>Value[i];

public static A121457Inst Instance=new A121457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121458
{
public static readonly long[] Value={ 1L,1L,19L,28L,406L,721L,8722L,17983L,188209L,438697L,4078270L,10530100L,88714549L,249679990L,1936716229L,5864281633L,42418800739L,136706927896L,931844786950L,3167777090989L,20525689021222L,73046232419419L,453213909082585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121458Inst : IEnumerable<long>
{
public static readonly long[] Value=A121458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121458.Bytes);
public long this[int i]=>Value[i];

public static A121458Inst Instance=new A121458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121459
{
public static readonly long[] Value={ 0L,-3L,-14L,-18L,-7L,-9L,-47L,-51L,0L,-15L,-15L,-48L,-17L,-36L,57L,-151L,0L,-63L,0L,-11L,0L,25L,26L,368L,29L,-5L,-96L,-33L,0L,-144L,16927L,-466L,-180L,9033L,10192L,0L,-43L,316L,0L,0L,47L,-302L,49L,152L,1122L,945L,9145L,71914L,8041L,9591L,121L,54L,23142L,0L,177L,12813L,1665L,-5L,3255L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121459Inst : IEnumerable<long>
{
public static readonly long[] Value=A121459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121459.Bytes);
public long this[int i]=>Value[i];

public static A121459Inst Instance=new A121459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121460
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,4L,3L,1L,13L,9L,7L,4L,1L,34L,22L,16L,11L,5L,1L,89L,56L,38L,27L,16L,6L,1L,233L,145L,94L,65L,43L,22L,7L,1L,610L,378L,239L,159L,108L,65L,29L,8L,1L,1597L,988L,617L,398L,267L,173L,94L,37L,9L,1L,4181L,2585L,1605L,1015L,665L,440L,267L,131L,46L,10L,1L,10946L,6766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121460Inst : IEnumerable<long>
{
public static readonly long[] Value=A121460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121460.Bytes);
public long this[int i]=>Value[i];

public static A121460Inst Instance=new A121460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121461
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,8L,3L,1L,1L,21L,8L,3L,1L,1L,55L,21L,8L,3L,1L,1L,144L,55L,21L,8L,3L,1L,1L,377L,144L,55L,21L,8L,3L,1L,1L,987L,377L,144L,55L,21L,8L,3L,1L,1L,2584L,987L,377L,144L,55L,21L,8L,3L,1L,1L,6765L,2584L,987L,377L,144L,55L,21L,8L,3L,1L,1L,17711L,6765L,2584L,987L,377L,144L,55L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121461Inst : IEnumerable<long>
{
public static readonly long[] Value=A121461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121461.Bytes);
public long this[int i]=>Value[i];

public static A121461Inst Instance=new A121461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121462
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,4L,0L,1L,4L,8L,0L,1L,5L,12L,16L,0L,1L,6L,18L,32L,32L,0L,1L,7L,25L,56L,80L,64L,0L,1L,8L,33L,88L,160L,192L,128L,0L,1L,9L,42L,129L,280L,432L,448L,256L,0L,1L,10L,52L,180L,450L,832L,1120L,1024L,512L,0L,1L,11L,63L,242L,681L,1452L,2352L,2816L,2304L,1024L,0L,1L,12L,75L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121462Inst : IEnumerable<long>
{
public static readonly long[] Value=A121462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121462.Bytes);
public long this[int i]=>Value[i];

public static A121462Inst Instance=new A121462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121463
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,11L,1L,1L,26L,7L,1L,57L,30L,1L,1L,120L,102L,10L,1L,247L,303L,58L,1L,1L,502L,825L,256L,13L,1L,1013L,2116L,955L,95L,1L,1L,2036L,5200L,3178L,515L,16L,1L,4083L,12381L,9740L,2310L,141L,1L,1L,8178L,28779L,28064L,9078L,906L,19L,1L,16369L,65658L,77093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121463Inst : IEnumerable<long>
{
public static readonly long[] Value=A121463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121463.Bytes);
public long this[int i]=>Value[i];

public static A121463Inst Instance=new A121463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121464
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,1L,2L,1L,4L,2L,3L,3L,1L,12L,6L,5L,6L,4L,1L,33L,18L,11L,11L,10L,5L,1L,88L,51L,29L,22L,21L,15L,6L,1L,232L,139L,80L,51L,43L,36L,21L,7L,1L,609L,371L,219L,131L,94L,79L,57L,28L,8L,1L,1596L,980L,590L,350L,225L,173L,136L,85L,36L,9L,1L,4180L,2576L,1570L,940L,575L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121464Inst : IEnumerable<long>
{
public static readonly long[] Value=A121464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121464.Bytes);
public long this[int i]=>Value[i];

public static A121464Inst Instance=new A121464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121465
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,1L,0L,0L,4L,4L,1L,0L,0L,8L,12L,4L,2L,0L,0L,16L,33L,12L,8L,4L,0L,0L,32L,88L,33L,24L,16L,8L,0L,0L,64L,232L,88L,66L,48L,32L,16L,0L,0L,128L,609L,232L,176L,132L,96L,64L,32L,0L,0L,256L,1596L,609L,464L,352L,264L,192L,128L,64L,0L,0L,512L,4180L,1596L,1218L,928L,704L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121465Inst : IEnumerable<long>
{
public static readonly long[] Value=A121465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121465.Bytes);
public long this[int i]=>Value[i];

public static A121465Inst Instance=new A121465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121466
{
public static readonly long[] Value={ 1L,2L,4L,1L,8L,5L,16L,17L,1L,32L,49L,8L,64L,129L,39L,1L,128L,321L,150L,11L,256L,769L,501L,70L,1L,512L,1793L,1524L,338L,14L,1024L,4097L,4339L,1375L,110L,1L,2048L,9217L,11762L,4973L,640L,17L,4096L,20481L,30705L,16508L,3075L,159L,1L,8192L,45057L,77808L,51340L,12918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121466Inst : IEnumerable<long>
{
public static readonly long[] Value=A121466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121466.Bytes);
public long this[int i]=>Value[i];

public static A121466Inst Instance=new A121466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121467
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,0L,0L,1L,0L,3L,0L,2L,0L,3L,0L,2L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,4L,0L,4L,0L,5L,0L,5L,0L,4L,0L,4L,0L,3L,0L,2L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,5L,0L,7L,0L,8L,0L,10L,0L,8L,0L,11L,0L,9L,0L,7L,0L,6L,0L,6L,0L,4L,0L,3L,0L,2L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,6L,0L,11L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121467Inst : IEnumerable<long>
{
public static readonly long[] Value=A121467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121467.Bytes);
public long this[int i]=>Value[i];

public static A121467Inst Instance=new A121467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121468
{
public static readonly long[] Value={ 1L,2L,1L,6L,3L,1L,18L,9L,4L,1L,53L,28L,12L,5L,1L,154L,85L,38L,15L,6L,1L,443L,253L,117L,48L,18L,7L,1L,1264L,742L,352L,149L,58L,21L,8L,1L,3582L,2151L,1041L,451L,181L,68L,24L,9L,1L,10092L,6177L,3038L,1340L,550L,213L,78L,27L,10L,1L,28291L,17600L,8772L,3925L,1639L,649L,245L,88L,30L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121468Inst : IEnumerable<long>
{
public static readonly long[] Value=A121468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121468.Bytes);
public long this[int i]=>Value[i];

public static A121468Inst Instance=new A121468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121469
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,3L,0L,1L,3L,4L,5L,0L,1L,6L,13L,7L,7L,0L,1L,14L,28L,27L,10L,9L,0L,1L,31L,70L,62L,45L,13L,11L,0L,1L,70L,164L,171L,108L,67L,16L,13L,0L,1L,157L,392L,429L,325L,166L,93L,19L,15L,0L,1L,353L,926L,1101L,862L,540L,236L,123L,22L,17L,0L,1L,793L,2189L,2766L,2355L,1499L,824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121469Inst : IEnumerable<long>
{
public static readonly long[] Value=A121469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121469.Bytes);
public long this[int i]=>Value[i];

public static A121469Inst Instance=new A121469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121470
{
public static readonly long[] Value={ 1L,7L,16L,31L,49L,73L,100L,133L,169L,211L,256L,307L,361L,421L,484L,553L,625L,703L,784L,871L,961L,1057L,1156L,1261L,1369L,1483L,1600L,1723L,1849L,1981L,2116L,2257L,2401L,2551L,2704L,2863L,3025L,3193L,3364L,3541L,3721L,3907L,4096L,4291L,4489L,4693L,4900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121470Inst : IEnumerable<long>
{
public static readonly long[] Value=A121470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121470.Bytes);
public long this[int i]=>Value[i];

public static A121470Inst Instance=new A121470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121471
{
public static readonly long[] Value={ 1L,3L,11L,22L,39L,59L,85L,114L,149L,187L,231L,278L,331L,387L,449L,514L,585L,659L,739L,822L,911L,1003L,1101L,1202L,1309L,1419L,1535L,1654L,1779L,1907L,2041L,2178L,2321L,2467L,2619L,2774L,2935L,3099L,3269L,3442L,3621L,3803L,3991L,4182L,4379L,4579L,4785L,4994L,5209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121471Inst : IEnumerable<long>
{
public static readonly long[] Value=A121471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121471.Bytes);
public long this[int i]=>Value[i];

public static A121471Inst Instance=new A121471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121472
{
public static readonly long[] Value={ 8L,5L,7L,2L,8L,2L,3L,8L,3L,1L,0L,3L,4L,0L,6L,1L,7L,7L,5L,1L,1L,9L,0L,3L,3L,0L,8L,5L,0L,9L,7L,3L,3L,9L,9L,7L,5L,9L,0L,9L,8L,8L,3L,1L,2L,0L,9L,3L,1L,4L,6L,9L,2L,2L,2L,5L,7L,8L,2L,4L,2L,9L,2L,4L,6L,0L,6L,9L,3L,3L,3L,3L,2L,6L,8L,3L,3L,6L,3L,4L,8L,2L,8L,9L,1L,0L,8L,1L,1L,5L,2L,4L,9L,3L,5L,4L,1L,1L,2L,7L,0L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121472Inst : IEnumerable<long>
{
public static readonly long[] Value=A121472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121472.Bytes);
public long this[int i]=>Value[i];

public static A121472Inst Instance=new A121472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121473
{
public static readonly BigInteger[] Value={ 0L,1L,6L,146L,8L,BigInteger.Parse("37783544111994270385152"),BigInteger.Parse("784637716923335095479473680436259502469253233551410733056"),BigInteger.Parse("309485009821345068724781056") };
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
public class A121473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121473Inst Instance=new A121473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121474
{
public static readonly long[] Value={ 2L,3L,3L,0L,7L,2L,4L,0L,7L,0L,4L,5L,0L,0L,9L,7L,8L,4L,7L,3L,5L,7L,2L,7L,2L,6L,4L,0L,1L,7L,8L,0L,9L,3L,5L,3L,8L,6L,0L,3L,1L,4L,8L,6L,1L,0L,1L,4L,3L,8L,7L,5L,6L,5L,0L,3L,2L,1L,0L,8L,2L,4L,3L,3L,1L,6L,6L,7L,2L,1L,0L,5L,5L,0L,5L,8L,6L,4L,0L,0L,5L,0L,3L,8L,2L,0L,0L,0L,6L,2L,3L,0L,8L,5L,2L,3L,5L,4L,2L,4L,8L,9L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121474Inst : IEnumerable<long>
{
public static readonly long[] Value=A121474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121474.Bytes);
public long this[int i]=>Value[i];

public static A121474Inst Instance=new A121474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121475
{
public static readonly BigInteger[] Value={ 2L,3L,42L,4L,4512412933881984L,BigInteger.Parse("2722258935367507708887588480171556995584"),2305843009213693952L,BigInteger.Parse("6277101735386680763835789423207666416102355444464034512896") };
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
public class A121475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121475Inst Instance=new A121475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121476
{
public static readonly long[] Value={ 9L,171L,252L,333L,414L,10701L,11511L,12321L,13131L,20502L,21312L,22122L,30303L,31113L,40104L,1007001L,1015101L,1023201L,1031301L,1105011L,1113111L,1121211L,1203021L,1211121L,2005002L,2013102L,2021202L,2103012L,2111112L,2201022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121476Inst : IEnumerable<long>
{
public static readonly long[] Value=A121476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121476.Bytes);
public long this[int i]=>Value[i];

public static A121476Inst Instance=new A121476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121477
{
public static readonly long[] Value={ 9L,171L,252L,333L,414L,11511L,12321L,13131L,21321L,22122L,31113L,1113111L,1121211L,1211121L,2111112L,111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121477Inst : IEnumerable<long>
{
public static readonly long[] Value=A121477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121477.Bytes);
public long this[int i]=>Value[i];

public static A121477Inst Instance=new A121477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121478
{
public static readonly long[] Value={ 66L,78L,105L,120L,190L,231L,276L,300L,378L,406L,435L,465L,528L,561L,595L,666L,741L,820L,861L,903L,946L,1035L,1128L,1176L,1275L,1378L,1485L,1653L,1953L,2016L,2080L,2211L,2278L,2485L,2556L,2628L,2775L,3081L,3160L,3240L,3655L,3741L,3916L,4005L,4371L,4465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121478Inst : IEnumerable<long>
{
public static readonly long[] Value=A121478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121478.Bytes);
public long this[int i]=>Value[i];

public static A121478Inst Instance=new A121478Inst();

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