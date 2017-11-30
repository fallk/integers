using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A262682
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,2L,0L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262682Inst : IEnumerable<long>
{
public static readonly long[] Value=A262682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262682.Bytes);
public long this[int i]=>Value[i];

public static A262682Inst Instance=new A262682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262683
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262683Inst : IEnumerable<long>
{
public static readonly long[] Value=A262683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262683.Bytes);
public long this[int i]=>Value[i];

public static A262683Inst Instance=new A262683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262684
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262684Inst : IEnumerable<long>
{
public static readonly long[] Value=A262684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262684.Bytes);
public long this[int i]=>Value[i];

public static A262684Inst Instance=new A262684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262685
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,8L,8L,8L,8L,9L,10L,10L,10L,11L,11L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,15L,15L,16L,17L,17L,17L,18L,19L,20L,20L,21L,21L,22L,22L,23L,23L,23L,23L,23L,23L,23L,24L,25L,25L,26L,26L,27L,27L,28L,28L,28L,28L,28L,29L,30L,30L,31L,31L,32L,33L,33L,33L,33L,33L,33L,33L,34L,34L,34L,34L,35L,35L,35L,35L,35L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262685Inst : IEnumerable<long>
{
public static readonly long[] Value=A262685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262685.Bytes);
public long this[int i]=>Value[i];

public static A262685Inst Instance=new A262685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262686
{
public static readonly long[] Value={ 2L,4L,6L,5L,8L,7L,12L,0L,0L,11L,14L,16L,18L,0L,20L,17L,24L,21L,22L,0L,0L,23L,30L,27L,0L,0L,32L,36L,0L,33L,34L,35L,40L,0L,42L,39L,0L,0L,48L,45L,0L,43L,46L,0L,50L,47L,54L,51L,60L,0L,0L,55L,0L,57L,58L,0L,0L,64L,66L,61L,72L,65L,70L,0L,0L,69L,0L,0L,0L,75L,80L,73L,84L,77L,0L,0L,81L,79L,90L,0L,88L,85L,86L,87L,96L,0L,92L,91L,0L,93L,94L,100L,98L,99L,102L,97L,108L,105L,0L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262686Inst : IEnumerable<long>
{
public static readonly long[] Value=A262686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262686.Bytes);
public long this[int i]=>Value[i];

public static A262686Inst Instance=new A262686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262687
{
public static readonly long[] Value={ 0L,1L,4L,169L,324L,1521L,125316L,126025L,425104L,1713481L,1716100L,4959529L,24760576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262687Inst : IEnumerable<long>
{
public static readonly long[] Value=A262687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262687.Bytes);
public long this[int i]=>Value[i];

public static A262687Inst Instance=new A262687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262688
{
public static readonly long[] Value={ 0L,1L,2L,13L,18L,39L,354L,355L,652L,1309L,1310L,2227L,4976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262688Inst : IEnumerable<long>
{
public static readonly long[] Value=A262688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262688.Bytes);
public long this[int i]=>Value[i];

public static A262688Inst Instance=new A262688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262689
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L,5L,5L,5L,5L,5L,5L,5L,4L,5L,5L,5L,6L,6L,6L,6L,6L,5L,5L,5L,6L,6L,6L,6L,4L,7L,7L,7L,6L,7L,7L,7L,6L,7L,7L,7L,7L,6L,7L,7L,8L,8L,8L,7L,8L,8L,6L,7L,6L,8L,7L,7L,6L,8L,7L,7L,8L,9L,9L,9L,8L,9L,9L,9L,6L,8L,9L,9L,9L,8L,9L,9L,8L,9L,7L,9L,10L,10L,10L,10L,10L,10L,9L,9L,10L,10L,10L,10L,10L,8L,8L,9L,10L,9L,10L,10L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262689Inst : IEnumerable<long>
{
public static readonly long[] Value=A262689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262689.Bytes);
public long this[int i]=>Value[i];

public static A262689Inst Instance=new A262689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262690
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,4L,4L,4L,4L,9L,9L,9L,4L,9L,9L,9L,16L,16L,9L,9L,16L,16L,9L,9L,16L,25L,25L,25L,25L,25L,25L,25L,16L,25L,25L,25L,36L,36L,36L,36L,36L,25L,25L,25L,36L,36L,36L,36L,16L,49L,49L,49L,36L,49L,49L,49L,36L,49L,49L,49L,49L,36L,49L,49L,64L,64L,64L,49L,64L,64L,36L,49L,36L,64L,49L,49L,36L,64L,49L,49L,64L,81L,81L,81L,64L,81L,81L,81L,36L,64L,81L,81L,81L,64L,81L,81L,64L,81L,49L,81L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262690Inst : IEnumerable<long>
{
public static readonly long[] Value=A262690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262690.Bytes);
public long this[int i]=>Value[i];

public static A262690Inst Instance=new A262690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262691
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,6L,15L,19L,8L,23L,13L,31L,10L,39L,14L,17L,18L,47L,27L,63L,22L,12L,21L,79L,30L,29L,38L,35L,16L,37L,95L,55L,127L,45L,25L,43L,46L,159L,26L,61L,62L,20L,59L,77L,78L,28L,34L,71L,36L,33L,94L,75L,54L,191L,111L,255L,91L,51L,87L,126L,44L,93L,24L,319L,42L,53L,158L,123L,125L,41L,119L,60L,58L,155L,76L,157L,70L,32L,57L,69L,143L,73L,67L,189L,74L,151L,109L,383L,190L,223L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262691Inst : IEnumerable<long>
{
public static readonly long[] Value=A262691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262691.Bytes);
public long this[int i]=>Value[i];

public static A262691Inst Instance=new A262691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262692
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,6L,12L,7L,16L,8L,25L,14L,18L,10L,32L,19L,20L,11L,45L,26L,24L,13L,66L,38L,42L,22L,49L,29L,28L,15L,81L,53L,50L,31L,52L,33L,30L,17L,121L,73L,68L,39L,64L,37L,40L,21L,175L,106L,104L,61L,114L,69L,56L,35L,135L,82L,76L,46L,75L,43L,44L,23L,231L,129L,147L,86L,136L,83L,80L,51L,144L,85L,88L,55L,78L,47L,48L,27L,338L,197L,190L,118L,182L,108L,105L,62L,172L,101L,102L,60L,110L,65L,54L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262692Inst : IEnumerable<long>
{
public static readonly long[] Value=A262692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262692.Bytes);
public long this[int i]=>Value[i];

public static A262692Inst Instance=new A262692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262693
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262693Inst : IEnumerable<long>
{
public static readonly long[] Value=A262693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262693.Bytes);
public long this[int i]=>Value[i];

public static A262693Inst Instance=new A262693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262694
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262694Inst : IEnumerable<long>
{
public static readonly long[] Value=A262694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262694.Bytes);
public long this[int i]=>Value[i];

public static A262694Inst Instance=new A262694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262695
{
public static readonly long[] Value={ 0L,4L,0L,3L,2L,2L,0L,1L,1L,24L,3L,23L,0L,1L,2L,22L,2L,21L,0L,1L,1L,20L,0L,19L,1L,1L,3L,18L,1L,17L,0L,16L,2L,1L,0L,15L,1L,1L,10L,14L,1L,2L,0L,1L,2L,13L,0L,12L,9L,1L,1L,11L,1L,10L,0L,1L,1L,9L,0L,8L,8L,7L,0L,1L,1L,6L,1L,1L,1L,5L,0L,4L,7L,3L,1L,1L,13L,2L,0L,1L,2L,12L,4L,11L,6L,1L,3L,10L,1L,5L,0L,9L,2L,4L,0L,8L,5L,7L,1L,3L,1L,2L,0L,1L,4L,6L,0L,5L,1L,1L,2L,4L,1L,1L,0L,3L,1L,1L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262695Inst : IEnumerable<long>
{
public static readonly long[] Value=A262695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262695.Bytes);
public long this[int i]=>Value[i];

public static A262695Inst Instance=new A262695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262696
{
public static readonly long[] Value={ 0L,2L,0L,1L,1L,1L,0L,1L,1L,13L,1L,13L,0L,1L,1L,11L,1L,11L,0L,1L,1L,10L,0L,10L,1L,1L,1L,10L,1L,9L,0L,8L,1L,1L,0L,8L,1L,1L,6L,7L,1L,1L,0L,1L,1L,6L,0L,6L,5L,1L,1L,6L,1L,5L,0L,1L,1L,5L,0L,3L,4L,3L,0L,1L,1L,3L,1L,1L,1L,2L,0L,1L,4L,1L,1L,1L,7L,1L,0L,1L,1L,7L,1L,6L,4L,1L,1L,6L,1L,1L,0L,5L,1L,1L,0L,4L,4L,4L,1L,1L,1L,1L,0L,1L,3L,4L,0L,4L,1L,1L,1L,3L,1L,1L,0L,1L,1L,1L,0L,1L,3L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262696Inst : IEnumerable<long>
{
public static readonly long[] Value=A262696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262696.Bytes);
public long this[int i]=>Value[i];

public static A262696Inst Instance=new A262696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262697
{
public static readonly long[] Value={ 0L,6L,0L,3L,2L,2L,0L,1L,1L,38L,3L,37L,0L,1L,2L,33L,2L,32L,0L,1L,1L,30L,0L,29L,1L,1L,3L,28L,1L,26L,0L,24L,2L,1L,0L,23L,1L,1L,16L,21L,1L,2L,0L,1L,2L,18L,0L,17L,13L,1L,1L,16L,1L,14L,0L,1L,1L,13L,0L,10L,11L,9L,0L,1L,1L,8L,1L,1L,1L,6L,0L,4L,10L,3L,1L,1L,23L,2L,0L,1L,2L,22L,4L,20L,9L,1L,3L,19L,1L,5L,0L,13L,2L,4L,0L,11L,8L,10L,1L,3L,1L,2L,0L,1L,6L,9L,0L,8L,1L,1L,2L,6L,1L,1L,0L,3L,1L,1L,0L,2L,5L,0L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262697Inst : IEnumerable<long>
{
public static readonly long[] Value=A262697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262697.Bytes);
public long this[int i]=>Value[i];

public static A262697Inst Instance=new A262697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262698
{
public static readonly long[] Value={ 1L,2L,4L,24L,41L,51L,88L,95L,99L,179L,183L,663L,782L,829L,1339L,2054L,2816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262698Inst : IEnumerable<long>
{
public static readonly long[] Value=A262698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262698.Bytes);
public long this[int i]=>Value[i];

public static A262698Inst Instance=new A262698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262699
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,8L,8L,16L,16L,32L,32L,64L,64L,128L,128L,256L,256L,512L,512L,1024L,1024L,2048L,2048L,4096L,4096L,8192L,8192L,16384L,16384L,32768L,32768L,65536L,65536L,131072L,131072L,262144L,262144L,524288L,524288L,1048576L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262699Inst : IEnumerable<long>
{
public static readonly long[] Value=A262699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262699.Bytes);
public long this[int i]=>Value[i];

public static A262699Inst Instance=new A262699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262700
{
public static readonly long[] Value={ 5L,19L,31L,151L,691L,1181L,1489L,1511L,1601L,2579L,3037L,7297L,9661L,10993L,11699L,20407L,25657L,33937L,65099L,96419L,102911L,133157L,251789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262700Inst : IEnumerable<long>
{
public static readonly long[] Value=A262700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262700.Bytes);
public long this[int i]=>Value[i];

public static A262700Inst Instance=new A262700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262701
{
public static readonly long[] Value={ 9L,6L,3L,9L,7L,2L,3L,8L,4L,4L,0L,2L,1L,9L,4L,1L,0L,5L,2L,7L,1L,1L,4L,5L,9L,2L,6L,2L,3L,6L,4L,8L,2L,3L,1L,5L,6L,2L,6L,7L,2L,8L,9L,5L,2L,5L,8L,2L,1L,9L,0L,6L,4L,5L,6L,1L,0L,9L,5L,7L,9L,7L,0L,0L,5L,6L,4L,0L,3L,5L,6L,4L,7L,8L,6L,3L,3L,7L,0L,3L,9L,0L,7L,2L,2L,8L,7L,3L,1L,6L,5L,0L,0L,8L,7L,9L,6L,7L,8L,8L,8L,3L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262701Inst : IEnumerable<long>
{
public static readonly long[] Value=A262701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262701.Bytes);
public long this[int i]=>Value[i];

public static A262701Inst Instance=new A262701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262702
{
public static readonly long[] Value={ 2L,23L,3L,13L,11L,17L,7L,37L,43L,31L,19L,41L,101L,61L,103L,71L,47L,73L,67L,79L,97L,29L,229L,293L,307L,53L,5L,59L,359L,83L,283L,311L,107L,131L,109L,151L,113L,137L,181L,127L,191L,139L,211L,149L,241L,157L,251L,163L,271L,167L,281L,173L,313L,193L,317L,179L,331L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262702Inst : IEnumerable<long>
{
public static readonly long[] Value=A262702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262702.Bytes);
public long this[int i]=>Value[i];

public static A262702Inst Instance=new A262702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262703
{
public static readonly long[] Value={ 8L,-7L,6L,-5L,4L,-3L,2L,-1L,10L,1L,-2L,3L,-4L,5L,-6L,7L,-8L,18L,-8L,18L,-17L,6L,-5L,4L,-3L,2L,-1L,10L,1L,-2L,3L,-4L,5L,-6L,16L,-6L,7L,-18L,28L,-18L,19L,-20L,21L,-18L,4L,-3L,2L,-1L,10L,-5L,1L,1L,1L,1L,2L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,-40L,41L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262703Inst : IEnumerable<long>
{
public static readonly long[] Value=A262703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262703.Bytes);
public long this[int i]=>Value[i];

public static A262703Inst Instance=new A262703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262704
{
public static readonly long[] Value={ 1L,0L,1L,0L,6L,1L,0L,6L,24L,1L,0L,0L,114L,60L,1L,0L,0L,180L,690L,120L,1L,0L,0L,90L,2940L,2640L,210L,1L,0L,0L,0L,5670L,21840L,7770L,336L,1L,0L,0L,0L,5040L,87570L,107520L,19236L,504L,1L,0L,0L,0L,1680L,189000L,735210L,407400L,42084L,720L,1L,0L,0L,0L,0L,224700L,2835756L,4280850L,1284360L,83880L,990L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262704Inst : IEnumerable<long>
{
public static readonly long[] Value=A262704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262704.Bytes);
public long this[int i]=>Value[i];

public static A262704Inst Instance=new A262704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262705
{
public static readonly long[] Value={ 1L,0L,1L,0L,14L,1L,0L,36L,78L,1L,0L,24L,978L,252L,1L,0L,0L,4320L,8730L,620L,1L,0L,0L,8460L,103820L,46890L,1290L,1L,0L,0L,7560L,581700L,1159340L,185430L,2394L,1L,0L,0L,2520L,1767360L,13387570L,8314880L,595476L,4088L,1L,0L,0L,0L,3087000L,85806000L,170429490L,44341584L,1642788L,6552L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262705Inst : IEnumerable<long>
{
public static readonly long[] Value=A262705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262705.Bytes);
public long this[int i]=>Value[i];

public static A262705Inst Instance=new A262705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262706
{
public static readonly long[] Value={ 1L,0L,1L,0L,30L,1L,0L,150L,240L,1L,0L,240L,6810L,1020L,1L,0L,120L,63540L,94890L,3120L,1L,0L,0L,271170L,2615340L,740640L,7770L,1L,0L,0L,604800L,32186070L,47271840L,4029690L,16800L,1L,0L,0L,730800L,214628400L,1281612570L,518276640L,17075940L,32760L,1L,0L,0L,453600L,859992000L,18459063000L,26947757970L,4027831080L,60171300L,59040L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262706Inst : IEnumerable<long>
{
public static readonly long[] Value=A262706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262706.Bytes);
public long this[int i]=>Value[i];

public static A262706Inst Instance=new A262706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262707
{
public static readonly long[] Value={ 5L,8L,10L,14L,16L,19L,23L,31L,35L,39L,45L,63L,65L,66L,68L,71L,74L,82L,87L,92L,94L,115L,130L,145L,151L,162L,172L,204L,250L,279L,292L,304L,334L,391L,413L,415L,418L,449L,451L,454L,461L,499L,514L,524L,552L,557L,626L,664L,676L,683L,691L,706L,708L,724L,763L,766L,846L,848L,858L,866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262707Inst : IEnumerable<long>
{
public static readonly long[] Value=A262707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262707.Bytes);
public long this[int i]=>Value[i];

public static A262707Inst Instance=new A262707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262708
{
public static readonly long[] Value={ 8L,10L,14L,18L,18L,24L,28L,30L,38L,40L,44L,48L,54L,58L,60L,68L,70L,74L,78L,84L,88L,98L,100L,104L,108L,108L,114L,128L,130L,138L,138L,148L,150L,158L,164L,168L,174L,178L,180L,190L,194L,198L,198L,210L,224L,228L,228L,234L,238L,240L,250L,258L,264L,268L,270L,278L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262708Inst : IEnumerable<long>
{
public static readonly long[] Value=A262708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262708.Bytes);
public long this[int i]=>Value[i];

public static A262708Inst Instance=new A262708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262709
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-2L,1L,0L,0L,1L,2L,0L,0L,-2L,0L,0L,0L,3L,-2L,0L,0L,-2L,-3L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,2L,-1L,0L,0L,-2L,2L,0L,0L,1L,2L,0L,0L,-4L,0L,0L,0L,0L,-2L,0L,0L,-2L,0L,0L,0L,3L,2L,0L,0L,-2L,0L,0L,0L,2L,-3L,0L,0L,0L,2L,0L,0L,4L,0L,0L,0L,-2L,0L,0L,0L,2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262709Inst : IEnumerable<long>
{
public static readonly long[] Value=A262709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262709.Bytes);
public long this[int i]=>Value[i];

public static A262709Inst Instance=new A262709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262710
{
public static readonly long[] Value={ 1L,-4L,16L,-64L,256L,-1024L,4096L,-16384L,65536L,-262144L,1048576L,-4194304L,16777216L,-67108864L,268435456L,-1073741824L,4294967296L,-17179869184L,68719476736L,-274877906944L,1099511627776L,-4398046511104L,17592186044416L,-70368744177664L,281474976710656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262710Inst : IEnumerable<long>
{
public static readonly long[] Value=A262710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262710.Bytes);
public long this[int i]=>Value[i];

public static A262710Inst Instance=new A262710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262711
{
public static readonly long[] Value={ 4L,5L,32L,40L,49L,50L,149L,320L,400L,490L,500L,1049L,1490L,3200L,4000L,4900L,5000L,10490L,14900L,32000L,40000L,49000L,50000L,104900L,149000L,320000L,400000L,490000L,500000L,1049000L,1490000L,3200000L,4000000L,4900000L,5000000L,10490000L,14900000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262711Inst : IEnumerable<long>
{
public static readonly long[] Value=A262711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262711.Bytes);
public long this[int i]=>Value[i];

public static A262711Inst Instance=new A262711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262712
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,18L,21L,30L,39L,45L,48L,51L,60L,90L,102L,105L,111L,120L,150L,180L,201L,210L,249L,300L,318L,321L,348L,351L,390L,450L,480L,501L,510L,549L,600L,900L,1002L,1005L,1011L,1020L,1050L,1101L,1110L,1149L,1200L,1500L,1761L,1800L,2001L,2010L,2100L,2490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262712Inst : IEnumerable<long>
{
public static readonly long[] Value=A262712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262712.Bytes);
public long this[int i]=>Value[i];

public static A262712Inst Instance=new A262712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262713
{
public static readonly long[] Value={ 8L,19L,35L,46L,55L,71L,80L,145L,152L,179L,190L,251L,332L,350L,361L,449L,451L,460L,548L,550L,649L,710L,800L,1450L,1520L,1790L,1900L,2510L,3320L,3500L,3610L,4490L,4499L,4510L,4600L,5480L,5500L,6490L,7100L,8000L,14500L,15200L,17900L,19000L,20249L,20251L,24499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262713Inst : IEnumerable<long>
{
public static readonly long[] Value=A262713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262713.Bytes);
public long this[int i]=>Value[i];

public static A262713Inst Instance=new A262713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262714
{
public static readonly BigInteger[] Value={ 2L,2L,5L,11L,56L,617L,34553L,21319202L,736642386707L,15704627843968647815UL,BigInteger.Parse("11568694537326272321321120595206"),BigInteger.Parse("181682042349262169758803442669575561298555791374891"),BigInteger.Parse("2101824050856189730969091901210449068013789839106586804501928241686514359003372547") };
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
public class A262714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262714Inst Instance=new A262714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262715
{
public static readonly BigInteger[] Value={ 29L,24389L,20511149L,17249876309L,14507145975869L,12200509765705829L,10260628712958602189UL,BigInteger.Parse("8629188747598184440949"),BigInteger.Parse("7257147736730073114838109"),BigInteger.Parse("6103261246589991489578849669"),BigInteger.Parse("5132842708382182842735812571629"),BigInteger.Parse("4316720717749415770740818372739989") };
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
public class A262715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262715.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262715Inst Instance=new A262715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262716
{
public static readonly BigInteger[] Value={ 31L,29791L,28629151L,27512614111L,26439622160671L,25408476896404831L,BigInteger.Parse("24417546297445042591"),BigInteger.Parse("23465261991844685929951"),BigInteger.Parse("22550116774162743178682911"),BigInteger.Parse("21670662219970396194714277471"),BigInteger.Parse("20825506393391550743120420649631"),BigInteger.Parse("20013311644049280264138724244295391") };
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
public class A262716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262716Inst Instance=new A262716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262717
{
public static readonly long[] Value={ 1L,0L,1L,6L,35L,208L,1260L,7752L,48279L,303600L,1924065L,12271350L,78676884L,506662016L,3275052040L,21238169904L,138111313215L,900331830048L,5881813095795L,38499031112850L,252423322176795L,1657580519271600L,10899847657028400L,71764700685918240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262717Inst : IEnumerable<long>
{
public static readonly long[] Value=A262717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262717.Bytes);
public long this[int i]=>Value[i];

public static A262717Inst Instance=new A262717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262718
{
public static readonly BigInteger[] Value={ 0L,0L,2L,18L,194L,2550L,39962L,730002L,15257090L,359376750L,9424209002L,272385029466L,8604312602690L,294957765448710L,10906288759973882L,432701819402940450L,18336112083960655874UL,BigInteger.Parse("826578941145375829470"),BigInteger.Parse("39497618599385891373002"),BigInteger.Parse("1994276034034710498109674") };
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
public class A262718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262718Inst Instance=new A262718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262719
{
public static readonly long[] Value={ 1L,6L,21L,55L,110L,203L,357L,544L,808L,1177L,1670L,2215L,2865L,3599L,4558L,5621L,6637L,8041L,9769L,11413L,13394L,15593L,17683L,20317L,23249L,26063L,29506L,33287L,37461L,41692L,46306L,50707L,55667L,61723L,67547L,73939L,80767L,87941L,94913L,101613L,111422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262719Inst : IEnumerable<long>
{
public static readonly long[] Value=A262719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262719.Bytes);
public long this[int i]=>Value[i];

public static A262719Inst Instance=new A262719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262720
{
public static readonly long[] Value={ 1L,2L,8L,22L,68L,198L,586L,1718L,5047L,14808L,43470L,127636L,374957L,1102078L,3241082L,9537070L,28079357L,82718212L,243809138L,718994032L,2121378272L,6262089436L,18493519148L,54639914652L,161503493023L,477558890378L,1412658185320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262720Inst : IEnumerable<long>
{
public static readonly long[] Value=A262720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262720.Bytes);
public long this[int i]=>Value[i];

public static A262720Inst Instance=new A262720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262721
{
public static readonly long[] Value={ 1L,11L,14L,1215L,1811L,111211L,1419L,2215L,1120L,1116L,1811L,111211L,1419L,2215L,1120L,1116L,1811L,111211L,1419L,2215L,1120L,1116L,1811L,111211L,1419L,2215L,1120L,1116L,1811L,111211L,1419L,2215L,1120L,1116L,1811L,111211L,1419L,2215L,1120L,1116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262721Inst : IEnumerable<long>
{
public static readonly long[] Value=A262721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262721.Bytes);
public long this[int i]=>Value[i];

public static A262721Inst Instance=new A262721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262722
{
public static readonly long[] Value={ 1L,41L,56L,74L,103L,157L,384L,491L,537L,868L,1490L,1710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262722Inst : IEnumerable<long>
{
public static readonly long[] Value=A262722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262722.Bytes);
public long this[int i]=>Value[i];

public static A262722Inst Instance=new A262722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262723
{
public static readonly long[] Value={ 105L,231L,627L,897L,935L,1581L,1729L,2465L,2967L,4123L,4301L,4715L,5487L,7685L,7881L,9717L,10707L,11339L,14993L,16377L,17353L,20213L,20915L,23779L,25327L,26331L,26765L,29341L,29607L,32021L,33335L,40587L,40807L,42911L,48635L,49321L,54739L,55581L,55637L,59563L,60297L,63017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262723Inst : IEnumerable<long>
{
public static readonly long[] Value=A262723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262723.Bytes);
public long this[int i]=>Value[i];

public static A262723Inst Instance=new A262723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262724
{
public static readonly BigInteger[] Value={ 1L,3L,10L,28L,36L,91L,1081L,2278L,2926L,8001L,46665L,5639761L,10911456L,166066200L,341532180L,3137785371L,1647882316985625L,BigInteger.Parse("875366737297292691171"),BigInteger.Parse("465198187808352499674075441") };
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
public class A262724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262724.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262724Inst Instance=new A262724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262725
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262725Inst : IEnumerable<long>
{
public static readonly long[] Value=A262725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262725.Bytes);
public long this[int i]=>Value[i];

public static A262725Inst Instance=new A262725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262726
{
public static readonly long[] Value={ 1L,-2L,0L,0L,2L,0L,1L,-2L,0L,-2L,2L,0L,0L,0L,0L,-2L,2L,0L,1L,-2L,0L,0L,4L,0L,0L,-2L,0L,-2L,0L,0L,0L,-2L,0L,0L,2L,0L,3L,-2L,0L,0L,2L,0L,2L,-2L,0L,-2L,0L,0L,0L,-2L,0L,0L,2L,0L,2L,-2L,0L,0L,0L,0L,1L,-4L,0L,0L,4L,0L,0L,-2L,0L,-2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262726Inst : IEnumerable<long>
{
public static readonly long[] Value=A262726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262726.Bytes);
public long this[int i]=>Value[i];

public static A262726Inst Instance=new A262726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262727
{
public static readonly long[] Value={ 2L,7L,13L,41L,151L,173L,181L,223L,331L,641L,1373L,1759L,2011L,3061L,4507L,5867L,9601L,13537L,14533L,14591L,14821L,15101L,15161L,30557L,32707L,37657L,38653L,45361L,46687L,48463L,54331L,54773L,59197L,63853L,70321L,76031L,77041L,78101L,87133L,91541L,95083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262727Inst : IEnumerable<long>
{
public static readonly long[] Value=A262727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262727.Bytes);
public long this[int i]=>Value[i];

public static A262727Inst Instance=new A262727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262728
{
public static readonly long[] Value={ 2L,173L,181L,233L,443L,877L,967L,1373L,1831L,4001L,4231L,4663L,8191L,8753L,9043L,10333L,10631L,13537L,14591L,16931L,18211L,25411L,32707L,32843L,33637L,37573L,54773L,56167L,63853L,64513L,78101L,84131L,100207L,102667L,106087L,112571L,113153L,133087L,149531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262728Inst : IEnumerable<long>
{
public static readonly long[] Value=A262728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262728.Bytes);
public long this[int i]=>Value[i];

public static A262728Inst Instance=new A262728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262729
{
public static readonly long[] Value={ 2L,171472673L,343808687L,1364225981L,1469999801L,1871684753L,2110769237L,2227044401L,2411201729L,2485782361L,2545607453L,3795488227L,3946237717L,4213334953L,4395443513L,5308651577L,5770033901L,5832097819L,6385775491L,6694883219L,7064806421L,7235208829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262729Inst : IEnumerable<long>
{
public static readonly long[] Value=A262729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262729.Bytes);
public long this[int i]=>Value[i];

public static A262729Inst Instance=new A262729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262730
{
public static readonly long[] Value={ 2L,3L,23L,83L,199L,331L,487L,1069L,1289L,1697L,2467L,3463L,3617L,3733L,5153L,5449L,6221L,9203L,9811L,9967L,12473L,13883L,14723L,15791L,16001L,18919L,33589L,33827L,46093L,58321L,59051L,59921L,60289L,71249L,84349L,85133L,88211L,124309L,126047L,126359L,127541L,145679L,146807L,153247L,165233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262730Inst : IEnumerable<long>
{
public static readonly long[] Value=A262730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262730.Bytes);
public long this[int i]=>Value[i];

public static A262730Inst Instance=new A262730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262731
{
public static readonly long[] Value={ 11L,13L,17L,19L,41L,43L,101L,103L,223L,293L,313L,331L,359L,401L,409L,439L,491L,521L,523L,571L,613L,677L,709L,821L,883L,947L,1009L,1039L,1061L,1193L,1283L,1291L,1303L,1373L,1409L,1427L,1453L,1471L,1487L,1543L,1553L,1609L,1669L,1697L,1811L,1861L,1879L,1907L,1949L,1999L,2039L,2063L,2143L,2213L,2239L,2251L,2267L,2287L,2309L,2381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262731Inst : IEnumerable<long>
{
public static readonly long[] Value=A262731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262731.Bytes);
public long this[int i]=>Value[i];

public static A262731Inst Instance=new A262731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262732
{
public static readonly BigInteger[] Value={ 1L,8L,126L,2240L,41990L,811008L,15967980L,318636032L,6421422150L,130395668480L,2663825039876L,54684895150080L,1127155102890908L,23311847679590400L,483537022180231320L,10054732930602762240UL,BigInteger.Parse("209536624110664757830"),BigInteger.Parse("4375058594685417160704"),BigInteger.Parse("91505601042318156186900") };
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
public class A262732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262732Inst Instance=new A262732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262733
{
public static readonly BigInteger[] Value={ 1L,12L,286L,7680L,217350L,6336512L,188296108L,5670567936L,172459427910L,5284842700800L,162922160580036L,5047099485847552L,156983503897469340L,4899363753956474880L,BigInteger.Parse("153349672416272587800"),BigInteger.Parse("4811846645261721927680"),BigInteger.Parse("151316978279502571401798"),BigInteger.Parse("4767566079229070105640960") };
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
public class A262733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262733.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262733Inst Instance=new A262733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262734
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262734Inst : IEnumerable<long>
{
public static readonly long[] Value=A262734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262734.Bytes);
public long this[int i]=>Value[i];

public static A262734Inst Instance=new A262734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262735
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,8L,17L,36L,77L,165L,354L,760L,1632L,3505L,7528L,16169L,34729L,74594L,160220L,344136L,739169L,1587660L,3410133L,7324621L,15732546L,33791920L,72581632L,155898017L,334853200L,719230865L,1544835281L,3318150210L,7127051636L,15308187336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262735Inst : IEnumerable<long>
{
public static readonly long[] Value=A262735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262735.Bytes);
public long this[int i]=>Value[i];

public static A262735Inst Instance=new A262735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262736
{
public static readonly long[] Value={ 1L,1L,0L,3L,3L,5L,8L,10L,22L,25L,41L,57L,88L,126L,168L,261L,351L,512L,685L,984L,1357L,1865L,2566L,3485L,4838L,6459L,8832L,11831L,16056L,21404L,28660L,38259L,50875L,67613L,89161L,118184L,155321L,204609L,267708L,351125L,458331L,597740L,777590L,1010020L,1310390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262736Inst : IEnumerable<long>
{
public static readonly long[] Value=A262736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262736.Bytes);
public long this[int i]=>Value[i];

public static A262736Inst Instance=new A262736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262737
{
public static readonly BigInteger[] Value={ 1L,8L,95L,1336L,20642L,338640L,5791291L,102108760L,1842857390L,33879118384L,632210693270L,11944142806064L,228010741228740L,4391334026631072L,85221618348230355L,1664901954576830360L,BigInteger.Parse("32716286416687895862"),BigInteger.Parse("646228961799752926320"),BigInteger.Parse("12823701194384778672322") };
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
public class A262737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262737Inst Instance=new A262737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262738
{
public static readonly BigInteger[] Value={ 1L,10L,149L,2630L,51002L,1050132L,22539085L,498732014L,11296141454L,260613866380L,6103074997890L,144696786555580L,3466352150674324L,83776927644646952L,2040261954214847421L,BigInteger.Parse("50018542073019175806"),BigInteger.Parse("1233419779839067305350"),BigInteger.Parse("30572886836581693309020") };
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
public class A262738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262738.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262738Inst Instance=new A262738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262739
{
public static readonly BigInteger[] Value={ 1L,12L,215L,4564L,106442L,2635704L,68031147L,1810302340L,49308457334L,1368019979976L,38525145673126L,1098380420669000L,31641932951483220L,919622628946689648L,BigInteger.Parse("26931762975278938035"),BigInteger.Parse("793967020231145502564"),BigInteger.Parse("23543663463050594677310"),BigInteger.Parse("701763102761640853890600"),BigInteger.Parse("21014048069544552257072530"),BigInteger.Parse("631868353403527700756671320"),BigInteger.Parse("19070677448561228207945931276") };
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
public class A262739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262739Inst Instance=new A262739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262740
{
public static readonly BigInteger[] Value={ 1L,14L,293L,7266L,197962L,5726364L,172662765L,5367187226L,170772853790L,5534640052292L,182070248073826L,6063785526898644L,204055962203476788L,6927718839334775608L,BigInteger.Parse("236994877398511998717"),BigInteger.Parse("8161492483543100398410"),BigInteger.Parse("282705062046649346154006"),BigInteger.Parse("9843330120848835962213940") };
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
public class A262740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262740Inst Instance=new A262740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262741
{
public static readonly long[] Value={ 15L,33L,45L,51L,63L,65L,69L,75L,87L,91L,95L,99L,105L,123L,135L,141L,145L,147L,153L,159L,165L,175L,177L,189L,195L,207L,213L,221L,225L,231L,245L,249L,255L,261L,267L,273L,285L,287L,295L,297L,303L,315L,321L,325L,339L,345L,357L,363L,369L,375L,385L,393L,395L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262741Inst : IEnumerable<long>
{
public static readonly long[] Value=A262741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262741.Bytes);
public long this[int i]=>Value[i];

public static A262741Inst Instance=new A262741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262742
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,0L,0L,0L,4L,0L,0L,0L,6L,0L,0L,0L,4L,0L,0L,0L,1L,1L,1L,4L,4L,10L,10L,20L,20L,31L,31L,40L,40L,44L,44L,40L,40L,31L,31L,20L,20L,10L,10L,4L,4L,1L,1L,1L,0L,0L,0L,9L,0L,0L,0L,36L,0L,0L,0L,84L,0L,0L,0L,126L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262742Inst : IEnumerable<long>
{
public static readonly long[] Value=A262742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262742.Bytes);
public long this[int i]=>Value[i];

public static A262742Inst Instance=new A262742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262743
{
public static readonly long[] Value={ 64L,95L,130L,242L,325L,326L,392L,396L,435L,504L,544L,552L,572L,585L,632L,644L,664L,693L,740L,748L,756L,762L,770L,784L,806L,868L,952L,968L,973L,986L,990L,995L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262743Inst : IEnumerable<long>
{
public static readonly long[] Value=A262743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262743.Bytes);
public long this[int i]=>Value[i];

public static A262743Inst Instance=new A262743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262744
{
public static readonly long[] Value={ 0L,2L,4L,7L,13L,20L,2L,5L,10L,19L,28L,41L,56L,71L,88L,109L,134L,159L,188L,9L,19L,32L,46L,63L,85L,108L,130L,153L,175L,198L,232L,267L,305L,342L,386L,429L,475L,524L,574L,627L,683L,738L,800L,861L,923L,984L,1054L,1133L,1213L,17L,46L,77L,106L,141L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262744Inst : IEnumerable<long>
{
public static readonly long[] Value=A262744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262744.Bytes);
public long this[int i]=>Value[i];

public static A262744Inst Instance=new A262744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262745
{
public static readonly BigInteger[] Value={ 0L,0L,1L,4L,12L,52L,360L,2656L,20160L,177472L,1814400L,20135296L,239500800L,3102326272L,43589145600L,654789062656L,10461394944000L,177738781376512L,3201186852864000L,60837094646972416L,1216451004088320000L,BigInteger.Parse("25542995336828157952"),BigInteger.Parse("562000363888803840000") };
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
public class A262745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262745Inst Instance=new A262745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262746
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,2L,3L,3L,3L,4L,2L,3L,2L,3L,3L,3L,3L,4L,5L,1L,4L,4L,3L,3L,6L,5L,2L,4L,4L,6L,3L,2L,5L,6L,3L,1L,6L,4L,4L,4L,4L,4L,4L,4L,2L,6L,4L,3L,7L,5L,5L,4L,6L,5L,7L,2L,3L,8L,3L,5L,3L,4L,6L,7L,5L,4L,7L,4L,6L,7L,3L,4L,8L,7L,4L,3L,4L,4L,11L,3L,4L,9L,4L,4L,6L,7L,2L,9L,6L,3L,6L,4L,6L,7L,3L,5L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262746Inst : IEnumerable<long>
{
public static readonly long[] Value=A262746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262746.Bytes);
public long this[int i]=>Value[i];

public static A262746Inst Instance=new A262746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262747
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,3L,2L,1L,2L,4L,2L,2L,1L,2L,2L,1L,2L,3L,2L,3L,4L,3L,1L,2L,3L,4L,2L,4L,2L,2L,3L,1L,4L,2L,1L,2L,5L,4L,1L,2L,2L,6L,3L,2L,4L,4L,3L,3L,4L,3L,3L,5L,3L,3L,4L,2L,6L,7L,3L,4L,4L,5L,2L,2L,5L,6L,6L,1L,5L,4L,4L,4L,6L,6L,1L,4L,4L,2L,4L,3L,5L,6L,3L,4L,5L,5L,4L,2L,2L,6L,5L,4L,6L,3L,3L,1L,5L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262747Inst : IEnumerable<long>
{
public static readonly long[] Value=A262747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262747.Bytes);
public long this[int i]=>Value[i];

public static A262747Inst Instance=new A262747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262748
{
public static readonly long[] Value={ 9L,21L,25L,27L,35L,39L,49L,55L,57L,77L,81L,85L,93L,111L,115L,117L,119L,121L,125L,129L,133L,143L,155L,161L,169L,171L,183L,185L,187L,201L,203L,205L,209L,215L,217L,219L,235L,237L,243L,247L,253L,259L,265L,275L,279L,289L,291L,299L,301L,305L,309L,319L,323L,327L,329L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262748Inst : IEnumerable<long>
{
public static readonly long[] Value=A262748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262748.Bytes);
public long this[int i]=>Value[i];

public static A262748Inst Instance=new A262748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262749
{
public static readonly long[] Value={ 16L,31L,46L,51L,76L,81L,94L,106L,111L,121L,123L,126L,133L,141L,146L,156L,157L,172L,174L,181L,186L,191L,196L,198L,211L,216L,225L,226L,231L,237L,241L,246L,256L,259L,268L,276L,281L,286L,289L,291L,297L,301L,310L,315L,321L,326L,328L,331L,336L,346L,354L,361L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262749Inst : IEnumerable<long>
{
public static readonly long[] Value=A262749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262749.Bytes);
public long this[int i]=>Value[i];

public static A262749Inst Instance=new A262749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262750
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,4L,1L,1L,2L,2L,4L,1L,2L,4L,1L,1L,2L,2L,1L,2L,3L,4L,4L,1L,2L,2L,5L,1L,2L,6L,1L,2L,3L,2L,1L,1L,2L,4L,1L,1L,2L,4L,4L,1L,2L,4L,4L,1L,2L,2L,1L,1L,2L,5L,4L,3L,3L,2L,4L,1L,2L,6L,1L,1L,2L,8L,1L,2L,3L,4L,1L,1L,2L,2L,6L,3L,3L,4L,1L,1L,2L,2L,5L,1L,2L,4L,4L,1L,2L,2L,4L,6L,3L,8L,4L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262750Inst : IEnumerable<long>
{
public static readonly long[] Value=A262750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262750.Bytes);
public long this[int i]=>Value[i];

public static A262750Inst Instance=new A262750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262751
{
public static readonly long[] Value={ -1L,1L,-3L,15L,-97L,709L,-5469L,44205L,-397923L,4296945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262751Inst : IEnumerable<long>
{
public static readonly long[] Value=A262751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262751.Bytes);
public long this[int i]=>Value[i];

public static A262751Inst Instance=new A262751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262752
{
public static readonly long[] Value={ 2L,9L,49L,1645L,135595L,71515801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262752Inst : IEnumerable<long>
{
public static readonly long[] Value=A262752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262752.Bytes);
public long this[int i]=>Value[i];

public static A262752Inst Instance=new A262752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262753
{
public static readonly long[] Value={ 4L,9L,25L,100L,361L,1369L,5476L,21609L,85849L,343396L,1371241L,5480281L,21921124L,87665769L,350625625L,1402502500L,5609860201L,22439141209L,89756564836L,359025060969L,1436097847129L,5744391388516L,22977555967081L,91910204694361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262753Inst : IEnumerable<long>
{
public static readonly long[] Value=A262753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262753.Bytes);
public long this[int i]=>Value[i];

public static A262753Inst Instance=new A262753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262754
{
public static readonly long[] Value={ 7L,17L,49L,319L,1345L,6193L,39751L,229841L,1339569L,8663743L,55835745L,358608881L,2379031207L,15973282577L,107339155889L,729414305599L,4997779808385L,34344305727921L,237112117127431L,1643074583243345L,11416088795366577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262754Inst : IEnumerable<long>
{
public static readonly long[] Value=A262754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262754.Bytes);
public long this[int i]=>Value[i];

public static A262754Inst Instance=new A262754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262755
{
public static readonly long[] Value={ 13L,37L,129L,1645L,8605L,52993L,658381L,5747701L,51979793L,636258829L,7230695309L,80140442481L,979582061773L,12020681709477L,143857668728353L,1766744698318765L,21995191160679549L,270443634865041121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262755Inst : IEnumerable<long>
{
public static readonly long[] Value=A262755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262755.Bytes);
public long this[int i]=>Value[i];

public static A262755Inst Instance=new A262755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262756
{
public static readonly long[] Value={ 26L,107L,709L,16450L,135595L,1635877L,37426418L,595006235L,10954392773L,252014772610L,5417495716875L,121326759600741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262756Inst : IEnumerable<long>
{
public static readonly long[] Value=A262756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262756.Bytes);
public long this[int i]=>Value[i];

public static A262756Inst Instance=new A262756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262757
{
public static readonly long[] Value={ 52L,321L,4953L,243220L,3051121L,71515801L,3270912532L,99189450609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262757Inst : IEnumerable<long>
{
public static readonly long[] Value=A262757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262757.Bytes);
public long this[int i]=>Value[i];

public static A262757Inst Instance=new A262757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262758
{
public static readonly long[] Value={ 103L,865L,16705L,1614175L,31840777L,1252506169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262758Inst : IEnumerable<long>
{
public static readonly long[] Value=A262758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262758.Bytes);
public long this[int i]=>Value[i];

public static A262758Inst Instance=new A262758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262759
{
public static readonly long[] Value={ 2L,4L,3L,7L,9L,5L,13L,17L,25L,10L,26L,37L,49L,100L,19L,52L,107L,129L,319L,361L,37L,103L,321L,709L,1645L,1345L,1369L,74L,205L,865L,4953L,16450L,8605L,6193L,5476L,147L,410L,2449L,16705L,243220L,135595L,52993L,39751L,21609L,293L,820L,7299L,73345L,1614175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262759Inst : IEnumerable<long>
{
public static readonly long[] Value=A262759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262759.Bytes);
public long this[int i]=>Value[i];

public static A262759Inst Instance=new A262759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262760
{
public static readonly long[] Value={ 5L,25L,49L,129L,709L,4953L,16705L,73345L,384485L,2252185L,9821425L,47556225L,241769125L,1278440025L,6106506625L,30240858625L,152043549125L,774590745625L,3814859880625L,19015880330625L,95252710613125L,479215784705625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262760Inst : IEnumerable<long>
{
public static readonly long[] Value=A262760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262760.Bytes);
public long this[int i]=>Value[i];

public static A262760Inst Instance=new A262760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262761
{
public static readonly long[] Value={ 10L,100L,319L,1645L,16450L,243220L,1614175L,15350125L,153501250L,1790228500L,15826009375L,157647278125L,1576472781250L,16543231412500L,159357016609375L,1592677865078125L,15926778650781250L,161625340977812500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262761Inst : IEnumerable<long>
{
public static readonly long[] Value=A262761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262761.Bytes);
public long this[int i]=>Value[i];

public static A262761Inst Instance=new A262761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262762
{
public static readonly long[] Value={ 19L,361L,1345L,8605L,135595L,3051121L,31840777L,475175089L,7929763795L,150668328169L,2326985790673L,39746065869181L,690182655459499L,12460277987364721L,213488928651534985L,3766549018888748593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262762Inst : IEnumerable<long>
{
public static readonly long[] Value=A262762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262762.Bytes);
public long this[int i]=>Value[i];

public static A262762Inst Instance=new A262762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262763
{
public static readonly long[] Value={ 37L,1369L,6193L,52993L,1635877L,71515801L,1252506169L,32264365249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262763Inst : IEnumerable<long>
{
public static readonly long[] Value=A262763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262763.Bytes);
public long this[int i]=>Value[i];

public static A262763Inst Instance=new A262763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262764
{
public static readonly long[] Value={ 74L,5476L,39751L,658381L,37426418L,3270912532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262764Inst : IEnumerable<long>
{
public static readonly long[] Value=A262764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262764.Bytes);
public long this[int i]=>Value[i];

public static A262764Inst Instance=new A262764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262765
{
public static readonly long[] Value={ 1L,2L,3L,7L,14L,28L,57L,113L,227L,437L,834L,1616L,3143L,6144L,12036L,23467L,45713L,89375L,175722L,346193L,681828L,1344815L,2657630L,5253615L,10374965L,20471599L,40401901L,79871358L,158182869L,313402574L,620776183L,1228390053L,2430853614L,4813878134L,9550070608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262765Inst : IEnumerable<long>
{
public static readonly long[] Value=A262765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262765.Bytes);
public long this[int i]=>Value[i];

public static A262765Inst Instance=new A262765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262766
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,3L,2L,1L,2L,4L,2L,2L,1L,2L,2L,1L,2L,3L,2L,3L,4L,3L,1L,2L,3L,3L,1L,4L,2L,2L,2L,1L,3L,2L,1L,2L,4L,4L,1L,2L,2L,6L,3L,2L,3L,4L,3L,3L,4L,3L,3L,4L,3L,3L,4L,2L,5L,6L,3L,4L,4L,4L,2L,2L,4L,5L,4L,1L,5L,4L,3L,4L,5L,6L,1L,4L,3L,2L,3L,3L,5L,5L,3L,4L,4L,4L,3L,2L,2L,5L,4L,4L,5L,3L,3L,1L,3L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262766Inst : IEnumerable<long>
{
public static readonly long[] Value=A262766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262766.Bytes);
public long this[int i]=>Value[i];

public static A262766Inst Instance=new A262766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262767
{
public static readonly long[] Value={ 4L,6L,8L,8L,12L,10L,16L,12L,12L,14L,24L,14L,28L,18L,16L,16L,36L,18L,40L,18L,20L,26L,48L,20L,20L,30L,24L,22L,60L,22L,64L,24L,28L,38L,24L,24L,76L,42L,32L,26L,84L,26L,88L,30L,28L,50L,96L,28L,28L,30L,40L,34L,108L,30L,32L,30L,44L,62L,120L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262767Inst : IEnumerable<long>
{
public static readonly long[] Value=A262767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262767.Bytes);
public long this[int i]=>Value[i];

public static A262767Inst Instance=new A262767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262768
{
public static readonly long[] Value={ 0L,0L,4L,20L,85L,344L,1365L,5368L,21021L,82160L,320892L,1253240L,4896034L,19137104L,74847175L,292929840L,1147223325L,4496006880L,17631691440L,69189377400L,271676550390L,1067383059600L,4195964793930L,16503454480656L,64943823784050L,255687666536224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262768Inst : IEnumerable<long>
{
public static readonly long[] Value=A262768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262768.Bytes);
public long this[int i]=>Value[i];

public static A262768Inst Instance=new A262768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262769
{
public static readonly long[] Value={ 3L,23L,63L,261L,281L,291L,4689L,11231L,12519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262769Inst : IEnumerable<long>
{
public static readonly long[] Value=A262769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262769.Bytes);
public long this[int i]=>Value[i];

public static A262769Inst Instance=new A262769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262770
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,10L,12L,14L,16L,18L,19L,21L,23L,25L,27L,28L,30L,32L,34L,36L,37L,39L,41L,43L,45L,46L,48L,50L,52L,54L,55L,57L,59L,61L,63L,64L,66L,68L,70L,72L,73L,75L,77L,79L,81L,82L,84L,86L,88L,90L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,109L,111L,113L,115L,117L,118L,120L,122L,124L,126L,127L,129L,131L,133L,135L,136L,138L,140L,142L,144L,145L,147L,149L,151L,153L,154L,156L,158L,160L,162L,163L,165L,167L,169L,171L,172L,174L,176L,178L,180L,181L,183L,185L,187L,189L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262770Inst : IEnumerable<long>
{
public static readonly long[] Value=A262770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262770.Bytes);
public long this[int i]=>Value[i];

public static A262770Inst Instance=new A262770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262771
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,0L,-1L,1L,0L,0L,1L,-2L,0L,3L,-2L,-2L,4L,0L,-3L,2L,-1L,-1L,3L,-4L,-1L,8L,-5L,-6L,10L,-2L,-7L,7L,-2L,-2L,8L,-10L,-3L,18L,-12L,-12L,22L,-4L,-15L,15L,-5L,-6L,19L,-20L,-7L,38L,-24L,-26L,45L,-10L,-30L,34L,-13L,-13L,40L,-40L,-16L,74L,-46L,-48L,87L,-22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262771Inst : IEnumerable<long>
{
public static readonly long[] Value=A262771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262771.Bytes);
public long this[int i]=>Value[i];

public static A262771Inst Instance=new A262771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262772
{
public static readonly long[] Value={ 7L,45L,67L,145L,411L,825L,1021L,4039L,9069L,9789L,12463L,15137L,26313L,27499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262772Inst : IEnumerable<long>
{
public static readonly long[] Value=A262772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262772.Bytes);
public long this[int i]=>Value[i];

public static A262772Inst Instance=new A262772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262773
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,11L,13L,15L,17L,20L,22L,24L,26L,29L,31L,33L,35L,38L,40L,42L,44L,47L,49L,51L,53L,56L,58L,60L,62L,65L,67L,69L,71L,74L,76L,78L,80L,83L,85L,87L,89L,92L,94L,96L,98L,101L,103L,105L,107L,110L,112L,114L,116L,119L,121L,123L,125L,128L,130L,132L,134L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262773Inst : IEnumerable<long>
{
public static readonly long[] Value=A262773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262773.Bytes);
public long this[int i]=>Value[i];

public static A262773Inst Instance=new A262773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262774
{
public static readonly long[] Value={ 1L,0L,1L,-2L,0L,-2L,1L,0L,0L,-2L,0L,0L,3L,0L,2L,-2L,0L,0L,2L,0L,1L,0L,0L,-2L,2L,0L,0L,-2L,0L,-2L,1L,0L,2L,-4L,0L,0L,0L,0L,0L,-2L,0L,0L,3L,0L,0L,-2L,0L,-2L,2L,0L,2L,0L,0L,0L,4L,0L,1L,-2L,0L,-2L,2L,0L,0L,0L,0L,0L,0L,0L,4L,-2L,0L,0L,1L,0L,0L,-4L,0L,-2L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262774Inst : IEnumerable<long>
{
public static readonly long[] Value=A262774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262774.Bytes);
public long this[int i]=>Value[i];

public static A262774Inst Instance=new A262774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262775
{
public static readonly long[] Value={ 0L,2L,3L,7L,9L,13L,15L,19L,21L,27L,33L,37L,39L,49L,51L,55L,57L,63L,67L,69L,81L,85L,99L,105L,109L,111L,117L,121L,123L,127L,135L,141L,147L,153L,175L,177L,189L,195L,201L,207L,211L,219L,247L,249L,261L,265L,267L,273L,279L,285L,289L,301L,303L,307L,315L,327L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262775Inst : IEnumerable<long>
{
public static readonly long[] Value=A262775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262775.Bytes);
public long this[int i]=>Value[i];

public static A262775Inst Instance=new A262775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262776
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,20160L,1098377280L,10712200669548618240UL,BigInteger.Parse("157910199555786679826546221836620444160"),BigInteger.Parse("12162675222629942931022379230724715707339402614012620710827200735689241600") };
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
public class A262776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262776Inst Instance=new A262776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262777
{
public static readonly ulong[] Value={ 8L,97L,995L,9993L,99989L,999987L,9999983L,99999981L,999999977L,9999999971L,99999999969L,999999999963L,9999999999959L,99999999999957L,999999999999953L,9999999999999947L,99999999999999941L,999999999999999939L,9999999999999999933UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262777Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A262777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262777.Bytes);
public ulong this[int i]=>Value[i];

public static A262777Inst Instance=new A262777Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262778
{
public static readonly long[] Value={ 12L,103L,1005L,10007L,100011L,1000013L,10000017L,100000019L,1000000023L,10000000029L,100000000031L,1000000000037L,10000000000041L,100000000000043L,1000000000000047L,10000000000000053L,100000000000000059L,1000000000000000061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262778Inst : IEnumerable<long>
{
public static readonly long[] Value=A262778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262778.Bytes);
public long this[int i]=>Value[i];

public static A262778Inst Instance=new A262778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262779
{
public static readonly BigInteger[] Value={ 1L,110L,11011L,1101111L,110111111L,11011111111L,1101111111111L,110111111111111L,11011111111111111L,1101111111111111111L,BigInteger.Parse("110111111111111111111"),BigInteger.Parse("11011111111111111111111"),BigInteger.Parse("1101111111111111111111111"),BigInteger.Parse("110111111111111111111111111"),BigInteger.Parse("11011111111111111111111111111") };
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
public class A262779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262779Inst Instance=new A262779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262780
{
public static readonly long[] Value={ 1L,1L,0L,-2L,1L,0L,-2L,0L,0L,2L,-2L,0L,1L,1L,0L,-2L,0L,0L,-2L,-2L,0L,2L,0L,0L,3L,0L,0L,0L,2L,0L,-2L,-2L,0L,2L,0L,0L,2L,1L,0L,-2L,1L,0L,0L,0L,0L,4L,-2L,0L,2L,0L,0L,-2L,0L,0L,-2L,-2L,0L,0L,-2L,0L,1L,0L,0L,-2L,2L,0L,-4L,0L,0L,2L,0L,0L,0L,3L,0L,-2L,0L,0L,-2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262780Inst : IEnumerable<long>
{
public static readonly long[] Value=A262780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262780.Bytes);
public long this[int i]=>Value[i];

public static A262780Inst Instance=new A262780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262781
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,0L,2L,3L,1L,1L,2L,3L,2L,3L,2L,2L,1L,3L,3L,1L,2L,3L,4L,1L,1L,3L,2L,3L,2L,4L,1L,3L,2L,2L,3L,1L,3L,3L,4L,2L,2L,3L,5L,5L,1L,4L,4L,4L,2L,6L,4L,4L,4L,6L,3L,4L,5L,4L,5L,4L,4L,3L,6L,4L,2L,3L,3L,5L,4L,4L,4L,3L,1L,4L,5L,4L,3L,6L,3L,1L,2L,3L,4L,4L,5L,5L,3L,3L,2L,8L,5L,3L,4L,2L,4L,4L,2L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262781Inst : IEnumerable<long>
{
public static readonly long[] Value=A262781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262781.Bytes);
public long this[int i]=>Value[i];

public static A262781Inst Instance=new A262781Inst();

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