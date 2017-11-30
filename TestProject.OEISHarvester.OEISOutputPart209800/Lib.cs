using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A248182
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248182Inst : IEnumerable<long>
{
public static readonly long[] Value=A248182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248182.Bytes);
public long this[int i]=>Value[i];

public static A248182Inst Instance=new A248182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248183
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,4L,5L,5L,6L,7L,8L,8L,9L,10L,10L,11L,12L,12L,13L,14L,15L,15L,16L,17L,17L,18L,19L,20L,20L,21L,22L,22L,23L,24L,24L,25L,26L,27L,27L,28L,29L,29L,30L,31L,32L,32L,33L,34L,34L,35L,36L,36L,37L,38L,39L,39L,40L,41L,41L,42L,43L,44L,44L,45L,46L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248183Inst : IEnumerable<long>
{
public static readonly long[] Value=A248183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248183.Bytes);
public long this[int i]=>Value[i];

public static A248183Inst Instance=new A248183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248184
{
public static readonly long[] Value={ 1L,2L,5L,8L,12L,15L,18L,22L,25L,29L,32L,35L,39L,42L,46L,49L,52L,56L,59L,63L,66L,70L,73L,76L,80L,83L,87L,90L,93L,97L,100L,104L,107L,110L,114L,117L,121L,124L,128L,131L,134L,138L,141L,145L,148L,151L,155L,158L,162L,165L,169L,172L,175L,179L,182L,186L,189L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248184Inst : IEnumerable<long>
{
public static readonly long[] Value=A248184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248184.Bytes);
public long this[int i]=>Value[i];

public static A248184Inst Instance=new A248184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248185
{
public static readonly long[] Value={ 3L,4L,6L,7L,9L,10L,11L,13L,14L,16L,17L,19L,20L,21L,23L,24L,26L,27L,28L,30L,31L,33L,34L,36L,37L,38L,40L,41L,43L,44L,45L,47L,48L,50L,51L,53L,54L,55L,57L,58L,60L,61L,62L,64L,65L,67L,68L,69L,71L,72L,74L,75L,77L,78L,79L,81L,82L,84L,85L,86L,88L,89L,91L,92L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248185Inst : IEnumerable<long>
{
public static readonly long[] Value=A248185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248185.Bytes);
public long this[int i]=>Value[i];

public static A248185Inst Instance=new A248185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248186
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,3L,4L,5L,5L,6L,7L,8L,8L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,26L,26L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,41L,42L,43L,44L,44L,45L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248186Inst : IEnumerable<long>
{
public static readonly long[] Value=A248186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248186.Bytes);
public long this[int i]=>Value[i];

public static A248186Inst Instance=new A248186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248187
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,13L,16L,19L,22L,26L,29L,32L,35L,39L,42L,45L,48L,52L,55L,58L,61L,65L,68L,71L,75L,78L,81L,84L,88L,91L,94L,97L,101L,104L,107L,110L,114L,117L,120L,123L,127L,130L,133L,136L,140L,143L,146L,150L,153L,156L,159L,163L,166L,169L,172L,176L,179L,182L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248187Inst : IEnumerable<long>
{
public static readonly long[] Value=A248187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248187.Bytes);
public long this[int i]=>Value[i];

public static A248187Inst Instance=new A248187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248188
{
public static readonly long[] Value={ 4L,5L,7L,8L,10L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,25L,27L,28L,30L,31L,33L,34L,36L,37L,38L,40L,41L,43L,44L,46L,47L,49L,50L,51L,53L,54L,56L,57L,59L,60L,62L,63L,64L,66L,67L,69L,70L,72L,73L,74L,76L,77L,79L,80L,82L,83L,85L,86L,87L,89L,90L,92L,93L,95L,96L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248188Inst : IEnumerable<long>
{
public static readonly long[] Value=A248188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248188.Bytes);
public long this[int i]=>Value[i];

public static A248188Inst Instance=new A248188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248189
{
public static readonly long[] Value={ 1L,1L,1L,7L,2L,38L,4L,81L,1L,102L,868L,1L,9L,3L,702L,26505L,1554L,14L,3L,243L,1L,650L,108L,1833L,34542L,18L,68L,186L,7252L,39L,58L,736839L,1L,3108L,72L,778L,210L,6L,3L,4830L,267L,2L,567L,5859L,6640L,6363L,3178412L,155771L,4964L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248189Inst : IEnumerable<long>
{
public static readonly long[] Value=A248189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248189.Bytes);
public long this[int i]=>Value[i];

public static A248189Inst Instance=new A248189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248190
{
public static readonly long[] Value={ 8L,3L,7L,7L,5L,5L,7L,6L,3L,4L,7L,6L,5L,9L,8L,0L,5L,7L,9L,1L,2L,3L,6L,5L,9L,9L,7L,0L,0L,3L,2L,1L,2L,3L,7L,5L,6L,8L,3L,0L,6L,1L,5L,8L,0L,8L,9L,5L,1L,3L,9L,1L,5L,0L,6L,1L,9L,7L,4L,5L,2L,1L,0L,8L,4L,6L,3L,4L,8L,8L,4L,3L,0L,2L,5L,0L,7L,3L,9L,3L,0L,0L,2L,6L,1L,4L,2L,4L,5L,6L,4L,9L,2L,7L,5L,3L,8L,2L,9L,7L,6L,2L,9L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248190Inst : IEnumerable<long>
{
public static readonly long[] Value=A248190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248190.Bytes);
public long this[int i]=>Value[i];

public static A248190Inst Instance=new A248190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248191
{
public static readonly long[] Value={ 5L,9L,2L,3L,8L,2L,7L,8L,1L,3L,3L,2L,4L,1L,5L,8L,8L,5L,2L,9L,0L,3L,6L,3L,3L,7L,4L,4L,9L,1L,9L,9L,5L,3L,7L,2L,7L,6L,1L,5L,2L,9L,9L,9L,3L,2L,0L,5L,7L,7L,0L,6L,6L,5L,2L,3L,4L,2L,8L,9L,9L,3L,9L,6L,2L,7L,1L,7L,6L,2L,3L,5L,1L,2L,5L,5L,5L,3L,9L,7L,0L,3L,2L,0L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248191Inst : IEnumerable<long>
{
public static readonly long[] Value=A248191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248191.Bytes);
public long this[int i]=>Value[i];

public static A248191Inst Instance=new A248191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248192
{
public static readonly long[] Value={ 3L,5L,0L,9L,1L,9L,8L,0L,7L,1L,7L,4L,1L,4L,3L,2L,3L,6L,4L,3L,0L,2L,2L,9L,5L,8L,9L,0L,5L,6L,2L,7L,6L,3L,8L,0L,9L,3L,1L,1L,4L,6L,0L,4L,3L,9L,8L,5L,3L,4L,5L,9L,0L,7L,3L,8L,8L,8L,6L,4L,9L,1L,2L,2L,6L,1L,8L,9L,6L,3L,0L,9L,8L,2L,9L,1L,5L,3L,8L,7L,2L,6L,7L,8L,9L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248192Inst : IEnumerable<long>
{
public static readonly long[] Value=A248192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248192.Bytes);
public long this[int i]=>Value[i];

public static A248192Inst Instance=new A248192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248193
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,5L,10L,17L,26L,37L,51L,74L,118L,201L,347L,586L,955L,1509L,2351L,3682L,5871L,9545L,15700L,25851L,42292L,68606L,110635L,178190L,287852L,467313L,761957L,1245011L,2033856L,3317230L,5401332L,8787539L,14301168L,23301005L,38016585L,62090615L,101457357L,165778774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248193Inst : IEnumerable<long>
{
public static readonly long[] Value=A248193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248193.Bytes);
public long this[int i]=>Value[i];

public static A248193Inst Instance=new A248193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248194
{
public static readonly long[] Value={ 1L,3L,8L,9L,17L,19L,24L,25L,33L,49L,51L,57L,67L,72L,73L,81L,88L,89L,96L,97L,99L,121L,129L,136L,147L,152L,163L,169L,177L,179L,193L,201L,211L,225L,233L,241L,243L,249L,264L,288L,289L,297L,313L,337L,339L,352L,361L,369L,387L,393L,408L,409L,441L,449L,451L,456L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248194Inst : IEnumerable<long>
{
public static readonly long[] Value=A248194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248194.Bytes);
public long this[int i]=>Value[i];

public static A248194Inst Instance=new A248194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248195
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,14L,16L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248195Inst : IEnumerable<long>
{
public static readonly long[] Value=A248195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248195.Bytes);
public long this[int i]=>Value[i];

public static A248195Inst Instance=new A248195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248196
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,15L,17L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248196Inst : IEnumerable<long>
{
public static readonly long[] Value=A248196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248196.Bytes);
public long this[int i]=>Value[i];

public static A248196Inst Instance=new A248196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248197
{
public static readonly long[] Value={ 1L,9L,4L,1L,17L,12L,3L,4L,2L,4L,15L,6L,1L,20L,4L,74L,4L,3L,2L,8L,9L,5L,3L,17L,5L,9L,8L,26L,8L,1L,14L,4L,17L,35L,33L,52L,29L,46L,35L,95L,4L,4L,23L,24L,23L,38L,135L,64L,11L,62L,222L,36L,92L,41L,1L,39L,6L,37L,3L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248197Inst : IEnumerable<long>
{
public static readonly long[] Value=A248197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248197.Bytes);
public long this[int i]=>Value[i];

public static A248197Inst Instance=new A248197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248198
{
public static readonly long[] Value={ 2L,13L,43L,101L,197L,340L,539L,805L,1146L,1571L,2091L,2715L,3452L,4311L,5302L,6434L,7718L,9161L,10775L,12567L,14548L,16726L,19112L,21715L,24544L,27609L,30918L,34483L,38311L,42412L,46796L,51472L,56450L,61739L,67348L,73288L,79566L,86193L,93179L,100531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248198Inst : IEnumerable<long>
{
public static readonly long[] Value=A248198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248198.Bytes);
public long this[int i]=>Value[i];

public static A248198Inst Instance=new A248198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248199
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,47L,499L,673L,677L,769L,1277L,1279L,1327L,1697L,2357L,3163L,3907L,4057L,4133L,4909L,5479L,5669L,6047L,7283L,9349L,9533L,9539L,9547L,9923L,10667L,11149L,11159L,12277L,12841L,17167L,17431L,17443L,21101L,21379L,22549L,22567L,22993L,24181L,24337L,24659L,24671L,25219L,26161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248199Inst : IEnumerable<long>
{
public static readonly long[] Value=A248199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248199.Bytes);
public long this[int i]=>Value[i];

public static A248199Inst Instance=new A248199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248200
{
public static readonly long[] Value={ 7L,5L,6L,9L,4L,5L,1L,0L,6L,4L,5L,7L,5L,8L,3L,6L,6L,4L,5L,8L,4L,0L,1L,7L,0L,8L,8L,1L,2L,0L,2L,4L,1L,5L,0L,0L,0L,6L,1L,1L,2L,7L,6L,6L,0L,1L,8L,7L,3L,6L,5L,8L,0L,8L,2L,1L,0L,5L,2L,8L,7L,2L,7L,5L,4L,6L,5L,7L,1L,9L,7L,2L,4L,2L,8L,2L,6L,1L,9L,7L,9L,0L,2L,5L,0L,6L,5L,3L,5L,8L,5L,6L,0L,6L,5L,2L,2L,0L,7L,7L,6L,4L,7L,1L,6L,8L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248200Inst : IEnumerable<long>
{
public static readonly long[] Value=A248200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248200.Bytes);
public long this[int i]=>Value[i];

public static A248200Inst Instance=new A248200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248201
{
public static readonly long[] Value={ 34L,86L,94L,142L,202L,214L,218L,302L,394L,446L,634L,698L,922L,1042L,1138L,1262L,1346L,1402L,1642L,1762L,1838L,1894L,1942L,1982L,2102L,2182L,2218L,2306L,2362L,2434L,2462L,2518L,2642L,2722L,2734L,3098L,3386L,3602L,3694L,3866L,3902L,3958L,4286L,4414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248201Inst : IEnumerable<long>
{
public static readonly long[] Value=A248201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248201.Bytes);
public long this[int i]=>Value[i];

public static A248201Inst Instance=new A248201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248202
{
public static readonly long[] Value={ 1310L,1886L,2014L,2666L,3730L,5134L,6062L,6214L,6306L,6478L,6854L,6986L,7258L,7954L,8394L,8534L,8786L,9214L,9454L,9822L,9878L,10282L,10946L,11606L,12454L,12566L,12802L,12858L,12994L,13054L,14134L,14314L,14330L,14466L,14818L,15086L,15266L,15806L,16114L,16134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248202Inst : IEnumerable<long>
{
public static readonly long[] Value=A248202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248202.Bytes);
public long this[int i]=>Value[i];

public static A248202Inst Instance=new A248202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248203
{
public static readonly long[] Value={ 203434L,214490L,225070L,258014L,294594L,313054L,315722L,352886L,389390L,409354L,418846L,421630L,452354L,464386L,478906L,485134L,500906L,508046L,508990L,526030L,528410L,538746L,542270L,542794L,548302L,556870L,559690L,569066L,571234L,579886L,582406L,588730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248203Inst : IEnumerable<long>
{
public static readonly long[] Value=A248203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248203.Bytes);
public long this[int i]=>Value[i];

public static A248203Inst Instance=new A248203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248204
{
public static readonly long[] Value={ 16467034L,18185870L,21134554L,21374354L,21871366L,22247554L,22412534L,22721586L,24845314L,25118094L,25228930L,25435334L,25596934L,26217246L,27140114L,29218630L,29752346L,30323734L,30563246L,31943066L,32663266L,33367894L,36055046L,38269022L,39738062L,40547066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248204Inst : IEnumerable<long>
{
public static readonly long[] Value=A248204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248204.Bytes);
public long this[int i]=>Value[i];

public static A248204Inst Instance=new A248204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248205
{
public static readonly BigInteger[] Value={ 1L,50L,4851L,475300L,46574501L,4563825750L,447208348951L,43821854371400L,4294094520048201L,420777441110352250L,BigInteger.Parse("41231895134294472251"),BigInteger.Parse("4040304945719747928300"),BigInteger.Parse("395908652785401002501101"),BigInteger.Parse("38795007668023578497179550"),BigInteger.Parse("3801514842813525291721094751") };
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
public class A248205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248205Inst Instance=new A248205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248206
{
public static readonly long[] Value={ 43L,457L,967L,11923L,15787L,41113L,213943L,294919L,392737L,430879L,524827L,572629L,730633L,1097293L,1149163L,2349313L,2738779L,3316147L,3666007L,5248153L,5396617L,5477089L,7960009L,9949627L,10048117L,11260237L,11613289L,15281023L,16153279L,17250367L,18733807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248206Inst : IEnumerable<long>
{
public static readonly long[] Value=A248206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248206.Bytes);
public long this[int i]=>Value[i];

public static A248206Inst Instance=new A248206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248207
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,0L,2L,7L,2L,0L,2L,3L,0L,0L,3L,11L,2L,0L,0L,13L,5L,0L,2L,15L,2L,0L,2L,0L,3L,0L,0L,3L,0L,0L,2L,21L,0L,0L,6L,0L,3L,0L,0L,5L,5L,0L,3L,27L,0L,0L,2L,29L,0L,0L,0L,31L,2L,0L,2L,3L,0L,0L,0L,0L,2L,0L,0L,0L,7L,0L,5L,39L,0L,0L,0L,0L,3L,0L,2L,47L,2L,0L,0L,3L,0L,0L,3L,0L,0L,0L,0L,5L,0L,0L,5L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248207Inst : IEnumerable<long>
{
public static readonly long[] Value=A248207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248207.Bytes);
public long this[int i]=>Value[i];

public static A248207Inst Instance=new A248207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248208
{
public static readonly long[] Value={ 3L,11L,47L,83L,1063L,1637L,1699L,7529L,7673L,23059L,28097L,29573L,34157L,34961L,36587L,40897L,43609L,44711L,101839L,102763L,103423L,104087L,104393L,106363L,117437L,117499L,124471L,125407L,126011L,129419L,134753L,135007L,137393L,139487L,143879L,143971L,145037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248208Inst : IEnumerable<long>
{
public static readonly long[] Value=A248208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248208.Bytes);
public long this[int i]=>Value[i];

public static A248208Inst Instance=new A248208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248209
{
public static readonly long[] Value={ 54L,243L,297L,432L,486L,621L,675L,810L,864L,1018L,1143L,1197L,1225L,1332L,1386L,1410L,1443L,1521L,1522L,1525L,1571L,1575L,1577L,1710L,1764L,1775L,1810L,1908L,1918L,1953L,1997L,2043L,2097L,2125L,2232L,2233L,2286L,2321L,2332L,2333L,2421L,2475L,2521L,2610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248209Inst : IEnumerable<long>
{
public static readonly long[] Value=A248209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248209.Bytes);
public long this[int i]=>Value[i];

public static A248209Inst Instance=new A248209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248210
{
public static readonly long[] Value={ 293L,362L,436L,545L,554L,631L,653L,749L,763L,891L,958L,965L,1293L,1362L,1436L,1545L,1554L,1631L,1653L,1749L,1763L,1891L,1958L,1965L,2193L,2331L,2491L,2536L,2556L,2565L,2693L,2917L,2954L,2963L,3162L,3231L,3325L,3382L,3529L,3534L,3635L,3651L,4291L,4515L,4533L,4551L,4634L,4935L,4952L,4971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248210Inst : IEnumerable<long>
{
public static readonly long[] Value=A248210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248210.Bytes);
public long this[int i]=>Value[i];

public static A248210Inst Instance=new A248210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248211
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,1L,-1L,1L,0L,-1L,0L,1L,-1L,1L,0L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,2L,-2L,0L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,2L,-2L,1L,0L,0L,-1L,1L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,0L,-1L,2L,-2L,1L,0L,-1L,1L,1L,-2L,1L,0L,1L,-2L,1L,-1L,1L,0L,0L,0L,1L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248211Inst : IEnumerable<long>
{
public static readonly long[] Value=A248211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248211.Bytes);
public long this[int i]=>Value[i];

public static A248211Inst Instance=new A248211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248212
{
public static readonly long[] Value={ 0L,2L,4L,1L,3L,7L,10L,12L,11L,8L,5L,7L,16L,15L,14L,18L,16L,8L,15L,14L,19L,22L,2L,4L,6L,25L,8L,17L,28L,22L,19L,5L,7L,27L,11L,23L,31L,29L,4L,25L,28L,8L,10L,19L,24L,14L,35L,33L,1L,23L,9L,31L,35L,20L,34L,6L,40L,36L,8L,35L,41L,21L,42L,1L,41L,43L,36L,44L,20L,11L,27L,44L,38L,42L,46L,29L,17L,4L,40L,10L,12L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248212Inst : IEnumerable<long>
{
public static readonly long[] Value=A248212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248212.Bytes);
public long this[int i]=>Value[i];

public static A248212Inst Instance=new A248212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248213
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,1L,1L,2L,3L,4L,4L,1L,2L,3L,1L,3L,5L,4L,5L,4L,3L,7L,7L,7L,2L,7L,6L,1L,5L,6L,8L,8L,4L,8L,6L,2L,4L,9L,6L,5L,9L,9L,8L,7L,9L,2L,4L,10L,8L,10L,6L,4L,9L,5L,11L,1L,5L,11L,6L,2L,10L,1L,12L,4L,2L,7L,1L,11L,12L,10L,3L,7L,5L,1L,10L,12L,13L,7L,13L,13L,11L,10L,13L,4L,5L,11L,13L,14L,14L,4L,3L,6L,12L,11L,7L,12L,14L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248213Inst : IEnumerable<long>
{
public static readonly long[] Value=A248213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248213.Bytes);
public long this[int i]=>Value[i];

public static A248213Inst Instance=new A248213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248214
{
public static readonly long[] Value={ 3L,7L,2L,110L,3L,7L,3L,40L,2L,2L,3L,110L,3L,7L,2L,392L,3L,7L,3L,110L,2L,7L,3L,40L,3L,5L,2L,110L,3L,2L,3L,894L,2L,4L,3L,110L,3L,7L,2L,40L,3L,7L,3L,110L,2L,7L,3L,107L,3L,2L,2L,110L,3L,7L,2L,40L,2L,7L,3L,110L,3L,7L,2L,315L,3L,7L,3L,2L,2L,2L,3L,40L,3L,6L,2L,110L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248214Inst : IEnumerable<long>
{
public static readonly long[] Value=A248214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248214.Bytes);
public long this[int i]=>Value[i];

public static A248214Inst Instance=new A248214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248215
{
public static readonly long[] Value={ 13L,17L,29L,1L,9L,49L,9L,1L,17L,25L,25L,49L,9L,17L,1L,25L,9L,25L,17L,1L,49L,29L,17L,29L,49L,1L,25L,29L,17L,29L,49L,25L,49L,1L,17L,9L,25L,9L,29L,1L,17L,25L,9L,49L,17L,1L,29L,49L,1L,9L,29L,25L,29L,49L,25L,49L,1L,9L,25L,29L,17L,25L,9L,1L,17L,29L,9L,25L,49L,17L,1L,25L,1L,9L,49L,9L,29L,29L,1L,9L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248215Inst : IEnumerable<long>
{
public static readonly long[] Value=A248215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248215.Bytes);
public long this[int i]=>Value[i];

public static A248215Inst Instance=new A248215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248216
{
public static readonly long[] Value={ 0L,4L,32L,208L,1280L,7744L,46592L,279808L,1679360L,10077184L,60465152L,362795008L,2176778240L,13060685824L,78364147712L,470184951808L,2821109841920L,16926659313664L,101559956406272L,609359739486208L,3656158439014400L,21936950638280704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248216Inst : IEnumerable<long>
{
public static readonly long[] Value=A248216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248216.Bytes);
public long this[int i]=>Value[i];

public static A248216Inst Instance=new A248216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248217
{
public static readonly long[] Value={ 0L,6L,60L,504L,4080L,32736L,262080L,2097024L,16776960L,134217216L,1073740800L,8589932544L,68719472640L,549755805696L,4398046494720L,35184372056064L,281474976645120L,2251799813554176L,18014398509219840L,144115188075331584L,1152921504605798400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248217Inst : IEnumerable<long>
{
public static readonly long[] Value=A248217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248217.Bytes);
public long this[int i]=>Value[i];

public static A248217Inst Instance=new A248217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248218
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,1L,2L,3L,6L,2L,2L,4L,2L,3L,2L,6L,6L,1L,6L,1L,2L,2L,2L,3L,4L,3L,2L,2L,6L,1L,2L,2L,6L,3L,6L,1L,2L,4L,6L,7L,2L,1L,2L,3L,2L,4L,2L,6L,6L,6L,4L,2L,6L,6L,2L,1L,2L,3L,6L,10L,2L,3L,2L,12L,2L,2L,6L,2L,6L,11L,6L,6L,2L,3L,2L,2L,4L,4L,6L,9L,14L,5L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248218Inst : IEnumerable<long>
{
public static readonly long[] Value=A248218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248218.Bytes);
public long this[int i]=>Value[i];

public static A248218Inst Instance=new A248218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248219
{
public static readonly long[] Value={ 1L,3L,7L,19L,21L,31L,37L,43L,57L,93L,111L,129L,133L,157L,217L,259L,301L,307L,313L,399L,463L,471L,499L,589L,613L,651L,703L,777L,817L,903L,921L,939L,967L,1099L,1147L,1333L,1389L,1497L,1591L,1767L,1839L,2109L,2149L,2191L,2451L,2683L,2901L,2983L,3241L,3297L,3441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248219Inst : IEnumerable<long>
{
public static readonly long[] Value=A248219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248219.Bytes);
public long this[int i]=>Value[i];

public static A248219Inst Instance=new A248219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248220
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,16L,25L,31L,39L,48L,49L,52L,57L,64L,73L,74L,79L,84L,86L,97L,100L,112L,121L,127L,129L,134L,169L,192L,194L,196L,199L,217L,241L,244L,254L,256L,266L,273L,289L,292L,302L,304L,326L,336L,337L,350L,361L,372L,399L,400L,409L,448L,457L,484L,487L,489L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248220Inst : IEnumerable<long>
{
public static readonly long[] Value=A248220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248220.Bytes);
public long this[int i]=>Value[i];

public static A248220Inst Instance=new A248220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248221
{
public static readonly long[] Value={ 1L,3L,6L,10L,13L,18L,21L,24L,25L,31L,36L,39L,40L,43L,45L,46L,49L,55L,60L,64L,66L,73L,78L,85L,91L,94L,96L,109L,115L,123L,124L,126L,129L,130L,133L,138L,139L,141L,144L,145L,151L,154L,159L,165L,168L,171L,174L,178L,181L,189L,193L,195L,196L,201L,211L,223L,225L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248221Inst : IEnumerable<long>
{
public static readonly long[] Value=A248221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248221.Bytes);
public long this[int i]=>Value[i];

public static A248221Inst Instance=new A248221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248222
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,2L,3L,4L,3L,3L,4L,5L,5L,3L,5L,7L,4L,3L,5L,7L,6L,4L,5L,8L,3L,5L,3L,7L,4L,5L,5L,8L,6L,4L,5L,9L,5L,5L,6L,11L,6L,6L,6L,8L,6L,5L,5L,12L,4L,3L,6L,8L,7L,3L,8L,9L,7L,4L,6L,11L,7L,5L,9L,8L,9L,6L,7L,13L,7L,5L,7L,12L,5L,5L,7L,8L,11L,6L,7L,15L,3L,6L,8L,12L,13L,6L,11L,16L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248222Inst : IEnumerable<long>
{
public static readonly long[] Value=A248222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248222.Bytes);
public long this[int i]=>Value[i];

public static A248222Inst Instance=new A248222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248223
{
public static readonly long[] Value={ 2L,7L,5L,6L,1L,1L,3L,4L,8L,2L,6L,9L,3L,3L,1L,7L,3L,4L,8L,9L,3L,1L,2L,2L,8L,0L,0L,5L,9L,6L,4L,5L,6L,8L,4L,6L,2L,4L,2L,0L,0L,2L,5L,6L,5L,0L,3L,0L,0L,8L,9L,8L,4L,6L,1L,7L,0L,1L,7L,3L,6L,7L,2L,0L,3L,3L,8L,3L,4L,6L,2L,1L,4L,8L,8L,5L,8L,4L,0L,5L,3L,6L,6L,7L,2L,5L,9L,5L,6L,4L,7L,3L,4L,2L,4L,7L,8L,7L,7L,2L,7L,1L,3L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248223Inst : IEnumerable<long>
{
public static readonly long[] Value=A248223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248223.Bytes);
public long this[int i]=>Value[i];

public static A248223Inst Instance=new A248223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248224
{
public static readonly long[] Value={ 1L,7L,8L,8L,6L,3L,3L,7L,1L,9L,5L,7L,3L,5L,6L,8L,6L,7L,3L,9L,5L,0L,2L,3L,6L,1L,2L,3L,2L,2L,9L,6L,0L,6L,9L,6L,0L,9L,5L,6L,8L,9L,0L,3L,5L,1L,8L,2L,4L,0L,3L,7L,2L,4L,5L,5L,4L,4L,0L,3L,2L,8L,1L,2L,5L,9L,1L,0L,0L,1L,5L,8L,3L,4L,0L,9L,6L,8L,8L,9L,1L,2L,9L,7L,1L,5L,0L,5L,9L,0L,8L,6L,3L,3L,3L,5L,3L,9L,3L,6L,6L,5L,8L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248224Inst : IEnumerable<long>
{
public static readonly long[] Value=A248224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248224.Bytes);
public long this[int i]=>Value[i];

public static A248224Inst Instance=new A248224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248225
{
public static readonly long[] Value={ 0L,3L,27L,189L,1215L,7533L,45927L,277749L,1673055L,10058013L,60407127L,362619909L,2176250895L,13059099693L,78359381127L,470170635669L,2821066860735L,16926530304573L,101559569247927L,609358577749029L,3656154953278575L,21936940180024653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248225Inst : IEnumerable<long>
{
public static readonly long[] Value=A248225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248225.Bytes);
public long this[int i]=>Value[i];

public static A248225Inst Instance=new A248225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248226
{
public static readonly BigInteger[] Value={ 0L,7L,91L,973L,9919L,99757L,999271L,9997813L,99993439L,999980317L,9999940951L,99999822853L,999999468559L,9999998405677L,99999995217031L,999999985651093L,9999999956953279L,99999999870859837L,999999999612579511L,9999999998837738533UL,BigInteger.Parse("99999999996513215599") };
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
public class A248226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248226Inst Instance=new A248226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248227
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,12L,12L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,37L,38L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L,46L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248227Inst : IEnumerable<long>
{
public static readonly long[] Value=A248227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248227.Bytes);
public long this[int i]=>Value[i];

public static A248227Inst Instance=new A248227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248228
{
public static readonly long[] Value={ 1L,4L,8L,11L,14L,17L,21L,24L,27L,30L,34L,37L,40L,44L,47L,50L,53L,57L,60L,63L,66L,70L,73L,76L,79L,83L,86L,89L,92L,96L,99L,102L,105L,109L,112L,115L,119L,122L,125L,128L,132L,135L,138L,141L,145L,148L,151L,154L,158L,161L,164L,167L,171L,174L,177L,180L,184L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248228Inst : IEnumerable<long>
{
public static readonly long[] Value=A248228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248228.Bytes);
public long this[int i]=>Value[i];

public static A248228Inst Instance=new A248228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248229
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,10L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,33L,35L,36L,38L,39L,41L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,82L,84L,85L,87L,88L,90L,91L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248229Inst : IEnumerable<long>
{
public static readonly long[] Value=A248229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248229.Bytes);
public long this[int i]=>Value[i];

public static A248229Inst Instance=new A248229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248230
{
public static readonly long[] Value={ 12L,50L,133L,280L,507L,833L,1276L,1855L,2586L,3488L,4579L,5878L,7401L,9167L,11194L,13501L,16104L,19022L,22273L,25876L,29847L,34205L,38968L,44155L,49782L,55868L,62431L,69490L,77061L,85163L,93814L,103033L,112836L,123242L,134269L,145936L,158259L,171257L,184948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248230Inst : IEnumerable<long>
{
public static readonly long[] Value=A248230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248230.Bytes);
public long this[int i]=>Value[i];

public static A248230Inst Instance=new A248230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248231
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,5L,6L,6L,7L,8L,8L,9L,10L,11L,11L,12L,13L,13L,14L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,22L,23L,23L,24L,25L,25L,26L,27L,28L,28L,29L,30L,30L,31L,32L,33L,33L,34L,35L,35L,36L,37L,37L,38L,39L,40L,40L,41L,42L,42L,43L,44L,45L,45L,46L,47L,47L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248231Inst : IEnumerable<long>
{
public static readonly long[] Value=A248231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248231.Bytes);
public long this[int i]=>Value[i];

public static A248231Inst Instance=new A248231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248232
{
public static readonly long[] Value={ 1L,4L,8L,11L,15L,18L,22L,25L,28L,32L,35L,39L,42L,46L,49L,52L,56L,59L,63L,66L,69L,73L,76L,80L,83L,87L,90L,93L,97L,100L,104L,107L,110L,114L,117L,121L,124L,128L,131L,134L,138L,141L,145L,148L,151L,155L,158L,162L,165L,168L,172L,175L,179L,182L,186L,189L,192L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248232Inst : IEnumerable<long>
{
public static readonly long[] Value=A248232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248232.Bytes);
public long this[int i]=>Value[i];

public static A248232Inst Instance=new A248232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248233
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,10L,12L,13L,14L,16L,17L,19L,20L,21L,23L,24L,26L,27L,29L,30L,31L,33L,34L,36L,37L,38L,40L,41L,43L,44L,45L,47L,48L,50L,51L,53L,54L,55L,57L,58L,60L,61L,62L,64L,65L,67L,68L,70L,71L,72L,74L,75L,77L,78L,79L,81L,82L,84L,85L,86L,88L,89L,91L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248233Inst : IEnumerable<long>
{
public static readonly long[] Value=A248233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248233.Bytes);
public long this[int i]=>Value[i];

public static A248233Inst Instance=new A248233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248234
{
public static readonly long[] Value={ 27L,176L,639L,1706L,3759L,7279L,12842L,21119L,32879L,48986L,70399L,98175L,133466L,177519L,231679L,297386L,376175L,469679L,579626L,707839L,856239L,1026842L,1221759L,1443199L,1693466L,1974959L,2290175L,2641706L,3032239L,3464559L,3941546L,4466175L,5041519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248234Inst : IEnumerable<long>
{
public static readonly long[] Value=A248234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248234.Bytes);
public long this[int i]=>Value[i];

public static A248234Inst Instance=new A248234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248235
{
public static readonly BigInteger[] Value={ 2L,5L,28L,2828L,11765225L,244616741135815L,BigInteger.Parse("200345939091917238204751820525"),BigInteger.Parse("58201747163932603551486315260692070868016224421408235882974"),BigInteger.Parse("3950825087286888657146721201016118914863842749907092675300186489072730656660851348699680127901879302396406080621599015") };
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
public class A248235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248235Inst Instance=new A248235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248236
{
public static readonly BigInteger[] Value={ 2L,3L,9L,199L,49572L,30799364495L,BigInteger.Parse("1408429952507887000310"),BigInteger.Parse("3677260735023142918878205127156519291320765"),BigInteger.Parse("102293202370266874495262346614859561910266026424997387777849999466054887759064682698213") };
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
public class A248236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248236Inst Instance=new A248236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248237
{
public static readonly BigInteger[] Value={ 2L,2L,7L,346L,250326L,159992246122L,BigInteger.Parse("43126926376468440463866"),BigInteger.Parse("2067900185855597116733968004943580535040713497"),BigInteger.Parse("14833490144163739987168640921306687956266487136609932761918465200939453258507455567518894133") };
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
public class A248237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248237Inst Instance=new A248237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248238
{
public static readonly BigInteger[] Value={ 2L,2L,4L,13L,665L,3467111L,21396320062803L,BigInteger.Parse("658294037732639489281287503"),BigInteger.Parse("22388829144690900907571301740725846339553919136567283158"),BigInteger.Parse("522702581366233755060474792093646176756253098085471164612763539572950704431022333880928617340303584572474648760") };
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
public class A248238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248238Inst Instance=new A248238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248239
{
public static readonly BigInteger[] Value={ 3L,7L,52L,5271L,32510519L,1551821465402536L,BigInteger.Parse("2553352811042166137014681056617"),BigInteger.Parse("6785214292790116540717856342564735260380655042140053309985580"),BigInteger.Parse("57499324177051573068556985649019772314982410954417460069917198506894068347777607349711324456505504280305966462257432295349") };
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
public class A248239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248239Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248239.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248239Inst Instance=new A248239Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248240
{
public static readonly BigInteger[] Value={ 3L,4L,16L,243L,104559L,25176928409L,BigInteger.Parse("26586186736052347315834"),BigInteger.Parse("1862816215759124563815793524962166009780011752"),BigInteger.Parse("5214712907768239185916350444296489272388117885310572145230445264540008760076034857528421553") };
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
public class A248240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248240Inst Instance=new A248240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248241
{
public static readonly BigInteger[] Value={ 3L,3L,8L,174L,47270L,3322246062L,13585339584457844199UL,BigInteger.Parse("266643312158266377656241697792775202384"),BigInteger.Parse("221110316712057155914682414678073188192934894445719392090279403577596961625414") };
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
public class A248241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248241Inst Instance=new A248241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248242
{
public static readonly BigInteger[] Value={ 3L,2L,10L,181L,37860L,2063394882L,BigInteger.Parse("20133724366323386460"),BigInteger.Parse("895769948382354175062611801976979893814"),BigInteger.Parse("1095684829796116398764171865109547325653507924058299202087102696023776712107256") };
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
public class A248242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248242Inst Instance=new A248242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248243
{
public static readonly BigInteger[] Value={ 3L,2L,5L,25L,604L,568947L,524109421430L,BigInteger.Parse("456412587974094208278324"),BigInteger.Parse("217923503007735559214372603301923745039374715408"),BigInteger.Parse("53829867761684622028477476025136774072620218179339699337234480313626745601639126196448075512614") };
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
public class A248243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248243Inst Instance=new A248243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248244
{
public static readonly BigInteger[] Value={ 3L,2L,3L,26L,842L,1210718L,3125731485713L,BigInteger.Parse("19754948045006045983659938"),BigInteger.Parse("1065761639370207788402744631308304462734917602085737"),BigInteger.Parse("324026619188969581072902747191745217929877633476958459802312813323913819842709323919885352524528244937458") };
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
public class A248244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248244Inst Instance=new A248244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248245
{
public static readonly BigInteger[] Value={ 4L,9L,84L,11142L,474347339L,1448582974451426406L,BigInteger.Parse("2526762018809024624337804813995389534"),BigInteger.Parse("28249016389028465904997590221278194109894254535234000317524709009386354668") };
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
public class A248245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248245Inst Instance=new A248245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248246
{
public static readonly BigInteger[] Value={ 4L,5L,24L,1027L,3219387L,102715635003972L,BigInteger.Parse("28595657331015533671660837004"),BigInteger.Parse("1215572475769570408109978391934299568566509985905302163092"),BigInteger.Parse("2006120697781748129559395265597556700767017998650179835542888817906954377068504244660639847221485156172682330027607") };
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
public class A248246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248246Inst Instance=new A248246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248247
{
public static readonly BigInteger[] Value={ 4L,3L,40L,1769L,3133987L,24555734311137L,BigInteger.Parse("5553769558933640154963528048"),BigInteger.Parse("58425567381851662534231519139184106852906758833242204348"),BigInteger.Parse("8289351943967938706857419188398816898988729770105649746642711092034483624446711151502281270880844114102012375418") };
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
public class A248247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248247Inst Instance=new A248247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248248
{
public static readonly BigInteger[] Value={ 4L,3L,8L,73L,9617L,111131795L,26084503201670555L,BigInteger.Parse("4157115685705509978962832510685264"),BigInteger.Parse("147322611763368949503218439363472434087529649552239912252006589221170"),BigInteger.Parse("71615688159358613181735412731094718668653530665367791449989367208307390123881747858538896669229709245658779872053034609094278277577821587") };
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
public class A248248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248248Inst Instance=new A248248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248249
{
public static readonly BigInteger[] Value={ 4L,2L,13L,177L,344766L,1649432522483L,BigInteger.Parse("3009384963228815398356405"),BigInteger.Parse("9085726642856091334926418336934724393317743509110"),BigInteger.Parse("200625769243543756748406312378876010708020812606355642597458369416042779347013395136132184521789202") };
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
public class A248249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248249Inst Instance=new A248249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248250
{
public static readonly BigInteger[] Value={ 4L,2L,6L,43L,2028L,5477762L,40063230724280L,BigInteger.Parse("10039617492048087897098971783"),BigInteger.Parse("598943577818423089223821862011302605314284839297545338532"),BigInteger.Parse("451273778419286656581820003198742640276389207705020449590295850757882195737121214614786626350432663721793231915121") };
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
public class A248250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248250Inst Instance=new A248250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248251
{
public static readonly BigInteger[] Value={ 4L,2L,4L,22L,2653L,21700059L,708858809575725L,BigInteger.Parse("1165753299339083780718554998198"),BigInteger.Parse("2548635100713650540210812530804809217002270820405582029350843"),BigInteger.Parse("9424721747010820452946739585309019492765231528601856929750632998033892638026047178801699999141027371964867528932823084053") };
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
public class A248251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248251Inst Instance=new A248251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248252
{
public static readonly BigInteger[] Value={ 4L,2L,3L,16L,318L,667493L,520599832812L,BigInteger.Parse("1406502882894868771562029"),BigInteger.Parse("5482100301108869539661068478608291549480253128390"),BigInteger.Parse("195012261486920753888173091467257385308263858947121366558714224718185929485569758493733677353323155") };
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
public class A248252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248252Inst Instance=new A248252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248253
{
public static readonly BigInteger[] Value={ 5L,11L,124L,21784L,767400293L,1762025132544871871L,BigInteger.Parse("3756028786746097256770667892973677974"),BigInteger.Parse("42736560346010944990137576929510502074095427615068285034007804816583306199") };
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
public class A248253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248253Inst Instance=new A248253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248254
{
public static readonly BigInteger[] Value={ 5L,6L,34L,13516L,202119099L,64783216365098195L,BigInteger.Parse("22100984125756663557825370106132649"),BigInteger.Parse("666714143657173655990633057343413567220367208291412102910376204532308") };
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
public class A248254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248254Inst Instance=new A248254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248255
{
public static readonly BigInteger[] Value={ 5L,4L,25L,666L,892358L,830113252100L,BigInteger.Parse("6890868531517036908804204"),BigInteger.Parse("765564099160305273559925342798919694764879717405690"),BigInteger.Parse("681027718799553552099401892363533829797246440808729714034620705787624761700369516608168143683921127348") };
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
public class A248255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248255Inst Instance=new A248255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248256
{
public static readonly BigInteger[] Value={ 5L,3L,20L,547L,301184L,147558270953L,BigInteger.Parse("86497522148984105061516"),BigInteger.Parse("8551929116782420428265616715584087619312418621"),BigInteger.Parse("99749931990938468116836650873165146389082138700427586581720209715910550531363814159816345424") };
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
public class A248256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248256Inst Instance=new A248256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248257
{
public static readonly BigInteger[] Value={ 5L,3L,7L,967L,1028069L,2298068118217L,BigInteger.Parse("5494201416226460930421913"),BigInteger.Parse("8921656602209859921713003519980673897631224869075674"),BigInteger.Parse("838074105556913621236663949120105672159883231833809533473972526431411898035963444027095791284399338983624") };
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
public class A248257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248257Inst Instance=new A248257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248258
{
public static readonly BigInteger[] Value={ 5L,2L,15L,911L,756131657L,1046059081493109619L,BigInteger.Parse("1823555845900657755132295578770597587"),BigInteger.Parse("5295210870312939233563525303202129576974975306672437715711158044936692625") };
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
public class A248258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248258Inst Instance=new A248258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248259
{
public static readonly BigInteger[] Value={ 5L,2L,7L,72L,9241L,229909903L,85086814482844985L,BigInteger.Parse("23179346469573782778010843389086345"),BigInteger.Parse("543347867420258195663107222041076121949552033670222863973158866609327"),BigInteger.Parse("741522735509298769232902024568403103695824837660291384400704443062457446366917782889948614422252425565925024142554380383285632350884136295") };
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
public class A248259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248259Inst Instance=new A248259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248260
{
public static readonly BigInteger[] Value={ 5L,2L,5L,23L,923L,1039448L,1349594009502L,BigInteger.Parse("1841990944227649463764190"),BigInteger.Parse("5531888379621714420992617902281239594988386275117"),BigInteger.Parse("172423874327527416450254906621893256497583527925050132860644029730203113536215473159687066655835408") };
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
public class A248260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248260.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248260Inst Instance=new A248260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248261
{
public static readonly BigInteger[] Value={ 5L,2L,4L,13L,249L,78409L,36737419013L,BigInteger.Parse("3360517821921008389676"),BigInteger.Parse("12410117686109445240372967020019944131780632"),BigInteger.Parse("3346975977981026206584708326983128003661219924365061759193139960235987881485856695085453") };
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
public class A248261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248261Inst Instance=new A248261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248262
{
public static readonly BigInteger[] Value={ 5L,2L,3L,13L,172L,106165L,18285649425L,BigInteger.Parse("2186743227575352844102"),BigInteger.Parse("34485253453894276212351220254887863775700566"),BigInteger.Parse("1196120890861075329034546890130985440938005448458845105688952404014155813652248242764257") };
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
public class A248262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248262Inst Instance=new A248262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248263
{
public static readonly BigInteger[] Value={ 6L,13L,172L,39216L,11016972197L,BigInteger.Parse("134283233503741443791"),BigInteger.Parse("18872603108304707287590736836379382332539"),BigInteger.Parse("773806129529571836706640292961775806691343199188996534429569375589794450652266246") };
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
public class A248263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248263Inst Instance=new A248263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248264
{
public static readonly BigInteger[] Value={ 6L,7L,47L,3569L,13543237L,813461964457561L,BigInteger.Parse("7421316108781190769825230152615"),BigInteger.Parse("711253293828537228004750977021512448161146012227144474046636992"),BigInteger.Parse("2200029703970808428058199608953702518884689809814432014002394662129432102727790523039076189301028040002865113400234535183784056") };
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
public class A248264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248264Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248264.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248264.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248264Inst Instance=new A248264Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248265
{
public static readonly BigInteger[] Value={ 6L,5L,23L,659L,437284L,377751319913L,BigInteger.Parse("340271588652415528090388"),BigInteger.Parse("1890912187940287800367373789659912522501201614249"),BigInteger.Parse("7449562319978893326251035904298267810521574218546460385778180298134511070414909881921779582771096") };
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
public class A248265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248265Inst Instance=new A248265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248266
{
public static readonly BigInteger[] Value={ 6L,4L,14L,320L,571786L,469930223859L,BigInteger.Parse("260342286471149560589985"),BigInteger.Parse("110737149164265654381526929767261159120340941327"),BigInteger.Parse("13640751783742037895965317463353502238298025074840803034014381823166601709380037834476485770683") };
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
public class A248266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248266Inst Instance=new A248266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248267
{
public static readonly BigInteger[] Value={ 6L,3L,15L,321L,111450L,533909816159L,BigInteger.Parse("325998701518914099105001"),BigInteger.Parse("1006914879088411198399682064005635831534437484321"),BigInteger.Parse("1497711655729721286088828059704410216184274677681054392262396421340070136379357931802690267613686") };
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
public class A248267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248267Inst Instance=new A248267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248268
{
public static readonly BigInteger[] Value={ 6L,3L,7L,220L,209746L,1800026104632L,BigInteger.Parse("11289682294671072755879655"),BigInteger.Parse("1247832270676194041105480584245717817404868332358363"),BigInteger.Parse("5623554373314472317858205865619051220489843727752125404940182021329874216730979924009375686764591034334") };
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
public class A248268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248268Inst Instance=new A248268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248269
{
public static readonly BigInteger[] Value={ 6L,2L,18L,532L,305858L,137859230710L,BigInteger.Parse("22012211318177566410441"),BigInteger.Parse("1147928569154887244380386940705198857524244457"),BigInteger.Parse("54505440157936785019731226309482186897275025107764309863984976644953861019275801793173245974") };
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
public class A248269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248269Inst Instance=new A248269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248270
{
public static readonly BigInteger[] Value={ 6L,2L,8L,122L,18919L,402739144L,764123173937021975L,BigInteger.Parse("2148666191962903360885805290461855276"),BigInteger.Parse("8622580654686644746427953833014483269744901669599325824509666827330296874") };
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
public class A248270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248270Inst Instance=new A248270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248271
{
public static readonly BigInteger[] Value={ 6L,2L,5L,122L,138674L,32476589259L,BigInteger.Parse("7827697016386517458238"),BigInteger.Parse("674742854143668103289252692160450020023615629"),BigInteger.Parse("480580099090725670530151893237450499682750267119621001128141465878491826900413350973083878") };
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
public class A248271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248271Inst Instance=new A248271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248272
{
public static readonly BigInteger[] Value={ 6L,2L,4L,31L,13905L,492036837L,305826422756315436L,BigInteger.Parse("925021938815488805990118508463313646"),BigInteger.Parse("9816702673371796111477307067848281658737547920701725975736611619650989298") };
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
public class A248272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248272Inst Instance=new A248272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248273
{
public static readonly BigInteger[] Value={ 6L,2L,3L,45L,10097L,180933939L,70214804893433857L,BigInteger.Parse("24596197522004292913199742834240369"),BigInteger.Parse("851917396155337556711167562167009352482986581505723891411145951010937"),BigInteger.Parse("1830843559366860042528367793031819716270540620095563249767306742965459078226069734667092696644523226923832775331940549734586475295256730688") };
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
public class A248273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248273Inst Instance=new A248273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248274
{
public static readonly BigInteger[] Value={ 6L,2L,3L,11L,253L,121406L,26366884520L,BigInteger.Parse("849309519459745289215"),BigInteger.Parse("1275274072254463235178765644812100983170793"),BigInteger.Parse("6840927687383150447046638299623716679409134458251745775753167712124043749551513939746") };
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
public class A248274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248274Inst Instance=new A248274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248275
{
public static readonly BigInteger[] Value={ 7L,15L,228L,65875L,47908261511L,BigInteger.Parse("2667718882316939409472"),BigInteger.Parse("10322125191786944152031025720794295875480056"),BigInteger.Parse("2674110852900041212107591350675026110499276180787546409661407265673151668416641308455602") };
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
public class A248275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248275Inst Instance=new A248275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248276
{
public static readonly BigInteger[] Value={ 7L,8L,61L,28583L,11215712908L,BigInteger.Parse("163912730694765446902"),BigInteger.Parse("323312653298355913241854107936424272297052"),BigInteger.Parse("282221573696620922018917798450701835109135899750274145244297035015729916105092332416") };
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
public class A248276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248276Inst Instance=new A248276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248277
{
public static readonly BigInteger[] Value={ 7L,5L,91L,8808L,147334267L,630308457230044767L,BigInteger.Parse("705412662885103424818861300802350580"),BigInteger.Parse("5393679030808484908733796582654864706316301359628528840178094089020230098") };
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
public class A248277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248277Inst Instance=new A248277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248278
{
public static readonly BigInteger[] Value={ 7L,4L,34L,1433L,3473810L,16229351336487L,BigInteger.Parse("949514635841230182654078450"),BigInteger.Parse("2889844410885034994651072554166092838631734010754362047"),BigInteger.Parse("90303610423494587890114446343335205731154007285533876023746429382538260256932049359769872513411427600496627202") };
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
public class A248278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248278Inst Instance=new A248278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248279
{
public static readonly BigInteger[] Value={ 7L,3L,67L,4751L,25076431L,1253373011645810L,BigInteger.Parse("9187269148593176940086772749458"),BigInteger.Parse("498651977464932900685397060435928260390239175775532045711576034"),BigInteger.Parse("321776209073611476881274134051635561805771857820185011672099181310492331070886792488196910194328794077954530415887963244506932") };
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
public class A248279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248279Inst Instance=new A248279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248280
{
public static readonly BigInteger[] Value={ 7L,3L,13L,169L,40134L,1830451404L,6293054590385574716L,BigInteger.Parse("99455005060617253985959291400980656073"),BigInteger.Parse("14444603640289593121113624113291244368730444113988502168325108818988403980391") };
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
public class A248280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248280Inst Instance=new A248280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248281
{
public static readonly BigInteger[] Value={ 7L,3L,7L,141L,31154L,5919757544L,BigInteger.Parse("160210422116327440975"),BigInteger.Parse("51936028072305364257094751268091425897982"),BigInteger.Parse("4468374619865723526161303689130955516769923438522458566697540434310939905017570043") };
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
public class A248281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248281Inst Instance=new A248281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}