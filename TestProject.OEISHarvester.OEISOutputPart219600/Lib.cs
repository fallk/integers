using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A257982
{
public static readonly long[] Value={ 1L,2L,-1L,3L,5L,-6L,4L,-2L,6L,-5L,7L,-3L,11L,-13L,9L,18L,-23L,13L,-11L,15L,-14L,16L,-15L,17L,-10L,-4L,20L,-21L,19L,-17L,21L,-19L,23L,-18L,28L,-31L,25L,-9L,-12L,29L,-27L,31L,-35L,27L,-7L,-8L,39L,-45L,33L,-29L,37L,-39L,35L,-26L,44L,-43L,45L,-47L,43L,-38L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257982Inst : IEnumerable<long>
{
public static readonly long[] Value=A257982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257982.Bytes);
public long this[int i]=>Value[i];

public static A257982Inst Instance=new A257982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257983
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,4L,9L,8L,16L,6L,12L,24L,10L,20L,11L,22L,14L,28L,13L,26L,15L,30L,17L,34L,18L,36L,19L,38L,31L,25L,21L,42L,23L,46L,41L,29L,58L,27L,54L,32L,64L,35L,70L,33L,66L,39L,78L,37L,74L,40L,80L,44L,88L,43L,86L,47L,94L,45L,90L,48L,96L,49L,98L,50L,100L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257983Inst : IEnumerable<long>
{
public static readonly long[] Value=A257983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257983.Bytes);
public long this[int i]=>Value[i];

public static A257983Inst Instance=new A257983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257984
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,18L,21L,24L,27L,30L,33L,37L,40L,43L,46L,49L,52L,55L,59L,62L,65L,68L,71L,74L,77L,81L,84L,87L,90L,93L,96L,99L,103L,106L,109L,112L,115L,118L,121L,125L,128L,131L,134L,137L,140L,143L,147L,150L,153L,156L,159L,162L,165L,169L,172L,175L,178L,181L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257984Inst : IEnumerable<long>
{
public static readonly long[] Value=A257984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257984.Bytes);
public long this[int i]=>Value[i];

public static A257984Inst Instance=new A257984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257985
{
public static readonly long[] Value={ 2L,3L,5L,4L,7L,13L,6L,11L,8L,15L,9L,17L,12L,10L,19L,37L,14L,27L,16L,31L,18L,35L,20L,39L,21L,41L,22L,43L,23L,45L,24L,47L,25L,49L,32L,28L,55L,26L,51L,42L,30L,59L,29L,57L,33L,65L,34L,67L,40L,44L,36L,71L,38L,75L,50L,99L,46L,91L,48L,95L,53L,105L,54L,107L,52L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257985Inst : IEnumerable<long>
{
public static readonly long[] Value=A257985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257985.Bytes);
public long this[int i]=>Value[i];

public static A257985Inst Instance=new A257985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257986
{
public static readonly long[] Value={ 2L,4L,3L,6L,11L,5L,9L,7L,13L,8L,15L,12L,23L,10L,19L,37L,14L,27L,16L,31L,17L,33L,18L,35L,25L,21L,41L,20L,39L,22L,43L,24L,47L,29L,57L,26L,51L,42L,30L,59L,32L,63L,28L,55L,48L,40L,79L,34L,67L,38L,75L,36L,71L,45L,89L,46L,91L,44L,87L,49L,97L,53L,105L,50L,99L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257986Inst : IEnumerable<long>
{
public static readonly long[] Value=A257986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257986.Bytes);
public long this[int i]=>Value[i];

public static A257986Inst Instance=new A257986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257987
{
public static readonly long[] Value={ 2L,3L,6L,4L,8L,5L,10L,9L,17L,7L,13L,25L,11L,21L,12L,23L,15L,29L,14L,27L,16L,31L,18L,35L,19L,37L,20L,39L,32L,26L,22L,43L,24L,47L,42L,30L,59L,28L,55L,33L,65L,36L,71L,34L,67L,40L,79L,38L,75L,41L,81L,45L,89L,44L,87L,48L,95L,46L,91L,49L,97L,50L,99L,51L,101L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257987Inst : IEnumerable<long>
{
public static readonly long[] Value=A257987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257987.Bytes);
public long this[int i]=>Value[i];

public static A257987Inst Instance=new A257987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257988
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,0L,2L,1L,1L,0L,1L,1L,2L,0L,1L,2L,1L,1L,2L,1L,1L,0L,2L,1L,3L,1L,1L,2L,1L,0L,2L,1L,2L,0L,1L,1L,2L,0L,1L,2L,1L,1L,3L,1L,1L,0L,2L,2L,2L,1L,1L,3L,2L,1L,2L,1L,1L,1L,1L,1L,3L,0L,2L,2L,1L,1L,2L,2L,1L,0L,1L,1L,3L,1L,2L,2L,1L,0L,4L,1L,1L,1L,2L,1L,2L,1L,1L,3L,2L,1L,2L,1L,2L,0L,1L,2L,3L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257988Inst : IEnumerable<long>
{
public static readonly long[] Value=A257988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257988.Bytes);
public long this[int i]=>Value[i];

public static A257988Inst Instance=new A257988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257989
{
public static readonly long[] Value={ -1L,2L,-2L,3L,0L,4L,-3L,2L,0L,5L,-2L,6L,0L,3L,-4L,7L,1L,8L,-1L,4L,0L,9L,-3L,3L,0L,2L,-1L,10L,1L,11L,-5L,5L,0L,4L,-2L,12L,0L,6L,-3L,13L,1L,14L,-1L,3L,0L,15L,-4L,4L,1L,7L,-1L,16L,2L,5L,-2L,8L,0L,17L,-1L,18L,0L,4L,-6L,6L,1L,19L,-1L,9L,1L,20L,-3L,21L,0L,3L,-1L,5L,1L,22L,-4L,2L,0L,23L,-1L,7L,0L,10L,-2L,24L,2L,6L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257989Inst : IEnumerable<long>
{
public static readonly long[] Value=A257989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257989.Bytes);
public long this[int i]=>Value[i];

public static A257989Inst Instance=new A257989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257990
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257990Inst : IEnumerable<long>
{
public static readonly long[] Value=A257990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257990.Bytes);
public long this[int i]=>Value[i];

public static A257990Inst Instance=new A257990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257991
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,1L,0L,3L,0L,2L,1L,2L,0L,1L,1L,4L,1L,1L,0L,3L,0L,2L,1L,3L,2L,1L,0L,2L,0L,2L,1L,5L,1L,2L,1L,2L,0L,1L,0L,4L,1L,1L,0L,3L,1L,2L,1L,4L,0L,3L,1L,2L,0L,1L,2L,3L,0L,1L,1L,3L,0L,2L,0L,6L,1L,2L,1L,3L,1L,2L,0L,3L,1L,1L,2L,2L,1L,1L,0L,5L,0L,2L,1L,2L,2L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257991Inst : IEnumerable<long>
{
public static readonly long[] Value=A257991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257991.Bytes);
public long this[int i]=>Value[i];

public static A257991Inst Instance=new A257991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257992
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,2L,0L,0L,1L,1L,1L,1L,0L,0L,2L,1L,0L,2L,0L,0L,1L,0L,1L,3L,1L,1L,1L,0L,0L,1L,0L,1L,2L,1L,1L,2L,0L,0L,2L,1L,0L,2L,0L,0L,1L,2L,0L,1L,1L,1L,3L,0L,1L,2L,1L,0L,1L,1L,0L,3L,0L,1L,1L,0L,0L,1L,1L,1L,2L,0L,1L,1L,1L,1L,2L,1L,0L,4L,0L,0L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257992Inst : IEnumerable<long>
{
public static readonly long[] Value=A257992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257992.Bytes);
public long this[int i]=>Value[i];

public static A257992Inst Instance=new A257992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257993
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257993Inst : IEnumerable<long>
{
public static readonly long[] Value=A257993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257993.Bytes);
public long this[int i]=>Value[i];

public static A257993Inst Instance=new A257993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257994
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,0L,2L,1L,1L,1L,0L,0L,2L,0L,1L,2L,0L,1L,1L,1L,0L,1L,2L,0L,3L,0L,0L,2L,1L,0L,2L,1L,1L,2L,0L,0L,1L,1L,1L,1L,0L,1L,3L,0L,0L,1L,0L,2L,2L,0L,0L,3L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,1L,1L,1L,1L,0L,2L,0L,0L,3L,0L,1L,1L,0L,1L,4L,1L,1L,1L,2L,0L,1L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257994Inst : IEnumerable<long>
{
public static readonly long[] Value=A257994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257994.Bytes);
public long this[int i]=>Value[i];

public static A257994Inst Instance=new A257994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257995
{
public static readonly BigInteger[] Value={ 1L,2L,37L,866L,23285L,679606L,20931998L,669688835L,22040134327L,741386199872L,25376258521393L,880977739374392L,30946637156662975L,1097929752363923490L,BigInteger.Parse("39284677690031136567"),BigInteger.Parse("1415992852373003788459") };
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
public class A257995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257995Inst Instance=new A257995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257996
{
public static readonly long[] Value={ 120L,1456L,121024L,2198352216064L,576458003527499776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257996Inst : IEnumerable<long>
{
public static readonly long[] Value=A257996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257996.Bytes);
public long this[int i]=>Value[i];

public static A257996Inst Instance=new A257996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257997
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,15L,16L,18L,20L,24L,25L,27L,32L,36L,40L,45L,48L,50L,54L,64L,72L,75L,80L,81L,96L,100L,108L,125L,128L,135L,144L,160L,162L,192L,200L,216L,225L,243L,250L,256L,288L,320L,324L,375L,384L,400L,405L,432L,486L,500L,512L,576L,625L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257997Inst : IEnumerable<long>
{
public static readonly long[] Value=A257997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257997.Bytes);
public long this[int i]=>Value[i];

public static A257997Inst Instance=new A257997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257998
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,3L,4L,5L,6L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,18L,19L,20L,20L,20L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,22L,22L,22L,22L,22L,23L,24L,24L,24L,25L,25L,26L,27L,28L,29L,30L,30L,31L,32L,33L,34L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257998Inst : IEnumerable<long>
{
public static readonly long[] Value=A257998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257998.Bytes);
public long this[int i]=>Value[i];

public static A257998Inst Instance=new A257998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257999
{
public static readonly long[] Value={ 2L,3L,8L,12L,18L,27L,32L,48L,72L,108L,128L,162L,192L,243L,288L,432L,512L,648L,768L,972L,1152L,1458L,1728L,2048L,2187L,2592L,3072L,3888L,4608L,5832L,6912L,8192L,8748L,10368L,12288L,13122L,15552L,18432L,19683L,23328L,27648L,32768L,34992L,41472L,49152L,52488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257999Inst : IEnumerable<long>
{
public static readonly long[] Value=A257999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257999.Bytes);
public long this[int i]=>Value[i];

public static A257999Inst Instance=new A257999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258000
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,14L,26L,48L,89L,164L,302L,557L,1028L,1896L,3496L,6448L,11893L,21935L,40455L,74613L,137613L,253807L,468108L,863354L,1592327L,2936808L,5416499L,9989915L,18424893L,33981939L,62674564L,115593785L,213195313L,393206621L,725210344L,1337541166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258000Inst : IEnumerable<long>
{
public static readonly long[] Value=A258000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258000.Bytes);
public long this[int i]=>Value[i];

public static A258000Inst Instance=new A258000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258001
{
public static readonly long[] Value={ 1L,64L,127L,1057L,1090L,1156L,1288L,1519L,1552L,1783L,1915L,1981L,2014L,4369L,4642L,5188L,6007L,6280L,7099L,7645L,7918L,16963L,17029L,17161L,17542L,17545L,17674L,17938L,18529L,18577L,18700L,18706L,18964L,19492L,20335L,20641L,20674L,20770L,21016L,21028L,21544L,22447L,22600L,23479L,23503L,23995L,24187L,24253L,24286L,24865L,24898L,24964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258001Inst : IEnumerable<long>
{
public static readonly long[] Value=A258001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258001.Bytes);
public long this[int i]=>Value[i];

public static A258001Inst Instance=new A258001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258002
{
public static readonly long[] Value={ 1L,127L,1519L,1783L,1915L,1981L,2014L,6007L,7099L,7645L,7918L,20335L,22447L,23479L,23503L,23995L,24187L,24253L,24286L,26551L,27607L,28123L,28135L,28381L,28477L,28510L,29659L,30187L,30445L,30451L,30574L,30622L,31213L,31477L,31606L,31609L,31990L,32122L,32188L,80815L,81271L,89527L,89551L,89719L,93655L,93883L,95191L,95707L,95719L,95965L,96061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258002Inst : IEnumerable<long>
{
public static readonly long[] Value=A258002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258002.Bytes);
public long this[int i]=>Value[i];

public static A258002Inst Instance=new A258002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258003
{
public static readonly long[] Value={ 1L,127L,2014L,7918L,31606L,32122L,32188L,126394L,127930L,128476L,486838L,503254L,503482L,505306L,505564L,506332L,511450L,511462L,511708L,511804L,513514L,513772L,513778L,514540L,514804L,514936L,2012890L,2012902L,2013916L,2021098L,2021212L,2022124L,2025196L,2039254L,2043610L,2043622L,2045674L,2045788L,2046700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258003Inst : IEnumerable<long>
{
public static readonly long[] Value=A258003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258003.Bytes);
public long this[int i]=>Value[i];

public static A258003Inst Instance=new A258003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258004
{
public static readonly long[] Value={ 0L,63L,990L,3822L,15222L,15738L,15804L,60858L,62394L,62940L,224694L,241110L,241338L,243162L,243420L,244188L,249306L,249318L,249564L,249660L,251370L,251628L,251634L,252396L,252660L,252792L,964314L,964326L,965340L,972522L,972636L,973548L,976620L,990678L,995034L,995046L,997098L,997212L,998124L,998130L,1003242L,1005420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258004Inst : IEnumerable<long>
{
public static readonly long[] Value=A258004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258004.Bytes);
public long this[int i]=>Value[i];

public static A258004Inst Instance=new A258004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258005
{
public static readonly long[] Value={ 1L,127L,2014L,7918L,31606L,32122L,32188L,126394L,486838L,503482L,505564L,506332L,511708L,511804L,513514L,514936L,2012890L,2021098L,2025196L,2054044L,2055544L,7788250L,8050522L,8051434L,8051548L,8054620L,8075098L,8075110L,8084380L,8104888L,8182636L,8183020L,8185756L,8207218L,8207602L,8214442L,8219596L,8219602L,8231884L,8236516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258005Inst : IEnumerable<long>
{
public static readonly long[] Value=A258005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258005.Bytes);
public long this[int i]=>Value[i];

public static A258005Inst Instance=new A258005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258006
{
public static readonly long[] Value={ 22L,333L,22L,333L,22L,223L,110L,22L,333L,22L,223L,110L,22L,333L,22L,333L,22L,333L,22L,333L,22L,223L,110L,22L,333L,22L,333L,22L,333L,22L,333L,22L,223L,110L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,223L,110L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,333L,22L,223L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258006Inst : IEnumerable<long>
{
public static readonly long[] Value=A258006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258006.Bytes);
public long this[int i]=>Value[i];

public static A258006Inst Instance=new A258006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258007
{
public static readonly long[] Value={ 3L,19L,3L,19L,3L,19L,3L,19L,3L,13L,6L,3L,13L,6L,3L,13L,6L,3L,13L,6L,3L,3L,10L,6L,3L,3L,10L,6L,3L,3L,16L,3L,3L,16L,3L,3L,19L,3L,7L,12L,3L,19L,3L,7L,12L,3L,19L,3L,19L,3L,19L,3L,19L,3L,13L,6L,3L,13L,6L,3L,13L,6L,3L,13L,6L,3L,3L,10L,6L,3L,3L,10L,6L,3L,3L,16L,3L,3L,16L,3L,3L,19L,3L,7L,12L,3L,19L,3L,19L,3L,19L,3L,19L,3L,19L,3L,19L,3L,13L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258007Inst : IEnumerable<long>
{
public static readonly long[] Value=A258007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258007.Bytes);
public long this[int i]=>Value[i];

public static A258007Inst Instance=new A258007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258008
{
public static readonly long[] Value={ 7L,6L,4L,4L,11L,4L,4L,4L,8L,4L,4L,10L,4L,12L,29L,4L,4L,4L,8L,4L,4L,10L,4L,12L,38L,4L,4L,10L,4L,12L,47L,4L,12L,57L,182L,4L,4L,4L,8L,4L,4L,10L,4L,12L,38L,4L,4L,10L,4L,12L,47L,4L,12L,57L,231L,4L,4L,10L,4L,12L,47L,4L,12L,57L,277L,4L,12L,57L,322L,359L,335L,314L,222L,31L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258008Inst : IEnumerable<long>
{
public static readonly long[] Value=A258008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258008.Bytes);
public long this[int i]=>Value[i];

public static A258008Inst Instance=new A258008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258009
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,25L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,41L,39L,40L,41L,42L,43L,50L,51L,46L,47L,48L,49L,50L,51L,52L,53L,57L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,73L,71L,72L,73L,74L,75L,82L,83L,78L,79L,80L,81L,82L,83L,84L,85L,89L,87L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258009Inst : IEnumerable<long>
{
public static readonly long[] Value=A258009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258009.Bytes);
public long this[int i]=>Value[i];

public static A258009Inst Instance=new A258009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258010
{
public static readonly long[] Value={ 7L,6L,2L,2L,4L,11L,2L,2L,4L,4L,6L,2L,4L,4L,10L,4L,7L,5L,9L,10L,10L,2L,2L,4L,4L,6L,2L,4L,4L,10L,4L,7L,5L,9L,10L,9L,2L,6L,2L,4L,4L,10L,4L,7L,5L,9L,10L,9L,2L,8L,9L,4L,7L,5L,9L,10L,9L,2L,8L,2L,6L,2L,9L,9L,10L,9L,2L,8L,8L,16L,8L,9L,2L,8L,8L,29L,2L,8L,8L,9L,6L,13L,10L,2L,2L,4L,4L,6L,2L,4L,4L,10L,4L,7L,5L,9L,10L,9L,2L,6L,2L,4L,4L,10L,4L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258010Inst : IEnumerable<long>
{
public static readonly long[] Value=A258010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258010.Bytes);
public long this[int i]=>Value[i];

public static A258010Inst Instance=new A258010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258011
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,15L,21L,25L,27L,31L,33L,37L,43L,45L,49L,51L,55L,57L,63L,67L,69L,73L,75L,79L,85L,87L,91L,93L,97L,99L,105L,109L,111L,115L,117L,121L,127L,129L,133L,135L,139L,141L,147L,151L,153L,157L,159L,163L,169L,171L,175L,177L,181L,183L,189L,193L,195L,199L,201L,205L,211L,213L,217L,219L,223L,225L,231L,235L,237L,241L,243L,247L,253L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258011Inst : IEnumerable<long>
{
public static readonly long[] Value=A258011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258011.Bytes);
public long this[int i]=>Value[i];

public static A258011Inst Instance=new A258011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258012
{
public static readonly long[] Value={ 1L,127L,1519L,1783L,1915L,1981L,2014L,6007L,7099L,7645L,7918L,20335L,22447L,23479L,23503L,23995L,24187L,24253L,24286L,26551L,27607L,28123L,28135L,28381L,28477L,28510L,29659L,30187L,30445L,30451L,30574L,30622L,31213L,31477L,31606L,31609L,31990L,32122L,32188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258012Inst : IEnumerable<long>
{
public static readonly long[] Value=A258012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258012.Bytes);
public long this[int i]=>Value[i];

public static A258012Inst Instance=new A258012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258013
{
public static readonly long[] Value={ 1L,127L,2014L,7918L,31606L,32122L,32188L,126394L,127930L,128476L,486838L,503254L,503482L,505306L,505564L,506332L,511450L,511462L,511708L,511804L,513514L,513772L,513778L,514540L,514804L,514936L,2012890L,2012902L,2013916L,2021098L,2021212L,2022124L,2025196L,2039254L,2043610L,2043622L,2045674L,2045788L,2046700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258013Inst : IEnumerable<long>
{
public static readonly long[] Value=A258013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258013.Bytes);
public long this[int i]=>Value[i];

public static A258013Inst Instance=new A258013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258014
{
public static readonly long[] Value={ 0L,63L,990L,3822L,15222L,15738L,15804L,60858L,62394L,62940L,224694L,241110L,241338L,243162L,243420L,244188L,249306L,249318L,249564L,249660L,251370L,251628L,251634L,252396L,252660L,252792L,964314L,964326L,965340L,972522L,972636L,973548L,976620L,990678L,995034L,995046L,997098L,997212L,998124L,998130L,1003242L,1005420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258014Inst : IEnumerable<long>
{
public static readonly long[] Value=A258014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258014.Bytes);
public long this[int i]=>Value[i];

public static A258014Inst Instance=new A258014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258015
{
public static readonly long[] Value={ 1L,127L,2014L,7918L,31606L,32122L,32188L,126394L,486838L,503482L,505564L,506332L,511708L,511804L,513514L,514936L,2012890L,2021098L,2025196L,2054044L,2055544L,7788250L,8050522L,8051434L,8051548L,8054620L,8075098L,8075110L,8084380L,8104888L,8182636L,8183020L,8185756L,8207218L,8207602L,8214442L,8219596L,8219602L,8231884L,8236516L,8238832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258015Inst : IEnumerable<long>
{
public static readonly long[] Value=A258015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258015.Bytes);
public long this[int i]=>Value[i];

public static A258015Inst Instance=new A258015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258016
{
public static readonly long[] Value={ 19L,39L,61L,81L,103L,123L,145L,165L,187L,207L,229L,249L,271L,291L,313L,333L,355L,375L,397L,417L,439L,459L,481L,501L,523L,543L,565L,585L,607L,627L,649L,669L,691L,711L,733L,753L,775L,795L,817L,837L,859L,879L,901L,921L,943L,963L,985L,1005L,1027L,1047L,1069L,1089L,1111L,1131L,1153L,1173L,1195L,1215L,1237L,1257L,1279L,1299L,1321L,1341L,1363L,1383L,1405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258016Inst : IEnumerable<long>
{
public static readonly long[] Value=A258016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258016.Bytes);
public long this[int i]=>Value[i];

public static A258016Inst Instance=new A258016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258017
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,3L,3L,16L,23L,80L,183L,564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258017Inst : IEnumerable<long>
{
public static readonly long[] Value=A258017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258017.Bytes);
public long this[int i]=>Value[i];

public static A258017Inst Instance=new A258017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258018
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,3L,1L,8L,5L,20L,11L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258018Inst : IEnumerable<long>
{
public static readonly long[] Value=A258018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258018.Bytes);
public long this[int i]=>Value[i];

public static A258018Inst Instance=new A258018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258019
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,3L,2L,12L,14L,50L,97L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258019Inst : IEnumerable<long>
{
public static readonly long[] Value=A258019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258019.Bytes);
public long this[int i]=>Value[i];

public static A258019Inst Instance=new A258019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258020
{
public static readonly long[] Value={ 0L,0L,2L,5L,1L,5L,5L,1L,6L,5L,1L,2L,5L,1L,2L,5L,1L,6L,4L,1L,3L,4L,1L,1L,2L,5L,1L,5L,5L,1L,6L,5L,1L,6L,5L,1L,2L,5L,1L,6L,4L,1L,3L,4L,1L,1L,2L,5L,1L,5L,5L,1L,6L,5L,1L,4L,5L,1L,7L,5L,1L,6L,4L,1L,3L,4L,1L,1L,2L,5L,1L,5L,5L,1L,2L,5L,1L,7L,5L,1L,6L,5L,1L,6L,4L,1L,3L,4L,1L,1L,4L,5L,1L,2L,5L,1L,2L,5L,1L,5L,5L,1L,6L,5L,1L,2L,4L,1L,3L,4L,1L,1L,4L,5L,1L,2L,5L,1L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258020Inst : IEnumerable<long>
{
public static readonly long[] Value=A258020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258020.Bytes);
public long this[int i]=>Value[i];

public static A258020Inst Instance=new A258020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258021
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258021Inst : IEnumerable<long>
{
public static readonly long[] Value=A258021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258021.Bytes);
public long this[int i]=>Value[i];

public static A258021Inst Instance=new A258021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258022
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,24L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,68L,69L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258022Inst : IEnumerable<long>
{
public static readonly long[] Value=A258022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258022.Bytes);
public long this[int i]=>Value[i];

public static A258022Inst Instance=new A258022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258023
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,12L,15L,16L,18L,24L,25L,27L,32L,36L,45L,48L,54L,64L,72L,75L,81L,96L,108L,125L,128L,135L,144L,162L,192L,216L,225L,243L,256L,288L,324L,375L,384L,405L,432L,486L,512L,576L,625L,648L,675L,729L,768L,864L,972L,1024L,1125L,1152L,1215L,1296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258023Inst : IEnumerable<long>
{
public static readonly long[] Value=A258023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258023.Bytes);
public long this[int i]=>Value[i];

public static A258023Inst Instance=new A258023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258024
{
public static readonly long[] Value={ 1L,4L,23L,26L,45L,48L,67L,70L,89L,92L,105L,111L,114L,121L,127L,133L,136L,143L,149L,155L,158L,171L,177L,180L,183L,193L,199L,202L,205L,215L,221L,224L,227L,243L,246L,249L,265L,268L,271L,290L,293L,300L,312L,315L,334L,337L,344L,356L,359L,378L,381L,400L,403L,422L,425L,444L,447L,460L,466L,469L,476L,482L,488L,491L,498L,504L,510L,513L,526L,532L,535L,538L,548L,554L,557L,560L,570L,576L,579L,582L,598L,601L,604L,620L,623L,626L,645L,648L,655L,667L,670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258024Inst : IEnumerable<long>
{
public static readonly long[] Value=A258024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258024.Bytes);
public long this[int i]=>Value[i];

public static A258024Inst Instance=new A258024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258025
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,13L,14L,17L,20L,22L,23L,26L,28L,29L,31L,33L,35L,38L,41L,43L,45L,49L,50L,52L,57L,60L,61L,64L,65L,67L,69L,70L,71L,75L,76L,78L,79L,81L,83L,85L,86L,89L,90L,93L,95L,96L,98L,100L,104L,105L,109L,113L,116L,117L,120L,122L,123L,124L,126L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258025Inst : IEnumerable<long>
{
public static readonly long[] Value=A258025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258025.Bytes);
public long this[int i]=>Value[i];

public static A258025Inst Instance=new A258025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258026
{
public static readonly long[] Value={ 4L,6L,9L,11L,12L,16L,18L,19L,21L,24L,25L,27L,30L,32L,34L,37L,40L,42L,44L,47L,48L,51L,53L,56L,58L,59L,62L,63L,66L,68L,72L,74L,77L,80L,82L,84L,87L,88L,91L,92L,94L,97L,99L,101L,103L,106L,108L,111L,112L,114L,115L,119L,121L,125L,127L,128L,130L,132L,133L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258026Inst : IEnumerable<long>
{
public static readonly long[] Value=A258026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258026.Bytes);
public long this[int i]=>Value[i];

public static A258026Inst Instance=new A258026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258027
{
public static readonly long[] Value={ 2L,4L,6L,9L,12L,16L,19L,21L,24L,25L,27L,28L,30L,32L,34L,37L,40L,42L,44L,47L,48L,51L,53L,56L,59L,62L,63L,64L,66L,68L,72L,74L,77L,80L,82L,84L,87L,88L,89L,92L,94L,95L,97L,99L,101L,103L,106L,108L,112L,115L,119L,121L,125L,128L,130L,133L,135L,137L,139L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258027Inst : IEnumerable<long>
{
public static readonly long[] Value=A258027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258027.Bytes);
public long this[int i]=>Value[i];

public static A258027Inst Instance=new A258027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258028
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,14L,15L,17L,20L,23L,26L,29L,31L,33L,35L,36L,38L,39L,41L,43L,45L,46L,50L,52L,55L,57L,60L,61L,65L,67L,71L,73L,76L,78L,79L,81L,83L,86L,90L,93L,96L,98L,100L,102L,105L,107L,109L,110L,113L,114L,117L,118L,120L,124L,126L,129L,131L,134L,136L,138L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258028Inst : IEnumerable<long>
{
public static readonly long[] Value=A258028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258028.Bytes);
public long this[int i]=>Value[i];

public static A258028Inst Instance=new A258028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258029
{
public static readonly long[] Value={ 17L,31L,41L,61L,79L,227L,251L,271L,347L,349L,379L,439L,467L,569L,607L,641L,673L,677L,709L,743L,1031L,1091L,1277L,1291L,1427L,1429L,1487L,1549L,1607L,1619L,1657L,1723L,1741L,1777L,1861L,1979L,1987L,2039L,2131L,2203L,2371L,2459L,2477L,2557L,2677L,2687L,2689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258029Inst : IEnumerable<long>
{
public static readonly long[] Value=A258029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258029.Bytes);
public long this[int i]=>Value[i];

public static A258029Inst Instance=new A258029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258030
{
public static readonly long[] Value={ 3L,7L,13L,23L,37L,53L,67L,73L,89L,97L,103L,107L,113L,131L,139L,157L,173L,181L,193L,211L,223L,233L,241L,263L,277L,293L,307L,311L,317L,337L,359L,373L,389L,409L,421L,433L,449L,457L,461L,479L,491L,499L,509L,523L,547L,563L,577L,593L,613L,631L,653L,661L,691L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258030Inst : IEnumerable<long>
{
public static readonly long[] Value=A258030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258030.Bytes);
public long this[int i]=>Value[i];

public static A258030Inst Instance=new A258030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258031
{
public static readonly long[] Value={ 2L,5L,11L,19L,29L,43L,47L,59L,71L,83L,101L,109L,127L,137L,149L,151L,163L,167L,179L,191L,197L,199L,229L,239L,257L,269L,281L,283L,313L,331L,353L,367L,383L,397L,401L,419L,431L,443L,463L,487L,503L,521L,541L,557L,571L,587L,599L,601L,617L,619L,643L,647L,659L,683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258031Inst : IEnumerable<long>
{
public static readonly long[] Value=A258031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258031.Bytes);
public long this[int i]=>Value[i];

public static A258031Inst Instance=new A258031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258032
{
public static readonly long[] Value={ 3L,17L,53L,113L,157L,233L,257L,277L,353L,359L,379L,397L,677L,877L,997L,1039L,1217L,1439L,1613L,1697L,1879L,1973L,1997L,2273L,2417L,2459L,2777L,3257L,3413L,3499L,3517L,3697L,3779L,4073L,4157L,4177L,4339L,4973L,4999L,5077L,5197L,5279L,5639L,5813L,5897L,6277L,6379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258032Inst : IEnumerable<long>
{
public static readonly long[] Value=A258032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258032.Bytes);
public long this[int i]=>Value[i];

public static A258032Inst Instance=new A258032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258033
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,2L,1L,3L,0L,5L,2L,4L,1L,3L,0L,5L,2L,4L,1L,6L,3L,0L,8L,5L,2L,7L,4L,1L,6L,3L,0L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,0L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,11L,0L,8L,5L,13L,2L,10L,7L,4L,12L,1L,9L,6L,3L,11L,0L,8L,5L,13L,2L,10L,7L,4L,12L,1L,9L,6L,14L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258033Inst : IEnumerable<long>
{
public static readonly long[] Value=A258033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258033.Bytes);
public long this[int i]=>Value[i];

public static A258033Inst Instance=new A258033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258034
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,0L,4L,4L,0L,0L,4L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,4L,4L,0L,0L,4L,0L,0L,0L,0L,8L,0L,0L,0L,2L,0L,0L,4L,0L,0L,0L,0L,0L,4L,0L,0L,4L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,4L,4L,0L,0L,0L,0L,0L,0L,0L,4L,4L,0L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258034Inst : IEnumerable<long>
{
public static readonly long[] Value=A258034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258034.Bytes);
public long this[int i]=>Value[i];

public static A258034Inst Instance=new A258034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258035
{
public static readonly long[] Value={ 2L,37L,3L,7L,13L,277L,2617L,43L,2924263L,300999679L,631112173L,1368737917L,4428230508349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258035Inst : IEnumerable<long>
{
public static readonly long[] Value=A258035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258035.Bytes);
public long this[int i]=>Value[i];

public static A258035Inst Instance=new A258035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258036
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,17L,19L,21L,23L,25L,28L,30L,32L,34L,36L,38L,41L,43L,45L,47L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,99L,101L,103L,105L,107L,109L,111L,114L,116L,118L,120L,122L,124L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258036Inst : IEnumerable<long>
{
public static readonly long[] Value=A258036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258036.Bytes);
public long this[int i]=>Value[i];

public static A258036Inst Instance=new A258036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258037
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,13L,15L,16L,18L,20L,22L,24L,26L,27L,29L,31L,33L,35L,37L,39L,40L,42L,44L,46L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,100L,102L,104L,106L,108L,110L,112L,113L,115L,117L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258037Inst : IEnumerable<long>
{
public static readonly long[] Value=A258037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258037.Bytes);
public long this[int i]=>Value[i];

public static A258037Inst Instance=new A258037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258038
{
public static readonly long[] Value={ 7L,13L,19L,29L,37L,43L,59L,67L,73L,83L,97L,107L,113L,131L,139L,151L,163L,179L,191L,197L,211L,223L,229L,239L,251L,263L,271L,281L,293L,311L,317L,337L,349L,359L,373L,383L,397L,409L,421L,433L,443L,457L,463L,479L,491L,503L,521L,523L,547L,563L,571L,587L,599L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258038Inst : IEnumerable<long>
{
public static readonly long[] Value=A258038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258038.Bytes);
public long this[int i]=>Value[i];

public static A258038Inst Instance=new A258038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258039
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,31L,41L,47L,53L,61L,71L,79L,89L,101L,103L,109L,127L,137L,149L,157L,167L,173L,181L,193L,199L,227L,233L,241L,257L,269L,277L,283L,307L,313L,331L,347L,353L,367L,379L,389L,401L,419L,431L,439L,449L,461L,467L,487L,499L,509L,541L,557L,569L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258039Inst : IEnumerable<long>
{
public static readonly long[] Value=A258039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258039.Bytes);
public long this[int i]=>Value[i];

public static A258039Inst Instance=new A258039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258040
{
public static readonly long[] Value={ 1L,-2L,2L,0L,-2L,2L,0L,0L,-2L,2L,2L,-8L,8L,0L,-8L,8L,-2L,0L,-6L,8L,6L,-24L,24L,0L,-24L,22L,-4L,0L,-16L,20L,16L,-64L,62L,0L,-60L,56L,-10L,0L,-40L,48L,38L,-148L,144L,0L,-136L,126L,-24L,0L,-88L,106L,82L,-320L,308L,0L,-288L,264L,-48L,0L,-180L,216L,168L,-652L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258040Inst : IEnumerable<long>
{
public static readonly long[] Value=A258040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258040.Bytes);
public long this[int i]=>Value[i];

public static A258040Inst Instance=new A258040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258041
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,10L,31L,94L,303L,986L,3284L,11099L,38024L,131694L,460607L,1624451L,5771532L,20640334L,74246701L,268478962L,975436348L,3559204700L,13037907692L,47931423574L,176792821643L,654078238224L,2426705590840L,9026907769955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258041Inst : IEnumerable<long>
{
public static readonly long[] Value=A258041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258041.Bytes);
public long this[int i]=>Value[i];

public static A258041Inst Instance=new A258041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258042
{
public static readonly long[] Value={ 1L,7L,5L,5L,0L,6L,9L,6L,5L,8L,3L,7L,6L,8L,2L,4L,1L,8L,8L,1L,0L,9L,9L,4L,6L,4L,7L,1L,3L,3L,9L,1L,0L,6L,2L,4L,7L,7L,9L,4L,2L,3L,8L,0L,8L,3L,0L,2L,8L,2L,6L,8L,3L,5L,4L,2L,3L,5L,7L,6L,7L,5L,8L,3L,1L,2L,5L,1L,4L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258042Inst : IEnumerable<long>
{
public static readonly long[] Value=A258042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258042.Bytes);
public long this[int i]=>Value[i];

public static A258042Inst Instance=new A258042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258043
{
public static readonly long[] Value={ 3L,1L,8L,2L,2L,2L,4L,4L,2L,16L,193L,4L,8L,3L,4L,21L,11L,18L,8L,8L,11L,2L,8L,7L,70L,3L,95L,4L,172L,7L,4L,94L,143L,90L,193L,17L,2L,8L,46L,41L,2L,10L,254L,90L,74L,75L,371L,85L,70L,3L,177L,53L,85L,91L,18L,24L,84L,103L,34L,95L,34L,111L,80L,253L,84L,224L,397L,1002L,11L,33L,773L,29L,647L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258043Inst : IEnumerable<long>
{
public static readonly long[] Value=A258043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258043.Bytes);
public long this[int i]=>Value[i];

public static A258043Inst Instance=new A258043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258044
{
public static readonly long[] Value={ 5L,8L,144L,1548008755920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258044Inst : IEnumerable<long>
{
public static readonly long[] Value=A258044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258044.Bytes);
public long this[int i]=>Value[i];

public static A258044Inst Instance=new A258044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258045
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,0L,1L,1L,1L,2L,1L,1L,1L,1L,0L,1L,2L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,2L,3L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258045Inst : IEnumerable<long>
{
public static readonly long[] Value=A258045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258045.Bytes);
public long this[int i]=>Value[i];

public static A258045Inst Instance=new A258045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258046
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,12L,5L,10L,7L,14L,8L,16L,11L,9L,18L,36L,13L,26L,15L,30L,17L,34L,19L,38L,20L,40L,21L,42L,22L,44L,23L,46L,24L,48L,31L,27L,54L,25L,50L,41L,29L,58L,28L,56L,32L,64L,33L,66L,39L,43L,35L,70L,37L,74L,49L,98L,45L,90L,47L,94L,52L,104L,53L,106L,51L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258046Inst : IEnumerable<long>
{
public static readonly long[] Value=A258046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258046.Bytes);
public long this[int i]=>Value[i];

public static A258046Inst Instance=new A258046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258047
{
public static readonly long[] Value={ 0L,1L,2L,-1L,3L,6L,-7L,5L,-3L,7L,-6L,8L,-5L,-2L,9L,18L,-23L,13L,-11L,15L,-13L,17L,-15L,19L,-18L,20L,-19L,21L,-20L,22L,-21L,23L,-22L,24L,-17L,-4L,27L,-29L,25L,-9L,-12L,29L,-30L,28L,-24L,32L,-31L,33L,-27L,4L,-8L,35L,-33L,37L,-25L,49L,-53L,45L,-43L,47L,-42L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258047Inst : IEnumerable<long>
{
public static readonly long[] Value=A258047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258047.Bytes);
public long this[int i]=>Value[i];

public static A258047Inst Instance=new A258047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258048
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,34L,35L,36L,38L,39L,41L,42L,44L,45L,47L,48L,50L,51L,53L,54L,56L,57L,58L,60L,61L,63L,64L,66L,67L,69L,70L,72L,73L,75L,76L,78L,79L,80L,82L,83L,85L,86L,88L,89L,91L,92L,94L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258048Inst : IEnumerable<long>
{
public static readonly long[] Value=A258048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258048.Bytes);
public long this[int i]=>Value[i];

public static A258048Inst Instance=new A258048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258049
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,11L,14L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,36L,38L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258049Inst : IEnumerable<long>
{
public static readonly long[] Value=A258049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258049.Bytes);
public long this[int i]=>Value[i];

public static A258049Inst Instance=new A258049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258050
{
public static readonly long[] Value={ 3L,6L,8L,10L,12L,13L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,35L,37L,39L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258050Inst : IEnumerable<long>
{
public static readonly long[] Value=A258050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258050.Bytes);
public long this[int i]=>Value[i];

public static A258050Inst Instance=new A258050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258051
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,2L,4L,1L,3L,0L,5L,2L,4L,1L,3L,0L,5L,2L,7L,4L,1L,6L,3L,0L,8L,5L,2L,7L,4L,1L,9L,6L,3L,0L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,0L,8L,5L,2L,10L,7L,4L,12L,1L,9L,6L,3L,11L,0L,8L,5L,13L,2L,10L,7L,4L,12L,1L,9L,6L,3L,11L,0L,8L,5L,13L,2L,10L,7L,15L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258051Inst : IEnumerable<long>
{
public static readonly long[] Value=A258051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258051.Bytes);
public long this[int i]=>Value[i];

public static A258051Inst Instance=new A258051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258052
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,13L,18L,23L,20L,21L,22L,27L,26L,29L,30L,29L,30L,37L,42L,41L,48L,49L,48L,47L,56L,75L,74L,77L,78L,83L,74L,81L,80L,83L,80L,81L,82L,79L,84L,83L,84L,97L,94L,99L,104L,111L,106L,101L,102L,103L,102L,101L,102L,101L,102L,125L,126L,127L,128L,137L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258052Inst : IEnumerable<long>
{
public static readonly long[] Value=A258052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258052.Bytes);
public long this[int i]=>Value[i];

public static A258052Inst Instance=new A258052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258053
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,-2L,-4L,0L,-7L,20L,42L,0L,84L,-272L,-584L,0L,-1239L,4270L,9288L,0L,20370L,-72860L,-159840L,0L,-358092L,1312824L,2897400L,0L,6587944L,-24580512L,-54490848L,0L,-125256887L,473534676L,1053346410L,0L,2441648384L,-9325376200L,-20800103016L,0L,-48534848222L,186886877456L,417769301220L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258053Inst : IEnumerable<long>
{
public static readonly long[] Value=A258053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258053.Bytes);
public long this[int i]=>Value[i];

public static A258053Inst Instance=new A258053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258054
{
public static readonly long[] Value={ 1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,12L,5L,10L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258054Inst : IEnumerable<long>
{
public static readonly long[] Value=A258054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258054.Bytes);
public long this[int i]=>Value[i];

public static A258054Inst Instance=new A258054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258055
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,11L,0L,3L,2L,21L,1L,12L,11L,111L,0L,4L,3L,31L,2L,22L,21L,211L,1L,13L,12L,121L,11L,112L,111L,1111L,0L,5L,4L,41L,3L,32L,31L,311L,2L,23L,22L,221L,21L,212L,211L,2111L,1L,14L,13L,131L,12L,122L,121L,1211L,11L,113L,112L,1121L,111L,1112L,1111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258055Inst : IEnumerable<long>
{
public static readonly long[] Value=A258055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258055.Bytes);
public long this[int i]=>Value[i];

public static A258055Inst Instance=new A258055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258056
{
public static readonly long[] Value={ 75L,226L,113L,340L,170L,85L,256L,128L,64L,32L,16L,8L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258056Inst : IEnumerable<long>
{
public static readonly long[] Value=A258056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258056.Bytes);
public long this[int i]=>Value[i];

public static A258056Inst Instance=new A258056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258057
{
public static readonly long[] Value={ 0L,1L,0L,3L,-3L,4L,-4L,11L,-6L,1L,-6L,15L,-15L,8L,-1L,24L,-31L,20L,-20L,23L,-14L,3L,-12L,43L,-34L,5L,12L,5L,-31L,30L,-30L,79L,-66L,5L,-7L,48L,-59L,20L,-5L,52L,-67L,40L,-40L,47L,-9L,-14L,-24L,111L,-98L,31L,-25L,36L,-55L,80L,-65L,76L,-70L,9L,-30L,91L,-91L,32L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258057Inst : IEnumerable<long>
{
public static readonly long[] Value=A258057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258057.Bytes);
public long this[int i]=>Value[i];

public static A258057Inst Instance=new A258057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258058
{
public static readonly long[] Value={ 1L,2L,1L,7L,9L,3L,6L,4L,0L,5L,4L,8L,0L,3L,5L,2L,8L,1L,0L,0L,7L,4L,4L,0L,7L,4L,5L,8L,1L,1L,7L,2L,6L,6L,2L,1L,8L,5L,5L,9L,0L,2L,6L,1L,2L,2L,9L,4L,5L,3L,6L,2L,8L,1L,5L,1L,3L,0L,3L,6L,0L,8L,4L,3L,9L,9L,3L,0L,8L,0L,2L,2L,1L,2L,8L,0L,7L,7L,8L,1L,0L,2L,4L,8L,1L,2L,2L,2L,1L,8L,3L,9L,0L,1L,0L,2L,2L,1L,1L,4L,0L,2L,2L,7L,4L,3L,4L,2L,1L,2L,6L,9L,1L,0L,1L,1L,9L,3L,5L,7L,7L,5L,3L,0L,1L,5L,7L,6L,6L,1L,3L,2L,2L,3L,6L,4L,4L,9L,0L,1L,5L,7L,7L,7L,3L,6L,9L,6L,9L,9L,7L,1L,1L,4L,5L,3L,0L,4L,1L,6L,1L,0L,3L,3L,7L,5L,5L,0L,3L,1L,3L,0L,5L,6L,7L,3L,0L,9L,6L,5L,5L,1L,1L,7L,1L,7L,1L,2L,2L,8L,6L,1L,9L,7L,8L,7L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258058Inst : IEnumerable<long>
{
public static readonly long[] Value=A258058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258058.Bytes);
public long this[int i]=>Value[i];

public static A258058Inst Instance=new A258058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258059
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,4L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258059Inst : IEnumerable<long>
{
public static readonly long[] Value=A258059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258059.Bytes);
public long this[int i]=>Value[i];

public static A258059Inst Instance=new A258059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258060
{
public static readonly long[] Value={ 49L,169L,361L,1225L,1444L,1681L,3249L,4225L,4900L,15625L,16900L,36100L,42025L,49729L,64009L,81225L,93025L,122500L,142129L,144400L,168100L,225625L,237169L,324900L,414736L,422500L,490000L,519841L,819025L,950625L,970225L,1024144L,1442401L,1562500L,1600225L,1690000L,1692601L,2079364L,2304324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258060Inst : IEnumerable<long>
{
public static readonly long[] Value=A258060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258060.Bytes);
public long this[int i]=>Value[i];

public static A258060Inst Instance=new A258060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258061
{
public static readonly long[] Value={ 1069022L,1174439L,1433930L,7315048L,8383730L,19106606L,23389398L,34089553L,38835086L,71663630L,75752521L,86624609L,101137815L,107237721L,119545490L,123036966L,129093958L,130383688L,132980893L,138881703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258061Inst : IEnumerable<long>
{
public static readonly long[] Value=A258061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258061.Bytes);
public long this[int i]=>Value[i];

public static A258061Inst Instance=new A258061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258062
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,7L,1L,1L,9L,1L,2L,2L,1L,10L,1L,4L,2L,2L,1L,1L,5L,1L,7L,1L,7L,2L,4L,1L,2L,2L,1L,4L,2L,2L,1L,7L,2L,10L,1L,1L,1L,6L,1L,4L,2L,2L,1L,1L,4L,3L,1L,1L,1L,2L,2L,1L,7L,3L,1L,1L,5L,1L,7L,1L,2L,1L,6L,1L,3L,1L,6L,1L,1L,1L,3L,1L,2L,1L,1L,4L,5L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258062Inst : IEnumerable<long>
{
public static readonly long[] Value=A258062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258062.Bytes);
public long this[int i]=>Value[i];

public static A258062Inst Instance=new A258062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258063
{
public static readonly long[] Value={ 1L,4L,5L,17L,6L,43L,7L,206L,10L,15L,343L,168L,341L,1636L,1496L,1577L,526L,2463L,809L,3640L,5455L,16183L,33073L,5261L,4480L,6679L,3678L,18286L,29268L,9970L,16293L,86706L,51917L,29328L,106123L,48123L,5513L,54326L,10814L,24362L,128961L,43695L,35671L,53900L,97291L,24028L,129173L,60751L,86574L,250333L,80525L,62243L,65362L,71986L,77650L,675846L,16119L,380911L,245146L,90632L,71766L,353564L,508042L,237403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258063Inst : IEnumerable<long>
{
public static readonly long[] Value=A258063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258063.Bytes);
public long this[int i]=>Value[i];

public static A258063Inst Instance=new A258063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258064
{
public static readonly long[] Value={ 3L,9L,29L,67L,147L,283L,526L,893L,1470L,2287L,3451L,4990L,7030L,9559L,12697L,16375L,20664L,25406L,30621L,36034L,41618L,47022L,52174L,56696L,60548L,63362L,65186L,65746L,65186L,63362L,60548L,56696L,52174L,47022L,41618L,36034L,30621L,25406L,20664L,16375L,12697L,9559L,7030L,4990L,3451L,2287L,1470L,893L,526L,283L,147L,67L,29L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258064Inst : IEnumerable<long>
{
public static readonly long[] Value=A258064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258064.Bytes);
public long this[int i]=>Value[i];

public static A258064Inst Instance=new A258064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258065
{
public static readonly long[] Value={ 1L,0L,-2L,-4L,-1L,8L,6L,4L,-7L,-8L,-2L,-4L,10L,-8L,-4L,0L,2L,16L,-2L,16L,5L,-8L,0L,-12L,-12L,-16L,-2L,12L,-9L,0L,6L,8L,2L,16L,12L,-20L,0L,-8L,22L,0L,18L,8L,-32L,0L,4L,8L,-26L,-28L,-13L,-8L,0L,12L,-6L,24L,2L,20L,18L,0L,30L,-16L,-3L,-8L,-10L,20L,0L,-16L,14L,-16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258065Inst : IEnumerable<long>
{
public static readonly long[] Value=A258065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258065.Bytes);
public long this[int i]=>Value[i];

public static A258065Inst Instance=new A258065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258066
{
public static readonly long[] Value={ 1L,2L,4L,5L,1L,0L,4L,6L,1L,4L,8L,9L,3L,1L,2L,0L,1L,5L,6L,2L,4L,0L,2L,6L,9L,7L,0L,6L,9L,8L,5L,6L,5L,2L,1L,2L,0L,5L,9L,2L,1L,4L,7L,3L,0L,7L,3L,3L,6L,2L,9L,1L,9L,5L,0L,8L,0L,5L,1L,1L,5L,5L,1L,1L,8L,3L,7L,6L,5L,1L,8L,9L,2L,1L,3L,0L,0L,7L,7L,9L,6L,4L,6L,9L,4L,8L,8L,9L,1L,9L,2L,0L,2L,5L,5L,3L,0L,9L,4L,9L,5L,6L,4L,4L,6L,6L,9L,2L,3L,7L,3L,1L,2L,5L,9L,5L,1L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258066Inst : IEnumerable<long>
{
public static readonly long[] Value=A258066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258066.Bytes);
public long this[int i]=>Value[i];

public static A258066Inst Instance=new A258066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258067
{
public static readonly long[] Value={ 1L,2L,5L,1L,7L,8L,3L,3L,9L,6L,8L,6L,0L,5L,4L,0L,1L,8L,3L,6L,3L,7L,0L,8L,7L,2L,2L,7L,0L,5L,7L,7L,7L,4L,7L,5L,8L,9L,4L,8L,5L,8L,4L,3L,8L,3L,3L,3L,4L,5L,3L,0L,2L,8L,8L,7L,0L,0L,0L,3L,7L,3L,5L,8L,9L,9L,5L,6L,2L,5L,6L,7L,9L,0L,1L,1L,7L,9L,5L,4L,5L,2L,9L,7L,9L,1L,2L,8L,8L,3L,9L,0L,2L,8L,9L,2L,1L,1L,9L,2L,4L,6L,8L,4L,7L,3L,6L,9L,8L,8L,3L,5L,0L,7L,5L,7L,2L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258067Inst : IEnumerable<long>
{
public static readonly long[] Value=A258067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258067.Bytes);
public long this[int i]=>Value[i];

public static A258067Inst Instance=new A258067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258068
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258068Inst : IEnumerable<long>
{
public static readonly long[] Value=A258068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258068.Bytes);
public long this[int i]=>Value[i];

public static A258068Inst Instance=new A258068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258069
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258069Inst : IEnumerable<long>
{
public static readonly long[] Value=A258069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258069.Bytes);
public long this[int i]=>Value[i];

public static A258069Inst Instance=new A258069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258070
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258070Inst : IEnumerable<long>
{
public static readonly long[] Value=A258070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258070.Bytes);
public long this[int i]=>Value[i];

public static A258070Inst Instance=new A258070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258071
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258071Inst : IEnumerable<long>
{
public static readonly long[] Value=A258071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258071.Bytes);
public long this[int i]=>Value[i];

public static A258071Inst Instance=new A258071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258072
{
public static readonly long[] Value={ 0L,5L,5L,6L,4L,2L,5L,3L,0L,9L,8L,4L,9L,9L,6L,7L,3L,8L,4L,2L,1L,3L,9L,5L,9L,5L,5L,6L,4L,2L,5L,3L,0L,9L,8L,4L,9L,9L,6L,7L,4L,1L,4L,8L,8L,5L,6L,9L,7L,3L,4L,6L,9L,6L,1L,1L,8L,7L,4L,2L,2L,5L,3L,7L,1L,5L,6L,8L,7L,4L,6L,8L,3L,5L,1L,4L,0L,9L,9L,7L,7L,6L,5L,6L,9L,7L,4L,6L,2L,4L,1L,1L,4L,7L,2L,1L,7L,5L,1L,4L,0L,0L,8L,0L,4L,1L,7L,5L,7L,0L,7L,2L,8L,4L,3L,0L,4L,9L,5L,6L,6L,8L,9L,0L,2L,1L,8L,6L,3L,8L,8L,0L,3L,9L,8L,1L,6L,8L,9L,5L,0L,4L,4L,5L,3L,7L,6L,7L,7L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258072Inst : IEnumerable<long>
{
public static readonly long[] Value=A258072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258072.Bytes);
public long this[int i]=>Value[i];

public static A258072Inst Instance=new A258072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258073
{
public static readonly long[] Value={ 157115L,314229L,628457L,1256913L,2513825L,5027649L,10055297L,20110593L,40221185L,80442369L,160884737L,321769473L,643538945L,1287077889L,2574155777L,5148311553L,10296623105L,20593246209L,41186492417L,82372984833L,164745969665L,329491939329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258073Inst : IEnumerable<long>
{
public static readonly long[] Value=A258073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258073.Bytes);
public long this[int i]=>Value[i];

public static A258073Inst Instance=new A258073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258074
{
public static readonly long[] Value={ 5359L,5054502L,33661L,7031232L,28433L,7830457L,27653L,9167433L,19249L,13018586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258074Inst : IEnumerable<long>
{
public static readonly long[] Value=A258074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258074.Bytes);
public long this[int i]=>Value[i];

public static A258074Inst Instance=new A258074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258075
{
public static readonly long[] Value={ 0L,4L,4L,3L,5L,7L,4L,6L,9L,0L,1L,5L,0L,0L,3L,2L,6L,1L,5L,7L,8L,6L,0L,4L,0L,4L,4L,3L,5L,7L,4L,6L,9L,0L,1L,5L,0L,0L,3L,2L,5L,8L,5L,1L,1L,4L,3L,0L,2L,6L,5L,3L,0L,3L,8L,8L,1L,2L,5L,7L,7L,4L,6L,2L,8L,4L,3L,1L,2L,5L,3L,1L,6L,4L,8L,5L,9L,0L,0L,2L,2L,3L,4L,3L,0L,2L,5L,3L,7L,5L,8L,8L,5L,2L,7L,8L,2L,4L,8L,5L,9L,9L,1L,9L,5L,8L,2L,4L,2L,9L,2L,7L,1L,5L,6L,9L,5L,0L,4L,3L,3L,1L,0L,9L,7L,8L,1L,3L,6L,1L,1L,9L,6L,0L,1L,8L,3L,1L,0L,4L,9L,5L,5L,4L,6L,2L,3L,2L,2L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258075Inst : IEnumerable<long>
{
public static readonly long[] Value=A258075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258075.Bytes);
public long this[int i]=>Value[i];

public static A258075Inst Instance=new A258075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258076
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,8L,7L,14L,9L,12L,11L,10L,13L,26L,15L,16L,17L,34L,19L,18L,23L,46L,21L,24L,25L,20L,27L,22L,29L,58L,31L,62L,33L,30L,37L,28L,39L,36L,35L,40L,41L,82L,43L,32L,45L,42L,47L,38L,49L,56L,51L,44L,53L,106L,55L,50L,57L,48L,59L,52L,61L,122L,63L,64L,65L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258076Inst : IEnumerable<long>
{
public static readonly long[] Value=A258076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258076.Bytes);
public long this[int i]=>Value[i];

public static A258076Inst Instance=new A258076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258077
{
public static readonly long[] Value={ 1L,2L,3L,6L,14L,15L,30L,35L,42L,70L,78L,105L,190L,210L,348L,357L,418L,570L,714L,812L,910L,1045L,1254L,2090L,2436L,2730L,3135L,4060L,4522L,4674L,5278L,6270L,9990L,10659L,12180L,12441L,13566L,14630L,15834L,16770L,20026L,21318L,21978L,23374L,24244L,24871L,24882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258077Inst : IEnumerable<long>
{
public static readonly long[] Value=A258077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258077.Bytes);
public long this[int i]=>Value[i];

public static A258077Inst Instance=new A258077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258078
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,8L,5L,10L,7L,14L,9L,12L,15L,18L,11L,22L,16L,20L,13L,26L,24L,21L,17L,34L,19L,38L,23L,46L,28L,30L,29L,58L,25L,35L,27L,33L,36L,32L,31L,62L,37L,74L,39L,42L,40L,44L,41L,82L,48L,45L,43L,86L,50L,52L,47L,94L,49L,56L,51L,54L,57L,60L,53L,106L,64L,66L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258078Inst : IEnumerable<long>
{
public static readonly long[] Value=A258078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258078.Bytes);
public long this[int i]=>Value[i];

public static A258078Inst Instance=new A258078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258079
{
public static readonly long[] Value={ 1L,2L,6L,10L,36L,168L,1098L,1204L,2840L,19488L,1881124L,3105700L,445577184L,105314212224L,134633963520L,2167649138304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258079Inst : IEnumerable<long>
{
public static readonly long[] Value=A258079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258079.Bytes);
public long this[int i]=>Value[i];

public static A258079Inst Instance=new A258079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258080
{
public static readonly long[] Value={ 1L,1L,5L,19L,1L,17L,53L,43L,29L,31L,79L,29L,179L,199L,11L,69L,169L,317L,139L,361L,185L,497L,331L,149L,601L,439L,263L,73L,739L,581L,411L,229L,35L,1019L,871L,713L,545L,367L,179L,1621L,1495L,1361L,1219L,1069L,911L,745L,571L,389L,199L,1L,2447L,2337L,2221L,2099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258080Inst : IEnumerable<long>
{
public static readonly long[] Value=A258080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258080.Bytes);
public long this[int i]=>Value[i];

public static A258080Inst Instance=new A258080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258081
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,10L,12L,10L,21L,25L,70L,670L,239L,2115L,586L,1619L,26800L,2505L,99019L,40903L,285641L,67166L,1852765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258081Inst : IEnumerable<long>
{
public static readonly long[] Value=A258081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258081.Bytes);
public long this[int i]=>Value[i];

public static A258081Inst Instance=new A258081Inst();

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