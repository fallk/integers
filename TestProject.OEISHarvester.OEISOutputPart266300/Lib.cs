using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A029184
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,1L,3L,1L,3L,3L,4L,3L,5L,5L,6L,5L,8L,7L,9L,8L,12L,10L,13L,12L,16L,14L,18L,17L,21L,19L,24L,23L,27L,26L,31L,30L,34L,34L,39L,38L,43L,43L,49L,47L,54L,53L,60L,58L,66L,65L,72L,71L,79L,79L,86L,86L,94L,94L,102L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029184Inst : IEnumerable<long>
{
public static readonly long[] Value=A029184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029184.Bytes);
public long this[int i]=>Value[i];

public static A029184Inst Instance=new A029184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029185
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,1L,3L,1L,3L,2L,5L,2L,6L,3L,8L,3L,9L,5L,11L,6L,12L,8L,15L,9L,17L,11L,21L,12L,23L,15L,27L,17L,29L,21L,34L,23L,37L,27L,43L,29L,47L,34L,53L,37L,57L,43L,64L,47L,69L,53L,77L,57L,83L,64L,92L,69L,98L,77L,108L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029185Inst : IEnumerable<long>
{
public static readonly long[] Value=A029185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029185.Bytes);
public long this[int i]=>Value[i];

public static A029185Inst Instance=new A029185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029186
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,4L,1L,4L,1L,6L,2L,6L,2L,9L,4L,10L,4L,13L,6L,14L,6L,18L,9L,20L,10L,24L,13L,26L,14L,31L,18L,34L,20L,40L,24L,43L,26L,50L,31L,54L,34L,62L,40L,66L,43L,75L,50L,80L,54L,90L,62L,96L,66L,107L,75L,114L,80L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029186Inst : IEnumerable<long>
{
public static readonly long[] Value=A029186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029186.Bytes);
public long this[int i]=>Value[i];

public static A029186Inst Instance=new A029186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029187
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,4L,0L,4L,1L,6L,1L,6L,2L,9L,2L,9L,4L,12L,4L,13L,6L,17L,6L,18L,9L,22L,9L,24L,12L,29L,13L,31L,17L,36L,18L,39L,22L,45L,24L,48L,29L,55L,31L,59L,36L,67L,39L,71L,45L,80L,48L,85L,55L,95L,59L,100L,67L,111L,71L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029187Inst : IEnumerable<long>
{
public static readonly long[] Value=A029187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029187.Bytes);
public long this[int i]=>Value[i];

public static A029187Inst Instance=new A029187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029188
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,3L,1L,4L,1L,5L,2L,6L,2L,7L,3L,9L,4L,11L,5L,13L,6L,15L,7L,17L,9L,20L,11L,23L,13L,26L,15L,29L,17L,33L,20L,37L,23L,42L,26L,46L,29L,51L,33L,56L,37L,62L,42L,68L,46L,74L,51L,81L,56L,88L,62L,96L,68L,104L,74L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029188Inst : IEnumerable<long>
{
public static readonly long[] Value=A029188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029188.Bytes);
public long this[int i]=>Value[i];

public static A029188Inst Instance=new A029188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029189
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,3L,1L,3L,2L,4L,3L,4L,4L,5L,5L,6L,6L,8L,7L,10L,8L,12L,9L,14L,11L,16L,13L,18L,16L,20L,19L,22L,22L,25L,25L,28L,28L,32L,31L,36L,34L,41L,38L,45L,42L,50L,47L,54L,52L,59L,58L,64L,64L,70L,70L,76L,76L,83L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029189Inst : IEnumerable<long>
{
public static readonly long[] Value=A029189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029189.Bytes);
public long this[int i]=>Value[i];

public static A029189Inst Instance=new A029189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029190
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,3L,1L,3L,1L,5L,2L,5L,2L,7L,3L,8L,3L,10L,5L,11L,5L,14L,7L,15L,8L,18L,10L,20L,11L,23L,14L,25L,15L,30L,18L,32L,20L,37L,23L,40L,25L,45L,30L,48L,32L,55L,37L,58L,40L,65L,45L,70L,48L,77L,55L,82L,58L,91L,65L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029190Inst : IEnumerable<long>
{
public static readonly long[] Value=A029190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029190.Bytes);
public long this[int i]=>Value[i];

public static A029190Inst Instance=new A029190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029191
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,3L,0L,4L,1L,5L,1L,6L,2L,7L,2L,8L,3L,10L,4L,12L,5L,14L,6L,16L,7L,18L,8L,21L,10L,24L,12L,27L,14L,30L,16L,33L,18L,37L,21L,41L,24L,46L,27L,50L,30L,55L,33L,60L,37L,66L,41L,72L,46L,78L,50L,84L,55L,91L,60L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029191Inst : IEnumerable<long>
{
public static readonly long[] Value=A029191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029191.Bytes);
public long this[int i]=>Value[i];

public static A029191Inst Instance=new A029191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029192
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,3L,0L,3L,1L,5L,1L,5L,2L,7L,2L,7L,3L,9L,3L,10L,5L,13L,5L,14L,7L,17L,7L,18L,9L,21L,10L,23L,13L,27L,14L,29L,17L,33L,18L,35L,21L,40L,23L,43L,27L,49L,29L,52L,33L,58L,35L,61L,40L,68L,43L,72L,49L,80L,52L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029192Inst : IEnumerable<long>
{
public static readonly long[] Value=A029192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029192.Bytes);
public long this[int i]=>Value[i];

public static A029192Inst Instance=new A029192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029193
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,2L,2L,2L,3L,3L,5L,4L,6L,5L,7L,7L,9L,9L,11L,11L,13L,13L,16L,16L,19L,19L,22L,22L,26L,26L,30L,30L,34L,35L,39L,40L,44L,45L,50L,51L,57L,57L,63L,64L,70L,72L,78L,80L,86L,88L,95L,97L,105L,107L,115L,117L,125L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029193Inst : IEnumerable<long>
{
public static readonly long[] Value=A029193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029193.Bytes);
public long this[int i]=>Value[i];

public static A029193Inst Instance=new A029193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029194
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,1L,3L,1L,4L,2L,5L,3L,6L,4L,8L,5L,10L,6L,12L,8L,14L,10L,17L,12L,20L,14L,23L,17L,27L,20L,31L,23L,35L,27L,40L,31L,45L,35L,51L,40L,57L,45L,63L,51L,70L,57L,78L,63L,86L,70L,94L,78L,103L,86L,113L,94L,123L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029194Inst : IEnumerable<long>
{
public static readonly long[] Value=A029194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029194.Bytes);
public long this[int i]=>Value[i];

public static A029194Inst Instance=new A029194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029195
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,1L,2L,2L,3L,3L,4L,3L,5L,5L,6L,6L,8L,7L,10L,9L,11L,11L,14L,13L,16L,16L,18L,19L,22L,21L,25L,25L,28L,29L,33L,32L,37L,37L,41L,42L,47L,46L,52L,53L,57L,59L,64L,64L,71L,72L,77L,79L,86L,86L,94L,95L,101L,104L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029195Inst : IEnumerable<long>
{
public static readonly long[] Value=A029195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029195.Bytes);
public long this[int i]=>Value[i];

public static A029195Inst Instance=new A029195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029196
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,2L,1L,2L,1L,4L,2L,5L,2L,5L,4L,7L,5L,8L,5L,11L,7L,13L,8L,14L,11L,17L,13L,19L,14L,24L,17L,27L,19L,29L,24L,34L,27L,37L,29L,44L,34L,49L,37L,52L,44L,59L,49L,64L,52L,73L,59L,80L,64L,85L,73L,94L,80L,101L,85L,113L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029196Inst : IEnumerable<long>
{
public static readonly long[] Value=A029196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029196.Bytes);
public long this[int i]=>Value[i];

public static A029196Inst Instance=new A029196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029213
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,3L,2L,3L,3L,4L,4L,4L,4L,5L,5L,7L,6L,8L,7L,9L,9L,10L,10L,11L,11L,13L,13L,15L,15L,17L,17L,19L,19L,21L,21L,23L,23L,26L,26L,29L,29L,32L,32L,35L,35L,38L,38L,41L,42L,45L,46L,49L,50L,54L,54L,58L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029213Inst : IEnumerable<long>
{
public static readonly long[] Value=A029213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029213.Bytes);
public long this[int i]=>Value[i];

public static A029213Inst Instance=new A029213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029214
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,1L,3L,1L,3L,1L,4L,2L,6L,3L,7L,3L,8L,4L,10L,6L,12L,7L,14L,8L,16L,10L,19L,12L,22L,14L,25L,16L,28L,19L,32L,22L,36L,25L,40L,28L,45L,32L,50L,36L,55L,40L,61L,45L,67L,50L,73L,55L,80L,61L,88L,67L,95L,73L,103L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029214Inst : IEnumerable<long>
{
public static readonly long[] Value=A029214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029214.Bytes);
public long this[int i]=>Value[i];

public static A029214Inst Instance=new A029214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029215
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,4L,7L,5L,8L,7L,9L,8L,11L,10L,12L,13L,14L,14L,17L,16L,19L,19L,22L,21L,26L,24L,28L,28L,31L,31L,36L,35L,39L,40L,43L,43L,49L,48L,53L,54L,58L,58L,65L,64L,70L,71L,76L,76L,84L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029215Inst : IEnumerable<long>
{
public static readonly long[] Value=A029215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029215.Bytes);
public long this[int i]=>Value[i];

public static A029215Inst Instance=new A029215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029216
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,1L,2L,1L,3L,1L,4L,2L,5L,2L,6L,3L,7L,4L,9L,5L,10L,6L,12L,7L,14L,9L,16L,10L,19L,12L,21L,14L,24L,16L,27L,19L,30L,21L,34L,24L,38L,27L,42L,30L,46L,34L,51L,38L,56L,42L,61L,46L,67L,51L,73L,56L,79L,61L,86L,67L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029216Inst : IEnumerable<long>
{
public static readonly long[] Value=A029216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029216.Bytes);
public long this[int i]=>Value[i];

public static A029216Inst Instance=new A029216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029217
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,1L,2L,1L,2L,2L,3L,3L,4L,3L,4L,4L,6L,5L,7L,6L,8L,7L,10L,9L,11L,10L,13L,12L,15L,14L,17L,16L,19L,19L,22L,21L,24L,24L,27L,27L,31L,30L,34L,33L,38L,37L,42L,41L,46L,45L,50L,50L,55L,55L,60L,60L,65L,65L,71L,71L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029217Inst : IEnumerable<long>
{
public static readonly long[] Value=A029217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029217.Bytes);
public long this[int i]=>Value[i];

public static A029217Inst Instance=new A029217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029218
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,1L,2L,1L,2L,1L,4L,2L,5L,2L,5L,2L,7L,4L,8L,5L,8L,5L,11L,7L,13L,8L,14L,8L,17L,11L,19L,13L,20L,14L,24L,17L,27L,19L,29L,20L,34L,24L,37L,27L,39L,29L,45L,34L,49L,37L,52L,39L,59L,45L,64L,49L,67L,52L,75L,59L,81L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029218Inst : IEnumerable<long>
{
public static readonly long[] Value=A029218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029218.Bytes);
public long this[int i]=>Value[i];

public static A029218Inst Instance=new A029218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029219
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,3L,1L,3L,1L,4L,1L,5L,2L,6L,3L,8L,3L,9L,4L,10L,5L,13L,6L,15L,8L,16L,9L,19L,10L,22L,13L,24L,15L,28L,16L,31L,19L,34L,22L,39L,24L,43L,28L,46L,31L,52L,34L,57L,39L,61L,43L,68L,46L,74L,52L,79L,57L,87L,61L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029219Inst : IEnumerable<long>
{
public static readonly long[] Value=A029219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029219.Bytes);
public long this[int i]=>Value[i];

public static A029219Inst Instance=new A029219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029220
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,3L,0L,3L,1L,4L,1L,5L,1L,6L,2L,7L,3L,8L,3L,10L,4L,12L,5L,13L,6L,15L,7L,18L,8L,20L,10L,22L,12L,25L,13L,28L,15L,31L,18L,34L,20L,38L,22L,42L,25L,46L,28L,50L,31L,55L,34L,60L,38L,65L,42L,70L,46L,76L,50L,82L,55L,88L,60L,95L,65L,102L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029220Inst : IEnumerable<long>
{
public static readonly long[] Value=A029220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029220.Bytes);
public long this[int i]=>Value[i];

public static A029220Inst Instance=new A029220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029221
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,2L,1L,3L,1L,4L,1L,4L,2L,5L,2L,7L,3L,8L,4L,9L,4L,11L,5L,12L,7L,14L,8L,17L,9L,18L,11L,20L,12L,24L,14L,26L,17L,29L,18L,33L,20L,35L,24L,39L,26L,44L,29L,47L,33L,51L,35L,57L,39L,61L,44L,66L,47L,73L,51L,77L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029221Inst : IEnumerable<long>
{
public static readonly long[] Value=A029221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029221.Bytes);
public long this[int i]=>Value[i];

public static A029221Inst Instance=new A029221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029222
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,2L,1L,2L,2L,3L,2L,3L,3L,3L,4L,5L,4L,6L,5L,7L,6L,9L,6L,10L,8L,11L,10L,13L,11L,14L,14L,15L,16L,18L,17L,20L,20L,22L,22L,26L,23L,29L,27L,31L,30L,35L,32L,38L,37L,40L,41L,45L,44L,49L,49L,52L,53L,58L,56L,63L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029222Inst : IEnumerable<long>
{
public static readonly long[] Value=A029222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029222.Bytes);
public long this[int i]=>Value[i];

public static A029222Inst Instance=new A029222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029223
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,2L,1L,2L,1L,4L,1L,4L,2L,4L,2L,7L,2L,7L,4L,7L,4L,11L,4L,11L,7L,11L,7L,16L,7L,16L,11L,16L,11L,23L,11L,23L,16L,23L,16L,31L,16L,31L,23L,31L,23L,41L,23L,41L,31L,41L,31L,53L,31L,53L,41L,53L,41L,67L,41L,67L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029223Inst : IEnumerable<long>
{
public static readonly long[] Value=A029223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029223.Bytes);
public long this[int i]=>Value[i];

public static A029223Inst Instance=new A029223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029224
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,3L,1L,4L,1L,4L,1L,5L,2L,6L,2L,7L,3L,9L,4L,10L,4L,11L,5L,13L,6L,15L,7L,17L,9L,19L,10L,21L,11L,23L,13L,26L,15L,29L,17L,32L,19L,35L,21L,38L,23L,42L,26L,46L,29L,50L,32L,54L,35L,58L,38L,63L,42L,68L,46L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029224Inst : IEnumerable<long>
{
public static readonly long[] Value=A029224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029224.Bytes);
public long this[int i]=>Value[i];

public static A029224Inst Instance=new A029224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029225
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,2L,1L,4L,1L,4L,1L,4L,2L,6L,2L,6L,2L,7L,4L,10L,4L,10L,4L,11L,6L,14L,6L,14L,7L,16L,10L,20L,10L,20L,11L,22L,14L,26L,14L,27L,16L,30L,20L,35L,20L,36L,22L,39L,26L,44L,27L,46L,30L,50L,35L,56L,36L,58L,39L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029225Inst : IEnumerable<long>
{
public static readonly long[] Value=A029225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029225.Bytes);
public long this[int i]=>Value[i];

public static A029225Inst Instance=new A029225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029226
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,5L,4L,6L,4L,6L,5L,7L,7L,9L,9L,10L,10L,11L,11L,13L,13L,16L,15L,18L,17L,20L,19L,22L,22L,25L,25L,28L,28L,31L,31L,34L,34L,38L,38L,42L,42L,46L,46L,50L,50L,55L,55L,60L,60L,65L,65L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029226Inst : IEnumerable<long>
{
public static readonly long[] Value=A029226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029226.Bytes);
public long this[int i]=>Value[i];

public static A029226Inst Instance=new A029226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029227
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,2L,1L,3L,1L,3L,1L,4L,2L,5L,3L,6L,3L,7L,4L,8L,5L,10L,6L,11L,7L,13L,8L,15L,10L,17L,11L,19L,13L,21L,15L,24L,17L,27L,19L,30L,21L,33L,24L,36L,27L,40L,30L,44L,33L,48L,36L,52L,40L,57L,44L,62L,48L,67L,52L,72L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029227Inst : IEnumerable<long>
{
public static readonly long[] Value=A029227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029227.Bytes);
public long this[int i]=>Value[i];

public static A029227Inst Instance=new A029227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029228
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,2L,1L,2L,2L,2L,2L,3L,3L,4L,3L,5L,4L,5L,5L,7L,6L,8L,7L,9L,8L,10L,10L,12L,11L,14L,13L,15L,15L,17L,17L,19L,19L,22L,21L,24L,24L,27L,26L,30L,29L,33L,32L,36L,36L,39L,39L,43L,43L,47L,47L,51L,51L,55L,55L,60L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029228Inst : IEnumerable<long>
{
public static readonly long[] Value=A029228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029228.Bytes);
public long this[int i]=>Value[i];

public static A029228Inst Instance=new A029228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029229
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,2L,1L,2L,1L,3L,1L,4L,2L,5L,2L,5L,3L,6L,4L,7L,5L,9L,5L,10L,6L,12L,7L,13L,9L,15L,10L,16L,12L,19L,13L,21L,15L,24L,16L,26L,19L,29L,21L,31L,24L,35L,26L,38L,29L,42L,31L,45L,35L,50L,38L,53L,42L,58L,45L,62L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029229Inst : IEnumerable<long>
{
public static readonly long[] Value=A029229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029229.Bytes);
public long this[int i]=>Value[i];

public static A029229Inst Instance=new A029229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029230
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,1L,2L,2L,2L,2L,2L,3L,2L,4L,3L,5L,4L,6L,5L,6L,6L,7L,7L,8L,9L,10L,10L,12L,11L,13L,12L,15L,14L,17L,17L,19L,19L,21L,21L,23L,23L,26L,26L,29L,29L,32L,32L,35L,35L,38L,38L,42L,42L,46L,46L,50L,50L,54L,54L,58L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029230Inst : IEnumerable<long>
{
public static readonly long[] Value=A029230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029230.Bytes);
public long this[int i]=>Value[i];

public static A029230Inst Instance=new A029230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029231
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,1L,2L,1L,3L,1L,3L,2L,3L,3L,3L,5L,3L,6L,4L,7L,5L,7L,7L,7L,9L,8L,11L,9L,12L,11L,13L,13L,14L,16L,15L,18L,17L,20L,19L,22L,22L,24L,25L,26L,28L,28L,31L,31L,34L,34L,37L,38L,40L,42L,43L,46L,46L,50L,50L,54L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029231Inst : IEnumerable<long>
{
public static readonly long[] Value=A029231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029231.Bytes);
public long this[int i]=>Value[i];

public static A029231Inst Instance=new A029231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029232
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,2L,2L,3L,2L,4L,2L,5L,3L,5L,5L,5L,6L,6L,7L,7L,8L,9L,8L,11L,9L,12L,11L,13L,13L,15L,15L,16L,17L,18L,18L,21L,20L,23L,23L,25L,25L,28L,28L,30L,31L,33L,33L,37L,36L,40L,40L,43L,43L,47L,47L,50L,52L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029232Inst : IEnumerable<long>
{
public static readonly long[] Value=A029232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029232.Bytes);
public long this[int i]=>Value[i];

public static A029232Inst Instance=new A029232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029233
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,2L,3L,3L,4L,3L,5L,5L,6L,5L,7L,6L,7L,7L,9L,8L,10L,10L,12L,11L,13L,13L,14L,14L,16L,16L,18L,18L,21L,20L,23L,22L,25L,24L,27L,27L,30L,30L,33L,33L,36L,36L,39L,39L,42L,42L,46L,46L,50L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029233Inst : IEnumerable<long>
{
public static readonly long[] Value=A029233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029233.Bytes);
public long this[int i]=>Value[i];

public static A029233Inst Instance=new A029233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029234
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,4L,2L,4L,3L,5L,4L,6L,4L,8L,4L,9L,5L,10L,6L,11L,8L,12L,9L,14L,10L,16L,11L,18L,12L,20L,14L,22L,16L,24L,18L,26L,20L,29L,22L,32L,24L,35L,26L,38L,29L,41L,32L,44L,35L,48L,38L,52L,41L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029234Inst : IEnumerable<long>
{
public static readonly long[] Value=A029234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029234.Bytes);
public long this[int i]=>Value[i];

public static A029234Inst Instance=new A029234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029235
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,2L,3L,2L,3L,2L,4L,3L,4L,4L,5L,5L,6L,6L,7L,6L,8L,7L,9L,8L,10L,10L,11L,12L,13L,13L,14L,14L,16L,15L,18L,17L,20L,19L,22L,22L,24L,24L,26L,26L,28L,28L,31L,31L,34L,34L,37L,37L,40L,40L,43L,43L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029235Inst : IEnumerable<long>
{
public static readonly long[] Value=A029235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029235.Bytes);
public long this[int i]=>Value[i];

public static A029235Inst Instance=new A029235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029236
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,2L,1L,3L,1L,3L,1L,3L,1L,4L,2L,6L,3L,7L,3L,7L,3L,8L,4L,10L,6L,12L,7L,13L,7L,14L,8L,16L,10L,19L,12L,21L,13L,23L,14L,25L,16L,28L,19L,31L,21L,34L,23L,37L,25L,40L,28L,44L,31L,48L,34L,52L,37L,56L,40L,60L,44L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029236Inst : IEnumerable<long>
{
public static readonly long[] Value=A029236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029236.Bytes);
public long this[int i]=>Value[i];

public static A029236Inst Instance=new A029236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029237
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,4L,5L,4L,6L,4L,7L,5L,8L,7L,9L,8L,10L,9L,11L,11L,12L,13L,14L,14L,16L,15L,18L,17L,20L,19L,23L,21L,25L,23L,27L,26L,29L,29L,32L,32L,35L,35L,38L,38L,41L,41L,45L,44L,49L,48L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029237Inst : IEnumerable<long>
{
public static readonly long[] Value=A029237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029237.Bytes);
public long this[int i]=>Value[i];

public static A029237Inst Instance=new A029237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029238
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,1L,3L,1L,3L,1L,4L,2L,5L,2L,6L,3L,6L,3L,8L,4L,9L,5L,10L,6L,11L,6L,13L,8L,14L,9L,17L,10L,18L,11L,20L,13L,22L,14L,25L,17L,26L,18L,30L,20L,32L,22L,35L,25L,38L,26L,42L,30L,44L,32L,49L,35L,52L,38L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029238Inst : IEnumerable<long>
{
public static readonly long[] Value=A029238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029238.Bytes);
public long this[int i]=>Value[i];

public static A029238Inst Instance=new A029238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029239
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,3L,1L,3L,1L,3L,1L,4L,1L,5L,2L,6L,3L,7L,3L,8L,3L,9L,4L,10L,5L,12L,6L,14L,7L,15L,8L,16L,9L,18L,10L,21L,12L,23L,14L,25L,15L,27L,16L,30L,18L,33L,21L,36L,23L,39L,25L,42L,27L,45L,30L,49L,33L,53L,36L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029239Inst : IEnumerable<long>
{
public static readonly long[] Value=A029239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029239.Bytes);
public long this[int i]=>Value[i];

public static A029239Inst Instance=new A029239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029240
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,2L,1L,3L,1L,3L,1L,4L,1L,4L,2L,5L,2L,6L,3L,8L,3L,8L,4L,9L,4L,10L,5L,12L,6L,13L,8L,15L,8L,16L,9L,18L,10L,19L,12L,22L,13L,24L,15L,27L,16L,28L,18L,31L,19L,33L,22L,37L,24L,39L,27L,43L,28L,45L,31L,49L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029240Inst : IEnumerable<long>
{
public static readonly long[] Value=A029240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029240.Bytes);
public long this[int i]=>Value[i];

public static A029240Inst Instance=new A029240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029241
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,5L,4L,6L,4L,6L,4L,6L,5L,7L,7L,9L,9L,10L,10L,10L,10L,11L,11L,13L,13L,16L,15L,18L,16L,19L,17L,20L,19L,22L,22L,25L,25L,27L,27L,29L,29L,31L,31L,34L,34L,38L,37L,41L,40L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029241Inst : IEnumerable<long>
{
public static readonly long[] Value=A029241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029241.Bytes);
public long this[int i]=>Value[i];

public static A029241Inst Instance=new A029241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029242
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,2L,1L,3L,1L,3L,1L,3L,1L,4L,2L,5L,3L,6L,3L,7L,3L,7L,4L,8L,5L,10L,6L,11L,7L,12L,7L,14L,8L,15L,10L,17L,11L,19L,12L,20L,14L,22L,15L,25L,17L,27L,19L,29L,20L,32L,22L,34L,25L,37L,27L,41L,29L,43L,32L,46L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029242Inst : IEnumerable<long>
{
public static readonly long[] Value=A029242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029242.Bytes);
public long this[int i]=>Value[i];

public static A029242Inst Instance=new A029242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029243
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,2L,4L,3L,5L,4L,6L,4L,6L,5L,6L,6L,7L,7L,8L,9L,9L,10L,11L,10L,12L,11L,13L,12L,15L,13L,17L,16L,18L,18L,20L,19L,21L,21L,22L,23L,25L,25L,28L,28L,30L,30L,33L,31L,35L,34L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029243Inst : IEnumerable<long>
{
public static readonly long[] Value=A029243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029243.Bytes);
public long this[int i]=>Value[i];

public static A029243Inst Instance=new A029243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029244
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,1L,3L,1L,3L,1L,3L,1L,3L,1L,4L,2L,6L,3L,7L,3L,7L,3L,7L,3L,8L,4L,10L,6L,12L,7L,13L,7L,13L,7L,14L,8L,16L,10L,19L,12L,21L,13L,22L,13L,23L,14L,25L,16L,28L,19L,31L,21L,33L,22L,35L,23L,37L,25L,40L,28L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029244Inst : IEnumerable<long>
{
public static readonly long[] Value=A029244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029244.Bytes);
public long this[int i]=>Value[i];

public static A029244Inst Instance=new A029244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029245
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,17L,19L,21L,22L,24L,26L,28L,30L,32L,35L,37L,39L,42L,45L,48L,50L,54L,57L,60L,64L,67L,71L,75L,79L,83L,87L,92L,96L,101L,106L,111L,116L,121L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029245Inst : IEnumerable<long>
{
public static readonly long[] Value=A029245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029245.Bytes);
public long this[int i]=>Value[i];

public static A029245Inst Instance=new A029245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029246
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,3L,2L,2L,3L,4L,4L,4L,5L,7L,6L,7L,8L,10L,10L,10L,12L,15L,14L,15L,17L,20L,20L,21L,23L,27L,27L,28L,31L,35L,35L,37L,40L,45L,45L,47L,51L,56L,57L,59L,63L,70L,70L,73L,78L,84L,86L,89L,94L,102L,103L,107L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029246Inst : IEnumerable<long>
{
public static readonly long[] Value=A029246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029246.Bytes);
public long this[int i]=>Value[i];

public static A029246Inst Instance=new A029246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029247
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,2L,3L,2L,2L,4L,4L,4L,5L,5L,6L,8L,7L,8L,10L,10L,11L,13L,13L,14L,17L,17L,18L,21L,21L,23L,26L,26L,28L,32L,32L,34L,38L,39L,41L,45L,46L,49L,54L,54L,57L,63L,64L,67L,72L,74L,78L,84L,85L,89L,96L,98L,102L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029247Inst : IEnumerable<long>
{
public static readonly long[] Value=A029247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029247.Bytes);
public long this[int i]=>Value[i];

public static A029247Inst Instance=new A029247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029248
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,3L,2L,3L,4L,4L,5L,5L,5L,7L,7L,9L,8L,9L,11L,12L,13L,13L,14L,17L,17L,20L,19L,21L,24L,25L,27L,28L,29L,33L,34L,38L,37L,40L,44L,46L,49L,50L,52L,58L,59L,64L,64L,68L,73L,76L,80L,82L,85L,92L,94L,101L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029248Inst : IEnumerable<long>
{
public static readonly long[] Value=A029248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029248.Bytes);
public long this[int i]=>Value[i];

public static A029248Inst Instance=new A029248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029249
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,5L,5L,5L,6L,7L,8L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,19L,20L,22L,23L,25L,27L,28L,30L,32L,34L,36L,38L,40L,43L,45L,47L,50L,53L,55L,58L,61L,64L,67L,70L,74L,77L,80L,84L,88L,92L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029249Inst : IEnumerable<long>
{
public static readonly long[] Value=A029249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029249.Bytes);
public long this[int i]=>Value[i];

public static A029249Inst Instance=new A029249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029250
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,4L,3L,3L,5L,5L,5L,6L,6L,8L,8L,8L,9L,12L,11L,11L,14L,15L,15L,17L,17L,20L,21L,21L,23L,27L,26L,27L,31L,33L,33L,36L,37L,41L,43L,43L,46L,52L,51L,53L,58L,61L,62L,66L,68L,73L,76L,77L,81L,89L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029250Inst : IEnumerable<long>
{
public static readonly long[] Value=A029250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029250.Bytes);
public long this[int i]=>Value[i];

public static A029250Inst Instance=new A029250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029251
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,2L,1L,2L,3L,2L,4L,4L,4L,5L,6L,5L,8L,8L,8L,10L,11L,10L,14L,14L,14L,17L,19L,17L,22L,23L,23L,26L,29L,28L,33L,34L,35L,39L,42L,41L,48L,49L,50L,55L,59L,58L,66L,68L,69L,75L,80L,79L,88L,91L,93L,99L,105L,105L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029251Inst : IEnumerable<long>
{
public static readonly long[] Value=A029251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029251.Bytes);
public long this[int i]=>Value[i];

public static A029251Inst Instance=new A029251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029252
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,1L,2L,2L,2L,2L,5L,2L,4L,5L,6L,4L,8L,6L,9L,8L,10L,9L,15L,10L,14L,15L,18L,14L,22L,18L,24L,22L,26L,24L,34L,26L,34L,34L,40L,34L,46L,40L,50L,46L,54L,50L,65L,54L,66L,65L,75L,66L,84L,75L,90L,84L,96L,90L,111L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029252Inst : IEnumerable<long>
{
public static readonly long[] Value=A029252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029252.Bytes);
public long this[int i]=>Value[i];

public static A029252Inst Instance=new A029252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029253
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,1L,1L,3L,2L,1L,5L,3L,2L,6L,5L,3L,9L,6L,5L,11L,9L,6L,15L,11L,9L,18L,15L,11L,23L,18L,15L,27L,23L,18L,34L,27L,23L,39L,34L,27L,47L,39L,34L,54L,47L,39L,64L,54L,47L,72L,64L,54L,84L,72L,64L,94L,84L,72L,108L,94L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029253Inst : IEnumerable<long>
{
public static readonly long[] Value=A029253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029253.Bytes);
public long this[int i]=>Value[i];

public static A029253Inst Instance=new A029253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029254
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,1L,1L,2L,3L,1L,4L,3L,3L,4L,6L,3L,7L,6L,7L,7L,10L,7L,12L,10L,12L,12L,16L,12L,19L,16L,19L,19L,24L,19L,28L,24L,28L,28L,35L,28L,39L,35L,40L,39L,48L,40L,53L,48L,55L,53L,64L,55L,70L,64L,73L,70L,83L,73L,91L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029254Inst : IEnumerable<long>
{
public static readonly long[] Value=A029254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029254.Bytes);
public long this[int i]=>Value[i];

public static A029254Inst Instance=new A029254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029255
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,1L,1L,2L,2L,2L,4L,2L,3L,5L,4L,4L,7L,5L,6L,8L,8L,8L,11L,9L,11L,13L,13L,13L,17L,15L,17L,20L,20L,20L,25L,23L,25L,29L,29L,29L,35L,33L,36L,40L,40L,41L,48L,45L,49L,54L,54L,55L,63L,61L,65L,70L,71L,73L,81L,79L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029255Inst : IEnumerable<long>
{
public static readonly long[] Value=A029255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029255.Bytes);
public long this[int i]=>Value[i];

public static A029255Inst Instance=new A029255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029256
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,1L,1L,2L,2L,1L,5L,2L,2L,5L,5L,2L,8L,5L,5L,8L,8L,5L,14L,8L,8L,14L,14L,8L,20L,14L,14L,20L,20L,14L,30L,20L,20L,30L,30L,20L,40L,30L,30L,40L,40L,30L,55L,40L,40L,55L,55L,40L,70L,55L,55L,70L,70L,55L,91L,70L,70L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029256Inst : IEnumerable<long>
{
public static readonly long[] Value=A029256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029256.Bytes);
public long this[int i]=>Value[i];

public static A029256Inst Instance=new A029256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029257
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,2L,2L,1L,2L,3L,3L,2L,4L,5L,5L,4L,6L,7L,7L,7L,9L,10L,11L,10L,12L,14L,15L,14L,17L,19L,20L,19L,22L,25L,26L,25L,29L,32L,33L,32L,37L,40L,41L,41L,46L,49L,51L,51L,56L,60L,62L,62L,68L,72L,75L,75L,81L,86L,89L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029257Inst : IEnumerable<long>
{
public static readonly long[] Value=A029257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029257.Bytes);
public long this[int i]=>Value[i];

public static A029257Inst Instance=new A029257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029258
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,2L,1L,2L,2L,2L,3L,3L,3L,4L,5L,4L,6L,6L,6L,8L,8L,8L,10L,11L,10L,13L,14L,13L,16L,17L,17L,19L,21L,21L,24L,25L,25L,29L,30L,30L,34L,36L,36L,40L,42L,42L,47L,49L,49L,54L,57L,57L,62L,65L,66L,71L,74L,75L,81L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029258Inst : IEnumerable<long>
{
public static readonly long[] Value=A029258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029258.Bytes);
public long this[int i]=>Value[i];

public static A029258Inst Instance=new A029258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029259
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,2L,1L,1L,3L,2L,2L,3L,4L,3L,4L,5L,5L,5L,7L,7L,7L,8L,10L,9L,10L,12L,13L,12L,15L,16L,16L,17L,20L,20L,21L,23L,25L,25L,28L,29L,31L,32L,35L,36L,38L,40L,43L,44L,47L,49L,52L,53L,57L,59L,62L,64L,68L,70L,74L,76L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029259Inst : IEnumerable<long>
{
public static readonly long[] Value=A029259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029259.Bytes);
public long this[int i]=>Value[i];

public static A029259Inst Instance=new A029259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029260
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,2L,1L,1L,2L,3L,2L,2L,4L,4L,3L,4L,6L,5L,5L,7L,8L,7L,8L,10L,10L,10L,12L,13L,13L,14L,16L,17L,17L,19L,21L,21L,22L,25L,26L,26L,29L,31L,32L,33L,36L,38L,39L,41L,44L,46L,47L,50L,53L,55L,57L,60L,63L,65L,68L,71L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029260Inst : IEnumerable<long>
{
public static readonly long[] Value=A029260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029260.Bytes);
public long this[int i]=>Value[i];

public static A029260Inst Instance=new A029260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029261
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,2L,1L,1L,2L,2L,3L,2L,3L,4L,4L,3L,5L,6L,5L,6L,7L,7L,9L,8L,9L,11L,12L,10L,13L,15L,14L,15L,17L,18L,20L,19L,21L,24L,25L,23L,28L,30L,29L,31L,34L,35L,38L,38L,40L,44L,46L,44L,50L,53L,53L,55L,59L,61L,65L,65L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029261Inst : IEnumerable<long>
{
public static readonly long[] Value=A029261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029261.Bytes);
public long this[int i]=>Value[i];

public static A029261Inst Instance=new A029261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029262
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,2L,2L,1L,2L,4L,2L,2L,4L,5L,4L,5L,5L,7L,7L,6L,7L,11L,9L,9L,12L,13L,12L,14L,14L,17L,18L,17L,19L,24L,21L,22L,26L,28L,27L,30L,31L,35L,36L,35L,38L,45L,42L,43L,49L,52L,51L,55L,56L,62L,64L,63L,67L,76L,73L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029262Inst : IEnumerable<long>
{
public static readonly long[] Value=A029262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029262.Bytes);
public long this[int i]=>Value[i];

public static A029262Inst Instance=new A029262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029263
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,5L,3L,5L,5L,7L,5L,7L,7L,10L,7L,10L,10L,13L,10L,14L,13L,17L,14L,18L,17L,22L,18L,23L,22L,28L,23L,29L,28L,34L,29L,36L,34L,42L,36L,44L,42L,50L,44L,53L,50L,60L,53L,63L,60L,71L,63L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029263Inst : IEnumerable<long>
{
public static readonly long[] Value=A029263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029263.Bytes);
public long this[int i]=>Value[i];

public static A029263Inst Instance=new A029263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029264
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,2L,1L,1L,3L,3L,1L,3L,4L,4L,3L,4L,6L,6L,4L,7L,8L,8L,7L,9L,11L,11L,9L,13L,14L,14L,14L,16L,18L,19L,17L,21L,23L,23L,23L,26L,28L,30L,28L,32L,35L,36L,35L,39L,42L,44L,42L,47L,51L,52L,51L,56L,60L,62L,60L,66L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029264Inst : IEnumerable<long>
{
public static readonly long[] Value=A029264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029264.Bytes);
public long this[int i]=>Value[i];

public static A029264Inst Instance=new A029264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029265
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,2L,1L,1L,2L,4L,1L,2L,4L,5L,2L,4L,5L,7L,4L,5L,7L,11L,5L,7L,11L,13L,7L,11L,13L,17L,11L,13L,17L,23L,13L,17L,23L,27L,17L,23L,27L,33L,23L,27L,33L,42L,27L,33L,42L,48L,33L,42L,48L,57L,42L,48L,57L,69L,48L,57L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029265Inst : IEnumerable<long>
{
public static readonly long[] Value=A029265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029265.Bytes);
public long this[int i]=>Value[i];

public static A029265Inst Instance=new A029265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029266
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,2L,2L,1L,3L,3L,2L,3L,4L,3L,5L,5L,5L,6L,7L,6L,8L,8L,8L,10L,11L,10L,13L,13L,13L,15L,16L,15L,19L,19L,19L,22L,24L,22L,26L,27L,27L,30L,32L,31L,36L,37L,37L,40L,43L,42L,47L,48L,49L,53L,56L,55L,61L,62L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029266Inst : IEnumerable<long>
{
public static readonly long[] Value=A029266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029266.Bytes);
public long this[int i]=>Value[i];

public static A029266Inst Instance=new A029266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029267
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,2L,1L,2L,3L,2L,2L,4L,3L,3L,5L,4L,5L,6L,6L,6L,8L,7L,8L,10L,9L,10L,12L,12L,12L,15L,14L,15L,18L,17L,18L,21L,21L,21L,25L,24L,26L,29L,28L,30L,34L,33L,34L,39L,38L,40L,44L,44L,46L,50L,50L,52L,57L,56L,59L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029267Inst : IEnumerable<long>
{
public static readonly long[] Value=A029267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029267.Bytes);
public long this[int i]=>Value[i];

public static A029267Inst Instance=new A029267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029268
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,2L,1L,1L,4L,2L,1L,4L,4L,2L,5L,4L,4L,7L,5L,4L,10L,7L,5L,11L,10L,7L,13L,11L,10L,16L,13L,11L,21L,16L,13L,23L,21L,16L,26L,23L,21L,31L,26L,23L,38L,31L,26L,41L,38L,31L,46L,41L,38L,53L,46L,41L,62L,53L,46L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029268Inst : IEnumerable<long>
{
public static readonly long[] Value=A029268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029268.Bytes);
public long this[int i]=>Value[i];

public static A029268Inst Instance=new A029268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029269
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,11L,11L,12L,13L,14L,14L,16L,16L,17L,18L,20L,20L,22L,23L,25L,25L,27L,28L,30L,30L,33L,34L,36L,37L,40L,41L,43L,44L,47L,48L,51L,52L,55L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029269Inst : IEnumerable<long>
{
public static readonly long[] Value=A029269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029269.Bytes);
public long this[int i]=>Value[i];

public static A029269Inst Instance=new A029269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029270
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,3L,2L,2L,3L,4L,2L,4L,4L,5L,4L,6L,5L,8L,6L,7L,8L,10L,7L,11L,10L,12L,11L,14L,12L,17L,14L,16L,17L,21L,16L,22L,21L,24L,22L,27L,24L,31L,27L,31L,31L,37L,31L,39L,37L,42L,39L,46L,42L,52L,46L,52L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029270Inst : IEnumerable<long>
{
public static readonly long[] Value=A029270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029270.Bytes);
public long this[int i]=>Value[i];

public static A029270Inst Instance=new A029270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029271
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,2L,3L,1L,2L,4L,3L,2L,4L,4L,4L,4L,5L,6L,7L,5L,7L,9L,8L,7L,10L,10L,10L,11L,12L,13L,15L,13L,15L,18L,17L,16L,20L,20L,21L,22L,23L,25L,28L,25L,28L,32L,31L,30L,35L,36L,37L,38L,40L,43L,46L,43L,47L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029271Inst : IEnumerable<long>
{
public static readonly long[] Value=A029271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029271.Bytes);
public long this[int i]=>Value[i];

public static A029271Inst Instance=new A029271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029272
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,1L,1L,2L,2L,2L,4L,3L,3L,5L,4L,5L,7L,6L,7L,9L,8L,9L,12L,11L,12L,15L,14L,15L,19L,18L,19L,23L,22L,24L,28L,27L,29L,33L,33L,35L,40L,39L,41L,47L,46L,49L,55L,54L,57L,63L,63L,66L,73L,73L,76L,83L,83L,87L,95L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029272Inst : IEnumerable<long>
{
public static readonly long[] Value=A029272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029272.Bytes);
public long this[int i]=>Value[i];

public static A029272Inst Instance=new A029272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029273
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,0L,2L,2L,1L,3L,3L,2L,4L,4L,4L,5L,6L,5L,7L,8L,7L,9L,11L,9L,12L,13L,12L,15L,17L,15L,19L,20L,19L,23L,25L,23L,28L,29L,29L,33L,35L,34L,39L,41L,41L,45L,49L,47L,53L,56L,55L,61L,65L,63L,71L,73L,73L,80L,84L,83L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029273Inst : IEnumerable<long>
{
public static readonly long[] Value=A029273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029273.Bytes);
public long this[int i]=>Value[i];

public static A029273Inst Instance=new A029273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029274
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,0L,1L,3L,1L,2L,4L,1L,3L,6L,2L,4L,8L,3L,6L,10L,4L,8L,13L,6L,10L,16L,8L,13L,20L,10L,16L,24L,13L,20L,29L,16L,24L,34L,20L,29L,40L,24L,34L,47L,29L,40L,54L,34L,47L,62L,40L,54L,71L,47L,62L,80L,54L,71L,91L,62L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029274Inst : IEnumerable<long>
{
public static readonly long[] Value=A029274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029274.Bytes);
public long this[int i]=>Value[i];

public static A029274Inst Instance=new A029274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029275
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,0L,1L,2L,2L,2L,3L,2L,2L,5L,4L,3L,6L,4L,6L,8L,6L,7L,9L,9L,10L,11L,11L,11L,16L,14L,14L,18L,16L,19L,23L,19L,22L,25L,26L,27L,30L,29L,30L,37L,36L,35L,42L,39L,44L,49L,46L,49L,54L,55L,58L,61L,62L,63L,73L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029275Inst : IEnumerable<long>
{
public static readonly long[] Value=A029275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029275.Bytes);
public long this[int i]=>Value[i];

public static A029275Inst Instance=new A029275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029276
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,0L,1L,2L,1L,3L,3L,1L,3L,4L,3L,5L,5L,3L,6L,7L,6L,8L,8L,7L,10L,11L,10L,12L,13L,12L,15L,17L,15L,18L,20L,18L,22L,24L,22L,26L,28L,26L,31L,33L,31L,36L,38L,36L,42L,44L,42L,48L,50L,49L,55L,57L,56L,62L,65L,64L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029276Inst : IEnumerable<long>
{
public static readonly long[] Value=A029276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029276.Bytes);
public long this[int i]=>Value[i];

public static A029276Inst Instance=new A029276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029293
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,1L,0L,3L,1L,0L,4L,2L,1L,5L,3L,1L,7L,4L,2L,9L,5L,3L,11L,7L,4L,14L,9L,5L,17L,11L,7L,20L,14L,9L,24L,17L,11L,28L,20L,14L,33L,24L,17L,38L,28L,20L,44L,33L,24L,50L,38L,28L,57L,44L,33L,64L,50L,38L,72L,57L,44L,81L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029293Inst : IEnumerable<long>
{
public static readonly long[] Value=A029293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029293.Bytes);
public long this[int i]=>Value[i];

public static A029293Inst Instance=new A029293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029294
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,1L,0L,2L,2L,0L,3L,3L,1L,3L,4L,2L,4L,5L,4L,5L,6L,5L,7L,7L,7L,9L,9L,8L,12L,11L,10L,14L,14L,12L,17L,17L,15L,19L,21L,18L,23L,24L,22L,26L,28L,26L,31L,32L,31L,35L,37L,35L,41L,42L,41L,46L,48L,46L,53L,54L,53L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029294Inst : IEnumerable<long>
{
public static readonly long[] Value=A029294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029294.Bytes);
public long this[int i]=>Value[i];

public static A029294Inst Instance=new A029294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029295
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,1L,0L,2L,1L,1L,3L,2L,2L,3L,2L,3L,5L,3L,4L,6L,4L,5L,8L,6L,6L,9L,8L,8L,11L,10L,10L,13L,12L,13L,16L,14L,15L,19L,17L,18L,23L,20L,21L,26L,24L,25L,30L,28L,29L,34L,32L,34L,39L,37L,39L,44L,42L,44L,50L,48L,50L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029295Inst : IEnumerable<long>
{
public static readonly long[] Value=A029295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029295.Bytes);
public long this[int i]=>Value[i];

public static A029295Inst Instance=new A029295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029296
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,1L,0L,2L,1L,0L,4L,2L,1L,4L,2L,1L,6L,4L,2L,7L,4L,2L,10L,6L,4L,11L,7L,4L,14L,10L,6L,16L,11L,7L,20L,14L,10L,22L,16L,11L,27L,20L,14L,30L,22L,16L,36L,27L,20L,39L,30L,22L,46L,36L,27L,50L,39L,30L,58L,46L,36L,63L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029296Inst : IEnumerable<long>
{
public static readonly long[] Value=A029296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029296.Bytes);
public long this[int i]=>Value[i];

public static A029296Inst Instance=new A029296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029297
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,1L,3L,0L,1L,4L,0L,2L,5L,1L,3L,7L,1L,4L,8L,2L,5L,11L,3L,7L,13L,4L,8L,16L,5L,11L,19L,7L,13L,23L,8L,16L,26L,11L,19L,31L,13L,23L,35L,16L,26L,41L,19L,31L,46L,23L,35L,53L,26L,41L,59L,31L,46L,67L,35L,53L,74L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029297Inst : IEnumerable<long>
{
public static readonly long[] Value=A029297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029297.Bytes);
public long this[int i]=>Value[i];

public static A029297Inst Instance=new A029297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029298
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,1L,2L,1L,1L,3L,1L,2L,3L,3L,2L,5L,3L,4L,5L,5L,4L,8L,5L,7L,8L,8L,7L,12L,8L,11L,12L,12L,11L,17L,12L,16L,17L,18L,16L,23L,18L,22L,23L,25L,22L,31L,25L,30L,31L,33L,30L,40L,33L,40L,40L,43L,40L,51L,43L,51L,51L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029298Inst : IEnumerable<long>
{
public static readonly long[] Value=A029298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029298.Bytes);
public long this[int i]=>Value[i];

public static A029298Inst Instance=new A029298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029299
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,1L,2L,0L,2L,3L,0L,3L,3L,1L,4L,4L,2L,5L,4L,4L,6L,6L,5L,7L,7L,7L,8L,10L,8L,10L,12L,10L,12L,15L,11L,15L,17L,14L,18L,20L,16L,22L,22L,20L,25L,26L,23L,29L,29L,28L,32L,34L,32L,37L,38L,37L,41L,44L,41L,47L,49L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029299Inst : IEnumerable<long>
{
public static readonly long[] Value=A029299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029299.Bytes);
public long this[int i]=>Value[i];

public static A029299Inst Instance=new A029299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029300
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,1L,2L,0L,1L,4L,0L,2L,4L,1L,2L,6L,1L,4L,6L,2L,4L,10L,2L,6L,10L,4L,6L,14L,4L,10L,14L,6L,10L,20L,6L,14L,20L,10L,14L,26L,10L,20L,26L,14L,20L,35L,14L,26L,35L,20L,26L,44L,20L,35L,44L,26L,35L,56L,26L,44L,56L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029300Inst : IEnumerable<long>
{
public static readonly long[] Value=A029300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029300.Bytes);
public long this[int i]=>Value[i];

public static A029300Inst Instance=new A029300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029301
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,0L,3L,1L,0L,4L,1L,0L,5L,2L,0L,7L,3L,1L,8L,4L,1L,10L,5L,2L,12L,7L,3L,15L,8L,4L,17L,10L,5L,21L,12L,7L,24L,15L,8L,28L,17L,10L,32L,21L,12L,37L,24L,15L,41L,28L,17L,47L,32L,21L,52L,37L,24L,59L,41L,28L,65L,47L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029301Inst : IEnumerable<long>
{
public static readonly long[] Value=A029301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029301.Bytes);
public long this[int i]=>Value[i];

public static A029301Inst Instance=new A029301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029302
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,0L,3L,0L,1L,4L,0L,1L,5L,0L,2L,7L,0L,3L,8L,1L,4L,10L,1L,5L,12L,2L,7L,14L,3L,8L,17L,4L,10L,20L,5L,12L,23L,7L,14L,27L,8L,17L,31L,10L,20L,35L,12L,23L,40L,14L,27L,45L,17L,31L,50L,20L,35L,56L,23L,40L,62L,27L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029302Inst : IEnumerable<long>
{
public static readonly long[] Value=A029302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029302.Bytes);
public long this[int i]=>Value[i];

public static A029302Inst Instance=new A029302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029303
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,0L,2L,1L,1L,3L,1L,1L,3L,2L,2L,4L,2L,3L,5L,4L,4L,6L,4L,5L,7L,6L,6L,9L,7L,8L,11L,9L,9L,13L,10L,11L,15L,13L,13L,18L,15L,16L,20L,18L,18L,23L,20L,22L,26L,24L,25L,30L,27L,29L,33L,31L,32L,38L,35L,37L,42L,40L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029303Inst : IEnumerable<long>
{
public static readonly long[] Value=A029303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029303.Bytes);
public long this[int i]=>Value[i];

public static A029303Inst Instance=new A029303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029304
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,0L,2L,1L,0L,4L,1L,0L,4L,2L,0L,6L,2L,1L,6L,4L,1L,9L,4L,2L,9L,6L,2L,13L,6L,4L,13L,9L,4L,18L,9L,6L,18L,13L,6L,24L,13L,9L,24L,18L,9L,31L,18L,13L,31L,24L,13L,39L,24L,18L,39L,31L,18L,49L,31L,24L,49L,39L,24L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029304Inst : IEnumerable<long>
{
public static readonly long[] Value=A029304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029304.Bytes);
public long this[int i]=>Value[i];

public static A029304Inst Instance=new A029304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029305
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,1L,4L,0L,1L,4L,0L,2L,6L,0L,2L,6L,1L,4L,9L,1L,4L,9L,2L,6L,12L,2L,6L,13L,4L,9L,17L,4L,9L,18L,6L,12L,22L,6L,13L,24L,9L,17L,29L,9L,18L,31L,12L,22L,36L,13L,24L,39L,17L,29L,45L,18L,31L,48L,22L,36L,55L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029305Inst : IEnumerable<long>
{
public static readonly long[] Value=A029305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029305.Bytes);
public long this[int i]=>Value[i];

public static A029305Inst Instance=new A029305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029306
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,3L,3L,4L,3L,3L,5L,4L,5L,7L,6L,6L,8L,7L,7L,10L,9L,10L,12L,11L,12L,14L,13L,14L,17L,16L,17L,20L,19L,20L,23L,22L,23L,27L,26L,27L,31L,30L,31L,35L,34L,36L,40L,39L,41L,45L,44L,46L,51L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029306Inst : IEnumerable<long>
{
public static readonly long[] Value=A029306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029306.Bytes);
public long this[int i]=>Value[i];

public static A029306Inst Instance=new A029306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029307
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,6L,5L,6L,7L,7L,7L,9L,9L,9L,10L,11L,11L,12L,13L,14L,14L,16L,16L,17L,18L,19L,20L,21L,22L,24L,24L,26L,27L,28L,29L,31L,32L,34L,35L,37L,38L,40L,41L,43L,45L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029307Inst : IEnumerable<long>
{
public static readonly long[] Value=A029307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029307.Bytes);
public long this[int i]=>Value[i];

public static A029307Inst Instance=new A029307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029308
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,2L,3L,3L,3L,3L,4L,5L,4L,5L,6L,5L,6L,7L,7L,8L,8L,9L,10L,9L,11L,12L,11L,13L,14L,14L,15L,16L,17L,18L,18L,20L,21L,21L,23L,24L,25L,26L,27L,29L,30L,31L,33L,34L,35L,37L,38L,40L,42L,43L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029308Inst : IEnumerable<long>
{
public static readonly long[] Value=A029308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029308.Bytes);
public long this[int i]=>Value[i];

public static A029308Inst Instance=new A029308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029325
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,3L,3L,4L,3L,3L,4L,3L,3L,5L,4L,5L,7L,6L,6L,8L,6L,6L,8L,7L,7L,10L,9L,10L,12L,11L,11L,13L,11L,12L,14L,13L,14L,17L,16L,17L,19L,18L,18L,21L,19L,20L,23L,22L,23L,27L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029325Inst : IEnumerable<long>
{
public static readonly long[] Value=A029325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029325.Bytes);
public long this[int i]=>Value[i];

public static A029325Inst Instance=new A029325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029326
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,3L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,9L,9L,10L,10L,12L,12L,14L,14L,16L,16L,18L,19L,21L,21L,23L,24L,27L,27L,30L,30L,33L,34L,37L,38L,41L,42L,45L,46L,50L,51L,55L,56L,60L,61L,65L,67L,72L,73L,77L,79L,84L,86L,91L,93L,98L,100L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029326Inst : IEnumerable<long>
{
public static readonly long[] Value=A029326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029326.Bytes);
public long this[int i]=>Value[i];

public static A029326Inst Instance=new A029326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029327
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,0L,2L,1L,2L,1L,3L,2L,3L,2L,5L,3L,5L,3L,7L,5L,7L,5L,10L,7L,10L,7L,13L,10L,14L,10L,17L,13L,18L,14L,22L,17L,23L,18L,28L,22L,29L,23L,34L,28L,36L,29L,42L,34L,44L,36L,50L,42L,53L,44L,60L,50L,63L,53L,71L,60L,74L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029327Inst : IEnumerable<long>
{
public static readonly long[] Value=A029327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029327.Bytes);
public long this[int i]=>Value[i];

public static A029327Inst Instance=new A029327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029328
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,0L,1L,2L,2L,1L,2L,2L,3L,3L,3L,3L,5L,4L,5L,5L,6L,6L,8L,7L,8L,9L,10L,10L,12L,11L,13L,14L,15L,15L,18L,17L,19L,20L,22L,22L,25L,24L,27L,29L,30L,30L,34L,34L,37L,38L,40L,41L,46L,45L,48L,50L,53L,54L,59L,58L,62L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029328Inst : IEnumerable<long>
{
public static readonly long[] Value=A029328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029328.Bytes);
public long this[int i]=>Value[i];

public static A029328Inst Instance=new A029328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029329
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,3L,1L,2L,1L,3L,3L,4L,2L,4L,3L,7L,4L,6L,4L,8L,7L,9L,6L,10L,8L,14L,9L,13L,10L,16L,14L,18L,13L,19L,16L,25L,18L,24L,19L,28L,25L,31L,24L,33L,28L,40L,31L,40L,33L,45L,40L,49L,40L,52L,45L,61L,49L,61L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029329Inst : IEnumerable<long>
{
public static readonly long[] Value=A029329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029329.Bytes);
public long this[int i]=>Value[i];

public static A029329Inst Instance=new A029329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029330
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,2L,2L,2L,1L,2L,3L,4L,3L,3L,3L,5L,5L,6L,5L,6L,6L,8L,8L,9L,8L,10L,10L,12L,12L,13L,13L,15L,15L,17L,17L,19L,19L,21L,21L,24L,24L,26L,26L,29L,29L,32L,32L,35L,35L,38L,39L,42L,42L,45L,46L,50L,50L,53L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029330Inst : IEnumerable<long>
{
public static readonly long[] Value=A029330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029330.Bytes);
public long this[int i]=>Value[i];

public static A029330Inst Instance=new A029330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029331
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,2L,1L,3L,1L,2L,2L,4L,3L,4L,2L,5L,4L,6L,4L,8L,5L,7L,6L,10L,8L,11L,7L,12L,10L,14L,11L,17L,12L,16L,14L,21L,17L,22L,16L,24L,21L,27L,22L,31L,24L,31L,27L,37L,31L,39L,31L,42L,37L,46L,39L,52L,42L,52L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029331Inst : IEnumerable<long>
{
public static readonly long[] Value=A029331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029331.Bytes);
public long this[int i]=>Value[i];

public static A029331Inst Instance=new A029331Inst();

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