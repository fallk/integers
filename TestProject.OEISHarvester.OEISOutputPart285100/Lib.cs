using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A186511
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,8L,10L,11L,13L,14L,16L,17L,18L,20L,21L,23L,24L,26L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,70L,72L,73L,75L,76L,78L,79L,81L,82L,83L,85L,86L,88L,89L,91L,92L,94L,95L,96L,98L,99L,101L,102L,104L,105L,107L,108L,110L,111L,112L,114L,115L,117L,118L,120L,121L,123L,124L,125L,127L,128L,130L,131L,133L,134L,136L,137L,138L,140L,141L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186511Inst : IEnumerable<long>
{
public static readonly long[] Value=A186511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186511.Bytes);
public long this[int i]=>Value[i];

public static A186511Inst Instance=new A186511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186512
{
public static readonly long[] Value={ 1L,5L,9L,12L,15L,19L,22L,25L,29L,32L,35L,38L,41L,45L,48L,51L,54L,58L,61L,64L,67L,71L,74L,77L,80L,84L,87L,90L,93L,97L,100L,103L,106L,109L,113L,116L,119L,122L,126L,129L,132L,135L,139L,142L,145L,148L,152L,155L,158L,161L,165L,168L,171L,174L,177L,181L,184L,187L,190L,194L,197L,200L,203L,207L,210L,213L,216L,220L,223L,226L,229L,232L,236L,239L,242L,245L,249L,252L,255L,258L,262L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186512Inst : IEnumerable<long>
{
public static readonly long[] Value=A186512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186512.Bytes);
public long this[int i]=>Value[i];

public static A186512Inst Instance=new A186512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186513
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,9L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,25L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,67L,69L,70L,72L,73L,75L,76L,78L,79L,81L,82L,83L,85L,86L,88L,89L,91L,92L,94L,95L,96L,98L,99L,101L,102L,104L,105L,107L,108L,109L,111L,112L,114L,115L,117L,118L,120L,121L,123L,124L,125L,127L,128L,130L,131L,133L,134L,136L,137L,138L,140L,141L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186513Inst : IEnumerable<long>
{
public static readonly long[] Value=A186513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186513.Bytes);
public long this[int i]=>Value[i];

public static A186513Inst Instance=new A186513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186514
{
public static readonly long[] Value={ 4L,6L,10L,13L,16L,19L,22L,26L,29L,32L,35L,38L,42L,45L,48L,51L,55L,58L,61L,64L,68L,71L,74L,77L,80L,84L,87L,90L,93L,97L,100L,103L,106L,110L,113L,116L,119L,122L,126L,129L,132L,135L,139L,142L,145L,148L,152L,155L,158L,161L,165L,168L,171L,174L,178L,181L,184L,187L,190L,194L,197L,200L,203L,207L,210L,213L,216L,220L,223L,226L,229L,233L,236L,239L,242L,245L,249L,252L,255L,258L,262L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186514Inst : IEnumerable<long>
{
public static readonly long[] Value=A186514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186514.Bytes);
public long this[int i]=>Value[i];

public static A186514Inst Instance=new A186514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186515
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,70L,72L,73L,75L,76L,78L,79L,81L,82L,83L,85L,86L,88L,89L,91L,92L,94L,95L,96L,98L,99L,101L,102L,104L,105L,107L,108L,109L,111L,112L,114L,115L,117L,118L,120L,121L,123L,124L,125L,127L,128L,130L,131L,133L,134L,136L,137L,138L,140L,141L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186515Inst : IEnumerable<long>
{
public static readonly long[] Value=A186515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186515.Bytes);
public long this[int i]=>Value[i];

public static A186515Inst Instance=new A186515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186516
{
public static readonly long[] Value={ 3L,6L,9L,13L,16L,19L,22L,25L,29L,32L,35L,38L,42L,45L,48L,51L,55L,58L,61L,64L,67L,71L,74L,77L,80L,84L,87L,90L,93L,97L,100L,103L,106L,110L,113L,116L,119L,122L,126L,129L,132L,135L,139L,142L,145L,148L,152L,155L,158L,161L,165L,168L,171L,174L,177L,181L,184L,187L,190L,194L,197L,200L,203L,207L,210L,213L,216L,220L,223L,226L,229L,233L,236L,239L,242L,245L,249L,252L,255L,258L,262L,265L,268L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186516Inst : IEnumerable<long>
{
public static readonly long[] Value=A186516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186516.Bytes);
public long this[int i]=>Value[i];

public static A186516Inst Instance=new A186516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186517
{
public static readonly long[] Value={ 0L,1L,1L,3L,8L,34L,201L,2000L,53397L,10435175L,49476809194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186517Inst : IEnumerable<long>
{
public static readonly long[] Value=A186517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186517.Bytes);
public long this[int i]=>Value[i];

public static A186517Inst Instance=new A186517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186518
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186518Inst : IEnumerable<long>
{
public static readonly long[] Value=A186518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186518.Bytes);
public long this[int i]=>Value[i];

public static A186518Inst Instance=new A186518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186519
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,3L,3L,4L,5L,4L,4L,8L,5L,7L,8L,7L,10L,10L,7L,12L,9L,12L,6L,12L,12L,10L,16L,14L,13L,12L,15L,13L,18L,17L,13L,19L,14L,16L,16L,16L,19L,19L,20L,19L,17L,23L,15L,21L,28L,20L,18L,22L,24L,22L,21L,26L,27L,23L,22L,29L,33L,21L,32L,31L,33L,32L,27L,39L,27L,31L,29L,33L,33L,32L,41L,35L,27L,45L,28L,37L,40L,28L,36L,35L,41L,30L,33L,40L,45L,42L,32L,41L,42L,39L,45L,38L,44L,48L,44L,46L,49L,48L,56L,45L,51L,50L,49L,44L,51L,50L,46L,45L,58L,53L,42L,45L,52L,50L,62L,51L,55L,50L,56L,52L,62L,52L,60L,53L,68L,53L,57L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186519Inst : IEnumerable<long>
{
public static readonly long[] Value=A186519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186519.Bytes);
public long this[int i]=>Value[i];

public static A186519Inst Instance=new A186519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186520
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,4L,1L,1L,2L,4L,3L,5L,10L,2L,1L,1L,2L,4L,3L,5L,10L,2L,4L,7L,12L,2L,16L,47L,6L,22L,1L,1L,2L,4L,3L,5L,10L,10L,4L,6L,12L,2L,18L,2L,4L,10L,5L,7L,17L,2L,19L,55L,6L,28L,22L,49L,120L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186520Inst : IEnumerable<long>
{
public static readonly long[] Value=A186520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186520.Bytes);
public long this[int i]=>Value[i];

public static A186520Inst Instance=new A186520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186521
{
public static readonly long[] Value={ 1L,3L,6L,7L,49L,578L,793L,1322L,1392L,2392L,3066L,13479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186521Inst : IEnumerable<long>
{
public static readonly long[] Value=A186521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186521.Bytes);
public long this[int i]=>Value[i];

public static A186521Inst Instance=new A186521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186522
{
public static readonly long[] Value={ 3L,7L,5L,31L,7L,127L,17L,73L,11L,23L,13L,8191L,43L,31L,17L,131071L,19L,524287L,41L,127L,23L,47L,241L,601L,2731L,262657L,29L,233L,31L,2147483647L,257L,599479L,43691L,71L,37L,223L,174763L,79L,41L,13367L,43L,431L,89L,631L,47L,2351L,97L,4432676798593L,251L,103L,53L,6361L,87211L,881L,113L,32377L,59L,179951L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186522Inst : IEnumerable<long>
{
public static readonly long[] Value=A186522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186522.Bytes);
public long this[int i]=>Value[i];

public static A186522Inst Instance=new A186522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186523
{
public static readonly long[] Value={ 2L,6L,14L,34L,82L,206L,526L,1378L,3674L,9950L,27278L,75514L,210634L,591054L,1666406L,4716186L,13389434L,38113462L,108737894L,310851770L,890244546L,2553782246L,7337143110L,21110531858L,60823037522L,175471424214L,506862346750L,1465875933394L,4244315841666L,12302751068958L,35699515448510L,103697897085458L,301514033677482L,877521633678990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186523Inst : IEnumerable<long>
{
public static readonly long[] Value=A186523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186523.Bytes);
public long this[int i]=>Value[i];

public static A186523Inst Instance=new A186523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186556
{
public static readonly BigInteger[] Value={ 60074L,13360840L,2976803436L,663296784123L,147795682647630L,32931888185295104L,7337893459883784628L,BigInteger.Parse("1635031754050410331405"),BigInteger.Parse("364318292831600934919531"),BigInteger.Parse("81177517366244082982029095") };
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
public class A186556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186556Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186556.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186556Inst Instance=new A186556Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186557
{
public static readonly BigInteger[] Value={ 927477L,783375343L,663296784123L,561714653720250L,475681559860717916L,BigInteger.Parse("402827283017904807331"),BigInteger.Parse("341131017852900112413067"),BigInteger.Parse("288884064380556803805427879"),BigInteger.Parse("244639147969972250796140260427") };
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
public class A186557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186557Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186557.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186557.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186557Inst Instance=new A186557Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186558
{
public static readonly long[] Value={ 256L,3891L,3891L,60074L,227890L,60074L,927477L,13360840L,13360840L,927477L,14319230L,783375343L,2976803436L,783375343L,14319230L,221073168L,45931015744L,663296784123L,663296784123L,45931015744L,221073168L,3413126694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186558Inst : IEnumerable<long>
{
public static readonly long[] Value=A186558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186558.Bytes);
public long this[int i]=>Value[i];

public static A186558Inst Instance=new A186558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186559
{
public static readonly long[] Value={ 19683L,173L,1399L,8983L,21007L,29935L,47719L,82783L,168391L,441199L,1129591L,2679679L,6669991L,15566383L,34790167L,83037151L,194778055L,446546575L,1070609527L,2528845759L,5841194023L,13884206959L,32712096727L,75846181663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186559Inst : IEnumerable<long>
{
public static readonly long[] Value=A186559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186559.Bytes);
public long this[int i]=>Value[i];

public static A186559Inst Instance=new A186559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186560
{
public static readonly long[] Value={ 19683L,721L,2917L,6594L,12122L,20056L,29303L,35198L,53611L,85029L,121783L,199305L,321297L,465750L,728568L,1143162L,1676187L,2600987L,4073323L,6071427L,9378717L,14610267L,21959403L,33776511L,52386811L,79228491L,121620695L,188062383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186560Inst : IEnumerable<long>
{
public static readonly long[] Value=A186560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186560.Bytes);
public long this[int i]=>Value[i];

public static A186560Inst Instance=new A186560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186561
{
public static readonly long[] Value={ 721L,173L,401L,1411L,2617L,3379L,4033L,4795L,6361L,10443L,17153L,26995L,43177L,66139L,98497L,151699L,231881L,350539L,543249L,835843L,1270105L,1958875L,3007777L,4577331L,7041321L,10810763L,16490033L,25335715L,38890105L,59403259L,91177217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186561Inst : IEnumerable<long>
{
public static readonly long[] Value=A186561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186561.Bytes);
public long this[int i]=>Value[i];

public static A186561Inst Instance=new A186561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186562
{
public static readonly long[] Value={ 2917L,401L,1399L,3421L,4807L,5605L,6511L,8029L,11647L,19237L,31623L,49805L,77743L,118309L,177703L,271789L,415903L,634037L,977431L,1502013L,2293423L,3523525L,5404231L,8254861L,12669663L,19434837L,29722679L,45599069L,69937615L,107022757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186562Inst : IEnumerable<long>
{
public static readonly long[] Value=A186562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186562.Bytes);
public long this[int i]=>Value[i];

public static A186562Inst Instance=new A186562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186563
{
public static readonly long[] Value={ 6594L,1411L,3421L,8983L,11557L,12895L,14845L,18415L,25381L,40279L,63565L,102591L,161381L,244087L,372205L,569647L,861493L,1322215L,2039165L,3110335L,4775493L,7347991L,11212621L,17186671L,26409301L,40358535L,61856925L,94997471L,145320485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186563Inst : IEnumerable<long>
{
public static readonly long[] Value=A186563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186563.Bytes);
public long this[int i]=>Value[i];

public static A186563Inst Instance=new A186563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186564
{
public static readonly long[] Value={ 12122L,2617L,4807L,11557L,21007L,23389L,27391L,33445L,44263L,68269L,104335L,154693L,256359L,394253L,582367L,921109L,1404439L,2088925L,3277999L,5032037L,7564615L,11783853L,18099679L,27341557L,42334903L,65029501L,98641359L,152194629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186564Inst : IEnumerable<long>
{
public static readonly long[] Value=A186564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186564.Bytes);
public long this[int i]=>Value[i];

public static A186564Inst Instance=new A186564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186565
{
public static readonly long[] Value={ 20056L,3379L,5605L,12895L,23389L,29935L,36133L,44887L,60493L,91519L,137701L,205879L,317293L,498159L,754229L,1158823L,1794685L,2717311L,4159813L,6426583L,9779021L,14980399L,23102037L,35240263L,53961373L,83056543L,126889765L,194291511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186565Inst : IEnumerable<long>
{
public static readonly long[] Value=A186565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186565.Bytes);
public long this[int i]=>Value[i];

public static A186565Inst Instance=new A186565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186566
{
public static readonly long[] Value={ 29303L,4033L,6511L,14845L,27391L,36133L,47719L,60973L,82447L,122725L,185863L,278125L,425791L,645685L,993687L,1533053L,2343151L,3593989L,5522887L,8433037L,12920671L,19843157L,30348343L,46510173L,71399503L,109274533L,167438119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186566Inst : IEnumerable<long>
{
public static readonly long[] Value=A186566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186566.Bytes);
public long this[int i]=>Value[i];

public static A186566Inst Instance=new A186566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186567
{
public static readonly long[] Value={ 35198L,4795L,8029L,18415L,33445L,44887L,60973L,82783L,112357L,168727L,255085L,381007L,587317L,891271L,1333501L,2082015L,3198533L,4843447L,7513549L,11527567L,17482837L,26985511L,41409053L,63004927L,97035813L,148936471L,227092333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186567Inst : IEnumerable<long>
{
public static readonly long[] Value=A186567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186567.Bytes);
public long this[int i]=>Value[i];

public static A186567Inst Instance=new A186567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186568
{
public static readonly long[] Value={ 19683L,721L,721L,2917L,173L,2917L,6594L,401L,401L,6594L,12122L,1411L,1399L,1411L,12122L,20056L,2617L,3421L,3421L,2617L,20056L,29303L,3379L,4807L,8983L,4807L,3379L,29303L,35198L,4033L,5605L,11557L,11557L,5605L,4033L,35198L,53611L,4795L,6511L,12895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186568Inst : IEnumerable<long>
{
public static readonly long[] Value=A186568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186568.Bytes);
public long this[int i]=>Value[i];

public static A186568Inst Instance=new A186568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186569
{
public static readonly long[] Value={ 10077696L,1441L,64794L,1831246L,5762806L,7092466L,10131226L,18983086L,52102546L,250276606L,1023882766L,3333167026L,13883727886L,48468351346L,146915043406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186569Inst : IEnumerable<long>
{
public static readonly long[] Value=A186569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186569.Bytes);
public long this[int i]=>Value[i];

public static A186569Inst Instance=new A186569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186570
{
public static readonly long[] Value={ 10077696L,12828L,12828L,299556L,1441L,299556L,741024L,5545L,5545L,741024L,2309831L,65919L,64794L,65919L,2309831L,4364050L,155193L,242568L,242568L,155193L,4364050L,6628076L,203371L,355246L,1831246L,355246L,203371L,6628076L,7396218L,229951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186570Inst : IEnumerable<long>
{
public static readonly long[] Value=A186570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186570.Bytes);
public long this[int i]=>Value[i];

public static A186570Inst Instance=new A186570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186571
{
public static readonly long[] Value={ 40353607L,2295L,155811L,6144163L,20145619L,24109915L,33341515L,63091963L,185353627L,1030573051L,4642181947L,16031111611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186571Inst : IEnumerable<long>
{
public static readonly long[] Value=A186571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186571.Bytes);
public long this[int i]=>Value[i];

public static A186571Inst Instance=new A186571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186620
{
public static readonly long[] Value={ 12L,25L,37L,62L,99L,161L,260L,421L,681L,1102L,1783L,2885L,4668L,7553L,12221L,19774L,31995L,51769L,83764L,135533L,219297L,354830L,574127L,928957L,1503084L,2432041L,3935125L,6367166L,10302291L,16669457L,26971748L,43641205L,70612953L,114254158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186620Inst : IEnumerable<long>
{
public static readonly long[] Value=A186620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186620.Bytes);
public long this[int i]=>Value[i];

public static A186620Inst Instance=new A186620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186621
{
public static readonly long[] Value={ 3L,5L,8L,9L,13L,14L,20L,21L,24L,25L,32L,33L,34L,37L,38L,45L,48L,50L,54L,56L,57L,61L,64L,68L,73L,76L,81L,84L,85L,86L,90L,92L,93L,94L,105L,110L,114L,117L,118L,120L,121L,122L,128L,132L,133L,140L,141L,142L,144L,145L,154L,157L,158L,160L,165L,168L,176L,177L,182L,184L,186L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186621Inst : IEnumerable<long>
{
public static readonly long[] Value=A186621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186621.Bytes);
public long this[int i]=>Value[i];

public static A186621Inst Instance=new A186621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186622
{
public static readonly long[] Value={ 19683L,317115L,5109075L,82312875L,1033357725L,12972796635L,162860787181L,1762332055974L,19070362665396L,206362206802584L,2024796890931192L,19867021743214296L,194932417524520248L,1785642965511020136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186622Inst : IEnumerable<long>
{
public static readonly long[] Value=A186622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186622.Bytes);
public long this[int i]=>Value[i];

public static A186622Inst Instance=new A186622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186623
{
public static readonly BigInteger[] Value={ 317115L,9957573L,313250283L,9626194591L,205142945972L,4375747771546L,93024904363336L,1542711926710876L,25595116082268286L,424415611230113963L,5897079175874583945L,BigInteger.Parse("81949864725872441631"),BigInteger.Parse("1138621686844736898393") };
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
public class A186623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186623.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186623Inst Instance=new A186623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186624
{
public static readonly long[] Value={ 5109075L,313250283L,19192412328L,1114156913743L,40638068592052L,1479413089672909L,53067946949076948L,1364942987805378749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186624Inst : IEnumerable<long>
{
public static readonly long[] Value=A186624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186624.Bytes);
public long this[int i]=>Value[i];

public static A186624Inst Instance=new A186624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186625
{
public static readonly long[] Value={ 19683L,317115L,317115L,5109075L,9957573L,5109075L,82312875L,313250283L,313250283L,82312875L,1033357725L,9626194591L,19192412328L,9626194591L,1033357725L,12972796635L,205142945972L,1114156913743L,1114156913743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186625Inst : IEnumerable<long>
{
public static readonly long[] Value=A186625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186625.Bytes);
public long this[int i]=>Value[i];

public static A186625Inst Instance=new A186625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186626
{
public static readonly BigInteger[] Value={ 262144L,9576448L,349839616L,12780078472L,351107784608L,9646003088512L,265005162695168L,6097375527142592L,140291562401607848L,3227900658811424387L,BigInteger.Parse("65768960528937396632"),BigInteger.Parse("1340052444690066421952"),BigInteger.Parse("27303769743019178665472") };
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
public class A186626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186626.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186626Inst Instance=new A186626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186627
{
public static readonly BigInteger[] Value={ 9576448L,876951552L,80485522400L,7188107084815L,422905697694540L,24906342705832823L,1460201980801808620L,BigInteger.Parse("63739557332176142137"),BigInteger.Parse("2783635995639584526500"),BigInteger.Parse("121426165183353517129064") };
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
public class A186627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186627Inst Instance=new A186627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186628
{
public static readonly long[] Value={ 349839616L,80485522400L,18496850510312L,3990816642970118L,507626088316719132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186628Inst : IEnumerable<long>
{
public static readonly long[] Value=A186628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186628.Bytes);
public long this[int i]=>Value[i];

public static A186628Inst Instance=new A186628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186629
{
public static readonly long[] Value={ 262144L,9576448L,9576448L,349839616L,876951552L,349839616L,12780078472L,80485522400L,80485522400L,12780078472L,351107784608L,7188107084815L,18496850510312L,7188107084815L,351107784608L,9646003088512L,422905697694540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186629Inst : IEnumerable<long>
{
public static readonly long[] Value=A186629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186629.Bytes);
public long this[int i]=>Value[i];

public static A186629Inst Instance=new A186629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186630
{
public static readonly long[] Value={ 1L,2L,10L,12L,30L,48L,373L,580L,619L,718L,1592L,2928L,3076L,4741L,9198L,14020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186630Inst : IEnumerable<long>
{
public static readonly long[] Value=A186630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186630.Bytes);
public long this[int i]=>Value[i];

public static A186630Inst Instance=new A186630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186631
{
public static readonly long[] Value={ 1L,2L,5L,3L,8L,1L,5L,4L,8L,0L,6L,4L,2L,8L,9L,1L,6L,8L,6L,6L,9L,6L,3L,7L,0L,9L,3L,1L,1L,4L,3L,8L,7L,4L,7L,9L,9L,8L,6L,9L,9L,3L,4L,3L,3L,8L,3L,8L,6L,9L,5L,2L,1L,1L,4L,7L,1L,2L,7L,7L,9L,6L,8L,4L,1L,8L,0L,5L,0L,6L,9L,5L,8L,5L,0L,7L,7L,8L,5L,0L,5L,4L,7L,6L,5L,8L,5L,5L,1L,7L,2L,5L,8L,9L,7L,3L,7L,0L,9L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186631Inst : IEnumerable<long>
{
public static readonly long[] Value=A186631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186631.Bytes);
public long this[int i]=>Value[i];

public static A186631Inst Instance=new A186631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186632
{
public static readonly BigInteger[] Value={ 1L,2L,24L,588L,22560L,1201320L,82875744L,7085373456L,727827579648L,87810122446560L,12227912455651200L,1938610503725962176L,BigInteger.Parse("346053263639068417536"),BigInteger.Parse("68919212804888587849344") };
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
public class A186632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186632.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186632Inst Instance=new A186632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186633
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,71L,705L,8470L,127284L,2231342L,45505041L,1048341387L,27059612615L,771505041184L,24109351520196L,818862556900962L,30044548635160841L,1184027932446520895L,BigInteger.Parse("49883835880381353808"),BigInteger.Parse("2237276988838875420087") };
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
public class A186633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186633Inst Instance=new A186633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186634
{
public static readonly long[] Value={ 0L,2L,0L,2L,6L,0L,4L,6L,0L,2L,6L,8L,0L,2L,6L,8L,12L,0L,4L,6L,10L,12L,0L,4L,6L,10L,12L,16L,0L,2L,6L,8L,12L,18L,20L,0L,2L,8L,12L,14L,18L,20L,0L,2L,6L,8L,12L,18L,20L,26L,0L,2L,6L,12L,14L,20L,24L,26L,0L,6L,8L,14L,18L,20L,24L,26L,0L,2L,6L,8L,12L,18L,20L,26L,30L,0L,2L,6L,12L,14L,20L,24L,26L,30L,0L,4L,6L,10L,16L,18L,24L,28L,30L,0L,4L,10L,12L,18L,22L,24L,28L,30L,0L,2L,6L,8L,12L,18L,20L,26L,30L,32L,0L,2L,6L,12L,14L,20L,24L,26L,30L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186634Inst : IEnumerable<long>
{
public static readonly long[] Value=A186634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186634.Bytes);
public long this[int i]=>Value[i];

public static A186634Inst Instance=new A186634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186635
{
public static readonly long[] Value={ 2L,3L,5L,31L,37L,41L,43L,53L,67L,71L,79L,83L,107L,151L,163L,173L,191L,199L,227L,239L,271L,277L,283L,307L,311L,317L,347L,359L,397L,431L,439L,443L,467L,479L,523L,547L,563L,587L,599L,613L,631L,643L,683L,719L,733L,751L,757L,773L,787L,797L,827L,839L,853L,883L,907L,911L,919L,947L,991L,1013L,1031L,1039L,1093L,1123L,1151L,1163L,1187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186635Inst : IEnumerable<long>
{
public static readonly long[] Value=A186635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186635.Bytes);
public long this[int i]=>Value[i];

public static A186635Inst Instance=new A186635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186684
{
public static readonly long[] Value={ 0L,1L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186684Inst : IEnumerable<long>
{
public static readonly long[] Value=A186684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186684.Bytes);
public long this[int i]=>Value[i];

public static A186684Inst Instance=new A186684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186685
{
public static readonly long[] Value={ 0L,1L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186685Inst : IEnumerable<long>
{
public static readonly long[] Value=A186685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186685.Bytes);
public long this[int i]=>Value[i];

public static A186685Inst Instance=new A186685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186686
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,10L,6L,1L,3L,20L,21L,8L,1L,1L,31L,56L,36L,10L,1L,0L,38L,120L,120L,55L,12L,1L,0L,38L,213L,322L,220L,78L,14L,1L,0L,30L,321L,724L,705L,364L,105L,16L,1L,0L,17L,414L,1400L,1897L,1353L,560L,136L,18L,1L,0L,6L,456L,2364L,4410L,4218L,2366L,816L,171L,20L,1L,0L,1L,427L,3515L,9020L,11374L,8365L,3860L,1140L,210L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186686Inst : IEnumerable<long>
{
public static readonly long[] Value=A186686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186686.Bytes);
public long this[int i]=>Value[i];

public static A186686Inst Instance=new A186686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186687
{
public static readonly ulong[] Value={ 2L,17L,41L,107L,251L,647L,761L,1511L,23327L,27431L,139967L,3145721L,30233087L,35551871L,6530347007L,39182082047L,91424858111L,146766805631L,6847552083566591L,153558654482644991L,246511875008397311L,14215144014964850687UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186687Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A186687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186687.Bytes);
public ulong this[int i]=>Value[i];

public static A186687Inst Instance=new A186687Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186688
{
public static readonly long[] Value={ 82L,626L,2402L,4097L,10001L,14642L,20737L,28562L,38417L,83522L,104977L,194482L,234257L,279842L,456977L,707282L,810001L,1048577L,1500626L,1679617L,2085137L,2313442L,2560001L,3111697L,6250001L,7311617L,10556002L,11316497L,13845842L,14776337L,17850626L,21381377L,25411682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186688Inst : IEnumerable<long>
{
public static readonly long[] Value=A186688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186688.Bytes);
public long this[int i]=>Value[i];

public static A186688Inst Instance=new A186688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186689
{
public static readonly long[] Value={ 3L,5L,7L,8L,10L,11L,12L,13L,14L,17L,18L,21L,22L,23L,26L,29L,30L,32L,35L,36L,38L,39L,40L,42L,50L,52L,57L,58L,61L,62L,65L,68L,71L,72L,73L,78L,81L,84L,86L,92L,94L,98L,100L,102L,103L,105L,108L,112L,113L,114L,115L,116L,119L,120L,122L,124L,128L,129L,130L,138L,146L,148L,152L,153L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186689Inst : IEnumerable<long>
{
public static readonly long[] Value=A186689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186689.Bytes);
public long this[int i]=>Value[i];

public static A186689Inst Instance=new A186689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186690
{
public static readonly long[] Value={ 1L,-2L,4L,-4L,6L,-8L,8L,-8L,13L,-12L,12L,-16L,14L,-16L,24L,-16L,18L,-26L,20L,-24L,32L,-24L,24L,-32L,31L,-28L,40L,-32L,30L,-48L,32L,-32L,48L,-36L,48L,-52L,38L,-40L,56L,-48L,42L,-64L,44L,-48L,78L,-48L,48L,-64L,57L,-62L,72L,-56L,54L,-80L,72L,-64L,80L,-60L,60L,-96L,62L,-64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186690Inst : IEnumerable<long>
{
public static readonly long[] Value=A186690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186690.Bytes);
public long this[int i]=>Value[i];

public static A186690Inst Instance=new A186690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186691
{
public static readonly long[] Value={ 1L,5L,8L,5L,0L,0L,3L,6L,7L,2L,4L,8L,0L,3L,6L,8L,7L,3L,6L,6L,3L,6L,9L,9L,1L,1L,7L,3L,6L,5L,6L,5L,8L,9L,3L,4L,4L,3L,4L,1L,4L,1L,4L,7L,5L,4L,0L,2L,5L,3L,0L,7L,9L,1L,9L,9L,0L,7L,3L,8L,4L,7L,1L,5L,2L,0L,5L,6L,6L,9L,3L,5L,3L,6L,4L,9L,0L,0L,3L,2L,5L,6L,9L,3L,6L,2L,8L,2L,6L,4L,4L,0L,0L,2L,5L,3L,1L,0L,6L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186691Inst : IEnumerable<long>
{
public static readonly long[] Value=A186691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186691.Bytes);
public long this[int i]=>Value[i];

public static A186691Inst Instance=new A186691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186692
{
public static readonly long[] Value={ 2L,5L,1L,3L,4L,7L,9L,7L,9L,9L,7L,2L,2L,7L,3L,0L,8L,8L,9L,2L,6L,6L,8L,8L,5L,6L,2L,6L,1L,4L,0L,2L,0L,0L,9L,6L,6L,4L,0L,6L,2L,5L,8L,2L,0L,9L,7L,1L,2L,7L,8L,2L,5L,5L,0L,5L,5L,7L,1L,0L,5L,0L,8L,2L,9L,0L,1L,3L,1L,1L,6L,7L,3L,3L,3L,6L,0L,2L,1L,4L,3L,8L,4L,5L,6L,2L,2L,3L,4L,6L,0L,5L,6L,4L,9L,2L,9L,4L,0L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186692Inst : IEnumerable<long>
{
public static readonly long[] Value=A186692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186692.Bytes);
public long this[int i]=>Value[i];

public static A186692Inst Instance=new A186692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186693
{
public static readonly long[] Value={ 3L,1L,4L,4L,5L,6L,8L,3L,7L,3L,1L,0L,9L,4L,6L,7L,5L,9L,2L,1L,3L,7L,8L,6L,2L,6L,3L,2L,9L,0L,9L,4L,0L,8L,7L,6L,9L,6L,9L,3L,8L,8L,4L,3L,0L,5L,4L,5L,6L,8L,3L,8L,5L,5L,8L,7L,7L,1L,6L,7L,3L,6L,8L,9L,2L,8L,5L,3L,6L,8L,1L,6L,5L,5L,1L,4L,1L,5L,4L,5L,6L,7L,8L,6L,3L,7L,0L,8L,0L,9L,8L,0L,0L,3L,5L,8L,6L,0L,5L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186693Inst : IEnumerable<long>
{
public static readonly long[] Value=A186693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186693.Bytes);
public long this[int i]=>Value[i];

public static A186693Inst Instance=new A186693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186694
{
public static readonly long[] Value={ 212159L,294001L,505447L,584141L,595631L,604171L,872897L,971767L,1062599L,1203623L,1282529L,1293671L,1524181L,1566691L,1702357L,1830661L,2017963L,2474431L,2690201L,3085553L,3326489L,3716213L,3964169L,4103917L,4134953L,4173921L,4310617L,4376703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186694Inst : IEnumerable<long>
{
public static readonly long[] Value=A186694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186694.Bytes);
public long this[int i]=>Value[i];

public static A186694Inst Instance=new A186694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186695
{
public static readonly long[] Value={ 1L,1L,3L,1L,12L,15L,1L,39L,135L,105L,1L,120L,870L,1680L,945L,1L,363L,4950L,17850L,23625L,10395L,1L,1092L,26565L,159600L,373275L,374220L,135135L,1L,3279L,138285L,1303155L,4795875L,8222445L,6621615L,2027025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186695Inst : IEnumerable<long>
{
public static readonly long[] Value=A186695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186695.Bytes);
public long this[int i]=>Value[i];

public static A186695Inst Instance=new A186695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186696
{
public static readonly long[] Value={ 5L,6L,16L,23L,33L,35L,51L,55L,63L,91L,103L,121L,138L,178L,195L,216L,233L,243L,268L,348L,385L,436L,510L,511L,518L,588L,628L,675L,693L,696L,710L,723L,741L,751L,773L,810L,818L,863L,913L,930L,973L,975L,1025L,1035L,1036L,1045L,1070L,1071L,1115L,1161L,1260L,1273L,1311L,1336L,1365L,1368L,1386L,1438L,1441L,1448L,1490L,1501L,1508L,1521L,1540L,1546L,1623L,1651L,1655L,1720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186696Inst : IEnumerable<long>
{
public static readonly long[] Value=A186696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186696.Bytes);
public long this[int i]=>Value[i];

public static A186696Inst Instance=new A186696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186697
{
public static readonly long[] Value={ 3L,5L,8L,8L,13L,21L,21L,21L,34L,34L,34L,55L,55L,55L,55L,55L,89L,89L,89L,89L,89L,89L,89L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,233L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,377L,610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186697Inst : IEnumerable<long>
{
public static readonly long[] Value=A186697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186697.Bytes);
public long this[int i]=>Value[i];

public static A186697Inst Instance=new A186697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186698
{
public static readonly long[] Value={ 2L,3L,5L,5L,7L,7L,11L,11L,11L,13L,23L,37L,47L,59L,67L,79L,89L,101L,103L,113L,127L,137L,149L,157L,163L,173L,191L,193L,211L,223L,223L,233L,251L,257L,263L,277L,283L,293L,307L,317L,331L,337L,347L,359L,367L,379L,389L,397L,409L,419L,431L,439L,449L,457L,467L,479L,487L,499L,509L,521L,541L,541L,547L,557L,569L,577L,587L,599L,607L,617L,631L,641L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186698Inst : IEnumerable<long>
{
public static readonly long[] Value=A186698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186698.Bytes);
public long this[int i]=>Value[i];

public static A186698Inst Instance=new A186698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186699
{
public static readonly long[] Value={ 1L,2L,4L,9L,11L,16L,23L,24L,25L,26L,33L,36L,47L,49L,50L,52L,59L,64L,73L,74L,81L,88L,96L,97L,100L,107L,121L,122L,144L,146L,148L,169L,177L,184L,191L,193L,194L,196L,218L,225L,239L,241L,242L,244L,249L,256L,276L,289L,292L,297L,299L,311L,312L,313L,324L,337L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186699Inst : IEnumerable<long>
{
public static readonly long[] Value=A186699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186699.Bytes);
public long this[int i]=>Value[i];

public static A186699Inst Instance=new A186699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186748
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,3L,0L,13L,0L,155L,0L,4337L,0L,266362L,0L,20807688L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186748Inst : IEnumerable<long>
{
public static readonly long[] Value=A186748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186748.Bytes);
public long this[int i]=>Value[i];

public static A186748Inst Instance=new A186748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186749
{
public static readonly long[] Value={ 2L,2L,2L,4L,2L,6L,2L,6L,2L,6L,2L,10L,2L,10L,4L,10L,2L,8L,2L,8L,4L,8L,2L,18L,4L,16L,4L,18L,2L,20L,2L,18L,8L,12L,6L,18L,2L,22L,6L,18L,2L,20L,2L,18L,8L,18L,2L,24L,4L,20L,10L,30L,2L,24L,6L,24L,8L,20L,2L,46L,2L,24L,8L,24L,8L,42L,2L,24L,12L,42L,2L,32L,2L,40L,18L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186749Inst : IEnumerable<long>
{
public static readonly long[] Value=A186749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186749.Bytes);
public long this[int i]=>Value[i];

public static A186749Inst Instance=new A186749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186750
{
public static readonly BigInteger[] Value={ 3L,6L,33L,1086L,1179393L,1390967848446L,BigInteger.Parse("1934791555410494424614913"),BigInteger.Parse("3743418362887760317407541271559358491868341997566") };
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
public class A186750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186750Inst Instance=new A186750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186751
{
public static readonly BigInteger[] Value={ 3L,5L,21L,437L,190965L,36467631221L,BigInteger.Parse("1329888126870853950837"),BigInteger.Parse("1768602429992068534155014726612412013000565") };
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
public class A186751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186751Inst Instance=new A186751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186752
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,13L,19L,26L,34L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186752Inst : IEnumerable<long>
{
public static readonly long[] Value=A186752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186752.Bytes);
public long this[int i]=>Value[i];

public static A186752Inst Instance=new A186752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186753
{
public static readonly long[] Value={ 1L,2L,2L,3L,8L,3L,4L,20L,20L,4L,5L,40L,76L,40L,5L,6L,70L,216L,216L,70L,6L,7L,112L,511L,832L,511L,112L,7L,8L,168L,1064L,2568L,2568L,1064L,168L,8L,9L,240L,2016L,6768L,10036L,6768L,2016L,240L,9L,10L,330L,3552L,15840L,32680L,32680L,15840L,3552L,330L,10L,11L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186753Inst : IEnumerable<long>
{
public static readonly long[] Value=A186753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186753.Bytes);
public long this[int i]=>Value[i];

public static A186753Inst Instance=new A186753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186754
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,3L,1L,5L,5L,7L,6L,1L,23L,36L,25L,25L,10L,1L,129L,234L,166L,110L,65L,15L,1L,894L,1597L,1316L,686L,385L,140L,21L,1L,7202L,12459L,10893L,5754L,2611L,1106L,266L,28L,1L,65085L,111451L,97287L,54559L,22428L,8841L,2730L,462L,36L,1L,651263L,1116277L,963121L,554670L,229405L,80871L,26397L,6000L,750L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186754Inst : IEnumerable<long>
{
public static readonly long[] Value=A186754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186754.Bytes);
public long this[int i]=>Value[i];

public static A186754Inst Instance=new A186754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186755
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1L,5L,23L,129L,894L,7202L,65085L,651263L,7161713L,85922825L,1116946192L,15637356864L,234562319757L,3753007054781L,63801128569995L,1148420035784849L,21819978138955622L,436399552962252082L,9164390639379582121L,BigInteger.Parse("201616594791853840063") };
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
public class A186755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186755Inst Instance=new A186755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186756
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,15L,9L,52L,68L,203L,507L,10L,877L,3918L,245L,4140L,32057L,4123L,21147L,280700L,60753L,280L,115975L,2645611L,853914L,13300L,678570L,26917867L,11923428L,396935L,4213597L,295934526L,169127222L,9710855L,15400L,27644437L,3513447546L,2469452843L,215274774L,1201200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186756Inst : IEnumerable<long>
{
public static readonly long[] Value=A186756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186756.Bytes);
public long this[int i]=>Value[i];

public static A186756Inst Instance=new A186756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186757
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,10L,11L,3L,59L,36L,25L,363L,212L,130L,15L,2491L,1688L,651L,210L,19661L,14317L,4487L,1750L,105L,176536L,129076L,42435L,12628L,2205L,1767540L,1277159L,451626L,104755L,26775L,945L,19460671L,13974236L,5068723L,1120570L,264880L,27720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186757Inst : IEnumerable<long>
{
public static readonly long[] Value=A186757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186757.Bytes);
public long this[int i]=>Value[i];

public static A186757Inst Instance=new A186757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186758
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,10L,59L,363L,2491L,19661L,176536L,1767540L,19460671L,233578585L,3036411429L,42507793209L,637606959466L,10201702712738L,173429224591607L,3121728583605435L,59312852905363623L,1186257030934984061L,BigInteger.Parse("24911396924131631880"),BigInteger.Parse("548050726738352726108") };
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
public class A186758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186758Inst Instance=new A186758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186759
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,4L,0L,1L,4L,9L,10L,0L,1L,11L,53L,35L,20L,0L,1L,41L,280L,268L,95L,35L,0L,1L,162L,1804L,1904L,903L,210L,56L,0L,1L,715L,12971L,15727L,8008L,2408L,406L,84L,0L,1L,3425L,104600L,142533L,80323L,25662L,5502L,714L,120L,0L,1L,17722L,936370L,1418444L,871575L,303385L,68712L,11256L,1170L,165L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186759Inst : IEnumerable<long>
{
public static readonly long[] Value=A186759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186759.Bytes);
public long this[int i]=>Value[i];

public static A186759Inst Instance=new A186759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186760
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,33L,188L,1247L,9448L,80623L,765926L,8022139L,91872328L,1142384735L,15330003154L,220847064955L,3399884265524L,55705822616383L,967921774366510L,17778279366693179L,344189681672898400L,7005438733866799999L,BigInteger.Parse("149547115419379439978"),BigInteger.Parse("3341127481398057119515") };
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
public class A186760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186760Inst Instance=new A186760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186761
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,4L,0L,1L,9L,4L,10L,0L,1L,33L,56L,10L,20L,0L,1L,235L,218L,211L,20L,35L,0L,1L,1517L,1982L,833L,616L,35L,56L,0L,1L,12593L,14040L,9612L,2408L,1526L,56L,84L,0L,1L,111465L,134248L,72588L,35176L,5838L,3360L,84L,120L,0L,1L,1122819L,1305126L,797461L,276120L,107710L,12516L,6762L,120L,165L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186761Inst : IEnumerable<long>
{
public static readonly long[] Value=A186761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186761.Bytes);
public long this[int i]=>Value[i];

public static A186761Inst Instance=new A186761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186762
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1L,9L,33L,235L,1517L,12593L,111465L,1122819L,12313409L,147949593L,1922353925L,26918452691L,403744456541L,6460109224801L,109820584161393L,1976779056442179L,37558742545087481L,751175283283221129L,15774677696321630525UL,BigInteger.Parse("347042934659313999539"),BigInteger.Parse("7981987292809647817237") };
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
public class A186762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186762Inst Instance=new A186762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186763
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,28L,141L,846L,5923L,47384L,426457L,4264570L,46910271L,562923252L,7318002277L,102452031878L,1536780478171L,24588487650736L,418004290062513L,7524077221125234L,142957467201379447L,2859149344027588940L,BigInteger.Parse("60042136224579367741") };
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
public class A186763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186763Inst Instance=new A186763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186812
{
public static readonly long[] Value={ 1L,1L,3L,8L,21L,53L,135L,346L,886L,2266L,5796L,14828L,37935L,97047L,248269L,635134L,1624833L,4156729L,10633949L,27204296L,69595384L,178042372L,455476844L,1165223500L,2980932677L,7625970145L,19509135875L,49909241100L,127680301337L,326638093273L,835621805859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186812Inst : IEnumerable<long>
{
public static readonly long[] Value=A186812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186812.Bytes);
public long this[int i]=>Value[i];

public static A186812Inst Instance=new A186812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186813
{
public static readonly long[] Value={ 0L,1L,3L,3L,2L,5L,9L,7L,4L,9L,15L,11L,6L,13L,21L,15L,8L,17L,27L,19L,10L,21L,33L,23L,12L,25L,39L,27L,14L,29L,45L,31L,16L,33L,51L,35L,18L,37L,57L,39L,20L,41L,63L,43L,22L,45L,69L,47L,24L,49L,75L,51L,26L,53L,81L,55L,28L,57L,87L,59L,30L,61L,93L,63L,32L,65L,99L,67L,34L,69L,105L,71L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186813Inst : IEnumerable<long>
{
public static readonly long[] Value=A186813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186813.Bytes);
public long this[int i]=>Value[i];

public static A186813Inst Instance=new A186813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186814
{
public static readonly long[] Value={ 1L,3L,9L,5L,25L,23L,7L,39L,19L,21L,53L,81L,43L,83L,63L,61L,101L,13L,143L,31L,169L,15L,55L,113L,225L,105L,157L,175L,17L,263L,89L,41L,77L,269L,165L,159L,271L,361L,123L,363L,75L,315L,239L,365L,93L,51L,437L,321L,397L,529L,439L,351L,543L,229L,333L,355L,449L,557L,625L,431L,517L,27L,583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186814Inst : IEnumerable<long>
{
public static readonly long[] Value=A186814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186814.Bytes);
public long this[int i]=>Value[i];

public static A186814Inst Instance=new A186814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186815
{
public static readonly long[] Value={ 9L,21L,27L,39L,51L,69L,81L,87L,99L,117L,129L,147L,153L,171L,177L,183L,207L,219L,249L,261L,309L,333L,351L,363L,387L,393L,399L,429L,441L,447L,459L,471L,477L,483L,519L,537L,561L,597L,609L,621L,633L,639L,651L,663L,687L,711L,717L,723L,741L,753L,777L,807L,849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186815Inst : IEnumerable<long>
{
public static readonly long[] Value=A186815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186815.Bytes);
public long this[int i]=>Value[i];

public static A186815Inst Instance=new A186815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186816
{
public static readonly long[] Value={ 126L,3988L,222632L,24581099L,5634207241L,2438542117645L,2065963672906699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186816Inst : IEnumerable<long>
{
public static readonly long[] Value=A186816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186816.Bytes);
public long this[int i]=>Value[i];

public static A186816Inst Instance=new A186816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186817
{
public static readonly long[] Value={ 126L,606L,2904L,14229L,70767L,351549L,1750896L,8730234L,43522407L,217032372L,1082345247L,5397586308L,26918218566L,134243793585L,669486128850L,3338798653422L,16650942997338L,83040015704427L,414129463721703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186817Inst : IEnumerable<long>
{
public static readonly long[] Value=A186817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186817.Bytes);
public long this[int i]=>Value[i];

public static A186817Inst Instance=new A186817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186818
{
public static readonly long[] Value={ 606L,3988L,25808L,173121L,1190637L,8178097L,56422648L,390661554L,2704080467L,18732156320L,129837515003L,899875661504L,6237831734078L,43243690039607L,299782052613422L,2078270386909730L,14408014447228498L,99886103229478687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186818Inst : IEnumerable<long>
{
public static readonly long[] Value=A186818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186818.Bytes);
public long this[int i]=>Value[i];

public static A186818Inst Instance=new A186818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186819
{
public static readonly long[] Value={ 2904L,25808L,222632L,2009622L,18829218L,175882357L,1653336285L,15639380661L,147826932337L,1399067559974L,13257222778967L,125596828357521L,1190237476340344L,11282323553231805L,106939751216903914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186819Inst : IEnumerable<long>
{
public static readonly long[] Value=A186819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186819.Bytes);
public long this[int i]=>Value[i];

public static A186819Inst Instance=new A186819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186820
{
public static readonly long[] Value={ 14229L,173121L,2009622L,24581099L,315843055L,4037185979L,52016332522L,676967599202L,8797063846281L,114525000303377L,1494214340595378L,19486159712805501L,254239381610119789L,3318768935260629498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186820Inst : IEnumerable<long>
{
public static readonly long[] Value=A186820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186820.Bytes);
public long this[int i]=>Value[i];

public static A186820Inst Instance=new A186820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186821
{
public static readonly BigInteger[] Value={ 70767L,1190637L,18829218L,315843055L,5634207241L,99751773733L,1783799078413L,32322581577916L,584495537657334L,10594536209194545L,192625016377623752L,3500057158418808686L,BigInteger.Parse("63637200466766220870"),BigInteger.Parse("1157907423273867982529") };
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
public class A186821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186821Inst Instance=new A186821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186822
{
public static readonly BigInteger[] Value={ 351549L,8178097L,175882357L,4037185979L,99751773733L,2438542117645L,60308324623150L,1516683374850488L,38032276571587138L,956441493166746722L,BigInteger.Parse("24150737847734062271"),BigInteger.Parse("609282424290159593345"),BigInteger.Parse("15383449942709902209325") };
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
public class A186822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A186822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186822Inst Instance=new A186822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186823
{
public static readonly long[] Value={ 1750896L,56422648L,1653336285L,52016332522L,1783799078413L,60308324623150L,2065963672906699L,72230087740874585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186823Inst : IEnumerable<long>
{
public static readonly long[] Value=A186823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186823.Bytes);
public long this[int i]=>Value[i];

public static A186823Inst Instance=new A186823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186824
{
public static readonly long[] Value={ 8730234L,390661554L,15639380661L,676967599202L,32322581577916L,1516683374850488L,72230087740874585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186824Inst : IEnumerable<long>
{
public static readonly long[] Value=A186824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186824.Bytes);
public long this[int i]=>Value[i];

public static A186824Inst Instance=new A186824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186825
{
public static readonly long[] Value={ 126L,606L,606L,2904L,3988L,2904L,14229L,25808L,25808L,14229L,70767L,173121L,222632L,173121L,70767L,351549L,1190637L,2009622L,2009622L,1190637L,351549L,1750896L,8178097L,18829218L,24581099L,18829218L,8178097L,1750896L,8730234L,56422648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186825Inst : IEnumerable<long>
{
public static readonly long[] Value=A186825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186825.Bytes);
public long this[int i]=>Value[i];

public static A186825Inst Instance=new A186825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186826
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,11L,11L,5L,1L,45L,45L,23L,7L,1L,197L,197L,107L,39L,9L,1L,903L,903L,509L,205L,59L,11L,1L,4279L,4279L,2473L,1061L,347L,83L,13L,1L,20793L,20793L,12235L,5483L,1949L,541L,111L,15L,1L,103049L,103049L,61463L,28435L,10717L,3285L,795L,143L,17L,1L,518859L,518859L,312761L,148249L,58351L,19199L,5197L,1117L,179L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186826Inst : IEnumerable<long>
{
public static readonly long[] Value=A186826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186826.Bytes);
public long this[int i]=>Value[i];

public static A186826Inst Instance=new A186826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186827
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-3L,1L,0L,4L,-5L,1L,0L,-4L,12L,-7L,1L,0L,4L,-20L,24L,-9L,1L,0L,-4L,28L,-56L,40L,-11L,1L,0L,4L,-36L,104L,-120L,60L,-13L,1L,0L,-4L,44L,-168L,280L,-220L,84L,-15L,1L,0L,4L,-52L,248L,-552L,620L,-364L,112L,-17L,1L,0L,-4L,60L,-344L,968L,-1452L,1204L,-560L,144L,-19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186827Inst : IEnumerable<long>
{
public static readonly long[] Value=A186827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186827.Bytes);
public long this[int i]=>Value[i];

public static A186827Inst Instance=new A186827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186892
{
public static readonly long[] Value={ 1L,25L,55L,65L,77L,91L,95L,115L,121L,125L,133L,143L,145L,161L,169L,175L,185L,203L,205L,209L,215L,235L,245L,247L,253L,265L,289L,295L,299L,301L,305L,319L,323L,329L,335L,343L,361L,377L,391L,395L,407L,415L,425L,427L,445L,451L,469L,473L,475L,485L,493L,505L,515L,517L,529L,533L,539L,545L,551L,559L,575L,581L,583L,623L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186892Inst : IEnumerable<long>
{
public static readonly long[] Value=A186892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186892.Bytes);
public long this[int i]=>Value[i];

public static A186892Inst Instance=new A186892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186893
{
public static readonly long[] Value={ 1L,3L,7L,11L,31L,59L,127L,251L,377L,433L,1019L,1969L,2047L,3449L,4091L,8191L,11327L,15737L,16379L,32689L,36737L,64889L,65531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186893Inst : IEnumerable<long>
{
public static readonly long[] Value=A186893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186893.Bytes);
public long this[int i]=>Value[i];

public static A186893Inst Instance=new A186893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186894
{
public static readonly long[] Value={ 0L,148L,444L,5401L,39372L,703983L,14050512L,523902288L,17552393136L,1009883277293L,82740925046288L,10723440611064915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186894Inst : IEnumerable<long>
{
public static readonly long[] Value=A186894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186894.Bytes);
public long this[int i]=>Value[i];

public static A186894Inst Instance=new A186894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186895
{
public static readonly long[] Value={ 30L,148L,140L,406L,1246L,3106L,7240L,19040L,49004L,124974L,318420L,814714L,2080852L,5324036L,13622742L,34838372L,89070962L,227812618L,582742964L,1490551186L,3812248194L,9750367192L,24938804546L,63787545162L,163151712528L,417295494174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186895Inst : IEnumerable<long>
{
public static readonly long[] Value=A186895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186895.Bytes);
public long this[int i]=>Value[i];

public static A186895Inst Instance=new A186895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186896
{
public static readonly long[] Value={ 76L,140L,444L,1692L,3948L,13894L,35270L,122820L,328174L,1091770L,2989514L,9789230L,27386704L,88043136L,249821778L,792963658L,2277817920L,7153114096L,20739269674L,64581466696L,188672537578L,583564854384L,1715136004208L,5276315756596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186896Inst : IEnumerable<long>
{
public static readonly long[] Value=A186896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186896.Bytes);
public long this[int i]=>Value[i];

public static A186896Inst Instance=new A186896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186897
{
public static readonly long[] Value={ 234L,406L,1692L,5401L,14437L,49303L,171877L,608194L,1974583L,6828851L,23697904L,82511604L,280821141L,969113166L,3356595204L,11627225657L,40028089405L,138218574688L,478039503452L,1653233404522L,5707628406749L,19717537044734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186897Inst : IEnumerable<long>
{
public static readonly long[] Value=A186897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186897.Bytes);
public long this[int i]=>Value[i];

public static A186897Inst Instance=new A186897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186898
{
public static readonly long[] Value={ 632L,1246L,3948L,14437L,39372L,158437L,554824L,2203303L,7843906L,30466049L,113590802L,441081353L,1649380080L,6378340507L,24111571374L,93224628427L,352830579988L,1361940600445L,5170282798940L,19947364408573L,75793555364736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186898Inst : IEnumerable<long>
{
public static readonly long[] Value=A186898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186898.Bytes);
public long this[int i]=>Value[i];

public static A186898Inst Instance=new A186898Inst();

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