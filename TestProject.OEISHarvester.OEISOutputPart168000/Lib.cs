using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198457
{
public static readonly long[] Value={ 3L,6L,7L,4L,4L,6L,5L,16L,17L,6L,10L,12L,7L,8L,11L,7L,30L,31L,8L,18L,20L,9L,14L,17L,9L,48L,49L,10L,12L,16L,10L,28L,30L,11L,70L,71L,12L,18L,22L,12L,40L,42L,13L,16L,21L,13L,30L,33L,13L,96L,97L,14L,25L,29L,14L,54L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198457Inst : IEnumerable<long>
{
public static readonly long[] Value=A198457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198457.Bytes);
public long this[int i]=>Value[i];

public static A198457Inst Instance=new A198457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198458
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,7L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,18L,18L,18L,19L,19L,19L,20L,20L,21L,21L,21L,22L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,27L,27L,27L,28L,28L,28L,28L,28L,29L,30L,30L,30L,30L,30L,30L,31L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198458Inst : IEnumerable<long>
{
public static readonly long[] Value=A198458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198458.Bytes);
public long this[int i]=>Value[i];

public static A198458Inst Instance=new A198458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198459
{
public static readonly long[] Value={ 6L,4L,16L,10L,8L,30L,18L,14L,48L,12L,28L,70L,18L,40L,16L,30L,96L,25L,54L,22L,40L,126L,20L,33L,70L,160L,26L,42L,88L,24L,64L,198L,52L,108L,30L,78L,240L,28L,40L,63L,130L,54L,286L,34L,48L,75L,154L,32L,64L,110L,336L,88L,180L,38L,128L,390L,28L,36L,66L,102L,208L,448L,33L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198459Inst : IEnumerable<long>
{
public static readonly long[] Value=A198459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198459.Bytes);
public long this[int i]=>Value[i];

public static A198459Inst Instance=new A198459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198460
{
public static readonly long[] Value={ 7L,6L,17L,12L,11L,31L,20L,17L,49L,16L,30L,71L,22L,42L,21L,33L,97L,29L,56L,27L,43L,127L,26L,37L,72L,161L,32L,46L,90L,31L,67L,199L,56L,110L,37L,81L,241L,36L,46L,67L,132L,59L,287L,42L,54L,79L,156L,41L,69L,113L,337L,92L,182L,47L,131L,391L,40L,46L,72L,106L,210L,449L,45L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198460Inst : IEnumerable<long>
{
public static readonly long[] Value=A198460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198460.Bytes);
public long this[int i]=>Value[i];

public static A198460Inst Instance=new A198460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198461
{
public static readonly long[] Value={ 2L,3L,4L,3L,7L,8L,4L,12L,13L,5L,18L,19L,6L,6L,9L,6L,11L,13L,6L,25L,26L,7L,15L,17L,7L,33L,34L,8L,42L,43L,9L,10L,14L,9L,15L,18L,9L,52L,53L,10L,30L,32L,10L,63L,64L,11L,36L,38L,11L,75L,76L,12L,14L,19L,12L,19L,23L,12L,27L,30L,12L,88L,89L,13L,102L,103L,14L,57L,59L,14L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198461Inst : IEnumerable<long>
{
public static readonly long[] Value=A198461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198461.Bytes);
public long this[int i]=>Value[i];

public static A198461Inst Instance=new A198461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198462
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,6L,6L,7L,7L,8L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,14L,14L,15L,15L,15L,15L,15L,16L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,27L,27L,27L,27L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198462Inst : IEnumerable<long>
{
public static readonly long[] Value=A198462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198462.Bytes);
public long this[int i]=>Value[i];

public static A198462Inst Instance=new A198462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198463
{
public static readonly long[] Value={ 3L,7L,12L,18L,6L,11L,25L,15L,33L,42L,10L,15L,52L,30L,63L,36L,75L,14L,19L,27L,88L,102L,75L,117L,18L,23L,42L,65L,133L,150L,30L,39L,168L,22L,27L,60L,92L,187L,102L,207L,42L,54L,228L,22L,26L,31L,81L,250L,51L,135L,273L,147L,297L,30L,35L,105L,322L,45L,66L,84L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198463Inst : IEnumerable<long>
{
public static readonly long[] Value=A198463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198463.Bytes);
public long this[int i]=>Value[i];

public static A198463Inst Instance=new A198463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198464
{
public static readonly long[] Value={ 4L,8L,13L,19L,9L,13L,26L,17L,34L,43L,14L,18L,53L,32L,64L,38L,76L,19L,23L,30L,89L,103L,59L,118L,24L,28L,42L,67L,134L,151L,35L,43L,169L,29L,33L,63L,94L,188L,104L,208L,47L,58L,229L,31L,34L,38L,84L,251L,56L,137L,274L,149L,298L,39L,43L,108L,323L,52L,71L,88L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198464Inst : IEnumerable<long>
{
public static readonly long[] Value=A198464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198464.Bytes);
public long this[int i]=>Value[i];

public static A198464Inst Instance=new A198464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198465
{
public static readonly long[] Value={ 3L,3L,4L,4L,6L,7L,5L,10L,11L,6L,7L,9L,6L,15L,16L,7L,10L,12L,7L,21L,22L,8L,28L,29L,9L,11L,14L,9L,36L,37L,10L,14L,17L,10L,22L,24L,10L,45L,46L,11L,27L,29L,11L,55L,56L,12L,15L,19L,12L,21L,24L,12L,66L,67L,13L,18L,22L,13L,25L,28L,13L,78L,79L,14L,45L,47L,14L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198465Inst : IEnumerable<long>
{
public static readonly long[] Value=A198465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198465.Bytes);
public long this[int i]=>Value[i];

public static A198465Inst Instance=new A198465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198466
{
public static readonly long[] Value={ 3L,4L,5L,6L,6L,7L,7L,8L,9L,9L,10L,10L,10L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,22L,22L,23L,23L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L,27L,27L,27L,27L,28L,28L,28L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198466Inst : IEnumerable<long>
{
public static readonly long[] Value=A198466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198466.Bytes);
public long this[int i]=>Value[i];

public static A198466Inst Instance=new A198466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198467
{
public static readonly long[] Value={ 3L,6L,10L,7L,15L,10L,21L,28L,11L,36L,14L,22L,45L,27L,55L,15L,21L,66L,18L,25L,78L,45L,91L,15L,19L,34L,52L,105L,22L,39L,120L,136L,23L,50L,76L,153L,26L,56L,85L,171L,36L,46L,190L,27L,40L,51L,69L,210L,30L,36L,76L,115L,231L,126L,253L,31L,91L,276L,34L,58L,99L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198467Inst : IEnumerable<long>
{
public static readonly long[] Value=A198467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198467.Bytes);
public long this[int i]=>Value[i];

public static A198467Inst Instance=new A198467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198468
{
public static readonly long[] Value={ 4L,7L,11L,9L,16L,12L,22L,29L,14L,37L,17L,24L,46L,29L,56L,19L,24L,67L,22L,28L,79L,47L,92L,21L,24L,37L,54L,106L,27L,42L,121L,137L,29L,53L,78L,154L,32L,59L,87L,172L,41L,50L,191L,34L,45L,55L,72L,211L,37L,42L,79L,117L,232L,128L,254L,39L,94L,277L,42L,63L,102L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198468Inst : IEnumerable<long>
{
public static readonly long[] Value=A198468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198468.Bytes);
public long this[int i]=>Value[i];

public static A198468Inst Instance=new A198468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198469
{
public static readonly long[] Value={ 1129L,113L,139L,139L,23L,47L,7L,7L,37L,67L,67L,37L,127L,3L,3L,5L,41L,11L,17L,5L,5L,5L,29L,71L,11L,101L,2L,2L,2L,101L,107L,2L,2L,71L,71L,191L,191L,227L,239L,281L,2L,197L,227L,107L,29L,569L,281L,821L,599L,1031L,521L,641L,659L,1229L,569L,1061L,1481L,2657L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198469Inst : IEnumerable<long>
{
public static readonly long[] Value=A198469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198469.Bytes);
public long this[int i]=>Value[i];

public static A198469Inst Instance=new A198469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198470
{
public static readonly long[] Value={ 12L,18L,24L,36L,40L,48L,54L,56L,60L,72L,80L,84L,96L,100L,108L,112L,120L,126L,132L,140L,144L,156L,160L,162L,168L,176L,180L,192L,196L,198L,200L,204L,208L,216L,224L,228L,234L,240L,252L,264L,270L,276L,280L,288L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198470Inst : IEnumerable<long>
{
public static readonly long[] Value=A198470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198470.Bytes);
public long this[int i]=>Value[i];

public static A198470Inst Instance=new A198470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198471
{
public static readonly long[] Value={ 20L,30L,42L,66L,70L,78L,88L,102L,104L,114L,138L,150L,174L,246L,258L,260L,272L,282L,294L,304L,308L,318L,330L,340L,354L,364L,366L,368L,380L,390L,402L,426L,438L,450L,460L,462L,464L,474L,476L,498L,510L,532L,534L,546L,550L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198471Inst : IEnumerable<long>
{
public static readonly long[] Value=A198471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198471.Bytes);
public long this[int i]=>Value[i];

public static A198471Inst Instance=new A198471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198472
{
public static readonly long[] Value={ 2L,2L,2L,6L,6L,4L,4L,6L,6L,8L,6L,18L,8L,18L,8L,18L,18L,10L,10L,12L,12L,14L,12L,30L,14L,30L,14L,30L,30L,16L,16L,18L,18L,20L,18L,42L,20L,42L,20L,42L,42L,54L,24L,24L,28L,54L,24L,28L,30L,54L,28L,32L,54L,28L,28L,30L,30L,32L,30L,66L,32L,66L,32L,66L,66L,78L,36L,36L,40L,78L,36L,40L,42L,78L,40L,44L,78L,40L,40L,42L,42L,44L,42L,90L,44L,90L,44L,90L,90L,52L,48L,48L,50L,50L,48L,52L,50L,54L,50L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198472Inst : IEnumerable<long>
{
public static readonly long[] Value=A198472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198472.Bytes);
public long this[int i]=>Value[i];

public static A198472Inst Instance=new A198472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198473
{
public static readonly long[] Value={ 0L,1L,4L,2L,8L,3L,12L,5L,16L,6L,20L,7L,24L,9L,28L,10L,32L,11L,36L,13L,40L,14L,44L,15L,48L,17L,52L,18L,56L,19L,60L,21L,64L,22L,68L,23L,72L,25L,76L,26L,80L,27L,84L,29L,88L,30L,92L,31L,96L,33L,100L,34L,104L,35L,108L,37L,112L,38L,116L,39L,120L,41L,124L,42L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198473Inst : IEnumerable<long>
{
public static readonly long[] Value=A198473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198473.Bytes);
public long this[int i]=>Value[i];

public static A198473Inst Instance=new A198473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198474
{
public static readonly long[] Value={ 2L,12L,76L,492L,3212L,21036L,137932L,904812L,5936396L,38950572L,255572812L,1676946156L,11003350412L,72199015212L,473737530316L,3108453529452L,20396281280012L,133831275048876L,878140974959692L,5761968373855212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198474Inst : IEnumerable<long>
{
public static readonly long[] Value=A198474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198474.Bytes);
public long this[int i]=>Value[i];

public static A198474Inst Instance=new A198474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198475
{
public static readonly BigInteger[] Value={ 12L,252L,6104L,153222L,3935188L,101884208L,2646874462L,68861880812L,1792520780552L,46671361129270L,1215282911633348L,31646146096635168L,824083171352362894L,BigInteger.Parse("21459718004443762012"),BigInteger.Parse("558827923845866912376") };
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
public class A198475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198475Inst Instance=new A198475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198476
{
public static readonly BigInteger[] Value={ 76L,6104L,636636L,72691500L,8603604942L,1033040477928L,124663962280912L,15071363660899808L,1823268135974847902L,BigInteger.Parse("220624354578524466374"),BigInteger.Parse("26698969327372019396108"),BigInteger.Parse("3231092587816932360442484") };
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
public class A198476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198476Inst Instance=new A198476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198477
{
public static readonly long[] Value={ 2L,12L,12L,76L,252L,76L,492L,6104L,6104L,492L,3212L,153222L,636636L,153222L,3212L,21036L,3935188L,72691500L,72691500L,3935188L,21036L,137932L,101884208L,8603604942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198477Inst : IEnumerable<long>
{
public static readonly long[] Value=A198477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198477.Bytes);
public long this[int i]=>Value[i];

public static A198477Inst Instance=new A198477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198478
{
public static readonly BigInteger[] Value={ 0L,9L,41472L,14348907L,1719926784L,115330078125L,5355700839936L,193010051319183L,5777633090469888L,150094635296999121L,3486784401000000000L,BigInteger.Parse("73994897046174912819"),BigInteger.Parse("1457274373159131021312"),BigInteger.Parse("26955214582765006137717") };
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
public class A198478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198478Inst Instance=new A198478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198479
{
public static readonly BigInteger[] Value={ 0L,10L,102400L,59049000L,10485760000L,976562500000L,60466176000000L,2824752490000000L,107374182400000000L,3486784401000000000L,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("2593742460100000000000"),BigInteger.Parse("61917364224000000000000") };
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
public class A198479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198479Inst Instance=new A198479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198480
{
public static readonly long[] Value={ 1L,13L,97L,685L,4801L,33613L,235297L,1647085L,11529601L,80707213L,564950497L,3954653485L,27682574401L,193778020813L,1356446145697L,9495123019885L,66465861139201L,465261027974413L,3256827195820897L,22797790370746285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198480Inst : IEnumerable<long>
{
public static readonly long[] Value=A198480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198480.Bytes);
public long this[int i]=>Value[i];

public static A198480Inst Instance=new A198480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198481
{
public static readonly BigInteger[] Value={ 1L,1L,240L,304819200L,3440500260470784000L,BigInteger.Parse("1827912356210202139164672000000000"),BigInteger.Parse("13482302715547740229948201750717130814259200000000000") };
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
public class A198481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198481Inst Instance=new A198481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198482
{
public static readonly BigInteger[] Value={ 5L,193L,10072L,528283L,27711478L,1453628917L,76251331828L,3999827976463L,209814352850962L,11005988987858473L,577328442763429648L,BigInteger.Parse("30284250801208664707"),BigInteger.Parse("1588585939401430092718"),BigInteger.Parse("83330616412779323165533") };
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
public class A198482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198482Inst Instance=new A198482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198483
{
public static readonly BigInteger[] Value={ 193L,333308L,579476701L,1007486056500L,1751630302786777L,3045410673315147020L,BigInteger.Parse("5294796602205290417269"),BigInteger.Parse("9205612663330831095993732"),BigInteger.Parse("16005016032539421751657150321"),BigInteger.Parse("27826560552805542982631002720412") };
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
public class A198483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198483Inst Instance=new A198483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198484
{
public static readonly BigInteger[] Value={ 10072L,579476701L,33408897045776L,1926147852876420067L,BigInteger.Parse("111049673372896355573468"),BigInteger.Parse("6402431748862885892818595024"),BigInteger.Parse("369124294364655578368535852718606") };
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
public class A198484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198484Inst Instance=new A198484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198485
{
public static readonly long[] Value={ 5L,193L,193L,10072L,333308L,10072L,528283L,579476701L,579476701L,528283L,27711478L,1007486056500L,33408897045776L,1007486056500L,27711478L,1453628917L,1751630302786777L,1926147852876420067L,1926147852876420067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198485Inst : IEnumerable<long>
{
public static readonly long[] Value=A198485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198485.Bytes);
public long this[int i]=>Value[i];

public static A198485Inst Instance=new A198485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198486
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,90L,909L,9090L,90909L,909090L,9090909L,90909090L,909090909L,9090909090L,90909090909L,909090909090L,9090909090909L,90909090909090L,909090909090909L,9090909090909090L,90909090909090909L,909090909090909090L,9090909090909090909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198486Inst : IEnumerable<long>
{
public static readonly long[] Value=A198486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198486.Bytes);
public long this[int i]=>Value[i];

public static A198486Inst Instance=new A198486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198487
{
public static readonly long[] Value={ 10L,1L,12L,1113L,4L,15L,6L,117L,8L,9L,25L,0L,26L,0L,27L,35L,28L,0L,36L,0L,45L,371L,0L,0L,38L,55L,0L,39L,74L,0L,56L,0L,48L,0L,0L,57L,49L,0L,0L,0L,58L,0L,76L,0L,0L,95L,0L,0L,68L,77L,255L,0L,0L,0L,69L,0L,78L,0L,0L,0L,256L,0L,0L,791L,88L,0L,0L,0L,0L,0L,275L,0L,98L,0L,0L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198487Inst : IEnumerable<long>
{
public static readonly long[] Value=A198487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198487.Bytes);
public long this[int i]=>Value[i];

public static A198487Inst Instance=new A198487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198488
{
public static readonly long[] Value={ 3L,0L,7L,9L,9L,7L,4L,1L,1L,6L,2L,9L,0L,7L,1L,9L,2L,4L,5L,5L,0L,9L,4L,4L,7L,2L,2L,0L,6L,3L,0L,7L,5L,7L,7L,7L,9L,4L,7L,6L,5L,6L,1L,2L,8L,7L,8L,9L,9L,9L,1L,7L,8L,6L,8L,6L,6L,4L,9L,5L,1L,7L,7L,6L,0L,4L,0L,8L,2L,0L,0L,2L,8L,6L,4L,0L,0L,4L,4L,8L,8L,0L,7L,9L,2L,0L,3L,3L,2L,6L,8L,1L,8L,6L,1L,9L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198488Inst : IEnumerable<long>
{
public static readonly long[] Value=A198488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198488.Bytes);
public long this[int i]=>Value[i];

public static A198488Inst Instance=new A198488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198489
{
public static readonly long[] Value={ 3L,8L,3L,3L,5L,6L,1L,0L,0L,7L,1L,6L,8L,5L,7L,4L,4L,2L,3L,4L,0L,1L,4L,9L,4L,5L,3L,0L,5L,7L,9L,9L,0L,1L,8L,0L,4L,6L,6L,2L,9L,2L,2L,3L,5L,5L,2L,6L,1L,7L,2L,0L,8L,3L,6L,9L,0L,2L,7L,5L,3L,7L,6L,9L,7L,2L,3L,2L,0L,7L,1L,8L,8L,8L,5L,5L,0L,9L,3L,0L,8L,5L,0L,4L,1L,7L,2L,0L,8L,1L,5L,8L,8L,8L,2L,4L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198489Inst : IEnumerable<long>
{
public static readonly long[] Value=A198489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198489.Bytes);
public long this[int i]=>Value[i];

public static A198489Inst Instance=new A198489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198490
{
public static readonly long[] Value={ 3L,7L,0L,9L,8L,6L,6L,6L,1L,0L,0L,6L,7L,4L,9L,7L,1L,9L,4L,1L,9L,4L,4L,7L,5L,1L,0L,1L,4L,5L,7L,3L,2L,6L,6L,6L,7L,5L,3L,5L,9L,3L,4L,5L,0L,0L,7L,3L,8L,4L,9L,0L,0L,3L,6L,1L,7L,3L,8L,0L,4L,5L,2L,9L,5L,0L,7L,2L,9L,5L,9L,4L,0L,4L,7L,2L,4L,1L,2L,2L,8L,0L,1L,9L,6L,5L,0L,2L,9L,8L,9L,5L,7L,0L,9L,2L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198490Inst : IEnumerable<long>
{
public static readonly long[] Value=A198490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198490.Bytes);
public long this[int i]=>Value[i];

public static A198490Inst Instance=new A198490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198491
{
public static readonly long[] Value={ 3L,6L,1L,9L,0L,6L,8L,6L,3L,6L,5L,5L,6L,5L,2L,9L,7L,6L,8L,4L,8L,5L,0L,6L,2L,0L,4L,1L,7L,6L,8L,8L,5L,0L,4L,6L,3L,2L,1L,7L,7L,2L,9L,7L,7L,6L,3L,5L,8L,8L,0L,1L,2L,4L,5L,1L,8L,8L,0L,5L,1L,1L,2L,4L,6L,9L,6L,8L,5L,7L,8L,5L,6L,3L,3L,7L,9L,4L,6L,4L,8L,8L,6L,4L,0L,2L,3L,5L,5L,6L,8L,8L,7L,2L,8L,9L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198491Inst : IEnumerable<long>
{
public static readonly long[] Value=A198491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198491.Bytes);
public long this[int i]=>Value[i];

public static A198491Inst Instance=new A198491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198492
{
public static readonly long[] Value={ 3L,5L,5L,1L,3L,1L,5L,4L,5L,6L,0L,0L,1L,2L,4L,3L,7L,1L,0L,2L,4L,7L,4L,5L,6L,6L,3L,1L,9L,6L,2L,5L,4L,3L,4L,7L,6L,9L,6L,0L,3L,5L,8L,1L,4L,9L,8L,0L,6L,5L,4L,1L,4L,3L,1L,5L,7L,0L,1L,7L,3L,6L,5L,0L,4L,5L,9L,7L,3L,0L,4L,8L,6L,7L,1L,5L,3L,6L,3L,7L,9L,8L,3L,6L,7L,9L,7L,3L,3L,0L,2L,7L,5L,9L,3L,4L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198492Inst : IEnumerable<long>
{
public static readonly long[] Value=A198492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198492.Bytes);
public long this[int i]=>Value[i];

public static A198492Inst Instance=new A198492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198493
{
public static readonly long[] Value={ 4L,6L,4L,4L,3L,5L,6L,5L,7L,2L,3L,9L,4L,6L,6L,7L,6L,0L,6L,1L,6L,1L,4L,6L,8L,6L,6L,1L,1L,4L,3L,5L,3L,8L,7L,0L,6L,3L,1L,5L,4L,2L,8L,2L,3L,0L,9L,0L,5L,3L,3L,8L,4L,5L,3L,2L,9L,7L,7L,5L,5L,0L,4L,8L,7L,3L,8L,4L,4L,0L,4L,4L,1L,3L,2L,6L,4L,4L,5L,1L,3L,6L,3L,4L,6L,0L,3L,3L,1L,3L,5L,0L,0L,6L,3L,8L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198493Inst : IEnumerable<long>
{
public static readonly long[] Value=A198493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198493.Bytes);
public long this[int i]=>Value[i];

public static A198493Inst Instance=new A198493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198494
{
public static readonly long[] Value={ 8L,3L,2L,6L,0L,2L,2L,2L,1L,7L,6L,6L,6L,8L,9L,5L,5L,9L,5L,4L,1L,7L,0L,6L,5L,2L,0L,5L,9L,7L,9L,3L,4L,9L,7L,4L,0L,5L,6L,7L,1L,3L,1L,2L,5L,5L,3L,8L,7L,7L,4L,9L,7L,2L,1L,8L,6L,2L,5L,4L,5L,8L,6L,8L,8L,0L,9L,3L,6L,9L,0L,1L,6L,2L,4L,5L,2L,3L,1L,7L,9L,5L,6L,9L,8L,5L,6L,0L,4L,1L,6L,5L,2L,1L,2L,4L,9L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198494Inst : IEnumerable<long>
{
public static readonly long[] Value=A198494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198494.Bytes);
public long this[int i]=>Value[i];

public static A198494Inst Instance=new A198494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198495
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,1L,7L,4L,2L,4L,1L,8L,4L,5L,0L,0L,0L,9L,5L,3L,2L,1L,0L,1L,6L,8L,7L,5L,6L,3L,7L,5L,9L,2L,9L,9L,7L,8L,5L,4L,3L,8L,7L,0L,5L,2L,7L,8L,1L,4L,4L,4L,7L,5L,9L,2L,2L,8L,4L,4L,4L,0L,5L,7L,8L,4L,0L,2L,2L,2L,4L,7L,2L,5L,6L,5L,7L,9L,2L,9L,6L,1L,1L,1L,8L,2L,5L,1L,6L,4L,3L,8L,7L,2L,8L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198495Inst : IEnumerable<long>
{
public static readonly long[] Value=A198495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198495.Bytes);
public long this[int i]=>Value[i];

public static A198495Inst Instance=new A198495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198496
{
public static readonly long[] Value={ 5L,2L,2L,4L,3L,6L,6L,0L,9L,3L,9L,9L,3L,5L,1L,4L,3L,9L,8L,1L,5L,3L,5L,6L,9L,0L,7L,8L,8L,9L,5L,7L,8L,2L,9L,5L,6L,9L,9L,0L,5L,9L,3L,8L,8L,1L,2L,9L,6L,9L,2L,5L,8L,2L,6L,5L,6L,8L,2L,2L,8L,3L,1L,2L,2L,6L,7L,5L,9L,9L,7L,2L,1L,7L,4L,6L,6L,5L,4L,4L,8L,9L,2L,9L,0L,6L,1L,4L,1L,7L,1L,8L,6L,6L,4L,9L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198496Inst : IEnumerable<long>
{
public static readonly long[] Value=A198496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198496.Bytes);
public long this[int i]=>Value[i];

public static A198496Inst Instance=new A198496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198497
{
public static readonly long[] Value={ 4L,4L,9L,9L,0L,5L,8L,6L,5L,9L,7L,0L,4L,6L,5L,3L,8L,8L,5L,5L,4L,4L,2L,8L,7L,6L,4L,9L,2L,6L,2L,1L,7L,8L,7L,2L,2L,8L,8L,9L,0L,1L,8L,3L,2L,5L,7L,6L,1L,0L,0L,7L,1L,0L,1L,8L,3L,8L,8L,4L,0L,0L,8L,6L,8L,0L,4L,6L,4L,9L,5L,8L,6L,2L,3L,1L,9L,0L,3L,9L,7L,7L,1L,0L,2L,6L,1L,9L,2L,3L,4L,3L,6L,9L,6L,5L,8L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198497Inst : IEnumerable<long>
{
public static readonly long[] Value=A198497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198497.Bytes);
public long this[int i]=>Value[i];

public static A198497Inst Instance=new A198497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198498
{
public static readonly long[] Value={ 3L,2L,1L,8L,8L,0L,8L,9L,8L,7L,4L,2L,3L,6L,4L,2L,3L,9L,8L,6L,1L,8L,3L,3L,8L,4L,5L,3L,9L,4L,4L,7L,8L,4L,5L,2L,8L,3L,6L,6L,7L,9L,7L,7L,6L,7L,5L,0L,1L,1L,4L,2L,7L,1L,4L,3L,5L,1L,9L,1L,1L,2L,9L,3L,4L,6L,9L,1L,4L,8L,7L,1L,9L,1L,5L,2L,6L,7L,9L,1L,6L,3L,3L,1L,0L,6L,2L,4L,1L,3L,2L,0L,2L,7L,3L,6L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198498Inst : IEnumerable<long>
{
public static readonly long[] Value=A198498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198498.Bytes);
public long this[int i]=>Value[i];

public static A198498Inst Instance=new A198498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198499
{
public static readonly long[] Value={ 6L,0L,6L,4L,8L,1L,0L,5L,6L,5L,4L,6L,5L,5L,1L,7L,0L,0L,0L,6L,1L,5L,0L,5L,0L,8L,5L,3L,9L,8L,3L,0L,0L,8L,0L,7L,9L,7L,4L,5L,3L,7L,1L,9L,6L,7L,5L,4L,8L,0L,5L,9L,9L,4L,0L,1L,5L,2L,2L,0L,5L,8L,8L,2L,5L,1L,8L,6L,1L,8L,3L,7L,5L,1L,8L,3L,3L,7L,5L,0L,8L,2L,0L,8L,3L,2L,3L,8L,9L,4L,7L,2L,0L,2L,8L,3L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198499Inst : IEnumerable<long>
{
public static readonly long[] Value=A198499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198499.Bytes);
public long this[int i]=>Value[i];

public static A198499Inst Instance=new A198499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198500
{
public static readonly long[] Value={ 8L,4L,6L,4L,0L,5L,6L,9L,7L,8L,9L,3L,2L,0L,6L,0L,9L,9L,9L,9L,4L,7L,6L,7L,5L,2L,0L,6L,4L,2L,8L,4L,4L,6L,2L,8L,3L,1L,1L,4L,3L,3L,9L,1L,0L,4L,9L,5L,6L,8L,2L,1L,6L,0L,5L,9L,2L,3L,0L,9L,2L,0L,2L,3L,3L,9L,2L,2L,7L,2L,9L,0L,4L,7L,7L,9L,9L,0L,8L,2L,8L,3L,6L,7L,4L,6L,5L,6L,9L,3L,5L,7L,4L,0L,0L,6L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198500Inst : IEnumerable<long>
{
public static readonly long[] Value=A198500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198500.Bytes);
public long this[int i]=>Value[i];

public static A198500Inst Instance=new A198500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198501
{
public static readonly long[] Value={ 3L,2L,7L,4L,0L,9L,7L,7L,4L,2L,7L,7L,0L,3L,7L,5L,9L,2L,3L,3L,5L,6L,6L,4L,0L,8L,1L,0L,6L,2L,1L,0L,8L,2L,9L,2L,0L,9L,2L,6L,4L,1L,8L,9L,7L,5L,1L,2L,9L,1L,9L,2L,7L,4L,9L,4L,5L,7L,5L,1L,6L,6L,4L,8L,7L,2L,8L,9L,7L,7L,7L,6L,1L,2L,5L,5L,3L,7L,3L,1L,1L,3L,9L,4L,7L,6L,3L,0L,1L,8L,4L,0L,5L,1L,5L,1L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198501Inst : IEnumerable<long>
{
public static readonly long[] Value=A198501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198501.Bytes);
public long this[int i]=>Value[i];

public static A198501Inst Instance=new A198501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198502
{
public static readonly long[] Value={ 6L,2L,4L,2L,0L,9L,2L,8L,7L,0L,4L,8L,3L,2L,7L,5L,5L,8L,0L,0L,5L,9L,4L,1L,4L,5L,0L,4L,3L,9L,2L,0L,0L,8L,2L,8L,5L,7L,6L,6L,9L,3L,7L,0L,8L,3L,5L,4L,9L,8L,5L,7L,4L,5L,3L,2L,6L,6L,4L,6L,6L,2L,5L,1L,6L,3L,1L,3L,3L,3L,7L,2L,1L,0L,9L,4L,2L,8L,2L,2L,0L,8L,9L,1L,4L,0L,5L,8L,5L,0L,7L,6L,3L,7L,7L,5L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198502Inst : IEnumerable<long>
{
public static readonly long[] Value=A198502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198502.Bytes);
public long this[int i]=>Value[i];

public static A198502Inst Instance=new A198502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198503
{
public static readonly long[] Value={ 2L,4L,7L,4L,5L,6L,3L,5L,6L,7L,7L,0L,3L,8L,9L,8L,7L,2L,7L,3L,0L,3L,2L,8L,7L,7L,6L,3L,3L,7L,9L,9L,3L,7L,2L,5L,2L,6L,1L,6L,4L,9L,4L,0L,2L,8L,4L,0L,2L,1L,2L,8L,3L,8L,1L,5L,0L,3L,2L,6L,6L,1L,6L,9L,5L,3L,9L,4L,2L,8L,1L,2L,1L,8L,3L,3L,6L,6L,1L,7L,2L,0L,2L,0L,5L,9L,0L,5L,1L,2L,0L,2L,2L,1L,7L,6L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198503Inst : IEnumerable<long>
{
public static readonly long[] Value=A198503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198503.Bytes);
public long this[int i]=>Value[i];

public static A198503Inst Instance=new A198503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198504
{
public static readonly long[] Value={ 6L,9L,1L,6L,2L,1L,3L,6L,4L,6L,2L,5L,5L,8L,4L,5L,3L,2L,0L,0L,7L,1L,1L,6L,4L,0L,3L,1L,3L,7L,2L,6L,4L,0L,7L,3L,7L,9L,1L,5L,6L,4L,1L,1L,5L,9L,4L,9L,1L,0L,0L,0L,9L,7L,2L,7L,7L,7L,7L,6L,3L,5L,3L,5L,0L,5L,0L,2L,7L,9L,8L,7L,5L,4L,7L,0L,2L,8L,1L,8L,5L,5L,3L,9L,2L,9L,9L,5L,4L,8L,3L,1L,2L,7L,6L,6L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198504Inst : IEnumerable<long>
{
public static readonly long[] Value=A198504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198504.Bytes);
public long this[int i]=>Value[i];

public static A198504Inst Instance=new A198504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198505
{
public static readonly long[] Value={ 2L,4L,5L,0L,1L,2L,4L,0L,4L,2L,4L,6L,2L,6L,1L,5L,0L,1L,4L,0L,8L,2L,4L,5L,3L,0L,6L,8L,3L,6L,8L,1L,1L,1L,3L,4L,4L,4L,2L,8L,1L,5L,6L,5L,1L,3L,8L,6L,8L,0L,1L,2L,4L,2L,1L,1L,1L,7L,9L,6L,5L,5L,0L,9L,7L,9L,7L,6L,9L,6L,1L,0L,7L,0L,8L,2L,5L,0L,3L,5L,0L,0L,0L,3L,5L,8L,1L,9L,7L,3L,1L,8L,4L,6L,6L,4L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198505Inst : IEnumerable<long>
{
public static readonly long[] Value=A198505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198505.Bytes);
public long this[int i]=>Value[i];

public static A198505Inst Instance=new A198505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198506
{
public static readonly long[] Value={ 4L,7L,2L,4L,1L,2L,8L,9L,8L,9L,4L,8L,7L,9L,8L,3L,1L,8L,6L,3L,1L,2L,2L,3L,3L,0L,1L,8L,3L,4L,1L,4L,4L,5L,4L,7L,3L,0L,1L,4L,3L,6L,8L,6L,6L,2L,7L,4L,6L,8L,4L,8L,7L,8L,5L,3L,9L,2L,6L,5L,7L,8L,9L,5L,7L,0L,4L,4L,2L,7L,4L,8L,3L,7L,2L,8L,1L,4L,3L,9L,9L,8L,9L,2L,7L,6L,0L,9L,8L,2L,0L,8L,8L,8L,0L,1L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198506Inst : IEnumerable<long>
{
public static readonly long[] Value=A198506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198506.Bytes);
public long this[int i]=>Value[i];

public static A198506Inst Instance=new A198506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198507
{
public static readonly long[] Value={ 6L,7L,5L,6L,3L,6L,8L,7L,1L,4L,5L,7L,3L,4L,1L,3L,7L,5L,7L,8L,9L,6L,6L,0L,2L,1L,4L,1L,1L,9L,9L,9L,6L,1L,1L,7L,2L,9L,3L,5L,9L,9L,1L,6L,9L,5L,3L,8L,1L,6L,5L,8L,9L,0L,3L,9L,9L,9L,5L,4L,4L,6L,6L,0L,4L,1L,9L,9L,7L,8L,3L,5L,3L,8L,6L,5L,0L,5L,0L,7L,4L,6L,7L,2L,6L,3L,8L,2L,7L,1L,8L,9L,6L,6L,7L,5L,3L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198507Inst : IEnumerable<long>
{
public static readonly long[] Value=A198507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198507.Bytes);
public long this[int i]=>Value[i];

public static A198507Inst Instance=new A198507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198508
{
public static readonly BigInteger[] Value={ 4L,59L,1626L,52065L,1720080L,57202471L,1905005414L,63461666189L,2114248706396L,70438021997715L,2346711308830450L,78183030527210041L,2604746159812022824L,BigInteger.Parse("86779736758694997119"),BigInteger.Parse("2891154190334815424766"),BigInteger.Parse("96321709194421413316965") };
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
public class A198508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198508Inst Instance=new A198508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198509
{
public static readonly BigInteger[] Value={ 59L,4666L,308854L,23016128L,1768050096L,137433138206L,10767346425686L,846703466364788L,66715358024129644L,5262276771966640650L,BigInteger.Parse("415296502306889789762"),BigInteger.Parse("32784348340670740616160"),BigInteger.Parse("2588447317141729017555864") };
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
public class A198509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198509Inst Instance=new A198509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198510
{
public static readonly BigInteger[] Value={ 1626L,308854L,59007820L,13127875861L,3023133941944L,714429326523241L,171400320611391344L,BigInteger.Parse("41515521989152410680"),BigInteger.Parse("10116919781533608842706"),BigInteger.Parse("2474972835936834280715447") };
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
public class A198510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198510Inst Instance=new A198510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198511
{
public static readonly long[] Value={ 4L,59L,59L,1626L,4666L,1626L,52065L,308854L,308854L,52065L,1720080L,23016128L,59007820L,23016128L,1720080L,57202471L,1768050096L,13127875861L,13127875861L,1768050096L,57202471L,1905005414L,137433138206L,3023133941944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198511Inst : IEnumerable<long>
{
public static readonly long[] Value=A198511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198511.Bytes);
public long this[int i]=>Value[i];

public static A198511Inst Instance=new A198511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198512
{
public static readonly long[] Value={ 1L,2L,4L,1L,5L,7L,3L,8L,4L,10L,2L,6L,13L,3L,14L,7L,17L,9L,5L,19L,20L,6L,22L,1L,12L,13L,25L,8L,28L,29L,16L,3L,32L,11L,18L,4L,34L,19L,12L,35L,2L,21L,38L,3L,40L,6L,15L,24L,43L,17L,47L,27L,5L,18L,28L,9L,1L,20L,31L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198512Inst : IEnumerable<long>
{
public static readonly long[] Value=A198512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198512.Bytes);
public long this[int i]=>Value[i];

public static A198512Inst Instance=new A198512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198513
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,320L,5556L,129600L,3756936L,132872192L,5679982288L,286769980416L,16732506817280L,1115928688967680L,84383735744758464L,7163164003950936064L,BigInteger.Parse("676619301019539271040"),BigInteger.Parse("70674282825174467215360"),BigInteger.Parse("8117559039240651749888256") };
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
public class A198513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198513Inst Instance=new A198513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198514
{
public static readonly long[] Value={ 1L,3L,6L,9L,11L,22L,22L,23L,29L,29L,35L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198514Inst : IEnumerable<long>
{
public static readonly long[] Value=A198514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198514.Bytes);
public long this[int i]=>Value[i];

public static A198514Inst Instance=new A198514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198515
{
public static readonly long[] Value={ 1L,3L,11L,16L,22L,31L,30L,35L,39L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198515Inst : IEnumerable<long>
{
public static readonly long[] Value=A198515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198515.Bytes);
public long this[int i]=>Value[i];

public static A198515Inst Instance=new A198515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198516
{
public static readonly long[] Value={ 1L,2L,3L,6L,6L,8L,9L,10L,14L,17L,17L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198516Inst : IEnumerable<long>
{
public static readonly long[] Value=A198516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198516.Bytes);
public long this[int i]=>Value[i];

public static A198516Inst Instance=new A198516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198517
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198517Inst : IEnumerable<long>
{
public static readonly long[] Value=A198517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198517.Bytes);
public long this[int i]=>Value[i];

public static A198517Inst Instance=new A198517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198518
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,9L,16L,29L,54L,102L,194L,375L,730L,1434L,2837L,5650L,11311L,22767L,46023L,93422L,190322L,389037L,797613L,1639878L,3380099L,6983484L,14459570L,29999618L,62357426L,129843590L,270807835L,565674584L,1183301266L,2478624060L,5198504694L,10916110768L,22948299899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198518Inst : IEnumerable<long>
{
public static readonly long[] Value=A198518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198518.Bytes);
public long this[int i]=>Value[i];

public static A198518Inst Instance=new A198518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198519
{
public static readonly long[] Value={ 3L,5L,11L,19L,7L,37L,17L,61L,23L,101L,13L,137L,29L,179L,31L,239L,41L,311L,67L,419L,71L,557L,73L,701L,47L,821L,43L,911L,59L,1013L,79L,1151L,53L,1283L,97L,1433L,83L,1613L,127L,1823L,89L,2039L,109L,2237L,113L,2459L,139L,2711L,103L,2953L,107L,3163L,163L,3433L,131L,3727L,149L,4007L,181L,4337L,173L,4691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198519Inst : IEnumerable<long>
{
public static readonly long[] Value=A198519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198519.Bytes);
public long this[int i]=>Value[i];

public static A198519Inst Instance=new A198519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198520
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,22L,55L,141L,370L,986L,2662L,7264L,20006L,55534L,155219L,436456L,1233822L,3504482L,9996417L,28624038L,82248498L,237082689L,685375920L,1986604360L,5772399530L,16810591254L,49059068617L,143450142998L,420213814655L,1233034693847L,3623838769503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198520Inst : IEnumerable<long>
{
public static readonly long[] Value=A198520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198520.Bytes);
public long this[int i]=>Value[i];

public static A198520Inst Instance=new A198520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198521
{
public static readonly BigInteger[] Value={ 1L,15L,16714L,1084539825L,1814002928583853L,BigInteger.Parse("72341858272434900016248") };
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
public class A198521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198521Inst Instance=new A198521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198522
{
public static readonly BigInteger[] Value={ 2L,15L,193L,3660L,81844L,1948672L,47436498L,1163606279L,28617909415L,704465305625L,17346617064022L,427184684002131L,10520398796919219L,259092051772297458L,6380839372392481249L,BigInteger.Parse("157145577058895542027") };
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
public class A198522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198522Inst Instance=new A198522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198523
{
public static readonly BigInteger[] Value={ 5L,193L,16714L,1877316L,222590953L,26670041125L,3201911378187L,384557171168810L,46189600128813487L,5547962760669962158L,BigInteger.Parse("666383179391895903794"),BigInteger.Parse("80041410904141273707361"),BigInteger.Parse("9614030302463648373863365") };
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
public class A198523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198523Inst Instance=new A198523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198524
{
public static readonly BigInteger[] Value={ 15L,3660L,1877316L,1084539825L,634586561196L,371815743708461L,217885196778717007L,BigInteger.Parse("127683385189755792564"),BigInteger.Parse("74824145653256981522691"),BigInteger.Parse("43847942678019724723096730"),BigInteger.Parse("25695476991145191912238756667") };
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
public class A198524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198524Inst Instance=new A198524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198525
{
public static readonly BigInteger[] Value={ 52L,81844L,222590953L,634586561196L,1814002928583853L,5186266567454077293L,BigInteger.Parse("14827770532074166305565"),BigInteger.Parse("42393290191915767856385826"),BigInteger.Parse("121204405622972228787863169567"),BigInteger.Parse("346529082914494875185400399625818") };
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
public class A198525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198525Inst Instance=new A198525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198526
{
public static readonly BigInteger[] Value={ 202L,1948672L,26670041125L,371815743708461L,5186266567454077293L,BigInteger.Parse("72341858272434900016248"),BigInteger.Parse("1009078065869144136137180812"),BigInteger.Parse("14075371934477934686865356966591"),BigInteger.Parse("196333764385468923490801365319931630") };
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
public class A198526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198526Inst Instance=new A198526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198527
{
public static readonly BigInteger[] Value={ 855L,47436498L,3201911378187L,217885196778717007L,BigInteger.Parse("14827770532074166305565"),BigInteger.Parse("1009078065869144136137180812") };
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
public class A198527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198527Inst Instance=new A198527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198528
{
public static readonly long[] Value={ 1L,2L,2L,5L,15L,5L,15L,193L,193L,15L,52L,3660L,16714L,3660L,52L,202L,81844L,1877316L,1877316L,81844L,202L,855L,1948672L,222590953L,1084539825L,222590953L,1948672L,855L,3845L,47436498L,26670041125L,634586561196L,634586561196L,26670041125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198528Inst : IEnumerable<long>
{
public static readonly long[] Value=A198528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198528.Bytes);
public long this[int i]=>Value[i];

public static A198528Inst Instance=new A198528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198529
{
public static readonly BigInteger[] Value={ 12L,206L,3838L,74582L,1481214L,29737425L,600187403L,12144602583L,246046084954L,4987787543526L,101140166737445L,2051157938501522L,41600949234763960L,843764349062814286L,17113771581568185569UL,BigInteger.Parse("347115075675201580800") };
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
public class A198529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198529Inst Instance=new A198529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198530
{
public static readonly BigInteger[] Value={ 76L,3838L,213328L,12510524L,757941274L,46796529288L,2920541321626L,183371225099361L,11551938856624945L,729096061168837827L,BigInteger.Parse("46063831233179842268"),BigInteger.Parse("2911931787180884205541"),BigInteger.Parse("184135675347690092435300") };
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
public class A198530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198530Inst Instance=new A198530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198531
{
public static readonly BigInteger[] Value={ 492L,74582L,12510524L,2223874372L,411119156729L,77956630302044L,15021391650662681L,2923455266600557870L,BigInteger.Parse("572454626428774679082"),BigInteger.Parse("112514115501137650870546"),BigInteger.Parse("22164495447174669745358050") };
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
public class A198531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198531Inst Instance=new A198531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198532
{
public static readonly long[] Value={ 2L,12L,12L,76L,206L,76L,492L,3838L,3838L,492L,3212L,74582L,213328L,74582L,3212L,21036L,1481214L,12510524L,12510524L,1481214L,21036L,137932L,29737425L,757941274L,2223874372L,757941274L,29737425L,137932L,904812L,600187403L,46796529288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198532Inst : IEnumerable<long>
{
public static readonly long[] Value=A198532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198532.Bytes);
public long this[int i]=>Value[i];

public static A198532Inst Instance=new A198532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198533
{
public static readonly BigInteger[] Value={ 17L,7376L,5724014L,4685798318L,3879729611186L,3222491533589620L,2679021244608145508L,BigInteger.Parse("2227788819914832219768"),BigInteger.Parse("1852697804471510467351558"),BigInteger.Parse("1540794008599547700761105406"),BigInteger.Parse("1281407594160466806617993848394") };
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
public class A198533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198533Inst Instance=new A198533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198534
{
public static readonly long[] Value={ 2L,17L,17L,377L,7376L,377L,11473L,5724014L,5724014L,11473L,375273L,4685798318L,116594439780L,4685798318L,375273L,12456897L,3879729611186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198534Inst : IEnumerable<long>
{
public static readonly long[] Value=A198534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198534.Bytes);
public long this[int i]=>Value[i];

public static A198534Inst Instance=new A198534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198535
{
public static readonly BigInteger[] Value={ 5L,404L,67442L,11739910L,2048681430L,357559607382L,62405998006614L,10891920070833494L,1901001993638057302L,BigInteger.Parse("331788019307198829910"),BigInteger.Parse("57908034887329483937110"),BigInteger.Parse("10106876407223511717074262") };
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
public class A198535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198535Inst Instance=new A198535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198536
{
public static readonly BigInteger[] Value={ 404L,7937268L,163506788110L,3368739754955320L,BigInteger.Parse("69406373651979823710"),BigInteger.Parse("1429984226143212404754264"),BigInteger.Parse("29462062047551694076888833310"),BigInteger.Parse("607008863611669902737169765762040") };
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
public class A198536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198536Inst Instance=new A198536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198537
{
public static readonly BigInteger[] Value={ 67442L,163506788110L,397739142470871040L,BigInteger.Parse("967523967174230258261646"),BigInteger.Parse("2353559236762243709633958950262") };
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
public class A198537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198537Inst Instance=new A198537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198538
{
public static readonly BigInteger[] Value={ 5L,404L,404L,67442L,7937268L,67442L,11739910L,163506788110L,163506788110L,11739910L,2048681430L,3368739754955320L,397739142470871040L,3368739754955320L,2048681430L,357559607382L,BigInteger.Parse("69406373651979823710") };
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
public class A198538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198538Inst Instance=new A198538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198539
{
public static readonly long[] Value={ 2L,5L,2L,6L,5L,1L,2L,1L,7L,3L,6L,3L,0L,6L,7L,9L,6L,9L,8L,4L,9L,9L,4L,7L,8L,9L,1L,4L,6L,7L,0L,0L,1L,5L,8L,8L,9L,4L,0L,1L,1L,1L,8L,9L,2L,5L,4L,4L,2L,2L,4L,9L,7L,2L,1L,6L,2L,5L,7L,7L,4L,4L,6L,8L,3L,0L,5L,9L,7L,5L,5L,7L,0L,4L,8L,0L,1L,9L,1L,4L,6L,5L,2L,5L,6L,0L,8L,5L,7L,8L,4L,5L,2L,1L,2L,5L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198539Inst : IEnumerable<long>
{
public static readonly long[] Value=A198539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198539.Bytes);
public long this[int i]=>Value[i];

public static A198539Inst Instance=new A198539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198540
{
public static readonly long[] Value={ 2L,4L,2L,6L,6L,1L,0L,9L,0L,1L,4L,0L,2L,2L,1L,3L,1L,2L,6L,3L,0L,2L,6L,4L,8L,3L,4L,9L,7L,4L,7L,3L,8L,4L,2L,1L,3L,1L,7L,8L,2L,5L,8L,1L,5L,0L,5L,0L,8L,6L,2L,5L,8L,9L,0L,5L,7L,5L,0L,7L,5L,2L,3L,6L,5L,1L,2L,7L,3L,8L,7L,3L,9L,0L,2L,9L,0L,7L,0L,3L,7L,9L,5L,4L,9L,6L,6L,9L,4L,5L,3L,7L,2L,1L,9L,3L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198540Inst : IEnumerable<long>
{
public static readonly long[] Value=A198540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198540.Bytes);
public long this[int i]=>Value[i];

public static A198540Inst Instance=new A198540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198541
{
public static readonly long[] Value={ 5L,1L,0L,7L,2L,7L,5L,7L,3L,3L,8L,5L,5L,1L,7L,3L,1L,2L,0L,7L,9L,4L,0L,8L,2L,9L,0L,2L,7L,2L,0L,5L,8L,5L,4L,4L,6L,0L,7L,9L,0L,7L,3L,1L,7L,7L,8L,9L,3L,9L,8L,9L,1L,1L,9L,3L,5L,6L,3L,5L,4L,7L,0L,3L,7L,3L,3L,4L,5L,5L,7L,6L,3L,8L,0L,4L,8L,5L,6L,5L,0L,9L,7L,9L,7L,1L,3L,9L,6L,4L,3L,5L,9L,8L,9L,0L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198541Inst : IEnumerable<long>
{
public static readonly long[] Value=A198541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198541.Bytes);
public long this[int i]=>Value[i];

public static A198541Inst Instance=new A198541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198542
{
public static readonly long[] Value={ 2L,5L,5L,4L,1L,8L,8L,5L,9L,9L,3L,7L,6L,0L,8L,1L,0L,1L,0L,0L,7L,6L,2L,2L,8L,1L,0L,9L,4L,9L,1L,6L,4L,2L,4L,3L,4L,9L,4L,9L,9L,6L,1L,1L,9L,0L,9L,1L,4L,9L,8L,4L,8L,7L,1L,4L,1L,5L,3L,5L,8L,0L,4L,3L,3L,0L,5L,9L,4L,3L,7L,1L,7L,6L,8L,9L,0L,9L,8L,1L,9L,3L,1L,6L,6L,8L,2L,1L,6L,8L,7L,2L,5L,7L,9L,8L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198542Inst : IEnumerable<long>
{
public static readonly long[] Value=A198542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198542.Bytes);
public long this[int i]=>Value[i];

public static A198542Inst Instance=new A198542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198543
{
public static readonly long[] Value={ 2L,4L,0L,3L,9L,6L,0L,8L,0L,1L,4L,4L,3L,6L,5L,3L,9L,5L,9L,1L,3L,2L,3L,7L,1L,7L,6L,6L,1L,7L,0L,7L,7L,6L,9L,9L,7L,1L,7L,6L,5L,5L,9L,0L,7L,4L,4L,3L,4L,4L,0L,7L,7L,2L,0L,4L,5L,0L,5L,7L,3L,9L,4L,9L,4L,8L,4L,9L,9L,5L,4L,7L,4L,4L,1L,7L,0L,5L,1L,4L,0L,3L,0L,0L,5L,6L,3L,4L,8L,2L,9L,2L,2L,9L,5L,0L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198543Inst : IEnumerable<long>
{
public static readonly long[] Value=A198543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198543.Bytes);
public long this[int i]=>Value[i];

public static A198543Inst Instance=new A198543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198544
{
public static readonly long[] Value={ 7L,7L,4L,2L,3L,8L,8L,9L,1L,7L,5L,6L,3L,9L,1L,3L,2L,0L,4L,2L,7L,4L,0L,3L,6L,1L,9L,7L,3L,8L,5L,0L,9L,3L,9L,9L,3L,2L,0L,8L,8L,6L,1L,1L,0L,9L,8L,1L,0L,8L,1L,4L,8L,9L,0L,6L,8L,0L,1L,2L,5L,5L,7L,6L,9L,8L,7L,1L,4L,3L,7L,7L,8L,1L,0L,5L,7L,8L,5L,6L,8L,6L,1L,0L,1L,0L,1L,1L,6L,4L,2L,2L,6L,5L,1L,8L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198544Inst : IEnumerable<long>
{
public static readonly long[] Value=A198544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198544.Bytes);
public long this[int i]=>Value[i];

public static A198544Inst Instance=new A198544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198545
{
public static readonly long[] Value={ 2L,5L,8L,3L,1L,2L,9L,1L,2L,3L,7L,7L,5L,2L,3L,9L,2L,6L,0L,3L,2L,7L,3L,4L,0L,7L,3L,9L,5L,1L,9L,8L,2L,5L,3L,0L,6L,5L,4L,9L,1L,5L,5L,2L,1L,6L,2L,4L,8L,6L,5L,0L,3L,6L,6L,7L,8L,8L,4L,2L,9L,8L,5L,8L,1L,7L,9L,4L,8L,9L,6L,1L,0L,4L,0L,1L,8L,2L,8L,7L,7L,0L,7L,5L,1L,6L,4L,6L,5L,0L,8L,1L,3L,3L,3L,0L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198545Inst : IEnumerable<long>
{
public static readonly long[] Value=A198545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198545.Bytes);
public long this[int i]=>Value[i];

public static A198545Inst Instance=new A198545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198546
{
public static readonly long[] Value={ 9L,3L,0L,8L,5L,6L,7L,5L,6L,0L,3L,9L,4L,5L,5L,9L,5L,5L,2L,7L,5L,4L,0L,5L,8L,2L,0L,7L,0L,0L,9L,8L,2L,8L,4L,5L,2L,2L,5L,9L,9L,7L,1L,0L,8L,2L,9L,6L,6L,4L,3L,8L,1L,8L,4L,2L,4L,9L,7L,2L,4L,5L,5L,8L,4L,4L,0L,1L,6L,0L,3L,9L,2L,0L,4L,8L,7L,8L,0L,8L,1L,1L,2L,7L,8L,1L,4L,6L,5L,0L,0L,1L,7L,9L,3L,4L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198546Inst : IEnumerable<long>
{
public static readonly long[] Value=A198546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198546.Bytes);
public long this[int i]=>Value[i];

public static A198546Inst Instance=new A198546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198547
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,7L,6L,8L,9L,5L,9L,6L,1L,2L,7L,1L,7L,3L,0L,4L,4L,1L,8L,9L,1L,1L,5L,1L,2L,6L,5L,6L,7L,1L,8L,6L,8L,6L,7L,1L,2L,7L,1L,7L,8L,6L,2L,1L,0L,4L,6L,3L,3L,2L,4L,6L,2L,1L,8L,6L,5L,9L,0L,3L,4L,3L,3L,6L,9L,4L,8L,7L,3L,8L,0L,3L,2L,5L,4L,8L,4L,3L,7L,5L,0L,7L,6L,0L,9L,2L,1L,3L,6L,9L,6L,0L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198547Inst : IEnumerable<long>
{
public static readonly long[] Value=A198547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198547.Bytes);
public long this[int i]=>Value[i];

public static A198547Inst Instance=new A198547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198548
{
public static readonly long[] Value={ 1L,4L,9L,8L,4L,2L,8L,5L,7L,0L,1L,4L,1L,0L,2L,6L,2L,8L,9L,1L,0L,5L,6L,5L,2L,1L,0L,1L,2L,4L,4L,0L,1L,9L,8L,3L,8L,5L,1L,8L,3L,8L,5L,4L,4L,1L,5L,8L,9L,3L,8L,6L,7L,8L,9L,8L,1L,8L,3L,7L,3L,4L,5L,2L,6L,9L,4L,7L,2L,8L,3L,1L,2L,2L,0L,3L,2L,7L,0L,7L,8L,5L,4L,9L,5L,7L,4L,3L,9L,6L,4L,7L,3L,4L,0L,2L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198548Inst : IEnumerable<long>
{
public static readonly long[] Value=A198548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198548.Bytes);
public long this[int i]=>Value[i];

public static A198548Inst Instance=new A198548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198549
{
public static readonly long[] Value={ 1L,6L,8L,1L,8L,4L,5L,2L,4L,4L,9L,4L,5L,0L,1L,2L,3L,1L,0L,9L,3L,2L,6L,2L,8L,6L,2L,0L,2L,1L,9L,4L,1L,9L,9L,4L,2L,3L,5L,6L,4L,0L,1L,7L,1L,5L,4L,1L,8L,8L,1L,7L,9L,6L,6L,6L,2L,1L,5L,7L,0L,1L,0L,1L,8L,4L,7L,2L,9L,6L,0L,4L,2L,7L,7L,1L,3L,7L,4L,0L,1L,8L,6L,7L,3L,8L,1L,8L,0L,6L,6L,2L,7L,3L,1L,3L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198549Inst : IEnumerable<long>
{
public static readonly long[] Value=A198549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198549.Bytes);
public long this[int i]=>Value[i];

public static A198549Inst Instance=new A198549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198550
{
public static readonly long[] Value={ 6L,4L,4L,0L,9L,2L,5L,3L,0L,1L,9L,3L,0L,7L,2L,5L,5L,8L,9L,9L,1L,2L,8L,9L,2L,1L,5L,2L,5L,1L,3L,0L,0L,8L,3L,6L,9L,5L,1L,1L,4L,0L,8L,1L,8L,5L,6L,8L,3L,5L,4L,0L,8L,9L,2L,3L,1L,0L,7L,0L,2L,1L,6L,4L,8L,9L,3L,8L,1L,4L,9L,6L,2L,6L,8L,7L,7L,2L,8L,8L,7L,1L,2L,1L,5L,7L,8L,7L,2L,4L,5L,7L,7L,4L,4L,6L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198550Inst : IEnumerable<long>
{
public static readonly long[] Value=A198550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198550.Bytes);
public long this[int i]=>Value[i];

public static A198550Inst Instance=new A198550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198551
{
public static readonly long[] Value={ 9L,1L,1L,4L,5L,3L,8L,1L,4L,9L,9L,7L,9L,0L,6L,8L,9L,3L,9L,3L,3L,7L,9L,2L,8L,3L,5L,1L,7L,0L,5L,1L,3L,2L,8L,0L,9L,3L,2L,4L,4L,2L,4L,1L,8L,4L,3L,8L,9L,3L,7L,4L,0L,2L,2L,0L,7L,2L,7L,3L,0L,6L,6L,9L,0L,4L,1L,5L,0L,7L,8L,6L,6L,7L,0L,1L,4L,7L,3L,6L,6L,8L,6L,8L,3L,0L,0L,1L,7L,1L,1L,5L,8L,7L,9L,5L,8L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198551Inst : IEnumerable<long>
{
public static readonly long[] Value=A198551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198551.Bytes);
public long this[int i]=>Value[i];

public static A198551Inst Instance=new A198551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198552
{
public static readonly long[] Value={ 1L,1L,3L,2L,7L,7L,8L,4L,1L,6L,6L,7L,8L,0L,4L,3L,5L,5L,1L,2L,9L,8L,3L,7L,2L,5L,4L,3L,7L,2L,4L,1L,0L,8L,3L,8L,5L,0L,6L,9L,7L,7L,3L,0L,0L,2L,2L,8L,8L,6L,6L,0L,9L,6L,0L,8L,8L,4L,8L,6L,9L,9L,0L,8L,5L,6L,8L,4L,3L,1L,9L,5L,1L,9L,1L,2L,9L,0L,9L,0L,8L,8L,7L,3L,4L,0L,7L,3L,2L,5L,1L,4L,8L,9L,5L,7L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198552Inst : IEnumerable<long>
{
public static readonly long[] Value=A198552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198552.Bytes);
public long this[int i]=>Value[i];

public static A198552Inst Instance=new A198552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198553
{
public static readonly long[] Value={ 1L,3L,1L,4L,5L,1L,8L,9L,3L,5L,6L,6L,2L,9L,1L,3L,3L,7L,8L,5L,6L,2L,0L,3L,2L,7L,2L,2L,8L,9L,9L,0L,1L,3L,0L,4L,7L,0L,8L,6L,4L,8L,6L,6L,8L,7L,6L,7L,2L,6L,3L,8L,2L,3L,5L,9L,7L,7L,7L,0L,5L,1L,9L,4L,0L,4L,4L,7L,9L,7L,0L,5L,4L,6L,6L,8L,5L,4L,2L,3L,9L,8L,3L,0L,2L,8L,9L,9L,7L,5L,3L,0L,6L,2L,5L,5L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198553Inst : IEnumerable<long>
{
public static readonly long[] Value=A198553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198553.Bytes);
public long this[int i]=>Value[i];

public static A198553Inst Instance=new A198553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198554
{
public static readonly long[] Value={ 4L,9L,0L,1L,1L,0L,8L,3L,0L,7L,3L,4L,8L,6L,7L,4L,3L,7L,3L,5L,5L,1L,4L,0L,7L,3L,7L,4L,1L,1L,1L,6L,7L,2L,0L,1L,4L,3L,4L,8L,1L,0L,1L,9L,5L,1L,7L,8L,7L,8L,7L,7L,4L,6L,4L,1L,5L,1L,7L,4L,1L,1L,2L,9L,7L,3L,7L,4L,0L,5L,7L,6L,8L,3L,7L,3L,0L,3L,7L,5L,8L,9L,9L,4L,5L,6L,8L,7L,1L,1L,0L,2L,7L,2L,0L,1L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198554Inst : IEnumerable<long>
{
public static readonly long[] Value=A198554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198554.Bytes);
public long this[int i]=>Value[i];

public static A198554Inst Instance=new A198554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198555
{
public static readonly long[] Value={ 7L,0L,9L,1L,3L,5L,0L,9L,3L,6L,6L,7L,6L,4L,5L,1L,3L,1L,2L,9L,5L,7L,2L,8L,3L,5L,8L,3L,3L,3L,5L,1L,4L,5L,4L,8L,6L,1L,4L,1L,2L,7L,2L,4L,2L,7L,4L,7L,2L,9L,7L,0L,9L,8L,5L,1L,7L,3L,2L,7L,6L,1L,5L,4L,1L,6L,6L,1L,7L,2L,8L,1L,2L,4L,3L,7L,6L,4L,6L,3L,9L,5L,0L,3L,0L,0L,4L,9L,1L,5L,7L,0L,7L,2L,9L,4L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198555Inst : IEnumerable<long>
{
public static readonly long[] Value=A198555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198555.Bytes);
public long this[int i]=>Value[i];

public static A198555Inst Instance=new A198555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198556
{
public static readonly long[] Value={ 9L,0L,2L,2L,9L,5L,9L,7L,5L,6L,8L,7L,3L,7L,0L,9L,8L,1L,6L,7L,1L,5L,2L,6L,9L,9L,7L,4L,7L,9L,8L,5L,2L,4L,4L,2L,1L,1L,1L,9L,1L,3L,6L,2L,0L,2L,8L,2L,1L,2L,8L,3L,4L,6L,4L,3L,8L,0L,5L,1L,4L,0L,2L,0L,6L,1L,1L,6L,1L,9L,2L,3L,1L,9L,8L,5L,8L,6L,3L,8L,9L,0L,2L,3L,1L,1L,9L,6L,0L,2L,0L,9L,4L,6L,0L,8L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198556Inst : IEnumerable<long>
{
public static readonly long[] Value=A198556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198556.Bytes);
public long this[int i]=>Value[i];

public static A198556Inst Instance=new A198556Inst();

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