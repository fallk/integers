using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A039217
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039217Inst : IEnumerable<long>
{
public static readonly long[] Value=A039217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039217.Bytes);
public long this[int i]=>Value[i];

public static A039217Inst Instance=new A039217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039216
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039216Inst : IEnumerable<long>
{
public static readonly long[] Value=A039216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039216.Bytes);
public long this[int i]=>Value[i];

public static A039216Inst Instance=new A039216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039215
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,85L,86L,87L,88L,89L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039215Inst : IEnumerable<long>
{
public static readonly long[] Value=A039215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039215.Bytes);
public long this[int i]=>Value[i];

public static A039215Inst Instance=new A039215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039214
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,60L,73L,74L,75L,76L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039214Inst : IEnumerable<long>
{
public static readonly long[] Value=A039214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039214.Bytes);
public long this[int i]=>Value[i];

public static A039214Inst Instance=new A039214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039213
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,89L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039213Inst : IEnumerable<long>
{
public static readonly long[] Value=A039213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039213.Bytes);
public long this[int i]=>Value[i];

public static A039213Inst Instance=new A039213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039212
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,16L,17L,18L,19L,20L,21L,22L,23L,25L,26L,28L,29L,30L,31L,32L,33L,34L,35L,36L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,88L,89L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039212Inst : IEnumerable<long>
{
public static readonly long[] Value=A039212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039212.Bytes);
public long this[int i]=>Value[i];

public static A039212Inst Instance=new A039212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039211
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,75L,76L,77L,78L,79L,80L,81L,82L,83L,85L,87L,88L,89L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039211Inst : IEnumerable<long>
{
public static readonly long[] Value=A039211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039211.Bytes);
public long this[int i]=>Value[i];

public static A039211Inst Instance=new A039211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039210
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,86L,87L,88L,89L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039210Inst : IEnumerable<long>
{
public static readonly long[] Value=A039210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039210.Bytes);
public long this[int i]=>Value[i];

public static A039210Inst Instance=new A039210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039209
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,30L,33L,34L,35L,36L,37L,38L,39L,40L,41L,44L,45L,46L,47L,48L,49L,50L,51L,52L,55L,56L,57L,58L,59L,60L,61L,62L,63L,66L,67L,68L,69L,70L,71L,72L,73L,74L,77L,78L,79L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039209Inst : IEnumerable<long>
{
public static readonly long[] Value=A039209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039209.Bytes);
public long this[int i]=>Value[i];

public static A039209Inst Instance=new A039209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039208
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,11L,12L,13L,14L,15L,16L,17L,18L,20L,22L,23L,24L,25L,26L,27L,28L,29L,31L,33L,34L,35L,36L,37L,38L,39L,40L,42L,44L,45L,46L,47L,48L,49L,50L,51L,53L,55L,56L,57L,58L,59L,60L,61L,62L,64L,66L,67L,68L,69L,70L,71L,72L,73L,75L,77L,78L,79L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039208Inst : IEnumerable<long>
{
public static readonly long[] Value=A039208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039208.Bytes);
public long this[int i]=>Value[i];

public static A039208Inst Instance=new A039208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039207
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,10L,11L,12L,13L,14L,15L,16L,17L,18L,21L,22L,23L,24L,25L,26L,27L,28L,29L,32L,33L,34L,35L,36L,37L,38L,39L,40L,43L,44L,45L,46L,47L,48L,49L,50L,51L,54L,55L,56L,57L,58L,59L,60L,61L,62L,65L,66L,67L,68L,69L,70L,71L,72L,73L,76L,77L,78L,79L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039207Inst : IEnumerable<long>
{
public static readonly long[] Value=A039207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039207.Bytes);
public long this[int i]=>Value[i];

public static A039207Inst Instance=new A039207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039206
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,9L,11L,12L,13L,14L,15L,16L,17L,19L,20L,22L,23L,24L,25L,26L,27L,28L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,44L,45L,46L,47L,48L,49L,50L,52L,53L,55L,56L,57L,58L,59L,60L,61L,63L,64L,66L,67L,68L,69L,70L,71L,72L,74L,75L,87L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039206Inst : IEnumerable<long>
{
public static readonly long[] Value=A039206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039206.Bytes);
public long this[int i]=>Value[i];

public static A039206Inst Instance=new A039206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039205
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,10L,11L,12L,13L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,37L,38L,39L,41L,43L,44L,45L,46L,47L,48L,49L,50L,52L,54L,55L,56L,57L,58L,59L,60L,61L,63L,65L,66L,67L,68L,69L,70L,71L,72L,74L,76L,86L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039205Inst : IEnumerable<long>
{
public static readonly long[] Value=A039205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039205.Bytes);
public long this[int i]=>Value[i];

public static A039205Inst Instance=new A039205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039204
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,13L,14L,15L,16L,17L,20L,21L,22L,23L,24L,25L,26L,27L,28L,31L,32L,33L,34L,35L,36L,37L,38L,39L,42L,43L,44L,45L,46L,47L,48L,49L,50L,53L,54L,55L,56L,57L,58L,59L,60L,61L,64L,65L,66L,67L,68L,69L,70L,71L,72L,75L,76L,85L,95L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039204Inst : IEnumerable<long>
{
public static readonly long[] Value=A039204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039204.Bytes);
public long this[int i]=>Value[i];

public static A039204Inst Instance=new A039204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039203
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,14L,15L,16L,18L,19L,20L,22L,23L,24L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,37L,38L,40L,41L,42L,44L,45L,46L,47L,48L,49L,51L,52L,53L,55L,56L,57L,58L,59L,60L,62L,63L,64L,76L,77L,78L,79L,80L,81L,82L,84L,85L,86L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039203Inst : IEnumerable<long>
{
public static readonly long[] Value=A039203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039203.Bytes);
public long this[int i]=>Value[i];

public static A039203Inst Instance=new A039203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039202
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,10L,11L,12L,13L,14L,15L,16L,18L,19L,21L,22L,23L,24L,25L,26L,27L,29L,30L,32L,33L,34L,35L,36L,37L,38L,40L,41L,43L,44L,45L,46L,47L,48L,49L,51L,52L,54L,55L,56L,57L,58L,59L,60L,62L,63L,65L,75L,77L,78L,79L,80L,81L,82L,84L,85L,87L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039202Inst : IEnumerable<long>
{
public static readonly long[] Value=A039202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039202.Bytes);
public long this[int i]=>Value[i];

public static A039202Inst Instance=new A039202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039201
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,9L,10L,11L,12L,13L,14L,15L,16L,18L,20L,21L,22L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,36L,37L,38L,40L,42L,43L,44L,45L,46L,47L,48L,49L,51L,53L,54L,55L,56L,57L,58L,59L,60L,62L,64L,65L,74L,77L,78L,79L,80L,81L,82L,84L,86L,87L,94L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039201Inst : IEnumerable<long>
{
public static readonly long[] Value=A039201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039201.Bytes);
public long this[int i]=>Value[i];

public static A039201Inst Instance=new A039201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039200
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,9L,10L,11L,12L,13L,14L,15L,16L,19L,20L,21L,22L,23L,24L,25L,26L,27L,30L,31L,32L,33L,34L,35L,36L,37L,38L,41L,42L,43L,44L,45L,46L,47L,48L,49L,52L,53L,54L,55L,56L,57L,58L,59L,60L,63L,64L,65L,73L,83L,88L,89L,90L,91L,92L,93L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039200Inst : IEnumerable<long>
{
public static readonly long[] Value=A039200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039200.Bytes);
public long this[int i]=>Value[i];

public static A039200Inst Instance=new A039200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039199
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,47L,48L,50L,51L,52L,53L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,86L,88L,89L,90L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039199Inst : IEnumerable<long>
{
public static readonly long[] Value=A039199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039199.Bytes);
public long this[int i]=>Value[i];

public static A039199Inst Instance=new A039199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039198
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,10L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,25L,26L,28L,29L,30L,32L,33L,34L,35L,36L,37L,39L,40L,41L,43L,44L,45L,46L,47L,48L,50L,51L,52L,54L,64L,66L,67L,68L,69L,70L,72L,73L,74L,76L,77L,78L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039198Inst : IEnumerable<long>
{
public static readonly long[] Value=A039198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039198.Bytes);
public long this[int i]=>Value[i];

public static A039198Inst Instance=new A039198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039197
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,20L,21L,22L,23L,24L,25L,26L,28L,29L,31L,32L,33L,34L,35L,36L,37L,39L,40L,42L,43L,44L,45L,46L,47L,48L,50L,51L,53L,54L,63L,66L,67L,68L,69L,70L,72L,73L,75L,76L,77L,78L,79L,80L,81L,83L,84L,86L,87L,93L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039197Inst : IEnumerable<long>
{
public static readonly long[] Value=A039197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039197.Bytes);
public long this[int i]=>Value[i];

public static A039197Inst Instance=new A039197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039180
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,8L,10L,11L,12L,14L,15L,16L,17L,18L,19L,21L,31L,33L,34L,36L,37L,38L,39L,40L,41L,43L,44L,45L,47L,48L,49L,50L,51L,52L,54L,55L,56L,58L,59L,60L,61L,62L,63L,65L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,78L,80L,81L,82L,83L,84L,85L,87L,88L,89L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039180Inst : IEnumerable<long>
{
public static readonly long[] Value=A039180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039180.Bytes);
public long this[int i]=>Value[i];

public static A039180Inst Instance=new A039180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039179
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,9L,10L,11L,12L,14L,15L,16L,17L,18L,20L,21L,30L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,45L,47L,48L,49L,50L,51L,53L,54L,55L,56L,58L,59L,60L,61L,62L,64L,65L,66L,67L,69L,70L,71L,72L,73L,75L,76L,77L,78L,80L,81L,82L,83L,84L,86L,87L,90L,99L,100L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039179Inst : IEnumerable<long>
{
public static readonly long[] Value=A039179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039179.Bytes);
public long this[int i]=>Value[i];

public static A039179Inst Instance=new A039179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039178
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,16L,17L,19L,20L,21L,29L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,50L,52L,53L,54L,55L,56L,58L,59L,60L,61L,63L,64L,65L,66L,67L,69L,70L,71L,72L,74L,75L,76L,79L,88L,89L,91L,92L,93L,94L,96L,97L,98L,99L,100L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039178Inst : IEnumerable<long>
{
public static readonly long[] Value=A039178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039178.Bytes);
public long this[int i]=>Value[i];

public static A039178Inst Instance=new A039178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039177
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,9L,10L,11L,12L,14L,15L,16L,18L,19L,20L,21L,28L,33L,34L,36L,37L,38L,40L,41L,42L,43L,44L,45L,47L,48L,49L,51L,52L,53L,54L,55L,56L,58L,59L,60L,62L,63L,64L,65L,68L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,89L,91L,92L,93L,95L,96L,97L,98L,99L,100L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039177Inst : IEnumerable<long>
{
public static readonly long[] Value=A039177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039177.Bytes);
public long this[int i]=>Value[i];

public static A039177Inst Instance=new A039177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039176
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,8L,9L,10L,11L,12L,14L,15L,17L,18L,19L,20L,21L,27L,33L,34L,36L,37L,39L,40L,41L,42L,43L,44L,45L,47L,48L,50L,51L,52L,53L,54L,57L,66L,67L,69L,70L,72L,73L,74L,75L,76L,77L,78L,80L,81L,83L,84L,85L,86L,87L,88L,89L,91L,92L,94L,95L,96L,97L,98L,99L,100L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039176Inst : IEnumerable<long>
{
public static readonly long[] Value=A039176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039176.Bytes);
public long this[int i]=>Value[i];

public static A039176Inst Instance=new A039176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039175
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,8L,9L,10L,11L,12L,14L,16L,17L,18L,19L,20L,21L,26L,33L,34L,36L,38L,39L,40L,41L,42L,43L,46L,55L,56L,58L,60L,61L,62L,63L,64L,65L,66L,67L,69L,71L,72L,73L,74L,75L,76L,77L,78L,80L,82L,83L,84L,85L,86L,87L,88L,89L,91L,93L,94L,95L,96L,97L,98L,99L,100L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039175Inst : IEnumerable<long>
{
public static readonly long[] Value=A039175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039175.Bytes);
public long this[int i]=>Value[i];

public static A039175Inst Instance=new A039175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039174
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,8L,9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,21L,25L,35L,44L,45L,48L,49L,50L,51L,52L,53L,54L,55L,56L,59L,60L,61L,62L,63L,64L,65L,66L,67L,70L,71L,72L,73L,74L,75L,76L,77L,78L,81L,82L,83L,84L,85L,86L,87L,88L,89L,92L,93L,94L,95L,96L,97L,98L,99L,100L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039174Inst : IEnumerable<long>
{
public static readonly long[] Value=A039174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039174.Bytes);
public long this[int i]=>Value[i];

public static A039174Inst Instance=new A039174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039173
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,9L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,33L,35L,36L,37L,38L,39L,40L,41L,42L,44L,46L,47L,48L,49L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,63L,64L,66L,68L,69L,70L,71L,72L,73L,74L,75L,77L,79L,80L,81L,82L,83L,84L,85L,86L,88L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039173Inst : IEnumerable<long>
{
public static readonly long[] Value=A039173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039173.Bytes);
public long this[int i]=>Value[i];

public static A039173Inst Instance=new A039173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039172
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,10L,20L,22L,24L,25L,26L,27L,28L,29L,30L,32L,33L,35L,36L,37L,38L,39L,40L,41L,43L,44L,46L,47L,48L,49L,50L,51L,52L,54L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,68L,69L,70L,71L,72L,73L,74L,76L,77L,79L,80L,81L,82L,83L,84L,85L,87L,88L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039172Inst : IEnumerable<long>
{
public static readonly long[] Value=A039172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039172.Bytes);
public long this[int i]=>Value[i];

public static A039172Inst Instance=new A039172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039171
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,9L,10L,19L,22L,24L,25L,26L,27L,28L,29L,31L,32L,33L,35L,36L,37L,38L,39L,40L,42L,43L,44L,46L,47L,48L,49L,50L,51L,53L,54L,55L,57L,58L,59L,60L,61L,62L,64L,65L,66L,68L,69L,70L,71L,72L,73L,75L,76L,77L,79L,80L,81L,82L,83L,84L,86L,87L,89L,99L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039171Inst : IEnumerable<long>
{
public static readonly long[] Value=A039171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039171.Bytes);
public long this[int i]=>Value[i];

public static A039171Inst Instance=new A039171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039170
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,8L,9L,10L,18L,22L,24L,25L,26L,27L,28L,30L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,60L,61L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,78L,88L,90L,91L,92L,93L,94L,96L,97L,98L,99L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039170Inst : IEnumerable<long>
{
public static readonly long[] Value=A039170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039170.Bytes);
public long this[int i]=>Value[i];

public static A039170Inst Instance=new A039170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039169
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,8L,9L,10L,17L,22L,24L,25L,26L,27L,29L,30L,31L,32L,33L,35L,36L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,54L,55L,57L,58L,59L,60L,62L,63L,64L,65L,67L,77L,79L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,95L,96L,97L,98L,99L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039169Inst : IEnumerable<long>
{
public static readonly long[] Value=A039169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039169.Bytes);
public long this[int i]=>Value[i];

public static A039169Inst Instance=new A039169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039168
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,8L,9L,10L,16L,22L,24L,25L,26L,28L,29L,30L,31L,32L,33L,35L,36L,37L,39L,40L,41L,42L,43L,44L,46L,47L,48L,50L,51L,52L,53L,54L,56L,66L,68L,69L,70L,72L,73L,74L,75L,76L,77L,79L,80L,81L,83L,84L,85L,86L,87L,88L,90L,91L,92L,94L,95L,96L,97L,98L,99L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039168Inst : IEnumerable<long>
{
public static readonly long[] Value=A039168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039168.Bytes);
public long this[int i]=>Value[i];

public static A039168Inst Instance=new A039168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039167
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,7L,8L,9L,10L,15L,22L,24L,25L,27L,28L,29L,30L,31L,32L,33L,35L,36L,38L,39L,40L,41L,42L,43L,45L,55L,57L,58L,60L,61L,62L,63L,64L,65L,66L,68L,69L,71L,72L,73L,74L,75L,76L,77L,79L,80L,82L,83L,84L,85L,86L,87L,88L,90L,91L,93L,94L,95L,96L,97L,98L,99L,101L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039167Inst : IEnumerable<long>
{
public static readonly long[] Value=A039167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039167.Bytes);
public long this[int i]=>Value[i];

public static A039167Inst Instance=new A039167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039166
{
public static readonly long[] Value={ 0L,2L,4L,5L,6L,7L,8L,9L,10L,14L,22L,24L,26L,27L,28L,29L,30L,31L,32L,34L,44L,46L,48L,49L,50L,51L,52L,53L,54L,55L,57L,59L,60L,61L,62L,63L,64L,65L,66L,68L,70L,71L,72L,73L,74L,75L,76L,77L,79L,81L,82L,83L,84L,85L,86L,87L,88L,90L,92L,93L,94L,95L,96L,97L,98L,99L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039166Inst : IEnumerable<long>
{
public static readonly long[] Value=A039166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039166.Bytes);
public long this[int i]=>Value[i];

public static A039166Inst Instance=new A039166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039165
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,8L,9L,10L,13L,23L,33L,36L,37L,38L,39L,40L,41L,42L,43L,44L,47L,48L,49L,50L,51L,52L,53L,54L,55L,58L,59L,60L,61L,62L,63L,64L,65L,66L,69L,70L,71L,72L,73L,74L,75L,76L,77L,80L,81L,82L,83L,84L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,97L,98L,99L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039165Inst : IEnumerable<long>
{
public static readonly long[] Value=A039165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039165.Bytes);
public long this[int i]=>Value[i];

public static A039165Inst Instance=new A039165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039148
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,9L,10L,11L,12L,13L,14L,16L,17L,19L,20L,21L,22L,23L,24L,26L,27L,29L,30L,31L,32L,33L,34L,36L,37L,39L,40L,41L,42L,43L,44L,46L,47L,49L,58L,60L,61L,62L,63L,64L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,79L,85L,90L,91L,92L,93L,94L,96L,97L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039148Inst : IEnumerable<long>
{
public static readonly long[] Value=A039148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039148.Bytes);
public long this[int i]=>Value[i];

public static A039148Inst Instance=new A039148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039147
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,9L,10L,11L,12L,13L,14L,16L,18L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,32L,33L,34L,36L,38L,39L,40L,41L,42L,43L,44L,46L,48L,49L,57L,60L,61L,62L,63L,64L,66L,68L,69L,75L,80L,81L,82L,83L,84L,86L,88L,89L,90L,91L,92L,93L,94L,96L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039147Inst : IEnumerable<long>
{
public static readonly long[] Value=A039147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039147.Bytes);
public long this[int i]=>Value[i];

public static A039147Inst Instance=new A039147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039146
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,8L,9L,10L,11L,12L,13L,14L,17L,18L,19L,20L,21L,22L,23L,24L,27L,28L,29L,30L,31L,32L,33L,34L,37L,38L,39L,40L,41L,42L,43L,44L,47L,48L,49L,56L,65L,70L,71L,72L,73L,74L,77L,78L,79L,80L,81L,82L,83L,84L,87L,88L,89L,90L,91L,92L,93L,94L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039146Inst : IEnumerable<long>
{
public static readonly long[] Value=A039146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039146.Bytes);
public long this[int i]=>Value[i];

public static A039146Inst Instance=new A039146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039145
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,18L,20L,21L,22L,23L,25L,26L,27L,28L,30L,31L,32L,33L,35L,36L,37L,38L,49L,50L,51L,52L,53L,55L,56L,57L,58L,60L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,73L,75L,76L,77L,78L,80L,81L,82L,83L,85L,86L,87L,88L,94L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039145Inst : IEnumerable<long>
{
public static readonly long[] Value=A039145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039145.Bytes);
public long this[int i]=>Value[i];

public static A039145Inst Instance=new A039145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039144
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,9L,10L,11L,12L,13L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,33L,35L,36L,37L,39L,48L,50L,51L,52L,53L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,69L,70L,71L,72L,73L,75L,76L,77L,79L,84L,90L,91L,92L,93L,95L,96L,97L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039144Inst : IEnumerable<long>
{
public static readonly long[] Value=A039144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039144.Bytes);
public long this[int i]=>Value[i];

public static A039144Inst Instance=new A039144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039143
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,10L,11L,12L,13L,15L,16L,18L,19L,20L,21L,22L,23L,25L,26L,28L,29L,30L,31L,32L,33L,35L,36L,38L,39L,47L,50L,51L,52L,53L,55L,56L,58L,59L,60L,61L,62L,63L,65L,66L,68L,69L,74L,80L,81L,82L,83L,85L,86L,88L,89L,90L,91L,92L,93L,95L,96L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039143Inst : IEnumerable<long>
{
public static readonly long[] Value=A039143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039143.Bytes);
public long this[int i]=>Value[i];

public static A039143Inst Instance=new A039143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039142
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,8L,9L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,22L,23L,25L,27L,28L,29L,30L,31L,32L,33L,35L,37L,38L,39L,46L,50L,51L,52L,53L,55L,57L,58L,59L,64L,70L,71L,72L,73L,75L,77L,78L,79L,80L,81L,82L,83L,85L,87L,88L,89L,90L,91L,92L,93L,95L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039142Inst : IEnumerable<long>
{
public static readonly long[] Value=A039142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039142.Bytes);
public long this[int i]=>Value[i];

public static A039142Inst Instance=new A039142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039141
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,10L,11L,12L,13L,16L,17L,18L,19L,20L,21L,22L,23L,26L,27L,28L,29L,30L,31L,32L,33L,36L,37L,38L,39L,45L,54L,60L,61L,62L,63L,66L,67L,68L,69L,70L,71L,72L,73L,76L,77L,78L,79L,80L,81L,82L,83L,86L,87L,88L,89L,90L,91L,92L,93L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039141Inst : IEnumerable<long>
{
public static readonly long[] Value=A039141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039141.Bytes);
public long this[int i]=>Value[i];

public static A039141Inst Instance=new A039141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039140
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,10L,11L,12L,14L,15L,16L,17L,18L,20L,21L,22L,24L,25L,26L,27L,28L,39L,40L,41L,42L,44L,45L,46L,47L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,61L,62L,64L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,93L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039140Inst : IEnumerable<long>
{
public static readonly long[] Value=A039140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039140.Bytes);
public long this[int i]=>Value[i];

public static A039140Inst Instance=new A039140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039139
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,9L,10L,11L,12L,14L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,27L,29L,38L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,67L,69L,70L,71L,72L,74L,75L,76L,77L,79L,83L,90L,91L,92L,94L,95L,96L,97L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039139Inst : IEnumerable<long>
{
public static readonly long[] Value=A039139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039139.Bytes);
public long this[int i]=>Value[i];

public static A039139Inst Instance=new A039139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039138
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,16L,18L,19L,20L,21L,22L,24L,25L,26L,28L,29L,37L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,58L,59L,60L,61L,62L,64L,65L,66L,68L,69L,73L,80L,81L,82L,84L,85L,86L,88L,89L,90L,91L,92L,94L,95L,96L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039138Inst : IEnumerable<long>
{
public static readonly long[] Value=A039138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039138.Bytes);
public long this[int i]=>Value[i];

public static A039138Inst Instance=new A039138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039137
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,9L,10L,11L,12L,14L,15L,17L,18L,19L,20L,21L,22L,24L,25L,27L,28L,29L,36L,40L,41L,42L,44L,45L,47L,48L,49L,50L,51L,52L,54L,55L,57L,58L,59L,63L,70L,71L,72L,74L,75L,77L,78L,79L,80L,81L,82L,84L,85L,87L,88L,89L,90L,91L,92L,94L,95L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039137Inst : IEnumerable<long>
{
public static readonly long[] Value=A039137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039137.Bytes);
public long this[int i]=>Value[i];

public static A039137Inst Instance=new A039137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039136
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,9L,10L,11L,12L,14L,16L,17L,18L,19L,20L,21L,22L,24L,26L,27L,28L,29L,35L,40L,41L,42L,44L,46L,47L,48L,49L,53L,60L,61L,62L,64L,66L,67L,68L,69L,70L,71L,72L,74L,76L,77L,78L,79L,80L,81L,82L,84L,86L,87L,88L,89L,90L,91L,92L,94L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039136Inst : IEnumerable<long>
{
public static readonly long[] Value=A039136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039136.Bytes);
public long this[int i]=>Value[i];

public static A039136Inst Instance=new A039136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039135
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,21L,22L,25L,26L,27L,28L,29L,34L,43L,50L,51L,52L,55L,56L,57L,58L,59L,60L,61L,62L,65L,66L,67L,68L,69L,70L,71L,72L,75L,76L,77L,78L,79L,80L,81L,82L,85L,86L,87L,88L,89L,90L,91L,92L,95L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039135Inst : IEnumerable<long>
{
public static readonly long[] Value=A039135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039135.Bytes);
public long this[int i]=>Value[i];

public static A039135Inst Instance=new A039135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039134
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,8L,10L,11L,13L,14L,15L,16L,17L,18L,29L,30L,31L,33L,34L,35L,36L,37L,38L,40L,41L,43L,44L,45L,46L,47L,48L,50L,51L,53L,54L,55L,56L,57L,58L,60L,61L,63L,64L,65L,66L,67L,68L,70L,71L,73L,74L,75L,76L,77L,78L,80L,81L,83L,84L,85L,86L,87L,88L,92L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039134Inst : IEnumerable<long>
{
public static readonly long[] Value=A039134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039134.Bytes);
public long this[int i]=>Value[i];

public static A039134Inst Instance=new A039134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039133
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,17L,19L,28L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,67L,69L,70L,71L,73L,74L,75L,76L,77L,79L,82L,90L,91L,93L,94L,95L,96L,97L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039133Inst : IEnumerable<long>
{
public static readonly long[] Value=A039133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039133.Bytes);
public long this[int i]=>Value[i];

public static A039133Inst Instance=new A039133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039116
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,50L,61L,62L,63L,64L,66L,67L,68L,69L,71L,72L,73L,74L,76L,77L,78L,79L,81L,82L,83L,84L,86L,87L,88L,89L,91L,92L,93L,94L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039116Inst : IEnumerable<long>
{
public static readonly long[] Value=A039116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039116.Bytes);
public long this[int i]=>Value[i];

public static A039116Inst Instance=new A039116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039115
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,9L,11L,12L,13L,15L,16L,17L,18L,19L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,35L,36L,37L,38L,39L,40L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,65L,66L,67L,68L,69L,71L,72L,73L,75L,76L,77L,78L,79L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039115Inst : IEnumerable<long>
{
public static readonly long[] Value=A039115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039115.Bytes);
public long this[int i]=>Value[i];

public static A039115Inst Instance=new A039115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039114
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,9L,11L,12L,14L,15L,16L,17L,18L,19L,21L,22L,24L,25L,26L,27L,28L,29L,30L,41L,42L,44L,45L,46L,47L,48L,49L,51L,52L,54L,55L,56L,57L,58L,59L,61L,62L,64L,65L,66L,67L,68L,69L,71L,72L,74L,75L,76L,77L,78L,79L,81L,82L,84L,85L,86L,87L,88L,89L,91L,92L,94L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039114Inst : IEnumerable<long>
{
public static readonly long[] Value=A039114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039114.Bytes);
public long this[int i]=>Value[i];

public static A039114Inst Instance=new A039114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039113
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,9L,11L,13L,14L,15L,16L,17L,18L,19L,20L,31L,33L,34L,35L,36L,37L,38L,39L,41L,43L,44L,45L,46L,47L,48L,49L,51L,53L,54L,55L,56L,57L,58L,59L,61L,63L,64L,65L,66L,67L,68L,69L,71L,73L,74L,75L,76L,77L,78L,79L,81L,83L,84L,85L,86L,87L,88L,89L,91L,93L,94L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039113Inst : IEnumerable<long>
{
public static readonly long[] Value=A039113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039113.Bytes);
public long this[int i]=>Value[i];

public static A039113Inst Instance=new A039113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039112
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,22L,23L,24L,25L,26L,27L,28L,29L,32L,33L,34L,35L,36L,37L,38L,39L,42L,43L,44L,45L,46L,47L,48L,49L,52L,53L,54L,55L,56L,57L,58L,59L,62L,63L,64L,65L,66L,67L,68L,69L,72L,73L,74L,75L,76L,77L,78L,79L,82L,83L,84L,85L,86L,87L,88L,89L,92L,93L,94L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039112Inst : IEnumerable<long>
{
public static readonly long[] Value=A039112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039112.Bytes);
public long this[int i]=>Value[i];

public static A039112Inst Instance=new A039112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039111
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,13L,14L,15L,18L,19L,20L,21L,22L,23L,24L,27L,28L,29L,30L,31L,32L,33L,36L,37L,38L,39L,40L,41L,42L,45L,46L,47L,48L,49L,50L,51L,54L,55L,56L,57L,58L,59L,60L,71L,79L,81L,82L,83L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L,96L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039111Inst : IEnumerable<long>
{
public static readonly long[] Value=A039111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039111.Bytes);
public long this[int i]=>Value[i];

public static A039111Inst Instance=new A039111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039110
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,9L,10L,11L,12L,13L,14L,16L,18L,19L,20L,21L,22L,23L,25L,27L,28L,29L,30L,31L,32L,34L,36L,37L,38L,39L,40L,41L,43L,45L,46L,47L,48L,49L,50L,52L,62L,63L,64L,65L,66L,67L,68L,70L,78L,81L,82L,83L,84L,85L,86L,88L,90L,91L,92L,93L,94L,95L,97L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039110Inst : IEnumerable<long>
{
public static readonly long[] Value=A039110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039110.Bytes);
public long this[int i]=>Value[i];

public static A039110Inst Instance=new A039110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039109
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,9L,10L,11L,12L,13L,14L,17L,18L,19L,20L,21L,22L,23L,26L,27L,28L,29L,30L,31L,32L,35L,36L,37L,38L,39L,40L,41L,44L,45L,46L,47L,48L,49L,50L,53L,61L,69L,72L,73L,74L,75L,76L,77L,80L,81L,82L,83L,84L,85L,86L,89L,90L,91L,92L,93L,94L,95L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039109Inst : IEnumerable<long>
{
public static readonly long[] Value=A039109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039109.Bytes);
public long this[int i]=>Value[i];

public static A039109Inst Instance=new A039109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039108
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,9L,10L,11L,12L,13L,15L,16L,18L,19L,20L,21L,22L,24L,25L,27L,28L,29L,30L,31L,33L,34L,36L,37L,38L,39L,40L,42L,43L,53L,54L,55L,56L,57L,58L,60L,61L,63L,64L,65L,66L,67L,69L,70L,77L,81L,82L,83L,84L,85L,87L,88L,90L,91L,92L,93L,94L,96L,97L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039108Inst : IEnumerable<long>
{
public static readonly long[] Value=A039108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039108.Bytes);
public long this[int i]=>Value[i];

public static A039108Inst Instance=new A039108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039107
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,9L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,22L,24L,26L,27L,28L,29L,30L,31L,33L,35L,36L,37L,38L,39L,40L,42L,44L,52L,54L,55L,56L,57L,58L,60L,62L,68L,72L,73L,74L,75L,76L,78L,80L,81L,82L,83L,84L,85L,87L,89L,90L,91L,92L,93L,94L,96L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039107Inst : IEnumerable<long>
{
public static readonly long[] Value=A039107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039107.Bytes);
public long this[int i]=>Value[i];

public static A039107Inst Instance=new A039107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039106
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,8L,9L,10L,11L,12L,13L,16L,17L,18L,19L,20L,21L,22L,25L,26L,27L,28L,29L,30L,31L,34L,35L,36L,37L,38L,39L,40L,43L,44L,51L,59L,63L,64L,65L,66L,67L,70L,71L,72L,73L,74L,75L,76L,79L,80L,81L,82L,83L,84L,85L,88L,89L,90L,91L,92L,93L,94L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039106Inst : IEnumerable<long>
{
public static readonly long[] Value=A039106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039106.Bytes);
public long this[int i]=>Value[i];

public static A039106Inst Instance=new A039106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039105
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,9L,10L,11L,12L,14L,15L,16L,18L,19L,20L,21L,23L,24L,25L,27L,28L,29L,30L,32L,33L,34L,44L,45L,46L,47L,48L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,68L,69L,70L,76L,81L,82L,83L,84L,86L,87L,88L,90L,91L,92L,93L,95L,96L,97L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039105Inst : IEnumerable<long>
{
public static readonly long[] Value=A039105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039105.Bytes);
public long this[int i]=>Value[i];

public static A039105Inst Instance=new A039105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039104
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,10L,11L,12L,14L,15L,17L,18L,19L,20L,21L,23L,24L,26L,27L,28L,29L,30L,32L,33L,35L,43L,45L,46L,47L,48L,50L,51L,53L,54L,55L,56L,57L,59L,60L,62L,67L,72L,73L,74L,75L,77L,78L,80L,81L,82L,83L,84L,86L,87L,89L,90L,91L,92L,93L,95L,96L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039104Inst : IEnumerable<long>
{
public static readonly long[] Value=A039104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039104.Bytes);
public long this[int i]=>Value[i];

public static A039104Inst Instance=new A039104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039103
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,8L,9L,10L,11L,12L,14L,16L,17L,18L,19L,20L,21L,23L,25L,26L,27L,28L,29L,30L,32L,34L,35L,42L,45L,46L,47L,48L,50L,52L,53L,58L,63L,64L,65L,66L,68L,70L,71L,72L,73L,74L,75L,77L,79L,80L,81L,82L,83L,84L,86L,88L,89L,90L,91L,92L,93L,95L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039103Inst : IEnumerable<long>
{
public static readonly long[] Value=A039103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039103.Bytes);
public long this[int i]=>Value[i];

public static A039103Inst Instance=new A039103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039102
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,21L,24L,25L,26L,27L,28L,29L,30L,33L,34L,35L,41L,49L,54L,55L,56L,57L,60L,61L,62L,63L,64L,65L,66L,69L,70L,71L,72L,73L,74L,75L,78L,79L,80L,81L,82L,83L,84L,87L,88L,89L,90L,91L,92L,93L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039102Inst : IEnumerable<long>
{
public static readonly long[] Value=A039102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039102.Bytes);
public long this[int i]=>Value[i];

public static A039102Inst Instance=new A039102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039101
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,18L,19L,20L,22L,23L,24L,25L,35L,36L,37L,38L,40L,41L,42L,43L,45L,46L,47L,49L,50L,51L,52L,54L,55L,56L,58L,59L,60L,61L,63L,64L,65L,67L,68L,69L,70L,75L,81L,82L,83L,85L,86L,87L,88L,90L,91L,92L,94L,95L,96L,97L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039101Inst : IEnumerable<long>
{
public static readonly long[] Value=A039101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039101.Bytes);
public long this[int i]=>Value[i];

public static A039101Inst Instance=new A039101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039100
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,26L,34L,36L,37L,38L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,56L,58L,59L,60L,62L,66L,72L,73L,74L,76L,77L,78L,80L,81L,82L,83L,85L,86L,87L,89L,90L,91L,92L,94L,95L,96L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039100Inst : IEnumerable<long>
{
public static readonly long[] Value=A039100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039100.Bytes);
public long this[int i]=>Value[i];

public static A039100Inst Instance=new A039100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039099
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,9L,10L,11L,13L,14L,16L,17L,18L,19L,20L,22L,23L,25L,26L,33L,36L,37L,38L,40L,41L,43L,44L,45L,46L,47L,49L,50L,52L,53L,57L,63L,64L,65L,67L,68L,70L,71L,72L,73L,74L,76L,77L,79L,80L,81L,82L,83L,85L,86L,88L,89L,90L,91L,92L,94L,95L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039099Inst : IEnumerable<long>
{
public static readonly long[] Value=A039099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039099.Bytes);
public long this[int i]=>Value[i];

public static A039099Inst Instance=new A039099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039098
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,9L,10L,11L,13L,15L,16L,17L,18L,19L,20L,22L,24L,25L,26L,32L,36L,37L,38L,40L,42L,43L,44L,48L,54L,55L,56L,58L,60L,61L,62L,63L,64L,65L,67L,69L,70L,71L,72L,73L,74L,76L,78L,79L,80L,81L,82L,83L,85L,87L,88L,89L,90L,91L,92L,94L,96L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039098Inst : IEnumerable<long>
{
public static readonly long[] Value=A039098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039098.Bytes);
public long this[int i]=>Value[i];

public static A039098Inst Instance=new A039098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039097
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,9L,10L,11L,14L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,31L,39L,45L,46L,47L,50L,51L,52L,53L,54L,55L,56L,59L,60L,61L,62L,63L,64L,65L,68L,69L,70L,71L,72L,73L,74L,77L,78L,79L,80L,81L,82L,83L,86L,87L,88L,89L,90L,91L,92L,95L,96L,97L,98L,99L,100L,101L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039097Inst : IEnumerable<long>
{
public static readonly long[] Value=A039097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039097.Bytes);
public long this[int i]=>Value[i];

public static A039097Inst Instance=new A039097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039096
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,9L,10L,12L,13L,14L,15L,16L,26L,27L,28L,30L,31L,32L,33L,34L,36L,37L,39L,40L,41L,42L,43L,45L,46L,48L,49L,50L,51L,52L,54L,55L,57L,58L,59L,60L,61L,63L,64L,66L,67L,68L,69L,70L,74L,81L,82L,84L,85L,86L,87L,88L,90L,91L,93L,94L,95L,96L,97L,107L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039096Inst : IEnumerable<long>
{
public static readonly long[] Value=A039096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039096.Bytes);
public long this[int i]=>Value[i];

public static A039096Inst Instance=new A039096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039095
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,10L,12L,13L,14L,15L,17L,25L,27L,28L,30L,31L,32L,33L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,53L,54L,55L,57L,58L,59L,60L,62L,65L,72L,73L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,89L,90L,91L,93L,94L,95L,96L,98L,106L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039095Inst : IEnumerable<long>
{
public static readonly long[] Value=A039095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039095.Bytes);
public long this[int i]=>Value[i];

public static A039095Inst Instance=new A039095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039094
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,9L,10L,12L,13L,14L,16L,17L,24L,27L,28L,30L,31L,32L,34L,35L,36L,37L,39L,40L,41L,43L,44L,45L,46L,48L,49L,50L,52L,53L,56L,63L,64L,66L,67L,68L,70L,71L,72L,73L,75L,76L,77L,79L,80L,81L,82L,84L,85L,86L,88L,89L,90L,91L,93L,94L,95L,97L,98L,105L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039094Inst : IEnumerable<long>
{
public static readonly long[] Value=A039094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039094.Bytes);
public long this[int i]=>Value[i];

public static A039094Inst Instance=new A039094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039093
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,8L,9L,10L,12L,13L,15L,16L,17L,23L,27L,28L,30L,31L,33L,34L,35L,36L,37L,39L,40L,42L,43L,44L,47L,54L,55L,57L,58L,60L,61L,62L,63L,64L,66L,67L,69L,70L,71L,72L,73L,75L,76L,78L,79L,80L,81L,82L,84L,85L,87L,88L,89L,90L,91L,93L,94L,96L,97L,98L,104L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039093Inst : IEnumerable<long>
{
public static readonly long[] Value=A039093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039093.Bytes);
public long this[int i]=>Value[i];

public static A039093Inst Instance=new A039093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039092
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,17L,22L,27L,28L,30L,32L,33L,34L,35L,38L,45L,46L,48L,50L,51L,52L,53L,54L,55L,57L,59L,60L,61L,62L,63L,64L,66L,68L,69L,70L,71L,72L,73L,75L,77L,78L,79L,80L,81L,82L,84L,86L,87L,88L,89L,90L,91L,93L,95L,96L,97L,98L,103L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039092Inst : IEnumerable<long>
{
public static readonly long[] Value=A039092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039092.Bytes);
public long this[int i]=>Value[i];

public static A039092Inst Instance=new A039092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039091
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,8L,9L,10L,13L,14L,15L,16L,17L,21L,29L,36L,37L,40L,41L,42L,43L,44L,45L,46L,49L,50L,51L,52L,53L,54L,55L,58L,59L,60L,61L,62L,63L,64L,67L,68L,69L,70L,71L,72L,73L,76L,77L,78L,79L,80L,81L,82L,85L,86L,87L,88L,89L,90L,91L,94L,95L,96L,97L,98L,102L,110L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039091Inst : IEnumerable<long>
{
public static readonly long[] Value=A039091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039091.Bytes);
public long this[int i]=>Value[i];

public static A039091Inst Instance=new A039091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039090
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,17L,18L,20L,21L,22L,23L,24L,25L,27L,29L,30L,31L,32L,33L,34L,36L,38L,39L,40L,41L,42L,43L,45L,47L,48L,49L,50L,51L,52L,54L,56L,57L,58L,59L,60L,61L,63L,65L,66L,67L,68L,69L,70L,73L,89L,107L,116L,125L,134L,143L,152L,153L,155L,156L,157L,158L,159L,160L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039090Inst : IEnumerable<long>
{
public static readonly long[] Value=A039090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039090.Bytes);
public long this[int i]=>Value[i];

public static A039090Inst Instance=new A039090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039089
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,8L,16L,18L,20L,21L,22L,23L,24L,26L,27L,29L,30L,31L,32L,33L,35L,36L,38L,39L,40L,41L,42L,44L,45L,47L,48L,49L,50L,51L,53L,54L,56L,57L,58L,59L,60L,62L,64L,72L,74L,75L,76L,77L,78L,80L,88L,106L,115L,124L,133L,142L,144L,146L,147L,148L,149L,150L,152L,160L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039089Inst : IEnumerable<long>
{
public static readonly long[] Value=A039089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039089.Bytes);
public long this[int i]=>Value[i];

public static A039089Inst Instance=new A039089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039088
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,8L,15L,18L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,38L,39L,40L,41L,43L,44L,45L,47L,48L,49L,50L,52L,53L,55L,63L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,77L,79L,80L,87L,105L,114L,123L,132L,135L,137L,138L,139L,140L,142L,143L,150L,159L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039088Inst : IEnumerable<long>
{
public static readonly long[] Value=A039088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039088.Bytes);
public long this[int i]=>Value[i];

public static A039088Inst Instance=new A039088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039087
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,8L,14L,18L,20L,21L,22L,24L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,42L,43L,44L,46L,54L,56L,57L,58L,60L,61L,62L,63L,65L,66L,67L,69L,70L,71L,72L,74L,75L,76L,78L,79L,80L,86L,104L,113L,122L,126L,128L,129L,130L,132L,133L,134L,140L,149L,158L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039087Inst : IEnumerable<long>
{
public static readonly long[] Value=A039087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039087.Bytes);
public long this[int i]=>Value[i];

public static A039087Inst Instance=new A039087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039086
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,7L,8L,13L,18L,20L,21L,23L,24L,25L,26L,27L,29L,30L,32L,33L,34L,35L,37L,45L,47L,48L,50L,51L,52L,53L,54L,56L,57L,59L,60L,61L,62L,63L,65L,66L,68L,69L,70L,71L,72L,74L,75L,77L,78L,79L,80L,85L,103L,112L,117L,119L,120L,122L,123L,124L,125L,130L,139L,148L,157L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039086Inst : IEnumerable<long>
{
public static readonly long[] Value=A039086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039086.Bytes);
public long this[int i]=>Value[i];

public static A039086Inst Instance=new A039086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039085
{
public static readonly long[] Value={ 0L,2L,4L,5L,6L,7L,8L,12L,18L,20L,22L,23L,24L,25L,26L,28L,36L,38L,40L,41L,42L,43L,44L,45L,47L,49L,50L,51L,52L,53L,54L,56L,58L,59L,60L,61L,62L,63L,65L,67L,68L,69L,70L,71L,72L,74L,76L,77L,78L,79L,80L,84L,102L,108L,110L,112L,113L,114L,115L,116L,120L,129L,138L,147L,156L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039085Inst : IEnumerable<long>
{
public static readonly long[] Value=A039085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039085.Bytes);
public long this[int i]=>Value[i];

public static A039085Inst Instance=new A039085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039084
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,8L,11L,19L,27L,30L,31L,32L,33L,34L,35L,36L,39L,40L,41L,42L,43L,44L,45L,48L,49L,50L,51L,52L,53L,54L,57L,58L,59L,60L,61L,62L,63L,66L,67L,68L,69L,70L,71L,72L,75L,76L,77L,78L,79L,80L,83L,99L,102L,103L,104L,105L,106L,107L,110L,119L,128L,137L,146L,155L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039084Inst : IEnumerable<long>
{
public static readonly long[] Value=A039084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039084.Bytes);
public long this[int i]=>Value[i];

public static A039084Inst Instance=new A039084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039083
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,11L,12L,13L,14L,15L,17L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,32L,33L,35L,37L,38L,39L,40L,41L,42L,44L,46L,47L,48L,49L,50L,51L,53L,55L,56L,57L,58L,59L,60L,62L,63L,73L,74L,75L,76L,77L,78L,80L,88L,91L,92L,93L,94L,95L,96L,98L,100L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039083Inst : IEnumerable<long>
{
public static readonly long[] Value=A039083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039083.Bytes);
public long this[int i]=>Value[i];

public static A039083Inst Instance=new A039083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039082
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,10L,11L,12L,13L,14L,16L,17L,19L,20L,21L,22L,23L,25L,26L,28L,29L,30L,31L,32L,34L,35L,37L,38L,39L,40L,41L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,64L,65L,66L,67L,68L,70L,71L,73L,74L,75L,76L,77L,79L,80L,87L,91L,92L,93L,94L,95L,97L,98L,100L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039082Inst : IEnumerable<long>
{
public static readonly long[] Value=A039082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039082.Bytes);
public long this[int i]=>Value[i];

public static A039082Inst Instance=new A039082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039081
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,28L,29L,30L,31L,33L,34L,35L,37L,38L,39L,40L,42L,43L,44L,45L,55L,56L,57L,58L,60L,61L,62L,64L,65L,66L,67L,69L,70L,71L,73L,74L,75L,76L,78L,79L,80L,86L,91L,92L,93L,94L,96L,97L,98L,100L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039081Inst : IEnumerable<long>
{
public static readonly long[] Value=A039081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039081.Bytes);
public long this[int i]=>Value[i];

public static A039081Inst Instance=new A039081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039080
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,14L,15L,16L,17L,19L,20L,21L,23L,24L,25L,26L,28L,29L,30L,32L,33L,34L,35L,36L,46L,47L,48L,50L,51L,52L,53L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,68L,69L,70L,71L,73L,74L,75L,77L,78L,79L,80L,85L,91L,92L,93L,95L,96L,97L,98L,100L,101L,102L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039080Inst : IEnumerable<long>
{
public static readonly long[] Value=A039080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039080.Bytes);
public long this[int i]=>Value[i];

public static A039080Inst Instance=new A039080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039079
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,10L,11L,13L,14L,15L,16L,17L,19L,20L,22L,23L,24L,25L,26L,27L,37L,38L,40L,41L,42L,43L,44L,46L,47L,49L,50L,51L,52L,53L,55L,56L,58L,59L,60L,61L,62L,64L,65L,67L,68L,69L,70L,71L,73L,74L,76L,77L,78L,79L,80L,84L,91L,92L,94L,95L,96L,97L,98L,100L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039079Inst : IEnumerable<long>
{
public static readonly long[] Value=A039079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039079.Bytes);
public long this[int i]=>Value[i];

public static A039079Inst Instance=new A039079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039078
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,10L,12L,13L,14L,15L,16L,17L,18L,28L,30L,31L,32L,33L,34L,35L,37L,39L,40L,41L,42L,43L,44L,46L,48L,49L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,64L,66L,67L,68L,69L,70L,71L,73L,75L,76L,77L,78L,79L,80L,83L,91L,93L,94L,95L,96L,97L,98L,99L,109L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039078Inst : IEnumerable<long>
{
public static readonly long[] Value=A039078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039078.Bytes);
public long this[int i]=>Value[i];

public static A039078Inst Instance=new A039078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039077
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,20L,21L,22L,23L,24L,25L,26L,29L,30L,31L,32L,33L,34L,35L,38L,39L,40L,41L,42L,43L,44L,47L,48L,49L,50L,51L,52L,53L,56L,57L,58L,59L,60L,61L,62L,65L,66L,67L,68L,69L,70L,71L,74L,75L,76L,77L,78L,79L,80L,83L,84L,85L,86L,87L,88L,89L,99L,108L,117L,126L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039077Inst : IEnumerable<long>
{
public static readonly long[] Value=A039077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039077.Bytes);
public long this[int i]=>Value[i];

public static A039077Inst Instance=new A039077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039076
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,9L,10L,11L,12L,13L,16L,17L,18L,19L,20L,21L,24L,25L,26L,27L,28L,29L,32L,33L,34L,35L,36L,37L,40L,41L,42L,43L,44L,45L,55L,62L,64L,65L,66L,67L,68L,69L,72L,73L,74L,75L,76L,77L,80L,81L,82L,83L,84L,85L,88L,89L,90L,91L,92L,93L,96L,97L,98L,99L,100L,101L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039076Inst : IEnumerable<long>
{
public static readonly long[] Value=A039076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039076.Bytes);
public long this[int i]=>Value[i];

public static A039076Inst Instance=new A039076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039075
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,9L,10L,11L,12L,14L,16L,17L,18L,19L,20L,22L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,47L,48L,49L,50L,51L,52L,54L,61L,64L,65L,66L,67L,68L,70L,72L,73L,74L,75L,76L,78L,80L,81L,82L,83L,84L,86L,88L,89L,90L,91L,92L,94L,96L,97L,98L,99L,100L,102L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039075Inst : IEnumerable<long>
{
public static readonly long[] Value=A039075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039075.Bytes);
public long this[int i]=>Value[i];

public static A039075Inst Instance=new A039075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039074
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,8L,9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,28L,31L,32L,33L,34L,35L,36L,39L,46L,53L,56L,57L,58L,59L,60L,63L,64L,65L,66L,67L,68L,71L,72L,73L,74L,75L,76L,79L,80L,81L,82L,83L,84L,87L,88L,89L,90L,91L,92L,95L,96L,97L,98L,99L,100L,103L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039074Inst : IEnumerable<long>
{
public static readonly long[] Value=A039074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039074.Bytes);
public long this[int i]=>Value[i];

public static A039074Inst Instance=new A039074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039073
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,10L,11L,13L,14L,16L,17L,18L,19L,21L,22L,24L,25L,26L,27L,29L,30L,39L,40L,41L,42L,43L,45L,46L,48L,49L,50L,51L,53L,54L,60L,64L,65L,66L,67L,69L,70L,72L,73L,74L,75L,77L,78L,80L,81L,82L,83L,85L,86L,88L,89L,90L,91L,93L,94L,103L,104L,105L,106L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039073Inst : IEnumerable<long>
{
public static readonly long[] Value=A039073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039073.Bytes);
public long this[int i]=>Value[i];

public static A039073Inst Instance=new A039073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039072
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,8L,9L,10L,11L,13L,15L,16L,17L,18L,19L,21L,23L,24L,25L,26L,27L,29L,31L,38L,40L,41L,42L,43L,45L,47L,52L,56L,57L,58L,59L,61L,63L,64L,65L,66L,67L,69L,71L,72L,73L,74L,75L,77L,79L,80L,81L,82L,83L,85L,87L,88L,89L,90L,91L,93L,95L,102L,104L,105L,106L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039072Inst : IEnumerable<long>
{
public static readonly long[] Value=A039072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039072.Bytes);
public long this[int i]=>Value[i];

public static A039072Inst Instance=new A039072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039071
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,10L,11L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,30L,31L,37L,44L,48L,49L,50L,51L,54L,55L,56L,57L,58L,59L,62L,63L,64L,65L,66L,67L,70L,71L,72L,73L,74L,75L,78L,79L,80L,81L,82L,83L,86L,87L,88L,89L,90L,91L,94L,95L,101L,108L,112L,113L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039071Inst : IEnumerable<long>
{
public static readonly long[] Value=A039071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039071.Bytes);
public long this[int i]=>Value[i];

public static A039071Inst Instance=new A039071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039070
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,31L,32L,33L,34L,36L,37L,38L,40L,41L,42L,44L,45L,46L,48L,49L,50L,52L,53L,54L,59L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L,86L,95L,96L,97L,98L,100L,101L,102L,104L,105L,106L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039070Inst : IEnumerable<long>
{
public static readonly long[] Value=A039070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039070.Bytes);
public long this[int i]=>Value[i];

public static A039070Inst Instance=new A039070Inst();

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