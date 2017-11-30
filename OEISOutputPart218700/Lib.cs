using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A269362
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,5L,6L,6L,6L,7L,7L,8L,9L,9L,10L,10L,11L,12L,13L,14L,15L,16L,17L,18L,18L,19L,20L,21L,21L,21L,22L,22L,22L,23L,24L,25L,26L,27L,27L,27L,28L,29L,30L,30L,31L,32L,32L,32L,32L,33L,33L,34L,35L,36L,37L,38L,39L,40L,41L,41L,42L,43L,44L,44L,45L,45L,45L,46L,46L,47L,48L,49L,50L,51L,52L,53L,53L,54L,54L,55L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269362Inst : IEnumerable<long>
{
public static readonly long[] Value=A269362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269362.Bytes);
public long this[int i]=>Value[i];

public static A269362Inst Instance=new A269362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269363
{
public static readonly long[] Value={ 3L,6L,7L,12L,11L,15L,22L,24L,14L,19L,27L,38L,28L,23L,46L,48L,43L,30L,39L,35L,59L,44L,31L,75L,62L,87L,51L,83L,56L,47L,88L,54L,76L,55L,96L,86L,60L,71L,67L,70L,78L,112L,79L,107L,102L,91L,120L,139L,118L,140L,119L,142L,131L,134L,155L,240L,156L,135L,152L,108L,95L,92L,103L,179L,184L,115L,147L,224L,94L,175L,123L,150L,111L,158L,214L,163L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269363Inst : IEnumerable<long>
{
public static readonly long[] Value=A269363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269363.Bytes);
public long this[int i]=>Value[i];

public static A269363Inst Instance=new A269363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269364
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,7L,8L,7L,8L,9L,10L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,11L,12L,13L,14L,15L,16L,17L,16L,17L,18L,19L,18L,17L,18L,17L,16L,17L,18L,19L,20L,21L,20L,19L,20L,21L,22L,21L,22L,23L,22L,21L,20L,21L,20L,21L,22L,23L,24L,25L,26L,27L,28L,27L,28L,29L,30L,29L,30L,29L,28L,29L,28L,29L,30L,31L,32L,33L,34L,35L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269364Inst : IEnumerable<long>
{
public static readonly long[] Value=A269364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269364.Bytes);
public long this[int i]=>Value[i];

public static A269364Inst Instance=new A269364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269365
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,8L,12L,14L,13L,9L,16L,25L,11L,10L,28L,18L,29L,24L,36L,15L,51L,17L,30L,56L,27L,33L,32L,37L,103L,26L,22L,74L,49L,50L,52L,19L,59L,20L,102L,48L,57L,31L,54L,23L,75L,21L,58L,34L,55L,72L,66L,53L,149L,65L,112L,118L,73L,105L,104L,61L,597L,206L,204L,108L,119L,96L,114L,41L,39L,38L,40L,148L,35L,45L,116L,205L,115L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269365Inst : IEnumerable<long>
{
public static readonly long[] Value=A269365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269365.Bytes);
public long this[int i]=>Value[i];

public static A269365Inst Instance=new A269365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269366
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,8L,12L,16L,15L,9L,11L,10L,22L,13L,24L,18L,38L,40L,48L,33L,46L,20L,14L,32L,27L,17L,19L,25L,44L,29L,28L,50L,75L,21L,30L,72L,71L,73L,70L,133L,139L,113L,76L,129L,91L,42L,35L,36L,23L,37L,54L,45L,51L,26L,43L,49L,39L,82L,62L,128L,107L,80L,56L,53L,83L,114L,140L,109L,214L,52L,59L,34L,47L,149L,150L,141L,123L,221L,111L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269366Inst : IEnumerable<long>
{
public static readonly long[] Value=A269366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269366.Bytes);
public long this[int i]=>Value[i];

public static A269366Inst Instance=new A269366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269367
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,11L,6L,8L,12L,17L,13L,10L,21L,23L,19L,14L,18L,16L,28L,20L,15L,35L,30L,41L,24L,39L,27L,22L,42L,25L,36L,26L,47L,40L,29L,34L,32L,33L,37L,55L,38L,51L,49L,43L,59L,67L,57L,68L,58L,69L,64L,65L,75L,119L,76L,66L,74L,52L,46L,44L,50L,87L,90L,56L,71L,111L,45L,85L,60L,72L,54L,77L,104L,79L,99L,88L,95L,48L,53L,78L,102L,82L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269367Inst : IEnumerable<long>
{
public static readonly long[] Value=A269367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269367.Bytes);
public long this[int i]=>Value[i];

public static A269367Inst Instance=new A269367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269368
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,9L,6L,10L,7L,14L,8L,11L,13L,18L,23L,20L,12L,19L,17L,22L,15L,30L,16L,27L,32L,34L,29L,21L,37L,25L,85L,39L,40L,38L,24L,33L,41L,43L,28L,36L,26L,31L,46L,62L,69L,61L,35L,80L,45L,63L,44L,60L,81L,73L,42L,66L,49L,51L,47L,71L,87L,93L,129L,53L,54L,58L,48L,50L,52L,88L,67L,72L,86L,59L,55L,57L,74L,82L,76L,104L,106L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269368Inst : IEnumerable<long>
{
public static readonly long[] Value=A269368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269368.Bytes);
public long this[int i]=>Value[i];

public static A269368Inst Instance=new A269368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269369
{
public static readonly long[] Value={ 1L,3L,7L,5L,19L,11L,9L,17L,13L,23L,39L,29L,15L,35L,21L,41L,61L,47L,27L,53L,25L,59L,81L,65L,31L,71L,45L,77L,103L,83L,33L,89L,37L,95L,123L,101L,43L,107L,57L,113L,145L,119L,49L,125L,55L,131L,165L,137L,51L,143L,63L,149L,187L,155L,85L,161L,97L,167L,207L,173L,91L,179L,67L,185L,229L,191L,69L,197L,73L,203L,249L,209L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269369Inst : IEnumerable<long>
{
public static readonly long[] Value=A269369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269369.Bytes);
public long this[int i]=>Value[i];

public static A269369Inst Instance=new A269369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269370
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,3L,1L,7L,4L,6L,2L,9L,3L,13L,1L,8L,7L,5L,4L,15L,6L,10L,2L,21L,9L,19L,3L,12L,13L,25L,1L,31L,8L,14L,7L,33L,5L,11L,4L,16L,15L,37L,6L,27L,10L,18L,2L,43L,21L,49L,9L,20L,19L,45L,3L,39L,12L,22L,13L,17L,25L,51L,1L,24L,31L,63L,8L,67L,14L,26L,7L,69L,33L,73L,5L,28L,11L,75L,4L,23L,16L,30L,15L,55L,37L,79L,6L,32L,27L,61L,10L,87L,18L,34L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269370Inst : IEnumerable<long>
{
public static readonly long[] Value=A269370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269370.Bytes);
public long this[int i]=>Value[i];

public static A269370Inst Instance=new A269370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269371
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,4L,5L,5L,5L,6L,6L,6L,6L,7L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,11L,11L,11L,11L,11L,12L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,27L,27L,27L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269371Inst : IEnumerable<long>
{
public static readonly long[] Value=A269371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269371.Bytes);
public long this[int i]=>Value[i];

public static A269371Inst Instance=new A269371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269372
{
public static readonly long[] Value={ 0L,2L,6L,4L,18L,10L,8L,16L,12L,22L,38L,28L,14L,34L,20L,40L,60L,46L,26L,52L,24L,58L,80L,64L,30L,70L,44L,76L,102L,82L,32L,88L,36L,94L,122L,100L,42L,106L,56L,112L,144L,118L,48L,124L,54L,130L,164L,136L,50L,142L,62L,148L,186L,154L,84L,160L,96L,166L,206L,172L,90L,178L,66L,184L,228L,190L,68L,196L,72L,202L,248L,208L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269372Inst : IEnumerable<long>
{
public static readonly long[] Value=A269372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269372.Bytes);
public long this[int i]=>Value[i];

public static A269372Inst Instance=new A269372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269373
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,4L,11L,8L,9L,10L,7L,16L,21L,32L,15L,22L,17L,12L,19L,64L,13L,18L,31L,128L,41L,24L,63L,14L,29L,256L,43L,512L,33L,42L,23L,1024L,37L,20L,127L,30L,25L,2048L,35L,48L,61L,34L,255L,4096L,81L,8192L,47L,38L,125L,96L,27L,40L,57L,26L,511L,44L,85L,16384L,1023L,62L,65L,32768L,83L,65536L,45L,82L,2047L,131072L,73L,262144L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269373Inst : IEnumerable<long>
{
public static readonly long[] Value=A269373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269373.Bytes);
public long this[int i]=>Value[i];

public static A269373Inst Instance=new A269373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269374
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,4L,11L,8L,9L,10L,7L,18L,21L,28L,15L,12L,17L,22L,19L,38L,13L,16L,35L,26L,41L,58L,55L,102L,29L,40L,23L,14L,33L,46L,43L,80L,37L,52L,75L,56L,25L,34L,31L,60L,69L,100L,51L,44L,81L,118L,115L,206L,109L,160L,203L,152L,57L,82L,79L,144L,45L,64L,27L,20L,65L,94L,91L,164L,85L,124L,159L,120L,73L,106L,103L,186L,149L,220L,111L,96L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269374Inst : IEnumerable<long>
{
public static readonly long[] Value=A269374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269374.Bytes);
public long this[int i]=>Value[i];

public static A269374Inst Instance=new A269374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269375
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,5L,6L,7L,16L,17L,10L,19L,12L,11L,14L,9L,32L,41L,34L,61L,20L,23L,38L,27L,24L,29L,22L,39L,28L,35L,18L,13L,64L,89L,82L,145L,68L,95L,122L,91L,40L,53L,46L,81L,76L,107L,54L,45L,48L,65L,58L,103L,44L,59L,78L,57L,56L,77L,70L,123L,36L,47L,26L,15L,128L,185L,178L,313L,164L,239L,290L,217L,136L,197L,190L,333L,244L,359L,182L,147L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269375Inst : IEnumerable<long>
{
public static readonly long[] Value=A269375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269375.Bytes);
public long this[int i]=>Value[i];

public static A269375Inst Instance=new A269375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269376
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,6L,7L,4L,15L,10L,13L,12L,31L,14L,63L,8L,9L,30L,11L,20L,127L,26L,21L,24L,255L,62L,23L,28L,25L,126L,511L,16L,1023L,18L,29L,60L,2047L,22L,27L,40L,17L,254L,4095L,52L,47L,42L,61L,48L,8191L,510L,16383L,124L,41L,46L,95L,56L,55L,50L,53L,252L,19L,1022L,32767L,32L,49L,2046L,65535L,36L,131071L,58L,125L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269376Inst : IEnumerable<long>
{
public static readonly long[] Value=A269376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269376.Bytes);
public long this[int i]=>Value[i];

public static A269376Inst Instance=new A269376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269377
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,5L,8L,9L,14L,11L,12L,19L,10L,17L,16L,13L,18L,35L,28L,39L,22L,29L,24L,27L,38L,23L,20L,61L,34L,41L,32L,15L,26L,47L,36L,123L,70L,77L,56L,57L,78L,59L,44L,103L,58L,65L,48L,45L,54L,107L,76L,81L,46L,53L,40L,91L,122L,95L,68L,145L,82L,89L,64L,21L,30L,71L,52L,165L,94L,101L,72L,183L,246L,203L,140L,271L,154L,161L,112L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269377Inst : IEnumerable<long>
{
public static readonly long[] Value=A269377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269377.Bytes);
public long this[int i]=>Value[i];

public static A269377Inst Instance=new A269377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269378
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,8L,13L,10L,11L,16L,9L,32L,15L,14L,17L,12L,27L,64L,21L,26L,23L,128L,33L,24L,19L,22L,65L,256L,31L,512L,29L,18L,35L,1024L,25L,20L,55L,30L,129L,2048L,43L,48L,53L,34L,47L,4096L,257L,8192L,67L,54L,49L,96L,39L,40L,45L,42L,131L,28L,513L,16384L,63L,46L,1025L,32768L,59L,65536L,37L,66L,71L,131072L,2049L,262144L,51L,38L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269378Inst : IEnumerable<long>
{
public static readonly long[] Value=A269378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269378.Bytes);
public long this[int i]=>Value[i];

public static A269378Inst Instance=new A269378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269379
{
public static readonly long[] Value={ 1L,3L,5L,9L,7L,15L,11L,21L,19L,27L,13L,33L,17L,39L,35L,45L,23L,51L,31L,57L,49L,63L,25L,69L,29L,75L,65L,81L,37L,87L,55L,93L,79L,99L,59L,105L,41L,111L,95L,117L,43L,123L,47L,129L,109L,135L,53L,141L,85L,147L,125L,153L,61L,159L,73L,165L,139L,171L,103L,177L,67L,183L,155L,189L,113L,195L,71L,201L,169L,207L,77L,213L,101L,219L,185L,225L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269379Inst : IEnumerable<long>
{
public static readonly long[] Value=A269379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269379.Bytes);
public long this[int i]=>Value[i];

public static A269379Inst Instance=new A269379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269380
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,5L,1L,4L,3L,7L,2L,11L,5L,6L,1L,13L,4L,9L,3L,8L,7L,17L,2L,23L,11L,10L,5L,25L,6L,19L,1L,12L,13L,15L,4L,29L,9L,14L,3L,37L,8L,41L,7L,16L,17L,43L,2L,21L,23L,18L,11L,47L,10L,31L,5L,20L,25L,35L,6L,53L,19L,22L,1L,27L,12L,61L,13L,24L,15L,67L,4L,55L,29L,26L,9L,71L,14L,33L,3L,28L,37L,77L,8L,49L,41L,30L,7L,83L,16L,89L,17L,32L,43L,39L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269380Inst : IEnumerable<long>
{
public static readonly long[] Value=A269380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269380.Bytes);
public long this[int i]=>Value[i];

public static A269380Inst Instance=new A269380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269381
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,4L,5L,5L,5L,5L,6L,6L,6L,7L,8L,8L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,22L,22L,22L,22L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269381Inst : IEnumerable<long>
{
public static readonly long[] Value=A269381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269381.Bytes);
public long this[int i]=>Value[i];

public static A269381Inst Instance=new A269381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269382
{
public static readonly long[] Value={ 0L,2L,4L,8L,6L,14L,10L,20L,18L,26L,12L,32L,16L,38L,34L,44L,22L,50L,30L,56L,48L,62L,24L,68L,28L,74L,64L,80L,36L,86L,54L,92L,78L,98L,58L,104L,40L,110L,94L,116L,42L,122L,46L,128L,108L,134L,52L,140L,84L,146L,124L,152L,60L,158L,72L,164L,138L,170L,102L,176L,66L,182L,154L,188L,112L,194L,70L,200L,168L,206L,76L,212L,100L,218L,184L,224L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269382Inst : IEnumerable<long>
{
public static readonly long[] Value=A269382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269382.Bytes);
public long this[int i]=>Value[i];

public static A269382Inst Instance=new A269382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269383
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,16L,15L,32L,13L,10L,11L,64L,17L,12L,31L,14L,29L,128L,63L,256L,25L,18L,19L,512L,21L,24L,127L,30L,33L,20L,23L,1024L,61L,26L,27L,2048L,57L,4096L,255L,22L,125L,8192L,511L,28L,49L,34L,35L,16384L,37L,48L,1023L,62L,41L,40L,47L,32768L,253L,58L,59L,36L,65L,65536L,39L,126L,45L,131072L,2047L,96L,121L,50L,51L,262144L,53L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269383Inst : IEnumerable<long>
{
public static readonly long[] Value=A269383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269383.Bytes);
public long this[int i]=>Value[i];

public static A269383Inst Instance=new A269383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269384
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,7L,6L,9L,14L,15L,18L,13L,20L,11L,10L,17L,26L,27L,34L,29L,44L,35L,30L,25L,38L,39L,48L,21L,32L,19L,12L,33L,50L,51L,64L,53L,80L,67L,58L,57L,86L,87L,108L,69L,104L,59L,54L,49L,74L,75L,94L,77L,116L,95L,84L,41L,62L,63L,78L,37L,56L,23L,16L,65L,98L,99L,124L,101L,152L,127L,112L,105L,158L,159L,198L,133L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269384Inst : IEnumerable<long>
{
public static readonly long[] Value=A269384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269384.Bytes);
public long this[int i]=>Value[i];

public static A269384Inst Instance=new A269384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269385
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,6L,5L,16L,21L,18L,19L,12L,15L,10L,7L,32L,45L,42L,49L,36L,51L,38L,31L,24L,33L,30L,35L,20L,27L,14L,11L,64L,93L,90L,109L,84L,123L,98L,85L,72L,105L,102L,125L,76L,111L,62L,55L,48L,69L,66L,79L,60L,87L,70L,59L,40L,57L,54L,65L,28L,39L,22L,13L,128L,189L,186L,229L,180L,267L,218L,191L,168L,249L,246L,305L,196L,291L,170L,151L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269385Inst : IEnumerable<long>
{
public static readonly long[] Value=A269385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269385.Bytes);
public long this[int i]=>Value[i];

public static A269385Inst Instance=new A269385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269386
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,15L,4L,5L,14L,31L,12L,63L,30L,13L,8L,127L,10L,11L,28L,9L,62L,255L,24L,511L,126L,29L,60L,1023L,26L,23L,16L,25L,254L,27L,20L,2047L,22L,61L,56L,4095L,18L,8191L,124L,17L,510L,16383L,48L,19L,1022L,21L,252L,32767L,58L,47L,120L,57L,2046L,55L,52L,65535L,46L,125L,32L,59L,50L,131071L,508L,49L,54L,262143L,40L,95L,4094L,253L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269386Inst : IEnumerable<long>
{
public static readonly long[] Value=A269386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269386.Bytes);
public long this[int i]=>Value[i];

public static A269386Inst Instance=new A269386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269387
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,8L,7L,10L,15L,12L,19L,18L,21L,16L,11L,14L,27L,20L,35L,30L,33L,24L,31L,38L,51L,36L,49L,42L,45L,32L,13L,22L,39L,28L,65L,54L,57L,40L,59L,70L,87L,60L,79L,66L,69L,48L,55L,62L,111L,76L,125L,102L,105L,72L,85L,98L,123L,84L,109L,90L,93L,64L,17L,26L,63L,44L,95L,78L,81L,56L,113L,130L,159L,108L,139L,114L,117L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269387Inst : IEnumerable<long>
{
public static readonly long[] Value=A269387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269387.Bytes);
public long this[int i]=>Value[i];

public static A269387Inst Instance=new A269387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269388
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,16L,11L,32L,17L,10L,15L,64L,13L,12L,19L,14L,33L,128L,23L,256L,65L,18L,35L,512L,21L,24L,31L,22L,129L,20L,27L,1024L,25L,34L,39L,2048L,29L,4096L,67L,30L,257L,8192L,47L,28L,513L,26L,131L,16384L,37L,48L,71L,38L,1025L,40L,43L,32768L,49L,66L,63L,36L,45L,65536L,259L,46L,41L,131072L,55L,96L,2049L,130L,51L,262144L,69L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269388Inst : IEnumerable<long>
{
public static readonly long[] Value=A269388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269388.Bytes);
public long this[int i]=>Value[i];

public static A269388Inst Instance=new A269388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269389
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,11L,13L,14L,16L,18L,19L,20L,21L,22L,23L,24L,25L,27L,28L,29L,32L,35L,36L,37L,38L,39L,42L,43L,44L,46L,47L,51L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,64L,66L,69L,71L,72L,73L,74L,75L,76L,77L,79L,81L,82L,83L,84L,86L,87L,88L,89L,92L,95L,98L,100L,103L,106L,107L,109L,110L,111L,114L,116L,118L,119L,120L,121L,122L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269389Inst : IEnumerable<long>
{
public static readonly long[] Value=A269389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269389.Bytes);
public long this[int i]=>Value[i];

public static A269389Inst Instance=new A269389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269390
{
public static readonly long[] Value={ 3L,5L,6L,9L,10L,11L,13L,14L,17L,18L,19L,20L,22L,23L,25L,26L,27L,29L,30L,33L,34L,35L,36L,37L,39L,40L,41L,43L,44L,45L,47L,48L,50L,51L,52L,54L,55L,57L,58L,59L,61L,62L,65L,66L,67L,68L,69L,70L,72L,73L,74L,76L,77L,78L,80L,81L,83L,84L,85L,86L,88L,89L,91L,92L,93L,95L,96L,98L,99L,100L,101L,103L,104L,105L,107L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269390Inst : IEnumerable<long>
{
public static readonly long[] Value=A269390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269390.Bytes);
public long this[int i]=>Value[i];

public static A269390Inst Instance=new A269390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269391
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,9L,11L,15L,10L,13L,17L,14L,12L,19L,23L,31L,21L,16L,27L,35L,18L,29L,25L,39L,22L,47L,63L,30L,20L,43L,33L,55L,71L,37L,26L,59L,51L,79L,34L,45L,95L,127L,28L,61L,41L,24L,87L,67L,111L,38L,143L,75L,46L,53L,119L,103L,62L,159L,69L,42L,32L,91L,191L,255L,57L,123L,83L,54L,49L,175L,135L,70L,223L,77L,287L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269391Inst : IEnumerable<long>
{
public static readonly long[] Value=A269391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269391.Bytes);
public long this[int i]=>Value[i];

public static A269391Inst Instance=new A269391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269392
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,9L,12L,10L,16L,13L,15L,11L,21L,14L,24L,17L,32L,20L,28L,18L,49L,26L,38L,22L,46L,25L,31L,19L,64L,34L,42L,23L,79L,37L,53L,27L,110L,48L,63L,33L,94L,43L,56L,29L,186L,72L,87L,40L,128L,57L,71L,35L,174L,68L,82L,39L,106L,47L,60L,30L,245L,92L,117L,51L,152L,62L,75L,36L,322L,112L,127L,55L,203L,77L,90L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269392Inst : IEnumerable<long>
{
public static readonly long[] Value=A269392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269392.Bytes);
public long this[int i]=>Value[i];

public static A269392Inst Instance=new A269392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269393
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,45L,38L,39L,40L,41L,42L,43L,44L,49L,46L,47L,48L,37L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,73L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,81L,90L,91L,76L,77L,78L,79L,80L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269393Inst : IEnumerable<long>
{
public static readonly long[] Value=A269393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269393.Bytes);
public long this[int i]=>Value[i];

public static A269393Inst Instance=new A269393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269394
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,49L,38L,39L,40L,41L,42L,43L,44L,37L,46L,47L,48L,45L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,97L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,61L,98L,99L,76L,77L,78L,79L,80L,73L,82L,83L,84L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269394Inst : IEnumerable<long>
{
public static readonly long[] Value=A269394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269394.Bytes);
public long this[int i]=>Value[i];

public static A269394Inst Instance=new A269394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269395
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,23L,20L,21L,22L,25L,24L,19L,26L,27L,28L,29L,30L,37L,32L,33L,34L,35L,36L,45L,46L,39L,40L,43L,42L,47L,44L,31L,50L,53L,48L,41L,38L,51L,52L,61L,54L,49L,56L,57L,58L,67L,60L,89L,74L,63L,64L,65L,66L,77L,68L,69L,70L,83L,72L,81L,90L,85L,92L,59L,78L,91L,80L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269395Inst : IEnumerable<long>
{
public static readonly long[] Value=A269395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269395.Bytes);
public long this[int i]=>Value[i];

public static A269395Inst Instance=new A269395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269396
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,25L,20L,21L,22L,19L,24L,23L,26L,27L,28L,29L,30L,45L,32L,33L,34L,35L,36L,31L,50L,39L,40L,49L,42L,41L,44L,37L,38L,43L,48L,55L,46L,51L,52L,47L,54L,105L,56L,57L,58L,77L,60L,53L,90L,63L,64L,65L,66L,59L,68L,69L,70L,97L,72L,181L,62L,99L,100L,67L,78L,81L,80L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269396Inst : IEnumerable<long>
{
public static readonly long[] Value=A269396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269396.Bytes);
public long this[int i]=>Value[i];

public static A269396Inst Instance=new A269396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269397
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,5L,4L,16L,13L,12L,10L,15L,9L,27L,11L,8L,22L,21L,18L,25L,46L,17L,43L,35L,20L,14L,36L,32L,34L,29L,26L,42L,40L,69L,28L,65L,54L,23L,33L,24L,55L,85L,50L,52L,45L,31L,41L,62L,19L,60L,100L,44L,67L,95L,80L,64L,37L,51L,38L,53L,82L,122L,78L,158L,75L,77L,68L,48L,61L,91L,49L,30L,88L,143L,145L,66L,98L,136L,116L,115L,93L,63L,56L,76L,58L,79L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269397Inst : IEnumerable<long>
{
public static readonly long[] Value=A269397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269397.Bytes);
public long this[int i]=>Value[i];

public static A269397Inst Instance=new A269397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269398
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,5L,4L,16L,13L,11L,15L,10L,9L,26L,12L,8L,22L,19L,49L,25L,18L,17L,38L,40L,20L,31L,14L,35L,30L,72L,46L,28L,39L,29L,24L,27L,57L,59L,87L,33L,47L,32L,23L,52L,45L,21L,103L,68L,71L,43L,58L,44L,60L,37L,41L,83L,186L,85L,123L,50L,69L,48L,82L,56L,36L,76L,53L,67L,34L,144L,128L,98L,101L,143L,65L,84L,66L,63L,86L,55L,106L,61L,118L,253L,42L,121L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269398Inst : IEnumerable<long>
{
public static readonly long[] Value=A269398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269398.Bytes);
public long this[int i]=>Value[i];

public static A269398Inst Instance=new A269398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269399
{
public static readonly long[] Value={ 3L,5L,9L,10L,12L,15L,17L,26L,30L,31L,33L,34L,40L,41L,45L,48L,49L,50L,52L,61L,65L,67L,68L,70L,78L,80L,85L,90L,91L,93L,94L,96L,97L,99L,101L,102L,104L,105L,108L,112L,113L,115L,117L,123L,124L,127L,133L,154L,155L,158L,159L,161L,162L,164L,168L,173L,174L,178L,179L,181L,182L,188L,189L,191L,193L,194L,196L,197L,199L,202L,204L,208L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269399Inst : IEnumerable<long>
{
public static readonly long[] Value=A269399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269399.Bytes);
public long this[int i]=>Value[i];

public static A269399Inst Instance=new A269399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269400
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,1L,3L,3L,2L,3L,4L,3L,1L,1L,4L,5L,2L,3L,3L,4L,4L,2L,5L,5L,2L,5L,5L,2L,1L,1L,3L,6L,2L,3L,4L,8L,1L,3L,8L,7L,3L,3L,4L,5L,2L,3L,6L,9L,4L,6L,10L,4L,3L,3L,3L,8L,5L,4L,5L,5L,5L,1L,7L,4L,2L,7L,4L,5L,1L,5L,7L,5L,2L,4L,8L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269400Inst : IEnumerable<long>
{
public static readonly long[] Value=A269400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269400.Bytes);
public long this[int i]=>Value[i];

public static A269400Inst Instance=new A269400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269401
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,5L,4L,12L,13L,15L,14L,11L,9L,25L,10L,8L,27L,31L,24L,29L,23L,19L,26L,51L,21L,30L,17L,55L,63L,49L,28L,22L,59L,47L,18L,39L,53L,103L,50L,43L,61L,20L,35L,111L,127L,16L,99L,57L,54L,45L,119L,95L,62L,37L,79L,107L,48L,207L,101L,87L,123L,41L,58L,46L,71L,223L,38L,255L,33L,199L,52L,115L,109L,102L,91L,239L,191L,42L,125L,75L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269401Inst : IEnumerable<long>
{
public static readonly long[] Value=A269401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269401.Bytes);
public long this[int i]=>Value[i];

public static A269401Inst Instance=new A269401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269402
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,4L,5L,16L,13L,15L,12L,8L,9L,11L,10L,46L,27L,35L,22L,42L,25L,32L,21L,19L,14L,23L,17L,31L,20L,26L,18L,158L,69L,85L,43L,116L,54L,67L,36L,142L,62L,78L,40L,104L,50L,64L,34L,57L,30L,39L,24L,71L,37L,49L,28L,101L,48L,63L,33L,81L,41L,53L,29L,669L,219L,259L,100L,321L,122L,145L,65L,476L,164L,190L,80L,255L,98L,120L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269402Inst : IEnumerable<long>
{
public static readonly long[] Value=A269402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269402.Bytes);
public long this[int i]=>Value[i];

public static A269402Inst Instance=new A269402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269403
{
public static readonly long[] Value={ 0L,2L,3L,6L,10L,16L,21L,28L,36L,46L,55L,66L,78L,92L,105L,120L,136L,154L,171L,190L,210L,232L,253L,276L,300L,326L,351L,378L,406L,436L,465L,496L,528L,562L,595L,630L,666L,704L,741L,780L,820L,862L,903L,946L,990L,1036L,1081L,1128L,1176L,1226L,1275L,1326L,1378L,1432L,1485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269403Inst : IEnumerable<long>
{
public static readonly long[] Value=A269403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269403.Bytes);
public long this[int i]=>Value[i];

public static A269403Inst Instance=new A269403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269404
{
public static readonly long[] Value={ 1L,0L,1L,7L,0L,9L,2L,7L,6L,9L,1L,3L,0L,4L,9L,9L,2L,7L,6L,6L,4L,3L,2L,7L,2L,1L,3L,3L,0L,9L,7L,9L,0L,9L,9L,2L,0L,4L,9L,2L,2L,1L,9L,0L,7L,9L,4L,9L,4L,1L,0L,1L,1L,3L,4L,6L,6L,4L,6L,5L,1L,7L,9L,3L,8L,1L,8L,9L,3L,5L,3L,3L,5L,8L,3L,4L,2L,2L,7L,9L,4L,3L,1L,8L,1L,5L,1L,5L,9L,6L,4L,7L,8L,5L,0L,6L,6L,8L,9L,7L,8L,4L,5L,4L,6L,5L,1L,0L,6L,4L,0L,2L,6L,1L,3L,3L,6L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269404Inst : IEnumerable<long>
{
public static readonly long[] Value=A269404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269404.Bytes);
public long this[int i]=>Value[i];

public static A269404Inst Instance=new A269404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269405
{
public static readonly long[] Value={ 5L,25L,120L,570L,2670L,12380L,56890L,259445L,1175355L,5293671L,23718780L,105781845L,469798125L,2078552055L,9164402118L,40277785365L,176503698495L,771372344695L,3362640467600L,14624384170213L,63463229049585L,274836205944615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269405Inst : IEnumerable<long>
{
public static readonly long[] Value=A269405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269405.Bytes);
public long this[int i]=>Value[i];

public static A269405Inst Instance=new A269405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269406
{
public static readonly long[] Value={ 6L,36L,210L,1215L,6960L,39560L,223320L,1253190L,6995660L,38870136L,215074596L,1185563746L,6512894520L,35666937840L,194765568024L,1060744346079L,5762980508994L,31239002042780L,168977143019910L,912220049428041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269406Inst : IEnumerable<long>
{
public static readonly long[] Value=A269406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269406.Bytes);
public long this[int i]=>Value[i];

public static A269406Inst Instance=new A269406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269407
{
public static readonly long[] Value={ 7L,49L,336L,2289L,15477L,104006L,695135L,4623815L,30625210L,202067047L,1328649469L,8708852838L,56920021347L,371043659463L,2412849114074L,15655214564192L,101363364976160L,655024985471255L,4225174990367555L,27207648363845138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269407Inst : IEnumerable<long>
{
public static readonly long[] Value=A269407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269407.Bytes);
public long this[int i]=>Value[i];

public static A269407Inst Instance=new A269407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269408
{
public static readonly long[] Value={ 8L,64L,504L,3948L,30744L,238224L,1837752L,14121282L,108123624L,825227424L,6279994728L,47663522844L,360868232424L,2726022470928L,20549497120776L,154606709405835L,1161096042133440L,8705061811230400L,65160664171875440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269408Inst : IEnumerable<long>
{
public static readonly long[] Value=A269408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269408.Bytes);
public long this[int i]=>Value[i];

public static A269408Inst Instance=new A269408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269409
{
public static readonly long[] Value={ 2L,3L,4L,4L,9L,6L,5L,16L,24L,9L,6L,25L,60L,63L,12L,7L,36L,120L,222L,159L,16L,8L,49L,210L,570L,804L,394L,20L,9L,64L,336L,1215L,2670L,2872L,957L,25L,10L,81L,504L,2289L,6960L,12380L,10132L,2292L,30L,11L,100L,720L,3948L,15477L,39560L,56890L,35383L,5419L,36L,12L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269409Inst : IEnumerable<long>
{
public static readonly long[] Value=A269409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269409.Bytes);
public long this[int i]=>Value[i];

public static A269409Inst Instance=new A269409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269410
{
public static readonly long[] Value={ 9L,63L,222L,570L,1215L,2289L,3948L,6372L,9765L,14355L,20394L,28158L,37947L,50085L,64920L,82824L,104193L,129447L,159030L,193410L,233079L,278553L,330372L,389100L,455325L,529659L,612738L,705222L,807795L,921165L,1046064L,1183248L,1333497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269410Inst : IEnumerable<long>
{
public static readonly long[] Value=A269410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269410.Bytes);
public long this[int i]=>Value[i];

public static A269410Inst Instance=new A269410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269411
{
public static readonly long[] Value={ 12L,159L,804L,2670L,6960L,15477L,30744L,56124L,95940L,155595L,241692L,362154L,526344L,745185L,1031280L,1399032L,1864764L,2446839L,3165780L,4044390L,5107872L,6383949L,7902984L,9698100L,11805300L,14263587L,17115084L,20405154L,24182520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269411Inst : IEnumerable<long>
{
public static readonly long[] Value=A269411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269411.Bytes);
public long this[int i]=>Value[i];

public static A269411Inst Instance=new A269411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269412
{
public static readonly long[] Value={ 16L,394L,2872L,12380L,39560L,104006L,238224L,492312L,939360L,1681570L,2857096L,4647604L,7286552L,11068190L,16357280L,23599536L,33332784L,46198842L,62956120L,84492940L,111841576L,146193014L,188912432L,241555400L,305884800L,383888466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269412Inst : IEnumerable<long>
{
public static readonly long[] Value=A269412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269412.Bytes);
public long this[int i]=>Value[i];

public static A269412Inst Instance=new A269412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269413
{
public static readonly long[] Value={ 20L,957L,10132L,56890L,223320L,695135L,1837752L,4302612L,9168780L,18124865L,33696300L,59523022L,100692592L,164133795L,259075760L,397577640L,595133892L,871360197L,1250765060L,1763612130L,2446878280L,3345312487L,4512600552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269413Inst : IEnumerable<long>
{
public static readonly long[] Value=A269413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269413.Bytes);
public long this[int i]=>Value[i];

public static A269413Inst Instance=new A269413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269414
{
public static readonly long[] Value={ 3L,19L,31L,83L,109L,199L,251L,409L,571L,631L,683L,829L,1091L,1489L,1999L,2341L,2531L,2971L,3529L,4621L,4789L,5051L,7039L,7211L,7669L,8779L,9721L,10459L,10711L,11171L,13681L,14851L,15131L,16069L,16381L,16883L,17659L,18731L,20011L,20359L,21683L,23251L,24851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269414Inst : IEnumerable<long>
{
public static readonly long[] Value=A269414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269414.Bytes);
public long this[int i]=>Value[i];

public static A269414Inst Instance=new A269414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269415
{
public static readonly long[] Value={ 2L,1L,4L,6L,13L,11L,19L,8L,15L,22L,24L,17L,28L,20L,33L,31L,42L,26L,37L,51L,59L,39L,46L,35L,55L,48L,57L,44L,66L,75L,40L,60L,53L,64L,84L,62L,73L,93L,68L,82L,77L,79L,101L,91L,71L,88L,86L,103L,80L,109L,95L,97L,99L,129L,107L,112L,116L,118L,138L,110L,189L,105L,127L,114L,123L,125L,136L,132L,134L,141L,145L,149L,147L,121L,150L,143L,156L,130L,158L,154L,152L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269415Inst : IEnumerable<long>
{
public static readonly long[] Value=A269415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269415.Bytes);
public long this[int i]=>Value[i];

public static A269415Inst Instance=new A269415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269416
{
public static readonly long[] Value={ 6L,-9L,15L,-18L,24L,-27L,33L,-36L,42L,-45L,51L,-54L,60L,-63L,69L,-72L,78L,-81L,87L,-90L,96L,-99L,105L,-108L,114L,-117L,123L,-126L,132L,-135L,141L,-144L,150L,-153L,159L,-162L,168L,-171L,177L,-180L,186L,-189L,195L,-198L,204L,-207L,213L,-216L,222L,-225L,231L,-234L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269416Inst : IEnumerable<long>
{
public static readonly long[] Value=A269416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269416.Bytes);
public long this[int i]=>Value[i];

public static A269416Inst Instance=new A269416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269417
{
public static readonly long[] Value={ 1L,1L,386356909593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269417Inst : IEnumerable<long>
{
public static readonly long[] Value=A269417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269417.Bytes);
public long this[int i]=>Value[i];

public static A269417Inst Instance=new A269417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269418
{
public static readonly BigInteger[] Value={ -1L,1L,49L,1225L,4412401L,73560025L,245229441961L,7759635184525L,2163099334469560445L,BigInteger.Parse("243352176577765537625"),BigInteger.Parse("126154825844683612669806743"),BigInteger.Parse("307996788703417873806157775"),BigInteger.Parse("3816216508144039222348410175181221"),BigInteger.Parse("4472139245793702477426700875742975") };
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
public class A269418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269418Inst Instance=new A269418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269419
{
public static readonly BigInteger[] Value={ 1L,48L,4608L,55296L,42467328L,84934656L,21743271936L,36691771392L,400771988324352L,1352605460594688L,16620815899787526144UL,779100745302540288L,BigInteger.Parse("153177439332441840943104"),BigInteger.Parse("2393397489569403764736"),BigInteger.Parse("235280546814630667688607744"),BigInteger.Parse("57441539749665690353664") };
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
public class A269419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269419Inst Instance=new A269419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269420
{
public static readonly long[] Value={ 8L,24L,32L,40L,48L,72L,120L,144L,152L,176L,216L,264L,320L,400L,520L,592L,600L,824L,856L,872L,936L,992L,1064L,1072L,1112L,1336L,1392L,1408L,1584L,1720L,2080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269420Inst : IEnumerable<long>
{
public static readonly long[] Value=A269420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269420.Bytes);
public long this[int i]=>Value[i];

public static A269420Inst Instance=new A269420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269421
{
public static readonly long[] Value={ 3L,19L,179L,379L,691L,1187L,1307L,4787L,15467L,22307L,43067L,83579L,273323L,373459L,1543291L,5364091L,5768803L,20941259L,137649667L,251522291L,369352163L,426008699L,938378747L,1042908091L,1378014731L,1878780427L,11474650339L,12402606331L,15931938899L,51025309339L,144309631099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269421Inst : IEnumerable<long>
{
public static readonly long[] Value=A269421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269421.Bytes);
public long this[int i]=>Value[i];

public static A269421Inst Instance=new A269421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269422
{
public static readonly long[] Value={ 11L,43L,211L,419L,739L,1259L,1427L,4931L,15619L,22483L,43283L,83843L,273643L,373859L,1543811L,5364683L,5769403L,20942083L,137650523L,251523163L,369353099L,426009691L,938379811L,1042909163L,1378015843L,1878781763L,11474651731L,12402607739L,15931940483L,51025311059L,144309633179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269422Inst : IEnumerable<long>
{
public static readonly long[] Value=A269422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269422.Bytes);
public long this[int i]=>Value[i];

public static A269422Inst Instance=new A269422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269423
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,4L,8L,8L,10L,16L,3L,9L,7L,12L,13L,25L,12L,4L,12L,14L,22L,58L,3L,12L,34L,48L,11L,31L,31L,4L,79L,14L,35L,82L,36L,113L,21L,28L,6L,47L,59L,9L,46L,1L,105L,131L,59L,103L,30L,27L,48L,12L,7L,38L,60L,19L,50L,110L,157L,210L,7L,6L,23L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269423Inst : IEnumerable<long>
{
public static readonly long[] Value=A269423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269423.Bytes);
public long this[int i]=>Value[i];

public static A269423Inst Instance=new A269423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269424
{
public static readonly long[] Value={ 24L,32L,56L,64L,88L,112L,120L,136L,160L,216L,232L,240L,264L,304L,384L,480L,488L,528L,544L,576L,624L,640L,720L,760L,816L,888L,960L,1032L,1064L,1200L,1296L,1320L,1432L,1464L,1520L,1560L,1608L,1832L,1848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269424Inst : IEnumerable<long>
{
public static readonly long[] Value=A269424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269424.Bytes);
public long this[int i]=>Value[i];

public static A269424Inst Instance=new A269424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269425
{
public static readonly long[] Value={ 17L,41L,137L,457L,673L,2161L,5953L,8377L,10009L,22481L,37657L,73121L,79889L,220897L,351529L,1879121L,2321393L,4259113L,6394657L,8211977L,9618457L,11282017L,36087113L,59502217L,72495233L,236885513L,556952881L,809097481L,830449097L,888023449L,2420630497L,3845315977L,13243532017L,17279668529L,29704277129L,49624608961L,59974490209L,107046775289L,158191299481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269425Inst : IEnumerable<long>
{
public static readonly long[] Value=A269425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269425.Bytes);
public long this[int i]=>Value[i];

public static A269425Inst Instance=new A269425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269426
{
public static readonly long[] Value={ 41L,73L,193L,521L,761L,2273L,6073L,8513L,10169L,22697L,37889L,73361L,80153L,221201L,351913L,1879601L,2321881L,4259641L,6395201L,8212553L,9619081L,11282657L,36087833L,59502977L,72496049L,236886401L,556953841L,809098513L,830450161L,888024649L,2420631793L,3845317297L,13243533449L,17279669993L,29704278649L,49624610521L,59974491817L,107046777121L,158191301329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269426Inst : IEnumerable<long>
{
public static readonly long[] Value=A269426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269426.Bytes);
public long this[int i]=>Value[i];

public static A269426Inst Instance=new A269426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269427
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,3L,2L,4L,3L,3L,1L,7L,4L,2L,1L,7L,3L,4L,3L,4L,2L,6L,5L,7L,3L,2L,1L,10L,1L,6L,5L,6L,3L,3L,2L,8L,5L,6L,2L,5L,4L,6L,3L,6L,7L,6L,1L,10L,3L,3L,3L,9L,3L,5L,3L,7L,5L,8L,3L,7L,4L,6L,3L,5L,4L,7L,6L,7L,3L,4L,3L,9L,8L,7L,3L,6L,1L,6L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269427Inst : IEnumerable<long>
{
public static readonly long[] Value=A269427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269427.Bytes);
public long this[int i]=>Value[i];

public static A269427Inst Instance=new A269427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269428
{
public static readonly long[] Value={ 0L,-1L,7L,-19L,41L,-74L,122L,-186L,270L,-375L,505L,-661L,847L,-1064L,1316L,-1604L,1932L,-2301L,2715L,-3175L,3685L,-4246L,4862L,-5534L,6266L,-7059L,7917L,-8841L,9835L,-10900L,12040L,-13256L,14552L,-15929L,17391L,-18939L,20577L,-22306L,24130L,-26050L,28070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269428Inst : IEnumerable<long>
{
public static readonly long[] Value=A269428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269428.Bytes);
public long this[int i]=>Value[i];

public static A269428Inst Instance=new A269428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269429
{
public static readonly long[] Value={ 0L,-1L,8L,-22L,48L,-87L,144L,-220L,320L,-445L,600L,-786L,1008L,-1267L,1568L,-1912L,2304L,-2745L,3240L,-3790L,4400L,-5071L,5808L,-6612L,7488L,-8437L,9464L,-10570L,11760L,-13035L,14400L,-15856L,17408L,-19057L,20808L,-22662L,24624L,-26695L,28880L,-31180L,33600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269429Inst : IEnumerable<long>
{
public static readonly long[] Value=A269429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269429.Bytes);
public long this[int i]=>Value[i];

public static A269429Inst Instance=new A269429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269430
{
public static readonly long[] Value={ 2L,0L,7L,0L,7L,9L,6L,3L,2L,6L,7L,9L,4L,8L,9L,6L,6L,1L,9L,2L,3L,1L,3L,2L,1L,6L,9L,1L,6L,3L,9L,7L,5L,1L,4L,4L,2L,0L,9L,8L,5L,8L,4L,6L,9L,9L,6L,8L,7L,5L,5L,2L,9L,1L,0L,4L,8L,7L,4L,7L,2L,2L,9L,6L,1L,5L,3L,9L,0L,8L,2L,0L,3L,1L,4L,3L,1L,0L,4L,4L,9L,9L,3L,1L,4L,0L,1L,7L,4L,1L,2L,6L,7L,1L,0L,5L,8L,5L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269430Inst : IEnumerable<long>
{
public static readonly long[] Value=A269430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269430.Bytes);
public long this[int i]=>Value[i];

public static A269430Inst Instance=new A269430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269431
{
public static readonly long[] Value={ 5L,25L,125L,615L,2995L,14455L,69235L,329430L,1558430L,7334806L,34364270L,160340610L,745362730L,3453222850L,15949215754L,73454841775L,337413819915L,1546145183895L,7068979186035L,32251365241137L,146853223312325L,667445619383425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269431Inst : IEnumerable<long>
{
public static readonly long[] Value=A269431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269431.Bytes);
public long this[int i]=>Value[i];

public static A269431Inst Instance=new A269431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269432
{
public static readonly long[] Value={ 6L,36L,216L,1281L,7536L,44021L,255576L,1475871L,8482276L,48543777L,276756312L,1572394697L,8905537932L,50293202487L,283276001872L,1591658418642L,8922925364502L,49917266140917L,278703080519352L,1553227427718978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269432Inst : IEnumerable<long>
{
public static readonly long[] Value=A269432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269432.Bytes);
public long this[int i]=>Value[i];

public static A269432Inst Instance=new A269432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269433
{
public static readonly long[] Value={ 7L,49L,343L,2380L,16408L,112476L,767172L,5209554L,35236110L,237479970L,1595378190L,10686193980L,71386033740L,475694666700L,3162645548916L,20982275486907L,138930896958189L,918219765681883L,6058251819231325L,39906814296599320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269433Inst : IEnumerable<long>
{
public static readonly long[] Value=A269433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269433.Bytes);
public long this[int i]=>Value[i];

public static A269433Inst Instance=new A269433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269434
{
public static readonly long[] Value={ 8L,64L,512L,4068L,32152L,252932L,1981512L,15465934L,120310016L,933059856L,7216323640L,55670133422L,428465939112L,3290601897928L,25221303496496L,192953793764769L,1473623863797808L,11236105478130612L,85542959337048488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269434Inst : IEnumerable<long>
{
public static readonly long[] Value=A269434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269434.Bytes);
public long this[int i]=>Value[i];

public static A269434Inst Instance=new A269434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269435
{
public static readonly long[] Value={ 2L,3L,4L,4L,9L,8L,5L,16L,27L,15L,6L,25L,64L,78L,28L,7L,36L,125L,250L,222L,51L,8L,49L,216L,615L,964L,622L,92L,9L,64L,343L,1281L,2995L,3674L,1722L,164L,10L,81L,512L,2380L,7536L,14455L,13868L,4719L,290L,11L,100L,729L,4068L,16408L,44021L,69235L,51917L,12821L,509L,12L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269435Inst : IEnumerable<long>
{
public static readonly long[] Value=A269435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269435.Bytes);
public long this[int i]=>Value[i];

public static A269435Inst Instance=new A269435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269436
{
public static readonly long[] Value={ 15L,78L,250L,615L,1281L,2380L,4068L,6525L,9955L,14586L,20670L,28483L,38325L,50520L,65416L,83385L,104823L,130150L,159810L,194271L,234025L,279588L,331500L,390325L,456651L,531090L,614278L,706875L,809565L,923056L,1048080L,1185393L,1335775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269436Inst : IEnumerable<long>
{
public static readonly long[] Value=A269436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269436.Bytes);
public long this[int i]=>Value[i];

public static A269436Inst Instance=new A269436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269437
{
public static readonly long[] Value={ 28L,222L,964L,2995L,7536L,16408L,32152L,58149L,98740L,159346L,246588L,368407L,534184L,754860L,1043056L,1413193L,1881612L,2466694L,3188980L,4071291L,5138848L,6419392L,7943304L,9743725L,11856676L,14321178L,17179372L,20476639L,24261720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269437Inst : IEnumerable<long>
{
public static readonly long[] Value=A269437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269437.Bytes);
public long this[int i]=>Value[i];

public static A269437Inst Instance=new A269437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269438
{
public static readonly long[] Value={ 51L,622L,3674L,14455L,44021L,112476L,252932L,516189L,976135L,1735866L,2934526L,4754867L,7431529L,11260040L,16606536L,23918201L,33734427L,46698694L,63571170L,85242031L,112745501L,147274612L,190196684L,243069525L,307658351L,385953426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269438Inst : IEnumerable<long>
{
public static readonly long[] Value=A269438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269438.Bytes);
public long this[int i]=>Value[i];

public static A269438Inst Instance=new A269438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269439
{
public static readonly long[] Value={ 92L,1722L,13868L,69235L,255576L,767172L,1981512L,4566213L,9621220L,18861326L,34844052L,61247927L,103206208L,167701080L,264023376L,404302857L,604114092L,883162978L,1266058940L,1783177851L,2471620712L,3376273132L,4550970648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269439Inst : IEnumerable<long>
{
public static readonly long[] Value=A269439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269439.Bytes);
public long this[int i]=>Value[i];

public static A269439Inst Instance=new A269439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269440
{
public static readonly long[] Value={ 0L,-1L,9L,-25L,55L,-100L,166L,-254L,370L,-515L,695L,-911L,1169L,-1470L,1820L,-2220L,2676L,-3189L,3765L,-4405L,5115L,-5896L,6754L,-7690L,8710L,-9815L,11011L,-12299L,13685L,-15170L,16760L,-18456L,20264L,-22185L,24225L,-26385L,28671L,-31084L,33630L,-36310L,39130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269440Inst : IEnumerable<long>
{
public static readonly long[] Value=A269440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269440.Bytes);
public long this[int i]=>Value[i];

public static A269440Inst Instance=new A269440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269441
{
public static readonly long[] Value={ 0L,-1L,10L,-28L,62L,-113L,188L,-288L,420L,-585L,790L,-1036L,1330L,-1673L,2072L,-2528L,3048L,-3633L,4290L,-5020L,5830L,-6721L,7700L,-8768L,9932L,-11193L,12558L,-14028L,15610L,-17305L,19120L,-21056L,23120L,-25313L,27642L,-30108L,32718L,-35473L,38380L,-41440L,44660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269441Inst : IEnumerable<long>
{
public static readonly long[] Value=A269441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269441.Bytes);
public long this[int i]=>Value[i];

public static A269441Inst Instance=new A269441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269442
{
public static readonly long[] Value={ 1L,17L,131071L,64570081L,5726623061L,190734863281L,3385331888947L,38771752331201L,321685687669321L,2084647712458321L,11111111111111111L,50544702849929377L,201691918794585181L,720867993281778161L,2345488209948553531L,7037580381120954241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269442Inst : IEnumerable<long>
{
public static readonly long[] Value=A269442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269442.Bytes);
public long this[int i]=>Value[i];

public static A269442Inst Instance=new A269442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269443
{
public static readonly long[] Value={ 0L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,3L,2L,2L,4L,1L,1L,1L,1L,1L,1L,4L,1L,6L,3L,7L,1L,7L,3L,3L,2L,4L,2L,2L,1L,1L,2L,1L,1L,3L,2L,1L,5L,1L,3L,1L,2L,1L,1L,13L,40L,1L,1L,1L,48L,211L,4L,91L,1L,16L,9L,1L,10L,8L,2L,4L,1L,2L,3L,2L,1L,1L,13L,3L,1L,2L,2L,1L,3L,1L,18L,2L,1L,1L,1L,5L,3L,7L,1L,1L,21L,1L,6L,4L,1L,1L,2L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269443Inst : IEnumerable<long>
{
public static readonly long[] Value=A269443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269443.Bytes);
public long this[int i]=>Value[i];

public static A269443Inst Instance=new A269443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269444
{
public static readonly long[] Value={ 0L,1L,9L,6L,2L,1L,1L,1L,1L,1L,1L,6L,1L,4L,1L,7L,2L,1L,1L,1L,2L,91L,32L,1L,1L,6L,23L,1L,1L,1L,1L,2L,9L,1L,2L,1L,1L,5L,1L,1L,37L,12L,1L,12L,3L,2L,87L,1L,4L,2L,2L,2L,320L,1L,7L,1L,2L,6L,3L,1L,6L,4L,1L,4L,2L,1L,69L,1L,4L,3L,3L,1L,14L,3L,1L,3L,1L,10L,2L,694L,2L,4L,21L,1L,1L,1L,3L,3L,10L,2L,1L,2L,2L,1L,3L,5L,1L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269444Inst : IEnumerable<long>
{
public static readonly long[] Value=A269444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269444.Bytes);
public long this[int i]=>Value[i];

public static A269444Inst Instance=new A269444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269445
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,42L,45L,48L,51L,54L,57L,60L,63L,66L,69L,72L,75L,78L,82L,86L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,130L,135L,140L,145L,150L,155L,160L,165L,170L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269445Inst : IEnumerable<long>
{
public static readonly long[] Value=A269445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269445.Bytes);
public long this[int i]=>Value[i];

public static A269445Inst Instance=new A269445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269446
{
public static readonly BigInteger[] Value={ 1L,19L,524287L,581130733L,91625968981L,4768371582031L,121871948002099L,1899815864228857L,20587884010836553L,168856464709124011L,1111111111111111111L,6115909044841454629L,BigInteger.Parse("29043636306420266077"),BigInteger.Parse("121826690864620509223"),BigInteger.Parse("459715689149916492091"),BigInteger.Parse("1583455585752214704241") };
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
public class A269446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269446Inst Instance=new A269446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269447
{
public static readonly long[] Value={ 7L,17L,881L,1351L,42787L,65337L,2053401L,3135331L,98520967L,150431057L,4726953521L,7217555911L,226795248547L,346292253177L,10881444977241L,16614810597091L,522082563659527L,797164616407697L,25049081610680561L,38247286776972871L,1201833834749007907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269447Inst : IEnumerable<long>
{
public static readonly long[] Value=A269447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269447.Bytes);
public long this[int i]=>Value[i];

public static A269447Inst Instance=new A269447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269448
{
public static readonly long[] Value={ 25L,301L,454L,3850L,31966L,47569L,393925L,3261481L,4852834L,40177750L,332640346L,494942749L,4097737825L,33926055061L,50479308814L,417929081650L,3460124977126L,5148394557529L,42624668591725L,352898821613041L,525085765560394L,4347298267275550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269448Inst : IEnumerable<long>
{
public static readonly long[] Value=A269448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269448.Bytes);
public long this[int i]=>Value[i];

public static A269448Inst Instance=new A269448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269449
{
public static readonly long[] Value={ 7L,27L,60L,181L,227L,612L,1085L,1985L,3492L,9047L,11161L,28860L,50607L,91987L,161276L,416685L,513883L,1327652L,2327541L,4230121L,7415908L,19159167L,23628161L,61043836L,107016983L,194494283L,340971196L,880905701L,1086382227L,2806689508L,4920454381L,8942507601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269449Inst : IEnumerable<long>
{
public static readonly long[] Value=A269449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269449.Bytes);
public long this[int i]=>Value[i];

public static A269449Inst Instance=new A269449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269450
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,4L,18L,90L,542L,3812L,30584L,275780L,2761524L,30406824L,365153944L,4749732736L,66526393072L,998258318560L,15976852694928L,271672659784368L,4891101414839216L,92946837570669440L,1859207430534452576L,BigInteger.Parse("39048231231949618976"),BigInteger.Parse("859153763261341223136") };
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
public class A269450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269450Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269450.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269450.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269450Inst Instance=new A269450Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269451
{
public static readonly long[] Value={ 7L,28L,44L,67L,87L,124L,168L,287L,379L,512L,628L,843L,1099L,1792L,2328L,3103L,3779L,5032L,6524L,10563L,13687L,18204L,22144L,29447L,38143L,61684L,79892L,106219L,129183L,171748L,222432L,359639L,465763L,619208L,753052L,1001139L,1296547L,2096248L,2714784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269451Inst : IEnumerable<long>
{
public static readonly long[] Value=A269451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269451.Bytes);
public long this[int i]=>Value[i];

public static A269451Inst Instance=new A269451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269452
{
public static readonly long[] Value={ 24L,40L,60L,88L,132L,184L,220L,232L,276L,348L,328L,460L,424L,492L,580L,636L,664L,712L,820L,1012L,904L,996L,1060L,1068L,1048L,1276L,1356L,1384L,1432L,1660L,1572L,1804L,1528L,1780L,1864L,1912L,2076L,2332L,2260L,2148L,2008L,2292L,2668L,2248L,2620L,2344L,2796L,2868L,3012L,2872L,3460L,3652L,3772L,3372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269452Inst : IEnumerable<long>
{
public static readonly long[] Value=A269452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269452.Bytes);
public long this[int i]=>Value[i];

public static A269452Inst Instance=new A269452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269453
{
public static readonly long[] Value={ 12L,20L,30L,44L,33L,92L,110L,116L,69L,174L,164L,230L,212L,246L,290L,318L,332L,356L,410L,253L,452L,249L,530L,534L,524L,638L,678L,692L,716L,830L,393L,902L,764L,890L,932L,956L,1038L,1166L,1130L,537L,1004L,573L,1334L,1124L,1310L,1172L,1398L,717L,753L,1436L,1730L,913L,1886L,1686L,1790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269453Inst : IEnumerable<long>
{
public static readonly long[] Value=A269453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269453.Bytes);
public long this[int i]=>Value[i];

public static A269453Inst Instance=new A269453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269454
{
public static readonly long[] Value={ 5L,11L,59L,83L,107L,179L,227L,347L,467L,563L,587L,1019L,1187L,1283L,1307L,1523L,1619L,1907L,2027L,2099L,2459L,2579L,2819L,2963L,3203L,3467L,3779L,3803L,3947L,4139L,4259L,4283L,4547L,4787L,5099L,5387L,5483L,5507L,5939L,6659L,6779L,6827L,6899L,7187L,7523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269454Inst : IEnumerable<long>
{
public static readonly long[] Value=A269454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269454.Bytes);
public long this[int i]=>Value[i];

public static A269454Inst Instance=new A269454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269455
{
public static readonly BigInteger[] Value={ 1L,3L,15L,105L,2295L,75735L,4922775L,625192425L,163204759575L,83724041661975L,85817142703524375L,BigInteger.Parse("175667691114114395625"),BigInteger.Parse("720413716161839357604375"),BigInteger.Parse("5902349576513949856852644375"),BigInteger.Parse("96709997811181068404530578084375"),BigInteger.Parse("3168896498278970068411253452090715625"),BigInteger.Parse("207692645973961964120828372930661061284375"),BigInteger.Parse("27222898185745116523209337325140537285726884375"),BigInteger.Parse("7136346644902153570976711733098966146766874104484375"),BigInteger.Parse("374149377341581538926666726441125766418996412361779951562") };
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
public class A269455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269455Inst Instance=new A269455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269456
{
public static readonly long[] Value={ 2L,1L,3L,2L,2L,4L,3L,5L,3L,5L,6L,8L,8L,4L,6L,9L,18L,14L,11L,5L,7L,18L,30L,32L,20L,14L,6L,8L,30L,63L,57L,47L,26L,17L,7L,9L,56L,114L,124L,86L,62L,32L,20L,8L,10L,99L,226L,234L,191L,116L,77L,38L,23L,9L,11L,186L,422L,480L,370L,260L,146L,92L,44L,26L,10L,12L,335L,826L,932L,775L,512L,330L,176L,107L,50L,29L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269456Inst : IEnumerable<long>
{
public static readonly long[] Value=A269456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269456.Bytes);
public long this[int i]=>Value[i];

public static A269456Inst Instance=new A269456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269457
{
public static readonly long[] Value={ 10L,25L,45L,70L,100L,135L,175L,220L,270L,325L,385L,450L,520L,595L,675L,760L,850L,945L,1045L,1150L,1260L,1375L,1495L,1620L,1750L,1885L,2025L,2170L,2320L,2475L,2635L,2800L,2970L,3145L,3325L,3510L,3700L,3895L,4095L,4300L,4510L,4725L,4945L,5170L,5400L,5635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269457Inst : IEnumerable<long>
{
public static readonly long[] Value=A269457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269457.Bytes);
public long this[int i]=>Value[i];

public static A269457Inst Instance=new A269457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269458
{
public static readonly long[] Value={ 3L,53L,61L,71L,89L,101L,107L,7121L,7129L,7159L,7187L,424891L,29739371L,29740511L,29740523L,29740723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269458Inst : IEnumerable<long>
{
public static readonly long[] Value=A269458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269458.Bytes);
public long this[int i]=>Value[i];

public static A269458Inst Instance=new A269458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269459
{
public static readonly long[] Value={ 15L,16L,45L,60L,69L,75L,112L,116L,236L,296L,319L,452L,576L,586L,843L,1047L,1184L,1704L,1902L,2852L,2966L,3068L,3122L,4708L,4805L,5684L,6150L,6712L,7126L,10920L,10950L,13107L,16700L,18698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269459Inst : IEnumerable<long>
{
public static readonly long[] Value=A269459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269459.Bytes);
public long this[int i]=>Value[i];

public static A269459Inst Instance=new A269459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269460
{
public static readonly BigInteger[] Value={ 2L,9L,60L,580L,7170L,108402L,1934856L,39808584L,927352710L,24123618310L,693066874236L,21793557008028L,744461976979994L,27451268150267850L,1086741065393740560L,BigInteger.Parse("45971289976043485456"),BigInteger.Parse("2069440771476789080334") };
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
public class A269460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269460Inst Instance=new A269460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269461
{
public static readonly long[] Value={ 3L,9L,24L,66L,174L,462L,1206L,3150L,8166L,21150L,54582L,140718L,362118L,931134L,2391894L,6141006L,15757734L,40420062L,103647606L,265721070L,681097926L,1745555070L,4473092502L,11461604238L,29366557158L,75238139934L,192754700214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A269461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269461Inst : IEnumerable<long>
{
public static readonly long[] Value=A269461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269461.Bytes);
public long this[int i]=>Value[i];

public static A269461Inst Instance=new A269461Inst();

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