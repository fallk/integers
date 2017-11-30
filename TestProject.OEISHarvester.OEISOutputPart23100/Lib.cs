using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A039069
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,9L,10L,12L,13L,15L,16L,17L,18L,20L,21L,23L,30L,32L,33L,34L,36L,37L,39L,40L,41L,42L,44L,45L,47L,51L,56L,57L,58L,60L,61L,63L,64L,65L,66L,68L,69L,71L,72L,73L,74L,76L,77L,79L,80L,81L,82L,84L,85L,87L,94L,96L,97L,98L,100L,101L,103L,104L,105L,106L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039069Inst : IEnumerable<long>
{
public static readonly long[] Value=A039069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039069.Bytes);
public long this[int i]=>Value[i];

public static A039069Inst Instance=new A039069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039068
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,9L,10L,12L,14L,15L,16L,17L,18L,20L,22L,23L,29L,32L,33L,34L,36L,38L,39L,43L,48L,49L,50L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,70L,71L,72L,73L,74L,76L,78L,79L,80L,81L,82L,84L,86L,87L,93L,96L,97L,98L,100L,102L,103L,107L,112L,113L,114L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039068Inst : IEnumerable<long>
{
public static readonly long[] Value=A039068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039068.Bytes);
public long this[int i]=>Value[i];

public static A039068Inst Instance=new A039068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039067
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,9L,10L,13L,14L,15L,16L,17L,18L,21L,22L,23L,28L,35L,40L,41L,42L,45L,46L,47L,48L,49L,50L,53L,54L,55L,56L,57L,58L,61L,62L,63L,64L,65L,66L,69L,70L,71L,72L,73L,74L,77L,78L,79L,80L,81L,82L,85L,86L,87L,92L,99L,104L,105L,106L,109L,110L,111L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039067Inst : IEnumerable<long>
{
public static readonly long[] Value=A039067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039067.Bytes);
public long this[int i]=>Value[i];

public static A039067Inst Instance=new A039067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039066
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,11L,12L,13L,14L,23L,24L,25L,27L,28L,29L,30L,32L,33L,35L,36L,37L,38L,40L,41L,43L,44L,45L,46L,48L,49L,51L,52L,53L,54L,58L,64L,65L,67L,68L,69L,70L,72L,73L,75L,76L,77L,78L,87L,88L,89L,91L,92L,93L,94L,96L,97L,99L,100L,101L,102L,104L,105L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039066Inst : IEnumerable<long>
{
public static readonly long[] Value=A039066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039066.Bytes);
public long this[int i]=>Value[i];

public static A039066Inst Instance=new A039066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039065
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,9L,11L,12L,13L,15L,22L,24L,25L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,45L,47L,50L,56L,57L,59L,60L,61L,63L,64L,65L,67L,68L,69L,71L,72L,73L,75L,76L,77L,79L,86L,88L,89L,91L,92L,93L,95L,96L,97L,99L,100L,101L,103L,104L,105L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039065Inst : IEnumerable<long>
{
public static readonly long[] Value=A039065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039065.Bytes);
public long this[int i]=>Value[i];

public static A039065Inst Instance=new A039065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039064
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,8L,9L,11L,12L,14L,15L,21L,24L,25L,27L,28L,30L,31L,32L,33L,35L,36L,38L,39L,42L,48L,49L,51L,52L,54L,55L,56L,57L,59L,60L,62L,63L,64L,65L,67L,68L,70L,71L,72L,73L,75L,76L,78L,79L,85L,88L,89L,91L,92L,94L,95L,96L,97L,99L,100L,102L,103L,106L,112L,113L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039064Inst : IEnumerable<long>
{
public static readonly long[] Value=A039064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039064.Bytes);
public long this[int i]=>Value[i];

public static A039064Inst Instance=new A039064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039063
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,8L,9L,11L,13L,14L,15L,20L,24L,25L,27L,29L,30L,31L,34L,40L,41L,43L,45L,46L,47L,48L,49L,51L,53L,54L,55L,56L,57L,59L,61L,62L,63L,64L,65L,67L,69L,70L,71L,72L,73L,75L,77L,78L,79L,84L,88L,89L,91L,93L,94L,95L,98L,104L,105L,107L,109L,110L,111L,112L,113L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039063Inst : IEnumerable<long>
{
public static readonly long[] Value=A039063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039063.Bytes);
public long this[int i]=>Value[i];

public static A039063Inst Instance=new A039063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039062
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,8L,9L,12L,13L,14L,15L,19L,26L,32L,33L,36L,37L,38L,39L,40L,41L,44L,45L,46L,47L,48L,49L,52L,53L,54L,55L,56L,57L,60L,61L,62L,63L,64L,65L,68L,69L,70L,71L,72L,73L,76L,77L,78L,79L,83L,90L,96L,97L,100L,101L,102L,103L,104L,105L,108L,109L,110L,111L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039062Inst : IEnumerable<long>
{
public static readonly long[] Value=A039062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039062.Bytes);
public long this[int i]=>Value[i];

public static A039062Inst Instance=new A039062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039061
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,15L,16L,18L,19L,20L,21L,22L,24L,26L,27L,28L,29L,30L,32L,34L,35L,36L,37L,38L,40L,42L,43L,44L,45L,46L,48L,50L,51L,52L,53L,54L,57L,71L,87L,95L,103L,111L,119L,120L,122L,123L,124L,125L,126L,128L,130L,131L,132L,133L,134L,143L,144L,146L,147L,148L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039061Inst : IEnumerable<long>
{
public static readonly long[] Value=A039061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039061.Bytes);
public long this[int i]=>Value[i];

public static A039061Inst Instance=new A039061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039060
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,14L,16L,18L,19L,20L,21L,23L,24L,26L,27L,28L,29L,31L,32L,34L,35L,36L,37L,39L,40L,42L,43L,44L,45L,47L,49L,56L,58L,59L,60L,61L,63L,70L,86L,94L,102L,110L,112L,114L,115L,116L,117L,119L,126L,128L,130L,131L,132L,133L,135L,142L,144L,146L,147L,148L,149L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039060Inst : IEnumerable<long>
{
public static readonly long[] Value=A039060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039060.Bytes);
public long this[int i]=>Value[i];

public static A039060Inst Instance=new A039060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039059
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,13L,16L,18L,19L,20L,22L,23L,24L,26L,27L,28L,30L,31L,32L,34L,35L,36L,38L,39L,41L,48L,50L,51L,52L,54L,55L,56L,58L,59L,60L,62L,63L,69L,85L,93L,101L,104L,106L,107L,108L,110L,111L,117L,125L,128L,130L,131L,132L,134L,135L,141L,144L,146L,147L,148L,150L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039059Inst : IEnumerable<long>
{
public static readonly long[] Value=A039059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039059.Bytes);
public long this[int i]=>Value[i];

public static A039059Inst Instance=new A039059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039058
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,7L,12L,16L,18L,19L,21L,22L,23L,24L,26L,27L,29L,30L,31L,33L,40L,42L,43L,45L,46L,47L,48L,50L,51L,53L,54L,55L,56L,58L,59L,61L,62L,63L,68L,84L,92L,96L,98L,99L,101L,102L,103L,108L,116L,124L,128L,130L,131L,133L,134L,135L,140L,144L,146L,147L,149L,150L,151L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039058Inst : IEnumerable<long>
{
public static readonly long[] Value=A039058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039058.Bytes);
public long this[int i]=>Value[i];

public static A039058Inst Instance=new A039058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039057
{
public static readonly long[] Value={ 0L,2L,4L,5L,6L,7L,11L,16L,18L,20L,21L,22L,23L,25L,32L,34L,36L,37L,38L,39L,40L,42L,44L,45L,46L,47L,48L,50L,52L,53L,54L,55L,56L,58L,60L,61L,62L,63L,67L,83L,88L,90L,92L,93L,94L,95L,99L,107L,115L,123L,128L,130L,132L,133L,134L,135L,139L,144L,146L,148L,149L,150L,151L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039057Inst : IEnumerable<long>
{
public static readonly long[] Value=A039057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039057.Bytes);
public long this[int i]=>Value[i];

public static A039057Inst Instance=new A039057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039056
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,10L,17L,24L,27L,28L,29L,30L,31L,32L,35L,36L,37L,38L,39L,40L,43L,44L,45L,46L,47L,48L,51L,52L,53L,54L,55L,56L,59L,60L,61L,62L,63L,66L,80L,83L,84L,85L,86L,87L,90L,98L,106L,114L,122L,129L,136L,139L,140L,141L,142L,143L,153L,161L,169L,177L,185L,192L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039056Inst : IEnumerable<long>
{
public static readonly long[] Value=A039056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039056.Bytes);
public long this[int i]=>Value[i];

public static A039056Inst Instance=new A039056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039055
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,23L,25L,26L,27L,28L,29L,31L,33L,34L,35L,36L,37L,39L,41L,42L,43L,44L,45L,47L,48L,57L,58L,59L,60L,61L,63L,70L,73L,74L,75L,76L,77L,79L,81L,82L,83L,84L,85L,87L,89L,90L,91L,92L,93L,95L,97L,98L,99L,100L,101L,103L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039055Inst : IEnumerable<long>
{
public static readonly long[] Value=A039055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039055.Bytes);
public long this[int i]=>Value[i];

public static A039055Inst Instance=new A039055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039054
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,10L,11L,12L,14L,15L,17L,18L,19L,20L,22L,23L,25L,26L,27L,28L,30L,31L,33L,34L,35L,36L,38L,39L,40L,49L,50L,51L,52L,54L,55L,57L,58L,59L,60L,62L,63L,69L,73L,74L,75L,76L,78L,79L,81L,82L,83L,84L,86L,87L,89L,90L,91L,92L,94L,95L,97L,98L,99L,100L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039054Inst : IEnumerable<long>
{
public static readonly long[] Value=A039054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039054.Bytes);
public long this[int i]=>Value[i];

public static A039054Inst Instance=new A039054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039053
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,41L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,63L,68L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,90L,91L,93L,94L,95L,96L,105L,106L,107L,109L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039053Inst : IEnumerable<long>
{
public static readonly long[] Value=A039053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039053.Bytes);
public long this[int i]=>Value[i];

public static A039053Inst Instance=new A039053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039052
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,9L,10L,12L,13L,14L,15L,17L,18L,20L,21L,22L,23L,24L,33L,34L,36L,37L,38L,39L,41L,42L,44L,45L,46L,47L,49L,50L,52L,53L,54L,55L,57L,58L,60L,61L,62L,63L,67L,73L,74L,76L,77L,78L,79L,81L,82L,84L,85L,86L,87L,88L,97L,98L,100L,101L,102L,103L,105L,106L,108L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039052Inst : IEnumerable<long>
{
public static readonly long[] Value=A039052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039052.Bytes);
public long this[int i]=>Value[i];

public static A039052Inst Instance=new A039052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039051
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,9L,11L,12L,13L,14L,15L,16L,25L,27L,28L,29L,30L,31L,33L,35L,36L,37L,38L,39L,41L,43L,44L,45L,46L,47L,49L,51L,52L,53L,54L,55L,57L,59L,60L,61L,62L,63L,66L,73L,75L,76L,77L,78L,79L,80L,89L,91L,92L,93L,94L,95L,97L,99L,100L,101L,102L,103L,105L,107L,108L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039051Inst : IEnumerable<long>
{
public static readonly long[] Value=A039051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039051.Bytes);
public long this[int i]=>Value[i];

public static A039051Inst Instance=new A039051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039050
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,18L,19L,20L,21L,22L,23L,26L,27L,28L,29L,30L,31L,34L,35L,36L,37L,38L,39L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,54L,55L,58L,59L,60L,61L,62L,63L,66L,67L,68L,69L,70L,71L,80L,88L,96L,104L,112L,120L,129L,136L,146L,147L,148L,149L,150L,151L,154L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039050Inst : IEnumerable<long>
{
public static readonly long[] Value=A039050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039050.Bytes);
public long this[int i]=>Value[i];

public static A039050Inst Instance=new A039050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039049
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,8L,9L,10L,11L,14L,15L,16L,17L,18L,21L,22L,23L,24L,25L,28L,29L,30L,31L,32L,41L,47L,49L,50L,51L,52L,53L,56L,57L,58L,59L,60L,63L,64L,65L,66L,67L,70L,71L,72L,73L,74L,77L,78L,79L,80L,81L,90L,96L,98L,99L,100L,101L,102L,105L,106L,107L,108L,109L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039049Inst : IEnumerable<long>
{
public static readonly long[] Value=A039049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039049.Bytes);
public long this[int i]=>Value[i];

public static A039049Inst Instance=new A039049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039048
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,8L,9L,10L,12L,14L,15L,16L,17L,19L,21L,22L,23L,24L,26L,34L,35L,36L,37L,38L,40L,46L,49L,50L,51L,52L,54L,56L,57L,58L,59L,61L,63L,64L,65L,66L,68L,70L,71L,72L,73L,75L,83L,84L,85L,86L,87L,89L,95L,98L,99L,100L,101L,103L,105L,106L,107L,108L,110L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039048Inst : IEnumerable<long>
{
public static readonly long[] Value=A039048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039048.Bytes);
public long this[int i]=>Value[i];

public static A039048Inst Instance=new A039048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039047
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,10L,13L,14L,15L,16L,17L,20L,21L,22L,23L,24L,27L,33L,39L,42L,43L,44L,45L,48L,49L,50L,51L,52L,55L,56L,57L,58L,59L,62L,63L,64L,65L,66L,69L,70L,71L,72L,73L,76L,82L,88L,91L,92L,93L,94L,97L,98L,99L,100L,101L,104L,105L,106L,107L,108L,111L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039047Inst : IEnumerable<long>
{
public static readonly long[] Value=A039047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039047.Bytes);
public long this[int i]=>Value[i];

public static A039047Inst Instance=new A039047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039046
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,9L,11L,12L,14L,15L,16L,18L,19L,27L,28L,29L,30L,32L,33L,35L,36L,37L,39L,40L,45L,49L,50L,51L,53L,54L,56L,57L,58L,60L,61L,63L,64L,65L,67L,68L,76L,77L,78L,79L,81L,82L,84L,85L,86L,88L,89L,94L,98L,99L,100L,102L,103L,105L,106L,107L,109L,110L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039046Inst : IEnumerable<long>
{
public static readonly long[] Value=A039046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039046.Bytes);
public long this[int i]=>Value[i];

public static A039046Inst Instance=new A039046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039045
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,9L,11L,13L,14L,15L,16L,18L,20L,26L,28L,29L,30L,32L,34L,38L,42L,43L,44L,46L,48L,49L,50L,51L,53L,55L,56L,57L,58L,60L,62L,63L,64L,65L,67L,69L,75L,77L,78L,79L,81L,83L,87L,91L,92L,93L,95L,97L,98L,99L,100L,102L,104L,105L,106L,107L,109L,111L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039045Inst : IEnumerable<long>
{
public static readonly long[] Value=A039045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039045.Bytes);
public long this[int i]=>Value[i];

public static A039045Inst Instance=new A039045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039044
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,9L,12L,13L,14L,15L,16L,19L,20L,25L,31L,35L,36L,37L,40L,41L,42L,43L,44L,47L,48L,49L,50L,51L,54L,55L,56L,57L,58L,61L,62L,63L,64L,65L,68L,69L,74L,80L,84L,85L,86L,89L,90L,91L,92L,93L,96L,97L,98L,99L,100L,103L,104L,105L,106L,107L,110L,111L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039044Inst : IEnumerable<long>
{
public static readonly long[] Value=A039044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039044.Bytes);
public long this[int i]=>Value[i];

public static A039044Inst Instance=new A039044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039043
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,10L,11L,12L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,33L,35L,36L,38L,39L,40L,44L,49L,50L,52L,53L,54L,56L,57L,59L,60L,61L,69L,70L,71L,73L,74L,75L,77L,78L,80L,81L,82L,84L,85L,87L,88L,89L,93L,104L,111L,125L,132L,139L,140L,141L,143L,144L,145L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039043Inst : IEnumerable<long>
{
public static readonly long[] Value=A039043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039043.Bytes);
public long this[int i]=>Value[i];

public static A039043Inst Instance=new A039043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039042
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,8L,10L,11L,13L,19L,21L,22L,24L,25L,27L,28L,29L,31L,32L,34L,37L,42L,43L,45L,46L,48L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,68L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,86L,91L,92L,94L,95L,97L,103L,110L,124L,131L,133L,134L,136L,137L,139L,145L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039042Inst : IEnumerable<long>
{
public static readonly long[] Value=A039042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039042.Bytes);
public long this[int i]=>Value[i];

public static A039042Inst Instance=new A039042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039041
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,8L,10L,12L,13L,18L,21L,22L,24L,26L,27L,30L,35L,36L,38L,40L,41L,42L,43L,45L,47L,48L,49L,50L,52L,54L,55L,56L,57L,59L,61L,62L,67L,70L,71L,73L,75L,76L,79L,84L,85L,87L,89L,90L,91L,92L,94L,96L,97L,102L,109L,123L,126L,127L,129L,131L,132L,137L,144L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039041Inst : IEnumerable<long>
{
public static readonly long[] Value=A039041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039041.Bytes);
public long this[int i]=>Value[i];

public static A039041Inst Instance=new A039041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039040
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,8L,11L,12L,13L,17L,23L,28L,29L,32L,33L,34L,35L,36L,39L,40L,41L,42L,43L,46L,47L,48L,49L,50L,53L,54L,55L,56L,57L,60L,61L,62L,66L,72L,77L,78L,81L,82L,83L,84L,85L,88L,89L,90L,91L,92L,95L,96L,97L,101L,108L,119L,120L,123L,124L,125L,129L,136L,143L,149L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039040Inst : IEnumerable<long>
{
public static readonly long[] Value=A039040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039040.Bytes);
public long this[int i]=>Value[i];

public static A039040Inst Instance=new A039040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039039
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,13L,14L,16L,17L,18L,19L,21L,23L,24L,25L,26L,28L,30L,31L,32L,33L,35L,37L,38L,39L,40L,43L,55L,69L,76L,83L,90L,91L,93L,94L,95L,96L,98L,100L,101L,102L,103L,111L,112L,114L,115L,116L,117L,119L,121L,122L,123L,124L,126L,128L,129L,130L,131L,133L,135L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039039Inst : IEnumerable<long>
{
public static readonly long[] Value=A039039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039039.Bytes);
public long this[int i]=>Value[i];

public static A039039Inst Instance=new A039039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039038
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,12L,14L,16L,17L,18L,20L,21L,23L,24L,25L,27L,28L,30L,31L,32L,34L,36L,42L,44L,45L,46L,48L,54L,68L,75L,82L,84L,86L,87L,88L,90L,96L,98L,100L,101L,102L,104L,110L,112L,114L,115L,116L,118L,119L,121L,122L,123L,125L,126L,128L,129L,130L,132L,134L,140L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039038Inst : IEnumerable<long>
{
public static readonly long[] Value=A039038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039038.Bytes);
public long this[int i]=>Value[i];

public static A039038Inst Instance=new A039038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039037
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,11L,14L,16L,17L,19L,20L,21L,23L,24L,26L,27L,29L,35L,37L,38L,40L,41L,42L,44L,45L,47L,48L,53L,67L,74L,77L,79L,80L,82L,83L,88L,95L,98L,100L,101L,103L,104L,109L,112L,114L,115L,117L,118L,119L,121L,122L,124L,125L,127L,133L,135L,136L,138L,139L,140L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039037Inst : IEnumerable<long>
{
public static readonly long[] Value=A039037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039037.Bytes);
public long this[int i]=>Value[i];

public static A039037Inst Instance=new A039037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039020
{
public static readonly long[] Value={ 0L,3L,4L,5L,8L,13L,18L,21L,22L,23L,24L,27L,28L,29L,30L,33L,34L,35L,38L,48L,51L,52L,53L,56L,62L,68L,73L,78L,81L,82L,83L,91L,97L,103L,108L,111L,112L,113L,116L,121L,126L,129L,130L,131L,132L,135L,136L,137L,138L,141L,142L,143L,144L,147L,148L,149L,152L,157L,162L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039020Inst : IEnumerable<long>
{
public static readonly long[] Value=A039020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039020.Bytes);
public long this[int i]=>Value[i];

public static A039020Inst Instance=new A039020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039019
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,9L,11L,13L,14L,15L,17L,19L,20L,21L,23L,24L,31L,32L,33L,35L,40L,43L,44L,45L,47L,49L,50L,51L,53L,55L,56L,57L,59L,60L,67L,68L,69L,71L,76L,79L,80L,81L,83L,85L,86L,87L,89L,91L,92L,93L,95L,96L,103L,104L,105L,107L,112L,115L,116L,117L,119L,121L,122L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039019Inst : IEnumerable<long>
{
public static readonly long[] Value=A039019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039019.Bytes);
public long this[int i]=>Value[i];

public static A039019Inst Instance=new A039019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039018
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,18L,25L,26L,28L,29L,31L,32L,34L,35L,39L,43L,44L,46L,47L,49L,50L,52L,53L,54L,61L,62L,64L,65L,67L,68L,70L,71L,75L,79L,80L,82L,83L,85L,86L,88L,89L,90L,97L,98L,100L,101L,103L,104L,106L,107L,109L,110L,112L,113L,114L,120L,132L,138L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039018Inst : IEnumerable<long>
{
public static readonly long[] Value=A039018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039018.Bytes);
public long this[int i]=>Value[i];

public static A039018Inst Instance=new A039018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039017
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,10L,11L,12L,19L,21L,22L,23L,25L,27L,28L,29L,31L,33L,34L,35L,38L,43L,45L,46L,47L,48L,55L,57L,58L,59L,61L,63L,64L,65L,67L,69L,70L,71L,73L,75L,76L,77L,78L,90L,96L,102L,110L,115L,117L,118L,119L,120L,127L,129L,130L,131L,133L,135L,136L,137L,139L,141L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039017Inst : IEnumerable<long>
{
public static readonly long[] Value=A039017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039017.Bytes);
public long this[int i]=>Value[i];

public static A039017Inst Instance=new A039017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039016
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,14L,15L,16L,17L,20L,21L,22L,23L,26L,27L,28L,29L,32L,33L,34L,35L,38L,39L,40L,41L,48L,54L,60L,66L,73L,78L,86L,87L,88L,89L,92L,93L,94L,95L,98L,99L,100L,101L,104L,105L,106L,107L,109L,114L,122L,123L,124L,125L,128L,129L,130L,131L,134L,135L,136L,137L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039016Inst : IEnumerable<long>
{
public static readonly long[] Value=A039016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039016.Bytes);
public long this[int i]=>Value[i];

public static A039016Inst Instance=new A039016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039015
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,10L,11L,12L,19L,23L,25L,26L,27L,30L,31L,32L,35L,36L,37L,44L,48L,50L,51L,52L,55L,56L,57L,60L,61L,62L,69L,73L,79L,84L,89L,95L,96L,97L,103L,108L,113L,115L,116L,117L,125L,126L,127L,130L,131L,132L,135L,136L,137L,144L,148L,150L,151L,152L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039015Inst : IEnumerable<long>
{
public static readonly long[] Value=A039015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039015.Bytes);
public long this[int i]=>Value[i];

public static A039015Inst Instance=new A039015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039014
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,8L,14L,15L,16L,18L,22L,25L,26L,28L,30L,31L,33L,39L,40L,41L,43L,47L,54L,59L,69L,70L,71L,73L,75L,76L,78L,80L,81L,83L,89L,90L,91L,93L,97L,102L,107L,110L,111L,113L,117L,125L,126L,128L,130L,131L,133L,139L,140L,141L,143L,147L,150L,151L,153L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039014Inst : IEnumerable<long>
{
public static readonly long[] Value=A039014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039014.Bytes);
public long this[int i]=>Value[i];

public static A039014Inst Instance=new A039014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039013
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,9L,13L,17L,20L,21L,24L,25L,26L,29L,30L,31L,34L,38L,42L,45L,46L,49L,53L,58L,65L,66L,69L,73L,77L,82L,85L,86L,89L,97L,100L,101L,104L,105L,106L,109L,113L,117L,120L,121L,124L,125L,126L,129L,130L,131L,134L,138L,142L,145L,146L,149L,150L,151L,154L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039013Inst : IEnumerable<long>
{
public static readonly long[] Value=A039013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039013.Bytes);
public long this[int i]=>Value[i];

public static A039013Inst Instance=new A039013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039012
{
public static readonly long[] Value={ 0L,2L,3L,9L,10L,12L,13L,15L,17L,18L,21L,29L,39L,44L,45L,47L,48L,50L,52L,53L,59L,60L,62L,63L,65L,67L,68L,71L,75L,77L,78L,84L,85L,87L,88L,90L,92L,93L,96L,101L,105L,107L,108L,111L,116L,129L,139L,144L,145L,147L,148L,174L,179L,189L,194L,195L,197L,198L,204L,214L,219L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039012Inst : IEnumerable<long>
{
public static readonly long[] Value=A039012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039012.Bytes);
public long this[int i]=>Value[i];

public static A039012Inst Instance=new A039012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039011
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,12L,14L,16L,20L,22L,24L,28L,38L,40L,42L,44L,48L,50L,52L,54L,58L,60L,62L,64L,66L,70L,72L,74L,76L,80L,82L,84L,86L,96L,100L,102L,104L,108L,110L,112L,114L,116L,120L,122L,124L,128L,138L,140L,142L,144L,148L,168L,178L,188L,190L,192L,194L,198L,200L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039011Inst : IEnumerable<long>
{
public static readonly long[] Value=A039011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039011.Bytes);
public long this[int i]=>Value[i];

public static A039011Inst Instance=new A039011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039010
{
public static readonly long[] Value={ 0L,3L,4L,7L,11L,15L,18L,19L,20L,23L,24L,27L,35L,38L,39L,42L,47L,51L,55L,58L,59L,66L,71L,75L,78L,79L,82L,86L,90L,93L,94L,95L,98L,99L,100L,103L,104L,107L,111L,115L,118L,119L,120L,123L,124L,127L,135L,138L,139L,142L,147L,162L,175L,178L,179L,182L,186L,190L,193L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039010Inst : IEnumerable<long>
{
public static readonly long[] Value=A039010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039010.Bytes);
public long this[int i]=>Value[i];

public static A039010Inst Instance=new A039010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039009
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,11L,12L,14L,15L,21L,22L,24L,28L,31L,32L,34L,36L,37L,39L,40L,46L,47L,49L,53L,56L,57L,59L,61L,62L,64L,65L,71L,72L,74L,76L,77L,79L,80L,85L,95L,103L,106L,107L,109L,111L,112L,114L,115L,121L,122L,124L,133L,138L,141L,142L,144L,148L,153L,156L,157L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039009Inst : IEnumerable<long>
{
public static readonly long[] Value=A039009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039009.Bytes);
public long this[int i]=>Value[i];

public static A039009Inst Instance=new A039009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039008
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,10L,16L,18L,19L,21L,23L,24L,27L,31L,33L,34L,35L,41L,43L,44L,46L,48L,49L,51L,53L,54L,55L,65L,70L,77L,81L,83L,84L,85L,91L,93L,94L,96L,98L,99L,102L,106L,108L,109L,110L,116L,118L,119L,121L,123L,124L,132L,136L,138L,139L,142L,147L,152L,156L,158L,159L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039008Inst : IEnumerable<long>
{
public static readonly long[] Value=A039008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039008.Bytes);
public long this[int i]=>Value[i];

public static A039008Inst Instance=new A039008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039007
{
public static readonly long[] Value={ 2L,3L,4L,5L,12L,13L,14L,17L,18L,19L,22L,23L,24L,27L,28L,29L,35L,40L,45L,51L,55L,62L,63L,64L,67L,68L,69L,72L,73L,74L,76L,80L,87L,88L,89L,92L,93L,94L,97L,98L,99L,101L,105L,112L,113L,114L,117L,118L,119L,122L,123L,124L,126L,130L,137L,138L,139L,142L,143L,144L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039007Inst : IEnumerable<long>
{
public static readonly long[] Value=A039007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039007.Bytes);
public long this[int i]=>Value[i];

public static A039007Inst Instance=new A039007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039006
{
public static readonly long[] Value={ 0L,1L,4L,5L,11L,14L,16L,17L,20L,21L,27L,30L,35L,39L,44L,45L,50L,54L,56L,57L,64L,65L,68L,69L,75L,78L,80L,81L,84L,85L,91L,94L,99L,103L,108L,109L,114L,118L,120L,121L,131L,135L,140L,141L,147L,151L,156L,157L,175L,176L,177L,180L,181L,187L,190L,194L,198L,200L,201L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039006Inst : IEnumerable<long>
{
public static readonly long[] Value=A039006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039006.Bytes);
public long this[int i]=>Value[i];

public static A039006Inst Instance=new A039006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039005
{
public static readonly long[] Value={ 0L,2L,7L,8L,10L,13L,19L,27L,28L,30L,32L,34L,39L,40L,42L,45L,49L,52L,54L,57L,67L,75L,76L,78L,95L,99L,107L,108L,110L,112L,114L,119L,120L,122L,125L,128L,130L,135L,136L,138L,141L,147L,155L,156L,158L,160L,162L,167L,168L,170L,173L,177L,180L,182L,185L,193L,196L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039005Inst : IEnumerable<long>
{
public static readonly long[] Value=A039005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039005.Bytes);
public long this[int i]=>Value[i];

public static A039005Inst Instance=new A039005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038988
{
public static readonly long[] Value={ 5L,7L,13L,17L,19L,23L,29L,37L,41L,59L,67L,71L,83L,107L,127L,131L,137L,139L,149L,157L,173L,179L,181L,199L,211L,223L,233L,239L,251L,257L,263L,271L,277L,281L,311L,317L,331L,337L,347L,349L,359L,367L,373L,383L,401L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038988Inst : IEnumerable<long>
{
public static readonly long[] Value=A038988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038988.Bytes);
public long this[int i]=>Value[i];

public static A038988Inst Instance=new A038988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038987
{
public static readonly long[] Value={ 2L,3L,11L,31L,43L,47L,53L,61L,73L,79L,89L,97L,101L,103L,109L,113L,151L,163L,167L,191L,193L,197L,227L,229L,241L,269L,283L,293L,307L,313L,353L,379L,389L,397L,419L,421L,431L,449L,461L,463L,467L,479L,487L,491L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038987Inst : IEnumerable<long>
{
public static readonly long[] Value=A038987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038987.Bytes);
public long this[int i]=>Value[i];

public static A038987Inst Instance=new A038987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038986
{
public static readonly long[] Value={ 3L,11L,17L,29L,41L,67L,73L,89L,103L,107L,109L,127L,131L,137L,139L,157L,167L,181L,191L,197L,199L,223L,227L,233L,239L,241L,251L,269L,271L,277L,281L,307L,311L,313L,353L,359L,383L,397L,401L,409L,419L,421L,449L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038986Inst : IEnumerable<long>
{
public static readonly long[] Value=A038986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038986.Bytes);
public long this[int i]=>Value[i];

public static A038986Inst Instance=new A038986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038985
{
public static readonly long[] Value={ 2L,5L,7L,13L,19L,23L,31L,37L,43L,47L,53L,59L,61L,71L,79L,83L,97L,101L,113L,149L,151L,163L,173L,179L,193L,211L,229L,257L,263L,283L,293L,317L,331L,337L,347L,349L,367L,373L,379L,389L,431L,433L,439L,443L,461L,463L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038985Inst : IEnumerable<long>
{
public static readonly long[] Value=A038985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038985.Bytes);
public long this[int i]=>Value[i];

public static A038985Inst Instance=new A038985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038984
{
public static readonly long[] Value={ 7L,11L,19L,37L,41L,43L,53L,61L,67L,71L,73L,79L,101L,103L,107L,113L,137L,139L,149L,157L,163L,173L,179L,191L,193L,197L,211L,227L,233L,239L,257L,263L,269L,271L,277L,281L,313L,383L,397L,409L,419L,431L,433L,439L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038984Inst : IEnumerable<long>
{
public static readonly long[] Value=A038984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038984.Bytes);
public long this[int i]=>Value[i];

public static A038984Inst Instance=new A038984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038983
{
public static readonly long[] Value={ 2L,3L,5L,13L,17L,23L,29L,31L,47L,59L,83L,89L,97L,109L,127L,131L,151L,167L,181L,199L,223L,229L,241L,251L,283L,293L,307L,311L,317L,331L,337L,347L,349L,353L,359L,367L,373L,379L,389L,401L,421L,457L,461L,463L,491L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038983Inst : IEnumerable<long>
{
public static readonly long[] Value=A038983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038983.Bytes);
public long this[int i]=>Value[i];

public static A038983Inst Instance=new A038983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038982
{
public static readonly long[] Value={ 2L,5L,13L,37L,41L,43L,47L,59L,61L,71L,73L,79L,101L,107L,113L,127L,131L,139L,149L,151L,173L,181L,191L,199L,223L,227L,229L,233L,241L,257L,271L,277L,281L,293L,311L,313L,317L,331L,337L,359L,367L,409L,419L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038982Inst : IEnumerable<long>
{
public static readonly long[] Value=A038982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038982.Bytes);
public long this[int i]=>Value[i];

public static A038982Inst Instance=new A038982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038981
{
public static readonly long[] Value={ 3L,7L,11L,17L,19L,23L,29L,31L,53L,67L,83L,89L,97L,103L,109L,137L,157L,163L,167L,179L,193L,197L,211L,239L,251L,263L,269L,283L,307L,347L,349L,353L,373L,379L,383L,389L,397L,401L,421L,439L,449L,461L,491L,509L,541L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038981Inst : IEnumerable<long>
{
public static readonly long[] Value=A038981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038981.Bytes);
public long this[int i]=>Value[i];

public static A038981Inst Instance=new A038981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038980
{
public static readonly long[] Value={ 2L,17L,19L,23L,31L,37L,43L,47L,59L,61L,79L,83L,101L,107L,109L,127L,137L,149L,157L,167L,173L,179L,181L,191L,193L,197L,211L,223L,227L,257L,263L,269L,271L,281L,307L,313L,317L,347L,383L,401L,421L,433L,443L,449L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038980Inst : IEnumerable<long>
{
public static readonly long[] Value=A038980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038980.Bytes);
public long this[int i]=>Value[i];

public static A038980Inst Instance=new A038980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038979
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,29L,41L,53L,67L,71L,73L,89L,97L,103L,113L,131L,139L,151L,163L,199L,229L,233L,239L,241L,251L,277L,283L,293L,311L,331L,337L,349L,353L,359L,367L,373L,379L,389L,397L,409L,419L,431L,439L,461L,463L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038979Inst : IEnumerable<long>
{
public static readonly long[] Value=A038979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038979.Bytes);
public long this[int i]=>Value[i];

public static A038979Inst Instance=new A038979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038978
{
public static readonly long[] Value={ 3L,7L,13L,19L,23L,29L,31L,37L,41L,43L,59L,61L,83L,101L,103L,113L,127L,137L,149L,151L,163L,181L,191L,193L,197L,211L,229L,239L,241L,281L,293L,313L,337L,349L,353L,359L,379L,383L,389L,397L,419L,421L,431L,433L,439L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038978Inst : IEnumerable<long>
{
public static readonly long[] Value=A038978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038978.Bytes);
public long this[int i]=>Value[i];

public static A038978Inst Instance=new A038978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038977
{
public static readonly long[] Value={ 2L,5L,11L,17L,47L,53L,67L,71L,73L,79L,89L,97L,107L,109L,131L,139L,157L,167L,173L,179L,199L,223L,227L,233L,251L,257L,263L,269L,271L,277L,283L,307L,311L,317L,331L,347L,367L,373L,401L,409L,443L,449L,461L,463L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038977Inst : IEnumerable<long>
{
public static readonly long[] Value=A038977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038977.Bytes);
public long this[int i]=>Value[i];

public static A038977Inst Instance=new A038977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038976
{
public static readonly long[] Value={ 5L,7L,11L,37L,47L,53L,61L,67L,73L,97L,103L,131L,139L,149L,151L,157L,173L,191L,193L,197L,199L,223L,229L,233L,251L,257L,263L,281L,283L,311L,337L,353L,359L,401L,409L,421L,433L,439L,443L,463L,467L,479L,487L,491L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038976Inst : IEnumerable<long>
{
public static readonly long[] Value=A038976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038976.Bytes);
public long this[int i]=>Value[i];

public static A038976Inst Instance=new A038976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038975
{
public static readonly long[] Value={ 2L,3L,13L,17L,19L,23L,29L,31L,41L,43L,59L,71L,79L,83L,89L,101L,107L,109L,113L,127L,137L,163L,167L,179L,181L,211L,227L,239L,241L,269L,271L,277L,293L,307L,313L,317L,331L,347L,349L,367L,373L,379L,383L,389L,397L,419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038975Inst : IEnumerable<long>
{
public static readonly long[] Value=A038975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038975.Bytes);
public long this[int i]=>Value[i];

public static A038975Inst Instance=new A038975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038974
{
public static readonly long[] Value={ 3L,13L,19L,23L,31L,47L,53L,73L,79L,89L,101L,103L,109L,113L,127L,131L,137L,163L,167L,173L,179L,181L,197L,211L,227L,229L,233L,239L,241L,257L,269L,271L,293L,311L,313L,317L,331L,347L,359L,367L,397L,409L,419L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038974Inst : IEnumerable<long>
{
public static readonly long[] Value=A038974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038974.Bytes);
public long this[int i]=>Value[i];

public static A038974Inst Instance=new A038974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038973
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,29L,37L,41L,43L,59L,61L,67L,71L,83L,97L,107L,139L,149L,151L,157L,191L,193L,199L,223L,251L,263L,277L,281L,283L,307L,337L,349L,353L,373L,379L,383L,389L,401L,421L,443L,463L,503L,547L,563L,569L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038973Inst : IEnumerable<long>
{
public static readonly long[] Value=A038973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038973.Bytes);
public long this[int i]=>Value[i];

public static A038973Inst Instance=new A038973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038956
{
public static readonly long[] Value={ 3L,13L,17L,19L,41L,43L,53L,61L,79L,83L,97L,103L,107L,113L,131L,137L,149L,151L,167L,173L,179L,181L,191L,193L,197L,199L,223L,241L,251L,257L,263L,269L,271L,281L,311L,317L,337L,349L,353L,359L,367L,379L,389L,397L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038956Inst : IEnumerable<long>
{
public static readonly long[] Value=A038956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038956.Bytes);
public long this[int i]=>Value[i];

public static A038956Inst Instance=new A038956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038955
{
public static readonly long[] Value={ 2L,5L,7L,11L,23L,29L,31L,37L,47L,59L,67L,71L,73L,89L,101L,109L,127L,139L,157L,163L,211L,227L,229L,233L,239L,277L,283L,293L,307L,313L,331L,347L,373L,383L,409L,439L,443L,467L,479L,487L,491L,509L,521L,523L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038955Inst : IEnumerable<long>
{
public static readonly long[] Value=A038955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038955.Bytes);
public long this[int i]=>Value[i];

public static A038955Inst Instance=new A038955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038954
{
public static readonly long[] Value={ 13L,19L,29L,41L,43L,47L,59L,67L,71L,79L,89L,103L,107L,109L,113L,131L,137L,139L,149L,151L,157L,163L,167L,173L,191L,193L,223L,233L,239L,241L,251L,293L,337L,347L,359L,367L,383L,389L,397L,409L,419L,421L,431L,443L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038954Inst : IEnumerable<long>
{
public static readonly long[] Value=A038954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038954.Bytes);
public long this[int i]=>Value[i];

public static A038954Inst Instance=new A038954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038953
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,23L,31L,37L,53L,61L,73L,83L,97L,101L,127L,179L,181L,197L,199L,211L,227L,229L,257L,263L,269L,271L,277L,281L,283L,307L,311L,313L,317L,331L,349L,353L,373L,379L,401L,433L,439L,449L,461L,463L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038953Inst : IEnumerable<long>
{
public static readonly long[] Value=A038953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038953.Bytes);
public long this[int i]=>Value[i];

public static A038953Inst Instance=new A038953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038952
{
public static readonly long[] Value={ 2L,7L,19L,29L,37L,41L,43L,47L,59L,61L,67L,71L,79L,97L,101L,103L,109L,131L,157L,167L,173L,179L,181L,197L,199L,229L,233L,239L,241L,257L,269L,283L,311L,313L,317L,337L,347L,353L,367L,373L,379L,421L,433L,443L,449L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038952Inst : IEnumerable<long>
{
public static readonly long[] Value=A038952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038952.Bytes);
public long this[int i]=>Value[i];

public static A038952Inst Instance=new A038952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038951
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,23L,31L,53L,73L,83L,89L,107L,113L,127L,137L,139L,149L,151L,163L,191L,193L,211L,223L,227L,251L,263L,271L,277L,281L,293L,307L,331L,349L,359L,383L,389L,397L,401L,409L,419L,431L,439L,463L,467L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038951Inst : IEnumerable<long>
{
public static readonly long[] Value=A038951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038951.Bytes);
public long this[int i]=>Value[i];

public static A038951Inst Instance=new A038951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038950
{
public static readonly long[] Value={ 2L,5L,13L,19L,23L,41L,47L,53L,59L,61L,71L,83L,97L,101L,103L,107L,109L,113L,127L,131L,137L,151L,163L,167L,197L,199L,211L,223L,227L,229L,233L,263L,281L,283L,307L,313L,337L,353L,359L,373L,401L,409L,419L,431L,433L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038950Inst : IEnumerable<long>
{
public static readonly long[] Value=A038950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038950.Bytes);
public long this[int i]=>Value[i];

public static A038950Inst Instance=new A038950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038949
{
public static readonly long[] Value={ 3L,7L,11L,17L,29L,31L,37L,43L,67L,73L,79L,89L,139L,149L,157L,173L,179L,181L,191L,193L,239L,241L,251L,257L,269L,271L,277L,293L,311L,317L,331L,347L,349L,367L,379L,383L,389L,397L,421L,443L,449L,457L,461L,463L,487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038949Inst : IEnumerable<long>
{
public static readonly long[] Value=A038949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038949.Bytes);
public long this[int i]=>Value[i];

public static A038949Inst Instance=new A038949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038948
{
public static readonly long[] Value={ 7L,23L,29L,37L,47L,67L,71L,73L,79L,83L,89L,101L,107L,113L,127L,131L,137L,149L,151L,157L,163L,173L,181L,191L,193L,197L,227L,229L,241L,257L,271L,293L,311L,331L,337L,347L,353L,379L,383L,397L,401L,409L,421L,439L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038948Inst : IEnumerable<long>
{
public static readonly long[] Value=A038948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038948.Bytes);
public long this[int i]=>Value[i];

public static A038948Inst Instance=new A038948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038947
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,19L,31L,41L,43L,53L,59L,61L,97L,103L,109L,139L,167L,179L,199L,211L,223L,233L,239L,251L,263L,269L,277L,281L,283L,307L,313L,317L,349L,359L,367L,373L,389L,419L,431L,433L,443L,463L,467L,479L,487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038947Inst : IEnumerable<long>
{
public static readonly long[] Value=A038947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038947.Bytes);
public long this[int i]=>Value[i];

public static A038947Inst Instance=new A038947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038946
{
public static readonly long[] Value={ 3L,11L,17L,19L,23L,31L,41L,43L,53L,59L,71L,89L,103L,107L,109L,113L,127L,149L,151L,157L,173L,229L,233L,239L,241L,257L,263L,271L,277L,281L,283L,313L,331L,337L,347L,349L,359L,367L,373L,379L,401L,409L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038946Inst : IEnumerable<long>
{
public static readonly long[] Value=A038946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038946.Bytes);
public long this[int i]=>Value[i];

public static A038946Inst Instance=new A038946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038945
{
public static readonly long[] Value={ 2L,5L,7L,13L,29L,37L,47L,61L,67L,73L,79L,83L,97L,101L,131L,137L,139L,163L,167L,179L,181L,191L,193L,197L,199L,211L,223L,227L,251L,269L,293L,307L,311L,317L,353L,383L,389L,397L,419L,439L,457L,463L,487L,491L,521L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038945Inst : IEnumerable<long>
{
public static readonly long[] Value=A038945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038945.Bytes);
public long this[int i]=>Value[i];

public static A038945Inst Instance=new A038945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038944
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,43L,47L,71L,73L,83L,89L,101L,103L,109L,137L,139L,149L,157L,173L,179L,191L,241L,251L,293L,311L,313L,317L,331L,337L,347L,349L,353L,359L,373L,397L,401L,409L,421L,431L,433L,439L,449L,457L,479L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038944Inst : IEnumerable<long>
{
public static readonly long[] Value=A038944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038944.Bytes);
public long this[int i]=>Value[i];

public static A038944Inst Instance=new A038944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038943
{
public static readonly long[] Value={ 2L,13L,19L,23L,29L,31L,37L,41L,53L,59L,61L,67L,79L,97L,107L,113L,127L,131L,151L,163L,167L,181L,193L,197L,199L,211L,223L,227L,229L,233L,239L,257L,263L,269L,271L,277L,281L,283L,307L,367L,379L,383L,389L,419L,443L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038943Inst : IEnumerable<long>
{
public static readonly long[] Value=A038943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038943.Bytes);
public long this[int i]=>Value[i];

public static A038943Inst Instance=new A038943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038942
{
public static readonly long[] Value={ 2L,7L,11L,17L,23L,29L,31L,37L,43L,53L,59L,67L,71L,79L,89L,101L,139L,151L,157L,173L,181L,191L,193L,211L,223L,227L,233L,251L,277L,281L,307L,311L,313L,331L,337L,349L,359L,373L,383L,389L,397L,401L,409L,419L,421L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038942Inst : IEnumerable<long>
{
public static readonly long[] Value=A038942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038942.Bytes);
public long this[int i]=>Value[i];

public static A038942Inst Instance=new A038942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038941
{
public static readonly long[] Value={ 3L,5L,13L,19L,41L,47L,61L,73L,83L,97L,103L,107L,109L,113L,127L,131L,137L,149L,163L,167L,179L,197L,199L,229L,239L,241L,257L,263L,269L,271L,283L,293L,317L,347L,353L,367L,379L,431L,439L,443L,449L,461L,463L,479L,487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038941Inst : IEnumerable<long>
{
public static readonly long[] Value=A038941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038941.Bytes);
public long this[int i]=>Value[i];

public static A038941Inst Instance=new A038941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038924
{
public static readonly long[] Value={ 2L,5L,11L,23L,29L,31L,37L,47L,59L,61L,67L,73L,79L,83L,89L,103L,107L,113L,127L,137L,139L,149L,157L,167L,233L,239L,241L,251L,257L,271L,277L,283L,307L,311L,313L,349L,359L,367L,373L,379L,389L,409L,421L,431L,433L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038924Inst : IEnumerable<long>
{
public static readonly long[] Value=A038924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038924.Bytes);
public long this[int i]=>Value[i];

public static A038924Inst Instance=new A038924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038923
{
public static readonly long[] Value={ 3L,7L,13L,17L,19L,41L,43L,53L,71L,97L,101L,109L,131L,151L,163L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,263L,269L,281L,293L,317L,331L,337L,347L,353L,383L,397L,401L,419L,461L,463L,467L,491L,499L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038923Inst : IEnumerable<long>
{
public static readonly long[] Value=A038923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038923.Bytes);
public long this[int i]=>Value[i];

public static A038923Inst Instance=new A038923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038922
{
public static readonly long[] Value={ 5L,23L,31L,37L,43L,59L,67L,71L,73L,83L,97L,101L,103L,109L,113L,131L,137L,163L,173L,191L,199L,211L,223L,227L,233L,239L,241L,251L,263L,269L,271L,277L,281L,293L,313L,331L,359L,367L,373L,379L,401L,409L,419L,421L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038922Inst : IEnumerable<long>
{
public static readonly long[] Value=A038922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038922.Bytes);
public long this[int i]=>Value[i];

public static A038922Inst Instance=new A038922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038921
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,19L,29L,41L,47L,53L,61L,79L,89L,107L,127L,139L,149L,151L,157L,167L,179L,181L,193L,197L,229L,257L,283L,307L,311L,317L,337L,347L,349L,353L,383L,389L,397L,443L,457L,463L,479L,487L,491L,503L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038921Inst : IEnumerable<long>
{
public static readonly long[] Value=A038921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038921.Bytes);
public long this[int i]=>Value[i];

public static A038921Inst Instance=new A038921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038920
{
public static readonly long[] Value={ 3L,7L,11L,13L,17L,19L,29L,47L,53L,67L,71L,79L,89L,97L,101L,109L,137L,149L,151L,157L,167L,179L,181L,191L,193L,199L,211L,227L,229L,233L,239L,257L,263L,281L,293L,311L,313L,317L,331L,347L,383L,397L,421L,439L,457L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038920Inst : IEnumerable<long>
{
public static readonly long[] Value=A038920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038920.Bytes);
public long this[int i]=>Value[i];

public static A038920Inst Instance=new A038920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038919
{
public static readonly long[] Value={ 2L,5L,23L,31L,37L,41L,43L,59L,61L,73L,83L,103L,107L,113L,127L,131L,139L,163L,173L,197L,223L,241L,251L,269L,271L,277L,283L,307L,337L,349L,353L,359L,367L,373L,379L,389L,401L,409L,419L,431L,433L,443L,449L,461L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038919Inst : IEnumerable<long>
{
public static readonly long[] Value=A038919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038919.Bytes);
public long this[int i]=>Value[i];

public static A038919Inst Instance=new A038919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038918
{
public static readonly long[] Value={ 11L,17L,29L,37L,43L,47L,53L,59L,71L,73L,79L,83L,97L,101L,103L,109L,113L,127L,139L,167L,173L,193L,199L,211L,227L,229L,233L,239L,241L,257L,269L,283L,349L,359L,367L,383L,389L,397L,409L,421L,431L,439L,457L,479L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038918Inst : IEnumerable<long>
{
public static readonly long[] Value=A038918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038918.Bytes);
public long this[int i]=>Value[i];

public static A038918Inst Instance=new A038918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038917
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,23L,31L,41L,61L,67L,89L,107L,131L,137L,149L,151L,157L,163L,179L,181L,191L,197L,223L,251L,263L,271L,277L,281L,293L,307L,311L,313L,317L,331L,337L,347L,353L,373L,379L,401L,419L,433L,443L,449L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038917Inst : IEnumerable<long>
{
public static readonly long[] Value=A038917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038917.Bytes);
public long this[int i]=>Value[i];

public static A038917Inst Instance=new A038917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038916
{
public static readonly long[] Value={ 3L,5L,7L,23L,41L,47L,59L,61L,67L,89L,97L,101L,107L,113L,149L,157L,179L,191L,193L,197L,199L,211L,227L,229L,239L,241L,257L,263L,271L,277L,281L,307L,311L,331L,337L,349L,359L,367L,379L,389L,397L,401L,409L,433L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038916Inst : IEnumerable<long>
{
public static readonly long[] Value=A038916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038916.Bytes);
public long this[int i]=>Value[i];

public static A038916Inst Instance=new A038916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038915
{
public static readonly long[] Value={ 2L,11L,13L,17L,19L,29L,31L,37L,43L,53L,71L,73L,79L,83L,103L,109L,127L,131L,137L,139L,151L,163L,167L,173L,181L,223L,233L,251L,269L,283L,293L,313L,317L,347L,353L,373L,383L,419L,421L,431L,439L,443L,457L,467L,487L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038915Inst : IEnumerable<long>
{
public static readonly long[] Value=A038915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038915.Bytes);
public long this[int i]=>Value[i];

public static A038915Inst Instance=new A038915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038914
{
public static readonly long[] Value={ 2L,5L,13L,17L,19L,23L,29L,31L,43L,59L,61L,79L,89L,97L,103L,109L,113L,131L,163L,167L,179L,191L,193L,199L,227L,239L,241L,251L,257L,277L,281L,283L,311L,313L,331L,347L,353L,383L,389L,401L,409L,421L,431L,439L,449L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038914Inst : IEnumerable<long>
{
public static readonly long[] Value=A038914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038914.Bytes);
public long this[int i]=>Value[i];

public static A038914Inst Instance=new A038914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038913
{
public static readonly long[] Value={ 3L,7L,11L,37L,41L,47L,53L,67L,71L,73L,83L,101L,107L,127L,137L,139L,149L,151L,157L,173L,181L,197L,211L,223L,229L,233L,263L,269L,271L,293L,307L,317L,337L,349L,359L,367L,373L,379L,397L,419L,433L,443L,491L,509L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038913Inst : IEnumerable<long>
{
public static readonly long[] Value=A038913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038913.Bytes);
public long this[int i]=>Value[i];

public static A038913Inst Instance=new A038913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038912
{
public static readonly long[] Value={ 2L,3L,11L,37L,41L,47L,53L,61L,71L,79L,83L,89L,101L,103L,113L,137L,151L,167L,179L,181L,191L,193L,197L,211L,223L,227L,229L,233L,239L,241L,269L,277L,283L,307L,317L,331L,337L,349L,359L,367L,373L,379L,383L,409L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038912Inst : IEnumerable<long>
{
public static readonly long[] Value=A038912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038912.Bytes);
public long this[int i]=>Value[i];

public static A038912Inst Instance=new A038912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038911
{
public static readonly long[] Value={ 5L,7L,13L,17L,19L,23L,29L,31L,43L,59L,67L,73L,97L,107L,109L,127L,131L,139L,149L,157L,163L,173L,199L,251L,257L,263L,271L,281L,293L,311L,313L,347L,353L,389L,397L,401L,419L,421L,433L,439L,443L,449L,463L,479L,487L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038911Inst : IEnumerable<long>
{
public static readonly long[] Value=A038911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038911.Bytes);
public long this[int i]=>Value[i];

public static A038911Inst Instance=new A038911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038910
{
public static readonly long[] Value={ 7L,13L,19L,23L,31L,41L,43L,53L,59L,67L,71L,73L,79L,83L,97L,101L,113L,149L,157L,167L,179L,193L,199L,229L,233L,241L,251L,293L,307L,311L,313L,331L,337L,349L,367L,373L,389L,401L,421L,431L,439L,443L,449L,461L,467L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038910Inst : IEnumerable<long>
{
public static readonly long[] Value=A038910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038910.Bytes);
public long this[int i]=>Value[i];

public static A038910Inst Instance=new A038910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038909
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,29L,37L,47L,61L,89L,103L,107L,109L,127L,131L,137L,139L,151L,163L,173L,181L,191L,197L,211L,223L,227L,239L,257L,263L,269L,271L,277L,281L,283L,317L,347L,353L,359L,379L,383L,397L,409L,419L,433L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038909Inst : IEnumerable<long>
{
public static readonly long[] Value=A038909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038909.Bytes);
public long this[int i]=>Value[i];

public static A038909Inst Instance=new A038909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038908
{
public static readonly long[] Value={ 5L,7L,13L,19L,23L,43L,47L,53L,59L,61L,71L,73L,79L,89L,109L,113L,127L,137L,139L,151L,179L,191L,193L,211L,241L,251L,257L,269L,271L,277L,283L,307L,311L,317L,337L,349L,353L,373L,383L,389L,401L,409L,419L,439L,443L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038908Inst : IEnumerable<long>
{
public static readonly long[] Value=A038908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038908.Bytes);
public long this[int i]=>Value[i];

public static A038908Inst Instance=new A038908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038907
{
public static readonly long[] Value={ 2L,3L,11L,17L,29L,31L,37L,41L,67L,83L,97L,101L,103L,107L,131L,149L,157L,163L,167L,173L,181L,197L,199L,223L,227L,229L,233L,239L,263L,281L,293L,313L,331L,347L,359L,367L,379L,397L,421L,431L,433L,461L,463L,479L,487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038907Inst : IEnumerable<long>
{
public static readonly long[] Value=A038907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038907.Bytes);
public long this[int i]=>Value[i];

public static A038907Inst Instance=new A038907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038906
{
public static readonly long[] Value={ 7L,13L,17L,19L,29L,37L,47L,53L,59L,61L,67L,71L,73L,89L,103L,107L,131L,137L,163L,181L,191L,197L,211L,227L,229L,241L,269L,277L,283L,307L,311L,313L,337L,353L,359L,379L,389L,401L,409L,419L,431L,433L,439L,443L,449L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038906Inst : IEnumerable<long>
{
public static readonly long[] Value=A038906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038906.Bytes);
public long this[int i]=>Value[i];

public static A038906Inst Instance=new A038906Inst();

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